Public Class Panel_Startingup
    Private Sub Panel_Startingup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        progressBoot_progr.Increment(5)
        If progressBoot_progr.Value = 100 Then
            login.Show()
            Me.Close()
        End If
    End Sub
End Class