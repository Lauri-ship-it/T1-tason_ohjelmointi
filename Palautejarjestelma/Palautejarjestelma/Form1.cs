using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Palautejarjestelma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginBT_Click(object sender, EventArgs e) // KIRJAUTUMINEN
        {
            yhdista conn = new yhdista();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM `kirjautumistunnukset` WHERE `emaili`=@em AND `salasana`=@ss";

            command.CommandText = query;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@em", MySqlDbType.VarChar).Value = emailTB.Text;
            command.Parameters.Add("@ss", MySqlDbType.VarChar).Value = passwordTB.Text;

            adapter.SelectCommand = command;
     
            
            // toimivalle kirjautumiselle
            if (table.Rows.Count > 0)
            {
                // näytä sivu 2
                this.Hide();
                toinensivu mform = new toinensivu();
                mform.Show();
            }
            else
            {
                if (emailTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Lisää E-mail kirjautuaksesi.", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (passwordTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Lisää salasana kirjautuaksesi.", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Joko olematon E-mail, salasana tai molemmat.", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void registerBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            kirjautumissivu mform = new kirjautumissivu();
            mform.Show();
        }
    }
}
