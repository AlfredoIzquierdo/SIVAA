using Datos;
using Entidades;
using Logicas;
using Pantallas_SIVAA.Pedidos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pantallas_SIVAA
{
    public partial class Vehiculos : Form
    {
        readonly VehiculoLog vehiculo = new VehiculoLog();
        String ID;
        Empleado _pqt;
        public Vehiculos(Empleado pqt)
        {
            InitializeComponent();
            this._pqt = pqt;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio inicio = new Inicio(_pqt);
            inicio.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
            AgregarVehiculos agregarVehiculos = new AgregarVehiculos(_pqt);
            agregarVehiculos.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string id = null;
            if (dataGridView1.SelectedRows.Count == 1)
            {
                id = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();
                ModificarVehiculo modificarVehiculo = new ModificarVehiculo(id, _pqt);
                this.Close();
                modificarVehiculo.Show();
            }
            else
            {
                MessageBox.Show("Favor de seleccionar un vehiculo");
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            GestionarPedidos pedidos = new GestionarPedidos(_pqt);
            pedidos.Show();
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

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            vehiculo.Eliminar(ID);
            MessageBox.Show("Vehiculo eliminado correctamente");
            List<Vehiculo> vhe = vehiculo.ListadoAll();
            dataGridView1.DataSource = vhe;

        }
        List<Vehiculo> listas; 
        private void Vehiculos_Load(object sender, EventArgs e)
        {

            dataGridView1.ClearSelection();
            List<Vehiculo> pro = vehiculo.ListadoAll();
            listas = pro;
            dataGridView1.Rows.Clear();
            foreach (Vehiculo x in pro)
            {
                dataGridView1.Rows.Add(x.IDVehiculo,x.Nombre);
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

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                List<Vehiculo>carros = vehiculo.OrdenarID();
                dataGridView1.DataSource = carros;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                List<Vehiculo> carros = vehiculo.OrdenarNombre();
                dataGridView1.DataSource = carros;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReporteVehiculos rp = new ReporteVehiculos(listas);
            rp.Show();
        }


        public List<Vehiculo> ListadoEspecifico(string CodPqt, string opcion)
        {
            string CdCnx = ConfigurationManager.ConnectionStrings["CnxSQL"].ToString();
            List<Vehiculo> productos = new List<Vehiculo>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla Proveedor

                string CdSql = "SELECT * FROM Vehiculo WHERE " + opcion + "=@Cl";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    Cmd.Parameters.AddWithValue("@Cl", CodPqt);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        Vehiculo Pqte = new Vehiculo
                        {
                             IDVehiculo= Convert.ToString(Dr["IDVehiculo"]),
                            Nombre = Convert.ToString(Dr["Nombre"]),
                            
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<Vehiculo> pro;
            int opcion = cmbOpcionBusqueda.SelectedIndex;
            dataGridView1.ClearSelection();
            pro = ListadoEspecifico(txtValorBusqueda.Text, cmbOpcionBusqueda.Text);
            dataGridView1.Rows.Clear();
            listas = pro;
            foreach (Vehiculo x in pro)
            {
                dataGridView1.Rows.Add(x.IDVehiculo, x.Nombre);
            }

            //if (comboBox2.SelectedIndex == 0)
            //{
            //    Vehiculo listado = vehiculo.LeerPorClave(textBox1.Text);
            //    if (listado != null)
            //    {
            //        dataGridView1.AutoGenerateColumns = false;
            //        dataGridView1.DataSource = listado;
            //        dataGridView1.Columns["Column25"].DataPropertyName = "IDVehiculo";
            //        dataGridView1.Columns["Column26"].DataPropertyName = "Nombre";
            //    }
            //}
            //if (comboBox2.SelectedIndex == 1)
            //{
            //    Vehiculo listado = vehiculo.LeerPorNombre(textBox1.Text);
            //    if (listado != null)
            //    {
            //        dataGridView1.AutoGenerateColumns = false;
            //        dataGridView1.DataSource = listado;
            //        dataGridView1.Columns["Column25"].DataPropertyName = "IDVehiculo";
            //        dataGridView1.Columns["Column26"].DataPropertyName = "Nombre";
            //    }
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
