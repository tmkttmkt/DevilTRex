Imports System.Threading
Imports System.IO
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

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Visible = True
        Label4.Visible = True
        Label3.Visible = True
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter
        Label3.ForeColor = Color.Red
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        If Not Label3.ClientRectangle.Contains(Label3.PointToClient(MousePosition)) Then
            Label3.ForeColor = Color.White
        End If
    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        Label4.ForeColor = Color.Red
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

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim filePath As String = "New Goodbye.exe - saisyo"
        Process.Start(filePath)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim filePath As String = "Five Nights At ティラノサウルス In Visial Basic.exe"
        Process.Start(filePath)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim filePath As String = "New Goodbye.exe - hello"
        Process.Start(filePath)
    End Sub
End Class