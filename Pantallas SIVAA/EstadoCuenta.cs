using Datos;
using Entidades;
using Logicas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_SIVAA
{
    public partial class EstadoCuenta : Form
    {

        readonly AbonoLog cuentas = new AbonoLog();
        string IDVenta;
        public EstadoCuenta(string Nombre,string apellidoP,string ApellidoM,string vehiculo, string versions, string idVenta)
        {
            InitializeComponent();
            lblCliente.Text = Nombre+" "+apellidoP+" "+ApellidoM;
            lblVehiculo.Text = vehiculo+" "+versions;
            lblFecha.Text= DateTime.Now.ToString("D");
            IDVenta = idVenta;

        }

        private void EstadoCuenta_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            List<Abono> clie = cuentas.ListadoEspecificp(IDVenta);
            foreach (Abono x in clie)
            {
                dataGridView1.Rows.Add(x.IDAbono, x.SaldoAnterior, x.SaldoActual, x.Monto, x.Dia, x.Mes, x.Año, x.Tipo, x.FormaPago);
            }
        }
    }
}
