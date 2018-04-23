using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Q148684 {
    public partial class SimpleDetailEditor : DevExpress.XtraEditors.XtraUserControl {
        public SimpleDetailEditor() {
            InitializeComponent();
        }

        private void SimpleDetailEditor_Load(object sender, EventArgs e) {
            productsTableAdapter.Fill(nwindDataSet.Products);
        }

        public object DataSource {
            get { return orderDetailsBindingSource.DataSource; }
            set { 
                orderDetailsBindingSource.DataSource = value;
                orderDetailsBindingSource.DataMember = "OrdersOrder Details";
            }
        }
    }
}
