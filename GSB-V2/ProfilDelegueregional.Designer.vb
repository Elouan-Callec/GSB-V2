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
        Me.LinkLabelmodifiermoncompte = New System.Windows.Forms.LinkLabel()
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
        Me.Labelprenom.Location = New System.Drawing.Point(75, 15)
        Me.Labelprenom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelprenom.Name = "Labelprenom"
        Me.Labelprenom.Size = New System.Drawing.Size(57, 17)
        Me.Labelprenom.TabIndex = 52
        Me.Labelprenom.Text = "Prenom"
        '
        'Labelnom
        '
        Me.Labelnom.AutoSize = True
        Me.Labelnom.Location = New System.Drawing.Point(136, 15)
        Me.Labelnom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelnom.Name = "Labelnom"
        Me.Labelnom.Size = New System.Drawing.Size(37, 17)
        Me.Labelnom.TabIndex = 53
        Me.Labelnom.Text = "Nom"
        '
        'LinkLabelmodifiermoncompte
        '
        Me.LinkLabelmodifiermoncompte.AutoSize = True
        Me.LinkLabelmodifiermoncompte.Location = New System.Drawing.Point(75, 31)
        Me.LinkLabelmodifiermoncompte.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabelmodifiermoncompte.Name = "LinkLabelmodifiermoncompte"
        Me.LinkLabelmodifiermoncompte.Size = New System.Drawing.Size(139, 17)
        Me.LinkLabelmodifiermoncompte.TabIndex = 54
        Me.LinkLabelmodifiermoncompte.TabStop = True
        Me.LinkLabelmodifiermoncompte.Text = "Modifier mon compte"
        '
        'ButtonRedigerCompteRendu
        '
        Me.ButtonRedigerCompteRendu.Location = New System.Drawing.Point(196, 383)
        Me.ButtonRedigerCompteRendu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonRedigerCompteRendu.Name = "ButtonRedigerCompteRendu"
        Me.ButtonRedigerCompteRendu.Size = New System.Drawing.Size(267, 43)
        Me.ButtonRedigerCompteRendu.TabIndex = 55
        Me.ButtonRedigerCompteRendu.Text = "Rediger un compte rendu"
        Me.ButtonRedigerCompteRendu.UseVisualStyleBackColor = True
        '
        'Labelhiérarchieparsecteur
        '
        Me.Labelhiérarchieparsecteur.AutoSize = True
        Me.Labelhiérarchieparsecteur.Location = New System.Drawing.Point(75, 62)
        Me.Labelhiérarchieparsecteur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelhiérarchieparsecteur.Name = "Labelhiérarchieparsecteur"
        Me.Labelhiérarchieparsecteur.Size = New System.Drawing.Size(81, 17)
        Me.Labelhiérarchieparsecteur.TabIndex = 56
        Me.Labelhiérarchieparsecteur.Text = "Hiérarchie :"
        '
        'LabelVisiteurMedical
        '
        Me.LabelVisiteurMedical.AutoSize = True
        Me.LabelVisiteurMedical.Location = New System.Drawing.Point(164, 62)
        Me.LabelVisiteurMedical.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelVisiteurMedical.Name = "LabelVisiteurMedical"
        Me.LabelVisiteurMedical.Size = New System.Drawing.Size(116, 17)
        Me.LabelVisiteurMedical.TabIndex = 57
        Me.LabelVisiteurMedical.Text = "Délégué régional"
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
        'ButtonSelectionActivite
        '
        Me.ButtonSelectionActivite.Location = New System.Drawing.Point(196, 198)
        Me.ButtonSelectionActivite.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonSelectionActivite.Name = "ButtonSelectionActivite"
        Me.ButtonSelectionActivite.Size = New System.Drawing.Size(267, 46)
        Me.ButtonSelectionActivite.TabIndex = 60
        Me.ButtonSelectionActivite.Text = "Sélectionner une activité"
        Me.ButtonSelectionActivite.UseVisualStyleBackColor = True
        '
        'ButtonVoirCompteRendu
        '
        Me.ButtonVoirCompteRendu.Location = New System.Drawing.Point(196, 290)
        Me.ButtonVoirCompteRendu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonVoirCompteRendu.Name = "ButtonVoirCompteRendu"
        Me.ButtonVoirCompteRendu.Size = New System.Drawing.Size(267, 46)
        Me.ButtonVoirCompteRendu.TabIndex = 61
        Me.ButtonVoirCompteRendu.Text = "Sélectionner un compte rendu"
        Me.ButtonVoirCompteRendu.UseVisualStyleBackColor = True
        '
        'ProfilDelegueregional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 586)
        Me.Controls.Add(Me.ButtonVoirCompteRendu)
        Me.Controls.Add(Me.ButtonSelectionActivite)
        Me.Controls.Add(Me.LabelVisiteurMedical)
        Me.Controls.Add(Me.Labelhiérarchieparsecteur)
        Me.Controls.Add(Me.ButtonRedigerCompteRendu)
        Me.Controls.Add(Me.LinkLabelmodifiermoncompte)
        Me.Controls.Add(Me.Labelnom)
        Me.Controls.Add(Me.Labelprenom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ProfilDelegueregional"
        Me.Text = "InterfaceDelegueregional"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Labelprenom As Label
    Friend WithEvents Labelnom As Label
    Friend WithEvents LinkLabelmodifiermoncompte As LinkLabel
    Friend WithEvents ButtonRedigerCompteRendu As Button
    Friend WithEvents Labelhiérarchieparsecteur As Label
    Friend WithEvents LabelVisiteurMedical As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonSelectionActivite As Button
    Friend WithEvents ButtonVoirCompteRendu As Button
End Class
