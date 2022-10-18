
Public Class Opening

    Private hsarray As ArrayList = New ArrayList
    Private hsarrayog As ArrayList = New ArrayList


    Private Sub Play_Click(sender As Object, e As EventArgs) Handles Play.Click
        FrmSnake.Show()
        Me.Close()
        sez = False
    End Sub

    Private Sub ext_Click(sender As Object, e As EventArgs) Handles ext.Click
        Me.Close()
    End Sub

    Private Sub Opening_Load(sender As Object, e As EventArgs) Handles Me.Load
        sez = False
        Dim file As System.IO.StreamReader
        file = My.Computer.FileSystem.OpenTextFileReader("C:\Users\Bradley\Documents\Visual Studio 2015\Projects\WindowsApplication1\Highscores.txt")
        Do Until file.EndOfStream
            Dim fileitem As String
            fileitem = file.ReadLine()
            If Not fileitem = "" Then
                hsarray.Add(fileitem)


            End If
        Loop
        file.Close()
        sort()
        hsarray.Reverse()
        Dim n As Integer = 0
        For n = 0 To hsarray.Count - 1
            ListBox1.Items.Add(hsarray(n))
        Next n

    End Sub
    Private Sub sort()

        Dim swaps As Boolean = True
        While swaps = True
            swaps = False
            For i As Integer = 0 To hsarray.Count - 2
                Dim two As Integer = Microsoft.VisualBasic.Right(hsarray(i + 1), hsarray(i + 1).Length - 16)
                Dim one As Integer = Microsoft.VisualBasic.Right(hsarray(i), hsarray(i).Length - 16)
                If one > two Then

                    Dim temp = hsarray(i + 1)
                    hsarray(i + 1) = hsarray(i)
                    hsarray(i) = temp
                    swaps = True
                End If
            Next i
        End While

    End Sub

    Private Sub playsez_Click(sender As Object, e As EventArgs) Handles playsez.Click
        sez = True
        FrmSnake.Show()
        Me.Close()

    End Sub
End Class