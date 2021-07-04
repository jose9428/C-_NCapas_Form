using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class PagosDAO
    {
        Database db = new Database();

        public List<Pagos> ListarPagoPorAlumno(string idAlu)
        {
            List<Pagos> lista = new List<Pagos>();
            try
            {
                SqlConnection conn = db.ConectarDb();
                SqlCommand cmd = new SqlCommand("sp_listarPagos", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idAlu", idAlu);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Pagos p = new Pagos();
                    p.ciclo = (string)reader["ciclo"];
                    p.cuota = (int)reader["nCuota"];
                    p.fecha = (DateTime)reader["fecha"];
                    p.monto = (decimal)reader["monto"];

                    lista.Add(p);
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
