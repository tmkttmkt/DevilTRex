Public Class Form2
    Dim count As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        PictureBox1.Image = Image.FromFile("T3.png")
        AxWindowsMediaPlayer1.URL = "T5.mp4"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        count += 1
        Label1.Text = Str(count)
        Select Case count
            Case 30 To 59
                PictureBox1.Image = Image.FromFile("T0.png")
            Case 60 To 89
                PictureBox1.Image = Image.FromFile("T1.png")
            Case 90 To 119
                PictureBox1.Image = Image.FromFile("T2.png")
            Case 120 To 157
                PictureBox1.Visible = False
                AxWindowsMediaPlayer1.Visible = True
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Case 158 To 218
                PictureBox1.Visible = False
                AxWindowsMediaPlayer1.Visible = True
                AxWindowsMediaPlayer1.Ctlcontrols.play()
        End Select
    End Sub
End Class