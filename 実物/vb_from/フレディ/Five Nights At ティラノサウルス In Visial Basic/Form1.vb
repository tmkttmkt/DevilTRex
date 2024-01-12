Imports System.Threading
Imports System.Random
Imports System.Drawing
Public Class Form1
    Dim Gamen_flg = False
    Dim Shatta_flg = False
    Dim Doutai_flg1 = False
    Dim Doutai_flg2 = False
    Dim Doutai_flg3 = False
    Dim Doutai_flg5 = False
    Dim camera_flg1 = False
    Dim T_Location As Integer = 2
    Dim xs(3) As Integer
    Dim ys(3) As Integer
    Dim xs2() As Integer = {498}
    Dim ys2() As Integer = {175}
    Dim Kankaku As Integer = 100
    Dim denci As Integer = 100
    Dim r As New Random()
    Dim x_2 As Integer = 0
    Dim y_2 As Integer = 0
    Dim Tomare As Integer = 0
    Dim T_number As Integer = 22
    Dim root As Integer = 3



    'Dim gage_value As Integer = 0
    Dim Images(5) As Image
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0
        xs(0) = 489
        xs(1) = 523
        xs(2) = 570
        xs(3) = 664
        ys(0) = 83
        ys(1) = 143
        ys(2) = 104
        ys(3) = 216
        Gamens(False)
        'PictureBox2.Visible = True
        Label19.Text = "100%"
        Label21.Text = "0 AM"
        Timer1.Interval = 1000
        Timer2.Interval = 2000
        Timer3.Interval = 60000
        Timer5.Interval = 8000
        Timer1.Enabled = True
        Timer3.Enabled = True
        Images(0) = Image.FromFile("Desktop.jpg")
        Images(1) = Image.FromFile("学校13.gif")
        Images(2) = Image.FromFile("学校14.gif") '
        Images(3) = Image.FromFile("Form.png") '
        Images(4) = Image.FromFile("Form_up.png")
        PictureBox3.Image = Images(3)
        PictureBox4.Image = Images(4)
        PictureBox5.Visible = False
        PictureBox6.Image = Images(3)
        PictureBox8.Image = Images(3)
        Timer5.Enabled = True
    End Sub
    Private Sub Home()
        Label20.Visible = True

    End Sub
    Private Function Aruku(Number As String, x As Integer, y As Integer) As Boolean
        If Tomare < Number Then
            Dim Numbers As String = Number
            Randomize()
            Dim x2 As Integer = Controls("Label" & CStr(Numbers)).Location.X
            Dim y2 As Integer = Controls("Label" & CStr(Numbers)).Location.Y
            Dim raberu_x = Controls("Label" & CStr(Numbers)).Location.X
            Dim raberu_y = Controls("Label" & CStr(Numbers)).Location.Y
            Dim End_flg_x As Boolean = False
            Dim End_flg_y As Boolean = False
            Timer5.Stop()
            If End_flg_x = False Then
                If x2 < x Then
                    x2 += 1
                    Controls("Label" & CStr(Numbers)).Location = New Point(x2, raberu_y)
                    Threading.Thread.Sleep(100)
                    '   Application.DoEvents()
                End If
                If x2 > x Then
                    x2 -= 1
                    Controls("Label" & CStr(Numbers)).Location = New Point(x2, raberu_y)
                    Threading.Thread.Sleep(100)
                    '    Application.DoEvents()
                End If
                If x2 = x Then
                    End_flg_x = True
                End If
            End If
            If End_flg_y = False Then
                If y2 < y Then
                    y2 += 1
                    Controls("Label" & CStr(Numbers)).Location = New Point(raberu_x, y2)
                    Threading.Thread.Sleep(100)
                    '  Application.DoEvents()
                End If
                If y2 > y Then
                    y2 -= 1
                    Controls("Label" & CStr(Numbers)).Location = New Point(raberu_x, y2)
                    Threading.Thread.Sleep(100)
                    '  Application.DoEvents()
                End If
                If y2 = y Then
                    End_flg_y = True
                End If
            End If
            If End_flg_x = True And End_flg_y = True Then
                Return True
                ' Make_random(1)
            End If
            Return False
        End If
    End Function
    Private Function Move_telirano(Number As String, x As Integer, y As Integer) As Boolean
        Dim Numbers As String = Number
        '  Aruku(Numbers, x, y)
        '    Return Aruku(Numbers, x, y)
    End Function
    Private Sub Select_Rex(Number As String)
        Dim r As New Random()
        Dim bango As Integer = r.Next(1, 2)
        Dim Taiki As Integer = r.Next(1000, 5000)
        Dim koudou As Integer = 3
        x_2 = r.Next(xs(Number - 1), xs(Number))
        y_2 = r.Next(ys(Number - 1), ys(Number))
        Label26.Text = koudou
        Label27.Text = bango
        Select Case koudou
            Case 1
                Timer5.Stop()
                Thread.Sleep(Taiki)
                Timer5.Start()
            Case 2
                Timer5.Stop()
                    Timer4.Enabled = True
                Timer4.Start()
            Case 3
                Timer5.Stop()
                root = 1
                koudou = 2
                Thread.Sleep(50)
                Timer5.Start()
        End Select
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ' グラフィックスオブジェクトを取得
        Dim g As Graphics = e.Graphics

        ' 描画する四角形の位置とサイズを指定
        Dim rectangleBounds As New Rectangle(485, 52, 317, 326)
        Dim rectangleBounds2 As New Rectangle(560, 104, 137, 131)
        Dim rectangleBounds3 As New Rectangle(707, 94, 53, 205)
        Dim rectangleBounds4 As New Rectangle(610, 305, 72, 58)
        Dim rectangleBounds5 As New Rectangle(511, 252, 74, 98)
        Dim rectangleBounds6 As New Rectangle(707, 318, 41, 45)
        Dim rectangleBounds7 As New Rectangle(617, 252, 53, 31)
        Dim rectangleBounds8 As New Rectangle(498, 134, 40, 68)
        Dim rectangleBounds9 As New Rectangle(498, 71, 53, 57)

        ' 白い枠線の黒い四角形を描画
        If Gamen_flg = True Then

            Using pen As New Pen(Color.Red, 2) ' 枠線の色と幅を指定
                Using brush As New SolidBrush(Color.Black) ' 塗りつぶしの色を指定
                    g.FillRectangle(brush, rectangleBounds) ' 四角形を塗りつぶす
                    g.DrawRectangle(pen, rectangleBounds) ' 枠線を描画
                End Using
            End Using
            Using pen As New Pen(Color.Blue, 2) ' 枠線の色と幅を指定
                Using brush As New SolidBrush(Color.Black) ' 塗りつぶしの色を指定
                    g.FillRectangle(brush, rectangleBounds2) ' 四角形を塗りつぶす
                    If Doutai_flg5 = True Then
                        Using pen2 As New Pen(Color.Yellow, 2)
                            g.DrawRectangle(pen2, rectangleBounds2)
                        End Using
                    Else
                        g.DrawRectangle(pen, rectangleBounds2)
                    End If ' 枠線を描画
                End Using
            End Using
            Using pen As New Pen(Color.Green, 2) ' 枠線の色と幅を指定
                Using brush As New SolidBrush(Color.Black) ' 塗りつぶしの色を指定
                    g.FillRectangle(brush, rectangleBounds3)
                    If Doutai_flg3 = True Then
                        Using pen2 As New Pen(Color.Yellow, 2)
                            g.DrawRectangle(pen2, rectangleBounds3)
                        End Using
                    Else
                        g.DrawRectangle(pen, rectangleBounds3)
                    End If ' 四角形を塗りつぶす ' 枠線を描画
                End Using
            End Using
            Using pen As New Pen(Color.White, 2) ' 枠線の色と幅を指定
                Using brush As New SolidBrush(Color.Black) ' 塗りつぶしの色を指定
                    g.FillRectangle(brush, rectangleBounds4) ' 四角形を塗りつぶす
                    g.DrawRectangle(pen, rectangleBounds4) ' 枠線を描画
                End Using
            End Using
            Using pen As New Pen(Color.Purple, 2) ' 枠線の色と幅を指定
                Using brush As New SolidBrush(Color.Black) ' 塗りつぶしの色を指定
                    g.FillRectangle(brush, rectangleBounds5) ' 四角形を塗りつぶす
                    g.DrawRectangle(pen, rectangleBounds5) ' 枠線を描画
                End Using
            End Using
            Using pen As New Pen(Color.Gold, 2) ' 枠線の色と幅を指定
                Using brush As New SolidBrush(Color.Black) ' 塗りつぶしの色を指定
                    g.FillRectangle(brush, rectangleBounds6)
                    If Doutai_flg2 = True Then
                        Using pen2 As New Pen(Color.Yellow, 2)
                            g.DrawRectangle(pen2, rectangleBounds6)
                        End Using
                    Else
                        g.DrawRectangle(pen, rectangleBounds6)
                    End If ' 四角形を塗りつぶす ' 枠線を描画
                End Using
            End Using
            Using pen As New Pen(Color.Silver, 2) ' 枠線の色と幅を指定
                Using brush As New SolidBrush(Color.Black) ' 塗りつぶしの色を指定
                    g.FillRectangle(brush, rectangleBounds7) ' 四角形を塗りつぶす
                    g.DrawRectangle(pen, rectangleBounds7) ' 枠線を描画
                End Using
            End Using
            Using pen As New Pen(Color.Pink, 2) ' 枠線の色と幅を指定
                Using brush As New SolidBrush(Color.Black) ' 塗りつぶしの色を指定
                    g.FillRectangle(brush, rectangleBounds8) ' 四角形を塗りつぶす
                    g.DrawRectangle(pen, rectangleBounds8) ' 枠線を描画
                End Using
            End Using
            Using pen As New Pen(Color.Orange, 2) ' 枠線の色と幅を指定
                Using brush As New SolidBrush(Color.Black)
                    ' 塗りつぶしの色を指定
                    g.FillRectangle(brush, rectangleBounds9)
                    ' 四角形を塗りつぶす
                    If Doutai_flg1 = True Then
                        Using pen2 As New Pen(Color.Yellow, 2)
                            g.DrawRectangle(pen2, rectangleBounds9)
                        End Using
                    Else
                        g.DrawRectangle(pen, rectangleBounds9)
                    End If ' 枠線を描画
                End Using
            End Using
        End If
    End Sub
    Private Sub Gamens(flg As Boolean) ' As Boolean
        PictureBox1.Visible = flg
        PictureBox2.Visible = Not (flg)
        PictureBox3.Visible = flg
        ProgressBar1.Visible = flg
        PictureBox4.Visible = flg
        PictureBox5.Visible = flg
        PictureBox6.Visible = flg
        PictureBox7.Visible = flg
        PictureBox8.Visible = flg
        Label2.Visible = flg
        Label4.Visible = flg
        Label5.Visible = flg
        Label6.Visible = flg
        Label7.Visible = flg
        Label8.Visible = flg
        Label9.Visible = flg
        Label10.Visible = flg
        Label11.Visible = flg
        Label12.Visible = flg
        Label13.Visible = flg
        Label14.Visible = flg
        Label15.Visible = flg
        Label16.Visible = flg
        Label17.Visible = flg
        Label18.Visible = flg
        Label20.Visible = Not (flg)
        If camera_flg1 = True Then
            Label3.Visible = False
        Else
            Label3.Visible = flg
        End If

        ' PictureBox6.Visible = flg
        'Return flg
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If Gamen_flg = False Then
            Gamens(True)
            Gamen_flg = True
            Me.Invalidate()
        Else
            Gamens(False)
            Gamen_flg = False
        End If

    End Sub
    Private Sub Camera_on(bango As Integer)
        camera_flg1 = True
        Label3.Visible = False
        PictureBox1.Image = Images(bango)
    End Sub



    Private Sub Cam1_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If camera_flg1 = False And PictureBox3.Visible = True Then
            Label3.Visible = False
            camera_flg1 = True
            Camera_on(1)
            Label2.BackColor = Color.Yellow
            PictureBox1.Visible = True
        Else
            Label3.Visible = True
            camera_flg1 = False
            Label2.BackColor = Color.White
            PictureBox1.Visible = False
        End If
    End Sub





    Private Sub Cam6_Click(sender As Object, e As EventArgs) Handles Label8.Click
        ' Camera_on(14)
        If Doutai_flg2 = True Then
            Doutai_flg2 = False
            Label4.Text = "動体検知機の結果を
