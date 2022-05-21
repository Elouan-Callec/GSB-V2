<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChoixRedacteurCompteRendu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabelHierarchie = New System.Windows.Forms.Label()
        Me.Labelhiérarchieparsecteur = New System.Windows.Forms.Label()
        Me.Labelnom = New System.Windows.Forms.Label()
        Me.Labelprenom = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BoutonModifier = New System.Windows.Forms.Button()
        Me.BoutonAffichage = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelHierarchie
        '
        Me.LabelHierarchie.AutoSize = True
        Me.LabelHierarchie.Location = New System.Drawing.Point(184, 91)
        Me.LabelHierarchie.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelHierarchie.Name = "LabelHierarchie"
        Me.LabelHierarchie.Size = New System.Drawing.Size(42, 20)
        Me.LabelHierarchie.TabIndex = 79
        Me.LabelHierarchie.Text = "Role"
        '
        'Labelhiérarchieparsecteur
        '
        Me.Labelhiérarchieparsecteur.AutoSize = True
        Me.Labelhiérarchieparsecteur.Location = New System.Drawing.Point(84, 91)
        Me.Labelhiérarchieparsecteur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelhiérarchieparsecteur.Name = "Labelhiérarchieparsecteur"
        Me.Labelhiérarchieparsecteur.Size = New System.Drawing.Size(89, 20)
        Me.Labelhiérarchieparsecteur.TabIndex = 78
        Me.Labelhiérarchieparsecteur.Text = "Hiérarchie :"
        '
        'Labelnom
        '
        Me.Labelnom.AutoSize = True
        Me.Labelnom.Location = New System.Drawing.Point(84, 32)
        Me.Labelnom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelnom.Name = "Labelnom"
        Me.Labelnom.Size = New System.Drawing.Size(42, 20)
        Me.Labelnom.TabIndex = 76
        Me.Labelnom.Text = "Nom"
        '
        'Labelprenom
        '
        Me.Labelprenom.AutoSize = True
        Me.Labelprenom.Location = New System.Drawing.Point(84, 62)
        Me.Labelprenom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelprenom.Name = "Labelprenom"
        Me.Labelprenom.Size = New System.Drawing.Size(64, 20)
        Me.Labelprenom.TabIndex = 75
        Me.Labelprenom.Text = "Prenom"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(18, 32)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 80)
        Me.PictureBox1.TabIndex = 74
        Me.PictureBox1.TabStop = False
        '
        'BoutonModifier
        '
        Me.BoutonModifier.Location = New System.Drawing.Point(411, 300)
        Me.BoutonModifier.Name = "BoutonModifier"
        Me.BoutonModifier.Size = New System.Drawing.Size(188, 52)
        Me.BoutonModifier.TabIndex = 73
        Me.BoutonModifier.Text = "Compte rendu d'un visiteur"
        Me.BoutonModifier.UseVisualStyleBackColor = True
        '
        'BoutonAffichage
        '
        Me.BoutonAffichage.Location = New System.Drawing.Point(122, 300)
        Me.BoutonAffichage.Name = "BoutonAffichage"
        Me.BoutonAffichage.Size = New System.Drawing.Size(194, 52)
        Me.BoutonAffichage.TabIndex = 72
        Me.BoutonAffichage.Text = "Mes comptes rendus"
        Me.BoutonAffichage.UseVisualStyleBackColor = True
        '
        'ChoixRedacteurCompteRendu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 488)
        Me.Controls.Add(Me.LabelHierarchie)
        Me.Controls.Add(Me.Labelhiérarchieparsecteur)
        Me.Controls.Add(Me.Labelnom)
        Me.Controls.Add(Me.Labelprenom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BoutonModifier)
        Me.Controls.Add(Me.BoutonAffichage)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ChoixRedacteurCompteRendu"
        Me.Text = "ChoixRedacteurCompteRendu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelHierarchie As Label
    Friend WithEvents Labelhiérarchieparsecteur As Label
    Friend WithEvents Labelnom As Label
    Friend WithEvents Labelprenom As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BoutonModifier As Button
    Friend WithEvents BoutonAffichage As Button
End Class
