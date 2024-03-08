
Imports System.Runtime.InteropServices

Public Class Form1
    <DllImport("user32.dll", CharSet:=CharSet.Unicode)>
    Private Shared Function SendMessage(hWnd As HandleRef,
    Msg As UInt32, wParam As UInt32, lParam As IntPtr) As IntPtr
    End Function

    Private Const WM_USER As UInt32 = &H400
    Private Const PBM_SETSTATE As UInt32 = WM_USER + 16
    Private Const PBST_NORMAL As UInt32 = &H1
    Private Const PBST_ERROR As UInt32 = &H2
    Private Const PBST_PAUSED As UInt32 = &H3
    Dim r As New Random()
    Dim r3 As New Random()
    Dim r4 As New Random()
    Dim r5 As New Random()
    Dim Keta As Integer = 0
    Dim Wa As Integer = 0
    Dim Wa2 As Integer = 0
    Dim jikan As Integer
    Dim Gamen_flg = False
    Dim Syasin_flg = False
    Dim Shatta_flg1 = False
    Dim Shatta_flg2 = False
    Dim Shatta_flg3 = False
    Dim Doutai_flg1 = False
    Dim Doutai_flg2 = False
    Dim Doutai_flg3 = False
    Dim Doutai_flg4 = False
    Dim Doutai_flg5 = False
    Dim Light_flg1 = False
    Dim Light_flg2 = False
    Dim Light_flg3 = False
    Dim Light1_flg = False
    Dim Light2_flg = False
    Dim Game_Over = False
    Dim Game_Overs = False
    Dim Game_clear = False
    Dim Epilog = True
    Dim Ending = False
    Dim Idou_flg = False
    Dim Idou_flg2 = False
    Dim Idou_flg3 = True
    Dim Idou_flg4 = False
    Dim Dengen = False
    Dim camera_flg1 = False
    Dim Ongakus = True
    Dim Kankaku As Integer = 100
    Dim denci As Integer = 101
    Dim heri1 As Integer = 0
    Dim x_2 As Integer = 0
    Dim y_2 As Integer = 0
    Dim Tomare As Integer = 0
    Dim T_number As Integer = 22
    Dim Text_count As Integer = 0
    Dim dash_count As Integer = 0
    Dim dash_count2 As Integer = 0
    Dim dash_count3 As Integer = 1
    Dim T_location1 As Integer = 0
    Dim T_location2 As Integer = 0
    Dim T_location3 As Integer = 7
    Dim T_mode1 As Integer = 0
    Dim T_mode2 As Integer = 0
    Dim T_joutai1 As Integer = 0
    Dim T_joutai2 As Integer = 0
    Dim T_joutai3 As Integer = 2
    Dim T1_room As Integer = 1
    Dim T2_room As Integer = 1
    Dim T3_room As Integer = 7
    Dim dotira As Integer = 2
    Dim x_d3 As Integer = 0
    Dim y_d3 As Integer = 0
    Dim T_owari = True
    Public counts As Integer = 0
    Dim donokurai As Integer = r5.Next(30000, 120000)
    Dim starts As Boolean = True
    Dim Text_count2 As Integer

    Dim xs(5) As Integer
    Dim ys(5) As Integer
    Dim xs2(4) As Integer
    Dim ys2(4) As Integer

    Dim dash_x(5) As Integer
    Dim dash_y(5) As Integer
    Dim dash_x2(6) As Integer
    Dim dash_y2(6) As Integer
    Dim dash_x2s(6) As Integer
    Dim dash_y2s(6) As Integer
    Dim dash_x2sx(6) As Integer
    Dim dash_y2sx(6) As Integer
    Dim dash_x3(8) As Integer
    Dim dash_y3(8) As Integer
    'Dim story1 As New Story1()

    Dim Ongaku(27) As String
    Private Sub ShowMessageBoxes()
        For i As Integer = 1 To 5
            MessageBox.Show("ティラノウイルスに感染 " & i.ToString() & " しました！", "やばいよ！", MessageBoxButtons.OK)
        Next
    End Sub
    'Dim gage_value As Integer = 0
    Dim Images(100) As Image
    Private Sub Images_Sengen()
        Images(0) = Image.FromFile("Desktop.jpg")
        Images(1) = Image.FromFile("学校13.gif")
        Images(2) = Image.FromFile("学校14.gif") '
        Images(3) = Image.FromFile("Form.png") '
        Images(4) = Image.FromFile("Form_up.png")
        Images(5) = Image.FromFile("shatter1.png")
        Images(6) = Image.FromFile("shatter2.png")
        Images(7) = Image.FromFile("shatter3.png")
        Images(8) = Image.FromFile("shatter4.png")
        Images(9) = Image.FromFile("光る眼.jpg")
        Images(10) = Image.FromFile("背景.png")
        Images(11) = Image.FromFile("shatter5.png")
        Images(12) = Image.FromFile("shatter6.png")
        Images(13) = Image.FromFile("shatter7.png")
        Images(14) = Image.FromFile("shatter8.png")

        Images(15) = Image.FromFile("postar.jpg")
        Images(16) = Image.FromFile("postar2.png")
        Images(17) = Image.FromFile("postar3.jpg")
        Images(18) = Image.FromFile("ore.jpg")
        Images(19) = Image.FromFile("ポスター.png")
        Images(20) = Image.FromFile("扇風機4.gif")
        Images(21) = Image.FromFile("game_over.gif")
        Images(22) = Image.FromFile("Game_Over1.jpg")
        Images(23) = Image.FromFile("Game_Over2.jpg")
        Images(24) = Image.FromFile("Game_Over3.jpg")

        Images(25) = Image.FromFile("T_1.jpg")
        Images(26) = Image.FromFile("T_2.jpg")
        Images(27) = Image.FromFile("T_3.jpg")
        Images(28) = Image.FromFile("T_4.jpg")
        Images(29) = Image.FromFile("T_5.jpg")
        Images(30) = Image.FromFile("T_6.jpg")
        Images(31) = Image.FromFile("T_7.jpg")

        Images(32) = Image.FromFile("skusyo.png")
        Images(33) = Image.FromFile("System.jpg")
        Images(34) = Image.FromFile("AM.jpg")
        Images(35) = Image.FromFile("shatters.jpg")
        Images(36) = Image.FromFile("OpenDown.jpg")
        Images(37) = Image.FromFile("Shine.jpg")
        Images(38) = Image.FromFile("Pasocon.jpg")
        Images(39) = Image.FromFile("sukusyo2.png")
        Images(40) = Image.FromFile("Mov.jpg")
        Images(41) = Image.FromFile("Camera.jpg")
        Images(42) = Image.FromFile("KeyPad.jpg")
        Images(43) = Image.FromFile("Denci.jpg")
        Images(44) = Image.FromFile("Maiku.png")
    End Sub
    Private Sub Ongaku_sengen()
        Ongaku(0) = "shatter_open.mp3"
        Ongaku(1) = "shatter_close.mp3"
        Ongaku(2) = "light.mp3"
        Ongaku(3) = "noise.mp3"
        Ongaku(4) = "T_Rex.mp3"
        Ongaku(5) = "dondon.mp3"
        Ongaku(6) = "pi.mp3"
        Ongaku(7) = "noise.mp3"
        Ongaku(8) = "click.mp3"
        Ongaku(9) = "run.mp3"
        Ongaku(10) = "pc_on.mp3"
        Ongaku(11) = "pc_off.mp3"
        Ongaku(12) = "sakebi.mp3"
        Ongaku(13) = "pico.mp3"
        Ongaku(14) = "tokei.mp3"
        Ongaku(15) = "yea.mp3"
        Ongaku(16) = "hakusyu2.mp3"
        Ongaku(17) = "1.mp3"
        Ongaku(18) = "2.mp3"
        Ongaku(19) = "3.mp3"
        Ongaku(20) = "4.mp3"
        Ongaku(21) = "5.mp3"
        Ongaku(22) = "6.mp3"
        Ongaku(23) = "7.mp3"
        Ongaku(24) = "8.mp3"
        Ongaku(25) = "9.mp3"
        Ongaku(26) = "bubu.mp3"
        Ongaku(27) = "pinpon.mp3"
    End Sub
    Private Async Sub Game_start()
        jikan = 5
        If ProgressBar1.IsHandleCreated Then
            SendMessage(New HandleRef(ProgressBar1, ProgressBar1.Handle),
                        PBM_SETSTATE, PBST_NORMAL, IntPtr.Zero)
        End If
        Label10.Text = "システム
