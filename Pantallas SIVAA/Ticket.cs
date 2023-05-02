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
    public partial class Ticket : Form
    {
        private bool isFormBorderStyleNone = false;
        private bool isFormBorderStyleChanged = false;
        public Ticket(Pago pa)
        {
            InitializeComponent();
            LBLFECHA.Text = pa.Dia + "/" + pa.Mes + "/" + pa.Año;
            LBLHORA.Text = DateTime.Now.ToString("HH:mm");
            VentaContadoLog venco = new VentaContadoLog();
            VentaContado venc;
            venc = venco.LeerPorClave(pa.IDVenta);
            CotizacionContadoLog coco = new CotizacionContadoLog();
            CotizacionContado coc;
            coc = coco.LeerPorClave(venc.IDCotizacion);
            CotizacionLog cot = new CotizacionLog();
            Entidades.Cotizacion co;
            co = cot.LeerPorClave(coc.IDCotizacion);
            LBLIDCLIENTE.Text = co.IDCliente;
            LBLCONCEPTO.Text = "PAGO";
            LBLCANTIDAD.Text = "1";
            LBLIMPORTE.Text = pa.Monto.ToString();
            LBLTOTAL.Text = pa.Monto.ToString();
            LBLFORMAPAGO.Text = pa.FormaPago.ToString();
        }
        public Ticket(Abono pa)
        {
            InitializeComponent();
            LBLFECHA.Text = pa.Dia + "/" + pa.Mes + "/" + pa.Año;
            LBLHORA.Text = DateTime.Now.ToString("HH:mm");
            VentaCreditoLog venco = new VentaCreditoLog();
            VentaCredito venc;
            venc = venco.LeerPorClave(pa.IDVenta);
            CotizacionCreditoLog coco = new CotizacionCreditoLog();
            CotizacionCredito coc;
            coc = coco.LeerPorClave(venc.IDCotizacion);
            CotizacionLog cot = new CotizacionLog();
            Entidades.Cotizacion co;
            co = cot.LeerPorClave(coc.IDCotizacion);
            LBLIDCLIENTE.Text = co.IDCliente;
            LBLCONCEPTO.Text = pa.Tipo;
            LBLCANTIDAD.Text = "1";
            LBLIMPORTE.Text = pa.Monto.ToString();
            LBLTOTAL.Text = pa.Monto.ToString();
            lbltextosalac.Text = "SALDO ACTUAL";
            lblsaldoactual.Text = pa.SaldoActual.ToString();
            lbltexttosalant.Text = "SALDO ANTERIOR";
            lblsalant.Text = pa.SaldoAnterior.ToString();
            LBLFORMAPAGO.Text = pa.FormaPago.ToString();
        }
        private void Ticket_Load(object sender, EventArgs e)
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
