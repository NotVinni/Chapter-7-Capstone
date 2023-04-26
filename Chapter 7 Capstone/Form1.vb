
Option Strict On
Option Explicit On
Option Infer Off
Public Class Form1
    Dim Timer As Integer = 0
    Dim ranValue As New Random

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Dim randgen As New Random
    Dim word As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        word = randgen.Next(0, 4)

        Dim i As Integer = ListBox1.Items.Count
        Timer += 1

        For T As Integer = 0 To 10
            If T < 9 Then
                Label1.Text = CStr(ListBox1.Items(word))
            ElseIf T < 9 Then
                Timer1.Enabled = False
                Exit For
            End If
        Next T

        ' Original Loop Below
        '    If Timer = 5 Then
        '        Label1.Text = CStr(ListBox1.Items(0))
        '    ElseIf Timer = 10 Then
        '        Label1.Text = CStr(ListBox1.Items(1))
        '    ElseIf Timer = 15 Then
        '        Label1.Text = CStr(ListBox1.Items(2))
        '    ElseIf Timer = 20 Then
        '        Label1.Text = CStr(ListBox1.Items(3))
        '    ElseIf Timer = 25 Then
        '        Label1.Text = CStr(ListBox1.Items(ranValue.Next(i)))
        '    ElseIf Timer = 30 Then
        '        Timer = 0
        '        Timer1.Enabled = False
        '    End If
    End Sub
End Class
