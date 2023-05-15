﻿' Name:             Chapter 7 Capstone
' Purpose:          Wheel of Fortune type game
' Programmer:       Vinni Vongnaraj on 4/26/2023

Option Strict Off
Option Explicit On
Option Infer On

Imports System.Globalization
Imports System.IO
Imports System.IO.Pipes
Imports System.Net.Security
Imports System.Reflection.Emit
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar

Public Class frmMain

    ' Class level variables
    Dim Timer As Integer = 0
    Dim secondTimer As Integer = 0
    Dim rand As New Random
    Dim word As Integer
    Dim word2 As Integer
    Dim word3 As Integer

    Dim intTotal1 As Integer
    Dim intTotal2 As Integer

    Dim ranIndex As Integer
    Dim ranWord As String
    Dim tempWord As String
    Dim outputWord As String


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblRanWord.Text = String.Empty

    End Sub

    Private Sub keyboard()

    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        ' Button starts the timer which ends itself after a set time
        Timer1.Enabled = True
        Timer3.Enabled = True
        btnAddPlay2.Enabled = False
        btnAddPlay1.Enabled = False
        btnPlay.Enabled = False
    End Sub

    ' Variables to help create a scrolling effects
    Dim intRandom As Integer = 0
    Dim intRandom2 As Integer = 1
    Dim intRandom3 As Integer = 2
    Dim intRandom4 As Integer = 3
    Dim intRandom5 As Integer = 4
    Dim intRandom6 As Integer = 5
    Dim intRandom7 As Integer = 6
    Dim intRandom8 As Integer = 7
    Dim intRandom9 As Integer = 8
    Dim intRandom10 As Integer = 9
    Dim intRandom11 As Integer = 10
    Dim intRandom12 As Integer = 11
    Dim intRandom13 As Integer = 12
    Dim intRandom14 As Integer = 13
    Dim intRandom15 As Integer = 14
    Dim intRandom16 As Integer = 15
    Dim intRandom17 As Integer = 16
    Dim intRandom18 As Integer = 17
    Dim intRandom19 As Integer = 18
    Dim intRandom20 As Integer = 19
    Dim intRandom21 As Integer = 20
    Dim intRandom22 As Integer = 21
    Dim intRandom23 As Integer = 22
    Dim intRandom24 As Integer = 23
    Dim intRandom25 As Integer = 24
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        intRandom += 1
        intRandom2 += 1
        intRandom3 += 1
        intRandom4 += 1
        intRandom5 += 1
        intRandom6 += 1
        intRandom7 += 1
        intRandom8 += 1
        intRandom9 += 1
        intRandom10 += 1
        intRandom11 += 1
        intRandom12 += 1
        intRandom13 += 1
        intRandom14 += 1
        intRandom15 += 1
        intRandom16 += 1
        intRandom17 += 1
        intRandom18 += 1
        intRandom19 += 1
        intRandom20 += 1
        intRandom21 += 1
        intRandom22 += 1
        intRandom23 += 1
        intRandom24 += 1
        intRandom25 += 1

        word = rand.Next(0, 24)
        word2 = rand.Next(0, 24)
        word3 = rand.Next(0, 24)

        Timer += 1

        ' Loop to change the labels color and create a scrolling effect which ends on a random number
        ' Bankrupt method TBA, likely will check if lblwheel13 contains bankrupt and make a button to bankrupt visible 
        For T As Integer = 0 To 0
            If Timer <= 25 Then
                lblWheel1.Text = CStr(lstMoney.Items(intRandom))
                lblWheel2.Text = CStr(lstMoney.Items(intRandom2))
                lblWheel3.Text = CStr(lstMoney.Items(intRandom3))
                lblWheel4.Text = CStr(lstMoney.Items(intRandom4))
                lblWheel5.Text = CStr(lstMoney.Items(intRandom5))
                lblWheel6.Text = CStr(lstMoney.Items(intRandom6))
                lblWheel7.Text = CStr(lstMoney.Items(intRandom7))
                lblWheel8.Text = CStr(lstMoney.Items(intRandom9))
                lblWheel9.Text = CStr(lstMoney.Items(intRandom10))
                lblWheel10.Text = CStr(lstMoney.Items(intRandom11))
                lblWheel11.Text = CStr(lstMoney.Items(intRandom12))
                lblWheel12.Text = CStr(lstMoney.Items(intRandom13))
                lblWheel13.Text = CStr(lstMoney.Items(intRandom14))
                lblWheel14.Text = CStr(lstMoney.Items(intRandom14))
                lblWheel15.Text = CStr(lstMoney.Items(intRandom15))
                lblWheel16.Text = CStr(lstMoney.Items(intRandom16))
                lblWheel17.Text = CStr(lstMoney.Items(intRandom17))
                lblWheel18.Text = CStr(lstMoney.Items(intRandom18))
                lblWheel19.Text = CStr(lstMoney.Items(intRandom19))
                lblWheel20.Text = CStr(lstMoney.Items(intRandom20))
                lblWheel21.Text = CStr(lstMoney.Items(intRandom21))
                lblWheel22.Text = CStr(lstMoney.Items(intRandom22))
                lblWheel23.Text = CStr(lstMoney.Items(intRandom23))
                lblWheel24.Text = CStr(lstMoney.Items(intRandom24))
                lblWheel25.Text = CStr(lstMoney.Items(intRandom25))


                ' If statement that adds a $ symbol, want to create a function of some sort for this later maybe
                If lblWheel1.Text Like "?,000" Or lblWheel1.Text Like "??,000" Then
                    lblWheel1.Text = lblWheel1.Text.Insert(0, "$")
                End If
                If lblWheel2.Text Like "?,000" Or lblWheel2.Text Like "??,000" Then
                    lblWheel2.Text = lblWheel2.Text.Insert(0, "$")
                End If
                If lblWheel3.Text Like "?,000" Or lblWheel3.Text Like "??,000" Then
                    lblWheel3.Text = lblWheel3.Text.Insert(0, "$")
                End If

                'lblWheel1.BackColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256))
                'lblWheel2.BackColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256))
                'lblWheel3.BackColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256))
                Timer1.Interval = 300

            Else
                lblWheel1.Text = CStr(lstMoney.Items(word))
                lblWheel2.Text = CStr(lstMoney.Items(word2))
                lblWheel3.Text = CStr(lstMoney.Items(word3))

                ' See line 44
                If lblWheel1.Text Like "?,000" Or lblWheel1.Text Like "??,000" Then
                    lblWheel1.Text = lblWheel1.Text.Insert(0, "$")
                End If
                If lblWheel2.Text Like "?,000" Or lblWheel2.Text Like "??,000" Then
                    lblWheel2.Text = lblWheel2.Text.Insert(0, "$")
                End If
                If lblWheel3.Text Like "?,000" Or lblWheel3.Text Like "??,000" Then
                    lblWheel3.Text = lblWheel3.Text.Insert(0, "$")
                End If


                If lblWheel13.Text Like "Bankrupt" And Tick = 0 Then
                    btnBankruptPlay1.Visible = True
                ElseIf lblWheel13.Text Like "Bankrupt" And Tick = 1 Then
                    btnBankruptPlay2.Visible = True
                End If


                If Tick = 0 Then
                    btnAddPlay1.Enabled = True
                    btnPlay.Enabled = True
                Else
                    btnAddPlay2.Enabled = True
                    btnPlay.Enabled = True
                End If


                Timer = 0
                Timer1.Enabled = False

                Label1.Text = DisabledTimer.ToString
                Label2.Text = secondTimer.ToString
                Label3.Text = Tick.ToString
                Exit For
            End If
        Next T
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub






    ' Loads text file of random phrases     
    Private Sub menuOpen_Click(sender As Object, e As EventArgs) Handles menuOpen.Click
        ranWord = String.Empty
        tempWord = String.Empty
        outputWord = String.Empty

        Dim Open As New OpenFileDialog()
        Dim myStreamReader As System.IO.StreamReader

        Open.Filter = "Text [*.txt*]|*.txt|All Files [*.*]|*.*"
        Open.CheckFileExists = True
        Open.Title = "OpenFile"
        Open.ShowDialog(Me)

        Try
            For Each line As String In File.ReadAllLines(Open.FileName)
                lstPhrases.Items.Add(line)
            Next
            Open.OpenFile()
            myStreamReader = System.IO.File.OpenText(Open.FileName)

            ranIndex = CInt(lstPhrases.Items.Count * Rnd())
            ranWord = lstPhrases.Items(ranIndex).ToString.Trim.ToUpper

            For Each c As Char In ranWord
                tempWord += c + " "
                outputWord += "- "
            Next
            lblRanWord.Text = outputWord
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    ' Guess Letters 
    Private Sub btGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click
        Dim strGuess As String
        strGuess = txtGuess.Text.Trim.ToUpper()

        If ranWord.Contains(txtGuess.Text.ToUpper) Then
            For intIndex As Integer = 0 To tempWord.Length - 1
                If tempWord(intIndex) = txtGuess.Text.ToUpper Then
                    outputWord = outputWord.Insert(intIndex, txtGuess.Text.ToUpper)
                    outputWord = outputWord.Remove(intIndex + 1, 1)
                    tempWord = tempWord.Insert(intIndex, " ")
                    tempWord = tempWord.Remove(intIndex + 1, 1)
                End If
            Next
        End If



        lblRanWord.Text = outputWord
    End Sub
    Private Sub btnBankrupt1_Click(sender As Object, e As EventArgs) Handles btnBankruptPlay1.Click
        ' Resets Money
        intTotal1 = 0
        lblPlay1.Text = intTotal1.ToString("C0")
        btnBankruptPlay1.Visible = False
    End Sub
    Private Sub btnBankruptPlay2_Click(sender As Object, e As EventArgs) Handles btnBankruptPlay2.Click
        intTotal2 = 0
        lblPlay2.Text = intTotal2.ToString("C0")
        btnBankruptPlay2.Visible = False
    End Sub

    Private Sub btnAddTeam1_Click(sender As Object, e As EventArgs) Handles btnAddPlay1.Click
        ' Button to add money to teams/person. Likely will be done by grabbing values from the listbox unless i figure out how to grab it from the label
        ' Will maybe try to turn this into a function

        If lblWheel13.Text Like "??,000" Or lblWheel13.Text Like "???,000" Then
            Dim intValue As Integer = CInt(lstMoney.Items(word2))
            intTotal1 += intValue
            lblPlay1.Text = intTotal1.ToString("C0")
            btnAddPlay1.Enabled = False
        Else
            MsgBox("Please select a different option.", 0, "Error")
            btnAddPlay1.Enabled = False
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAddPlay2.Click

        If lblWheel13.Text Like "??,000" Or lblWheel13.Text Like "???,000" Then
            Dim intValue As Integer = CInt(lstMoney.Items(word2))
            intTotal2 += intValue
            lblPlay2.Text = intTotal2.ToString("C0")
            btnAddPlay2.Enabled = False
        Else
            MsgBox("Please select a different option.", 0, "Error")
            btnAddPlay2.Enabled = False
        End If
    End Sub
    '  Class level variables
    Dim Tick As Double
    Dim DisabledTimer As Double = 0

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        DisabledTimer += 1

        Tick = DisabledTimer Mod 2

        If DisabledTimer > 1 Then
            Timer3.Enabled = False
        End If

        Label1.Text = DisabledTimer.ToString
        Label2.Text = secondTimer.ToString
        Label3.Text = Tick.ToString
    End Sub


    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        txtGuess.Text = "A"
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        txtGuess.Text = "B"
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtGuess.Text = "C"
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        txtGuess.Text = "D"
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        txtGuess.Text = "E"
    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        txtGuess.Text = "F"
    End Sub

    Private Sub btnG_Click(sender As Object, e As EventArgs) Handles btnG.Click
        txtGuess.Text = "G"
    End Sub

    Private Sub btnH_Click(sender As Object, e As EventArgs) Handles btnH.Click
        txtGuess.Text = "H"
    End Sub

    Private Sub btnJ_Click(sender As Object, e As EventArgs) Handles btnJ.Click
        txtGuess.Text = "I"
    End Sub

    Private Sub btnK_Click(sender As Object, e As EventArgs) Handles btnK.Click
        txtGuess.Text = "K"
    End Sub

End Class