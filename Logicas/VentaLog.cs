using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicas
{
    public class VentaLog
    {
        private VentaD Pdto = new VentaD();//No poner public
        private ClienteD pdtoclien = new ClienteD();
        private UnidadD pdtounidad = new UnidadD();
        private EmpleadoD pdtoEmpleado = new EmpleadoD();
        public readonly StringBuilder Mensaje = new StringBuilder();

        public void Registrar(Venta Pd)
        {
            Mensaje.Clear();
            if (ValidarProducto(Pd))
            {
                if (Pdto.ObtenerPdto(Pd.IDVenta) == null)
                    //No se encuentra el dato (El código no existe)
                    Pdto.Insertar(Pd);
                else
                    Mensaje.Append("El Codigo de Venta ya se encuentra en la B.D.");
            }
        }

        public List<Venta> ListadoAll()
        {
            //Método que obtiene la lista dinámica de todos los registro que tiene mi tabla
            return Pdto.ListadoTotal();
        }

        public List<VentasEntrega> ListadoAllVentasEntrega()
        {
            //Método que obtiene la lista dinámica de todos los registro que tiene mi tabla
            return Pdto.ListadoTotalVentasEntrega();
        }
        public List<VentasEntrega> ListadoAllVentasEntregaContado()
        {
            //Método que obtiene la lista dinámica de todos los registro que tiene mi tabla
            return Pdto.ListadoTotalVentasEntregaContado();
        }
        public List<VentasEntrega> ListadoAllVentasEntregaCredito()
        {
            //Método que obtiene la lista dinámica de todos los registro que tiene mi tabla
            return Pdto.ListadoTotalVentasEntregaCredito();
        }
        public List<VentasEntrega> ListadoAllVentasEntregaCredito2()
        {
            //Método que obtiene la lista dinámica de todos los registro que tiene mi tabla
            return Pdto.ListadoTotalVentasEntregaCredito2();
        }
        //public List<VentasEntrega> ListadoAllAbonosYAnualidad()
        //{
        //    //Método que obtiene la lista dinámica de todos los registro que tiene mi tabla
        //    return Pdto.ListadoTotalVentasABONOEspecificos();
        //}
        public List<VentasEntrega> ListadoAllVentasABONOCredito()
        {
            //Método que obtiene la lista dinámica de todos los registro que tiene mi tabla
            return Pdto.ListadoTotalVentasporABONAR();
        }
        public List<VentasEntrega> Listaporcliente(string nom, string app)
        {
            List<VentasEntrega> Pd = null;
            Mensaje.Clear();
            if (app == "0")
                Mensaje.Append("Por favor proporcionar un nombre valida");
            if (Mensaje.Length == 0)
            {
                Pd = Pdto.ListadoTotalVentasEntregaPorClientes(nom, app);
                if (Pd == null)
                    Mensaje.Append("nombre o apellido no encontrado en la B.D.");
                return Pd;
            }
            return null;
        }
        public List<VentasEntrega> ListaporclienteENGANCHES(string nom, string app)
        {
            List<VentasEntrega> Pd = null;
            Mensaje.Clear();
            if (app == "0")
                Mensaje.Append("Por favor proporcionar un nombre valida");
            if (Mensaje.Length == 0)
            {
                Pd = Pdto.ListadoTotalVentasEnganchePorClientes(nom, app);
                if (Pd == null)
                    Mensaje.Append("nombre o apellido no encontrado en la B.D.");
                return Pd;
            }
            return null;
        }
        public List<VentasEntrega> ListaporclienteABONOS(string nom, string app)
        {
            List<VentasEntrega> Pd = null;
            Mensaje.Clear();
            if (app == "0")
                Mensaje.Append("Por favor proporcionar un nombre valida");
            if (Mensaje.Length == 0)
            {
                Pd = Pdto.ListadoTotalDEVENTASPORABONOPorClientes(nom, app);
                if (Pd == null)
                    Mensaje.Append("nombre o apellido no encontrado en la B.D.");
                return Pd;
            }
            return null;
        }
        public List<VentasEntrega> Listaporclientedeventasacreditoporabonar(string nom, string app)
        {
            List<VentasEntrega> Pd = null;
            Mensaje.Clear();
            if (app == "0")
                Mensaje.Append("Por favor proporcionar un nombre valida");
            if (Mensaje.Length == 0)
            {
                Pd = Pdto.ListadoTotalVentasABONOEspecificos(nom, app);
                if (Pd == null)
                    Mensaje.Append("cliente no encontrado en la B.D.");
                return Pd;
            }
            return null;
        }
        public List<VentasEntrega> ListaporclienteABONO(string nom, string app)
        {
            List<VentasEntrega> Pd = null;
            Mensaje.Clear();
            if (app == "0")
                Mensaje.Append("Por favor proporcionar un nombre valida");
            if (Mensaje.Length == 0)
            {
                Pd = Pdto.ListadoTotalVentasABONOPorClientes(nom, app);
                if (Pd == null)
                    Mensaje.Append("nombre o apellido no encontrado en la B.D.");
                return Pd;
            }
            return null;
        }
        public List<ReporteVentasContado> ListaVentasContadoPorDia(int dia, int mes, int an)
        {
            List<ReporteVentasContado> Pd = null;
            Mensaje.Clear();
            if (dia == 0 || mes==0 || an==0)
                Mensaje.Append("Por favor proporcionar una fecha valida");
            if (Mensaje.Length == 0)
            {
                Pd = Pdto.VentasPorDiaespecifico(dia,mes,an);
                if (Pd == null)
                    Mensaje.Append("Ventas no encontradas de acuerdo a la fecha");
                return Pd;
            }
            return null;
        }
        //public List<ReporteVentasContado> ListaVentasContadoPorMes(int dia, int mes, int an)
        //{
        //    List<ReporteVentasContado> Pd = null;
        //    Mensaje.Clear();
        //    if (dia == 0 || mes == 0 || an == 0)
        //        Mensaje.Append("Por favor proporcionar una fecha valida");
        //    if (Mensaje.Length == 0)
        //    {
        //        Pd = Pdto.VentasPorDiaespecifico(dia, mes, an);
        //        if (Pd == null)
        //            Mensaje.Append("Ventas no encontradas de acuerdo a la fecha");
        //        return Pd;
        //    }
        //    return null;
        //}
        //public List<ReporteVentasContado> ListaVentasContadoAnual(int dia, int mes, int an)
        //{
        //    List<ReporteVentasContado> Pd = null;
        //    Mensaje.Clear();
        //    if (dia == 0 || mes == 0 || an == 0)
        //        Mensaje.Append("Por favor proporcionar una fecha valida");
        //    if (Mensaje.Length == 0)
        //    {
        //        Pd = Pdto.VentasPorDiaespecifico(dia, mes, an);
        //        if (Pd == null)
        //            Mensaje.Append("Ventas no encontradas de acuerdo a la fecha");
        //        return Pd;
        //    }
        //    return null;
        //}
        public List<ReporteVentasContado> ListaVentasContadoSemanal(int dia,int fin, int mes, int an)
        {
            List<ReporteVentasContado> Pd = null;
            Mensaje.Clear();
            if (dia == 0 || mes == 0 || an == 0 || fin==0)
                Mensaje.Append("Por favor proporcionar una fecha valida");
            if (Mensaje.Length == 0)
            {
                Pd = Pdto.VentasPorSemanaespecifico(dia,fin, mes, an);
                if (Pd == null)
                    Mensaje.Append("Ventas no encontradas de acuerdo a la fecha");
                return Pd;
            }
            return null;
        }
        public List<ReporteVentasContado> ListaVentasContadoMes(int mes, int an)
        {
            List<ReporteVentasContado> Pd = null;
            Mensaje.Clear();
            if (mes == 0 || an == 0)
                Mensaje.Append("Por favor proporcionar una fecha valida");
            if (Mensaje.Length == 0)
            {
                Pd = Pdto.VentasPorMesespecifico(mes, an);
                if (Pd == null)
                    Mensaje.Append("Ventas no encontradas de acuerdo a la fecha");
                return Pd;
            }
            return null;
        }
        public List<ReporteVentasContado> ListaVentasContadoAnual(int an)
        {
            List<ReporteVentasContado> Pd = null;
            Mensaje.Clear();
            if (an == 0)
                Mensaje.Append("Por favor proporcionar una fecha valida");
            if (Mensaje.Length == 0)
            {
                Pd = Pdto.VentasAnualesespecificas(an);
                if (Pd == null)
                    Mensaje.Append("Ventas no encontradas de acuerdo a la fecha");
                return Pd;
            }
            return null;
        }

        public List<ReporteVentasCredito> ListaVentasCreditoPorDia(int dia, int mes, int an)
        {
            List<ReporteVentasCredito> Pd = null;
            Mensaje.Clear();
            if (dia == 0 || mes == 0 || an == 0)
                Mensaje.Append("Por favor proporcionar una fecha valida");
            if (Mensaje.Length == 0)
            {
                Pd = Pdto.ReporteVentasACreditoPorDia(dia, mes, an);
                if (Pd == null)
                    Mensaje.Append("Ventas no encontradas de acuerdo a la fecha");
                return Pd;
            }
            return null;
        }
        public List<ReporteVentasCredito> ListaVentasCreditoSemanal(int dia,int fin ,int mes, int an)
        {
            List<ReporteVentasCredito> Pd = null;
            Mensaje.Clear();
            if (dia == 0 || fin==0 || mes == 0 || an == 0)
                Mensaje.Append("Por favor proporcionar una fecha valida");
            if (Mensaje.Length == 0)
            {
                Pd = Pdto.ReporteVentasACreditoPorSemana(dia,fin, mes, an);
                if (Pd == null)
                    Mensaje.Append("Ventas no encontradas de acuerdo a la fecha");
                return Pd;
            }
            return null;
        }
        public List<ReporteVentasCredito> ListaVentasCreditoPorMes(int mes, int an)
        {
            List<ReporteVentasCredito> Pd = null;
            Mensaje.Clear();
            if (mes == 0 || an == 0)
                Mensaje.Append("Por favor proporcionar una fecha valida");
            if (Mensaje.Length == 0)
            {
                Pd = Pdto.ReporteVentasACreditoPorMes(mes, an);
                if (Pd == null)
                    Mensaje.Append("Ventas no encontradas de acuerdo a la fecha");
                return Pd;
            }
            return null;
        }
        public List<ReporteVentasCredito> ListaVentasCreditoAnual(int an)
        {
            List<ReporteVentasCredito> Pd = null;
            Mensaje.Clear();
            if (an == 0)
                Mensaje.Append("Por favor proporcionar una fecha valida");
            if (Mensaje.Length == 0)
            {
                Pd = Pdto.ReporteVentasACreditoAnual(an);
                if (Pd == null)
                    Mensaje.Append("Ventas no encontradas de acuerdo a la fecha");
                return Pd;
            }
            return null;
        }
        public List<ReporteContadoVsCredito> ListaReporteCreditoVsContadoAnual(int an)
        {
            List<ReporteContadoVsCredito> Pd = null;
            Mensaje.Clear();
            if (an == 0)
                Mensaje.Append("Por favor proporcionar una fecha valida");
            if (Mensaje.Length == 0)
            {
                Pd = Pdto.ReporteContadoVsCreditoAnual(an);
                if (Pd == null)
                    Mensaje.Append("Ventas no encontradas de acuerdo a la fecha");
                return Pd;
            }
            return null;
        }
        public List<ReporteContadoVsCredito> ListaReporteCreditoVsContadoPorSemana(int dia, int fin, int mes, int an)
        {
            List<ReporteContadoVsCredito> Pd = null;
            Mensaje.Clear();
            if (dia == 0||fin == 0||mes == 0||an == 0)
                Mensaje.Append("Por favor proporcionar una fecha valida");
            if (Mensaje.Length == 0)
            {
                Pd = Pdto.ReporteContadoVsCreditoPorSemana(dia,fin,mes,an);
                if (Pd == null)
                    Mensaje.Append("Ventas no encontradas de acuerdo a la fecha");
                return Pd;
            }
            return null;
        }
        public List<ReporteContadoVsCredito> ListaReporteCreditoVsContadoPorMes(int mes, int an)
        {
            List<ReporteContadoVsCredito> Pd = null;
            Mensaje.Clear();
            if (mes == 0 || an == 0)
                Mensaje.Append("Por favor proporcionar una fecha valida");
            if (Mensaje.Length == 0)
            {
                Pd = Pdto.ReporteContadoVsCreditoPorMes(mes, an);
                if (Pd == null)
                    Mensaje.Append("Ventas no encontradas de acuerdo a la fecha");
                return Pd;
            }
            return null;
        }
        public List<ReporteContadoVsCredito> ListaReporteCreditoVsContadoPorDia(int dia,int mes, int an)
        {
            List<ReporteContadoVsCredito> Pd = null;
            Mensaje.Clear();
            if (dia==0||mes == 0 || an == 0)
                Mensaje.Append("Por favor proporcionar una fecha valida");
            if (Mensaje.Length == 0)
            {
                Pd = Pdto.ReporteContadoVsCreditoPorDia(dia,mes, an);
                if (Pd == null)
                    Mensaje.Append("Ventas no encontradas de acuerdo a la fecha");
                return Pd;
            }
            return null;
        }
        public Venta LeerPorClave(string ClPdto)
        {
            Venta Pd = null;
            Mensaje.Clear();
            if (ClPdto == "0")
                Mensaje.Append("Por favor proporcionar una clave valida");
            if (Mensaje.Length == 0)
            {
                Pd = Pdto.ObtenerPdto(ClPdto);
                if (Pd == null)
                    Mensaje.Append("Codigo de Venta no existe en la B.D.");
                return Pd;
            }
            return null;
        }
        //public Venta LeerPorClaveVoucher(string ClPdto)
        //{
        //    Venta Pd = null;
        //    Mensaje.Clear();
        //    if (ClPdto == "0")
        //        Mensaje.Append("Por favor proporcionar una clave valida");
        //    if (Mensaje.Length == 0)
        //    {
        //        Pd = Pdto.ObtenerPdto(ClPdto);
        //        if (Pd == null)
        //            Mensaje.Append("Voucher no encontrado en la B.D.");
        //        return Pd;
        //    }
        //    return null;
        //}

        public void Eliminar(string CodPqte)
        {
            Mensaje.Clear();
            if (CodPqte == "0")
                Mensaje.Append("Por favor proporcionar un Codigo valido");
            if (Mensaje.Length == 0)
                Pdto.Eliminar(CodPqte);
        }

        private bool ValidarProducto(Venta Pq)
        {
            Mensaje.Clear();
            if (string.IsNullOrEmpty(Pq.IDEmpleado) || Pq.IDEmpleado == "IDEmpleado")
                Mensaje.Append("El campo empleado no puede estar vacio");
            //if (!string.IsNullOrEmpty(Pq.NoSerie))
            //    Mensaje.Append("El campo No de serie debe estar vacio");
            if (Pq.Dia < 0 || Pq.Dia > 31)
                Mensaje.Append("El campo dia no puede ser menor que 0 ni mayor que 31");
            if (Pq.Mes < 0 || Pq.Mes > 12)
                Mensaje.Append("El campo mes no puede ser menor que 0 ni mayor que 12");
            if (Pq.Año < 2022 || Pq.Año > 2024)
                Mensaje.Append("El campo año no puede ser menor que 2022 ni mayor que 2024");
            if (string.IsNullOrEmpty(Pq.Hora))
                Mensaje.Append("El campo hora no puede estar vacio");
            if (Pq.Subtotal < 0)
                Mensaje.Append("El campo subtotal no puede ser negativo");
            if (string.IsNullOrEmpty(Pq.TipoVenta))
                Mensaje.Append("El campo de Tipo pago no puede estar vacio");
            return Mensaje.Length == 0;

        }
        private bool ValidarProductoserie(string Pq)
        {
            Mensaje.Clear();
            if (string.IsNullOrEmpty(Pq))
                Mensaje.Append("El campo Numero de serie no debe estar vacio");
            return Mensaje.Length == 0;

        }
        public void Modificar(Venta Pqte)
        {
            if (ValidarProducto(Pqte))
                Pdto.Actualizar(Pqte);


        }
        public void ModificarAuto(string idventa, string serie)
        {
            if (ValidarProductoserie(serie))
                Pdto.Actualizarserie(idventa, serie);
        }

        
    }
}
