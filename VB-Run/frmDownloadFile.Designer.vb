<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDownloadFile
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDownloadFile))
        Dim CBlendItems1 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CButton1 = New CButtonLib.CButton()
        Me.CButton2 = New CButtonLib.CButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(40, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Looks like an Installer Script wants to Extract a ZIP File" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It might be a Virus a" &
    "re you sure you want to continue?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CButton1
        '
        Me.CButton1.BorderColor = System.Drawing.Color.Black
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))}
        CBlendItems1.iPoint = New Single() {0!, 1.0!}
        Me.CButton1.ColorFillBlend = CBlendItems1
        Me.CButton1.DesignerSelected = False
        Me.CButton1.ImageIndex = 0
        Me.CButton1.Location = New System.Drawing.Point(98, 113)
        Me.CButton1.Name = "CButton1"
        Me.CButton1.Size = New System.Drawing.Size(89, 31)
        Me.CButton1.TabIndex = 3
        Me.CButton1.TabStop = False
        Me.CButton1.Text = "Yes"
        Me.CButton1.TextShadow = System.Drawing.Color.Black
        '
        'CButton2
        '
        Me.CButton2.BorderColor = System.Drawing.Color.Black
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))}
        CBlendItems2.iPoint = New Single() {0!, 1.0!}
        Me.CButton2.ColorFillBlend = CBlendItems2
        Me.CButton2.DesignerSelected = True
        Me.CButton2.ImageIndex = 0
        Me.CButton2.Location = New System.Drawing.Point(193, 113)
        Me.CButton2.Name = "CButton2"
        Me.CButton2.Size = New System.Drawing.Size(89, 31)
        Me.CButton2.TabIndex = 0
        Me.CButton2.Text = "No"
        Me.CButton2.TextShadow = System.Drawing.Color.Black
        '
        'frmDownloadFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(380, 157)
        Me.Controls.Add(Me.CButton2)
        Me.Controls.Add(Me.CButton1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDownloadFile"
        Me.Text = "Attention!"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CButton1 As CButtonLib.CButton
    Friend WithEvents CButton2 As CButtonLib.CButton
End Class
