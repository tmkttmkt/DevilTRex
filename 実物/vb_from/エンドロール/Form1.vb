Imports System.Media
Public Class Form1
    Public count As Integer
    Private Declare Function GetCursorPos Lib "user32.dll" (ByRef lpPoint As Point) As Boolean
    Private Declare Function sndPlaySound Lib "winmm.dll" Alias "sndPlaySoundA" (ByVal lpszSoundName As String, ByVal uFlags As Long) As Long
    Private Declare Function PtInRect Lib "user32.dll" (ByRef lprc As Rectangle, ByVal pt As Point) As Boolean
    Private Sub PlayWavFile(ByVal filePath As String)
        Dim player As New SoundPlayer(filePath)
        player.Play()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
        PlayWavFile("課題研究 Edit 1 エクスポート 1.wav")
        AxWindowsMediaPlayer1.URL = "endrool2.mp4"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        AxWindowsMediaPlayer2.URL = "T5.mp4"
        AxWindowsMediaPlayer2.Visible = False
        AxWindowsMediaPlayer3.URL = "T6.mp4"
        AxWindowsMediaPlayer3.Visible = False
        AxWindowsMediaPlayer4.URL = "T12.mp4"
        AxWindowsMediaPlayer4.Visible = False
        Label4.Left -= 50
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' ボタンの位置とサイズを取得
        count += 1
        AxWindowsMediaPlayer4.Visible = False
        Me.BackColor = Color.Black
        Select Case count
            Case 1 To 29
                Dim lbl As New Label
                lbl.Size = New System.Drawing.Size(159, 23) 'set your size
                lbl.Location = New System.Drawing.Point(300, 180) 'set your location
                lbl.Text = "AIに作らせた没画像" 'set your name
                Me.Controls.Add(lbl)
            Case 30 To 59
                PictureBox1.Enabled = True
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
            Case 220
                AxWindowsMediaPlayer1.Ctlcontrols.pause()
                PictureBox1.Visible = False
                AxWindowsMediaPlayer2.Visible = False
                AxWindowsMediaPlayer3.Visible = False
                AxWindowsMediaPlayer4.Visible = False
                PictureBox2.Visible = True
                Timer1.Stop()
                Label1.Enabled = False
                Label2.Enabled = False
                Label4.Enabled = False
                PictureBox2.Image = Image.FromFile("main.jpg")
        End Select
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            Process.Start("start2.exe")
            Application.Exit()
        Catch ex As Exception
            MessageBox.Show("ファイルが開けませんでした:" & ex.Message)
        End Try
    End Sub
End Class
