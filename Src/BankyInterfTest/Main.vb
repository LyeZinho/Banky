Public Class Main
    Dim _depoist As Boolean = False
    Dim _whitdraw As Boolean = False
    Dim _transfer As Boolean = False



    Private Sub InterfacePrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Client As New Cliente
        Dim dbc As New DatabaseClients
        Dim dbl As New DatabaseLogin


        dbl.readDb(Client)
        dbc.readDb(Client)
        Dim bal As Double = Convert.ToDouble(Client.Balance)
        MoneyLB.Text = bal.ToString("C", New System.Globalization.CultureInfo("pt-PT"))




        Dim dbm As New DatabaseMoves
        Dim ArrayLi As New ArrayList
        Dim Moves As New AccountMoves

        ArrayLi = dbm.readDbASC(Client)
        Dim i As Integer = 0
        Dim f As Integer = ArrayLi.Count()

        Do While i < f
            Console.WriteLine("...................................................")
            Moves = TryCast(ArrayLi.Item(i), AccountMoves)
            Dim money As Integer = Convert.ToInt32(Moves.Moveamount)
            Moves.Moveamount = money.ToString("C", New System.Globalization.CultureInfo("en-US"))
            Dim str As String = "[" + Moves.Movetype + " | " + Moves.Moveamount + " | " + Moves.Movedate + "]"
            Transf_LB.Items.Add(str)
            i = i + 1
        Loop

        Nifsend_LB.Visible = False
        SendNif_TB.Visible = False
        Moves_GB.Visible = False
    End Sub

    Private Sub Orderbydes_BT_Click(sender As Object, e As EventArgs) Handles Orderbydes_BT.Click
        Transf_LB.Items.Clear()


        Dim dbl As New DatabaseLogin
        Dim dbc As New DatabaseClients
        Dim dbm As New DatabaseMoves

        Dim ArrayLi As New ArrayList

        Dim Moves As New AccountMoves
        Dim Client As New Cliente

        dbl.readDb(Client)
        dbc.readDb(Client)

        ArrayLi = dbm.readDbDESC(Client)
        Dim i As Integer = 0
        Dim f As Integer = ArrayLi.Count()

        Do While i < f
            Console.WriteLine("...................................................")
            Moves = TryCast(ArrayLi.Item(i), AccountMoves)
            Dim money As Integer = Convert.ToInt32(Moves.Moveamount)
            Moves.Moveamount = money.ToString("C", New System.Globalization.CultureInfo("pt-PT"))

            Dim str As String = "[" + Moves.Movetype + " | " + Moves.Moveamount + " | " + Moves.Movedate + "]"

            Transf_LB.Items.Add(str)
            i = i + 1
        Loop
    End Sub

    Private Sub Orderbyasc_BT_Click(sender As Object, e As EventArgs) Handles Orderbyasc_BT.Click
        Transf_LB.Items.Clear()

        Dim dbl As New DatabaseLogin
        Dim dbc As New DatabaseClients
        Dim dbm As New DatabaseMoves

        Dim ArrayLi As New ArrayList

        Dim Moves As New AccountMoves
        Dim Client As New Cliente

        dbl.readDb(Client)
        dbc.readDb(Client)

        ArrayLi = dbm.readDbASC(Client)
        Dim i As Integer = 0
        Dim f As Integer = ArrayLi.Count()

        Do While i < f
            Console.WriteLine("...................................................")
            Moves = TryCast(ArrayLi.Item(i), AccountMoves)
            Dim money As Integer = Convert.ToInt32(Moves.Moveamount)
            Moves.Moveamount = money.ToString("C", New System.Globalization.CultureInfo("pt-PT"))

            Dim str As String = "[" + Moves.Movetype + " | " + Moves.Moveamount + " | " + Moves.Movedate + "]"

            Transf_LB.Items.Add(str)
            i = i + 1
        Loop
    End Sub

    Private Sub DepoBTN_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TransfBTN_Click(sender As Object, e As EventArgs)
        _depoist = False
        _whitdraw = False
        If _transfer = True Then
            _transfer = False
            Moves_GB.Visible = False
        ElseIf _transfer = False Then
            Moves_GB.Text = "Transferencia"
            _transfer = True
            Moves_GB.Visible = True
        End If
    End Sub


    'Re escrever o codigo
    Private Sub WhitdrawBTN_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ConfritmBTN_Click(sender As Object, e As EventArgs) Handles ConfritmBTN.Click
        Dim _dbc As New DatabaseClients
        Dim _dbl As New DatabaseLogin
        Dim _sec As New BankySecurity
        Dim _acm As New AccountMoves
        Dim _client As New Cliente

        _dbl.readDb(_client)
        _dbc.readDb(_client)

        If _depoist = True Then
            Dim password = Pass_TB.Text
            Dim amount = Amount_TB.Text
            Dim val As Integer = 0
            Dim valIsValid, passIsValid, userIsValid As Boolean

            If String.IsNullOrEmpty(password) Then
                Amount_TB.Text = "Insira uma senha!"
                passIsValid = False
            Else
                passIsValid = True
            End If

            If String.IsNullOrEmpty(amount) Then
                Amount_TB.Text = "Insira uma quantidade!"
                valIsValid = False
            Else
                valIsValid = True
            End If

            val = ConvetToInt(Amount_TB.Text)


            userIsValid = _sec.Passverify(_client, password)

            If userIsValid = False Then
                Amount_TB.Text = "Usuario invalido!"
            End If

            If valIsValid = True And passIsValid = True And userIsValid = True Then
                _acm.Deposito(_client, val)
                UpdateBalLable()
            End If
        End If

        If _whitdraw = True Then
            Dim password = Pass_TB.Text
            Dim amount = Amount_TB.Text
            Dim val As Integer = 0
            Dim valIsValid, passIsValid, userIsValid As Boolean

            If String.IsNullOrEmpty(password) Then
                Amount_TB.Text = "Insira uma senha!"
                passIsValid = False
            Else
                passIsValid = True
            End If

            If String.IsNullOrEmpty(amount) Then
                Amount_TB.Text = "Insira uma quantidade!"
                valIsValid = False
            Else
                valIsValid = True
            End If

            val = ConvetToInt(Amount_TB.Text)


            userIsValid = _sec.Passverify(_client, password)

            If userIsValid = False Then
                Amount_TB.Text = "Usuario invalido!"
            End If

            If valIsValid = True And passIsValid = True And userIsValid = True Then
                _acm.Levantamento(_client, val)
                UpdateBalLable()
            End If
        End If

        If _transfer = True Then
            Dim password = Pass_TB.Text
            Dim amount = Amount_TB.Text
            Dim targNif = SendNif_TB.Text
            Dim val As Integer = 0
            Dim valIsValid, passIsValid, userIsValid As Boolean

            If String.IsNullOrEmpty(password) Then
                passIsValid = False
                Amount_TB.Text = "Insira uma senha!"
            Else
                passIsValid = True
            End If

            If String.IsNullOrEmpty(amount) Then
                valIsValid = False

            Else
                valIsValid = True
            End If

            val = ConvetToInt(Amount_TB.Text)

            userIsValid = _sec.Passverify(_client, password)

            If userIsValid = False Then
                Amount_TB.Text = "Usuario invalido!"
            End If

            If valIsValid = True And passIsValid = True And userIsValid = True Then
                Dim targClient As New Cliente
                targClient.Nif = targNif

                _acm.Transferencia(_client, targClient, val)
                UpdateBalLable()
            End If

        End If
    End Sub


    Sub UpdateBalLable()
        Dim _client As New Cliente
        Dim _dbl As New DatabaseLogin
        Dim _dbc As New DatabaseClients
        _dbl.readDb(_client)
        _dbc.readDb(_client)
        Dim _balDob As Double = Convert.ToDouble(_client.Balance)
        MoneyLB.Text = _balDob.ToString("C", New System.Globalization.CultureInfo("pt-PT"))
    End Sub

    Function ConvetToInt(ByVal _input As String) As Integer
        Dim val As Integer
        Try
            val = Convert.ToInt32(_input)
        Catch ex As Exception

        End Try
        Return val
    End Function


    Private Sub DepoPB_Click(sender As Object, e As EventArgs) Handles DepoPB.Click
        _transfer = False
        _whitdraw = False
        Nifsend_LB.Visible = False
        SendNif_TB.Visible = False
        If _depoist = True Then
            Nifsend_LB.Visible = False
            SendNif_TB.Visible = False
            _depoist = False
            Moves_GB.Visible = False
        ElseIf _depoist = False Then
            _depoist = True
            Moves_GB.Visible = True
            Moves_GB.Text = "Deposito"
        End If
    End Sub

    Private Sub With_PB_Click(sender As Object, e As EventArgs) Handles With_PB.Click
        _transfer = False
        _depoist = False
        Nifsend_LB.Visible = False
        SendNif_TB.Visible = False
        If _whitdraw = True Then
            _whitdraw = False
            Moves_GB.Visible = False
        ElseIf _whitdraw = False Then
            _whitdraw = True
            Moves_GB.Visible = True
            Moves_GB.Text = "Levantamento"
        End If
    End Sub

    Private Sub Transf_PB_Click(sender As Object, e As EventArgs) Handles Transf_PB.Click
        _depoist = False
        _whitdraw = False
        Nifsend_LB.Visible = False
        SendNif_TB.Visible = False
        If _transfer = True Then
            _transfer = False
            Moves_GB.Visible = False
        ElseIf _transfer = False Then
            Nifsend_LB.Visible = True
            SendNif_TB.Visible = True
            _transfer = True
            Moves_GB.Visible = True
            Moves_GB.Text = "Transferencia"
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Hide()
        Startscreen.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserInfo.Show()
    End Sub
End Class