' Name:             Chapter 7 Capstone
' Purpose:          Wheel of Fortune type game
' Programmer:       Vinni Vongnaraj on 4/26/2023

Option Strict Off
Option Explicit On
Option Infer On

Imports System.Globalization
Imports System.IO
Imports System.IO.Pipes
Imports System.Net.Security
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

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

    Dim Test1 As Integer
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblRanWord.Text = String.Empty

    End Sub

    Private Sub keyboard()

    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        ' Button starts the timer which ends itself after a set time
        Timer1.Enabled = True
        btnAddPlay1.Enabled = False
        btnPlay.Enabled = False
        Test1 += 1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Variables to help create a scrolling effects
        Dim intRandom As Integer = 0
        Dim intRandom2 As Integer = 1
        Dim intRandom3 As Integer = 2


        word = rand.Next(0, 24)
        word2 = rand.Next(0, 24)
        word3 = rand.Next(0, 24)

        Timer += 1

        ' Loop to change the labels color and create a scrolling effect which ends on a random number
        ' Bankrupt method TBA, likely will check if lblwheel2 contains bankrupt and make a button to bankrupt visible 
        For T As Integer = 0 To 0
            If Timer <= 17 Then
                lblWheel.Text = CStr(lstMoney.Items(intRandom + Timer))
                lblWheel2.Text = CStr(lstMoney.Items(intRandom2 + Timer))
                lblWheel3.Text = CStr(lstMoney.Items(intRandom3 + Timer))

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
                lblWheel.Text = CStr(lstMoney.Items(word))
                lblWheel2.Text = CStr(lstMoney.Items(word2))
                lblWheel3.Text = CStr(lstMoney.Items(word3))

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
                If lblWheel2.Text Like "Bankrupt" Then
                    btnBankruptPlay1.Visible = True
                End If

                ' Determines who is in play
                If Test1 / 2 = 1 Then
                    btnPlay.Enabled = True
                    btnAddPlay2.Enabled = True
                Else
                    btnPlay.Enabled = True
                    btnAddPlay1.Enabled = True
                End If


                Timer = 0
                Timer1.Enabled = False
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
        btnBankruptPlay1.Visible = False
    End Sub

    Private Sub btnAddTeam1_Click(sender As Object, e As EventArgs) Handles btnAddPlay1.Click
        ' Button to add money to teams/person. Likely will be done by grabbing values from the listbox unless i figure out how to grab it from the label
        ' Will maybe try to turn this into a function

        If lblWheel2.Text Like "??,000" Or lblWheel2.Text Like "???,000" Then
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

        If lblWheel2.Text Like "??,000" Or lblWheel2.Text Like "???,000" Then
            Dim intValue As Integer = CInt(lstMoney.Items(word2))
            intTotal2 += intValue
            lblPlay2.Text = intTotal2.ToString("C0")
            btnAddPlay1.Enabled = False
        Else
            MsgBox("Please select a different option.", 0, "Error")
            btnAddPlay2.Enabled = False
        End If
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