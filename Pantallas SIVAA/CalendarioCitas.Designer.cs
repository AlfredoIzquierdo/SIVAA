namespace Pantallas_SIVAA
{
    partial class CalendarioCitas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarioCitas));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTipoEmpleado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnCobros = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTodo = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(96, 205);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1356, 593);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IDCita";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "IDEmpleado";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "IDCliente";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Dia";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Mes";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Año";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Hora";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "archive.png");
            this.imageList2.Images.SetKeyName(1, "bar-chart.png");
            this.imageList2.Images.SetKeyName(2, "book-open.png");
            this.imageList2.Images.SetKeyName(3, "calendar.png");
            this.imageList2.Images.SetKeyName(4, "dollar-sign.png");
            this.imageList2.Images.SetKeyName(5, "package.png");
            this.imageList2.Images.SetKeyName(6, "shopping-cart.png");
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.lblTipoEmpleado);
            this.panel7.Controls.Add(this.lblNombre);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.pictureBox13);
            this.panel7.ForeColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1604, 95);
            this.panel7.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(776, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 48);
            this.label8.TabIndex = 22;
            this.label8.Text = "Citas";
            // 
            // lblTipoEmpleado
            // 
            this.lblTipoEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoEmpleado.AutoSize = true;
            this.lblTipoEmpleado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipoEmpleado.Location = new System.Drawing.Point(1244, 45);
            this.lblTipoEmpleado.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTipoEmpleado.Name = "lblTipoEmpleado";
            this.lblTipoEmpleado.Size = new System.Drawing.Size(96, 25);
            this.lblTipoEmpleado.TabIndex = 20;
            this.lblTipoEmpleado.Text = "Supervisor";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(1244, 12);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(255, 32);
            this.lblNombre.TabIndex = 21;
            this.lblNombre.Text = "Bienvenido: Fulanito";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(151, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 45);
            this.label7.TabIndex = 16;
            this.label7.Text = "SIVAA";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(21, 0);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(66, 95);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 2;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox13_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(101)))), ((int)(((byte)(143)))));
            this.panel1.Controls.Add(this.btnReportes);
            this.panel1.Controls.Add(this.btnCobros);
            this.panel1.Controls.Add(this.btnVentas);
            this.panel1.Controls.Add(this.btnCitas);
            this.panel1.Controls.Add(this.btnStock);
            this.panel1.Controls.Add(this.btnPedidos);
            this.panel1.Location = new System.Drawing.Point(-1, 95);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 715);
            this.panel1.TabIndex = 38;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(101)))), ((int)(((byte)(143)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReportes.ImageKey = "bar-chart.png";
            this.btnReportes.ImageList = this.imageList2;
            this.btnReportes.Location = new System.Drawing.Point(0, 472);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(94, 95);
            this.btnReportes.TabIndex = 11;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnCobros
            // 
            this.btnCobros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(101)))), ((int)(((byte)(143)))));
            this.btnCobros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobros.ForeColor = System.Drawing.Color.White;
            this.btnCobros.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCobros.ImageKey = "dollar-sign.png";
            this.btnCobros.ImageList = this.imageList2;
            this.btnCobros.Location = new System.Drawing.Point(0, 377);
            this.btnCobros.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnCobros.Name = "btnCobros";
            this.btnCobros.Size = new System.Drawing.Size(94, 95);
            this.btnCobros.TabIndex = 10;
            this.btnCobros.Text = "Cobros";
            this.btnCobros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCobros.UseVisualStyleBackColor = false;
            this.btnCobros.Click += new System.EventHandler(this.btnCobros_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(101)))), ((int)(((byte)(143)))));
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVentas.ImageKey = "shopping-cart.png";
            this.btnVentas.ImageList = this.imageList2;
            this.btnVentas.Location = new System.Drawing.Point(0, 282);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(94, 95);
            this.btnVentas.TabIndex = 9;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(101)))), ((int)(((byte)(143)))));
            this.btnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitas.ForeColor = System.Drawing.Color.White;
            this.btnCitas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCitas.ImageKey = "calendar.png";
            this.btnCitas.ImageList = this.imageList2;
            this.btnCitas.Location = new System.Drawing.Point(0, 187);
            this.btnCitas.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(94, 95);
            this.btnCitas.TabIndex = 8;
            this.btnCitas.Text = "Citas";
            this.btnCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCitas.UseVisualStyleBackColor = false;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(101)))), ((int)(((byte)(143)))));
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStock.ImageKey = "book-open.png";
            this.btnStock.ImageList = this.imageList2;
            this.btnStock.Location = new System.Drawing.Point(0, 92);
            this.btnStock.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(94, 95);
            this.btnStock.TabIndex = 7;
            this.btnStock.Text = "Inventario";
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(101)))), ((int)(((byte)(143)))));
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.ForeColor = System.Drawing.Color.White;
            this.btnPedidos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPedidos.ImageKey = "package.png";
            this.btnPedidos.ImageList = this.imageList2;
            this.btnPedidos.Location = new System.Drawing.Point(0, 0);
            this.btnPedidos.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(94, 95);
            this.btnPedidos.TabIndex = 6;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnTodo);
            this.panel3.Controls.Add(this.numericUpDown3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.numericUpDown2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(476, 118);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(930, 58);
            this.panel3.TabIndex = 63;
            // 
            // btnTodo
            // 
            this.btnTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(101)))), ((int)(((byte)(143)))));
            this.btnTodo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTodo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTodo.Location = new System.Drawing.Point(4, 3);
            this.btnTodo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(170, 47);
            this.btnTodo.TabIndex = 105;
            this.btnTodo.Text = "Todas las citas";
            this.btnTodo.UseVisualStyleBackColor = false;
            this.btnTodo.Click += new System.EventHandler(this.btnTodo_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(671, 13);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(87, 31);
            this.numericUpDown3.TabIndex = 104;
            this.numericUpDown3.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(646, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 26);
            this.label2.TabIndex = 103;
            this.label2.Text = "/";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(584, 13);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(57, 31);
            this.numericUpDown2.TabIndex = 102;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(559, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 26);
            this.label1.TabIndex = 101;
            this.label1.Text = "/";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(494, 13);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(57, 31);
            this.numericUpDown1.TabIndex = 100;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(101)))), ((int)(((byte)(143)))));
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(840, 2);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 47);
            this.btnBuscar.TabIndex = 99;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(366, 17);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 26);
            this.label11.TabIndex = 97;
            this.label11.Text = "Buscar por:";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Pantallas_SIVAA.Properties.Resources.x;
            this.pictureBox11.Location = new System.Drawing.Point(344, 118);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(54, 52);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 62;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Pantallas_SIVAA.Properties.Resources.edit_2;
            this.pictureBox9.Location = new System.Drawing.Point(281, 118);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(54, 52);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 61;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(219, 118);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(54, 52);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 60;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pantallas_SIVAA.Properties.Resources.print_FILL0_wght400_GRAD0_opsz48;
            this.pictureBox1.Location = new System.Drawing.Point(406, 120);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 51);
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CalendarioCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1604, 810);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CalendarioCitas";
            this.Text = "Citas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CalendarioCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dataGridView1;
        private ImageList imageList2;
        private Panel panel7;
        private Label label7;
        private PictureBox pictureBox13;
        private Label lblTipoEmpleado;
        private Label lblNombre;
        private Label label8;
        private Panel panel1;
        private Button btnReportes;
        private Button btnCobros;
        private Button btnVentas;
        private Button btnCitas;
        private Button btnStock;
        private Button btnPedidos;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Panel panel3;
        private Label label11;
        private PictureBox pictureBox11;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private Button btnBuscar;
        private NumericUpDown numericUpDown3;
        private Label label2;
        private NumericUpDown numericUpDown2;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Button btnTodo;
        private PictureBox pictureBox1;
    }
}