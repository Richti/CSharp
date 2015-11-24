namespace FormN
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDéco
            // 
            this.buttonDéco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDéco.Location = new System.Drawing.Point(207, 205);
            this.buttonDéco.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDéco.Name = "buttonDéco";
            this.buttonDéco.Size = new System.Drawing.Size(99, 32);
            this.buttonDéco.TabIndex = 1;
            this.buttonDéco.Text = "Déconnexion";
            this.buttonDéco.UseVisualStyleBackColor = true;
            this.buttonDéco.Click += new System.EventHandler(this.buttonDéco_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.Location = new System.Drawing.Point(237, 79);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(41, 26);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(357, 316);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(349, 287);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Compte";
            // 
            // labelAlias
            // 
            this.labelAlias.AutoSize = true;
            this.labelAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlias.ForeColor = System.Drawing.Color.Red;
            this.labelAlias.Location = new System.Drawing.Point(53, 130);
            this.labelAlias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlias.Name = "labelAlias";
            this.labelAlias.Size = new System.Drawing.Size(167, 17);
            this.labelAlias.TabIndex = 12;
            this.labelAlias.Text = "Merci de choisir un alias !";
            this.labelAlias.Click += new System.EventHandler(this.labelAlias_Click);
            // 
            // textBoxAlias
            // 
            this.textBoxAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlias.Location = new System.Drawing.Point(107, 82);
            this.textBoxAlias.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAlias.Name = "textBoxAlias";
            this.textBoxAlias.Size = new System.Drawing.Size(101, 23);
            this.textBoxAlias.TabIndex = 11;
            this.textBoxAlias.TextChanged += new System.EventHandler(this.textBoxAlias_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Alias";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(53, 33);
            this.labelUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(109, 17);
            this.labelUser.TabIndex = 9;
            this.labelUser.Text = "Texte de Prez";
            this.labelUser.Visible = false;
            // 
            // labelStartServeur
            // 
            this.labelStartServeur.AutoSize = true;
            this.labelStartServeur.ForeColor = System.Drawing.Color.Red;
            this.labelStartServeur.Location = new System.Drawing.Point(53, 164);
            this.labelStartServeur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartServeur.Name = "labelStartServeur";
            this.labelStartServeur.Size = new System.Drawing.Size(132, 17);
            this.labelStartServeur.TabIndex = 8;
            this.labelStartServeur.Text = "Etat du Server : ON";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(349, 287);
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
            this.splitContainer1.Location = new System.Drawing.Point(0, 2);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
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
            this.splitContainer1.Size = new System.Drawing.Size(348, 289);
            this.splitContainer1.SplitterDistance = 117;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 2;
            // 
            // labelSalonCréer
            // 
            this.labelSalonCréer.AutoSize = true;
            this.labelSalonCréer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalonCréer.ForeColor = System.Drawing.Color.Red;
            this.labelSalonCréer.Location = new System.Drawing.Point(23, 84);
            this.labelSalonCréer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSalonCréer.Name = "labelSalonCréer";
            this.labelSalonCréer.Size = new System.Drawing.Size(151, 17);
            this.labelSalonCréer.TabIndex = 5;
            this.labelSalonCréer.Text = "Message de Validation";
            this.labelSalonCréer.Visible = false;
            // 
            // labelCréerSalon
            // 
            this.labelCréerSalon.AutoSize = true;
            this.labelCréerSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCréerSalon.Location = new System.Drawing.Point(23, 14);
            this.labelCréerSalon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCréerSalon.Name = "labelCréerSalon";
            this.labelCréerSalon.Size = new System.Drawing.Size(119, 18);
            this.labelCréerSalon.TabIndex = 0;
            this.labelCréerSalon.Text = "Créer un salon";
            // 
            // buttonValiderSalon
            // 
            this.buttonValiderSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValiderSalon.Location = new System.Drawing.Point(231, 47);
            this.buttonValiderSalon.Margin = new System.Windows.Forms.Padding(2);
            this.buttonValiderSalon.Name = "buttonValiderSalon";
            this.buttonValiderSalon.Size = new System.Drawing.Size(69, 27);
            this.buttonValiderSalon.TabIndex = 3;
            this.buttonValiderSalon.Text = "Créer";
            this.buttonValiderSalon.UseVisualStyleBackColor = true;
            this.buttonValiderSalon.Click += new System.EventHandler(this.buttonValiderSalon_Click);
            // 
            // labelNomSalon
            // 
            this.labelNomSalon.AutoSize = true;
            this.labelNomSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomSalon.Location = new System.Drawing.Point(76, 51);
            this.labelNomSalon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomSalon.Name = "labelNomSalon";
            this.labelNomSalon.Size = new System.Drawing.Size(37, 17);
            this.labelNomSalon.TabIndex = 1;
            this.labelNomSalon.Text = "Nom";
            // 
            // textBoxNomSalon
            // 
            this.textBoxNomSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomSalon.Location = new System.Drawing.Point(135, 49);
            this.textBoxNomSalon.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNomSalon.Name = "textBoxNomSalon";
            this.textBoxNomSalon.Size = new System.Drawing.Size(68, 23);
            this.textBoxNomSalon.TabIndex = 2;
            this.textBoxNomSalon.TextChanged += new System.EventHandler(this.textBoxNomSalon_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 57);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelErrorCreaSal
            // 
            this.labelErrorCreaSal.AutoSize = true;
            this.labelErrorCreaSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorCreaSal.ForeColor = System.Drawing.Color.Red;
            this.labelErrorCreaSal.Location = new System.Drawing.Point(52, 107);
            this.labelErrorCreaSal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelErrorCreaSal.Name = "labelErrorCreaSal";
            this.labelErrorCreaSal.Size = new System.Drawing.Size(151, 17);
            this.labelErrorCreaSal.TabIndex = 5;
            this.labelErrorCreaSal.Text = "Message de Validation";
            this.labelErrorCreaSal.Visible = false;
            // 
            // buttonAccéderSalons
            // 
            this.buttonAccéderSalons.Location = new System.Drawing.Point(231, 53);
            this.buttonAccéderSalons.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAccéderSalons.Name = "buttonAccéderSalons";
            this.buttonAccéderSalons.Size = new System.Drawing.Size(69, 28);
            this.buttonAccéderSalons.TabIndex = 7;
            this.buttonAccéderSalons.Text = "Accéder";
            this.buttonAccéderSalons.UseVisualStyleBackColor = true;
            this.buttonAccéderSalons.Click += new System.EventHandler(this.buttonAccéderSalons_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Liste des salons";
            // 
            // InfoUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 316);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDéco;
        private System.Windows.Forms.Button buttonOk;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxNomSalon;
        private System.Windows.Forms.Label labelNomSalon;
        private System.Windows.Forms.Label labelCréerSalon;
        private System.Windows.Forms.Button buttonValiderSalon;
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
        public System.Windows.Forms.ComboBox comboBox1;


    }
}