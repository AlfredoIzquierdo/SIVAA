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
    public partial class ReporteEmpleados : Form
    {
        List<Empleado> lista;
        public ReporteEmpleados(List<Empleado> lis)
        {
            lista = lis;
            InitializeComponent();
        }

        private void ReporteEmpleados_Load(object sender, EventArgs e)
        {
            label7.Text = "Alfredo Izquierdo";
            label8.Text = DateTime.Now.ToString();
            dataGridView1.DataSource = lista;
            //dataGridView1.Rows.Clear();
            //foreach (Empleado x in lista)
            //{
            //    if (x.EstadoEmpleado == "Activo")
            //    {
            //        //MessageBox.Show("Mens");
            //        dataGridView1.Rows.Add(1);
            //        dataGridView1.Rows.Add(x.IDEmpleado, x.Nombre, x.ApellidoPat, x.ApellidoMat, x.Correo, x.Telefono, x.RFC, x.Contraseña, x.Tipo);

            //    }
            //}
        }
    }
}
