Public Class ProfilVisiteurMedical

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String

    Private Sub ProfilVisiteurMedical_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connString = "DSN=CNXORA06;Uid=SYSTEM;Pwd=Iroise29;"
        myConnection.ConnectionString = connString
        myConnection.Open()

        Dim login As String = FormulaireConnexion.TextBoxLogin.Text

        myCommand.Connection = myConnection

        'Affichage du nom de l utilisateur
        Dim SQLafficheNom As String = "SELECT nom FROM VISITEUR WHERE login = '" + login + "';"
        myCommand.CommandText = SQLafficheNom
        myReader = myCommand.ExecuteReader
        myReader.Read()
        Labelnom.Text = myReader.GetValue(0)
        myReader.Close()

        'Affichage du prenom de l utilisateur
        Dim SQLaffichePrenom As String = "SELECT prenom FROM VISITEUR WHERE login = '" + login + "';"
        myCommand.CommandText = SQLaffichePrenom
        myReader = myCommand.ExecuteReader
        myReader.Read()
        Labelprenom.Text = myReader.GetValue(0)
        myReader.Close()

        'Affichage de la hiérarchie de l utilisateur
        Dim SQLafficheHierarchie As String = "SELECT nomrole FROM ROLE INNER JOIN VISITEUR ON VISITEUR.role = ROLE.idrole WHERE VISITEUR.login = '" + login + "';"
        myCommand.CommandText = SQLafficheHierarchie
        myReader = myCommand.ExecuteReader
        myReader.Read()
        LabelAffichageHierarchie.Text = myReader.GetValue(0)
        myReader.Close()

        'Recuperation de l id de l'utilisateur
        Dim SQLrecupIdVisiteur As String = "SELECT idvis FROM VISITEUR WHERE VISITEUR.login = '" + login + "';"
        myCommand.CommandText = SQLrecupIdVisiteur
        myReader = myCommand.ExecuteReader
        myReader.Read()
        Dim IdVisiteur As Integer = myReader.GetValue(0)
        myReader.Close()

        'Affichage du numero du compte rendu dans la liste deroulante
        'Dim SQLafficheNumeroCompteRendu As Integer = "SELECT id FROM COMPTE_RENDU WHERE visiteur = '" + IdVisiteur + "';"
        Dim SQLafficheNumeroCompteRendu As String = "SELECT id FROM COMPTE_RENDU WHERE visiteur = '" & IdVisiteur & "'"
        myCommand.CommandText = SQLafficheNumeroCompteRendu
        myReader = myCommand.ExecuteReader
        While myReader.Read()
            ComboBoxCompteRendu.Items.Add("Compte rendu n°" & myReader.GetString(0))
            Me.ComboBoxCompteRendu.Text = Me.ComboBoxCompteRendu.Items(0).ToString()
        End While
        myReader.Close()

    End Sub

    Private Sub BoutonAffichage_Click(sender As Object, e As EventArgs) Handles BoutonAffichage.Click
        AffichageCompteRendu.Show()
        Me.Close()
    End Sub

    Private Sub BoutonModifier_Click(sender As Object, e As EventArgs) Handles BoutonModifier.Click
        ModificationCompteRendu.Show()
        Me.Close()
    End Sub

    Private Sub BoutonRedigerCompteRendu_Click(sender As Object, e As EventArgs) Handles BoutonRedigerCompteRendu.Click
        RedactionCompteRendu.Show()
        Me.Close()
    End Sub
End Class