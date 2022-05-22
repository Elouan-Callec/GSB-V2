Public Class RedactionCompteRendu
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ProfilDelegueregional.Show()
        Me.Hide()
    End Sub

    Private Sub RedactionCompteRendu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim login As String = BDD.afficheLogin()

        'Affichage du nom
        LabelNom.Text = BDD.afficheNom(login)

        'Affichage du prenom
        Labelprenom.Text = BDD.affichePrenom(login)

        'Affichage de la hierarchie
        LabelHierarchie.Text = BDD.afficheHierarchie(login)
    End Sub
End Class