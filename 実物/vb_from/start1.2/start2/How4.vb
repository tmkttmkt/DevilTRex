Public Class How4
    Dim flg As Boolean = False
    Dim flg2 = False
    Dim rokka As Boolean = False
    Dim rokka2 As Boolean = True
    Dim count As Integer
    Dim gazou(21) As Image
    Dim gousei_flg As Boolean = False
    Dim hyouji As Boolean = False
    Dim gousei = False
    Dim gousei2 = True
    Dim rokka_flg = False
    Private Sub How4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        gazou(10) = Image.FromFile("シェルターのカギ.png")
        gazou(11) = Image.FromFile("本体.png")
        gazou(12) = Image.FromFile("持ち手.png")
        gazou(13) = Image.FromFile("G.png")
        gazou(14) = Image.FromFile("G_R.png")
        gazou(15) = Image.FromFile("アイテム欄２.png")
        gazou(16) = Image.FromFile("SPACE.png")
        gazou(17) = Image.FromFile("ロッカー.png")
        gazou(18) = Image.FromFile("主人公 (2).png")
        gazou(19) = Image.FromFile("SPACE_R.png")
        gazou(20) = Image.FromFile("閉じるロッカー.png")
        gazou(21) = Image.FromFile("シルエットティラノ.png")
        PictureBox1.Image = gazou(0)
        PictureBox2.Image = gazou(2)
        PictureBox3.Image = gazou(1)
        PictureBox4.Image = gazou(3)
        PictureBox5.Image = gazou(4)
        PictureBox6.Image = gazou(13)
        PictureBox7.Image = gazou(16)
        PictureBox9.Image = gazou(15)
        PictureBox10.Image = gazou(11)
        PictureBox11.Image = gazou(12)
        PictureBox13.Image = gazou(17)
        PictureBox14.Image = gazou(18)
        Me.KeyPreview = True
        Timer1.Enabled = True
    End Sub

    Private Sub How4_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.W Then
            PictureBox1.Image = gazou(5)
            Label2.Text = "↑"
            If Label2.Top > PictureBox8.Top Then
                Label2.Top -= 10
            End If
        End If
        If e.KeyCode = Keys.A Then
            PictureBox3.Image = gazou(6)
            Label2.Text = "←"
            If Label2.Left > PictureBox8.Left Then
                Label2.Left -= 10
            End If
        End If
        If e.KeyCode = Keys.S Then
            PictureBox2.Image = gazou(7)
            Label2.Text = "↓"
            If Label2.Top + Label2.Height < PictureBox8.Top + PictureBox8.Height Then
                Label2.Top += 10
            End If
        End If
        If e.KeyCode = Keys.D Then
            PictureBox4.Image = gazou(8)
            Label2.Text = "→"
            If Label2.Right < PictureBox8.Left + PictureBox8.Width Then
                Label2.Left += 10
            End If
        End If

        ''WASDキー以外

        If flg2 = True And gousei2 = True Then
            If e.KeyCode = Keys.G Then
                PictureBox10.Image = gazou(10)
                'PictureBox9.Image = gazou(10)
                PictureBox11.Visible = False
                Label5.Text = "冒険のゴングは鳴る"
                Label6.Visible = False
                gousei = True
            End If
        End If
        If e.KeyCode = Keys.E Then
            PictureBox5.Image = gazou(9)
            flg2 = True
            If hyouji = False Then
                hyouji = True
            Else
                hyouji = False
            End If
        End If
        If e.KeyCode = Keys.Space Then
            PictureBox7.Image = gazou(19)
            If rokka_flg = False Then
                rokka_flg = True
                PictureBox13.Image = gazou(20)
                PictureBox14.Visible = False
                Label3.Visible = False
            ElseIf rokka_flg = True Then
                rokka_flg = False
                PictureBox13.Image = gazou(17)
                Label3.Visible = True
                PictureBox14.Visible = True
            End If
            'Label4.Text = "OK"
            rokka = True
        End If
    End Sub

    Private Sub How4_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
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
        End If
        If e.KeyCode = Keys.G Then
            PictureBox6.Image = gazou(13)
        End If
        If e.KeyCode = Keys.Space Then
            PictureBox7.Image = gazou(16)
        End If
    End Sub
    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Label12.MouseEnter
        Label12.ForeColor = Color.Red
    End Sub
    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Label12.MouseLeave
        If Not Label3.ClientRectangle.Contains(Label3.PointToClient(MousePosition)) Then
            Label12.ForeColor = Color.White
        End If
    End Sub
    'END
    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Label13.MouseEnter
        Label13.ForeColor = Color.Red
    End Sub
    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Label13.MouseLeave
        If Not Label4.ClientRectangle.Contains(Label4.PointToClient(MousePosition)) Then
            Label13.ForeColor = Color.White
        End If
    End Sub
    Private Sub Button6_MouseEnter(sender As Object, e As EventArgs) Handles Label14.MouseEnter
        Label14.ForeColor = Color.Red
    End Sub
    Private Sub Button6_MouseLeave(sender As Object, e As EventArgs) Handles Label14.MouseLeave
        If Not Label6.ClientRectangle.Contains(Label6.PointToClient(MousePosition)) Then
            Label14.ForeColor = Color.White
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        count += 1
        If hyouji = True Then
            PictureBox10.Visible = True
            Label5.Visible = True
            PictureBox9.Visible = True
            If gousei = True Then
                PictureBox11.Visible = False
                Label6.Visible = False
            ElseIf gousei = False Then
                PictureBox11.Visible = True
                Label6.Visible = True
            End If
        Else
            PictureBox10.Visible = False
            Label5.Visible = False
            PictureBox9.Visible = False
            PictureBox11.Visible = False
            Label6.Visible = False
        End If
        If count >= 340 Then
            My.Computer.Audio.Stop()
            My.Computer.Audio.Play("何作ってるんだっけ2.wav")
            count = 0
        End If
    End Sub
    Private Sub BackHome()
        PictureBox1.Image = gazou(0)
        PictureBox2.Image = gazou(2)
        PictureBox3.Image = gazou(1)
        PictureBox4.Image = gazou(3)
        PictureBox5.Image = gazou(4)
        PictureBox6.Image = gazou(13)
        PictureBox7.Image = gazou(16)
        PictureBox9.Image = gazou(15)
        PictureBox10.Image = gazou(11)
        PictureBox11.Image = gazou(12)
        PictureBox13.Image = gazou(17)
        PictureBox14.Image = gazou(18)
        Label5.Text = "誰だよバラしたやつ"
        Label6.Text = "ありふれたやつ"
        Timer1.Stop()
        My.Computer.Audio.Stop()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Me.Hide()
        BackHome()
        How3.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Me.Hide()
        BackHome()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Me.Hide()
        BackHome()
        How.Show()
    End Sub

    Private Sub How4_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.KeyPreview = True
        Timer1.Enabled = True
        flg = False
        flg2 = False
        rokka = False
        count = 0
        gousei_flg = False
        hyouji = False
        gousei = False
        gousei2 = True
        rokka_flg = False
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play("何作ってるんだっけ2.wav")
    End Sub
End Class