﻿Public Class WinSimStartup
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Windows_XP_Startup, AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play(My.Resources.title, AudioPlayMode.BackgroundLoop)
        Dim idleMouse As New System.IO.MemoryStream(My.Resources.Cursor_1)
        Dim lnkHoverMouse As New System.IO.MemoryStream(My.Resources.Cursor_15)
        Me.Cursor = New Cursor(idleMouse)
        start_btn.Cursor = New Cursor(lnkHoverMouse)
    End Sub
End Class