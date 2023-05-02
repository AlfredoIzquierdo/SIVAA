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
            printDocument1 = new System.Drawing.Printing.PrintDocument();
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
            dataGridView1.Location = new Point(10, 172);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(872, 449);
            dataGridView1.TabIndex = 49;
            // 
            // lblfecha
            // 
            lblfecha.AutoSize = true;
            lblfecha.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblfecha.Location = new Point(208, 108);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new Size(89, 20);
            lblfecha.TabIndex = 48;
            lblfecha.Text = "08/03/2023";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.print_FILL0_wght400_GRAD0_opsz48;
            pictureBox1.Location = new Point(836, 104);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 33);
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblnombreempleado
            // 
            lblnombreempleado.AutoSize = true;
            lblnombreempleado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblnombreempleado.Location = new Point(225, 83);
            lblnombreempleado.Name = "lblnombreempleado";
            lblnombreempleado.Size = new Size(66, 20);
            lblnombreempleado.TabIndex = 45;
            lblnombreempleado.Text = "Fulanito";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 83);
            label5.Name = "label5";
            label5.Size = new Size(175, 20);
            label5.TabIndex = 44;
            label5.Text = "Nombre del que expide:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(10, 108);
            label6.Name = "label6";
            label6.Size = new Size(159, 20);
            label6.TabIndex = 46;
            label6.Text = "Fecha de expedicion:";
            // 
            // lblidempleado
            // 
            lblidempleado.AutoSize = true;
            lblidempleado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblidempleado.ForeColor = SystemColors.ActiveCaptionText;
            lblidempleado.Location = new Point(694, 26);
            lblidempleado.Name = "lblidempleado";
            lblidempleado.Size = new Size(38, 20);
            lblidempleado.TabIndex = 43;
            lblidempleado.Text = "E21";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(656, 9);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 42;
            label3.Text = "IDEmpleado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(116, 12);
            label1.Name = "label1";
            label1.Size = new Size(136, 29);
            label1.TabIndex = 41;
            label1.Text = "Empleados";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(908, 58);
            panel1.TabIndex = 50;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(-1, -1);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(492, 58);
            panel2.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 137);
            label2.Name = "label2";
            label2.Size = new Size(155, 20);
            label2.TabIndex = 46;
            label2.Text = "Fecha de busqueda:";
            // 
            // lblPeriodo
            // 
            lblPeriodo.AutoSize = true;
            lblPeriodo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPeriodo.Location = new Point(208, 137);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Size = new Size(89, 20);
            lblPeriodo.TabIndex = 48;
            lblPeriodo.Text = "08/03/2023";
            // 
            // printDocument1
            // 
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.EndPrint += printDocument1_EndPrint;
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // ReporteContadoContraCredito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(894, 631);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}