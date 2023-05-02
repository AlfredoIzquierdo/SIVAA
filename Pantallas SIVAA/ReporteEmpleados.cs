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
    public partial class ReporteEmpleados : Form
    {
        List<Empleado> lista;
        private bool isFormBorderStyleNone = false;
        private bool isFormBorderStyleChanged = false;
        public ReporteEmpleados(List<Empleado> lis)
        {
            lista = lis;
            InitializeComponent();
        }

        private void ReporteEmpleados_Load(object sender, EventArgs e)
        {
            label7.Text = "Alfredo Izquierdo";
            label8.Text = DateTime.Now.ToString();
            dataGridView1.DataSource = lista;
            //dataGridView1.Rows.Clear();
            //foreach (Empleado x in lista)
            //{
            //    if (x.EstadoEmpleado == "Activo")
            //    {
            //        //MessageBox.Show("Mens");
            //        dataGridView1.Rows.Add(1);
            //        dataGridView1.Rows.Add(x.IDEmpleado, x.Nombre, x.ApellidoPat, x.ApellidoMat, x.Correo, x.Telefono, x.RFC, x.Contraseña, x.Tipo);

            //    }
            //}
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
