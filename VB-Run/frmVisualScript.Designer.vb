<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisual_Script
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
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonListBox1 = New ComponentFactory.Krypton.Toolkit.KryptonListBox()
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonButton2 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonButton3 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonButton4 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonButton5 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.KryptonButton5)
        Me.KryptonPanel1.Controls.Add(Me.KryptonButton4)
        Me.KryptonPanel1.Controls.Add(Me.KryptonButton3)
        Me.KryptonPanel1.Controls.Add(Me.KryptonButton2)
        Me.KryptonPanel1.Controls.Add(Me.KryptonButton1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(559, 30)
        Me.KryptonPanel1.TabIndex = 1
        '
        'KryptonListBox1
        '
        Me.KryptonListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonListBox1.Location = New System.Drawing.Point(0, 30)
        Me.KryptonListBox1.Name = "KryptonListBox1"
        Me.KryptonListBox1.ScrollAlwaysVisible = True
        Me.KryptonListBox1.Size = New System.Drawing.Size(559, 333)
        Me.KryptonListBox1.TabIndex = 2
        '
        'KryptonButton1
        '
        Me.KryptonButton1.Location = New System.Drawing.Point(3, 3)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.Size = New System.Drawing.Size(90, 25)
        Me.KryptonButton1.TabIndex = 0
        Me.KryptonButton1.Values.Text = "Add Action..."
        '
        'KryptonButton2
        '
        Me.KryptonButton2.Location = New System.Drawing.Point(99, 3)
        Me.KryptonButton2.Name = "KryptonButton2"
        Me.KryptonButton2.Size = New System.Drawing.Size(111, 25)
        Me.KryptonButton2.TabIndex = 1
        Me.KryptonButton2.Values.Text = "Remove Action..."
        '
        'KryptonButton3
        '
        Me.KryptonButton3.Location = New System.Drawing.Point(217, 3)
        Me.KryptonButton3.Name = "KryptonButton3"
        Me.KryptonButton3.Size = New System.Drawing.Size(47, 25)
        Me.KryptonButton3.TabIndex = 2
        Me.KryptonButton3.Values.Text = "Build..."
        '
        'KryptonButton4
        '
        Me.KryptonButton4.Location = New System.Drawing.Point(270, 3)
        Me.KryptonButton4.Name = "KryptonButton4"
        Me.KryptonButton4.Size = New System.Drawing.Size(84, 25)
        Me.KryptonButton4.TabIndex = 3
        Me.KryptonButton4.Values.Text = "Clear Script..."
        '
        'KryptonButton5
        '
        Me.KryptonButton5.Location = New System.Drawing.Point(360, 3)
        Me.KryptonButton5.Name = "KryptonButton5"
        Me.KryptonButton5.Size = New System.Drawing.Size(112, 25)
        Me.KryptonButton5.TabIndex = 4
        Me.KryptonButton5.Values.Text = "Open Script Path..."
        '
        'frmVisual_Script
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 363)
        Me.Controls.Add(Me.KryptonListBox1)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Name = "frmVisual_Script"
        Me.Text = "Visual Script"
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonListBox1 As ComponentFactory.Krypton.Toolkit.KryptonListBox
    Friend WithEvents KryptonButton2 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents KryptonButton3 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton5 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton4 As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
