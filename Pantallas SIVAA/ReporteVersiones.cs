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
    public partial class ReporteVersiones : Form
    {
        List<Versions> lista;
        public ReporteVersiones(List<Versions> lisra)
        {
            lista = lisra;
            InitializeComponent();
        }

        private void ReporteVersiones_Load(object sender, EventArgs e)
        {
            label7.Text = "Alfredo Izquierdo";
            label8.Text = DateTime.Now.ToString();
            dataGridView1.DataSource = lista;
        }
    }
}
