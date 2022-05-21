Public Class ChoixRedacteurCompteRendu

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader

    Dim connString As String

    Private Sub ChoixRedacteurCompteRendu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        LabelHierarchie.Text = myReader.GetValue(0)
        myReader.Close()

    End Sub

    Private Sub BoutonAffichage_Click(sender As Object, e As EventArgs) Handles BoutonAffichage.Click
        SelectionCompteRendu.Show()
        Me.Close()
    End Sub

    Private Sub BoutonModifier_Click(sender As Object, e As EventArgs) Handles BoutonModifier.Click
        SelectionCompteRenduDuVisiteur.Show()
        Me.Close()
    End Sub
End Class