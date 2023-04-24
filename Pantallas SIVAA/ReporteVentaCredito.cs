using Entidades;
using Logicas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_SIVAA
{
    public partial class ReporteVentaCredito : Form
    {
        public ReporteVentaCredito(Empleado _pqt, string tipo, int dia, int mes, int año)
        {
            InitializeComponent();
            //Fecha
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //datos de quien genera el reporte
            lblidempleado.Text = _pqt.IDEmpleado.ToString();
            lblnombreempleado.Text = _pqt.Nombre.Trim() + " " + _pqt.ApellidoPat.Trim() + " " + _pqt.ApellidoMat;
            VentaLog ven = new VentaLog();
            List<ReporteVentasCredito> con;
            //MessageBox.Show("Tipo= " + tipo);
            if (tipo == "Dia")
            {
                lblPeriodo.Text = dia + "/" + mes + "/" + año;
                con = ven.ListaVentasCreditoPorDia(dia, mes, año);
                dataGridView1.DataSource = con;
            }
            if (tipo == "Semana")
            {
                lblPeriodo.Text = dia + "/" + mes + "/" + año;
                con = ven.ListaVentasCreditoSemanal(dia, dia + 7, mes, año);
                dataGridView1.DataSource = con;
            }
            if (tipo == "Mes")
            {
                lblPeriodo.Text = mes + "/" + año;
                con = ven.ListaVentasCreditoPorMes(mes, año);
                dataGridView1.DataSource = con;
            }
            if (tipo == "Anual")
            {
                lblPeriodo.Text = año.ToString();
                con = ven.ListaVentasCreditoAnual(año);
                dataGridView1.DataSource = con;
            }
        }

        private void ReporteVentaCredito_Load(object sender, EventArgs e)
        {

        }
    }
}
