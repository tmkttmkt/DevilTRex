Imports System.Threading
Imports System.Threading.Tasks
Imports System.Random
Imports System.Drawing
Public Class Form1
    Dim Gamen_flg = False
    Dim Shatta_flg1 = False
    Dim Shatta_flg2 = False
    Dim Shatta_flg3 = False
    Dim Doutai_flg1 = False
    Dim Doutai_flg2 = False
    Dim Doutai_flg3 = False
    Dim Doutai_flg5 = False
    Dim camera_flg1 = False
    Dim xs(5) As Integer
    Dim ys(5) As Integer
    Dim xs2(4) As Integer
    Dim ys2(4) As Integer
    Dim Kankaku As Integer = 100
    Dim denci As Integer = 100
    Dim heri1 As Integer = 0
    Dim x_2 As Integer = 0
    Dim y_2 As Integer = 0
    Dim Tomare As Integer = 0
    Dim T_number As Integer = 22
    Dim root As Integer = 1
    Dim Idou_flg = False
    Dim Idou_flg2 = False
    Dim Idou_flg3 = False
    Dim dash_x(5) As Integer
    Dim dash_y(5) As Integer
    Dim dash_x2(6) As Integer
    Dim dash_y2(6) As Integer
    Dim dash_x3(3) As Integer
    Dim dash_y3(3) As Integer
    Dim dash_count As Integer = 0
    Dim dash_count2 As Integer = 0
    Dim dash_count3 As Integer = 1
    Dim T_location1 As Integer = 1
    Dim T_location2 As Integer = 1
    Dim T_location3 As Integer = 7
    Dim T_mode1 As Integer = 0
    Dim T_mode2 As Integer = 0
    Dim T_joutai1 As Integer = 1
    Dim T_joutai2 As Integer = 1
    Dim T_joutai3 As Integer = 1
    Dim T_owari = True
    Dim r As New Random(7800)
    Dim r3 As New Random(7600)
    Dim r4 As New Random(7500)
    Dim r5 As New Random(7400)
    Dim donokurai As Integer = r5.Next(60000, 120000)


    'Dim gage_value As Integer = 0
    Dim Images(5) As Image
    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0

        dash_x(0) = 615
        dash_y(0) = 174
        dash_x(1) = 522
        dash_y(1) = 173
        dash_x(2) = 522
        dash_y(2) = 313
        dash_x(3) = 615
        dash_y(3) = 329 'ここで死亡
        dash_x(4) = 717
        dash_y(4) = 176
        dash_x(5) = 717
        dash_y(5) = 336
        'ここで死亡
        dash_x3(0) = 510
        dash_y3(0) = 97

        dash_x3(1) = 627
        dash_y3(1) = 180

        dash_x3(2) = 627
        dash_y3(2) = 252

        dash_x3(3) = 629
        dash_y3(3) = 311

        dash_x2(0) = 627
        dash_y2(0) = 180
        dash_x2(1) = 522
        dash_y2(1) = 173
        dash_x2(2) = 522
        dash_y2(2) = 313

        dash_x2(3) = 629
        dash_y2(3) = 311 'ここで死亡

        dash_x2(4) = 627
        dash_y2(4) = 252

        dash_x2(5) = 717
        dash_y2(5) = 176
        dash_x2(6) = 717
        dash_y2(6) = 336


        Gamens(False)
        'PictureBox2.Visible = True
        Label19.Text = "100%"
        Label21.Text = "0 AM"
        Timer1.Interval = 3000
        Timer2.Interval = 2000
        Timer3.Interval = 120000
        Timer4.Interval = 300
        Timer6.Interval = 300
        Timer7.Interval = 300
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
        Timer1.Enabled = True
        Timer4.Enabled = True
        Timer6.Enabled = True
        Await Task.Delay(donokurai)
        Timer7.Enabled = True
    End Sub
    Private Sub Home()
        Label20.Visible = True

    End Sub



    Private Async Function Dash_Rex2() As Task(Of Boolean)
        Dim dotti As Integer = r4.Next(1, 4)
        Dim x_d As Integer = Label34.Location.X
        Dim y_d As Integer = Label34.Location.Y
        Dim raberu_x2 = Label34.Location.X
        Dim raberu_y2 = Label34.Location.Y
        Dim x_d2 As Integer
        Dim y_d2 As Integer
        Dim dash_flg_x = False
        Dim dash_flg_y = False
        Dim OK_flg = False
        If dash_count2 = 0 And T_mode2 = 0 And T_joutai2 = 1 Then
            Select Case dotti
                Case 1
                    dash_count2 = 1
                    T_mode2 = 1
                    T_joutai2 = 2
                Case 2
                    dash_count2 = 4
                    T_mode2 = 2
                    T_joutai2 = 2
                Case 3
                    dash_count2 = 5
                    T_mode2 = 3
                    T_joutai2 = 2
            End Select
        End If
        If Idou_flg3 = True Then
            x_d2 = dash_x2(dash_count2)
            y_d2 = dash_y2(dash_count2)
        End If

        If x_d < x_d2 Then
            x_d += 1
            Await Task.Delay(100)
            Label34.Location = New Point(x_d, raberu_y2)
        End If
        If x_d > x_d2 Then
            x_d -= 1
            Await Task.Delay(100)
            Label34.Location = New Point(x_d, raberu_y2)
        End If
        If x_d = x_d2 Then
            dash_flg_x = True
        End If

        If y_d < y_d2 Then
            y_d += 1
            Await Task.Delay(100)
            Label34.Location = New Point(raberu_x2, y_d)
        ElseIf y_d > y_d2 Then
            y_d -= 1
            Await Task.Delay(100)
            Label34.Location = New Point(raberu_x2, y_d)
        End If
        If y_d = y_d2 Then
            dash_flg_y = True
        End If
        If dash_flg_y = True And dash_flg_x = True Then
            If dash_count2 = 0 Then
                T_joutai2 = 1
                Dim r4 As New Random(7500)
                dotti = r4.Next(1, 4)
            End If
            If dash_count2 = 3 Then
                Select Case T_mode2
                    Case 1
                        If Shatta_flg1 = False Then
                            Label33.Text = "RIP お前"
                        Else
                            T_mode2 = 0
                            T_joutai2 = 0
                        End If
                    Case 2
                        If Shatta_flg2 = False Then
                            Label33.Text = "RIP お前"
                        Else
                            T_mode2 = 0
                            T_joutai2 = 0
                        End If
                    Case 3
                        If Shatta_flg3 = False Then
                            Label33.Text = "RIP お前"
                        Else
                            T_mode2 = 0
                            T_joutai2 = 0
                        End If
                End Select
            End If
            OK_flg = True
            Return True
        Else
            Return False
        End If

    End Function
    Private Async Function Dash_Rex3() As Task(Of Boolean)
        '    Dim dotti As Integer = r5.Next(5000, 50000)
        Dim x_d As Integer = Label22.Location.X
        Dim y_d As Integer = Label22.Location.Y
        Dim raberu_x = Controls("Label" & CStr(22)).Location.X
        Dim raberu_y = Controls("Label" & CStr(22)).Location.Y
        Dim x_d2 As Integer
        Dim y_d2 As Integer
        Dim dash_flg_x = False
        Dim dash_flg_y = False
        Dim OK_flg = False
        If dash_count3 = 0 And T_joutai3 = 1 Then
            '    Await Task.Delay(dotti)
            T_joutai3 = 2
        End If
        If Idou_flg3 = True Then
            x_d2 = dash_x3(dash_count3)
            y_d2 = dash_y3(dash_count3)
        End If
        If x_d < x_d2 Then
            x_d += 1
            Await Task.Delay(100)
            Label22.Location = New Point(x_d, raberu_y)
        End If
        If x_d > x_d2 Then
            x_d -= 1
            Await Task.Delay(100)
            Label22.Location = New Point(x_d, raberu_y)
        End If
        If x_d = x_d2 Then
            dash_flg_x = True
        End If

        If y_d < y_d2 Then
            y_d += 1
            Await Task.Delay(100)
            Label22.Location = New Point(raberu_x, y_d)
        ElseIf y_d > y_d2 Then
            y_d -= 1
            Await Task.Delay(100)
            Label22.Location = New Point(raberu_x, y_d)
        End If
        If y_d = y_d2 Then
            dash_flg_y = True
        End If
        If dash_flg_y = True And dash_flg_x = True Then
            OK_flg = True
            If dash_count3 = 0 Then
                T_joutai3 = 1
            End If
            If dash_count3 = 3 Then
                If Shatta_flg2 = False Then
                    Label33.Text = "RIP お前"
                Else
                    T_joutai3 = 0
                End If
            End If
            Return True
            T_location3 = dash_count3
        Else
            Return False
        End If

    End Function
    Private Async Function Dash_Rex() As Task(Of Boolean)
        Dim dotti As Integer = r3.Next(1, 4)
        Dim x_d As Integer = Label25.Location.X
        Dim y_d As Integer = Label25.Location.Y
        Dim raberu_x = Controls("Label" & CStr(25)).Location.X
        Dim raberu_y = Controls("Label" & CStr(25)).Location.Y
        Dim x_d2 As Integer
        Dim y_d2 As Integer
        Dim dash_flg_x = False
        Dim dash_flg_y = False
        Dim OK_flg = False
        If dash_count = 0 And T_mode1 = 0 And T_joutai1 = 1 Then
            Select Case dotti
                Case 1
                    dash_count = 1
                    T_mode1 = 1
                    T_joutai1 = 2
                Case 2
                    dash_count = 4
                    T_mode1 = 2
                    T_joutai1 = 2
                Case 3
                    dash_count = 5
                    T_mode1 = 3
                    T_joutai1 = 2
            End Select
        End If
        If Idou_flg2 = True Then
            x_d2 = dash_x2(dash_count)
            y_d2 = dash_y2(dash_count)
        End If
        If x_d < x_d2 Then
            x_d += 1
            Await Task.Delay(100)
            Label25.Location = New Point(x_d, raberu_y)
        End If
        If x_d > x_d2 Then
            x_d -= 1
            Await Task.Delay(100)
            Label25.Location = New Point(x_d, raberu_y)
        End If
        If x_d = x_d2 Then
            dash_flg_x = True
        End If

        If y_d < y_d2 Then
            y_d += 1
            Await Task.Delay(100)
            Label25.Location = New Point(raberu_x, y_d)
        ElseIf y_d > y_d2 Then
            y_d -= 1
            Await Task.Delay(100)
            Label25.Location = New Point(raberu_x, y_d)
        End If
        If y_d = y_d2 Then
            dash_flg_y = True
        End If
        If dash_flg_y = True And dash_flg_x = True Then
            OK_flg = True
            If dash_count = 0 Then
                T_joutai1 = 1
                Dim r3 As New Random(7600)
            End If
            If dash_count = 3 Then
                Select Case T_mode1
                    Case 1
                        If Shatta_flg1 = False Then
                            Label33.Text = "RIP お前"
                        Else
                            T_mode1 = 0
                            T_joutai1 = 0
                        End If
                    Case 2
                        If Shatta_flg2 = False Then
                            Label33.Text = "RIP お前"
                        Else
                            T_mode2 = 0
                            T_joutai1 = 0
                        End If
                    Case 3
                        If Shatta_flg3 = False Then
                            Label33.Text = "RIP お前"
                        Else
                            T_mode2 = 0
                            T_joutai1 = 0
                        End If
                End Select
            End If
            Return True
            T_location1 = dash_count
        Else
            Return False
        End If

    End Function


    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ' グラフィックスオブジェクトを取得
        Dim g As Graphics = e.Graphics

        ' 描画する四角形の位置とサイズを指定
        Dim rectangleBounds As New Rectangle(485, 52, 317, 326)
        Dim rectangleBounds2 As New Rectangle(560, 104, 137, 131)
        Dim rectangleBounds3 As New Rectangle(707, 94, 53, 205)
        Dim rectangleBounds4 As New Rectangle(625, 330, 30, 30)
        Dim rectangleBounds5 As New Rectangle(511, 252, 74, 98)
        Dim rectangleBounds6 As New Rectangle(707, 318, 41, 45)
        Dim rectangleBounds7 As New Rectangle(617, 252, 53, 31)
        Dim rectangleBounds8 As New Rectangle(498, 175, 40, 68)
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
        Label35.Visible = Not (flg)
        Label36.Visible = Not (flg)
        Label24.Visible = flg
        Label28.Visible = flg
        Label30.Visible = flg
        Label32.Visible = flg
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
    End Sub



    Private Sub Cam1_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If camera_flg1 = False And PictureBox3.Visible = True Then
            heri1 = 1
            If T_location1 = 4 Or T_location2 = 4 Or dash_count3 = 2 Then
                PictureBox1.Image = Images(2)
            Else
                PictureBox1.Image = Images(1)
            End If

            Label3.Visible = False
            camera_flg1 = True
            Camera_on(1)
            Label2.BackColor = Color.Yellow
            PictureBox1.Visible = True
        Else
            heri1 = 0
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


    Private Async Sub Battery(bai As Integer, Kankaku2 As Integer, heri As Integer)
        Dim Kankakus As Integer = Kankaku2
        Dim heris As Integer = heri
        Dim Bai2 As Double = bai
        Await Task.Delay(Kankakus)
        denci -= (1 * Bai2 + heris + heri1)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim zanryo
        Dim heri As Integer
        If Doutai_flg5 = False Then
            heri = 0.125
        End If
        Battery(1, 5000, heri)
        Label19.Text = Str(denci) + "%"
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        If Shatta_flg1 = False Then
            Kankaku = 1750
            Label20.BackColor = Color.Red
            Shatta_flg1 = True
        Else
            Shatta_flg1 = False
            Label20.BackColor = Color.Chartreuse
            Kankaku = 2000
        End If

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


    Private Async Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If Await Dash_Rex2() = True Then
            T_location2 = dash_count2
            If T_joutai2 = 2 Then
                'Await Task.Delay(100)
                If dash_count2 + 1 = 5 Or dash_count2 + 1 = 7 Then
                    dash_count2 = 3
                Else
                    dash_count2 += 1
                End If
                Idou_flg3 = False
            ElseIf T_joutai2 = 0 And dash_count2 - 1 >= 0 Then
                If dash_count2 - 1 = 3 Or dash_count - 1 = 4 Then
                    dash_count2 = 0
                Else
                    dash_count2 -= 1
                End If
            End If
        Else
            Idou_flg3 = True
        End If
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

        Label21.Text = "Go"
    End Sub

    Private Async Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click
        If Doutai_flg5 = False And (T_location2 = 1 Or T_location1 = 1 Or T_location3 = 1) Then
            If T_location1 = 1 Then
                Await Task.Delay(10)
                Label30.BackColor = Color.Yellow
                Label25.Visible = True
                Await Task.Delay(1000)
                Label25.Visible = False
                Label30.BackColor = Color.White
                Label4.Text = "動体探知機３
