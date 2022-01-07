
Public Class Startscreen

    Private Sub Startscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbc As New DatabaseClients
        Dim dbm As New DatabaseMoves
        Dim dbl As New DatabaseLogin

        dbl.startDb()
        dbm.startDb()
        dbc.startDb()
    End Sub


    Dim Pos As Point
    Private Sub Startscreen_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login.Show()
        Me.Hide()

    End Sub

End Class