<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSnake
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSnake))
        Me.Snake3 = New System.Windows.Forms.Label()
        Me.Snake1 = New System.Windows.Forms.Label()
        Me.Snake2 = New System.Windows.Forms.Label()
        Me.Timersnakespeed = New System.Windows.Forms.Timer(Me.components)
        Me.Scorebar = New System.Windows.Forms.Panel()
        Me.score = New System.Windows.Forms.Label()
        Me.highscore = New System.Windows.Forms.Label()
        Me.sc = New System.Windows.Forms.Label()
        Me.hs = New System.Windows.Forms.Label()
        Me.Gameoverscreen = New System.Windows.Forms.Panel()
        Me.Initial3 = New System.Windows.Forms.TextBox()
        Me.Initial2 = New System.Windows.Forms.TextBox()
        Me.Initial1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.goscore = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gameovermessage = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timersez = New System.Windows.Forms.Timer(Me.components)
        Me.Scorebar.SuspendLayout()
        Me.Gameoverscreen.SuspendLayout()
        Me.SuspendLayout()
        '
        'Snake3
        '
        Me.Snake3.BackColor = System.Drawing.Color.White
        Me.Snake3.Location = New System.Drawing.Point(0, 50)
        Me.Snake3.Margin = New System.Windows.Forms.Padding(0)
        Me.Snake3.Name = "Snake3"
        Me.Snake3.Size = New System.Drawing.Size(50, 50)
        Me.Snake3.TabIndex = 0
        '
        'Snake1
        '
        Me.Snake1.BackColor = System.Drawing.Color.White
        Me.Snake1.Location = New System.Drawing.Point(100, 50)
        Me.Snake1.Margin = New System.Windows.Forms.Padding(0)
        Me.Snake1.Name = "Snake1"
        Me.Snake1.Size = New System.Drawing.Size(50, 50)
        Me.Snake1.TabIndex = 1
        '
        'Snake2
        '
        Me.Snake2.BackColor = System.Drawing.Color.White
        Me.Snake2.Location = New System.Drawing.Point(50, 50)
        Me.Snake2.Margin = New System.Windows.Forms.Padding(0)
        Me.Snake2.Name = "Snake2"
        Me.Snake2.Size = New System.Drawing.Size(50, 50)
        Me.Snake2.TabIndex = 2
        '
        'Timersnakespeed
        '
        Me.Timersnakespeed.Interval = 500
        '
        'Scorebar
        '
        Me.Scorebar.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.Scorebar.AutoSize = True
        Me.Scorebar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Scorebar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Scorebar.Controls.Add(Me.score)
        Me.Scorebar.Controls.Add(Me.highscore)
        Me.Scorebar.Controls.Add(Me.sc)
        Me.Scorebar.Controls.Add(Me.hs)
        Me.Scorebar.Location = New System.Drawing.Point(0, 0)
        Me.Scorebar.Margin = New System.Windows.Forms.Padding(0)
        Me.Scorebar.Name = "Scorebar"
        Me.Scorebar.Size = New System.Drawing.Size(1600, 50)
        Me.Scorebar.TabIndex = 3
        '
        'score
        '
        Me.score.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.score.AutoSize = True
        Me.score.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.score.ForeColor = System.Drawing.Color.White
        Me.score.Location = New System.Drawing.Point(1100, 0)
        Me.score.Margin = New System.Windows.Forms.Padding(0)
        Me.score.Name = "score"
        Me.score.Size = New System.Drawing.Size(34, 37)
        Me.score.TabIndex = 3
        Me.score.Text = "0"
        '
        'highscore
        '
        Me.highscore.AutoSize = True
        Me.highscore.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.highscore.ForeColor = System.Drawing.Color.White
        Me.highscore.Location = New System.Drawing.Point(300, 0)
        Me.highscore.Margin = New System.Windows.Forms.Padding(0)
        Me.highscore.Name = "highscore"
        Me.highscore.Size = New System.Drawing.Size(34, 37)
        Me.highscore.TabIndex = 2
        Me.highscore.Text = "0"
        '
        'sc
        '
        Me.sc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sc.AutoSize = True
        Me.sc.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc.ForeColor = System.Drawing.Color.White
        Me.sc.Location = New System.Drawing.Point(800, 0)
        Me.sc.Margin = New System.Windows.Forms.Padding(0)
        Me.sc.Name = "sc"
        Me.sc.Size = New System.Drawing.Size(132, 37)
        Me.sc.TabIndex = 1
        Me.sc.Text = "SCORE:"
        '
        'hs
        '
        Me.hs.AutoSize = True
        Me.hs.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hs.ForeColor = System.Drawing.Color.White
        Me.hs.Location = New System.Drawing.Point(0, 0)
        Me.hs.Margin = New System.Windows.Forms.Padding(0)
        Me.hs.Name = "hs"
        Me.hs.Size = New System.Drawing.Size(215, 37)
        Me.hs.TabIndex = 0
        Me.hs.Text = "HIGHSCORE:"
        '
        'Gameoverscreen
        '
        Me.Gameoverscreen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Gameoverscreen.Controls.Add(Me.Initial3)
        Me.Gameoverscreen.Controls.Add(Me.Initial2)
        Me.Gameoverscreen.Controls.Add(Me.Initial1)
        Me.Gameoverscreen.Controls.Add(Me.Label2)
        Me.Gameoverscreen.Controls.Add(Me.goscore)
        Me.Gameoverscreen.Controls.Add(Me.Label1)
        Me.Gameoverscreen.Controls.Add(Me.gameovermessage)
        Me.Gameoverscreen.Location = New System.Drawing.Point(350, 175)
        Me.Gameoverscreen.Name = "Gameoverscreen"
        Me.Gameoverscreen.Size = New System.Drawing.Size(800, 400)
        Me.Gameoverscreen.TabIndex = 4
        Me.Gameoverscreen.Visible = False
        '
        'Initial3
        '
        Me.Initial3.BackColor = System.Drawing.Color.Black
        Me.Initial3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Initial3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Initial3.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Initial3.ForeColor = System.Drawing.Color.White
        Me.Initial3.Location = New System.Drawing.Point(459, 271)
        Me.Initial3.MaxLength = 1
        Me.Initial3.Name = "Initial3"
        Me.Initial3.Size = New System.Drawing.Size(71, 92)
        Me.Initial3.TabIndex = 6
        Me.Initial3.Text = "_"
        Me.Initial3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Initial2
        '
        Me.Initial2.BackColor = System.Drawing.Color.Black
        Me.Initial2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Initial2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Initial2.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Initial2.ForeColor = System.Drawing.Color.White
        Me.Initial2.Location = New System.Drawing.Point(349, 271)
        Me.Initial2.MaxLength = 1
        Me.Initial2.Name = "Initial2"
        Me.Initial2.Size = New System.Drawing.Size(71, 92)
        Me.Initial2.TabIndex = 5
        Me.Initial2.Text = "_"
        Me.Initial2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Initial1
        '
        Me.Initial1.BackColor = System.Drawing.Color.Black
        Me.Initial1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Initial1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Initial1.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Initial1.ForeColor = System.Drawing.Color.White
        Me.Initial1.Location = New System.Drawing.Point(241, 271)
        Me.Initial1.MaxLength = 1
        Me.Initial1.Name = "Initial1"
        Me.Initial1.Size = New System.Drawing.Size(71, 92)
        Me.Initial1.TabIndex = 4
        Me.Initial1.Text = "_"
        Me.Initial1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(168, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(462, 48)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PLEASE ENTER YOUR INITIALS"
        '
        'goscore
        '
        Me.goscore.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.goscore.ForeColor = System.Drawing.Color.White
        Me.goscore.Location = New System.Drawing.Point(435, 128)
        Me.goscore.Name = "goscore"
        Me.goscore.Size = New System.Drawing.Size(296, 48)
        Me.goscore.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(143, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 48)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "YOUR SCORE WAS:"
        '
        'gameovermessage
        '
        Me.gameovermessage.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gameovermessage.ForeColor = System.Drawing.Color.White
        Me.gameovermessage.Location = New System.Drawing.Point(23, 18)
        Me.gameovermessage.Name = "gameovermessage"
        Me.gameovermessage.Size = New System.Drawing.Size(762, 93)
        Me.gameovermessage.TabIndex = 0
        Me.gameovermessage.Text = "GAME OVER"
        Me.gameovermessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timersez
        '
        '
        'FrmSnake
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1482, 753)
        Me.Controls.Add(Me.Gameoverscreen)
        Me.Controls.Add(Me.Scorebar)
        Me.Controls.Add(Me.Snake2)
        Me.Controls.Add(Me.Snake1)
        Me.Controls.Add(Me.Snake3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "FrmSnake"
        Me.Text = "Snake"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Scorebar.ResumeLayout(False)
        Me.Scorebar.PerformLayout()
        Me.Gameoverscreen.ResumeLayout(False)
        Me.Gameoverscreen.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Snake3 As Label
    Friend WithEvents Snake1 As Label
    Friend WithEvents Snake2 As Label
    Friend WithEvents Timersnakespeed As Timer
    Friend WithEvents Scorebar As Panel
    Friend WithEvents score As Label
    Friend WithEvents highscore As Label
    Friend WithEvents sc As Label
    Friend WithEvents hs As Label
    Friend WithEvents Gameoverscreen As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents gameovermessage As Label
    Friend WithEvents Initial3 As TextBox
    Friend WithEvents Initial2 As TextBox
    Friend WithEvents Initial1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents goscore As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timersez As Timer
End Class
