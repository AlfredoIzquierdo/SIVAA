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
    public partial class FichaDePago : Form
    {
        private bool isFormBorderStyleNone = false;
        private bool isFormBorderStyleChanged = false;
        public FichaDePago(string noSerie, string Vehiculo, string Version, string Modelo, string concepto, string monto, string id, string cli)
        {
            InitializeComponent();
            lblConcepto.Text = concepto;
            lblImporte.Text = monto;
            lblNoSerie.Text = noSerie;
            lblVehiculo.Text = Vehiculo;
            lblVersion.Text = Version;
            lblModelo.Text = Modelo;
            lblcli.Text = cli;
            lblPago.Text = id;
        }

        private void FichaDePago_Load(object sender, EventArgs e)
        {

        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Size formSize = this.Size;
            float scaleX = e.MarginBounds.Width / (float)formSize.Width;
            float scaleY = e.MarginBounds.Height / (float)formSize.Height;
            float scale = Math.Min(scaleX, scaleY);
            int targetWidth = (int)(formSize.Width * scale);
            int targetHeight = (int)(formSize.Height * scale);
            Bitmap bitmap = new Bitmap(targetWidth, targetHeight, graphics);
            Graphics bitmapGraphics = Graphics.FromImage(bitmap);
            bitmapGraphics.CopyFromScreen(this.PointToScreen(Point.Empty), Point.Empty, formSize);
            e.Graphics.DrawImage(bitmap, e.MarginBounds);
            bitmap.Dispose();
            bitmapGraphics.Dispose();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Crear un objeto PrintDocument
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            printDocument1.DefaultPageSettings.Landscape = false;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Letter", 850, 1100);
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
    }
}
