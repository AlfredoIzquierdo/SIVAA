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
    public partial class FichaDePago : Form
    {
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
    }
}
