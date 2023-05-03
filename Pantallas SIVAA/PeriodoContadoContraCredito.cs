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
    public partial class PeriodoContadoContraCredito : Form
    {
        Empleado pqt;
        public PeriodoContadoContraCredito(Empleado _pqt)
        {
            InitializeComponent();
            pqt = _pqt;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    ReporteContadoContraCredito reporteContadoContraCredito = new ReporteContadoContraCredito();
        //    reporteContadoContraCredito.Show();
        //    this.Close();
        //}

        private void PeriodoContadoContraCredito_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                return;
            }
            //ReporteVentaContado rep = new ReporteVentaContado(pqt, comboBox1.SelectedItem.ToString());
            if (comboBox1.SelectedItem.ToString() == "Dia")
            {
                Pantallas_SIVAA.ReporteContadoContraCredito rep = new Pantallas_SIVAA.ReporteContadoContraCredito(pqt, "Dia", (int)(nddia.Value), (int)(ndmes.Value), (int)(ndan.Value));
                this.Close();
                rep.Show();
            }
            if (comboBox1.SelectedItem.ToString() == "Semana")
            {
                Pantallas_SIVAA.ReporteContadoContraCredito rep = new Pantallas_SIVAA.ReporteContadoContraCredito(pqt, "Semana", (int)(nddia.Value), (int)(ndmes.Value), (int)(ndan.Value));
                this.Close();
                rep.Show();
            }
            if (comboBox1.SelectedItem.ToString() == "Mes")
            {
                Pantallas_SIVAA.ReporteContadoContraCredito rep = new Pantallas_SIVAA.ReporteContadoContraCredito(pqt, "Mes", (int)(0), (int)(ndmes.Value), (int)(ndan.Value));
                this.Close();
                rep.Show();
            }
            if (comboBox1.SelectedItem.ToString() == "Anual")
            {
                Pantallas_SIVAA.ReporteContadoContraCredito rep = new Pantallas_SIVAA.ReporteContadoContraCredito(pqt, "Anual", (int)(0), (int)(0), (int)(ndan.Value));
                this.Close();
                rep.Show();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nddia.Enabled = false;
            ndmes.Enabled = false;
            ndan.Enabled = false;
            nddia2.Enabled = false;
            nddia.Value = 1;
            ndmes.Value = 1;
            ndan.Value = 2023;
            nddia2.Value = 1;
            if (comboBox1.SelectedItem.ToString() == "Dia")
            {
                nddia.Enabled = true;
                ndmes.Enabled = true;
                ndan.Enabled = true;
            }
            if (comboBox1.SelectedItem.ToString() == "Semana")
            {
                nddia.Enabled = true;
                ndmes.Enabled = true;
                ndan.Enabled = true;
                //nddia2.Enabled = true;
            }
            if (comboBox1.SelectedItem.ToString() == "Mes")
            {
                ndmes.Enabled = true;
                ndan.Enabled = true;
            }
            if (comboBox1.SelectedItem.ToString() == "Anual")
            {
                ndan.Enabled = true;
            }
        }

        private void nddia_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Semana")
            {
                if (nddia.Value > 24)
                {
                    nddia.Value = 24;
                    nddia2.Value = 31;
                }
                else
                    nddia2.Value = nddia.Value + 7;
            }
                //nddia2.Value = nddia.Value + 7;
        }
    }
}
