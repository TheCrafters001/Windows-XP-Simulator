Public Class ExplorerStatusChanger
    Public Shared Sub KillExplorer()
        Shell("taskkill /f /im explorer.exe")
    End Sub
    Public Shared Sub StartExplorer()
        Shell("explorer.exe")
    End Sub
End Class
