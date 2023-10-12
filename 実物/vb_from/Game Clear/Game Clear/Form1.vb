Public Class Form1
    Public count As Integer
    Private Declare Function GetCursorPos Lib "user32.dll" (ByRef lpPoint As Point) As Boolean
    Private Declare Function PtInRect Lib "user32.dll" (ByRef lprc As Rectangle, ByVal pt As Point) As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
        AxWindowsMediaPlayer1.URL = "endrool2.mp4"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        AxWindowsMediaPlayer2.URL = "T5.mp4"
        AxWindowsMediaPlayer3.URL = "T6.mp4"
        AxWindowsMediaPlayer4.URL = "T12.mp4"
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' ボタンの位置とサイズを取得
        count += 1
        Label1.Text = Str(count)
        Label1.Visible = True
        Select Case count
            Case 30 To 59
                PictureBox1.Image = Image.FromFile("T0.png")
            Case 60 To 89
                PictureBox1.Image = Image.FromFile("T1.png")
            Case 90 To 119
                PictureBox1.Image = Image.FromFile("T2.png")
            Case 120 To 150
                PictureBox1.Visible = False
                AxWindowsMediaPlayer2.Visible = True
                AxWindowsMediaPlayer2.Ctlcontrols.play()
            Case 151 To 180
                AxWindowsMediaPlayer2.Ctlcontrols.pause()
                AxWindowsMediaPlayer2.Visible = False
                AxWindowsMediaPlayer3.Visible = True
                AxWindowsMediaPlayer3.Ctlcontrols.play()
            Case 181 To 200
                AxWindowsMediaPlayer3.Ctlcontrols.pause()
                AxWindowsMediaPlayer3.Visible = False
                AxWindowsMediaPlayer4.Visible = True
                AxWindowsMediaPlayer4.Ctlcontrols.play()
            Case 216
                AxWindowsMediaPlayer1.Ctlcontrols.pause()
                PictureBox1.Visible = False
                AxWindowsMediaPlayer2.Visible = False
                AxWindowsMediaPlayer3.Visible = False
                PictureBox2.Visible = True
                Timer1.Stop()
                PictureBox2.Image = Image.FromFile("main.jpg")
        End Select
    End Sub

End Class
