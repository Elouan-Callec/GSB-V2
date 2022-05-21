﻿Public Module BDD
    Public ReadOnly myConnection As New Odbc.OdbcConnection
    Public myCommand As New Odbc.OdbcCommand
    Public myReader As Odbc.OdbcDataReader
    'Public myAdapter As Odbc.OdbcDataAdapter
    'Public myBuilder As Odbc.OdbcCommandBuilder
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
End Module
