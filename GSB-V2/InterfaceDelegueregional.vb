Public Class InterfaceDelegueregional
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim testprenom As String = "JONES"
    Dim testnom As String = "JONESS"


    Private Sub InterfaceDelegueregional_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim affichePrenom As String = "SELECT ename FROM emp WHERE login ='JONES';"

        Labelprenom.Text = testprenom
        Labelnom.Text = testnom

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'AfficheDelegueregional.Show()
        'Me.Close()
        Me.Hide()
        AfficheDelegueregional.Show()
    End Sub
End Class