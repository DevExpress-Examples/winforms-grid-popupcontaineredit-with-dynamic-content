Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace Q148684
	Partial Public Class SimpleDetailEditor
		Inherits DevExpress.XtraEditors.XtraUserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub SimpleDetailEditor_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			productsTableAdapter.Fill(nwindDataSet.Products)
		End Sub

		Public Property DataSource() As Object
			Get
				Return orderDetailsBindingSource.DataSource
			End Get
			Set(ByVal value As Object)
				orderDetailsBindingSource.DataSource = value
				orderDetailsBindingSource.DataMember = "OrdersOrder Details"
			End Set
		End Property
	End Class
End Namespace
