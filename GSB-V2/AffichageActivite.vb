Public Class AffichageActivite
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader

    Private Sub AffichageActivite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim login As String = BDD.afficheLogin()
        Dim UtilisateurSelect As String = SelectionActivite.ComboBoxActiviteVisiteur.Text
        Dim SQLafficheNomFonctionSelectionner As String = "SELECT nom FROM VISITEUR WHERE nom ='" & UtilisateurSelect & "';"
        Dim SQLafficheSecteur As String = "SELECT SECTEUR.nom FROM SECTEUR INNER JOIN VISITEUR ON visiteur.id_secteur = secteur.id where visiteur.nom = '" & Labelnom.Text & "';"

        'Affichage du nom
        Labelnom.Text = BDD.afficheNom(login)

        'Affichage du prenom
        Labelprenom.Text = BDD.affichePrenom(login)

        'Affichage de la hierarchie
        LabelHierarchie.Text = BDD.afficheHierarchie(login)


        If (SelectionActivite.ValeurBouton1 = 1) Then

            'AffichageActivite Visiteur 
            myCommand.CommandText = SQLafficheNomFonctionSelectionner
            myReader = myCommand.ExecuteReader
            myReader.Read()
            LabelSelection.Text = myReader.GetValue(0)
            LabelTypeActivité.Text = "Activité du visiteur :"
            myReader.Close()

        ElseIf (SelectionActivite.ValeurBouton2 = 1) Then

            'AffichageActivite Secteur 
            myCommand.CommandText = SQLafficheSecteur
            myReader = myCommand.ExecuteReader
            myReader.Read()
            LabelSelection.Text = myReader.GetValue(0)
            LabelTypeActivité.Text = "Activité du secteur :"
            myReader.Close()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProfilDelegueregional.Show()
        Me.Close()
    End Sub
End Class