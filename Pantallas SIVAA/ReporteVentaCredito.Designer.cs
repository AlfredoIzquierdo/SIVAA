namespace Pantallas_SIVAA
{
    partial class ReporteVentaCredito
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
            lblfecha = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            lblnombreempleado = new Label();
            label5 = new Label();
            panel1 = new Panel();
            lblidempleado = new Label();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel6 = new Panel();
            lblPeriodo = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblfecha
            // 
            lblfecha.AutoSize = true;
            lblfecha.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblfecha.Location = new Point(238, 153);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new Size(112, 25);
            lblfecha.TabIndex = 53;
            lblfecha.Text = "08/03/2023";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.print_FILL0_wght400_GRAD0_opsz48;
            pictureBox1.Location = new Point(1217, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 44);
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(11, 153);
            label6.Name = "label6";
            label6.Size = new Size(199, 25);
            label6.TabIndex = 50;
            label6.Text = "Fecha de expedicion:";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Enabled = false;
            dataGridView1.Location = new Point(15, 240);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1256, 416);
            dataGridView1.TabIndex = 49;
            // 
            // lblnombreempleado
            // 
            lblnombreempleado.AutoSize = true;
            lblnombreempleado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblnombreempleado.Location = new Point(257, 120);
            lblnombreempleado.Name = "lblnombreempleado";
            lblnombreempleado.Size = new Size(81, 25);
            lblnombreempleado.TabIndex = 48;
            lblnombreempleado.Text = "Fulanito";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(11, 120);
            label5.Name = "label5";
            label5.Size = new Size(219, 25);
            label5.TabIndex = 47;
            label5.Text = "Nombre del que expide:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblidempleado);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1298, 82);
            panel1.TabIndex = 55;
            // 
            // lblidempleado
            // 
            lblidempleado.AutoSize = true;
            lblidempleado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblidempleado.ForeColor = SystemColors.ActiveCaptionText;
            lblidempleado.Location = new Point(833, 40);
            lblidempleado.Name = "lblidempleado";
            lblidempleado.Size = new Size(49, 25);
            lblidempleado.TabIndex = 3;
            lblidempleado.Text = "C21";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(790, 17);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 2;
            label3.Text = "IDEmpleado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(11, 27);
            label1.Name = "label1";
            label1.Size = new Size(320, 29);
            label1.TabIndex = 0;
            label1.Text = "Reporte de venta al contado:";
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(848, 84);
            panel2.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Location = new Point(493, -1);
            panel6.Name = "panel6";
            panel6.Size = new Size(792, 91);
            panel6.TabIndex = 8;
            // 
            // lblPeriodo
            // 
            lblPeriodo.AutoSize = true;
            lblPeriodo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPeriodo.Location = new Point(242, 193);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Size = new Size(112, 25);
            lblPeriodo.TabIndex = 54;
            lblPeriodo.Text = "08/03/2023";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 193);
            label2.Name = "label2";
            label2.Size = new Size(192, 25);
            label2.TabIndex = 51;
            label2.Text = "Fecha de busqueda:";
            // 
            // ReporteVentaCredito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1298, 665);
            Controls.Add(lblfecha);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(lblnombreempleado);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(lblPeriodo);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReporteVentaCredito";
            Text = "ReporteVentaCredito";
            Load += ReporteVentaCredito_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblfecha;
        private PictureBox pictureBox1;
        private Label label6;
        private DataGridView dataGridView1;
        private Label lblnombreempleado;
        private Label label5;
        private Panel panel1;
        private Label lblidempleado;
        private Label label3;
        private Label label1;
        private Panel panel2;
        private Panel panel6;
        private Label lblPeriodo;
        private Label label2;
    }
}