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

        Dim SQLafficheNom As String = "SELECT nom FROM VISITEUR WHERE login = '" + login + "';"
        Dim SQLaffichePrenom As String = "SELECT prenom FROM VISITEUR WHERE login = '" + login + "';"
        Dim SQLafficheHierarchie As String = "SELECT nomrole FROM ROLE INNER JOIN VISITEUR ON VISITEUR.ROLE = ROLE.IDROLE where visiteur.login = '" + login + "';"

        myCommand.Connection = myConnection

        'AffichageActivite Nom utilisateur
        myCommand.CommandText = SQLafficheNom
        myReader = myCommand.ExecuteReader
        myReader.Read()
        Labelnom.Text = myReader.GetValue(0)
        myReader.Close()

        'AffichageActivite Prenom utilisateur
        myCommand.CommandText = SQLaffichePrenom
        myReader = myCommand.ExecuteReader
        myReader.Read()
        Labelprenom.Text = myReader.GetValue(0)
        myReader.Close()

        'AffichageActivite hiérarchie 
        myCommand.CommandText = SQLafficheHierarchie
        myReader = myCommand.ExecuteReader
        myReader.Read()
        LabelAffichageHierarchie.Text = myReader.GetValue(0)
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