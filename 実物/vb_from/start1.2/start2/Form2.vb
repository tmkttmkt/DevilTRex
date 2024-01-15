Imports System.Threading
Imports System.Diagnostics
Public Class Form2
    Dim hozons As String = ""
    Dim displayText As String = "エンターキーで会話を進められます。" ' 表示する文字列
    Dim currentIndex As Integer = 0
    Dim count As Integer = 0
    Dim count2 As Integer = 0
    Dim v As Integer = 0
    Dim Auto_flg As Boolean = False
    Dim Enter_flg As Boolean = False
    Dim Images(2) As Image
    Dim ss(20) As String
    Dim ss2(20) As String
    Public Sub New(hozon As String)
        InitializeComponent()
        hozons = hozon
    End Sub
    Private Sub Mojiyomi(h As Integer)
        If currentIndex < displayText.Length Then
            Enter_flg = False
            Thread.Sleep(h)
            Label1.Text &= displayText(currentIndex) ' 現在の位置の文字を追加
            currentIndex += 1
        ElseIf Enter_flg = False Then
            Label1.Text &= " Enter->"
            Enter_flg = True
        End If

    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Images(0) = Image.FromFile("シルエットティラノ.png")
        Images(1) = Image.FromFile("光るシルエットティラノ.png")
        Label1.Text = ""
        PictureBox1.Image = Images(0)
        Select Case hozons
            Case "game_clear"
                ss(0) = "このガキャーッ！"
                ss2(0) = "ティラノサウルス"
                displayText = ss(0)
                Label2.Text = ss2(0)
                ss(1) = "もうマジで許せねェ！"
                ss2(1) = "ティラノサウルス"
                ss(2) = "次はけちょんけちょんにしてやるからな
覚悟しとけよ！"
                ss2(2) = "ティラノサウルス"
                ss(3) = "ガチであんま調子に乗んな
この有象無象！"
                ss2(3) = "ティラノサウルス"
                ss(4) = "惨敗をスタンバイ
しておけよ！！"
                ss2(4) = "ティラノサウルス"
                ss(5) = ""
                ss2(5) = ""
                Timer1.Enabled = True
            Case "game_over"
                ss(0) = "ぎゃはは！"
                ss2(0) = "ティラノサウルス"
                displayText = ss(0)
                Label2.Text = ss2(0)
                ss(1) = "散々な目にあったな"
                ss2(1) = "ティラノサウルス"
                ss(2) = "まああんま気を落とさないで
いこうぜ！"
                ss2(2) = "ティラノサウルス"
                ss(3) = "だがな…"
                ss2(3) = "ティラノサウルス"
                ss(4) = "もう一回ボコすけどな！"
                ss2(4) = "ティラノサウルス"
                ss(5) = ""
                ss2(5) = ""
                Timer1.Enabled = True
            Case Else
                ss(0) = "ここは選択画面です。"
                ss2(0) = "ティラノサウルス"
                displayText = ss(0)
                Label2.Text = ss2(0)
                ss(1) = "どこから始めるのかを選べます。"
                ss2(1) = "ティラノサウルス"
                ss(2) = "具体的には"
                ss2(2) = "ティラノサウルス"
                ss(3) = "ゲーム本編やサブゲームなどを
選択できます"
                ss2(3) = "ティラノサウルス"
                ss(4) = "お好きなほうをお選びください。"
                ss2(4) = "ティラノサウルス"
                ss(5) = ""
                ss2(5) = ""
                Timer1.Enabled = True
        End Select

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case count
            Case 4
                PictureBox1.Image = Images(1)
            Case 5
                Label2.Visible = False
                PictureBox1.Visible = False
                Label3.Visible = True
                Label4.Visible = True
                Label5.Visible = True
                Label6.Visible = True
        End Select
        Mojiyomi(100)
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Label1.Text = ""
            currentIndex = 0
            count += 1
            displayText = ss(count)
            Label2.Text = ss2(count)
            'count2 = count
            'v = count2 - 3
        End If
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter
        Label3.ForeColor = Color.Red
    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        Label4.ForeColor = Color.Red
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        If Not Label3.ClientRectangle.Contains(Label3.PointToClient(MousePosition)) Then
            Label3.ForeColor = Color.White
        End If
    End Sub
    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        If Not Label4.ClientRectangle.Contains(Label4.PointToClient(MousePosition)) Then
            Label4.ForeColor = Color.White
        End If
    End Sub
    Private Sub Label5_MouseEnter(sender As Object, e As EventArgs) Handles Label5.MouseEnter
        Label5.ForeColor = Color.Red
    End Sub

    Private Sub Label5_MouseLeave(sender As Object, e As EventArgs) Handles Label5.MouseLeave
        If Not Label5.ClientRectangle.Contains(Label5.PointToClient(MousePosition)) Then
            Label5.ForeColor = Color.White
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim filePath As String = "New_Goodbye.exe -Hello"

        Dim process As New Process()
        process.StartInfo.FileName = filePath

        Try
            process.Start()
        Catch ex As Exception
            MessageBox.Show("エラーが発生しました: " & ex.Message)
        End Try
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim filePath As String = "New_Goodbye.exe -Sample"

        Dim process As New Process()
        process.StartInfo.FileName = filePath

        Try
            process.Start()
        Catch ex As Exception
            MessageBox.Show("エラーが発生しました: " & ex.Message)
        End Try
    End Sub
End Class