using Entidades;
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
    public partial class ReporteBuenoCaja : Form
    {
        private bool isFormBorderStyleNone = false;
        private bool isFormBorderStyleChanged = false;
        public ReporteBuenoCaja(Entidades.CorteCaja caja, Empleado _pqt)
        {
            InitializeComponent();
            //caja
            lblfondoinicial.Text = caja.FondoInicial.ToString();
            lblefectivo3.Text = caja.BalanceEfectivo.ToString();
            lbltarjeta3.Text = caja.BalanceTarjeta.ToString();
            lblefectivo2.Text = caja.BalanceEfectivo.ToString();
            lbltotal.Text = (caja.BalanceEfectivo + caja.BalanceTarjeta).ToString();
            //Parte superior
            lbltarjeta.Text = caja.BalanceTarjeta.ToString();
            lblefectivo.Text = caja.BalanceEfectivo.ToString();
            lbltotal1.Text = (caja.BalanceEfectivo + caja.BalanceTarjeta).ToString();
            //Declarado
            lblfondoinicial2.Text = caja.FondoInicial.ToString();
            lblefectivodeclarado.Text = caja.EfectivoFinal.ToString();
            lbltarjetadeclarado.Text = caja.TarjetaFinal.ToString();
            lbltotaldeclarado.Text = caja.TotalFinal.ToString();
            double sobfal = caja.TotalFinal - (caja.BalanceEfectivo + caja.BalanceTarjeta);
            if (sobfal > 0)
            {
                lblsobrante.Text = sobfal.ToString();
            }
            if (sobfal < 0)
            {
                lblfaltante.Text = sobfal.ToString();
            }
            //Fecha
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //datos de quien genera el reporte
            lblidempleado.Text = _pqt.IDEmpleado.ToString();
            lblnombreempleado.Text = _pqt.Nombre.Trim() + " " + _pqt.ApellidoPat.Trim() + " " + _pqt.ApellidoMat;

        }

        private void ReporteBuenoCaja_Load(object sender, EventArgs e)
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
