using Entidades;
using Logicas;
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
    public partial class Ticket : Form
    {
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
    }
}
