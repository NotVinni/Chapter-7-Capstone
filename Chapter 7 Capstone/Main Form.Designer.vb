<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.lblWheel = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblWheel2 = New System.Windows.Forms.Label()
        Me.lblWheel3 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDescTeam1 = New System.Windows.Forms.Label()
        Me.lblTeam1 = New System.Windows.Forms.Label()
        Me.btnAddTeam1 = New System.Windows.Forms.Button()
        Me.btnSubTeam1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(309, 12)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(112, 40)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "&Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'lblWheel
        '
        Me.lblWheel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWheel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWheel.Location = New System.Drawing.Point(12, 12)
        Me.lblWheel.Name = "lblWheel"
        Me.lblWheel.Size = New System.Drawing.Size(145, 40)
        Me.lblWheel.TabIndex = 1
        Me.lblWheel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"1,000", "5,000", "2,000", "10,000", "Skip", "2,000", "2,000", "1,000", "1,000", "Bankrupt", "5,000", "2,000", "Skip", "1,000", "1,000", "1,000", "Skip", "5,000", "1,000", "1,000", "Bankrupt", "2,000", "1,000", "1,000", "2,000"})
        Me.ListBox1.Location = New System.Drawing.Point(225, 98)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(134, 147)
        Me.ListBox1.TabIndex = 5
        Me.ListBox1.Visible = False
        '
        'lblWheel2
        '
        Me.lblWheel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWheel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWheel2.Location = New System.Drawing.Point(12, 52)
        Me.lblWheel2.Name = "lblWheel2"
        Me.lblWheel2.Size = New System.Drawing.Size(145, 40)
        Me.lblWheel2.TabIndex = 6
        Me.lblWheel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWheel3
        '
        Me.lblWheel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWheel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWheel3.Location = New System.Drawing.Point(12, 92)
        Me.lblWheel3.Name = "lblWheel3"
        Me.lblWheel3.Size = New System.Drawing.Size(145, 40)
        Me.lblWheel3.TabIndex = 7
        Me.lblWheel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(443, 228)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 36)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(163, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'lblDescTeam1
        '
        Me.lblDescTeam1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescTeam1.Location = New System.Drawing.Point(12, 153)
        Me.lblDescTeam1.Name = "lblDescTeam1"
        Me.lblDescTeam1.Size = New System.Drawing.Size(145, 40)
        Me.lblDescTeam1.TabIndex = 10
        Me.lblDescTeam1.Text = "Team 1:"
        Me.lblDescTeam1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTeam1
        '
        Me.lblTeam1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam1.Location = New System.Drawing.Point(12, 191)
        Me.lblTeam1.Name = "lblTeam1"
        Me.lblTeam1.Size = New System.Drawing.Size(145, 40)
        Me.lblTeam1.TabIndex = 11
        Me.lblTeam1.Text = "$0"
        Me.lblTeam1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddTeam1
        '
        Me.btnAddTeam1.Enabled = False
        Me.btnAddTeam1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTeam1.Location = New System.Drawing.Point(18, 234)
        Me.btnAddTeam1.Name = "btnAddTeam1"
        Me.btnAddTeam1.Size = New System.Drawing.Size(71, 36)
        Me.btnAddTeam1.TabIndex = 12
        Me.btnAddTeam1.Text = "+"
        Me.btnAddTeam1.UseVisualStyleBackColor = True
        '
        'btnSubTeam1
        '
        Me.btnSubTeam1.Enabled = False
        Me.btnSubTeam1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubTeam1.Location = New System.Drawing.Point(95, 234)
        Me.btnSubTeam1.Name = "btnSubTeam1"
        Me.btnSubTeam1.Size = New System.Drawing.Size(71, 36)
        Me.btnSubTeam1.TabIndex = 13
        Me.btnSubTeam1.Text = "-"
        Me.btnSubTeam1.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 307)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSubTeam1)
        Me.Controls.Add(Me.btnAddTeam1)
        Me.Controls.Add(Me.lblTeam1)
        Me.Controls.Add(Me.lblDescTeam1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblWheel3)
        Me.Controls.Add(Me.lblWheel2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.lblWheel)
        Me.Controls.Add(Me.btnPlay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wheel of Fortune"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnPlay As Button
    Friend WithEvents lblWheel As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lblWheel2 As Label
    Friend WithEvents lblWheel3 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblDescTeam1 As Label
    Friend WithEvents lblTeam1 As Label
    Friend WithEvents btnAddTeam1 As Button
    Friend WithEvents btnSubTeam1 As Button
End Class
