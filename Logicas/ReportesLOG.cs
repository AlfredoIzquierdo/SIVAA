using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logicas
{
    
    public class ReportesLOG
    {
        private ReportesD pqtReport = new ReportesD();
        private ModeloD pqtMod = new ModeloD();
        private ModeloVersionD pqtModVer = new ModeloVersionD();
        public string gananciasCliente (string idcliente)
        {
            string ganancias;
            return ganancias = pqtReport.GananciasDeUnCliente(idcliente);
        }
        public string gananciasEmpleado(string idcliente)
        {
            string ganancias;
            return ganancias = pqtReport.GananciasDeUnEmpleado(idcliente);
        }
        public string gananciasVersion(string idversion)
        {
            string ganancias;
            return ganancias = pqtReport.GananciasDeUnaVersion(idversion);
        }
        public List<ReportesEntidad> listadoClienteContado(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF,string Opcion)
        {

            List<ReportesEntidad> datos = new List<ReportesEntidad>();
            if (Opcion=="Dia")
            {
                
                return datos = pqtReport.ListadoClienteFrecuenteContadoDia(DiaI, MesI, AnoI, DiaF, MesF, AnoF);
            }
            if (Opcion == "Mes")
            {
               
                return datos = pqtReport.ListadoClienteFrecuenteContadoMes(DiaI, MesI, AnoI, DiaF, MesF, AnoF);
            }
            if (Opcion == "Año")
            {
                return datos = pqtReport.ListadoClienteFrecuenteContadoAno(DiaI, MesI, AnoI, DiaF, MesF, AnoF);
            }
            return datos;
        }
        public List<ReportesEntidad> listadoClienteCredito(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF,string Opcion)
        {
            List<ReportesEntidad> datos = new List<ReportesEntidad>();
            if (Opcion == "Dia")
            {

                return datos = pqtReport.ListadoClienteFrecuenteCreditoDia(DiaI, MesI, AnoI, DiaF, MesF, AnoF);
            }
            if (Opcion == "Mes")
            {

                return datos = pqtReport.ListadoClienteFrecuenteCreditoMes(DiaI, MesI, AnoI, DiaF, MesF, AnoF);
            }
            if (Opcion == "Año")
            {
                return datos = pqtReport.ListadoClienteFrecuenteCreditoAno(DiaI, MesI, AnoI, DiaF, MesF, AnoF);
            }
            return datos;
        }

        public List<ReporteVehiculoMasVendido> listadoVehiculoMasVendidoCredito(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF, string Opcion)
        {
            List<ReporteVehiculoMasVendido> datos = new List<ReporteVehiculoMasVendido>();
            if (Opcion == "Dia")
            {

                return datos = pqtReport.ListadoVehiculoMasVendidoCreditoDia(DiaI, MesI, AnoI, DiaF, MesF, AnoF);
            }
            if (Opcion == "Mes")
            {

                return datos = pqtReport.ListadoVehiculoMasVendidoCreditoMes(DiaI, MesI, AnoI, DiaF, MesF, AnoF);
            }
            if (Opcion == "Año")
            {
                return datos = pqtReport.ListadoVehiculoMasVendidoCreditoAno(DiaI, MesI, AnoI, DiaF, MesF, AnoF);
            }
            return datos;
        }
        public List<ReporteVehiculoMasVendido> listadoVehiculoMasVendidoContado(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF, string Opcion)
        {
            List<ReporteVehiculoMasVendido> datos = new List<ReporteVehiculoMasVendido>();
            if (Opcion == "Dia")
            {

                return datos = pqtReport.ListadoVehiculoMasVendidoContadoDia(DiaI, MesI, AnoI, DiaF, MesF, AnoF);
            }
            if (Opcion == "Mes")
            {

                return datos = pqtReport.ListadoVehiculoMasVendidoContadoMes(DiaI, MesI, AnoI, DiaF, MesF, AnoF);
            }
            if (Opcion == "Año")
            {
                return datos = pqtReport.ListadoVehiculoMasVendidoCreditoAno(DiaI, MesI, AnoI, DiaF, MesF, AnoF);
            }
            return datos;
        }
        public List<ReporteEmpleadoVenta> listadoEmpleadoVentasContado(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF, string Opcion)
        {
            List<ReporteEmpleadoVenta> datos = new List<ReporteEmpleadoVenta>();
            if (Opcion == "Dia")
            {

                return datos = pqtReport.ListadoEmpleadoVentaContadoAno(DiaI, MesI, AnoI, DiaF, MesF, AnoF);
            }
            if (Opcion == "Mes")
            {

                return datos = pqtReport.ListadoEmpleadoVentaContadoMes(DiaI, MesI, AnoI, DiaF, MesF, AnoF);
            }
            if (Opcion == "Año")
            {
                return datos = pqtReport.ListadoEmpleadoVentaContadoAno(DiaI, MesI, AnoI, DiaF, MesF, AnoF);
            }
            return datos;
        }
        public List<ReporteEmpleadoVenta> listadoEmpleadoVentasCredito(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF, string Opcion)
        {
            List<ReporteEmpleadoVenta> datos = new List<ReporteEmpleadoVenta>();
            if (Opcion == "Dia")
            {

                return datos = pqtReport.ListadoEmpleadoVentaCreditoAno(DiaI, MesI, AnoI, DiaF, MesF, AnoF);
            }
            if (Opcion == "Mes")
            {

                return datos = pqtReport.ListadoEmpleadoVentaCreditoMes(DiaI, MesI, AnoI, DiaF, MesF, AnoF);
            }
            if (Opcion == "Año")
            {
                return datos = pqtReport.ListadoEmpleadoVentaCreditoAno(DiaI, MesI, AnoI, DiaF, MesF, AnoF);
            }
            return datos;
        }

        public ModeloVersion ObtenerModeloVersion(string idversion)
        {
            ModeloVersion datos = pqtModVer.ObtenerPdto(idversion);
            return datos;
        }
        public Modelo datosmodelo(string idmodelo)
        {
            Modelo datosmodelo;

            datosmodelo = pqtMod.ObtenerPdto(idmodelo);
            return datosmodelo;
        }
        public List<Venta> ListadoVentas(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF, string Opcion)
        {
            List<Venta> datos = new List<Venta> ();
            if (Opcion == "Dia")
            {

                return datos = pqtReport.ListadoVentasPorDia(DiaI, MesI, AnoI, DiaF, MesF, AnoF);
            }
            if (Opcion == "Mes")
            {

                return datos = pqtReport.ListadoVentasPorMes(DiaI, MesI, AnoI, DiaF, MesF, AnoF);
            }
            if (Opcion == "Año")
            {
                return datos = pqtReport.ListadoVentasPorAno(DiaI, MesI, AnoI, DiaF, MesF, AnoF);
            }
            return datos;
        }

    }
}
