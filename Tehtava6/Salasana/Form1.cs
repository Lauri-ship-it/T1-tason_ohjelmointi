using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salasana
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void SalasanaPanel_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void VirheLB_Click(object sender, EventArgs e)
        {
            //how to delete deez?
        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if (KayttajaTB.Text == "Lauri" && SalasanaTB.Text == "Yeetin")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;
            }
            else
            {
                VirheLB.Text = "Käyttäjätunnus tai salasana on väärin.";
                VirheLB.Visible = true;
            }
        }
    }
}
