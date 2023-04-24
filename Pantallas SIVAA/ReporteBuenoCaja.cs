using Entidades;
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
    public partial class ReporteBuenoCaja : Form
    {
        public ReporteBuenoCaja(Entidades.CorteCaja caja, Empleado _pqt)
        {
            InitializeComponent();
            //caja
            lblfondoinicial.Text = caja.FondoInicial.ToString();
            lblefectivo3.Text = caja.BalanceEfectivo.ToString();
            lbltarjeta3.Text = caja.BalanceTarjeta.ToString();
            lblefectivo2.Text = caja.BalanceEfectivo.ToString();
            lbltotal.Text = (caja.BalanceEfectivo+caja.BalanceTarjeta).ToString();
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
    }
}
