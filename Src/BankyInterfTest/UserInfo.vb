Public Class UserInfo
    Private Sub UserInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _client As New Cliente
        Dim dbl As New DatabaseLogin
        Dim dbc As New DatabaseClients

        dbl.readDb(_client)
        dbc.readDb(_client)

        Dim name, nif, pass, work, numc, crdate As String

        name = "Nome: " + _client.Name
        nif = "Nif: " + _client.Nif
        pass = "Senha(Encriptada): " + _client.Password
        numc = "Numero de conta: " + _client.AccountNumber
        work = "Emprego: " + _client.WorkType
        crdate = "Data de criação: " + _client.Creationdate

        DataLB.Items.Add(name)
        DataLB.Items.Add(nif)
        DataLB.Items.Add(pass)
        DataLB.Items.Add(numc)
        DataLB.Items.Add(work)
        DataLB.Items.Add(crdate)
    End Sub
End Class