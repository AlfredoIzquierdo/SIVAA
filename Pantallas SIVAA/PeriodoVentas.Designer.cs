namespace Pantallas_SIVAA
{
    partial class PeriodoVentas
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
            cbPeriodoVentas = new ComboBox();
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
            button1.Location = new Point(280, 262);
            button1.Name = "button1";
            button1.Size = new Size(178, 49);
            button1.TabIndex = 8;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cbPeriodoVentas
            // 
            cbPeriodoVentas.FormattingEnabled = true;
            cbPeriodoVentas.Items.AddRange(new object[] { "Dia", "Semana", "Mes", "Año" });
            cbPeriodoVentas.Location = new Point(400, 52);
            cbPeriodoVentas.Name = "cbPeriodoVentas";
            cbPeriodoVentas.Size = new Size(213, 28);
            cbPeriodoVentas.TabIndex = 67;
            cbPeriodoVentas.SelectedValueChanged += cbPeriodoVeh_SelectedValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(585, 190);
            label12.Name = "label12";
            label12.Size = new Size(36, 20);
            label12.TabIndex = 66;
            label12.Text = "Año";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(489, 190);
            label13.Name = "label13";
            label13.Size = new Size(36, 20);
            label13.TabIndex = 65;
            label13.Text = "Mes";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(421, 190);
            label14.Name = "label14";
            label14.Size = new Size(32, 20);
            label14.TabIndex = 64;
            label14.Text = "Dia";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(246, 190);
            label11.Name = "label11";
            label11.Size = new Size(36, 20);
            label11.TabIndex = 63;
            label11.Text = "Año";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(150, 190);
            label10.Name = "label10";
            label10.Size = new Size(36, 20);
            label10.TabIndex = 62;
            label10.Text = "Mes";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(82, 190);
            label9.Name = "label9";
            label9.Size = new Size(32, 20);
            label9.TabIndex = 61;
            label9.Text = "Dia";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(500, 106);
            label8.Name = "label8";
            label8.Size = new Size(57, 28);
            label8.TabIndex = 60;
            label8.Text = "Final:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(135, 106);
            label7.Name = "label7";
            label7.Size = new Size(68, 28);
            label7.TabIndex = 59;
            label7.Text = "Inicio: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(337, 146);
            label6.Name = "label6";
            label6.Size = new Size(60, 28);
            label6.TabIndex = 58;
            label6.Text = "______";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(547, 160);
            label5.Name = "label5";
            label5.Size = new Size(17, 23);
            label5.TabIndex = 57;
            label5.Text = "/";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(466, 160);
            label4.Name = "label4";
            label4.Size = new Size(17, 23);
            label4.TabIndex = 56;
            label4.Text = "/";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(208, 160);
            label3.Name = "label3";
            label3.Size = new Size(17, 23);
            label3.TabIndex = 55;
            label3.Text = "/";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(127, 160);
            label2.Name = "label2";
            label2.Size = new Size(17, 23);
            label2.TabIndex = 54;
            label2.Text = "/";
            // 
            // numericAnoF
            // 
            numericAnoF.Location = new Point(570, 160);
            numericAnoF.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            numericAnoF.Minimum = new decimal(new int[] { 2021, 0, 0, 0 });
            numericAnoF.Name = "numericAnoF";
            numericAnoF.Size = new Size(77, 27);
            numericAnoF.TabIndex = 53;
            numericAnoF.Value = new decimal(new int[] { 2021, 0, 0, 0 });
            // 
            // numericMesF
            // 
            numericMesF.Location = new Point(489, 160);
            numericMesF.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numericMesF.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericMesF.Name = "numericMesF";
            numericMesF.Size = new Size(52, 27);
            numericMesF.TabIndex = 52;
            numericMesF.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericDiaF
            // 
            numericDiaF.Location = new Point(416, 160);
            numericDiaF.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            numericDiaF.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericDiaF.Name = "numericDiaF";
            numericDiaF.Size = new Size(44, 27);
            numericDiaF.TabIndex = 51;
            numericDiaF.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericAnoI
            // 
            numericAnoI.Location = new Point(227, 160);
            numericAnoI.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            numericAnoI.Minimum = new decimal(new int[] { 2021, 0, 0, 0 });
            numericAnoI.Name = "numericAnoI";
            numericAnoI.Size = new Size(77, 27);
            numericAnoI.TabIndex = 50;
            numericAnoI.Value = new decimal(new int[] { 2021, 0, 0, 0 });
            // 
            // numericMesI
            // 
            numericMesI.Location = new Point(150, 160);
            numericMesI.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numericMesI.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericMesI.Name = "numericMesI";
            numericMesI.Size = new Size(52, 27);
            numericMesI.TabIndex = 49;
            numericMesI.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericDiaI
            // 
            numericDiaI.Location = new Point(82, 160);
            numericDiaI.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            numericDiaI.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericDiaI.Name = "numericDiaI";
            numericDiaI.Size = new Size(44, 27);
            numericDiaI.TabIndex = 48;
            numericDiaI.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Lucida Fax", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(77, 55);
            label15.Name = "label15";
            label15.Size = new Size(317, 20);
            label15.TabIndex = 47;
            label15.Text = "Selecciona el periodo que abarcara:";
            // 
            // PeriodoVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 338);
            Controls.Add(cbPeriodoVentas);
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
            Controls.Add(label15);
            Controls.Add(button1);
            Name = "PeriodoVentas";
            Text = "PeriodoVentas";
            Load += PeriodoVentas_Load;
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
        private ComboBox cbPeriodoVentas;
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
        private Label label15;
    }
}