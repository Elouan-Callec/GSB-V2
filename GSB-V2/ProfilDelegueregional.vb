Public Class ProfilDelegueregional

    Private Sub InterfaceDelegueregional_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim login As String = BDD.afficheLogin()

        'Affichage du nom
        Labelnom.Text = BDD.afficheNom(login)

        'Affichage du prenom
        Labelprenom.Text = BDD.affichePrenom(login)

        'Affichage de la hierarchie
        LabelHierarchie.Text = BDD.afficheHierarchie(login)
    End Sub

    'Selectionner une activite
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonSelectionActivite.Click
        SelectionActivite.Show()
        Me.Hide()
    End Sub

    'Selectionner un compte rendu 
    Private Sub ButtonVoirCompteRendu_Click(sender As Object, e As EventArgs) Handles ButtonVoirCompteRendu.Click
        ChoixRedacteurCompteRendu.Show()
        Me.Hide()
    End Sub

    'Rediger un compte rendu
    Private Sub ButtonRedigerCompteRendu_Click(sender As Object, e As EventArgs) Handles ButtonRedigerCompteRendu.Click
        AffichageActivite.Show()
        Me.Hide()

    End Sub


End Class