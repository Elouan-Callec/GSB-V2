Module BDD
    Public ReadOnly myConnection As New Odbc.OdbcConnection
    Public myCommand As New Odbc.OdbcCommand
    Public myReader As Odbc.OdbcDataReader
    Dim connString As String

    Public Sub connexion()
        connString = "DSN=CNXORA06;Uid=SYSTEM;Pwd=Iroise29;"
        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
            MessageBox.Show("Connexion réussie")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    'Verification des informations de connexion
    Public Function verifIdentification(login, password)
        Dim query As String = "SELECT count(*) FROM VISITEUR WHERE login = '" + login + "' AND password = '" + password + "';"
        Dim resultat As Integer

        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader
        myReader.Read()

        resultat = myReader.GetString(0)
        myReader.Close()

        Return resultat
    End Function


    'Affichage du login
    Public Function afficheLogin() As String
        Dim login As String = FormulaireConnexion.TextBoxLogin.Text
        Return login
    End Function


    'Affichage de l id
    Public Function afficheIdVisiteur(login) As Integer
        Dim SQLrecupIdVisiteur As String = "SELECT idvis FROM VISITEUR WHERE VISITEUR.login = '" + login + "';"
        Dim IdVisiteur As Integer

        myCommand.CommandText = SQLrecupIdVisiteur
        myReader = myCommand.ExecuteReader
        myReader.Read()

        IdVisiteur = myReader.GetValue(0)
        myReader.Close()

        Return IdVisiteur
    End Function


    'Affichage du nom
    Public Function afficheNom(login) As String
        Dim nom As String
        Dim sqlAfficheNom As String = "select nom from visiteur where login = '" & login & "';"

        myCommand.Connection = myConnection
        myCommand.CommandText = sqlAfficheNom
        myReader = myCommand.ExecuteReader()
        myReader.Read()

        nom = myReader.GetValue(0)
        myReader.Close()

        Return nom
    End Function


    'Affichage du prenom
    Public Function affichePrenom(login) As String
        Dim prenom As String
        Dim sqlAffichePrenom As String = "select prenom from visiteur where login = '" & login & "';"

        myCommand.Connection = myConnection
        myCommand.CommandText = sqlAffichePrenom
        myReader = myCommand.ExecuteReader()
        myReader.Read()

        prenom = myReader.GetValue(0)
        myReader.Close()

        Return prenom
    End Function


    'Affichage hierarchie
    Public Function afficheHierarchie(login)
        Dim hierarchie As String
        Dim sqlAfficheHierarchie As String = "SELECT nomrole FROM ROLE INNER JOIN VISITEUR ON VISITEUR.ROLE = ROLE.IDROLE where visiteur.login = '" & login & "';"

        myCommand.Connection = myConnection
        myCommand.CommandText = sqlAfficheHierarchie
        myReader = myCommand.ExecuteReader()
        myReader.Read()

        hierarchie = myReader.GetValue(0)
        myReader.Close()

        Return hierarchie
    End Function


    'Selection du nom des visiteurs
    Public Function SelectionNomVisiteur(login)
        Dim SQLSecteur As String = "SELECT id_secteur FROM VISITEUR where LOGIN ='" & login & "';"
        Dim donnees As New List(Of String)

        'Recuperation du secteur
        myCommand.CommandText = SQLSecteur
        myReader = myCommand.ExecuteReader
        myReader.Read()

        Dim secteur = myReader.GetValue(0)
        myReader.Close()

        'Recuperation du nom du visiteur
        Dim SQLafficheVisiteur As String = "SELECT nom FROM VISITEUR WHERE id_secteur =" & secteur & ";"
        myCommand.Connection = myConnection
        myCommand.CommandText = SQLafficheVisiteur
        myReader = myCommand.ExecuteReader()

        While myReader.Read()
            donnees.Add(myReader.GetString(0))
        End While

        myReader.Close()

        Return donnees
    End Function


    'Selection de la date des comptes rendus
    Public Function SelectionDateCompteRendu(login, idVisiteur)
        Dim donnees As New List(Of String)
        Dim SQLafficheDateCompteRendu As String = "SELECT DTE FROM COMPTE_RENDU WHERE visiteur = '" & idVisiteur & "'Order by DTE DESC;"

        myCommand.CommandText = SQLafficheDateCompteRendu
        myReader = myCommand.ExecuteReader

        While myReader.Read()
            donnees.Add(myReader.GetString(0))
        End While

        myReader.Close()

        Return donnees
    End Function


    'Recuperation ID CompteRendu
    Public Function RecuperationIDCompteRendu(idVisiteur, dte)
        Dim donnees
        Dim SQL As String = "SELECT id FROM compte_rendu WHERE visiteur = '" & idVisiteur & "' AND dte = TO_DATE('" & dte & "','DD/MM/YY');"

        myCommand.Connection = myConnection
        myCommand.CommandText = SQL
        myReader = myCommand.ExecuteReader()
        myReader.Read()

        donnees = myReader.GetValue(0)
        myReader.Close()

        Return donnees
    End Function


    'Affichage du compte rendu
    Public Function AffichageCompteRendu(idVisiteur, dte)

        Dim donnees
        Dim SQL As String = "SELECT id FROM compte_rendu WHERE visiteur = '" & idVisiteur & "' AND dte = TO_DATE('" & dte & "','DD/MM/YY');"

        myCommand.Connection = myConnection
        myCommand.CommandText = SQL
        myReader = myCommand.ExecuteReader()
        myReader.Read()

        donnees = myReader.GetValue(0)
        myReader.Close()

        Return donnees
    End Function


    'Affichage Bilandesc du CompteRENDU
    Public Function AfficheBilan(idCompteRendu)
        Dim donnees
        Dim SQL As String = "SELECT bilandesc FROM compte_rendu WHERE ID = " & idCompteRendu & ";"

        myCommand.Connection = myConnection
        myCommand.CommandText = SQL
        myReader = myCommand.ExecuteReader()
        myReader.Read()

        donnees = myReader.GetValue(0)
        myReader.Close()

        Return donnees
    End Function

    'Affichage QTE_MEDOC du CompteRENDU
    Public Function AfficheQTE_Medoc(idCompteRendu)
        Dim donnees
        Dim SQL As String = "SELECT QTE_MEDOC FROM compte_rendu WHERE ID = " & idCompteRendu & ";"

        myCommand.Connection = myConnection
        myCommand.CommandText = SQL
        myReader = myCommand.ExecuteReader()
        myReader.Read()

        donnees = myReader.GetValue(0)
        Return donnees
    End Function


    'Selection des motifs
    Public Function SelectionMotifs(login, dte)
        Dim donnees As New List(Of String)
        Dim SQLselectionMotifs As String = "SELECT nom FROM motif"

        myCommand.CommandText = SQLselectionMotifs
        myReader = myCommand.ExecuteReader

        While myReader.Read()
            donnees.Add(myReader.GetString(0))
        End While


        myReader.Close()

        Return donnees
    End Function


    'Affichage Medicament du CompteRENDU
    Public Function AfficheMedicament(idCompteRendu)
        Dim donnees
        Dim SQL As String = "SELECT Medic FROM compte_rendu WHERE ID = " & idCompteRendu & ";"

        myCommand.Connection = myConnection
        myCommand.CommandText = SQL
        myReader = myCommand.ExecuteReader()
        myReader.Read()

        donnees = myReader.GetValue(0)
        myReader.Close()

        Return donnees
    End Function

    'AffichageMotif du CompteRENDU
    Public Function AfficheMotifduCompteRendu(idCompteRendu)
        Dim donnees
        Dim SQL As String = "SELECT Motif.nom FROM Motif INNER JOIN COMPTE_RENDU ON COMPTE_RENDU.MOTIF = Motif.id WHERE COMPTE_RENDU.ID = " & idCompteRendu & ";"

        myCommand.Connection = myConnection
        myCommand.CommandText = SQL
        myReader = myCommand.ExecuteReader()
        myReader.Read()

        donnees = myReader.GetValue(0)
        myReader.Close()

    End Function


    'Selection du nom des motifs
    Public Function SelectionMotifs()
        Dim donnees As New List(Of String)
        Dim SQLselectionMotifs As String = "SELECT nom FROM motif"

        myCommand.CommandText = SQLselectionMotifs
        myReader = myCommand.ExecuteReader

        While myReader.Read()
            donnees.Add(myReader.GetString(0))
        End While


        myReader.Close()

        Return donnees
    End Function


    'AffichageMedecin du CompteRendu
    Public Function AfficheMedecinduCompteRendu(idCompteRendu)
        Dim donnees
        Dim SQL As String = "SELECT Medecin.nom FROM Medecin INNER JOIN COMPTE_RENDU ON COMPTE_RENDU.Medecin = Medecin.id WHERE COMPTE_RENDU.ID = " & idCompteRendu & ";"

        myCommand.Connection = myConnection
        myCommand.CommandText = SQL
        myReader = myCommand.ExecuteReader()
        myReader.Read()

        donnees = myReader.GetValue(0)
        myReader.Close()

        Return donnees
    End Function

    'Recuperation ID visiteur Selectionné

    Public Function RecuperationIDVisiteurSelect(nom)
        Dim donnees
        Dim SQL As String = "SELECT Compte_rendu.visiteur FROM Compte_rendu INNER JOIN VISITEUR ON VISITEUR.idvis = Compte_rendu.visiteur WHERE Visiteur.nom = '" & nom & "';"

        myCommand.Connection = myConnection
        myCommand.CommandText = SQL
        myReader = myCommand.ExecuteReader()
        myReader.Read()

        donnees = myReader.GetValue(0)
        myReader.Close()

        Return donnees
    End Function



    'Fonction specifique a AffichageActivite

    Public Function AffichageAciviteSecteur(login)
        Dim donnees
        Dim nom = afficheNom(login)
        Dim SQLafficheSecteur As String = "SELECT SECTEUR.nom FROM SECTEUR INNER JOIN VISITEUR ON visiteur.id_secteur = secteur.id where visiteur.nom = '" & nom & "';"

        myCommand.Connection = myConnection
        myCommand.CommandText = SQLafficheSecteur
        myReader = myCommand.ExecuteReader()
        myReader.Read()

        donnees = myReader.GetValue(0)
        myReader.Close()

        Return donnees
    End Function





    'Selection des medicaments
    Public Function SelectionMedicaments()
        Dim donnees As New List(Of String)
        Dim SQLselectionMedicaments As String = "SELECT nommedoc FROM medicament"

        myCommand.CommandText = SQLselectionMedicaments
        myReader = myCommand.ExecuteReader

        While myReader.Read()
            donnees.Add(myReader.GetString(0))
        End While

        myReader.Close()

        Return donnees
    End Function


    'Selection des medecins
    Public Function SelectionMedecins()
        Dim donnees As New List(Of String)
        Dim SQLselectionMedecins As String = "SELECT nom FROM medecin"

        myCommand.CommandText = SQLselectionMedecins
        myReader = myCommand.ExecuteReader

        While myReader.Read()
            donnees.Add(myReader.GetString(0))
        End While

        myReader.Close()

        Return donnees
    End Function


    Public Function AffichageCompteRenduDunVisiteurSelectionne(utilisateurselect)
        Dim donnees As New List(Of String)
        Dim SQLCompteRenduVisiteurSelect = "SELECT DTE FROM COMPTE_RENDU INNER JOIN VISITEUR ON visiteur.idvis = Compte_rendu.visiteur WHERE VISITEUR.nom='" & utilisateurselect & "';"

        myCommand.Connection = myConnection
        myCommand.CommandText = SQLCompteRenduVisiteurSelect

        myReader = myCommand.ExecuteReader()

        While myReader.Read()
            donnees.Add(myReader.GetString(0))
        End While

        myReader.Close()

        Return donnees
    End Function


    'Selection de l id du motif
    Public Function SelectionIdMotif(nomMotif)
        Dim idMotif As String
        Dim SQLselectionIdMotif As String = "SELECT id FROM motif WHERE nom = '" & nomMotif & "';"

        myCommand.Connection = myConnection
        myCommand.CommandText = SQLselectionIdMotif
        myReader = myCommand.ExecuteReader()
        myReader.Read()

        idMotif = myReader.GetValue(0)
        myReader.Close()

        Return idMotif
    End Function


    'Selection de l id du medecin
    Public Function SelectionIdMedecin(nomMedecin)
        Dim idMedecin As String
        Dim SQLselectionIdMedecin As String = "SELECT id FROM medecin WHERE nom = '" & nomMedecin & "';"

        myCommand.Connection = myConnection
        myCommand.CommandText = SQLselectionIdMedecin
        myReader = myCommand.ExecuteReader()
        myReader.Read()

        idMedecin = myReader.GetValue(0)
        myReader.Close()

        Return idMedecin
    End Function


    'Selection de l id du medecin
    Public Function SelectionIdMedicament(nomMedicament)
        Dim idMedicament As String
        Dim SQLselectionIdMedicament As String = "SELECT idmedoc FROM medicament WHERE nommedoc = '" & nomMedicament & "';"

        myCommand.Connection = myConnection
        myCommand.CommandText = SQLselectionIdMedicament
        myReader = myCommand.ExecuteReader()
        myReader.Read()

        idMedicament = myReader.GetValue(0)
        myReader.Close()

        Return idMedicament
    End Function


    'Insertion d un compte rendu
    Public Function InsertionCompteRendu(medecin, visiteur, bilandesc, dte, qteMedoc, medicament, motif)
        Dim resultat
        Dim SQLinsertionCompteRendu As String = "INSERT INTO compte_rendu (MEDECIN, VISITEUR, BILANDESC, DTE, QTE_MEDOC, MEDIC, MOTIF) VALUES ('" & medecin & "', '" & visiteur & "', '" & bilandesc & "', TO_DATE('" & dte & "','DD/MM/YY'), '" & qteMedoc & "', '" & medicament & "', '" & motif & "');"

        myCommand.Connection = myConnection
        myCommand.CommandText = SQLinsertionCompteRendu
        myReader = myCommand.ExecuteReader()

        resultat = myReader
        myReader.Close()

        Return resultat
    End Function

End Module
