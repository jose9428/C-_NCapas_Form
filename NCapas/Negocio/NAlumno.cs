using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NAlumno
    {
        AlumnoDAO aluDao;
        public NAlumno()
        {
            aluDao = new AlumnoDAO();
        }

        public List<Alumno> ListarPorEspecialidad(string idEsp)
        {
            return aluDao.ListarPorEspecialidad(idEsp);
        }

        public int AgregarAlumno(Alumno a)
        {
            return aluDao.Agregar(a);
        }

        public Alumno BuscarPorId(string idAlu)
        {
            return aluDao.BuscarPorId(idAlu);
        }

        public int ModificarAlumno(Alumno a)
        {
            return aluDao.Modificar(a);
        }
        public int EliminarAlumno(string idAlu)
        {
            return aluDao.Eliminar(idAlu);
        }
    }
}
