Public Class ProfilVisiteurMedical

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String

    Private Sub ProfilVisiteurMedical_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim login As String = BDD.afficheLogin()

        'Affichage du nom
        Labelnom.Text = BDD.afficheNom(login)

        'Affichage du prenom
        Labelprenom.Text = BDD.affichePrenom(login)

        'Affichage de la hierarchie
        LabelHierarchie.Text = BDD.afficheHierarchie(login)

        'Recuperation de l id de l'utilisateur
        Dim SQLrecupIdVisiteur As String = "SELECT idvis FROM VISITEUR WHERE VISITEUR.login = '" + login + "';"
        myCommand.CommandText = SQLrecupIdVisiteur
        myReader = myCommand.ExecuteReader
        myReader.Read()
        Dim IdVisiteur As Integer = myReader.GetValue(0)
        myReader.Close()

        'Affichage du numero du compte rendu dans la liste deroulante
        Dim SQLafficheDateCompteRendu As String = "SELECT DTE FROM COMPTE_RENDU WHERE visiteur = '" & IdVisiteur & "'Order by DTE DESC;"
        myCommand.CommandText = SQLafficheDateCompteRendu
        myReader = myCommand.ExecuteReader
        While myReader.Read()
            Dim AfficheDate As Date = myReader.GetString(0)
            ComboBoxCompteRendu.Items.Add("Compte rendu du " & AfficheDate)
            Me.ComboBoxCompteRendu.Text = Me.ComboBoxCompteRendu.Items(0).ToString()
        End While
        myReader.Close()

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