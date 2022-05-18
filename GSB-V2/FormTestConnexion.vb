
Public Class FormTestConnexion

    Dim MaConnexion As New ClassConnexion()

    Private Sub FormTestConnexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = MaConnexion.Login
        Label2.Text = MaConnexion.Nom
        Label3.Text = MaConnexion.Prenom
        Label4.Text = MaConnexion.Hierarchie
    End Sub

End Class