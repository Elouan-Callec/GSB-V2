Public Class RedactionCompteRendu
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ProfilDelegueregional.Show()
        Me.Hide()
    End Sub

    Private Sub RedactionCompteRendu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim login As String = BDD.afficheLogin()
        Dim dte = ProfilVisiteurMedical.ComboBoxCompteRendu.Text.Substring(16, 10)
        dte = dte.Remove(7, 2)

        'Affichage du nom
        LabelNom.Text = BDD.afficheNom(login)

        'Affichage du prenom
        Labelprenom.Text = BDD.affichePrenom(login)

        'Affichage de la hierarchie
        LabelHierarchie.Text = BDD.afficheHierarchie(login)

        'Affichage des motifs
        Dim donneesMotifs = BDD.SelectionMotifs()

        For Each donneeMotif As String In donneesMotifs
            ComboBoxMotif.Items.Add(donneeMotif)
            Me.ComboBoxMotif.Text = Me.ComboBoxMotif.Items(0).ToString()
        Next

        'Affichage des medicaments
        Dim donneesMedicaments = BDD.SelectionMedicaments()

        For Each donneeMedicament As String In donneesMedicaments
            ComboBoxMedicament.Items.Add(donneeMedicament)
            Me.ComboBoxMedicament.Text = Me.ComboBoxMedicament.Items(0).ToString()
        Next

        'Affichage des medecins
        Dim donneesMedecins = BDD.SelectionMedecins()

        For Each donneeMedecin As String In donneesMedecins
            ComboBoxMedecin.Items.Add(donneeMedecin)
            Me.ComboBoxMedecin.Text = Me.ComboBoxMedecin.Items(0).ToString()
        Next
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim login As String = BDD.afficheLogin()
        Dim idVisiteur = BDD.afficheIdVisiteur(login)
        Dim DateChoisi As Date = DateTimePicker.Text.ToString()

        Dim MotifChoisi = ComboBoxMotif.Text
        MotifChoisi = BDD.SelectionIdMotif(MotifChoisi)

        Dim MedicamentChoisi = ComboBoxMedicament.Text
        MedicamentChoisi = BDD.SelectionIdMedicament(MedicamentChoisi)

        Dim QteEchantillonChoisi = TextBoxEchantillon.Text

        Dim MedecinChoisi = ComboBoxMedecin.Text
        MedecinChoisi = BDD.SelectionIdMedecin(MedecinChoisi)

        Dim BilanChoisi = TextBoxBilan.Text

        Try
            BDD.InsertionCompteRendu(MedecinChoisi, idVisiteur, BilanChoisi, DateChoisi, QteEchantillonChoisi, MedicamentChoisi, MotifChoisi)
            MessageBox.Show("Insertion réussie")
            ProfilVisiteurMedical.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Insertion échouée : " & ex.Message)
            ProfilVisiteurMedical.Show()
            Me.Close()
        End Try
    End Sub
End Class