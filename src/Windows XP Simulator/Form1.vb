Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ms As New System.IO.MemoryStream(My.Resources.arrow_m)
        Me.Cursor = New Cursor(ms)
    End Sub
End Class
