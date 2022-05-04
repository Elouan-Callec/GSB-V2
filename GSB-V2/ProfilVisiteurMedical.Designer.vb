<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfilVisiteurMedical
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BoutonModifier = New System.Windows.Forms.Button()
        Me.BoutonAffichage = New System.Windows.Forms.Button()
        Me.ComboBoxCompteRendu = New System.Windows.Forms.ComboBox()
        Me.LabelVisiteurMedical = New System.Windows.Forms.Label()
        Me.LabelHierarchie = New System.Windows.Forms.Label()
        Me.BoutonRedigerCompteRendu = New System.Windows.Forms.Button()
        Me.LinkLabelmodifiermoncompte = New System.Windows.Forms.LinkLabel()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.Labelprenom = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BoutonModifier
        '
        Me.BoutonModifier.Location = New System.Drawing.Point(361, 171)
        Me.BoutonModifier.Margin = New System.Windows.Forms.Padding(2)
        Me.BoutonModifier.Name = "BoutonModifier"
        Me.BoutonModifier.Size = New System.Drawing.Size(118, 21)
        Me.BoutonModifier.TabIndex = 61
        Me.BoutonModifier.Text = "Modifier"
        Me.BoutonModifier.UseVisualStyleBackColor = True
        '
        'BoutonAffichage
        '
        Me.BoutonAffichage.Location = New System.Drawing.Point(196, 171)
        Me.BoutonAffichage.Margin = New System.Windows.Forms.Padding(2)
        Me.BoutonAffichage.Name = "BoutonAffichage"
        Me.BoutonAffichage.Size = New System.Drawing.Size(118, 21)
        Me.BoutonAffichage.TabIndex = 60
        Me.BoutonAffichage.Text = "Afficher"
        Me.BoutonAffichage.UseVisualStyleBackColor = True
        '
        'ComboBoxCompteRendu
        '
        Me.ComboBoxCompteRendu.FormattingEnabled = True
        Me.ComboBoxCompteRendu.Items.AddRange(New Object() {"CompteRendu n°1", "CompteRendu n°2", "CompteRendu n°3"})
        Me.ComboBoxCompteRendu.Location = New System.Drawing.Point(196, 128)
        Me.ComboBoxCompteRendu.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxCompteRendu.Name = "ComboBoxCompteRendu"
        Me.ComboBoxCompteRendu.Size = New System.Drawing.Size(283, 21)
        Me.ComboBoxCompteRendu.TabIndex = 58
        Me.ComboBoxCompteRendu.Text = "CompteRendu n°1"
        '
        'LabelVisiteurMedical
        '
        Me.LabelVisiteurMedical.AutoSize = True
        Me.LabelVisiteurMedical.Location = New System.Drawing.Point(123, 50)
        Me.LabelVisiteurMedical.Name = "LabelVisiteurMedical"
        Me.LabelVisiteurMedical.Size = New System.Drawing.Size(81, 13)
        Me.LabelVisiteurMedical.TabIndex = 57
        Me.LabelVisiteurMedical.Text = "Visiteur Médical"
        '
        'LabelHierarchie
        '
        Me.LabelHierarchie.AutoSize = True
        Me.LabelHierarchie.Location = New System.Drawing.Point(56, 50)
        Me.LabelHierarchie.Name = "LabelHierarchie"
        Me.LabelHierarchie.Size = New System.Drawing.Size(61, 13)
        Me.LabelHierarchie.TabIndex = 56
        Me.LabelHierarchie.Text = "Hiérarchie :"
        '
        'BoutonRedigerCompteRendu
        '
        Me.BoutonRedigerCompteRendu.Location = New System.Drawing.Point(196, 263)
        Me.BoutonRedigerCompteRendu.Name = "BoutonRedigerCompteRendu"
        Me.BoutonRedigerCompteRendu.Size = New System.Drawing.Size(151, 30)
        Me.BoutonRedigerCompteRendu.TabIndex = 55
        Me.BoutonRedigerCompteRendu.Text = "Rediger un compte rendu"
        Me.BoutonRedigerCompteRendu.UseVisualStyleBackColor = True
        '
        'LinkLabelmodifiermoncompte
        '
        Me.LinkLabelmodifiermoncompte.AutoSize = True
        Me.LinkLabelmodifiermoncompte.Location = New System.Drawing.Point(56, 25)
        Me.LinkLabelmodifiermoncompte.Name = "LinkLabelmodifiermoncompte"
        Me.LinkLabelmodifiermoncompte.Size = New System.Drawing.Size(105, 13)
        Me.LinkLabelmodifiermoncompte.TabIndex = 54
        Me.LinkLabelmodifiermoncompte.TabStop = True
        Me.LinkLabelmodifiermoncompte.Text = "Modifier mon compte"
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(102, 12)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(29, 13)
        Me.LabelNom.TabIndex = 53
        Me.LabelNom.Text = "Nom"
        '
        'Labelprenom
        '
        Me.Labelprenom.AutoSize = True
        Me.Labelprenom.Location = New System.Drawing.Point(56, 12)
        Me.Labelprenom.Name = "Labelprenom"
        Me.Labelprenom.Size = New System.Drawing.Size(43, 13)
        Me.Labelprenom.TabIndex = 52
        Me.Labelprenom.Text = "Prenom"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 52)
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'ProfilVisiteurMedical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 385)
        Me.Controls.Add(Me.BoutonModifier)
        Me.Controls.Add(Me.BoutonAffichage)
        Me.Controls.Add(Me.ComboBoxCompteRendu)
        Me.Controls.Add(Me.LabelVisiteurMedical)
        Me.Controls.Add(Me.LabelHierarchie)
        Me.Controls.Add(Me.BoutonRedigerCompteRendu)
        Me.Controls.Add(Me.LinkLabelmodifiermoncompte)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.Labelprenom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ProfilVisiteurMedical"
        Me.Text = "ProfilVisiteurMedical"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BoutonModifier As Button
    Friend WithEvents BoutonAffichage As Button
    Friend WithEvents ComboBoxCompteRendu As ComboBox
    Friend WithEvents LabelVisiteurMedical As Label
    Friend WithEvents LabelHierarchie As Label
    Friend WithEvents BoutonRedigerCompteRendu As Button
    Friend WithEvents LinkLabelmodifiermoncompte As LinkLabel
    Friend WithEvents LabelNom As Label
    Friend WithEvents Labelprenom As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
