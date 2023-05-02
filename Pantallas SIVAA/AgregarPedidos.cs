using Datos;
using Entidades;
using Logicas;
using Pantallas_SIVAA.Pedidos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Logicas;

namespace Pantallas_SIVAA
{
    public partial class AgregarPedidos : Form
    {
        Empleado _pqt;
        readonly PedidoLOG pedidoLog = new PedidoLOG();
        Pedido pedido = new Pedido();
        VehiculoLog pqte = new VehiculoLog();
        VersionLog pqte2 = new VersionLog();
        UnidadLog PqteLog2 = new UnidadLog();

        public AgregarPedidos(Empleado pqt)
        {
            InitializeComponent();
            _pqt = pqt;
        }

        private void AgregarPedidos_Load(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now;
            int dia = fechaActual.Day;
            int mes = fechaActual.Month;
            int anio = fechaActual.Year;
            numericUpDownDia.Value = dia;
            numericUpDownMes.Value = mes;
            numericUpDownAno.Value = anio;

            cbProov.SelectedIndex = 0;
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
            List<Vehiculo> veh;
            veh = pqte.ListadoAll();
            foreach (Vehiculo x in veh)
            {
                if (x.EstadoVehiculo.Trim() == "Activo")
                {
                    cmbVehiculo.Items.Add(x.Nombre);
                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Favor de ingresar al menos una unidad para guardar el pedido");
                return;
            }
            else
            {
                List<Pedido> x = pedidoLog.ListadoAll();
                string i = "PD" + (x.Count + 1).ToString();
                pedido.IDPedido = i;
                pedido.IDProveedor = pedidoLog.IdentProveed(cbProov.Text);
                pedido.IDEmpleado = _pqt.IDEmpleado;
                pedido.Dia = Convert.ToInt32(numericUpDownDia.Value);
                pedido.Mes = Convert.ToInt32(numericUpDownMes.Value);
                pedido.Año = Convert.ToInt32(numericUpDownAno.Value);
                pedido.Importe = Convert.ToDouble(txtImporte.Text);
                pedido.EstadoPedido = "Disponible";
                pedidoLog.Registrar(pedido);
                //Agrega Unidad por unidad
                Versions ver;
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    string serie, color;
                    serie = dataGridView1[0, j].Value.ToString();
                    color = dataGridView1[4, j].Value.ToString();
                    string ve, vers, mod;
                    ve = dataGridView1[1, j].Value.ToString();
                    vers = dataGridView1[2, j].Value.ToString();
                    mod = dataGridView1[3, j].Value.ToString();
                    ver = pqte2.ObtenerVersionPorDatos(ve, vers, mod);
                    Unidad uni;
                    //Unidades
                    uni = new Unidad
                    {
                        NoSerie = Convert.ToString(serie),
                        IDVersion = Convert.ToString(ver.IDVersion),
                        IDPedido = pedido.IDPedido.ToString(),
                        Color = Convert.ToString(color),
                        Estatus = Convert.ToString("Disponible")

                    };
                    PqteLog2.Registrar(uni);
                }

                MessageBox.Show("Pedido Agregado con exito");

                ResumenPedido resumen = new ResumenPedido(pedido.IDPedido, _pqt);
                resumen.Show();
            }


        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbProov_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtImporte_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            GestionarPedidos pedidos = new GestionarPedidos(_pqt);
            pedidos.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio inicio = new Inicio(_pqt);
            inicio.Show();
        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {

        }

        private void btnStock_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCitas_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPedidos_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCobros_Click_1(object sender, EventArgs e)
        {

        }

        private void AgregarPedidos_Load_1(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtImporte_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnIngresarUnidad_Click(object sender, EventArgs e)
        {
            if (txtSerie.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
                return;
            }
            else if (txtSerie.Text.Length < 10)
            {
                MessageBox.Show("El numero de serie debe contener 10 caracteres");
            }
            else if (cmbVehiculo.SelectedIndex < 0 || cmbVersion.SelectedIndex < 0 || cmbModelo.SelectedIndex < 0 || cmbColor.SelectedIndex < 0)
            {
                MessageBox.Show("Favor de seleccionar todos los campos");
                return;
            }
            else
            {
                string idversion, idpedido;
                string serie, color;
                string vehiculo, version, modelo;
                serie = txtSerie.Text;
                vehiculo = cmbVehiculo.SelectedItem.ToString();
                version = cmbVersion.SelectedItem.ToString();
                modelo = cmbModelo.SelectedItem.ToString();
                color = cmbColor.SelectedItem.ToString();

                dataGridView1.Rows.Add(serie, vehiculo, version, modelo, color);
                actualizar();
                Limpiar();
            }

        }
        public void Limpiar()
        {
            txtSerie.Text = "";
            cmbVersion.Items.Clear();
            cmbVersion.Text = "";
            cmbModelo.Items.Clear();
            cmbModelo.Text = "";
            cmbVehiculo.Text = "";

            //cmbVersion.SelectedItem=-1;
            //cmbModelo.SelectedItem=-1;
            //cmbColor.SelectedItem=-1;
            //cmbVehiculo.SelectedItem=-1;

        }
        Vehiculo v = new Vehiculo();

        private void cmbVehiculo_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbVersion.Items.Clear();
            List<Versions> ver;
            ver = pqte2.ListadoVersionesPorVehiculo(cmbVehiculo.SelectedItem.ToString());
            foreach (Versions x in ver)
            {
                if (x.EstadoVersion == "Activo")
                    cmbVersion.Items.Add(x.Version);
            }
        }

        private void cmbVersion_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbModelo.Items.Clear();
            List<Modelo> mo;
            mo = pqte2.ListaAnPorVersion(cmbVehiculo.SelectedItem.ToString(), cmbVersion.SelectedItem.ToString());
            foreach (Modelo x in mo)
            {
                cmbModelo.Items.Add(x.Año);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string id = null;
            if (dataGridView1.SelectedRows.Count == 1)
            {
                //id = dataGridView2[0, dataGridView2.SelectedRows[0].Index].Value.ToString();
                //MessageBox.Show("Empleado eliminado");
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                actualizar();
            }
            else
            {
                MessageBox.Show("Favor de seleccionar una unidad para eliminar");
            }
        }
        public void actualizar()
        {
            Versions ver;
            double total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string ve, vers, mod;
                ve = dataGridView1[1, i].Value.ToString();
                vers = dataGridView1[2, i].Value.ToString();
                mod = dataGridView1[3, i].Value.ToString();
                ver = pqte2.ObtenerVersionPorDatos(ve, vers, mod);
                total += ver.Costo;
            }
            txtCant.Text = (dataGridView1.Rows.Count).ToString();
            txtImporte.Text = total.ToString();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {

        }
    }
}
