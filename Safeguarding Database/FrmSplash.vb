Public Class FrmSplash

    Private Sub FrmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplashTimer.Start()
    End Sub

    Private Sub SplashTimer_Tick(sender As Object, e As EventArgs) Handles SplashTimer.Tick
        lblPercentage.Text = Val(lblPercentage.Text) + 2 & ("%")
        If lblPercentage.Text = 100 & "%" Then
            FrmCaseload.Show()
            SplashTimer.Stop()
            Me.Hide()
            SplashTimer.Dispose()
        End If
    End Sub
End Class