namespace Pantallas_SIVAA
{
    partial class AgregarCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCita));
            panel1 = new Panel();
            btnReportes = new Button();
            imageList2 = new ImageList(components);
            btnCobros = new Button();
            btnVentas = new Button();
            btnCitas = new Button();
            btnStock = new Button();
            btnPedidos = new Button();
            imageList1 = new ImageList(components);
            panel7 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            lblTipoEmpleado = new Label();
            lblNombre = new Label();
            label7 = new Label();
            pictureBox13 = new PictureBox();
            monthCalendar1 = new MonthCalendar();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            cmbVendedor = new ComboBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label10 = new Label();
            lblIDCliente = new Label();
            lblDia = new Label();
            lblMes = new Label();
            lblAño = new Label();
            btnAgregarCita = new Button();
            label9 = new Label();
            txtHora = new MaskedTextBox();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            panel1.Location = new Point(-1, 92);
            panel1.Margin = new Padding(1, 3, 1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(94, 848);
            panel1.TabIndex = 36;
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
            btnCobros.Location = new Point(0, 383);
            btnCobros.Margin = new Padding(1, 3, 1, 3);
            btnCobros.Name = "btnCobros";
            btnCobros.Size = new Size(101, 95);
            btnCobros.TabIndex = 9;
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
            btnVentas.Location = new Point(0, 287);
            btnVentas.Margin = new Padding(1, 3, 1, 3);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(101, 95);
            btnVentas.TabIndex = 8;
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
            btnCitas.Location = new Point(0, 193);
            btnCitas.Margin = new Padding(1, 3, 1, 3);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(101, 95);
            btnCitas.TabIndex = 7;
            btnCitas.Text = "Citas";
            btnCitas.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCitas.UseVisualStyleBackColor = false;
            btnCitas.Click += btnCitas_Click;
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
            btnPedidos.Location = new Point(0, 3);
            btnPedidos.Margin = new Padding(1, 3, 1, 3);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(101, 95);
            btnPedidos.TabIndex = 5;
            btnPedidos.Text = "Pedidos";
            btnPedidos.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPedidos.UseVisualStyleBackColor = false;
            btnPedidos.Click += btnPedidos_Click;
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
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel7.BackColor = Color.FromArgb(51, 58, 86);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(label1);
            panel7.Controls.Add(lblTipoEmpleado);
            panel7.Controls.Add(lblNombre);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(pictureBox13);
            panel7.ForeColor = Color.White;
            panel7.Location = new Point(1, 0);
            panel7.Margin = new Padding(4, 5, 4, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(1729, 95);
            panel7.TabIndex = 37;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1526, 57);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 18;
            label2.Text = "Supervisor";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1443, 15);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(255, 32);
            label3.TabIndex = 19;
            label3.Text = "Bienvenido: Fulanito";
            label3.TextAlign = ContentAlignment.TopCenter;
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
            // lblTipoEmpleado
            // 
            lblTipoEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTipoEmpleado.AutoSize = true;
            lblTipoEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoEmpleado.Location = new Point(2331, 57);
            lblTipoEmpleado.Margin = new Padding(1, 0, 1, 0);
            lblTipoEmpleado.Name = "lblTipoEmpleado";
            lblTipoEmpleado.Size = new Size(96, 25);
            lblTipoEmpleado.TabIndex = 1;
            lblTipoEmpleado.Text = "Supervisor";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(2249, 15);
            lblNombre.Margin = new Padding(1, 0, 1, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(255, 32);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Bienvenido: Fulanito";
            lblNombre.TextAlign = ContentAlignment.TopCenter;
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
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(134, 115);
            monthCalendar1.Margin = new Padding(13, 15, 13, 15);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 39;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(490, 130);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(42, 25);
            label4.TabIndex = 40;
            label4.Text = "Dia:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(491, 185);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 41;
            label5.Text = "Mes:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(491, 238);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(49, 25);
            label6.TabIndex = 42;
            label6.Text = "Año:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(493, 285);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(93, 25);
            label8.TabIndex = 43;
            label8.Text = "Vendedor:";
            // 
            // cmbVendedor
            // 
            cmbVendedor.FormattingEnabled = true;
            cmbVendedor.Location = new Point(607, 277);
            cmbVendedor.Margin = new Padding(4, 5, 4, 5);
            cmbVendedor.Name = "cmbVendedor";
            cmbVendedor.Size = new Size(171, 33);
            cmbVendedor.TabIndex = 44;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column4, Column8, Column6, Column3, Column9, Column10, Column11, Column12, Column5 });
            dataGridView1.Location = new Point(99, 482);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1364, 465);
            dataGridView1.TabIndex = 60;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "IdCliente";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Apellido Paterno";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Apellido Materno";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "RFC";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Correo";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "Telefono";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.HeaderText = "No.Exterior";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Column11
            // 
            Column11.HeaderText = "Colonia";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // Column12
            // 
            Column12.HeaderText = "Ciudad";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Estado";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(493, 340);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(69, 25);
            label10.TabIndex = 61;
            label10.Text = "Cliente:";
            // 
            // lblIDCliente
            // 
            lblIDCliente.AutoSize = true;
            lblIDCliente.Location = new Point(604, 347);
            lblIDCliente.Margin = new Padding(4, 0, 4, 0);
            lblIDCliente.Name = "lblIDCliente";
            lblIDCliente.Size = new Size(174, 25);
            lblIDCliente.TabIndex = 64;
            lblIDCliente.Text = "Seleccione un cliente";
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(581, 130);
            lblDia.Margin = new Padding(4, 0, 4, 0);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(59, 25);
            lblDia.TabIndex = 65;
            lblDia.Text = "label9";
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Location = new Point(584, 185);
            lblMes.Margin = new Padding(4, 0, 4, 0);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(59, 25);
            lblMes.TabIndex = 66;
            lblMes.Text = "label9";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Location = new Point(589, 240);
            lblAño.Margin = new Padding(4, 0, 4, 0);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(59, 25);
            lblAño.TabIndex = 67;
            lblAño.Text = "label9";
            // 
            // btnAgregarCita
            // 
            btnAgregarCita.Location = new Point(1024, 307);
            btnAgregarCita.Margin = new Padding(4, 5, 4, 5);
            btnAgregarCita.Name = "btnAgregarCita";
            btnAgregarCita.Size = new Size(171, 58);
            btnAgregarCita.TabIndex = 68;
            btnAgregarCita.Text = "Agregar";
            btnAgregarCita.UseVisualStyleBackColor = true;
            btnAgregarCita.Click += btnAgregarCita_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(771, 125);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(55, 25);
            label9.TabIndex = 69;
            label9.Text = "Hora:";
            // 
            // txtHora
            // 
            txtHora.Location = new Point(831, 117);
            txtHora.Margin = new Padding(4, 5, 4, 5);
            txtHora.Mask = "00:00";
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(141, 31);
            txtHora.TabIndex = 70;
            txtHora.ValidatingType = typeof(DateTime);
            // 
            // AgregarCita
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1729, 940);
            Controls.Add(txtHora);
            Controls.Add(label9);
            Controls.Add(btnAgregarCita);
            Controls.Add(lblAño);
            Controls.Add(lblMes);
            Controls.Add(lblDia);
            Controls.Add(lblIDCliente);
            Controls.Add(label10);
            Controls.Add(dataGridView1);
            Controls.Add(cmbVendedor);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(monthCalendar1);
            Controls.Add(panel7);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AgregarCita";
            Text = "AgregarCita";
            WindowState = FormWindowState.Maximized;
            Load += AgregarCita_Load;
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnReportes;
        private Button btnCobros;
        private Button btnVentas;
        private Button btnCitas;
        private Button btnStock;
        private Button btnPedidos;
        private ImageList imageList2;
        private ImageList imageList1;
        private Panel panel7;
        private Label label1;
        private Label lblTipoEmpleado;
        private Label lblNombre;
        private Label label7;
        private PictureBox pictureBox13;
        private Label label2;
        private Label label3;
        private MonthCalendar monthCalendar1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private ComboBox cmbVendedor;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column5;
        private Label label10;
        private Label lblIDCliente;
        private Label lblDia;
        private Label lblMes;
        private Label lblAño;
        private Button btnAgregarCita;
        private Label label9;
        private MaskedTextBox txtHora;
    }
}