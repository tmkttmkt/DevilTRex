Public Class Form1
    Public count As Integer
    Private Declare Function GetCursorPos Lib "user32.dll" (ByRef lpPoint As Point) As Boolean
    Private Declare Function PtInRect Lib "user32.dll" (ByRef lprc As Rectangle, ByVal pt As Point) As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
        AxWindowsMediaPlayer1.URL = "endrool2.mp4"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' ボタンの位置とサイズを取得
        count += 1
        If count = 1 Then
            Form2.Show()
        End If
        If count >= 216 Then
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
            Timer1.Stop()
            Me.Hide()
        End If
    End Sub

End Class
