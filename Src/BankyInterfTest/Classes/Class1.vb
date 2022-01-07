Imports System.Data.SQLite

Class Cliente
    Private _name_client As String
    Private _password As String
    Private _nif As String
    Private _work_type As String
    Private _balance As String = Format("0.0")
    Private _account_number As String
    Public _moves_count As String = "0"
    ReadOnly _creation_date As String = New Date.Today.ToString("MM/dd/yyyy hh:mm")

    Property Name
        Get
            Name = _name_client
        End Get
        Set(value)
            _name_client = value
        End Set
    End Property

    Property Password
        Get
            Password = _password
        End Get
        Set(value)
            _password = value
        End Set
    End Property

    Property Nif
        Get
            Nif = _nif
        End Get
        Set(value)
            _nif = value
        End Set
    End Property

    Property WorkType
        Get
            WorkType = _work_type
        End Get
        Set(value)
            _work_type = value
        End Set
    End Property

    Property Balance
        Get
            Balance = _balance
        End Get
        Set(value)
            _balance = value
        End Set
    End Property

    Property AccountNumber
        Get
            AccountNumber = _account_number
        End Get
        Set(value)
            _account_number = value
        End Set
    End Property

    Property Movescount
        Get
            Movescount = _moves_count
        End Get
        Set(value)
            _moves_count = value
        End Set
    End Property

    ReadOnly Property Creationdate
        Get
            Creationdate = _creation_date
        End Get
    End Property

End Class

Class AccountMoves
    Private _movetype As String
    Private _moveamount As String
    Private _movedate As String
    Private _account_number As String

    Property Movetype
        Get
            Movetype = _movetype
        End Get
        Set(value)
            _movetype = value
        End Set
    End Property

    Property Moveamount
        Get
            Moveamount = _moveamount
        End Get
        Set(value)
            _moveamount = value
        End Set
    End Property

    Property Movedate
        Get
            Movedate = _movedate
        End Get
        Set(value)
            _movedate = value
        End Set
    End Property

    Property AccountNumber
        Get
            AccountNumber = _account_number
        End Get
        Set(value)
            _account_number = value
        End Set
    End Property


    Sub CreateMoveDeposito(_move As AccountMoves)
        Dim day As String = New Date.Today.ToString("MM/dd/yyyy")
        Dim hour As String = New Date.Now.ToString("HH:mm")
        _move.Movedate = day + " | " + hour
        _move.Movetype = "Deposito"
        Dim db As New DatabaseMoves
        db.insertDb(_move)
    End Sub

    Sub CreateMoveLevantamento(_move As AccountMoves)
        Dim day As String = New Date.Today.ToString("MM/dd/yyyy")
        Dim hour As String = New Date.Now.ToString("HH:mm")
        _move.Movedate = day + " | " + hour
        _move.Movetype = "Levantamento"
        Dim db As New DatabaseMoves
        db.insertDb(_move)
    End Sub

    Sub CreateMoveTransferencia(_move As AccountMoves)
        Dim day As String = New Date.Today.ToString("MM/dd/yyyy")
        Dim hour As String = New Date.Now.ToString("HH:mm")
        _move.Movedate = day + " | " + hour
        _move.Movetype = "Transferencia"
        Dim db As New DatabaseMoves
        db.insertDb(_move)
    End Sub

    Function Levantamento(_client As Cliente, _amount As Integer)

        Dim db As New DatabaseClients
        Dim Client As Cliente = _client

        db.readDb(Client)

        Dim Money As Integer = Convert.ToInt32(Client.Balance)

        If Money < _amount Then

        ElseIf Money > _amount Then

            Money = Money - _amount
        End If

        db.updateBalDb(Client, Money.ToString)

        Dim Move As New AccountMoves
        Move.Moveamount = _amount
        Move.AccountNumber = _client.AccountNumber
        Move.CreateMoveLevantamento(Move)

        Return "Levantamento concluido"
    End Function

    Function Deposito(_client As Cliente, _amount As Integer) As String
        Dim db As New DatabaseClients

        Dim Client As Cliente = _client

        db.readDb(Client)

        Dim Money As Integer = Convert.ToInt32(Client.Balance)

        Money = Money + _amount

        db.updateBalDb(Client, Money.ToString)

        Dim Move As New AccountMoves
        Move.Moveamount = _amount
        Move.AccountNumber = _client.AccountNumber
        Move.CreateMoveDeposito(Move)

        Return "Deposito concluido"
    End Function

    Function Transferencia(_clientSource As Cliente, _clientTarget As Cliente, _amount As Integer) As String
        Dim db As New DatabaseClients

        Dim SrcClient As Cliente = _clientSource
        Dim TrgClient As Cliente = _clientTarget

        db.readDb(SrcClient)
        db.readDb(TrgClient)

        Dim MoneySrc As Integer = Convert.ToInt32(SrcClient.Balance)
        Dim MoneyTrg As Integer = Convert.ToInt32(TrgClient.Balance)

        If MoneySrc < _amount Then

            Return "Valor insuficiente!"
        ElseIf MoneySrc > _amount Then

            MoneySrc = MoneySrc - _amount
            MoneyTrg = MoneyTrg + _amount
        End If

        db.updateBalDb(SrcClient, MoneySrc.ToString)
        db.updateBalDb(TrgClient, MoneyTrg.ToString)

        Dim Move As New AccountMoves
        Move.Moveamount = _amount
        Move.AccountNumber = _clientSource.AccountNumber
        Move.CreateMoveTransferencia(Move)

        Return "Transferencia concluida!"
    End Function

