Public Class AffichageCompteRendu
    Private Sub AffichageCompteRendu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (SelectionCompteRenduDuVisiteur.ValeurBouton1 = 1) Then
            Dim login As String = BDD.afficheLogin()
            Dim idVisiteur = BDD.afficheIdVisiteur(login)

            Dim dte = SelectionCompteRenduDuVisiteur.ComboBoxCompteRendu.Text.Substring(16, 10)
            dte = dte.Remove(7, 2)
            Dim datefinal As DateTime = dte
            Dim ID = BDD.RecuperationIDCompteRendu(idVisiteur, datefinal)
            Dim Bilan = BDD.AfficheBilan(ID)
            Dim QTE_Medoc = BDD.AfficheQTE_Medoc(ID)
            Dim Medicament = BDD.AfficheMedicament(ID)
            Dim Motif = BDD.AfficheMotifduCompteRendu(ID)
            Dim Medecin = BDD.AfficheMedecinduCompteRendu(ID)

            'Affichage du nom
            LabelNom.Text = BDD.afficheNom(login)

            'Affichage du prenom
            Labelprenom.Text = BDD.affichePrenom(login)

            'Affichage de la hierarchie
            LabelHierarchie.Text = BDD.afficheHierarchie(login)
            Dim visiteur = SelectionCompteRenduDuVisiteur.UtilisateurSelect

            LabelVisiteurSelectionner.Text = visiteur

        Else
            Dim login As String = BDD.afficheLogin()
            Dim idVisiteur = BDD.afficheIdVisiteur(login)
            Dim dte = ProfilVisiteurMedical.ComboBoxCompteRendu.Text.Substring(16, 10)
            dte = dte.Remove(7, 2)
            Dim datefinal As DateTime = dte
            Dim ID = BDD.RecuperationIDCompteRendu(idVisiteur, datefinal)
            Dim Bilan = BDD.AfficheBilan(ID)
            Dim QTE_Medoc = BDD.AfficheQTE_Medoc(ID)
            Dim Medicament = BDD.AfficheMedicament(ID)
            Dim Motif = BDD.AfficheMotifduCompteRendu(ID)
            Dim Medecin = BDD.AfficheMedecinduCompteRendu(ID)

            'Affichage du nom
            LabelNom.Text = BDD.afficheNom(login)

            'Affichage du prenom
            Labelprenom.Text = BDD.affichePrenom(login)

            'Affichage de la hierarchie
            LabelHierarchie.Text = BDD.afficheHierarchie(login)

            LabelVisiteurSelectionner.Text = ""

            LabelID.Text = ID
            LabelBilan.Text = Bilan
            LabelDte.Text = datefinal
            LabelQTE_Medoc.Text = QTE_Medoc
            LabelMedicament.Text = Medicament
            LabelMotif.Text = Motif
            LabelMedecin.Text = Medecin

        End If
    End Sub
End Class