<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.lblWheel = New System.Windows.Forms.Label()
        Me.lstMoney = New System.Windows.Forms.ListBox()
        Me.lblWheel2 = New System.Windows.Forms.Label()
        Me.lblWheel3 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDescPlay1 = New System.Windows.Forms.Label()
        Me.lblPlay1 = New System.Windows.Forms.Label()
        Me.btnAddPlay1 = New System.Windows.Forms.Button()
        Me.btnBankruptPlay1 = New System.Windows.Forms.Button()
        Me.btnGuess = New System.Windows.Forms.Button()
        Me.lstPhrases = New System.Windows.Forms.ListBox()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtGuess = New System.Windows.Forms.TextBox()
        Me.lblRanWord = New System.Windows.Forms.Label()
        Me.btnBankruptPlay2 = New System.Windows.Forms.Button()
        Me.btnAddPlay2 = New System.Windows.Forms.Button()
        Me.lblPlay2 = New System.Windows.Forms.Label()
        Me.lblDescPlay2 = New System.Windows.Forms.Label()
        Me.lblGuessedLetters = New System.Windows.Forms.Label()
        Me.lblDescGuessedLetters = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(305, 26)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(112, 40)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "&Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'lblWheel
        '
        Me.lblWheel.BackColor = System.Drawing.Color.Red
        Me.lblWheel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWheel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWheel.Location = New System.Drawing.Point(8, 26)
        Me.lblWheel.Name = "lblWheel"
        Me.lblWheel.Size = New System.Drawing.Size(145, 40)
        Me.lblWheel.TabIndex = 1
        Me.lblWheel.Text = "Bankrupt"
        Me.lblWheel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstMoney
        '
        Me.lstMoney.FormattingEnabled = True
        Me.lstMoney.Items.AddRange(New Object() {"1,000", "5,000", "2,000", "10,000", "Skip", "2,000", "2,000", "1,000", "1,000", "Bankrupt", "5,000", "2,000", "Skip", "1,000", "1,000", "1,000", "Skip", "5,000", "1,000", "1,000", "Bankrupt", "2,000", "1,000", "1,000", "2,000"})
        Me.lstMoney.Location = New System.Drawing.Point(1031, 26)
        Me.lstMoney.Name = "lstMoney"
        Me.lstMoney.Size = New System.Drawing.Size(134, 147)
        Me.lstMoney.TabIndex = 5
        Me.lstMoney.Visible = False
        '
        'lblWheel2
        '
        Me.lblWheel2.BackColor = System.Drawing.Color.Lime
        Me.lblWheel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWheel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWheel2.Location = New System.Drawing.Point(8, 66)
        Me.lblWheel2.Name = "lblWheel2"
        Me.lblWheel2.Size = New System.Drawing.Size(145, 40)
        Me.lblWheel2.TabIndex = 6
        Me.lblWheel2.Text = "$5000"
        Me.lblWheel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWheel3
        '
        Me.lblWheel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblWheel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWheel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWheel3.Location = New System.Drawing.Point(8, 106)
        Me.lblWheel3.Name = "lblWheel3"
        Me.lblWheel3.Size = New System.Drawing.Size(145, 40)
        Me.lblWheel3.TabIndex = 7
        Me.lblWheel3.Text = "$2000"
        Me.lblWheel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(1058, 533)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 36)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(159, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'lblDescPlay1
        '
        Me.lblDescPlay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescPlay1.Location = New System.Drawing.Point(16, 452)
        Me.lblDescPlay1.Name = "lblDescPlay1"
        Me.lblDescPlay1.Size = New System.Drawing.Size(145, 40)
        Me.lblDescPlay1.TabIndex = 10
        Me.lblDescPlay1.Text = "Player 1:"
        Me.lblDescPlay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlay1
        '
        Me.lblPlay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlay1.Location = New System.Drawing.Point(16, 490)
        Me.lblPlay1.Name = "lblPlay1"
        Me.lblPlay1.Size = New System.Drawing.Size(145, 40)
        Me.lblPlay1.TabIndex = 11
        Me.lblPlay1.Text = "$0"
        Me.lblPlay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddPlay1
        '
        Me.btnAddPlay1.Enabled = False
        Me.btnAddPlay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPlay1.Location = New System.Drawing.Point(13, 533)
        Me.btnAddPlay1.Name = "btnAddPlay1"
        Me.btnAddPlay1.Size = New System.Drawing.Size(71, 36)
        Me.btnAddPlay1.TabIndex = 12
        Me.btnAddPlay1.Text = "+"
        Me.btnAddPlay1.UseVisualStyleBackColor = True
        '
        'btnBankruptPlay1
        '
        Me.btnBankruptPlay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBankruptPlay1.Location = New System.Drawing.Point(90, 533)
        Me.btnBankruptPlay1.Name = "btnBankruptPlay1"
        Me.btnBankruptPlay1.Size = New System.Drawing.Size(71, 36)
        Me.btnBankruptPlay1.TabIndex = 14
        Me.btnBankruptPlay1.Text = "&Bankrupt"
        Me.btnBankruptPlay1.UseVisualStyleBackColor = True
        Me.btnBankruptPlay1.Visible = False
        '
        'btnGuess
        '
        Me.btnGuess.Location = New System.Drawing.Point(305, 133)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(112, 40)
        Me.btnGuess.TabIndex = 15
        Me.btnGuess.Text = "&Guess"
        Me.btnGuess.UseVisualStyleBackColor = True
        '
        'lstPhrases
        '
        Me.lstPhrases.FormattingEnabled = True
        Me.lstPhrases.Location = New System.Drawing.Point(892, 33)
        Me.lstPhrases.Name = "lstPhrases"
        Me.lstPhrases.Size = New System.Drawing.Size(133, 134)
        Me.lstPhrases.TabIndex = 16
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1181, 24)
        Me.MenuStrip.TabIndex = 17
        Me.MenuStrip.Text = "Open"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuOpen})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'menuOpen
        '
        Me.menuOpen.Name = "menuOpen"
        Me.menuOpen.Size = New System.Drawing.Size(124, 22)
        Me.menuOpen.Text = "Open File"
        '
        'txtGuess
        '
        Me.txtGuess.Location = New System.Drawing.Point(507, 133)
        Me.txtGuess.Name = "txtGuess"
        Me.txtGuess.Size = New System.Drawing.Size(100, 20)
        Me.txtGuess.TabIndex = 18
        '
        'lblRanWord
        '
        Me.lblRanWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRanWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRanWord.Location = New System.Drawing.Point(507, 33)
        Me.lblRanWord.Name = "lblRanWord"
        Me.lblRanWord.Size = New System.Drawing.Size(334, 73)
        Me.lblRanWord.TabIndex = 19
        Me.lblRanWord.Text = "Word:"
        Me.lblRanWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBankruptPlay2
        '
        Me.btnBankruptPlay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBankruptPlay2.Location = New System.Drawing.Point(327, 533)
        Me.btnBankruptPlay2.Name = "btnBankruptPlay2"
        Me.btnBankruptPlay2.Size = New System.Drawing.Size(71, 36)
        Me.btnBankruptPlay2.TabIndex = 23
        Me.btnBankruptPlay2.Text = "&Bankrupt"
        Me.btnBankruptPlay2.UseVisualStyleBackColor = True
        Me.btnBankruptPlay2.Visible = False
        '
        'btnAddPlay2
        '
        Me.btnAddPlay2.Enabled = False
        Me.btnAddPlay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPlay2.Location = New System.Drawing.Point(250, 533)
        Me.btnAddPlay2.Name = "btnAddPlay2"
        Me.btnAddPlay2.Size = New System.Drawing.Size(71, 36)
        Me.btnAddPlay2.TabIndex = 22
        Me.btnAddPlay2.Text = "+"
        Me.btnAddPlay2.UseVisualStyleBackColor = True
        '
        'lblPlay2
        '
        Me.lblPlay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlay2.Location = New System.Drawing.Point(253, 490)
        Me.lblPlay2.Name = "lblPlay2"
        Me.lblPlay2.Size = New System.Drawing.Size(145, 40)
        Me.lblPlay2.TabIndex = 21
        Me.lblPlay2.Text = "$0"
        Me.lblPlay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDescPlay2
        '
        Me.lblDescPlay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescPlay2.Location = New System.Drawing.Point(253, 452)
        Me.lblDescPlay2.Name = "lblDescPlay2"
        Me.lblDescPlay2.Size = New System.Drawing.Size(145, 40)
        Me.lblDescPlay2.TabIndex = 20
        Me.lblDescPlay2.Text = "Player 2:"
        Me.lblDescPlay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGuessedLetters
        '
        Me.lblGuessedLetters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGuessedLetters.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuessedLetters.Location = New System.Drawing.Point(691, 490)
        Me.lblGuessedLetters.Name = "lblGuessedLetters"
        Me.lblGuessedLetters.Size = New System.Drawing.Size(334, 73)
        Me.lblGuessedLetters.TabIndex = 24
        Me.lblGuessedLetters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDescGuessedLetters
        '
        Me.lblDescGuessedLetters.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescGuessedLetters.Location = New System.Drawing.Point(687, 465)
        Me.lblDescGuessedLetters.Name = "lblDescGuessedLetters"
        Me.lblDescGuessedLetters.Size = New System.Drawing.Size(135, 25)
        Me.lblDescGuessedLetters.TabIndex = 25
        Me.lblDescGuessedLetters.Text = "Letters Guessed:"
        Me.lblDescGuessedLetters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer2
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 621)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblDescGuessedLetters)
        Me.Controls.Add(Me.lblGuessedLetters)
        Me.Controls.Add(Me.btnBankruptPlay2)
        Me.Controls.Add(Me.btnAddPlay2)
        Me.Controls.Add(Me.lblPlay2)
        Me.Controls.Add(Me.lblDescPlay2)
        Me.Controls.Add(Me.lblRanWord)
        Me.Controls.Add(Me.txtGuess)
        Me.Controls.Add(Me.lstPhrases)
        Me.Controls.Add(Me.btnGuess)
        Me.Controls.Add(Me.btnBankruptPlay1)
        Me.Controls.Add(Me.btnAddPlay1)
        Me.Controls.Add(Me.lblPlay1)
        Me.Controls.Add(Me.lblDescPlay1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblWheel3)
        Me.Controls.Add(Me.lblWheel2)
        Me.Controls.Add(Me.lstMoney)
        Me.Controls.Add(Me.lblWheel)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = """Wheel"" of Fortune"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnPlay As Button
    Friend WithEvents lblWheel As Label
    Friend WithEvents lstMoney As ListBox
    Friend WithEvents lblWheel2 As Label
    Friend WithEvents lblWheel3 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblDescPlay1 As Label
    Friend WithEvents lblPlay1 As Label
    Friend WithEvents btnAddPlay1 As Button
    Friend WithEvents btnBankruptPlay1 As Button
    Friend WithEvents btnGuess As Button
    Friend WithEvents lstPhrases As ListBox
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuOpen As ToolStripMenuItem
    Friend WithEvents txtGuess As TextBox
    Friend WithEvents lblRanWord As Label
    Friend WithEvents btnBankruptPlay2 As Button
    Friend WithEvents btnAddPlay2 As Button
    Friend WithEvents lblPlay2 As Label
    Friend WithEvents lblDescPlay2 As Label
    Friend WithEvents lblGuessedLetters As Label
    Friend WithEvents lblDescGuessedLetters As Label
    Friend WithEvents Timer2 As Timer
End Class
