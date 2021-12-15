using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehtava5toimiva
{
    public partial class lukujenjarjestysFORM : Form
    {
        List<int> jono = new List<int>();
        public lukujenjarjestysFORM()
        {
            InitializeComponent();
        }

        private void uusilukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (uusilukuTB.Text == "-999")
                {
                    vastausLB.Text = "";
                    int[] taulukko = jono.ToArray();
                    Array.Sort(taulukko);
                    foreach (var jasen in taulukko)
                    {
                        vastausLB.Text += jasen + " ";
                    }
                    vastausLB.Visible = true;
                }
                else
                {
                    jono.Add(Int32.Parse(uusilukuTB.Text));
                    uusilukuTB.Text = "";
                }
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                TyhjaaLomake();
            }
        }
        private void TyhjaaLomake()
        {
                uusilukuTB.Text = "";
        }
    }
}
