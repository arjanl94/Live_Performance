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
    //Dit form wordt alleen gebruikt om de bestelpagina te vernieuwen zodat een nieuw bestelling makkelijk geplaatst kan worden.
    public partial class Refresh : Form
    {
        public Refresh()
        {
            InitializeComponent();
        }

        private void Refresh_Load(object sender, EventArgs e)
        {
            Bestelpagina pagina = new Bestelpagina();
            pagina.ShowDialog();
            this.Close();
        }
    }
}
