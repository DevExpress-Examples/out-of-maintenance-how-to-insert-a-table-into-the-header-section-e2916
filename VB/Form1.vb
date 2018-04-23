Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit.API.Native

Namespace RichHeaderTable
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            Dim section As Section = richEditControl1.Document.Sections(0)
            Dim subdoc As SubDocument = section.BeginUpdateHeader()
            subdoc.Tables.Create(subdoc.Range.End, 2, 3, AutoFitBehaviorType.AutoFitToWindow)
            section.EndUpdateHeader(subdoc)
        End Sub
    End Class
End Namespace