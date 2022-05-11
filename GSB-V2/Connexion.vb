Public Class Connexion

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String = "DSN=CNXORA06;Uid=SYSTEM;Pwd=Iroise29;"

    Function Connexion() As String
        myConnection.ConnectionString = connString


        Try
            myConnection.Open()
            Return MessageBox.Show("Connexion réussie")
        Catch ex As Exception
            Return MessageBox.Show(ex.Message)
        End Try
    End Function

End Class
