Public Class SelectionCompteRendu

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader

    Dim connString As String


    Private Sub SelectionCompteRendu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim login As String = BDD.afficheLogin()
        Dim idVisiteur As Integer = BDD.afficheIdVisiteur(login)

        'Affichage du nom
        Labelnom.Text = BDD.afficheNom(login)

        'Affichage du prenom
        Labelprenom.Text = BDD.affichePrenom(login)

        'Affichage de la hierarchie
        LabelHierarchie.Text = BDD.afficheHierarchie(login)

        Dim donnees = BDD.SelectionDateCompteRendu(login, idVisiteur)

        For Each donnee As Date In donnees
            ComboBoxCompteRendu.Items.Add("Compte rendu du " & donnee)
            Me.ComboBoxCompteRendu.Text = Me.ComboBoxCompteRendu.Items(0).ToString()
        Next

    End Sub
    Public ValeurBouton1 As Integer = 0
    Private Sub BoutonAffichage_Click(sender As Object, e As EventArgs) Handles BoutonAffichage.Click
        ValeurBouton1 = 1
        AffichageCompteRendu.Show()
        Me.Close()
    End Sub

    Public ValeurBouton2 As Integer = 0
    Private Sub BoutonModifier_Click(sender As Object, e As EventArgs) Handles BoutonModifier.Click
        ValeurBouton2 = 1
        ModificationCompteRendu.Show()
        Me.Close()
    End Sub
End Class