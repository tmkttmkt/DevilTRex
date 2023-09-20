Imports System.Runtime.InteropServices
Public Class Form1
    Public count As Integer
    Private Declare Function GetCursorPos Lib "user32.dll" (ByRef lpPoint As Point) As Boolean
    Private Declare Function PtInRect Lib "user32.dll" (ByRef lprc As Rectangle, ByVal pt As Point) As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim cursorPos As New Point()
        GetCursorPos(cursorPos)

        ' ボタンの位置とサイズを取得
        Dim buttonRect As Rectangle = Button1.Bounds

        ' マウスカーソルがボタンの上にあるかどうかをチェック
        If PtInRect(buttonRect, cursorPos) Then
            ' マウスカーソルがボタンの上にある場合、枠線を赤くする
            Button1.FlatAppearance.BorderColor = Color.Red
            isMouseOverButton = True
        Else
            ' マウスカーソルがボタンの上にない場合、元の枠線色に戻す
            If isMouseOverButton Then
                Button1.FlatAppearance.BorderColor = initialButtonBorderColor
                isMouseOverButton = False
            End If
        End If
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
