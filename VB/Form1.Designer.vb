﻿Namespace RichHeaderTable
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
            Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.button1 = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            ' 
            ' richEditControl1
            ' 
            Me.richEditControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.richEditControl1.Location = New System.Drawing.Point(9, 10)
            Me.richEditControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Size = New System.Drawing.Size(497, 329)
            Me.richEditControl1.TabIndex = 0
            Me.richEditControl1.Text = "richEditControl1"
            ' 
            ' button1
            ' 
            Me.button1.Location = New System.Drawing.Point(56, 359)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(179, 23)
            Me.button1.TabIndex = 1
            Me.button1.Text = "Add a table to the header section"
            Me.button1.UseVisualStyleBackColor = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(515, 397)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.richEditControl1)
            Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
        Private WithEvents button1 As System.Windows.Forms.Button
    End Class
End Namespace

