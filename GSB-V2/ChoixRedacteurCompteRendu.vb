Public Class ChoixRedacteurCompteRendu

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader

    Dim connString As String

    Private Sub ChoixRedacteurCompteRendu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim login As String = BDD.afficheLogin()

        'Affichage du nom
        Labelnom.Text = BDD.afficheNom(login)

        'Affichage du prenom
        Labelprenom.Text = BDD.affichePrenom(login)

        'Affichage de la hierarchie
        LabelHierarchie.Text = BDD.afficheHierarchie(login)

    End Sub

    Private Sub BoutonAffichage_Click(sender As Object, e As EventArgs) Handles BoutonAffichage.Click
        SelectionCompteRendu.Show()
        Me.Close()
    End Sub

    Private Sub BoutonModifier_Click(sender As Object, e As EventArgs) Handles BoutonModifier.Click
        SelectionVisiteur.Show()
        Me.Close()
    End Sub
End Class