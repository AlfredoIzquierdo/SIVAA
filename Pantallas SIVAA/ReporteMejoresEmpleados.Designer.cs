﻿namespace Pantallas_SIVAA
{
    partial class ReporteMejoresEmpleados
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
            dgvEmpleadosV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel8 = new Panel();
            label43 = new Label();
            lblidempleado = new Label();
            lblperiodo = new Label();
            lblnombrec = new Label();
            label8 = new Label();
            label4 = new Label();
            label51 = new Label();
            panel3 = new Panel();
            label59 = new Label();
            lblmes = new Label();
            label58 = new Label();
            lblano = new Label();
            lbldia = new Label();
            lblidcot = new Label();
            label15 = new Label();
            label14 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            label41 = new Label();
            label40 = new Label();
            label39 = new Label();
            label38 = new Label();
            pictureBox3 = new PictureBox();
            label12 = new Label();
            label11 = new Label();
            label9 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleadosV).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dgvEmpleadosV
            // 
            dgvEmpleadosV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpleadosV.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(51, 58, 86);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEmpleadosV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmpleadosV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleadosV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvEmpleadosV.Enabled = false;
            dgvEmpleadosV.EnableHeadersVisualStyles = false;
            dgvEmpleadosV.Location = new Point(-1, 236);
            dgvEmpleadosV.Margin = new Padding(3, 2, 3, 2);
            dgvEmpleadosV.Name = "dgvEmpleadosV";
            dgvEmpleadosV.RowHeadersVisible = false;
            dgvEmpleadosV.RowHeadersWidth = 51;
            dgvEmpleadosV.RowTemplate.Height = 29;
            dgvEmpleadosV.Size = new Size(897, 383);
            dgvEmpleadosV.TabIndex = 15;
            // 
            // Column1
            // 
            Column1.HeaderText = "IDEmpleado";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre Vendedor";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "No. de ventas credito";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "No. de ventas contado";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "No. total de ventas";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Ganancias generadas($)";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(lblidempleado);
            panel1.Controls.Add(lblperiodo);
            panel1.Controls.Add(lblnombrec);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label51);
            panel1.Location = new Point(-1, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(897, 126);
            panel1.TabIndex = 25;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.printer;
            pictureBox1.Location = new Point(831, 80);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(51, 58, 86);
            panel8.Controls.Add(label43);
            panel8.Location = new Point(0, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(965, 22);
            panel8.TabIndex = 34;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label43.ForeColor = SystemColors.ButtonHighlight;
            label43.Location = new Point(8, 2);
            label43.Name = "label43";
            label43.Size = new Size(140, 19);
            label43.TabIndex = 0;
            label43.Text = "Datos del que expide:";
            // 
            // lblidempleado
            // 
            lblidempleado.AutoSize = true;
            lblidempleado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblidempleado.Location = new Point(170, 54);
            lblidempleado.Name = "lblidempleado";
            lblidempleado.Size = new Size(64, 21);
            lblidempleado.TabIndex = 25;
            lblidempleado.Text = "253458";
            // 
            // lblperiodo
            // 
            lblperiodo.AutoSize = true;
            lblperiodo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblperiodo.Location = new Point(157, 86);
            lblperiodo.Name = "lblperiodo";
            lblperiodo.Size = new Size(16, 21);
            lblperiodo.TabIndex = 20;
            lblperiodo.Text = "-";
            // 
            // lblnombrec
            // 
            lblnombrec.AutoSize = true;
            lblnombrec.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblnombrec.Location = new Point(81, 26);
            lblnombrec.Name = "lblnombrec";
            lblnombrec.Size = new Size(16, 21);
            lblnombrec.TabIndex = 18;
            lblnombrec.Text = "-";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 54);
            label8.Name = "label8";
            label8.Size = new Size(147, 21);
            label8.TabIndex = 7;
            label8.Text = "Clave identificacion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 26);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 0;
            label4.Text = "Nombre:";
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label51.Location = new Point(5, 86);
            label51.Name = "label51";
            label51.Size = new Size(134, 21);
            label51.TabIndex = 3;
            label51.Text = "Periodo abarcado:";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label59);
            panel3.Controls.Add(lblmes);
            panel3.Controls.Add(label58);
            panel3.Controls.Add(lblano);
            panel3.Controls.Add(lbldia);
            panel3.Controls.Add(lblidcot);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label14);
            panel3.Location = new Point(712, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(184, 114);
            panel3.TabIndex = 24;
            // 
            // label59
            // 
            label59.AutoSize = true;
            label59.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label59.Location = new Point(94, 87);
            label59.Name = "label59";
            label59.Size = new Size(16, 21);
            label59.TabIndex = 27;
            label59.Text = "/";
            // 
            // lblmes
            // 
            lblmes.AutoSize = true;
            lblmes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblmes.Location = new Point(65, 82);
            lblmes.Name = "lblmes";
            lblmes.Size = new Size(16, 21);
            lblmes.TabIndex = 21;
            lblmes.Text = "-";
            // 
            // label58
            // 
            label58.AutoSize = true;
            label58.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label58.Location = new Point(35, 87);
            label58.Name = "label58";
            label58.Size = new Size(16, 21);
            label58.TabIndex = 26;
            label58.Text = "/";
            // 
            // lblano
            // 
            lblano.AutoSize = true;
            lblano.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblano.Location = new Point(126, 82);
            lblano.Name = "lblano";
            lblano.Size = new Size(16, 21);
            lblano.TabIndex = 20;
            lblano.Text = "-";
            // 
            // lbldia
            // 
            lbldia.AutoSize = true;
            lbldia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbldia.Location = new Point(13, 82);
            lbldia.Name = "lbldia";
            lbldia.Size = new Size(16, 21);
            lbldia.TabIndex = 19;
            lbldia.Text = "-";
            // 
            // lblidcot
            // 
            lblidcot.AutoSize = true;
            lblidcot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblidcot.Location = new Point(54, 28);
            lblidcot.Name = "lblidcot";
            lblidcot.Size = new Size(27, 21);
            lblidcot.TabIndex = 18;
            lblidcot.Text = "F1";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(38, 3);
            label15.Name = "label15";
            label15.Size = new Size(47, 21);
            label15.TabIndex = 17;
            label15.Text = "Folio:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(13, 57);
            label14.Name = "label14";
            label14.Size = new Size(149, 21);
            label14.TabIndex = 16;
            label14.Text = "Fecha de expedicion";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label41);
            panel2.Controls.Add(label40);
            panel2.Controls.Add(label39);
            panel2.Controls.Add(label38);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(-1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(717, 114);
            panel2.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(501, 57);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 21;
            label1.Text = "AS12546SQ94";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label41.Location = new Point(443, 81);
            label41.Name = "label41";
            label41.Size = new Size(100, 21);
            label41.TabIndex = 20;
            label41.Text = "6121767223";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label40.Location = new Point(266, 28);
            label40.Name = "label40";
            label40.Size = new Size(295, 21);
            label40.TabIndex = 19;
            label40.Text = "REPORTE DE VENTAS POR EMPLEADO";
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
            label38.Location = new Point(163, 57);
            label38.Name = "label38";
            label38.Size = new Size(265, 21);
            label38.TabIndex = 17;
            label38.Text = "San gregio 126#, Santa fe,BCS,La Paz";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Nissan_logo;
            pictureBox3.Location = new Point(6, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(131, 99);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(366, 81);
            label12.Name = "label12";
            label12.Size = new Size(71, 21);
            label12.TabIndex = 14;
            label12.Text = "Telefono:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(459, 58);
            label11.Name = "label11";
            label11.Size = new Size(42, 21);
            label11.TabIndex = 13;
            label11.Text = "RFC:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(327, 3);
            label9.Name = "label9";
            label9.Size = new Size(150, 21);
            label9.TabIndex = 11;
            label9.Text = "Nissan, La Paz,BCS";
            // 
            // printDocument1
            // 
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.EndPrint += printDocument1_EndPrint;
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // ReporteMejoresEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(898, 631);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(dgvEmpleadosV);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReporteMejoresEmpleados";
            Text = "ReporteMejoresEmpleados";
            Load += ReporteMejoresEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleadosV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvEmpleadosV;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel8;
        private Label label43;
        private Label lblidempleado;
        private Label lblperiodo;
        private Label lblnombrec;
        private Label label8;
        private Label label4;
        private Label label51;
        private Panel panel3;
        private Label label59;
        private Label lblmes;
        private Label label58;
        private Label lblano;
        private Label lbldia;
        private Label lblidcot;
        private Label label15;
        private Label label14;
        private Panel panel2;
        private Label label1;
        private Label label41;
        private Label label40;
        private Label label39;
        private Label label38;
        private PictureBox pictureBox3;
        private Label label12;
        private Label label11;
        private Label label9;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}