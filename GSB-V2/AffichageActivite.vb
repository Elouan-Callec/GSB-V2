Public Class AffichageActivite
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader

    Private Sub AffichageActivite_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Connexion
        Dim connString As String = "DSN=CNXORA06;Uid=SYSTEM;Pwd=Iroise29;"
        myConnection.ConnectionString = connString
        myConnection.Open()

        Dim login As String = ProfilDelegueregional.login

        Dim SQLafficheNom As String = "SELECT nom FROM VISITEUR WHERE login = '" & login & "';"
        Dim SQLaffichePrenom As String = "SELECT prenom FROM VISITEUR WHERE login = '" & login & "';"
        Dim SQLafficheHierarchie As String = "SELECT nomrole FROM ROLE INNER JOIN VISITEUR ON VISITEUR.ROLE = ROLE.IDROLE where visiteur.login = '" & login & "';"

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
        LabelHierarchie.Text = myReader.GetValue(0)
        myReader.Close()


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProfilDelegueregional.Show()
        Me.Hide()
    End Sub
End Class