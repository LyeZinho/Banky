Public Class Login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AlertLB.Visible = False

    End Sub



    Dim Pos As Point
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub


    Private Sub ConfirmBTN_Click(sender As Object, e As EventArgs) Handles ConfirmBTN.Click
        AlertLB.Visible = False
        Dim dbl As New DatabaseLogin
        Dim sec As New BankySecurity
        Dim Client As New Cliente

        Client.Nif = NifTB.Text

        Dim _valid As Boolean = sec.Passverify(Client, PassTB.Text)

        If _valid = False Then
            AlertLB.Visible = True
            AlertLB.Text = "Senha invalida"
        ElseIf _valid = True Then
            Me.Hide()
            Main.Show()
            dbl.insertDb(Client)
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Startscreen.Show()
    End Sub
End Class
