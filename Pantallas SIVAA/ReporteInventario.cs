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
    public partial class ReporteInventario : Form
    {
        public ReporteInventario(Empleado _pqt)
        {
            InitializeComponent();
            UnidadLog uni = new UnidadLog();
            List<Entidades.ReporteInventario> repuni;
            repuni = uni.ReportInventario();
            dataGridView1.DataSource = repuni;
            //Fecha
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //datos de quien genera el reporte
            lblidempleado.Text = _pqt.IDEmpleado.ToString();
            lblnombreempleado.Text = _pqt.Nombre.Trim() + " " + _pqt.ApellidoPat.Trim() + " " + _pqt.ApellidoMat;
        }

        private void ReporteInventario_Load(object sender, EventArgs e)
        {

        }
    }
}