End Class

Class BankySecurity

    Function Passverify(_client As Cliente, _password As String) As Boolean
        Dim db As New DatabaseClients
        Dim Cliente As Cliente = _client
        Dim validation As Boolean = False
        Dim Hash = HashGen(_password)

        db.readDb(Cliente)
        Dim dbPass As String = Cliente.Password

        If dbPass = Hash Then
            validation = True
        ElseIf Not dbPass = Hash Then
            validation = False
        End If

        Return validation
    End Function

    Function HashGen(_strToHash As String) As String

        Dim sha1Obj As New System.Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(_strToHash)

        bytesToHash = sha1Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""

        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next

        Return strResult
    End Function
End Class

Class AccountNumberGenerators
    Function AccountNumberGen() As String
        Dim _str As String = ""
        Dim rand As New Random
        Dim _num As Integer

        For i As Integer = 0 To 3
            _num = rand.Next(100, 999)
            _str = _str + _num.ToString
        Next

        Return _str
    End Function

End Class

Class DatabaseMoves
    Sub startDb()
        Dim sqlite_conn As SQLiteConnection
        Dim sqlite_cmd As SQLiteCommand
        sqlite_conn = New SQLiteConnection("Data Source=moves.db;Version=3;")
        sqlite_conn.Open()

        sqlite_cmd = sqlite_conn.CreateCommand()

        Dim _create As String = "CREATE TABLE IF NOT EXISTS Moves "
        Dim _table As String = "(movetype TEXT, moneyamount TEXT, movedate TEXT, accountnumber TEXT);"
        Dim _command = _create + _table

        sqlite_cmd.CommandText = _command
        sqlite_cmd.ExecuteNonQuery()
    End Sub

    Sub insertDb(_moves As AccountMoves)
        Dim sqlite_conn As SQLiteConnection
        Dim sqlite_cmd As SQLiteCommand
        sqlite_conn = New SQLiteConnection("Data Source=moves.db;Version=3;")
        sqlite_conn.Open()


        sqlite_cmd = sqlite_conn.CreateCommand()

        Dim _insert As String = "INSERT INTO Moves ( movetype, moneyamount, movedate, accountnumber) "
        Dim _values As String = "VALUES ('" + _moves.Movetype + "', '" + _moves.Moveamount + "', '" + _moves.Movedate + "', '" + _moves.AccountNumber + "');"
        Dim _command As String = _insert + _values


        sqlite_cmd.CommandText = _command
        sqlite_cmd.ExecuteNonQuery()
    End Sub

    Function readDbASC(ByVal _cliente As Cliente) As System.Collections.ArrayList

        Dim sqlite_conn As SQLiteConnection
        Dim sqlite_cmd As SQLiteCommand

        sqlite_conn = New SQLiteConnection("Data Source=moves.db;Version=3;")
        sqlite_conn.Open()
        sqlite_cmd = sqlite_conn.CreateCommand()

        Dim _select As String = "SELECT movetype, moneyamount, movedate, accountnumber "
        Dim _from As String = "FROM Moves "
        Dim _where As String = "WHERE accountnumber = '" + _cliente.AccountNumber + "' "
        Dim _orderby As String = "ORDER BY movedate ASC;"
        Dim _command As String = _select + _from + _where + _orderby

        sqlite_cmd.CommandText = _command
        Dim _varArrL As New System.Collections.ArrayList()

        Dim Adapter As New System.Data.SQLite.SQLiteDataAdapter(sqlite_cmd)
        Dim DataTable As New System.Data.DataTable()
        Adapter.Fill(DataTable)

        For Each Row As System.Data.DataRow In DataTable.Rows
            Dim _varMoves As New AccountMoves

            _varMoves.Movetype = Row("movetype")
            _varMoves.Moveamount = Row("moneyamount")
            _varMoves.Movedate = Row("movedate")
            _varMoves.AccountNumber = Row("accountnumber")


            _varArrL.Add(_varMoves)
        Next
        Return _varArrL
    End Function

    Function readDbDESC(ByVal _cliente As Cliente) As System.Collections.ArrayList

        Dim sqlite_conn As SQLiteConnection
        Dim sqlite_cmd As SQLiteCommand

        sqlite_conn = New SQLiteConnection("Data Source=moves.db;Version=3;")
        sqlite_conn.Open()
        sqlite_cmd = sqlite_conn.CreateCommand()

        Dim _select As String = "SELECT movetype, moneyamount, movedate, accountnumber "
        Dim _from As String = "FROM Moves "
        Dim _where As String = "WHERE accountnumber = '" + _cliente.AccountNumber + "' "
        Dim _orderby As String = "ORDER BY movedate DESC;"
        Dim _command As String = _select + _from + _where + _orderby

        sqlite_cmd.CommandText = _command
        Dim _varArrL As New System.Collections.ArrayList()

        Dim Adapter As New System.Data.SQLite.SQLiteDataAdapter(sqlite_cmd)
        Dim DataTable As New System.Data.DataTable()
        Adapter.Fill(DataTable)

        For Each Row As System.Data.DataRow In DataTable.Rows
            Dim _varMoves As New AccountMoves

            _varMoves.Movetype = Row("movetype")
            _varMoves.Moveamount = Row("moneyamount")
            _varMoves.Movedate = Row("movedate")
            _varMoves.AccountNumber = Row("accountnumber")


            _varArrL.Add(_varMoves)
        Next
        Return _varArrL
    End Function
