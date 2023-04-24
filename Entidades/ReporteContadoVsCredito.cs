using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ReporteContadoVsCredito
    {
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Año { get; set; }
        public int TotalVentas { get; set; }
        public string TipoVenta { get; set; }
        public double Total { get; set; }
    }
}
