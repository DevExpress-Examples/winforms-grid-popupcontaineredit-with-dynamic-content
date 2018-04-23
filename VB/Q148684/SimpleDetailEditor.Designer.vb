Imports Microsoft.VisualBasic
Imports System
Namespace Q148684
	Partial Public Class SimpleDetailEditor
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.lookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.spinEdit2 = New DevExpress.XtraEditors.SpinEdit()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.spinEdit3 = New DevExpress.XtraEditors.SpinEdit()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.dataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
			Me.nwindDataSet = New Q148684.nwindDataSet()
			Me.orderDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.productsTableAdapter = New Q148684.nwindDataSetTableAdapters.ProductsTableAdapter()
			CType(Me.lookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.orderDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lookUpEdit1
			' 
			Me.lookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.orderDetailsBindingSource, "ProductID", True))
			Me.lookUpEdit1.Location = New System.Drawing.Point(54, 3)
			Me.lookUpEdit1.Name = "lookUpEdit1"
			Me.lookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.lookUpEdit1.Properties.DataSource = Me.productsBindingSource
			Me.lookUpEdit1.Properties.DisplayMember = "ProductName"
			Me.lookUpEdit1.Properties.ValueMember = "ProductID"
			Me.lookUpEdit1.Size = New System.Drawing.Size(141, 20)
			Me.lookUpEdit1.TabIndex = 0
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(3, 6)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(37, 13)
			Me.labelControl1.TabIndex = 1
			Me.labelControl1.Text = "Product"
			' 
			' spinEdit1
			' 
			Me.spinEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.orderDetailsBindingSource, "UnitPrice", True))
			Me.spinEdit1.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinEdit1.Location = New System.Drawing.Point(54, 29)
			Me.spinEdit1.Name = "spinEdit1"
			Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEdit1.Size = New System.Drawing.Size(141, 20)
			Me.spinEdit1.TabIndex = 2
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(3, 32)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(45, 13)
			Me.labelControl2.TabIndex = 3
			Me.labelControl2.Text = "Unit Price"
			' 
			' spinEdit2
			' 
			Me.spinEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.orderDetailsBindingSource, "Quantity", True))
			Me.spinEdit2.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinEdit2.Location = New System.Drawing.Point(54, 55)
			Me.spinEdit2.Name = "spinEdit2"
			Me.spinEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEdit2.Size = New System.Drawing.Size(141, 20)
			Me.spinEdit2.TabIndex = 4
			' 
			' labelControl3
			' 
			Me.labelControl3.Location = New System.Drawing.Point(3, 58)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(42, 13)
			Me.labelControl3.TabIndex = 5
			Me.labelControl3.Text = "Quantity"
			' 
			' spinEdit3
			' 
			Me.spinEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.orderDetailsBindingSource, "Discount", True))
			Me.spinEdit3.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinEdit3.Location = New System.Drawing.Point(54, 81)
			Me.spinEdit3.Name = "spinEdit3"
			Me.spinEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEdit3.Size = New System.Drawing.Size(141, 20)
			Me.spinEdit3.TabIndex = 6
			' 
			' labelControl4
			' 
			Me.labelControl4.Location = New System.Drawing.Point(3, 84)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New System.Drawing.Size(41, 13)
			Me.labelControl4.TabIndex = 7
			Me.labelControl4.Text = "Discount"
			' 
			' dataNavigator1
			' 
			Me.dataNavigator1.DataSource = Me.orderDetailsBindingSource
			Me.dataNavigator1.Location = New System.Drawing.Point(3, 107)
			Me.dataNavigator1.Name = "dataNavigator1"
			Me.dataNavigator1.Size = New System.Drawing.Size(192, 24)
			Me.dataNavigator1.TabIndex = 8
			Me.dataNavigator1.Text = "dataNavigator1"
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' orderDetailsBindingSource
			' 
			Me.orderDetailsBindingSource.DataMember = "OrdersOrder Details"
			' 
			' productsBindingSource
			' 
			Me.productsBindingSource.DataMember = "Products"
			Me.productsBindingSource.DataSource = Me.nwindDataSet
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' SimpleDetailEditor
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.dataNavigator1)
			Me.Controls.Add(Me.labelControl4)
			Me.Controls.Add(Me.spinEdit3)
			Me.Controls.Add(Me.labelControl3)
			Me.Controls.Add(Me.spinEdit2)
			Me.Controls.Add(Me.labelControl2)
			Me.Controls.Add(Me.spinEdit1)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.lookUpEdit1)
			Me.Name = "SimpleDetailEditor"
			Me.Size = New System.Drawing.Size(202, 136)
'			Me.Load += New System.EventHandler(Me.SimpleDetailEditor_Load);
			CType(Me.lookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.orderDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private lookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private spinEdit1 As DevExpress.XtraEditors.SpinEdit
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private orderDetailsBindingSource As System.Windows.Forms.BindingSource
		Private nwindDataSet As nwindDataSet
		Private productsBindingSource As System.Windows.Forms.BindingSource
		Private spinEdit2 As DevExpress.XtraEditors.SpinEdit
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private spinEdit3 As DevExpress.XtraEditors.SpinEdit
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private dataNavigator1 As DevExpress.XtraEditors.DataNavigator
		Private productsTableAdapter As Q148684.nwindDataSetTableAdapters.ProductsTableAdapter
	End Class
End Namespace
