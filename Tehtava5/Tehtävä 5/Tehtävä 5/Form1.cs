using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehtävä_5
{
    public partial class Lukujenjarjestys : Form
    {

        public Lukujenjarjestys()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UusilukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (UusilukuTB.Text == "-999")
                {
                    VastausLB.Text = "";
                    int[]
                        jonot = jono.ToArray();
                    Array.Sort(jonot);
                    foreach
                        (var item in jonot)
                    {
                        VastausLB.Text += item + " ";
                    }
                    VastausLB.Visible = true;
                }
                else
                {
                    jono.Add(Int32.Parse(UusilukuTB.Text));
                    UusilukuTB.Text = "";
                }
                if
                  (e.KeyChar == (char)Keys.Escape)
                {
                    TyhjaaLomake();
                }
                void
            TyhjaaLomake()
                {
                    UusilukuTB.Text = "";
                }
            }

                
            
        }
    }
}
