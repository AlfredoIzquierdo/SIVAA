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
    public partial class PeriodoMejorCliente : Form
    {
        Empleado _pqt;
        public PeriodoMejorCliente(Empleado pqt)
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

            cbPeriodoClien.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(numericDiaF.Value<numericDiaI.Value | numericMesF.Value < numericMesI.Value| numericAnoF.Value < numericAnoI.Value)
            {
                MessageBox.Show("La fecha final debe ser menor a la fecha final");
            }else
            {
                ReporteMejoresClientes mejorclien = new ReporteMejoresClientes(_pqt, (int)numericDiaI.Value, (int)numericMesI.Value, (int)numericAnoI.Value, (int)numericDiaF.Value, (int)numericMesF.Value, (int)numericAnoF.Value,cbPeriodoClien.Text);
                this.Close();
                mejorclien.Show();
            }
            

        }

        private void PeriodoMejorCliente_Load(object sender, EventArgs e)
        {
            if (cbPeriodoClien.Text == "Dia")
            {
                numericMesF.Enabled = false;
                numericMesI.Enabled = false;
                numericAnoF.Enabled = false;
                numericAnoI.Enabled = false;
            }
           
        }

        private void numericMesI_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void cbPeriodoClien_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbPeriodoClien.Text == "Dia")
            {
                numericDiaI.Enabled = true;
                numericDiaF.Enabled = true;
                numericMesF.Enabled = false;
                numericMesI.Enabled = false;
                numericAnoF.Enabled = false;
                numericAnoI.Enabled = false;
            }
            if (cbPeriodoClien.Text == "Mes")
            {
                numericMesF.Enabled = true;
                numericMesI.Enabled = true;
                numericAnoF.Enabled = false;
                numericAnoI.Enabled = false;
                numericDiaI.Enabled = false;
                numericDiaF.Enabled = false;
            }
            if (cbPeriodoClien.Text == "Año")
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
