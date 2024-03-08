Imports System.Threading
Imports System.IO
Imports System.Text
Public Class Form1
    Dim Images(2) As Image
    Dim Label_flg As Boolean = False
    Dim Songen_flg As Boolean = False
    Dim Start_flg As Boolean = False
    Dim Auto_flg As Boolean = False
    Dim sokudo As Integer = 100
    Dim v As Integer = 0
    Dim count2 As Integer = 0
    Dim count3 As Integer = 0
    Dim displayText As String = "エンターキーで会話を進められます。" ' 表示する文字列
    Dim currentIndex As Integer = 0
    Dim displayText2 As String = "スタートへ
戻りますか？" ' 表示する文字列
    Dim currentIndex2 As Integer = 0
    Dim ss() As String = {"(俺は制限時間以内に、
学校から出ることはかなわなかった。)", "(あの後結局脱出するための鍵は
何とか見つけられた。)", "(しかし腐敗していたのだ。)", "こんな短時間で！？", "そのような疑問が浮かぶが
その前にお迎えが来た。", "また会ったな。俺ティラノ！！", "ぎゃぁぁぁア！！？？", "熱烈な歓迎でうれしいよ
Mr.高橋。", "さて、俺がここまで来たのは
他でもない。", "お前に選択肢を与えに来た！", "何を言ってるんだ
こいつは…？", "まぁ聞けや。", "お前の選択肢は２つ", "これから俺達に食われるか
俺たちの専属料理人になるかだ。", "専属料理人だと！？", "あぁ、俺らの朝昼晩の3食…
あとは、３時におやつを作ってもらう。", "食材はもちろん
人間だ！！", "カニバリズムには協力できない！", "カニバリズムは人間が人間を
食うことなんだがな…", "協力しないのなら
惨たらしく殺す！", "ひえぇぇぇぇェ…", "お前らの食事で例えると
毎日刺身を食っているようなものなんだ。", "もしお前が毎日食事を作るのなら
お前の命は保証しよう！", "さぁどうする高橋！？", "料理人になるか死ぬか", "どちらか選べぃ！", "(どうしよう…)", "", "(こうして俺はティラノ共のとこで
働いた。)", "(「トロピカル血液ジュース」や
肉じゃがの人バージョンの「人じゃが」)", "(人肉ソーセージなどを作る日々だった)", "(やつらはヴィーガン精神の
かけらもない。)", "(もはや人の解体も無心で行えるように
なってしまった。)", "(俺の人間性が薄れていく…)", "(もはや心は決壊寸前。)", "(表面張力ぎりぎりまで
水が入ったコップのようだ。)", "オイッ高橋！
飯はまだか！", "はいっ！
すぐにお持ちします！", "もう限界だ！！
あのクソ・T・Rex がァ！！", "(だが刃物では敵わない。
この刃渡り15cmの鋭利な刃物で)", "(自ら命を
絶ってやる！)", "少年は自ら頸動脈と頸静脈に
斬撃器を突き刺した！", "アベシッ！！！", "高橋死んだ！", "誰がクソティーレックスだと！
このガキャー！！", "うわー！
こいつ死んでやがる！", "こうして高橋は
人生の終わりを迎えた！", "BAD END! その１
～高塚はマジ死～", "俺は人間だぞ！", "俺は人間だぞ！
人間の調理なんかするかよ！", "じゃあ
食い殺してやるよ！", "やってみろよ
バァ～カ！！", "その時、ティラノサウルスのかぎ爪が高橋の
脇腹を貫き首に噛みついた！", "これはティラノ真拳の基本の型でこれを用いて
太古の地球を征服したのだ！", "ぎゃあぁぁぁぁ
痛ってえぇぇぇぇぇ！", "ティラノなめんなァ！", "ティラノは高橋にとどめを刺し
高橋の断末魔がこだまする！", "ほわぁぁぁぁぁ！！！！", ""}
    Dim ss2() As String = {"[高橋]", "[高橋]", "[高橋]", "[高橋]", "[ナレーション]", "[ティラノサウルス]", "[高橋]", "[ティラノサウルス]", "[ティラノサウルス]", "[ティラノサウルス]", "[高橋]", "[ティラノサウルス]", "[ティラノサウルス]", "[ティラノサウルス]", "[高橋]", "[ティラノサウルス]", "[ティラノサウルス]", "[高橋]", "[ティラノサウルス]", "[ティラノサウルス]", "[高橋]", "[ティラノサウルス]", "[ティラノサウルス]", "[ティラノサウルス]", "[ティラノサウルス]", "[ティラノサウルス]", "[高橋]", " ", "[高橋]", "[高橋]", "[高橋]", "[高橋]", "[高橋]", "[高橋]", "[高橋]", "[高橋]", "[ティラノサウルス]", "[高橋]", "[高橋]", "[高橋]", "[高橋]", "[ナレーション]", "[高橋]", "[ナレーション]", "[ティラノサウルス]", "[ティラノサウルス]", "[ナレーション]", "[ナレーション]", "[高橋]", "[高橋]", "[ティラノサウルス]", "[高橋]", "[ナレーション]", "[ナレーション]", "[高橋]", "[ティラノサウルス]", "[ナレーション]", "[高橋]", " "}
    '料理人は47まで
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Using writer As New StreamWriter("visual.txt", False, Encoding.GetEncoding("Shift_JIS"))
            If File.Exists("visual.txt") Then
                writer.WriteLine("time_up")
            Else
                MessageBox.Show("ファイルが見つかりません")
            End If
        End Using
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Label13.Visible = False
        Label14.Visible = False
        Label19.Text = ""
        'PictureBox1.Image = Image.FromFile("新聞.jpg")
        Images(0) = Image.FromFile("学校の中.png")
        Images(1) = Image.FromFile("black.png")
        Images(2) = Image.FromFile("ティラノin学校.png")
        Timer1.Interval = 10
        Timer2.Interval = 100
        Timer1.Enabled = True
        Timer2.Enabled = True
        displayText = ss(count2)
        Label7.Text = ss2(count2)
        Label1.Text = ""
        Label6.Text = "▶1倍速"
        Label4.Text = "------------"
        Label3.Text = "------------"
        Label2.Text = "------------"
        Label8.Text = "------------"
        Label9.Text = "------------"
        Label10.Text = "------------"
        AddHandler Me.MouseWheel, AddressOf Form1_MouseWheel
    End Sub
    Private Sub Mojiyomi(h As Integer)
        If currentIndex < displayText.Length Then
            Thread.Sleep(h)
            Label1.Text &= displayText(currentIndex) ' 現在の位置の文字を追加
            currentIndex += 1
        ElseIf Auto_flg = False Then
            Label17.Visible = True
        End If

    End Sub
    Private Sub Mojiyomi2()
        If currentIndex2 < displayText2.Length Then
            Thread.Sleep(100)
            Label19.Text &= displayText2(currentIndex2) ' 現在の位置の文字を追加
            currentIndex2 += 1
        Else
            Label20.Visible = True
            Label21.Visible = True
        End If

    End Sub
    Private Sub Tugi()
        Label17.Visible = False
        Label1.Text = ""
        currentIndex = 0
        count2 += 1
        displayText = ss(count2)
        Label7.Text = ss2(count2)
        count3 = count2
        v = count3 - 3
        Serekuto()
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter And Label_flg = False And Auto_flg = False And Not count2 = 27 And Not count2 = 47 And count2 < 57 Then
            Tugi()
        ElseIf count2 = 47 Then
            Try
                Process.Start("start2.exe")
                Application.Exit()
            Catch ex As Exception
                MessageBox.Show("ファイルが開けませんでした:" & ex.Message)
                Application.Exit()
            End Try
        ElseIf count2 = 57 Then
            Try
                Process.Start("Game Over.exe")
                Application.Exit()
            Catch ex As Exception
                MessageBox.Show("ファイルが開けませんでした:" & ex.Message)
                Application.Exit()
            End Try
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label12.Text = count2
        If Start_flg = True Then
            Label19.Visible = True
            Mojiyomi2()
        Else
            Label19.Visible = False
            Label20.Visible = False
            Label21.Visible = False
            Label19.Text = ""
            currentIndex2 = 0
            Mojiyomi(sokudo)
        End If
        Select Case count2
            Case 0
                PictureBox1.Image = Images(0)
            Case 5
                PictureBox1.Image = Images(2)
            Case 27
                Label11.ForeColor = Color.White
                Label17.Visible = False
                Timer1.Stop()
                Auto_flg = False
                'Timer2.Stop()
                Label13.Visible = True
                Label14.Visible = True
            Case 47
                Label17.Visible = False
                Auto_flg = False
                Label11.ForeColor = Color.White
                Label15.Visible = True
            Case 52
                PictureBox1.Image = Images(1)
            Case 57
                Label17.Visible = False
                Auto_flg = False
                Label11.ForeColor = Color.White
                Label15.Text = "高橋は死ぬ！"
                Label15.Visible = True
        End Select


    End Sub



    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        If Label_flg = False Then
            PictureBox3.Visible = True
            Label16.Visible = True
            Label4.Visible = True
            Label3.Visible = True
            Label2.Visible = True
            Label8.Visible = True
            Label9.Visible = True
            Label10.Visible = True
            Label_flg = True
            Label5.ForeColor = Color.Red
        Else
            Label5.ForeColor = Color.White
            PictureBox3.Visible = False
            Label_flg = False
            Label16.Visible = False
            Label4.Visible = False
            Label3.Visible = False
            Label2.Visible = False
            Label8.Visible = False
            Label9.Visible = False
            Label10.Visible = False
            Label18.ForeColor = Color.White
        End If



    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Select Case sokudo
            Case 50
                sokudo = 25
                Label6.Text = "▶▶2倍速"
            Case 25
                sokudo = 100
                Label6.Text = "0.5倍速"
            Case 100
                sokudo = 50
                Label6.Text = "▶1倍速"
        End Select


    End Sub
    Private Sub Serekuto()
        Select Case v
            Case -3
                Label4.Text = "------------"
                Label3.Text = "------------"
                Label2.Text = "------------"
                Label8.Text = "------------"
                Label9.Text = "------------"
                Label10.Text = "------------"
            Case -2
                Label4.Text = "------------"
                Label3.Text = "------------"
                Label2.Text = ss(count3 - 1)
                Label8.Text = "------------"
                Label9.Text = "------------"
                Label10.Text = ss2(count3 - 1)
            Case -1
                Label4.Text = "------------"
                Label3.Text = ss(count3 - 2)
                Label2.Text = ss(count3 - 1)
                Label8.Text = "------------"
                Label9.Text = ss2(count3 - 2)
                Label10.Text = ss2(count3 - 1)
            Case >= 0
                Label4.Text = ss(count3 - 3)
                    Label3.Text = ss(count3 - 2)
                    Label2.Text = ss(count3 - 1)
                    Label8.Text = ss2(count3 - 3)
                    Label9.Text = ss2(count3 - 2)
                Label10.Text = ss2(count3 - 1)
        End Select
    End Sub
    Private Sub Form1_MouseWheel(sender As Object, e As MouseEventArgs)
        If e.Delta > 0 And count3 - 4 >= 0 Then
            count3 -= 1
            Serekuto()
        ElseIf e.Delta <= 0 And count3 < count2 Then
            count3 += 1
            Serekuto()
        End If
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        If count2 = 27 Or count2 = 47 Or count2 = 57 Then
            Label11.ForeColor = Color.White
            Auto_flg = False
        Else
            If Auto_flg = False Then
                Label11.ForeColor = Color.Red
                Auto_flg = True
            ElseIf Auto_flg = True Then
                Label11.ForeColor = Color.White
                Auto_flg = False
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Auto_flg = True And currentIndex >= displayText.Length And Label_flg = False Then
            Thread.Sleep(800)
            Tugi()
        End If
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        'Songen_flg = True
        Timer1.Start()
        count2 = 48
        count3 = 48
        Tugi()
        ss(count3 - 1) = "-> 人としての尊厳を守る"
        ss2(count3 - 1) = "[高橋]"
        Label14.Visible = False
        Label13.Visible = False
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Timer1.Start()
        PictureBox1.Image = Images(1)
        Tugi()
        ss(count3 - 1) = "-> 専属料理人になる"
        ss2(count3 - 1) = "[高橋]"
        Label14.Visible = False
        Label13.Visible = False
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Start_flg = True
        Label18.ForeColor = Color.Red
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        Start_flg = False
        Label18.ForeColor = Color.White
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        Try
            Process.Start("start2.exe")
            Application.Exit()
        Catch ex As Exception
            MessageBox.Show("ファイルが開けませんでした:" & ex.Message)
        End Try
    End Sub

    Private Sub Label20_MouseLeave(sender As Object, e As EventArgs) Handles Label20.MouseLeave
        If Not Label20.ClientRectangle.Contains(Label20.PointToClient(MousePosition)) Then
            Label20.ForeColor = Color.White
        End If
    End Sub

    Private Sub Label20_MouseEnter(sender As Object, e As EventArgs) Handles Label20.MouseEnter
        Label20.ForeColor = Color.Red
    End Sub
    Private Sub Label21_MouseLeave(sender As Object, e As EventArgs) Handles Label21.MouseLeave
        If Not Label21.ClientRectangle.Contains(Label21.PointToClient(MousePosition)) Then
            Label21.ForeColor = Color.White
        End If
    End Sub

    Private Sub Label21_MouseEnter(sender As Object, e As EventArgs) Handles Label21.MouseEnter
        Label21.ForeColor = Color.Red
    End Sub
    Private Sub Label13_MouseLeave(sender As Object, e As EventArgs) Handles Label13.MouseLeave
        If Not Label13.ClientRectangle.Contains(Label13.PointToClient(MousePosition)) Then
            Label13.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Label14_MouseEnter(sender As Object, e As EventArgs) Handles Label14.MouseEnter
        Label14.ForeColor = Color.Red
    End Sub
    Private Sub Label14_MouseLeave(sender As Object, e As EventArgs) Handles Label14.MouseLeave
        If Not Label14.ClientRectangle.Contains(Label14.PointToClient(MousePosition)) Then
            Label14.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Label13_MouseEnter(sender As Object, e As EventArgs) Handles Label13.MouseEnter
        Label13.ForeColor = Color.Red
    End Sub
End Class

