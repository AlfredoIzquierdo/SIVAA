using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicas
{
    public class VehiculoLog
    {
        private VehiculoD Pdto = new VehiculoD();//No poner public
        public readonly StringBuilder Mensaje = new StringBuilder();

        public void Registrar(Vehiculo Pd)
        {
            Mensaje.Clear();
            if (ValidarProducto(Pd))
            {
                if (Pdto.ObtenerPdto(Pd.IDVehiculo) == null)
                    //No se encuentra el dato (El código no existe)
                    Pdto.Insertar(Pd);
                else
                    Mensaje.Append("El Codigo del Cliente ya se encuentra en la B.D.");
            }
        }

        public List<Vehiculo> ListadoAll()
        {
            //Método que obtiene la lista dinámica de todos los registro que tiene mi tabla
            return Pdto.ListadoTotal();
        }

        public void Modificar(Vehiculo Pqte)
        {
            if (ValidarProducto(Pqte))
                Pdto.Actualizar(Pqte);
        }

        private bool ValidarProducto(Vehiculo Pq)
        {
            Mensaje.Clear();
            if (string.IsNullOrEmpty(Pq.Nombre))
                Mensaje.Append("El campo nombre no puede estar vacio");
            if (Pq.Nombre.Length>10)
                Mensaje.Append("El campo nombre no puede tener más de 10 caractéres");
            return Mensaje.Length == 0;

        }
        public void Eliminar(string CodPqte)
        {
            Mensaje.Clear();
            if (CodPqte == "0")
                Mensaje.Append("Por favor proporcionar un Codigo valido");
            if (Mensaje.Length == 0)
                Pdto.Eliminar(CodPqte);
            return;
        }
        public List<Vehiculo> OrdenarID()
        {
            //Método que obtiene la lista dinámica de todos los registro que tiene mi tabla
            return Pdto.OrdenarID();
        }
        public List<Vehiculo> OrdenarNombre()
        {
            //Método que obtiene la lista dinámica de todos los registro que tiene mi tabla
            return Pdto.OrdenarNombre();
        }
        public Vehiculo LeerPorClave(string ClPdto)
        {
            Vehiculo Pd = null;
            Mensaje.Clear();
            if (ClPdto == "0")
                Mensaje.Append("Por favor proporcionar una clave valida");
            if (Mensaje.Length == 0)
            {
                Pd = Pdto.ObtenerPdto(ClPdto);
                if (Pd == null)
                    Mensaje.Append("Codigo de Vehiculo no existe en la B.D.");
                return Pd;
            }
            return null;
        }
        public Vehiculo LeerPorNombre(string ClPdto)
        {
            Vehiculo Pd = null;
            Mensaje.Clear();
            if (ClPdto == "0")
                Mensaje.Append("Por favor proporcionar una clave valida");
            if (Mensaje.Length == 0)
            {
                Pd = Pdto.ObtenerPdto(ClPdto);
                if (Pd == null)
                    Mensaje.Append("Codigo de Vehiculo no existe en la B.D.");
                return Pd;
            }
            return null;
        }
    }
}
