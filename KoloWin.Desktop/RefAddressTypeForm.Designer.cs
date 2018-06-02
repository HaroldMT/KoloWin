namespace KoloWin.Desktop
{
    partial class RefAddressTypeForm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.addressTypeCodeTextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.refCreateAddressTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressTypeDescriptionTextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.addressTypeCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.refAddressTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressTypeDescriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.refAddressTypesGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAddressTypeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddressTypeDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressTypeCodeTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refCreateAddressTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTypeDescriptionTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTypeCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refAddressTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTypeDescriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refAddressTypesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.addressTypeCodeTextEdit1);
            this.layoutControl1.Controls.Add(this.addressTypeDescriptionTextEdit1);
            this.layoutControl1.Controls.Add(this.addressTypeCodeTextEdit);
            this.layoutControl1.Controls.Add(this.addressTypeDescriptionTextEdit);
            this.layoutControl1.Controls.Add(this.refAddressTypesGridControl);
            this.layoutControl1.Controls.Add(this.btnRefresh);
            this.layoutControl1.Controls.Add(this.btnDelete);
            this.layoutControl1.Controls.Add(this.btnUpdate);
            this.layoutControl1.Controls.Add(this.btnCreate);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(652, 417);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // addressTypeCodeTextEdit1
            // 
            this.addressTypeCodeTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.refCreateAddressTypesBindingSource, "AddressTypeCode", true));
            this.addressTypeCodeTextEdit1.Location = new System.Drawing.Point(84, 46);
            this.addressTypeCodeTextEdit1.Name = "addressTypeCodeTextEdit1";
            this.addressTypeCodeTextEdit1.Size = new System.Drawing.Size(238, 20);
            this.addressTypeCodeTextEdit1.StyleController = this.layoutControl1;
            this.addressTypeCodeTextEdit1.TabIndex = 9;
            // 
            // refCreateAddressTypesBindingSource
            // 
            this.refCreateAddressTypesBindingSource.DataSource = typeof(KoloWin.Desktop.KoloGateway.RefAddressType);
            // 
            // addressTypeDescriptionTextEdit1
            // 
            this.addressTypeDescriptionTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.refCreateAddressTypesBindingSource, "AddressTypeDescription", true));
            this.addressTypeDescriptionTextEdit1.Location = new System.Drawing.Point(386, 46);
            this.addressTypeDescriptionTextEdit1.Name = "addressTypeDescriptionTextEdit1";
            this.addressTypeDescriptionTextEdit1.Size = new System.Drawing.Size(242, 20);
            this.addressTypeDescriptionTextEdit1.StyleController = this.layoutControl1;
            this.addressTypeDescriptionTextEdit1.TabIndex = 11;
            // 
            // addressTypeCodeTextEdit
            // 
            this.addressTypeCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.refAddressTypesBindingSource, "AddressTypeCode", true));
            this.addressTypeCodeTextEdit.Location = new System.Drawing.Point(96, 325);
            this.addressTypeCodeTextEdit.Name = "addressTypeCodeTextEdit";
            this.addressTypeCodeTextEdit.Size = new System.Drawing.Size(226, 20);
            this.addressTypeCodeTextEdit.StyleController = this.layoutControl1;
            this.addressTypeCodeTextEdit.TabIndex = 6;
            // 
            // refAddressTypesBindingSource
            // 
            this.refAddressTypesBindingSource.DataSource = typeof(KoloWin.Desktop.KoloGateway.RefAddressType);
            // 
            // addressTypeDescriptionTextEdit
            // 
            this.addressTypeDescriptionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.refAddressTypesBindingSource, "AddressTypeDescription", true));
            this.addressTypeDescriptionTextEdit.Location = new System.Drawing.Point(386, 325);
            this.addressTypeDescriptionTextEdit.Name = "addressTypeDescriptionTextEdit";
            this.addressTypeDescriptionTextEdit.Size = new System.Drawing.Size(230, 20);
            this.addressTypeDescriptionTextEdit.StyleController = this.layoutControl1;
            this.addressTypeDescriptionTextEdit.TabIndex = 8;
            // 
            // refAddressTypesGridControl
            // 
            this.refAddressTypesGridControl.DataSource = this.refAddressTypesBindingSource;
            this.refAddressTypesGridControl.Location = new System.Drawing.Point(24, 46);
            this.refAddressTypesGridControl.MainView = this.gridView1;
            this.refAddressTypesGridControl.Name = "refAddressTypesGridControl";
            this.refAddressTypesGridControl.Size = new System.Drawing.Size(604, 245);
            this.refAddressTypesGridControl.TabIndex = 4;
            this.refAddressTypesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAddressTypeCode,
            this.colAddressTypeDescription});
            this.gridView1.GridControl = this.refAddressTypesGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colAddressTypeCode
            // 
            this.colAddressTypeCode.Caption = "Code";
            this.colAddressTypeCode.FieldName = "AddressTypeCode";
            this.colAddressTypeCode.Name = "colAddressTypeCode";
            this.colAddressTypeCode.Visible = true;
            this.colAddressTypeCode.VisibleIndex = 0;
            // 
            // colAddressTypeDescription
            // 
            this.colAddressTypeDescription.Caption = "Description";
            this.colAddressTypeDescription.FieldName = "AddressTypeDescription";
            this.colAddressTypeDescription.Name = "colAddressTypeDescription";
            this.colAddressTypeDescription.Visible = true;
            this.colAddressTypeDescription.VisibleIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(397, 366);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(70, 22);
            this.btnRefresh.StyleController = this.layoutControl1;
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Actualiser";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(481, 366);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 22);
            this.btnDelete.StyleController = this.layoutControl1;
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(567, 366);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(56, 22);
            this.btnUpdate.StyleController = this.layoutControl1;
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(484, 75);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(139, 22);
            this.btnCreate.StyleController = this.layoutControl1;
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "Enregistrer";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabbedControlGroup1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(652, 417);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup2;
            this.tabbedControlGroup1.SelectedTabPageIndex = 0;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(632, 397);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.layoutControlItem9,
            this.emptySpaceItem2});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(608, 351);
            this.layoutControlGroup3.Text = "Créer un nouveau type d\'adresse";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.addressTypeCodeTextEdit1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(302, 351);
            this.layoutControlItem4.Text = "Code:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.addressTypeDescriptionTextEdit1;
            this.layoutControlItem7.Location = new System.Drawing.Point(302, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(306, 24);
            this.layoutControlItem7.Text = "Description:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnCreate;
            this.layoutControlItem9.Location = new System.Drawing.Point(455, 24);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(153, 327);
            this.layoutControlItem9.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(302, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(153, 327);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlGroup4,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem6,
            this.layoutControlItem8});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(608, 351);
            this.layoutControlGroup2.Text = "Liste des types d\'adresses";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.refAddressTypesGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(608, 249);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem5});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 249);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(608, 66);
            this.layoutControlGroup4.Text = "Détails sur le type d\'adresse sélectionné";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.addressTypeCodeTextEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(290, 24);
            this.layoutControlItem2.Text = "Code:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.addressTypeDescriptionTextEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(290, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(294, 24);
            this.layoutControlItem5.Text = "Description:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(57, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 315);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(368, 36);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnRefresh;
            this.layoutControlItem3.Location = new System.Drawing.Point(368, 315);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(84, 36);
            this.layoutControlItem3.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnDelete;
            this.layoutControlItem6.Location = new System.Drawing.Point(452, 315);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(86, 36);
            this.layoutControlItem6.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnUpdate;
            this.layoutControlItem8.Location = new System.Drawing.Point(538, 315);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(70, 36);
            this.layoutControlItem8.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // RefAddressTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 417);
            this.Controls.Add(this.layoutControl1);
            this.Name = "RefAddressTypeForm";
            this.Text = "Types d\'adresses";
            this.Load += new System.EventHandler(this.RefAddressTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addressTypeCodeTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refCreateAddressTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTypeDescriptionTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTypeCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refAddressTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTypeDescriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refAddressTypesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit addressTypeCodeTextEdit1;
        private System.Windows.Forms.BindingSource refCreateAddressTypesBindingSource;
        private DevExpress.XtraEditors.TextEdit addressTypeDescriptionTextEdit1;
        private DevExpress.XtraEditors.TextEdit addressTypeCodeTextEdit;
        private System.Windows.Forms.BindingSource refAddressTypesBindingSource;
        private DevExpress.XtraEditors.TextEdit addressTypeDescriptionTextEdit;
        private DevExpress.XtraGrid.GridControl refAddressTypesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressTypeCode;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressTypeDescription;
    }
}