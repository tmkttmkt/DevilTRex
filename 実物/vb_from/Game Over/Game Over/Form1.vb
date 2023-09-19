Public Class Form1
    Public count As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim buttonFlat As FlatButtonAppearance = Button1.FlatAppearance
        buttonFlat.BorderColor = Color.Gray
        Timer1.Start()
        AxWindowsMediaPlayer1.URL = "terano3.mp4"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Process.Start("start2.exe")
            Application.Exit()
        Catch ex As Exception
            MessageBox.Show("ファイルが開けませんでした:" & ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        count += 1
        If count >= 48 Then
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
            If count = 70 Then
                Timer1.Stop()
                PictureBox1.Visible = True
                Button1.Visible = True
            End If
        End If
    End Sub
End Class
