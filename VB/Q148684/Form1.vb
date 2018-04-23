Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base

Namespace Q148684
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			InitializePopupControls()
		End Sub

		Private unboundData As List(Of Boolean) = New List(Of Boolean)()

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Orders' table. You can move, or remove it, as needed.
			Me.ordersTableAdapter.Fill(Me.nwindDataSet.Orders)
			order_DetailsTableAdapter1.Fill(nwindDataSet.Order_Details)
			InitializeUnboundData()
		End Sub

		Private simpleEditor As SimpleDetailEditor
		Private gridEditor As GridDetailEditor
		Private SimpleEditorSize As New Size(202, 136)
		Private GridEditorSize As New Size(403, 218)

		Private Sub InitializePopupControls()
			simpleEditor = New SimpleDetailEditor()
			simpleEditor.DataSource = ordersBindingSource
			simpleEditor.Dock = DockStyle.Fill
			gridEditor = New GridDetailEditor()
			gridEditor.DataSource = ordersBindingSource
			gridEditor.Dock = DockStyle.Fill
			detailsEdit.PopupControl = New PopupContainerControl()
		End Sub

		Private Sub InitializeUnboundData()
			For i As Integer = 0 To nwindDataSet.Orders.Count - 1
				unboundData.Add(i Mod 2 = 0)
			Next i
		End Sub

		Private Sub OnDetailsEditQueryPopup(ByVal sender As Object, ByVal e As CancelEventArgs) Handles detailsEdit.QueryPopUp
			Dim edit As PopupContainerEdit = CType(sender, PopupContainerEdit)
			If CBool(gridView1.GetFocusedRowCellValue(colUseGrid)) Then
				edit.Properties.PopupControl.Controls.Add(gridEditor)
				edit.Properties.PopupControl.Size = GridEditorSize
			Else
				edit.Properties.PopupControl.Controls.Add(simpleEditor)
				edit.Properties.PopupControl.Size = SimpleEditorSize
			End If
		End Sub

		Private Sub OnDetailsEditCloseUp(ByVal sender As Object, ByVal e As CloseUpEventArgs) Handles detailsEdit.CloseUp
			CType(sender, PopupContainerEdit).Properties.PopupControl.Controls.Clear()
		End Sub

		Private Sub OnGridViewCustomUnboundColumnData(ByVal sender As Object, ByVal e As CustomColumnDataEventArgs) Handles gridView1.CustomUnboundColumnData
			If e.Column Is colUseGrid Then
				If e.IsGetData Then
					e.Value = unboundData(e.ListSourceRowIndex)
				ElseIf e.IsSetData Then
					unboundData(e.ListSourceRowIndex) = CBool(e.Value)
				End If
			End If
		End Sub

		Private Sub OnDetailsEditQueryDisplayText(ByVal sender As Object, ByVal e As QueryDisplayTextEventArgs) Handles detailsEdit.QueryDisplayText
			e.DisplayText = "Edit Details"
		End Sub
	End Class
End Namespace