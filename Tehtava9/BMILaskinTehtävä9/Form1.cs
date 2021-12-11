using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMILaskinTehtävä9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0;
            paino = Convert.ToDouble(PainoTB.Text);
            pituus = Convert.ToDouble(PituusTB.Text);
            double bmi = Math.Round(paino / (pituus * pituus), 2);
            if(bmi < 18.5)
            {
                IndeksiLB.Text = "Painoindeksisi on: " + bmi;
                IndeksiLB.ForeColor = Color.Aqua;
                IndeksiLB.Visible = true;
                PainoLB.Text = "Alipaino";
                PainoLB.ForeColor = Color.Aqua;
                PainoLB.Visible = true;
            }
            else if(bmi < 25)
            {
                IndeksiLB.Text = "Painoindeksisi on: " + bmi;
                IndeksiLB.ForeColor = Color.Green;
                IndeksiLB.Visible = true;
                PainoLB.Text = "Normaalipaino";
                PainoLB.ForeColor = Color.Green;
                PainoLB.Visible = true;

            }
            else if(bmi < 40)
            {
                IndeksiLB.Text = "Painoindeksisi on: " + bmi;
                IndeksiLB.ForeColor = Color.Gold;
                IndeksiLB.Visible = true;
                PainoLB.Text = "Ylipaino";
                PainoLB.ForeColor = Color.Gold;
                PainoLB.Visible = true;
            }
            else
            {
                IndeksiLB.Text = "Painoindeksisi on: " + bmi;
                IndeksiLB.ForeColor = Color.Red;
                IndeksiLB.Visible = true;
                PainoLB.Text = "Huomatta ylipaino";
                PainoLB.ForeColor = Color.Red;
                PainoLB.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //hups
        }
    }
}
