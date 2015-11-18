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
            this.buttonDéco = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelAlias = new System.Windows.Forms.Label();
            this.textBoxAlias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelStartServeur = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelSalonCréer = new System.Windows.Forms.Label();
            this.labelCréerSalon = new System.Windows.Forms.Label();
            this.buttonValiderSalon = new System.Windows.Forms.Button();
            this.labelNomSalon = new System.Windows.Forms.Label();
            this.textBoxNomSalon = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelErrorCreaSal = new System.Windows.Forms.Label();
            this.buttonAccéderSalons = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.textBoxConv = new System.Windows.Forms.TextBox();
            this.buttonEnvoyer = new System.Windows.Forms.Button();
            this.richTextBoxMsg = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDéco
            // 
            this.buttonDéco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDéco.Location = new System.Drawing.Point(310, 316);
            this.buttonDéco.Name = "buttonDéco";
            this.buttonDéco.Size = new System.Drawing.Size(148, 50);
            this.buttonDéco.TabIndex = 1;
            this.buttonDéco.Text = "Déconnexion";
            this.buttonDéco.UseVisualStyleBackColor = true;
            this.buttonDéco.Click += new System.EventHandler(this.buttonDéco_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.Location = new System.Drawing.Point(355, 121);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(61, 40);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(536, 486);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SeaShell;
            this.tabPage1.Controls.Add(this.labelAlias);
            this.tabPage1.Controls.Add(this.textBoxAlias);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.labelUser);
            this.tabPage1.Controls.Add(this.labelStartServeur);
            this.tabPage1.Controls.Add(this.buttonDéco);
            this.tabPage1.Controls.Add(this.buttonOk);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(528, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Compte";
            // 
            // labelAlias
            // 
            this.labelAlias.AutoSize = true;
            this.labelAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlias.ForeColor = System.Drawing.Color.Red;
            this.labelAlias.Location = new System.Drawing.Point(79, 200);
            this.labelAlias.Name = "labelAlias";
            this.labelAlias.Size = new System.Drawing.Size(231, 25);
            this.labelAlias.TabIndex = 12;
            this.labelAlias.Text = "Merci de choisir un alias !";
            // 
            // textBoxAlias
            // 
            this.textBoxAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlias.Location = new System.Drawing.Point(161, 126);
            this.textBoxAlias.Name = "textBoxAlias";
            this.textBoxAlias.Size = new System.Drawing.Size(149, 30);
            this.textBoxAlias.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Alias";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(79, 51);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(147, 25);
            this.labelUser.TabIndex = 9;
            this.labelUser.Text = "Texte de Prez";
            this.labelUser.Visible = false;
            // 
            // labelStartServeur
            // 
            this.labelStartServeur.AutoSize = true;
            this.labelStartServeur.ForeColor = System.Drawing.Color.Red;
            this.labelStartServeur.Location = new System.Drawing.Point(79, 253);
            this.labelStartServeur.Name = "labelStartServeur";
            this.labelStartServeur.Size = new System.Drawing.Size(182, 25);
            this.labelStartServeur.TabIndex = 8;
            this.labelStartServeur.Text = "Etat du Server : ON";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(528, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Salons";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.splitContainer1.Panel1.Controls.Add(this.labelSalonCréer);
            this.splitContainer1.Panel1.Controls.Add(this.labelCréerSalon);
            this.splitContainer1.Panel1.Controls.Add(this.buttonValiderSalon);
            this.splitContainer1.Panel1.Controls.Add(this.labelNomSalon);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxNomSalon);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Panel1MinSize = 20;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LightSalmon;
            this.splitContainer1.Panel2.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel2.Controls.Add(this.labelErrorCreaSal);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAccéderSalons);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainer1.Size = new System.Drawing.Size(522, 445);
            this.splitContainer1.SplitterDistance = 181;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 2;
            // 
            // labelSalonCréer
            // 
            this.labelSalonCréer.AutoSize = true;
            this.labelSalonCréer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalonCréer.ForeColor = System.Drawing.Color.Red;
            this.labelSalonCréer.Location = new System.Drawing.Point(35, 130);
            this.labelSalonCréer.Name = "labelSalonCréer";
            this.labelSalonCréer.Size = new System.Drawing.Size(211, 25);
            this.labelSalonCréer.TabIndex = 5;
            this.labelSalonCréer.Text = "Message de Validation";
            this.labelSalonCréer.Visible = false;
            // 
            // labelCréerSalon
            // 
            this.labelCréerSalon.AutoSize = true;
            this.labelCréerSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCréerSalon.Location = new System.Drawing.Point(35, 21);
            this.labelCréerSalon.Name = "labelCréerSalon";
            this.labelCréerSalon.Size = new System.Drawing.Size(168, 26);
            this.labelCréerSalon.TabIndex = 0;
            this.labelCréerSalon.Text = "Créer un salon";
            // 
            // buttonValiderSalon
            // 
            this.buttonValiderSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValiderSalon.Location = new System.Drawing.Point(346, 73);
            this.buttonValiderSalon.Name = "buttonValiderSalon";
            this.buttonValiderSalon.Size = new System.Drawing.Size(104, 42);
            this.buttonValiderSalon.TabIndex = 3;
            this.buttonValiderSalon.Text = "Créer";
            this.buttonValiderSalon.UseVisualStyleBackColor = true;
            this.buttonValiderSalon.Click += new System.EventHandler(this.buttonValiderSalon_Click);
            // 
            // labelNomSalon
            // 
            this.labelNomSalon.AutoSize = true;
            this.labelNomSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomSalon.Location = new System.Drawing.Point(114, 79);
            this.labelNomSalon.Name = "labelNomSalon";
            this.labelNomSalon.Size = new System.Drawing.Size(53, 25);
            this.labelNomSalon.TabIndex = 1;
            this.labelNomSalon.Text = "Nom";
            // 
            // textBoxNomSalon
            // 
            this.textBoxNomSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomSalon.Location = new System.Drawing.Point(203, 76);
            this.textBoxNomSalon.Name = "textBoxNomSalon";
            this.textBoxNomSalon.Size = new System.Drawing.Size(100, 30);
            this.textBoxNomSalon.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 33);
            this.comboBox1.TabIndex = 8;
            // 
            // labelErrorCreaSal
            // 
            this.labelErrorCreaSal.AutoSize = true;
            this.labelErrorCreaSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorCreaSal.ForeColor = System.Drawing.Color.Red;
            this.labelErrorCreaSal.Location = new System.Drawing.Point(78, 164);
            this.labelErrorCreaSal.Name = "labelErrorCreaSal";
            this.labelErrorCreaSal.Size = new System.Drawing.Size(211, 25);
            this.labelErrorCreaSal.TabIndex = 5;
            this.labelErrorCreaSal.Text = "Message de Validation";
            this.labelErrorCreaSal.Visible = false;
            // 
            // buttonAccéderSalons
            // 
            this.buttonAccéderSalons.Location = new System.Drawing.Point(346, 82);
            this.buttonAccéderSalons.Name = "buttonAccéderSalons";
            this.buttonAccéderSalons.Size = new System.Drawing.Size(104, 43);
            this.buttonAccéderSalons.TabIndex = 7;
            this.buttonAccéderSalons.Text = "Accéder";
            this.buttonAccéderSalons.UseVisualStyleBackColor = true;
            this.buttonAccéderSalons.Click += new System.EventHandler(this.buttonAccéderSalons_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Liste des salons";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightSalmon;
            this.tabPage3.Controls.Add(this.buttonQuitter);
            this.tabPage3.Controls.Add(this.textBoxConv);
            this.tabPage3.Controls.Add(this.buttonEnvoyer);
            this.tabPage3.Controls.Add(this.richTextBoxMsg);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(528, 448);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Chat";
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(41, 382);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(107, 37);
            this.buttonQuitter.TabIndex = 7;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // textBoxConv
            // 
            this.textBoxConv.BackColor = System.Drawing.Color.White;
            this.textBoxConv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConv.Location = new System.Drawing.Point(41, 26);
            this.textBoxConv.Multiline = true;
            this.textBoxConv.Name = "textBoxConv";
            this.textBoxConv.ReadOnly = true;
            this.textBoxConv.Size = new System.Drawing.Size(448, 264);
            this.textBoxConv.TabIndex = 6;
            // 
            // buttonEnvoyer
            // 
            this.buttonEnvoyer.Location = new System.Drawing.Point(203, 381);
            this.buttonEnvoyer.Name = "buttonEnvoyer";
            this.buttonEnvoyer.Size = new System.Drawing.Size(114, 38);
            this.buttonEnvoyer.TabIndex = 5;
            this.buttonEnvoyer.Text = "Envoyer";
            this.buttonEnvoyer.UseVisualStyleBackColor = true;
            this.buttonEnvoyer.Click += new System.EventHandler(this.buttonEnvoyer_Click);
            // 
            // richTextBoxMsg
            // 
            this.richTextBoxMsg.Location = new System.Drawing.Point(41, 321);
            this.richTextBoxMsg.Name = "richTextBoxMsg";
            this.richTextBoxMsg.Size = new System.Drawing.Size(448, 54);
            this.richTextBoxMsg.TabIndex = 4;
            this.richTextBoxMsg.Text = "";
            // 
            // InfoUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 486);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InfoUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.InfoUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDéco;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonEnvoyer;
        private System.Windows.Forms.RichTextBox richTextBoxMsg;
        private System.Windows.Forms.TextBox textBoxNomSalon;
        private System.Windows.Forms.Label labelNomSalon;
        private System.Windows.Forms.Label labelCréerSalon;
        private System.Windows.Forms.Button buttonValiderSalon;
        private System.Windows.Forms.TextBox textBoxConv;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAccéderSalons;
        private System.Windows.Forms.Label labelErrorCreaSal;
        private System.Windows.Forms.Label labelStartServeur;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSalonCréer;
        private System.Windows.Forms.TextBox textBoxAlias;
        private System.Windows.Forms.Label labelAlias;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonQuitter;

        

      public System.Windows.Forms.TextBox getTextBoxConv() { return textBoxConv; }

    }
}