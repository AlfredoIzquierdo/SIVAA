namespace Pantallas_SIVAA
{
    partial class ReporteVentaContado
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
            label2 = new Label();
            lblPeriodo = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblfecha
            // 
            lblfecha.AutoSize = true;
            lblfecha.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblfecha.Location = new Point(208, 108);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new Size(89, 20);
            lblfecha.TabIndex = 45;
            lblfecha.Text = "08/03/2023";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.print_FILL0_wght400_GRAD0_opsz48;
            pictureBox1.Location = new Point(748, 92);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 33);
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(10, 108);
            label6.Name = "label6";
            label6.Size = new Size(159, 20);
            label6.TabIndex = 42;
            label6.Text = "Fecha de expedicion:";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Enabled = false;
            dataGridView1.Location = new Point(13, 173);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(870, 449);
            dataGridView1.TabIndex = 41;
            // 
            // lblnombreempleado
            // 
            lblnombreempleado.AutoSize = true;
            lblnombreempleado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblnombreempleado.Location = new Point(225, 83);
            lblnombreempleado.Name = "lblnombreempleado";
            lblnombreempleado.Size = new Size(66, 20);
            lblnombreempleado.TabIndex = 40;
            lblnombreempleado.Text = "Fulanito";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 83);
            label5.Name = "label5";
            label5.Size = new Size(175, 20);
            label5.TabIndex = 39;
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(894, 62);
            panel1.TabIndex = 46;
            // 
            // lblidempleado
            // 
            lblidempleado.AutoSize = true;
            lblidempleado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblidempleado.ForeColor = SystemColors.ActiveCaptionText;
            lblidempleado.Location = new Point(729, 30);
            lblidempleado.Name = "lblidempleado";
            lblidempleado.Size = new Size(38, 20);
            lblidempleado.TabIndex = 3;
            lblidempleado.Text = "C21";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(691, 13);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 2;
            label3.Text = "IDEmpleado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(251, 24);
            label1.TabIndex = 0;
            label1.Text = "Reporte de venta al contado:";
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 72);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(742, 63);
            panel2.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Location = new Point(431, -1);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(448, 69);
            panel6.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 138);
            label2.Name = "label2";
            label2.Size = new Size(155, 20);
            label2.TabIndex = 42;
            label2.Text = "Fecha de busqueda:";
            // 
            // lblPeriodo
            // 
            lblPeriodo.AutoSize = true;
            lblPeriodo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPeriodo.Location = new Point(212, 138);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Size = new Size(89, 20);
            lblPeriodo.TabIndex = 45;
            lblPeriodo.Text = "08/03/2023";
            // 
            // printDocument1
            // 
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.EndPrint += printDocument1_EndPrint;
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // ReporteVentaContado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(894, 631);
            Controls.Add(lblPeriodo);
            Controls.Add(lblfecha);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(lblnombreempleado);
            Controls.Add(label5);
            Controls.Add(panel1);
            Name = "ReporteVentaContado";
            Text = "ReporteVentaContado";
            Load += ReporteVentaContado_Load;
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
        private Label label2;
        private Label lblPeriodo;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}