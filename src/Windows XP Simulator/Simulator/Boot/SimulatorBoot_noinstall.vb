Imports ExplorerStatusChanger

Public Class SimulatorBoot_noinstall
    Private Sub SimulatorBoot_noinstall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Visible = False
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BootScreen_Animated.Location = New Point((Me.Width / 2) - (BootScreen_Animated.Width / 2), (Me.Height / 2) - (BootScreen_Animated.Height / 2))
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = 100 Then
            Background.Show()
            Me.Close()
        End If
    End Sub
End Class