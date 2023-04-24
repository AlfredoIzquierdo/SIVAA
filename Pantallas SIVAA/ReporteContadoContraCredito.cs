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
    public partial class ReporteContadoContraCredito : Form
    {
        public ReporteContadoContraCredito(Empleado _pqt, string tipo, int dia, int mes, int año)
        {
            InitializeComponent();
            //Fecha
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //datos de quien genera el reporte
            lblidempleado.Text = _pqt.IDEmpleado.ToString();
            lblnombreempleado.Text = _pqt.Nombre.Trim() + " " + _pqt.ApellidoPat.Trim() + " " + _pqt.ApellidoMat;
            VentaLog ven = new VentaLog();
            List<Entidades.ReporteContadoVsCredito> con;
            //MessageBox.Show("Tipo= " + tipo);
            if (tipo == "Dia")
            {
                lblPeriodo.Text = dia + "/" + mes + "/" + año;
                con = ven.ListaReporteCreditoVsContadoPorDia(dia, mes, año);
                dataGridView1.DataSource = con;
            }
            if (tipo == "Semana")
            {
                lblPeriodo.Text = dia + "/" + mes + "/" + año;
                con = ven.ListaReporteCreditoVsContadoPorSemana(dia, dia + 7, mes, año);
                dataGridView1.DataSource = con;
            }
            if (tipo == "Mes")
            {
                lblPeriodo.Text = mes + "/" + año;
                con = ven.ListaReporteCreditoVsContadoPorMes(mes, año);
                dataGridView1.DataSource = con;
            }
            if (tipo == "Anual")
            {
                lblPeriodo.Text = año.ToString();
                con = ven.ListaReporteCreditoVsContadoAnual(año);
                dataGridView1.DataSource = con;
            }
        }

        private void ReporteContadoContraCredito_Load(object sender, EventArgs e)
        {

        }
    }
}
