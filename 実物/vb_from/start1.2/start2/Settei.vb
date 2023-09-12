Imports System.IO
Imports System.Text
Public Class Settei
    Dim str As String = ""
    Dim ss() As String = {"1", "2", "3"}
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DomainUpDown1.Text = ss(0)
        DomainUpDown1.Items.Add(ss(0))
        DomainUpDown1.Items.Add(ss(1))
        DomainUpDown1.Items.Add(ss(2))
        DomainUpDown2.Text = ss(0)
        DomainUpDown2.Items.Add(ss(0))
        DomainUpDown2.Items.Add(ss(1))
        DomainUpDown2.Items.Add(ss(2))
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using writer As New StreamWriter("test2.txt", False, Encoding.GetEncoding("Shift_JIS"))
            writer.WriteLine("teki=" + TextBox1.Text)
            If DomainUpDown1.Text = ss(0) Then
                writer.WriteLine("time=" + "300")
            ElseIf DomainUpDown1.Text = ss(1) Then
                writer.WriteLine("time=" + "180")
            ElseIf DomainUpDown1.Text = ss(2) Then
                writer.WriteLine("time=" + "30")
            End If
            If DomainUpDown2.Text = ss(0) Then
                writer.WriteLine("speed=" + "4")
            ElseIf DomainUpDown2.Text = ss(1) Then
                writer.WriteLine("speed=" + "3")
            ElseIf DomainUpDown2.Text = ss(2) Then
                writer.WriteLine("speed=" + "2")
            End If
            writer.WriteLine("アイテムの数=" + TextBox4.Text)
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class
