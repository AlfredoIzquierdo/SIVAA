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
    public partial class CitasPorVendedor : Form
    {
        string IdEmp; string diaI; string mesI; string anioI; string diaF; string mesF; string anioF;
        public CitasPorVendedor(string IdEmp, string diaI, string mesI, string anioI, string diaF, string mesF, string anioF)
        {
            InitializeComponent();
            this.IdEmp = IdEmp;
            this.diaI = diaI;
            this.mesI = mesI;
            this.anioI = anioI;
            this.anioF = anioF;
            this.diaF = diaF;
            this.mesF = mesF;
            this.anioF = anioF;
            

        }

        private void CitasPorVendedor_Load(object sender, EventArgs e)
        {
            List<Cita> citas = ObtenerPdtoxFecha(IdEmp, diaI, mesI, anioI, diaF, mesF, anioF);
        }
        public List<Cita> ObtenerPdtoxFecha(string IdEmp, string diaI, string mesI, string anioI, string diaF, string mesF, string anioF)
        {
            List<Cita> productos = new List<Cita>();
            //Using que crea la conexión
            string CdCnx = ConfigurationManager.ConnectionStrings["CnxSQL"].ToString();

            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                //Abro la conexión y creo el Query insertar, eliminar, consultar, elminar, actualizar, consulta individaul, general, orrar todo
                Cnx.Open();
                string CdSql = "SELECT *\r\nFROM CITA\r\n" +
                    "WHERE Dia BETWEEN @Di AND @Df" +
                    "\r\n  AND Mes BETWEEN @Mi AND @Mf" +
                    "\r\n  AND Año BETWEEN @Ai AND @Af\r\n " +
                    " AND EstadoCita = 'Activo'" +
                    "AND IDEmpleado =@Cl";
                //Using que crea el comando que voy a ejecutar con relación al query que planeteo
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    Cmd.Parameters.AddWithValue("@Cl", IdEmp);
                    Cmd.Parameters.AddWithValue("@Di", diaI);
                    Cmd.Parameters.AddWithValue("@Mi", mesI);
                    Cmd.Parameters.AddWithValue("@Ai", anioF);
                    Cmd.Parameters.AddWithValue("@Df", diaF);
                    Cmd.Parameters.AddWithValue("@Mf", mesF);
                    Cmd.Parameters.AddWithValue("@Af", anioF);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    if (Dr.Read())
                    {
                        Cita Pqte = new Cita
                        {
                            IDCita = Convert.ToString(Dr["IDCita"]),
                            IDEmpleado = Convert.ToString(Dr["IDEmpleado"]),
                            IDCliente = Convert.ToString(Dr["IDCliente"]),
                            Dia = Convert.ToInt32(Dr["Dia"]),
                            Mes = Convert.ToInt32(Dr["Mes"]),
                            Año = Convert.ToInt32(Dr["Año"]),
                            Hora = Convert.ToString(Dr["Hora"]),
                            EstadoCita = Convert.ToString(Dr["EstadoCita"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }
    }
}
