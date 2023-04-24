using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ReporteVentasContado
    {
        public string IDVenta { get; set; }
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Año { get; set; }
        public double Subtotal { get; set; }
        public double Total { get; set; }
        public string NoSerie { get; set; }
        public string IDCliente { get; set; }
        public string NombreCli { get; set; }
        public string ApellidoPaternoCli { get; set; }
        public string ApellidoMaternoCli { get; set; }
        //public string IDEmpleado { get; set; }
        public string NombreEmp { get; set; }
        public string ApellidoPaternoEmp { get; set; }
        public string ApellidoMaternoEmp { get; set; }
    }
}