End Class

Class DatabaseClients
    Sub startDb()
        Dim sqlite_conn As SQLiteConnection
        Dim sqlite_cmd As SQLiteCommand
        sqlite_conn = New SQLiteConnection("Data Source=clients.db;Version=3;")
        sqlite_conn.Open()

        sqlite_cmd = sqlite_conn.CreateCommand()

        Dim _create As String = "CREATE TABLE IF NOT EXISTS Clients "
        Dim _table As String = "(name TEXT, password TEXT, nif TEXT, worktype TEXT, balance TEXT, movescount TEXT, accountnumber TEXT, creationdate TEXT);"
        Dim _command = _create + _table

        sqlite_cmd.CommandText = _command
        sqlite_cmd.ExecuteNonQuery()
    End Sub

    Function insertDb(_client As Cliente)
        Dim sqlite_conn As SQLiteConnection
        Dim sqlite_cmd As SQLiteCommand
        sqlite_conn = New SQLiteConnection("Data Source=clients.db;Version=3;")
        sqlite_conn.Open()


        sqlite_cmd = sqlite_conn.CreateCommand()

        Dim _insert As String = "INSERT INTO Clients (name, password, nif, worktype, balance, movescount, accountnumber, creationdate) "
        Dim _values As String = "VALUES ('" + _client.Name + "', '" + _client.Password + "', '" + _client.Nif + "', '" + _client.WorkType + "', '" + _client.Balance + "', '" + _client.Movescount + "', '" + _client.AccountNumber + "', '" + _client.Creationdate + "');"
        Dim _command As String = _insert + _values


        sqlite_cmd.CommandText = _command
        sqlite_cmd.ExecuteNonQuery()
    End Function

    Sub readDb(ByRef _client As Cliente)
        Dim sqlite_conn As SQLiteConnection
        Dim sqlite_cmd As SQLiteCommand
        Dim sqlite_datareader As SQLiteDataReader

        sqlite_conn = New SQLiteConnection("Data Source=clients.db;Version=3;")
        sqlite_conn.Open()
        sqlite_cmd = sqlite_conn.CreateCommand()

        Dim _select As String = "SELECT name, password, worktype, balance, movescount, accountnumber, creationdate "
        Dim _from As String = "FROM Clients "
        Dim _where As String = "WHERE nif = '" + _client.Nif + "';"
        Dim _command As String = _select + _from + _where

        sqlite_cmd.CommandText = _command
        sqlite_datareader = sqlite_cmd.ExecuteReader()

        While (sqlite_datareader.Read())

            _client.Name = sqlite_datareader.GetString(0)
            _client.Password = sqlite_datareader.GetString(1)
            _client.WorkType = sqlite_datareader.GetString(2)
            _client.Balance = sqlite_datareader.GetString(3)
            _client.Movescount = sqlite_datareader.GetString(4)
            _client.AccountNumber = sqlite_datareader.GetString(5)
        End While

    End Sub

    Function readCreationDateDb(_client As Cliente)
        Dim sqlite_conn As SQLiteConnection
        Dim sqlite_cmd As SQLiteCommand
        Dim sqlite_datareader As SQLiteDataReader

        sqlite_conn = New SQLiteConnection("Data Source=clients.db;Version=3;")
        sqlite_conn.Open()
        sqlite_cmd = sqlite_conn.CreateCommand()

        Dim _select As String = "SELECT creationdate "
        Dim _from As String = "FROM Clients "
        Dim _where As String = "WHERE accountnumber = '" + _client.AccountNumber + "';"
        Dim _command As String = _select + _from + _where

        sqlite_cmd.CommandText = _command
        sqlite_datareader = sqlite_cmd.ExecuteReader()

        Dim _date As String = Nothing
        While (sqlite_datareader.Read())

            _date = sqlite_datareader.GetString(0)

        End While
        Return _date
    End Function

    Sub deleteDb(_client As Cliente)
        Dim sqlite_conn As SQLiteConnection
        Dim sqlite_cmd As SQLiteCommand
        sqlite_conn = New SQLiteConnection("Data Source=clients.db;Version=3;")
        sqlite_conn.Open()


        sqlite_cmd = sqlite_conn.CreateCommand()

        Dim _delete As String = "DELETE FROM Clients "
        Dim _where As String = "WHERE accountnumber = '" + _client.AccountNumber + "'"
        Dim _command As String = _delete + _where

        sqlite_cmd.CommandText = _command
        sqlite_cmd.ExecuteNonQuery()
    End Sub

    Function updateDb(ByVal clientOld As Cliente, ByVal clientNew As Cliente)
        deleteDb(clientOld)
        insertDb(clientNew)
    End Function

    Sub updateBalDb(_client As Cliente, _balance As String)
        Dim sqlite_conn As SQLiteConnection
        Dim sqlite_cmd As SQLiteCommand
        sqlite_conn = New SQLiteConnection("Data Source=clients.db;Version=3;")
        sqlite_conn.Open()


        sqlite_cmd = sqlite_conn.CreateCommand()

        Dim _update As String = "UPDATE Clients "
        Dim _set As String = "SET balance = '" + _balance + "'"
        Dim _where As String = "WHERE accountnumber = '" + _client.AccountNumber + "';"
        Dim _command As String = _update + _set + _where

        sqlite_cmd.CommandText = _command
        sqlite_cmd.ExecuteNonQuery()
    End Sub
