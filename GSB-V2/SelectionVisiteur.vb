Public Class SelectionVisiteur
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader

    Dim connString As String

    Private Sub SelectionVisiteur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connString = "DSN=CNXORA06;Uid=SYSTEM;Pwd=Iroise29;"
        myConnection.ConnectionString = connString
        myConnection.Open()

        Dim login As String = FormulaireConnexion.TextBoxLogin.Text

        myCommand.Connection = myConnection

        'Affichage du nom de l utilisateur
        Dim SQLafficheNom As String = "SELECT nom FROM VISITEUR WHERE login = '" + login + "';"
        myCommand.CommandText = SQLafficheNom
        myReader = myCommand.ExecuteReader
        myReader.Read()
        Labelnom.Text = myReader.GetValue(0)
        myReader.Close()

        'Affichage du prenom de l utilisateur
        Dim SQLaffichePrenom As String = "SELECT prenom FROM VISITEUR WHERE login = '" + login + "';"
        myCommand.CommandText = SQLaffichePrenom
        myReader = myCommand.ExecuteReader
        myReader.Read()
        Labelprenom.Text = myReader.GetValue(0)
        myReader.Close()

        'Affichage de la hiérarchie de l utilisateur
        Dim SQLafficheHierarchie As String = "SELECT nomrole FROM ROLE INNER JOIN VISITEUR ON VISITEUR.role = ROLE.idrole WHERE VISITEUR.login = '" + login + "';"
        myCommand.CommandText = SQLafficheHierarchie
        myReader = myCommand.ExecuteReader
        myReader.Read()
        LabelHierarchie.Text = myReader.GetValue(0)
        myReader.Close()

        Dim SQLSecteur As String = "SELECT id_secteur FROM VISITEUR where LOGIN ='" & login & "';"

        'AffichageVisiteur 
        myCommand.CommandText = SQLSecteur
        myReader = myCommand.ExecuteReader
        myReader.Read()
        Dim secteur = myReader.GetValue(0)
        myReader.Close()

        Dim SQLafficheVisiteur As String = "SELECT nom FROM VISITEUR WHERE id_secteur =" & secteur & ";"

        myCommand.CommandText = SQLafficheVisiteur
        myReader = myCommand.ExecuteReader
        While myReader.Read()
            ComboBoxChoixVisiteur.Items.Add(myReader.GetString(0))
            Me.ComboBoxChoixVisiteur.Text = Me.ComboBoxChoixVisiteur.Items(0).ToString()
        End While

        myReader.Close()

    End Sub

    Private Sub ValiderCompteRendu_Click(sender As Object, e As EventArgs) Handles ValiderCompteRendu.Click
        SelectionCompteRenduDuVisiteur.Show()
        Me.Close()
    End Sub
End Class