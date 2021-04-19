Public Class frmSplash

    Private Async Function frmSplash_LoadAsync(sender As Object, e As EventArgs) As Task Handles MyBase.Load
        Await (Task.Delay(3000))
        Me.Close()
    End Function
End Class