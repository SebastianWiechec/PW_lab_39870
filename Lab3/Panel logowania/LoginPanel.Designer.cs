namespace Panel_logowania
{
    partial class PanelLogowania
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelLogowania));
            this.LabLogin = new System.Windows.Forms.Label();
            this.LabHaslo = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxHaslo = new System.Windows.Forms.TextBox();
            this.buttonZaloguj = new System.Windows.Forms.Button();
            this.BrakLoginu = new System.Windows.Forms.Label();
            this.BrakHasla = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabLogin
            // 
            this.LabLogin.AutoSize = true;
            this.LabLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabLogin.Location = new System.Drawing.Point(38, 23);
            this.LabLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabLogin.Name = "LabLogin";
            this.LabLogin.Size = new System.Drawing.Size(135, 46);
            this.LabLogin.TabIndex = 0;
            this.LabLogin.Text = "Login:";
            // 
            // LabHaslo
            // 
            this.LabHaslo.AutoSize = true;
            this.LabHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabHaslo.Location = new System.Drawing.Point(31, 194);
            this.LabHaslo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabHaslo.Name = "LabHaslo";
            this.LabHaslo.Size = new System.Drawing.Size(140, 46);
            this.LabHaslo.TabIndex = 1;
            this.LabHaslo.Text = "Hasło:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLogin.Location = new System.Drawing.Point(181, 13);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(421, 61);
            this.textBoxLogin.TabIndex = 2;
            // 
            // textBoxHaslo
            // 
            this.textBoxHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxHaslo.Location = new System.Drawing.Point(181, 184);
            this.textBoxHaslo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHaslo.Name = "textBoxHaslo";
            this.textBoxHaslo.PasswordChar = '*';
            this.textBoxHaslo.Size = new System.Drawing.Size(421, 61);
            this.textBoxHaslo.TabIndex = 3;
            // 
            // buttonZaloguj
            // 
            this.buttonZaloguj.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZaloguj.Location = new System.Drawing.Point(804, 421);
            this.buttonZaloguj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZaloguj.Name = "buttonZaloguj";
            this.buttonZaloguj.Size = new System.Drawing.Size(211, 85);
            this.buttonZaloguj.TabIndex = 4;
            this.buttonZaloguj.Text = "Zaloguj";
            this.buttonZaloguj.UseVisualStyleBackColor = true;
            this.buttonZaloguj.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // BrakLoginu
            // 
            this.BrakLoginu.AutoSize = true;
            this.BrakLoginu.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BrakLoginu.ForeColor = System.Drawing.Color.Red;
            this.BrakLoginu.Location = new System.Drawing.Point(181, 78);
            this.BrakLoginu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BrakLoginu.Name = "BrakLoginu";
            this.BrakLoginu.Size = new System.Drawing.Size(311, 44);
            this.BrakLoginu.TabIndex = 5;
            this.BrakLoginu.Text = "Wprowadź login !";
            this.BrakLoginu.Visible = false;
            // 
            // BrakHasla
            // 
            this.BrakHasla.AutoSize = true;
            this.BrakHasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BrakHasla.ForeColor = System.Drawing.Color.Red;
            this.BrakHasla.Location = new System.Drawing.Point(181, 247);
            this.BrakHasla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BrakHasla.Name = "BrakHasla";
            this.BrakHasla.Size = new System.Drawing.Size(239, 44);
            this.BrakHasla.TabIndex = 6;
            this.BrakHasla.Text = "Podaj hasło !";
            this.BrakHasla.Visible = false;
            this.BrakHasla.Click += new System.EventHandler(this.labelPasswordEmpty_Click);
            // 
            // PanelLogowania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 544);
            this.Controls.Add(this.BrakHasla);
            this.Controls.Add(this.BrakLoginu);
            this.Controls.Add(this.buttonZaloguj);
            this.Controls.Add(this.textBoxHaslo);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.LabHaslo);
            this.Controls.Add(this.LabLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1082, 591);
            this.MinimumSize = new System.Drawing.Size(1082, 591);
            this.Name = "PanelLogowania";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Panel logowania";
            this.Load += new System.EventHandler(this.PanelLogowania_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabLogin;
        private System.Windows.Forms.Label LabHaslo;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxHaslo;
        private System.Windows.Forms.Button buttonZaloguj;
        private System.Windows.Forms.Label BrakLoginu;
        private System.Windows.Forms.Label BrakHasla;
    }
}

