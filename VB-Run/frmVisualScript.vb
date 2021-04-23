Public Class frmVisual_Script
    Private Sub KryptonButton2_Click(sender As Object, e As EventArgs) Handles KryptonButton2.Click
        KryptonListBox1.Items.Remove(KryptonListBox1.SelectedItem)
    End Sub

    Private Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click
        frmAddAction.ShowDialog()
    End Sub

    Private Sub KryptonButton3_Click(sender As Object, e As EventArgs) Handles KryptonButton3.Click
        For Each item As String In KryptonListBox1.Items
            My.Computer.FileSystem.WriteAllText(".\Scripts\VisualScript.nx", item + vbNewLine, True)
        Next
    End Sub

    Private Sub KryptonButton4_Click(sender As Object, e As EventArgs) Handles KryptonButton4.Click
        My.Computer.FileSystem.WriteAllText(".\Scripts\VisualScript.nx", "", False)
    End Sub

    Private Sub KryptonButton5_Click(sender As Object, e As EventArgs) Handles KryptonButton5.Click
        Process.Start("explorer.exe", String.Format("/n, /e, {0}", ".\Scripts\"))
    End Sub
End Class