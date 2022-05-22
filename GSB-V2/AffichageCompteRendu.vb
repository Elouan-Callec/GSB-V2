Public Class AffichageCompteRendu
    Private Sub AffichageCompteRendu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim login As String = BDD.afficheLogin()
        Dim idVisiteur = BDD.afficheIdVisiteur(login)
        Dim dte = ProfilVisiteurMedical.ComboBoxCompteRendu.Text.Substring(16, 10)
        dte = dte.Remove(7, 2)
        Dim donnees As String

        'Affichage du nom
        LabelNom.Text = BDD.afficheNom(login)

        'Affichage du prenom
        Labelprenom.Text = BDD.affichePrenom(login)

        'Affichage de la hierarchie
        LabelHierarchie.Text = BDD.afficheHierarchie(login)

        donnees = BDD.AffichageCompteRendu(idVisiteur, dte)

        LabelMedicament.Text = donnees("medecin")
    End Sub
End Class