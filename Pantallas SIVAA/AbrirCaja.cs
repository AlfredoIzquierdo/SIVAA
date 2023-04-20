using Datos;
using Entidades;
using Logicas;
using Pantallas_SIVAA.Pedidos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pantallas_SIVAA
{
    public partial class AbrirCaja : Form
    {

        Empleado _pqt;
        EmpleadoLog emplog = new EmpleadoLog();
        CorteCajaLog PqteLog2 = new CorteCajaLog();
        public AbrirCaja(Empleado pqt)
        {
            InitializeComponent();
            _pqt = pqt;
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

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(_pqt);
            this.Close();
            inicio.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            CorteDeCaja caja = new CorteDeCaja(_pqt);
            caja.Show();

        }

        private void AbrirCaja_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            string time = DateTime.Now.ToString("HH:mm");
            TXTHORA.Text = time;
            string dia = DateTime.Now.ToString("dd");
            numericUpDown13.Value = int.Parse(dia);
            string mes = DateTime.Now.ToString("MM");
            numericUpDown12.Value = int.Parse(mes);
            string an = DateTime.Now.ToString("yyyy");
            numericUpDown10.Value = int.Parse(an);
            CorteCaja cor = PqteLog2.BuscarCajaAbierta();
            if (cor != null)
            {
                //MessageBox.Show("Ya hay una caja abierta");
                label48.Text = "ACTIVA";
                btnAbrir.Enabled = false;
                btnIrCaja.Enabled = true;
                btnCerrar.Enabled = true;
            }
            else
            if (cor == null)
            {
                //MessageBox.Show("Aun no hay una caja abierta");
                label48.Text = "APAGADA";
                btnAbrir.Enabled = true;
                btnIrCaja.Enabled = false;
                btnCerrar.Enabled = false;
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

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Random rn = new Random();
            int k = rn.Next(100, 300);
            CorteCaja pqt; ;
            //VentaContado Deb;
            //VentaCredito Deb2;
            if (label55.Text == "")
            {
                label55.Text = "0";
            }
            if (double.Parse(label55.Text) > 0)
            {
                try
                {
                    pqt = new CorteCaja
                    {
                        IDCorteCaja = Convert.ToString("CC" + k),
                        IDEmpleado = Convert.ToString(txtid.Text),
                        Dia = Convert.ToInt32(numericUpDown13.Value),
                        Mes = Convert.ToInt32(numericUpDown12.Value),
                        Año = Convert.ToInt32(numericUpDown10.Value),
                        Hora = Convert.ToString(TXTHORA.Text),
                        FondoInicial = Convert.ToDouble(label55.Text),
                        EfectivoFinal = Convert.ToDouble("0"),
                        TarjetaFinal = Convert.ToDouble("0"),
                        TotalFinal = Convert.ToDouble("0"),
                        BalanceEfectivo = Convert.ToDouble("0"),
                        BalanceTarjeta = Convert.ToDouble("0"),
                        Estado = Convert.ToString("ACTIVA")

                    };
                    PqteLog2.Registrar(pqt);

                    if (PqteLog2.Mensaje.Length != 0)
                    {
                        //Hubo un error
                        MessageBox.Show(PqteLog2.Mensaje.ToString(), "Mensaje de Error");
                    }
                    else
                    {
                        //MessageBox.Show("Caja abierta con exito");
                        //Limpiar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Error {0}", ex.Message, "Error inesperado "));
                }
            }
            else
            {
                MessageBox.Show("Una caja no se puede abrir con tan poco dinero");
                return;
            }
            btnIrCaja.Enabled = true;
            btnAbrir.Enabled = false;
            btnCerrar.Enabled = true;
            label48.Text = "ACTIVA";
        }

        private void numericUpDown14_ValueChanged(object sender, EventArgs e)
        {
            double total = 0;
            double billetes = 0;
            //Billetes
            billetes += (((double)numericUpDown6.Value) * 20);
            billetes += (((double)numericUpDown5.Value) * 50);
            billetes += (((double)numericUpDown4.Value) * 100);
            billetes += (((double)numericUpDown3.Value) * 200);
            billetes += (((double)numericUpDown2.Value) * 500);
            billetes += (((double)numericUpDown1.Value) * 1000);
            label53.Text = billetes.ToString();
            double monedas = 0;
            //Monedas
            monedas += (((double)numericUpDown14.Value) * 10);
            monedas += (((double)numericUpDown17.Value) * 5);
            monedas += (((double)numericUpDown16.Value) * 2);
            monedas += (((double)numericUpDown15.Value) * 1);
            label54.Text = monedas.ToString();
            total = monedas + billetes;
            label55.Text = total.ToString();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            List<Empleado> listado = emplog.ListadoAllCajeros();


            if (listado.Count > 0)
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = listado;
                dataGridView1.Columns["Column1"].DataPropertyName = "Nombre";
                dataGridView1.Columns["Column2"].DataPropertyName = "ApellidoPat";
                dataGridView1.Columns["Column3"].DataPropertyName = "ApellidoMat";
                dataGridView1.Columns["Column4"].DataPropertyName = "Correo";
                dataGridView1.Columns["Column5"].DataPropertyName = "IDEmpleado";
            }
            else
            {
                MessageBox.Show("No hay registro de empleados que sean cajeros");
                return;
            }
            //mostrarcotizaciones();
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex >= 0)
            {
                int i = dataGridView1.CurrentCell.RowIndex;
                //MessageBox.Show("Columna " + i);
                txtid.Text = dataGridView1[0, i].Value.ToString();
                txtnom.Text = dataGridView1[1, i].Value.ToString();
                txtap.Text = dataGridView1[2, i].Value.ToString();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("HH:mm");
            TXTHORA.Text = time;
        }

        private void btnIrCaja_Click(object sender, EventArgs e)
        {
        CorteDeCaja corteDeCaja = new CorteDeCaja(_pqt);
        this.Close();
        corteDeCaja.Show();
        }
        public static PagoLog Pqtelog7 = new PagoLog();
        public static AbonoLog Pqtelog8 = new AbonoLog();
        public static CortePagoLog Pqtelog9 = new CortePagoLog();
        public static CorteAbonoLogcs Pqtelog10 = new CorteAbonoLogcs();

        double efeini, efefin;
        double balancefec = 0;
        double balancetar = 0;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (lbltotaltarjeta.Text == "" || label37.Text == "")
            {
                MessageBox.Show("Favor de llenar los campos requeridos");
                return;
            }
            efeini = double.Parse(label37.Text);
            efefin = double.Parse(lbltotaltarjeta.Text);
            //if (paefec == null || patar == null)
            //{
            //    balancefec = abonosefec + pagosefec;
            //    //san = cre.TotalFinal;
            //}
            //else
            //{
            //    balancefec = abonosefec + pagosefec;
            //}
            //Busqueda en efectivo de abono y pagos

            //Actualizacion del corte
            pqt = new CorteCaja
            {
                IDCorteCaja = Convert.ToString(pqte.IDCorteCaja.ToString()),
                IDEmpleado = Convert.ToString(pqte.IDEmpleado.ToString()),
                Dia = Convert.ToInt32(pqte.Dia),
                Mes = Convert.ToInt32(pqte.Mes),
                Año = Convert.ToInt32(pqte.Año),
                Hora = Convert.ToString(pqte.Hora),
                FondoInicial = Convert.ToDouble(pqte.FondoInicial),
                EfectivoFinal = Convert.ToDouble(efeini),
                TarjetaFinal = Convert.ToDouble(efefin),
                TotalFinal = Convert.ToDouble(efefin + efeini),
                BalanceEfectivo = Convert.ToDouble(balancefec),
                BalanceTarjeta = Convert.ToDouble(balancetar),
                Estado = Convert.ToString("FINALIZADO")

            };
            //PqteLog2.Registrar(pqt);
            PqteLog2.ModificarEstado(pqt);
            //MessageBox.Show("Cierre de caja exitoso");
            label48.Text = "APAGADA";
            btnCerrar.Enabled = false;
            btnIrCaja.Enabled = false;
            btnAbrir.Enabled = true;
            Limpiar();
        }
        CorteCaja pqte;
        CorteCaja pqt;
        private void tabPage4_Enter(object sender, EventArgs e)
        {


            pqte = PqteLog2.BuscarCajaAbierta();
            if (pqte != null)
            {
                btnCerrar.Enabled = true;
                //Busqueda en efectivo y tarjeta de abono
                Abono abefec = Pqtelog8.BuscarAbonosEfec(pqte.IDCorteCaja);
                Abono abtar = Pqtelog8.BuscarAbonosTar(pqte.IDCorteCaja);
                //Busqueda en efectivo y tarjeta de pagos
                Pago paefec = Pqtelog7.BuscarPAGOSEfec(pqte.IDCorteCaja);
                Pago patar = Pqtelog7.BuscarPAGOSTar(pqte.IDCorteCaja);
                //MessageBox.Show("id = "+ab.IDVenta+"\r\nsaldoAnt = "+ab.SaldoAnterior);
                double abonosefec = 0, abonostar = 0;
                double pagosefec = 0, pagostar = 0;

                if (abefec == null)
                {
                    abonosefec = 0;

                    //san = cre.TotalFinal;
                }
                else
                {
                    abonosefec = abefec.SaldoAnterior;
                }
                if (paefec == null)
                {
                    pagosefec = 0;

                    //san = cre.TotalFinal;
                }
                else
                {
                    pagosefec = paefec.Monto;
                }
                if (abtar == null)
                {
                    abonostar = 0;

                    //san = cre.TotalFinal;
                }
                else
                {
                    abonostar = abtar.SaldoAnterior;
                }
                if (patar == null)
                {
                    pagostar = 0;

                    //san = cre.TotalFinal;
                }
                else
                {
                    pagostar = patar.Monto;
                }
                balancefec = abonosefec + pagosefec;
                balancetar = abonostar + pagostar;
                textBox3.Text = balancefec.ToString();
                textBox4.Text = balancetar.ToString();
                //MessageBox.Show("abonos efectivo = " + abonosefec + "\r\nabonos tarjeta = " + abonostar + "\r\npagos efectivo = " + pagosefec + "\r\npagos tarjeta = " + pagostar);
                //MessageBox.Show("balande efectivo = " + balancefec + "\r\nbalance tarjeta = " + balancetar);
            }
        }

        private void panel4_Enter(object sender, EventArgs e)
        {
            CorteCaja cor = PqteLog2.BuscarCajaAbierta();
            if (cor != null)
            {
                //MessageBox.Show("Ya hay una caja abierta");
                btnAbrir.Enabled = false;
                btnIrCaja.Enabled = true;
                btnCerrar.Enabled = true;
            }
            else
            if (cor == null)
            {
                //MessageBox.Show("Aun no hay una caja abierta");
                btnAbrir.Enabled = true;
                btnIrCaja.Enabled = false;
                btnCerrar.Enabled = false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (textBox1.Text.Length > 5)
            {
                e.Handled = true;
                //MessageBox.Show("Limite de caracteres exedido");
                string te = textBox1.Text.Substring(0, 5).ToString();
                textBox1.Text = te;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (textBox2.Text.Length > 5)
            {
                e.Handled = true;
                //MessageBox.Show("Limite de caracteres exedido");
                string te = textBox2.Text.Substring(0, 5).ToString();
                textBox2.Text = te;
            }
        }

        private void numericUpDown21_ValueChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Error 404");
                return;
            }
            double total = 0;
            double billetes = 0;
            //Billetes
            billetes += (((double)numericUpDown23.Value) * 20);
            billetes += (((double)numericUpDown22.Value) * 50);
            billetes += (((double)numericUpDown21.Value) * 100);
            billetes += (((double)numericUpDown20.Value) * 200);
            billetes += (((double)numericUpDown19.Value) * 500);
            billetes += (((double)numericUpDown18.Value) * 1000);
            label42.Text = billetes.ToString();
            double monedas = 0;
            //Monedas
            monedas += (((double)numericUpDown7.Value) * 10);
            monedas += (((double)numericUpDown8.Value) * 5);
            monedas += (((double)numericUpDown9.Value) * 2);
            monedas += (((double)numericUpDown11.Value) * 1);
            label41.Text = monedas.ToString();
            total = monedas + billetes;
            label37.Text = total.ToString();

            double totalefec;
            totalefec = double.Parse(label37.Text);
            textBox3.Text = (balancefec - totalefec).ToString();
        }

        private void btnIngresarMonto_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Favor de ingresar un monto");
                return;
            }
            dataGridView2.Rows.Add(textBox2.Text);
            actualizartarjeta();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string id = null;
            if (dataGridView2.SelectedRows.Count == 1)
            {
                //id = dataGridView2[0, dataGridView2.SelectedRows[0].Index].Value.ToString();
                //MessageBox.Show("Empleado eliminado");
                dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
                actualizartarjeta();
            }
            else
            {
                MessageBox.Show("Favor de seleccionar un ingreso para eliminar");
            }
        }

        public void actualizartarjeta()
        {
            if (textBox4.Text != "")
            {
                //double tarjeta, totaltar=0;
                double totaltar = 0;
                //tarjeta= double.Parse(textBox4.Text);
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    totaltar += double.Parse(dataGridView2[0, i].Value.ToString());
                    //MessageBox.Show("total= " + totaltar);
                }
                textBox4.Text = (balancetar - totaltar).ToString();
                lbltotaltarjeta.Text = totaltar.ToString();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView2.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btnStock_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCobros_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCitas_Click_1(object sender, EventArgs e)
        {

        }

        private void btnReportes_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPedidos_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAbrir_Click_1(object sender, EventArgs e)
        {

        }

        private void btnIrCaja_Click_1(object sender, EventArgs e)
        {

        }

        private void btnIngresarMonto_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {

        }

        public void Limpiar()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label42.Text = "";
            label41.Text = "";
            label37.Text = "";
            lbltotaltarjeta.Text = "";
            dataGridView2.Rows.Clear();

            numericUpDown18.Value = 0;
            numericUpDown19.Value = 0;
            numericUpDown20.Value = 0;
            numericUpDown21.Value = 0;
            numericUpDown22.Value = 0;
            numericUpDown23.Value = 0;

            numericUpDown7.Value = 0;
            numericUpDown8.Value = 0;
            numericUpDown9.Value = 0;
            numericUpDown11.Value = 0;


        }
    }

}
