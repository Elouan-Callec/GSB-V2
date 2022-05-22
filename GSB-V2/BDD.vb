Module BDD
    Public ReadOnly myConnection As New Odbc.OdbcConnection
    Public myCommand As New Odbc.OdbcCommand
    Public myReader As Odbc.OdbcDataReader
    Dim connString As String

    Public Sub connexion()
        connString = "DSN=CNXORA06;Uid=SYSTEM;Pwd=Iroise29;"
        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
            MessageBox.Show("Connexion réussie")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Verification des informations de connexion
    Public Function verifIdentification(login, password)
        Dim query As String = "SELECT count(*) FROM VISITEUR WHERE login = '" + login + "' AND password = '" + password + "';"
        Dim resultat As Integer

        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader
        myReader.Read()

        resultat = myReader.GetString(0)
        myReader.Close()

        Return resultat
    End Function

    'Affichage du login
    Public Function afficheLogin() As String
        Dim login As String = FormulaireConnexion.TextBoxLogin.Text
        Return login
    End Function

    'Affichage de l id
    Public Function afficheIdVisiteur(login) As Integer
        Dim SQLrecupIdVisiteur As String = "SELECT idvis FROM VISITEUR WHERE VISITEUR.login = '" + login + "';"
        Dim IdVisiteur As Integer

        myCommand.CommandText = SQLrecupIdVisiteur
        myReader = myCommand.ExecuteReader
        myReader.Read()

        IdVisiteur = myReader.GetValue(0)
        myReader.Close()

        Return IdVisiteur
    End Function

    'Affichage du nom
    Public Function afficheNom(login) As String
        Dim nom As String
        Dim sqlAfficheNom As String = "select nom from visiteur where login = '" & login & "';"

        myCommand.Connection = myConnection
        myCommand.CommandText = sqlAfficheNom
        myReader = myCommand.ExecuteReader()
        myReader.Read()

        nom = myReader.GetValue(0)
        myReader.Close()

        Return nom
    End Function

    'Affichage du prenom
    Public Function affichePrenom(login) As String
        Dim prenom As String
        Dim sqlAffichePrenom As String = "select prenom from visiteur where login = '" & login & "';"

        myCommand.Connection = myConnection
        myCommand.CommandText = sqlAffichePrenom
        myReader = myCommand.ExecuteReader()
        myReader.Read()

        prenom = myReader.GetValue(0)
        myReader.Close()

        Return prenom
    End Function

    'Affichage hierarchie
    Public Function afficheHierarchie(login)
        Dim hierarchie As String
        Dim sqlAfficheHierarchie As String = "SELECT nomrole FROM ROLE INNER JOIN VISITEUR ON VISITEUR.ROLE = ROLE.IDROLE where visiteur.login = '" & login & "';"

        myCommand.Connection = myConnection
        myCommand.CommandText = sqlAfficheHierarchie
        myReader = myCommand.ExecuteReader()
        myReader.Read()

        hierarchie = myReader.GetValue(0)
        myReader.Close()

        Return hierarchie
    End Function

    'Selection du nom des visiteurs
    Public Function SelectionNomVisiteur(login)
        Dim SQLSecteur As String = "SELECT id_secteur FROM VISITEUR where LOGIN ='" & login & "';"
        Dim donnees As New List(Of String)

        'Recuperation du secteur
        myCommand.CommandText = SQLSecteur
        myReader = myCommand.ExecuteReader
        myReader.Read()

        Dim secteur = myReader.GetValue(0)
        myReader.Close()

        'Recuperation du nom du visiteur
        Dim SQLafficheVisiteur As String = "SELECT nom FROM VISITEUR WHERE id_secteur =" & secteur & ";"
        myCommand.Connection = myConnection
        myCommand.CommandText = SQLafficheVisiteur
        myReader = myCommand.ExecuteReader()

        While myReader.Read()
            donnees.Add(myReader.GetString(0))
        End While

        myReader.Close()

        Return donnees
    End Function

    'Selection de la date des comptes rendus
    Public Function SelectionDateCompteRendu(login, idVisiteur)
        Dim donnees As New List(Of String)
        Dim SQLafficheDateCompteRendu As String = "SELECT DTE FROM COMPTE_RENDU WHERE visiteur = '" & idVisiteur & "'Order by DTE DESC;"

        myCommand.CommandText = SQLafficheDateCompteRendu
        myReader = myCommand.ExecuteReader

        While myReader.Read()
            donnees.Add(myReader.GetString(0))
        End While

        myReader.Close()

        Return donnees
    End Function

    'Affichage du compte rendu
    Public Function AffichageCompteRendu(idVisiteur, dte)
        Dim donnees
        Dim SQLafficheCompteRendu As String = "SELECT id FROM compte_rendu WHERE visiteur = '" & idVisiteur & "' AND dte = '" & dte & "';"

        myCommand.Connection = myConnection
        myCommand.CommandText = SQLafficheCompteRendu
        myReader = myCommand.ExecuteReader()
        myReader.Read()

        donnees = myReader.GetValue(0)
        myReader.Close()

        Return donnees
    End Function
End Module