表示します。"
        Else
            Doutai_flg2 = True
            Label4.Text = "動体探知機３
に反応あり"

        End If
        Me.Invalidate()
    End Sub

    Private Sub Cam5_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Label5.Top = 338
        ' Camera_on(8)
        If Doutai_flg3 = True Then
            Doutai_flg3 = False
            Label5.Text = ""
        Else
            PictureBox1.Visible = False
            Doutai_flg3 = True
            Label5.Text = "動体探知機２
に反応なし"

        End If
        Me.Invalidate()
    End Sub


    Private Function Battery(bai As Integer, Kankaku2 As Integer) As Integer
        Dim Kankakus As Integer = Kankaku2
        Dim Bai2 As Double = bai
        Thread.Sleep(Kankakus)
        denci -= (1 * Bai2)
        Return denci
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim zanryo As Integer
        zanryo = Battery(1, Kankaku)
        Label19.Text = Str(zanryo) + "%"

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        If Shatta_flg = False Then
            Label20.BackColor = Color.Red
            Kankaku = 1750
            Shatta_flg = True
        Else
            Label20.BackColor = Color.Chartreuse
            Kankaku = 2000
        End If

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        ' Camera_on(2)
        If Doutai_flg1 = True Then
            Doutai_flg1 = False
            Label7.Text = ""
        Else
            Doutai_flg1 = True
            Label7.Text = "動体探知機１
