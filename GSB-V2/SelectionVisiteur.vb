Public Class SelectionVisiteur
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader

    Dim connString As String

    Private Sub SelectionVisiteur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim login As String = BDD.afficheLogin()
        Dim SQLSecteur As String = "SELECT id_secteur FROM VISITEUR where LOGIN ='" & login & "';"

        'Affichage du nom
        Labelnom.Text = BDD.afficheNom(login)

        'Affichage du prenom
        Labelprenom.Text = BDD.affichePrenom(login)

        'Affichage de la hierarchie
        LabelHierarchie.Text = BDD.afficheHierarchie(login)

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