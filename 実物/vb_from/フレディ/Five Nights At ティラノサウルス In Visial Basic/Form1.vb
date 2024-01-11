Imports System.Threading
Public Class Form1
    Dim Gamen_flg = False
    Dim Kankaku As Integer = 1000
    Dim denci As Integer = 100
    Dim Images(20) As Image
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Gamens(False)
        Label19.Text = "100"
        'Timer1.Interval = 1000
        Timer1.Enabled = True
        Images(0) = Image.FromFile("学校1.gif")
        Images(1) = Image.FromFile("学校2.gif")
        Images(2) = Image.FromFile("学校3.gif")
        Images(3) = Image.FromFile("学校4.gif")
        Images(4) = Image.FromFile("学校5.gif")
        Images(5) = Image.FromFile("学校6.gif")
        Images(6) = Image.FromFile("学校7.gif")
        Images(7) = Image.FromFile("学校8.gif")
        Images(8) = Image.FromFile("学校9.gif")
        Images(9) = Image.FromFile("学校10.gif")
        Images(10) = Image.FromFile("学校11.gif")
        Images(11) = Image.FromFile("学校12.gif")
        Images(12) = Image.FromFile("学校13.gif")
        Images(13) = Image.FromFile("学校14.gif")
        Images(14) = Image.FromFile("学校15.gif")
        Images(15) = Image.FromFile("学校16.gif")
        Images(16) = Image.FromFile("学校17.gif")
        Images(17) = Image.FromFile("学校18.gif")
        Images(18) = Image.FromFile("学校19.gif")
        Images(19) = Image.FromFile("学校20.gif")
        Images(20) = Image.FromFile("学校21.gif")

    End Sub
    Private Sub Home()
        Label20.Visible = True

    End Sub
    Private Sub Gamens(flg As Boolean) ' As Boolean
        PictureBox1.Visible = flg
        Label2.Visible = flg
        Label3.Visible = flg
        Label4.Visible = flg
        Label5.Visible = flg
        Label6.Visible = flg
        Label7.Visible = flg
        Label8.Visible = flg
        Label9.Visible = flg
        Label10.Visible = flg
        Label11.Visible = flg
        Label12.Visible = flg
        Label13.Visible = flg
        Label14.Visible = flg
        Label15.Visible = flg
        Label16.Visible = flg
        Label17.Visible = flg
        Label18.Visible = flg
        Label20.Visible = Not (flg)
        PictureBox2.Visible = flg
        PictureBox3.Visible = flg
        PictureBox4.Visible = flg
        PictureBox5.Visible = flg
        PictureBox6.Visible = flg
        PictureBox8.Visible = flg
        PictureBox9.Visible = flg
        PictureBox11.Visible = flg
        PictureBox12.Visible = flg
        'Return flg
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If Gamen_flg = False Then
            Gamens(True)
            Gamen_flg = True
        Else
            Gamens(False)
            Gamen_flg = False
        End If

    End Sub

    Private Sub Cam9_Click(sender As Object, e As EventArgs) Handles Label7.Click
        PictureBox1.Image = Images(15)
    End Sub

    Private Sub Cam1_Click(sender As Object, e As EventArgs) Handles Label2.Click
        PictureBox1.Image = Images(12)
    End Sub

    Private Sub Cam2_Click(sender As Object, e As EventArgs) Handles Label3.Click
        PictureBox1.Image = Images(2)
    End Sub

    Private Sub Cam7_Click(sender As Object, e As EventArgs) Handles Label9.Click, Label7.Click
        PictureBox1.Image = Images(16)
    End Sub

    Private Sub Cam3_Click(sender As Object, e As EventArgs) Handles Label4.Click
        PictureBox1.Image = Images(6)
    End Sub

    Private Sub Cam8_Click(sender As Object, e As EventArgs) Handles Label10.Click
        PictureBox1.Image = Images(8)
    End Sub

    Private Sub Cam6_Click(sender As Object, e As EventArgs) Handles Label8.Click
        PictureBox1.Image = Images(0)
    End Sub

    Private Sub Cam5_Click(sender As Object, e As EventArgs) Handles Label6.Click
        PictureBox1.Image = Images(18)
    End Sub

    Private Sub Cam4_Click(sender As Object, e As EventArgs) Handles Label5.Click
        PictureBox1.Image = Images(20)
    End Sub
    Private Function Battery(bai As Integer, Kankaku2 As Integer) As Integer
        Dim Kankakus As Integer = Kankaku2
        Dim Bai2 As Double = bai
        Thread.Sleep(Kankakus)
        denci -= (1 * Bai2)
        Return denci
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim zanryo As Integer
        zanryo = Battery(1, Kankaku)
        Label19.Text = zanryo
    End Sub
End Class
