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
        public void Registrar(Pedido Pd)
        {
            Mensaje.Clear();
            if (ValidarProducto(Pd))
            {
                if (pqtPed.ObtenerPdto(Pd.IDPedido) == null)
                    //No se encuentra el dato (El código no existe)
                    pqtPed.Insertar(Pd);
                else
                    Mensaje.Append("El Codigo del Cliente ya se encuentra en la B.D.");
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
