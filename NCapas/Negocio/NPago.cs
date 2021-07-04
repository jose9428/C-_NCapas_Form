using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NPago
    {
        PagosDAO pagDao;

        public NPago()
        {
            pagDao = new PagosDAO();
        }

        public List<Pagos> ListarPagoPorAlumno(string idAlu)
        {
            return pagDao.ListarPagoPorAlumno(idAlu);
        }
    }
}
