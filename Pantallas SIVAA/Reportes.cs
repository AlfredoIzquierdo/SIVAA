﻿using Entidades;
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
        PeriodoMejorCliente periodoMejorCliente = new PeriodoMejorCliente();
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
            this.Close();
            corte.Show();

        }

        private void btnVersiones_Click(object sender, EventArgs e)
        {
            this.Close();
            ReporteVentas reporteVentas = new ReporteVentas();
            reporteVentas.Show();
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

        }

        private void pictureBox13_Click_1(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(_pqt);
            this.Close();
            inicio.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            PeriodoMejorServicio periodoMejorServicio = new PeriodoMejorServicio();
            periodoMejorServicio.Show();
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

            periodoMejorCliente.Show();
        }

        private void btnrepventas_Click(object sender, EventArgs e)
        {
            PeriodoVentas periodoventas = new PeriodoVentas();
            periodoventas.Show();
        }

        private void btnCorteCaja_Click_1(object sender, EventArgs e)
        {
            Corte C = new Corte(_pqt);
            C.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PeriodoUnidadesVendidas C = new PeriodoUnidadesVendidas();
            C.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PeriodoContadoContraCredito periodoContadoContraCredito = new PeriodoContadoContraCredito();
            periodoContadoContraCredito.Show();
        }
    }
}
