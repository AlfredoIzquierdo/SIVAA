namespace Pantallas_SIVAA
{
    partial class ReporteCrudInventario
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblFecha = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            lblnombreempleado = new Label();
            label5 = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            label4 = new Label();
            panel8 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            label43 = new Label();
            panel3 = new Panel();
            label14 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label41 = new Label();
            label40 = new Label();
            label39 = new Label();
            label38 = new Label();
            pictureBox3 = new PictureBox();
            label12 = new Label();
            label11 = new Label();
            label9 = new Label();
            lblidempleado = new Label();
            label3 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(37, 59);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(89, 20);
            lblFecha.TabIndex = 45;
            lblFecha.Text = "08/03/2023";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.print_FILL0_wght400_GRAD0_opsz48;
            pictureBox1.Location = new Point(731, 172);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 33);
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Enabled = false;
            dataGridView1.GridColor = SystemColors.ButtonShadow;
            dataGridView1.Location = new Point(13, 255);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(785, 336);
            dataGridView1.TabIndex = 41;
            // 
            // Column1
            // 
            Column1.HeaderText = "No Serie";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Vehiculo";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Version";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Modelo";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Color";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // lblnombreempleado
            // 
            lblnombreempleado.AutoSize = true;
            lblnombreempleado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblnombreempleado.Location = new Point(228, 156);
            lblnombreempleado.Name = "lblnombreempleado";
            lblnombreempleado.Size = new Size(66, 20);
            lblnombreempleado.TabIndex = 40;
            lblnombreempleado.Text = "Fulanito";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(13, 156);
            label5.Name = "label5";
            label5.Size = new Size(175, 20);
            label5.TabIndex = 39;
            label5.Text = "Nombre del que expide:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lblnombreempleado);
            panel1.Controls.Add(lblidempleado);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 576);
            panel1.TabIndex = 46;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(51, 58, 86);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(-39, 221);
            panel5.Name = "panel5";
            panel5.Size = new Size(888, 22);
            panel5.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(85, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 19);
            label4.TabIndex = 0;
            label4.Text = "Reporte";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(51, 58, 86);
            panel8.Controls.Add(panel4);
            panel8.Controls.Add(label43);
            panel8.Location = new Point(-76, 127);
            panel8.Name = "panel8";
            panel8.Size = new Size(888, 22);
            panel8.TabIndex = 47;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(51, 58, 86);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(6, 77);
            panel4.Name = "panel4";
            panel4.Size = new Size(888, 22);
            panel4.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(85, 0);
            label1.Name = "label1";
            label1.Size = new Size(140, 19);
            label1.TabIndex = 0;
            label1.Text = "Datos del que expide:";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label43.ForeColor = SystemColors.ButtonHighlight;
            label43.Location = new Point(121, 0);
            label43.Name = "label43";
            label43.Size = new Size(140, 19);
            label43.TabIndex = 0;
            label43.Text = "Datos del que expide:";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label14);
            panel3.Controls.Add(lblFecha);
            panel3.Location = new Point(638, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(170, 113);
            panel3.TabIndex = 46;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(3, 28);
            label14.Name = "label14";
            label14.Size = new Size(149, 21);
            label14.TabIndex = 16;
            label14.Text = "Fecha de expedicion";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label41);
            panel2.Controls.Add(label40);
            panel2.Controls.Add(label39);
            panel2.Controls.Add(label38);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(-1, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(635, 113);
            panel2.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(501, 57);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 21;
            label2.Text = "AS12546SQ94";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label41.Location = new Point(442, 81);
            label41.Name = "label41";
            label41.Size = new Size(100, 21);
            label41.TabIndex = 20;
            label41.Text = "6121767223";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label40.Location = new Point(334, 29);
            label40.Name = "label40";
            label40.Size = new Size(107, 21);
            label40.TabIndex = 19;
            label40.Text = "INVENTARIO";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label39.Location = new Point(266, 81);
            label39.Name = "label39";
            label39.Size = new Size(84, 21);
            label39.TabIndex = 18;
            label39.Text = "C.P: 12312";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label38.Location = new Point(162, 57);
            label38.Name = "label38";
            label38.Size = new Size(265, 21);
            label38.TabIndex = 17;
            label38.Text = "San gregio 126#, Santa fe,BCS,La Paz";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Nissan_logo;
            pictureBox3.Location = new Point(6, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(132, 99);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(365, 81);
            label12.Name = "label12";
            label12.Size = new Size(71, 21);
            label12.TabIndex = 14;
            label12.Text = "Telefono:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(459, 59);
            label11.Name = "label11";
            label11.Size = new Size(42, 21);
            label11.TabIndex = 13;
            label11.Text = "RFC:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(312, 3);
            label9.Name = "label9";
            label9.Size = new Size(150, 21);
            label9.TabIndex = 11;
            label9.Text = "Nissan, La Paz,BCS";
            // 
            // lblidempleado
            // 
            lblidempleado.AutoSize = true;
            lblidempleado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblidempleado.ForeColor = SystemColors.ActiveCaptionText;
            lblidempleado.Location = new Point(228, 181);
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
            label3.Location = new Point(13, 181);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 2;
            label3.Text = "IDEmpleado";
            // 
            // printDocument1
            // 
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.EndPrint += printDocument1_EndPrint;
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // ReporteCrudInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 576);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReporteCrudInventario";
            Text = "ReporteCrudInventario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblFecha;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label lblnombreempleado;
        private Label label5;
        private Panel panel1;
        private Label lblidempleado;
        private Label label3;
        private Panel panel2;
        private Label label2;
        private Label label41;
        private Label label40;
        private Label label39;
        private Label label38;
        private PictureBox pictureBox3;
        private Label label12;
        private Label label11;
        private Label label9;
        private Panel panel3;
        private Label label14;
        private Panel panel8;
        private Label label43;
        private Panel panel5;
        private Label label4;
        private Panel panel4;
        private Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}