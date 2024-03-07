Imports System.Diagnostics
Imports System.Media
Imports System.Text
Imports AxWMPLib
Imports System.IO
Public Class Form3


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
        Process.Start("New Goodbye.exe")
        Application.Exit()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

        Process.Start("Five Nights At ティラノサウルス In Visial Basic.exe")
        Application.Exit()
    End Sub

End Class