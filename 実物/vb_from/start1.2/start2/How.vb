Public Class How
    Dim flg As Integer
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' キーボードが押されたときのイベントハンドラ

        If e.KeyCode = Keys.W Then
            PictureBox1.Image = Image.FromFile("U:\github\tet\実物\vb_from\start1.2\W_R.png")
            Label7.Text = "↑"
            If Label7.Top + Label7.Height + 10 > PictureBox8.Top + PictureBox8.Height Then
                Label7.Top -= 10
            End If
        End If
        If e.KeyCode = Keys.A Then
            PictureBox3.Image = Image.FromFile("U:\github\tet\実物\vb_from\start1.2\A_R.png")
            Label7.Text = "←"
            If Label7.Right > PictureBox8.Left Then
                Label7.Left -= 10
            End If
        End If
        If e.KeyCode = Keys.S Then
            PictureBox2.Image = Image.FromFile("U:\github\tet\実物\vb_from\start1.2\S_R.png")
            Label7.Text = "↓"
            If Label7.Top + Label7.Height < PictureBox8.Top + PictureBox8.Height Then
                Label7.Top += 10
            End If
        End If
        If e.KeyCode = Keys.D Then
            PictureBox4.Image = Image.FromFile("U:\github\tet\実物\vb_from\start1.2\D_R.png")
            Label7.Text = "→"
            If Label7.Right < PictureBox8.Left + PictureBox8.Width Then
                Label7.Left += 10
            End If
        End If
        If e.KeyCode = Keys.E And flg = 0 Then
            PictureBox5.Image = Image.FromFile("U:\github\tet\実物\vb_from\start1.2\E_R.png")
        End If
        If e.KeyCode = Keys.E And flg = 1 Then
            PictureBox5.Image = Image.FromFile("U:\github\tet\実物\vb_from\start1.2\E_R.png")
            PictureBox7.Visible = False
            flg = 0
        End If

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.W Then
            PictureBox1.Image = Image.FromFile("U:\github\tet\実物\vb_from\start1.2\W.png")
        End If
        If e.KeyCode = Keys.A Then
            PictureBox3.Image = Image.FromFile("U:\github\tet\実物\vb_from\start1.2\A.png")
        End If
        If e.KeyCode = Keys.S Then
            PictureBox2.Image = Image.FromFile("U:\github\tet\実物\vb_from\start1.2\S.png")
        End If
        If e.KeyCode = Keys.D Then
            PictureBox4.Image = Image.FromFile("U:\github\tet\実物\vb_from\start1.2\D.png")
        End If
        If e.KeyCode = Keys.E Then
            PictureBox5.Image = Image.FromFile("U:\github\tet\実物\vb_from\start1.2\E.png")
            If flg = 0 Then
                flg = 1
            End If
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Label7.Left = 41
        Label7.Top = 143
        Label7.Text = "↑"
        PictureBox7.Visible = False
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        How2.Show()
    End Sub

    Private Sub How_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
    End Sub
End Class