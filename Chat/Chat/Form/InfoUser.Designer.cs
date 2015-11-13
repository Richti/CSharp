namespace Chat
{
    partial class InfoUser
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
            this.labelUser = new System.Windows.Forms.Label();
            this.buttonDéco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(94, 86);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(106, 20);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "Texte de Prez";
            this.labelUser.Click += new System.EventHandler(this.labelUser_Click);
            // 
            // buttonDéco
            // 
            this.buttonDéco.Location = new System.Drawing.Point(187, 185);
            this.buttonDéco.Name = "buttonDéco";
            this.buttonDéco.Size = new System.Drawing.Size(129, 41);
            this.buttonDéco.TabIndex = 1;
            this.buttonDéco.Text = "Déconnexion";
            this.buttonDéco.UseVisualStyleBackColor = true;
            this.buttonDéco.Click += new System.EventHandler(this.buttonDéco_Click);
            // 
            // InfoUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 318);
            this.Controls.Add(this.buttonDéco);
            this.Controls.Add(this.labelUser);
            this.Name = "InfoUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.InfoUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button buttonDéco;
    }
}