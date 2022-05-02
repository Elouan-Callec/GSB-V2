Public Class ProfilVisiteurMedical

    Private Sub ProfilVisiteurMedical_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LabelNom.Text = FormulaireConnexion.TextBoxlogin.Text
    End Sub


End Class