namespace Pantallas_SIVAA
{
    partial class ReporteContadoContraCredito
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
            dataGridView1 = new DataGridView();
            lblfecha = new Label();
            pictureBox1 = new PictureBox();
            lblnombreempleado = new Label();
            label5 = new Label();
            label6 = new Label();
            lblidempleado = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            lblPeriodo = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Enabled = false;
            dataGridView1.Location = new Point(12, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1020, 376);
            dataGridView1.TabIndex = 49;
            // 
            // lblfecha
            // 
            lblfecha.AutoSize = true;
            lblfecha.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblfecha.Location = new Point(238, 144);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new Size(112, 25);
            lblfecha.TabIndex = 48;
            lblfecha.Text = "08/03/2023";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.print_FILL0_wght400_GRAD0_opsz48;
            pictureBox1.Location = new Point(955, 139);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 44);
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // lblnombreempleado
            // 
            lblnombreempleado.AutoSize = true;
            lblnombreempleado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblnombreempleado.Location = new Point(257, 111);
            lblnombreempleado.Name = "lblnombreempleado";
            lblnombreempleado.Size = new Size(81, 25);
            lblnombreempleado.TabIndex = 45;
            lblnombreempleado.Text = "Fulanito";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 111);
            label5.Name = "label5";
            label5.Size = new Size(219, 25);
            label5.TabIndex = 44;
            label5.Text = "Nombre del que expide:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 144);
            label6.Name = "label6";
            label6.Size = new Size(199, 25);
            label6.TabIndex = 46;
            label6.Text = "Fecha de expedicion:";
            // 
            // lblidempleado
            // 
            lblidempleado.AutoSize = true;
            lblidempleado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblidempleado.ForeColor = SystemColors.ActiveCaptionText;
            lblidempleado.Location = new Point(793, 35);
            lblidempleado.Name = "lblidempleado";
            lblidempleado.Size = new Size(47, 25);
            lblidempleado.TabIndex = 43;
            lblidempleado.Text = "E21";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(750, 12);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 42;
            label3.Text = "IDEmpleado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(132, 16);
            label1.Name = "label1";
            label1.Size = new Size(163, 36);
            label1.TabIndex = 41;
            label1.Text = "Empleados";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1037, 76);
            panel1.TabIndex = 50;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(-1, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(562, 76);
            panel2.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 183);
            label2.Name = "label2";
            label2.Size = new Size(192, 25);
            label2.TabIndex = 46;
            label2.Text = "Fecha de busqueda:";
            // 
            // lblPeriodo
            // 
            lblPeriodo.AutoSize = true;
            lblPeriodo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPeriodo.Location = new Point(238, 183);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Size = new Size(112, 25);
            lblPeriodo.TabIndex = 48;
            lblPeriodo.Text = "08/03/2023";
            // 
            // ReporteContadoContraCredito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1044, 618);
            Controls.Add(dataGridView1);
            Controls.Add(lblPeriodo);
            Controls.Add(lblfecha);
            Controls.Add(pictureBox1);
            Controls.Add(lblnombreempleado);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(lblidempleado);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "ReporteContadoContraCredito";
            Text = "ReporteContadoContraCredito";
            Load += ReporteContadoContraCredito_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblfecha;
        private PictureBox pictureBox1;
        private Label lblnombreempleado;
        private Label label5;
        private Label label6;
        private Label lblidempleado;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label lblPeriodo;
    }
}