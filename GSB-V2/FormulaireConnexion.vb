Public Class FormulaireConnexion

    Private Sub FormulaireConnexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BDD.connexion()
    End Sub

    Public Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim login As String = TextBoxLogin.Text
        Dim password As String = TextBoxMotDePasse.Text
        Dim resultat As Integer
        Dim resultatReq As Integer

        resultat = BDD.verifIdentification(login, password)

        If (resultat = 1) Then
            MessageBox.Show("Connexion réussie")

            Dim ID_role = "SELECT ROLE FROM VISITEUR WHERE login ='" + login + "';"

            myCommand.CommandText = ID_role
            myReader = myCommand.ExecuteReader
            myReader.Read()

            resultatReq = myReader.GetString(0)
            myReader.Close()

            If (resultatReq = 1) Then
                ProfilVisiteurMedical.Show()
                Me.Hide()
            End If

            If (resultatReq = 2) Then
                ProfilDelegueregional.Show()
                Me.Hide()
            End If

            If (resultatReq = 3) Then

            End If

        Else
            MessageBox.Show("Connexion échouée")
        End If
    End Sub

End Class