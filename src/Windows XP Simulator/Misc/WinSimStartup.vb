Imports ExplorerStatusChanger
Public Class WinSimStartup
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Windows_XP_Startup, AudioPlayMode.WaitToComplete)
        If My.Settings.Music = False Then
            My.Computer.Audio.Play(My.Resources.title, AudioPlayMode.BackgroundLoop)
        ElseIf My.Settings.Music = True Then
            My.Computer.Audio.Stop()
        End If
        Dim idleMouse As New System.IO.MemoryStream(My.Resources.Cursor_1)
        Dim lnkHoverMouse As New System.IO.MemoryStream(My.Resources.Cursor_15)
        Dim lnkHoverMouseDeny As New System.IO.MemoryStream(My.Resources.Cursor_11)
        Me.Cursor = New Cursor(idleMouse)
        start_btn.Cursor = New Cursor(lnkHoverMouse)
        install_btn.Cursor = New Cursor(lnkHoverMouseDeny)
    End Sub

    Private Sub toggleMusic_Click(sender As Object, e As EventArgs) Handles toggleMusic.Click
        If My.Settings.Music = False Then
            My.Settings.Music = True
            My.Computer.Audio.Stop()
        ElseIf My.Settings.Music = True Then
            My.Settings.Music = False
            My.Computer.Audio.Play(My.Resources.title, AudioPlayMode.BackgroundLoop)
        End If
    End Sub

    Private Sub start_btn_Click(sender As Object, e As EventArgs) Handles start_btn.Click
        My.Computer.Audio.Stop()
        SimulatorBoot_noinstall.Show()
        Me.Close()
    End Sub
End Class
