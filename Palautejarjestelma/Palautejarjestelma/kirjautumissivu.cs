using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palautejarjestelma
{
    public partial class kirjautumissivu : Form
    {
        public kirjautumissivu()
        {
            InitializeComponent();
        }

        private void backtokirjBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mform = new Form1();
            mform.Show();
        }

        private void lisaaopBT_Click(object sender, EventArgs e)
        {
            if (em1TB != em2TB)
            {
                MessageBox.Show("E-mailit eivät ole sama.");
            }
            if (ss1TB != ss2TB)
            {
                MessageBox.Show("Salasanat eivät ole sama.");
            }
            if (kouluCB.Text.Trim().Equals(""))
            {
                MessageBox.Show("Valitse koulu.");
            }
            if (em1TB.Text.Trim().Equals("") || em2TB.Text.Trim().Equals(""))
            {
                MessageBox.Show("E-mailit ovat tyhjiä.");
            }
            if (ss1TB.Text.Trim().Equals("") || ss2TB.Text.Trim().Equals(""))
            {
                MessageBox.Show("Salasanat ovat tyhjiä.");
            }
            else
            {
                // En muista/tiedä miten saan oppilaan tallennettua tietokantaan.
            }
        }
    }
}