に反応あり"
                Doutai_flg5 = True
            End If
            If T_location2 = 1 Then
                Await Task.Delay(10)
                Label30.BackColor = Color.Yellow
                Label34.Visible = True
                Await Task.Delay(1000)
                Label34.Visible = False
                Label4.Text = "動体探知機３
に反応あり"
                Doutai_flg5 = True
            End If
            If T_location3 = 1 Then
                Await Task.Delay(10)
                Label30.BackColor = Color.Yellow
                Label34.Visible = True
                Await Task.Delay(1000)
                Label34.Visible = False
                Label4.Text = "動体探知機３
に反応あり"
                Doutai_flg5 = True
            End If
        End If


        If Doutai_flg5 = False And T_location2 = Not (1) And T_location1 = Not (1) And T_location3 = Not (1) Then
            Label30.BackColor = Color.Yellow
            Label4.Text = "動体探知機３
に反応なし"
        End If
        If Doutai_flg5 = True Then
            Doutai_flg5 = False
            Label30.BackColor = Color.White
            Label4.Text = "動体検知機の結果を
表示します。"
        End If
    End Sub


    Async Function AsyncFunction(times As Integer) As Task

        ' ここで非同期な処理を行う
        Await Task.Delay(times) ' 例として5秒の非同期待機
    End Function

    Private Async Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Label26.Text = T_location1
        Label27.Text = T_location2
        Label29.Text = dash_count
        Label31.Text = dash_count2

        If Await Dash_Rex() = True Then
            If T_joutai1 = 2 Then
                'Await Task.Delay(100)
                If dash_count + 1 = 5 Or dash_count + 1 = 7 Then
                    dash_count = 3
                Else
                    dash_count += 1
                End If
                '  If dash_count + 1 = Not (3) Then
                ' End If
                Idou_flg2 = False
            ElseIf T_joutai1 = 0 And dash_count - 1 >= 0 Then
                If dash_count - 1 = 3 Or dash_count - 1 = 4 Then
                    dash_count = 0
                Else
                    dash_count -= 1
                End If
            End If
            T_location1 = dash_count
        Else
            Idou_flg2 = True
        End If
    End Sub

    Private Sub Label35_Click(sender As Object, e As EventArgs) Handles Label35.Click
        If Shatta_flg2 = False Then
            Kankaku = 1750
            Label35.BackColor = Color.Red
            Shatta_flg2 = True
        Else
            Shatta_flg2 = False
            Label35.BackColor = Color.Chartreuse
            Kankaku = 2000
        End If

    End Sub

    Private Sub Label36_Click(sender As Object, e As EventArgs) Handles Label36.Click
        If Shatta_flg3 = False Then
            Kankaku = 1750
            Label36.BackColor = Color.Red
            Shatta_flg3 = True
        Else
            Shatta_flg3 = False
            Label36.BackColor = Color.Chartreuse
            Kankaku = 2000
        End If
    End Sub

    Private Async Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click
        If Doutai_flg5 = False And (T_location2 = 5 Or T_location1 = 5 Or T_location3 = 5) Then
            If T_location1 = 5 Then
                Await Task.Delay(10)
                Label24.BackColor = Color.Yellow
                Label25.Visible = True
                Await Task.Delay(1000)
                Label25.Visible = False
                Label24.BackColor = Color.White
                Label7.Text = "動体探知機１
