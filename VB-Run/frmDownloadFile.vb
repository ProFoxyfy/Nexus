Public Class frmDownloadFile
    Friend Shared Filename As String
    Friend Shared TargetLocation As String

    Private Sub CButton1_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles CButton1.ClickButtonArea
        System.IO.Compression.ZipFile.ExtractToDirectory(Filename, TargetLocation)
        MsgBox("Extraction Completed!")
        Me.Close()
    End Sub

    Private Sub CButton2_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles CButton2.ClickButtonArea
        Me.Close()
    End Sub
End Class