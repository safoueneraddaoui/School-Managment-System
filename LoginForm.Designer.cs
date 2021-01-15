namespace Ecole
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.champ_nom = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.champ_mdp = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.LoginButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(453, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 572);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ecole.Properties.Resources.firstPic;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 572);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-2, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 100);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Caveat", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(286, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "version 1.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Caveat", 32.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "Madrassati";
            // 
            // champ_nom
            // 
            this.champ_nom.BorderColorFocused = System.Drawing.Color.Transparent;
            this.champ_nom.BorderColorIdle = System.Drawing.Color.DodgerBlue;
            this.champ_nom.BorderColorMouseHover = System.Drawing.Color.Transparent;
            this.champ_nom.BorderThickness = 1;
            this.champ_nom.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.champ_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.champ_nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.champ_nom.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.champ_nom.isPassword = false;
            this.champ_nom.Location = new System.Drawing.Point(54, 262);
            this.champ_nom.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.champ_nom.Name = "champ_nom";
            this.champ_nom.Size = new System.Drawing.Size(348, 40);
            this.champ_nom.TabIndex = 5;
            this.champ_nom.Text = "Nom";
            this.champ_nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.champ_nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nom_keyPress);
            // 
            // champ_mdp
            // 
            this.champ_mdp.BorderColorFocused = System.Drawing.Color.Transparent;
            this.champ_mdp.BorderColorIdle = System.Drawing.Color.DodgerBlue;
            this.champ_mdp.BorderColorMouseHover = System.Drawing.Color.Transparent;
            this.champ_mdp.BorderThickness = 1;
            this.champ_mdp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.champ_mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.champ_mdp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.champ_mdp.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.champ_mdp.isPassword = true;
            this.champ_mdp.Location = new System.Drawing.Point(54, 312);
            this.champ_mdp.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.champ_mdp.Name = "champ_mdp";
            this.champ_mdp.Size = new System.Drawing.Size(348, 40);
            this.champ_mdp.TabIndex = 6;
            this.champ_mdp.Text = "Mot de passe";
            this.champ_mdp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.champ_mdp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mdp_keyPress);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Red;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Red;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Quitter";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton22.Location = new System.Drawing.Point(245, 388);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(157, 46);
            this.bunifuThinButton22.TabIndex = 9;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.ActiveBorderThickness = 1;
            this.LoginButton.ActiveCornerRadius = 20;
            this.LoginButton.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.LoginButton.ActiveForecolor = System.Drawing.Color.White;
            this.LoginButton.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.LoginButton.BackColor = System.Drawing.SystemColors.Control;
            this.LoginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginButton.BackgroundImage")));
            this.LoginButton.ButtonText = "Login";
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LoginButton.IdleBorderThickness = 1;
            this.LoginButton.IdleCornerRadius = 20;
            this.LoginButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.LoginButton.IdleForecolor = System.Drawing.Color.White;
            this.LoginButton.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.LoginButton.Location = new System.Drawing.Point(54, 388);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(5);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(166, 46);
            this.LoginButton.TabIndex = 8;
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginButton.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Ecole.Properties.Resources.logoEcole;
            this.pictureBox2.Location = new System.Drawing.Point(169, 105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 512);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.champ_mdp);
            this.Controls.Add(this.champ_nom);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMetroTextbox champ_nom;
        private Bunifu.Framework.UI.BunifuMetroTextbox champ_mdp;
        private Bunifu.Framework.UI.BunifuThinButton2 LoginButton;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
    }
}