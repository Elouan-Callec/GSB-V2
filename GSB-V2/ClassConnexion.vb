Public Class ClassConnexion
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader

    Private _login As String
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


    Public Sub New()

        Dim connString As String = "DSN=CNXORA06;Uid=SYSTEM;Pwd=Iroise29;"
        myConnection.ConnectionString = connString
        myConnection.Open()

        myCommand.Connection = myConnection

        'Affiche Login'
        Me.Login = FormulaireConnexion.TextBoxLogin.Text

        'Affiche Nom'
        Dim SQLafficheNom As String = "SELECT nom FROM VISITEUR WHERE login = '" + Me.Login + "';"

        myCommand.CommandText = SQLafficheNom
        myReader = myCommand.ExecuteReader
        myReader.Read()
        Me.Nom = myReader.GetValue(0)
        myReader.Close()

        'Affiche Prenom'
        Dim SQLaffichePrenom As String = "SELECT prenom FROM VISITEUR WHERE login = '" + Login + "';"

        myCommand.CommandText = SQLaffichePrenom
        myReader = myCommand.ExecuteReader
        myReader.Read()
        Me.Prenom = myReader.GetValue(0)
        myReader.Close()

        'Affiche Hierarchie'
        Dim SQLafficheHierarchie As String = "SELECT nomrole FROM ROLE INNER JOIN VISITEUR ON VISITEUR.ROLE = ROLE.IDROLE where visiteur.login = '" + Login + "';"

        myCommand.CommandText = SQLafficheHierarchie
        myReader = myCommand.ExecuteReader
        myReader.Read()
        Me.Hierarchie = myReader.GetValue(0)
        myReader.Close()


    End Sub

    'Public Sub New(login As String, nom As String, prenom As String, hierarchie As String)
    '    Me.Login = login
    '    Me.Nom = nom
    '    Me.Prenom = prenom
    '    Me.Hierarchie = hierarchie
    'End Sub

    Public Sub New(login As String, nom As String, prenom As String, hierarchie As String)
        Me.Login = login
        Me.Nom = nom
        Me.Prenom = prenom
        Me.Hierarchie = hierarchie
    End Sub

End Class
