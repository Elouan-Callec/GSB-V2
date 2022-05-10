<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfilDelegueregional
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
        Me.Labelprenom = New System.Windows.Forms.Label()
        Me.Labelnom = New System.Windows.Forms.Label()
        Me.ButtonRedigerCompteRendu = New System.Windows.Forms.Button()
        Me.Labelhiérarchieparsecteur = New System.Windows.Forms.Label()
        Me.LabelVisiteurMedical = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonSelectionActivite = New System.Windows.Forms.Button()
        Me.ButtonVoirCompteRendu = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Labelprenom
        '
        Me.Labelprenom.AutoSize = True
        Me.Labelprenom.Location = New System.Drawing.Point(58, 32)
        Me.Labelprenom.Name = "Labelprenom"
        Me.Labelprenom.Size = New System.Drawing.Size(43, 13)
        Me.Labelprenom.TabIndex = 52
        Me.Labelprenom.Text = "Prenom"
        '
        'Labelnom
        '
        Me.Labelnom.AutoSize = True
        Me.Labelnom.Location = New System.Drawing.Point(57, 9)
        Me.Labelnom.Name = "Labelnom"
        Me.Labelnom.Size = New System.Drawing.Size(29, 13)
        Me.Labelnom.TabIndex = 53
        Me.Labelnom.Text = "Nom"
        '
        'ButtonRedigerCompteRendu
        '
        Me.ButtonRedigerCompteRendu.Location = New System.Drawing.Point(147, 311)
        Me.ButtonRedigerCompteRendu.Name = "ButtonRedigerCompteRendu"
        Me.ButtonRedigerCompteRendu.Size = New System.Drawing.Size(200, 35)
        Me.ButtonRedigerCompteRendu.TabIndex = 55
        Me.ButtonRedigerCompteRendu.Text = "Rediger un compte rendu"
        Me.ButtonRedigerCompteRendu.UseVisualStyleBackColor = True
        '
        'Labelhiérarchieparsecteur
        '
        Me.Labelhiérarchieparsecteur.AutoSize = True
        Me.Labelhiérarchieparsecteur.Location = New System.Drawing.Point(57, 60)
        Me.Labelhiérarchieparsecteur.Name = "Labelhiérarchieparsecteur"
        Me.Labelhiérarchieparsecteur.Size = New System.Drawing.Size(61, 13)
        Me.Labelhiérarchieparsecteur.TabIndex = 56
        Me.Labelhiérarchieparsecteur.Text = "Hiérarchie :"
        '
        'LabelVisiteurMedical
        '
        Me.LabelVisiteurMedical.AutoSize = True
        Me.LabelVisiteurMedical.Location = New System.Drawing.Point(124, 60)
        Me.LabelVisiteurMedical.Name = "LabelVisiteurMedical"
        Me.LabelVisiteurMedical.Size = New System.Drawing.Size(87, 13)
        Me.LabelVisiteurMedical.TabIndex = 57
        Me.LabelVisiteurMedical.Text = "Délégué régional"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 52)
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'ButtonSelectionActivite
        '
        Me.ButtonSelectionActivite.Location = New System.Drawing.Point(147, 161)
        Me.ButtonSelectionActivite.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonSelectionActivite.Name = "ButtonSelectionActivite"
        Me.ButtonSelectionActivite.Size = New System.Drawing.Size(200, 37)
        Me.ButtonSelectionActivite.TabIndex = 60
        Me.ButtonSelectionActivite.Text = "Sélectionner une activité"
        Me.ButtonSelectionActivite.UseVisualStyleBackColor = True
        '
        'ButtonVoirCompteRendu
        '
        Me.ButtonVoirCompteRendu.Location = New System.Drawing.Point(147, 236)
        Me.ButtonVoirCompteRendu.Name = "ButtonVoirCompteRendu"
        Me.ButtonVoirCompteRendu.Size = New System.Drawing.Size(200, 37)
        Me.ButtonVoirCompteRendu.TabIndex = 61
        Me.ButtonVoirCompteRendu.Text = "Sélectionner un compte rendu"
        Me.ButtonVoirCompteRendu.UseVisualStyleBackColor = True
        '
        'ProfilDelegueregional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 476)
        Me.Controls.Add(Me.ButtonVoirCompteRendu)
        Me.Controls.Add(Me.ButtonSelectionActivite)
        Me.Controls.Add(Me.LabelVisiteurMedical)
        Me.Controls.Add(Me.Labelhiérarchieparsecteur)
        Me.Controls.Add(Me.ButtonRedigerCompteRendu)
        Me.Controls.Add(Me.Labelnom)
        Me.Controls.Add(Me.Labelprenom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ProfilDelegueregional"
        Me.Text = "InterfaceDelegueregional"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Labelprenom As Label
    Friend WithEvents Labelnom As Label
    Friend WithEvents ButtonRedigerCompteRendu As Button
    Friend WithEvents Labelhiérarchieparsecteur As Label
    Friend WithEvents LabelVisiteurMedical As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonSelectionActivite As Button
    Friend WithEvents ButtonVoirCompteRendu As Button
End Class
