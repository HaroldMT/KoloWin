namespace KoloWin.Desktop
{
    partial class CountriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountriesForm));
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countriesGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButtonEnregistrer = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonEditer = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSupprimer = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonAjouter = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonActualiser = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tileControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tileControl1.Location = new System.Drawing.Point(-397, 252);
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(842, 122);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.countriesGridControl);
            this.layoutControl1.Location = new System.Drawing.Point(0, 121);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(879, 372);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(879, 372);
            this.layoutControlGroup1.Text = "`";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataSource = typeof(KoloWin.Desktop.KoloGateway.Country);
            // 
            // countriesGridControl
            // 
            this.countriesGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countriesGridControl.DataSource = this.countriesBindingSource;
            this.countriesGridControl.Location = new System.Drawing.Point(12, 12);
            this.countriesGridControl.MainView = this.gridView1;
            this.countriesGridControl.Name = "countriesGridControl";
            this.countriesGridControl.Size = new System.Drawing.Size(855, 348);
            this.countriesGridControl.TabIndex = 4;
            this.countriesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Code,
            this.Nom});
            this.gridView1.GridControl = this.countriesGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.countriesGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(859, 352);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // Code
            // 
            this.Code.Caption = "Code";
            this.Code.Name = "Code";
            this.Code.Visible = true;
            this.Code.VisibleIndex = 0;
            // 
            // Nom
            // 
            this.Nom.Caption = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.Visible = true;
            this.Nom.VisibleIndex = 1;
            // 
            // simpleButtonEnregistrer
            // 
            this.simpleButtonEnregistrer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonEnregistrer.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.simpleButtonEnregistrer.Appearance.Options.UseForeColor = true;
            this.simpleButtonEnregistrer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonEnregistrer.ImageOptions.Image")));
            this.simpleButtonEnregistrer.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButtonEnregistrer.Location = new System.Drawing.Point(658, 28);
            this.simpleButtonEnregistrer.Name = "simpleButtonEnregistrer";
            this.simpleButtonEnregistrer.Size = new System.Drawing.Size(110, 87);
            this.simpleButtonEnregistrer.TabIndex = 16;
            this.simpleButtonEnregistrer.Text = "Enregister";
            // 
            // simpleButtonEditer
            // 
            this.simpleButtonEditer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonEditer.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.simpleButtonEditer.Appearance.Options.UseForeColor = true;
            this.simpleButtonEditer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonEditer.ImageOptions.Image")));
            this.simpleButtonEditer.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButtonEditer.Location = new System.Drawing.Point(519, 28);
            this.simpleButtonEditer.Name = "simpleButtonEditer";
            this.simpleButtonEditer.Size = new System.Drawing.Size(110, 87);
            this.simpleButtonEditer.TabIndex = 15;
            this.simpleButtonEditer.Text = "Editer";
            // 
            // simpleButtonSupprimer
            // 
            this.simpleButtonSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonSupprimer.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.simpleButtonSupprimer.Appearance.Options.UseForeColor = true;
            this.simpleButtonSupprimer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonSupprimer.ImageOptions.Image")));
            this.simpleButtonSupprimer.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButtonSupprimer.Location = new System.Drawing.Point(380, 28);
            this.simpleButtonSupprimer.Name = "simpleButtonSupprimer";
            this.simpleButtonSupprimer.Size = new System.Drawing.Size(110, 87);
            this.simpleButtonSupprimer.TabIndex = 14;
            this.simpleButtonSupprimer.Text = "Supprimer";
            // 
            // simpleButtonAjouter
            // 
            this.simpleButtonAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonAjouter.Appearance.BackColor = System.Drawing.Color.Blue;
            this.simpleButtonAjouter.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.simpleButtonAjouter.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.simpleButtonAjouter.Appearance.Options.UseBackColor = true;
            this.simpleButtonAjouter.Appearance.Options.UseBorderColor = true;
            this.simpleButtonAjouter.Appearance.Options.UseForeColor = true;
            this.simpleButtonAjouter.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonAjouter.ImageOptions.Image")));
            this.simpleButtonAjouter.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButtonAjouter.Location = new System.Drawing.Point(241, 28);
            this.simpleButtonAjouter.Name = "simpleButtonAjouter";
            this.simpleButtonAjouter.Size = new System.Drawing.Size(110, 87);
            this.simpleButtonAjouter.TabIndex = 13;
            this.simpleButtonAjouter.Text = "Ajouter";
            // 
            // simpleButtonActualiser
            // 
            this.simpleButtonActualiser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonActualiser.Appearance.BackColor = System.Drawing.Color.Blue;
            this.simpleButtonActualiser.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.simpleButtonActualiser.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.simpleButtonActualiser.Appearance.Options.UseBackColor = true;
            this.simpleButtonActualiser.Appearance.Options.UseBorderColor = true;
            this.simpleButtonActualiser.Appearance.Options.UseForeColor = true;
            this.simpleButtonActualiser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonActualiser.ImageOptions.Image")));
            this.simpleButtonActualiser.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButtonActualiser.Location = new System.Drawing.Point(102, 28);
            this.simpleButtonActualiser.Name = "simpleButtonActualiser";
            this.simpleButtonActualiser.Size = new System.Drawing.Size(110, 87);
            this.simpleButtonActualiser.TabIndex = 12;
            this.simpleButtonActualiser.Text = "Actualiser";
            this.simpleButtonActualiser.Click += new System.EventHandler(this.simpleButtonActualiser_Click_1);
            // 
            // CountriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(879, 493);
            this.Controls.Add(this.simpleButtonEnregistrer);
            this.Controls.Add(this.simpleButtonEditer);
            this.Controls.Add(this.simpleButtonSupprimer);
            this.Controls.Add(this.simpleButtonAjouter);
            this.Controls.Add(this.simpleButtonActualiser);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.tileControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CountriesForm";
            this.Text = "CountriesForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl countriesGridControl;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Code;
        private DevExpress.XtraGrid.Columns.GridColumn Nom;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonEnregistrer;
        private DevExpress.XtraEditors.SimpleButton simpleButtonEditer;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSupprimer;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAjouter;
        private DevExpress.XtraEditors.SimpleButton simpleButtonActualiser;
    }
}