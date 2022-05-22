<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AffichageCompteRendu
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
        Me.LabelHierarchie = New System.Windows.Forms.Label()
        Me.Labelhiérarchieparsecteur = New System.Windows.Forms.Label()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.Labelprenom = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelBilan = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelDte = New System.Windows.Forms.Label()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.Labelcompterendu = New System.Windows.Forms.Label()
        Me.LabelMedicament = New System.Windows.Forms.Label()
        Me.LabelQTE_Medoc = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LabelMotif = New System.Windows.Forms.Label()
        Me.ButtonRetour = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.LabelMedecin = New System.Windows.Forms.Label()
        Me.LabelVisiteurSelectionner = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelHierarchie
        '
        Me.LabelHierarchie.AutoSize = True
        Me.LabelHierarchie.Location = New System.Drawing.Point(184, 78)
        Me.LabelHierarchie.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelHierarchie.Name = "LabelHierarchie"
        Me.LabelHierarchie.Size = New System.Drawing.Size(120, 20)
        Me.LabelHierarchie.TabIndex = 148
        Me.LabelHierarchie.Text = "Visiteur Médical"
        '
        'Labelhiérarchieparsecteur
        '
        Me.Labelhiérarchieparsecteur.AutoSize = True
        Me.Labelhiérarchieparsecteur.Location = New System.Drawing.Point(84, 78)
        Me.Labelhiérarchieparsecteur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelhiérarchieparsecteur.Name = "Labelhiérarchieparsecteur"
        Me.Labelhiérarchieparsecteur.Size = New System.Drawing.Size(89, 20)
        Me.Labelhiérarchieparsecteur.TabIndex = 147
        Me.Labelhiérarchieparsecteur.Text = "Hiérarchie :"
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(84, 18)
        Me.LabelNom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(42, 20)
        Me.LabelNom.TabIndex = 145
        Me.LabelNom.Text = "Nom"
        '
        'Labelprenom
        '
        Me.Labelprenom.AutoSize = True
        Me.Labelprenom.Location = New System.Drawing.Point(84, 48)
        Me.Labelprenom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelprenom.Name = "Labelprenom"
        Me.Labelprenom.Size = New System.Drawing.Size(64, 20)
        Me.Labelprenom.TabIndex = 144
        Me.Labelprenom.Text = "Prenom"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(18, 18)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 80)
        Me.PictureBox1.TabIndex = 143
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(848, 342)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 20)
        Me.Label4.TabIndex = 159
        Me.Label4.Text = "Motif :"
        '
        'LabelBilan
        '
        Me.LabelBilan.AutoSize = True
        Me.LabelBilan.Location = New System.Drawing.Point(364, 374)
        Me.LabelBilan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelBilan.Name = "LabelBilan"
        Me.LabelBilan.Size = New System.Drawing.Size(87, 20)
        Me.LabelBilan.TabIndex = 158
        Me.LabelBilan.Text = "Label Bilan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(848, 261)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(216, 20)
        Me.Label6.TabIndex = 157
        Me.Label6.Text = "Nombre Echantillons Offerts :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(364, 261)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 20)
        Me.Label3.TabIndex = 154
        Me.Label3.Text = "Médicaments Présentés :"
        '
        'LabelDte
        '
        Me.LabelDte.AutoSize = True
        Me.LabelDte.Location = New System.Drawing.Point(852, 199)
        Me.LabelDte.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDte.Name = "LabelDte"
        Me.LabelDte.Size = New System.Drawing.Size(87, 20)
        Me.LabelDte.TabIndex = 153
        Me.LabelDte.Text = "Label Date"
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Location = New System.Drawing.Point(364, 199)
        Me.LabelID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(58, 20)
        Me.LabelID.TabIndex = 151
        Me.LabelID.Text = "label id"
        '
        'Labelcompterendu
        '
        Me.Labelcompterendu.AutoSize = True
        Me.Labelcompterendu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelcompterendu.Location = New System.Drawing.Point(489, 18)
        Me.Labelcompterendu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelcompterendu.Name = "Labelcompterendu"
        Me.Labelcompterendu.Size = New System.Drawing.Size(324, 29)
        Me.Labelcompterendu.TabIndex = 149
        Me.Labelcompterendu.Text = "Affichage du compte rendu"
        '
        'LabelMedicament
        '
        Me.LabelMedicament.AutoSize = True
        Me.LabelMedicament.Location = New System.Drawing.Point(364, 292)
        Me.LabelMedicament.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelMedicament.Name = "LabelMedicament"
        Me.LabelMedicament.Size = New System.Drawing.Size(57, 20)
        Me.LabelMedicament.TabIndex = 167
        Me.LabelMedicament.Text = "Label9"
        '
        'LabelQTE_Medoc
        '
        Me.LabelQTE_Medoc.AutoSize = True
        Me.LabelQTE_Medoc.Location = New System.Drawing.Point(848, 292)
        Me.LabelQTE_Medoc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelQTE_Medoc.Name = "LabelQTE_Medoc"
        Me.LabelQTE_Medoc.Size = New System.Drawing.Size(66, 20)
        Me.LabelQTE_Medoc.TabIndex = 168
        Me.LabelQTE_Medoc.Text = "Label10"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(364, 437)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 20)
        Me.Label11.TabIndex = 169
        Me.Label11.Text = "Medecin :"
        '
        'LabelMotif
        '
        Me.LabelMotif.AutoSize = True
        Me.LabelMotif.Location = New System.Drawing.Point(848, 374)
        Me.LabelMotif.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelMotif.Name = "LabelMotif"
        Me.LabelMotif.Size = New System.Drawing.Size(87, 20)
        Me.LabelMotif.TabIndex = 170
        Me.LabelMotif.Text = "Label Motif"
        '
        'ButtonRetour
        '
        Me.ButtonRetour.Location = New System.Drawing.Point(368, 560)
        Me.ButtonRetour.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(202, 60)
        Me.ButtonRetour.TabIndex = 152
        Me.ButtonRetour.Text = "Retour"
        Me.ButtonRetour.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(364, 342)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 20)
        Me.Label7.TabIndex = 171
        Me.Label7.Text = "Bilan :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(367, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 20)
        Me.Label1.TabIndex = 172
        Me.Label1.Text = "ID :"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(852, 165)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(52, 20)
        Me.Label.TabIndex = 173
        Me.Label.Text = "Date :"
        '
        'LabelMedecin
        '
        Me.LabelMedecin.AutoSize = True
        Me.LabelMedecin.Location = New System.Drawing.Point(367, 468)
        Me.LabelMedecin.Name = "LabelMedecin"
        Me.LabelMedecin.Size = New System.Drawing.Size(112, 20)
        Me.LabelMedecin.TabIndex = 174
        Me.LabelMedecin.Text = "Label Medecin"
        '
        'LabelVisiteurSelectionner
        '
        Me.LabelVisiteurSelectionner.AutoSize = True
        Me.LabelVisiteurSelectionner.Location = New System.Drawing.Point(494, 77)
        Me.LabelVisiteurSelectionner.Name = "LabelVisiteurSelectionner"
        Me.LabelVisiteurSelectionner.Size = New System.Drawing.Size(57, 20)
        Me.LabelVisiteurSelectionner.TabIndex = 175
        Me.LabelVisiteurSelectionner.Text = "Label2"
        '
        'AffichageCompteRendu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1407, 968)
        Me.Controls.Add(Me.LabelVisiteurSelectionner)
        Me.Controls.Add(Me.LabelMedecin)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LabelMotif)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LabelQTE_Medoc)
        Me.Controls.Add(Me.LabelMedicament)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabelBilan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelDte)
        Me.Controls.Add(Me.ButtonRetour)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.Labelcompterendu)
        Me.Controls.Add(Me.LabelHierarchie)
        Me.Controls.Add(Me.Labelhiérarchieparsecteur)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.Labelprenom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AffichageCompteRendu"
        Me.Text = "Affichage2CompteRenduVisiteurMedical"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelHierarchie As Label
    Friend WithEvents Labelhiérarchieparsecteur As Label
    Friend WithEvents LabelNom As Label
    Friend WithEvents Labelprenom As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelBilan As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelDte As Label
    Friend WithEvents LabelID As Label
    Friend WithEvents Labelcompterendu As Label
    Friend WithEvents LabelMedicament As Label
    Friend WithEvents LabelQTE_Medoc As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LabelMotif As Label
    Friend WithEvents ButtonRetour As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label As Label
    Friend WithEvents LabelMedecin As Label
    Friend WithEvents LabelVisiteurSelectionner As Label
End Class
