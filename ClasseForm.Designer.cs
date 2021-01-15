namespace Ecole
{
    partial class ClasseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClasseForm));
            this.champ_nom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClassDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.champ_id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nom = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Quitter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mdp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.champ_desc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gunaAdvenceButton4 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.deleteButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.updateButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.addButton = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.ClassDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.champ_nom.Location = new System.Drawing.Point(102, 211);
            this.champ_nom.Margin = new System.Windows.Forms.Padding(5);
            this.champ_nom.Name = "champ_nom";
            this.champ_nom.Size = new System.Drawing.Size(254, 41);
            this.champ_nom.TabIndex = 28;
            this.champ_nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.champ_nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.classe_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Caveat", 32.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(547, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 56);
            this.label3.TabIndex = 21;
            this.label3.Text = "Liste des Classes";
            // 
            // ClassDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ClassDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ClassDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClassDGV.BackgroundColor = System.Drawing.Color.White;
            this.ClassDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClassDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ClassDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClassDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ClassDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClassDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.ClassDGV.EnableHeadersVisualStyles = false;
            this.ClassDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClassDGV.Location = new System.Drawing.Point(381, 208);
            this.ClassDGV.Name = "ClassDGV";
            this.ClassDGV.RowHeadersVisible = false;
            this.ClassDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClassDGV.Size = new System.Drawing.Size(498, 266);
            this.ClassDGV.TabIndex = 25;
            this.ClassDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.ClassDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ClassDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ClassDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ClassDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ClassDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ClassDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ClassDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClassDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClassDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ClassDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ClassDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ClassDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ClassDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.ClassDGV.ThemeStyle.ReadOnly = false;
            this.ClassDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ClassDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ClassDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ClassDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ClassDGV.ThemeStyle.RowsStyle.Height = 22;
            this.ClassDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClassDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ClassDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClassDGV_CellContentClick);
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
            this.champ_id.Location = new System.Drawing.Point(102, 160);
            this.champ_id.Margin = new System.Windows.Forms.Padding(5);
            this.champ_id.Name = "champ_id";
            this.champ_id.Size = new System.Drawing.Size(254, 41);
            this.champ_id.TabIndex = 20;
            this.champ_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.champ_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_keyPress);
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.nom.ForeColor = System.Drawing.Color.DodgerBlue;
            this.nom.Location = new System.Drawing.Point(28, 228);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(66, 24);
            this.nom.TabIndex = 18;
            this.nom.Text = "Classe";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.id.ForeColor = System.Drawing.Color.DodgerBlue;
            this.id.Location = new System.Drawing.Point(67, 177);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(27, 24);
            this.id.TabIndex = 17;
            this.id.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(0, 497);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 15);
            this.panel2.TabIndex = 16;
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
            // mdp
            // 
            this.mdp.AutoSize = true;
            this.mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.mdp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.mdp.Location = new System.Drawing.Point(-1, 276);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(95, 20);
            this.mdp.TabIndex = 19;
            this.mdp.Text = "Description";
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
            this.panel1.TabIndex = 15;
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
            this.gunaImageButton1.TabIndex = 30;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // champ_desc
            // 
            this.champ_desc.BackColor = System.Drawing.SystemColors.Control;
            this.champ_desc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.champ_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.champ_desc.ForeColor = System.Drawing.Color.Black;
            this.champ_desc.HintForeColor = System.Drawing.Color.Black;
            this.champ_desc.HintText = "";
            this.champ_desc.isPassword = false;
            this.champ_desc.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.champ_desc.LineIdleColor = System.Drawing.Color.Gray;
            this.champ_desc.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.champ_desc.LineThickness = 4;
            this.champ_desc.Location = new System.Drawing.Point(102, 255);
            this.champ_desc.Margin = new System.Windows.Forms.Padding(5);
            this.champ_desc.Name = "champ_desc";
            this.champ_desc.Size = new System.Drawing.Size(254, 41);
            this.champ_desc.TabIndex = 29;
            this.champ_desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.champ_desc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.desc_keyPress);
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
            this.gunaAdvenceButton4.Location = new System.Drawing.Point(46, 432);
            this.gunaAdvenceButton4.Name = "gunaAdvenceButton4";
            this.gunaAdvenceButton4.OnHoverBaseColor = System.Drawing.Color.Red;
            this.gunaAdvenceButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton4.OnHoverImage = null;
            this.gunaAdvenceButton4.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.Size = new System.Drawing.Size(310, 42);
            this.gunaAdvenceButton4.TabIndex = 27;
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
            this.deleteButton.Location = new System.Drawing.Point(122, 384);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.OnHoverBaseColor = System.Drawing.Color.Red;
            this.deleteButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deleteButton.OnHoverForeColor = System.Drawing.Color.White;
            this.deleteButton.OnHoverImage = null;
            this.deleteButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.deleteButton.OnPressedColor = System.Drawing.Color.Black;
            this.deleteButton.Size = new System.Drawing.Size(149, 42);
            this.deleteButton.TabIndex = 26;
            this.deleteButton.Text = "Supprimer";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
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
            this.updateButton.Location = new System.Drawing.Point(207, 336);
            this.updateButton.Name = "updateButton";
            this.updateButton.OnHoverBaseColor = System.Drawing.Color.CornflowerBlue;
            this.updateButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.updateButton.OnHoverForeColor = System.Drawing.Color.White;
            this.updateButton.OnHoverImage = null;
            this.updateButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.updateButton.OnPressedColor = System.Drawing.Color.Black;
            this.updateButton.Size = new System.Drawing.Size(149, 42);
            this.updateButton.TabIndex = 24;
            this.updateButton.Text = "Modifier";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
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
            this.addButton.Location = new System.Drawing.Point(46, 336);
            this.addButton.Name = "addButton";
            this.addButton.OnHoverBaseColor = System.Drawing.Color.CornflowerBlue;
            this.addButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addButton.OnHoverForeColor = System.Drawing.Color.White;
            this.addButton.OnHoverImage = null;
            this.addButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.addButton.OnPressedColor = System.Drawing.Color.Black;
            this.addButton.Size = new System.Drawing.Size(149, 42);
            this.addButton.TabIndex = 23;
            this.addButton.Text = "Ajouter";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ClasseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 512);
            this.Controls.Add(this.champ_desc);
            this.Controls.Add(this.champ_nom);
            this.Controls.Add(this.gunaAdvenceButton4);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClassDGV);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.champ_id);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.id);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClasseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClasseForm";
            this.Load += new System.EventHandler(this.ClasseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox champ_nom;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton4;
        private Guna.UI.WinForms.GunaAdvenceButton deleteButton;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaDataGridView ClassDGV;
        private Guna.UI.WinForms.GunaAdvenceButton updateButton;
        private Guna.UI.WinForms.GunaAdvenceButton addButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox champ_id;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Quitter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mdp;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox champ_desc;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
    }
}