Public Class frmLoadScript
    Friend Shared ExitCode As Integer
    Private Sub frmLoadScript_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each script As String In My.Computer.FileSystem.GetFiles(Application.StartupPath + "\Scripts")
            ListBox1.Items.Add(script)
        Next
    End Sub
    Function RunScript()
        ListBox2.Items.Clear()
        ListBox2.Items.AddRange(TextBox1.Lines)
        For i = 0 To ListBox2.Items.Count - 1
            Dim str As String = ListBox2.Items.Item(i)
            Dim arr() As String = Split(str)
            If arr(0) = "Nexus.SendMessageBox" Then
                MsgBox(arr(1),, arr(2))
            End If
            If arr(0) = "Nexus.Debugging.SendDebugMsg(" Then
                frmDebugger.SendDebugMessage(arr(1))
            End If
            If arr(0) = "Nexus.IO.FileSystem.DeleteFile(" Then
                My.Computer.FileSystem.DeleteFile(arr(1))
            End If
            If arr(0) = "Nexus.IO.FileSystem.DeleteDirectory(" Then
                My.Computer.FileSystem.DeleteDirectory(arr(1), FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            If arr(0) = "Nexus.IO.FileSystem.WriteFile(" Then
                My.Computer.FileSystem.WriteAllText(arr(1), arr(2), False)
            End If
            If arr(0) = "Nexus.IO.FileSystem.CreateDirectory(" Then
                My.Computer.FileSystem.CreateDirectory(arr(1))
            End If
            If arr(0) = "Nexus.Debugging.ForceDebugger()" Then
                frmDebugger.Show()
            End If
            If arr(0) = "Nexus.System.Actions.RestartComputer()" Then
                Process.Start("shutdown /r")
            End If
            If arr(0) = "Nexus.UI.ShowTextEditorForm(" Then
                frmTextEditor.RichTextBox1.Font = New Font(arr(1), 12, FontStyle.Bold)
                frmTextEditor.Show()
            End If
            If arr(0) = "Nexus.UI.SplashScreens.ShowSplash(" Then
                frmSplash.Label1.Text = arr(1)
                frmSplash.ShowDialog()
            End If
            If arr(0) = "Nexus.Debugging.SendCode(" Then
                Try
                    ExitCode = arr(1)
                    frmDebugger.SendDebugMessage("Script returned code: " + ExitCode)
                Catch ex As Exception
                    frmDebugger.SendDebugMessage("InvalidTypeException: The excepted type was supposed to be Integer instead of Any other type.")
                    ExitCode = -1
                End Try
            End If
            If arr(0) = "#TYPE = INSTALLER" Then
                frmDebugger.SendDebugMessage("Script is running as an Installer.")
            End If
            If arr(0) = "Nexus.Installers.ZipFiles.ExtractFile(" Then
                frmDownloadFile.Filename = arr(1)
                frmDownloadFile.TargetLocation = arr(2)
                frmDownloadFile.ShowDialog()
            End If
        Next
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = My.Computer.FileSystem.ReadAllText(ListBox1.SelectedItem)
        RunScript()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmDebugger.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        frmTutorial.ShowDialog()
    End Sub
End Class