ボタン"
        Dim r As New Random()
        Dim r3 As New Random()
        Dim r4 As New Random()
        Dim r5 As New Random()
        Label25.Location = New Point(572, 126)
        Label34.Location = New Point(596, 143)
        Label22.Location = New Point(510, 97)
        Gamen_flg = False
        Game_clear = False
        Game_Over = False
        Game_Overs = False
        Syasin_flg = False
        Shatta_flg1 = False
        Shatta_flg2 = False
        Shatta_flg3 = False
        Doutai_flg1 = False
        Doutai_flg2 = False
        Doutai_flg3 = False
        Doutai_flg4 = False
        Doutai_flg5 = False
        Light_flg1 = False
        Light_flg2 = False
        Light_flg3 = False
        Light1_flg = False
        Light2_flg = False
        Idou_flg = False
        Idou_flg2 = False
        Idou_flg3 = True
        Idou_flg4 = False
        Dengen = False
        camera_flg1 = False
        Ongakus = True
        Kankaku = 100
        Text_count2 = 0
        denci = 101
        heri1 = 0
        Keta = 0
        Wa = 0
        x_2 = 0
        y_2 = 0
        Tomare = 0
        T_number = 22
        dash_count = 0
        dash_count2 = 0
        dash_count3 = 1
        T_location1 = 0
        T_location2 = 0
        T_location3 = 7
        T_mode1 = 0
        T_mode2 = 0
        T_joutai1 = 0
        T_joutai2 = 0
        T_joutai3 = 2
        T1_room = 1
        T2_room = 1
        T3_room = 7
        dotira = 2
        x_d3 = 0
        y_d3 = 0
        T_owari = True
        donokurai = r5.Next(30000, 120000)
        starts = True
        PictureBox19.BackColor = Color.FromArgb(60, 60, 60)
        AxWindowsMediaPlayer1.settings.autoStart = False
        AddHandler AxWindowsMediaPlayer1.PlayStateChange, AddressOf MediaPlayer_PlayStateChange
        AxWindowsMediaPlayer2.settings.autoStart = False
        AddHandler AxWindowsMediaPlayer2.PlayStateChange, AddressOf MediaPlayer_PlayStateChange
        AxWindowsMediaPlayer3.settings.autoStart = False
        AddHandler AxWindowsMediaPlayer3.PlayStateChange, AddressOf MediaPlayer_PlayStateChange
        AxWindowsMediaPlayer4.settings.autoStart = False
        AddHandler AxWindowsMediaPlayer4.PlayStateChange, AddressOf MediaPlayer_PlayStateChange
        AxWindowsMediaPlayer5.settings.autoStart = False
        AddHandler AxWindowsMediaPlayer5.PlayStateChange, AddressOf MediaPlayer_PlayStateChange
        AxWindowsMediaPlayer6.settings.autoStart = False
        AddHandler AxWindowsMediaPlayer6.PlayStateChange, AddressOf MediaPlayer_PlayStateChange

        AxWindowsMediaPlayer4.URL = Ongaku(12)
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0
        '  Label40.Visible = False
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

        dash_x2s(0) = 584
        dash_y2s(0) = 115
        dash_x2sx(0) = 701
        dash_y2sx(0) = 210

        dash_x2s(1) = 486
        dash_y2s(1) = 174
        dash_x2sx(1) = 524
        dash_y2sx(1) = 252

        dash_x2s(2) = 173
        dash_y2s(2) = 138
        dash_x2sx(2) = 557
        dash_y2sx(2) = 336

        dash_x2s(4) = 610
        dash_y2s(4) = 239
        dash_x2sx(4) = 635
        dash_y2sx(4) = 275

        dash_x2s(5) = 705
        dash_y2s(5) = 115
        dash_x2sx(5) = 753
        dash_y2sx(5) = 287

        dash_x2s(6) = 707
        dash_y2s(6) = 320
        dash_x2sx(6) = 738
        dash_y2sx(6) = 337

        x_d3 = r4.Next(584, 701)
        y_d3 = r4.Next(115, 210)
        Gamens(False)
        PictureBox2.Visible = True
        Label38.Text = "┃■■■┃"
        Label19.Text = "100%"
        Label21.Text = Str(jikan) + " AM"
        Timer2.Interval = 700
        Timer5.Interval = 2000
        Timer3.Interval = 36000
        Timer4.Interval = 500
        Timer6.Interval = 500
        Timer7.Interval = 10
        Timer1.Enabled = True
        Timer3.Enabled = True

        PictureBox2.Visible = True
        PictureBox2.Image = Images(10)
        PictureBox3.Image = Images(3)
        PictureBox4.Image = Images(4)
        PictureBox5.Visible = False
        PictureBox6.Image = Images(3)
        PictureBox7.Image = Images(15)
        PictureBox8.Image = Images(3)
        PictureBox9.Image = Images(5)
        PictureBox10.Image = Images(11)
        PictureBox11.Image = Images(5)
        PictureBox12.Image = Images(9)
        PictureBox13.Image = Images(9)
        PictureBox14.Image = Images(9)
        PictureBox7.Image = Images(19)
        PictureBox15.Image = Images(15)
        PictureBox16.Image = Images(16)
        PictureBox17.Image = Images(17)
        PictureBox18.Image = Images(18)
        PictureBox19.Image = Images(20)
        Timer1.Enabled = True
        ' Timer5.Enabled = True
        Timer4.Enabled = True
        Timer6.Enabled = True
        Label4.Visible = False
        Label41.BackColor = Color.DarkRed
        Label33.BackColor = Color.DarkRed
        Label20.BackColor = Color.DarkOliveGreen
        Label39.BackColor = Color.DarkRed
        Label37.BackColor = Color.DarkRed
        Label36.BackColor = Color.DarkOliveGreen
        Label41.BackColor = Color.DarkRed
        Label35.BackColor = Color.DarkOliveGreen
        Await Task.Delay(donokurai)
        Timer7.Enabled = True
        AxWindowsMediaPlayer3.URL = Ongaku(9)
        AxWindowsMediaPlayer3.Ctlcontrols.play()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Images_Sengen()
        Ongaku_sengen()
        Over(0)
        PictureBox2.Image = Images(100)
        Me.BackgroundImage = Image.FromFile("Desktop.jpg")
        Timer9.Interval = 50
        Label23.Visible = True
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        'Me.ControlBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Label23.Visible = False
        PictureBox20.Image = Images(44)
        '  Await Task.Delay(800)
        Timer9.Enabled = True
        Label27.Text = ""
        Label29.Text = ""
    End Sub
    Private Sub Home()
        Label20.Visible = True

    End Sub
    Private Sub MediaPlayer_PlayStateChange(sender As Object, e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent)
        If e.newState = 8 Then
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
        End If
    End Sub



    Private Async Function Dash_Rex2() As Task(Of Boolean)
        Dim dotti As Integer = r4.Next((4 * Rnd()) + 1)
        Dim timetime As Integer = r4.Next((100000 * Rnd()) + 3000)
        Dim x_d As Integer = Label34.Location.X
        Dim y_d As Integer = Label34.Location.Y
        Dim raberu_x2 = Label34.Location.X
        Dim raberu_y2 = Label34.Location.Y
        '  Dim dotira As Integer = r4.Next((2 * Rnd()) + 1)
        Dim x_d2 As Integer
        Dim y_d2 As Integer
        Dim dash_flg_x = False
        Dim dash_flg_y = False
        Dim OK_flg = False
        If Game_Over = False Then
            If T_location2 = 0 And T_mode2 = 0 And T_joutai2 = 1 Then
                dotti = r4.Next((4 * Rnd()) + 1)
                timetime = r4.Next((100000 * Rnd()) + 3000)
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
                    Case 4
                        Await Task.Delay(timetime)
                End Select
            End If
            'dotira = 2
            '   Label48.Text = Doutai_flg5
            If dotira = 2 Then
                T_joutai2 = -1
            End If
            If T_joutai2 > -1 Then
                x_d2 = dash_x2(dash_count2)
                y_d2 = dash_y2(dash_count2)
            End If
            If T_joutai2 = -1 Then
                x_d2 = x_d3
                y_d2 = y_d3
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

            If y_d < y_d2 And dash_flg_x = True Then
                y_d += 1
                Await Task.Delay(100)
                Label34.Location = New Point(raberu_x2, y_d)
            ElseIf y_d > y_d2 And dash_flg_x = True Then
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
                End If
                If dash_count2 = 3 Then
                    Label43.Visible = True
                    AxWindowsMediaPlayer2.URL = Ongaku(5)
                    AxWindowsMediaPlayer2.Ctlcontrols.play()
                    Select Case T_mode2
                        Case 1
                            If Shatta_flg1 = False Then
                                Game_Over2()
                            End If
                        Case 2
                            If Shatta_flg2 = False Then
                                Game_Over2()
                            End If
                        Case 3
                            If Shatta_flg3 = False Then
                                Game_Over2()
                            End If
                    End Select
                    T_joutai2 = 0
                    T_mode2 = 0
                End If
                Return True
                OK_flg = True
                T_location2 = dash_count2

            Else
                Return False
            End If
        End If
    End Function
    Private Async Function Dash_Rex3() As Task(Of Boolean)
        Dim dotti As Integer = r5.Next((50000 * Rnd()) + 5000)
        '  Dim donokurai As Integer = r5.Next((50000 * Rnd()) + 5000)
        Dim x_d As Integer = Label22.Location.X
        Dim y_d As Integer = Label22.Location.Y
        Dim raberu_x = Controls("Label" & CStr(22)).Location.X
        Dim raberu_y = Controls("Label" & CStr(22)).Location.Y
        Dim x_d2 As Integer
        Dim y_d2 As Integer
        Dim dash_flg_x = False
        Dim dash_flg_y = False
        Dim OK_flg = False
        Dim randoms As Integer = r5.Next((2 * Rnd()) + 1)
        If Ongakus = True Then
            AxWindowsMediaPlayer3.URL = Ongaku(9)
            AxWindowsMediaPlayer3.Ctlcontrols.play()
            Ongakus = False
        End If
        ' Label58.Text = "dotti2 " + Str(dotti2)
        If Idou_flg4 = True Then
            x_d2 = dash_x3(dash_count3)
            y_d2 = dash_y3(dash_count3)
        End If
        ' Label44.Text = "T_Location3" + Str(T_location3)
        '  Label45.Text = y_d2
        '  Label47.Text = "dash_count3" + Str(dash_count3)
        If x_d < x_d2 Then
            x_d += 1
            ' Await Task.Delay(20)
            Label22.Location = New Point(x_d, raberu_y)
        End If
        If x_d > x_d2 Then
            x_d -= 1
            '  Await Task.Delay(20)
            Label22.Location = New Point(x_d, raberu_y)
        End If
        If x_d = x_d2 Then
            dash_flg_x = True
        End If

        If y_d < y_d2 Then
            y_d += 1
            '  Await Task.Delay(20)
            Label22.Location = New Point(raberu_x, y_d)
        ElseIf y_d > y_d2 Then
            y_d -= 1
            ' Await Task.Delay(20)
            Label22.Location = New Point(raberu_x, y_d)
        End If

        If y_d = y_d2 Then
            dash_flg_y = True
        End If
        If dash_flg_y = True And dash_flg_x = True Then
            OK_flg = True
            If dash_count3 = 0 And T_joutai3 = 0 Then
                T_joutai3 = 2
                dotti = r5.Next(30000, 120000)
                Timer7.Stop()
                Await Task.Delay(dotti)
                If Game_clear = False And Game_Over = False Then
                    Timer7.Start()
                    Ongakus = True
                End If
            End If
            If dash_count3 = 3 Then
                If Shatta_flg2 = False Then
                    Game_Over3()
                Else
                    AxWindowsMediaPlayer2.URL = Ongaku(5)
                    AxWindowsMediaPlayer2.Ctlcontrols.play()
                    T_joutai3 = 0
                End If
            End If
            Return True
            T_location3 = dash_count3
        Else
            Return False
        End If

    End Function
    Private Async Sub Game_Over1()
        AxWindowsMediaPlayer2.Ctlcontrols.stop()
        AxWindowsMediaPlayer4.Ctlcontrols.play()
        Gamens(False)
        Gamen_flg = False
        Over(5)
        Label43.Text = "RIP お前1"
        Await Task.Delay(2500)
        Over(1)
    End Sub
    Private Async Sub Game_Over2()
        AxWindowsMediaPlayer2.Ctlcontrols.stop()
        AxWindowsMediaPlayer4.Ctlcontrols.play()
        Label43.Text = "RIP お前2"
        Gamens(False)
        Gamen_flg = False
        Over(6)
        Await Task.Delay(2500)
        Over(1)
    End Sub
    Private Async Sub Game_Over3()
        AxWindowsMediaPlayer2.Ctlcontrols.stop()
        AxWindowsMediaPlayer4.Ctlcontrols.play()
        Label43.Text = "RIP お前3"
        Gamens(False)
        Gamen_flg = False
        Over(7)
        Await Task.Delay(2500)
        Over(1)
    End Sub
    Private Async Function Dash_Rex() As Task(Of Boolean)
        Dim dotti2 As Integer = r3.Next((4 * Rnd()) + 1)
        Dim timetime As Integer = r3.Next((100000 * Rnd()) + 3000)
        Dim x_d As Integer = Label25.Location.X
        Dim y_d As Integer = Label25.Location.Y
        Dim raberu_x = Controls("Label" & CStr(25)).Location.X
        Dim raberu_y = Controls("Label" & CStr(25)).Location.Y
        Dim x_d2 As Integer
        Dim y_d2 As Integer
        Dim dash_flg_x = False
        Dim dash_flg_y = False
        Dim OK_flg = False
        If Game_Over = False Then
            If T_location1 = 0 And T_mode1 = 0 And T_joutai1 = 1 Then
                timetime = r3.Next((100000 * Rnd()) + 3000)
                Select Case dotti2
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
                    Case 4
                        Await Task.Delay(timetime)
                End Select
            End If

            If T_joutai1 > -1 Then
                x_d2 = dash_x2(dash_count)
                y_d2 = dash_y2(dash_count)
            End If
            '   Label44.Text = "T_Location1" + Str(T_location1)
            '  Label45.Text = y_d2
            ' Label46.Text = "T_joutai1" + Str(T_joutai1)
            ' Label47.Text = "dash_count" + Str(dash_count)
            If x_d < x_d2 Then
                x_d += 1
                ' Await Task.Delay(100)
                Label25.Location = New Point(x_d, raberu_y)
            End If
            If x_d > x_d2 Then
                x_d -= 1
                ' Await Task.Delay(100)
                Label25.Location = New Point(x_d, raberu_y)
            End If
            If x_d = x_d2 Then
                dash_flg_x = True
            End If

            If y_d < y_d2 Then
                y_d += 1
                '  Await Task.Delay(100)
                Label25.Location = New Point(raberu_x, y_d)
            ElseIf y_d > y_d2 Then
                y_d -= 1
                ' Await Task.Delay(100)
                Label25.Location = New Point(raberu_x, y_d)
            End If
            If y_d = y_d2 Then
                dash_flg_y = True
            End If
            If dash_flg_y = True And dash_flg_x = True Then
                OK_flg = True
                If dash_count = 0 Then
                    T_joutai1 = 1
                End If
                If dash_count = 3 Then
                    'Label23.Visible = True
                    AxWindowsMediaPlayer2.URL = Ongaku(5)
                    AxWindowsMediaPlayer2.Ctlcontrols.play()
                    Select Case T_mode1
                        Case 1
                            If Shatta_flg1 = False Then
                                Game_Over1()
                            End If
                        Case 2
                            If Shatta_flg2 = False Then
                                Game_Over1()
                            End If
                        Case 3
                            If Shatta_flg3 = False Then
                                Game_Over1()
                            End If
                    End Select
                    T_mode1 = 0
                    T_joutai1 = 0
                End If
                Return True
                T_location1 = dash_count
            Else
                Return False
            End If
        End If
    End Function


    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim g As Graphics = e.Graphics

        Dim rectangleBounds As New Rectangle(485, 52, 317, 326)
        Dim rectangleBounds2 As New Rectangle(560, 104, 137, 131)
        Dim rectangleBounds3 As New Rectangle(707, 94, 53, 205)
        Dim rectangleBounds4 As New Rectangle(625, 330, 30, 30)
        Dim rectangleBounds5 As New Rectangle(511, 252, 74, 98)
        Dim rectangleBounds6 As New Rectangle(707, 318, 41, 45)
        Dim rectangleBounds7 As New Rectangle(617, 252, 53, 31)
        Dim rectangleBounds8 As New Rectangle(498, 175, 40, 68)
        Dim rectangleBounds9 As New Rectangle(498, 71, 53, 57)
        Dim penColor As Color
        Dim penColor2 As Color
        Dim penColor3 As Color
        Dim penColor4 As Color
        Dim penColor5 As Color
        If Gamen_flg = True Then

            Using pen As New Pen(Color.White, 2)
                Using brush As New SolidBrush(Color.Black)
                    g.FillRectangle(brush, rectangleBounds)
                    g.DrawRectangle(pen, rectangleBounds)
                End Using
            End Using

            If Doutai_flg5 Then
                penColor = Color.Yellow
            Else
                penColor = Color.White
            End If
            Using pen As New Pen(penColor, 2)
                g.DrawRectangle(pen, rectangleBounds2)
            End Using


            If Doutai_flg3 Then
                penColor2 = Color.Yellow
            Else
                penColor2 = Color.White
            End If
            Using pen As New Pen(penColor2, 2)
                g.DrawRectangle(pen, rectangleBounds3)
            End Using

            Using pen As New Pen(Color.White, 2)
                Using brush As New SolidBrush(Color.Black)
                    g.FillRectangle(brush, rectangleBounds4)
                    g.DrawRectangle(pen, rectangleBounds4)
                End Using
            End Using
            Using pen As New Pen(Color.White, 2)
                Using brush As New SolidBrush(Color.Black)
                    g.FillRectangle(brush, rectangleBounds5)
                    g.DrawRectangle(pen, rectangleBounds5)
                End Using
            End Using
            Using pen As New Pen(Color.White, 2)
                Using brush As New SolidBrush(Color.Black)
                    g.FillRectangle(brush, rectangleBounds6)
                    If Doutai_flg2 = True Then
                        Using pen2 As New Pen(Color.Yellow, 2)
                            g.DrawRectangle(pen2, rectangleBounds6)
                        End Using
                    Else
                        g.DrawRectangle(pen, rectangleBounds6)
                    End If
                End Using
            End Using
            If camera_flg1 Then
                penColor3 = Color.Yellow
            Else
                penColor3 = Color.White
            End If
            Using pen As New Pen(penColor3, 2)
                g.DrawRectangle(pen, rectangleBounds7)
            End Using
            If Doutai_flg4 Then
                penColor5 = Color.Yellow
            Else
                penColor5 = Color.White
            End If
            Using pen As New Pen(penColor5, 2)
                Using brush As New SolidBrush(Color.Black)
                    g.FillRectangle(brush, rectangleBounds8)
                    g.DrawRectangle(pen, rectangleBounds8)
                End Using
            End Using
            If Doutai_flg1 Then
                penColor4 = Color.Yellow
            Else
                penColor4 = Color.White
            End If
            Using pen As New Pen(penColor4, 2)
                g.DrawRectangle(pen, rectangleBounds9)
            End Using
        End If
    End Sub
    Private Sub Gamens(flg As Boolean) ' As Boolean
        If flg = False Then
            PictureBox1.Visible = flg
        End If
        Label31.Visible = flg
        Label45.Visible = flg
        Label46.Visible = flg
        Label47.Visible = flg
        Label48.Visible = flg
        Label49.Visible = flg
        Label50.Visible = flg
        Label51.Visible = flg
        Label52.Visible = flg
        Label53.Visible = flg
        Label54.Visible = flg

        Label1.Visible = True
        Label21.Visible = True
        Label19.Visible = True
        Label38.Visible = True
        '   Label43.Visible = True
        PictureBox2.Visible = Not (flg)
        PictureBox3.Visible = flg
        ProgressBar1.Visible = Not (flg)
        PictureBox4.Visible = flg
        PictureBox5.Visible = flg
        PictureBox6.Visible = flg
        PictureBox8.Visible = Not (flg)
        Label2.Visible = flg
        Label5.Visible = flg
        Label6.Visible = flg
        Label7.Visible = False
        Label8.Visible = flg
        Label9.Visible = flg
        Label10.Visible = Not (flg)
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
        Label39.Visible = Not (flg)
        ' Label40.Visible = Not (flg)
        Label41.Visible = Not (flg)
        Label24.Visible = flg
        Label28.Visible = flg
        Label30.Visible = flg
        Label32.Visible = flg
        PictureBox9.Visible = Not (flg)
        PictureBox10.Visible = Not (flg)
        PictureBox11.Visible = Not (flg)
        PictureBox7.Visible = Not (flg)
        PictureBox15.Visible = Not (flg)
        PictureBox16.Visible = Not (flg)
        PictureBox17.Visible = Not (flg)
        PictureBox18.Visible = Not (flg)
        PictureBox19.Visible = Not (flg)
        Label33.Visible = Not (flg)
        Label37.Visible = Not (flg)
        Label36.Visible = Not (flg)
        Label44.Visible = flg
        Label60.Visible = flg
        If camera_flg1 = True Or flg = False Then
            Label3.Visible = False
        Else
            Label3.Visible = flg
        End If
        If Not (flg) Then
            camera_flg1 = flg
            Label11.ForeColor = Color.White
            Label2.BackColor = Color.White
            Me.Invalidate()
        End If
        ' PictureBox6.Visible = flg
        'Return flg
    End Sub
    Private Async Sub Over(joutais) ' As Boolean
        Dim Joutai As Integer = joutais
        'Dengen = True
        Label43.Visible = False
        PictureBox2.Image = Images(21)
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Enabled = False
        Timer6.Enabled = False
        Timer7.Enabled = False
        PictureBox1.Visible = False
        PictureBox2.Visible = True
        PictureBox3.Visible = False
        ProgressBar1.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox8.Visible = False
        PictureBox12.Visible = False
        PictureBox13.Visible = False
        Label2.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label13.Visible = False
        Label14.Visible = False
        Label15.Visible = False
        Label16.Visible = False
        Label17.Visible = False
        Label18.Visible = False
        Label20.Visible = False
        Label35.Visible = False
        Label36.Visible = False
        Label39.Visible = False
        ' Label40.Visible = Not (flg)
        Label41.Visible = False
        Label24.Visible = False
        Label28.Visible = False
        Label30.Visible = False
        Label32.Visible = False

        Label31.Visible = False
        Label45.Visible = False
        Label46.Visible = False
        Label47.Visible = False
        Label48.Visible = False
        Label49.Visible = False
        Label50.Visible = False
        Label51.Visible = False
        Label52.Visible = False
        Label53.Visible = False
        Label53.Text = "Keypad"
        Label54.Visible = False
        Keta = 0
        Text_count2 = 0
        Wa = 0
        Wa2 = 0
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        PictureBox11.Visible = False
        PictureBox7.Visible = False
        PictureBox15.Visible = False
        PictureBox16.Visible = False
        PictureBox17.Visible = False
        PictureBox18.Visible = False
        PictureBox19.Visible = False
        Label33.Visible = False
        Label37.Visible = False
        Label36.Visible = False
        Label44.Visible = False
        Label60.Visible = False
        Label3.Visible = False
        Label3.Visible = False
        camera_flg1 = False
        Label1.Visible = False
        Label19.Visible = False
        Label21.Visible = False
        Label38.Visible = False
        Label1.Visible = False
        Label11.ForeColor = Color.White
        Label2.BackColor = Color.White
        Label41.BackColor = Color.DarkRed
        Label33.BackColor = Color.DarkRed
        Label20.BackColor = Color.DarkOliveGreen
        Label39.BackColor = Color.DarkRed
        Label37.BackColor = Color.DarkRed
        Label36.BackColor = Color.DarkOliveGreen
        Label41.BackColor = Color.DarkRed
        Label35.BackColor = Color.DarkOliveGreen
        Select Case Joutai
            Case 1
                Game_Over = True
                Timer8.Enabled = True
                Label4.Visible = True
            Case 2
                Game_clear = True
                PictureBox2.Image = Images(100)
                Label4.Location = New Point(310, 239)
                Label26.Location = New Point(293, 150)
                Label26.Visible = True
                AxWindowsMediaPlayer2.URL = Ongaku(14)
                AxWindowsMediaPlayer2.Ctlcontrols.play()
                Label26.Text = "5 AM"
                Await Task.Delay(500)
                Label26.Text = "  AM"
                Await Task.Delay(500)
                AxWindowsMediaPlayer2.URL = Ongaku(14)
                AxWindowsMediaPlayer2.Ctlcontrols.play()
                Label26.Text = "5 AM"
                Await Task.Delay(500)
                Label26.Text = "  AM"
                Await Task.Delay(500)
                AxWindowsMediaPlayer2.URL = Ongaku(14)
                AxWindowsMediaPlayer2.Ctlcontrols.play()
                Label26.Text = "5 AM"
                Await Task.Delay(500)
                Label26.Text = "  AM"
                Await Task.Delay(500)
                AxWindowsMediaPlayer2.URL = Ongaku(14)
                AxWindowsMediaPlayer2.Ctlcontrols.play()
                Label26.Text = "6 AM"
                Await Task.Delay(500)
                Label26.Location = New Point(156, 143)
                AxWindowsMediaPlayer2.URL = Ongaku(15)
                AxWindowsMediaPlayer2.Ctlcontrols.play()
                Label26.Text = "Game Clear"
                AxWindowsMediaPlayer1.URL = Ongaku(16)
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                Timer8.Enabled = True
                Label4.Text = "すごい！"
                Label4.Visible = True
                Await Task.Delay(5000)
                Game_clear = True
                Form2.Show()
                Me.Hide()

            Case 3
                Game_clear = True
                Form2.Show()
                Me.Hide()
            Case 4
                PictureBox2.Image = Images(32)
                Label19.Visible = True
                Label21.Visible = True
                Label38.Visible = True
            Case 5
                PictureBox2.Image = Images(22)
            Case 6
                PictureBox2.Image = Images(23)
            Case 7
                PictureBox2.Image = Images(24)
        End Select
        Me.Invalidate()
        ' PictureBox6.Visible = flg
        'Return flg
    End Sub

    Private Async Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Await Task.Delay(100)
        r3.Next((4 * Rnd()) + 1)
        If Dengen = False Then
            If Gamen_flg = False Then
                AxWindowsMediaPlayer1.URL = Ongaku(10)
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                Gamens(True)
                Gamen_flg = True
                Me.Invalidate()
            Else
                AxWindowsMediaPlayer1.URL = Ongaku(11)
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                Gamens(False)
                Gamen_flg = False
            End If
        End If
    End Sub




    Private Async Sub Cam1_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If camera_flg1 = False Then
            camera_flg1 = True
            Label11.ForeColor = Color.Yellow
            Me.Invalidate()
            heri1 = 1
            If T1_room = 4 Or T2_room = 4 Or T3_room = 4 Then
                Syasin_flg = True
                AxWindowsMediaPlayer1.URL = Ongaku(4)
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            Else
                Syasin_flg = False
                AxWindowsMediaPlayer1.URL = Ongaku(8)
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            End If
            Label3.Visible = False
            Label2.BackColor = Color.Yellow
            PictureBox1.Visible = True
            Await Task.Delay(3000)
            Label11.ForeColor = Color.White
            Label3.Visible = True
            camera_flg1 = False
            Me.Invalidate()
            Label2.BackColor = Color.White
            PictureBox1.Visible = False
        End If
    End Sub





    Private Sub Cam6_Click(sender As Object, e As EventArgs) Handles Label8.Click
        ' Camera_on(14)
        If Doutai_flg2 = True Then
            Doutai_flg2 = False

        Else
            Doutai_flg2 = True


        End If
        Me.Invalidate()
    End Sub



    Private Async Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim zanryo As Integer
        Dim heri As Integer
        Dim heri2 As Integer
        Dim heri3 As Integer
        Dim light1 As Integer
        Dim light2 As Integer
        Dim gamen As Integer
        '   Dim gamen_flg = False
        If Shatta_flg1 Then
            heri = 250
        Else
            heri = 1100
        End If
        If Shatta_flg2 Then
            heri2 = 250
        Else
            heri2 = 1100
        End If
        If Shatta_flg3 Then
            heri3 = 250
        Else
            heri3 = 1100
        End If
        If Light_flg1 Then
            light1 = 200
        Else
            light1 = 0
        End If
        If Light_flg2 Then
            light2 = 200
        Else
            light2 = 0
        End If
        If Gamen_flg Then
            gamen = 200
        Else
            gamen = 0
        End If
        zanryo = (heri + heri2 + heri3) - light1 - light2 - gamen
        '  Label61.Text = Str(zanryo)
        Timer1.Interval = zanryo
        If denci > 0 Then
            denci -= 1
        End If
        Label19.Text = Str(denci) + "%"
        If denci <= 60 And denci >= 30 Then
            Label38.Text = "┃■■ ┃"
        ElseIf denci <= 30 And denci >= 1 Then
            Label38.Text = "┃■   ┃"
        ElseIf denci = 0 Then
            If Shatta_flg1 = True Then
                AxWindowsMediaPlayer3.URL = Ongaku(0)
                AxWindowsMediaPlayer3.Ctlcontrols.play()
                PictureBox9.Image = Images(6)
                Await Task.Delay(100)
                PictureBox9.Image = Images(5)
                Shatta_flg1 = False
            End If
            If Shatta_flg2 = True Then
                Label35.BackColor = Color.DarkOliveGreen
                AxWindowsMediaPlayer2.URL = Ongaku(0)
                AxWindowsMediaPlayer2.Ctlcontrols.play()
                PictureBox10.Image = Images(12)
                Await Task.Delay(100)
                PictureBox10.Image = Images(11)
                Shatta_flg2 = False
            End If
            If Shatta_flg3 = True Then
                AxWindowsMediaPlayer5.URL = Ongaku(0)
                AxWindowsMediaPlayer5.Ctlcontrols.play()
                PictureBox11.Image = Images(12)
                Await Task.Delay(100)
                PictureBox11.Image = Images(11)
                Shatta_flg3 = False
            End If
            Label38.Text = "┃     ┃"
            If Gamen_flg = True Then
                Gamens(False)
                AxWindowsMediaPlayer1.URL = Ongaku(11)
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                Gamen_flg = False
            End If
            Dengen = True
            Light_flg1 = False
            Shatta_flg1 = False
            Shatta_flg2 = False
            Shatta_flg3 = False
            Label41.BackColor = Color.DarkRed
            Label33.BackColor = Color.DarkRed
            Label20.BackColor = Color.DarkOliveGreen
            Label39.BackColor = Color.DarkRed
            Label37.BackColor = Color.DarkRed
            Label36.BackColor = Color.DarkOliveGreen
            Label41.BackColor = Color.DarkRed
            Label35.BackColor = Color.DarkOliveGreen
            Light_flg3 = False
            Timer1.Stop()
            '  AxWindowsMediaPlayer1.Ctlcontrols.stop()
        End If
    End Sub

    Private Async Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        If Dengen = False Then
            If Shatta_flg1 = False Then
                AxWindowsMediaPlayer1.URL = Ongaku(0)
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                PictureBox12.Visible = False
                Shatta_flg1 = True
                Label33.BackColor = Color.Red
                Label20.BackColor = Color.Chartreuse
                Light_flg1 = False
                Light1_flg = False
                Label39.BackColor = Color.DarkRed
                PictureBox9.Image = Images(6)
                Await Task.Delay(100)
                PictureBox9.Image = Images(7)
                Kankaku = 1750
                Await Task.Delay(100)
            Else
                AxWindowsMediaPlayer1.URL = Ongaku(1)
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                Label20.BackColor = Color.DarkOliveGreen
                Label33.BackColor = Color.DarkRed
                Shatta_flg1 = False
                PictureBox9.Image = Images(6)
                Await Task.Delay(100)
                PictureBox9.Image = Images(5)
                Kankaku = 2000
                Await Task.Delay(100)
            End If
        End If
    End Sub



    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If ProgressBar1.Value + 1 <= 100 Then
            ' AxWindowsMediaPlayer1.URL = Ongaku(13)
            '  AxWindowsMediaPlayer1.Ctlcontrols.play()
            ProgressBar1.Value += 1
        Else
            If ProgressBar1.IsHandleCreated Then
                SendMessage(New HandleRef(ProgressBar1, ProgressBar1.Handle),
                        PBM_SETSTATE, PBST_ERROR, IntPtr.Zero)
            End If
            Label10.Text = "起動
