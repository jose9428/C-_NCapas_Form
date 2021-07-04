using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class EspecialidadDAO
    {
        Database db = new Database();

        public List<Especialidad> ListarTodos()
        {
            List<Especialidad> lista = new List<Especialidad>();
            try
            {
                string sql = "select Idesp , Nomesp , costo from especialidad";

                SqlConnection conn = db.ConectarDb();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Especialidad e = new Especialidad();
                    e.id_esp = (string)reader["Idesp"];
                    e.nom_esp = (string)reader["Nomesp"];
                    e.costo = (decimal)reader["costo"];

                    lista.Add(e);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                db.DesconectaDb();
            }

            return lista;
        }
    }
}
