<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.ConfirmBTN = New System.Windows.Forms.Button()
        Me.AlertLB = New System.Windows.Forms.Label()
        Me.NifTB = New System.Windows.Forms.TextBox()
        Me.PassTB = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConfirmBTN
        '
        Me.ConfirmBTN.BackColor = System.Drawing.Color.Transparent
        Me.ConfirmBTN.Location = New System.Drawing.Point(346, 323)
        Me.ConfirmBTN.Name = "ConfirmBTN"
        Me.ConfirmBTN.Size = New System.Drawing.Size(75, 23)
        Me.ConfirmBTN.TabIndex = 0
        Me.ConfirmBTN.Text = "Confirmar"
        Me.ConfirmBTN.UseVisualStyleBackColor = False
        '
        'AlertLB
        '
        Me.AlertLB.AutoSize = True
        Me.AlertLB.BackColor = System.Drawing.Color.Transparent
        Me.AlertLB.Location = New System.Drawing.Point(372, 205)
        Me.AlertLB.Name = "AlertLB"
        Me.AlertLB.Size = New System.Drawing.Size(27, 15)
        Me.AlertLB.TabIndex = 1
        Me.AlertLB.Text = "----"
        '
        'NifTB
        '
        Me.NifTB.Location = New System.Drawing.Point(203, 267)
        Me.NifTB.Name = "NifTB"
        Me.NifTB.Size = New System.Drawing.Size(100, 23)
        Me.NifTB.TabIndex = 2
        Me.NifTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PassTB
        '
        Me.PassTB.Location = New System.Drawing.Point(466, 267)
        Me.PassTB.Name = "PassTB"
        Me.PassTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassTB.Size = New System.Drawing.Size(100, 23)
        Me.PassTB.TabIndex = 3
        Me.PassTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.BankyInterf.My.Resources.Resources.icons8_test_account_90
        Me.PictureBox1.Location = New System.Drawing.Point(325, 116)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(235, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "NIF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(489, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.BankyInterf.My.Resources.Resources.icons8_back_arrow_301
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 30)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Login
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PassTB)
        Me.Controls.Add(Me.NifTB)
        Me.Controls.Add(Me.AlertLB)
        Me.Controls.Add(Me.ConfirmBTN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Banky"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConfirmBTN As Button
    Friend WithEvents AlertLB As Label
    Friend WithEvents NifTB As TextBox
    Friend WithEvents PassTB As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
