Public Class ClassConnexion
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String

    Private _login As String = FormulaireConnexion.TextBoxLogin.Text
    Private _nom As String
    Private _prenom As String
    Private _hierarchie As String





    Public Property Login As String
        Get
            Return _login
        End Get
        Set(value As String)
            _login = value
        End Set
    End Property

    Public Property Nom As String
        Get
            Return _nom
        End Get
        Set(value As String)
            _nom = value
        End Set
    End Property

    Public Property Prenom As String
        Get
            Return _prenom
        End Get
        Set(value As String)
            _prenom = value
        End Set
    End Property

    Public Property Hierarchie As String
        Get
            Return _hierarchie
        End Get
        Set(value As String)
            _hierarchie = value
        End Set
    End Property

    Public Sub New(login As String, nom As String, prenom As String, hierarchie As String)
        Me.Login = login
        Me.Nom = nom
        Me.Prenom = prenom
        Me.Hierarchie = hierarchie
    End Sub

End Class
