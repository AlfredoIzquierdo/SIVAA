namespace Pantallas_SIVAA
{
    partial class ReporteEstadoDeCuenta
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
            label5 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            label7 = new Label();
            label6 = new Label();
            Mensaje = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel6 = new Panel();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel8 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 81);
            label5.Name = "label5";
            label5.Size = new Size(145, 18);
            label5.TabIndex = 3;
            label5.Text = "Total de adeudo:";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13 });
            dataGridView1.Enabled = false;
            dataGridView1.Location = new Point(10, 140);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1127, 269);
            dataGridView1.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.HeaderText = "IdCliente";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "ApellidoPaterno";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "ApellidoMaterno";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "IdVenta";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "IdCredito";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Plazo";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Enganche";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Mensualidad";
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "Intereses";
            Column10.Name = "Column10";
            // 
            // Column11
            // 
            Column11.HeaderText = "SaldoAnterior";
            Column11.Name = "Column11";
            // 
            // Column12
            // 
            Column12.HeaderText = "SaldoActual";
            Column12.Name = "Column12";
            // 
            // Column13
            // 
            Column13.HeaderText = "DeudaTotal";
            Column13.Name = "Column13";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(172, 81);
            label7.Name = "label7";
            label7.Size = new Size(48, 18);
            label7.TabIndex = 5;
            label7.Text = "$$$$";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(10, 110);
            label6.Name = "label6";
            label6.Size = new Size(85, 18);
            label6.TabIndex = 7;
            label6.Text = "Desgloce:";
            // 
            // Mensaje
            // 
            Mensaje.AutoSize = true;
            Mensaje.Font = new Font("Lucida Fax", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Mensaje.Location = new Point(11, 425);
            Mensaje.Name = "Mensaje";
            Mensaje.Size = new Size(158, 34);
            Mensaje.TabIndex = 8;
            Mensaje.Text = "Mensaje ejemplo:  \r\nPago tardio mes tal ";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(82, 101, 143);
            button1.Font = new Font("Lucida Fax", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(531, 425);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(205, 41);
            button1.TabIndex = 9;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.print_FILL0_wght400_GRAD0_opsz48;
            pictureBox1.Location = new Point(1078, 95);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 33);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1138, 62);
            panel1.TabIndex = 39;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(729, 30);
            label4.Name = "label4";
            label4.Size = new Size(39, 18);
            label4.TabIndex = 3;
            label4.Text = "C21";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(691, 13);
            label3.Name = "label3";
            label3.Size = new Size(82, 18);
            label3.TabIndex = 2;
            label3.Text = "IDCliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(181, 22);
            label1.TabIndex = 0;
            label1.Text = "Estado de cuenta:";
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
            // printDocument1
            // 
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.EndPrint += printDocument1_EndPrint;
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BackColor = Color.FromArgb(51, 58, 86);
            panel8.Controls.Add(panel4);
            panel8.Location = new Point(0, 61);
            panel8.Name = "panel8";
            panel8.Size = new Size(1138, 22);
            panel8.TabIndex = 60;
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
            // ReporteEstadoDeCuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 476);
            Controls.Add(panel8);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(Mensaje);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(label5);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReporteEstadoDeCuenta";
            Text = "ReporteBalance";
            Load += ReporteEstadoDeCuenta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel8.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private DataGridView dataGridView1;
        private Label label7;
        private Label label6;
        private Label Mensaje;
        private Button button1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label1;
        private Panel panel2;
        private Panel panel6;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Panel panel8;
        private Panel panel4;
        private Label label2;
    }
}