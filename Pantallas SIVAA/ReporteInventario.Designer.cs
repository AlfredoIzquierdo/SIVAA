﻿namespace Pantallas_SIVAA
{
    partial class ReporteInventario
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
            lblFecha = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            lblnombreempleado = new Label();
            label5 = new Label();
            lblidempleado = new Label();
            label3 = new Label();
            panel3 = new Panel();
            label14 = new Label();
            panel5 = new Panel();
            label9 = new Label();
            label41 = new Label();
            label40 = new Label();
            label39 = new Label();
            label38 = new Label();
            pictureBox3 = new PictureBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            panel8 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            label43 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(44, 57);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(89, 20);
            lblFecha.TabIndex = 37;
            lblFecha.Text = "08/03/2023";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.print_FILL0_wght400_GRAD0_opsz48;
            pictureBox1.Location = new Point(755, 158);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 33);
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Enabled = false;
            dataGridView1.Location = new Point(6, 196);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(785, 302);
            dataGridView1.TabIndex = 33;
            // 
            // lblnombreempleado
            // 
            lblnombreempleado.AutoSize = true;
            lblnombreempleado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblnombreempleado.Location = new Point(90, 146);
            lblnombreempleado.Name = "lblnombreempleado";
            lblnombreempleado.Size = new Size(66, 20);
            lblnombreempleado.TabIndex = 32;
            lblnombreempleado.Text = "Fulanito";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(9, 146);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 31;
            label5.Text = "Nombre:";
            // 
            // lblidempleado
            // 
            lblidempleado.AutoSize = true;
            lblidempleado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblidempleado.ForeColor = SystemColors.ActiveCaptionText;
            lblidempleado.Location = new Point(133, 168);
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
            label3.Location = new Point(9, 168);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 2;
            label3.Text = "IDEmpleado";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label14);
            panel3.Controls.Add(lblFecha);
            panel3.Location = new Point(645, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(170, 113);
            panel3.TabIndex = 58;
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
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label41);
            panel5.Controls.Add(label40);
            panel5.Controls.Add(label39);
            panel5.Controls.Add(label38);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(6, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(635, 113);
            panel5.TabIndex = 57;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(501, 57);
            label9.Name = "label9";
            label9.Size = new Size(113, 21);
            label9.TabIndex = 21;
            label9.Text = "AS12546SQ94";
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
            label40.Location = new Point(300, 29);
            label40.Name = "label40";
            label40.Size = new Size(205, 21);
            label40.TabIndex = 19;
            label40.Text = "REPORTE DE INVENTARIO";
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
            pictureBox3.Location = new Point(11, 7);
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(312, 3);
            label10.Name = "label10";
            label10.Size = new Size(150, 21);
            label10.TabIndex = 11;
            label10.Text = "Nissan, La Paz,BCS";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(51, 58, 86);
            panel8.Controls.Add(panel4);
            panel8.Controls.Add(label43);
            panel8.Location = new Point(4, 121);
            panel8.Name = "panel8";
            panel8.Size = new Size(888, 22);
            panel8.TabIndex = 59;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(51, 58, 86);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(6, 77);
            panel4.Name = "panel4";
            panel4.Size = new Size(888, 22);
            panel4.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(85, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 19);
            label2.TabIndex = 0;
            label2.Text = "Datos del que expide:";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label43.ForeColor = SystemColors.ButtonHighlight;
            label43.Location = new Point(6, 0);
            label43.Name = "label43";
            label43.Size = new Size(140, 19);
            label43.TabIndex = 0;
            label43.Text = "Datos del que expide:";
            // 
            // printDocument1
            // 
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.EndPrint += printDocument1_EndPrint;
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // ReporteInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(894, 631);
            Controls.Add(panel8);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(lblidempleado);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(lblnombreempleado);
            Controls.Add(label5);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReporteInventario";
            Text = "ReporteInventario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecha;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label lblnombreempleado;
        private Label label5;
        private Label lblidempleado;
        private Label label3;
        private Panel panel3;
        private Label label14;
        private Panel panel5;
        private Label label9;
        private Label label41;
        private Label label40;
        private Label label39;
        private Label label38;
        private PictureBox pictureBox3;
        private Label label12;
        private Label label11;
        private Label label10;
        private Panel panel8;
        private Panel panel4;
        private Label label2;
        private Label label43;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}