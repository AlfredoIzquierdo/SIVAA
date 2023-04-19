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

namespace Pantallas_SIVAA
{
    public partial class GestionarEmpleados : Form
    {
        public static NuevoEmpleado nuevoEmpleado = new NuevoEmpleado();
        readonly EmpleadoLog empleado = new EmpleadoLog();
        string ID;
        Empleado _pqt;
        public GestionarEmpleados(Empleado pqt)
        {
            InitializeComponent();
            this._pqt = pqt;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                MessageBox.Show("La accion que realizaras es irreversible ¿estas seguro de esto?", "Eliminacion de empleado", MessageBoxButtons.OKCancel);
                dataGridView1.ClearSelection();
                MessageBox.Show("Empleado eliminado con éxito");
            }
            else
            {
                MessageBox.Show("Favor de seleccionar un empleado para eliminar");
            }
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            NuevoEmpleado n = new NuevoEmpleado();
            n.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ModificarEmpleado modificarEmpleado = new ModificarEmpleado(ID, _pqt);
            this.Hide();
            modificarEmpleado.Show();
        }

        private void GestionarEmpleados_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            List<Empleado> em = empleado.ListadoAll();
            lista = em;
            foreach (Empleado x in em)
            {
                dataGridView1.Rows.Add(x.IDEmpleado, x.Nombre, x.ApellidoPat, x.ApellidoMat, x.Correo, x.Telefono, x.RFC, x.Contraseña, x.Tipo);
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.inicio.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio.Pedidos.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio.Stock.Show();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio.CalendarioCitas.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio.Ventas.Show();
        }

        private void btnCobros_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio.Caja.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio.Reportes.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            nuevoEmpleado.Show();
        }
        List<Empleado> lista;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ReporteEmpleados r = new ReporteEmpleados(lista);
            //this.Hide();
            r.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex >= 0)
            {
                int i = dataGridView1.CurrentCell.RowIndex;

                ID = dataGridView1[0, i].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Empleado> pro;
            int opcion = comboempleado.SelectedIndex;
            dataGridView1.ClearSelection();
            pro = ListadoEspecifico(txtbusqueda.Text, comboempleado.Text);
            lista = pro;
            dataGridView1.Rows.Clear();
            foreach (Empleado x in pro)
            {
                dataGridView1.Rows.Add(x.IDEmpleado, x.Nombre, x.ApellidoPat, x.ApellidoMat, x.Telefono, x.Correo, x.Contraseña, x.Tipo);
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

                string CdSql = "SELECT * FROM Empleado WHERE " + opcion + "=@Cl";
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
                            Tipo = Convert.ToString(Dr["Tipo"])
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
