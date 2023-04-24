using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ReporteVentasCredito
    {
        public string IDVenta { get; set; }
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Año { get; set; }
        public double Subtotal { get; set; }
        public string NoSerie { get; set; }
        public string IDCliente { get; set; }
        public string NombreCli { get; set; }
        public string ApellidoPaternoCli { get; set; }
        public string ApellidoMaternoCli { get; set; }
        public string NombreEmp { get; set; }
        public string ApellidoPaternoEmp { get; set; }
        public string ApellidoMaternoEmp { get; set; }
        //credito
        public int Plazo { get; set; }
        public double Enganche { get; set; }
        public double Mensualidad { get; set; }
        public double Anualidad { get; set; }
        public int Intereses { get; set; }
        public double TotalFinal { get; set; }
    }
}
