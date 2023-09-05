
Imports System.IO
Public Class Settei
    Dim str As String = ""
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using writer As New StreamWriter("U:\課題研究\start2\bin\Debug\test2.txt")
            writer.WriteLine("敵の数=" + TextBox1.Text)
            writer.WriteLine("難易度=" + TextBox2.Text)
            writer.WriteLine("スピード=" + TextBox3.Text)
            writer.WriteLine("アイテムの数=" + TextBox4.Text)
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class
