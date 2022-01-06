<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.CloseBTN = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NomeLB = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Name_TB = New System.Windows.Forms.TextBox()
        Me.Pass_TB = New System.Windows.Forms.TextBox()
        Me.Passconfirm_TB = New System.Windows.Forms.TextBox()
        Me.Nif_tb = New System.Windows.Forms.TextBox()
        Me.Employtipe_TB = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CloseBTN
        '
        Me.CloseBTN.BackColor = System.Drawing.Color.Transparent
        Me.CloseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CloseBTN.Location = New System.Drawing.Point(86, 385)
        Me.CloseBTN.Name = "CloseBTN"
        Me.CloseBTN.Size = New System.Drawing.Size(75, 24)
        Me.CloseBTN.TabIndex = 0
        Me.CloseBTN.Text = "Continuar"
        Me.CloseBTN.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(28, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Senha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(348, -13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Label5"
        '
        'NomeLB
        '
        Me.NomeLB.AutoSize = True
        Me.NomeLB.BackColor = System.Drawing.Color.Transparent
        Me.NomeLB.Location = New System.Drawing.Point(28, 86)
        Me.NomeLB.Name = "NomeLB"
        Me.NomeLB.Size = New System.Drawing.Size(40, 15)
        Me.NomeLB.TabIndex = 13
        Me.NomeLB.Text = "Nome"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(28, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Nif"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(28, 269)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 15)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Tipo de emprego"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(28, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 15)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Confirme sua senha"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.BankyInterf.My.Resources.Resources.bank47
        Me.PictureBox1.Location = New System.Drawing.Point(336, 86)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(229, 204)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(412, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 28)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Banky"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(103, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 30)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "---"
        '
        'Name_TB
        '
        Me.Name_TB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Name_TB.Location = New System.Drawing.Point(28, 104)
        Me.Name_TB.Name = "Name_TB"
        Me.Name_TB.Size = New System.Drawing.Size(223, 16)
        Me.Name_TB.TabIndex = 31
        '
        'Pass_TB
        '
        Me.Pass_TB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Pass_TB.Location = New System.Drawing.Point(28, 148)
        Me.Pass_TB.Name = "Pass_TB"
        Me.Pass_TB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Pass_TB.Size = New System.Drawing.Size(223, 16)
        Me.Pass_TB.TabIndex = 32
        '
        'Passconfirm_TB
        '
        Me.Passconfirm_TB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Passconfirm_TB.Location = New System.Drawing.Point(28, 192)
        Me.Passconfirm_TB.Name = "Passconfirm_TB"
        Me.Passconfirm_TB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Passconfirm_TB.Size = New System.Drawing.Size(223, 16)
        Me.Passconfirm_TB.TabIndex = 33
        '
        'Nif_tb
        '
        Me.Nif_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Nif_tb.Location = New System.Drawing.Point(28, 240)
        Me.Nif_tb.Name = "Nif_tb"
        Me.Nif_tb.Size = New System.Drawing.Size(223, 16)
        Me.Nif_tb.TabIndex = 34
        '
        'Employtipe_TB
        '
        Me.Employtipe_TB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Employtipe_TB.Location = New System.Drawing.Point(28, 287)
        Me.Employtipe_TB.Name = "Employtipe_TB"
        Me.Employtipe_TB.Size = New System.Drawing.Size(223, 16)
        Me.Employtipe_TB.TabIndex = 35
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.BankyInterf.My.Resources.Resources.icons8_back_arrow_301
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 30)
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Employtipe_TB)
        Me.Controls.Add(Me.Nif_tb)
        Me.Controls.Add(Me.Passconfirm_TB)
        Me.Controls.Add(Me.Pass_TB)
        Me.Controls.Add(Me.Name_TB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NomeLB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CloseBTN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Register"
        Me.Text = "Banky"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CloseBTN As Button
    Friend WithEvents SenhaTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NomeLB As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents NifTB As TextBox
    Friend WithEvents TdeTB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SenhaConfirmTB As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Name_TB As TextBox
    Friend WithEvents Pass_TB As TextBox
    Friend WithEvents Passconfirm_TB As TextBox
    Friend WithEvents Nif_tb As TextBox
    Friend WithEvents Employtipe_TB As TextBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
