Imports System
Imports System.Windows.Forms
Imports DevExpress.Utils.Commands
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Commands

Namespace RichHeaderTable
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			richEditControl1.BeginUpdate()

			Dim command As RichEditCommand = richEditControl1.CreateCommand(RichEditCommandId.EditPageHeader)
			command.Execute()

			command = New CustomInsertTableCommand(richEditControl1, 2, 3)
			command.ForceExecute(command.CreateDefaultCommandUIState())

			command = richEditControl1.CreateCommand(RichEditCommandId.ClosePageHeaderFooter)
			command.Execute()

			richEditControl1.EndUpdate()
		End Sub
	End Class

	Public Class CustomInsertTableCommand
		Inherits InsertTableCommand
		Private rowCount As Integer
		Private columnCount As Integer

		Public Sub New(ByVal control As IRichEditControl, ByVal rowCount As Integer, ByVal columnCount As Integer)
			MyBase.New(control)

			Me.rowCount = rowCount
			Me.columnCount = columnCount
		End Sub

		Public Overrides Sub ForceExecute(ByVal state As ICommandUIState)
			ShowInsertTableFormCallback(New CreateTableParameters(Me.rowCount, Me.columnCount), state)
		End Sub
	End Class

End Namespace