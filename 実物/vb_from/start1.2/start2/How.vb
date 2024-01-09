Imports System.Drawing
Imports System.Threading
Public Class How
    Dim flg As Boolean = False
    Dim flg2 = False
    Dim rokka As Boolean = False
    Dim rokka2 As Boolean = True
    Dim count As Integer
    Dim count2 As Integer = 0
    Dim im As Integer = 0
    Dim start_flg As Boolean = False
    Dim WASD_flg = False
    Dim E_flg = False
    Dim SPACE_flg = False
    Dim gazou(21) As Image
    Dim gousei_flg As Boolean = False
    Dim displayText As String = "やぁ、僕ティラノサウルス。君を食い殺す！" ' 表示する文字列
    Dim currentIndex As Integer = 0 '
    Dim ok(3) As Integer
    Dim hyouji As Boolean = False
    Dim gousei = False
    Dim gousei2 = False
    Dim rokka_flg = False

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' キーボードが押されたときのイベントハンドラ
        If start_flg = True Then

            If e.KeyCode = Keys.W And count2 >= 2 Then
                PictureBox1.Image = gazou(5)
                Label7.Text = "↑"
                If Label7.Top > PictureBox8.Top Then
                    Label7.Top -= 10
                    If WASD_flg = False Then
                        Label13.Visible = False
                    End If
                    ok(0) = 1
                End If
            End If
            If e.KeyCode = Keys.A And count2 >= 2 Then
                PictureBox3.Image = gazou(6)
                Label7.Text = "←"
                If Label7.Left > PictureBox8.Left Then
                    Label7.Left -= 10
                    ok(1) = 1
                    If WASD_flg = False Then
                        Label19.Visible = False
                    End If
                End If
            End If
            If e.KeyCode = Keys.S And count2 >= 2 Then
                PictureBox2.Image = gazou(7)
                Label7.Text = "↓"
                If Label7.Top + Label7.Height < PictureBox8.Top + PictureBox8.Height Then
                    Label7.Top += 10
                    ok(2) = 1
                    If WASD_flg = False Then
                        Label20.Visible = False
                    End If
                End If
            End If
            If e.KeyCode = Keys.D And count2 >= 2 Then
                PictureBox4.Image = gazou(8)
                Label7.Text = "→"
                If Label7.Right < PictureBox8.Left + PictureBox8.Width Then
                    Label7.Left += 10
                    ok(3) = 1
                    If WASD_flg = False Then
                        Label21.Visible = False
                    End If
                End If
            End If
        End If

        ''WASDキー以外

        If flg2 = True And gousei2 = True And count2 >= 9 Then
            If e.KeyCode = Keys.G Then
                Label23.Text = "GはOK"
                PictureBox11.Image = gazou(14)
                PictureBox9.Image = gazou(10)
                PictureBox10.Visible = False
                Label16.Text = "冒険のゴングは鳴る"
                Label17.Visible = False
                If gousei = False Then
                    Timer3.Start()
                End If
                gousei = True
            End If
        End If
        If e.KeyCode = Keys.E And count2 >= 5 Then
            PictureBox5.Image = gazou(9)
            flg2 = True
            If hyouji = False Then
                Label23.Text = "EはOK"
                hyouji = True
            End If
            If E_flg = True Then
                Timer3.Start()
            End If
        End If
        If e.KeyCode = Keys.Space And SPACE_flg = False And count2 >= 16 Then
            PictureBox6.Image = gazou(19)
            SPACE_flg = True
            If rokka_flg = False And count2 >= 16 Then
                rokka_flg = True
                PictureBox13.Image = gazou(20)
                PictureBox14.Visible = False
                If rokka2 = False Then
                    Timer3.Start()
                End If
                Label25.Visible = False
            ElseIf count >= 17 And rokka_flg = True Then
                rokka_flg = False
                PictureBox13.Image = gazou(17)
                Label25.Visible = True
                PictureBox14.Visible = True
            End If
            'Label4.Text = "OK"
            rokka = True
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Space And SPACE_flg = True And count2 >= 16 Then
            SPACE_flg = False
            PictureBox6.Image = gazou(16)
        End If

        If e.KeyCode = Keys.W And count2 >= 2 Then
            PictureBox1.Image = gazou(0)
        End If
        If e.KeyCode = Keys.A And count2 >= 2 Then
            PictureBox3.Image = gazou(1)
        End If
        If e.KeyCode = Keys.S And count2 >= 2 Then
            PictureBox2.Image = gazou(2)
        End If
        If e.KeyCode = Keys.D And count2 >= 2 Then
            PictureBox4.Image = gazou(3)
        End If
        If e.KeyCode = Keys.E And count2 >= 5 Then
            PictureBox5.Image = gazou(4)
        End If
        If e.KeyCode = Keys.G And count2 >= 9 Then
            PictureBox11.Image = gazou(13)
        End If

        If ok(0) = 1 And ok(1) = 1 And ok(2) = 1 And ok(3) = 1 And WASD_flg = False Then
            WASD_flg = True
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
        PictureBox7.Visible = False
        My.Computer.Audio.Stop()
        Timer2.Stop()
        count = 0
        How3.Show()
    End Sub

    Private Sub How_Load(sender As Object, e As EventArgs) Handles Me.Load
        WASD(False)
        Label26.Text = ""
        Label13.Visible = False
        Timer3.Enabled = True
        My.Computer.Audio.Play("チュートリアル.wav")
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
        gazou(16) = Image.FromFile("SPACE.png")
        gazou(17) = Image.FromFile("ロッカー.png")
        gazou(18) = Image.FromFile("主人公 (2).png")
        gazou(19) = Image.FromFile("SPACE_R.png")
        gazou(20) = Image.FromFile("閉じるロッカー.png")
        gazou(21) = Image.FromFile("シルエットティラノ.png")
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
        PictureBox12.Image = gazou(21)
        PictureBox6.Image = gazou(16)
        PictureBox13.Image = gazou(17)
        PictureBox14.Image = gazou(18)
        Timer2.Enabled = True
    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        count += 1
        'Label24.Text = count
        'Label24.Visible = True
        If count = 420 Then
            My.Computer.Audio.Play("チュートリアル.wav")
        End If
        'Label24.Text = flg2
        If hyouji = True Then
            PictureBox7.Visible = True
            PictureBox9.Visible = True
            Label16.Visible = True
            If gousei = False Then
                PictureBox10.Visible = True
                Label17.Visible = True
            End If
        Else
            PictureBox7.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            Label16.Visible = False
            Label17.Visible = False
        End If
    End Sub
    Private Sub WASD(i As Boolean)
        For a As Integer = 1 To 4
            Controls("PictureBox" & CStr(a)).Visible = i
        Next
        For b As Integer = 2 To 5
            Controls("Label" & CStr(b)).Visible = i
        Next
    End Sub


    Private Sub How_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        My.Computer.Audio.Stop()
        WASD(False)
        SPACE_flg = False
        flg = False
        flg2 = False
        rokka = False
        count = 0
        count2 = 0
        im = 0
        start_flg = False
        WASD_flg = False
        E_flg = False
        gousei_flg = False
        displayText = "やぁ、僕ティラノサウルス。君を食い殺す！" ' 表示する文字列
        Label16.Text = "カギの持ち手"
        Label17.Text = "カギの刺すとこ"
        Label13.Text = "Wキーで移動する"
        Label19.Text = "Aキーで移動する"
        Label19.Visible = False
        Label20.Visible = False
        Label20.Text = "Sキーで移動する"
        Label21.Text = "Dキーで移動する"
        PictureBox6.Visible = False
        PictureBox5.Visible = False
        Label6.Visible = False
        Label15.Visible = False
        PictureBox11.Visible = False
        PictureBox13.Visible = False
        currentIndex = 0 '
        hyouji = False
        gousei = False
        gousei2 = False
        rokka_flg = True
        Label26.Text = ""
        Label13.Visible = False
        Timer3.Enabled = True
        My.Computer.Audio.Play("チュートリアル.wav")
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
        gazou(16) = Image.FromFile("SPACE.png")
        gazou(17) = Image.FromFile("ロッカー.png")
        gazou(18) = Image.FromFile("主人公 (2).png")
        gazou(19) = Image.FromFile("SPACE_R.png")
        gazou(20) = Image.FromFile("閉じるロッカー.png")
        gazou(21) = Image.FromFile("シルエットティラノ.png")
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
        PictureBox12.Image = gazou(21)
        PictureBox6.Image = gazou(16)
        PictureBox13.Image = gazou(17)
        PictureBox14.Image = gazou(18)
        Timer2.Enabled = True
        rokka2 = False
        Label7.Left = 41
        Label7.Top = 143
        Label7.Text = "↑"
    End Sub
    Private Sub Mojiyomi()
        If currentIndex < displayText.Length Then
            Label26.Text &= displayText(currentIndex) ' 現在の位置の文字を追加
            currentIndex += 1
        Else
            Thread.Sleep(800)
            currentIndex = 0
            count2 += 1
            Label26.Text = ""
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Select Case count2
            Case 0
                Mojiyomi()
            Case 1
                displayText = "でもこのまま食べてもフェアじゃないから、