イエーイ"
        End If
    End Sub

    Private Sub Label10_MouseDown(sender As Object, e As EventArgs) Handles Label10.MouseDown
        Timer2.Enabled = True
        Timer2.Start()
        Label10.ForeColor = Color.Red
        Timer5.Stop()
    End Sub

    Private Sub Label10_MouseUp(sender As Object, e As MouseEventArgs) Handles Label10.MouseUp
        Timer2.Stop()
        Label10.ForeColor = Color.Black
        Timer5.Start()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        jikan += 1
        Label21.Text = Str(jikan) + " AM"
        If jikan = 6 And ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            Timer4.Enabled = False
            Timer6.Enabled = False
            Timer7.Enabled = False
            '  Label23.Visible = True
            Label43.Text = "おめでとうお前"
            Over(2)
        ElseIf jikan = 6 And ProgressBar1.Value < 100 Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            Timer4.Enabled = False
            Timer6.Enabled = False
            Timer7.Enabled = False
            'Label43.Visible = True
            ' Label43.Text = "失敗お前"
            Over(4)
            Game_Overs = True
            Game_Over = True
            Timer9.Enabled = True
        End If
    End Sub

    Private Sub Iroiro2()
        Dim r4 As New Random()
        If dash_x2s(dash_count2) <= dash_x2sx(dash_count2) Then
            x_d3 = r4.Next(dash_x2s(dash_count2), dash_x2sx(dash_count2))
        Else
            x_d3 = r4.Next(dash_x2sx(dash_count2), dash_x2s(dash_count2))
        End If
        If dash_y2s(dash_count2) <= dash_y2sx(dash_count2) Then
            y_d3 = r4.Next(dash_y2s(dash_count2), dash_y2sx(dash_count2))
        Else
            y_d3 = r4.Next(dash_y2sx(dash_count2), dash_y2s(dash_count2))
        End If
    End Sub
    Private Function Hantei(Bangos)
        Dim T_x As Integer = Controls("Label" & CStr(Bangos)).Location.X
        Dim T_y As Integer = Controls("Label" & CStr(Bangos)).Location.Y
        Select Case True
            Case (T_x >= 559 And T_x <= 687) And (T_y >= 112 And T_y <= 228)
                Return 0
            Case (T_x >= 496 And T_x <= 524) And (T_y >= 176 And T_y <= 248)
                Return 1
            Case (T_x >= 489 And T_x <= 557) And (T_y >= 268 And T_y <= 336)
                Return 2
            Case (T_x >= 605 And T_x <= 646) And (T_y >= 230 And T_y <= 310)
                Return 4
            Case (T_x >= 716 And T_x <= 738) And (T_y >= 132 And T_y <= 282)
                Return 5
            Case (T_x >= 706 And T_x <= 729) And (T_y >= 318 And T_y <= 345)
                Return 6
            Case (T_x >= 497 And T_x <= 524) And (T_y >= 83 And T_y <= 109)
                Return 7
            Case Else
                Return -1
        End Select
    End Function

    Private Async Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Dim times = r4.Next((5000 * Rnd()) + 1000)
        Await Task.Delay(times)
        If Game_Over = False And Game_clear = False Then
            If Syasin_flg Then
                PictureBox1.Image = Images(2)
            Else
                PictureBox1.Image = Images(1)
            End If
            If Light_flg1 = True And ((dash_count = 3 And T_mode1 = 1) Or (dash_count2 = 3 And T_mode2 = 1)) And Shatta_flg1 = False Then
                If Light1_flg Then
                    AxWindowsMediaPlayer2.URL = Ongaku(4)
                    AxWindowsMediaPlayer2.Ctlcontrols.play()
                    Light1_flg = False
                End If
                PictureBox12.Visible = True
            Else
                Light1_flg = True
                PictureBox12.Visible = False
            End If
            If Light_flg3 = True And ((dash_count = 3 And T_mode1 = 3) Or (dash_count2 = 3 And T_mode2 = 3)) And Shatta_flg3 = False Then
                If Light2_flg Then
                    AxWindowsMediaPlayer2.URL = Ongaku(4)
                    AxWindowsMediaPlayer2.Ctlcontrols.play()
                    Light2_flg = False
                End If
                PictureBox13.Visible = True
            Else
                Light2_flg = True
                PictureBox13.Visible = False
            End If
            T2_room = Hantei(34)
            If Await Dash_Rex2() = True And T_joutai2 > -1 Then
                '    Label53.Text = "True"
                If T_joutai2 = 2 Then
                    If dash_count2 + 1 = 5 Or dash_count2 + 1 = 7 Then
                        dash_count2 = 2
                    End If
                    '  ElseIf T_joutai2 > -1 Then
                    '    If dash_count2 + 1 = Not 3 Then
                    'dotira = r5.Next(1, 3)
                    '   End If
                    '  Iroiro2()
                    dash_count2 += 1
                    Idou_flg3 = False
                ElseIf T_joutai2 > -1 Then
                    '  T_location2 = dash_count2
                    '     Label53.Text = "False"
                    ' Idou_flg3 = True
                End If
                If T_joutai2 = 0 Then
                    dash_count2 -= 1
                End If
            End If
            If T_joutai2 = -1 And Await Dash_Rex2() = False Then
                Idou_flg3 = False
            End If
            If T_joutai2 = -1 And Await Dash_Rex2() = True Then
                '  T_location2 = dash_count2
                'dotira = r4.Next(1, 3)
                ' Iroiro2()
                'dash_count2 += 1
                dotira = 1
                T_joutai2 = 2
                Idou_flg3 = True
                '  Label46.Text = "True"
            End If
        End If
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

        Label21.Text = "Go"
    End Sub

    Private Async Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click
        If Doutai_flg5 = False And Doutai_flg2 = False And Doutai_flg1 = False And Doutai_flg4 = False Then
            Doutai_flg5 = True
            Me.Invalidate()
            AxWindowsMediaPlayer1.URL = Ongaku(8)
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            Label30.BackColor = Color.Yellow
            Label16.ForeColor = Color.Yellow
            Label17.ForeColor = Color.Yellow
            If T1_room = 0 Then
                Await Task.Delay(10)
                AxWindowsMediaPlayer1.URL = Ongaku(6)
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                Label25.Visible = True
                Await Task.Delay(1000)
                Label25.Visible = False
            End If
            If T2_room = 0 Then
                Await Task.Delay(10)
                AxWindowsMediaPlayer1.URL = Ongaku(6)
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                Label34.Visible = True
                Await Task.Delay(1000)
                Label34.Visible = False
            End If
            If T3_room = 0 Then
                Await Task.Delay(10)
                AxWindowsMediaPlayer1.URL = Ongaku(6)
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                Label22.Visible = True
                Await Task.Delay(1000)
                Label22.Visible = False
            End If
            Await Task.Delay(500)
            Label30.BackColor = Color.White
            Label16.ForeColor = Color.White
            Label17.ForeColor = Color.White
            Doutai_flg5 = False
            Me.Invalidate()
        End If

    End Sub


    Async Function AsyncFunction(times As Integer) As Task

        Await Task.Delay(times)
    End Function

    Private Async Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Dim times = r3.Next((5000 * Rnd()) + 1000)
        Await Task.Delay(times)
        T1_room = Hantei(25)
        '   ShowMessageBoxes()
        If Game_Over = False And Game_clear = False Then
            If Await Dash_Rex() = True And T_joutai1 > -1 Then
                If T_joutai1 = 2 Then
                    If dash_count + 1 = 5 Or dash_count + 1 = 7 Then
                        dash_count = 2
                    End If
                    '  ElseIf T_joutai2 > -1 Then
                    '    If dash_count2 + 1 = Not 3 Then
                    'dotira = r5.Next(1, 3)
                    '   End If
                    '  Iroiro2()
                    dash_count += 1
                ElseIf T_joutai1 > -1 Then
                    '  T_location2 = dash_count2
                    ' Idou_flg3 = True
                End If
                If T_joutai1 = 0 Then
                    dash_count -= 1
                End If
            End If
            If T_joutai1 = -1 And Await Dash_Rex() = False Then
                ' Idou_flg3 = False
            End If
            If T_joutai1 = -1 And Await Dash_Rex() = True Then
                '  T_location2 = dash_count2
                'dotira = r4.Next(1, 3)
                ' Iroiro2()
                'dash_count2 += 1
                dotira = 1
                T_joutai1 = 2
                ' Idou_flg3 = True
                ' Label46.Text = "True"
            End If
        End If
    End Sub

    Private Async Sub Label35_Click(sender As Object, e As EventArgs) Handles Label35.Click
        If Dengen = False Then
            If Shatta_flg2 = False Then
                AxWindowsMediaPlayer1.URL = Ongaku(0)
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                Shatta_flg2 = True
                Label35.BackColor = Color.Chartreuse
                PictureBox10.Image = Images(12)
                Await Task.Delay(100)
                PictureBox10.Image = Images(13)
                Kankaku = 650
                Await Task.Delay(100)
            Else
                AxWindowsMediaPlayer1.URL = Ongaku(1)
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                Shatta_flg2 = False
                Label35.BackColor = Color.DarkOliveGreen
                PictureBox10.Image = Images(12)
                Await Task.Delay(100)
                PictureBox10.Image = Images(11)
                Kankaku = 2000
                Await Task.Delay(100)
            End If
        End If
    End Sub

    Private Async Sub Label36_Click(sender As Object, e As EventArgs) Handles Label36.Click
        If Dengen = False Then
            If Shatta_flg3 = False Then
                If PictureBox13.Visible = True Then
                    PictureBox13.Visible = False
                End If
                AxWindowsMediaPlayer1.URL = Ongaku(0)
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                Shatta_flg3 = True
                Label37.BackColor = Color.Red
                Label36.BackColor = Color.Chartreuse
                Light_flg3 = False
                Light2_flg = False
                Label41.BackColor = Color.DarkRed
                PictureBox11.Image = Images(6)
                Await Task.Delay(100)
                PictureBox11.Image = Images(7)
                Kankaku = 1750
                Await Task.Delay(100)
            Else
                AxWindowsMediaPlayer1.URL = Ongaku(1)
                Label37.BackColor = Color.DarkRed
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                Shatta_flg3 = False
                Label36.BackColor = Color.DarkOliveGreen
                PictureBox11.Image = Images(6)
                Await Task.Delay(100)
                PictureBox11.Image = Images(5)
                Kankaku = 2000
                Await Task.Delay(100)
            End If
        End If
    End Sub

    Private Async Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click
        If Doutai_flg3 = False And Doutai_flg5 = False And Doutai_flg1 = False And Doutai_flg4 = False Then
            Doutai_flg3 = True
            AxWindowsMediaPlayer1.URL = Ongaku(8)
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            Me.Invalidate()
            Label24.BackColor = Color.Yellow
            If T1_room = 5 Then
                '  Await Task.Delay(10)
                AxWindowsMediaPlayer1.URL = Ongaku(6)
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                Label25.Visible = True
                Await Task.Delay(1000)
                Label25.Visible = False
            End If
            If T2_room = 5 Then
                '  Await Task.Delay(10)
                AxWindowsMediaPlayer1.URL = Ongaku(6)
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                Label34.Visible = True
                Await Task.Delay(1000)
                Label34.Visible = False
            End If
            Await Task.Delay(500)
            Label24.BackColor = Color.White
            Doutai_flg3 = False
            Me.Invalidate()
        End If


        If Doutai_flg5 = False And T_location2 = Not (5) And T_location1 = Not (5) Then
            Label24.BackColor = Color.Yellow
            Doutai_flg5 = True
        End If
        If Doutai_flg5 = True Then
            Doutai_flg5 = False
            Label24.BackColor = Color.White
        End If
    End Sub


    Private Sub Serekuto()
        Dim V As Integer = Text_count2
        Dim storyManager As New StoryManager(Me)
        Dim names As String = storyManager.Names(V)
        ' Dim storyManager2 As New StoryManager2(Me)
        Dim names1 As String
        Dim names2 As String
        Dim names3 As String
        Dim nextCharacter1 As String
        Dim nextCharacter2 As String
        Dim nextCharacter3 As String
        '  Dim nextCharacter_2_1 As String = storyManager2.GetNextCharacter(counts, v)
        ' Dim names2_1 As String = storyManager2.Names(v)
        Select Case V
            Case 0
                Label58.Text = "-------"
                Label59.Text = "-------"
                Label61.Text = "-------"
            Case 1
                names3 = storyManager.Names(V - 1)
                nextCharacter3 = names3 + " : " + storyManager.GetNextCharacter2(V - 1)
                Label58.Text = "-------"
                Label59.Text = "-------"
                Label61.Text = nextCharacter3
            Case 2
                names2 = storyManager.Names(V - 2)
                names3 = storyManager.Names(V - 1)
                nextCharacter2 = names2 + " : " + storyManager.GetNextCharacter2(V - 2)
                nextCharacter3 = names3 + " : " + storyManager.GetNextCharacter2(V - 1)
                Label58.Text = "-------"
                Label59.Text = nextCharacter2
                Label61.Text = nextCharacter3
            Case >= 3
                names1 = storyManager.Names(V - 3)
                names2 = storyManager.Names(V - 2)
                names3 = storyManager.Names(V - 1)
                nextCharacter1 = names1 + " : " + storyManager.GetNextCharacter2(V - 3)
                nextCharacter2 = names2 + " : " + storyManager.GetNextCharacter2(V - 2)
                nextCharacter3 = names3 + " : " + storyManager.GetNextCharacter2(V - 1)
                Label58.Text = nextCharacter1
                Label59.Text = nextCharacter2
                Label61.Text = nextCharacter3
        End Select
    End Sub

    Private Async Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick 'Foxy
        T3_room = Hantei(22)
        If Game_Over = False And Game_clear = False Then
            If Await Dash_Rex3() = True Then
                If dash_count3 + 1 < 4 And T_joutai3 > 0 Then
                    dash_count3 += 1
                    '  If dash_count + 1 = Not (3) Then
                    ' End If
                    Idou_flg4 = False
                ElseIf T_joutai3 = 0 Then
                    If dash_count3 - 1 > -1 Then
                        dash_count3 -= 1
                    End If
                    T_location3 = dash_count3
                End If
            Else
                Idou_flg4 = True
            End If
        End If
    End Sub

    Private Async Sub Label39_Click(sender As Object, e As MouseEventArgs) Handles Label39.MouseDown
        Await Task.Delay(10)
        If Dengen = False Then
            If Light_flg1 = False And Shatta_flg1 = False Then
                PictureBox9.Image = Images(8)
                AxWindowsMediaPlayer2.URL = Ongaku(2)
                AxWindowsMediaPlayer2.Ctlcontrols.play()
                If (dash_count = 3 And T_mode1 = 1) Or (dash_count2 = 3 And T_mode2 = 1) Then
                    PictureBox12.Visible = True
                    Light1_flg = True
                    AxWindowsMediaPlayer2.URL = Ongaku(4)
                    AxWindowsMediaPlayer2.Ctlcontrols.play()
                End If
                Light_flg1 = True
                Label39.BackColor = Color.Red
            End If
        End If
    End Sub

    Private Async Sub Label40_Click(sender As Object, e As MouseEventArgs) Handles Label40.MouseDown
        Await Task.Delay(10)
        If Light_flg2 = False And Shatta_flg2 = False Then
            PictureBox10.Image = Images(14)
            AxWindowsMediaPlayer2.URL = Ongaku(2)
            AxWindowsMediaPlayer2.Ctlcontrols.play()
            If (dash_count = 3 And T_mode1 = 3) Or (dash_count2 = 3 And T_mode2 = 3) Then
                PictureBox14.Visible = True
                AxWindowsMediaPlayer2.URL = Ongaku(3)
                AxWindowsMediaPlayer2.Ctlcontrols.play()
            End If
            Light_flg2 = True
            Await Task.Delay(10)
            Label40.BackColor = Color.Red
        End If
    End Sub

    Private Async Sub Label41_Click(sender As Object, e As MouseEventArgs) Handles Label41.MouseDown
        Await Task.Delay(10)
        If Dengen = False Then
            If Light_flg3 = False And Shatta_flg3 = False Then
                PictureBox11.Image = Images(8)
                AxWindowsMediaPlayer2.URL = Ongaku(2)
                AxWindowsMediaPlayer2.Ctlcontrols.play()
                If (dash_count2 = 3 And T_mode2 = 3) Or (dash_count = 3 And T_mode1 = 3) Then
                    ' Light2_flg = True
                    PictureBox13.Visible = True
                    AxWindowsMediaPlayer2.URL = Ongaku(4)
                    AxWindowsMediaPlayer2.Ctlcontrols.play()
                End If
                Light_flg3 = True
                Label41.BackColor = Color.Red
            End If
        End If
    End Sub


    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If ProgressBar1.Value > 0 And ProgressBar1.Value < 100 Then
            ProgressBar1.Value -= 1
        End If
    End Sub

    Private Async Sub Label60_Click(sender As Object, e As EventArgs) Handles Label60.Click
        If Doutai_flg1 = False And Doutai_flg5 = False And Doutai_flg3 = False And Doutai_flg4 = False Then
            Doutai_flg1 = True
            Me.Invalidate()
            Label60.BackColor = Color.Yellow
            If T3_room = 7 Then
                AxWindowsMediaPlayer1.URL = Ongaku(6)
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                Label22.Visible = True
                Await Task.Delay(1000)
                Label22.Visible = False
            Else
                AxWindowsMediaPlayer1.URL = Ongaku(8)
                AxWindowsMediaPlayer1.Ctlcontrols.play()
            End If
            Await Task.Delay(500)
            Label60.BackColor = Color.White
            Doutai_flg1 = False
            Me.Invalidate()
        End If
    End Sub

    Private Async Sub Label44_Click(sender As Object, e As EventArgs) Handles Label44.Click
        If Doutai_flg4 = False Then
            Doutai_flg4 = True
            Me.Invalidate()
            AxWindowsMediaPlayer1.URL = Ongaku(8)
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            Label44.BackColor = Color.Yellow
            If T1_room = 1 Then
                '  Await Task.Delay(10)
                AxWindowsMediaPlayer1.URL = Ongaku(6)
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                Label25.Visible = True
                Await Task.Delay(1000)
                Label25.Visible = False

            End If
            If T2_room = 1 Then
                '  Await Task.Delay(10)
                AxWindowsMediaPlayer1.URL = Ongaku(6)
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                Label34.Visible = True
                Await Task.Delay(1000)
                Label34.Visible = False

            End If
            Await Task.Delay(500)
            Label44.BackColor = Color.White
            Doutai_flg4 = False
            Me.Invalidate()
        End If
    End Sub

    Private Async Sub Label41_MouseUP(sender As Object, e As EventArgs) Handles Label41.MouseUp
        If Shatta_flg3 = False Then
            Light2_flg = False
            AxWindowsMediaPlayer2.Ctlcontrols.stop()
            PictureBox11.Image = Images(5)
            PictureBox13.Visible = False
            Light_flg3 = False
            Await Task.Delay(10)
            Label41.BackColor = Color.DarkRed
        End If
    End Sub

    Private Async Sub Label39_MouseUp(sender As Object, e As MouseEventArgs) Handles Label39.MouseUp
        If Shatta_flg1 = False Then
            Light1_flg = False
            AxWindowsMediaPlayer2.Ctlcontrols.stop()
            Await Task.Delay(10)
            PictureBox9.Image = Images(5)
            PictureBox12.Visible = False
            Light_flg1 = False
            Label39.BackColor = Color.DarkRed
        End If
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        Dim Label_x As Integer = r5.Next(272, 356)
        Dim Label_y As Integer = r5.Next(193, 232)
        Dim Label_rgb As Integer = r5.Next(64, 192)
        Dim rgb1 As Integer = r5.Next(0, 256)
        Dim rgb2 As Integer = r5.Next(0, 256)
        Dim rgb3 As Integer = r5.Next(0, 256)
        Dim rgb4 As Integer = r5.Next(0, 256)
        Dim rgb5 As Integer = r5.Next(0, 256)
        Dim rgb6 As Integer = r5.Next(0, 256)
        If Game_Over Then
            Label4.ForeColor = Color.FromArgb(Label_rgb, 0, 0)
            Label4.BackColor = Color.FromArgb(194, 194, 194)
            Label4.Location = New Point(Label_x, Label_y)
        End If
        If Game_clear Then
            Label26.ForeColor = Color.FromArgb(rgb1, rgb2, rgb3)
            Label4.ForeColor = Color.FromArgb(rgb4, rgb5, rgb6)
        End If
    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click
        If Game_clear = False And Game_Over = False Then
            Game_start()
            Label23.Visible = False
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Game_Over = True Then
            Label23.Visible = True
            Over(0)
            PictureBox2.Image = Images(22)
            Label4.Visible = False
        End If
    End Sub


    Private Async Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        Dim storyManager As New StoryManager(Me)
        Dim nextCharacter As String = storyManager.GetNextCharacter(counts, Text_count)
        Dim names As String = storyManager.Names(Text_count)
        Dim storyManager2 As New StoryManager2(Me)
        Dim nextCharacter2 As String
        Dim names2 As String
        If Game_Overs = True Then
            nextCharacter2 = storyManager2.GetNextCharacter(counts, Text_count)
            names2 = storyManager2.Names(Text_count)
        End If
        If Game_Over = False And Game_clear = False And Label58.Visible = False Then
            counts += 1

            Serekuto()
            Label29.Text = names
            If nextCharacter IsNot Nothing Then
                Label27.Text &= nextCharacter
                'Label27.Text &= counts
            End If
            If nextCharacter Is Nothing Then
                Timer9.Stop() ' 文字列の末尾に到達したらタイマーを停止
                counts = 0
                Await Task.Delay(1000)
                Label27.Text = ""
                Label29.Text = ""
                Text_count += 1
                Text_count2 += 1
                Timer9.Start()
            End If

            Select Case Text_count
                Case 0
                    PictureBox2.Image = Images(100)
                Case 5
                    PictureBox2.Image = Images(32)
                    PictureBox20.Image = Images(31)
                Case 6
                    PictureBox20.Image = Images(44)
                Case 9
                    PictureBox20.Image = Images(27)
                Case 11
                    PictureBox20.Image = Images(26)
                Case 12
                    PictureBox20.Image = Images(44)
                Case 15
                    PictureBox2.Image = Images(33)
                Case 17
                    PictureBox2.Image = Images(34)
                Case 21
                    PictureBox2.Image = Images(35)
                Case 22
                    PictureBox2.Image = Images(36)
                Case 24
                    PictureBox2.Image = Images(35)
                Case 25
                    PictureBox2.Image = Images(36)
                Case 26
                    PictureBox2.Image = Images(37)
                Case 29
                    PictureBox2.Image = Images(38)
                Case 30
                    PictureBox2.Image = Images(39)
                Case 33
                    PictureBox2.Image = Images(40)
                Case 35
                    PictureBox2.Image = Images(41)
                Case 39
                    PictureBox2.Image = Images(42)
                Case 42
                    PictureBox2.Image = Images(32)
                Case 43
                    PictureBox2.Image = Images(43)
                Case 49
                    PictureBox2.Image = Images(32)
                Case 58
                    Label57.Visible = False
                    Label63.Visible = False
                    PictureBox20.Visible = False
                    Timer9.Stop()
                    Await Task.Delay(1000)
                    Label27.Text = ""
                    Label29.Text = ""
                    Text_count = 0
                    Label23.Visible = True
            End Select


        ElseIf Game_Overs = True Then
            counts += 1
            Label29.Text = names2
            If nextCharacter2 IsNot Nothing Then
                Label27.Text &= nextCharacter2
                'Label27.Text &= counts
            End If
            If nextCharacter2 Is Nothing Then
                Timer9.Stop() ' 文字列の末尾に到達したらタイマーを停止
                counts = 0
                'Label27.Text &= Str(Text_count)
                Await Task.Delay(1000)
                Label27.Text = ""
                Label29.Text = ""
                Text_count += 1
                If Label58.Visible = False Then
                    Timer9.Start()
                End If
            End If
            If Text_count = 32 Then
                Timer9.Stop()
                Await Task.Delay(1000)
                Label27.Text = ""
                Label29.Text = ""
                Over(1)
            End If

        End If
    End Sub

    Private Sub KeyPad(kazu As Integer)
        Dim Kazu2 As Integer = kazu
        If Label53.Text = "Keypad" Or Label53.Text = "Bu Bu-!" Then
            Label53.Text = ""
        End If
        If Kazu2 = -1 Then
            If Label53.Text.Length - 1 > 0 Then
                Label53.Text = Label53.Text.Substring(0, Label53.Text.Length - 1)
                Wa -= Wa2
                If Keta - 1 = 0 Then
                    Label53.Text = "Keypad"
                    Keta = 0
                    Wa = 0
                Else
                    Keta -= 1
                End If
            Else
                Label53.Text = "Keypad"
                Keta = 0
            End If
        Else
            Wa += Kazu2
            Keta += 1
            Label53.Text &= Str(Kazu2)
        End If

        If Kazu2 <> -1 Then
            Wa2 = Kazu2
        End If

        If Keta = 3 And Wa = 3 Then
            AxWindowsMediaPlayer6.URL = Ongaku(27)
            AxWindowsMediaPlayer6.Ctlcontrols.play()
            Over(3)
        ElseIf Keta = 3 Then
            Label53.Text = "Bu Bu-!"
            Keta = 0
            Wa = 0
            Wa2 = 0
            AxWindowsMediaPlayer6.URL = Ongaku(26)
            AxWindowsMediaPlayer6.Ctlcontrols.play()
        End If

    End Sub
    Private Sub Label31_Click(sender As Object, e As EventArgs) Handles Label31.Click '1
        AxWindowsMediaPlayer6.URL = Ongaku(17)
        AxWindowsMediaPlayer6.Ctlcontrols.play()
        KeyPad(1)
    End Sub

    Private Sub Label45_Click(sender As Object, e As EventArgs) Handles Label45.Click '2
        AxWindowsMediaPlayer6.URL = Ongaku(18)
        AxWindowsMediaPlayer6.Ctlcontrols.play()
        KeyPad(2)
    End Sub

    Private Sub Label46_Click(sender As Object, e As EventArgs) Handles Label46.Click '3
        AxWindowsMediaPlayer6.URL = Ongaku(19)
        AxWindowsMediaPlayer6.Ctlcontrols.play()
        KeyPad(3)
    End Sub

    Private Sub Label47_Click(sender As Object, e As EventArgs) Handles Label47.Click '4
        AxWindowsMediaPlayer6.URL = Ongaku(20)
        AxWindowsMediaPlayer6.Ctlcontrols.play()
        KeyPad(4)
    End Sub

    Private Sub Label48_Click(sender As Object, e As EventArgs) Handles Label48.Click '5
        AxWindowsMediaPlayer6.URL = Ongaku(21)
        AxWindowsMediaPlayer6.Ctlcontrols.play()
        KeyPad(5)
    End Sub

    Private Sub Label49_Click(sender As Object, e As EventArgs) Handles Label49.Click '6
        AxWindowsMediaPlayer6.URL = Ongaku(22)
        AxWindowsMediaPlayer6.Ctlcontrols.play()
        KeyPad(6)
    End Sub

    Private Sub Label50_Click(sender As Object, e As EventArgs) Handles Label50.Click '7
        AxWindowsMediaPlayer6.URL = Ongaku(23)
        AxWindowsMediaPlayer6.Ctlcontrols.play()
        KeyPad(7)
    End Sub

    Private Sub Label51_Click(sender As Object, e As EventArgs) Handles Label51.Click '8
        AxWindowsMediaPlayer6.URL = Ongaku(24)
        AxWindowsMediaPlayer6.Ctlcontrols.play()
        KeyPad(8)
    End Sub

    Private Sub Label52_Click(sender As Object, e As EventArgs) Handles Label52.Click '9
        AxWindowsMediaPlayer6.URL = Ongaku(25)
        AxWindowsMediaPlayer6.Ctlcontrols.play()
        KeyPad(9)
    End Sub

    Private Sub Label54_Click(sender As Object, e As EventArgs) Handles Label54.Click
        AxWindowsMediaPlayer6.URL = Ongaku(8)
        AxWindowsMediaPlayer6.Ctlcontrols.play()
        KeyPad(-1)
    End Sub

    Private Sub Form1_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        If e.Delta > 0 And Text_count2 < Text_count Then
            Text_count2 += 1
            Serekuto()
        ElseIf e.Delta <= 0 And Text_count2 - 4 >= 0 Then
            Text_count2 -= 1
            ' Timer9.Stop()
            Serekuto()
        End If
    End Sub

    Private Sub Label57_Click(sender As Object, e As EventArgs) Handles Label57.Click
        If Label58.Visible = False Then
            Label58.Visible = True
            Label59.Visible = True
            Label61.Visible = True
            Label62.Visible = True
            Timer9.Stop()
            PictureBox21.Visible = True
            Label57.ForeColor = Color.Red
        Else
            Timer9.Start()
            PictureBox21.Visible = False
            Label58.Visible = False
            Label59.Visible = False
            Label61.Visible = False
            Label62.Visible = False
            Label57.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Label23_MouseEnter(sender As Object, e As EventArgs) Handles Label23.MouseEnter
        Label23.ForeColor = Color.Red
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        Over(3)
        Timer9.Enabled = False
    End Sub

    Private Sub Label23_Leave(sender As Object, e As EventArgs) Handles Label23.Leave
        If Not Label23.ClientRectangle.Contains(Label23.PointToClient(MousePosition)) Then
            Label23.ForeColor = Color.White
        End If
    End Sub

    Private Sub Label63_Click(sender As Object, e As EventArgs) Handles Label63.Click
        Text_count = 57
    End Sub
