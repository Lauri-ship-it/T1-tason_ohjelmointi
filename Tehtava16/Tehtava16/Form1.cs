using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Tehtava16
{
    public partial class LaskuriFORM : Form
    {
        public LaskuriFORM()
        {
            InitializeComponent();
        }
        private int kokonaisaika;
        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            if(kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekunnit = kokonaisaika - (minuutit * 60);
                AjastinLB.Text = minuutit.ToString() + ":" + sekunnit.ToString();
            }
            else
            {
                AjastinTM.Stop();
                MessageBox.Show("Aikasi loppui!");
            }
        }

        private void AloitaBT_Click(object sender, EventArgs e)
        {
            AloitaBT.Enabled = false;
            LopetaBT.Enabled = true;
            int minuutit = int.Parse(MinuutitCB.SelectedItem.ToString());
            int sekunnit = int.Parse(SekunnitCB.SelectedItem.ToString());
            kokonaisaika = (minuutit * 60) + sekunnit;
            AjastinTM.Enabled = true;

        }

        private void LopetaBT_Click(object sender, EventArgs e)
        {
            AloitaBT.Enabled = true;
            LopetaBT.Enabled = false;
            kokonaisaika = 0;
            AjastinTM.Enabled = false;
            AjastinLB.Text = "00:00";
        }

        private void LaskuriFORM_Load(object sender, EventArgs e)
        {
            LopetaBT.Enabled = false;
            for(int i=0; i < 60; i++)
            {
                MinuutitCB.Items.Add(i.ToString());
                SekunnitCB.Items.Add(i.ToString());
            }
            MinuutitCB.SelectedIndex = 30;
            SekunnitCB.SelectedIndex = 0;

        }
    }
}
