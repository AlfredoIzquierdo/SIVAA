using Entidades;
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
    public partial class Reportes : Form
    {
        //PeriodoMejorCliente periodoMejorCliente = new PeriodoMejorCliente();
        Empleado _pqt;
        public Reportes(Empleado pqt)
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

        private void btnCorteCaja_Click(object sender, EventArgs e)
        {
            Corte corte = new Corte(_pqt);
            //this.Close();
            corte.Show();

        }

        private void btnVersiones_Click(object sender, EventArgs e)
        {
            PeriodoVentas periodoVentas = new PeriodoVentas(_pqt);
            periodoVentas.Show();
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

        private void Reportes_Load(object sender, EventArgs e)
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
        }

        

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            //PeriodoMejorServicio periodoMejorServicio = new PeriodoMejorServicio();
            //periodoMejorServicio.Show();
            PeriodoVentasContado per = new PeriodoVentasContado(_pqt);
            per.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            PeriodoMejorEmpleado periodoMejorEmpleado = new PeriodoMejorEmpleado(_pqt);
            periodoMejorEmpleado.Show();
        }

        private void btnCitasxvendedor_Click(object sender, EventArgs e)
        {
            PeriodoCitasPorVendedor periodoCitasPorVendedor = new PeriodoCitasPorVendedor();
            periodoCitasPorVendedor.Show();
        }

        private void btnClientefrecuente_Click(object sender, EventArgs e)
        {

            PeriodoMejorCliente periodoMejorCliente = new PeriodoMejorCliente(_pqt);
            periodoMejorCliente.Show();
        }

        private void btnrepventas_Click(object sender, EventArgs e)
        {
            PeriodoVentas periodoventas = new PeriodoVentas(_pqt);
            periodoventas.Show();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            PeriodoUnidadesVendidas C = new PeriodoUnidadesVendidas(_pqt);
            C.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //PeriodoContadoContraCredito periodoContadoContraCredito = new PeriodoContadoContraCredito();
            //periodoContadoContraCredito.Show();
            PeriodoContadoContraCredito per = new PeriodoContadoContraCredito(_pqt);
            per.Show();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Inventario inventario = new Inventario(_pqt);
            inventario.Show();
        }

        private void btnReporteCredito_Click(object sender, EventArgs e)
        {
            PeriodoVentasCredito per = new PeriodoVentasCredito(_pqt);
            per.Show();
        }
    }
}
