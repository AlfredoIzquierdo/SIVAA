using Pantallas_SIVAA.Pedidos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logicas;
using Datos;
using Entidades;
using System.Configuration;
using System.Data.SqlClient;

namespace Pantallas_SIVAA
{
    public partial class Versiones : Form
    {
        public static AgregarVersion agregarVersion = new AgregarVersion(null);
        readonly VersionLog version = new VersionLog();
        Empleado _pqt;
        public Versiones(Empleado pqt)
        {
            InitializeComponent();
            _pqt = pqt;
        }



        private void pictureBox8_Click(object sender, EventArgs e)
        {
            AgregarVersion agregarVersion = new AgregarVersion(_pqt);
            this.Close();
            agregarVersion.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string id = null;
            if (dataGridView1.SelectedRows.Count == 1)
            {
                id = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();
                ModificarVersion modificarVehiculo = new ModificarVersion(id, _pqt);
                this.Hide();
                modificarVehiculo.Show();
            }
            else
            {
                MessageBox.Show("Favor de seleccionar una Version");
            }
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            this.Close();
            GestionarPedidos pedidos = new GestionarPedidos(_pqt);
            pedidos.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            this.Close();
            Inventario inventario = new Inventario(_pqt);
            inventario.Show();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            this.Close();
            CalendarioCitas citas = new CalendarioCitas(_pqt);
            citas.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.Close();
            Ventas ventas = new Ventas(_pqt);
            ventas.Show();
        }

        private void btnCobros_Click(object sender, EventArgs e)
        {
            this.Close();
            AbrirCaja Caja = new AbrirCaja(_pqt);
            Caja.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.Close();
            Reportes reportes = new Reportes(_pqt);
            reportes.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            string id = null;
            if (dataGridView1.SelectedRows.Count == 1)
            {
                id = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();
                version.Eliminar(id);
                MessageBox.Show("Version Eliminada");
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                dataGridView1.Rows.Clear();
                List<VersionEntidad> ve = version.ListadoTotal();
                listas = ve;
                foreach (VersionEntidad x in ve)
                {
                    if (x.EstadoVersion == "Activo")
                    {
                        dataGridView1.Rows.Add(x.IDVersion, x.IDVehiculo, x.Llantas, x.TipoAsientos, x.CamaraTrasera, x.Pantalla, x.TipoCombustible, x.Version, x.Rines, x.Cilindraje,
                   x.Costo, x.CapacidadCajuela, x.DistanciaEjes, x.Anchura, x.Altura, x.AudioVelC, x.TomaCorriente, x.TipoTraccion, x.NumPuertas, x.Transmision, x.FarosHal, x.NumEngranajes,
                   x.ACAutom, x.FarosLED, x.RendimientoCombustible, x.FrenosTraseros, x.FrenosDelanteros, x.SuspensionDelantera, x.SuspensionTrasera, x.EspejosLatDirC, x.EspejosLatAE);

                    }
                }
            }
            else
            {
                MessageBox.Show("Favor de seleccionar una version");
            }
        }

