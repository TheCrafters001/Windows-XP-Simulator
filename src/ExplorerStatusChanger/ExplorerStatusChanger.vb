Public Class ExplorerStatusChanger
    Public Shared Sub KillExplorer()
        shell("taskkill /f /im explorer.exe")
    End Sub
    Public Shared Sub StartExplorer()
        Shell(String.Concat(System.Environment.GetFolderPath(Environment.SpecialFolder.Windows), "\explorer.exe"))

    End Sub
End Class
