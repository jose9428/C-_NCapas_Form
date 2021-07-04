using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NEspecialidad
    {
        EspecialidadDAO espDao;

        public NEspecialidad()
        {
            espDao = new EspecialidadDAO();
        }

        public List<Especialidad> ListarTodos()
        {
            return espDao.ListarTodos();
        }
    }

}
