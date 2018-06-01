namespace KoloWin.Desktop
{
    partial class RecoveryCustomerLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoveryCustomerLoginForm));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditAdresseemail = new DevExpress.XtraEditors.TextEdit();
            this.textEditMotdepasse = new DevExpress.XtraEditors.TextEdit();
            this.BtnSeconnecter = new DevExpress.XtraEditors.SimpleButton();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.checkEditSesouvenir = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEditConfirmermotdepasse = new DevExpress.XtraEditors.TextEdit();
            this.BtnEnregistrer = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAdresseemail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMotdepasse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditSesouvenir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditConfirmermotdepasse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(43, 116);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Adresse Email";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(50, 232);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(114, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Confirmer mot de passe";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // textEditAdresseemail
            // 
            this.textEditAdresseemail.Location = new System.Drawing.Point(82, 140);
            this.textEditAdresseemail.Name = "textEditAdresseemail";
            this.textEditAdresseemail.Size = new System.Drawing.Size(341, 20);
            this.textEditAdresseemail.TabIndex = 2;
            // 
            // textEditMotdepasse
            // 
            this.textEditMotdepasse.Location = new System.Drawing.Point(82, 196);
            this.textEditMotdepasse.Name = "textEditMotdepasse";
            this.textEditMotdepasse.Size = new System.Drawing.Size(341, 20);
            this.textEditMotdepasse.TabIndex = 3;
            // 
            // BtnSeconnecter
            // 
            this.BtnSeconnecter.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.BtnSeconnecter.Location = new System.Drawing.Point(341, 315);
            this.BtnSeconnecter.Name = "BtnSeconnecter";
            this.BtnSeconnecter.Size = new System.Drawing.Size(82, 23);
            this.BtnSeconnecter.TabIndex = 4;
            this.BtnSeconnecter.Text = "Se connecter";
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(201, 283);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(100, 13);
            this.hyperlinkLabelControl1.TabIndex = 5;
            this.hyperlinkLabelControl1.Text = "Mot de passe oublie?";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(189, 25);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Properties.ZoomAcceleration = 100D;
            this.pictureEdit1.Properties.ZoomPercent = 50D;
            this.pictureEdit1.Size = new System.Drawing.Size(99, 91);
            this.pictureEdit1.TabIndex = 6;
            // 
            // checkEditSesouvenir
            // 
            this.checkEditSesouvenir.Location = new System.Drawing.Point(82, 317);
            this.checkEditSesouvenir.Name = "checkEditSesouvenir";
            this.checkEditSesouvenir.Properties.Caption = "Se souvenir?";
            this.checkEditSesouvenir.Size = new System.Drawing.Size(75, 19);
            this.checkEditSesouvenir.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(43, 177);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(110, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Nouveau mot de passe";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // textEditConfirmermotdepasse
            // 
            this.textEditConfirmermotdepasse.Location = new System.Drawing.Point(82, 251);
            this.textEditConfirmermotdepasse.Name = "textEditConfirmermotdepasse";
            this.textEditConfirmermotdepasse.Size = new System.Drawing.Size(341, 20);
            this.textEditConfirmermotdepasse.TabIndex = 9;
            // 
            // BtnEnregistrer
            // 
            this.BtnEnregistrer.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.BtnEnregistrer.Location = new System.Drawing.Point(234, 315);
            this.BtnEnregistrer.Name = "BtnEnregistrer";
            this.BtnEnregistrer.Size = new System.Drawing.Size(82, 23);
            this.BtnEnregistrer.TabIndex = 10;
            this.BtnEnregistrer.Text = "Enregistrer";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(421, 2);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.ZoomAcceleration = 100D;
            this.pictureEdit2.Properties.ZoomPercent = 50D;
            this.pictureEdit2.Size = new System.Drawing.Size(53, 52);
            this.pictureEdit2.TabIndex = 11;
            // 
            // RecoveryCustomerLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(471, 394);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.BtnEnregistrer);
            this.Controls.Add(this.textEditConfirmermotdepasse);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.checkEditSesouvenir);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.hyperlinkLabelControl1);
            this.Controls.Add(this.BtnSeconnecter);
            this.Controls.Add(this.textEditMotdepasse);
            this.Controls.Add(this.textEditAdresseemail);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "RecoveryCustomerLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecoveryCustomerLoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.textEditAdresseemail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMotdepasse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditSesouvenir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditConfirmermotdepasse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditAdresseemail;
        private DevExpress.XtraEditors.TextEdit textEditMotdepasse;
        private DevExpress.XtraEditors.SimpleButton BtnSeconnecter;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.CheckEdit checkEditSesouvenir;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEditConfirmermotdepasse;
        private DevExpress.XtraEditors.SimpleButton BtnEnregistrer;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
    }
}