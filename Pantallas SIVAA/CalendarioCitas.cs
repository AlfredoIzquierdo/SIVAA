﻿using Datos;
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

namespace Pantallas_SIVAA
{
    public partial class CalendarioCitas : Form
    {


        Empleado _pqt;

        readonly CitaLog citaLog = new CitaLog();
        String ID;
        string idCita = null;
        List<Cita> listas;
        public CalendarioCitas(Empleado _pqt)
        {
            InitializeComponent();
            this._pqt = _pqt;
        }

        private void Nueva_Cita_Load(object sender, EventArgs e)
        {
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

            //// Define la hora de inicio (8:00 AM)
            //DateTime hora = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);

            //// Agrega filas para cada hora, con un espaciado de 30 minutos
            //for (int i = 0; i < 24; i++)
            //{
            //    // Agrega una fila con el número de hora y el sufijo AM o PM
            //    dataGridView1.Rows.Add(hora.ToString("h:mm tt"));

            //    // Establece la altura de la fila
            //    dataGridView1.Rows[i].Height = 30;

            //    // Agrega un intervalo de 30 minutos a la hora
            //    hora = hora.AddMinutes(30);
            //}

            dataGridView1.ClearSelection();
            List<Cita> pro = citaLog.ListadoAll();
            dataGridView1.Rows.Clear();
            foreach (Cita x in pro)
            {
                dataGridView1.Rows.Add(x.IDCita, x.IDEmpleado, x.IDCliente, x.Dia, x.Mes, x.Año, x.Hora);
            }

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.RowIndex % 2 == 0)
            {
                e.CellStyle.BackColor = Color.LightGray;
            }
            else
            {
                e.CellStyle.BackColor = Color.White;
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            NuevaCita nuevaCita = new NuevaCita(_pqt);
            nuevaCita.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Cita> pro;
            dataGridView1.ClearSelection();
            pro = ListadoEspecifico(numericUpDown1.Value.ToString(), numericUpDown2.Value.ToString(), numericUpDown3.Value.ToString());
            listas = pro;
            dataGridView1.Rows.Clear();
            foreach (Cita x in pro)
            {
                dataGridView1.Rows.Add(x.IDCita, x.IDEmpleado, x.IDCliente, x.Dia, x.Mes, x.Año, x.Hora);
            }
        }
        public List<Cita> ListadoEspecifico(string dia, string mes, string año)
        {
            string CdCnx = ConfigurationManager.ConnectionStrings["CnxSQL"].ToString();
            List<Cita> productos = new List<Cita>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla Proveedor

                string CdSql = "SELECT * FROM Cita WHERE Dia=@Cl and Mes =@M and Año=@A";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    Cmd.Parameters.AddWithValue("@Cl", dia);
                    Cmd.Parameters.AddWithValue("@M", mes);
                    Cmd.Parameters.AddWithValue("@A", año);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        Cita Pqte = new Cita
                        {
                            IDCita = Convert.ToString(Dr["IDCita"]),
                            IDEmpleado = Convert.ToString(Dr["IDEmpleado"]),
                            IDCliente = Convert.ToString(Dr["IDCliente"]),
                            Dia = Convert.ToInt32(Dr["Dia"]),
                            Mes = Convert.ToInt32(Dr["Mes"]),
                            Año = Convert.ToInt32(Dr["Año"]),
                            Hora = Convert.ToString(Dr["Hora"])

                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            List<Cita> pro = citaLog.ListadoAll();
            listas = pro;
            dataGridView1.Rows.Clear();
            foreach (Cita x in pro)
            {
                dataGridView1.Rows.Add(x.IDCita, x.IDEmpleado, x.IDCliente, x.Dia, x.Mes, x.Año, x.Hora);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            AgregarCita agregarCita = new AgregarCita(_pqt);
            this.Close();
            agregarCita.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string id = null;
            if (dataGridView1.SelectedRows.Count == 1)
            {
                id = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();
                ModificarCita modificarCita = new ModificarCita(id, _pqt);
                this.Close();
                modificarCita.Show();
            }
            else
            {
                MessageBox.Show("Seleccione una cita haciendo click");
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            string id = null;
            if (dataGridView1.SelectedRows.Count == 1)
            {
                id = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();
                citaLog.Eliminar(id);
                MessageBox.Show("Cita eliminada");
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Favor de seleccionar una cita");
            }
        }

        private void CalendarioCitas_Load(object sender, EventArgs e)
        {
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
            dataGridView1.ClearSelection();
            List<Cita> listas = citaLog.ListadoAll();
            dataGridView1.Rows.Clear();
            foreach (Cita x in listas)
            {
                dataGridView1.Rows.Add(x.IDCita, x.IDEmpleado, x.IDCliente, x.Dia, x.Mes, x.Año, x.Hora);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReporteCitas r = new ReporteCitas(listas);
            r.Show();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnTodo_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPedidos_Click_1(object sender, EventArgs e)
        {

        }

        private void btnStock_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCitas_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCobros_Click_1(object sender, EventArgs e)
        {

        }

        private void btnReportes_Click_1(object sender, EventArgs e)
        {

        }
    }
}
