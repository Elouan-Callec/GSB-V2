Public Class ProfilVisiteurMedical

    Private Sub ProfilVisiteurMedical_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub BoutonAffichage_Click(sender As Object, e As EventArgs) Handles BoutonAffichage.Click
        AffichageCompteRendu.Show()
        Me.Hide()
    End Sub

    Private Sub BoutonModifier_Click(sender As Object, e As EventArgs) Handles BoutonModifier.Click
        ModificationCompteRendu.Show()
        Me.Hide()
    End Sub

    Private Sub BoutonRedigerCompteRendu_Click(sender As Object, e As EventArgs) Handles BoutonRedigerCompteRendu.Click
        RedactionCompteRendu.Show()
        Me.Hide()
    End Sub
End Class