using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logicas;
using Datos;
using System.Configuration;
using System.Data.SqlClient;

namespace Pantallas_SIVAA
{
    public partial class ModificarCita : Form
    {
        string _idCita;
        Cita cita = new Cita();
        Empleado _pqt;
        public ModificarCita(string idCita, Empleado pqt)
        {
            InitializeComponent();
            _idCita = idCita;
            _pqt = pqt;
        }
        public List<String> ListadoTotal()
        {
            string CdCnx = ConfigurationManager.ConnectionStrings["CnxSQL"].ToString();
            List<string> productos = new List<string>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
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
        private void ModificarCita_Load(object sender, EventArgs e)
        {
            CitaD citaD = new CitaD();
            citaD.ObtenerPdto(_idCita);
            cmbVendedor.Items.AddRange(ListadoTotal().ToArray());
            
            
            CitaLog log = new CitaLog();
            List<Cita> ver = citaD.ListadoTotal();
            foreach (Cita x in ver)
            {
                if (x.IDCita == _idCita)
                {
                    lblAño.Text = x.Año.ToString();
                    lblDia.Text = x.Dia.ToString();
                    lblMes.Text = x.Mes.ToString();
                    txtHora.Text = x.Hora.ToString();
                    cmbVendedor.Text = x.IDEmpleado.ToString();
                }
            }
        }
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            int dia = monthCalendar1.SelectionRange.Start.Day;
            int mes = monthCalendar1.SelectionRange.Start.Month;
            int año = monthCalendar1.SelectionRange.Start.Year;
            lblDia.Text = monthCalendar1.SelectionRange.Start.Day.ToString();
            lblMes.Text = monthCalendar1.SelectionRange.Start.Month.ToString();
            lblAño.Text = monthCalendar1.SelectionRange.Start.Year.ToString();
        }

        private void btnAgregarCita_Click(object sender, EventArgs e)
        {
            CitaLog log = new CitaLog();
           cita.Año= Convert.ToInt32( lblAño.Text);
           cita.Dia = Convert.ToInt32( lblDia.Text);
           cita.Mes = Convert.ToInt32 ( lblMes.Text);
           cita.Hora =  txtHora.Text;
           cita.IDEmpleado= cmbVendedor.Text;
            cita.IDCita = lblIDCliente.Text;
            log.Modificar(cita);
            CalendarioCitas citaas = new CalendarioCitas(_pqt);
            this.Close();
            citaas.Show();
        }
    }
}
