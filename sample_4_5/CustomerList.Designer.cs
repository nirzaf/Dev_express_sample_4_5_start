namespace sample_4_5 {
  partial class CustomerList {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
      DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
      this.contactView = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
      this.grid = new DevExpress.XtraGrid.GridControl();
      this.customerCollection = new DevExpress.Xpo.XPCollection(this.components);
      this.unitOfWork = new DevExpress.Xpo.UnitOfWork(this.components);
      this.addressView = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colLine1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colLine2 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colLine3 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPostCode = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
      this.customerView = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
      this.saveChangesItem = new DevExpress.XtraBars.BarButtonItem();
      this.discardChangesItem = new DevExpress.XtraBars.BarButtonItem();
      this.printExportItem = new DevExpress.XtraBars.BarButtonItem();
      this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
      this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      ((System.ComponentModel.ISupportInitialize)(this.contactView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.customerCollection)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.customerView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
      this.SuspendLayout();
      // 
      // contactView
      // 
      this.contactView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName1,
            this.colPhoneNumber});
      this.contactView.GridControl = this.grid;
      this.contactView.Name = "contactView";
      // 
      // colName1
      // 
      this.colName1.FieldName = "Name";
      this.colName1.Name = "colName1";
      this.colName1.Visible = true;
      this.colName1.VisibleIndex = 0;
      // 
      // colPhoneNumber
      // 
      this.colPhoneNumber.FieldName = "PhoneNumber";
      this.colPhoneNumber.Name = "colPhoneNumber";
      this.colPhoneNumber.Visible = true;
      this.colPhoneNumber.VisibleIndex = 1;
      // 
      // grid
      // 
      this.grid.DataSource = this.customerCollection;
      this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
      gridLevelNode1.LevelTemplate = this.contactView;
      gridLevelNode1.RelationName = "Contacts";
      gridLevelNode2.LevelTemplate = this.addressView;
      gridLevelNode2.RelationName = "Addresses";
      this.grid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
      this.grid.Location = new System.Drawing.Point(0, 150);
      this.grid.MainView = this.customerView;
      this.grid.MenuManager = this.ribbonControl1;
      this.grid.Name = "grid";
      this.grid.ShowOnlyPredefinedDetails = true;
      this.grid.Size = new System.Drawing.Size(816, 422);
      this.grid.TabIndex = 1;
      this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.addressView,
            this.customerView,
            this.contactView});
      // 
      // customerCollection
      // 
      this.customerCollection.ObjectType = typeof(EventsDB.Customer);
      this.customerCollection.Session = this.unitOfWork;
      // 
      // addressView
      // 
      this.addressView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLine1,
            this.colLine2,
            this.colLine3,
            this.colCity,
            this.colPostCode,
            this.colCountry});
      this.addressView.GridControl = this.grid;
      this.addressView.Name = "addressView";
      // 
      // colLine1
      // 
      this.colLine1.FieldName = "Line1";
      this.colLine1.Name = "colLine1";
      this.colLine1.Visible = true;
      this.colLine1.VisibleIndex = 0;
      // 
      // colLine2
      // 
      this.colLine2.FieldName = "Line2";
      this.colLine2.Name = "colLine2";
      this.colLine2.Visible = true;
      this.colLine2.VisibleIndex = 1;
      // 
      // colLine3
      // 
      this.colLine3.FieldName = "Line3";
      this.colLine3.Name = "colLine3";
      this.colLine3.Visible = true;
      this.colLine3.VisibleIndex = 2;
      // 
      // colCity
      // 
      this.colCity.FieldName = "City";
      this.colCity.Name = "colCity";
      this.colCity.Visible = true;
      this.colCity.VisibleIndex = 4;
      // 
      // colPostCode
      // 
      this.colPostCode.FieldName = "PostCode";
      this.colPostCode.Name = "colPostCode";
      this.colPostCode.Visible = true;
      this.colPostCode.VisibleIndex = 3;
      // 
      // colCountry
      // 
      this.colCountry.FieldName = "Country";
      this.colCountry.Name = "colCountry";
      this.colCountry.Visible = true;
      this.colCountry.VisibleIndex = 5;
      // 
      // customerView
      // 
      this.customerView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.gridColumn1,
            this.gridColumn3});
      this.customerView.GridControl = this.grid;
      this.customerView.Name = "customerView";
      this.customerView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colName, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Descending)});
      // 
      // colName
      // 
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.Visible = true;
      this.colName.VisibleIndex = 0;
      // 
      // gridColumn1
      // 
      this.gridColumn1.FieldName = "InvoiceContact.Name";
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 1;
      // 
      // gridColumn3
      // 
      this.gridColumn3.FieldName = "InvoiceAddress!";
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.Visible = true;
      this.gridColumn3.VisibleIndex = 2;
      // 
      // ribbonControl1
      // 
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.saveChangesItem,
            this.discardChangesItem,
            this.printExportItem});
      this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
      this.ribbonControl1.MaxItemId = 1;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
      this.ribbonControl1.Size = new System.Drawing.Size(816, 150);
      // 
      // saveChangesItem
      // 
      this.saveChangesItem.Caption = "Save Changes";
      this.saveChangesItem.Id = 1;
      this.saveChangesItem.ImageOptions.SvgImage = global::sample_4_5.Properties.Resources.savechanges;
      this.saveChangesItem.Name = "saveChangesItem";
      // 
      // discardChangesItem
      // 
      this.discardChangesItem.Caption = "Discard Changes";
      this.discardChangesItem.Id = 2;
      this.discardChangesItem.ImageOptions.SvgImage = global::sample_4_5.Properties.Resources.discardchanges;
      this.discardChangesItem.Name = "discardChangesItem";
      // 
      // printExportItem
      // 
      this.printExportItem.Caption = "Print && Export";
      this.printExportItem.Id = 3;
      this.printExportItem.ImageOptions.SvgImage = global::sample_4_5.Properties.Resources.printexport;
      this.printExportItem.Name = "printExportItem";
      // 
      // ribbonPageCategory1
      // 
      this.ribbonPageCategory1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.ribbonPageCategory1.Appearance.Options.UseBackColor = true;
      this.ribbonPageCategory1.Name = "ribbonPageCategory1";
      this.ribbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
      this.ribbonPageCategory1.Text = "Customers";
      // 
      // ribbonPage1
      // 
      this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "Data Operations";
      // 
      // ribbonPageGroup1
      // 
      this.ribbonPageGroup1.ItemLinks.Add(this.saveChangesItem);
      this.ribbonPageGroup1.ItemLinks.Add(this.discardChangesItem);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup1.Text = "Persistence";
      // 
      // ribbonPageGroup2
      // 
      this.ribbonPageGroup2.ItemLinks.Add(this.printExportItem);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup2.Text = "Tools";
      // 
      // CustomerList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.grid);
      this.Controls.Add(this.ribbonControl1);
      this.Name = "CustomerList";
      this.Size = new System.Drawing.Size(816, 572);
      this.Load += new System.EventHandler(this.CustomerList_Load);
      ((System.ComponentModel.ISupportInitialize)(this.contactView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.customerCollection)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.customerView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private DevExpress.Xpo.UnitOfWork unitOfWork;
    private DevExpress.Xpo.XPCollection customerCollection;
    private DevExpress.XtraBars.BarButtonItem saveChangesItem;
    private DevExpress.XtraBars.BarButtonItem discardChangesItem;
    private DevExpress.XtraBars.BarButtonItem printExportItem;
    private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
    private DevExpress.XtraGrid.GridControl grid;
    private DevExpress.XtraGrid.Views.Grid.GridView customerView;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    private DevExpress.XtraGrid.Views.Grid.GridView contactView;
    private DevExpress.XtraGrid.Views.Grid.GridView addressView;
    private DevExpress.XtraGrid.Columns.GridColumn colName1;
    private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
    private DevExpress.XtraGrid.Columns.GridColumn colLine1;
    private DevExpress.XtraGrid.Columns.GridColumn colLine2;
    private DevExpress.XtraGrid.Columns.GridColumn colLine3;
    private DevExpress.XtraGrid.Columns.GridColumn colCity;
    private DevExpress.XtraGrid.Columns.GridColumn colPostCode;
    private DevExpress.XtraGrid.Columns.GridColumn colCountry;
  }
}