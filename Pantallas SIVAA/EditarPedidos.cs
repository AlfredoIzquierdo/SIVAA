using Datos;
using Entidades;
using Logicas;
using Microsoft.VisualBasic.Logging;
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

namespace Pantallas_SIVAA
{
    public partial class EditarPedidos : Form
    {
        string id;
        readonly PedidoLOG pedidoLOG = new PedidoLOG();
        Pedido pedido = new Pedido();
        Empleado _pqt;
        public EditarPedidos(string idCliente, Empleado pqt)
        {
            InitializeComponent();
            _pqt = pqt;
            id = idCliente;
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

        private void button1_Click(object sender, EventArgs e)
        {
            pedido.IDPedido = id;
            pedido.IDProveedor = pedidoLOG.IdentProveed(cbProov.Text);
            pedido.IDEmpleado = _pqt.IDEmpleado;
            pedido.Dia = Convert.ToInt32(numericUpDownDia.Value);
            pedido.Mes = Convert.ToInt32(numericUpDownMes.Value);
            pedido.Año = Convert.ToInt32(numericUpDownAno.Value);
            pedido.Importe = Convert.ToDouble(txtImporte.Text);
            pedidoLOG.Modificar(pedido);

            this.Show();
            Inicio.Pedidos.Show();
        }

        private void EditarPedidos_Load(object sender, EventArgs e)
        {
            List<Pedido> listped = pedidoLOG.ListadoAll();
            foreach (Pedido x in listped)
            {
                if (x.IDPedido == id)
                {
                    cbProov.SelectedItem = pedidoLOG.NombreProv(x.IDProveedor);
                    numericUpDownAno.Value = x.Año;
                    numericUpDownMes.Value = x.Mes;
                    numericUpDownDia.Value = x.Dia;
                    txtImporte.Text = Convert.ToString(x.Importe);
                }
            }
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
