Public Class frmAddAction
    Private Sub KryptonTreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs)

    End Sub

    Private Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click
        frmParameters.ShowDialog()
        Me.Close()
    End Sub
End Class