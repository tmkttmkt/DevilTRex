Public Class How3
    Dim count As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        How.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        My.Computer.Audio.Play("ボタンの効果音.wav")
        How2.Show()
    End Sub

    Private Sub How3_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = True
        Label4.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        count += 1
        If Label3.Left >= 324 Then
            Label3.Left -= 50
        End If
        If count >= 20 Then
            Label6.Enabled = True
            Label4.Enabled = True
        End If

    End Sub


End Class