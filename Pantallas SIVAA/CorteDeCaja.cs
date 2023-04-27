using Entidades;
using Logicas;
using Pantallas_SIVAA.Pedidos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Pantallas_SIVAA
{

    public partial class CorteDeCaja : Form
    {
        public static CorteCajaLog PqteLog = new CorteCajaLog();

        public static ClienteLog PqteLog11 = new ClienteLog();
        public static VentaLog PqteLog1 = new VentaLog();
        public static VentaContadoLog PqteLog2 = new VentaContadoLog();
        public static VentaCreditoLog Pqtelog3 = new VentaCreditoLog();
        public static CotizacionLog Pqtelog4 = new CotizacionLog();
        public static CotizacionContadoLog Pqtelog5 = new CotizacionContadoLog();
        public static CotizacionCreditoLog Pqtelog6 = new CotizacionCreditoLog();

        public static PagoLog Pqtelog7 = new PagoLog();
        public static AbonoLog Pqtelog8 = new AbonoLog();
        public static CortePagoLog Pqtelog9 = new CortePagoLog();
        public static CorteAbonoLogcs Pqtelog10 = new CorteAbonoLogcs();


        //entidades
        Venta ven;
        // VentaContado ven2;
        VentaContado con;
        VentaCredito cre;
        CotizacionContado cotcon;
        CotizacionCredito cotcre;
        Cliente cli;
        CorteCaja corte;
        Empleado _pqt;
        readonly ClienteLog PqteLog5 = new ClienteLog();
        List<EstadoDeCuenta> lista; 

        string nombre, apellidoP, apellidoM, vehiculo, versions, id;
        public CorteDeCaja(Empleado pqt)
        {
            InitializeComponent();
            this._pqt = pqt;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(_pqt);
            this.Close();
            inicio.Show();
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

        private void CorteDeCaja_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Cargo");
            timer1.Enabled = true;
            string time = DateTime.Now.ToString("H:mm");
            TXTHORA.Text = time;
            textBox11.Text = time;
            string dia = DateTime.Now.ToString("dd");
            numericUpDown2.Value = int.Parse(dia);
            numericUpDown6.Value = int.Parse(dia);
            string mes = DateTime.Now.ToString("MM");
            numericUpDown3.Value = int.Parse(mes);
            numericUpDown5.Value = int.Parse(mes);
            string an = DateTime.Now.ToString("yyyy");
            numericUpDown4.Value = int.Parse(an);
            numericUpDown1.Value = int.Parse(an);
            panel9.Enabled = false;
            //CorteDeCaja_Load(sender, e);
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

            List<EstadoDeCuenta> clie = PqteLog5.Cuenta();
            lista = clie;
            foreach (EstadoDeCuenta x in clie)
            {
                dataGridView1.Rows.Add(x.IDCliente, x.Nombre, x.ApellidoPaterno, x.ApellidoMaterno, x.NombreV, x.Versions, x.IDVenta);
            }



        }



        private void numericUpDown15_ValueChanged(object sender, EventArgs e)
        {
            //Valoresiniciales();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox7.Enabled = true;
            }
            else
            {
                //if (radioButton2.Checked)
                //{
                textBox7.Enabled = false;
                textBox7.Text = "";
                //}
            }
        }
        Random rn = new Random();


        private void button3_Click(object sender, EventArgs e)
        {
            string voucher = "";
            voucher = textBox6.Text;
            if (voucher == "")
            {
                MessageBox.Show("Favor de escribir el voucher a pagar");
            }
            //ven = PqteLog1.LeerPorClave(voucher);
            con = PqteLog2.LeerPorClavevoucher(voucher);
            if (con != null)
            {
                //datos de la venta
                //con = PqteLog2.LeerPorClave(ven.IDVenta.ToString());
                ven = PqteLog1.LeerPorClave(voucher);
                //datos de la cotizacion
                cotcon = Pqtelog5.LeerPorClave(con.IDCotizacion.ToString());
                Entidades.Cotizacion cot = Pqtelog4.LeerPorClave(cotcon.IDCotizacion.ToString());
                textBox5.Text = cot.PrecioInicial.ToString();
                panel9.Enabled = true;
                //datos cliente
                cli = PqteLog11.LeerPorClave(cot.IDCliente.ToString());
                txtid.Text = cli.IDCliente.ToString();
                textBox9.Text = cli.Nombre.ToString();
                textBox8.Text = cli.ApellidoPat.ToString();

                ////datos corte de caja
                //CorteCaja
                corte = PqteLog.BuscarCajaAbierta();

            }
            else
            {
                MessageBox.Show("Voucher no encontrado");
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        Pago pqt;

        private void button1_Click(object sender, EventArgs e)
        {
            int k = rn.Next(100, 300);
            if (txtid.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Favor de escrbir un voucher");
                return;
            }
            if (radioButton2.Checked)
            {
                if (textBox7.Text == "")
                {
                    MessageBox.Show("Favor de escribir el monto a pagar");
                    return;
                }
            }
            else
            {

            }
            if (radioButton1.Checked || (double.Parse(textBox7.Text) >= double.Parse(textBox5.Text)))
            {
                try
                {
                    if (radioButton2.Checked)
                    {
                        pqt = new Pago
                        {
                            IDPago = Convert.ToString("PA0" + k),
                            IDVenta = Convert.ToString(con.IDVenta.ToString()),
                            IDEmpleado = Convert.ToString(corte.IDEmpleado),
                            Monto = Convert.ToDouble(textBox5.Text),
                            Dia = Convert.ToInt32(numericUpDown2.Value),
                            Mes = Convert.ToInt32(numericUpDown3.Value),
                            Año = Convert.ToInt32(numericUpDown4.Value),
                            FormaPago = Convert.ToString("EFECTIVO")
                        };
                    }
                    else
                    {
                        pqt = new Pago
                        {
                            IDPago = Convert.ToString("PA0" + k),
                            IDVenta = Convert.ToString(con.IDVenta.ToString()),
                            IDEmpleado = Convert.ToString(corte.IDEmpleado),
                            Monto = Convert.ToDouble(textBox5.Text),
                            Dia = Convert.ToInt32(numericUpDown2.Value),
                            Mes = Convert.ToInt32(numericUpDown3.Value),
                            Año = Convert.ToInt32(numericUpDown4.Value),
                            FormaPago = Convert.ToString("TARJETA")
                        };
                    }
                    Pqtelog7.Registrar(pqt);
                    //MessageBox.Show("paso pago");
                    if (Pqtelog7.Mensaje.Length != 0)
                    {
                        //Hubo un error
                        MessageBox.Show(Pqtelog7.Mensaje.ToString(), "Mensaje de Error");
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
                //corte pago
                if (Pqtelog7.Mensaje.Length != 0)
                {
                    return;
                    //Hubo un error
                    //MessageBox.Show(Pqtelog7.Mensaje.ToString(), "Mensaje de Error");
                }
                try
                {
                    CortePago pqt2 = new CortePago
                    {
                        IDPago = Convert.ToString(pqt.IDPago.ToString()),
                        IDCorteCaja = Convert.ToString(corte.IDCorteCaja.ToString()),
                    };
                    Pqtelog9.Registrar(pqt2);
                    //MessageBox.Show("paso corte pago");
                    if (Pqtelog9.Mensaje.Length != 0)
                    {
                        //Hubo un error
                        MessageBox.Show(Pqtelog9.Mensaje.ToString(), "Mensaje de Error");
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
                //modificacion de estatus de la venta
                if (Pqtelog9.Mensaje.Length != 0)
                {
                    return;
                    //Hubo un error
                    //MessageBox.Show(Pqtelog9.Mensaje.ToString(), "Mensaje de Error");
                }
                try
                {
                    //VentaContado pqt2 = new VentaContado
                    //{
                    //    IDPago = Convert.ToString(pqt.IDPago.ToString()),
                    //    IDCorteCaja = Convert.ToString(txtid.Text),
                    //};
                    //string est = "PAGADO";
                    string est = "FINALIZADO";
                    PqteLog2.ModificarEstatus(con.IDVenta, est);
                    //MessageBox.Show("paso estatus");
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
                MessageBox.Show("El pago no puede ser menor que el monto a pagar");
                return;
            }
            //MessageBox.Show("Pago efectuado");
            Ticket tic = new Ticket(pqt);
            tic.Show();

            Limpiar();
        }
        public void Limpiar()
        {
            txtid.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
        }
        public void Limpiar2()
        {
            //datoscliente
            textBox3.Text = "";
            textBox10.Text = "Nombre del cliente";
            textBox4.Text = "Apellido del cliente";
            //Auto
            textBox16.Text = "";
            textBox2.Text = "";
            textBox15.Text = "";
            //dinero
            textBox1.Text = "";
            textBox12.Text = "";
        }
        public void mostrarventasenganchecredito()
        {
            List<VentasEntrega> listado = PqteLog1.ListadoAllVentasEntregaCredito2();
            if (listado.Count > 0)
            {
                dataGridView6.AutoGenerateColumns = false;
                dataGridView6.DataSource = listado;
                dataGridView6.Columns["dataGridViewTextBoxColumn1"].DataPropertyName = "IDVenta";
                dataGridView6.Columns["dataGridViewTextBoxColumn2"].DataPropertyName = "Nombre";
                dataGridView6.Columns["dataGridViewTextBoxColumn3"].DataPropertyName = "ApellidoPaterno";
                dataGridView6.Columns["dataGridViewTextBoxColumn4"].DataPropertyName = "ApellidoMaterno";
                dataGridView6.Columns["dataGridViewTextBoxColumn5"].DataPropertyName = "Dia";
                dataGridView6.Columns["dataGridViewTextBoxColumn6"].DataPropertyName = "Mes";
                dataGridView6.Columns["Column37"].DataPropertyName = "Año";
                dataGridView6.Columns["Column44"].DataPropertyName = "Hora";
                dataGridView6.Columns["Column38"].DataPropertyName = "TipoVenta";
                dataGridView6.Columns["Column39"].DataPropertyName = "Vehiculo";
                dataGridView6.Columns["Column40"].DataPropertyName = "Version";
                dataGridView6.Columns["Column41"].DataPropertyName = "Cilindraje";
                dataGridView6.Columns["Column42"].DataPropertyName = "Transmision";
                dataGridView6.Columns["Column43"].DataPropertyName = "Modelo";
            }
            else
            {
                MessageBox.Show("No hay ventas a credito pendientes de abonos");
                dataGridView6.DataSource = "";
            }
            dataGridView6.ClearSelection();
        }
        public void mostrarventasengancheporcliente()
        {
            string nombre = textBox13.Text, apellido = textBox14.Text;
            if (nombre == "" || apellido == "")
            {
                MessageBox.Show("Favor de escribir el nombre y apellido del cliente para la busqueda");
                return;
            }
            List<VentasEntrega> listado = PqteLog1.ListaporclienteENGANCHES(nombre, apellido);
            if (listado.Count > 0)
            {
                dataGridView6.AutoGenerateColumns = false;
                dataGridView6.DataSource = listado;
                dataGridView6.Columns["dataGridViewTextBoxColumn1"].DataPropertyName = "IDVenta";
                dataGridView6.Columns["dataGridViewTextBoxColumn2"].DataPropertyName = "Nombre";
                dataGridView6.Columns["dataGridViewTextBoxColumn3"].DataPropertyName = "ApellidoPaterno";
                dataGridView6.Columns["dataGridViewTextBoxColumn4"].DataPropertyName = "ApellidoMaterno";
                dataGridView6.Columns["dataGridViewTextBoxColumn5"].DataPropertyName = "Dia";
                dataGridView6.Columns["dataGridViewTextBoxColumn6"].DataPropertyName = "Mes";
                dataGridView6.Columns["Column37"].DataPropertyName = "Año";
                dataGridView6.Columns["Column44"].DataPropertyName = "Hora";
                dataGridView6.Columns["Column38"].DataPropertyName = "TipoVenta";
                dataGridView6.Columns["Column39"].DataPropertyName = "Vehiculo";
                dataGridView6.Columns["Column40"].DataPropertyName = "Version";
                dataGridView6.Columns["Column41"].DataPropertyName = "Cilindraje";
                dataGridView6.Columns["Column42"].DataPropertyName = "Transmision";
                dataGridView6.Columns["Column43"].DataPropertyName = "Modelo";
            }
            else
            {
                MessageBox.Show(" para ese cliente");
                dataGridView6.DataSource = "";
            }
            dataGridView6.ClearSelection();
        }
        public void mostrarventasabonocredito()
        {
            List<VentasEntrega> listado = PqteLog1.ListadoAllVentasABONOCredito();
            if (listado.Count > 0)
            {
                dataGridView6.AutoGenerateColumns = false;
                dataGridView6.DataSource = listado;
                dataGridView6.Columns["dataGridViewTextBoxColumn1"].DataPropertyName = "IDVenta";
                dataGridView6.Columns["dataGridViewTextBoxColumn2"].DataPropertyName = "Nombre";
                dataGridView6.Columns["dataGridViewTextBoxColumn3"].DataPropertyName = "ApellidoPaterno";
                dataGridView6.Columns["dataGridViewTextBoxColumn4"].DataPropertyName = "ApellidoMaterno";
                dataGridView6.Columns["dataGridViewTextBoxColumn5"].DataPropertyName = "Dia";
                dataGridView6.Columns["dataGridViewTextBoxColumn6"].DataPropertyName = "Mes";
                dataGridView6.Columns["Column37"].DataPropertyName = "Año";
                dataGridView6.Columns["Column44"].DataPropertyName = "Hora";
                dataGridView6.Columns["Column38"].DataPropertyName = "TipoVenta";
                dataGridView6.Columns["Column39"].DataPropertyName = "Vehiculo";
                dataGridView6.Columns["Column40"].DataPropertyName = "Version";
                dataGridView6.Columns["Column41"].DataPropertyName = "Cilindraje";
                dataGridView6.Columns["Column42"].DataPropertyName = "Transmision";
                dataGridView6.Columns["Column43"].DataPropertyName = "Modelo";
            }
            else
            {
                MessageBox.Show("No hay ventas a credito pendientes de entregar autos");
                dataGridView6.DataSource = "";
            }
            dataGridView6.ClearSelection();
        }
        public void mostrarventasabonoporcliente()
        {
            string nombre = textBox13.Text, apellido = textBox14.Text;
            if (nombre == "" || apellido == "")
            {
                MessageBox.Show("Favor de escribir el nombre y apellido del cliente para la busqueda");
                return;
            }
            List<VentasEntrega> listado = PqteLog1.ListaporclienteABONOS(nombre, apellido);
            if (listado.Count > 0)
            {
                dataGridView6.AutoGenerateColumns = false;
                dataGridView6.DataSource = listado;
                dataGridView6.Columns["dataGridViewTextBoxColumn1"].DataPropertyName = "IDVenta";
                dataGridView6.Columns["dataGridViewTextBoxColumn2"].DataPropertyName = "Nombre";
                dataGridView6.Columns["dataGridViewTextBoxColumn3"].DataPropertyName = "ApellidoPaterno";
                dataGridView6.Columns["dataGridViewTextBoxColumn4"].DataPropertyName = "ApellidoMaterno";
                dataGridView6.Columns["dataGridViewTextBoxColumn5"].DataPropertyName = "Dia";
                dataGridView6.Columns["dataGridViewTextBoxColumn6"].DataPropertyName = "Mes";
                dataGridView6.Columns["Column37"].DataPropertyName = "Año";
                dataGridView6.Columns["Column44"].DataPropertyName = "Hora";
                dataGridView6.Columns["Column38"].DataPropertyName = "TipoVenta";
                dataGridView6.Columns["Column39"].DataPropertyName = "Vehiculo";
                dataGridView6.Columns["Column40"].DataPropertyName = "Version";
                dataGridView6.Columns["Column41"].DataPropertyName = "Cilindraje";
                dataGridView6.Columns["Column42"].DataPropertyName = "Transmision";
                dataGridView6.Columns["Column43"].DataPropertyName = "Modelo";
            }
            else
            {
                MessageBox.Show(" para ese cliente");
                dataGridView6.DataSource = "";
            }
            dataGridView6.ClearSelection();
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                mostrarventasenganchecredito();

            }
            if (radioButton6.Checked || radioButton7.Checked)
            {
                mostrarventasabonocredito();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                mostrarventasengancheporcliente();
            }
            if (radioButton6.Checked || radioButton7.Checked)
            {
                mostrarventasabonoporcliente();
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView6.DataSource = "";
        }
        Abono pqt3;

        private void button5_Click(object sender, EventArgs e)
        {
            double san = 0;
            double sac = 0;
            int k = rn.Next(100, 300);
            if (textBox12.Text == "")
            {
                textBox12.Text = "0";
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
                return;
                //textBox1.Text = "0";
            }
            if ((radioButton4.Checked) || (double.Parse(textBox12.Text) >= double.Parse(textBox1.Text)))
            {
                try
                {
                    cre = Pqtelog3.LeerPorClave(textBox3.Text);
                    corte = PqteLog.BuscarCajaAbierta();
                    Abono ab = Pqtelog8.BuscarSaldos(textBox3.Text);
                    //MessageBox.Show("id = "+ab.IDVenta+"\r\nsaldoAnt = "+ab.SaldoAnterior);
                    if (ab == null)
                    {
                        san = cre.TotalFinal;
                    }
                    else
                        san = ab.SaldoAnterior;
                    sac = san - double.Parse(textBox1.Text);
                    //enganche en efectivo o tarjeta
                    if (radioButton5.Checked && radioButton3.Checked)
                    {
                        pqt3 = new Abono
                        {
                            IDAbono = Convert.ToString("AB000" + k),
                            IDEmpleado = Convert.ToString(corte.IDEmpleado),
                            IDVenta = Convert.ToString(cre.IDVenta.ToString()),
                            SaldoActual = Convert.ToDouble(sac),
                            SaldoAnterior = Convert.ToDouble(san),
                            Monto = Convert.ToDouble(textBox1.Text),
                            Dia = Convert.ToInt32(numericUpDown2.Value),
                            Mes = Convert.ToInt32(numericUpDown3.Value),
                            Año = Convert.ToInt32(numericUpDown4.Value),
                            Tipo = Convert.ToString("ENGANCHE"),
                            FormaPago = Convert.ToString("EFECTIVO")
                        };
                    }
                    if (radioButton5.Checked && radioButton4.Checked)
                    {
                        pqt3 = new Abono
                        {
                            IDAbono = Convert.ToString("AB000" + k),
                            IDEmpleado = Convert.ToString(corte.IDEmpleado),
                            IDVenta = Convert.ToString(cre.IDVenta.ToString()),
                            SaldoActual = Convert.ToDouble(sac),
                            SaldoAnterior = Convert.ToDouble(san),
                            Monto = Convert.ToDouble(textBox1.Text),
                            Dia = Convert.ToInt32(numericUpDown2.Value),
                            Mes = Convert.ToInt32(numericUpDown3.Value),
                            Año = Convert.ToInt32(numericUpDown4.Value),
                            Tipo = Convert.ToString("ENGANCHE"),
                            FormaPago = Convert.ToString("TARJETA")
                        };
                    }
                    //mensualidad en efectivo o tarjeta
                    if (radioButton6.Checked && radioButton3.Checked)
                    {
                        pqt3 = new Abono
                        {
                            IDAbono = Convert.ToString("AB000" + k),
                            IDEmpleado = Convert.ToString(corte.IDEmpleado),
                            IDVenta = Convert.ToString(cre.IDVenta.ToString()),
                            SaldoActual = Convert.ToDouble(sac),
                            SaldoAnterior = Convert.ToDouble(san),
                            Monto = Convert.ToDouble(textBox1.Text),
                            Dia = Convert.ToInt32(numericUpDown2.Value),
                            Mes = Convert.ToInt32(numericUpDown3.Value),
                            Año = Convert.ToInt32(numericUpDown4.Value),
                            Tipo = Convert.ToString("MENSUALIDAD"),
                            FormaPago = Convert.ToString("EFECTIVO")
                        };
                    }
                    if (radioButton6.Checked && radioButton4.Checked)
                    {
                        pqt3 = new Abono
                        {
                            IDAbono = Convert.ToString("AB000" + k),
                            IDEmpleado = Convert.ToString(corte.IDEmpleado),
                            IDVenta = Convert.ToString(cre.IDVenta.ToString()),
                            SaldoActual = Convert.ToDouble(sac),
                            SaldoAnterior = Convert.ToDouble(san),
                            Monto = Convert.ToDouble(textBox1.Text),
                            Dia = Convert.ToInt32(numericUpDown2.Value),
                            Mes = Convert.ToInt32(numericUpDown3.Value),
                            Año = Convert.ToInt32(numericUpDown4.Value),
                            Tipo = Convert.ToString("MENSUALIDAD"),
                            FormaPago = Convert.ToString("TARJETA")
                        };
                    }
                    //anualidad en efectivo o tarjeta
                    if (radioButton7.Checked && radioButton3.Checked)
                    {
                        pqt3 = new Abono
                        {
                            IDAbono = Convert.ToString("AB000" + k),
                            IDEmpleado = Convert.ToString(corte.IDEmpleado),
                            IDVenta = Convert.ToString(cre.IDVenta.ToString()),
                            SaldoActual = Convert.ToDouble(sac),
                            SaldoAnterior = Convert.ToDouble(san),
                            Monto = Convert.ToDouble(textBox1.Text),
                            Dia = Convert.ToInt32(numericUpDown2.Value),
                            Mes = Convert.ToInt32(numericUpDown3.Value),
                            Año = Convert.ToInt32(numericUpDown4.Value),
                            Tipo = Convert.ToString("ANUALIDAD"),
                            FormaPago = Convert.ToString("EFECTIVO")
                        };
                    }
                    if (radioButton7.Checked && radioButton4.Checked)
                    {
                        pqt3 = new Abono
                        {
                            IDAbono = Convert.ToString("AB000" + k),
                            IDEmpleado = Convert.ToString(corte.IDEmpleado),
                            IDVenta = Convert.ToString(cre.IDVenta.ToString()),
                            SaldoActual = Convert.ToDouble(sac),
                            SaldoAnterior = Convert.ToDouble(san),
                            Monto = Convert.ToDouble(textBox1.Text),
                            Dia = Convert.ToInt32(numericUpDown2.Value),
                            Mes = Convert.ToInt32(numericUpDown3.Value),
                            Año = Convert.ToInt32(numericUpDown4.Value),
                            Tipo = Convert.ToString("ANUALIDAD"),
                            FormaPago = Convert.ToString("TARJETA")
                        };
                    }
                    Pqtelog8.Registrar(pqt3);
                    //MessageBox.Show("paso pago");
                    if (Pqtelog8.Mensaje.Length != 0)
                    {
                        //Hubo un error
                        MessageBox.Show(Pqtelog8.Mensaje.ToString(), "Mensaje de Error4");
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
                //corte pago
                if (Pqtelog8.Mensaje.Length != 0)
                {
                    return;
                    //Hubo un error
                    //MessageBox.Show(Pqtelog7.Mensaje.ToString(), "Mensaje de Error");
                }
                try
                {
                    CorteAbono pqt4 = new CorteAbono
                    {
                        IDAbono = Convert.ToString(pqt3.IDAbono.ToString()),
                        IDCorteCaja = Convert.ToString(corte.IDCorteCaja.ToString()),
                    };
                    Pqtelog10.Registrar(pqt4);
                    //MessageBox.Show("paso corte pago");
                    if (Pqtelog10.Mensaje.Length != 0)
                    {
                        //Hubo un error
                        MessageBox.Show(Pqtelog9.Mensaje.ToString(), "Mensaje de Error3");
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
                //modificacion de estatus de la venta
                if (Pqtelog10.Mensaje.Length != 0)
                {
                    return;
                    //Hubo un error
                    //MessageBox.Show(Pqtelog9.Mensaje.ToString(), "Mensaje de Error");
                }
                try
                {
                    //VentaContado pqt2 = new VentaContado
                    //{
                    //    IDPago = Convert.ToString(pqt.IDPago.ToString()),
                    //    IDCorteCaja = Convert.ToString(txtid.Text),
                    //};
                    string est = "";
                    if (radioButton5.Checked)
                    {
                        //est = "PAGADO";
                        est = "Activo";

                    }
                    if (radioButton6.Checked || radioButton7.Checked)
                    {
                        cre = Pqtelog3.LeerPorClave(textBox3.Text);
                        ven = PqteLog1.LeerPorClave(cre.IDVenta);
                        //if (ven.NoSerie != null)
                        //{
                            est = "Activo";
                        //}
                        //else
                        //    est = "PENDIENTE";
                    }
                    if (sac == 0 || sac < 1)
                    {
                        est = "FINALIZADO";
                    }
                    Pqtelog3.ModificarEstatus(cre.IDVenta, est);
                    //MessageBox.Show("paso estatus");
                    if (Pqtelog3.Mensaje.Length != 0)
                    {
                        //Hubo un error
                        MessageBox.Show(Pqtelog3.Mensaje.ToString(), "Mensaje de Error2");
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
                MessageBox.Show("El abono no puede ser menor que el monto a pagar");
                return;
            }
            //MessageBox.Show("abono efectuado");
            Ticket tic = new Ticket(pqt3);
            tic.Show();
            Limpiar2();
        }

        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView6.CurrentCell.RowIndex >= 0)
            {
                int i = dataGridView6.CurrentCell.RowIndex;
                //MessageBox.Show("Columna " + i);
                //Cliente
                textBox3.Text = dataGridView6[0, i].Value.ToString();
                textBox10.Text = dataGridView6[1, i].Value.ToString();
                textBox4.Text = dataGridView6[2, i].Value.ToString();

                //textBox11.Text = dataGridView6[8, i].Value.ToString();

                //Auto
                textBox16.Text = dataGridView6[9, i].Value.ToString();
                textBox2.Text = dataGridView6[13, i].Value.ToString();
                textBox15.Text = dataGridView6[10, i].Value.ToString();

                cre = Pqtelog3.LeerPorClave(textBox3.Text);
                cotcre = Pqtelog6.LeerPorClave(cre.IDCotizacion.ToString());
                if (radioButton5.Checked)
                {
                    textBox1.Text = cotcre.Enganche.ToString();

                }
                if (radioButton6.Checked)
                {
                    textBox1.Text = cotcre.Mensualidad.ToString();

                }
                if (radioButton7.Checked)
                {
                    textBox1.Text = cotcre.Anualidad.ToString();

                }
                //string idventa = textBox7.Text;
                //string tipoven = textBox11.Text;
                //mostrarUnidades(idventa, tipoven);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox12.Enabled = true;
            }
            else
            {
                //if (radioButton2.Checked)
                //{
                textBox12.Enabled = false;
                textBox12.Text = "";
                //}
            }
        }



        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (textBox7.Text.Length > 7)
            {
                e.Handled = true;
                //MessageBox.Show("Limite de caracteres exedido");
                string te = textBox7.Text.Substring(0, 7).ToString();
                textBox7.Text = te;
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (textBox12.Text.Length > 5)
            {
                e.Handled = true;
                //MessageBox.Show("Limite de caracteres exedido");
                string te = textBox12.Text.Substring(0, 5).ToString();
                textBox12.Text = te;
            }
        }


        private void EstadoCuenta_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
            nombre = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            apellidoP = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
            apellidoM = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
            vehiculo = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();
            versions = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString().Trim();
            id = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString().Trim();
        }

        private void btnEdoCuenta_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                EstadoCuenta estadoCuenta = new EstadoCuenta(nombre, apellidoP, apellidoM, vehiculo, versions, id);
                estadoCuenta.Show();
            }
            else
                MessageBox.Show("Seleccione un cliente");
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int opcion = comboBusqueda.SelectedIndex;
            string busqueda = comboBusqueda.Text;
            string texto = txtbusqueda.Text;
            if (opcion == 0)
            {
                dataGridView1.Rows.Clear();
                List<EstadoDeCuenta> clie = PqteLog5.Cuenta();
                lista = clie;
                foreach (EstadoDeCuenta x in clie)
                {
                    dataGridView1.Rows.Add(x.IDCliente, x.Nombre, x.ApellidoPaterno, x.ApellidoMaterno, x.NombreV, x.Versions, x.IDVenta);
                }
            }
            if (opcion == 1 || opcion == 2 || opcion == 3 || opcion == 4)
            {
                dataGridView1.Rows.Clear();
                List<EstadoDeCuenta> clie = PqteLog5.CuentaCliente(texto, busqueda);
                lista = clie;
                foreach (EstadoDeCuenta x in clie)
                {
                    dataGridView1.Rows.Add(x.IDCliente, x.Nombre, x.ApellidoPaterno, x.ApellidoMaterno, x.NombreV, x.Versions, x.IDVenta);
                }
            }
            if (opcion == 5)
            {
                dataGridView1.Rows.Clear();
                List<EstadoDeCuenta> clie = PqteLog5.CuentaVehiculo(texto);
                lista = clie;
                foreach (EstadoDeCuenta x in clie)
                {
                    dataGridView1.Rows.Add(x.IDCliente, x.Nombre, x.ApellidoPaterno, x.ApellidoMaterno, x.NombreV, x.Versions, x.IDVenta);
                }
            }
            if (opcion == 6)
            {
                dataGridView1.Rows.Clear();
                List<EstadoDeCuenta> clie = PqteLog5.CuentaVersion(texto);
                lista = clie;
                foreach (EstadoDeCuenta x in clie)
                {
                    dataGridView1.Rows.Add(x.IDCliente, x.Nombre, x.ApellidoPaterno, x.ApellidoMaterno, x.NombreV, x.Versions, x.IDVenta);
                }
            }
            if (opcion == 7)
            {
                dataGridView1.Rows.Clear();
                List<EstadoDeCuenta> clie = PqteLog5.CuentaVenta(texto);
                lista = clie;
                foreach (EstadoDeCuenta x in clie)
                {
                    dataGridView1.Rows.Add(x.IDCliente, x.Nombre, x.ApellidoPaterno, x.ApellidoMaterno, x.NombreV, x.Versions, x.IDVenta);
                }
            }
        }

        private void comboBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            if (comboBusqueda.SelectedIndex == 0)
                txtbusqueda.Enabled = false;
            else
                txtbusqueda.Enabled = true;
        }
    }
}

