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
    public partial class Hoofdpagina : Form
    {
        public Hoofdpagina()
        {
            InitializeComponent();
        }

        private void btnvoorraad_Click(object sender, EventArgs e)
        {
            Voorraadsysteem Voorraadsysteem = new Voorraadsysteem();
            this.Hide();
            Voorraadsysteem.ShowDialog();
            this.Close();
        }

        private void btnbestelpagina_Click(object sender, EventArgs e)
        {
            Bestelpagina bestelpagina = new Bestelpagina();
            this.Hide();
            bestelpagina.ShowDialog();
            this.Close();
        }

        private void btnbeheer_Click(object sender, EventArgs e)
        {
            Beheer beheer = new Beheer();
            this.Hide();
            beheer.ShowDialog();
            this.Close();
        }
    }
}
