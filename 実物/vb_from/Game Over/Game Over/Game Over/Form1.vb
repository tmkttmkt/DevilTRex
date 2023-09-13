Public Class Form1
    Private WithEvents gifTimer As New Timer()
    Private gifFrameIndex As Integer = 0
    Private gifFrames As List(Of Image) = New List(Of Image)()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' GIFファイルを読み込み、フレームを分解してリストに保存
        Dim gif As New System.Drawing.Imaging.FrameDimension(PictureBox1.Image.FrameDimensionsList(0))
        Dim frameCount As Integer = PictureBox1.Image.GetFrameCount(gif)
        For i As Integer = 0 To frameCount - 1
            PictureBox1.Image.SelectActiveFrame(gif, i)
            gifFrames.Add(New Bitmap(PictureBox1.Image))
        Next

        ' Timerの設定
        gifTimer.Interval = 100 ' ミリ秒単位で更新間隔を設定
        gifTimer.Start()
    End Sub

    Private Sub gifTimer_Tick(sender As Object, e As EventArgs) Handles gifTimer.Tick
        ' フレームを表示
        If gifFrameIndex < gifFrames.Count Then
            PictureBox1.Image = gifFrames(gifFrameIndex)
            gifFrameIndex += 1
        Else
            ' アニメーションが最後まで再生された場合、停止
            gifTimer.Stop()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' アニメーションを再生または再開
        If Not gifTimer.Enabled Then
            gifTimer.Start()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' アニメーションを停止
        gifTimer.Stop()
    End Sub
End Class
