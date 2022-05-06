<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InterfaceDelegueregional
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
        Me.ButtonVisionnerActivieVisiteur = New System.Windows.Forms.Button()
        Me.ButtonVoirCompteRendu = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Labelnom
        '
        Me.Labelnom.AutoSize = True
        Me.Labelnom.Location = New System.Drawing.Point(102, 12)
        Me.Labelnom.Name = "Labelnom"
        Me.Labelnom.Size = New System.Drawing.Size(29, 13)
        Me.Labelnom.TabIndex = 53
        Me.Labelnom.Text = "Nom"
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
        'ButtonRedigerCompteRendu
        '
        Me.ButtonRedigerCompteRendu.Location = New System.Drawing.Point(216, 318)
        Me.ButtonRedigerCompteRendu.Name = "ButtonRedigerCompteRendu"
        Me.ButtonRedigerCompteRendu.Size = New System.Drawing.Size(200, 35)
        Me.ButtonRedigerCompteRendu.TabIndex = 55
        Me.ButtonRedigerCompteRendu.Text = "Rediger un compte rendu"
        Me.ButtonRedigerCompteRendu.UseVisualStyleBackColor = True
        '
        'Labelhiérarchieparsecteur
        '
        Me.Labelhiérarchieparsecteur.AutoSize = True
        Me.Labelhiérarchieparsecteur.Location = New System.Drawing.Point(56, 50)
        Me.Labelhiérarchieparsecteur.Name = "Labelhiérarchieparsecteur"
        Me.Labelhiérarchieparsecteur.Size = New System.Drawing.Size(61, 13)
        Me.Labelhiérarchieparsecteur.TabIndex = 56
        Me.Labelhiérarchieparsecteur.Text = "Hiérarchie :"
        '
        'LabelVisiteurMedical
        '
        Me.LabelVisiteurMedical.AutoSize = True
        Me.LabelVisiteurMedical.Location = New System.Drawing.Point(123, 50)
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
        'ButtonVisionnerActivieVisiteur
        '
        Me.ButtonVisionnerActivieVisiteur.Location = New System.Drawing.Point(216, 168)
        Me.ButtonVisionnerActivieVisiteur.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonVisionnerActivieVisiteur.Name = "ButtonVisionnerActivieVisiteur"
        Me.ButtonVisionnerActivieVisiteur.Size = New System.Drawing.Size(200, 37)
        Me.ButtonVisionnerActivieVisiteur.TabIndex = 60
        Me.ButtonVisionnerActivieVisiteur.Text = "Visionner l'activité d'un visiteur"
        Me.ButtonVisionnerActivieVisiteur.UseVisualStyleBackColor = True
        '
        'ButtonVoirCompteRendu
        '
        Me.ButtonVoirCompteRendu.Location = New System.Drawing.Point(216, 243)
        Me.ButtonVoirCompteRendu.Name = "ButtonVoirCompteRendu"
        Me.ButtonVoirCompteRendu.Size = New System.Drawing.Size(200, 37)
        Me.ButtonVoirCompteRendu.TabIndex = 61
        Me.ButtonVoirCompteRendu.Text = "Voir mes comptes rendus"
        Me.ButtonVoirCompteRendu.UseVisualStyleBackColor = True
        '
        'InterfaceDelegueregional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 480)
        Me.Controls.Add(Me.ButtonVoirCompteRendu)
        Me.Controls.Add(Me.ButtonVisionnerActivieVisiteur)
        Me.Controls.Add(Me.LabelVisiteurMedical)
        Me.Controls.Add(Me.Labelhiérarchieparsecteur)
        Me.Controls.Add(Me.ButtonRedigerCompteRendu)
        Me.Controls.Add(Me.LinkLabelmodifiermoncompte)
        Me.Controls.Add(Me.Labelnom)
        Me.Controls.Add(Me.Labelprenom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "InterfaceDelegueregional"
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
    Friend WithEvents ButtonVisionnerActivieVisiteur As Button
    Friend WithEvents ButtonVoirCompteRendu As Button
End Class
