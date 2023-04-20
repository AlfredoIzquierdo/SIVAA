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
        public static EditarPedidos editarPedidos = new EditarPedidos();
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

            this.Hide();
            agregarPedidos.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

            this.Hide();
            editarPedidos.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            this.Close();
            GestionarPedidos pedidos = new GestionarPedidos(_pqt);
            pedidos.Show();
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

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Hide();
            editarPedidos.Show();
        }

        private void GestionarPedidos_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            List<Pedido> clie = pedlog.ListadoAll();
            foreach (Pedido x in clie)
            {
                if (x.EstadoPedido == "Activo")
                {

                    dataGridView1.Rows.Add(x.IDPedido, x.IDProveedor, x.Dia, x.Mes, x.Año, x.Importe);

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
    }
}
