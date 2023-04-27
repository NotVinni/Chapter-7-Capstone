' Name:             Chapter 7 Capstone
' Purpose:          Wheel of Fortune type game
' Programmer:       Vinni Vongnaraj on 4/26/2023

Option Strict On
Option Explicit On
Option Infer Off
Public Class frmMain
    Dim Timer As Integer = 0
    Dim rand As New Random
    Dim word As Integer
    Dim word2 As Integer
    Dim word3 As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Timer1.Enabled = True

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        word = rand.Next(0, 24)
        word2 = rand.Next(0, 24)
        word3 = rand.Next(0, 24)
        Dim Test As Integer = 0
        Dim Test2 As Integer = 1
        Dim Test3 As Integer = 2
        Dim i As Integer = ListBox1.Items.Count
        Timer += 1

        For T As Integer = 0 To 0
            If Timer <= 17 Then
                Label1.Text = CStr(ListBox1.Items(Test + Timer))
                Label2.Text = CStr(ListBox1.Items(Test2 + Timer))
                Label3.Text = CStr(ListBox1.Items(Test3 + Timer))
                Label3.BackColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256))
                Label1.BackColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256))
                Label2.BackColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256))
                Timer1.Interval = 150
            Else
                Label3.Text = CStr(ListBox1.Items(word))
                Label1.Text = CStr(ListBox1.Items(word2))
                Label2.Text = CStr(ListBox1.Items(word3))

                Timer = 0
                Timer1.Enabled = False
                Exit For
            End If
        Next T


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
