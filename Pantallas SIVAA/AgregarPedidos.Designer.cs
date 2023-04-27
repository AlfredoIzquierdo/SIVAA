namespace Pantallas_SIVAA
{
    partial class AgregarPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarPedidos));
            panel7 = new Panel();
            pictureBox13 = new PictureBox();
            lblTipoEmpleado = new Label();
            label2 = new Label();
            lblNombre = new Label();
            label7 = new Label();
            panel1 = new Panel();
            btnReportes = new Button();
            imageList2 = new ImageList(components);
            btnCobros = new Button();
            btnVentas = new Button();
            btnCitas = new Button();
            btnStock = new Button();
            btnPedidos = new Button();
            pictureBox4 = new PictureBox();
            cbProov = new ComboBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            numericUpDownDia = new NumericUpDown();
            numericUpDownMes = new NumericUpDown();
            numericUpDownAno = new NumericUpDown();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            txtImporte = new TextBox();
            button1 = new Button();
            btnRegresar = new Button();
            panel2 = new Panel();
            txtCant = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnIngresarUnidad = new Button();
            txtSerie = new TextBox();
            cmbModelo = new ComboBox();
            cmbVersion = new ComboBox();
            cmbColor = new ComboBox();
            cmbVehiculo = new ComboBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            pictureBox5 = new PictureBox();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(51, 58, 86);
            panel7.Controls.Add(pictureBox13);
            panel7.Controls.Add(lblTipoEmpleado);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(lblNombre);
            panel7.Controls.Add(label7);
            panel7.Dock = DockStyle.Top;
            panel7.ForeColor = Color.White;
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(4);
            panel7.Name = "panel7";
            panel7.Size = new Size(913, 71);
            panel7.TabIndex = 38;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(13, 0);
            pictureBox13.Margin = new Padding(1, 2, 1, 2);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(57, 71);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 40;
            pictureBox13.TabStop = false;
            pictureBox13.Click += pictureBox13_Click;
            // 
            // lblTipoEmpleado
            // 
            lblTipoEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTipoEmpleado.AutoSize = true;
            lblTipoEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoEmpleado.Location = new Point(790, 45);
            lblTipoEmpleado.Margin = new Padding(1, 0, 1, 0);
            lblTipoEmpleado.Name = "lblTipoEmpleado";
            lblTipoEmpleado.Size = new Size(62, 15);
            lblTipoEmpleado.TabIndex = 41;
            lblTipoEmpleado.Text = "Supervisor";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(365, 15);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(180, 32);
            label2.TabIndex = 20;
            label2.Text = "Agregar pedido";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(778, 14);
            lblNombre.Margin = new Padding(1, 0, 1, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(75, 21);
            lblNombre.TabIndex = 42;
            lblNombre.Text = "Fulanito";
            lblNombre.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(88, 26);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(99, 34);
            label7.TabIndex = 16;
            label7.Text = "SIVAA";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(82, 101, 143);
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(btnCobros);
            panel1.Controls.Add(btnVentas);
            panel1.Controls.Add(btnCitas);
            panel1.Controls.Add(btnStock);
            panel1.Controls.Add(btnPedidos);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 71);
            panel1.Margin = new Padding(1, 2, 1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(71, 413);
            panel1.TabIndex = 39;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(82, 101, 143);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.ForeColor = Color.White;
            btnReportes.ImageAlign = ContentAlignment.TopCenter;
            btnReportes.ImageKey = "bar-chart.png";
            btnReportes.ImageList = imageList2;
            btnReportes.Location = new Point(0, 292);
            btnReportes.Margin = new Padding(3, 2, 3, 2);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(70, 60);
            btnReportes.TabIndex = 11;
            btnReportes.Text = "Reportes";
            btnReportes.TextImageRelation = TextImageRelation.ImageAboveText;
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
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
            // btnCobros
            // 
            btnCobros.BackColor = Color.FromArgb(82, 101, 143);
            btnCobros.FlatStyle = FlatStyle.Flat;
            btnCobros.ForeColor = Color.White;
            btnCobros.ImageAlign = ContentAlignment.TopCenter;
            btnCobros.ImageKey = "dollar-sign.png";
            btnCobros.ImageList = imageList2;
            btnCobros.Location = new Point(0, 233);
            btnCobros.Margin = new Padding(3, 2, 3, 2);
            btnCobros.Name = "btnCobros";
            btnCobros.Size = new Size(70, 60);
            btnCobros.TabIndex = 10;
            btnCobros.Text = "Cobros";
            btnCobros.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCobros.UseVisualStyleBackColor = false;
            btnCobros.Click += btnCobros_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(82, 101, 143);
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.ForeColor = Color.White;
            btnVentas.ImageAlign = ContentAlignment.TopCenter;
            btnVentas.ImageKey = "shopping-cart.png";
            btnVentas.ImageList = imageList2;
            btnVentas.Location = new Point(0, 175);
            btnVentas.Margin = new Padding(3, 2, 3, 2);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(70, 60);
            btnVentas.TabIndex = 9;
            btnVentas.Text = "Ventas";
            btnVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
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
            btnCitas.Margin = new Padding(3, 2, 3, 2);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(70, 60);
            btnCitas.TabIndex = 8;
            btnCitas.Text = "Citas";
            btnCitas.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCitas.UseVisualStyleBackColor = false;
            btnCitas.Click += btnCitas_Click;
            // 
            // btnStock
            // 
            btnStock.BackColor = Color.FromArgb(82, 101, 143);
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnStock.ForeColor = Color.White;
            btnStock.ImageAlign = ContentAlignment.TopCenter;
            btnStock.ImageKey = "book-open.png";
            btnStock.ImageList = imageList2;
            btnStock.Location = new Point(0, 56);
            btnStock.Margin = new Padding(3, 2, 3, 2);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(70, 60);
            btnStock.TabIndex = 7;
            btnStock.Text = "Inventario";
            btnStock.TextImageRelation = TextImageRelation.ImageAboveText;
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.BackColor = Color.FromArgb(82, 101, 143);
            btnPedidos.FlatStyle = FlatStyle.Flat;
            btnPedidos.ForeColor = Color.White;
            btnPedidos.ImageAlign = ContentAlignment.TopCenter;
            btnPedidos.ImageKey = "package.png";
            btnPedidos.ImageList = imageList2;
            btnPedidos.Location = new Point(0, 0);
            btnPedidos.Margin = new Padding(3, 2, 3, 2);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(70, 60);
            btnPedidos.TabIndex = 6;
            btnPedidos.Text = "Pedidos";
            btnPedidos.TextAlign = ContentAlignment.BottomCenter;
            btnPedidos.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPedidos.UseVisualStyleBackColor = false;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.user__2_;
            pictureBox4.Location = new Point(36, 40);
            pictureBox4.Margin = new Padding(4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 43);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 109;
            pictureBox4.TabStop = false;
            // 
            // cbProov
            // 
            cbProov.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProov.FormattingEnabled = true;
            cbProov.Items.AddRange(new object[] { "AutoSur", "NissCar", "AutoT", "NisAuto", "AutoYa", "AutoG", "NissMX", "AutosP", "AutoK" });
            cbProov.Location = new Point(106, 61);
            cbProov.Margin = new Padding(3, 2, 3, 2);
            cbProov.Name = "cbProov";
            cbProov.Size = new Size(157, 23);
            cbProov.TabIndex = 110;
            cbProov.SelectedIndexChanged += cbProov_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(106, 31);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 111;
            label1.Text = "Proveedor:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.calendar;
            pictureBox1.Location = new Point(36, 101);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 112;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(106, 91);
            label3.Name = "label3";
            label3.Size = new Size(134, 21);
            label3.TabIndex = 113;
            label3.Text = "Fecha de recibido:";
            // 
            // numericUpDownDia
            // 
            numericUpDownDia.Location = new Point(106, 124);
            numericUpDownDia.Margin = new Padding(3, 2, 3, 2);
            numericUpDownDia.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            numericUpDownDia.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownDia.Name = "numericUpDownDia";
            numericUpDownDia.Size = new Size(34, 23);
            numericUpDownDia.TabIndex = 114;
            numericUpDownDia.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownMes
            // 
            numericUpDownMes.Location = new Point(165, 124);
            numericUpDownMes.Margin = new Padding(3, 2, 3, 2);
            numericUpDownMes.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numericUpDownMes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownMes.Name = "numericUpDownMes";
            numericUpDownMes.Size = new Size(34, 23);
            numericUpDownMes.TabIndex = 115;
            numericUpDownMes.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownAno
            // 
            numericUpDownAno.Location = new Point(224, 124);
            numericUpDownAno.Margin = new Padding(3, 2, 3, 2);
            numericUpDownAno.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            numericUpDownAno.Minimum = new decimal(new int[] { 2023, 0, 0, 0 });
            numericUpDownAno.Name = "numericUpDownAno";
            numericUpDownAno.Size = new Size(50, 23);
            numericUpDownAno.TabIndex = 116;
            numericUpDownAno.Value = new decimal(new int[] { 2023, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(106, 169);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 117;
            label4.Text = "Importe:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.billete;
            pictureBox2.Location = new Point(36, 176);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 118;
            pictureBox2.TabStop = false;
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(111, 199);
            txtImporte.Margin = new Padding(3, 2, 3, 2);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(165, 23);
            txtImporte.TabIndex = 119;
            txtImporte.TextChanged += cbProov_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(51, 58, 86);
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(368, 348);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(153, 43);
            button1.TabIndex = 120;
            button1.Text = "Finalizar pedido";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(51, 58, 86);
            btnRegresar.FlatStyle = FlatStyle.Popup;
            btnRegresar.ForeColor = SystemColors.Control;
            btnRegresar.Location = new Point(192, 348);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(153, 43);
            btnRegresar.TabIndex = 121;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(txtCant);
            panel2.Controls.Add(tabControl1);
            panel2.Controls.Add(txtImporte);
            panel2.Controls.Add(btnRegresar);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(cbProov);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(numericUpDownAno);
            panel2.Controls.Add(numericUpDownDia);
            panel2.Controls.Add(numericUpDownMes);
            panel2.Location = new Point(88, 77);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(820, 397);
            panel2.TabIndex = 122;
            // 
            // txtCant
            // 
            txtCant.Enabled = false;
            txtCant.Location = new Point(111, 232);
            txtCant.Margin = new Padding(3, 2, 3, 2);
            txtCant.Name = "txtCant";
            txtCant.PlaceholderText = "Cantidad";
            txtCant.Size = new Size(74, 23);
            txtCant.TabIndex = 123;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(343, 23);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(458, 255);
            tabControl1.TabIndex = 124;
            tabControl1.Enter += tabControl1_Enter;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnIngresarUnidad);
            tabPage1.Controls.Add(txtSerie);
            tabPage1.Controls.Add(cmbModelo);
            tabPage1.Controls.Add(cmbVersion);
            tabPage1.Controls.Add(cmbColor);
            tabPage1.Controls.Add(cmbVehiculo);
            tabPage1.Controls.Add(pictureBox8);
            tabPage1.Controls.Add(pictureBox7);
            tabPage1.Controls.Add(pictureBox6);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(450, 227);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "| Agregar Unidad |";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // btnIngresarUnidad
            // 
            btnIngresarUnidad.BackColor = Color.FromArgb(51, 58, 86);
            btnIngresarUnidad.FlatStyle = FlatStyle.Popup;
            btnIngresarUnidad.ForeColor = SystemColors.Control;
            btnIngresarUnidad.Location = new Point(343, 23);
            btnIngresarUnidad.Margin = new Padding(3, 2, 3, 2);
            btnIngresarUnidad.Name = "btnIngresarUnidad";
            btnIngresarUnidad.Size = new Size(94, 43);
            btnIngresarUnidad.TabIndex = 121;
            btnIngresarUnidad.Text = "Ingresar";
            btnIngresarUnidad.UseVisualStyleBackColor = false;
            btnIngresarUnidad.Click += btnIngresarUnidad_Click;
            // 
            // txtSerie
            // 
            txtSerie.Location = new Point(88, 23);
            txtSerie.Margin = new Padding(3, 2, 3, 2);
            txtSerie.MaxLength = 10;
            txtSerie.Name = "txtSerie";
            txtSerie.Size = new Size(182, 23);
            txtSerie.TabIndex = 1;
            // 
            // cmbModelo
            // 
            cmbModelo.FormattingEnabled = true;
            cmbModelo.Location = new Point(88, 146);
            cmbModelo.Margin = new Padding(3, 2, 3, 2);
            cmbModelo.Name = "cmbModelo";
            cmbModelo.Size = new Size(82, 23);
            cmbModelo.TabIndex = 0;
            cmbModelo.Text = "Modelo";
            // 
            // cmbVersion
            // 
            cmbVersion.FormattingEnabled = true;
            cmbVersion.Location = new Point(88, 109);
            cmbVersion.Margin = new Padding(3, 2, 3, 2);
            cmbVersion.Name = "cmbVersion";
            cmbVersion.Size = new Size(182, 23);
            cmbVersion.TabIndex = 0;
            cmbVersion.Text = "Version";
            cmbVersion.SelectedValueChanged += cmbVersion_SelectedValueChanged;
            // 
            // cmbColor
            // 
            cmbColor.FormattingEnabled = true;
            cmbColor.Items.AddRange(new object[] { "Rojo", "Negro", "Blanco", "Azul", "Gris" });
            cmbColor.Location = new Point(174, 146);
            cmbColor.Margin = new Padding(3, 2, 3, 2);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(96, 23);
            cmbColor.TabIndex = 0;
            cmbColor.Text = "Color";
            // 
            // cmbVehiculo
            // 
            cmbVehiculo.FormattingEnabled = true;
            cmbVehiculo.Location = new Point(88, 67);
            cmbVehiculo.Margin = new Padding(3, 2, 3, 2);
            cmbVehiculo.Name = "cmbVehiculo";
            cmbVehiculo.Size = new Size(182, 23);
            cmbVehiculo.TabIndex = 0;
            cmbVehiculo.Text = "Vehiculo";
            cmbVehiculo.SelectedValueChanged += cmbVehiculo_SelectedValueChanged;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.list;
            pictureBox8.Location = new Point(41, 103);
            pictureBox8.Margin = new Padding(4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(41, 29);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 109;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Car;
            pictureBox7.Location = new Point(41, 59);
            pictureBox7.Margin = new Padding(4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(41, 29);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 109;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.article_FILL0_wght400_GRAD0_opsz48;
            pictureBox6.Location = new Point(41, 17);
            pictureBox6.Margin = new Padding(4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 29);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 109;
            pictureBox6.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(pictureBox5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(450, 227);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "| Unidades |";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(6, 5);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(393, 221);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "NoSerie";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Vehiculo";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Version";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Modelo";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Color";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.x;
            pictureBox5.Location = new Point(403, 4);
            pictureBox5.Margin = new Padding(4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(41, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 109;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "Eliminar Una Unidad";
            pictureBox5.ClientSizeChanged += pictureBox5_Click;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // AgregarPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 484);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel7);
            Name = "AgregarPedidos";
            Text = "Agregar";
            WindowState = FormWindowState.Maximized;
            Load += AgregarPedidos_Load;
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAno).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private Label label2;
        private Label label7;
        private Label lblTipoEmpleado;
        private Label lblNombre;
        private Panel panel1;
        private Button btnReportes;
        private Button btnCobros;
        private Button btnVentas;
        private Button btnCitas;
        private Button btnStock;
        private Button btnPedidos;
        private ImageList imageList2;
        private PictureBox pictureBox13;
        private PictureBox pictureBox4;
        private Button btnfinal;
        private Label label8;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txtcost;
        private NumericUpDown numDiaP;
        private NumericUpDown numMesPed;
        private NumericUpDown numAnoPed;
        private Label label3;
        private Label label5;
        private Label label10;
        private ComboBox cbProov;
        private Label label6;
        private Label label1;
        private PictureBox pictureBox1;
        private NumericUpDown numericUpDownDia;
        private NumericUpDown numericUpDownMes;
        private NumericUpDown numericUpDownAno;
        private Label label4;
        private TextBox txtImporte;
        private Button button1;
        private Button btnRegresar;
        private Panel panel2;
        private TextBox txtCant;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnIngresarUnidad;
        private TextBox txtSerie;
        private ComboBox cmbModelo;
        private ComboBox cmbVersion;
        private ComboBox cmbColor;
        private ComboBox cmbVehiculo;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private PictureBox pictureBox5;
    }
}