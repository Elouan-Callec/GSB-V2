<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectionCompteRenduDuVisiteur
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
        Me.ComboBoxCompteRendu = New System.Windows.Forms.ComboBox()
        Me.BoutonAffichage = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelHierarchie = New System.Windows.Forms.Label()
        Me.Labelprenom = New System.Windows.Forms.Label()
        Me.Labelnom = New System.Windows.Forms.Label()
        Me.Labelhiérarchieparsecteur = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelnomVisiteur = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxCompteRendu
        '
        Me.ComboBoxCompteRendu.FormattingEnabled = True
        Me.ComboBoxCompteRendu.Location = New System.Drawing.Point(88, 265)
        Me.ComboBoxCompteRendu.Name = "ComboBoxCompteRendu"
        Me.ComboBoxCompteRendu.Size = New System.Drawing.Size(422, 28)
        Me.ComboBoxCompteRendu.TabIndex = 72
        '
        'BoutonAffichage
        '
        Me.BoutonAffichage.Location = New System.Drawing.Point(198, 343)
        Me.BoutonAffichage.Name = "BoutonAffichage"
        Me.BoutonAffichage.Size = New System.Drawing.Size(177, 32)
        Me.BoutonAffichage.TabIndex = 73
        Me.BoutonAffichage.Text = "Afficher"
        Me.BoutonAffichage.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(18, 18)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 80)
        Me.PictureBox1.TabIndex = 75
        Me.PictureBox1.TabStop = False
        '
        'LabelHierarchie
        '
        Me.LabelHierarchie.AutoSize = True
        Me.LabelHierarchie.Location = New System.Drawing.Point(184, 77)
        Me.LabelHierarchie.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelHierarchie.Name = "LabelHierarchie"
        Me.LabelHierarchie.Size = New System.Drawing.Size(42, 20)
        Me.LabelHierarchie.TabIndex = 80
        Me.LabelHierarchie.Text = "Role"
        '
        'Labelprenom
        '
        Me.Labelprenom.AutoSize = True
        Me.Labelprenom.Location = New System.Drawing.Point(84, 48)
        Me.Labelprenom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelprenom.Name = "Labelprenom"
        Me.Labelprenom.Size = New System.Drawing.Size(64, 20)
        Me.Labelprenom.TabIndex = 76
        Me.Labelprenom.Text = "Prenom"
        '
        'Labelnom
        '
        Me.Labelnom.AutoSize = True
        Me.Labelnom.Location = New System.Drawing.Point(84, 18)
        Me.Labelnom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelnom.Name = "Labelnom"
        Me.Labelnom.Size = New System.Drawing.Size(42, 20)
        Me.Labelnom.TabIndex = 77
        Me.Labelnom.Text = "Nom"
        '
        'Labelhiérarchieparsecteur
        '
        Me.Labelhiérarchieparsecteur.AutoSize = True
        Me.Labelhiérarchieparsecteur.Location = New System.Drawing.Point(84, 77)
        Me.Labelhiérarchieparsecteur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelhiérarchieparsecteur.Name = "Labelhiérarchieparsecteur"
        Me.Labelhiérarchieparsecteur.Size = New System.Drawing.Size(89, 20)
        Me.Labelhiérarchieparsecteur.TabIndex = 79
        Me.Labelhiérarchieparsecteur.Text = "Hiérarchie :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 20)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Compte Rendu du Visiteur :"
        '
        'LabelnomVisiteur
        '
        Me.LabelnomVisiteur.AutoSize = True
        Me.LabelnomVisiteur.Location = New System.Drawing.Point(88, 210)
        Me.LabelnomVisiteur.Name = "LabelnomVisiteur"
        Me.LabelnomVisiteur.Size = New System.Drawing.Size(57, 20)
        Me.LabelnomVisiteur.TabIndex = 82
        Me.LabelnomVisiteur.Text = "Label2"
        '
        'SelectionCompteRenduDuVisiteur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 482)
        Me.Controls.Add(Me.LabelnomVisiteur)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelHierarchie)
        Me.Controls.Add(Me.Labelhiérarchieparsecteur)
        Me.Controls.Add(Me.Labelnom)
        Me.Controls.Add(Me.Labelprenom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BoutonAffichage)
        Me.Controls.Add(Me.ComboBoxCompteRendu)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "SelectionCompteRenduDuVisiteur"
        Me.Text = "SelectionCompteRenduDuVisiteur"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxCompteRendu As ComboBox
    Friend WithEvents BoutonAffichage As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelHierarchie As Label
    Friend WithEvents Labelprenom As Label
    Friend WithEvents Labelnom As Label
    Friend WithEvents Labelhiérarchieparsecteur As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelnomVisiteur As Label
End Class
