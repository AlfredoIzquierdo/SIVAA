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

namespace Pantallas_SIVAA
{
    public partial class ReporteVentaContado : Form
    {
        public ReporteVentaContado(Empleado _pqt, string tipo, int dia, int mes, int año)
        {
            InitializeComponent();
            //Fecha
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //datos de quien genera el reporte
            lblidempleado.Text = _pqt.IDEmpleado.ToString();
            lblnombreempleado.Text = _pqt.Nombre.Trim() + " " + _pqt.ApellidoPat.Trim() + " " + _pqt.ApellidoMat;
            VentaLog ven = new VentaLog();
            List<ReporteVentasContado> con;
            MessageBox.Show("Tipo= " + tipo);
            if (tipo == "Dia")
            {
                lblPeriodo.Text = dia + "/" + mes + "/" + año;
                con = ven.ListaVentasContadoPorDia(dia, mes, año);
                dataGridView1.DataSource = con;
            }
            if (tipo == "Semana")
            {
                lblPeriodo.Text = dia + "/" + mes + "/" + año;
                con = ven.ListaVentasContadoSemanal(dia, dia + 7, mes, año);
                dataGridView1.DataSource = con;
            }
            if (tipo == "Mes")
            {
                lblPeriodo.Text =mes + "/" + año;
                con = ven.ListaVentasContadoMes(mes, año);
                dataGridView1.DataSource = con;
            }
            if (tipo == "Anual")
            {
                lblPeriodo.Text = año.ToString();
                con = ven.ListaVentasContadoAnual(año);
                dataGridView1.DataSource = con;
            }
        }

        private void ReporteVentaContado_Load(object sender, EventArgs e)
        {

        }
    }
}
