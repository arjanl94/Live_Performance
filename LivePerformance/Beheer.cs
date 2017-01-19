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
    public partial class Beheer : Form
    {
        GebruikerRepository gebruikerRepository = new GebruikerRepository(new MssqlGebruikerLogic());
        public Beheer()
        {
            InitializeComponent();
            lbklanten.DataSource = gebruikerRepository.ListKlanten();
        }

        private void btnterug_Click(object sender, EventArgs e)
        {
            Hoofdpagina pagina = new Hoofdpagina();
            this.Hide();
            pagina.ShowDialog();
            this.Close();
        }
    }
}
