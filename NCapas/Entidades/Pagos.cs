using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pagos
    {
        public int cuota { get; set; }
        public string ciclo { get; set; }
        public DateTime fecha { get; set; }
        public decimal monto { get; set; }
    }
}
