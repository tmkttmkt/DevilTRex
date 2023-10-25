<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AxWindowsMediaPlayer2 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AxWindowsMediaPlayer3 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayer4 = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(-6, -28)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(319, 569)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(172, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ok"
        Me.Label1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Location = New System.Drawing.Point(313, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(644, 453)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'AxWindowsMediaPlayer2
        '
        Me.AxWindowsMediaPlayer2.Enabled = True
        Me.AxWindowsMediaPlayer2.Location = New System.Drawing.Point(313, 0)
        Me.AxWindowsMediaPlayer2.Name = "AxWindowsMediaPlayer2"
        Me.AxWindowsMediaPlayer2.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer2.Size = New System.Drawing.Size(643, 541)
        Me.AxWindowsMediaPlayer2.TabIndex = 3
        Me.AxWindowsMediaPlayer2.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(-6, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(963, 450)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 12)
        Me.Label2.TabIndex = 5
        '
        'AxWindowsMediaPlayer3
        '
        Me.AxWindowsMediaPlayer3.Enabled = True
        Me.AxWindowsMediaPlayer3.Location = New System.Drawing.Point(313, 0)
        Me.AxWindowsMediaPlayer3.Name = "AxWindowsMediaPlayer3"
        Me.AxWindowsMediaPlayer3.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer3.Size = New System.Drawing.Size(643, 540)
        Me.AxWindowsMediaPlayer3.TabIndex = 6
        Me.AxWindowsMediaPlayer3.Visible = False
        '
        'AxWindowsMediaPlayer4
        '
        Me.AxWindowsMediaPlayer4.Enabled = True
        Me.AxWindowsMediaPlayer4.Location = New System.Drawing.Point(313, 0)
        Me.AxWindowsMediaPlayer4.Name = "AxWindowsMediaPlayer4"
        Me.AxWindowsMediaPlayer4.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer4.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer4.Size = New System.Drawing.Size(643, 539)
        Me.AxWindowsMediaPlayer4.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(956, 450)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.AxWindowsMediaPlayer4)
        Me.Controls.Add(Me.AxWindowsMediaPlayer3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AxWindowsMediaPlayer2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Cursor = System.Windows.Forms.Cursors.No
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AxWindowsMediaPlayer2 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents AxWindowsMediaPlayer3 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayer4 As AxWMPLib.AxWindowsMediaPlayer
End Class
