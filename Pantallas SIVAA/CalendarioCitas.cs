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
using static System.Windows.Forms.Design.AxImporter;

namespace Pantallas_SIVAA
{
    public partial class CalendarioCitas : Form
    {


        Empleado _pqt;

        readonly CitaLog citaLog = new CitaLog();
        String ID;
        string idCita = null;
        List<CitaNoUsar> listas;
        List<Cita> filtros;

        public CalendarioCitas(Empleado _pqt)
        {
            InitializeComponent();
            this._pqt = _pqt;
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
            DateTime fechaHoraSeleccionada = dateTimePicker1.Value;
            string fecha = fechaHoraSeleccionada.ToString("dd/MM/yyyy");
            string año = fechaHoraSeleccionada.ToString("yyyy");
            string mes = fechaHoraSeleccionada.ToString("MM");
            string dia = fechaHoraSeleccionada.ToString("dd");
            string hora = fechaHoraSeleccionada.ToString("HH:mm");

            string dias = Convert.ToInt32(dia).ToString();
            string meses = Convert.ToInt32(mes).ToString();
            string años = Convert.ToInt32(año).ToString();
            dataGridView1.ClearSelection();
            int opcion = comboBox1.SelectedIndex;
            string busqueda;

            dataGridView1.Rows.Clear();
            if (opcion == 1 || opcion == 2||opcion==7)
            {
                if (opcion == 7)
                    busqueda = hora;
                else busqueda = textBox1.Text;
                listas = citaLog.CitaFiltradaCita(comboBox1.Text,busqueda);
                foreach (CitaNoUsar x in listas)
                {
                    dataGridView1.Rows.Add(x.IDCita, x.IDEmpleado, x.Nombre, x.ApellidoPaterno, x.ApellidoMaterno, x.Dia, x.Mes, x.Año, x.Hora);
                }
            }
            if (opcion == 3 || opcion == 4 || opcion == 5)
            {
                busqueda = textBox1.Text;
                listas = citaLog.CitaFiltradaCliente(comboBox1.Text, busqueda);
                foreach (CitaNoUsar x in listas)
                {
                    dataGridView1.Rows.Add(x.IDCita, x.IDEmpleado, x.Nombre, x.ApellidoPaterno, x.ApellidoMaterno, x.Dia, x.Mes, x.Año, x.Hora);
                }
            }
            if(opcion == 6)
            {
                listas = citaLog.CitaPorFecha(dias, meses, años);
                foreach (CitaNoUsar x in listas)
                {
                    dataGridView1.Rows.Add(x.IDCita, x.IDEmpleado, x.Nombre, x.ApellidoPaterno, x.ApellidoMaterno, x.Dia, x.Mes, x.Año, x.Hora);
                }
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
            List<CitaNoUsar> listas = citaLog.ShowAll();
            dataGridView1.Rows.Clear();
            foreach (CitaNoUsar x in listas)
            {
                dataGridView1.Rows.Add(x.IDCita, x.IDEmpleado,x.Nombre,x.ApellidoPaterno,x.ApellidoMaterno, x.Dia, x.Mes, x.Año, x.Hora);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReporteCitas r = new ReporteCitas(listas);
            r.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Fecha")
                dateTimePicker1.Format = DateTimePickerFormat.Short;
            if (comboBox1.Text == "Hora")
                dateTimePicker1.Format = DateTimePickerFormat.Time;
            textBox1.Text = "";
            if (comboBox1.SelectedIndex == 0)
            {
                listas = citaLog.ShowAll();
                dataGridView1.Rows.Clear();
                foreach (CitaNoUsar x in listas)
                {
                    dataGridView1.Rows.Add(x.IDCita, x.IDEmpleado, x.Nombre, x.ApellidoPaterno, x.ApellidoMaterno, x.Dia, x.Mes, x.Año, x.Hora);
                }
            }
        }
    }
}
