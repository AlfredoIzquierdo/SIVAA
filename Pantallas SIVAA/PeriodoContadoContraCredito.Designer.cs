namespace Pantallas_SIVAA
{
    partial class PeriodoContadoContraCredito
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
            comboBox1 = new ComboBox();
            ndan = new NumericUpDown();
            nddia2 = new NumericUpDown();
            ndmes = new NumericUpDown();
            nddia = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)ndan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nddia2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ndmes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nddia).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(82, 101, 143);
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(159, 237);
            button1.Name = "button1";
            button1.Size = new Size(178, 49);
            button1.TabIndex = 14;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(277, 20);
            label1.TabIndex = 13;
            label1.Text = "Selecciona el periodo que abarcara:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dia", "Semana", "Mes", "Anual" });
            comboBox1.Location = new Point(343, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ndan
            // 
            ndan.Enabled = false;
            ndan.Location = new Point(347, 86);
            ndan.Maximum = new decimal(new int[] { 2023, 0, 0, 0 });
            ndan.Minimum = new decimal(new int[] { 2022, 0, 0, 0 });
            ndan.Name = "ndan";
            ndan.Size = new Size(87, 27);
            ndan.TabIndex = 20;
            ndan.Value = new decimal(new int[] { 2023, 0, 0, 0 });
            // 
            // nddia2
            // 
            nddia2.BackColor = SystemColors.Window;
            nddia2.Enabled = false;
            nddia2.Location = new Point(80, 144);
            nddia2.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            nddia2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nddia2.Name = "nddia2";
            nddia2.ReadOnly = true;
            nddia2.Size = new Size(87, 27);
            nddia2.TabIndex = 21;
            nddia2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ndmes
            // 
            ndmes.Enabled = false;
            ndmes.Location = new Point(217, 86);
            ndmes.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            ndmes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ndmes.Name = "ndmes";
            ndmes.Size = new Size(87, 27);
            ndmes.TabIndex = 22;
            ndmes.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nddia
            // 
            nddia.Enabled = false;
            nddia.Location = new Point(80, 86);
            nddia.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            nddia.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nddia.Name = "nddia";
            nddia.Size = new Size(87, 27);
            nddia.TabIndex = 23;
            nddia.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nddia.ValueChanged += nddia_ValueChanged;
            // 
            // PeriodoContadoContraCredito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 298);
            Controls.Add(ndan);
            Controls.Add(nddia2);
            Controls.Add(ndmes);
            Controls.Add(nddia);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "PeriodoContadoContraCredito";
            Text = "PeriodoContadoContraCredito";
            Load += PeriodoContadoContraCredito_Load;
            ((System.ComponentModel.ISupportInitialize)ndan).EndInit();
            ((System.ComponentModel.ISupportInitialize)nddia2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ndmes).EndInit();
            ((System.ComponentModel.ISupportInitialize)nddia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private ComboBox comboBox1;
        private NumericUpDown ndan;
        private NumericUpDown nddia2;
        private NumericUpDown ndmes;
        private NumericUpDown nddia;
    }
}