Public Class InterfaceDelegueregional
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim testprenom As String = "JONES"
    Dim testnom As String = "JONES"


    Function Connection(codesql)
        Dim connString As String = "DSN=CNXORA06;Uid=SCOTT;Pwd=TIGER;"
        myConnection.ConnectionString = connString
        myConnection.Open()
        myCommand.Connection = myConnection
        myCommand.CommandText = codesql
        myReader = myCommand.ExecuteReader
        myReader.Read()
    End Function


    Private Sub InterfaceDelegueregional_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connString As String = "DSN=CNXORA06;Uid=SCOTT;Pwd=TIGER;"
        myConnection.ConnectionString = connString
        myConnection.Open()



        Dim SQLaffichePrenom As String = "SELECT ename FROM emp WHERE login ='JONES';"

        myCommand.Connection = myConnection
        'Connection(SQLaffichePrenom)
        myCommand.CommandText = SQLaffichePrenom
        myReader = myCommand.ExecuteReader
        myReader.Read()

        Labelprenom.Text = myReader.GetValue(0)
        Labelnom.Text = "Test"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RedigerCompteRendu.Show()
        Me.Close()
    End Sub

    Private Sub Buttonredigercompterendu_Click(sender As Object, e As EventArgs) Handles Buttonredigercompterendu.Click
        AfficheDelegueregional.Show()
        Me.Close()

    End Sub
End Class