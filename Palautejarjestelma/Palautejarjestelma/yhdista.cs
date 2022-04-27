using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Palautejarjestelma
{
    class yhdista // yhdistetään sql:ään.
    {
        private MySqlConnection connection = new MySqlConnection("datasource=localhost;port=8012;username=root;password=;database=palautteet");
        public MySqlConnection getConnection()
        {
            return connection;
        }

        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }
    }
}