End Class

Class DatabaseLogin

    Sub startDb()
        Dim sqlite_conn As SQLiteConnection
        Dim sqlite_cmd As SQLiteCommand
        sqlite_conn = New SQLiteConnection("Data Source=login.db;Version=3;")
        sqlite_conn.Open()

        sqlite_cmd = sqlite_conn.CreateCommand()

        Dim _create As String = "CREATE TABLE IF NOT EXISTS Login "
        Dim _table As String = "(id TEXT, nif TEXT );"
        Dim _command = _create + _table

        sqlite_cmd.CommandText = _command
        sqlite_cmd.ExecuteNonQuery()
    End Sub

    Function insertDb(_client As Cliente)
        Dim sqlite_conn As SQLiteConnection
        Dim sqlite_cmd As SQLiteCommand
        sqlite_conn = New SQLiteConnection("Data Source=login.db;Version=3;")
        sqlite_conn.Open()

        deleteDb()

        sqlite_cmd = sqlite_conn.CreateCommand()

        Dim _insert As String = "INSERT INTO Login (id, nif) "
        Dim _values As String = "VALUES ('1' ,'" + _client.Nif + "');"
        Dim _command As String = _insert + _values


        sqlite_cmd.CommandText = _command
        sqlite_cmd.ExecuteNonQuery()
    End Function

    Sub deleteDb()
        Dim sqlite_conn As SQLiteConnection
        Dim sqlite_cmd As SQLiteCommand
        sqlite_conn = New SQLiteConnection("Data Source=login.db;Version=3;")
        sqlite_conn.Open()


        sqlite_cmd = sqlite_conn.CreateCommand()

        Dim _delete As String = "DELETE FROM Login "
        Dim _where As String = "WHERE id = '1';"
        Dim _command As String = _delete + _where

        sqlite_cmd.CommandText = _command
        sqlite_cmd.ExecuteNonQuery()
    End Sub

    Sub readDb(ByRef _client As Cliente)
        Dim sqlite_conn As SQLiteConnection
        Dim sqlite_cmd As SQLiteCommand
        Dim sqlite_datareader As SQLiteDataReader

        sqlite_conn = New SQLiteConnection("Data Source=login.db;Version=3;")
        sqlite_conn.Open()
        sqlite_cmd = sqlite_conn.CreateCommand()

        Dim _select As String = "SELECT nif "
        Dim _from As String = "FROM Login "
        Dim _where As String = "WHERE id = '1';"
        Dim _command As String = _select + _from + _where

        sqlite_cmd.CommandText = _command
        sqlite_datareader = sqlite_cmd.ExecuteReader()

        While (sqlite_datareader.Read())

            _client.Nif = sqlite_datareader.GetString(0)
        End While

    End Sub

End Class