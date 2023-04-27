using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_SIVAA
{
    public partial class PeriodoCitasPorVendedor : Form
    {
        public PeriodoCitasPorVendedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericDiaF.Value < numericDiaI.Value | numericMesF.Value < numericMesI.Value | numericAnoF.Value < numericAnoI.Value)
            {
                MessageBox.Show("La fecha final debe ser menor a la fecha final");
            }
            else
            {
                CitasPorVendedor citasPorVendedor = new CitasPorVendedor(cmbVendedor.Text,numericDiaI.Value.ToString(),numericMesI.Value.ToString(),numericAnoI.Value.ToString(),numericDiaF.Value.ToString(),numericMesF.Value.ToString(),numericAnoF.Value.ToString());
                
                citasPorVendedor.Show();
            }

        }

        private void PeriodoCitasPorVendedor_Load(object sender, EventArgs e)
        {
            cmbVendedor.Items.AddRange(ListadoTotal().ToArray());
            if (cbPeriodo.Text == "Dia")
            {
                numericMesF.Enabled = false;
                numericMesI.Enabled = false;
                numericAnoF.Enabled = false;
                numericAnoI.Enabled = false;
            }


           

        }

        public List<String> ListadoTotal()
        {
            string CdCnx2 = ConfigurationManager.ConnectionStrings["CnxSQL"].ToString();
            List<string> productos = new List<string>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx2))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla cliente
                string CdSql = "Select * from Empleado WHERE Tipo = 'Vendedor'";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        Empleado Pqte = new Empleado
                        {
                            IDEmpleado = Convert.ToString(Dr["IDEmpleado"]),
                            Nombre = Convert.ToString(Dr["Nombre"]),
                            ApellidoPat = Convert.ToString(Dr["ApellidoPaterno"]),
                            ApellidoMat = Convert.ToString(Dr["ApellidoMaterno"]),
                            RFC = Convert.ToString(Dr["RFC"]),
                            Correo = Convert.ToString(Dr["Correo"]),
                            Telefono = Convert.ToString(Dr["Telefono"]),
                            Contraseña = Convert.ToString(Dr["Contraseña"]),
                            Tipo = Convert.ToString(Dr["Tipo"])
                        };
                        productos.Add(Pqte.IDEmpleado.ToString());
                    }
                }
                Cnx.Close();
            }
            return productos;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbPeriodo.Text == "Dia")
            {
                numericDiaI.Enabled = true;
                numericDiaF.Enabled = true;
                numericMesF.Enabled = false;
                numericMesI.Enabled = false;
                numericAnoF.Enabled = false;
                numericAnoI.Enabled = false;
            }
            if (cbPeriodo.Text == "Mes")
            {
                numericMesF.Enabled = true;
                numericMesI.Enabled = true;
                numericAnoF.Enabled = false;
                numericAnoI.Enabled = false;
                numericDiaI.Enabled = false;
                numericDiaF.Enabled = false;
            }
            if (cbPeriodo.Text == "Año")
            {
                numericMesF.Enabled = false;
                numericMesI.Enabled = false;
                numericAnoF.Enabled = true;
                numericAnoI.Enabled = true;
                numericDiaI.Enabled = false;
                numericDiaF.Enabled = false;
            }
        }

        private void cbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPeriodo.Text == "Dia")
            {
                numericDiaI.Enabled = true;
                numericDiaF.Enabled = true;
                numericMesF.Enabled = false;
                numericMesI.Enabled = false;
                numericAnoF.Enabled = false;
                numericAnoI.Enabled = false;
            }
            if (cbPeriodo.Text == "Mes")
            {
                numericMesF.Enabled = true;
                numericMesI.Enabled = true;
                numericAnoF.Enabled = false;
                numericAnoI.Enabled = false;
                numericDiaI.Enabled = false;
                numericDiaF.Enabled = false;
            }
            if (cbPeriodo.Text == "Año")
            {
                numericMesF.Enabled = false;
                numericMesI.Enabled = false;
                numericAnoF.Enabled = true;
                numericAnoI.Enabled = true;
                numericDiaI.Enabled = false;
                numericDiaF.Enabled = false;
            }
        }

        //dia
       

    }
}
