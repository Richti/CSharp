namespace FormN
{
    partial class Connexion
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.buttonCréer = new System.Windows.Forms.Button();
            this.labelErreur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(62, 43);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(38, 15);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login";
            this.labelLogin.Click += new System.EventHandler(this.labelLogin_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(62, 97);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(61, 15);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            this.labelPassword.Click += new System.EventHandler(this.labelPassword_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.Location = new System.Drawing.Point(167, 42);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(105, 23);
            this.textBoxLogin.TabIndex = 2;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(167, 98);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(105, 23);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnexion.Location = new System.Drawing.Point(182, 175);
            this.buttonConnexion.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(90, 28);
            this.buttonConnexion.TabIndex = 4;
            this.buttonConnexion.Text = "Connexion";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // buttonCréer
            // 
            this.buttonCréer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCréer.Location = new System.Drawing.Point(65, 175);
            this.buttonCréer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCréer.Name = "buttonCréer";
            this.buttonCréer.Size = new System.Drawing.Size(77, 28);
            this.buttonCréer.TabIndex = 5;
            this.buttonCréer.Text = "Créer";
            this.buttonCréer.UseVisualStyleBackColor = true;
            this.buttonCréer.Click += new System.EventHandler(this.buttonCréer_Click);
            // 
            // labelErreur
            // 
            this.labelErreur.AutoSize = true;
            this.labelErreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelErreur.ForeColor = System.Drawing.Color.Red;
            this.labelErreur.Location = new System.Drawing.Point(65, 136);
            this.labelErreur.Name = "labelErreur";
            this.labelErreur.Size = new System.Drawing.Size(0, 17);
            this.labelErreur.TabIndex = 6;
            this.labelErreur.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(327, 234);
            this.Controls.Add(this.labelErreur);
            this.Controls.Add(this.buttonCréer);
            this.Controls.Add(this.buttonConnexion);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAUNCHER";
            this.Load += new System.EventHandler(this.Connexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.Button buttonCréer;
        private System.Windows.Forms.Label labelErreur;
    }
}