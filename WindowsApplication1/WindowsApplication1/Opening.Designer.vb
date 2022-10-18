<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Opening
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Opening))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Play = New System.Windows.Forms.Button()
        Me.ext = New System.Windows.Forms.Button()
        Me.playsez = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Black
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.Font = New System.Drawing.Font("Courier New", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 46
        Me.ListBox1.Location = New System.Drawing.Point(927, 145)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBox1.Size = New System.Drawing.Size(460, 506)
        Me.ListBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(186, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(654, 115)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SNAKE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(967, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(364, 115)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "HIGHSCORES"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(138, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(687, 123)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "* USE THE 'WASD' OR ARROW KEYS TO MOVE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(138, 289)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(687, 154)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "* EAT DOTS FOR POINTS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(138, 396)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(687, 154)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "* DON'T HIT THE WALL OR YOURSELF"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Play
        '
        Me.Play.BackColor = System.Drawing.Color.Black
        Me.Play.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Play.ForeColor = System.Drawing.Color.White
        Me.Play.Location = New System.Drawing.Point(119, 547)
        Me.Play.Name = "Play"
        Me.Play.Size = New System.Drawing.Size(205, 148)
        Me.Play.TabIndex = 6
        Me.Play.Text = "PLAY CLASSIC"
        Me.Play.UseVisualStyleBackColor = False
        '
        'ext
        '
        Me.ext.BackColor = System.Drawing.Color.Black
        Me.ext.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ext.ForeColor = System.Drawing.Color.White
        Me.ext.Location = New System.Drawing.Point(572, 547)
        Me.ext.Name = "ext"
        Me.ext.Size = New System.Drawing.Size(167, 148)
        Me.ext.TabIndex = 7
        Me.ext.Text = "EXIT"
        Me.ext.UseVisualStyleBackColor = False
        '
        'playsez
        '
        Me.playsez.BackColor = System.Drawing.Color.Black
        Me.playsez.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playsez.ForeColor = System.Drawing.Color.White
        Me.playsez.Location = New System.Drawing.Point(343, 547)
        Me.playsez.Name = "playsez"
        Me.playsez.Size = New System.Drawing.Size(205, 148)
        Me.playsez.TabIndex = 8
        Me.playsez.Text = "PLAY SEIZURE"
        Me.playsez.UseVisualStyleBackColor = False
        '
        'Opening
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1482, 753)
        Me.Controls.Add(Me.playsez)
        Me.Controls.Add(Me.ext)
        Me.Controls.Add(Me.Play)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Opening"
        Me.Text = "Snake"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Play As Button
    Friend WithEvents ext As Button
    Friend WithEvents playsez As Button
End Class
