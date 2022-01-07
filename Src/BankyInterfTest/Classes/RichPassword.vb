Public Class RichPassword
    Inherits RichTextBox
    Private Const ES_PASSWORD = 32
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim CP = MyBase.CreateParams
            CP.Style = CP.Style Or 32
            Return CP
        End Get
    End Property
End Class
