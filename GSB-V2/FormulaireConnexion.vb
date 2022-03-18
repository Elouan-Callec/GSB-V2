Public Class FormulaireConnexion

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String

    Private Sub FormulaireConnexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connString = "DSN=CNXORA06;Uid=SCOTT;Pwd=TIGER;"

        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
            MessageBox.Show("Connexion réussie")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim login As String = TextBoxlogin.Text
        Dim password As String = TextBoxmotdepasse.Text

        Dim query As String = "SELECT count(*) FROM emp WHERE ename = '" + password + "' AND login = '" + login + "';"
        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader

        myReader.Read()
        If (myReader.GetString(0) = 1) Then
            MessageBox.Show("Connexion réussie")
        Else
            MessageBox.Show("Connexion échouée")
        End If
    End Sub
End Class