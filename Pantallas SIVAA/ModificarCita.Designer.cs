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
            label3 = new Label();
            label2 = new Label();
            panel7 = new Panel();
            txtHora = new MaskedTextBox();
            label9 = new Label();
            btnAgregarCita = new Button();
            lblAño = new Label();
            lblMes = new Label();
            lblDia = new Label();
            lblIDCliente = new Label();
            label10 = new Label();
            cmbVendedor = new ComboBox();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            monthCalendar1 = new MonthCalendar();
            label11 = new Label();
            label12 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            panel7.SuspendLayout();
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
            panel1.Location = new Point(-186, 100);
            panel1.Margin = new Padding(1, 3, 1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(94, 677);
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
            btnReportes.Location = new Point(0, 480);
            btnReportes.Margin = new Padding(1, 3, 1, 3);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(101, 95);
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
            btnCobros.Location = new Point(0, 383);
            btnCobros.Margin = new Padding(1, 3, 1, 3);
            btnCobros.Name = "btnCobros";
            btnCobros.Size = new Size(101, 95);
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
            btnVentas.Location = new Point(0, 287);
            btnVentas.Margin = new Padding(1, 3, 1, 3);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(101, 95);
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
            btnCitas.Location = new Point(0, 193);
            btnCitas.Margin = new Padding(1, 3, 1, 3);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(101, 95);
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
            btnStock.Location = new Point(-20, 95);
            btnStock.Margin = new Padding(1, 3, 1, 3);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(141, 107);
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
            btnPedidos.Location = new Point(0, 3);
            btnPedidos.Margin = new Padding(1, 3, 1, 3);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(101, 95);
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
            panel2.Location = new Point(0, 98);
            panel2.Margin = new Padding(1, 3, 1, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(94, 695);
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
            button1.Location = new Point(0, 480);
            button1.Margin = new Padding(1, 3, 1, 3);
            button1.Name = "button1";
            button1.Size = new Size(101, 95);
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
            button2.Location = new Point(0, 383);
            button2.Margin = new Padding(1, 3, 1, 3);
            button2.Name = "button2";
            button2.Size = new Size(101, 95);
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
            button3.Location = new Point(0, 287);
            button3.Margin = new Padding(1, 3, 1, 3);
            button3.Name = "button3";
            button3.Size = new Size(101, 95);
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
            button4.Location = new Point(0, 193);
            button4.Margin = new Padding(1, 3, 1, 3);
            button4.Name = "button4";
            button4.Size = new Size(101, 95);
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
            button5.Location = new Point(-20, 95);
            button5.Margin = new Padding(1, 3, 1, 3);
            button5.Name = "button5";
            button5.Size = new Size(141, 107);
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
            button6.Location = new Point(0, 3);
            button6.Margin = new Padding(1, 3, 1, 3);
            button6.Name = "button6";
            button6.Size = new Size(101, 95);
            button6.TabIndex = 5;
            button6.Text = "Pedidos";
            button6.TextImageRelation = TextImageRelation.ImageAboveText;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(21, 12);
            pictureBox13.Margin = new Padding(1, 3, 1, 3);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(66, 67);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 2;
            pictureBox13.TabStop = false;
            pictureBox13.Click += pictureBox13_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(161, 25);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(115, 45);
            label7.TabIndex = 16;
            label7.Text = "SIVAA";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(2856, 15);
            lblNombre.Margin = new Padding(1, 0, 1, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(255, 32);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Bienvenido: Fulanito";
            lblNombre.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTipoEmpleado
            // 
            lblTipoEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTipoEmpleado.AutoSize = true;
            lblTipoEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoEmpleado.Location = new Point(2939, 57);
            lblTipoEmpleado.Margin = new Padding(1, 0, 1, 0);
            lblTipoEmpleado.Name = "lblTipoEmpleado";
            lblTipoEmpleado.Size = new Size(96, 25);
            lblTipoEmpleado.TabIndex = 1;
            lblTipoEmpleado.Text = "Supervisor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(529, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 48);
            label1.TabIndex = 17;
            label1.Text = "Inicio";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(2050, 15);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(255, 32);
            label3.TabIndex = 19;
            label3.Text = "Bienvenido: Fulanito";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(2133, 57);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 18;
            label2.Text = "Supervisor";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel7.BackColor = Color.FromArgb(51, 58, 86);
            panel7.Controls.Add(label11);
            panel7.Controls.Add(label12);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(label1);
            panel7.Controls.Add(lblTipoEmpleado);
            panel7.Controls.Add(lblNombre);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(pictureBox13);
            panel7.ForeColor = Color.White;
            panel7.Location = new Point(0, 3);
            panel7.Margin = new Padding(4, 5, 4, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(1330, 95);
            panel7.TabIndex = 39;
            // 
            // txtHora
            // 
            txtHora.Location = new Point(833, 165);
            txtHora.Margin = new Padding(4, 5, 4, 5);
            txtHora.Mask = "00:00";
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(141, 31);
            txtHora.TabIndex = 84;
            txtHora.ValidatingType = typeof(DateTime);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(773, 173);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(55, 25);
            label9.TabIndex = 83;
            label9.Text = "Hora:";
            // 
            // btnAgregarCita
            // 
            btnAgregarCita.Location = new Point(1026, 355);
            btnAgregarCita.Margin = new Padding(4, 5, 4, 5);
            btnAgregarCita.Name = "btnAgregarCita";
            btnAgregarCita.Size = new Size(171, 58);
            btnAgregarCita.TabIndex = 82;
            btnAgregarCita.Text = "Agregar";
            btnAgregarCita.UseVisualStyleBackColor = true;
            btnAgregarCita.Click += btnAgregarCita_Click;
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Location = new Point(590, 288);
            lblAño.Margin = new Padding(4, 0, 4, 0);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(59, 25);
            lblAño.TabIndex = 81;
            lblAño.Text = "label9";
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Location = new Point(586, 233);
            lblMes.Margin = new Padding(4, 0, 4, 0);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(59, 25);
            lblMes.TabIndex = 80;
            lblMes.Text = "label9";
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(583, 178);
            lblDia.Margin = new Padding(4, 0, 4, 0);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(59, 25);
            lblDia.TabIndex = 79;
            lblDia.Text = "label9";
            // 
            // lblIDCliente
            // 
            lblIDCliente.AutoSize = true;
            lblIDCliente.Location = new Point(606, 395);
            lblIDCliente.Margin = new Padding(4, 0, 4, 0);
            lblIDCliente.Name = "lblIDCliente";
            lblIDCliente.Size = new Size(174, 25);
            lblIDCliente.TabIndex = 78;
            lblIDCliente.Text = "Seleccione un cliente";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(494, 388);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(69, 25);
            label10.TabIndex = 77;
            label10.Text = "Cliente:";
            // 
            // cmbVendedor
            // 
            cmbVendedor.FormattingEnabled = true;
            cmbVendedor.Location = new Point(609, 325);
            cmbVendedor.Margin = new Padding(4, 5, 4, 5);
            cmbVendedor.Name = "cmbVendedor";
            cmbVendedor.Size = new Size(171, 33);
            cmbVendedor.TabIndex = 76;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(494, 333);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(93, 25);
            label8.TabIndex = 75;
            label8.Text = "Vendedor:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(493, 287);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(49, 25);
            label6.TabIndex = 74;
            label6.Text = "Año:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(493, 233);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 73;
            label5.Text = "Mes:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(491, 178);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(42, 25);
            label4.TabIndex = 72;
            label4.Text = "Dia:";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(136, 163);
            monthCalendar1.Margin = new Padding(13, 15, 13, 15);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 71;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(1108, 63);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(96, 25);
            label11.TabIndex = 20;
            label11.Text = "Supervisor";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(1026, 22);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(255, 32);
            label12.TabIndex = 21;
            label12.Text = "Bienvenido: Fulanito";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // ModificarCita
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 787);
            Controls.Add(txtHora);
            Controls.Add(label9);
            Controls.Add(btnAgregarCita);
            Controls.Add(lblAño);
            Controls.Add(lblMes);
            Controls.Add(lblDia);
            Controls.Add(lblIDCliente);
            Controls.Add(label10);
            Controls.Add(cmbVendedor);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(monthCalendar1);
            Controls.Add(panel2);
            Controls.Add(panel7);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ModificarCita";
            Text = "ModificarCita";
            WindowState = FormWindowState.Maximized;
            Load += ModificarCita_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
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
        private Label label3;
        private Label label2;
        private Panel panel7;
        private MaskedTextBox txtHora;
        private Label label9;
        private Button btnAgregarCita;
        private Label lblAño;
        private Label lblMes;
        private Label lblDia;
        private Label lblIDCliente;
        private Label label10;
        private ComboBox cmbVendedor;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private MonthCalendar monthCalendar1;
        private Label label11;
        private Label label12;
    }
}