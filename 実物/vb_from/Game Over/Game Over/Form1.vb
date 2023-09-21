
Public Class Form1
    Public count As Integer
    Private Declare Function GetCursorPos Lib "user32.dll" (ByRef lpPoint As Point) As Boolean
    Private Declare Function PtInRect Lib "user32.dll" (ByRef lprc As Rectangle, ByVal pt As Point) As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Button1.FlatAppearance.BorderColor = Color.Black
        Label1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = Image.FromFile("game.png")
        PictureBox1.Image = Image.FromFile("suna3.gif")
        Label1.BackColor = Color.Transparent
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

    Private Sub btnCustomButton_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        ' マウスがボタンに入ったときの枠線色を設定
        Button1.FlatAppearance.BorderColor = Color.Red
        Button1.FlatAppearance.BorderSize = 3
    End Sub
    Private Sub btnCustomButton_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        ' マウスがボタンから出たときの枠線色を設定
        If Not Button1.ClientRectangle.Contains(Button1.PointToClient(MousePosition)) Then
            Button1.FlatAppearance.BorderColor = Color.Black
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ' ボタンの位置とサイズを取得
        count += 1
        If count >= 48 Then
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
            If count = 70 Then
                Timer1.Stop()
                PictureBox1.Visible = True
                Button1.Visible = True
                Label1.Visible = True
            End If
        End If
    End Sub

End Class
