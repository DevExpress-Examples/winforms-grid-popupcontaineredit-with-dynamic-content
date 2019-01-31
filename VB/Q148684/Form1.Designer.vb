Imports Microsoft.VisualBasic
Imports System
Namespace Q148684
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.ordersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New nwindDataSet()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colEmployeeID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.detailsEdit = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
			Me.colUseGrid = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.ordersTableAdapter = New nwindDataSetTableAdapters.OrdersTableAdapter()
            Me.order_DetailsTableAdapter1 = New nwindDataSetTableAdapters.Order_DetailsTableAdapter()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.detailsEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.ordersBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.detailsEdit})
			Me.gridControl1.ShowOnlyPredefinedDetails = True
			Me.gridControl1.Size = New System.Drawing.Size(746, 524)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' ordersBindingSource
			' 
			Me.ordersBindingSource.DataMember = "Orders"
			Me.ordersBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colOrderID, Me.colCustomerID, Me.colEmployeeID, Me.colOrderDate, Me.colDetails, Me.colUseGrid})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
'			Me.gridView1.CustomUnboundColumnData += New DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(Me.OnGridViewCustomUnboundColumnData);
			' 
			' colOrderID
			' 
			Me.colOrderID.Caption = "OrderID"
			Me.colOrderID.FieldName = "OrderID"
			Me.colOrderID.Name = "colOrderID"
			Me.colOrderID.Visible = True
			Me.colOrderID.VisibleIndex = 0
			' 
			' colCustomerID
			' 
			Me.colCustomerID.Caption = "CustomerID"
			Me.colCustomerID.FieldName = "CustomerID"
			Me.colCustomerID.Name = "colCustomerID"
			Me.colCustomerID.Visible = True
			Me.colCustomerID.VisibleIndex = 1
			' 
			' colEmployeeID
			' 
			Me.colEmployeeID.Caption = "EmployeeID"
			Me.colEmployeeID.FieldName = "EmployeeID"
			Me.colEmployeeID.Name = "colEmployeeID"
			Me.colEmployeeID.Visible = True
			Me.colEmployeeID.VisibleIndex = 2
			' 
			' colOrderDate
			' 
			Me.colOrderDate.Caption = "OrderDate"
			Me.colOrderDate.FieldName = "OrderDate"
			Me.colOrderDate.Name = "colOrderDate"
			Me.colOrderDate.Visible = True
			Me.colOrderDate.VisibleIndex = 3
			' 
			' colDetails
			' 
			Me.colDetails.Caption = "Details"
			Me.colDetails.ColumnEdit = Me.detailsEdit
			Me.colDetails.Name = "colDetails"
			Me.colDetails.Visible = True
			Me.colDetails.VisibleIndex = 4
			' 
			' detailsEdit
			' 
			Me.detailsEdit.AutoHeight = False
			Me.detailsEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.detailsEdit.Name = "detailsEdit"
'			Me.detailsEdit.QueryDisplayText += New DevExpress.XtraEditors.Controls.QueryDisplayTextEventHandler(Me.OnDetailsEditQueryDisplayText);
'			Me.detailsEdit.QueryPopUp += New System.ComponentModel.CancelEventHandler(Me.OnDetailsEditQueryPopup);
'			Me.detailsEdit.CloseUp += New DevExpress.XtraEditors.Controls.CloseUpEventHandler(Me.OnDetailsEditCloseUp);
			' 
			' colUseGrid
			' 
			Me.colUseGrid.Caption = "Use Grid"
			Me.colUseGrid.FieldName = "colUseGrid"
			Me.colUseGrid.Name = "colUseGrid"
			Me.colUseGrid.UnboundType = DevExpress.Data.UnboundColumnType.Boolean
			Me.colUseGrid.Visible = True
			Me.colUseGrid.VisibleIndex = 5
			' 
			' ordersTableAdapter
			' 
			Me.ordersTableAdapter.ClearBeforeFill = True
			' 
			' order_DetailsTableAdapter1
			' 
			Me.order_DetailsTableAdapter1.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(746, 524)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.detailsEdit, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private nwindDataSet As nwindDataSet
		Private ordersBindingSource As System.Windows.Forms.BindingSource
        Private ordersTableAdapter As nwindDataSetTableAdapters.OrdersTableAdapter
        Private colOrderID As DevExpress.XtraGrid.Columns.GridColumn
		Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn
		Private colEmployeeID As DevExpress.XtraGrid.Columns.GridColumn
		Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colDetails As DevExpress.XtraGrid.Columns.GridColumn
		Private WithEvents detailsEdit As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
		Private colUseGrid As DevExpress.XtraGrid.Columns.GridColumn
        Private order_DetailsTableAdapter1 As nwindDataSetTableAdapters.Order_DetailsTableAdapter
    End Class
End Namespace

