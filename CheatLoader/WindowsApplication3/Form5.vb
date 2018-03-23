Public Class Form5
    Private Sub MephButton1_Click(sender As Object, e As EventArgs) Handles MephButton1.Click
        My.Computer.Network.DownloadFile("url injector", "save path", "", "", False, 1000, True)
        Shell("save path+.exe /s")
    End Sub

    Private Sub MephButton20000_Click(sender As Object, e As EventArgs) Handles MephButton20000.Click
        Application.Exit()
    End Sub

    Private Sub MephButton2_Click(sender As Object, e As EventArgs) Handles MephButton2.Click
        My.Computer.Network.DownloadFile("url injector", "save path", "", "", False, 1000, True)
        Shell("save path+.exe /s")
    End Sub

    Private Sub MephButton300000_Click(sender As Object, e As EventArgs) Handles MephButton300000.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class