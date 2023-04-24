using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logicas;
using Entidades;

namespace Pantallas_SIVAA
{
    public partial class ReporteMejoresClientes : Form
    {
        readonly ReportesLOG reportesLOG = new ReportesLOG();
        readonly ClienteLog clienteLog = new ClienteLog();
        private bool isFormBorderStyleNone = false;
        private bool isFormBorderStyleChanged = false;
        public ReporteMejoresClientes(Empleado pqt, int diaI, int mesI, int AnoI, int diaF, int mesF, int AnoF, string opcion)
        {
            InitializeComponent();
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
            //parte de abajo
            //Coordenadas
            int desplazamiento = 20;
            int xidclien = lblidcliente.Left;
            int yidclien = lblidcliente.Top;
            int xnomclien = lblnombreclien.Left;
            int ynomclien = lblnombreclien.Top;
            int xcomcred = lblcomprascred.Left;
            int ycomcred = lblcomprascred.Top;
            int xcomcon = lblcomprascon.Left;
            int ycomcon = lblcomprascon.Top;
            int xtotcom = totalcomp.Left;
            int ytotcom = totalcomp.Top;
            int xtot = lbltotal.Left;
            int ytot = lbltotal.Top;



            List<ReportesEntidad> ComprasContadoC = new List<ReportesEntidad>();
            List<ReportesEntidad> ComprasCreditoC = new List<ReportesEntidad>();
            ComprasContadoC = reportesLOG.listadoClienteContado(diaI, mesI, AnoI, diaF, mesF, AnoF, opcion);
            ComprasCreditoC = reportesLOG.listadoClienteCredito(diaI, mesI, AnoI, diaF, mesF, AnoF, opcion);
            foreach (ReportesEntidad x in ComprasContadoC)
            {

                Cliente cliente = new Cliente();
                cliente = clienteLog.LeerPorClave(x.IDCliente);
                string nombrecompleto = cliente.Nombre.Trim() + " " + cliente.ApellidoPat.Trim() + " " + cliente.ApellidoMat.Trim();
                int comprastotaltes = Convert.ToInt32(x.vecesCompro);
                foreach (ReportesEntidad z in ComprasCreditoC)
                {
                    if (z.IDCliente == x.IDCliente)
                    {
                        comprastotaltes += Convert.ToInt32(z.vecesCompro);
                    }
                }

                //Clavecliente
                Label ClaveCliente = new Label();
                ClaveCliente.Size = new Size(56, 20);
                ClaveCliente.Text = x.IDCliente;
                ClaveCliente.ForeColor = Color.Black;
                ClaveCliente.Location = new Point(xidclien, yidclien + desplazamiento);
                panel6.Controls.Add(ClaveCliente);

                //NombreCompleto
                Label NombreCompleto = new Label();
                //NombreCompleto.Size = new Size(89, 28);
                NombreCompleto.Text = nombrecompleto;
                NombreCompleto.ForeColor = Color.Black;
                NombreCompleto.Location = new Point(xnomclien, ynomclien + desplazamiento);
                panel6.Controls.Add(NombreCompleto);
                //Telefono
                Label Telefono = new Label();
                //NombreCompleto.Size = new Size(89, 28);
                Telefono.Text = cliente.Telefono;
                Telefono.ForeColor = Color.Black;
                Telefono.Location = new Point(xcomcred, ycomcred + desplazamiento);
                panel6.Controls.Add(Telefono);

                //Compras Al contado
                Label ComprasContado = new Label();
                //NombreCompleto.Size = new Size(89, 28);
                ComprasContado.Text = cliente.Correo;
                ComprasContado.ForeColor = Color.Black;
                ComprasContado.Location = new Point(xcomcon, ycomcon + desplazamiento);
                panel6.Controls.Add(ComprasContado);



                //Compras totales
                Label comprasTotales = new Label();
                //NombreCompleto.Size = new Size(89, 28);
                comprasTotales.Text = comprastotaltes.ToString();
                comprasTotales.ForeColor = Color.Black;
                comprasTotales.Location = new Point(xtotcom, ytotcom + desplazamiento);
                panel6.Controls.Add(comprasTotales);

                //GastadoCliente
                Label GastoCliente = new Label();
                //NombreCompleto.Size = new Size(89, 28);
                GastoCliente.Text = reportesLOG.gananciasCliente(x.IDCliente);
                GastoCliente.ForeColor = Color.Black;
                GastoCliente.Location = new Point(xtot, ytot + desplazamiento);
                panel6.Controls.Add(GastoCliente);


                desplazamiento += 30;
            }
            ReportesEntidad mejorclien = ComprasContadoC.First();
            Cliente mejorcliente = new Cliente();
            mejorcliente = clienteLog.LeerPorClave(mejorclien.IDCliente);
            lblmejorclien.Text = mejorcliente.Nombre.Trim() + " " + mejorcliente.ApellidoPat.Trim() + " " + mejorcliente.ApellidoMat.Trim();
        }

        private void ReporteMejoresClientes_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            printDocument1.DefaultPageSettings.Landscape = false;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Letter", 850, 1100);
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

        private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            // Restablecer el estado original de la propiedad "BorderStyle"
            if (isFormBorderStyleChanged)
            {
                this.FormBorderStyle = isFormBorderStyleNone ? FormBorderStyle.None : FormBorderStyle.FixedSingle;
            }
            pictureBox1.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
