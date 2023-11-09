Imports System.Media
Public Class Form1
    Public count As Integer
    Public count2 As Integer
    Private Declare Function GetCursorPos Lib "user32.dll" (ByRef lpPoint As Point) As Boolean
    Private Declare Function PtInRect Lib "user32.dll" (ByRef lprc As Rectangle, ByVal pt As Point) As Boolean

    Private Sub PlayWavFile(ByVal filePath As String)
        Dim player As New SoundPlayer(filePath)
        player.Play()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = Image.FromFile("game.png")
        PictureBox1.Image = Image.FromFile("suna3.gif")
        PictureBox2.Image = Image.FromFile("Game_Over_Button.png")
        Label1.BackColor = Color.Transparent
        Timer1.Start()
        AxWindowsMediaPlayer1.URL = "terano3.mp4"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub




    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' ボタンの位置とサイズを取得
        count += 1
        If count >= 49 Then
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
            If count = 70 Then
                Timer2.Enabled = True
                PlayWavFile("suna.wav")
                Timer1.Stop()
                PictureBox2.Visible = True
                PictureBox1.Visible = True
                Label1.Visible = True
            End If
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            Process.Start("start2.exe")
            Application.Exit()
        Catch ex As Exception
            MessageBox.Show("ファイルが開けませんでした:" & ex.Message)
        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        count2 += 1
        If count2 = 140 Then
            PlayWavFile("suna.wav")
            count2 = 0
        End If
    End Sub
End Class
