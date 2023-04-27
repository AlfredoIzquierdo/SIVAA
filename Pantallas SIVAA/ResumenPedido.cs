﻿using Datos;
using Entidades;
using Logicas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_SIVAA
{
    public partial class ResumenPedido : Form
    {
        Unidad unidad = new Unidad();
        UnidadLog unidadlog = new UnidadLog();
        Pedido pedido = new Pedido();
        PedidoD PedidoD = new PedidoD();
        Unidad Unidad = new Unidad();
        UnidadLog UnidadLog = new UnidadLog();
        Proveedor Proveedor = new Proveedor();
        ProveedorD ProveedorD = new ProveedorD();
        string _id;

        public ResumenPedido(string id)
        {
            InitializeComponent();
            _id = id;
        }

        private void ResumenPedido_Load(object sender, EventArgs e)
        {
            ListadoUnidxPedido(_id);
            pedido = PedidoD.ObtenerPdto(_id);
            lblIDPedido.Text = pedido.IDPedido.ToString();
            lblDia.Text = pedido.Dia.ToString();
            lblMes.Text = pedido.Mes.ToString();
            lblAno.Text = pedido.Año.ToString();
            lblMonto.Text = pedido.Importe.ToString();

            Proveedor = ProveedorD.ObtenerPdto(pedido.IDProveedor);
            lblNombreProv.Text = Proveedor.Nombre.ToString();
            lblRFCProv.Text = Proveedor.RFC.ToString();
            lblCiudadProv.Text = Proveedor.Ciudad.ToString();
            lblEstadoProv.Text = Proveedor.Estado.ToString();
            lblNoExtProv.Text = Proveedor.NoExterior.ToString();
            lblColoniaProv.Text = Proveedor.Colonia.ToString();

            List<UnidadNoUsar> unidades = ListadoUnidxPedido(_id).ToList();

            dataGridView1.DataSource = unidades;
        }

        public List<UnidadNoUsar> ListadoUnidxPedido(string nom)
        {
            List<UnidadNoUsar> productos = new List<UnidadNoUsar>();
            string CdCnx = ConfigurationManager.ConnectionStrings["CnxSQL"].ToString();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla unidad
                string CdSql = "SELECT Unidad.NoSerie, Vehiculo.Nombre, [Version].[Version], Unidad.Color, Modelo.Año,Unidad.Estatus\r\nfrom Unidad, Vehiculo, Version, ModeloVersion, Modelo\r\nwhere Version.IDVehiculo=Vehiculo.IDVehiculo and ModeloVersion.IDModelo=Modelo.IDModelo\r\nand ModeloVersion.IDVersion=Version.IDVersion and Unidad.IDVersion=Version.IDVersion and Unidad.IDPedido=@Cl AND Unidad.Estatus='DISPONIBLE'";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    Cmd.Parameters.AddWithValue("@Cl", nom);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        UnidadNoUsar Pqte = new UnidadNoUsar
                        {
                            NoSerie = Convert.ToString(Dr["NoSerie"]),
                            Vehiculo = Convert.ToString(Dr["Nombre"]),
                            Version = Convert.ToString(Dr["Version"]),
                            Color = Convert.ToString(Dr["Color"]),
                            Modelo = Convert.ToString(Dr["Año"]),
                            Estatus = Convert.ToString(Dr["Estatus"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }

    }
}
