Imports System.IO
Imports System.Text
Imports System.Media
Public Class Settei
    Dim count As Integer = 0
    Dim count2 As Integer = 0
    Dim str As String = ""
    Dim ss() As String = {"3分", "30分", "50分"}
    Dim ss2() As String = {"ナマケモノ", "凡庸", "生き急ぎ"}
    Dim flg As Integer = 0
    Dim selects As Integer = 1
    Dim selects2 As Integer = 1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Stop()
        Label12.Visible = False
        Label13.Visible = False
        Timer1.Enabled = False
        Timer2.Interval = 1000
        Label7.BackColor = Color.FromArgb(72, 65, 65)
        Label11.BackColor = Color.FromArgb(0, 0, 0)
        Label5.BackColor = Color.FromArgb(72, 65, 65)
        Label6.BackColor = Color.FromArgb(72, 65, 65)
        Timer2.Enabled = True
        Label8.Visible = False
        My.Computer.Audio.Play("何作ってるんだっけ.wav")
        PictureBox1.Image = Image.FromFile("設定画面.png")
        Label5.Text = "文字にカーソルを合わせると"
        Label6.Text = "説明文が出ます。"
        DomainUpDown1.Text = ss(1)
        DomainUpDown1.Items.Add(ss(0))
        DomainUpDown1.Items.Add(ss(1))
        DomainUpDown1.Items.Add(ss(2))
        DomainUpDown2.Text = ss2(1)
        DomainUpDown2.Items.Add(ss2(0))
        DomainUpDown2.Items.Add(ss2(1))
        DomainUpDown2.Items.Add(ss2(2))
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using writer As New StreamWriter("test2.txt", False, Encoding.GetEncoding("Shift_JIS"))
            If File.Exists("test2.txt") Then
                If TextBox4.Text = "4" Then
                    Label11.Visible = False
                    Label9.Visible = False
                    Label12.Visible = False
                    Label10.Visible = False
                    Label13.Visible = False
                    DomainUpDown1.Text = "やばいぜ！"
                    DomainUpDown2.Text = "祟り祟り！！"
                    writer.WriteLine("teki=" + DomainUpDown3.Text)
                    writer.WriteLine("time=" + "5996")
                    writer.WriteLine("speed=" + "-9")
                    writer.WriteLine("mu=" + "4")
                    Label5.Text = "「どうして君はこうなんだ…」"
                    Label6.Text = "ティラノサウルスの蹂躙が始まる！"
                    flg = 1
                    My.Computer.Audio.Play("逃げ惑う人々.wav")
                    PictureBox1.Image = Image.FromFile("光るティラノ.png")
                Else
                    writer.WriteLine("teki=" + DomainUpDown3.Text)
                    If DomainUpDown1.Text = ss(0) Then
                        writer.WriteLine("time=" + "3000")
                    ElseIf DomainUpDown1.Text = ss(1) Then
                        writer.WriteLine("time=" + "1800")
                    ElseIf DomainUpDown1.Text = ss(2) Then
                        writer.WriteLine("time=" + "180")
                    Else
                        writer.WriteLine("time=" + "1800")
                    End If
                    If DomainUpDown2.Text = ss2(0) Then
                        writer.WriteLine("speed=" + "1")
                    ElseIf DomainUpDown2.Text = ss(1) Then
                        writer.WriteLine("speed=" + "4")
                    ElseIf DomainUpDown2.Text = ss(2) Then
                        writer.WriteLine("speed=" + "9")
                    Else
                        writer.WriteLine("speed=" + "4")
                    End If
                    writer.WriteLine("mu=" + TextBox4.Text)
                    Label5.Text = "書き込みに成功しました。"
                    Label6.Text = ""
                End If
            Else
                Label5.Text = "申し訳ございません。"
                Label6.Text = "書き込みに失敗しました。"
            End If

        End Using
    End Sub
    Private Sub Mouse_Leave(i As Integer, v As Integer)
        If v = 1 And i > 0 Then
            Controls("Label" & CStr(i)).ForeColor = Color.White
        End If
        Label5.Text = "敵の数などにカーソルを合わせると"
        Label6.Text = "説明文が出ます。"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = True
        If flg = 0 Then
            My.Computer.Audio.Play("hikaru.wav")
        End If
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        Label1.ForeColor = Color.Red
        Label5.Text = "これは一体何なのか！？"
        Label6.Text = "ご期待ください。"
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        If Not Label1.ClientRectangle.Contains(Label1.PointToClient(MousePosition)) Then
            Mouse_Leave(1, 1)
        End If
    End Sub
    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter
        Label2.ForeColor = Color.Red
        Label5.Text = "制限時間を調整します。"
        Label6.Text = "最大で５０分です。"
    End Sub
    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        If Not Label2.ClientRectangle.Contains(Label2.PointToClient(MousePosition)) Then
            Mouse_Leave(2, 1)
        End If
    End Sub
    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter
        Label3.ForeColor = Color.Red
        Label5.Text = "主人公のスピードを変更します。標準は「凡庸」です。"
        Label6.Text = "遅い順で「ナマケモノ → 凡庸 → 生き急ぎ」です。"
    End Sub
    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        If Not Label3.ClientRectangle.Contains(Label3.PointToClient(MousePosition)) Then
            Mouse_Leave(3, 1)
        End If
    End Sub
    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        Label4.ForeColor = Color.Red
        Label5.Text = "特に意味はなさそうだ。"
        Label6.Text = "～三の次の数示唆なり。～"
    End Sub
    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        If Not Label4.ClientRectangle.Contains(Label4.PointToClient(MousePosition)) Then
            Mouse_Leave(4, 1)
        End If
    End Sub

    Private Sub DownUPDown1_MouseEnter(sender As Object, e As EventArgs) Handles DomainUpDown1.MouseEnter
        Label5.Text = "制限時間を調整します。"
        Label6.Text = "最大で５０分です。"
    End Sub

    Private Sub DownUPDown1_MouseLeave(sender As Object, e As EventArgs) Handles DomainUpDown1.MouseLeave
        If Not DomainUpDown1.ClientRectangle.Contains(DomainUpDown1.PointToClient(MousePosition)) Then
            Mouse_Leave(0, 0)
        End If
    End Sub
    Private Sub DownUPDown2_MouseEnter(sender As Object, e As EventArgs) Handles DomainUpDown2.MouseEnter
        Label5.Text = "主人公のスピードを変更します。標準は凡庸です。"
        Label6.Text = "遅い順で「ナマケモノ → 凡庸 → 生き急ぎ」です。"
    End Sub
    Private Sub DownUPDown2_MouseLeave(sender As Object, e As EventArgs) Handles DomainUpDown2.MouseLeave
        If Not DomainUpDown2.ClientRectangle.Contains(DomainUpDown2.PointToClient(MousePosition)) Then
            Mouse_Leave(0, 0)
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        count += 1
        If count <= 15 Then
            Label11.Visible = False
            Label9.Visible = False
            Label12.Visible = False
            Label10.Visible = False
            Label13.Visible = False
            PictureBox1.Image = Image.FromFile("光るティラノ.png")
            Label5.Text = "うわぁぁぁア！？光ってる！"
            Label6.Text = "怖い！！"
        ElseIf count >= 16 Then
            PictureBox1.Image = Image.FromFile("設定画面.png")
            Mouse_Leave(0, 0)
            My.Computer.Audio.Stop()
            Me.Hide()
            Timer1.Stop()
            count = 0
            Form1.Show()
            Timer1.Enabled = False
            count2 = 0
            Timer2.Stop()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        count2 += 1
        If Timer1.Enabled = False Then
            If TextBox4.Text = "4" Then

            Else
                Label9.Visible = True
                Label10.Visible = True
                Label11.Visible = True
                Select Case DomainUpDown1.Text
                    Case ss(0)
                        Label9.Left = 1
                        Label9.Text = "マジで？"
                        Label12.Text = "ラーメンでも作るの？"
                        Label12.Visible = True
                        Label9.Font = New Font(Label9.Font.FontFamily, 15, Label9.Font.Style)
                    Case ss(1)
                        Label9.Left = 95
                        Label9.Text = "30分→"
                        Label9.Font = New Font(Label9.Font.FontFamily, 20, Label9.Font.Style)
                        Label12.Visible = False
                    Case ss(2)
                        Label9.Left = 1
                        Label9.Font = New Font(Label9.Font.FontFamily, 15, Label9.Font.Style)
                        Label9.Text = "人間の集中力は"
                        Label12.Visible = True
                        Label12.Text = "最大で50分らしい"
                    Case "やばいぜ！"
                        Label9.Left = 1
                        Label9.Font = New Font(Label9.Font.FontFamily, 15, Label9.Font.Style)
                        Label9.Text = "思いとどまって"
                        Label12.Visible = True
                        Label12.Text = "くれてよかった"

                End Select
                Select Case DomainUpDown2.Text
                    Case ss2(0)
                        Label10.Left = 1
                        Label10.Text = "ティラノより遅い。"
                        Label10.Font = New Font(Label10.Font.FontFamily, 15, Label10.Font.Style)
                        Label13.Visible = True
                        Label13.Text = "食物連鎖の下層向け。"
                    Case ss2(1)
                        Label10.Text = "凡庸→"
                        Label10.Left = 95
                        Label10.Font = New Font(Label10.Font.FontFamily, 20, Label10.Font.Style)
                        Label13.Visible = False
                    Case ss2(2)
                        Label10.Left = 1
                        Label10.Text = "圧倒的なスピードは"
                        Label13.Visible = True
                        Label10.Font = New Font(Label10.Font.FontFamily, 15, Label10.Font.Style)
                        Label13.Text = "ティラノを凌駕する！"
                    Case "祟り祟り！！"
                        Label10.Left = 1
                        Label10.Text = "あのままでは"
                        Label13.Visible = True
                        Label10.Font = New Font(Label10.Font.FontFamily, 15, Label10.Font.Style)
                        Label13.Text = "破滅しかなかった"

                End Select
            End If
        End If
            If count2 >= 34 Then
            My.Computer.Audio.Stop()
            My.Computer.Audio.Play("何作ってるんだっけ.wav")
            count2 = 0
        End If
    End Sub

    Private Sub Settei_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        My.Computer.Audio.Play("何作ってるんだっけ.wav")
        If TextBox4.Text = "4" Then
            Label9.Visible = False
            Label10.Visible = False
            Label11.Visible = False
        Else
            Label9.Visible = True
            Label10.Visible = True
            Label11.Visible = True
        End If
        Timer2.Start()
        count2 = 0
    End Sub

    Private Sub DomainUpDown3_MouseEnter(sender As Object, e As EventArgs) Handles DomainUpDown3.MouseEnter

        Label5.Text = "これは一体何なのか！？"
        Label6.Text = "ご期待ください。"
    End Sub

    Private Sub DomainUpDown3_MouseLeave(sender As Object, e As EventArgs) Handles DomainUpDown3.MouseLeave
        If Not DomainUpDown3.ClientRectangle.Contains(DomainUpDown3.PointToClient(MousePosition)) Then
            Mouse_Leave(0, 0)
        End If
    End Sub

    Private Sub TextBox4_MouseEnter(sender As Object, e As EventArgs) Handles TextBox4.MouseEnter
        Label5.Text = "特に意味はなさそうだ。"
        Label6.Text = "～三の次の数示唆なり。～"
    End Sub

    Private Sub TextBox4_MouseLeave(sender As Object, e As EventArgs) Handles TextBox4.MouseLeave
        Mouse_Leave(0, 0)
    End Sub

    Private Sub Label7_MouseEnter(sender As Object, e As EventArgs) Handles Label7.MouseEnter
        Label5.Text = "なんだ設定画面か！"
        Label6.Text = "驚かしやがってよォ！"
    End Sub

    Private Sub Label7_MouseLeave(sender As Object, e As EventArgs) Handles Label7.MouseLeave
        If Not Label7.ClientRectangle.Contains(Label7.PointToClient(MousePosition)) Then
            Mouse_Leave(7, 1)
            Label7.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Label11_MouseEnter(sender As Object, e As EventArgs) Handles Label11.MouseEnter
        Label5.Text = "初めての方にオススメな"
        Label6.Text = "制限時間などです。"
    End Sub

    Private Sub Label11_MouseLeave(sender As Object, e As EventArgs) Handles Label11.MouseLeave
        Mouse_Leave(7, 1)
        Label7.ForeColor = Color.Red
    End Sub
End Class
