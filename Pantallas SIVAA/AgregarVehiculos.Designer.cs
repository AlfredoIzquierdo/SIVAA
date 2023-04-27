namespace Pantallas_SIVAA
{
    partial class AgregarVehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarVehiculos));
            btnAgregarVehiculo = new Button();
            label15 = new Label();
            txtNombre = new TextBox();
            imageList2 = new ImageList(components);
            panel7 = new Panel();
            lblTipoEmpleado = new Label();
            lblNombre = new Label();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            label7 = new Label();
            pictureBox13 = new PictureBox();
            panel1 = new Panel();
            btnReportes = new Button();
            btnCobros = new Button();
            btnVentas = new Button();
            btnCitas = new Button();
            btnStock = new Button();
            btnPedidos = new Button();
            btnRegresar = new Button();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregarVehiculo
            // 
            btnAgregarVehiculo.Anchor = AnchorStyles.Bottom;
            btnAgregarVehiculo.BackColor = Color.FromArgb(51, 58, 86);
            btnAgregarVehiculo.ForeColor = Color.White;
            btnAgregarVehiculo.Location = new Point(457, 358);
            btnAgregarVehiculo.Margin = new Padding(3, 4, 3, 4);
            btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            btnAgregarVehiculo.Size = new Size(177, 30);
            btnAgregarVehiculo.TabIndex = 108;
            btnAgregarVehiculo.Text = "Agregar";
            btnAgregarVehiculo.UseVisualStyleBackColor = false;
            btnAgregarVehiculo.Click += btnAgregarVehiculo_Click;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top;
            label15.AutoSize = true;
            label15.Location = new Point(366, 218);
            label15.Name = "label15";
            label15.Size = new Size(64, 20);
            label15.TabIndex = 110;
            label15.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top;
            txtNombre.Location = new Point(259, 262);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.MaxLength = 10;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(266, 27);
            txtNombre.TabIndex = 112;
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
            panel7.Controls.Add(lblTipoEmpleado);
            panel7.Controls.Add(lblNombre);
            panel7.Controls.Add(label1);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(pictureBox13);
            panel7.ForeColor = Color.White;
            panel7.Location = new Point(3, 6);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(782, 76);
            panel7.TabIndex = 118;
            // 
            // lblTipoEmpleado
            // 
            lblTipoEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTipoEmpleado.AutoSize = true;
            lblTipoEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoEmpleado.Location = new Point(639, 50);
            lblTipoEmpleado.Margin = new Padding(1, 0, 1, 0);
            lblTipoEmpleado.Name = "lblTipoEmpleado";
            lblTipoEmpleado.Size = new Size(78, 20);
            lblTipoEmpleado.TabIndex = 18;
            lblTipoEmpleado.Text = "Supervisor";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(530, 18);
            lblNombre.Margin = new Padding(1, 0, 1, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(217, 28);
            lblNombre.TabIndex = 19;
            lblNombre.Text = "Bienvenido: Fulanito";
            lblNombre.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(278, 18);
            label1.Name = "label1";
            label1.Size = new Size(255, 41);
            label1.TabIndex = 17;
            label1.Text = "Agregar vehiculos";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(2602, 46);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 1;
            label4.Text = "Supervisor";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(2537, 12);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(217, 28);
            label2.TabIndex = 1;
            label2.Text = "Bienvenido: Fulanito";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(130, 20);
            label7.Name = "label7";
            label7.Size = new Size(89, 38);
            label7.TabIndex = 16;
            label7.Text = "SIIVA";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(21, 12);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(66, 67);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 2;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox13_Click);
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
            panel1.Location = new Point(3, 84);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(75, 464);
            panel1.TabIndex = 117;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(101)))), ((int)(((byte)(143)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReportes.ImageKey = "bar-chart.png";
            this.btnReportes.ImageList = this.imageList2;
            this.btnReportes.Location = new System.Drawing.Point(0, 480);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(103, 95);
            this.btnReportes.TabIndex = 10;
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
            this.btnCobros.Location = new System.Drawing.Point(0, 383);
            this.btnCobros.Name = "btnCobros";
            this.btnCobros.Size = new System.Drawing.Size(103, 95);
            this.btnCobros.TabIndex = 9;
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
            this.btnVentas.Location = new System.Drawing.Point(0, 287);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(103, 95);
            this.btnVentas.TabIndex = 8;
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
            this.btnCitas.Location = new System.Drawing.Point(0, 193);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(103, 95);
            this.btnCitas.TabIndex = 7;
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
            this.btnStock.Location = new System.Drawing.Point(0, 97);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(103, 95);
            this.btnStock.TabIndex = 6;
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
            this.btnPedidos.Location = new System.Drawing.Point(0, 3);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(103, 95);
            this.btnPedidos.TabIndex = 5;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnRegresar
            // 
            btnRegresar.Anchor = AnchorStyles.Bottom;
            btnRegresar.BackColor = Color.FromArgb(51, 58, 86);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(171, 358);
            btnRegresar.Margin = new Padding(2, 2, 2, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(160, 30);
            btnRegresar.TabIndex = 119;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // AgregarVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 692);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnAgregarVehiculo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AgregarVehiculos";
            this.Text = "AgregarVehiculos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AgregarVehiculos_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnAgregarVehiculo;
        private Label label15;
        private TextBox txtNombre;
        private ImageList imageList2;
        private Panel panel7;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label7;
        private PictureBox pictureBox13;
        private Panel panel1;
        private Button btnReportes;
        private Button btnCobros;
        private Button btnVentas;
        private Button btnCitas;
        private Button btnStock;
        private Button btnPedidos;
        private Button btnRegresar;
        private Label lblTipoEmpleado;
        private Label lblNombre;
    }
}