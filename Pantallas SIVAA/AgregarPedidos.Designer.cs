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
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panel7.Margin = new Padding(4, 5, 4, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(953, 95);
            panel7.TabIndex = 38;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(14, 0);
            pictureBox13.Margin = new Padding(1, 3, 1, 3);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(66, 95);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 40;
            pictureBox13.TabStop = false;
            pictureBox13.Click += pictureBox2_Click;
            // 
            // lblTipoEmpleado
            // 
            lblTipoEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTipoEmpleado.AutoSize = true;
            lblTipoEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoEmpleado.Location = new Point(769, 57);
            lblTipoEmpleado.Margin = new Padding(1, 0, 1, 0);
            lblTipoEmpleado.Name = "lblTipoEmpleado";
            lblTipoEmpleado.Size = new Size(78, 20);
            lblTipoEmpleado.TabIndex = 41;
            lblTipoEmpleado.Text = "Supervisor";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(417, 20);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(227, 41);
            label2.TabIndex = 20;
            label2.Text = "Agregar pedido";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(756, 16);
            lblNombre.Margin = new Padding(1, 0, 1, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(93, 28);
            lblNombre.TabIndex = 42;
            lblNombre.Text = "Fulanito";
            lblNombre.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(154, 23);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(114, 45);
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
            panel1.Location = new Point(0, 95);
            panel1.Margin = new Padding(1, 3, 1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(94, 473);
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
            btnReportes.Location = new Point(0, 472);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(94, 95);
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
            btnCobros.Location = new Point(0, 377);
            btnCobros.Name = "btnCobros";
            btnCobros.Size = new Size(94, 95);
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
            btnVentas.Location = new Point(0, 282);
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
            btnCitas.Location = new Point(0, 187);
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
            btnStock.ForeColor = Color.White;
            btnStock.ImageAlign = ContentAlignment.TopCenter;
            btnStock.ImageKey = "book-open.png";
            btnStock.ImageList = imageList2;
            btnStock.Location = new Point(0, 92);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(94, 95);
            btnStock.TabIndex = 7;
            btnStock.Text = "Stock";
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
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(94, 95);
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
            pictureBox4.Location = new Point(371, 183);
            pictureBox4.Margin = new Padding(4, 5, 4, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(59, 57);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 109;
            pictureBox4.TabStop = false;
            // 
            // cbProov
            // 
            cbProov.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProov.FormattingEnabled = true;
            cbProov.Items.AddRange(new object[] { "AutoSur", "NissCar", "AutoT", "NisAuto", "AutoYa", "AutoG", "NissMX", "AutosP", "AutoK" });
            cbProov.Location = new Point(450, 212);
            cbProov.Name = "cbProov";
            cbProov.Size = new Size(178, 28);
            cbProov.TabIndex = 110;
            cbProov.SelectedIndexChanged += cbProov_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(450, 172);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 111;
            label1.Text = "Proveedor:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.calendar;
            pictureBox1.Location = new Point(371, 265);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 112;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(450, 251);
            label3.Name = "label3";
            label3.Size = new Size(170, 28);
            label3.TabIndex = 113;
            label3.Text = "Fecha de recibido:";
            // 
            // numericUpDownDia
            // 
            numericUpDownDia.Location = new Point(450, 295);
            numericUpDownDia.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            numericUpDownDia.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownDia.Name = "numericUpDownDia";
            numericUpDownDia.Size = new Size(39, 27);
            numericUpDownDia.TabIndex = 114;
            numericUpDownDia.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownMes
            // 
            numericUpDownMes.Location = new Point(518, 295);
            numericUpDownMes.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numericUpDownMes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownMes.Name = "numericUpDownMes";
            numericUpDownMes.Size = new Size(39, 27);
            numericUpDownMes.TabIndex = 115;
            numericUpDownMes.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownAno
            // 
            numericUpDownAno.Location = new Point(585, 295);
            numericUpDownAno.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            numericUpDownAno.Minimum = new decimal(new int[] { 2023, 0, 0, 0 });
            numericUpDownAno.Name = "numericUpDownAno";
            numericUpDownAno.Size = new Size(58, 27);
            numericUpDownAno.TabIndex = 116;
            numericUpDownAno.Value = new decimal(new int[] { 2023, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(450, 355);
            label4.Name = "label4";
            label4.Size = new Size(86, 28);
            label4.TabIndex = 117;
            label4.Text = "Importe:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.billete;
            pictureBox2.Location = new Point(371, 365);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 57);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 118;
            pictureBox2.TabStop = false;
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(455, 395);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(188, 27);
            txtImporte.TabIndex = 119;
            txtImporte.TextChanged += txtImporte_TextChanged;
            txtImporte.KeyDown += textBox1_KeyDown;
            txtImporte.KeyPress += txtImporte_KeyPress;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(82, 101, 143);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(428, 472);
            button1.Name = "button1";
            button1.Size = new Size(174, 57);
            button1.TabIndex = 120;
            button1.Text = "Finalizar pedido";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AgregarPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 568);
            Controls.Add(button1);
            Controls.Add(txtImporte);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(numericUpDownAno);
            Controls.Add(numericUpDownMes);
            Controls.Add(numericUpDownDia);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(cbProov);
            Controls.Add(pictureBox4);
            Controls.Add(panel1);
            Controls.Add(panel7);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AgregarPedidos";
            Text = "Agregar";
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
            ResumeLayout(false);
            PerformLayout();
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
    }
}