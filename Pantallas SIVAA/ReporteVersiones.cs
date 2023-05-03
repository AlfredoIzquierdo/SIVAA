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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;


namespace Pantallas_SIVAA
{
    public partial class ReporteVersiones : Form
    {
        List<VersionEntidad  > lista;
        private bool isFormBorderStyleNone = false;
        private bool isFormBorderStyleChanged = false;
        Empleado _pqt;
    
        public ReporteVersiones(List<VersionEntidad  > lisra,Empleado pqt)
        {
            lista = lisra;
            _pqt = pqt;
            InitializeComponent();
        }

        private void ReporteVersiones_Load(object sender, EventArgs e)
        {
            label7.Text = "Alfredo Izquierdo";
            label8.Text = DateTime.Now.ToString();
            dataGridView1.DataSource = lista;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(21000, 26001);
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = DateTime.Now.DayOfWeek.ToString().Trim()+ "Versiones.pdf";

            string paginahtml = Properties.Resources.plantilla.ToString();
            paginahtml = paginahtml.Replace("@TITULO", "REPORTE DE VERSIONES");
            paginahtml = paginahtml.Replace("@idempleado", _pqt.IDEmpleado);
            paginahtml = paginahtml.Replace("@nombreEmpleado", _pqt.Nombre.Trim() + " " + _pqt.ApellidoPat.Trim() + " " + _pqt.ApellidoMat.Trim());
            paginahtml = paginahtml.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
            paginahtml = paginahtml.Replace("@NUMEROFOLIO", numeroAleatorio.ToString());

            string filas = string.Empty;
            //cabecera

            //llenar tabla
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["IDVersion"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["IDVehiculo"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Llantas"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["TipoAsientos"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["CamaraTrasera"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["TipoCombustible"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Version"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Rines"].Value.ToString() + "</td>";
                filas += "</tr>";
               
            }
            paginahtml = paginahtml.Replace("@FILAS", filas);



            if (guardar.ShowDialog()== DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    //pdfDoc.Add(new Phrase(""));
                    using(StringReader sr= new StringReader(paginahtml)) 
                    
                    { 
                      XMLWorkerHelper.GetInstance().ParseXHtml(writer,pdfDoc,sr);
                    
                    }



                    pdfDoc.Close();
                    stream.Close();
                }
                

            }

            //pictureBox1.Hide();
            ////Guardar el estado original de la propiedad "BorderStyle"

            //isFormBorderStyleNone = this.FormBorderStyle == FormBorderStyle.None;
            //isFormBorderStyleChanged = true;
            //if (!isFormBorderStyleNone)
            //{
            //    this.FormBorderStyle = FormBorderStyle.None;
            //}

            //printDocument1.Print();
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
            //Bitmap bitmap = new Bitmap(this.Width, this.Height);
            //this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
            //e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
