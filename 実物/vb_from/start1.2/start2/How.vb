Imports System.Drawing
Public Class How
    Dim flg As Integer
    Dim flg2 As Boolean = True
    Dim im As Integer = 0
    Dim gazou(10) As Image

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' キーボードが押されたときのイベントハンドラ

        If e.KeyCode = Keys.W Then
            PictureBox1.Image = gazou(5)
            Label7.Text = "↑"
            If Label7.Top > PictureBox8.Top Then
                Label7.Top -= 10
            End If
        End If
        If e.KeyCode = Keys.A Then
            PictureBox3.Image = gazou(6)
            Label7.Text = "←"
            If Label7.Left > PictureBox8.Left Then
                Label7.Left -= 10
            End If
        End If
        If e.KeyCode = Keys.S Then
            PictureBox2.Image = gazou(7)
            Label7.Text = "↓"
            If Label7.Top + Label7.Height < PictureBox8.Top + PictureBox8.Height Then
                Label7.Top += 10
            End If
        End If
        If e.KeyCode = Keys.D Then
            PictureBox4.Image = gazou(8)
            Label7.Text = "→"
            If Label7.Right < PictureBox8.Left + PictureBox8.Width Then
                Label7.Left += 10
            End If
        End If
        If e.KeyCode = Keys.E And flg2 = True Then
            PictureBox5.Image = gazou(9)
            flg = 1
        End If
        If e.KeyCode = Keys.E And flg2 = False Then
            PictureBox5.Image = gazou(9)
            flg = 0
        End If

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.W Then
            PictureBox1.Image = gazou(0)
        End If
        If e.KeyCode = Keys.A Then
            PictureBox3.Image = gazou(1)
        End If
        If e.KeyCode = Keys.S Then
            PictureBox2.Image = gazou(2)
        End If
        If e.KeyCode = Keys.D Then
            PictureBox4.Image = gazou(3)
        End If
        If e.KeyCode = Keys.E Then
            PictureBox5.Image = gazou(4)
            im += 1
            flg2 = False
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Label7.Left = 41
        Label7.Top = 143
        Label7.Text = "↑"
        im = 0
        flg = 0
        flg2 = True
        PictureBox7.Visible = False
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Label7.Left = 41
        Label7.Top = 143
        Label7.Text = "↑"
        im = 0
        flg = 0
        flg2 = True
        PictureBox7.Visible = False
        How3.Show()
    End Sub

    Private Sub How_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
        Timer1.Enabled = True
        gazou(0) = Image.FromFile("W.png")
        gazou(1) = Image.FromFile("A.png")
        gazou(2) = Image.FromFile("S.png")
        gazou(3) = Image.FromFile("D.png")
        gazou(4) = Image.FromFile("E.png")
        gazou(5) = Image.FromFile("W_R.png")
        gazou(6) = Image.FromFile("A_R.png")
        gazou(7) = Image.FromFile("S_R.png")
        gazou(8) = Image.FromFile("D_R.png")
        gazou(9) = Image.FromFile("E_R.png")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If flg = 1 Then
            PictureBox7.Visible = True
        End If
        If flg = 0 Then
            PictureBox7.Visible = False
        End If
        If im = 2 Then
            im = 0
            flg2 = True
        End If
    End Sub
End Class