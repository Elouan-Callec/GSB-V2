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
        Me.BoutonRedigerCompteRendu = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelAffichageHierarchie = New System.Windows.Forms.Label()
        Me.Labelhiérarchieparsecteur = New System.Windows.Forms.Label()
        Me.Labelnom = New System.Windows.Forms.Label()
        Me.Labelprenom = New System.Windows.Forms.Label()
        Me.LabelSelectionCompteRendu = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BoutonModifier
        '
        Me.BoutonModifier.Location = New System.Drawing.Point(480, 265)
        Me.BoutonModifier.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BoutonModifier.Name = "BoutonModifier"
        Me.BoutonModifier.Size = New System.Drawing.Size(157, 26)
        Me.BoutonModifier.TabIndex = 61
        Me.BoutonModifier.Text = "Modifier"
        Me.BoutonModifier.UseVisualStyleBackColor = True
        '
        'BoutonAffichage
        '
        Me.BoutonAffichage.Location = New System.Drawing.Point(260, 265)
        Me.BoutonAffichage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BoutonAffichage.Name = "BoutonAffichage"
        Me.BoutonAffichage.Size = New System.Drawing.Size(157, 26)
        Me.BoutonAffichage.TabIndex = 60
        Me.BoutonAffichage.Text = "Afficher"
        Me.BoutonAffichage.UseVisualStyleBackColor = True
        '
        'ComboBoxCompteRendu
        '
        Me.ComboBoxCompteRendu.FormattingEnabled = True
        Me.ComboBoxCompteRendu.Location = New System.Drawing.Point(260, 206)
        Me.ComboBoxCompteRendu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxCompteRendu.Name = "ComboBoxCompteRendu"
        Me.ComboBoxCompteRendu.Size = New System.Drawing.Size(376, 24)
        Me.ComboBoxCompteRendu.TabIndex = 58
        '
        'BoutonRedigerCompteRendu
        '
        Me.BoutonRedigerCompteRendu.Location = New System.Drawing.Point(260, 372)
        Me.BoutonRedigerCompteRendu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BoutonRedigerCompteRendu.Name = "BoutonRedigerCompteRendu"
        Me.BoutonRedigerCompteRendu.Size = New System.Drawing.Size(201, 37)
        Me.BoutonRedigerCompteRendu.TabIndex = 55
        Me.BoutonRedigerCompteRendu.Text = "Rediger un compte rendu"
        Me.BoutonRedigerCompteRendu.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(16, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 64)
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'LabelAffichageHierarchie
        '
        Me.LabelAffichageHierarchie.AutoSize = True
        Me.LabelAffichageHierarchie.Location = New System.Drawing.Point(165, 70)
        Me.LabelAffichageHierarchie.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelAffichageHierarchie.Name = "LabelAffichageHierarchie"
        Me.LabelAffichageHierarchie.Size = New System.Drawing.Size(36, 17)
        Me.LabelAffichageHierarchie.TabIndex = 65
        Me.LabelAffichageHierarchie.Text = "Test"
        '
        'Labelhiérarchieparsecteur
        '
        Me.Labelhiérarchieparsecteur.AutoSize = True
        Me.Labelhiérarchieparsecteur.Location = New System.Drawing.Point(76, 70)
        Me.Labelhiérarchieparsecteur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelhiérarchieparsecteur.Name = "Labelhiérarchieparsecteur"
        Me.Labelhiérarchieparsecteur.Size = New System.Drawing.Size(81, 17)
        Me.Labelhiérarchieparsecteur.TabIndex = 64
        Me.Labelhiérarchieparsecteur.Text = "Hiérarchie :"
        '
        'Labelnom
        '
        Me.Labelnom.AutoSize = True
        Me.Labelnom.Location = New System.Drawing.Point(76, 15)
        Me.Labelnom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelnom.Name = "Labelnom"
        Me.Labelnom.Size = New System.Drawing.Size(37, 17)
        Me.Labelnom.TabIndex = 63
        Me.Labelnom.Text = "Nom"
        '
        'Labelprenom
        '
        Me.Labelprenom.AutoSize = True
        Me.Labelprenom.Location = New System.Drawing.Point(76, 43)
        Me.Labelprenom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelprenom.Name = "Labelprenom"
        Me.Labelprenom.Size = New System.Drawing.Size(57, 17)
        Me.Labelprenom.TabIndex = 62
        Me.Labelprenom.Text = "Prenom"
        '
        'LabelSelectionCompteRendu
        '
        Me.LabelSelectionCompteRendu.AutoSize = True
        Me.LabelSelectionCompteRendu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSelectionCompteRendu.Location = New System.Drawing.Point(255, 149)
        Me.LabelSelectionCompteRendu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSelectionCompteRendu.Name = "LabelSelectionCompteRendu"
        Me.LabelSelectionCompteRendu.Size = New System.Drawing.Size(300, 25)
        Me.LabelSelectionCompteRendu.TabIndex = 66
        Me.LabelSelectionCompteRendu.Text = "Selectionner un compte rendu"
        '
        'ProfilVisiteurMedical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 474)
        Me.Controls.Add(Me.LabelSelectionCompteRendu)
        Me.Controls.Add(Me.LabelAffichageHierarchie)
        Me.Controls.Add(Me.Labelhiérarchieparsecteur)
        Me.Controls.Add(Me.Labelnom)
        Me.Controls.Add(Me.Labelprenom)
        Me.Controls.Add(Me.BoutonModifier)
        Me.Controls.Add(Me.BoutonAffichage)
        Me.Controls.Add(Me.ComboBoxCompteRendu)
        Me.Controls.Add(Me.BoutonRedigerCompteRendu)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ProfilVisiteurMedical"
        Me.Text = "ProfilVisiteurMedical"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BoutonModifier As Button
    Friend WithEvents BoutonAffichage As Button
    Friend WithEvents ComboBoxCompteRendu As ComboBox
    Friend WithEvents BoutonRedigerCompteRendu As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelAffichageHierarchie As Label
    Friend WithEvents Labelhiérarchieparsecteur As Label
    Friend WithEvents Labelnom As Label
    Friend WithEvents Labelprenom As Label
    Friend WithEvents LabelSelectionCompteRendu As Label
End Class
