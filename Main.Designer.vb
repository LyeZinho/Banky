<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MoneyLB = New System.Windows.Forms.Label()
        Me.Transf_LB = New System.Windows.Forms.ListBox()
        Me.MainUIGB = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Senha_TB = New System.Windows.Forms.TextBox()
        Me.Amount_TB = New System.Windows.Forms.TextBox()
        Me.Pass_LB = New System.Windows.Forms.Label()
        Me.Quant_LB = New System.Windows.Forms.Label()
        Me.ConfritmBTN = New System.Windows.Forms.Button()
        Me.Moves_GB = New System.Windows.Forms.GroupBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.SendNif_TB = New System.Windows.Forms.TextBox()
        Me.Nifsend_LB = New System.Windows.Forms.Label()
        Me.Orderbydes_BT = New System.Windows.Forms.Button()
        Me.Orderbyasc_BT = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.MainUIGB.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Moves_GB.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MoneyLB
        '
        Me.MoneyLB.AutoSize = True
        Me.MoneyLB.Font = New System.Drawing.Font("Impact", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MoneyLB.Location = New System.Drawing.Point(133, 52)
        Me.MoneyLB.Name = "MoneyLB"
        Me.MoneyLB.Size = New System.Drawing.Size(59, 43)
        Me.MoneyLB.TabIndex = 0
        Me.MoneyLB.Text = "----"
        '
        'Transf_LB
        '
        Me.Transf_LB.FormattingEnabled = True
        Me.Transf_LB.ItemHeight = 15
        Me.Transf_LB.Location = New System.Drawing.Point(12, 344)
        Me.Transf_LB.Name = "Transf_LB"
        Me.Transf_LB.Size = New System.Drawing.Size(332, 94)
        Me.Transf_LB.TabIndex = 4
        '
        'MainUIGB
        '
        Me.MainUIGB.BackColor = System.Drawing.Color.Transparent
        Me.MainUIGB.Controls.Add(Me.PictureBox3)
        Me.MainUIGB.Controls.Add(Me.PictureBox2)
        Me.MainUIGB.Controls.Add(Me.PictureBox1)
        Me.MainUIGB.Controls.Add(Me.MoneyLB)
        Me.MainUIGB.Location = New System.Drawing.Point(12, 27)
        Me.MainUIGB.Name = "MainUIGB"
        Me.MainUIGB.Size = New System.Drawing.Size(332, 268)
        Me.MainUIGB.TabIndex = 6
        Me.MainUIGB.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.BankyInterf.My.Resources.Resources.tranferencia
        Me.PictureBox3.Location = New System.Drawing.Point(258, 187)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(46, 47)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.BankyInterf.My.Resources.Resources.levantamento
        Me.PictureBox2.Location = New System.Drawing.Point(140, 187)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(52, 47)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BankyInterf.My.Resources.Resources.depositar
        Me.PictureBox1.Location = New System.Drawing.Point(25, 187)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Senha_TB
        '
        Me.Senha_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Senha_TB.Location = New System.Drawing.Point(28, 96)
        Me.Senha_TB.Name = "Senha_TB"
        Me.Senha_TB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Senha_TB.Size = New System.Drawing.Size(127, 23)
        Me.Senha_TB.TabIndex = 4
        '
        'Amount_TB
        '
        Me.Amount_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Amount_TB.Location = New System.Drawing.Point(28, 144)
        Me.Amount_TB.Name = "Amount_TB"
        Me.Amount_TB.Size = New System.Drawing.Size(127, 23)
        Me.Amount_TB.TabIndex = 7
        '
        'Pass_LB
        '
        Me.Pass_LB.AutoSize = True
        Me.Pass_LB.Location = New System.Drawing.Point(28, 75)
        Me.Pass_LB.Name = "Pass_LB"
        Me.Pass_LB.Size = New System.Drawing.Size(39, 15)
        Me.Pass_LB.TabIndex = 8
        Me.Pass_LB.Text = "Senha"
        '
        'Quant_LB
        '
        Me.Quant_LB.AutoSize = True
        Me.Quant_LB.Location = New System.Drawing.Point(28, 126)
        Me.Quant_LB.Name = "Quant_LB"
        Me.Quant_LB.Size = New System.Drawing.Size(69, 15)
        Me.Quant_LB.TabIndex = 9
        Me.Quant_LB.Text = "Quantidade"
        '
        'ConfritmBTN
        '
        Me.ConfritmBTN.BackColor = System.Drawing.Color.Transparent
        Me.ConfritmBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConfritmBTN.Location = New System.Drawing.Point(45, 182)
        Me.ConfritmBTN.Name = "ConfritmBTN"
        Me.ConfritmBTN.Size = New System.Drawing.Size(75, 23)
        Me.ConfritmBTN.TabIndex = 10
        Me.ConfritmBTN.Text = "Confirmar"
        Me.ConfritmBTN.UseVisualStyleBackColor = False
        '
        'Moves_GB
        '
        Me.Moves_GB.BackColor = System.Drawing.Color.Transparent
        Me.Moves_GB.Controls.Add(Me.PictureBox4)
        Me.Moves_GB.Controls.Add(Me.SendNif_TB)
        Me.Moves_GB.Controls.Add(Me.Nifsend_LB)
        Me.Moves_GB.Controls.Add(Me.Amount_TB)
        Me.Moves_GB.Controls.Add(Me.ConfritmBTN)
        Me.Moves_GB.Controls.Add(Me.Senha_TB)
        Me.Moves_GB.Controls.Add(Me.Quant_LB)
        Me.Moves_GB.Controls.Add(Me.Pass_LB)
        Me.Moves_GB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Moves_GB.Location = New System.Drawing.Point(376, 27)
        Me.Moves_GB.Name = "Moves_GB"
        Me.Moves_GB.Size = New System.Drawing.Size(188, 223)
        Me.Moves_GB.TabIndex = 11
        Me.Moves_GB.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.BankyInterf.My.Resources.Resources.icons8_protect_90
        Me.PictureBox4.Location = New System.Drawing.Point(145, 9)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(43, 42)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 15
        Me.PictureBox4.TabStop = False
        '
        'SendNif_TB
        '
        Me.SendNif_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SendNif_TB.Location = New System.Drawing.Point(28, 49)
        Me.SendNif_TB.Name = "SendNif_TB"
        Me.SendNif_TB.Size = New System.Drawing.Size(127, 23)
        Me.SendNif_TB.TabIndex = 11
        Me.SendNif_TB.Visible = False
        '
        'Nifsend_LB
        '
        Me.Nifsend_LB.AutoSize = True
        Me.Nifsend_LB.Location = New System.Drawing.Point(28, 28)
        Me.Nifsend_LB.Name = "Nifsend_LB"
        Me.Nifsend_LB.Size = New System.Drawing.Size(71, 15)
        Me.Nifsend_LB.TabIndex = 12
        Me.Nifsend_LB.Text = "Nif de envio"
        Me.Nifsend_LB.Visible = False
        '
        'Orderbydes_BT
        '
        Me.Orderbydes_BT.BackColor = System.Drawing.Color.Transparent
        Me.Orderbydes_BT.Location = New System.Drawing.Point(12, 315)
        Me.Orderbydes_BT.Name = "Orderbydes_BT"
        Me.Orderbydes_BT.Size = New System.Drawing.Size(30, 23)
        Me.Orderbydes_BT.TabIndex = 12
        Me.Orderbydes_BT.Text = "▼"
        Me.Orderbydes_BT.UseVisualStyleBackColor = False
        '
        'Orderbyasc_BT
        '
        Me.Orderbyasc_BT.BackColor = System.Drawing.Color.Transparent
        Me.Orderbyasc_BT.Location = New System.Drawing.Point(48, 315)
        Me.Orderbyasc_BT.Name = "Orderbyasc_BT"
        Me.Orderbyasc_BT.Size = New System.Drawing.Size(30, 23)
        Me.Orderbyasc_BT.TabIndex = 14
        Me.Orderbyasc_BT.Text = "▲"
        Me.Orderbyasc_BT.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.BankyInterf.My.Resources.Resources.icons8_back_arrow_30
        Me.PictureBox5.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(31, 30)
        Me.PictureBox5.TabIndex = 15
        Me.PictureBox5.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Orderbyasc_BT)
        Me.Controls.Add(Me.Orderbydes_BT)
        Me.Controls.Add(Me.Moves_GB)
        Me.Controls.Add(Me.MainUIGB)
        Me.Controls.Add(Me.Transf_LB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Main"
        Me.Text = "Banky"
        Me.MainUIGB.ResumeLayout(False)
        Me.MainUIGB.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Moves_GB.ResumeLayout(False)
        Me.Moves_GB.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MoneyLB As Label
    Friend WithEvents Transf_LB As ListBox
    Friend WithEvents MainUIGB As GroupBox
    Friend WithEvents Senha_TB As TextBox
    Friend WithEvents Amount_TB As TextBox
    Friend WithEvents Pass_LB As Label
    Friend WithEvents Quant_LB As Label
    Friend WithEvents ConfritmBTN As Button
    Friend WithEvents Moves_GB As GroupBox
    Friend WithEvents Orderbydes_BT As Button
    Friend WithEvents Orderbyasc_BT As Button
    Friend WithEvents SendNif_TB As TextBox
    Friend WithEvents Nifsend_LB As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Public WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
