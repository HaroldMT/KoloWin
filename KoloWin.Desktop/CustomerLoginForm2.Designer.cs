namespace KoloWin.Desktop
{
    partial class CustomerLoginForm2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerLoginForm2));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditNomdelutilisateur = new DevExpress.XtraEditors.TextEdit();
            this.koloUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textEditMotdePasse = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonSeconnecter = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSortir = new DevExpress.XtraEditors.SimpleButton();
            this.hyperlinkLabelMotdepasseoublie = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNomdelutilisateur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.koloUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMotdePasse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Window;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(68, 191);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(104, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nom de l\'utilisateur";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.Window;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(68, 262);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mot de passe";
            // 
            // textEditNomdelutilisateur
            // 
            this.textEditNomdelutilisateur.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.koloUsersBindingSource, "IdCustomer", true));
            this.textEditNomdelutilisateur.Location = new System.Drawing.Point(242, 188);
            this.textEditNomdelutilisateur.Name = "textEditNomdelutilisateur";
            this.textEditNomdelutilisateur.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.textEditNomdelutilisateur.Properties.Appearance.Options.UseBackColor = true;
            this.textEditNomdelutilisateur.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.textEditNomdelutilisateur.Size = new System.Drawing.Size(226, 20);
            this.textEditNomdelutilisateur.TabIndex = 2;
            // 
            // koloUsersBindingSource
            // 
            this.koloUsersBindingSource.DataSource = typeof(KoloWin.Desktop.KoloGateway.KoloUser);
            // 
            // textEditMotdePasse
            // 
            this.textEditMotdePasse.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.koloUsersBindingSource, "Pwd", true));
            this.textEditMotdePasse.Location = new System.Drawing.Point(242, 259);
            this.textEditMotdePasse.Name = "textEditMotdePasse";
            this.textEditMotdePasse.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.textEditMotdePasse.Size = new System.Drawing.Size(226, 20);
            this.textEditMotdePasse.TabIndex = 3;
            // 
            // simpleButtonSeconnecter
            // 
            this.simpleButtonSeconnecter.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButtonSeconnecter.Location = new System.Drawing.Point(247, 333);
            this.simpleButtonSeconnecter.Name = "simpleButtonSeconnecter";
            this.simpleButtonSeconnecter.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonSeconnecter.TabIndex = 4;
            this.simpleButtonSeconnecter.Text = "Se connecter";
            this.simpleButtonSeconnecter.Click += new System.EventHandler(this.BtnSeconnecter);
            // 
            // simpleButtonSortir
            // 
            this.simpleButtonSortir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButtonSortir.Location = new System.Drawing.Point(388, 333);
            this.simpleButtonSortir.Name = "simpleButtonSortir";
            this.simpleButtonSortir.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonSortir.TabIndex = 5;
            this.simpleButtonSortir.Text = "Sortir";
            this.simpleButtonSortir.Click += new System.EventHandler(this.BtnSortir);
            // 
            // hyperlinkLabelMotdepasseoublie
            // 
            this.hyperlinkLabelMotdepasseoublie.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.hyperlinkLabelMotdepasseoublie.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hyperlinkLabelMotdepasseoublie.Appearance.ForeColor = System.Drawing.Color.Black;
            this.hyperlinkLabelMotdepasseoublie.Appearance.Options.UseBackColor = true;
            this.hyperlinkLabelMotdepasseoublie.Appearance.Options.UseFont = true;
            this.hyperlinkLabelMotdepasseoublie.Appearance.Options.UseForeColor = true;
            this.hyperlinkLabelMotdepasseoublie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hyperlinkLabelMotdepasseoublie.LineColor = System.Drawing.Color.Black;
            this.hyperlinkLabelMotdepasseoublie.LineVisible = true;
            this.hyperlinkLabelMotdepasseoublie.Location = new System.Drawing.Point(333, 302);
            this.hyperlinkLabelMotdepasseoublie.Name = "hyperlinkLabelMotdepasseoublie";
            this.hyperlinkLabelMotdepasseoublie.Size = new System.Drawing.Size(130, 14);
            this.hyperlinkLabelMotdepasseoublie.TabIndex = 6;
            this.hyperlinkLabelMotdepasseoublie.Text = "Mot de passe oublié?";
            this.hyperlinkLabelMotdepasseoublie.Click += new System.EventHandler(this.Motdepasseoublié);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(199, 245);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(42, 42);
            this.pictureEdit2.TabIndex = 10;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(201, 182);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.ZoomPercent = 70D;
            this.pictureEdit3.Size = new System.Drawing.Size(39, 30);
            this.pictureEdit3.TabIndex = 11;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(247, 23);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(100, 96);
            this.pictureEdit1.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(120, 125);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(343, 29);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Entrez les détails de votre compte ";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(182, 302);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.checkEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.checkEdit1.Properties.Caption = "Se souvenir";
            this.checkEdit1.Size = new System.Drawing.Size(75, 19);
            this.checkEdit1.TabIndex = 14;
            // 
            // CustomerLoginForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(552, 448);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.textEditNomdelutilisateur);
            this.Controls.Add(this.hyperlinkLabelMotdepasseoublie);
            this.Controls.Add(this.simpleButtonSortir);
            this.Controls.Add(this.simpleButtonSeconnecter);
            this.Controls.Add(this.textEditMotdePasse);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomerLoginForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerLoginForm2";
            ((System.ComponentModel.ISupportInitialize)(this.textEditNomdelutilisateur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.koloUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMotdePasse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditNomdelutilisateur;
        private DevExpress.XtraEditors.TextEdit textEditMotdePasse;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSeconnecter;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSortir;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelMotdepasseoublie;
        private System.Windows.Forms.BindingSource koloUsersBindingSource;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}