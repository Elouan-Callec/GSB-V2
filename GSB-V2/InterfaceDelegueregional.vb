Public Class InterfaceDelegueregional
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader


    Private Sub InterfaceDelegueregional_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim affichePrenom As String = "SELECT ename FROM emp WHERE login ='JONES';"

        myCommand.Connection = FormulaireConnexion.myConnection
        myCommand.CommandText = affichePrenom
        myReader = myCommand.ExecuteReader()

        'Labelprenom.Text = 
        myReader.Read()


    End Sub
End Class