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
        Dim dbl As New DatabaseLogin
        Dim dbc As New DatabaseClients

        Dim Client As New Cliente

        Dim sec As New BankySecurity

        'Dim _passIsValid, _amountIsValid As Boolean
        'Dim _passIsVerify As Boolean = False
        'Dim _allIsValid As Boolean = False


        'Deposito
        If _depoist = True Then
            dbl.readDb(Client)
            dbc.readDb(Client)

            Dim val As Integer = 0

            Try
                val = Convert.ToInt32(Amount_TB.Text)
            Catch ex As Exception
                Amount_TB.Text = "Insira um valor valido!"
            End Try

            Client.Deposito(Client, val)

            dbc.readDb(Client)
            val = val + Convert.ToInt32(Client.Balance)

            MoneyLB.Text = val.ToString("C", New System.Globalization.CultureInfo("pt-PT"))
        End If

        'Levantamento
        If _whitdraw = True Then
            dbl.readDb(Client)
            dbc.readDb(Client)

            Dim val As Integer = 0

            Try
                val = Convert.ToInt32(Amount_TB.Text)
            Catch ex As Exception
                Amount_TB.Text = "Insira um valor valido!"
            End Try

            Client.Levantamento(Client, val)

            dbc.readDb(Client)
            val = val + Convert.ToInt32(Client.Balance)

            MoneyLB.Text = val.ToString("C", New System.Globalization.CultureInfo("pt-PT"))
        End If

        'transferencia
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        _transfer = False
        _whitdraw = False
        If _depoist = True Then
            _depoist = False
            Moves_GB.Visible = False
        ElseIf _depoist = False Then
            Moves_GB.Text = "Deposito"
            _depoist = True
            Moves_GB.Visible = True
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        _depoist = False
        _transfer = False

        If _whitdraw = True Then
            _whitdraw = False
            Moves_GB.Visible = False
        ElseIf _whitdraw = False Then
            Moves_GB.Text = "Levantamento"
            _whitdraw = True
            Moves_GB.Visible = True
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
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
End Class