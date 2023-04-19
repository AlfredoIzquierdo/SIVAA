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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarioCitas));
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            imageList2 = new ImageList(components);
            panel7 = new Panel();
            label8 = new Label();
            lblTipoEmpleado = new Label();
            lblNombre = new Label();
            label7 = new Label();
            pictureBox13 = new PictureBox();
            panel1 = new Panel();
            btnReportes = new Button();
            btnCobros = new Button();
            btnVentas = new Button();
            btnCitas = new Button();
            btnStock = new Button();
            btnPedidos = new Button();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            btnTodo = new Button();
            numericUpDown3 = new NumericUpDown();
            label2 = new Label();
            numericUpDown2 = new NumericUpDown();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            btnBuscar = new Button();
            label11 = new Label();
            pictureBox11 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column2, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(96, 205);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1356, 593);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "IDCita";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "IDEmpleado";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "IDCliente";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Dia";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Mes";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Año";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Hora";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
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
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel7.BackColor = Color.FromArgb(51, 58, 86);
            panel7.Controls.Add(label8);
            panel7.Controls.Add(lblTipoEmpleado);
            panel7.Controls.Add(lblNombre);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(pictureBox13);
            panel7.ForeColor = Color.White;
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(4, 5, 4, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(1604, 95);
            panel7.TabIndex = 37;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(776, 22);
            label8.Margin = new Padding(1, 0, 1, 0);
            label8.Name = "label8";
            label8.Size = new Size(96, 48);
            label8.TabIndex = 22;
            label8.Text = "Citas";
            // 
            // lblTipoEmpleado
            // 
            lblTipoEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTipoEmpleado.AutoSize = true;
            lblTipoEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoEmpleado.Location = new Point(1244, 45);
            lblTipoEmpleado.Margin = new Padding(1, 0, 1, 0);
            lblTipoEmpleado.Name = "lblTipoEmpleado";
            lblTipoEmpleado.Size = new Size(96, 25);
            lblTipoEmpleado.TabIndex = 20;
            lblTipoEmpleado.Text = "Supervisor";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(1244, 12);
            lblNombre.Margin = new Padding(1, 0, 1, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(255, 32);
            lblNombre.TabIndex = 21;
            lblNombre.Text = "Bienvenido: Fulanito";
            lblNombre.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(151, 25);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(114, 45);
            label7.TabIndex = 16;
            label7.Text = "SIVAA";
            // 
            // pictureBox13
            // 
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(21, 0);
            pictureBox13.Margin = new Padding(1, 3, 1, 3);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(66, 95);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 2;
            pictureBox13.TabStop = false;
            pictureBox13.Click += pictureBox13_Click;
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
            panel1.Location = new Point(-1, 95);
            panel1.Margin = new Padding(1, 3, 1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(94, 715);
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
            btnReportes.Location = new Point(0, 472);
            btnReportes.Margin = new Padding(1, 3, 1, 3);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(94, 95);
            btnReportes.TabIndex = 11;
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
            btnCobros.Location = new Point(0, 377);
            btnCobros.Margin = new Padding(1, 3, 1, 3);
            btnCobros.Name = "btnCobros";
            btnCobros.Size = new Size(94, 95);
            btnCobros.TabIndex = 10;
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
            btnVentas.Location = new Point(0, 282);
            btnVentas.Margin = new Padding(1, 3, 1, 3);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(94, 95);
            btnVentas.TabIndex = 9;
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
            btnCitas.Location = new Point(0, 187);
            btnCitas.Margin = new Padding(1, 3, 1, 3);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(94, 95);
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
            btnStock.Location = new Point(0, 92);
            btnStock.Margin = new Padding(1, 3, 1, 3);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(94, 95);
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
            btnPedidos.Margin = new Padding(1, 3, 1, 3);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(94, 95);
            btnPedidos.TabIndex = 6;
            btnPedidos.Text = "Pedidos";
            btnPedidos.TextAlign = ContentAlignment.BottomCenter;
            btnPedidos.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPedidos.UseVisualStyleBackColor = false;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.print_FILL0_wght400_GRAD0_opsz48;
            pictureBox1.Location = new Point(406, 118);
            pictureBox1.Margin = new Padding(4, 2, 4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 52);
            pictureBox1.TabIndex = 64;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.Controls.Add(btnTodo);
            panel3.Controls.Add(numericUpDown3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(numericUpDown2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(numericUpDown1);
            panel3.Controls.Add(btnBuscar);
            panel3.Controls.Add(label11);
            panel3.Location = new Point(476, 118);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(930, 58);
            panel3.TabIndex = 63;
            // 
            // btnTodo
            // 
            btnTodo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTodo.BackColor = Color.FromArgb(82, 101, 143);
            btnTodo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnTodo.ForeColor = SystemColors.ButtonHighlight;
            btnTodo.Location = new Point(4, 3);
            btnTodo.Margin = new Padding(4, 3, 4, 3);
            btnTodo.Name = "btnTodo";
            btnTodo.Size = new Size(170, 47);
            btnTodo.TabIndex = 105;
            btnTodo.Text = "Todas las citas";
            btnTodo.UseVisualStyleBackColor = false;
            btnTodo.Click += btnTodo_Click;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(671, 13);
            numericUpDown3.Maximum = new decimal(new int[] { 2023, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 2022, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(87, 31);
            numericUpDown3.TabIndex = 104;
            numericUpDown3.Value = new decimal(new int[] { 2022, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(646, 17);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(18, 26);
            label2.TabIndex = 103;
            label2.Text = "/";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(584, 13);
            numericUpDown2.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(57, 31);
            numericUpDown2.TabIndex = 102;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(559, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(18, 26);
            label1.TabIndex = 101;
            label1.Text = "/";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(494, 13);
            numericUpDown1.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(57, 31);
            numericUpDown1.TabIndex = 100;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.BackColor = Color.FromArgb(82, 101, 143);
            btnBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Location = new Point(840, 2);
            btnBuscar.Margin = new Padding(4, 3, 4, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(86, 47);
            btnBuscar.TabIndex = 99;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(366, 17);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(123, 26);
            label11.TabIndex = 97;
            label11.Text = "Buscar por:";
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.x;
            pictureBox11.Location = new Point(344, 118);
            pictureBox11.Margin = new Padding(4, 3, 4, 3);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(54, 52);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 62;
            pictureBox11.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.edit_2;
            pictureBox9.Location = new Point(281, 118);
            pictureBox9.Margin = new Padding(4, 3, 4, 3);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(54, 52);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 61;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(219, 118);
            pictureBox8.Margin = new Padding(4, 3, 4, 3);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(54, 52);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 60;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // CalendarioCitas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1604, 810);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(panel1);
            Controls.Add(panel7);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "CalendarioCitas";
            Text = "Citas";
            WindowState = FormWindowState.Maximized;
            Load += Nueva_Cita_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
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
        private PictureBox pictureBox1;
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
    }
}