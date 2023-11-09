Imports System.IO
Imports System.Text
Imports System.Media
Public Class Settei
    Dim count As Integer = 0
    Dim count2 As Integer = 0
    Dim str As String = ""
    Dim ss() As String = {"1", "2", "3"}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Stop()
        Timer2.Enabled = True
        Label8.Visible = False
        My.Computer.Audio.Play("何作ってるんだっけ.wav")
        PictureBox1.Image = Image.FromFile("U:\github\tet\実物\画像\設定画面.png")
        Label5.Text = "文字にカーソルを合わせると"
        Label6.Text = "説明文が出ます。1234"
        DomainUpDown1.Text = ss(0)
        DomainUpDown1.Items.Add(ss(0))
        DomainUpDown1.Items.Add(ss(1))
        DomainUpDown1.Items.Add(ss(2))
        DomainUpDown2.Text = ss(0)
        DomainUpDown2.Items.Add(ss(0))
        DomainUpDown2.Items.Add(ss(1))
        DomainUpDown2.Items.Add(ss(2))
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using writer As New StreamWriter("test2.txt", False, Encoding.GetEncoding("Shift_JIS"))
            If File.Exists("test2.txt") Then
                If TextBox1.Text = "1" And DomainUpDown1.Text = ss(1) And DomainUpDown2.Text = ss(2) And TextBox4.Text = "4" Then
                    writer.WriteLine("teki=" + "10")
                    writer.WriteLine("time=" + "999")
                    writer.WriteLine("speed=" + "5")
                    Label5.Text = "隠しコマンドが入力されました。"
                    Label6.Text = "書き込みに成功しました。"
                Else
                    writer.WriteLine("teki=" + TextBox1.Text)
                    If DomainUpDown1.Text = ss(0) Then
                        writer.WriteLine("time=" + "300")
                    ElseIf DomainUpDown1.Text = ss(1) Then
                        writer.WriteLine("time=" + "180")
                    ElseIf DomainUpDown1.Text = ss(2) Then
                        writer.WriteLine("time=" + "30")
                    End If
                    If DomainUpDown2.Text = ss(0) Then
                        writer.WriteLine("speed=" + "4")
                    ElseIf DomainUpDown2.Text = ss(1) Then
                        writer.WriteLine("speed=" + "3")
                    ElseIf DomainUpDown2.Text = ss(2) Then
                        writer.WriteLine("speed=" + "2")
                    End If
                    writer.WriteLine("アイテムの数=" + TextBox4.Text)
                    Label5.Text = "書き込みに成功しました。"
                    Label6.Text = ""
                End If
            Else
                    Label5.Text = "申し訳ございません。"
                Label6.Text = "書き込みに失敗しました。"
            End If

        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        Label1.ForeColor = Color.Red
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        If Not Label1.ClientRectangle.Contains(Label1.PointToClient(MousePosition)) Then
            Label1.ForeColor = Color.White
        End If
    End Sub
    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter
        Label2.ForeColor = Color.Red
        Label5.Text = "制限時間を調整します。"
        Label6.Text = "数字を大きくするほど、制限時間が減ります。"
    End Sub
    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        If Not Label2.ClientRectangle.Contains(Label2.PointToClient(MousePosition)) Then
            Label2.ForeColor = Color.White
            Label5.Text = "文字にカーソルを合わせると"
            Label6.Text = "説明文が出ます。"
        End If
    End Sub
    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter
        Label3.ForeColor = Color.Red
        Label5.Text = "ティラノのスピードを変更します。標準は２です。"
        Label6.Text = ""
    End Sub
    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        If Not Label3.ClientRectangle.Contains(Label3.PointToClient(MousePosition)) Then
            Label3.ForeColor = Color.White
            Label5.Text = "文字にカーソルを合わせると"
            Label6.Text = "説明文が出ます。"
        End If
    End Sub
    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        Label4.ForeColor = Color.Red
    End Sub
    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        If Not Label4.ClientRectangle.Contains(Label4.PointToClient(MousePosition)) Then
            Label4.ForeColor = Color.White
        End If
    End Sub

    Private Sub DownUPDown1_MouseEnter(sender As Object, e As EventArgs) Handles DomainUpDown1.MouseEnter
        Label5.Text = "制限時間を調整します。"
        Label6.Text = "数字を大きくするほど、制限時間が減ります。"
    End Sub

    Private Sub DownUPDown1_MouseLeave(sender As Object, e As EventArgs) Handles DomainUpDown1.MouseLeave
        If Not DomainUpDown1.ClientRectangle.Contains(DomainUpDown1.PointToClient(MousePosition)) Then
            Label5.Text = "文字にカーソルを合わせると"
            Label6.Text = "説明文が出ます。"
        End If
    End Sub
    Private Sub DownUPDown2_MouseEnter(sender As Object, e As EventArgs) Handles DomainUpDown2.MouseEnter
        Label5.Text = "ティラノのスピードを変更します。標準は２です。"
        Label6.Text = ""
    End Sub
    Private Sub DownUPDown2_MouseLeave(sender As Object, e As EventArgs) Handles DomainUpDown2.MouseLeave
        If Not DomainUpDown2.ClientRectangle.Contains(DomainUpDown2.PointToClient(MousePosition)) Then
            Label5.Text = "文字にカーソルを合わせると"
            Label6.Text = "説明文が出ます。"
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        count += 1
        If count <= 5 Then
            PictureBox1.Image = Image.FromFile("U:\github\tet\実物\画像\光るティラノ.png")
        ElseIf count >= 6 Then
            count = 0
            PictureBox1.Image = Image.FromFile("U:\github\tet\実物\画像\設定画面.png")
            Label5.Text = "文字にカーソルを合わせると"
            Label6.Text = "説明文が出ます1234。"
            My.Computer.Audio.Stop()
            My.Computer.Audio.Play("ホーム画面の音楽.wav")
            Me.Hide()
            Form1.Show()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label8.Text = count2
        count2 += 1
        If count2 = 340 Then
            My.Computer.Audio.Play("何作ってるんだっけ.wav")
        End If
    End Sub
End Class
