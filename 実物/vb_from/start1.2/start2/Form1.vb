Imports System.IO
Imports System.Drawing.Imaging
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        Label3.ForeColor = Color.Black
        Label4.ForeColor = Color.Black
        If File.Exists("R:\_R05課題研究(情報技術科)\２班\ティラノタイトル.gif") Then
            PictureBox1.Image = Image.FromFile("R:\_R05課題研究(情報技術科)\２班\ティラノタイトル.gif")
        Else
            MessageBox.Show("画像ファイルが見つかりません。")
        End If
        PictureBox2.Image = Image.FromFile("タイトル2_transparent.png")

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class