ゲーム操作を解説するね。"
                Mojiyomi()
            Case 2
                displayText = "WASDキーで移動してみろ人間。"
                Mojiyomi()
                If currentIndex = displayText.Length And WASD_flg = False Then
                    WASD(True)
                    start_flg = True
                    Label7.Visible = True
                    Label13.Visible = True
                    Label19.Visible = True
                    Label20.Visible = True
                    Label21.Visible = True
                    Label22.Visible = True
                    Timer3.Stop()
                End If
            Case 3
                'start_flg = False
                Label22.Visible = False
                displayText = "70点ぐらいかな。"
                Mojiyomi()
            Case 4
                displayText = "まぁいいや。次に進むぞ。"
                Mojiyomi()
            Case 5
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


                End If
            Case 6
                E_flg = False
                Label13.Visible = False
                Label19.Visible = False
                displayText = "それがアイテム欄だ。いろいろできる。"
                Mojiyomi()
            Case 7
                displayText = "アイテムの名前も見れるし合成もできる。"
                Mojiyomi()
            Case 8
                displayText = "試しに合成をやってみるか。"
                Mojiyomi()
            Case 9
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
                    ' ElseIf currentIndex = displayText.Length And gousei = True Then
                    '    currentIndex = 0
                    '   If gousei = True Then
                    ''End If
                    ' Label13.Visible = False
                    ' Label11.Text = ""
                    ' count2 += 1
                    ' Label19.Visible = False
                    ' Thread.Sleep(500)
                End If
            Case 10
                Label13.Visible = False
                Label19.Visible = False
                displayText = "だいぶ頭が良くなってきたな。"
                Mojiyomi()
            Case 11
                displayText = "今回はうまくできたが、"
                Mojiyomi()
            Case 12
                displayText = "何かで部品同士をくっつける場合も
