using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Q148684 {
    public partial class GridDetailEditor : DevExpress.XtraEditors.XtraUserControl {
        public GridDetailEditor() {
            InitializeComponent();
        }
        public object DataSource {
            get { return orderDetailsBindingSource.DataSource; }
            set { orderDetailsBindingSource.DataSource = value; }
        }

        private void GridDetailEditor_Load(object sender, EventArgs e) {
            productsTableAdapter.Fill(nwindDataSet.Products);
        }
    }
}
