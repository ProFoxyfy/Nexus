<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FontList1 = New CustomFontDialog.FontList()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FontList1
        '
        Me.FontList1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FontList1.Location = New System.Drawing.Point(0, 0)
        Me.FontList1.Name = "FontList1"
        Me.FontList1.SelectedFontFamily = Nothing
        Me.FontList1.Size = New System.Drawing.Size(227, 401)
        Me.FontList1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(227, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 401)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "AaBbYyZz" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 401)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FontList1)
        Me.Name = "Form1"
        Me.Text = "Foxy's Font Selector"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FontList1 As CustomFontDialog.FontList
    Friend WithEvents Label1 As Label
End Class
