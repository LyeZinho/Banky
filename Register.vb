
Public Class Register
    Dim Pos As Point
    Private Sub Register_MouseMove(sender As Object, e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub Register_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Visible = False

    End Sub



    Private Sub CloseBTN_Click(sender As Object, e As EventArgs) Handles CloseBTN.Click
        Label4.Visible = False

        Dim Cliente As New Cliente
        Dim dbc As New DatabaseClients
        Dim dbl As New DatabaseLogin
        Dim Acc As New AccountNumberGenerators
        Dim sec As New BankySecurity

        Cliente.Name = Name_TB.Text
        Cliente.Password = Pass_TB.Text

        Dim _name, _nif, _work, _pass, _passconf As Boolean

        Dim _fieldsIsValid As Boolean = False
        Dim _userExists As Boolean = False

        If Name_TB.Text = "" Then
            Name_TB.Text = "Preencha esse campo!"
            _name = False
        Else
            Cliente.Name = Name_TB.Text
            _name = True
        End If

        If Nif_tb.Text = "" Then
            Nif_tb.Text = "Preencha esse campo!"
            _nif = False
        Else
            Cliente.Nif = Nif_tb.Text
            _nif = True
        End If

        If Employtipe_TB.Text = "" Then
            Employtipe_TB.Text = "Preencha esse campo!"
            _work = False
        Else
            Cliente.WorkType = Employtipe_TB.Text
            _work = True
        End If

        If Passconfirm_TB.Text = "" Or Pass_TB.Text = "" Then
            Passconfirm_TB.Text = "Preencha esse campo!"
            Pass_TB.Text = "Preencha esse campo!"
            _pass = False
            _passconf = False
        ElseIf Not Passconfirm_TB.Text = Pass_TB.Text Then
            Passconfirm_TB.Text = "Senhas não coincidem!"
            _pass = False
            _passconf = False
        Else
            Cliente.Password = sec.HashGen(Pass_TB.Text)
            _pass = True
            _passconf = True
        End If

        Cliente.AccountNumber = Acc.AccountNumberGen()
        Cliente.Balance = "0"

        If _name = True And _nif = True And _pass = True And _passconf = True And _work = True Then
            _fieldsIsValid = True
        End If


        Dim tryget As New Cliente

        tryget.Nif = Cliente.Nif
        dbc.readDb(tryget)

        If Not tryget.AccountNumber = "" Then
            _userExists = True
            Label4.Visible = True
            Label4.Text = "Usuario ja registrado!"
        ElseIf tryget.AccountNumber = "" Then
            _userExists = False

        End If

        If _userExists = False And _fieldsIsValid = True Then
            dbc.insertDb(Cliente)
            dbl.insertDb(Cliente)
            Me.Close()
            Main.Show()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class