Public Class Form2
    Private Sub MephTheme1_Click(sender As Object, e As EventArgs) Handles MephTheme1.Click

    End Sub

    Private Sub MephButton1_Click(sender As Object, e As EventArgs) Handles MephButton1.Click
        My.Computer.Network.DownloadFile("url injector", "save path", "", "", False, 1000, True)
        My.Computer.Network.DownloadFile("cheat", "save path", "", "", False, 1000, True)
        Shell("save path+.exe /s")

    End Sub

    Private Sub MephButton2_Click(sender As Object, e As EventArgs) Handles MephButton2.Click
        My.Computer.Network.DownloadFile("url injector", "save path", "", "", False, 1000, True)
        My.Computer.Network.DownloadFile("cheat", "save path", "", "", False, 1000, True)
        Shell("save path+.exe /s")
    End Sub

    Private Sub MephButton30000_Click(sender As Object, e As EventArgs) Handles MephButton30000.Click
        Application.Exit()
    End Sub

    Private Sub MephButton3_Click(sender As Object, e As EventArgs) Handles MephButton3.Click
        My.Computer.Network.DownloadFile("url injector", "save path", "", "", False, 1000, True)
        My.Computer.Network.DownloadFile("cheat", "save path", "", "", False, 1000, True)
        Shell("save path+.exe /s")
    End Sub

    Private Sub MephButton4_Click(sender As Object, e As EventArgs) Handles MephButton4.Click
        My.Computer.Network.DownloadFile("url injector", "save path", "", "", False, 1000, True)
        My.Computer.Network.DownloadFile("cheat", "save path", "", "", False, 1000, True)
        Shell("save path+.exe /s")
    End Sub

    Private Sub MephButton5_Click(sender As Object, e As EventArgs) Handles MephButton5.Click
        My.Computer.Network.DownloadFile("url injector", "save path", "", "", False, 1000, True)
        My.Computer.Network.DownloadFile("cheat", "save path", "", "", False, 1000, True)
        Shell("save path+.exe /s")
    End Sub

    Private Sub MephButton60000000_Click(sender As Object, e As EventArgs) Handles MephButton60000000.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class