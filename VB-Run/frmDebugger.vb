Public Class frmDebugger
    Private Sub frmDebugger_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub SendDebugMessage(Message As String)
        TextBox1.Text = TextBox1.Text + vbNewLine + Message
    End Sub
End Class