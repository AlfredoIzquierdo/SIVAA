using Entidades;
using Logicas;

namespace Pantallas_SIVAA
{
    public partial class ModificarCliente : Form
    {
        ClienteLog log = new ClienteLog();
        Cliente cliente = new Cliente();

        string id;

        Empleado _pqt;
        public ModificarCliente(string idCliente, Empleado pqt)
        {
            InitializeComponent();
            _pqt = pqt;
            id = idCliente;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cliente.IDCliente = id;
            cliente.Nombre = txtNombre.Text;
            cliente.ApellidoPat = txtApellidoP.Text;
            cliente.ApellidoMat = txtApellidoM.Text;
            cliente.Correo = txtCorreo.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.RFC = txtRFC.Text;
            cliente.NoExterior = txtNoExterior.Text;
            cliente.Colonia = txtColonia.Text;
            cliente.Estado = txtEstado.Text;
            cliente.Ciudad = txtCiudad.Text;

            log.Modificar(cliente);

            this.Hide();
            Clientes clientes = new Clientes(_pqt);
            clientes.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.inicio.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio.Pedidos.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio.Stock.Show();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio.CalendarioCitas.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio.Ventas.Show();
        }

        private void btnCobros_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio.Caja.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio.Reportes.Show();
        }


        private void ModificarCliente_Load(object sender, EventArgs e)
        {
            List<Cliente> cliente = log.ListadoAll();
            foreach (Cliente x in cliente)
            {
                if (x.IDCliente == id)
                {
                    txtNombre.Text = x.Nombre;
                    txtRFC.Text = x.RFC;
                    txtApellidoP.Text = x.ApellidoPat;
                    txtApellidoM.Text = x.ApellidoMat;
                    txtNoExterior.Text = x.NoExterior;
                    txtCiudad.Text = x.Ciudad;
                    txtCorreo.Text = x.Correo;
                    txtEstado.Text = x.Estado;
                    txtColonia.Text = x.Colonia;
                    txtTelefono.Text = x.Telefono;
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
