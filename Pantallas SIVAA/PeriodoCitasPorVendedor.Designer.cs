namespace Pantallas_SIVAA
{
    partial class PeriodoCitasPorVendedor
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
            button1 = new Button();
            label1 = new Label();
            cbPeriodo = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            numericAnoF = new NumericUpDown();
            numericMesF = new NumericUpDown();
            numericDiaF = new NumericUpDown();
            numericAnoI = new NumericUpDown();
            numericMesI = new NumericUpDown();
            numericDiaI = new NumericUpDown();
            cmbVendedor = new ComboBox();
            label15 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericAnoF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericMesF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDiaF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericAnoI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericMesI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDiaI).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(82, 101, 143);
            button1.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(222, 279);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(156, 37);
            button1.TabIndex = 8;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 40);
            label1.Name = "label1";
            label1.Size = new Size(258, 16);
            label1.TabIndex = 7;
            label1.Text = "Selecciona el periodo que abarcara:";
            // 
            // cbPeriodo
            // 
            cbPeriodo.FormattingEnabled = true;
            cbPeriodo.Items.AddRange(new object[] { "Dia", "Semana", "Mes", "Año" });
            cbPeriodo.Location = new Point(301, 38);
            cbPeriodo.Margin = new Padding(3, 2, 3, 2);
            cbPeriodo.Name = "cbPeriodo";
            cbPeriodo.Size = new Size(133, 23);
            cbPeriodo.TabIndex = 6;
            cbPeriodo.SelectedIndexChanged += cbPeriodo_SelectedIndexChanged;
            cbPeriodo.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(479, 139);
            label12.Name = "label12";
            label12.Size = new Size(29, 15);
            label12.TabIndex = 43;
            label12.Text = "Año";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(395, 139);
            label13.Name = "label13";
            label13.Size = new Size(29, 15);
            label13.TabIndex = 42;
            label13.Text = "Mes";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(336, 139);
            label14.Name = "label14";
            label14.Size = new Size(24, 15);
            label14.TabIndex = 41;
            label14.Text = "Dia";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(183, 139);
            label11.Name = "label11";
            label11.Size = new Size(29, 15);
            label11.TabIndex = 40;
            label11.Text = "Año";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(99, 139);
            label10.Name = "label10";
            label10.Size = new Size(29, 15);
            label10.TabIndex = 39;
            label10.Text = "Mes";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(39, 139);
            label9.Name = "label9";
            label9.Size = new Size(24, 15);
            label9.TabIndex = 38;
            label9.Text = "Dia";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(405, 77);
            label8.Name = "label8";
            label8.Size = new Size(46, 21);
            label8.TabIndex = 37;
            label8.Text = "Final:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(85, 77);
            label7.Name = "label7";
            label7.Size = new Size(54, 21);
            label7.TabIndex = 36;
            label7.Text = "Inicio: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(262, 107);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 35;
            label6.Text = "______";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(446, 117);
            label5.Name = "label5";
            label5.Size = new Size(14, 19);
            label5.TabIndex = 34;
            label5.Text = "/";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(375, 117);
            label4.Name = "label4";
            label4.Size = new Size(14, 19);
            label4.TabIndex = 33;
            label4.Text = "/";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(149, 117);
            label3.Name = "label3";
            label3.Size = new Size(14, 19);
            label3.TabIndex = 32;
            label3.Text = "/";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(78, 117);
            label2.Name = "label2";
            label2.Size = new Size(14, 19);
            label2.TabIndex = 31;
            label2.Text = "/";
            // 
            // numericAnoF
            // 
            numericAnoF.Enabled = false;
            numericAnoF.Location = new Point(466, 117);
            numericAnoF.Margin = new Padding(3, 2, 3, 2);
            numericAnoF.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            numericAnoF.Minimum = new decimal(new int[] { 2021, 0, 0, 0 });
            numericAnoF.Name = "numericAnoF";
            numericAnoF.Size = new Size(67, 23);
            numericAnoF.TabIndex = 30;
            numericAnoF.Value = new decimal(new int[] { 2021, 0, 0, 0 });
            // 
            // numericMesF
            // 
            numericMesF.Enabled = false;
            numericMesF.Location = new Point(395, 117);
            numericMesF.Margin = new Padding(3, 2, 3, 2);
            numericMesF.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numericMesF.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericMesF.Name = "numericMesF";
            numericMesF.Size = new Size(46, 23);
            numericMesF.TabIndex = 29;
            numericMesF.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericDiaF
            // 
            numericDiaF.Enabled = false;
            numericDiaF.Location = new Point(331, 117);
            numericDiaF.Margin = new Padding(3, 2, 3, 2);
            numericDiaF.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            numericDiaF.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericDiaF.Name = "numericDiaF";
            numericDiaF.Size = new Size(38, 23);
            numericDiaF.TabIndex = 28;
            numericDiaF.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericAnoI
            // 
            numericAnoI.Enabled = false;
            numericAnoI.Location = new Point(166, 117);
            numericAnoI.Margin = new Padding(3, 2, 3, 2);
            numericAnoI.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            numericAnoI.Minimum = new decimal(new int[] { 2021, 0, 0, 0 });
            numericAnoI.Name = "numericAnoI";
            numericAnoI.Size = new Size(67, 23);
            numericAnoI.TabIndex = 27;
            numericAnoI.Value = new decimal(new int[] { 2021, 0, 0, 0 });
            // 
            // numericMesI
            // 
            numericMesI.Enabled = false;
            numericMesI.Location = new Point(99, 117);
            numericMesI.Margin = new Padding(3, 2, 3, 2);
            numericMesI.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numericMesI.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericMesI.Name = "numericMesI";
            numericMesI.Size = new Size(46, 23);
            numericMesI.TabIndex = 26;
            numericMesI.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericDiaI
            // 
            numericDiaI.Enabled = false;
            numericDiaI.Location = new Point(39, 117);
            numericDiaI.Margin = new Padding(3, 2, 3, 2);
            numericDiaI.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            numericDiaI.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericDiaI.Name = "numericDiaI";
            numericDiaI.Size = new Size(38, 23);
            numericDiaI.TabIndex = 25;
            numericDiaI.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmbVendedor
            // 
            cmbVendedor.FormattingEnabled = true;
            cmbVendedor.Location = new Point(239, 201);
            cmbVendedor.Name = "cmbVendedor";
            cmbVendedor.Size = new Size(121, 23);
            cmbVendedor.TabIndex = 44;
            cmbVendedor.SelectedIndexChanged += cmbVendedor_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(166, 204);
            label15.Name = "label15";
            label15.Size = new Size(57, 15);
            label15.TabIndex = 45;
            label15.Text = "Vendedor";
            // 
            // PeriodoCitasPorVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 364);
            Controls.Add(label15);
            Controls.Add(cmbVendedor);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(numericAnoF);
            Controls.Add(numericMesF);
            Controls.Add(numericDiaF);
            Controls.Add(numericAnoI);
            Controls.Add(numericMesI);
            Controls.Add(numericDiaI);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(cbPeriodo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PeriodoCitasPorVendedor";
            Text = "PeriodoCitasPorVendedor";
            Load += PeriodoCitasPorVendedor_Load;
            ((System.ComponentModel.ISupportInitialize)numericAnoF).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericMesF).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericDiaF).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericAnoI).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericMesI).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericDiaI).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private ComboBox cbPeriodo;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private NumericUpDown numericAnoF;
        private NumericUpDown numericMesF;
        private NumericUpDown numericDiaF;
        private NumericUpDown numericAnoI;
        private NumericUpDown numericMesI;
        private NumericUpDown numericDiaI;
        private ComboBox cmbVendedor;
        private Label label15;
    }
}