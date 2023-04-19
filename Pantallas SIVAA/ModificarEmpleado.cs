using Entidades;
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
        public ModificarEmpleado(string idEmpleado)
        {
            InitializeComponent();
            id = idEmpleado;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ValidarVacios())
            {
                return;
            }
            Empleado empleado = new Empleado();
            empleado.IDEmpleado = id;
            empleado.Nombre = txtNombre.Text;
            empleado.ApellidoPat = txtApellidoP.Text;
            empleado.ApellidoMat = txtApellidoM.Text;
            empleado.Correo = txtCorreo.Text;
            empleado.Telefono = txtTelefono.Text;
            empleado.RFC = txtRFC.Text;
            empleado.Contraseña = txtContraseña.Text;
            if (cbpuesto.SelectedIndex == 1)
            {
                empleado.Tipo = "Atencion";

            }
            else
            {
                empleado.Tipo = cbpuesto.Text;
            }
            empleadoLog.Modificar(empleado);
            this.Close();
            GestionarEmpleados gestionarEmpleados = new GestionarEmpleados(_pqt);
            gestionarEmpleados.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio inicio = new Inicio(_pqt);
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

        public bool ValidarVacios()
        {
            if (txtNombre.Text == "" || txtApellidoP.Text == "" || txtApellidoM.Text == "" || txtCorreo.Text == "" || txtContraseña.Text == "" || txtRFC.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
                return true;
            }
            if (cbpuesto.SelectedIndex < 0)
            {
                MessageBox.Show("Favor de seleccionar un puesto para el empleado");
                return true;
            }
            return false;
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //    if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            //    {
            //        e.Handled = true;
            //    }
            //    if (txtNombre.Text.Length > 9)
            //    {
            //        e.Handled = true;
            //        //MessageBox.Show("Limite de caracteres exedido");
            //        string te = txtNombre.Text.Substring(0, 9).ToString();
            //        txtNombre.Text = te;
            //    }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtContraseña.Text.Length > 35)
            {
                e.Handled = true;
                //MessageBox.Show("Limite de caracteres exedido");
                string te = txtContraseña.Text.Substring(0, 9).ToString();
                txtContraseña.Text = te;
            }
        }

        private void txtApellidoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            //{
            //    e.Handled = true;
            //}
            //if (txtApellidoM.Text.Length > 9)
            //{
            //    e.Handled = true;
            //    //MessageBox.Show("Limite de caracteres exedido");
            //    string te = txtApellidoM.Text.Substring(0, 9).ToString();
            //    txtApellidoM.Text = te;
            //}
        }

        private void txtApellidoP_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtRFC_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


    }
}
