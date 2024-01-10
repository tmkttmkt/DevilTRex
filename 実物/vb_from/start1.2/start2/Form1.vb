Imports System.IO
Imports System.Text


Public Class Form1
    Dim hozon As String = ""
    Dim count As Integer
    Dim filePath As String = "visual.txt"
    Dim count2 As Integer
    Dim count3 As Integer
    Dim start_flg As Integer = 0
    Dim utf8 As System.Text.Encoding = System.Text.Encoding.UTF8
    Dim bytes As Byte() = utf8.GetBytes("©2023.Good_Natural_Person")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fileContent As String = ReadTextFile(filePath)
        hozon = fileContent
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Label7.Text = utf8.GetString(bytes)
        PictureBox2.Visible = False
        PictureBox3.Visible = True
        Test.Visible = True
        Label1.Visible = False
        Label1.BackColor = Color.FromArgb(75, 67, 67)
        Label2.Visible = False
        Label2.BackColor = Color.FromArgb(75, 67, 67)
        Label3.Visible = False
        Label3.BackColor = Color.FromArgb(75, 67, 67)
        Test.Visible = False
        Label4.Visible = False
        Label4.BackColor = Color.FromArgb(75, 67, 67)
        Label7.Visible = False
        Label7.BackColor = Color.FromArgb(227, 227, 203)
        Label8.Visible = False
        Label8.BackColor = Color.FromArgb(75, 67, 67)
        Label9.Visible = False
        Label6.Visible = False
        Label6.BackColor = Color.FromArgb(75, 67, 67)
        Label1.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        Label3.ForeColor = Color.Black
        Label4.ForeColor = Color.Black
        'PictureBox1.Image = Image.FromFile("start.png")
        If File.Exists("R:\_R05課題研究(情報技術科)\２班\最初.mp4") Then
            AxWindowsMediaPlayer1.URL = "R:\_R05課題研究(情報技術科)\２班\最初.mp4"
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            Timer1.Enabled = True
            PictureBox3.Visible = True
        Else
            MessageBox.Show("動画ファイルが見つかりません。")
        End If
        If File.Exists("R:\_R05課題研究(情報技術科)\２班\ティラノタイトル.gif") Then
            PictureBox4.Image = Image.FromFile("R:\_R05課題研究(情報技術科)\２班\シン・ティラノサウルス.gif")
        Else
            MessageBox.Show("画像ファイルが見つかりません。")
        End If
        PictureBox2.BackColor = Color.FromArgb(75, 67, 67)
        PictureBox2.Image = Image.FromFile("タイトル2.png")

    End Sub
    Private Function ReadTextFile(filePath As String) As String
        Dim content As String = ""

        ' ファイルが存在するかを確認し、存在する場合は内容を読み込む
        If File.Exists(filePath) Then
            Using reader As New StreamReader(filePath)
                content = reader.ReadToEnd()
            End Using
        Else
            content = "ファイルが見つかりません"
        End If

        Return content
    End Function
    Private Sub Colorsan()
        Label1.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        Label3.ForeColor = Color.Black
        Label4.ForeColor = Color.Black
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        My.Computer.Audio.Stop()
        Timer2.Stop()
        count2 = 0
        Me.Hide()
        'My.Computer.Audio.Stop()
        Colorsan()
        Settei.Show()
    End Sub
    'ラベルの色を変えるプログラム
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        Label1.ForeColor = Color.Red
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        If Not Label1.ClientRectangle.Contains(Label1.PointToClient(MousePosition)) Then
            Label1.ForeColor = Color.Black
        End If
    End Sub
    'START
    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter
        Label2.ForeColor = Color.Red
    End Sub
    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        If Not Label2.ClientRectangle.Contains(Label2.PointToClient(MousePosition)) Then
            Label2.ForeColor = Color.Black
        End If
    End Sub
    '設定
    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter
        Label3.ForeColor = Color.Red
    End Sub
    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        If Not Label3.ClientRectangle.Contains(Label3.PointToClient(MousePosition)) Then
            Label3.ForeColor = Color.Black
        End If
    End Sub
    'END
    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        Label4.ForeColor = Color.Red
    End Sub
    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        If Not Label4.ClientRectangle.Contains(Label4.PointToClient(MousePosition)) Then
            Label4.ForeColor = Color.Black
        End If
    End Sub
    Private Sub Button6_MouseEnter(sender As Object, e As EventArgs) Handles Label6.MouseEnter
        Label6.ForeColor = Color.Red
    End Sub
    Private Sub Button6_MouseLeave(sender As Object, e As EventArgs) Handles Label6.MouseLeave
        If Not Label6.ClientRectangle.Contains(Label6.PointToClient(MousePosition)) Then
            Label6.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        count = 0
        My.Computer.Audio.Stop()
        Timer2.Stop()
        Colorsan()
        Label2.ForeColor = Color.Black
        How2.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If hozon.Length > 0 Then
            Dim form2 As New Form2(hozon)
            form2.Show()
            Me.Hide()
        Else
            PictureBox1.Visible = True
            Timer3.Enabled = True
            AxWindowsMediaPlayer2.URL = "shutter1.mp3"
            AxWindowsMediaPlayer2.Ctlcontrols.play()
            My.Computer.Audio.Play("sakebi.wav")
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Using writer As New StreamWriter(filePath, False)
            writer.Write("")
        End Using
        Application.Exit()
    End Sub




    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Kaisi()
    End Sub


    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Try
            Process.Start("マイプロジェクト（3）.exe")
            Application.Exit()
        Catch ex As Exception
            MessageBox.Show("ファイルが開けませんでした:" & ex.Message)
        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        count2 += 1
        'Label9.Text = count2
        If count2 = 400 Then
            My.Computer.Audio.Play("ホーム画面の音楽.wav")
            count2 = 0
        End If
    End Sub
    Private Sub mediaPlayer_PlayStateChange(sender As Object, e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayer1.PlayStateChange
        ' メディアの再生状態が変化したときのイベントハンドラ

        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsMediaEnded Then
            Kaisi()
            PictureBox3.Visible = False
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
        End If
    End Sub
    Private Sub Kaisi()
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        My.Computer.Audio.Play("ホーム画面の音楽.wav")
        AxWindowsMediaPlayer1.Visible = False
        start_flg = 1
        Timer2.Enabled = True
        Me.KeyPreview = True
        PictureBox4.Visible = True
        PictureBox2.Visible = True
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        PictureBox3.Visible = False
        Label7.Visible = True
        Timer1.Enabled = False
        Label8.Visible = True
        Label6.Visible = True
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        count3 += 1
        Label9.Text = count3
        If count3 = 43 Then
            Try
                Process.Start("Goodbye Unity.exe")
                Application.Exit()
            Catch ex As Exception
                MessageBox.Show("ファイルが開けませんでした:" & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If start_flg >= 1 Then
            My.Computer.Audio.Play("ホーム画面の音楽.wav")
            count2 = 0
            Kaisi()
        End If
    End Sub

End Class
