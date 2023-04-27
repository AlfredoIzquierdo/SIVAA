namespace Pantallas_SIVAA
{
    partial class ModificarCita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarCita));
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            panel1 = new Panel();
            btnReportes = new Button();
            btnCobros = new Button();
            btnVentas = new Button();
            btnCitas = new Button();
            btnStock = new Button();
            btnPedidos = new Button();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            pictureBox13 = new PictureBox();
            label7 = new Label();
            lblNombre = new Label();
            lblTipoEmpleado = new Label();
            label1 = new Label();
            label2 = new Label();
            panel7 = new Panel();
            label9 = new Label();
            btnAgregarCita = new Button();
            lblAño = new Label();
            lblMes = new Label();
            lblDia = new Label();
            lblVendedor = new Label();
            label10 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnRegresar = new Button();
            lblHora = new Label();
            dateTimePicker1 = new DateTimePicker();
            label14 = new Label();
            lblCliente = new Label();
            panel4 = new Panel();
            dataGridView2 = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            btnBuscarEmpleado = new Button();
            label15 = new Label();
            txtBuscarEmpleado = new TextBox();
            cmbEmpleado = new ComboBox();
            lblNombreCliente = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Auto.png");
            imageList1.Images.SetKeyName(1, "Cli.png");
            imageList1.Images.SetKeyName(2, "EMP.png");
            imageList1.Images.SetKeyName(3, "Prov.png");
            imageList1.Images.SetKeyName(4, "Tipos.png");
            imageList1.Images.SetKeyName(5, "Cot.png");
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth8Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "archive.png");
            imageList2.Images.SetKeyName(1, "bar-chart.png");
            imageList2.Images.SetKeyName(2, "book-open.png");
            imageList2.Images.SetKeyName(3, "calendar.png");
            imageList2.Images.SetKeyName(4, "dollar-sign.png");
            imageList2.Images.SetKeyName(5, "package.png");
            imageList2.Images.SetKeyName(6, "shopping-cart.png");
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(82, 101, 143);
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(btnCobros);
            panel1.Controls.Add(btnVentas);
            panel1.Controls.Add(btnCitas);
            panel1.Controls.Add(btnStock);
            panel1.Controls.Add(btnPedidos);
            panel1.Location = new Point(-130, 60);
            panel1.Margin = new Padding(1, 2, 1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(66, 406);
            panel1.TabIndex = 38;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(82, 101, 143);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.ForeColor = Color.White;
            btnReportes.ImageAlign = ContentAlignment.TopCenter;
            btnReportes.ImageKey = "bar-chart.png";
            btnReportes.ImageList = imageList2;
            btnReportes.Location = new Point(0, 288);
            btnReportes.Margin = new Padding(1, 2, 1, 2);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(71, 57);
            btnReportes.TabIndex = 10;
            btnReportes.Text = "Reportes";
            btnReportes.TextImageRelation = TextImageRelation.ImageAboveText;
            btnReportes.UseVisualStyleBackColor = false;
            // 
            // btnCobros
            // 
            btnCobros.BackColor = Color.FromArgb(82, 101, 143);
            btnCobros.FlatStyle = FlatStyle.Flat;
            btnCobros.ForeColor = Color.White;
            btnCobros.ImageAlign = ContentAlignment.TopCenter;
            btnCobros.ImageKey = "dollar-sign.png";
            btnCobros.ImageList = imageList2;
            btnCobros.Location = new Point(0, 230);
            btnCobros.Margin = new Padding(1, 2, 1, 2);
            btnCobros.Name = "btnCobros";
            btnCobros.Size = new Size(71, 57);
            btnCobros.TabIndex = 9;
            btnCobros.Text = "Cobros";
            btnCobros.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCobros.UseVisualStyleBackColor = false;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(82, 101, 143);
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.ForeColor = Color.White;
            btnVentas.ImageAlign = ContentAlignment.TopCenter;
            btnVentas.ImageKey = "shopping-cart.png";
            btnVentas.ImageList = imageList2;
            btnVentas.Location = new Point(0, 172);
            btnVentas.Margin = new Padding(1, 2, 1, 2);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(71, 57);
            btnVentas.TabIndex = 8;
            btnVentas.Text = "Ventas";
            btnVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            btnVentas.UseVisualStyleBackColor = false;
            // 
            // btnCitas
            // 
            btnCitas.BackColor = Color.FromArgb(82, 101, 143);
            btnCitas.FlatStyle = FlatStyle.Flat;
            btnCitas.ForeColor = Color.White;
            btnCitas.ImageAlign = ContentAlignment.TopCenter;
            btnCitas.ImageKey = "calendar.png";
            btnCitas.ImageList = imageList2;
            btnCitas.Location = new Point(0, 116);
            btnCitas.Margin = new Padding(1, 2, 1, 2);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(71, 57);
            btnCitas.TabIndex = 7;
            btnCitas.Text = "Citas";
            btnCitas.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCitas.UseVisualStyleBackColor = false;
            // 
            // btnStock
            // 
            btnStock.BackColor = Color.FromArgb(82, 101, 143);
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.ForeColor = Color.White;
            btnStock.ImageAlign = ContentAlignment.TopCenter;
            btnStock.ImageKey = "book-open.png";
            btnStock.ImageList = imageList2;
            btnStock.Location = new Point(-14, 57);
            btnStock.Margin = new Padding(1, 2, 1, 2);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(99, 64);
            btnStock.TabIndex = 6;
            btnStock.Text = "Inventario";
            btnStock.TextImageRelation = TextImageRelation.ImageAboveText;
            btnStock.UseVisualStyleBackColor = false;
            // 
            // btnPedidos
            // 
            btnPedidos.BackColor = Color.FromArgb(82, 101, 143);
            btnPedidos.FlatStyle = FlatStyle.Flat;
            btnPedidos.ForeColor = Color.White;
            btnPedidos.ImageAlign = ContentAlignment.TopCenter;
            btnPedidos.ImageKey = "package.png";
            btnPedidos.ImageList = imageList2;
            btnPedidos.Location = new Point(0, 2);
            btnPedidos.Margin = new Padding(1, 2, 1, 2);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(71, 57);
            btnPedidos.TabIndex = 5;
            btnPedidos.Text = "Pedidos";
            btnPedidos.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPedidos.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.FromArgb(82, 101, 143);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button6);
            panel2.Location = new Point(0, 59);
            panel2.Margin = new Padding(1, 2, 1, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(66, 417);
            panel2.TabIndex = 41;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(82, 101, 143);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.ImageKey = "bar-chart.png";
            button1.ImageList = imageList2;
            button1.Location = new Point(420, 288);
            button1.Margin = new Padding(1, 2, 1, 2);
            button1.Name = "button1";
            button1.Size = new Size(71, 57);
            button1.TabIndex = 10;
            button1.Text = "Reportes";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(82, 101, 143);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.ImageKey = "dollar-sign.png";
            button2.ImageList = imageList2;
            button2.Location = new Point(0, 230);
            button2.Margin = new Padding(1, 2, 1, 2);
            button2.Name = "button2";
            button2.Size = new Size(71, 57);
            button2.TabIndex = 9;
            button2.Text = "Cobros";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(82, 101, 143);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.ImageKey = "shopping-cart.png";
            button3.ImageList = imageList2;
            button3.Location = new Point(0, 172);
            button3.Margin = new Padding(1, 2, 1, 2);
            button3.Name = "button3";
            button3.Size = new Size(71, 57);
            button3.TabIndex = 8;
            button3.Text = "Ventas";
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(82, 101, 143);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.ImageKey = "calendar.png";
            button4.ImageList = imageList2;
            button4.Location = new Point(0, 116);
            button4.Margin = new Padding(1, 2, 1, 2);
            button4.Name = "button4";
            button4.Size = new Size(71, 57);
            button4.TabIndex = 7;
            button4.Text = "Citas";
            button4.TextImageRelation = TextImageRelation.ImageAboveText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(82, 101, 143);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.ImageKey = "book-open.png";
            button5.ImageList = imageList2;
            button5.Location = new Point(-14, 57);
            button5.Margin = new Padding(1, 2, 1, 2);
            button5.Name = "button5";
            button5.Size = new Size(99, 64);
            button5.TabIndex = 6;
            button5.Text = "Inventario";
            button5.TextImageRelation = TextImageRelation.ImageAboveText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(82, 101, 143);
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.ImageAlign = ContentAlignment.TopCenter;
            button6.ImageKey = "package.png";
            button6.ImageList = imageList2;
            button6.Location = new Point(0, 2);
            button6.Margin = new Padding(1, 2, 1, 2);
            button6.Name = "button6";
            button6.Size = new Size(71, 57);
            button6.TabIndex = 5;
            button6.Text = "Pedidos";
            button6.TextImageRelation = TextImageRelation.ImageAboveText;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(15, 7);
            pictureBox13.Margin = new Padding(1, 2, 1, 2);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(46, 40);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 2;
            pictureBox13.TabStop = false;
            pictureBox13.Click += pictureBox13_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(113, 15);
            label7.Name = "label7";
            label7.Size = new Size(76, 30);
            label7.TabIndex = 16;
            label7.Text = "SIVAA";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(734, 13);
            lblNombre.Margin = new Padding(1, 0, 1, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(172, 21);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Bienvenido: Fulanito";
            lblNombre.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTipoEmpleado
            // 
            lblTipoEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTipoEmpleado.AutoSize = true;
            lblTipoEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoEmpleado.Location = new Point(810, 32);
            lblTipoEmpleado.Margin = new Padding(1, 0, 1, 0);
            lblTipoEmpleado.Name = "lblTipoEmpleado";
            lblTipoEmpleado.Size = new Size(62, 15);
            lblTipoEmpleado.TabIndex = 1;
            lblTipoEmpleado.Text = "Supervisor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(370, 13);
            label1.Name = "label1";
            label1.Size = new Size(159, 32);
            label1.TabIndex = 17;
            label1.Text = "Modificar cita";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1493, 34);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 18;
            label2.Text = "Supervisor";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel7.BackColor = Color.FromArgb(51, 58, 86);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(label1);
            panel7.Controls.Add(lblTipoEmpleado);
            panel7.Controls.Add(lblNombre);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(pictureBox13);
            panel7.ForeColor = Color.White;
            panel7.Location = new Point(0, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(931, 57);
            panel7.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(542, 83);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 83;
            label9.Text = "Hora:";
            // 
            // btnAgregarCita
            // 
            btnAgregarCita.BackColor = Color.FromArgb(51, 58, 86);
            btnAgregarCita.ForeColor = Color.White;
            btnAgregarCita.Location = new Point(778, 158);
            btnAgregarCita.Name = "btnAgregarCita";
            btnAgregarCita.Size = new Size(120, 35);
            btnAgregarCita.TabIndex = 82;
            btnAgregarCita.Text = "Modificar";
            btnAgregarCita.UseVisualStyleBackColor = false;
            btnAgregarCita.Click += btnAgregarCita_Click;
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Location = new Point(436, 136);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(38, 15);
            lblAño.TabIndex = 81;
            lblAño.Text = "label9";
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Location = new Point(436, 112);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(38, 15);
            lblMes.TabIndex = 80;
            lblMes.Text = "label9";
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(436, 88);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(38, 15);
            lblDia.TabIndex = 79;
            lblDia.Text = "label9";
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Location = new Point(633, 136);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(133, 15);
            lblVendedor.TabIndex = 78;
            lblVendedor.Text = "Seleccione un vendedor";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(542, 110);
            label10.Name = "label10";
            label10.Size = new Size(47, 15);
            label10.TabIndex = 77;
            label10.Text = "Cliente:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(542, 136);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 75;
            label8.Text = "Vendedor:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(346, 136);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 74;
            label6.Text = "Año:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(346, 111);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 73;
            label5.Text = "Mes:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 86);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 72;
            label4.Text = "Dia:";
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(51, 58, 86);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(88, 71);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(130, 28);
            btnRegresar.TabIndex = 85;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(633, 83);
            lblHora.Margin = new Padding(2, 0, 2, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(44, 15);
            lblHora.TabIndex = 86;
            lblHora.Text = "label13";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(228, 111);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(92, 23);
            dateTimePicker1.TabIndex = 87;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(113, 115);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(100, 15);
            label14.TabIndex = 88;
            label14.Text = "Fecha y hora --->";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(633, 110);
            lblCliente.Margin = new Padding(2, 0, 2, 0);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(57, 15);
            lblCliente.TabIndex = 89;
            lblCliente.Text = "lblCliente";
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridView2);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(88, 198);
            panel4.Margin = new Padding(2, 2, 2, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(824, 267);
            panel4.TabIndex = 90;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column3, Column5, Column6, Column7 });
            dataGridView2.Location = new Point(7, 40);
            dataGridView2.Margin = new Padding(2, 2, 2, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(815, 227);
            dataGridView2.TabIndex = 103;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // Column3
            // 
            Column3.HeaderText = "IDEmpleado";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            // 
            // Column5
            // 
            Column5.HeaderText = "Nombre";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Apellido Paterno";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Apellido Materno";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.Controls.Add(btnBuscarEmpleado);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(txtBuscarEmpleado);
            panel5.Controls.Add(cmbEmpleado);
            panel5.Location = new Point(3, 2);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(508, 35);
            panel5.TabIndex = 102;
            // 
            // btnBuscarEmpleado
            // 
            btnBuscarEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscarEmpleado.BackColor = Color.FromArgb(82, 101, 143);
            btnBuscarEmpleado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarEmpleado.ForeColor = SystemColors.ButtonHighlight;
            btnBuscarEmpleado.Location = new Point(400, 4);
            btnBuscarEmpleado.Margin = new Padding(3, 2, 3, 2);
            btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            btnBuscarEmpleado.Size = new Size(90, 25);
            btnBuscarEmpleado.TabIndex = 101;
            btnBuscarEmpleado.Text = "Buscar";
            btnBuscarEmpleado.UseVisualStyleBackColor = false;
            btnBuscarEmpleado.Click += btnBuscarEmpleado_Click;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(57, 9);
            label15.Name = "label15";
            label15.Size = new Size(75, 18);
            label15.TabIndex = 98;
            label15.Text = "Filtrar por:";
            // 
            // txtBuscarEmpleado
            // 
            txtBuscarEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscarEmpleado.BackColor = Color.White;
            txtBuscarEmpleado.Enabled = false;
            txtBuscarEmpleado.ForeColor = SystemColors.ActiveCaptionText;
            txtBuscarEmpleado.Location = new Point(245, 8);
            txtBuscarEmpleado.Margin = new Padding(3, 2, 3, 2);
            txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            txtBuscarEmpleado.PlaceholderText = "Ingrese su busqueda";
            txtBuscarEmpleado.Size = new Size(150, 23);
            txtBuscarEmpleado.TabIndex = 100;
            // 
            // cmbEmpleado
            // 
            cmbEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Items.AddRange(new object[] { "Todos", "IDEmpleado", "Nombre", "ApellidoPaterno", "ApellidoMaterno" });
            cmbEmpleado.Location = new Point(139, 8);
            cmbEmpleado.Margin = new Padding(3, 2, 3, 2);
            cmbEmpleado.Name = "cmbEmpleado";
            cmbEmpleado.Size = new Size(101, 23);
            cmbEmpleado.TabIndex = 99;
            cmbEmpleado.SelectedIndexChanged += cmbEmpleado_SelectedIndexChanged;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(696, 110);
            lblNombreCliente.Margin = new Padding(2, 0, 2, 0);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(38, 15);
            lblNombreCliente.TabIndex = 91;
            lblNombreCliente.Text = "label3";
            // 
            // ModificarCita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 472);
            Controls.Add(lblNombreCliente);
            Controls.Add(panel4);
            Controls.Add(lblCliente);
            Controls.Add(label14);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblHora);
            Controls.Add(btnRegresar);
            Controls.Add(label9);
            Controls.Add(btnAgregarCita);
            Controls.Add(lblAño);
            Controls.Add(lblMes);
            Controls.Add(lblDia);
            Controls.Add(lblVendedor);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(panel7);
            Controls.Add(panel1);
            Name = "ModificarCita";
            Text = "ModificarCita";
            WindowState = FormWindowState.Maximized;
            Load += ModificarCita_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imageList1;
        private ImageList imageList2;
        private Panel panel1;
        private Button btnReportes;
        private Button btnCobros;
        private Button btnVentas;
        private Button btnCitas;
        private Button btnStock;
        private Button btnPedidos;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private PictureBox pictureBox13;
        private Label label7;
        private Label lblNombre;
        private Label lblTipoEmpleado;
        private Label label1;
        private Label label2;
        private Panel panel7;
        private Label label9;
        private Button btnAgregarCita;
        private Label lblAño;
        private Label lblMes;
        private Label lblDia;
        private Label lblVendedor;
        private Label label10;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnRegresar;
        private Label lblHora;
        private DateTimePicker dateTimePicker1;
        private Label label14;
        private Label lblCliente;
        private Panel panel4;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Panel panel5;
        private Button btnBuscarEmpleado;
        private Label label15;
        private TextBox txtBuscarEmpleado;
        private ComboBox cmbEmpleado;
        private Label lblNombreCliente;
    }
}