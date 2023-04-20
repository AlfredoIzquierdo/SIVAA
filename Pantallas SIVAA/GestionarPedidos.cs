using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logicas;
using Datos;
using Entidades;

namespace Pantallas_SIVAA.Pedidos
{
    public partial class GestionarPedidos : Form
    {

        public static AgregarPedidos agregarPedidos = new AgregarPedidos(null);
        readonly PedidoD Producto = new PedidoD();
        readonly PedidoLOG pedlog = new PedidoLOG();
        Empleado _pqt;
        public GestionarPedidos(Empleado pqt)
        {
            InitializeComponent();
            this._pqt = pqt;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(_pqt);
            this.Close();
            inicio.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            this.Close();
            AgregarPedidos agregarPedidos = new AgregarPedidos(_pqt);
            agregarPedidos.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string id = null;
            if (dataGridView1.SelectedRows.Count == 1)
            {
                id = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();
                EditarPedidos editar = new EditarPedidos(id, _pqt);
                this.Close();
                editar.Show();
            }
            else
            {
                MessageBox.Show("Favor de seleccionar un cliente");
            }


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
            string id = null;
            if (dataGridView1.SelectedRows.Count == 1)
            {
                id = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();
                pedlog.EliminarPorStatus(id);
                MessageBox.Show("Pedido Eliminado");
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Favor de seleccionar un cliente");
            }
        }

        private void GestionarPedidos_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            comboBox2.SelectedIndex = 0;
            List<Pedido> clie = pedlog.ListadoAll();
            foreach (Pedido x in clie)
            {
                if (x.EstadoPedido == "Activo")
                {

                    dataGridView1.Rows.Add(x.IDPedido, x.IDProveedor, x.Dia, pedlog.MesALetra(Convert.ToString(x.Mes)), x.Año, x.Importe);

                }


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
            if (string.IsNullOrEmpty(txtbusqueda.Text))
            {
                MessageBox.Show("Llene el campo busqueda");
            }
            if (comboBox2.Text == "Importe mayor a")
            {
                List<Pedido> datos = new List<Pedido>();

                datos = pedlog.ListadoMayorA(Convert.ToDouble(txtbusqueda.Text));
                //listas = datos;
                dataGridView1.Rows.Clear();
                foreach (Pedido x in datos)
                {
                    dataGridView1.Rows.Add(x.IDPedido, x.IDProveedor, x.Dia, pedlog.MesALetra(Convert.ToString(x.Mes)), x.Año, x.Importe);
                }
            }
            else if (comboBox2.Text == "Importe menor a ")
            {
                List<Pedido> datos = new List<Pedido>();

                datos = pedlog.ListadoMenorA(Convert.ToDouble(txtbusqueda.Text));
                //listas = datos;
                dataGridView1.Rows.Clear();
                foreach (Pedido x in datos)
                {
                    dataGridView1.Rows.Add(x.IDPedido, x.IDProveedor, x.Dia, pedlog.MesALetra(Convert.ToString(x.Mes)), x.Año, x.Importe);
                }
            }else 
            
            {
                List<Pedido> datos = new List<Pedido>();

                datos = pedlog.ListadoEspecifico(txtbusqueda.Text, comboBox2.Text);
                //listas = datos;
                dataGridView1.Rows.Clear();
                foreach (Pedido x in datos)
                {
                    dataGridView1.Rows.Add(x.IDPedido, x.IDProveedor, x.Dia, pedlog.MesALetra(Convert.ToString(x.Mes)), x.Año, x.Importe);
                }

            }
        }


        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text != "Todos")
            {
                txtbusqueda.Enabled = true;
                button1.Enabled = true;


            }else
            {
                txtbusqueda.Enabled = false;
                button1.Enabled = false;
                dataGridView1.ClearSelection();
                //comboBox2.SelectedIndex = 0;
                List<Pedido> clie = pedlog.ListadoAll();
                foreach (Pedido x in clie)
                {
                    if (x.EstadoPedido == "Activo")
                    {

                        dataGridView1.Rows.Add(x.IDPedido, x.IDProveedor, x.Dia, pedlog.MesALetra(Convert.ToString(x.Mes)), x.Año, x.Importe);

                    }


                }
            }
        }
    }
}
