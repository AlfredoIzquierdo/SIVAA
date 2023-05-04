using Entidades;
using Logicas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_SIVAA
{
    public partial class ReporteMejoresEmpleados : Form
    {
        Empleado _pqt;
        readonly ReportesLOG reportesLOG = new ReportesLOG();
        readonly EmpleadoLog empleadoLog = new EmpleadoLog();
        private bool isFormBorderStyleNone = false;
        private bool isFormBorderStyleChanged = false;

        public ReporteMejoresEmpleados(Empleado pqt, int diaI, int mesI, int AnoI, int diaF, int mesF, int AnoF, string opcion)
        {
            InitializeComponent();
            _pqt = pqt;

            DateTime today = DateTime.Today;
            string diaAct = today.Day.ToString();
            string mesAct = today.Month.ToString();
            string anoAct = today.Year.ToString();
            Random rnd = new Random();
            int numeroAleatorio = rnd.Next(210000, 219001);

            lbldia.Text = diaAct;
            lblmes.Text = mesAct;
            lblano.Text = anoAct;
            lblnombrec.Text = pqt.Nombre.Trim() + " " + pqt.ApellidoPat.Trim() + " " + pqt.ApellidoMat.Trim();
            lblidempleado.Text = pqt.IDEmpleado.Trim();
            lblperiodo.Text = diaI.ToString() + "/" + mesI.ToString() + "/" + AnoI.ToString() + " --- " + diaF.ToString() + "/" + mesF.ToString() + "/" + AnoF.ToString();
            lblidcot.Text = numeroAleatorio.ToString();

            //Parte de abajo
            List<ReporteEmpleadoVenta> EmpleadosContado;
            List<ReporteEmpleadoVenta> EmpleadosCredito;
            List<ReporteEmpleadoVenta> EmpleadoTotal;
            //List<string> valoresusados= new List<string>();
            EmpleadosContado = reportesLOG.listadoEmpleadoVentasContado(diaI, mesI, AnoI, diaF, mesF, AnoF, opcion);
            EmpleadosCredito = reportesLOG.listadoEmpleadoVentasCredito(diaI, mesI, AnoI, diaF, mesF, AnoF, opcion);
            EmpleadoTotal = reportesLOG.listadoEmpleadoVentasTotal(diaI, mesI, AnoI, diaF, mesF, AnoF, opcion);
            int i = 0;
            foreach (ReporteEmpleadoVenta x in EmpleadoTotal)
            {
                Empleado empleadoActual = new Empleado();
                empleadoActual = empleadoLog.LeerPorClave(x.IDEmpleado);
                string nombrecompleto1 = empleadoActual.Nombre.Trim() + " " + empleadoActual.ApellidoPat.Trim() + " " + empleadoActual.ApellidoMat.Trim();
                bool bandera = false;
                int rowIndex = dgvEmpleadosV.Rows.Add(); // Agregar una nueva fila al DataGridView y obtener su índice
                dgvEmpleadosV.Rows[rowIndex].Cells["Column1"].Value = x.IDEmpleado;
                dgvEmpleadosV.Rows[rowIndex].Cells["nombreVendedor"].Value = nombrecompleto1;

                foreach (ReporteEmpleadoVenta z in EmpleadosContado)
                {
                    if (x.IDEmpleado == z.IDEmpleado)
                    {
                        dgvEmpleadosV.Rows[rowIndex].Cells["ventasContado"].Value = z.VentasRealizadas;
                    }
                    
                }

                foreach (ReporteEmpleadoVenta z in EmpleadosCredito)
                {
                    if (x.IDEmpleado == z.IDEmpleado)
                    {
                        dgvEmpleadosV.Rows[rowIndex].Cells["ventasCredito"].Value = z.VentasRealizadas;
                    }
                   
                }

                dgvEmpleadosV.Rows[rowIndex].Cells["totalVen"].Value = x.VentasRealizadas;
                dgvEmpleadosV.Rows[rowIndex].Cells["ganancias"].Value = reportesLOG.gananciasEmpleado(x.IDEmpleado, diaI, mesI, AnoI, diaF, mesF, AnoF,opcion);
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reportes regresar = new Reportes(_pqt);
            this.Close();
            regresar.Show();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ReporteMejoresEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            //Guardar el estado original de la propiedad "BorderStyle"
            isFormBorderStyleNone = this.FormBorderStyle == FormBorderStyle.None;
            isFormBorderStyleChanged = true;
            if (!isFormBorderStyleNone)
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }

            printDocument1.Print();
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            printDocument1.DefaultPageSettings.Landscape = false;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Letter", 850, 1100);
        }

        private void printDocument1_EndPrint(object sender, PrintEventArgs e)
        {
            // Restablecer el estado original de la propiedad "BorderStyle"
            if (isFormBorderStyleChanged)
            {
                this.FormBorderStyle = isFormBorderStyleNone ? FormBorderStyle.None : FormBorderStyle.FixedSingle;
            }
            pictureBox1.Show();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
