Public Class SelectionActivite
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader

    Private Sub SelectionActivite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim login As String = BDD.afficheLogin()
        Dim nom As String

        'Affichage du nom
        Labelnom.Text = BDD.afficheNom(login)

        'Affichage du prenom
        Labelprenom.Text = BDD.affichePrenom(login)

        'Affichage de la hierarchie
        LabelHierarchie.Text = BDD.afficheHierarchie(login)

        nom = BDD.SelectionNomVisiteur(login)
        Dim test As String = 0
        While test = nom
            ComboBoxActiviteVisiteur.Items.Add(myReader.GetString(0))
            Me.ComboBoxActiviteVisiteur.Text = Me.ComboBoxActiviteVisiteur.Items(0).ToString()
        End While

    End Sub

    Public ValeurBouton1 As Integer = 0
    Public ValeurBouton2 As Integer = 0
    Public Sub ButtonVisionnerActiviteVisiteur_Click(sender As Object, e As EventArgs) Handles ButtonVisionnerActiviteVisiteur.Click
        ValeurBouton1 = 1
        AffichageActivite.Show()
        Me.Close()
    End Sub

    Public Sub ButtonVisionnerActiviteEquipe_Click(sender As Object, e As EventArgs) Handles ButtonVisionnerActiviteEquipe.Click
        ValeurBouton2 = 1
        AffichageActivite.Show()
        Me.Close()
    End Sub
End Class