<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddAction
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
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonListBox1 = New ComponentFactory.Krypton.Toolkit.KryptonListBox()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.KryptonButton1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 282)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(507, 29)
        Me.KryptonPanel1.TabIndex = 1
        '
        'KryptonButton1
        '
        Me.KryptonButton1.Location = New System.Drawing.Point(3, 2)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.Size = New System.Drawing.Size(90, 25)
        Me.KryptonButton1.TabIndex = 0
        Me.KryptonButton1.Values.Text = "OK"
        '
        'KryptonListBox1
        '
        Me.KryptonListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonListBox1.HorizontalScrollbar = True
        Me.KryptonListBox1.Items.AddRange(New Object() {"Nexus.SendMessageBox(", "Nexus.Debugging.SendDebugMsg(", "Nexus.IO.FileSystem.DeleteFile(", "Nexus.IO.FileSystem.DeleteDirectory(", "Nexus.IO.FileSystem.WriteFile(", "Nexus.IO.FileSystem.CreateDirectory(", "Nexus.Debugging.ForceDebugger()", "Nexus.System.Actions.RestartComputer()", "Nexus.UI.ShowTextEditorForm(", "Nexus.UI.SplashScreens.ShowSplash(", "Nexus.Debugging.SendCode(", "Nexus.Installers.ZipFiles.ExtractFile(", "Nexus.UI.SplashScreens.ShowSplashEX(", "'"})
        Me.KryptonListBox1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonListBox1.Name = "KryptonListBox1"
        Me.KryptonListBox1.Size = New System.Drawing.Size(507, 282)
        Me.KryptonListBox1.TabIndex = 2
        '
        'frmAddAction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 311)
        Me.Controls.Add(Me.KryptonListBox1)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddAction"
        Me.Text = "Add Action"
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonListBox1 As ComponentFactory.Krypton.Toolkit.KryptonListBox
End Class
