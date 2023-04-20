﻿using Entidades;
using Logicas;
using Pantallas_SIVAA.Pedidos;
using Pantallas_SIVAA.Proovedores;
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
    public partial class ProovedoresPrin : Form
    {
        readonly ProveedorLog proveedor = new ProveedorLog();
        Empleado _pqt;
        public ProovedoresPrin(Empleado pqt)
        {
            InitializeComponent();
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox13_Click);
            _pqt = pqt;
        }


        private void pictureBox8_Click(object sender, EventArgs e)
        {
            AgregarProovedor agregarprov = new AgregarProovedor(_pqt);
            this.Close();
            agregarprov.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(_pqt);
            this.Close();
            inicio.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string id = null;
            if (dataGridView1.SelectedRows.Count == 1)
            {
                id = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();
                EditarProovedores modificarEmpleado = new EditarProovedores(id,_pqt);
                this.Close();
                modificarEmpleado.Show();
            }
            else
            {
                MessageBox.Show("Favor de seleccionar un empleado");
            }
        }


        private void btnPedidos_Click(object sender, EventArgs e)
        {
            GestionarPedidos pedidos = new GestionarPedidos(_pqt);
            this.Close();
            pedidos.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Inventario stock = new Inventario(_pqt);
            this.Close();
            stock.Show();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            ConsultaCitas citas = new ConsultaCitas(_pqt);
            this.Close();
            citas.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas(_pqt);
            this.Close();
            ventas.Show();
        }

        private void btnCobros_Click(object sender, EventArgs e)
        {
            CorteDeCaja corte = new CorteDeCaja(_pqt);
            this.Close();
            corte.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.Close();
            Reportes reportes = new Reportes(_pqt);
            reportes.Show();
        }

        private void btnCitas_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click_1(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(_pqt);
            this.Close();
            inicio.Show();
        }
        List<Proveedor> listas;
        private void ProovedoresPrin_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            List<Proveedor> pro = proveedor.ListadoAll();
            listas = pro;
            foreach (Proveedor x in pro)
            {
                dataGridView1.Rows.Add(x.IDProveedor, x.Nombre, x.RFC, x.NoExterior, x.Colonia, x.Ciudad, x.Estado);
            }
            switch (_pqt.Tipo.Trim())
            {
                case "Atencion":
                    // Funciones activas: Citas e inventario
                    lblTipoEmpleado.Text = _pqt.Tipo + " a clientes";
                    lblNombre.Text = "Bienvenido: " + _pqt.Nombre + " " + _pqt.ApellidoPat;


                    // Menu lateral
                    btnCitas.Enabled = true;
                    btnStock.Enabled = true;
                    btnReportes.Enabled = false;
                    btnPedidos.Enabled = false;
                    btnVentas.Enabled = false;
                    btnCobros.Enabled = false;
                    break;
                case "Vendedor":
                    // Funciones activas: ventas, inventario y citas
                    lblTipoEmpleado.Text = _pqt.Tipo;
                    lblNombre.Text = "Bienvenido: " + _pqt.Nombre + " " + _pqt.ApellidoPat;


                    //Menu lateral
                    btnCitas.Enabled = true;
                    btnStock.Enabled = true;
                    btnReportes.Enabled = false;
                    btnPedidos.Enabled = false;
                    btnVentas.Enabled = true;
                    btnCobros.Enabled = false;
                    break;
                // más casos...
                case "Cajero":


                    // El cajero no pasa por aqui, se va directo al apartado de caja

                    break;
                case "Supervisor":
                    // Todo esta activado, es la vista de supervisor
                    lblTipoEmpleado.Text = _pqt.Tipo;
                    lblNombre.Text = "Bienvenido: " + _pqt.Nombre + " " + _pqt.ApellidoPat;
                    break;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Proveedor> pro;
            int opcion = comboversion.SelectedIndex;
            dataGridView1.ClearSelection();
            pro = ListadoEspecifico(txtbusqueda.Text, comboversion.Text);
            dataGridView1.Rows.Clear();
            listas = pro;
            foreach (Proveedor x in pro)
            {
                dataGridView1.Rows.Add(x.IDProveedor, x.Nombre, x.RFC, x.NoExterior, x.Colonia, x.Ciudad, x.Estado);
            }
        }
        public List<Proveedor> ListadoEspecifico(string CodPqt, string opcion)
        {
            string CdCnx = ConfigurationManager.ConnectionStrings["CnxSQL"].ToString();
            List<Proveedor> productos = new List<Proveedor>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla Proveedor

                string CdSql = "SELECT * FROM Proovedor WHERE " + opcion + "=@Cl";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    Cmd.Parameters.AddWithValue("@Cl", CodPqt);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        Proveedor Pqte = new Proveedor
                        {
                            IDProveedor = Convert.ToString(Dr["IDProovedor"]),
                            Nombre = Convert.ToString(Dr["Nombre"]),
                            RFC = Convert.ToString(Dr["RFC"]),
                            NoExterior = Convert.ToString(Dr["NoExterior"]),
                            Colonia = Convert.ToString(Dr["Colonia"]),
                            Ciudad = Convert.ToString(Dr["Ciudad"]),
                            Estado = Convert.ToString(Dr["Estado"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReporteProveedores pr = new ReporteProveedores(listas);
            pr.Show();
        }
    }
}
