using Entidades;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
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

    public partial class ReporteClientes : Form
    {
        private bool isFormBorderStyleNone = false;
        private bool isFormBorderStyleChanged = false;
        List<Cliente> lista;
        Empleado _pqt;
        public ReporteClientes(List<Cliente> list,Empleado pqt)
        {
            _pqt = pqt;
            lista = list;
            InitializeComponent();
        }

        private void ReporteClientes_Load(object sender, EventArgs e)
        {
            label7.Text = _pqt.Nombre.Trim() + " " + _pqt.ApellidoPat.Trim() + " " + _pqt.ApellidoMat.Trim();
            label8.Text = DateTime.Now.ToString();
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = lista;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(21000, 26001);
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = numeroAleatorio.ToString()+"Cliente.pdf";

            string paginahtml = Properties.Resources.plantilla.ToString();
            paginahtml = paginahtml.Replace("@TITULO", "REPORTE DE CLIENTES");
            paginahtml = paginahtml.Replace("@idempleado", _pqt.IDEmpleado);
            paginahtml = paginahtml.Replace("@nombreEmpleado", _pqt.Nombre.Trim() + " " + _pqt.ApellidoPat.Trim() + " " + _pqt.ApellidoMat.Trim());
            paginahtml = paginahtml.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
            paginahtml = paginahtml.Replace("@NUMEROFOLIO", numeroAleatorio.ToString());

            string filas = string.Empty;
            string cabecera = string.Empty;
            //cabecera
            cabecera = "<th>" + "IDCliente" + "</th>" +
                      "<th>" + "Nombre" + "</th>" +
                      "<th>" + "ApellidoPat" + "</th>" +
                      "<th>" + "ApellidoMat" + "</th>" +
                      "<th>" + "RFC" + "</th>" +
                      "<th>" + "Correo" + "</th>" +
                      "<th>" + "Telefono" + "</th>" +
                      "<th>" + "No.Exterior" + "</th>" +
                      "<th>" + "Colonia" + "</th>" +
                      "<th>" + "Ciudad" + "</th>" +
                      "<th>" + "Estado" + "</th>" +
                      "<th>" + "EstadoCliente" + "</th>";

            paginahtml = paginahtml.Replace("@CABECERA", cabecera);
            //llenar tabla
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["IDCliente"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Nombre"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["ApellidoPat"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["ApellidoMat"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["RFC"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Correo"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Telefono"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["NoExterior"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Colonia"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Ciudad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Estado"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["EstadoCliente"].Value.ToString() + "</td>";

                filas += "</tr>";
                //break;
            }
            paginahtml = paginahtml.Replace("@FILAS", filas);



            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    //pdfDoc.Add(new Phrase(""));
                    using (StringReader sr = new StringReader(paginahtml))

                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);

                    }



                    pdfDoc.Close();
                    stream.Close();
                }


            }
            MessageBox.Show("Reporte guardado correctamente");


            //    pictureBox1.Hide();
            //    //Guardar el estado original de la propiedad "BorderStyle"
            //    isFormBorderStyleNone = this.FormBorderStyle == FormBorderStyle.None;
            //    isFormBorderStyleChanged = true;
            //    if (!isFormBorderStyleNone)
            //    {
            //        this.FormBorderStyle = FormBorderStyle.None;
            //    }

            //    printDocument1.Print();
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
            //this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
