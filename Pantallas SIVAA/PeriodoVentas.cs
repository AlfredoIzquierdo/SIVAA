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
    public partial class PeriodoVentas : Form
    {
        Empleado _pqt;
        public PeriodoVentas(Empleado pqt)
        {
            InitializeComponent();
            _pqt = pqt;
            DateTime today = DateTime.Today;
            int diaAct = today.Day;
            int mesAct = today.Month;
            int anoAct = today.Year;
            numericDiaI.Value = (decimal)diaAct;
            numericMesI.Value = (decimal)mesAct;
            numericAnoI.Value = (decimal)anoAct;
            numericDiaF.Value = (decimal)diaAct;
            numericMesF.Value = (decimal)mesAct;
            numericAnoF.Value = (decimal)anoAct;

            cbPeriodoVentas.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericDiaF.Value < numericDiaI.Value | numericMesF.Value < numericMesI.Value | numericAnoF.Value < numericAnoI.Value)
            {
                MessageBox.Show("Ingrese una fecha valida");
            }
            else
            {
                ReporteVentas reporteVentas = new ReporteVentas(_pqt, (int)numericDiaI.Value, (int)numericMesI.Value, (int)numericAnoI.Value, (int)numericDiaF.Value, (int)numericMesF.Value, (int)numericAnoF.Value, cbPeriodoVentas.Text);
                this.Close();
                reporteVentas.Show();
            }

        }

        private void PeriodoVentas_Load(object sender, EventArgs e)
        {
            if (cbPeriodoVentas.Text == "Dia")
            {
                numericMesF.Enabled = false;
                numericMesI.Enabled = false;
                numericAnoF.Enabled = false;
                numericAnoI.Enabled = false;
            }
        }

        private void cbPeriodoVeh_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbPeriodoVentas.Text == "Dia")
            {
                numericDiaI.Enabled = true;
                numericDiaF.Enabled = true;
                numericMesF.Enabled = false;
                numericMesI.Enabled = false;
                numericAnoF.Enabled = false;
                numericAnoI.Enabled = false;
            }
            if (cbPeriodoVentas.Text == "Mes")
            {
                numericMesF.Enabled = true;
                numericMesI.Enabled = true;
                numericAnoF.Enabled = false;
                numericAnoI.Enabled = false;
                numericDiaI.Enabled = false;
                numericDiaF.Enabled = false;
            }
            if (cbPeriodoVentas.Text == "Año")
            {
                numericMesF.Enabled = false;
                numericMesI.Enabled = false;
                numericAnoF.Enabled = true;
                numericAnoI.Enabled = true;
                numericDiaI.Enabled = false;
                numericDiaF.Enabled = false;
            }
        }
    }
}
