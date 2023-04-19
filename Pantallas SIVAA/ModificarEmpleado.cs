﻿using Entidades;
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
    public partial class ModificarEmpleado : Form
    {
        string id;
        EmpleadoLog empleadoLog = new EmpleadoLog();
        Empleado _pqt;
        Empleado emp = new Empleado();
        public ModificarEmpleado(string idEmpleado, Empleado pqt)
        {
            InitializeComponent();
            id = idEmpleado;
            this._pqt = pqt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.IDEmpleado = id;
            empleado.Nombre = txtNombre.Text;
            empleado.ApellidoPat = txtApellidoP.Text;
            empleado.ApellidoMat = txtApellidoM.Text;
            empleado.Correo = txtCorreo.Text;
            empleado.Telefono = txtTelefono.Text;
            empleado.RFC = txtRFC.Text;
            empleado.Contraseña = txtContraseña.Text;
            empleado.Tipo = cbpuesto.Text;

            empleadoLog.Modificar(empleado);
            this.Hide();
            Inicio.GestionarEmpleados.Show();
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


        private void ModificarEmpleado_Load(object sender, EventArgs e)
        {
            Empleado em = empleadoLog.LeerPorClave(id);
            txtNombre.Text = em.Nombre;
            txtApellidoP.Text = em.ApellidoPat;
            txtApellidoM.Text = em.ApellidoMat;
            txtContraseña.Text = em.Contraseña;
            cbpuesto.Text = em.Tipo;
            txtCorreo.Text = em.Correo;
            txtRFC.Text = em.RFC;
            txtTelefono.Text = em.Telefono;

        }
    }
}
