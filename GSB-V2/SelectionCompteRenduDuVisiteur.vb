Public Class SelectionCompteRenduDuVisiteur
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader

    Dim connString As String

    Public UtilisateurSelect As String = SelectionVisiteur.ComboBoxChoixVisiteur.Text
    Private Sub SelectionCompteRenduDuVisiteur_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim login As String = BDD.afficheLogin()

        'Dim UtilisateurSelect As String = SelectionVisiteur.ComboBoxChoixVisiteur.Text


        'Affichage du nom
        Labelnom.Text = BDD.afficheNom(login)

        'Affichage du prenom
        Labelprenom.Text = BDD.affichePrenom(login)

        'Affichage de la hierarchie
        LabelHierarchie.Text = BDD.afficheHierarchie(login)

        LabelnomVisiteur.Text = UtilisateurSelect

        'Affichage CompteRenduVisiteurSelect

        Dim donnees = BDD.AffichageCompteRenduDunVisiteurSelectionne(UtilisateurSelect)

        For Each donnee As Date In donnees
            ComboBoxCompteRendu.Items.Add("Compte rendu du " & donnee)
            Me.ComboBoxCompteRendu.Text = Me.ComboBoxCompteRendu.Items(0).ToString()
        Next

    End Sub

    Public ValeurBouton1 As Integer = 0
    Private Sub BoutonAffichage_Click(sender As Object, e As EventArgs) Handles BoutonAffichage.Click
        ValeurBouton1 = 1
        AffichageCompteRendu.Show()
        Me.Hide()
    End Sub
End Class