End Class
Public Class StoryManager
    Private ReadOnly formInstance As Form1
    Dim form1 As Form1 = Nothing
    Dim count2 As Integer = 0
    Dim Texts() As String = {"これは高橋（ティラノに追われてる人）が
ティラノに追われるずっと前の話…", "「佐々木」という少年の勇気と恐怖の
物語である！", "この話の主人公の佐々木は
高橋の友人なのだが", "怪奇現象によって
離れ離れになってしまった。", "それから一時間たった後。", "クソッタレの佐々木ィ！
どこ行きやがった！！", "スピーカーからノイズが流れた後
学校中に少年の声が響く", "ぎゃははァ！
爬虫類ごときに俺の場所がわかるかな？", "まったく俺の未来は明るいぜ！", "あ、わかった。
シャッター管理室にいるだろお前。", "終わったぁ…", "今から行くから首洗って
待ってろよ？", "青ざめた被食者は
スピーカーの電源を静かに落とす。", "さて遺言書でも書くかな。", "いや待てよ。
この部屋よく見てみると、なんかいろいろあるじゃないか。", "真ん中のパソコンに映っている
のはシステムボタンか", "クリックしている間下のゲージが
溜まっていくのか。", "このゲージがマックスにして
６時になると、",
"「Tyrannosaurus isolation system」
（ティラノサウルス隔離システム）が起動できる！", "俺は助からなくても
これ以上被害者を増やさなくて済むぞ！！", "他にも6時まで耐えるための
防衛設備があるみたいだ。", "右と左と真ん中にあるのは
シャッターか！", "緑の「OPEN DOWN」ボタンで
開け閉めすることができるのか。", "シャッターを閉めれば
ティラノが部屋に入ってくるのを阻止できる！", "ティラノサウルスは
右と左、そしてダクト（真ん中）の道のどれかからやってくる。", "それぞれの道に対応した
シャッターを閉めなければいけない。", "そして下にある赤いボタンは
ライトボタンか", "シャッターの近くにティラノが
来ていたらティラノの光る眼が表示されるみたいだ！", "ティラノが近いかどうかを
確認できるっていうことだな。", "下の「パソコン」をクリックすると
パソコンが起動できる。", "パソコンを起動すると3つのことが
できるみたいだな。", "１．「動体検知機」の使用
２.「監視カメラ」の確認", "３.「キーパッド」への入力。
一つずつ見ていこう。", "１の動体検知器は「Mov」をクリック
すると使用できる。", "一定の範囲内のティラノサウルスが
「●」で表示される！", "２の監視カメラも
クリックで使用できるみたいだ。", "使用すると
ダクト（真ん中）の様子が表示されるらしい。", "ダクトにティラノサウルスがいると
もちろんティラノが表示される。", "ダクトには動体検知器がないから
これで確認をするんだな。", "３のキーパッドは
隠された３桁の番号をクリックで入力すると", "「何かが起こる」
らしいぞ。", "もしこのゲームが難しかったら
ここで「１１１」と入力するといいような気がする…", "これらの防衛設備には
欠点があるみたいだ。", "それは「電池を使用する」こと。", "シャッターなどを使っていると
上にある94%みたいな数字が", "どんどん減っていくらしい！",
"そして0%になるとシャッターやパソコンが
「操作できなくなる！」", "つまり詰みってことか。", "こうならないためにも
シャッターとかを閉めっぱなしにしてはいけない！", "ここまでをまとめると",
"遠くのティラノはパソコンの動体検知器や
監視カメラで確認。", "近くのティラノサウルスはライトボタンで
確認をして、シャッターを閉める。", "これと並行してシステムボタンを
ゲージがマックスになるまで押して溜める。", "電池が0%にならないように
気を付けながら", "これを6時まで
やっていればいいんだな。", "この
ゲームはイヤホン推奨です。", "よく聞き耳を立てて
無事に生き残りましょう。", "幸運を祈っています。"} '57
    Dim Texts2() As String = {"ナレーション", "ナレーション", "ナレーション", "ナレーション",
        "ナレーション", "ティラノサウルス", "ナレーション", "スピーカー越しの佐々木", "スピーカー越しの佐々木",
        "ティラノサウルス", "スピーカー越しの佐々木", "ティラノサウルス", "ナレーション",
        "佐々木", "佐々木", "佐々木", "佐々木", "佐々木", "佐々木", "佐々木", "佐々木", "佐々木", "佐々木",
    "佐々木", "佐々木", "佐々木", "佐々木", "佐々木", "佐々木", "佐々木", "佐々木", "佐々木", "佐々木",
    "佐々木", "佐々木", "佐々木", "佐々木", "佐々木", "佐々木", "佐々木", "佐々木", "佐々木", "佐々木",
    "佐々木", "佐々木", "佐々木", "佐々木", "佐々木", "佐々木", "佐々木", "佐々木", "佐々木", "佐々木",
    "佐々木", "佐々木", "ナレーション", "ナレーション", "ナレーション"}
    Dim storyText As String = Texts(0)
    Dim storyText2 As String = Texts2(0)

    '   Private currentIndex As Integer = 0 ' 現在の文字の位置

    Public Sub New(form As Form1)
        formInstance = form
    End Sub

    Public Function Names(count) As String
        storyText2 = Texts2(count)
        Return storyText2
    End Function
    Public Function LogFlg(Logflgs) As Boolean
        If Logflgs Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function GetNextCharacter(currentIndex, count) As String
        storyText = Texts(count)
        If currentIndex < storyText.Length Then
            Dim nextCharacter As String
            nextCharacter &= storyText(currentIndex)
            Return nextCharacter
        Else
            Return Nothing
        End If
    End Function
    Public Function GetNextCharacter2(count) As String
        Dim Storys As String
        Storys = Texts(count)
        Return Storys
    End Function
End Class

Public Class StoryManager2
    Private ReadOnly formInstance As Form1
    Dim form1 As Form1 = Nothing
    Dim count2 As Integer = 0
    Dim Texts() As String = {"結局システムを立ち上げることは
できなかった。", "もうすぐ電池も切れてしまう。
ヤバいな。", "無情にも
電池は切れてしまった！！", "佐々木の命は
風前の灯火ィ！！", "ちくしょう…", "ん～…
おはよう！！", "アがが！？", "食物連鎖の頂点の
ティラノサウルス君だよ！", "（こ、殺される。
このままだと！）", "（命乞いをしなくては！）", "コンニチハ…
てぃらのさうるす サン。", "こんにちは。", "イイ天気ですね…",
"そうだね。", "こんなイイ天気には
殺生は向いてませんよね", "こんないい天気だからこそだろ。", "ちまちまと扉の開け閉めをする
小賢しいネズミを食い散らかすには、もってこいな日だ",
"そう思わないか？",
"やめてよして殺さないで！
運気が下がるよ風水だと！", "僕風水やってないんだよね。
クリスチャンだから。", "え、そうなの？", "ちょっとこんなことはどうでも
いいんだよ。", "ほんとはお前を料理人に勧誘しようと
思ったんだが、", "そんな惨めに命乞いしてる様を見てたら
誘う気にもなれなくなってきた。", "まっ待ってよ！", "待たない。
殺すから。", "俺めっちゃ料理できますぅ！", "マジ？
何を作れるのか言ってみろ。", "温泉卵。", "ギャアアアアアぁ！", "佐々木は無事にお陀仏！
ドンマイ！佐々木！！", "BAD END　～佐々木はマジ死～"} '32
    Dim Texts2() As String = {"佐々木", "佐々木", "ナレーション", "ナレーション",
        "佐々木", "ティラノサウルス", "佐々木", "ティラノサウルス", "佐々木",
        "佐々木", "佐々木", "ティラノサウルス", "佐々木",
        "ティラノサウルス", "佐々木", "ティラノサウルス", "ティラノサウルス", "ティラノサウルス", "佐々木", "ティラノサウルス",
    "佐々木", "ティラノサウルス", "ティラノサウルス", "ティラノサウルス", "佐々木", "ティラノサウルス", "佐々木",
    "ティラノサウルス", "佐々木", "佐々木", "ナレーション", "ナレーション"}
    Dim storyText As String = Texts(0)
    Dim storyText2 As String = Texts2(0)

    '   Private currentIndex As Integer = 0 ' 現在の文字の位置

    Public Sub New(form As Form1)
        formInstance = form
    End Sub

    Public Function Names(count) As String
        storyText2 = Texts2(count)
        Return storyText2
    End Function

    Public Function GetNextCharacter(currentIndex, count) As String
        storyText = Texts(count)
        If currentIndex < storyText.Length Then
            Dim nextCharacter As String
            nextCharacter &= storyText(currentIndex)
            Return nextCharacter
        Else
            Return Nothing
        End If
    End Function
End Class


