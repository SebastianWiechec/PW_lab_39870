namespace Kostka_do_gry
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelHint = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.labelWynik = new System.Windows.Forms.Label();
            this.LabDolPrawy = new System.Windows.Forms.Label();
            this.LabSrodekPrawy = new System.Windows.Forms.Label();
            this.LabSrodek = new System.Windows.Forms.Label();
            this.LabGoraLewy = new System.Windows.Forms.Label();
            this.LabGoraPrawy = new System.Windows.Forms.Label();
            this.LabSrodekLewy = new System.Windows.Forms.Label();
            this.LabDolLewy = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHint.Location = new System.Drawing.Point(151, 20);
            this.labelHint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(525, 29);
            this.labelHint.TabIndex = 0;
            this.labelHint.Text = "Naciśnięcie \"R\" spowoduje ponowne losowanie";
            this.labelHint.Click += new System.EventHandler(this.labelHint_Click);
            // 
            // labelWynik
            // 
            this.labelWynik.AutoSize = true;
            this.labelWynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWynik.Location = new System.Drawing.Point(243, 408);
            this.labelWynik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(109, 39);
            this.labelWynik.TabIndex = 10;
            this.labelWynik.Text = "label1";
            // 
            // LabDolPrawy
            // 
            this.LabDolPrawy.AutoSize = true;
            this.LabDolPrawy.BackColor = System.Drawing.Color.Transparent;
            this.LabDolPrawy.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabDolPrawy.ForeColor = System.Drawing.Color.Black;
            this.LabDolPrawy.Image = ((System.Drawing.Image)(resources.GetObject("LabDolPrawy.Image")));
            this.LabDolPrawy.Location = new System.Drawing.Point(427, 223);
            this.LabDolPrawy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabDolPrawy.Name = "LabDolPrawy";
            this.LabDolPrawy.Size = new System.Drawing.Size(51, 69);
            this.LabDolPrawy.TabIndex = 17;
            this.LabDolPrawy.Text = "•";
            this.LabDolPrawy.Click += new System.EventHandler(this.LabelDownRight_Click);
            // 
            // LabSrodekPrawy
            // 
            this.LabSrodekPrawy.AutoSize = true;
            this.LabSrodekPrawy.BackColor = System.Drawing.Color.Transparent;
            this.LabSrodekPrawy.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabSrodekPrawy.ForeColor = System.Drawing.Color.Black;
            this.LabSrodekPrawy.Image = ((System.Drawing.Image)(resources.GetObject("LabSrodekPrawy.Image")));
            this.LabSrodekPrawy.Location = new System.Drawing.Point(427, 180);
            this.LabSrodekPrawy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabSrodekPrawy.Name = "LabSrodekPrawy";
            this.LabSrodekPrawy.Size = new System.Drawing.Size(51, 69);
            this.LabSrodekPrawy.TabIndex = 16;
            this.LabSrodekPrawy.Text = "•";
            this.LabSrodekPrawy.Click += new System.EventHandler(this.LabSrodekPrawy_Click);
            // 
            // LabSrodek
            // 
            this.LabSrodek.AutoSize = true;
            this.LabSrodek.BackColor = System.Drawing.Color.Transparent;
            this.LabSrodek.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabSrodek.ForeColor = System.Drawing.Color.Black;
            this.LabSrodek.Image = ((System.Drawing.Image)(resources.GetObject("LabSrodek.Image")));
            this.LabSrodek.Location = new System.Drawing.Point(391, 180);
            this.LabSrodek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabSrodek.Name = "LabSrodek";
            this.LabSrodek.Size = new System.Drawing.Size(51, 69);
            this.LabSrodek.TabIndex = 14;
            this.LabSrodek.Text = "•";
            // 
            // LabGoraLewy
            // 
            this.LabGoraLewy.AutoSize = true;
            this.LabGoraLewy.BackColor = System.Drawing.Color.Transparent;
            this.LabGoraLewy.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabGoraLewy.ForeColor = System.Drawing.Color.Black;
            this.LabGoraLewy.Image = ((System.Drawing.Image)(resources.GetObject("LabGoraLewy.Image")));
            this.LabGoraLewy.Location = new System.Drawing.Point(354, 137);
            this.LabGoraLewy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabGoraLewy.Name = "LabGoraLewy";
            this.LabGoraLewy.Size = new System.Drawing.Size(51, 69);
            this.LabGoraLewy.TabIndex = 11;
            this.LabGoraLewy.Text = "•";
            // 
            // LabGoraPrawy
            // 
            this.LabGoraPrawy.AutoSize = true;
            this.LabGoraPrawy.BackColor = System.Drawing.Color.Transparent;
            this.LabGoraPrawy.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabGoraPrawy.ForeColor = System.Drawing.Color.Black;
            this.LabGoraPrawy.Image = ((System.Drawing.Image)(resources.GetObject("LabGoraPrawy.Image")));
            this.LabGoraPrawy.Location = new System.Drawing.Point(427, 137);
            this.LabGoraPrawy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabGoraPrawy.Name = "LabGoraPrawy";
            this.LabGoraPrawy.Size = new System.Drawing.Size(51, 69);
            this.LabGoraPrawy.TabIndex = 15;
            this.LabGoraPrawy.Text = "•";
            this.LabGoraPrawy.Click += new System.EventHandler(this.labelTopRight_Click);
            // 
            // LabSrodekLewy
            // 
            this.LabSrodekLewy.AutoSize = true;
            this.LabSrodekLewy.BackColor = System.Drawing.Color.Transparent;
            this.LabSrodekLewy.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabSrodekLewy.ForeColor = System.Drawing.Color.Black;
            this.LabSrodekLewy.Image = ((System.Drawing.Image)(resources.GetObject("LabSrodekLewy.Image")));
            this.LabSrodekLewy.Location = new System.Drawing.Point(354, 180);
            this.LabSrodekLewy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabSrodekLewy.Name = "LabSrodekLewy";
            this.LabSrodekLewy.Size = new System.Drawing.Size(51, 69);
            this.LabSrodekLewy.TabIndex = 12;
            this.LabSrodekLewy.Text = "•";
            // 
            // LabDolLewy
            // 
            this.LabDolLewy.AutoSize = true;
            this.LabDolLewy.BackColor = System.Drawing.Color.Transparent;
            this.LabDolLewy.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabDolLewy.ForeColor = System.Drawing.Color.Black;
            this.LabDolLewy.Image = ((System.Drawing.Image)(resources.GetObject("LabDolLewy.Image")));
            this.LabDolLewy.Location = new System.Drawing.Point(354, 223);
            this.LabDolLewy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabDolLewy.Name = "LabDolLewy";
            this.LabDolLewy.Size = new System.Drawing.Size(51, 69);
            this.LabDolLewy.TabIndex = 13;
            this.LabDolLewy.Text = "•";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(279, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 514);
            this.Controls.Add(this.LabDolPrawy);
            this.Controls.Add(this.LabSrodekPrawy);
            this.Controls.Add(this.LabSrodek);
            this.Controls.Add(this.labelWynik);
            this.Controls.Add(this.LabGoraLewy);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.LabGoraPrawy);
            this.Controls.Add(this.LabSrodekLewy);
            this.Controls.Add(this.LabDolLewy);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Kostka do gry";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label labelWynik;
        private System.Windows.Forms.Label LabDolPrawy;
        private System.Windows.Forms.Label LabSrodekPrawy;
        private System.Windows.Forms.Label LabSrodek;
        private System.Windows.Forms.Label LabGoraLewy;
        private System.Windows.Forms.Label LabGoraPrawy;
        private System.Windows.Forms.Label LabSrodekLewy;
        private System.Windows.Forms.Label LabDolLewy;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

