namespace Pantallas_SIVAA
{
    partial class Corte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Corte));
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            pictureBox13 = new PictureBox();
            btnCobros = new Button();
            imageList2 = new ImageList(components);
            btnVentas = new Button();
            btnCitas = new Button();
            btnStock = new Button();
            btnPedidos = new Button();
            btnReportes = new Button();
            panel3 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            dataGridView1 = new DataGridView();
            panel7 = new Panel();
            lblTipoEmpleado = new Label();
            lblNombre = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3024, 39);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 39;
            label4.Text = "Supervisor";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(442, 16);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(358, 41);
            label2.TabIndex = 20;
            label2.Text = "Historial de cortes de caja";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3010, 12);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 28);
            label1.TabIndex = 40;
            label1.Text = "Fulanito";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(122, 20);
            label7.Name = "label7";
            label7.Size = new Size(91, 36);
            label7.TabIndex = 16;
            label7.Text = "SIVAA";
            // 
            // pictureBox13
            // 
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(11, 0);
            pictureBox13.Margin = new Padding(1, 3, 1, 3);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(53, 76);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 2;
            pictureBox13.TabStop = false;
            pictureBox13.Click += pictureBox13_Click;
            // 
            // btnCobros
            // 
            btnCobros.BackColor = Color.FromArgb(82, 101, 143);
            btnCobros.FlatStyle = FlatStyle.Flat;
            btnCobros.ForeColor = Color.White;
            btnCobros.ImageAlign = ContentAlignment.TopCenter;
            btnCobros.ImageKey = "dollar-sign.png";
            btnCobros.ImageList = imageList2;
            btnCobros.Location = new Point(0, 301);
            btnCobros.Margin = new Padding(2, 3, 2, 3);
            btnCobros.Name = "btnCobros";
            btnCobros.Size = new Size(75, 76);
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
            btnVentas.Location = new Point(0, 225);
            btnVentas.Margin = new Padding(2, 3, 2, 3);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(75, 76);
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
            btnCitas.Location = new Point(0, 149);
            btnCitas.Margin = new Padding(2, 3, 2, 3);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(75, 76);
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
            btnStock.Location = new Point(0, 73);
            btnStock.Margin = new Padding(2, 3, 2, 3);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(75, 76);
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
            btnPedidos.Margin = new Padding(2, 3, 2, 3);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(75, 76);
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
            btnReportes.Location = new Point(0, 377);
            btnReportes.Margin = new Padding(2, 3, 2, 3);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(75, 76);
            btnReportes.TabIndex = 11;
            btnReportes.Text = "Reportes";
            btnReportes.TextImageRelation = TextImageRelation.ImageAboveText;
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(comboBox2);
            panel3.Location = new Point(434, 92);
            panel3.Name = "panel3";
            panel3.Size = new Size(565, 47);
            panel3.TabIndex = 69;
            // 
            // button1
            // 
            button1.Location = new Point(449, 13);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 70;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(302, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 13);
            label3.Name = "label3";
            label3.Size = new Size(92, 22);
            label3.TabIndex = 53;
            label3.Text = "Filtrar por:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Todos", "IDCorteCaja", "IDEmpleado", "Dia", "Mes", "Año" });
            comboBox2.Location = new Point(98, 12);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(166, 28);
            comboBox2.TabIndex = 55;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(109, 157);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1197, 458);
            dataGridView1.TabIndex = 68;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(51, 58, 86);
            panel7.Controls.Add(lblTipoEmpleado);
            panel7.Controls.Add(lblNombre);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(label1);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(pictureBox13);
            panel7.Dock = DockStyle.Top;
            panel7.ForeColor = Color.White;
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(1318, 76);
            panel7.TabIndex = 63;
            // 
            // lblTipoEmpleado
            // 
            lblTipoEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTipoEmpleado.AutoSize = true;
            lblTipoEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoEmpleado.Location = new Point(1120, 49);
            lblTipoEmpleado.Margin = new Padding(2, 0, 2, 0);
            lblTipoEmpleado.Name = "lblTipoEmpleado";
            lblTipoEmpleado.Size = new Size(78, 20);
            lblTipoEmpleado.TabIndex = 41;
            lblTipoEmpleado.Text = "Supervisor";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(1054, 16);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(217, 28);
            lblNombre.TabIndex = 42;
            lblNombre.Text = "Bienvenido: Fulanito";
            lblNombre.TextAlign = ContentAlignment.TopCenter;
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
            panel1.Location = new Point(0, 76);
            panel1.Margin = new Padding(1, 3, 1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(75, 552);
            panel1.TabIndex = 64;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.print_FILL0_wght400_GRAD0_opsz48;
            pictureBox1.Location = new Point(109, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 41);
            pictureBox1.TabIndex = 70;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Corte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1318, 628);
            Controls.Add(panel1);
            Controls.Add(panel7);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(dataGridView1);
            Name = "Corte";
            Text = "Corte";
            WindowState = FormWindowState.Maximized;
            Load += Corte_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label4;
        private Label label2;
        private Label label1;
        private Label label7;
        private PictureBox pictureBox13;
        private Button btnCobros;
        private ImageList imageList2;
        private Button btnVentas;
        private Button btnCitas;
        private Button btnStock;
        private Button btnPedidos;
        private Button btnReportes;
        private Panel panel3;
        private Label label3;
        private ComboBox comboBox2;
        private DataGridView dataGridView1;
        private Panel panel7;
        private Panel panel1;
        private Label lblTipoEmpleado;
        private Label lblNombre;
        private Button button1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}