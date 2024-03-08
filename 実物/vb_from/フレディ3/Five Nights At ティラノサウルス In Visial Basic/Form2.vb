
Imports System.Reflection
Imports System.Runtime.InteropServices



Public Class Form2
    Dim picCounter As Integer = 16
    <DllImport("user32.dll", CharSet:=CharSet.Unicode)>
    Private Shared Function SendMessage(hWnd As HandleRef,
    Msg As UInt32, wParam As UInt32, lParam As IntPtr) As IntPtr
    End Function

    Private pictureBoxes As New List(Of PictureBox)
    Private progressBars As New List(Of ProgressBar)
    Private Kyakulist As New List(Of PictureBox)
    Private Const WM_USER As UInt32 = &H400
    Private Const PBM_SETSTATE As UInt32 = WM_USER + 16
    Private Const PBST_NORMAL As UInt32 = &H1
    Private Const PBST_ERROR As UInt32 = &H2
    Private Const PBST_PAUSED As UInt32 = &H3
    Dim Gamestart As Boolean = True
    Dim GameOver As Boolean = False
    Dim Indexs As Integer
    Dim Gousei_flg As Boolean = False
    Dim timerList As New List(Of Timer)()
    Dim Location_y() As Integer = {63, 121, 181}
    Dim PictureBoxs As PictureBox = Nothing
    Dim Bango As PictureBox = Nothing
    Dim Bango2 As Integer = 0
    Dim Sara_flg() As Boolean = {False, False, False, False}
    Dim Sara_flg2(3) As PictureBox
    Dim Conro_flg() As Boolean = {False, False, False, False}
    Dim Ckick_flg(3) As PictureBox
    Dim Youkyu(5) As Image
    Dim TimerInterval As Integer = 2000
    Dim Youkyu2 As New List(Of Integer)
    Dim Conro_flg2(3) As PictureBox
    Dim Manaita_flg As Boolean = False
    Dim Manaita_flg2 As PictureBox
    Dim Drink_flg As Boolean = False
    Dim Drink_flg2 As PictureBox
    Dim Drink_flg3 As ProgressBar
    Dim Over As Integer = 0
    Dim supercount2 = 0
    Dim Jikan As Integer = 60
    Dim Score As Integer
    Dim super_count As Integer = 0
    Dim Images(100) As Image
    Dim Souseji() As String = {"nama", "gomi"}
    Dim r8 As New Random(5676)
    Dim Hanasita_flg As Boolean = False
    Dim PictureBox_number As Integer = 17
    ' ドラッグ中かどうかを示すフラグ
    Private isDragging As Boolean = False
    Private Bugger As Boolean = False
    ' マウスの位置とLabelの位置の差分
    Private offsetX As Integer
    Private offsetY As Integer

    Async Function AsyncFunction(times As Integer) As Task

        Await Task.Delay(times)
    End Function
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 3
            Sara_flg(i) = False
            Sara_flg2(i) = Nothing
            Conro_flg(i) = False
            Conro_flg2(i) = Nothing
            Ckick_flg(i) = Nothing
        Next
        Drink_flg2 = Nothing
        Drink_flg3 = Nothing
        PictureBoxs = Nothing
        isDragging = False
        Gousei_flg = False
        AxWindowsMediaPlayer1.settings.autoStart = False
        AddHandler AxWindowsMediaPlayer1.PlayStateChange, AddressOf MediaPlayer_PlayStateChange
        Over = 0
        Over2 = 0
        Over3 = 0
        Over4 = 0
        Over5 = 0
        super_count = 3
        points = 0
        Jikan = 70
        Score = 0
        Timer1.Interval = 1000
        Timer1.Enabled = True
        Timer2.Interval = 15000
        Timer2.Enabled = True
        Timer3.Interval = 1000
        Timer3.Enabled = True
        Timer4.Interval = 100
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.ControlBox = False
        Images(0) = Image.FromFile("pan.png")
        Images(1) = Image.FromFile("so_se_ji.png")
        Images(2) = Image.FromFile("kyabetu.png")
        Images(3) = Image.FromFile("mijingiri.png")
        Images(4) = Image.FromFile("hotdog.png")
        Images(5) = Image.FromFile("fire.png")
        Images(6) = Image.FromFile("bone.png")
        Images(7) = Image.FromFile("kasu.png")
        Images(8) = Image.FromFile("kasu.png")
        Images(9) = Image.FromFile("kasu.png")
        Images(10) = Image.FromFile("kasu.png")
        Images(11) = Image.FromFile("honedake.png")
        Images(12) = Image.FromFile("kyabedake.png")
        Images(13) = Image.FromFile("baburu.jpg")
        Images(14) = Image.FromFile("potato.png")
        Images(15) = Image.FromFile("potato2.png")

        Images(16) = Image.FromFile("manaita.png")
        Images(17) = Image.FromFile("jagabox.png")
        Images(18) = Image.FromFile("kyabebox.png")
        Images(19) = Image.FromFile("panbox.png")
        Images(20) = Image.FromFile("drinks.png")
        Images(21) = Image.FromFile("dust.png")
        Images(22) = Image.FromFile("jagabox.png")
        Images(23) = Image.FromFile("bonebox.png")
        Images(24) = Image.FromFile("age.png")
        Images(25) = Image.FromFile("conro.png")
        Images(26) = Image.FromFile("drinks.png")
        Images(27) = Image.FromFile("sara.png")
        Images(28) = Image.FromFile("UI.png")
        Images(29) = Image.FromFile("fukudasi.png")
        Youkyu(0) = Image.FromFile("hotdog.png")
        Youkyu(1) = Image.FromFile("drink.png")
        Youkyu(2) = Image.FromFile("potato3.png")
        Dim r8 As New Random(566)
        Dim dotti As Integer = r8.Next(0, 3)
        PictureBox1.Image = Images(16)
        PictureBox1.BackColor = Color.Transparent
        PictureBox7.Image = Images(24)
        PictureBox7.BackColor = Color.Transparent
        PictureBox8.Image = Images(21)
        PictureBox8.BackColor = Color.Transparent
        PictureBox3.Image = Images(25)
        PictureBox3.BackColor = Color.Transparent
        PictureBox14.Image = Images(26)
        PictureBox14.BackColor = Color.Transparent
        PictureBox9.Image = Images(22)
        PictureBox9.BackColor = Color.Transparent
        PictureBox10.Image = Images(19)
        PictureBox10.BackColor = Color.Transparent
        PictureBox11.Image = Images(18)
        PictureBox11.BackColor = Color.Transparent
        PictureBox12.Image = Images(23)
        PictureBox12.BackColor = Color.Transparent
        PictureBox2.Image = Images(27)
        PictureBox2.BackColor = Color.Transparent
        PictureBox4.Image = Images(27)
        PictureBox4.BackColor = Color.Transparent
        PictureBox5.Image = Images(27)
        PictureBox5.BackColor = Color.Transparent
        PictureBox6.Image = Images(27)
        PictureBox6.BackColor = Color.Transparent
        PictureBox16.Image = Images(28)
        PictureBox16.BackColor = Color.Transparent
        Label2.BackColor = Color.FromArgb(171, 106, 60)
        Label2.Text = "Times:" & Str(Jikan)
        Label9.BackColor = Color.FromArgb(171, 106, 60)
        Label9.Text = "Score:" & Str(Score)
        Label8.BackColor = Color.FromArgb(171, 106, 60)
        Label8.Text = "Debug:"
        If Gamestart = True Then
            Me.BackgroundImage = Image.FromFile("haikei.jpg")
            For i = 1 To 12
                Controls("PictureBox" & i).Visible = True
            Next
            PictureBox16.Visible = True
        End If
        ' 初期位置を設定

        'Select Case dotti
        '     Case 0
        '     AxWindowsMediaPlayer1.URL = "蒸気船ウィリー.mp4" 'ウォルトディズニー製作
        '     Case 1
        '     AxWindowsMediaPlayer1.URL = "異常気船ウォーリー.mp4" 'ツシマケント製作
        '    End Select

        '  AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub
    Private Sub MediaPlayer_PlayStateChange(sender As Object, e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent)
        If e.newState = 8 Then
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            Application.Exit()
        End If
    End Sub
    Private Sub Game_Overs()
        Dim controlsToRemove As New List(Of PictureBox)

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is PictureBox Then
                Dim pictureBox As PictureBox = DirectCast(ctrl, PictureBox)
                Dim pictureBoxNumber As Integer
                If Integer.TryParse(pictureBox.Name.Replace("PictureBox", ""), pictureBoxNumber) Then
                    If pictureBoxNumber > 16 Then
                        controlsToRemove.Add(pictureBox)
                    End If
                End If
            End If
        Next

        ' PictureBoxを削除
        For Each ctrlToRemove As PictureBox In controlsToRemove
            Me.Controls.Remove(ctrlToRemove)
        Next

        ' Kyakulistをクリア
        Kyakulist.Clear()
        Youkyu2.Clear()
        pictureBoxes.Clear()
        progressBars.Clear()
    End Sub
    Private Sub DraggableLabel_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            isDragging = True
            offsetX = e.X
            offsetY = e.Y
            Hanasita_flg = False
        End If
    End Sub
    Private Sub DraggableLabel_MouseMove(sender As Object, e As MouseEventArgs)
        If isDragging Then
            Dim newLocation As New Point(e.X + CType(sender, PictureBox).Left - offsetX, e.Y + CType(sender, PictureBox).Top - offsetY)
            If CType(sender, PictureBox) IsNot Manaita_flg2 Then
                CType(sender, PictureBox).Location = newLocation
                CType(sender, PictureBox).BackgroundImage = Images(100)
                '  CType(sender, PictureBox).BackColor = Color.Transparent
            End If
            'Controls("ProgressBar" & Int(sender)).Location = newLocation
            Dim index As Integer = pictureBoxes.IndexOf(CType(sender, PictureBox))
            If index >= 0 AndAlso index < progressBars.Count Then
                Dim progressBar As ProgressBar = progressBars(index)
                progressBar.Left = CType(sender, PictureBox).Left - 25
                progressBar.Top = CType(sender, PictureBox).Top - 50
                progressBar.Visible = False
                progressBar.Value = 0
            End If
        End If

    End Sub
    Private Function Gousei(number As PictureBox, picture As PictureBox, i As Integer)
        ' For i = 0 To 3
        'If Sara_flg2(i) Is number Then
        'Sara_flg(i) = False
        'End If
        'Next
        Dim r2 As New Random()
        Dim location_x As Integer = r2.Next(-50, 50)
        Dim location_y As Integer = r2.Next(-50, 50)
        Select Case True
            Case (Sara_flg2(i).Image Is Images(1) And number.Image Is Images(0)) Or (Sara_flg2(i).Image Is Images(0) And number.Image Is Images(1))
                Me.Controls.Remove(number)
                number.Dispose()
                Sara_flg2(i).Image = Images(11)
            Case (Sara_flg2(i).Image Is Images(3) And number.Image Is Images(0)) Or (Sara_flg2(i).Image Is Images(0) And number.Image Is Images(3))
                Me.Controls.Remove(number)
                number.Dispose()
                Sara_flg2(i).Image = Images(12)
            Case (Sara_flg2(i).Image Is Images(11) And number.Image Is Images(3)) Or (Sara_flg2(i).Image Is Images(11) And number.Image Is Images(3)) Or (Sara_flg2(i).Image Is Images(12) And number.Image Is Images(1)) Or (Sara_flg2(i).Image Is Images(1) And number.Image Is Images(12))
                Me.Controls.Remove(number)
                number.Dispose()
                Sara_flg2(i).Image = Youkyu(0)

            Case Else
                number.Location = New Point(picture.Left + location_x, picture.Top + location_y)
                number.Left = number.Left - 25
                number.Top = number.Top - 50
        End Select

    End Function

    Private Async Function Hantei(number As Object) As Task
        Dim pictureBox As PictureBox = CType(number, PictureBox)
        Dim clickedPictureBox As PictureBox = CType(number, PictureBox)
        Dim index As Integer = pictureBoxes.IndexOf(pictureBox)
        Dim progressBar As ProgressBar = progressBars(index)
        Dim r2 As New Random()
        Dim location_x As Integer = r2.Next(-50, 50)
        Dim location_y As Integer = r2.Next(-50, 50)
        Select Case True
            Case (pictureBox.Left <= PictureBox6.Left + PictureBox6.Width And pictureBox.Left >= PictureBox6.Left) And (pictureBox.Top <= PictureBox6.Top + PictureBox6.Height And pictureBox.Top >= PictureBox6.Top)
                For i = 1 To 3
                    If Sara_flg2(i) Is clickedPictureBox Then
                        Sara_flg(i) = False
                    End If
                Next
                If Manaita_flg2 Is clickedPictureBox Then
                    Manaita_flg = False
                End If
                For i = 0 To 3
                    If Conro_flg2(i) Is clickedPictureBox Then
                        Conro_flg(i) = False
                    End If
                Next
                If Sara_flg(0) = False Or (Sara_flg2(0) Is clickedPictureBox) Then
                    Sara_flg2(0) = clickedPictureBox
                    pictureBox.Location = New Point(((PictureBox6.Width) / 5) + PictureBox6.Left, ((PictureBox6.Height) / 5) + PictureBox6.Top)
                    progressBar.Left = pictureBox.Left - 25
                    progressBar.Top = pictureBox.Top - 50
                    If Ckick_flg(0) Is Sara_flg2(0) Then
                        Sara_flg(0) = False
                        Ckick_flg(0) = Nothing
                    Else
                        Sara_flg(0) = True
                    End If
                ElseIf Sara_flg2(0) IsNot clickedPictureBox Then
                    Gousei(clickedPictureBox, PictureBox6, 0)
                End If
            Case (pictureBox.Left <= PictureBox2.Left + PictureBox2.Width And pictureBox.Left >= PictureBox2.Left) And (pictureBox.Top <= PictureBox2.Top + PictureBox2.Height And pictureBox.Top >= PictureBox2.Top)
                For i = 2 To 3
                    If Sara_flg2(i) Is clickedPictureBox Then
                        Sara_flg(i) = False
                    End If
                Next
                For i = 0 To 3
                    If Conro_flg2(i) Is clickedPictureBox Then
                        Conro_flg(i) = False
                    End If
                Next
                If Manaita_flg2 Is clickedPictureBox Then
                    Manaita_flg = False
                End If
                If Sara_flg2(0) Is clickedPictureBox Then
                    Sara_flg(0) = False
                End If
                If Sara_flg(1) = False Or (Sara_flg2(1) Is clickedPictureBox) Then
                    pictureBox.Location = New Point(((PictureBox2.Width) / 5) + PictureBox2.Left, ((PictureBox2.Height) / 5) + PictureBox2.Top)
                    progressBar.Left = pictureBox.Left - 25
                    progressBar.Top = pictureBox.Top - 50
                    Sara_flg2(1) = clickedPictureBox
                    If Ckick_flg(1) Is Sara_flg2(1) Then
                        Sara_flg(1) = False
                        Ckick_flg(1) = Nothing
                    Else
                        Sara_flg(1) = True
                    End If
                ElseIf Sara_flg2(1) IsNot clickedPictureBox Then
                    Gousei(clickedPictureBox, PictureBox2, 1)
                End If

            Case (pictureBox.Left <= PictureBox5.Left + PictureBox5.Width And pictureBox.Left >= PictureBox5.Left) And (pictureBox.Top <= PictureBox5.Top + PictureBox5.Height And pictureBox.Top >= PictureBox5.Top)
                For i = 0 To 1
                    If Sara_flg2(i) Is clickedPictureBox Then
                        Sara_flg(i) = False
                    End If
                Next
                For i = 0 To 3
                    If Conro_flg2(i) Is clickedPictureBox Then
                        Conro_flg(i) = False
                    End If
                Next
                If Manaita_flg2 Is clickedPictureBox Then
                    Manaita_flg = False
                End If
                If Sara_flg2(3) Is clickedPictureBox Then
                    Sara_flg(3) = False
                End If
                If Sara_flg(2) = False Or (Sara_flg2(2) Is clickedPictureBox) Then
                    pictureBox.Location = New Point(((PictureBox5.Width) / 5) + PictureBox5.Left, ((PictureBox5.Height) / 5) + PictureBox5.Top)
                    progressBar.Left = pictureBox.Left - 25
                    progressBar.Top = pictureBox.Top - 50
                    Sara_flg2(2) = clickedPictureBox
                    If Ckick_flg(2) Is Sara_flg2(2) Then
                        Sara_flg(2) = False
                        Ckick_flg(2) = Nothing
                    Else
                        Sara_flg(2) = True
                    End If
                ElseIf Sara_flg2(2) IsNot clickedPictureBox Then
                    Gousei(clickedPictureBox, PictureBox5, 2)
                End If

            Case (pictureBox.Left <= PictureBox4.Left + PictureBox4.Width And pictureBox.Left >= PictureBox4.Left) And (pictureBox.Top <= PictureBox4.Top + PictureBox4.Height And pictureBox.Top >= PictureBox4.Top)
                For i = 0 To 2
                    If Sara_flg2(i) Is clickedPictureBox Then
                        Sara_flg(i) = False
                    End If
                Next
                For i = 0 To 3
                    If Conro_flg2(i) Is clickedPictureBox Then
                        Conro_flg(i) = False
                    End If
                Next
                If Manaita_flg2 Is clickedPictureBox Then
                    Manaita_flg = False
                End If
                If Sara_flg(3) = False Or (Sara_flg2(3) Is clickedPictureBox) Then
                    pictureBox.Location = New Point(((PictureBox4.Width) / 5) + PictureBox4.Left, ((PictureBox4.Height) / 5) + PictureBox4.Top)
                    progressBar.Left = pictureBox.Left - 25
                    progressBar.Top = pictureBox.Top - 50

                    Sara_flg2(3) = clickedPictureBox
                    If Ckick_flg(3) Is Sara_flg2(3) Then
                        Sara_flg(3) = False
                        Ckick_flg(3) = Nothing
                    Else
                        Sara_flg(3) = True
                    End If

                ElseIf Sara_flg2(3) IsNot clickedPictureBox Then
                        Gousei(clickedPictureBox, PictureBox4, 3)

                End If
            Case (pictureBox.Left <= PictureBox3.Left + PictureBox3.Width And pictureBox.Left >= PictureBox3.Left) And (pictureBox.Top <= PictureBox3.Top + PictureBox3.Height And pictureBox.Top >= PictureBox3.Top)
                For i = 0 To 3
                    If Sara_flg2(i) Is clickedPictureBox Then
                        Sara_flg(i) = False
                    End If
                Next
                For i = 0 To 2
                    If Conro_flg2(i) Is clickedPictureBox Then
                        Conro_flg(i) = False
                    End If
                Next
                If Manaita_flg2 Is clickedPictureBox Then
                    Manaita_flg = False
                End If
                If Conro_flg2(2) Is clickedPictureBox Then
                    Conro_flg(2) = False
                End If
                If pictureBox.Image IsNot Images(7) Then
                    Select Case True
                        Case Conro_flg(2) = False
                            Conro_flg(2) = True
                            Conro_flg2(2) = clickedPictureBox
                            pictureBox.Location = New Point(((PictureBox3.Width) / 7) + PictureBox3.Left, ((PictureBox3.Height) / 4) + PictureBox3.Top)
                            progressBar.Left = pictureBox.Left - 25
                            progressBar.Top = pictureBox.Top - 50
                            progressBar.Value = 0
                        Case Conro_flg(3) = False And Conro_flg(2) = True
                            Conro_flg(3) = True
                            Conro_flg2(3) = clickedPictureBox
                            pictureBox.Location = New Point(((PictureBox3.Width) / 1.5) + PictureBox3.Left, ((PictureBox3.Height) / 4) + PictureBox3.Top)
                            progressBar.Left = pictureBox.Left - 5
                            progressBar.Top = pictureBox.Top - 50
                            progressBar.Value = 0
                        Case Else
                            pictureBox.Location = New Point(PictureBox3.Left + location_x, PictureBox3.Top + location_y - 50)
                            progressBar.Left = pictureBox.Left - 25
                            progressBar.Top = pictureBox.Top - 50
                    End Select
                Else
                    pictureBox.Location = New Point(PictureBox3.Left + location_x + 25, PictureBox3.Top + location_y + 25)
                    progressBar.Left = pictureBox.Left - 25
                    progressBar.Top = pictureBox.Top - 50
                End If
            Case (pictureBox.Left <= PictureBox7.Left + PictureBox7.Width And pictureBox.Left >= PictureBox7.Left) And (pictureBox.Top <= PictureBox7.Top + PictureBox7.Height And pictureBox.Top >= PictureBox7.Top)
                For i = 0 To 3
                    If Sara_flg2(i) Is clickedPictureBox Then
                        Sara_flg(i) = False
                    End If
                Next
                For i = 2 To 3
                    If Conro_flg2(i) Is clickedPictureBox Then
                        Conro_flg(i) = False
                    End If
                Next
                If Conro_flg2(0) Is clickedPictureBox Then
                    Conro_flg(0) = False
                End If
                If Manaita_flg2 Is clickedPictureBox Then
                    Manaita_flg = False
                End If
                If pictureBox.Image IsNot Images(7) Then
                    Select Case True
                        Case Conro_flg(0) = False
                            Conro_flg(0) = True
                            Conro_flg2(0) = clickedPictureBox
                            pictureBox.Location = New Point(((PictureBox7.Width) / 7) + PictureBox7.Left, ((PictureBox7.Height) / 4) + PictureBox7.Top)
                            progressBar.Left = pictureBox.Left - 25
                            progressBar.Top = pictureBox.Top - 50
                            progressBar.Value = 0
                        Case Conro_flg(1) = False And Conro_flg(0) = True
                            Conro_flg(1) = True
                            progressBar.Value = 0
                            Conro_flg2(1) = clickedPictureBox
                            pictureBox.Location = New Point(((PictureBox7.Width) / 2) + PictureBox7.Left, ((PictureBox7.Height) / 4) + PictureBox7.Top)
                            progressBar.Left = pictureBox.Left - 5
                            progressBar.Top = pictureBox.Top - 50
                        Case Else
                            pictureBox.Location = New Point(PictureBox7.Left + location_x, PictureBox7.Top + location_y - 50)
                            progressBar.Left = pictureBox.Left - 25
                            progressBar.Top = pictureBox.Top - 50
                    End Select
                Else
                    pictureBox.Location = New Point(PictureBox7.Left + location_x + 25, PictureBox7.Top + location_y + 25)
                    progressBar.Left = pictureBox.Left - 25
                    progressBar.Top = pictureBox.Top - 50
                End If
            Case (pictureBox.Left <= PictureBox1.Left + PictureBox1.Width And pictureBox.Left >= PictureBox1.Left) And (pictureBox.Top <= PictureBox1.Top + PictureBox1.Height And pictureBox.Top >= PictureBox1.Top)

                For i = 0 To 3
                    If Sara_flg2(i) Is clickedPictureBox Then
                        Sara_flg(i) = False
                    End If
                Next
                For i = 0 To 3
                    If Conro_flg2(i) Is clickedPictureBox Then
                        Conro_flg(i) = False
                    End If
                Next
                If (Manaita_flg = False And clickedPictureBox.Image Is Images(2)) Or (Manaita_flg = False And clickedPictureBox.Image Is Images(14)) Or (Manaita_flg2 Is clickedPictureBox) Then
                    pictureBox.Location = New Point(((PictureBox1.Width) / 3) + PictureBox1.Left, ((PictureBox1.Height) / 4) + PictureBox1.Top)
                    progressBar.Left = pictureBox.Left - 25
                    progressBar.Top = pictureBox.Top - 50
                    Manaita_flg2 = clickedPictureBox
                    Manaita_flg = True
                    progressBar.Visible = True
                ElseIf Manaita_flg2 IsNot clickedPictureBox Then
                    pictureBox.Location = New Point(PictureBox1.Left + 50 + location_x, PictureBox1.Top - 50 + location_y)
                    progressBar.Left = pictureBox.Left - 75
                    progressBar.Top = pictureBox.Top - 50
                End If
            Case (pictureBox.Left <= PictureBox8.Left + PictureBox8.Width And pictureBox.Left >= PictureBox8.Left) And (pictureBox.Top <= PictureBox8.Top + PictureBox8.Height And pictureBox.Top >= PictureBox8.Top)
                For i = 0 To 3
                    If Sara_flg2(i) Is clickedPictureBox Then
                        Sara_flg(i) = False
                    End If
                Next
                For i = 0 To 3
                    If Conro_flg2(i) Is clickedPictureBox Then
                        Conro_flg(i) = False
                    End If
                Next
                If Manaita_flg2 Is clickedPictureBox Then
                    Manaita_flg = False
                End If
                Select Case True
                    Case (clickedPictureBox.Image Is Images(2)) Or (clickedPictureBox.Image Is Images(7) Or (clickedPictureBox.Image Is Images(3)))
                        Over -= 1
                    Case (clickedPictureBox.Image Is Images(6)) Or (clickedPictureBox.Image Is Images(8) Or (clickedPictureBox.Image Is Images(1)))
                        Over2 -= 1
                    Case (clickedPictureBox.Image Is Images(9)) Or (clickedPictureBox.Image Is Images(0))
                        Over3 -= 1
                    Case (clickedPictureBox.Image Is Images(14)) Or (clickedPictureBox.Image Is Images(15) Or (clickedPictureBox.Image Is Youkyu(2)))
                        Over4 -= 1
                    Case clickedPictureBox.Image Is Youkyu(0)
                        Over -= 1
                        Over2 -= 1
                        Over3 -= 1
                    Case clickedPictureBox.Image Is Youkyu(1)
                        Over5 -= 1
                End Select
                Me.Controls.Remove(clickedPictureBox)
                clickedPictureBox.Dispose()

            Case Else
                For i = 0 To 3
                    If Sara_flg2(i) Is clickedPictureBox Then
                        Sara_flg(i) = False
                    End If
                Next
                For i = 0 To 3
                    If Conro_flg2(i) Is clickedPictureBox Then
                        Conro_flg(i) = False
                    End If
                Next
                If Manaita_flg2 Is clickedPictureBox Then
                    Manaita_flg = False
                End If
        End Select
    End Function

    Private Sub DraggableLabel_MouseUp(sender As Object, e As MouseEventArgs)
        '  Dim pictureBox As PictureBox = CType(sender, PictureBox)
        If e.Button = MouseButtons.Left Then
            'pictureBox.BackColor = Color.WhiteSmoke
            isDragging = False
            Hantei(sender)
            Hanasita_flg = True
        End If
    End Sub
    Private Sub Drinks()
        Dim newPictureBox As New PictureBox()
        Dim newProgressBar As New ProgressBar()
        Dim colors() As Color = {Color.Red, Color.Blue, Color.Green, Color.Gold}
        Dim r1 As New Random()
        Dim random_number As Integer = r1.Next(0, 4)
        With newPictureBox
            .Size = New Size(45, 45)
            .Location = New Point(((PictureBox14.Width) / 3) + PictureBox14.Left, ((PictureBox14.Height) / 4) + PictureBox14.Top)
            .BorderStyle = BorderStyle.FixedSingle
            .AllowDrop = True
            .Name = "PictureBox" & picCounter
            .SizeMode = PictureBoxSizeMode.StretchImage
            .BackgroundImageLayout = ImageLayout.Stretch
            .Image = Youkyu(3)
            .Visible = False
        End With
        AddHandler newPictureBox.MouseDown, AddressOf DraggableLabel_MouseDown
        AddHandler newPictureBox.MouseMove, AddressOf DraggableLabel_MouseMove
        AddHandler newPictureBox.MouseUp, AddressOf DraggableLabel_MouseUp
        AddHandler newPictureBox.DoubleClick, AddressOf PictureBox_DoubleClick
        pictureBoxes.Add(newPictureBox)
        With newProgressBar
            .Size = New Size(79, 30)
            .Location = New Point(newPictureBox.Left, newPictureBox.Top - 50)
            .Name = "ProgressBar" & picCounter
            .Visible = True
        End With

        newProgressBar.Maximum = 10
        newProgressBar.Value = 0

        Drink_flg2 = newPictureBox
        Drink_flg3 = newProgressBar
        Me.Controls.Add(newPictureBox)
        newPictureBox.BringToFront()
        Me.Controls.Add(newProgressBar)
        newProgressBar.BringToFront()
        progressBars.Add(newProgressBar)
        picCounter += 1
        Drink_flg = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'ProgressBar1.Value += 1
        Dim index As Integer
        Dim r3 As New Random()
        Dim location_x As Integer = r3.Next(-50, 50)
        Dim location_y As Integer = r3.Next(-50, 50)
        If Drink_flg = True Then
            If Drink_flg3.Value + 2 <= 10 Then
                Drink_flg3.Value += 2
            Else
                Drink_flg2.Image = Youkyu(1)
                Drink_flg3.Visible = False
                Drink_flg2.Visible = True
                Drink_flg = False
            End If
        End If
        For i = 0 To 3
            If Sara_flg(i) = True And Gousei_flg Then
                Sara_flg(i) = False
                Gousei_flg = False

            End If

            If Conro_flg(i) = True Then
                index = pictureBoxes.IndexOf(Conro_flg2(i))
                Dim progressBar As ProgressBar = progressBars(index)
                progressBar.Visible = True
                Select Case i
                    Case 0
                        pictureBoxes(index).BackgroundImage = Images(13)
                    Case 1
                        pictureBoxes(index).BackgroundImage = Images(13)
                    Case 2
                        pictureBoxes(index).BackgroundImage = Images(5)
                    Case 3
                        pictureBoxes(index).BackgroundImage = Images(5)
                End Select


                If progressBar.Value + 1 <= 10 Then
                    progressBar.Value += 1
                ElseIf progressBar.Value = 10 Then
                    pictureBoxes(index).BackgroundImage = Images(100)
                    Select Case True
                        Case pictureBoxes(index).Image Is Images(0) And (Conro_flg(2) Or Conro_flg(3))
                            pictureBoxes(index).Image = Images(9)
                            pictureBoxes(index).BackgroundImage = Images(100)
                            progressBar.Value = 0
                            progressBar.Visible = False
                            pictureBoxes(index).Left += location_x
                            pictureBoxes(index).Top += location_y
                            Conro_flg(i) = False
                        Case pictureBoxes(index).Image Is Images(1) And (Conro_flg(2) Or Conro_flg(3))
                            pictureBoxes(index).Image = Images(8)
                            pictureBoxes(index).BackgroundImage = Images(100)
                            progressBar.Value = 0
                            progressBar.Visible = False
                            pictureBoxes(index).Left += location_x
                            pictureBoxes(index).Top += location_y
                            Conro_flg(i) = False
                        Case pictureBoxes(index).Image Is Images(2) And (Conro_flg(2) Or Conro_flg(3))
                            pictureBoxes(index).Image = Images(7)
                            pictureBoxes(index).BackgroundImage = Images(100)
                            progressBar.Value = 0
                            pictureBoxes(index).Left += location_x
                            pictureBoxes(index).Top += location_y
                            progressBar.Visible = False
                            Conro_flg(i) = False
                        Case pictureBoxes(index).Image Is Images(3) And (Conro_flg(2) Or Conro_flg(3))
                            pictureBoxes(index).Image = Images(7)
                            pictureBoxes(index).BackgroundImage = Images(100)
                            progressBar.Value = 0
                            pictureBoxes(index).Left += location_x
                            pictureBoxes(index).Top += location_y
                            progressBar.Visible = False
                            Conro_flg(i) = False
                        Case pictureBoxes(index).Image Is Images(6) And (Conro_flg(2) Or Conro_flg(3))
                            pictureBoxes(index).Image = Images(1)
                            pictureBoxes(index).BackgroundImage = Images(100)
                            progressBar.Value = 0
                            progressBar.Visible = False
                        Case pictureBoxes(index).Image Is Images(15) And (Conro_flg(0) Or Conro_flg(1))
                            pictureBoxes(index).Image = Youkyu(2)
                            pictureBoxes(index).BackgroundImage = Images(100)
                            progressBar.Value = 0
                            progressBar.Visible = False
                            Conro_flg(i) = False
                    End Select
                End If
            End If
        Next
    End Sub

    Private Sub PictureBox_DoubleClick(sender As Object, e As EventArgs)
        Dim pictureBox As PictureBox = CType(sender, PictureBox)
        Dim tags As Object = Nothing ' タグの値を格納する変数
        Dim Nasi_flg As Boolean = True
        Dim index2 As Integer
        Dim counts As Integer = 0
        Dim num_locacion As Integer
        Dim Ok_flg As Boolean = False

        ' PictureBoxを探して削除する
        For i = 0 To 3
            If Sara_flg(i) = True And Sara_flg2(i) Is pictureBox Then
                Sara_flg(i) = False
                For Each num As PictureBox In Kyakulist
                    counts += 1
                    If pictureBox.Image Is num.Image And counts < 4 Then
                        Ckick_flg(i) = pictureBox
                        num_locacion = num.Left
                        Gousei_flg = True
                        tags = num.Tag
                        ' PictureBoxと関連する要素を削除
                        Select Case True
                            Case num.Image Is Youkyu(0)
                                Over -= 1
                                Over2 -= 1
                                Over3 -= 1
                            Case num.Image Is Youkyu(1)
                                Over5 -= 1
                            Case num.Image Is Youkyu(2)
                                Over4 -= 1
                        End Select
                        index2 = CInt(num.Tag.ToString().Substring("PictureBox".Length))
                        num.Visible = False
                        pictureBox.Visible = False
                        Controls.Remove(num)
                        num.Dispose()
                        Kyakulist.Remove(num)
                        Controls.Remove(pictureBox)
                        pictureBox.Dispose()
                        ' KyakulistからPictureBoxを削除
                        ' Controls.Remove(pictureBox) ' PictureBoxを削除しない（PictureBoxはループの外で削除される）
                        ' pictureBox.Dispose() ' PictureBoxを削除しない（PictureBoxはループの外で削除される）
                        ' 削除後、同じタグを持つPictureBoxが他にないか確認
                        For Each num1 As PictureBox In Kyakulist
                            If num1.Tag.ToString() = tags.ToString() Then
                                Nasi_flg = False
                                super_count -= 1
                                Exit For
                            End If
                        Next
                        If super_count <= 0 Then
                            Nasi_flg = True
                        End If
                        Label8.Text = "Debug" & Nasi_flg & Str(super_count)

                        ' PictureBox を削除した後に Nasi_flg を確認するため、削除前にフラグを確認する
                        If Nasi_flg Then
                            For Each ctrl1 As Control In Me.Controls
                                If TypeOf ctrl1 Is PictureBox AndAlso ctrl1.Tag IsNot Nothing AndAlso ctrl1.Tag.ToString().StartsWith("PictureBox") Then
                                    Dim pb As PictureBox = DirectCast(ctrl1, PictureBox)
                                    ' PictureBoxの位置を移動する
                                    Dim index As Integer = CInt(ctrl1.Tag.ToString().Substring("PictureBox".Length))
                                    If index <> index2 Then ' 同じタグを持つPictureBoxかつクリックしたPictureBox以外
                                        ' PictureBoxの位置を移動する
                                        If pb.Left >= num_locacion Then
                                            pb.Left -= 80
                                        End If
                                    End If
                                    Label1.Text = index
                                ElseIf TypeOf ctrl1 Is ProgressBar AndAlso ctrl1.Tag IsNot Nothing AndAlso ctrl1.Tag.ToString().StartsWith("PictureBox") Then
                                    Dim pb2 As ProgressBar = DirectCast(ctrl1, ProgressBar)
                                    ' ProgressBarの位置を移動する
                                    Dim index3 As Integer = CInt(ctrl1.Tag.ToString().Substring("PictureBox".Length))
                                    index3 += 1
                                    '  If Ok_flg = False Then

                                    If index3 <> index2 Then ' ProgressBarが画面外に出た場合
                                        ' Ok_flg = True
                                        ' PictureBoxと同じ場所に移動
                                        pb2.Left -= 80
                                        If pb2.Left < 0 Then
                                            Controls.Remove(pb2)
                                            pb2.Dispose()
                                        End If
                                    End If
                                    If index3 = index2 + 1 Then
                                        Controls.Remove(pb2)
                                        pb2.Dispose()
                                        timerList(supercount2).Stop()
                                        '  Label1.Text &= index3
                                    End If

                                    ' End If
                                End If
                            Next
                            ' 減算はタグが追加された後にする
                            points -= 1
                            Score += 100
                            super_count = 3
                            supercount2 += 1
                        End If

                        Exit For
                    End If
                Next

                counts = 0
                ' PictureBox を削除

                Exit For

            End If
        Next

        ' tagsがNothingでないことを確認してから、処理を続行する
    End Sub


    Dim points As Integer = 0
    Private Sub Kyaku()
        If points <= 9 Then
            Dim r4 As New Random()
            Dim Kosuu As Integer = 2
            Dim count As Integer = 0
            Dim newProgressBar As New ProgressBar()
            newProgressBar.Maximum = 20
            newProgressBar.Minimum = 0
            For i = 0 To Kosuu
                Dim newPictureBox As New PictureBox()
                Dim newLabel As New Label()
                Dim dore As Integer = r4.Next(0, 3)

                With newPictureBox
                    .Size = New Size(60, 60)
                    .BorderStyle = BorderStyle.FixedSingle
                    .Name = "PictureBox" & picCounter
                    .SizeMode = PictureBoxSizeMode.StretchImage
                    .BackgroundImageLayout = ImageLayout.Stretch
                    .Image = Youkyu(dore)
                    .Location = New Point(80 * points, Location_y(i))
                    .Tag = "PictureBox" & points.ToString()
                    .Visible = True
                End With
                With newLabel
                    .Size = New Size(60, 60)
                    .BorderStyle = BorderStyle.FixedSingle
                    .Name = "Label" & picCounter
                    .Location = New Point(80 * points + 40, Location_y(i))
                    .Tag = "PictureBox" & points.ToString()
                    .Visible = True
                    .Text = newPictureBox.Tag.ToString()
                End With
                picCounter += 1
                Kyakulist.Add(newPictureBox)
                Me.Controls.Add(newPictureBox)
                newPictureBox.BringToFront()
                '  Me.Controls.Add(newLabel)
                'newLabel.BringToFront()
                Youkyu2.Add(Kosuu)
            Next
            With newProgressBar
                .Size = New Size(69, 15)
                .Location = New Point(80 * points, Location_y(Kosuu) + 65)
                .Name = "ProgressBar" & picCounter
                .Tag = "PictureBox" & points.ToString()
                .Visible = True
                .Value = 20
            End With


            ' Timerを作成し、ProgressBarと関連付ける
            Dim newTimer As New Timer()
            newTimer.Interval = TimerInterval
            AddHandler newTimer.Tick, AddressOf Timer_Tick
            newTimer.Tag = newProgressBar ' ProgressBarをタグとして設定
            timerList.Add(newTimer)
            newTimer.Start()

            Me.Controls.Add(newProgressBar)
            newProgressBar.BringToFront()
            points += 1
        Else
            Timer2.Stop()
        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        Dim timer As Timer = CType(sender, Timer)
        Dim progressBar As ProgressBar = CType(timer.Tag, ProgressBar)
        If Jikan > 0 Then

            If progressBar IsNot Nothing AndAlso progressBar.Value > 0 Then
                progressBar.Value -= 1
            ElseIf progressBar IsNot Nothing AndAlso progressBar.Value = 0 Then
                timer.Stop()
                RemoveHandler timer.Tick, AddressOf Timer_Tick

                'Process.Start("Five Nights At ティラノサウルス In Visial Basic.exe")
                Application.Exit()
            ElseIf progressBar Is Nothing Then
                timer.Stop()
                RemoveHandler timer.Tick, AddressOf Timer_Tick
            End If

        End If
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As MouseEventArgs) Handles PictureBox1.Click
        If e.Button = MouseButtons.Left Then
            If Manaita_flg2 IsNot Nothing Then
                If Manaita_flg = True And (Manaita_flg2.Image Is Images(2) Or Manaita_flg2.Image Is Images(14)) Then
                    Dim index As Integer = pictureBoxes.IndexOf(Manaita_flg2)
                    Dim progressBar As ProgressBar = progressBars(index)
                    If progressBar.Value + 2 <= 10 Then
                        progressBar.Value += 2
                    ElseIf progressBar.Value = 10 Then
                        Manaita_flg = False
                        progressBar.Value = 0
                        Select Case True
                            Case Manaita_flg2.Image Is Images(2)
                                Manaita_flg2.Image = Images(3)
                            Case Manaita_flg2.Image Is Images(14)
                                Manaita_flg2.Image = Images(15)
                        End Select
                        Manaita_flg2 = PictureBox15
                    End If
                End If
            End If
        Else
            Manaita_flg = True
            Manaita_flg2.Image = Images(2)
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Jikan > 0 Then
            Kyaku()
        End If

    End Sub
    Dim Over2 As Integer = 0

    Dim Over3 As Integer = 0
    Dim Over4 As Integer = 0

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        If Over3 <= 4 Then
            Dim newPictureBox As New PictureBox()
            Dim newProgressBar As New ProgressBar()
            Dim colors() As Color = {Color.Red, Color.Blue, Color.Green, Color.Gold}
            Dim r1 As New Random()
            Dim random_number As Integer = r1.Next(0, 4)
            Dim location_x As Integer = r1.Next(-50, 50)
            Dim location_y As Integer = r1.Next(-50, 50)
            With newPictureBox
                .Size = New Size(45, 45)
                .Location = New Point(PictureBox10.Left + location_x, PictureBox10.Top + location_y)
                .BorderStyle = BorderStyle.FixedSingle
                .AllowDrop = True
                .Name = "PictureBox" & picCounter
                .SizeMode = PictureBoxSizeMode.StretchImage
                .BackgroundImageLayout = ImageLayout.Stretch
                .Image = Images(0)
            End With
            pictureBoxes.Add(newPictureBox)
            With newProgressBar
                .Size = New Size(79, 30)
                .Location = New Point(newPictureBox.Left, newPictureBox.Top - 50)
                .Name = "ProgressBar" & picCounter
                .Visible = False
            End With

            newProgressBar.Maximum = 10
            newProgressBar.Value = 0

            AddHandler newPictureBox.MouseDown, AddressOf DraggableLabel_MouseDown
            AddHandler newPictureBox.MouseMove, AddressOf DraggableLabel_MouseMove
            AddHandler newPictureBox.MouseUp, AddressOf DraggableLabel_MouseUp
            AddHandler newPictureBox.DoubleClick, AddressOf PictureBox_DoubleClick

            Me.Controls.Add(newPictureBox)
            newPictureBox.BringToFront()
            Me.Controls.Add(newProgressBar)
            newProgressBar.BringToFront()
            progressBars.Add(newProgressBar)
            picCounter += 1
            Over3 += 1
        End If
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        If Over2 <= 4 Then
            Dim newPictureBox As New PictureBox()
            Dim newProgressBar As New ProgressBar()
            Dim colors() As Color = {Color.Red, Color.Blue, Color.Green, Color.Gold}
            Dim r1 As New Random()
            Dim random_number As Integer = r1.Next(0, 4)
            Dim location_x As Integer = r1.Next(-50, 50)
            Dim location_y As Integer = r1.Next(-50, 50)
            With newPictureBox
                .Size = New Size(45, 45)
                .Location = New Point(PictureBox12.Left + location_x, PictureBox12.Top + location_y)
                .BorderStyle = BorderStyle.FixedSingle
                .AllowDrop = True
                .Name = "PictureBox" & picCounter
                .SizeMode = PictureBoxSizeMode.StretchImage
                .BackgroundImageLayout = ImageLayout.Stretch
                .Image = Images(6)
            End With
            pictureBoxes.Add(newPictureBox)
            With newProgressBar
                .Size = New Size(79, 30)
                .Location = New Point(newPictureBox.Left, newPictureBox.Top - 50)
                .Name = "ProgressBar" & picCounter
                .Visible = False
            End With

            newProgressBar.Maximum = 10
            newProgressBar.Value = 0

            AddHandler newPictureBox.MouseDown, AddressOf DraggableLabel_MouseDown
            AddHandler newPictureBox.MouseMove, AddressOf DraggableLabel_MouseMove
            AddHandler newPictureBox.MouseUp, AddressOf DraggableLabel_MouseUp
            AddHandler newPictureBox.DoubleClick, AddressOf PictureBox_DoubleClick

            Me.Controls.Add(newPictureBox)
            newPictureBox.BringToFront()
            Me.Controls.Add(newProgressBar)
            newProgressBar.BringToFront()
            progressBars.Add(newProgressBar)
            picCounter += 1
            Over2 += 1
        End If
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        If Over <= 4 Then
            Dim newPictureBox As New PictureBox()
            Dim newProgressBar As New ProgressBar()
            Dim colors() As Color = {Color.Red, Color.Blue, Color.Green, Color.Gold}
            Dim r1 As New Random()
            Dim random_number As Integer = r1.Next(0, 4)
            Dim location_x As Integer = r1.Next(-50, 50)
            Dim location_y As Integer = r1.Next(-50, 50)
            With newPictureBox
                .Size = New Size(45, 45)
                .Location = New Point(PictureBox11.Left + location_x, PictureBox11.Top + location_y)
                .BorderStyle = BorderStyle.FixedSingle
                .AllowDrop = True
                .Name = "PictureBox" & picCounter
                .SizeMode = PictureBoxSizeMode.StretchImage
                .BackgroundImageLayout = ImageLayout.Stretch
                .Image = Images(2)
            End With
            pictureBoxes.Add(newPictureBox)
            With newProgressBar
                .Size = New Size(79, 30)
                .Location = New Point(newPictureBox.Left, newPictureBox.Top - 50)
                .Name = "ProgressBar" & picCounter
                .Visible = False
            End With

            newProgressBar.Maximum = 10
            newProgressBar.Value = 0

            AddHandler newPictureBox.MouseDown, AddressOf DraggableLabel_MouseDown
            AddHandler newPictureBox.MouseMove, AddressOf DraggableLabel_MouseMove
            AddHandler newPictureBox.MouseUp, AddressOf DraggableLabel_MouseUp
            AddHandler newPictureBox.DoubleClick, AddressOf PictureBox_DoubleClick

            Me.Controls.Add(newPictureBox)
            newPictureBox.BringToFront()
            Me.Controls.Add(newProgressBar)
            newProgressBar.BringToFront()
            progressBars.Add(newProgressBar)
            picCounter += 1
            Over += 1
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        If Over4 <= 4 Then
            Dim newPictureBox As New PictureBox()
            Dim newProgressBar As New ProgressBar()
            Dim colors() As Color = {Color.Red, Color.Blue, Color.Green, Color.Gold}
            Dim r1 As New Random()
            Dim random_number As Integer = r1.Next(0, 4)
            Dim location_x As Integer = r1.Next(-50, 50)
            Dim location_y As Integer = r1.Next(-50, 50)
            With newPictureBox
                .Size = New Size(45, 45)
                .Location = New Point(PictureBox9.Left + location_x, PictureBox9.Top + location_y)
                .BorderStyle = BorderStyle.FixedSingle
                .AllowDrop = True
                .Name = "PictureBox" & picCounter
                .SizeMode = PictureBoxSizeMode.StretchImage
                .BackgroundImageLayout = ImageLayout.Stretch
                .Image = Images(14)
            End With
            pictureBoxes.Add(newPictureBox)
            With newProgressBar
                .Size = New Size(79, 30)
                .Location = New Point(newPictureBox.Left, newPictureBox.Top - 50)
                .Name = "ProgressBar" & picCounter
                .Visible = False
            End With

            newProgressBar.Maximum = 10
            newProgressBar.Value = 0

            AddHandler newPictureBox.MouseDown, AddressOf DraggableLabel_MouseDown
            AddHandler newPictureBox.MouseMove, AddressOf DraggableLabel_MouseMove
            AddHandler newPictureBox.MouseUp, AddressOf DraggableLabel_MouseUp
            AddHandler newPictureBox.DoubleClick, AddressOf PictureBox_DoubleClick

            Me.Controls.Add(newPictureBox)
            newPictureBox.BringToFront()
            Me.Controls.Add(newProgressBar)
            newProgressBar.BringToFront()
            progressBars.Add(newProgressBar)
            picCounter += 1
            Over4 += 1
        End If
    End Sub
    Dim Over5 As Integer = 0

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        If Over5 <= 4 And Drink_flg = False Then
            Drinks()
            Over5 += 1
        End If
    End Sub
    Private Async Sub Game_Over()
        Dim r9 As New Random()
        Dim dotti As Integer = 1
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is PictureBox Then
                Dim pictureBox As PictureBox = DirectCast(ctrl, PictureBox)
                pictureBox.Visible = False
            End If
            If TypeOf ctrl Is ProgressBar Then
                Dim progressbar As ProgressBar = DirectCast(ctrl, ProgressBar)
                progressbar.Visible = False
            End If
        Next
        For i = 0 To 3
            Sara_flg(i) = False
            Conro_flg(i) = False
        Next

        Label3.Visible = True
        Timer4.Start()
        AxWindowsMediaPlayer1.Visible = True
        Await Task.Delay(3000)
        Label3.Text = "お前はすごいから"
        Await Task.Delay(3000)
        Label3.Text = "スペシャルな
動画をお見せ！"
        Await Task.Delay(3000)
        Label3.Visible = False
        Timer4.Stop()
        Select Case dotti
            Case 0
                AxWindowsMediaPlayer1.URL = "蒸気船ウィリー.mp4" 'ウォルトディズニー製作
            Case 1
                AxWindowsMediaPlayer1.URL = "異常気船ウォーリー.mp4" 'ツシマケント製作
        End Select

        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Jikan -= 1
        Label2.Text = Jikan
        Label2.Text = "Times:" & Str(Jikan)
        Label9.Text = "Score:" & Str(Score)
        If Jikan = 0 Then
            Timer2.Stop()
            Timer3.Stop()
            Game_Over()
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Dim r8 As New Random()
        Dim rgb1 As Integer = r8.Next(0, 256)
        Dim rgb2 As Integer = r8.Next(0, 256)
        Dim rgb3 As Integer = r8.Next(0, 256)
        Label3.ForeColor = Color.FromArgb(rgb1, rgb2, rgb3)
    End Sub
End Class