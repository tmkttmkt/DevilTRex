Public Class Form1
    Public count As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
        AxWindowsMediaPlayer1.URL = "Game Over.mp4"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        count += 1
        If count >= 48 Then
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
            If count = 60 Then
                Timer1.Stop()
                Button1.Visible = True
            End If
        End If
    End Sub
End Class
