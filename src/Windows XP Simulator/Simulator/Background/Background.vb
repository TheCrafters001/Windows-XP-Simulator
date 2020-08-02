Public Class Background
    Private Sub Background_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim idleMouse As New System.IO.MemoryStream(My.Resources.Cursor_1)
        Me.Cursor = New Cursor(idleMouse)
        Me.BackColor = Color.FromArgb(90, 126, 200)
        login.Show()
    End Sub
End Class