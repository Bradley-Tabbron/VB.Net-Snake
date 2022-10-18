Public Class FrmSnake
    Private snakebits As ArrayList = New ArrayList
    Private direction As String
    Private dot As Label = New Label
    Private hsarray As ArrayList = New ArrayList
    Private n As Integer = 0






    Private Sub FrmSnake_Load(sender As Object, e As EventArgs) Handles Me.Load
        snakebits.Add(Snake1)
        snakebits.Add(Snake2)
        snakebits.Add(Snake3)
        direction = "R"
        generatedot()
        Dim file As System.IO.StreamReader
        file = My.Computer.FileSystem.OpenTextFileReader("C:\Users\Bradley\Documents\Visual Studio 2015\Projects\WindowsApplication1\Highscores.txt")
        Do Until file.EndOfStream
            Dim fileitem, initials, hscore As String
            fileitem = file.ReadLine()
            If Not fileitem = "" Then
                initials = Microsoft.VisualBasic.Left(fileitem, 15)
                hscore = Microsoft.VisualBasic.Right(fileitem, fileitem.Length - 16)
                hsarray.Add(hscore)

            End If
        Loop
        file.Close()
        sort()
        hsarray.Reverse()
        highscore.Text = hsarray(0)
        Timersnakespeed.Start()
        If sez = True Then
            Timersez.Start()
        End If

    End Sub

    Private Sub Timersnakespeed_Tick(sender As Object, e As EventArgs) Handles Timersnakespeed.Tick
        movesnakebits(direction)

        If Snake1.Location = dot.Location Then
            adddottosnake()
        End If

        Dim n As Integer = 1
        Dim snakeval As Boolean = True
        Do Until n = snakebits.Count - 1

            If Snake1.Location = snakebits(n).location Then
                snakeval = False

            End If
            n = n + 1

        Loop
        If snakeval = False Then
            Timersnakespeed.Stop()
            Timer1.Stop()
            showgameoverscreen()
        End If
        If Snake1.Location.X = 1500 Then
            Timersnakespeed.Stop()
            showgameoverscreen()
        ElseIf Snake1.Location.X = -50 Then
            Timersnakespeed.Stop()
            showgameoverscreen()
        ElseIf Snake1.Location.Y = 0 Then
            Timersnakespeed.Stop()
            showgameoverscreen()
        ElseIf Snake1.Location.Y = 800 Then
            Timersnakespeed.Stop()
            showgameoverscreen()
        End If
        Timer1.Enabled = False

    End Sub
    Private Sub movesnakebits(direction As String)
        Dim n As Integer = snakebits.Count
        Do Until n = 1
            Dim back As Control = snakebits(n - 1)
            Dim front As Control = snakebits(n - 2)
            back.Location = front.Location
            n = n - 1
        Loop
        If direction = "R" Then
            Snake1.Location = New Point(Snake1.Location.X + 50, Snake1.Location.Y)
        ElseIf direction = "L" Then
            Snake1.Location = New Point(Snake1.Location.X - 50, Snake1.Location.Y)
        ElseIf direction = "U" Then
            Snake1.Location = New Point(Snake1.Location.X, Snake1.Location.Y - 50)
        Else
            Snake1.Location = New Point(Snake1.Location.X, Snake1.Location.Y + 50)
        End If

    End Sub

    Private Sub FrmSnake_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Not Timer1.Enabled = True Then
            If e.KeyCode = Keys.A Or e.KeyCode = Keys.Left Then
                If Not direction = "R" Then
                    direction = "L"
                End If
            ElseIf e.KeyCode = Keys.W Or e.KeyCode = Keys.Up Then
                If Not direction = "D" Then
                    direction = "U"

                End If
            ElseIf e.KeyCode = Keys.S Or e.KeyCode = Keys.Down Then
                If Not direction = "U" Then
                    direction = "D"

                End If
            ElseIf e.KeyCode - Keys.E Or Keys.Right Then
                If Not direction = "L" Then
                    direction = "R"

                End If

            End If
            Timer1.Interval = Timersnakespeed.Interval
            Timer1.Start()
        End If

    End Sub
    Sub generatedot()
        Dim dotx As Integer
        Dim doty As Integer
        Dim x As Random = New Random
        Dim y As Random = New Random
        Dim xval As Boolean = False
        Dim yval As Boolean = False
        Do Until xval = True
            dotx = x.Next(0, 29)
            dotx = dotx * 50
            Dim n As Integer = 0
            Dim livedot As Label = snakebits(n)
            If dotx = livedot.Location.X Then
                xval = False
            Else
                xval = True
            End If
        Loop
        Do Until yval = True
            doty = y.Next(1, 15)
            doty = doty * 50
            Dim n As Integer = 0
            Dim livedot As Label = snakebits(n)
            If doty = livedot.Location.Y Then
                yval = False
            Else
                yval = True
            End If
        Loop
        dot.Location = New Point(dotx, doty)
        dot.Width = 50
        dot.Height = 50
        dot.BackColor = Color.White
        dot.Text = ""
        dot.Name = "Snake" + (snakebits.Count).ToString
        Me.Controls.Add(dot)


    End Sub
    Sub adddottosnake()
        dot.Name = "Snake" + (snakebits.Count).ToString
        snakebits.Add(dot)
        Dim n As Integer = snakebits.Count
        Dim back As Control = snakebits(n - 1)
        Dim front As Control = snakebits(n - 2)
        If direction = "R" Then
            back.Location = New Point(front.Location.X - 50, front.Location.Y)
        ElseIf direction = "L" Then
            back.Location = New Point(front.Location.X + 50, front.Location.Y)
        ElseIf direction = "U" Then
            back.Location = New Point(front.Location.X, front.Location.Y + 50)
        Else
            back.Location = New Point(front.Location.X, front.Location.Y - 50)
        End If
        score.Text = CInt(score.Text) + 100
        If Not highscore.Text > CInt(score.Text) Then
            highscore.Text = score.Text
        End If
        Timersnakespeed.Interval = Timersnakespeed.Interval - Timersnakespeed.Interval / 20

        dot = New Label
        generatedot()

    End Sub

    Private Sub showgameoverscreen()
        Timersez.Stop()
        Gameoverscreen.Visible = True

        goscore.Text = score.Text
        Initial1.Focus()

    End Sub

    Private Sub Initial1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Initial1.KeyPress
        If Asc(e.KeyChar) = 8 Then
            Initial1.Text = "_"
            Initial1.Focus()
        Else
            Initial1.Text = e.KeyChar
            Initial2.Focus()
        End If
    End Sub

    Private Sub Initial2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Initial2.KeyPress
        If Asc(e.KeyChar) = 8 Then
            Initial2.Text = "_"
            Initial1.Focus()
        Else
            Initial2.Text = e.KeyChar
            Initial3.Focus()
        End If
    End Sub

    Private Sub Initial3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Initial3.KeyPress
        If Asc(e.KeyChar) = 8 Then
            Initial3.Text = "_"
            Initial2.Focus()
        Else
            Initial3.Text = e.KeyChar
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\Bradley\Documents\Visual Studio 2015\Projects\WindowsApplication1\Highscores.txt", True)
            file.WriteLine(Initial1.Text + Initial2.Text + Initial3.Text + "             " + score.Text)
            file.Close()
            Opening.Show()
            Me.Close()
        End If
    End Sub
    Private Sub sort()
        Dim swaps As Boolean = True
        While swaps = True
            swaps = False
            For i As Integer = 0 To hsarray.Count - 2
                If CInt(hsarray(i)) > CInt(hsarray(i + 1)) Then
                    Dim temp As Integer = CInt(hsarray(i + 1))
                    hsarray(i + 1) = CInt(hsarray(i))
                    hsarray(i) = temp
                    swaps = True
                End If
            Next
        End While
    End Sub

    Private Sub Timersez_Tick(sender As Object, e As EventArgs) Handles Timersez.Tick

        updatecolour(n)
    End Sub
    Private Sub updatecolour(num1 As Integer)
        If num1 = 0 Then
            Me.BackColor = Color.Black
        ElseIf num1 = 1 Then
            Me.BackColor = Color.White
        ElseIf num1 = 2 Then
            Me.BackColor = Color.Blue
        ElseIf num1 = 3 Then
            Me.BackColor = Color.Red
        ElseIf num1 = 4 Then
            Me.BackColor = Color.Yellow
        ElseIf num1 = 5 Then
            Me.BackColor = Color.Green
        ElseIf num1 = 6 Then
            Me.BackColor = Color.Orange
        ElseIf num1 = 7 Then
            Me.BackColor = Color.Purple
        ElseIf num1 = 8 Then
            Me.BackColor = Color.LightBlue
        ElseIf num1 = 9 Then
            Me.BackColor = Color.Pink
        ElseIf num1 = 10 Then
            Me.BackColor = Color.Gray
            n = -1
        End If
        n = n + 1
    End Sub

End Class
