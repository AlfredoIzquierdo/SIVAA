﻿using Datos;
using Entidades;
using iTextSharp.text;
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

namespace Pantallas_SIVAA
{
    public partial class Corte : Form
    {
        Empleado _pqt;
        CorteCajaLog cor = new CorteCajaLog();
        List<CorteCaja> lista = new List<CorteCaja>();
        public Corte(Empleado pqt)
        {
            InitializeComponent();
            _pqt = pqt;
        }

        private void Corte_Load(object sender, EventArgs e)
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
            List<CorteCaja> c;
            c = cor.ListadoAll();
            dataGridView1.DataSource = c;
            lista = c;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //ReporteBuenoCaja reporteBuenoCaja = new ReporteBuenoCaja();
            //this.Close();
            //reporteBuenoCaja.Show();
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
            inicio.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox2.SelectedIndex > 0 && textBox1.Text == "")
            {
                MessageBox.Show("Favor de llenar el campo de busqueda");
                //List<CorteCaja> c;
                //c = cor.ListadoAll();
                //dataGridView1.DataSource = c;
            }
            else
            {
                List<CorteCaja> c;
                c = cor.ListadoEspecifico(textBox1.Text, comboBox2.Text);
                dataGridView1.DataSource = c;
                lista = c;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Todos")
            {
                List<CorteCaja> c;
                c = cor.ListadoAll();
                dataGridView1.DataSource = c;
                lista = c;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReporteCorteCaja rc = new ReporteCorteCaja(_pqt,lista);
            rc.Show();
        }
    }
}
