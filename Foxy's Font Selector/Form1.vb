Public Class Form1
    Private Sub FontList1_SelectedFontFamilyChanged(sender As Object, e As EventArgs) Handles FontList1.SelectedFontFamilyChanged
        Label1.Font = New Font(FontList1.SelectedFontFamily, 48)
    End Sub
End Class
