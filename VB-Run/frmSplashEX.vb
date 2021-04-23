Public Class frmSplashEX
    Private Async Sub frmSplashEX_LoadAsync(sender As Object, e As EventArgs) Handles MyBase.Load
        Await (Task.Delay(3000))
        Me.Close()
    End Sub
End Class