namespace Pantallas_SIVAA
{
    partial class ReporteCitas
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
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
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
            panel8 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            label43 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(197, 163);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 50;
            label8.Text = "08/03/2023";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(214, 138);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 48;
            label7.Text = "Fulanito";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(0, 138);
            label5.Name = "label5";
            label5.Size = new Size(175, 20);
            label5.TabIndex = 47;
            label5.Text = "Nombre del que expide:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(0, 163);
            label6.Name = "label6";
            label6.Size = new Size(159, 20);
            label6.TabIndex = 49;
            label6.Text = "Fecha de expedicion:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column2, Column8, Column9, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(9, 186);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(878, 442);
            dataGridView1.TabIndex = 51;
            // 
            // Column1
            // 
            Column1.HeaderText = "IDCita";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "IDEmpleado";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "ApellidoPaterno";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "Apellido Materno";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Dia";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Mes";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Año";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Hora";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.print_FILL0_wght400_GRAD0_opsz48;
            pictureBox1.Location = new Point(799, 127);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 44);
            pictureBox1.TabIndex = 65;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // printDocument1
            // 
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.EndPrint += printDocument1_EndPrint;
            printDocument1.PrintPage += printDocument1_PrintPage;
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
            panel2.Location = new Point(0, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(887, 106);
            panel2.TabIndex = 66;
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
            label40.Location = new Point(326, 24);
            label40.Name = "label40";
            label40.Size = new Size(151, 21);
            label40.TabIndex = 19;
            label40.Text = "REPORTE DE CITAS";
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
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BackColor = Color.FromArgb(51, 58, 86);
            panel8.Controls.Add(panel4);
            panel8.Controls.Add(label43);
            panel8.Location = new Point(0, 109);
            panel8.Name = "panel8";
            panel8.Size = new Size(887, 22);
            panel8.TabIndex = 67;
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
            label43.Location = new Point(6, 0);
            label43.Name = "label43";
            label43.Size = new Size(140, 19);
            label43.TabIndex = 0;
            label43.Text = "Datos del que expide:";
            // 
            // ReporteCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 631);
            Controls.Add(panel8);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Margin = new Padding(2);
            Name = "ReporteCitas";
            Text = "ReporteCitas";
            Load += ReporteCitas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
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
        private Panel panel8;
        private Panel panel4;
        private Label label1;
        private Label label43;
    }
}