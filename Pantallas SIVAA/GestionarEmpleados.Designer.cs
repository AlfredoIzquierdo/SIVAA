namespace Pantallas_SIVAA
{
    partial class GestionarEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarEmpleados));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnCobros = new Button();
            imageList2 = new ImageList(components);
            btnVentas = new Button();
            btnCitas = new Button();
            btnPedidos = new Button();
            btnReportes = new Button();
            btnStock = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            panel7 = new Panel();
            panel6 = new Panel();
            pictureBox1 = new PictureBox();
            lblNombre = new Label();
            lblTipoEmpleado = new Label();
            label7 = new Label();
            pictureBox13 = new PictureBox();
            label6 = new Label();
            pictureBox11 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label2 = new Label();
            comboempleado = new ComboBox();
            button1 = new Button();
            txtbusqueda = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnCobros
            // 
            btnCobros.BackColor = Color.FromArgb(82, 101, 143);
            btnCobros.FlatStyle = FlatStyle.Flat;
            btnCobros.ForeColor = Color.White;
            btnCobros.ImageAlign = ContentAlignment.TopCenter;
            btnCobros.ImageKey = "dollar-sign.png";
            btnCobros.ImageList = imageList2;
            btnCobros.Location = new Point(0, 378);
            btnCobros.Margin = new Padding(2);
            btnCobros.Name = "btnCobros";
            btnCobros.Size = new Size(94, 95);
            btnCobros.TabIndex = 10;
            btnCobros.Text = "Cobros";
            btnCobros.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCobros.UseVisualStyleBackColor = false;
            btnCobros.Click += btnCobros_Click;
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
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(82, 101, 143);
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.ForeColor = Color.White;
            btnVentas.ImageAlign = ContentAlignment.TopCenter;
            btnVentas.ImageKey = "shopping-cart.png";
            btnVentas.ImageList = imageList2;
            btnVentas.Location = new Point(0, 282);
            btnVentas.Margin = new Padding(2);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(94, 95);
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
            btnCitas.Location = new Point(0, 188);
            btnCitas.Margin = new Padding(2);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(94, 95);
            btnCitas.TabIndex = 8;
            btnCitas.Text = "Citas";
            btnCitas.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCitas.UseVisualStyleBackColor = false;
            btnCitas.Click += btnCitas_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.BackColor = Color.FromArgb(82, 101, 143);
            btnPedidos.FlatStyle = FlatStyle.Flat;
            btnPedidos.ForeColor = Color.White;
            btnPedidos.ImageAlign = ContentAlignment.TopCenter;
            btnPedidos.ImageKey = "package.png";
            btnPedidos.ImageList = imageList2;
            btnPedidos.Location = new Point(0, -2);
            btnPedidos.Margin = new Padding(2);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(94, 95);
            btnPedidos.TabIndex = 6;
            btnPedidos.Text = "Pedidos";
            btnPedidos.TextAlign = ContentAlignment.BottomCenter;
            btnPedidos.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPedidos.UseVisualStyleBackColor = false;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(82, 101, 143);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.ForeColor = Color.White;
            btnReportes.ImageAlign = ContentAlignment.TopCenter;
            btnReportes.ImageKey = "bar-chart.png";
            btnReportes.ImageList = imageList2;
            btnReportes.Location = new Point(0, 472);
            btnReportes.Margin = new Padding(2);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(94, 95);
            btnReportes.TabIndex = 11;
            btnReportes.Text = "Reportes";
            btnReportes.TextImageRelation = TextImageRelation.ImageAboveText;
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
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
            btnStock.Location = new Point(0, 92);
            btnStock.Margin = new Padding(2);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(94, 95);
            btnStock.TabIndex = 7;
            btnStock.Text = "Inventario";
            btnStock.TextImageRelation = TextImageRelation.ImageAboveText;
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column8, Column9, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(132, 180);
            dataGridView1.Margin = new Padding(4, 2, 4, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1181, 532);
            dataGridView1.TabIndex = 52;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "IDEmpleado";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column8
            // 
            Column8.HeaderText = "Apellido P";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Apellido M";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            // 
            // Column3
            // 
            Column3.HeaderText = "Correo";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Telefono";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "RFC";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Contraseña";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Puesto";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(2651, 52);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 17;
            label4.Text = "Supervisor";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(2651, 18);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(255, 32);
            label1.TabIndex = 18;
            label1.Text = "Bienvenido: Fulanito";
            label1.TextAlign = ContentAlignment.TopCenter;
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
            panel1.Location = new Point(1, 88);
            panel1.Margin = new Padding(1, 2, 1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(94, 672);
            panel1.TabIndex = 43;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(2121, 18);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(272, 48);
            label3.TabIndex = 19;
            label3.Text = "Gestión de citas";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel7.BackColor = Color.FromArgb(51, 58, 86);
            panel7.Controls.Add(panel6);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(pictureBox13);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(label1);
            panel7.ForeColor = Color.White;
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(4, 5, 4, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(1334, 95);
            panel7.TabIndex = 44;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(pictureBox1);
            panel6.Controls.Add(lblNombre);
            panel6.Controls.Add(lblTipoEmpleado);
            panel6.Location = new Point(1074, 0);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(259, 112);
            panel6.TabIndex = 24;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 25);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(61, 32);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(183, 28);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Bienvenido: Alfredo";
            // 
            // lblTipoEmpleado
            // 
            lblTipoEmpleado.AutoSize = true;
            lblTipoEmpleado.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoEmpleado.Location = new Point(64, 62);
            lblTipoEmpleado.Margin = new Padding(2, 0, 2, 0);
            lblTipoEmpleado.Name = "lblTipoEmpleado";
            lblTipoEmpleado.Size = new Size(89, 23);
            lblTipoEmpleado.TabIndex = 1;
            lblTipoEmpleado.Text = "Supervisor";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(134, 25);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(134, 45);
            label7.TabIndex = 23;
            label7.Text = "SIVAA";
            // 
            // pictureBox13
            // 
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(2, 0);
            pictureBox13.Margin = new Padding(1, 2, 1, 2);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(66, 95);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 21;
            pictureBox13.TabStop = false;
            pictureBox13.Click += pictureBox13_Click;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Bottom;
            label6.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(0, 55);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(1334, 40);
            label6.TabIndex = 20;
            label6.Text = "Gestionar Empleados";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.x;
            pictureBox11.Location = new Point(131, 10);
            pictureBox11.Margin = new Padding(4, 2, 4, 2);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(54, 52);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 47;
            pictureBox11.TabStop = false;
            pictureBox11.Click += pictureBox11_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.edit_2;
            pictureBox9.Location = new Point(70, 10);
            pictureBox9.Margin = new Padding(4, 2, 4, 2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(54, 52);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 46;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(8, 10);
            pictureBox8.Margin = new Padding(4, 2, 4, 2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(54, 52);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 45;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(pictureBox8);
            panel2.Controls.Add(pictureBox9);
            panel2.Controls.Add(pictureBox11);
            panel2.Location = new Point(132, 102);
            panel2.Margin = new Padding(4, 2, 4, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1181, 68);
            panel2.TabIndex = 53;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.print_FILL0_wght400_GRAD0_opsz48;
            pictureBox2.Location = new Point(192, 10);
            pictureBox2.Margin = new Padding(4, 2, 4, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 52);
            pictureBox2.TabIndex = 63;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(comboempleado);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(txtbusqueda);
            panel3.Location = new Point(276, 8);
            panel3.Margin = new Padding(4, 2, 4, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(901, 58);
            panel3.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(210, 18);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 26);
            label2.TabIndex = 104;
            label2.Text = "Filtrar por:";
            // 
            // comboempleado
            // 
            comboempleado.FormattingEnabled = true;
            comboempleado.Items.AddRange(new object[] { "Todos", "IDEmpleado", "Nombre", "ApellidoPaterno", "ApellidoMaterno", "Correo", "Teléfono", "RFC", "Contraseña", "Tipo" });
            comboempleado.Location = new Point(338, 10);
            comboempleado.Margin = new Padding(2);
            comboempleado.Name = "comboempleado";
            comboempleado.Size = new Size(182, 33);
            comboempleado.TabIndex = 103;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(82, 101, 143);
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(746, 2);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(150, 48);
            button1.TabIndex = 102;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtbusqueda.BackColor = Color.White;
            txtbusqueda.ForeColor = SystemColors.ControlText;
            txtbusqueda.Location = new Point(535, 12);
            txtbusqueda.Margin = new Padding(4, 2, 4, 2);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.PlaceholderText = "Ingrese su busqueda";
            txtbusqueda.Size = new Size(192, 31);
            txtbusqueda.TabIndex = 101;
            // 
            // GestionarEmpleados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1334, 750);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel7);
            Margin = new Padding(4, 2, 4, 2);
            Name = "GestionarEmpleados";
            Text = "NuevoEmpleado";
            WindowState = FormWindowState.Maximized;
            Load += GestionarEmpleados_Load;
            VisibleChanged += GestionarEmpleados_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCobros;
        private ImageList imageList2;
        private Button btnVentas;
        private Button btnCitas;
        private Button btnPedidos;
        private Button btnReportes;
        private Button btnStock;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private Panel panel7;
        private PictureBox pictureBox11;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private Panel panel2;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox13;
        private Panel panel3;
        private Panel panel6;
        private PictureBox pictureBox1;
        private Label lblNombre;
        private Label lblTipoEmpleado;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Label label2;
        private ComboBox comboempleado;
        private Button button1;
        private TextBox txtbusqueda;
    }
}