異常なし"

        End If
        Me.Invalidate()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar1.Value += 1
    End Sub

    Private Sub Label10_MouseDown(sender As Object, e As EventArgs) Handles Label10.MouseDown
        Timer2.Enabled = True
        Timer2.Start()
        Label10.ForeColor = Color.Red
    End Sub

    Private Sub Label10_MouseUp(sender As Object, e As MouseEventArgs) Handles Label10.MouseUp
        Timer2.Stop()
        Label10.ForeColor = Color.Black
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim jikan As Integer = 0
        jikan += 1
        Label21.Text = Str(jikan) + " AM"
    End Sub


    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        '  Aruku()
        If Aruku(T_number, x_2, y_2) = True Then
            Tomare = T_number
            Label6.Text = "Start"
            Thread.Sleep(5000)
            Timer5.Start()
            Timer4.Stop()
            Tomare = 0
        Else
            Aruku(T_number, x_2, y_2)
        End If
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

        Label21.Text = "Go"
    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click
        If Doutai_flg5 = True Then
            Doutai_flg5 = False
            Label4.Text = "動体検知機の結果を
表示します。"
        ElseIf Doutai_flg5 = False Then
            Doutai_flg5 = True
            Label4.Text = "動体探知機３
に反応あり"
            Label22.Visible = True

        End If
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Select_Rex(root)
    End Sub
End Class
