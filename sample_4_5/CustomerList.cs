﻿using EventsDB;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010;

namespace sample_4_5 {
  public partial class CustomerList : XtraUserControl {
    public CustomerList() {
      InitializeComponent();
    }

    private void CustomerList_Load(object sender, System.EventArgs e) {
      TransactionalChangeHandler.Hookup<Customer>(
        DocumentManager.FromControl(ParentForm).View, unitOfWork, saveChangesItem,
        discardChangesItem, customerCollection);
    }
  }
}
