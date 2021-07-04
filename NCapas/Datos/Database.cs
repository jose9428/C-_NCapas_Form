using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Database
    {
        private SqlConnection conn;

        public SqlConnection ConectarDb()
        {
            try
            {
                string cadenaConn = "Data Source = localhost;Initial Catalog=bdnotas;Integrated Security=True";
                conn = new SqlConnection(cadenaConn);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void DesconectaDb()
        {
            conn.Close();
        }

    }
}
