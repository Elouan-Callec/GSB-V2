<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AffichageCompteRenduVisiteurMedical
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
        Me.LabelVisiteurMedical = New System.Windows.Forms.Label()
        Me.Labelhiérarchieparsecteur = New System.Windows.Forms.Label()
        Me.LinkLabelmodifiermoncompte = New System.Windows.Forms.LinkLabel()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.Labelprenom = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBoxCompteRendu = New System.Windows.Forms.ComboBox()
        Me.LabelConsulterCompteRendu = New System.Windows.Forms.Label()
        Me.BouttonValider = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelVisiteurMedical
        '
        Me.LabelVisiteurMedical.AutoSize = True
        Me.LabelVisiteurMedical.Location = New System.Drawing.Point(123, 50)
        Me.LabelVisiteurMedical.Name = "LabelVisiteurMedical"
        Me.LabelVisiteurMedical.Size = New System.Drawing.Size(81, 13)
        Me.LabelVisiteurMedical.TabIndex = 63
        Me.LabelVisiteurMedical.Text = "Visiteur Médical"
        '
        'Labelhiérarchieparsecteur
        '
        Me.Labelhiérarchieparsecteur.AutoSize = True
        Me.Labelhiérarchieparsecteur.Location = New System.Drawing.Point(56, 50)
        Me.Labelhiérarchieparsecteur.Name = "Labelhiérarchieparsecteur"
        Me.Labelhiérarchieparsecteur.Size = New System.Drawing.Size(61, 13)
        Me.Labelhiérarchieparsecteur.TabIndex = 62
        Me.Labelhiérarchieparsecteur.Text = "Hiérarchie :"
        '
        'LinkLabelmodifiermoncompte
        '
        Me.LinkLabelmodifiermoncompte.AutoSize = True
        Me.LinkLabelmodifiermoncompte.Location = New System.Drawing.Point(56, 25)
        Me.LinkLabelmodifiermoncompte.Name = "LinkLabelmodifiermoncompte"
        Me.LinkLabelmodifiermoncompte.Size = New System.Drawing.Size(105, 13)
        Me.LinkLabelmodifiermoncompte.TabIndex = 61
        Me.LinkLabelmodifiermoncompte.TabStop = True
        Me.LinkLabelmodifiermoncompte.Text = "Modifier mon compte"
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(102, 12)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(29, 13)
        Me.LabelNom.TabIndex = 60
        Me.LabelNom.Text = "Nom"
        '
        'Labelprenom
        '
        Me.Labelprenom.AutoSize = True
        Me.Labelprenom.Location = New System.Drawing.Point(56, 12)
        Me.Labelprenom.Name = "Labelprenom"
        Me.Labelprenom.Size = New System.Drawing.Size(43, 13)
        Me.Labelprenom.TabIndex = 59
        Me.Labelprenom.Text = "Prenom"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 52)
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'ComboBoxCompteRendu
        '
        Me.ComboBoxCompteRendu.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBoxCompteRendu.FormattingEnabled = True
        Me.ComboBoxCompteRendu.Location = New System.Drawing.Point(237, 203)
        Me.ComboBoxCompteRendu.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxCompteRendu.Name = "ComboBoxCompteRendu"
        Me.ComboBoxCompteRendu.Size = New System.Drawing.Size(283, 21)
        Me.ComboBoxCompteRendu.TabIndex = 64
        Me.ComboBoxCompteRendu.Text = "CompteRendu n°1"
        '
        'LabelConsulterCompteRendu
        '
        Me.LabelConsulterCompteRendu.AutoSize = True
        Me.LabelConsulterCompteRendu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConsulterCompteRendu.Location = New System.Drawing.Point(233, 168)
        Me.LabelConsulterCompteRendu.Name = "LabelConsulterCompteRendu"
        Me.LabelConsulterCompteRendu.Size = New System.Drawing.Size(226, 20)
        Me.LabelConsulterCompteRendu.TabIndex = 65
        Me.LabelConsulterCompteRendu.Text = "Consulter un compte rendu"
        '
        'BouttonValider
        '
        Me.BouttonValider.Location = New System.Drawing.Point(237, 252)
        Me.BouttonValider.Name = "BouttonValider"
        Me.BouttonValider.Size = New System.Drawing.Size(283, 23)
        Me.BouttonValider.TabIndex = 66
        Me.BouttonValider.Text = "Valider"
        Me.BouttonValider.UseVisualStyleBackColor = True
        '
        'AffichageCompteRenduVisiteurMedical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 423)
        Me.Controls.Add(Me.BouttonValider)
        Me.Controls.Add(Me.LabelConsulterCompteRendu)
        Me.Controls.Add(Me.ComboBoxCompteRendu)
        Me.Controls.Add(Me.LabelVisiteurMedical)
        Me.Controls.Add(Me.Labelhiérarchieparsecteur)
        Me.Controls.Add(Me.LinkLabelmodifiermoncompte)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.Labelprenom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "AffichageCompteRenduVisiteurMedical"
        Me.Text = "AffichageCompteRenduVisiteurMedical"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelVisiteurMedical As Label
    Friend WithEvents Labelhiérarchieparsecteur As Label
    Friend WithEvents LinkLabelmodifiermoncompte As LinkLabel
    Friend WithEvents LabelNom As Label
    Friend WithEvents Labelprenom As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBoxCompteRendu As ComboBox
    Friend WithEvents LabelConsulterCompteRendu As Label
    Friend WithEvents BouttonValider As Button
End Class
