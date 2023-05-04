using Entidades;
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
    public partial class ReporteCorteCaja : Form
    {
        public ReporteCorteCaja(Empleado _pqt, List<CorteCaja> lista)
        {
            InitializeComponent();
            //Fecha
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //datos de quien genera el reporte
            lblidempleado.Text = _pqt.IDEmpleado.ToString();
            lblnombreempleado.Text = _pqt.Nombre.Trim() + " " + _pqt.ApellidoPat.Trim() + " " + _pqt.ApellidoMat;
            dataGridView1.DataSource = lista;
            Random rnd = new Random();
            int numeroAleatorio = rnd.Next(210000, 219001);
            lblidcot.Text = numeroAleatorio.ToString();
        }

        private void ReporteCorteCaja_Load(object sender, EventArgs e)
        {

        }
    }
}
