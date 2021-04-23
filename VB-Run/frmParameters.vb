Public Class frmParameters
    Private Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click
        frmVisual_Script.KryptonListBox1.Items.Add(frmAddAction.KryptonListBox1.SelectedItem + " " + KryptonTextBox1.Text + " " + KryptonTextBox2.Text + " " + KryptonTextBox3.Text)
        Me.Close()
    End Sub
End Class