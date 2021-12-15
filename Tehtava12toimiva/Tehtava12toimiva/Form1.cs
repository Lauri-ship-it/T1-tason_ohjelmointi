using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehtava12toimiva
{
    public partial class vastauslomakeFORM : Form
    {
        int laskuri = 0;
        int oikein = 0;
        string[] oikeatVastaukset = new string[] {"B", "D", "A", "A", "C", "A", "B", "A", "C", "D",};
        string[] vastaukset = new string[10];
        public vastauslomakeFORM()
        {
            InitializeComponent();
            VastausARB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            vastausBRB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            vastausCRB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            vastausDRB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
        }

        private void vastauslomakeFORM_Load(object sender, EventArgs e)
        {

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton && laskuri < 10)
            {
                RadioButton radioButton = (RadioButton)sender;
                vastaukset[laskuri] = radioButton.Text;
                laskuri++;
                kysymysLB.Text = "Vastaus " + (laskuri) + ". kysymykseen:";

            }
            else
            {
                vastausLB.Text = "";
                VastausARB.Enabled = false;
                vastausBRB.Enabled = false;
                vastausCRB.Enabled = false;
                vastausDRB.Enabled = false;
                for(int j = 0; j < 10; j++)
                {
                    if (vastaukset[j] == oikeatVastaukset[j])
                    {
                        oikein++;
                    }
                }
                vastausLB.Text = "Oikeaita vastauksia oli: " + oikein;
                vastausLB.Visible = true;
            }
            TyhjaaVastaus();
        }
        private void TyhjaaVastaus()
        {
            if (VastausARB.Checked == true)
            {
                VastausARB.Checked = false;
                laskuri--;
            }
            if (vastausBRB.Checked == true)
            {
                vastausBRB.Checked = false;
                laskuri--;
            }
            if (vastausCRB.Checked == true)
            {
                vastausCRB.Checked = false;
                laskuri--;
            }
            if (vastausDRB.Checked == true)
            {
                vastausDRB.Checked = false;
                laskuri--;
            }
        }
    }
}
