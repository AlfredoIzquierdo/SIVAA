namespace Pantallas_SIVAA
{
    partial class PeriodoMejorEmpleado
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
            cbPeriodoEmpleado = new ComboBox();
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
            label1 = new Label();
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
            button1.Location = new Point(228, 221);
            button1.Name = "button1";
            button1.Size = new Size(178, 49);
            button1.TabIndex = 5;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cbPeriodoEmpleado
            // 
            cbPeriodoEmpleado.FormattingEnabled = true;
            cbPeriodoEmpleado.Items.AddRange(new object[] { "Dia", "Semana", "Mes", "Año" });
            cbPeriodoEmpleado.Location = new Point(366, 41);
            cbPeriodoEmpleado.Name = "cbPeriodoEmpleado";
            cbPeriodoEmpleado.Size = new Size(213, 28);
            cbPeriodoEmpleado.TabIndex = 46;
            cbPeriodoEmpleado.SelectedValueChanged += cbPeriodoClien_SelectedValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(551, 179);
            label12.Name = "label12";
            label12.Size = new Size(36, 20);
            label12.TabIndex = 45;
            label12.Text = "Año";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(455, 179);
            label13.Name = "label13";
            label13.Size = new Size(36, 20);
            label13.TabIndex = 44;
            label13.Text = "Mes";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(387, 179);
            label14.Name = "label14";
            label14.Size = new Size(32, 20);
            label14.TabIndex = 43;
            label14.Text = "Dia";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(212, 179);
            label11.Name = "label11";
            label11.Size = new Size(36, 20);
            label11.TabIndex = 42;
            label11.Text = "Año";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(116, 179);
            label10.Name = "label10";
            label10.Size = new Size(36, 20);
            label10.TabIndex = 41;
            label10.Text = "Mes";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(48, 179);
            label9.Name = "label9";
            label9.Size = new Size(32, 20);
            label9.TabIndex = 40;
            label9.Text = "Dia";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(466, 95);
            label8.Name = "label8";
            label8.Size = new Size(57, 28);
            label8.TabIndex = 39;
            label8.Text = "Final:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(101, 95);
            label7.Name = "label7";
            label7.Size = new Size(68, 28);
            label7.TabIndex = 38;
            label7.Text = "Inicio: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(303, 135);
            label6.Name = "label6";
            label6.Size = new Size(60, 28);
            label6.TabIndex = 37;
            label6.Text = "______";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(513, 149);
            label5.Name = "label5";
            label5.Size = new Size(17, 23);
            label5.TabIndex = 36;
            label5.Text = "/";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(432, 149);
            label4.Name = "label4";
            label4.Size = new Size(17, 23);
            label4.TabIndex = 35;
            label4.Text = "/";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(174, 149);
            label3.Name = "label3";
            label3.Size = new Size(17, 23);
            label3.TabIndex = 34;
            label3.Text = "/";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(93, 149);
            label2.Name = "label2";
            label2.Size = new Size(17, 23);
            label2.TabIndex = 33;
            label2.Text = "/";
            // 
            // numericAnoF
            // 
            numericAnoF.Location = new Point(536, 149);
            numericAnoF.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            numericAnoF.Minimum = new decimal(new int[] { 2021, 0, 0, 0 });
            numericAnoF.Name = "numericAnoF";
            numericAnoF.Size = new Size(77, 27);
            numericAnoF.TabIndex = 32;
            numericAnoF.Value = new decimal(new int[] { 2021, 0, 0, 0 });
            // 
            // numericMesF
            // 
            numericMesF.Location = new Point(455, 149);
            numericMesF.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numericMesF.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericMesF.Name = "numericMesF";
            numericMesF.Size = new Size(52, 27);
            numericMesF.TabIndex = 31;
            numericMesF.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericDiaF
            // 
            numericDiaF.Location = new Point(382, 149);
            numericDiaF.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            numericDiaF.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericDiaF.Name = "numericDiaF";
            numericDiaF.Size = new Size(44, 27);
            numericDiaF.TabIndex = 30;
            numericDiaF.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericAnoI
            // 
            numericAnoI.Location = new Point(193, 149);
            numericAnoI.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            numericAnoI.Minimum = new decimal(new int[] { 2021, 0, 0, 0 });
            numericAnoI.Name = "numericAnoI";
            numericAnoI.Size = new Size(77, 27);
            numericAnoI.TabIndex = 29;
            numericAnoI.Value = new decimal(new int[] { 2021, 0, 0, 0 });
            // 
            // numericMesI
            // 
            numericMesI.Location = new Point(116, 149);
            numericMesI.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numericMesI.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericMesI.Name = "numericMesI";
            numericMesI.Size = new Size(52, 27);
            numericMesI.TabIndex = 28;
            numericMesI.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericDiaI
            // 
            numericDiaI.Location = new Point(48, 149);
            numericDiaI.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            numericDiaI.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericDiaI.Name = "numericDiaI";
            numericDiaI.Size = new Size(44, 27);
            numericDiaI.TabIndex = 27;
            numericDiaI.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(43, 44);
            label1.Name = "label1";
            label1.Size = new Size(317, 20);
            label1.TabIndex = 26;
            label1.Text = "Selecciona el periodo que abarcara:";
            // 
            // PeriodoMejorEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 292);
            Controls.Add(cbPeriodoEmpleado);
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
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "PeriodoMejorEmpleado";
            Text = "PeriodoMejorEmpleado";
            Load += PeriodoMejorEmpleado_Load;
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
        private ComboBox cbPeriodoEmpleado;
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
        private Label label1;
    }
}