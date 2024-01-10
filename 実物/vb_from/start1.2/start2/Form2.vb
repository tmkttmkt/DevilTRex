Imports System.Threading
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
                ss(4) = "惨敗をスタンバイしておけよ！！"
                ss2(4) = "ティラノサウルス"
                ss(5) = ""
                ss2(5) = ""
                Timer1.Enabled = True
        End Select

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case count
            Case 4
                If hozons = "game_clear" Then
                    PictureBox1.Image = Images(1)
                End If
            Case 5
                If hozons = "game_clear" Then
                    Try
                        Process.Start("Goodbye Unity.exe")
                        Application.Exit()
                    Catch ex As Exception
                        MessageBox.Show("ファイルが開けませんでした:" & ex.Message)
                    End Try
                End If
            Case 6
        End Select
        Mojiyomi(100)
    End Sub
    Private Sub Tugi()

    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Tugi()
            Label1.Text = ""
            currentIndex = 0
            count += 1
            displayText = ss(count)
            Label2.Text = ss2(count)
            'count2 = count
            'v = count2 - 3
        End If
    End Sub
End Class