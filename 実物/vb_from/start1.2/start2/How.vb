Imports System.Drawing
Imports System.Threading
Public Class How
    Dim flg As Integer
    Dim flg2 As Boolean = False
    Dim count As Integer
    Dim count2 As Integer = 0
    Dim im As Integer = 0
    Dim start_flg As Boolean = False
    Dim WASD_flg = False
    Dim E_flg = False
    Dim gazou(15) As Image
    Dim gousei_flg As Boolean = False
    Dim displayText As String = "やぁ、僕はティラノサウルス。君を食い殺しに来たよ！" ' 表示する文字列
    Dim currentIndex As Integer = 0 '
    Dim ok(3) As Integer
    Dim hyouji As Boolean = False
    Dim gousei = False
    Dim gousei2 = False

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' キーボードが押されたときのイベントハンドラ
        If start_flg = True Then

            If e.KeyCode = Keys.W Then
                PictureBox1.Image = gazou(5)
                Label7.Text = "↑"
                If Label7.Top > PictureBox8.Top Then
                    Label7.Top -= 10
                    Label13.Visible = False
                    ok(0) = 1
                End If
            End If
            If e.KeyCode = Keys.A Then
                PictureBox3.Image = gazou(6)
                Label7.Text = "←"
                If Label7.Left > PictureBox8.Left Then
                    Label7.Left -= 10
                    ok(1) = 1
                    Label19.Visible = False
                End If
            End If
            If e.KeyCode = Keys.S Then
                PictureBox2.Image = gazou(7)
                Label7.Text = "↓"
                If Label7.Top + Label7.Height < PictureBox8.Top + PictureBox8.Height Then
                    Label7.Top += 10
                    ok(2) = 1
                    Label20.Visible = False
                End If
            End If
            If e.KeyCode = Keys.D Then
                PictureBox4.Image = gazou(8)
                Label7.Text = "→"
                If Label7.Right < PictureBox8.Left + PictureBox8.Width Then
                    Label7.Left += 10
                    ok(3) = 1
                    Label21.Visible = False
                End If
            End If
        End If
        If E_flg = True Then
            If e.KeyCode = Keys.E Then
                PictureBox5.Image = gazou(9)
                flg2 = True
                If hyouji = False Then
                    hyouji = True
                End If
            End If
        End If
        If e.KeyCode = Keys.G Then
            PictureBox11.Image = gazou(14)
            If flg2 = True And gousei2 = True Then
                PictureBox9.Image = gazou(10)
                PictureBox10.Visible = False
                Label16.Text = "冒険のゴングは鳴る"
                Label17.Visible = False
                gousei = True
            End If
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
        End If
        If e.KeyCode = Keys.G Then
            PictureBox11.Image = gazou(13)
        End If

        If ok(0) = 1 And ok(1) = 1 And ok(2) = 1 And ok(3) = 1 Then
            WASD_flg = True
            Timer3.Start()
        End If
        If flg2 = True Then
            Timer3.Start()
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Label7.Left = 41
        Label7.Top = 143
        Label7.Text = "↑"
        PictureBox9.Image = gazou(12)
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        im = 0
        flg = 0
        flg2 = True
        PictureBox7.Visible = False
        Timer2.Stop()
        count = 0
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        PictureBox9.Image = gazou(12)
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        Label7.Left = 41
        Label7.Top = 143
        Label7.Text = "↑"
        im = 0
        flg = 0
        flg2 = True
        PictureBox7.Visible = False
        My.Computer.Audio.Stop()
        Timer2.Stop()
        count = 0
        How3.Show()
    End Sub

    Private Sub How_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label13.Visible = False
        Timer3.Enabled = True
        My.Computer.Audio.Play("何作ってるんだっけ2.wav")
        Me.KeyPreview = True
        Timer1.Enabled = True
        ok(0) = 0
        ok(1) = 0
        ok(2) = 0
        ok(3) = 0
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
        PictureBox1.Image = gazou(0)
        PictureBox3.Image = gazou(1)
        PictureBox2.Image = gazou(2)
        PictureBox4.Image = gazou(3)
        PictureBox5.Image = gazou(4)
        ' PictureBox6.Image = Image.FromFile("Enter.png")
        PictureBox7.Image = gazou(15)
        PictureBox9.Image = gazou(12)
        PictureBox10.Image = gazou(11)
        PictureBox11.Image = gazou(13)
        PictureBox12.Image = gazou(10)
        Timer2.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If im = 2 Then
            im = 0
            flg2 = True
        End If

    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        count += 1
        'Label13.Text = count
        If count = 340 Then
            My.Computer.Audio.Play("何作ってるんだっけ2.wav")
        End If
        If hyouji = True Then
            PictureBox7.Visible = True
            PictureBox9.Visible = True
            Label16.Visible = True
            If gousei = False Then
                PictureBox10.Visible = True
                Label17.Visible = True
            End If
        End If
    End Sub

    Private Sub How_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        My.Computer.Audio.Play("何作ってるんだっけ2.wav")
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        Label16.Text = "カギの持ち手"
        Label16.Visible = False
        Label17.Visible = False
        gousei_flg = False
    End Sub
    Private Sub Mojiyomi()
        If currentIndex < displayText.Length Then
            Label11.Text &= displayText(currentIndex) ' 現在の位置の文字を追加
            currentIndex += 1
        Else
            Thread.Sleep(500)
            currentIndex = 0
            count2 += 1
            Label11.Text = ""
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If count2 = 0 Then
            Mojiyomi()
        End If
        If count2 = 1 Then
            displayText = "でもこのまま食べてもフェアじゃないから、ゲーム操作を解説するね。"
            Mojiyomi()
        ElseIf count2 = 2 Then
            displayText = "WASDキーで移動してみろ人間。"
            Mojiyomi()
            If currentIndex = displayText.Length And WASD_flg = False Then
                start_flg = True
                Label7.Visible = True
                Label13.Visible = True
                Label19.Visible = True
                Label20.Visible = True
                Label21.Visible = True
                Label22.Visible = True
                Timer3.Stop()
            ElseIf WASD_flg = True And currentIndex = displayText.Length Then
                currentIndex = 0
                Label13.Visible = False
                Label19.Visible = False
                Label11.Text = ""
                count2 += 1
            End If
        ElseIf count2 = 3 Then
            Label22.Visible = False
            displayText = "70点ぐらいかな。"
            Mojiyomi()
        ElseIf count2 = 4 Then
            displayText = "まぁいいや。次に進むぞ。"
            Mojiyomi()
        ElseIf count2 = 5 Then
            displayText = "次にEキーを押してアイテムを開いてみろ。"
            Mojiyomi()
            If currentIndex = displayText.Length And flg2 = False Then
                E_flg = True
                PictureBox5.Visible = True
                Label13.Text = "目標：Eキーで"
                Label13.Visible = True
                Label19.Text = "アイテム欄を開く。"
                Label19.Visible = True
                Label6.Visible = True
                Timer3.Stop()
            ElseIf currentIndex = displayText.Length And flg2 = True Then
                currentIndex = 0
                Label13.Visible = False
                Label11.Text = ""
                Label19.Visible = False
                count2 += 1
            End If
        ElseIf count2 = 6 Then
            displayText = "それがアイテム欄だ。いろいろできる。"
            Mojiyomi()
        ElseIf count2 = 7 Then
            displayText = "アイテムの名前も見れるし合成もできる。"
            Mojiyomi()
        ElseIf count2 = 8 Then
            displayText = "試しに合成をやってみるか。"
            Mojiyomi()
        ElseIf count2 = 9 Then
            displayText = "Gキーで合成できるぞ。"
            Mojiyomi()
            If currentIndex = displayText.Length And gousei = False Then
                gousei2 = True
                Label15.Visible = True
                PictureBox11.Visible = True
                Label13.Text = "目標：Gキーで"
                Label13.Visible = True
                Label19.Text = "アイテムを合成する。"
                Label19.Visible = True
                Timer3.Stop()
            ElseIf currentIndex = displayText.Length And gousei = True Then
                currentIndex = 0
                Label13.Visible = False
                Label11.Text = ""
                count2 += 1
                Label19.Visible = False
                Thread.Sleep(500)
            End If
        ElseIf count2 = 10 Then
            displayText = "だいぶ頭が良くなってきたな"
            Mojiyomi()
        ElseIf count2 = 11 Then
            displayText = "今回はうまくできたが"
            Mojiyomi()
        ElseIf count2 = 12 Then
            displayText = "何かで部品同士をくっつける場合もあるから、気をつけておけよ"
            Mojiyomi()
        ElseIf count2 = 13 Then
            displayText = "あとはそうだな、あれを伝えないとな。"
            Mojiyomi()
        End If

    End Sub


End Class