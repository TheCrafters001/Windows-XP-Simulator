Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim idleMouse As New System.IO.MemoryStream(My.Resources.Cursor_1)
        Dim lnkHoverMouse As New System.IO.MemoryStream(My.Resources.Cursor_15)
        Dim lnkHoverMouseDeny As New System.IO.MemoryStream(My.Resources.Cursor_11)
        Me.Cursor = New Cursor(idleMouse)
        ok_btn.Cursor = New Cursor(lnkHoverMouse)
        cancel_btn.Cursor = New Cursor(lnkHoverMouseDeny)
    End Sub
End Class