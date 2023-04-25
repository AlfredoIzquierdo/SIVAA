using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicas
{
    public class PedidoLOG
    {

         private PedidoD pqtPed = new PedidoD();
        public readonly StringBuilder Mensaje = new StringBuilder();

        public List<Pedido> ListadoAll()
        {
            //Método que obtiene la lista dinámica de todos los registro que tiene mi tabla
            return pqtPed.ListadoTotal();
        }
        public void Modificar(Pedido Pqte)
        {
            if (ValidarProducto(Pqte))
            {
                pqtPed.Actualizar(Pqte);

            }
        }
        public string IdentProveed(string nombreprov)
        {
            string idprov = "";
            if (nombreprov == "AutoSur")
            {
                return idprov = "P1";
            }
            if (nombreprov == "NissCar")
            {
                return idprov = "P10";
            }
            if (nombreprov == "AutoT")
            {
                return idprov = "P11";
            }
            if (nombreprov == "NisAuto")
            {
                return idprov = "P12";
            }
            if (nombreprov == "AutoYa")
            {
                return idprov = "P13";
            }
            if (nombreprov == "AutoG")
            {
                return idprov = "P14";
            }
            if (nombreprov == "NissMX")
            {
                return idprov = "P15";
            }
            if (nombreprov == "AutosP")
            {
                return idprov = "P16";
            }
            if (nombreprov == "AutoK")
            {
                return idprov = "P6";
            } else
            {
                return idprov;
            }

        }
          public string NombreProv(string nombreprov)
        {
            string idprov = "";
            if (nombreprov == "P1")
            {
                return idprov = "AutoSur";
            }
            if (nombreprov == "P10")
            {
                return idprov = "NissCar";
            }
            if (nombreprov == "P11")
            {
                return idprov = "AutoT";
            }
            if (nombreprov == "P12")
            {
                return idprov = "NisAuto";
            }
            if (nombreprov == "P13")
            {
                return idprov = "AutoYa";
            }
            if (nombreprov == "P14")
            {
                return idprov = "AutoG";
            }
            if (nombreprov == "P15")
            {
                return idprov = "NissMX";
            }
            if (nombreprov == "P16")
            {
                return idprov = "AutosP";
            }
            if (nombreprov == "P6")
            {
                return idprov = "AutoK";
            } else
            {
                return idprov;
            }

        }
        public string MesALetra(string num)
        {
            if (num == "1")
            {
                return "Enero";
            }
            if (num == "2")
            {
                return "Febrero";
            }
            if (num == "3")
            {
                return "Marzo";
            }
            if (num == "4")
            {
                return "Abril";
            }
            if (num == "5")
            {
                return "Mayo";
            }
            if (num == "6")
            {
                return "Junio";

            }
            if (num == "7")
            {
                return "Julio";
            }
            if (num == "8")
            {
                return "Agosto";
            }
            if (num == "9")
            {
                return "Septiembre";
            }
            if (num == "10")
            {
                return "Octubre";
            }
            if (num == "11")
            {
                return "Noviembre";
            }
            if (num == "12")
            {
                return "Diciembre";
            }
            else
            {
                return num;
            }
        }
        public int LetraAnumero(string num)
        {
            if (num == "ENERO")
            {
                return 1;
            }
            if (num == "FEBRERO")
            {
                return 2;
            }
            if (num == "MARZO")
            {
                return 3;
            }
            if (num == "ABRIL")
            {
                return 4;
            }
            if (num == "MAYO")
            {
                return 5;
            }
            if (num == "JUNIO")
            {
                return 6;

            }
            if (num == "JULIO")
            {
                return 7;
            }
            if (num == "AGOSTO")
            {
                return 8;
            }
            if (num == "SEPTIEMBRE")
            {
                return 9;
            }
            if (num == "OCTUBRE")
            {
                return 10;
            }
            if (num == "NOVIEMBRE")
            {
                return 11;
            }
            if (num == "DICIEMBRE")
            {
                return 12;
            }
            else
            {
                return 1;
            }
        }
        public void Registrar(Pedido Pd)
        {
            Mensaje.Clear();
            if (ValidarProducto(Pd))
            {
                if (pqtPed.ObtenerPdto(Pd.IDPedido) == null)
                    //No se encuentra el dato (El código no existe)
                    pqtPed.Insertar(Pd);
                else
                    Mensaje.Append("El Codigo del Pedido ya se encuentra en la B.D.");
            }
        }
        public List<Pedido> ListadoEspecifico(string ClPdto, string parametro)
        {
            List<Pedido> Pd = new List<Pedido>();
            Mensaje.Clear();
            if (ClPdto == "0")
                Mensaje.Append("Por favor proporcionar una clave valida");
            if (Mensaje.Length == 0)
            {
                Pd = pqtPed.ListadoTotalEspecifico(ClPdto, parametro);
                if (Pd == null)
                    Mensaje.Append(ClPdto + " no existe en la B.D.");
                return Pd;
            }
            return null;
        }
        public List<Pedido> ListadoEspecificoFechas(int ClPdto, string parametro)
        {
            List<Pedido> Pd = new List<Pedido>();
            Mensaje.Clear();
            if (ClPdto < 0)
                Mensaje.Append("Por favor proporcionar una clave valida");
            if (Mensaje.Length == 0)
            {
                Pd = pqtPed.ListadoTotalEspecificoFechas(ClPdto, parametro);
                if (Pd == null)
                    Mensaje.Append(ClPdto + " no existe en la B.D.");
                return Pd;
            }
            return null;
        }
        public List<Pedido> ListadoMayorA(double ClPdto)
        {
            List<Pedido> Pd = new List<Pedido>();
            Mensaje.Clear();
            if (ClPdto <0)
                Mensaje.Append("Por favor proporcionar una clave valida");
            if (Mensaje.Length == 0)
            {
                Pd = pqtPed.ListadoMayorA(ClPdto);
                if (Pd == null)
                    Mensaje.Append(ClPdto + " no existe en la B.D.");
                return Pd;
            }
            return null;
        }
        public List<Pedido> ListadoMenorA(double ClPdto)
        {
            List<Pedido> Pd = new List<Pedido>();
            Mensaje.Clear();
            if (ClPdto <0)
                Mensaje.Append("Por favor proporcionar una clave valida");
            if (Mensaje.Length == 0)
            {
                Pd = pqtPed.ListadoMenorA(ClPdto);
                if (Pd == null)
                    Mensaje.Append(ClPdto + " no existe en la B.D.");
                return Pd;
            }
            return null;
        }
        public void EliminarPorStatus(string CodPqte)
        {
            //Agregar esto
            Mensaje.Clear();
            if (CodPqte == null)
                Mensaje.Append("Por favor proporcionar un Codigo valido");
            if (Mensaje.Length == 0)
            {
                pqtPed.Eliminar(CodPqte);
            }


        }

        private bool ValidarProducto(Pedido Pq)
        {
            Mensaje.Clear();
            if (Pq.Dia<=0)
                Mensaje.Append("El campo nombre no puede estar vacio");
            if (Pq.Mes <= 0)
                Mensaje.Append("El campo apellido paterno no puede estar vacio");
            if (Pq.Año <= 0)
                Mensaje.Append("El campo apellido materno no puede estar vacio");
            if (Pq.Importe <= 0)
                Mensaje.Append("El campo RFC no puede estar vacio");
          
            return Mensaje.Length == 0;

        }



    }
}
