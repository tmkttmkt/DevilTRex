Public Class How2
    Dim count As Integer

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        How3.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        count += 2
        If count = 10 Then
            Label2.Visible = True
        End If
        If count = 20 Then
            Label3.Visible = True
        End If
        If count = 30 Then
            Label5.Visible = True
        End If
        If count = 40 Then
            Label6.Visible = True
        End If
        If count = 50 Then
            Label7.Visible = True
        End If
        If count = 60 Then
            Label8.Visible = True
        End If
        If count = 70 Then
            Label9.Visible = True
        End If
        If count = 80 Then
            Label10.Visible = True
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub How2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = True
        Label2.Visible = False
        Label3.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        PictureBox1.Image = Image.FromFile("ゲーム画面.png")
    End Sub
End Class