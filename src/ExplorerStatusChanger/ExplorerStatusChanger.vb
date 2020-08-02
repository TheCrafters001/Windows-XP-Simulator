Public Class ExplorerStatusChanger
    Public Shared Sub KillExplorer()
        shell("taskkill /f /im explorer.exe")
    End Sub
    Public Shared Sub StartExplorer()
        System.Diagnostics.Process.Start("explorer.exe")
    End Sub
End Class
