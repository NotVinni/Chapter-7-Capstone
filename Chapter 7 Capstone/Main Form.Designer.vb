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
        Me.grpLetters = New System.Windows.Forms.GroupBox()
        Me.btnX = New System.Windows.Forms.Button()
        Me.btnP = New System.Windows.Forms.Button()
        Me.btnS = New System.Windows.Forms.Button()
        Me.btnF = New System.Windows.Forms.Button()
        Me.btnU = New System.Windows.Forms.Button()
        Me.btnM = New System.Windows.Forms.Button()
        Me.btnI = New System.Windows.Forms.Button()
        Me.btnW = New System.Windows.Forms.Button()
        Me.btnO = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnT = New System.Windows.Forms.Button()
        Me.btnE = New System.Windows.Forms.Button()
        Me.btnZ = New System.Windows.Forms.Button()
        Me.btnR = New System.Windows.Forms.Button()
        Me.btnJ = New System.Windows.Forms.Button()
        Me.btnV = New System.Windows.Forms.Button()
        Me.btnN = New System.Windows.Forms.Button()
        Me.btnH = New System.Windows.Forms.Button()
        Me.btnY = New System.Windows.Forms.Button()
        Me.btnQ = New System.Windows.Forms.Button()
        Me.btnD = New System.Windows.Forms.Button()
        Me.btnL = New System.Windows.Forms.Button()
        Me.btnG = New System.Windows.Forms.Button()
        Me.btnK = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.btnA = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.grpLetters.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(407, 32)
        Me.btnPlay.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(149, 49)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "&Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'lblWheel
        '
        Me.lblWheel.BackColor = System.Drawing.Color.Red
        Me.lblWheel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWheel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWheel.Location = New System.Drawing.Point(11, 32)
        Me.lblWheel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWheel.Name = "lblWheel"
        Me.lblWheel.Size = New System.Drawing.Size(193, 49)
        Me.lblWheel.TabIndex = 1
        Me.lblWheel.Text = "Bankrupt"
        Me.lblWheel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstMoney
        '
        Me.lstMoney.FormattingEnabled = True
        Me.lstMoney.ItemHeight = 16
        Me.lstMoney.Items.AddRange(New Object() {"1,000", "5,000", "2,000", "10,000", "Skip", "2,000", "2,000", "1,000", "1,000", "Bankrupt", "5,000", "2,000", "Skip", "1,000", "1,000", "1,000", "Skip", "5,000", "1,000", "1,000", "Bankrupt", "2,000", "1,000", "1,000", "2,000"})
        Me.lstMoney.Location = New System.Drawing.Point(1375, 32)
        Me.lstMoney.Margin = New System.Windows.Forms.Padding(4)
        Me.lstMoney.Name = "lstMoney"
        Me.lstMoney.Size = New System.Drawing.Size(177, 180)
        Me.lstMoney.TabIndex = 5
        Me.lstMoney.Visible = False
        '
        'lblWheel2
        '
        Me.lblWheel2.BackColor = System.Drawing.Color.Lime
        Me.lblWheel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWheel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWheel2.Location = New System.Drawing.Point(11, 81)
        Me.lblWheel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWheel2.Name = "lblWheel2"
        Me.lblWheel2.Size = New System.Drawing.Size(193, 49)
        Me.lblWheel2.TabIndex = 6
        Me.lblWheel2.Text = "$5000"
        Me.lblWheel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWheel3
        '
        Me.lblWheel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblWheel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWheel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWheel3.Location = New System.Drawing.Point(11, 130)
        Me.lblWheel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWheel3.Name = "lblWheel3"
        Me.lblWheel3.Size = New System.Drawing.Size(193, 49)
        Me.lblWheel3.TabIndex = 7
        Me.lblWheel3.Text = "$2000"
        Me.lblWheel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(1411, 656)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(143, 44)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(212, 81)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'lblDescPlay1
        '
        Me.lblDescPlay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescPlay1.Location = New System.Drawing.Point(21, 556)
        Me.lblDescPlay1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescPlay1.Name = "lblDescPlay1"
        Me.lblDescPlay1.Size = New System.Drawing.Size(193, 49)
        Me.lblDescPlay1.TabIndex = 10
        Me.lblDescPlay1.Text = "Player 1:"
        Me.lblDescPlay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlay1
        '
        Me.lblPlay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlay1.Location = New System.Drawing.Point(21, 603)
        Me.lblPlay1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlay1.Name = "lblPlay1"
        Me.lblPlay1.Size = New System.Drawing.Size(193, 49)
        Me.lblPlay1.TabIndex = 11
        Me.lblPlay1.Text = "$0"
        Me.lblPlay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddPlay1
        '
        Me.btnAddPlay1.Enabled = False
        Me.btnAddPlay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPlay1.Location = New System.Drawing.Point(17, 656)
        Me.btnAddPlay1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddPlay1.Name = "btnAddPlay1"
        Me.btnAddPlay1.Size = New System.Drawing.Size(95, 44)
        Me.btnAddPlay1.TabIndex = 12
        Me.btnAddPlay1.Text = "+"
        Me.btnAddPlay1.UseVisualStyleBackColor = True
        '
        'btnBankruptPlay1
        '
        Me.btnBankruptPlay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBankruptPlay1.Location = New System.Drawing.Point(120, 656)
        Me.btnBankruptPlay1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBankruptPlay1.Name = "btnBankruptPlay1"
        Me.btnBankruptPlay1.Size = New System.Drawing.Size(95, 44)
        Me.btnBankruptPlay1.TabIndex = 14
        Me.btnBankruptPlay1.Text = "&Bankrupt"
        Me.btnBankruptPlay1.UseVisualStyleBackColor = True
        Me.btnBankruptPlay1.Visible = False
        '
        'btnGuess
        '
        Me.btnGuess.Location = New System.Drawing.Point(407, 164)
        Me.btnGuess.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(149, 49)
        Me.btnGuess.TabIndex = 15
        Me.btnGuess.Text = "&Guess"
        Me.btnGuess.UseVisualStyleBackColor = True
        '
        'lstPhrases
        '
        Me.lstPhrases.FormattingEnabled = True
        Me.lstPhrases.ItemHeight = 16
        Me.lstPhrases.Location = New System.Drawing.Point(1189, 41)
        Me.lstPhrases.Margin = New System.Windows.Forms.Padding(4)
        Me.lstPhrases.Name = "lstPhrases"
        Me.lstPhrases.Size = New System.Drawing.Size(176, 164)
        Me.lstPhrases.TabIndex = 16
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1575, 28)
        Me.MenuStrip.TabIndex = 17
        Me.MenuStrip.Text = "Open"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuOpen})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'menuOpen
        '
        Me.menuOpen.Name = "menuOpen"
        Me.menuOpen.Size = New System.Drawing.Size(155, 26)
        Me.menuOpen.Text = "Open File"
        '
        'txtGuess
        '
        Me.txtGuess.Location = New System.Drawing.Point(676, 164)
        Me.txtGuess.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGuess.Name = "txtGuess"
        Me.txtGuess.Size = New System.Drawing.Size(445, 22)
        Me.txtGuess.TabIndex = 18
        '
        'lblRanWord
        '
        Me.lblRanWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRanWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRanWord.Location = New System.Drawing.Point(676, 41)
        Me.lblRanWord.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRanWord.Name = "lblRanWord"
        Me.lblRanWord.Size = New System.Drawing.Size(445, 89)
        Me.lblRanWord.TabIndex = 19
        Me.lblRanWord.Text = "Word:"
        Me.lblRanWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBankruptPlay2
        '
        Me.btnBankruptPlay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBankruptPlay2.Location = New System.Drawing.Point(436, 656)
        Me.btnBankruptPlay2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBankruptPlay2.Name = "btnBankruptPlay2"
        Me.btnBankruptPlay2.Size = New System.Drawing.Size(95, 44)
        Me.btnBankruptPlay2.TabIndex = 23
        Me.btnBankruptPlay2.Text = "&Bankrupt"
        Me.btnBankruptPlay2.UseVisualStyleBackColor = True
        Me.btnBankruptPlay2.Visible = False
        '
        'btnAddPlay2
        '
        Me.btnAddPlay2.Enabled = False
        Me.btnAddPlay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPlay2.Location = New System.Drawing.Point(333, 656)
        Me.btnAddPlay2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddPlay2.Name = "btnAddPlay2"
        Me.btnAddPlay2.Size = New System.Drawing.Size(95, 44)
        Me.btnAddPlay2.TabIndex = 22
        Me.btnAddPlay2.Text = "+"
        Me.btnAddPlay2.UseVisualStyleBackColor = True
        '
        'lblPlay2
        '
        Me.lblPlay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlay2.Location = New System.Drawing.Point(337, 603)
        Me.lblPlay2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlay2.Name = "lblPlay2"
        Me.lblPlay2.Size = New System.Drawing.Size(193, 49)
        Me.lblPlay2.TabIndex = 21
        Me.lblPlay2.Text = "$0"
        Me.lblPlay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDescPlay2
        '
        Me.lblDescPlay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescPlay2.Location = New System.Drawing.Point(337, 556)
        Me.lblDescPlay2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescPlay2.Name = "lblDescPlay2"
        Me.lblDescPlay2.Size = New System.Drawing.Size(193, 49)
        Me.lblDescPlay2.TabIndex = 20
        Me.lblDescPlay2.Text = "Player 2:"
        Me.lblDescPlay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGuessedLetters
        '
        Me.lblGuessedLetters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGuessedLetters.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuessedLetters.Location = New System.Drawing.Point(921, 603)
        Me.lblGuessedLetters.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGuessedLetters.Name = "lblGuessedLetters"
        Me.lblGuessedLetters.Size = New System.Drawing.Size(445, 89)
        Me.lblGuessedLetters.TabIndex = 24
        Me.lblGuessedLetters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDescGuessedLetters
        '
        Me.lblDescGuessedLetters.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescGuessedLetters.Location = New System.Drawing.Point(916, 572)
        Me.lblDescGuessedLetters.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescGuessedLetters.Name = "lblDescGuessedLetters"
        Me.lblDescGuessedLetters.Size = New System.Drawing.Size(180, 31)
        Me.lblDescGuessedLetters.TabIndex = 25
        Me.lblDescGuessedLetters.Text = "Letters Guessed:"
        Me.lblDescGuessedLetters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpLetters
        '
        Me.grpLetters.Controls.Add(Me.btnX)
        Me.grpLetters.Controls.Add(Me.btnP)
        Me.grpLetters.Controls.Add(Me.btnS)
        Me.grpLetters.Controls.Add(Me.btnF)
        Me.grpLetters.Controls.Add(Me.btnU)
        Me.grpLetters.Controls.Add(Me.btnM)
        Me.grpLetters.Controls.Add(Me.btnI)
        Me.grpLetters.Controls.Add(Me.btnW)
        Me.grpLetters.Controls.Add(Me.btnO)
        Me.grpLetters.Controls.Add(Me.btnC)
        Me.grpLetters.Controls.Add(Me.btnT)
        Me.grpLetters.Controls.Add(Me.btnE)
        Me.grpLetters.Controls.Add(Me.btnZ)
        Me.grpLetters.Controls.Add(Me.btnR)
        Me.grpLetters.Controls.Add(Me.btnJ)
        Me.grpLetters.Controls.Add(Me.btnV)
        Me.grpLetters.Controls.Add(Me.btnN)
        Me.grpLetters.Controls.Add(Me.btnH)
        Me.grpLetters.Controls.Add(Me.btnY)
        Me.grpLetters.Controls.Add(Me.btnQ)
        Me.grpLetters.Controls.Add(Me.btnD)
        Me.grpLetters.Controls.Add(Me.btnL)
        Me.grpLetters.Controls.Add(Me.btnG)
        Me.grpLetters.Controls.Add(Me.btnK)
        Me.grpLetters.Controls.Add(Me.btnB)
        Me.grpLetters.Controls.Add(Me.btnA)
        Me.grpLetters.Location = New System.Drawing.Point(728, 213)
        Me.grpLetters.Name = "grpLetters"
        Me.grpLetters.Size = New System.Drawing.Size(344, 125)
        Me.grpLetters.TabIndex = 26
        Me.grpLetters.TabStop = False
        '
        'btnX
        '
        Me.btnX.Location = New System.Drawing.Point(175, 83)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(26, 25)
        Me.btnX.TabIndex = 0
        Me.btnX.Text = "X"
        Me.btnX.UseVisualStyleBackColor = True
        '
        'btnP
        '
        Me.btnP.Location = New System.Drawing.Point(175, 52)
        Me.btnP.Name = "btnP"
        Me.btnP.Size = New System.Drawing.Size(26, 25)
        Me.btnP.TabIndex = 0
        Me.btnP.Text = "P"
        Me.btnP.UseVisualStyleBackColor = True
        '
        'btnS
        '
        Me.btnS.Location = New System.Drawing.Point(273, 52)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(26, 25)
        Me.btnS.TabIndex = 0
        Me.btnS.Text = "S"
        Me.btnS.UseVisualStyleBackColor = True
        '
        'btnF
        '
        Me.btnF.Location = New System.Drawing.Point(175, 21)
        Me.btnF.Name = "btnF"
        Me.btnF.Size = New System.Drawing.Size(26, 25)
        Me.btnF.TabIndex = 0
        Me.btnF.Text = "F"
        Me.btnF.UseVisualStyleBackColor = True
        '
        'btnU
        '
        Me.btnU.Location = New System.Drawing.Point(80, 83)
        Me.btnU.Name = "btnU"
        Me.btnU.Size = New System.Drawing.Size(26, 25)
        Me.btnU.TabIndex = 0
        Me.btnU.Text = "U"
        Me.btnU.UseVisualStyleBackColor = True
        '
        'btnM
        '
        Me.btnM.Location = New System.Drawing.Point(80, 52)
        Me.btnM.Name = "btnM"
        Me.btnM.Size = New System.Drawing.Size(26, 25)
        Me.btnM.TabIndex = 0
        Me.btnM.Text = "M"
        Me.btnM.UseVisualStyleBackColor = True
        '
        'btnI
        '
        Me.btnI.Location = New System.Drawing.Point(273, 21)
        Me.btnI.Name = "btnI"
        Me.btnI.Size = New System.Drawing.Size(26, 25)
        Me.btnI.TabIndex = 0
        Me.btnI.Text = "I"
        Me.btnI.UseVisualStyleBackColor = True
        '
        'btnW
        '
        Me.btnW.Location = New System.Drawing.Point(143, 83)
        Me.btnW.Name = "btnW"
        Me.btnW.Size = New System.Drawing.Size(26, 25)
        Me.btnW.TabIndex = 0
        Me.btnW.Text = "W"
        Me.btnW.UseVisualStyleBackColor = True
        '
        'btnO
        '
        Me.btnO.Location = New System.Drawing.Point(143, 52)
        Me.btnO.Name = "btnO"
        Me.btnO.Size = New System.Drawing.Size(26, 25)
        Me.btnO.TabIndex = 0
        Me.btnO.Text = "O"
        Me.btnO.UseVisualStyleBackColor = True
        '
        'btnC
        '
        Me.btnC.Location = New System.Drawing.Point(80, 21)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(26, 25)
        Me.btnC.TabIndex = 0
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = True
        '
        'btnT
        '
        Me.btnT.Location = New System.Drawing.Point(304, 52)
        Me.btnT.Name = "btnT"
        Me.btnT.Size = New System.Drawing.Size(26, 25)
        Me.btnT.TabIndex = 0
        Me.btnT.Text = "T"
        Me.btnT.UseVisualStyleBackColor = True
        '
        'btnE
        '
        Me.btnE.Location = New System.Drawing.Point(143, 21)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(26, 25)
        Me.btnE.TabIndex = 0
        Me.btnE.Text = "E"
        Me.btnE.UseVisualStyleBackColor = True
        '
        'btnZ
        '
        Me.btnZ.Location = New System.Drawing.Point(241, 83)
        Me.btnZ.Name = "btnZ"
        Me.btnZ.Size = New System.Drawing.Size(26, 25)
        Me.btnZ.TabIndex = 0
        Me.btnZ.Text = "Z"
        Me.btnZ.UseVisualStyleBackColor = True
        '
        'btnR
        '
        Me.btnR.Location = New System.Drawing.Point(241, 52)
        Me.btnR.Name = "btnR"
        Me.btnR.Size = New System.Drawing.Size(26, 25)
        Me.btnR.TabIndex = 0
        Me.btnR.Text = "R"
        Me.btnR.UseVisualStyleBackColor = True
        '
        'btnJ
        '
        Me.btnJ.Location = New System.Drawing.Point(304, 21)
        Me.btnJ.Name = "btnJ"
        Me.btnJ.Size = New System.Drawing.Size(26, 25)
        Me.btnJ.TabIndex = 0
        Me.btnJ.Text = "J"
        Me.btnJ.UseVisualStyleBackColor = True
        '
        'btnV
        '
        Me.btnV.Location = New System.Drawing.Point(111, 83)
        Me.btnV.Name = "btnV"
        Me.btnV.Size = New System.Drawing.Size(26, 25)
        Me.btnV.TabIndex = 0
        Me.btnV.Text = "V"
        Me.btnV.UseVisualStyleBackColor = True
        '
        'btnN
        '
        Me.btnN.Location = New System.Drawing.Point(111, 52)
        Me.btnN.Name = "btnN"
        Me.btnN.Size = New System.Drawing.Size(26, 25)
        Me.btnN.TabIndex = 0
        Me.btnN.Text = "N"
        Me.btnN.UseVisualStyleBackColor = True
        '
        'btnH
        '
        Me.btnH.Location = New System.Drawing.Point(241, 21)
        Me.btnH.Name = "btnH"
        Me.btnH.Size = New System.Drawing.Size(26, 25)
        Me.btnH.TabIndex = 0
        Me.btnH.Text = "H"
        Me.btnH.UseVisualStyleBackColor = True
        '
        'btnY
        '
        Me.btnY.Location = New System.Drawing.Point(209, 83)
        Me.btnY.Name = "btnY"
        Me.btnY.Size = New System.Drawing.Size(26, 25)
        Me.btnY.TabIndex = 0
        Me.btnY.Text = "Y"
        Me.btnY.UseVisualStyleBackColor = True
        '
        'btnQ
        '
        Me.btnQ.Location = New System.Drawing.Point(209, 52)
        Me.btnQ.Name = "btnQ"
        Me.btnQ.Size = New System.Drawing.Size(26, 25)
        Me.btnQ.TabIndex = 0
        Me.btnQ.Text = "Q"
        Me.btnQ.UseVisualStyleBackColor = True
        '
        'btnD
        '
        Me.btnD.Location = New System.Drawing.Point(111, 21)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(26, 25)
        Me.btnD.TabIndex = 0
        Me.btnD.Text = "D"
        Me.btnD.UseVisualStyleBackColor = True
        '
        'btnL
        '
        Me.btnL.Location = New System.Drawing.Point(48, 52)
        Me.btnL.Name = "btnL"
        Me.btnL.Size = New System.Drawing.Size(26, 25)
        Me.btnL.TabIndex = 0
        Me.btnL.Text = "L"
        Me.btnL.UseVisualStyleBackColor = True
        '
        'btnG
        '
        Me.btnG.Location = New System.Drawing.Point(209, 21)
        Me.btnG.Name = "btnG"
        Me.btnG.Size = New System.Drawing.Size(26, 25)
        Me.btnG.TabIndex = 0
        Me.btnG.Text = "G"
        Me.btnG.UseVisualStyleBackColor = True
        '
        'btnK
        '
        Me.btnK.Location = New System.Drawing.Point(16, 52)
        Me.btnK.Name = "btnK"
        Me.btnK.Size = New System.Drawing.Size(26, 25)
        Me.btnK.TabIndex = 0
        Me.btnK.Text = "K"
        Me.btnK.UseVisualStyleBackColor = True
        '
        'btnB
        '
        Me.btnB.Location = New System.Drawing.Point(48, 21)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(26, 25)
        Me.btnB.TabIndex = 0
        Me.btnB.Text = "B"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'btnA
        '
        Me.btnA.Location = New System.Drawing.Point(16, 21)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(26, 25)
        Me.btnA.TabIndex = 0
        Me.btnA.Text = "A"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1575, 764)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpLetters)
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
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = """Wheel"" of Fortune"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.grpLetters.ResumeLayout(False)
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
    Friend WithEvents grpLetters As GroupBox
    Friend WithEvents btnX As Button
    Friend WithEvents btnP As Button
    Friend WithEvents btnS As Button
    Friend WithEvents btnF As Button
    Friend WithEvents btnU As Button
    Friend WithEvents btnM As Button
    Friend WithEvents btnI As Button
    Friend WithEvents btnW As Button
    Friend WithEvents btnO As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnT As Button
    Friend WithEvents btnE As Button
    Friend WithEvents btnZ As Button
    Friend WithEvents btnR As Button
    Friend WithEvents btnJ As Button
    Friend WithEvents btnV As Button
    Friend WithEvents btnN As Button
    Friend WithEvents btnH As Button
    Friend WithEvents btnY As Button
    Friend WithEvents btnQ As Button
    Friend WithEvents btnD As Button
    Friend WithEvents btnL As Button
    Friend WithEvents btnG As Button
    Friend WithEvents btnK As Button
    Friend WithEvents btnB As Button
    Friend WithEvents btnA As Button
End Class
