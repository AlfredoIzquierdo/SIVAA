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

    public partial class ReporteClientes : Form
    {
        List<Cliente> lista;
        public ReporteClientes(List<Cliente> list)
        {
            lista = list;
            InitializeComponent();
        }

        private void ReporteClientes_Load(object sender, EventArgs e)
        {
            label7.Text = "Alfredo Izquierdo";
            label8.Text = DateTime.Now.ToString();
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = lista;
        }
    }
}
