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
            List<ReporteEmpleadoVenta> EmpleadosContado = new List<ReporteEmpleadoVenta>();
            List<ReporteEmpleadoVenta> EmpleadosCredito = new List<ReporteEmpleadoVenta>();
            //List<string> valoresusados= new List<string>();
            EmpleadosContado = reportesLOG.listadoEmpleadoVentasContado(diaI, mesI, AnoI, diaF, mesF, AnoF, opcion);
            EmpleadosCredito = reportesLOG.listadoEmpleadoVentasCredito(diaI, mesI, AnoI, diaF, mesF, AnoF, opcion);
            foreach (ReporteEmpleadoVenta x in EmpleadosContado)
            {
                int totalVecesVendido = Convert.ToInt32(x.VentasRealizadas);
                bool bandera = false;
                foreach (ReporteEmpleadoVenta z in EmpleadosCredito)
                {

                    if (x.IDEmpleado == z.IDEmpleado)
                    {
                        bandera = true;

                        totalVecesVendido = Convert.ToInt32(x.VentasRealizadas);
                        totalVecesVendido += Convert.ToInt32(z.VentasRealizadas);
                        Empleado empleadoActual = new Empleado();
                        empleadoActual = empleadoLog.LeerPorClave(x.IDEmpleado);
                        string nombrecompleto1 = empleadoActual.Nombre.Trim() + " " + empleadoActual.ApellidoPat.Trim() + " " + empleadoActual.ApellidoMat.Trim();
                        dgvEmpleadosV.Rows.Add(x.IDEmpleado, nombrecompleto1, z.VentasRealizadas, x.VentasRealizadas, totalVecesVendido.ToString(), reportesLOG.gananciasEmpleado(x.IDEmpleado));
                        //int indice= EmpleadosCredito.IndexOf(z);
                        //EmpleadosCredito.RemoveAt(indice);
                        break;

                    }



                }
                if (bandera == false)
                {
                    Empleado empleadoAct = new Empleado();
                    empleadoAct = empleadoLog.LeerPorClave(x.IDEmpleado);
                    string nombrecompleto = empleadoAct.Nombre.Trim() + " " + empleadoAct.ApellidoPat.Trim() + " " + empleadoAct.ApellidoMat.Trim();
                    dgvEmpleadosV.Rows.Add(x.IDEmpleado, nombrecompleto, x.VentasRealizadas, 0, totalVecesVendido.ToString(), reportesLOG.gananciasEmpleado(x.IDEmpleado));
                }




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
