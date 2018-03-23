Public Class Form4
    Private Sub MephButton1_Click(sender As Object, e As EventArgs) Handles MephButton1.Click
        My.Computer.Network.DownloadFile("url injector", "save path", "", "", False, 1000, True)
        My.Computer.Network.DownloadFile("cheat", "save path", "", "", False, 1000, True)
        Shell("save path+.exe /s")
    End Sub

    Private Sub MephButton200000_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub MephButton2_Click(sender As Object, e As EventArgs) Handles MephButton2.Click
        My.Computer.Network.DownloadFile("url injector", "save path", "", "", False, 1000, True)
        My.Computer.Network.DownloadFile("cheat", "save path", "", "", False, 1000, True)
        Shell("save path+.exe /s")
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

    Private Sub MephButton500000_Click(sender As Object, e As EventArgs) Handles MephButton500000.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class