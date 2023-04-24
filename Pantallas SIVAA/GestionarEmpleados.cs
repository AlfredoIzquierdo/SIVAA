using Pantallas_SIVAA.Pedidos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logicas;
using Entidades;
using System.Configuration;
using System.Data.SqlClient;
using Datos;

namespace Pantallas_SIVAA
{
    public partial class GestionarEmpleados : Form
    {
        public static NuevoEmpleado nuevoEmpleado = new NuevoEmpleado(null);
        readonly EmpleadoLog empleado = new EmpleadoLog();
        string ID;
        Empleado _pqt;
        string inicia = "Activo";
        public GestionarEmpleados(Empleado pqt)
        {
            InitializeComponent();
            this._pqt = pqt;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            string id = null;
            if (dataGridView1.SelectedRows.Count == 1)
            {
                id = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();
                empleado.EliminarPorStatus(id);
                MessageBox.Show("Empleado eliminado");
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Favor de seleccionar un empleado");
            }
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            NuevoEmpleado n = new NuevoEmpleado(_pqt);
            n.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string id = null;
            if (dataGridView1.SelectedRows.Count == 1)
            {
                id = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();
                ModificarEmpleado modificarEmpleado = new ModificarEmpleado(id, _pqt);
                this.Close();
                modificarEmpleado.Show();
            }
            else
            {
                MessageBox.Show("Favor de seleccionar un cliente");
            }
        }

        private void GestionarEmpleados_Load(object sender, EventArgs e)
        {

            dataGridView1.ClearSelection();
            List<Empleado> clie = empleado.ListadoAll();
            lista = clie;
            foreach (Empleado x in clie)
            {
                if (x.EstadoEmpleado.Trim() == "Activo")
                {

                    dataGridView1.Rows.Add(x.IDEmpleado, x.Nombre, x.ApellidoPat, x.ApellidoMat, x.Correo, x.Telefono, x.RFC, x.Contraseña, x.Tipo);

                }
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

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(_pqt);
            this.Close();
            inicio.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            this.Close();
            GestionarPedidos pedidos = new GestionarPedidos(_pqt);
            pedidos.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            this.Close();
            Inventario inventario = new Inventario(_pqt);
            inventario.Show();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            this.Close();
            CalendarioCitas citas = new CalendarioCitas(_pqt);
            citas.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.Close();
            Ventas ventas = new Ventas(_pqt);
            ventas.Show();
        }

        private void btnCobros_Click(object sender, EventArgs e)
        {
            this.Close();
            AbrirCaja Caja = new AbrirCaja(_pqt);
            Caja.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.Close();
            Reportes reportes = new Reportes(_pqt);
            reportes.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
            NuevoEmpleado nuevoEmpleado = new NuevoEmpleado(_pqt);
            nuevoEmpleado.Show();
        }
        List<Empleado> lista;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ReporteEmpleados r = new ReporteEmpleados(lista);
            //this.Close();
            r.Show();
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
            List<Empleado> pro;
            int opcion = comboempleado.SelectedIndex;
            if (opcion == 0)
            {
                //txtbusqueda.Enabled = false;
                dataGridView1.Rows.Clear();
                List<Empleado> em = empleado.ListadoAll();
                lista = em;
                foreach (Empleado x in em)
                {
                    if (x.EstadoEmpleado.Trim() == "Activo")
                    {
                        dataGridView1.Rows.Add(x.IDEmpleado, x.Nombre, x.ApellidoPat, x.ApellidoMat, x.Correo, x.Telefono, x.RFC, x.Contraseña, x.Tipo);
                    }

                }
                return;
            }
            else
            {
                if (txtbusqueda.Text != "")
                    dataGridView1.ClearSelection();
                pro = ListadoEspecifico(txtbusqueda.Text, comboempleado.Text);
                lista = pro;
                dataGridView1.Rows.Clear();
                foreach (Empleado x in pro)
                {
                    if (x.EstadoEmpleado.Trim() == "Activo")
                    {
                        dataGridView1.Rows.Add(x.IDEmpleado, x.Nombre, x.ApellidoPat, x.ApellidoMat, x.Correo, x.Telefono, x.RFC, x.Contraseña, x.Tipo);

                    }
                }
            }

        }
        public List<Empleado> ListadoEspecifico(string CodPqt, string opcion)
        {
            string CdCnx = ConfigurationManager.ConnectionStrings["CnxSQL"].ToString();
            List<Empleado> productos = new List<Empleado>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla Proveedor

                string CdSql = "SELECT * FROM Empleado WHERE " + opcion + "=@Cl and EstadoEmpleado = 'Activo'";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    Cmd.Parameters.AddWithValue("@Cl", CodPqt);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        Empleado Pqte = new Empleado
                        {
                            IDEmpleado = Convert.ToString(Dr["IDEmpleado"]),
                            Nombre = Convert.ToString(Dr["Nombre"]),
                            ApellidoPat = Convert.ToString(Dr["ApellidoPaterno"]),
                            ApellidoMat = Convert.ToString(Dr["ApellidoMaterno"]),
                            RFC = Convert.ToString(Dr["RFC"]),
                            Correo = Convert.ToString(Dr["Correo"]),
                            Telefono = Convert.ToString(Dr["Telefono"]),
                            Contraseña = Convert.ToString(Dr["Contraseña"]),
                            Tipo = Convert.ToString(Dr["Tipo"]),
                            EstadoEmpleado = Convert.ToString(Dr["EstadoEmpleado"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }

        private void GestionarEmpleados_VisibleChanged(object sender, EventArgs e)
        {
            if (inicia == "Activo")
            {
                inicia = "NoActivo";
            }
            else
            {
                dataGridView1.Rows.Clear();
                List<Empleado> clie = empleado.ListadoAll();
                foreach (Empleado x in clie)
                {
                    if (x.EstadoEmpleado == "Activo")
                    {

                        dataGridView1.Rows.Add(x.IDEmpleado, x.Nombre, x.ApellidoPat, x.ApellidoMat, x.Correo, x.Telefono, x.RFC, x.Contraseña, x.Tipo);

                    }
                }
            }

        }

        private void comboempleado_SelectedValueChanged(object sender, EventArgs e)
        {
            if (txtbusqueda.Text != "")
            {
                txtbusqueda.ResetText();
            }
        }
    }
}
