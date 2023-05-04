using Datos;
using Entidades;
using Logicas;

namespace Pantallas_SIVAA
{

    public partial class Login : Form
    {
        private readonly EmpleadoLog PqteLog = new EmpleadoLog();

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Cd = "", Con = "";

            try
            {
                Con = textBox2.Text;
                Cd = textBox1.Text;
                Empleado pqt = PqteLog.LeerPorClave(Cd, Con);
                if (PqteLog.Mensaje.Length == 0)
                {
                    if (pqt.Tipo.Trim() == "Atencion")
                    {
                        //MessageBox.Show("Atencion a clientes");
                        Inicio AteInicio = new Inicio(pqt);
                        this.Hide();
                        AteInicio.Show();
                    }
                    else if (pqt.Tipo.Trim() == "Vendedor")
                    {
                        //MessageBox.Show("Vendedor");
                        Inicio VenInicio = new Inicio(pqt);
                        this.Hide();
                        VenInicio.Show();
                    }
                    else if (pqt.Tipo.Trim() == "Cajero")
                    {
                        //MessageBox.Show("Cajero");
                        AbrirCaja CajInicio = new AbrirCaja(pqt);
                        this.Hide();
                        CajInicio.Show();
                    }
                    else if (pqt.Tipo.Trim() == "Supervisor")
                    {
                        //MessageBox.Show("Supervisor");
                        Inicio SupInicio = new Inicio(pqt);
                        this.Hide();
                        SupInicio.Show();
                    }
                    //else
                    //MessageBox.Show("Inicio de sesion erroneo: "+ pqt.Tipo);
                }
                else
                    MessageBox.Show(PqteLog.Mensaje.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string Cd = "", Con = "";

            try
            {
                Con = textBox2.Text;
                Cd = textBox1.Text;
                Empleado pqt = PqteLog.LeerPorClave(Cd, Con);
                if (PqteLog.Mensaje.Length == 0)
                {
                    if (pqt.Tipo.Trim() == "Atencion")
                    {
                        //MessageBox.Show("Atencion a clientes");
                        Inicio AteInicio = new Inicio(pqt);
                        this.Close();
                        AteInicio.Show();
                    }
                    else if (pqt.Tipo.Trim() == "Vendedor")
                    {
                        //MessageBox.Show("Vendedor");
                        Inicio VenInicio = new Inicio(pqt);
                        this.Close();
                        VenInicio.Show();
                    }
                    else if (pqt.Tipo.Trim() == "Cajero")
                    {
                        //MessageBox.Show("Cajero");
                        AbrirCaja CajInicio = new AbrirCaja(pqt);
                        this.Close();
                        CajInicio.Show();
                    }
                    else if (pqt.Tipo.Trim() == "Supervisor")
                    {
                        //MessageBox.Show("Supervisor");
                        Inicio SupInicio = new Inicio(pqt);
                        this.Close();
                        SupInicio.Show();
                    }
                    //else
                    //MessageBox.Show("Inicio de sesion erroneo: "+ pqt.Tipo);
                }
                else
                    MessageBox.Show(PqteLog.Mensaje.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            ContraseñaOlvidada contra = new ContraseñaOlvidada();
            contra.Show();
            this.Hide();
        }

        
    }
}