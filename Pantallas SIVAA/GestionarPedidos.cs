﻿using System;
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
        public static AgregarPedidos agregarPedidos = new AgregarPedidos();
        readonly PedidoD Producto = new PedidoD();
        Empleado _pqt;
        public GestionarPedidos(Empleado pqt)
        {
            InitializeComponent();
            _pqt = pqt;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio inicio = new Inicio();
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
            AbrirCaja Caja = new AbrirCaja(_pqt);
            this.Close();
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
            this.Hide();
            editarPedidos.Show();
        }

        private void GestionarPedidos_Load(object sender, EventArgs e)
        {
            /*
            dataGridView1.Rows.Clear();
            List<Pedido> p = Producto.ListadoTotal();
            foreach (Pedido x in p) { 
                dataGridView1.Rows.Add(x.IDProveedor, x.);
            }
            */
        }
    }
}
