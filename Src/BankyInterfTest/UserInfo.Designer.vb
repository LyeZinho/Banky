<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserInfo))
        Me.DataLB = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'DataLB
        '
        Me.DataLB.BackColor = System.Drawing.Color.Turquoise
        Me.DataLB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataLB.FormattingEnabled = True
        Me.DataLB.ItemHeight = 15
        Me.DataLB.Location = New System.Drawing.Point(12, 23)
        Me.DataLB.Name = "DataLB"
        Me.DataLB.Size = New System.Drawing.Size(464, 165)
        Me.DataLB.TabIndex = 0
        '
        'UserInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(489, 206)
        Me.Controls.Add(Me.DataLB)
        Me.MaximizeBox = False
        Me.Name = "UserInfo"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Banky"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataLB As ListBox
End Class
