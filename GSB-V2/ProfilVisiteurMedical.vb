Public Class ProfilVisiteurMedical

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String

    Private Sub ProfilVisiteurMedical_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connString = "DSN=CNXORA06;Uid=SCOTT;Pwd=TIGER;"

        myConnection.ConnectionString = connString
        myConnection.Open()

        Dim login As String = FormulaireConnexion.TextBoxLogin.Text
        Dim password As String = FormulaireConnexion.TextBoxMotDePasse.Text

        Dim query As String = "SELECT ename FROM emp WHERE login = '" + login + "';"

        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader

        myReader.Read()
        Me.LabelNom.Text = myReader.GetString(0)
    End Sub


End Class