' Name:             Chapter 7 Capstone
' Purpose:          Wheel of Fortune type game
' Programmer:       Vinni Vongnaraj on 4/26/2023

Option Strict On
Option Explicit On
Option Infer Off

Imports System.Runtime.CompilerServices

Public Class frmMain

    ' Class level variables
    Dim Timer As Integer = 0
    Dim rand As New Random
    Dim word As Integer
    Dim word2 As Integer
    Dim word3 As Integer
    Dim intWheel As Integer
    Dim intTeam1 As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        ' Button starts the timer which ends itself after a set time
        Timer1.Enabled = True
        btnAddTeam1.Enabled = False
        btnSubTeam1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Variables to help create a scrolling effects
        Dim int0 As Integer = 0
        Dim int1 As Integer = 1
        Dim int2 As Integer = 2

        word = rand.Next(0, 24)
        word2 = rand.Next(0, 24)
        word3 = rand.Next(0, 24)

        Timer += 1

        ' Loop to change the labels color and create a scrolling effect which ends on a random number
        ' Bankrupt method TBA, likely will check if lblwheel2 contains bankrupt and make a button to bankrupt visible 
        For T As Integer = 0 To 0
            If Timer <= 17 Then
                lblWheel.Text = CStr(ListBox1.Items(int0 + Timer))
                lblWheel2.Text = CStr(ListBox1.Items(int1 + Timer))
                lblWheel3.Text = CStr(ListBox1.Items(int2 + Timer))

                ' If statement that adds a $ symbol, want to create a function of some sort for this later maybe
                If lblWheel.Text Like "?,000" Or lblWheel.Text Like "??,000" Then
                    lblWheel.Text = lblWheel.Text.Insert(0, "$")
                End If
                If lblWheel2.Text Like "?,000" Or lblWheel2.Text Like "??,000" Then
                    lblWheel2.Text = lblWheel2.Text.Insert(0, "$")
                End If
                If lblWheel3.Text Like "?,000" Or lblWheel3.Text Like "??,000" Then
                    lblWheel3.Text = lblWheel3.Text.Insert(0, "$")
                End If

                lblWheel.BackColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256))
                lblWheel2.BackColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256))
                lblWheel3.BackColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256))
                Timer1.Interval = 150

            Else
                lblWheel.Text = CStr(ListBox1.Items(word))
                lblWheel2.Text = CStr(ListBox1.Items(word2))
                lblWheel3.Text = CStr(ListBox1.Items(word3))

                ' See line 44
                If lblWheel.Text Like "?,000" Or lblWheel.Text Like "??,000" Then
                    lblWheel.Text = lblWheel.Text.Insert(0, "$")
                End If
                If lblWheel2.Text Like "?,000" Or lblWheel2.Text Like "??,000" Then
                    lblWheel2.Text = lblWheel2.Text.Insert(0, "$")
                End If
                If lblWheel3.Text Like "?,000" Or lblWheel3.Text Like "??,000" Then
                    lblWheel3.Text = lblWheel3.Text.Insert(0, "$")
                End If


                Timer = 0
                btnAddTeam1.Enabled = True
                btnSubTeam1.Enabled = True
                Timer1.Enabled = False
                Exit For
            End If
        Next T
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Dim intTotal As Integer

    Private Sub btnAddTeam1_Click(sender As Object, e As EventArgs) Handles btnAddTeam1.Click
        ' Button to add money to teams/person. Likely will be done by grabbing values from the listbox unless i figure out how to grab it from the label

        If lblWheel2.Text Like "??,000" Or lblWheel2.Text Like "???,000" Then
            Dim intValue As Integer = CInt(ListBox1.Items(word2))
            intTotal += intValue
            lblTeam1.Text = intTotal.ToString("C0")
        Else
            MsgBox("Please select a different option.", 0, "Error")
        End If

    End Sub
End Class
