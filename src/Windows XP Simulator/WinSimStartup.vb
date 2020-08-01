Public Class WinSimStartup
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.title, AudioPlayMode.BackgroundLoop)
        Dim ms As New System.IO.MemoryStream(My.Resources.arrow_m)
        Me.Cursor = New Cursor(ms)
    End Sub
End Class
