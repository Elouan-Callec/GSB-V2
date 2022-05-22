Public Class SelectionVisiteur
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader

    Dim connString As String

    Private Sub SelectionVisiteur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim login As String = BDD.afficheLogin()

        'Affichage du nom
        Labelnom.Text = BDD.afficheNom(login)

        'Affichage du prenom
        Labelprenom.Text = BDD.affichePrenom(login)

        'Affichage de la hierarchie
        LabelHierarchie.Text = BDD.afficheHierarchie(login)

        Dim donnees = BDD.SelectionNomVisiteur(login)

        For Each donnee As String In donnees
            ComboBoxChoixVisiteur.Items.Add(donnee)
            Me.ComboBoxChoixVisiteur.Text = Me.ComboBoxChoixVisiteur.Items(0).ToString()
        Next


    End Sub

    Private Sub ValiderCompteRendu_Click(sender As Object, e As EventArgs) Handles ValiderCompteRendu.Click
        SelectionCompteRenduDuVisiteur.Show()
        Me.Close()
    End Sub
End Class