using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehtava4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            DateTime synttari = syntymaaikaDT.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt - synttari).TotalDays);
            vuosiLB.Text = Math.Ceiling(erotus / 365.25) + " vuotta";
            kuukausiLB.Text = Math.Ceiling(erotus * 12 / 365.25) + " kuukautta";
            paivaLB.Text = erotus + " päivää";
            tuntiLB.Text = (erotus * 24) + " tuntia";
            minuuttiLB.Text = (erotus * 24 * 60) + " minuuttia";
            sekunttiLB.Text = (erotus * 24 * 60 * 60) + " sekuntteina";
            vuosiLB.Visible = true;
            kuukausiLB.Visible = true;
            paivaLB.Visible = true;
            tuntiLB.Visible = true;
            minuuttiLB.Visible = true;
            sekunttiLB.Visible = true;
        }
    }
}