        private void Versiones_Load(object sender, EventArgs e)
        {
            //Versiones_Load(sender, e);
            dataGridView1.Rows.Clear();
            List<VersionEntidad> ve = version.ListadoTotal();
            listas = ve;
            foreach (VersionEntidad x in ve)
            {
                if (x.EstadoVersion == "Activo")
                {
                    dataGridView1.Rows.Add(x.IDVersion, x.IDVehiculo, x.Llantas, x.TipoAsientos, x.CamaraTrasera, x.Pantalla, x.TipoCombustible, x.Version, x.Rines, x.Cilindraje,
               x.Costo, x.CapacidadCajuela, x.DistanciaEjes, x.Anchura, x.Altura, x.AudioVelC, x.TomaCorriente, x.TipoTraccion, x.NumPuertas, x.Transmision, x.FarosHal, x.NumEngranajes,
               x.ACAutom, x.FarosLED, x.RendimientoCombustible, x.FrenosTraseros, x.FrenosDelanteros, x.SuspensionDelantera, x.SuspensionTrasera, x.EspejosLatDirC, x.EspejosLatAE);

                }

            }
            switch (_pqt.Tipo.Trim())
            {
                case "Atencion":
                    // Funciones activas: Citas e inventario
                    lblTipoEmpleado.Text = _pqt.Tipo + " a clientes";
                    lblNombre.Text = "Bienvenido: " + _pqt.Nombre + " " + _pqt.ApellidoPat;


                    // Menu lateral
                    btnCitas.Enabled = true;
                    btnStock.Enabled = true;
                    btnReportes.Enabled = false;
                    btnPedidos.Enabled = false;
                    btnVentas.Enabled = false;
                    btnCobros.Enabled = false;
                    break;
                case "Vendedor":
                    // Funciones activas: ventas, inventario y citas
                    lblTipoEmpleado.Text = _pqt.Tipo;
                    lblNombre.Text = "Bienvenido: " + _pqt.Nombre + " " + _pqt.ApellidoPat;


                    //Menu lateral
                    btnCitas.Enabled = true;
                    btnStock.Enabled = true;
                    btnReportes.Enabled = false;
                    btnPedidos.Enabled = false;
                    btnVentas.Enabled = true;
                    btnCobros.Enabled = false;
                    break;
                // más casos...
                case "Cajero":


                    // El cajero no pasa por aqui, se va directo al apartado de caja

                    break;
                case "Supervisor":
                    // Todo esta activado, es la vista de supervisor
                    lblTipoEmpleado.Text = _pqt.Tipo;
                    lblNombre.Text = "Bienvenido: " + _pqt.Nombre + " " + _pqt.ApellidoPat;
                    break;
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }
        //METODO LISTADO ESPECIFICO    
        public List<VersionEntidad> ListadoTotalEspecifico(string nom, string parametro)
        {
            string CdCnx = ConfigurationManager.ConnectionStrings["CnxSQL"].ToString();
            List<VersionEntidad> productos = new List<VersionEntidad>();

            //Vuelvo a crear la conexiÃ³n
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla VersionEntidad
                string CdSql = "SELECT * FROM Version WHERE " + parametro + "=@Cl";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Cmd.Parameters.AddWithValue("@Lc", parametro);
                    Cmd.Parameters.AddWithValue("@Cl", nom);

                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        VersionEntidad Pqte = new VersionEntidad
                        {
                            IDVersion = Convert.ToString(Dr["IDVersion"]),
                            IDVehiculo = Convert.ToString(Dr["IDvehiculo"]),
                            Llantas = Convert.ToString(Dr["LLantas"]),
                            TipoAsientos = Convert.ToString(Dr["TipoAsientos"]),
                            CamaraTrasera = Convert.ToString(Dr["CamaraTrasera"]),
                            Pantalla = Convert.ToString(Dr["Pantalla"]),
                            TipoCombustible = Convert.ToString(Dr["tipoCombustible"]),
                            Version = Convert.ToString(Dr["Version"]),
                            Rines = Convert.ToString(Dr["Rines"]),
                            Cilindraje = Convert.ToString(Dr["Cilindraje"]),
                            Costo = Convert.ToDouble(Dr["Costo"]),
                            CapacidadCajuela = Convert.ToString(Dr["Capacidadcajuela"]),
                            DistanciaEjes = Convert.ToString(Dr["DistanciaEjes"]),
                            Anchura = Convert.ToString(Dr["Anchura"]),
                            Altura = Convert.ToString(Dr["Altura"]),
                            AudioVelC = Convert.ToString(Dr["AudioVelC"]),
                            TomaCorriente = Convert.ToString(Dr["TomaCorriente"]),
                            TipoTraccion = Convert.ToString(Dr["TipoTraccion"]),
                            NumPuertas = Convert.ToString(Dr["NumPuertas"]),
                            Transmision = Convert.ToString(Dr["Transmision"]),
                            FarosHal = Convert.ToString(Dr["FarosHal"]),
                            NumEngranajes = Convert.ToString(Dr["NumEngranajes"]),
                            ACAutom = Convert.ToString(Dr["ACAutom"]),
                            FarosLED = Convert.ToString(Dr["FarosLED"]),
                            RendimientoCombustible = Convert.ToString(Dr["RendimientoCombustible"]),
                            FrenosTraseros = Convert.ToString(Dr["FrenosTraseros"]),
                            FrenosDelanteros = Convert.ToString(Dr["FrenosDelanteros"]),
                            SuspensionDelantera = Convert.ToString(Dr["SuspensionDelantera"]),
                            SuspensionTrasera = Convert.ToString(Dr["SuspensionTrasera"]),
                            EspejosLatDirC = Convert.ToString(Dr["EspejosLatDirC"]),
                            EspejosLatAE = Convert.ToString(Dr["EspejosLatAE"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }
        List<VersionEntidad> listas;
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbusqueda.Text))
            {
                MessageBox.Show("Llene el campo busqueda");
            }
            else
            {
                List<VersionEntidad> datos = new List<VersionEntidad>();
                datos = ListadoTotalEspecifico(txtbusqueda.Text, comboversion.Text);
                listas = datos;
                dataGridView1.Rows.Clear();
                foreach (VersionEntidad x in datos)
                {

                    dataGridView1.Rows.Add(x.IDVersion, x.IDVehiculo, x.Llantas, x.TipoAsientos, x.CamaraTrasera, x.Pantalla, x.TipoCombustible, x.Version, x.Rines, x.Cilindraje,
                    x.Costo, x.CapacidadCajuela, x.DistanciaEjes, x.Anchura, x.Altura, x.AudioVelC, x.TomaCorriente, x.TipoTraccion, x.NumPuertas, x.Transmision, x.FarosHal, x.NumEngranajes,
                    x.ACAutom, x.FarosLED, x.RendimientoCombustible, x.FrenosTraseros, x.FrenosDelanteros, x.SuspensionDelantera, x.SuspensionTrasera, x.EspejosLatDirC, x.EspejosLatAE);

                }

            }
        }

        private void comboversion_SelectedValueChanged(object sender, EventArgs e)
        {
            if (txtbusqueda.Text != "")
            {
                txtbusqueda.ResetText();
            }
            txtbusqueda.Enabled = true;
            if (comboversion.Text == "Todos")
            {
                txtbusqueda.Enabled = false;
                dataGridView1.Rows.Clear();
                List<VersionEntidad> ve = version.ListadoTotal();
                foreach (VersionEntidad x in ve)
                {
                    if (x.EstadoVersion == "Activo")
                    {
                        dataGridView1.Rows.Add(x.IDVersion, x.IDVehiculo, x.Llantas, x.TipoAsientos, x.CamaraTrasera, x.Pantalla, x.TipoCombustible, x.Version, x.Rines, x.Cilindraje,
                    x.Costo, x.CapacidadCajuela, x.DistanciaEjes, x.Anchura, x.Altura, x.AudioVelC, x.TomaCorriente, x.TipoTraccion, x.NumPuertas, x.Transmision, x.FarosHal, x.NumEngranajes,
                    x.ACAutom, x.FarosLED, x.RendimientoCombustible, x.FrenosTraseros, x.FrenosDelanteros, x.SuspensionDelantera, x.SuspensionTrasera, x.EspejosLatDirC, x.EspejosLatAE);

                    }

                }
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReporteVersiones rp = new ReporteVersiones(listas,_pqt);
            rp.Show();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }



        private void btnInicio_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(_pqt);
            this.Close();
            inicio.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
