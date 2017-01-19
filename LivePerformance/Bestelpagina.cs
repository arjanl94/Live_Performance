using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivePerformance
{
    public partial class Bestelpagina : Form
    {
        private Random randomizer = new Random();
        private int addend1;
        private int addend2;
        private int Timeleft;
        private ProductRepository productRepository = new ProductRepository(new MssqlProductLogic());
        private GebruikerRepository gebruikerRepository = new GebruikerRepository(new MssqlGebruikerLogic());
        private BestelRepository bestelRepository = new BestelRepository(new MssqlBestelLogic());
        public Product product;
        public Bestelling bestelling;
        public int count = 0;

        public Bestelpagina()
        {
            InitializeComponent();
            lbpizzas.DataSource = productRepository.ListPizzas();
            lbproducten.DataSource = productRepository.ListArtikelen();
            product = new Product();
        }

        public void Refreshbestelling()
        {
            lbbestelling.DataSource = null;
            List<string> bestelling = new List<string>();
            decimal totaalprijs = 0;
            foreach (var item in product.Artikelen)
            {
                bestelling.Add(item.Bestelling);
                totaalprijs += item.Verkoopprijs;
            }
            foreach (var item in product.Pizzas)
            {
                bestelling.Add(item.Bestelling);
                totaalprijs += item.Verkoopprijs;
            }
            lbbestelling.DataSource = bestelling;
            lbprijs.Text = totaalprijs.ToString("#.##");
        }

        private void btnaddproduct_Click(object sender, EventArgs e)
        {
            Artikel artikel = (Artikel) lbproducten.SelectedItem;
            product.AddArtikel(artikel);
            Refreshbestelling();
        }

        private void btnaddpizza_Click(object sender, EventArgs e)
        {
            Pizza pizza = (Pizza) lbpizzas.SelectedItem;
            string bodem = "Deeg voor dunne bodem";
            pizza.AddBodem(bodem);
            product.AddPizza(pizza);
            Refreshbestelling();
        }

        private void btnbestel_Click(object sender, EventArgs e)
        {
            btnklantnew.Visible = true;
            btnbestelling.Visible = true;
        }

        private void btnklantnew_Click(object sender, EventArgs e)
        {
            gbklant.Visible = true;
            count = 1;
        }

        private void btnbestelling_Click(object sender, EventArgs e)
        {
            int duur = 0;
            if (count == 1)
            {
                Klant klant = new Klant(tbnaam.Text, tbadres.Text);
                gebruikerRepository.AddKlant(klant);
                Klant klantid = gebruikerRepository.KlantByNaam(klant.Naam);
                bestelling = new Bestelling(klant, product);
                
                foreach (var item in product.Artikelen)
                {
                    bestelRepository.AddBestelling(klantid.Gebruikernr, 0, item.Naam);
                }
                foreach (var item in product.Pizzas)
                {
                    bestelRepository.AddBestelling(klantid.Gebruikernr, item.Pizzanr, "null");
                    duur += 10;
                }
            }
            else if (count == 0)
            {
                bestelling = new Bestelling(product);
                foreach (var item in product.Artikelen)
                {
                    bestelRepository.AddBestelling(18, 0, item.Naam);
                }
                foreach (var item in product.Pizzas)
                {
                    bestelRepository.AddBestelling(18, item.Pizzanr, "null");
                    duur += 10;
                }
                bestelling.Bezorging(cbbezorg.Checked);
            }
            btnnieuw.Visible = true;
            lbgeplaatst.Visible = true;
            btnbestelling.Visible = false;
            btnbon.Visible = true;
            Timeleft = 100;
            lbtime.Visible = true;
            btnklantnew.Visible = false;
            gbklant.Visible = false;
            lbtime.Text = "Duur: " + duur + " minuten";
        }

        private void RefreshForm()
        {
            Refresh r = new Refresh();
            this.Hide();
            r.ShowDialog();
            this.Close();
        }

        private void btnnieuw_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hoofdpagina pagina = new Hoofdpagina();
            this.Hide();
            pagina.ShowDialog();
            this.Close();
        }

        private void btnbon_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text file | *.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    bestelling.ExporteerBestelling(save);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Het bestand kon niet opgeslagen worden" + ex.Message);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
