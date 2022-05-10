Public Class ProfilDelegueregional
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader


    'Function Connection(codesql)
    '    Dim connString As String = "DSN=CNXORA06;Uid=SCOTT;Pwd=TIGER;"
    '    myConnection.ConnectionString = connString
    '    myConnection.Open()
    '    myCommand.Connection = myConnection
    '    myCommand.CommandText = codesql
    '    myReader = myCommand.ExecuteReader
    '    myReader.Read()
    'End Function


    Private Sub InterfaceDelegueregional_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connString As String = "DSN=CNXORA06;Uid=SYSTEM;Pwd=Iroise29;"
        myConnection.ConnectionString = connString
        myConnection.Open()

        Dim login As String = FormulaireConnexion.TextBoxLogin.Text

        Dim SQLafficheNom As String = "SELECT nom FROM VISITEUR WHERE login = '" + login + "';"
        Dim SQLaffichePrenom As String = "SELECT prenom FROM VISITEUR WHERE login = '" + login + "';"
        Dim SQLafficheHierarchie As String = "SELECT nomrole FROM ROLE INNER JOIN VISITEUR ON VISITEUR.ROLE = ROLE.IDROLE where visiteur.login = '" + login + "';"

        myCommand.Connection = myConnection


        'AffichageActivite Nom utilisateur
        myCommand.CommandText = SQLafficheNom
        myReader = myCommand.ExecuteReader
        myReader.Read()
        Labelnom.Text = myReader.GetValue(0)
        myReader.Close()

        'AffichageActivite Prenom utilisateur
        myCommand.CommandText = SQLaffichePrenom
        myReader = myCommand.ExecuteReader
        myReader.Read()
        Labelprenom.Text = myReader.GetValue(0)
        myReader.Close()

        'AffichageActivite hiérarchie 
        myCommand.CommandText = SQLaffichePrenom
        myReader = myCommand.ExecuteReader
        myReader.Read()
        Labelprenom.Text = myReader.GetValue(0)
        myReader.Close()




    End Sub

    'Selectionner une activite
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonSelectionActivite.Click
        SelectionActivite.Show()
        Me.Close()
    End Sub

    'Selectionner un compte rendu 
    Private Sub ButtonVoirCompteRendu_Click(sender As Object, e As EventArgs) Handles ButtonVoirCompteRendu.Click
        ChoixRedacteurCompteRendu.Show()
        Me.Close()
    End Sub


    'Rediger un compte rendu
    Private Sub ButtonRedigerCompteRendu_Click(sender As Object, e As EventArgs) Handles ButtonRedigerCompteRendu.Click
        AffichageActivite.Show()
        Me.Close()

    End Sub


End Class