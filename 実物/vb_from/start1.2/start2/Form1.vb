Imports System.IO
Imports System.Media
Imports System.Drawing.Imaging
Imports System.ComponentModel

Public Class Form1
    Dim count As Integer
    Dim count2 As Integer
    Private Sub PlayWavFile(ByVal filePath As String)
        Dim player As New SoundPlayer(filePath)
        player.Play()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.Visible = False
        Test.Visible = True
        Label1.Visible = False
        Label1.BackColor = Color.FromArgb(150, 143, 139)
        Label2.Visible = False
        Label2.BackColor = Color.FromArgb(150, 143, 139)
        Label3.Visible = False
        Label3.BackColor = Color.FromArgb(150, 143, 139)
        Test.Visible = False
        Label4.Visible = False
        Label4.BackColor = Color.FromArgb(150, 143, 139)
        Label7.Visible = False
        Label7.BackColor = Color.FromArgb(231, 231, 215)
        Label8.Visible = False
        Label8.BackColor = Color.FromArgb(150, 143, 139)
        Label9.Visible = True
        Label6.Visible = False
        Label6.BackColor = Color.FromArgb(150, 143, 139)
        Label1.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        Label3.ForeColor = Color.Black
        Label4.ForeColor = Color.Black
        If File.Exists("R:\_R05課題研究(情報技術科)\２班\オープニング.gif") Then
            PictureBox1.Image = Image.FromFile("R:\_R05課題研究(情報技術科)\２班\オープニング.gif")
            Timer1.Enabled = True
        Else
            MessageBox.Show("画像ファイルが見つかりません。")
        End If
        If File.Exists("R:\_R05課題研究(情報技術科)\２班\ティラノタイトル.gif") Then
            PictureBox4.Image = Image.FromFile("R:\_R05課題研究(情報技術科)\２班\ティラノタイトル.gif")
        Else
            MessageBox.Show("画像ファイルが見つかりません。")
        End If
        PictureBox2.BackColor = Color.FromArgb(150, 143, 139)

        PictureBox2.Image = Image.FromFile("タイトル2.png")

    End Sub
    Private Sub Colorsan()
        Label1.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        Label3.ForeColor = Color.Black
        Label4.ForeColor = Color.Black
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
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
        Colorsan()
        Label2.ForeColor = Color.Black
        How2.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Try
            Process.Start("Goodbye Unity.exe")
            Application.Exit()
        Catch ex As Exception
            MessageBox.Show("ファイルが開けませんでした:" & ex.Message)
        End Try
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        End
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        count += 1
        Label9.Text = count
        If count <= 265 Then
            'If count = 230 Then
            'PlayWavFile("咆哮2.wav")
            'End If
            PictureBox3.Visible = True
        End If
        If count >= 265 Then
            PlayWavFile("ホーム画面の音楽.wav")
            Timer2.Enabled = True
            Me.KeyPreview = True
            PictureBox1.Visible = False
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
            Label6.Visible = False
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        count = 265
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Try
            Process.Start("Game Clear.exe")
            Application.Exit()
        Catch ex As Exception
            MessageBox.Show("ファイルが開けませんでした:" & ex.Message)
        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        count2 += 1
        'Label9.Text = count2
        If count2 = 400 Then
            PlayWavFile("ホーム画面の音楽.wav")
            count2 = 0
        End If
    End Sub
End Class
