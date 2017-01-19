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
    public partial class Voorraadsysteem : Form
    {
        private ProductRepository productRepository = new ProductRepository(new MssqlProductLogic());
        private int count;

        public Voorraadsysteem()
        {
            InitializeComponent();
            lbvoorraad.DataSource = productRepository.ListArtikelen();
            btnshowproduct.Visible = false;
            count = 1;
        }

        public void RefreshListVoorraad()
        {
            lbvoorraad.DataSource = null;
            lbvoorraad.DataSource = productRepository.ListArtikelen();
            count = 1;
        }

        public void RefreshListingredienten()
        {
            lbvoorraad.DataSource = null;
            lbvoorraad.DataSource = productRepository.ListIngrediënten();
            count = 2;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            btneditproduct.Visible = false;
            gbaddproduct.Visible = true;
            btnaddproduct.Visible = true;
            if (count == 2)
            {
                gbaddproduct.Text = "Add ingrediënt";
                lbbtw.Visible = false;
                tbbtw.Visible = false;
            }
            else if (count == 1)
            {
                gbaddproduct.Text = "Add product";
            }
        }

        private void btnaddproduct_Click(object sender, EventArgs e)
        {
            string naam = tbnaam.Text;
            decimal inkoopprijs = Convert.ToDecimal(tbinkoop.Text);
            decimal verkoopprijs = Convert.ToDecimal(tbverkoop.Text);
            if (count == 1)
            {

                int btw = Convert.ToInt32(tbbtw.Text);
                try
                {

                    productRepository.AddArtikel(new Artikel(naam, inkoopprijs, verkoopprijs, btw));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Artikel kan niet toegevoegd worden. Verkoopprijs moet hoger zijn dan inkoopprijs");
                }
                RefreshListVoorraad();
            }
            else if (count == 2)
            {
                try
                {
                    productRepository.AddIngrediënt(new Ingrediënt(naam, inkoopprijs, verkoopprijs));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Ingrediënt kan niet toegevoegd worden. Verkoopprijs moet hoger zijn dan inkoopprijs");
                }
                RefreshListingredienten();
            }
            gbaddproduct.Visible = false;
            btnaddproduct.Visible = false;

        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                Artikel artikel = (Artikel) lbvoorraad.SelectedItem;
                productRepository.RemoveArtikel(artikel);
                RefreshListVoorraad();
            }
            else if (count == 2)
            {
                Ingrediënt ingrediënt = (Ingrediënt) lbvoorraad.SelectedItem;
                productRepository.RemoveIngrediënt(ingrediënt);
                RefreshListingredienten();
            }
        }

        private void btnshowingredienten_Click(object sender, EventArgs e)
        {
            btnshowproduct.Visible = true;
            btnshowingredienten.Visible = false;
            btnsortproduct.Visible = false;
            RefreshListingredienten();
        }

        private void btnshowproduct_Click(object sender, EventArgs e)
        {
            btnshowingredienten.Visible = true;
            btnshowproduct.Visible = false;
            btnsortproduct.Visible = true;
            RefreshListVoorraad();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            btneditproduct.Visible = true;
            gbaddproduct.Visible = true;
            btnaddproduct.Visible = false;

            if (count == 1)
            {
                gbaddproduct.Text = "Edit product";
                Artikel artikel = (Artikel) lbvoorraad.SelectedItem;
                tbnaam.Text = artikel.Naam;
                tbinkoop.Text = artikel.Inkoopprijs.ToString();
                tbverkoop.Text = artikel.Verkoopprijs.ToString();
                tbbtw.Text = artikel.BtwPercentage.ToString();
            }
            else if (count == 2)
            {

                gbaddproduct.Text = "Edit ingrediënt";
                lbbtw.Visible = false;
                tbbtw.Visible = false;
                Ingrediënt ingrediënt = (Ingrediënt) lbvoorraad.SelectedItem;
                tbnaam.Text = ingrediënt.Naam;
                tbinkoop.Text = ingrediënt.Inkoopprijs.ToString();
                tbverkoop.Text = ingrediënt.Verkoopprijs.ToString();
            }

        }

        private void btneditproduct_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                string naam = tbnaam.Text;
                decimal inkoopprijs = Convert.ToDecimal(tbinkoop.Text);
                decimal verkoopprijs = Convert.ToDecimal(tbverkoop.Text);
                if (count == 1)
                {

                    int btw = Convert.ToInt32(tbbtw.Text);
                    try
                    {
                        productRepository.EditArtikel(new Artikel(naam, inkoopprijs, verkoopprijs, btw));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(
                            "Artikel kan niet worden gewijzigd. Verkoopprijs moet hoger zijn dan inkoopprijs");
                    }
                    RefreshListVoorraad();
                }
                else if (count == 2)
                {
                    try
                    {
                        productRepository.EditIngrediënt(new Ingrediënt(naam, inkoopprijs, verkoopprijs));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(
                            "Ingrediënt kan niet worden gewijzigd. Verkoopprijs moet hoger zijn dan inkoopprijs");
                    }
                    RefreshListingredienten();
                }
                gbaddproduct.Visible = false;
            }
        }

        private void btnhoofdpagina_Click(object sender, EventArgs e)
        {
            Hoofdpagina pagina = new Hoofdpagina();
            this.Hide();
            pagina.ShowDialog();
            this.Close();
        }

        private void btnsortproduct_Click(object sender, EventArgs e)
        {
            List<Artikel> artikelen = productRepository.ListArtikelen();
            artikelen.Sort();
            lbvoorraad.DataSource = null;
            lbvoorraad.DataSource = artikelen;
        }
    }
}
