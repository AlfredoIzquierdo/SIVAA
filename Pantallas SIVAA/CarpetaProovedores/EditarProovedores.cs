using Entidades;
using Logicas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pantallas_SIVAA.Pedidos;

namespace Pantallas_SIVAA.Proovedores
{
    public partial class EditarProovedores : Form
    {
        ProveedorLog log = new ProveedorLog();
        string id;
        Empleado _pqt;
        public EditarProovedores(string idProveedor, Empleado pqt)
        {
            InitializeComponent();
            id = idProveedor;
            _pqt = pqt;
        }



        private void EditarProovedores_Load(object sender, EventArgs e)
        {
            List<Proveedor> em = log.ListadoAll();
            foreach (Proveedor x in em)
            {
                if (x.IDProveedor == id)
                {
                    txtNombre.Text = x.Nombre;
                    txtRFC.Text = x.RFC;
                    txtNoExterior.Text = x.NoExterior;
                    txtEstado.Text = x.Estado;
                    txtColonia.Text = x.Colonia;
                    txtCiudad.Text = x.Ciudad;
                }
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

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(_pqt);
            this.Close();
            inicio.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.IDProveedor = id;
            proveedor.Nombre = txtNombre.Text;
            proveedor.RFC = txtRFC.Text;
            proveedor.Ciudad = txtCiudad.Text;
            proveedor.Estado = txtEstado.Text;
            proveedor.NoExterior = txtNoExterior.Text;
            proveedor.Colonia = txtColonia.Text;

            log.Modificar(proveedor);


            this.Close();
            ProovedoresPrin proovedores = new ProovedoresPrin(_pqt);
            proovedores.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            ProovedoresPrin proovedoresPrin = new ProovedoresPrin(_pqt);
            proovedoresPrin.Show();
        }

        private void txtNoExterior_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
