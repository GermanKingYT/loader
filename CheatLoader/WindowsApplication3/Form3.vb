Imports System.IO
Imports System.Threading
Imports System.Net
Imports System.Management
Imports System.Diagnostics

Public Class Form3





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load








    End Sub


    Private Sub MephButton1_Click(sender As Object, e As EventArgs) Handles MephButton1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub MephButton2_Click(sender As Object, e As EventArgs) Handles MephButton2.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub MephButton3_Click(sender As Object, e As EventArgs) Handles MephButton3.Click
        Form5.Show()
        Me.Hide()
    End Sub







    Private Sub MephButton4_Click(sender As Object, e As EventArgs) 
        Form6.Show()
        Me.Hide()
    End Sub
End Class