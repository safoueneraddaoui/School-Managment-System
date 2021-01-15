namespace Ecole
{
    partial class EnseignantForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnseignantForm));
            this.champ_classe = new Guna.UI.WinForms.GunaComboBox();
            this.champ_genre = new Guna.UI.WinForms.GunaComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.champ_tel = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.champ_nom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.Quitter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EnseignantDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.nom = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mdp = new System.Windows.Forms.Label();
            this.champ_id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.updateButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton4 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.deleteButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.addButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnseignantDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // champ_classe
            // 
            this.champ_classe.BackColor = System.Drawing.Color.Transparent;
            this.champ_classe.BaseColor = System.Drawing.Color.White;
            this.champ_classe.BorderColor = System.Drawing.Color.Silver;
            this.champ_classe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.champ_classe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.champ_classe.FocusedColor = System.Drawing.Color.Empty;
            this.champ_classe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.champ_classe.ForeColor = System.Drawing.Color.Black;
            this.champ_classe.FormattingEnabled = true;
            this.champ_classe.Location = new System.Drawing.Point(102, 330);
            this.champ_classe.Name = "champ_classe";
            this.champ_classe.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.champ_classe.OnHoverItemForeColor = System.Drawing.Color.White;
            this.champ_classe.Size = new System.Drawing.Size(254, 26);
            this.champ_classe.TabIndex = 61;
            // 
            // champ_genre
            // 
            this.champ_genre.BackColor = System.Drawing.Color.Transparent;
            this.champ_genre.BaseColor = System.Drawing.Color.White;
            this.champ_genre.BorderColor = System.Drawing.Color.Silver;
            this.champ_genre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.champ_genre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.champ_genre.FocusedColor = System.Drawing.Color.Empty;
            this.champ_genre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.champ_genre.ForeColor = System.Drawing.Color.Black;
            this.champ_genre.FormattingEnabled = true;
            this.champ_genre.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.champ_genre.Location = new System.Drawing.Point(102, 254);
            this.champ_genre.Name = "champ_genre";
            this.champ_genre.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.champ_genre.OnHoverItemForeColor = System.Drawing.Color.White;
            this.champ_genre.Size = new System.Drawing.Size(254, 26);
            this.champ_genre.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(28, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 56;
            this.label6.Text = "Classe";
            // 
            // champ_tel
            // 
            this.champ_tel.BackColor = System.Drawing.SystemColors.Control;
            this.champ_tel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.champ_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.champ_tel.ForeColor = System.Drawing.Color.Black;
            this.champ_tel.HintForeColor = System.Drawing.Color.Black;
            this.champ_tel.HintText = "";
            this.champ_tel.isPassword = false;
            this.champ_tel.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.champ_tel.LineIdleColor = System.Drawing.Color.Gray;
            this.champ_tel.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.champ_tel.LineThickness = 4;
            this.champ_tel.Location = new System.Drawing.Point(102, 280);
            this.champ_tel.Margin = new System.Windows.Forms.Padding(5);
            this.champ_tel.Name = "champ_tel";
            this.champ_tel.Size = new System.Drawing.Size(254, 41);
            this.champ_tel.TabIndex = 55;
            this.champ_tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.champ_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tel_keyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(57, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 24);
            this.label5.TabIndex = 54;
            this.label5.Text = "Tel";
            // 
            // champ_nom
            // 
            this.champ_nom.BackColor = System.Drawing.SystemColors.Control;
            this.champ_nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.champ_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.champ_nom.ForeColor = System.Drawing.Color.Black;
            this.champ_nom.HintForeColor = System.Drawing.Color.Black;
            this.champ_nom.HintText = "";
            this.champ_nom.isPassword = false;
            this.champ_nom.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.champ_nom.LineIdleColor = System.Drawing.Color.Gray;
            this.champ_nom.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.champ_nom.LineThickness = 4;
            this.champ_nom.Location = new System.Drawing.Point(102, 205);
            this.champ_nom.Margin = new System.Windows.Forms.Padding(5);
            this.champ_nom.Name = "champ_nom";
            this.champ_nom.Size = new System.Drawing.Size(254, 41);
            this.champ_nom.TabIndex = 52;
            this.champ_nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.champ_nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nom_keyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.gunaImageButton1);
            this.panel1.Controls.Add(this.Quitter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 100);
            this.panel1.TabIndex = 40;
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaImageButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = global::Ecole.Properties.Resources.home;
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.Location = new System.Drawing.Point(102, 12);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gunaImageButton1.Size = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.TabIndex = 64;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // Quitter
            // 
            this.Quitter.AutoSize = true;
            this.Quitter.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitter.Location = new System.Drawing.Point(855, 1);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(32, 31);
            this.Quitter.TabIndex = 6;
            this.Quitter.Text = "X";
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Caveat", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(490, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "version 1.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Caveat", 32.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(332, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "Madrassati";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Caveat", 32.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(547, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 56);
            this.label3.TabIndex = 46;
            this.label3.Text = "Liste des Enseignants";
            // 
            // EnseignantDGV
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.EnseignantDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.EnseignantDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EnseignantDGV.BackgroundColor = System.Drawing.Color.White;
            this.EnseignantDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnseignantDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EnseignantDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EnseignantDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.EnseignantDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EnseignantDGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.EnseignantDGV.EnableHeadersVisualStyles = false;
            this.EnseignantDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EnseignantDGV.Location = new System.Drawing.Point(380, 177);
            this.EnseignantDGV.Name = "EnseignantDGV";
            this.EnseignantDGV.RowHeadersVisible = false;
            this.EnseignantDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EnseignantDGV.Size = new System.Drawing.Size(498, 266);
            this.EnseignantDGV.TabIndex = 49;
            this.EnseignantDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.EnseignantDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EnseignantDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EnseignantDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EnseignantDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EnseignantDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EnseignantDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EnseignantDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EnseignantDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.EnseignantDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EnseignantDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.EnseignantDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EnseignantDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EnseignantDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.EnseignantDGV.ThemeStyle.ReadOnly = false;
            this.EnseignantDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EnseignantDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EnseignantDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.EnseignantDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EnseignantDGV.ThemeStyle.RowsStyle.Height = 22;
            this.EnseignantDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EnseignantDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EnseignantDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdminDGV_CellContentClick);
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.nom.ForeColor = System.Drawing.Color.DodgerBlue;
            this.nom.Location = new System.Drawing.Point(43, 222);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(51, 24);
            this.nom.TabIndex = 43;
            this.nom.Text = "Nom";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(0, 497);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 15);
            this.panel2.TabIndex = 41;
            // 
            // mdp
            // 
            this.mdp.AutoSize = true;
            this.mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.mdp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.mdp.Location = new System.Drawing.Point(33, 256);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(63, 24);
            this.mdp.TabIndex = 44;
            this.mdp.Text = "Genre";
            // 
            // champ_id
            // 
            this.champ_id.BackColor = System.Drawing.SystemColors.Control;
            this.champ_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.champ_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.champ_id.ForeColor = System.Drawing.Color.Black;
            this.champ_id.HintForeColor = System.Drawing.Color.Black;
            this.champ_id.HintText = "";
            this.champ_id.isPassword = false;
            this.champ_id.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.champ_id.LineIdleColor = System.Drawing.Color.Gray;
            this.champ_id.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.champ_id.LineThickness = 4;
            this.champ_id.Location = new System.Drawing.Point(102, 168);
            this.champ_id.Margin = new System.Windows.Forms.Padding(5);
            this.champ_id.Name = "champ_id";
            this.champ_id.Size = new System.Drawing.Size(254, 41);
            this.champ_id.TabIndex = 63;
            this.champ_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.champ_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_keyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(43, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 24);
            this.label4.TabIndex = 62;
            this.label4.Text = "ID";
            // 
            // updateButton
            // 
            this.updateButton.AnimationHoverSpeed = 0.07F;
            this.updateButton.AnimationSpeed = 0.03F;
            this.updateButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.updateButton.BorderColor = System.Drawing.Color.Black;
            this.updateButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.updateButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.updateButton.CheckedForeColor = System.Drawing.Color.White;
            this.updateButton.CheckedImage = global::Ecole.Properties.Resources.se_deconnecter;
            this.updateButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.updateButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.updateButton.FocusedColor = System.Drawing.Color.Empty;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Image = global::Ecole.Properties.Resources.edit_button1;
            this.updateButton.ImageSize = new System.Drawing.Size(20, 20);
            this.updateButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.updateButton.Location = new System.Drawing.Point(207, 401);
            this.updateButton.Name = "updateButton";
            this.updateButton.OnHoverBaseColor = System.Drawing.Color.CornflowerBlue;
            this.updateButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.updateButton.OnHoverForeColor = System.Drawing.Color.White;
            this.updateButton.OnHoverImage = null;
            this.updateButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.updateButton.OnPressedColor = System.Drawing.Color.Black;
            this.updateButton.Size = new System.Drawing.Size(149, 42);
            this.updateButton.TabIndex = 48;
            this.updateButton.Text = "Modifier";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // gunaAdvenceButton4
            // 
            this.gunaAdvenceButton4.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton4.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton4.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton4.CheckedImage = global::Ecole.Properties.Resources.se_deconnecter;
            this.gunaAdvenceButton4.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton4.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton4.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton4.Image")));
            this.gunaAdvenceButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton4.Location = new System.Drawing.Point(729, 449);
            this.gunaAdvenceButton4.Name = "gunaAdvenceButton4";
            this.gunaAdvenceButton4.OnHoverBaseColor = System.Drawing.Color.Red;
            this.gunaAdvenceButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton4.OnHoverImage = null;
            this.gunaAdvenceButton4.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.Size = new System.Drawing.Size(149, 42);
            this.gunaAdvenceButton4.TabIndex = 51;
            this.gunaAdvenceButton4.Text = "Deconnecter";
            this.gunaAdvenceButton4.Click += new System.EventHandler(this.gunaAdvenceButton4_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.AnimationHoverSpeed = 0.07F;
            this.deleteButton.AnimationSpeed = 0.03F;
            this.deleteButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.deleteButton.BorderColor = System.Drawing.Color.Black;
            this.deleteButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.deleteButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.deleteButton.CheckedForeColor = System.Drawing.Color.White;
            this.deleteButton.CheckedImage = global::Ecole.Properties.Resources.se_deconnecter;
            this.deleteButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.deleteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteButton.FocusedColor = System.Drawing.Color.Empty;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Image = global::Ecole.Properties.Resources.delete;
            this.deleteButton.ImageSize = new System.Drawing.Size(20, 20);
            this.deleteButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.deleteButton.Location = new System.Drawing.Point(138, 449);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.OnHoverBaseColor = System.Drawing.Color.Red;
            this.deleteButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deleteButton.OnHoverForeColor = System.Drawing.Color.White;
            this.deleteButton.OnHoverImage = null;
            this.deleteButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.deleteButton.OnPressedColor = System.Drawing.Color.Black;
            this.deleteButton.Size = new System.Drawing.Size(149, 42);
            this.deleteButton.TabIndex = 50;
            this.deleteButton.Text = "Supprimer";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.AnimationHoverSpeed = 0.07F;
            this.addButton.AnimationSpeed = 0.03F;
            this.addButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.addButton.BorderColor = System.Drawing.Color.Black;
            this.addButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.addButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.addButton.CheckedForeColor = System.Drawing.Color.White;
            this.addButton.CheckedImage = global::Ecole.Properties.Resources.se_deconnecter;
            this.addButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.addButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addButton.FocusedColor = System.Drawing.Color.Empty;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Image = global::Ecole.Properties.Resources.plus;
            this.addButton.ImageSize = new System.Drawing.Size(20, 20);
            this.addButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.addButton.Location = new System.Drawing.Point(46, 401);
            this.addButton.Name = "addButton";
            this.addButton.OnHoverBaseColor = System.Drawing.Color.CornflowerBlue;
            this.addButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addButton.OnHoverForeColor = System.Drawing.Color.White;
            this.addButton.OnHoverImage = null;
            this.addButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.addButton.OnPressedColor = System.Drawing.Color.Black;
            this.addButton.Size = new System.Drawing.Size(149, 42);
            this.addButton.TabIndex = 47;
            this.addButton.Text = "Ajouter";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // EnseignantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 512);
            this.Controls.Add(this.champ_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.champ_classe);
            this.Controls.Add(this.champ_genre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.champ_tel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.champ_nom);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaAdvenceButton4);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EnseignantDGV);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mdp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnseignantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnseignantForm";
            this.Load += new System.EventHandler(this.EnseignantForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnseignantDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox champ_classe;
        private Guna.UI.WinForms.GunaComboBox champ_genre;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox champ_tel;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox champ_nom;
        private Guna.UI.WinForms.GunaAdvenceButton updateButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Quitter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton4;
        private Guna.UI.WinForms.GunaAdvenceButton deleteButton;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaDataGridView EnseignantDGV;
        private Guna.UI.WinForms.GunaAdvenceButton addButton;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label mdp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox champ_id;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
    }
}