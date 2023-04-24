using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ReporteInventario
    {
        public string IDVehiculo { get; set; }
        public string Vehiculo { get; set; }
        public string IDVersion { get; set; }
        public string Version { get; set; }
        public string IDModelo { get; set; }
        public string Modelo { get; set; }
        public int NumeroUnidades { get; set; }
    }
}
