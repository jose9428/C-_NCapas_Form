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
    public class AlumnoDAO
    {
        Database db = new Database();

        public List<Alumno> ListarPorEspecialidad(string idEsp)
        {
            List<Alumno> lista = new List<Alumno>();
            try
            {
                string sql = string.Format("select IdAlumno , NomAlumno , ApeAlumno , proce , Idesp from Alumno where Idesp = '{0}'", idEsp);

                SqlConnection conn = db.ConectarDb();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Alumno e = new Alumno();
                    e.id_alumno = (string)reader["IdAlumno"];
                    e.nombre = (string)reader["NomAlumno"];
                    e.apellido = (string)reader["ApeAlumno"];
                    e.procedencia = (string)reader["proce"];
                    e.id_esp = (string)reader["Idesp"];
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

        public int Agregar(Alumno a)
        {
            int res = 0;
            try
            {
                SqlConnection con = db.ConectarDb();
                SqlCommand cmd = new SqlCommand("spadiAlu", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ape", a.apellido);
                cmd.Parameters.AddWithValue("@nom", a.nombre);
                cmd.Parameters.AddWithValue("@es", a.id_esp);
                cmd.Parameters.AddWithValue("@pro", a.procedencia);
                res = cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                db.DesconectaDb();
            }

            return res;
        }

        public Alumno BuscarPorId(string idAlu)
        {
            Alumno e = null;
            try
            {
                string sql = string.Format("select IdAlumno , NomAlumno , ApeAlumno , proce , Idesp from Alumno where IdAlumno = '{0}'", idAlu);

                SqlConnection conn = db.ConectarDb();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    e = new Alumno();
                    e.id_alumno = (string)reader["IdAlumno"];
                    e.nombre = (string)reader["NomAlumno"];
                    e.apellido = (string)reader["ApeAlumno"];
                    e.procedencia = (string)reader["proce"];
                    e.id_esp = (string)reader["Idesp"];
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

            return e;
        }

        public int Modificar(Alumno a)
        {
            int res = 0;
            try
            {
                string sql = string.Format("update alumno set apeAlumno ='{0}' , nomAlumno = '{1}' , idesp = '{2}', proce = '{3}' where idalumno = '{4}'" , a.apellido , a.nombre, a.id_esp , a.procedencia , a.id_alumno);
                SqlConnection con = db.ConectarDb();
                SqlCommand cmd = new SqlCommand(sql, con);
                res = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                db.DesconectaDb();
            }

            return res;
        }

        public int Eliminar(string idAlu)
        {
            int res = 0;
            try
            {
                string sql = string.Format("delete from alumno  where idalumno = '{0}'", idAlu);
                SqlConnection con = db.ConectarDb();
                SqlCommand cmd = new SqlCommand(sql, con);
                res = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                db.DesconectaDb();
            }

            return res;
        }
    }
}
