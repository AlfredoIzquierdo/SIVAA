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
            pedido.IDPedido = id;
            pedido.IDProveedor = pedidoLOG.IdentProveed(cbProov.Text);
            pedido.IDEmpleado = _pqt.IDEmpleado;
            pedido.Dia = Convert.ToInt32(numericUpDownDia.Value);
            pedido.Mes = Convert.ToInt32(numericUpDownMes.Value);
            pedido.Año = Convert.ToInt32(numericUpDownAno.Value);
            pedido.Importe = Convert.ToDouble(txtImporte.Text);
            pedidoLOG.Modificar(pedido);

            this.Close();
            GestionarPedidos gestionarPedidos = new GestionarPedidos(_pqt);
            gestionarPedidos.Show();

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
