Public Class How
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' キーボードが押されたときのイベントハンドラ

        If e.KeyCode = Keys.W Then
            PictureBox1.Image = Image.FromFile("U:\github\tet\実物\vb_from\start1.2\W_R.png")
            Label7.Text = "↑"
            Label7.Top -= 10
        End If
        If e.KeyCode = Keys.A Then
            PictureBox3.Image = Image.FromFile("U:\github\tet\実物\vb_from\start1.2\A_R.png")
            Label7.Text = "←"
            Label7.Left -= 10
        End If
        If e.KeyCode = Keys.S Then
            PictureBox2.Image = Image.FromFile("U:\github\tet\実物\vb_from\start1.2\S_R.png")
            Label7.Text = "↓"
            Label7.Top += 10
        End If
        If e.KeyCode = Keys.D Then
            PictureBox4.Image = Image.FromFile("U:\github\tet\実物\vb_from\start1.2\D_R.png")
            Label7.Text = "→"
            Label7.Left += 10
        End If
        If e.KeyCode = Keys.E Then
            PictureBox5.Image = Image.FromFile("U:\github\tet\実物\vb_from\start1.2\E_R.png")
            PictureBox7.Visible = True
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
            PictureBox7.Visible = False
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