に反応あり"
                Doutai_flg5 = True
            End If
            If T_location2 = 5 Then
                Await Task.Delay(10)
                Label24.BackColor = Color.Yellow
                Label34.Visible = True
                Await Task.Delay(1000)
                Label34.Visible = False
                Label7.Text = "動体探知機１
に反応あり"
                Doutai_flg5 = True
            End If
            If T_location3 = 5 Then
                Await Task.Delay(10)
                Label24.BackColor = Color.Yellow
                Label34.Visible = True
                Await Task.Delay(1000)
                Label34.Visible = False
                Label7.Text = "動体探知機１
に反応あり"
                Doutai_flg5 = True
            End If
        End If


        If Doutai_flg5 = False And T_location2 = Not (5) And T_location1 = Not (5) Then
            Label24.BackColor = Color.Yellow
            Label7.Text = "動体探知機１
に反応なし"
        End If
        If Doutai_flg5 = True Then
            Doutai_flg5 = False
            Label24.BackColor = Color.White
            Label7.Text = ""
        End If
    End Sub

    Private Async Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Label37.Text = dash_count3
        Label38.Text = T_location3
        If Await Dash_Rex3() = True Then
            If T_joutai3 = 2 Then
                'Await Task.Delay(100)
                dash_count3 += 1
                '  If dash_count + 1 = Not (3) Then
                ' End If
                Idou_flg3 = False
            ElseIf T_joutai3 = 0 And dash_count3 - 1 >= 0 Then
                If dash_count3 - 1 = 3 Then
                    dash_count3 = 0
                Else
                    dash_count3 -= 1
                End If
            End If
            T_location3 = dash_count3
        Else
            Idou_flg3 = True
        End If
    End Sub

End Class
