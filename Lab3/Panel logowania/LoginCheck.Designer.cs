namespace Panel_logowania
{
    partial class LoginCheck
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
            this.StatusLogowania = new System.Windows.Forms.Label();
            this.PrzyciskEnter = new System.Windows.Forms.Button();
            this.MojeDane = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StatusLogowania
            // 
            this.StatusLogowania.AutoSize = true;
            this.StatusLogowania.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StatusLogowania.Location = new System.Drawing.Point(33, 158);
            this.StatusLogowania.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLogowania.Name = "StatusLogowania";
            this.StatusLogowania.Size = new System.Drawing.Size(109, 39);
            this.StatusLogowania.TabIndex = 0;
            this.StatusLogowania.Text = "label1";
            // 
            // PrzyciskEnter
            // 
            this.PrzyciskEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrzyciskEnter.Location = new System.Drawing.Point(137, 331);
            this.PrzyciskEnter.Margin = new System.Windows.Forms.Padding(4);
            this.PrzyciskEnter.Name = "PrzyciskEnter";
            this.PrzyciskEnter.Size = new System.Drawing.Size(231, 99);
            this.PrzyciskEnter.TabIndex = 1;
            this.PrzyciskEnter.Text = "Zamknij Okno";
            this.PrzyciskEnter.UseVisualStyleBackColor = true;
            this.PrzyciskEnter.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // MojeDane
            // 
            this.MojeDane.AutoSize = true;
            this.MojeDane.Location = new System.Drawing.Point(12, 9);
            this.MojeDane.Name = "MojeDane";
            this.MojeDane.Size = new System.Drawing.Size(217, 17);
            this.MojeDane.TabIndex = 2;
            this.MojeDane.Text = "Sebastian WIecheć nr.ind. 39870";
            // 
            // LoginCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 444);
            this.Controls.Add(this.MojeDane);
            this.Controls.Add(this.PrzyciskEnter);
            this.Controls.Add(this.StatusLogowania);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginCheck";
            this.Text = "Sprawdzenie";
            this.Load += new System.EventHandler(this.LoginCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusLogowania;
        private System.Windows.Forms.Button PrzyciskEnter;
        private System.Windows.Forms.Label MojeDane;
    }
}