using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehtava3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            float luku1, luku2, vastaus;
            string merkki;
            luku1 = float.Parse(lukuyksiTB.Text);
            luku2 = float.Parse(lukukaksiTB.Text);
            merkki = laskutoimitusCB.Text;
            switch(merkki)
            {
                case "+":
                    vastaus = luku1 + luku2;
                    break;
                case "-":
                    vastaus = luku1 - luku2;
                    break;
                case "*":
                    vastaus = luku1 * luku2;
                    break;
                case "/":
                    vastaus = luku1 / luku2;
                    break;
                default:
                    vastaus = 0;
                    break;
            }
            vastausLB.Text = Convert.ToString(vastaus);
            vastausLB.Visible = true;
        }
    }
}
