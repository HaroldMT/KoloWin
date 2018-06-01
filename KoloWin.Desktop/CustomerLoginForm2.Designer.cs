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
            this.textEditMotdePasse = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonSeconnecter = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSortir = new DevExpress.XtraEditors.SimpleButton();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.koloUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.textEditNomdelutilisateur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMotdePasse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.koloUsersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(42, 161);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nom de l\'utilisateur";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(42, 232);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mot de passe";
            // 
            // textEditNomdelutilisateur
            // 
            this.textEditNomdelutilisateur.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.koloUsersBindingSource, "IdCustomer", true));
            this.textEditNomdelutilisateur.Location = new System.Drawing.Point(173, 158);
            this.textEditNomdelutilisateur.Name = "textEditNomdelutilisateur";
            this.textEditNomdelutilisateur.Size = new System.Drawing.Size(171, 20);
            this.textEditNomdelutilisateur.TabIndex = 2;
            // 
            // textEditMotdePasse
            // 
            this.textEditMotdePasse.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.koloUsersBindingSource, "Pwd", true));
            this.textEditMotdePasse.Location = new System.Drawing.Point(173, 229);
            this.textEditMotdePasse.Name = "textEditMotdePasse";
            this.textEditMotdePasse.Size = new System.Drawing.Size(171, 20);
            this.textEditMotdePasse.TabIndex = 3;
            // 
            // simpleButtonSeconnecter
            // 
            this.simpleButtonSeconnecter.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButtonSeconnecter.Location = new System.Drawing.Point(146, 310);
            this.simpleButtonSeconnecter.Name = "simpleButtonSeconnecter";
            this.simpleButtonSeconnecter.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonSeconnecter.TabIndex = 4;
            this.simpleButtonSeconnecter.Text = "Se connecter";
            this.simpleButtonSeconnecter.Click += new System.EventHandler(this.BtnSeconnecter);
            // 
            // simpleButtonSortir
            // 
            this.simpleButtonSortir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButtonSortir.Location = new System.Drawing.Point(287, 310);
            this.simpleButtonSortir.Name = "simpleButtonSortir";
            this.simpleButtonSortir.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonSortir.TabIndex = 5;
            this.simpleButtonSortir.Text = "Sortir";
            this.simpleButtonSortir.Click += new System.EventHandler(this.BtnSortir);
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(211, 255);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(100, 13);
            this.hyperlinkLabelControl1.TabIndex = 6;
            this.hyperlinkLabelControl1.Text = "Mot de passe oublie?";
            this.hyperlinkLabelControl1.Click += new System.EventHandler(this.hyperlinkLabelControl1_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(35, 30);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gray;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(90, 95);
            this.pictureEdit1.TabIndex = 7;
            // 
            // koloUsersBindingSource
            // 
            this.koloUsersBindingSource.DataSource = typeof(KoloWin.Desktop.KoloGateway.KoloUser);
            // 
            // CustomerLoginForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(424, 403);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.hyperlinkLabelControl1);
            this.Controls.Add(this.simpleButtonSortir);
            this.Controls.Add(this.simpleButtonSeconnecter);
            this.Controls.Add(this.textEditMotdePasse);
            this.Controls.Add(this.textEditNomdelutilisateur);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "CustomerLoginForm2";
            this.Text = "CustomerLoginForm2";
            ((System.ComponentModel.ISupportInitialize)(this.textEditNomdelutilisateur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMotdePasse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.koloUsersBindingSource)).EndInit();
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
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.BindingSource koloUsersBindingSource;
    }
}