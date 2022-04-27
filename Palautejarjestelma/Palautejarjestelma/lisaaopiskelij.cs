using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Palautejarjestelma
{
    public class lisaaopiskelij
    {
        yhdista yhteys = new yhdista();

        public bool lisaaOpiskelija(string emaili, string salasana)
        {
            MySqlCommand komento = new MySqlCommand();
            string lisayskysely = "INSERT INTO kirjautumistunnukset " +
                "(emaili, salasana) " +
                "VALUES (@em, @ss); ";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.getConnection();
            komento.Parameters.Add("@em", MySqlDbType.VarChar).Value = emaili;
            komento.Parameters.Add("@ss", MySqlDbType.VarChar).Value = salasana;

            yhteys.openConnection();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.closeConnection();
                return true;
            }
            else
            {
                yhteys.closeConnection();
                return false;
            }
        }
    }
}
