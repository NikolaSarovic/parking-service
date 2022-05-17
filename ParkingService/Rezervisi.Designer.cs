namespace ParkingService
{
    partial class Rezervisi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtRegistracija = new System.Windows.Forms.TextBox();
            this.txtBrDokumenta = new System.Windows.Forms.TextBox();
            this.txtVrijeme = new System.Windows.Forms.TextBox();
            this.btnRezervisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrarkse oznake";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Broj dokumenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "tip automobil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vrijme dolaska";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Upravo sada";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Automobil",
            "Motocikl",
            "Teretno Vozilp"});
            this.comboBox1.Location = new System.Drawing.Point(224, 259);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Automobil";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(355, 318);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtRegistracija
            // 
            this.txtRegistracija.Location = new System.Drawing.Point(239, 98);
            this.txtRegistracija.Name = "txtRegistracija";
            this.txtRegistracija.Size = new System.Drawing.Size(137, 22);
            this.txtRegistracija.TabIndex = 7;
            this.txtRegistracija.TextChanged += new System.EventHandler(this.txtRegistracija_TextChanged);
            // 
            // txtBrDokumenta
            // 
            this.txtBrDokumenta.Location = new System.Drawing.Point(239, 184);
            this.txtBrDokumenta.Name = "txtBrDokumenta";
            this.txtBrDokumenta.Size = new System.Drawing.Size(106, 22);
            this.txtBrDokumenta.TabIndex = 8;
            this.txtBrDokumenta.TextChanged += new System.EventHandler(this.txtBrDokumenta_TextChanged);
            // 
            // txtVrijeme
            // 
            this.txtVrijeme.Location = new System.Drawing.Point(211, 362);
            this.txtVrijeme.Name = "txtVrijeme";
            this.txtVrijeme.Size = new System.Drawing.Size(134, 22);
            this.txtVrijeme.TabIndex = 9;
            this.txtVrijeme.TextChanged += new System.EventHandler(this.txtVrijeme_TextChanged);
            // 
            // btnRezervisi
            // 
            this.btnRezervisi.Enabled = false;
            this.btnRezervisi.Location = new System.Drawing.Point(211, 417);
            this.btnRezervisi.Name = "btnRezervisi";
            this.btnRezervisi.Size = new System.Drawing.Size(75, 23);
            this.btnRezervisi.TabIndex = 10;
            this.btnRezervisi.Text = "Rezervisi";
            this.btnRezervisi.UseVisualStyleBackColor = true;
            this.btnRezervisi.Click += new System.EventHandler(this.btnRezervisi_Click);
            // 
            // Rezervisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 452);
            this.Controls.Add(this.btnRezervisi);
            this.Controls.Add(this.txtVrijeme);
            this.Controls.Add(this.txtBrDokumenta);
            this.Controls.Add(this.txtRegistracija);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Rezervisi";
            this.Text = "Rezervisi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtRegistracija;
        private System.Windows.Forms.TextBox txtBrDokumenta;
        private System.Windows.Forms.TextBox txtVrijeme;
        private System.Windows.Forms.Button btnRezervisi;
    }
}