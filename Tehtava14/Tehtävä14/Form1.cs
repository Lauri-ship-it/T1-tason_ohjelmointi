using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tehtävä14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = System.IO.File.ReadAllText(@"C:\\Users\\Lauri.Savopirtti\\source\\repos\\Tehtävä14\\demo.txt");
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter txt = new StreamWriter("C:\\Users\\Lauri.Savopirtti\\source\\repos\\Tehtävä14\\demo.txt");
            txt.Write(teksti);
            txt.Close();
            Application.Exit();
        }
    }
}