あるから気をつけておけよ。"
                Mojiyomi()
            Case 13
                displayText = "あとはそうだな、あれを伝えないとな。"
                Mojiyomi()
            Case 14
                displayText = "僕との死闘では、ロッカーが重要になるんだ。"
                Mojiyomi()
            Case 15
                displayText = "今から隠れるすべを教えてあげよう。"
                Mojiyomi()
            Case 16
                Label18.Visible = False
                displayText = "SPACEキーで、モグラみたいに隠れろ！"
                Mojiyomi()
                If currentIndex = displayText.Length And rokka = False Then
                    Timer3.Stop()
                    PictureBox6.Visible = True
                    PictureBox13.Visible = True
                    PictureBox14.Visible = True
                    Label7.Visible = False
                    Label13.Text = "目標：SPACEキーで"
                    Label13.Visible = True
                    Label19.Text = "モグラのごとく隠れる"
                    Label19.Visible = True
                    Label20.Text = "↓Hide"
                    Label20.Visible = True
                    rokka_flg = False
                    rokka2 = False
                    Label25.Visible = True
                End If
            Case 17
                Label13.Visible = False
                Label19.Visible = False
                rokka2 = True
                displayText = "惨めな人間だぜ。"
                Mojiyomi()
            Case 18
                displayText = "ちなみに僕が近くにいるのに隠れるのは
愚策だからな。"
                Mojiyomi()
            Case 19
                displayText = "なんでここまで親切に教えるのかだって？"
                Mojiyomi()
            Case 20
                displayText = "お前は知らないだろうけど、"
                Mojiyomi()
            Case 21
                displayText = "賢い人間の脳みそってのはすげぇ旨いんだよ。"
                Mojiyomi()
            Case 22
                displayText = "程よい薬味がいいアクセントになってて、
何人でも食えちゃうんだ。"
                Mojiyomi()
            Case 23
                displayText = "そしてお前は賢くなった。"
                Mojiyomi()
            Case 24
                displayText = "あとはわかるだろう？"
                Mojiyomi()
            Case 25
                displayText = "それにこれでフェアになったしな。"
                Mojiyomi()
            Case 26
                displayText = "やっぱお前、"
                Mojiyomi()
            Case 27
                displayText = "旨そうやな。"
                Mojiyomi()
            Case 28
                Timer3.Stop()
                Timer2.Stop()
                Timer1.Stop()
                My.Computer.Audio.Stop()
                PictureBox6.Image = gazou(16)
                PictureBox1.Image = gazou(0)
                PictureBox3.Image = gazou(1)
                PictureBox2.Image = gazou(2)
                PictureBox4.Image = gazou(3)
                PictureBox5.Image = gazou(4)
                PictureBox11.Image = gazou(13)
                Me.Hide()
                Form1.Show()
        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class