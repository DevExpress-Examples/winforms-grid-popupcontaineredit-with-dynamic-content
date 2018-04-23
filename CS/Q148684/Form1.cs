using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;

namespace Q148684 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            InitializePopupControls();
        }

        private List<bool> unboundData = new List<bool>();

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.nwindDataSet.Orders);
            order_DetailsTableAdapter1.Fill(nwindDataSet.Order_Details);
            InitializeUnboundData();
        }

        private SimpleDetailEditor simpleEditor;
        private GridDetailEditor gridEditor;
        private Size SimpleEditorSize = new Size(202, 136);
        private Size GridEditorSize = new Size(403, 218);

        private void InitializePopupControls() {
            simpleEditor = new SimpleDetailEditor();
            simpleEditor.DataSource = ordersBindingSource;
            simpleEditor.Dock = DockStyle.Fill;
            gridEditor = new GridDetailEditor();
            gridEditor.DataSource = ordersBindingSource;
            gridEditor.Dock = DockStyle.Fill;
            detailsEdit.PopupControl = new PopupContainerControl();
        }

        private void InitializeUnboundData() {
            for (int i = 0; i < nwindDataSet.Orders.Count; i++)
                unboundData.Add(i % 2 == 0);
        }

        private void OnDetailsEditQueryPopup(object sender, CancelEventArgs e) {
            PopupContainerEdit edit = (PopupContainerEdit)sender;
            if ((bool)gridView1.GetFocusedRowCellValue(colUseGrid)) {
                edit.Properties.PopupControl.Controls.Add(gridEditor);
                edit.Properties.PopupControl.Size = GridEditorSize;
            } else {
                edit.Properties.PopupControl.Controls.Add(simpleEditor);
                edit.Properties.PopupControl.Size = SimpleEditorSize;
            }
        }

        private void OnDetailsEditCloseUp(object sender, CloseUpEventArgs e) {
            ((PopupContainerEdit)sender).Properties.PopupControl.Controls.Clear();
        }

        private void OnGridViewCustomUnboundColumnData(object sender, CustomColumnDataEventArgs e) {
            if (e.Column == colUseGrid)
                if (e.IsGetData)
                    e.Value = unboundData[e.ListSourceRowIndex];
                else if (e.IsSetData)
                    unboundData[e.ListSourceRowIndex] = (bool)e.Value;
        }

        private void OnDetailsEditQueryDisplayText(object sender, QueryDisplayTextEventArgs e) {
            e.DisplayText = "Edit Details";
        }
    }
}