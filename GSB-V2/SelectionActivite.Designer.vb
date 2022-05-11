<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectionActivite
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
        Me.Labelnom = New System.Windows.Forms.Label()
        Me.Labelprenom = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBoxActiviteVisiteur = New System.Windows.Forms.ComboBox()
        Me.LabelChoixVisiteur = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonVisionnerActiviteVisiteur = New System.Windows.Forms.Button()
        Me.ButtonVisionnerActiviteEquipe = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelHierarchie
        '
        Me.LabelHierarchie.AutoSize = True
        Me.LabelHierarchie.Location = New System.Drawing.Point(120, 58)
        Me.LabelHierarchie.Name = "LabelHierarchie"
        Me.LabelHierarchie.Size = New System.Drawing.Size(87, 13)
        Me.LabelHierarchie.TabIndex = 63
        Me.LabelHierarchie.Text = "Délégué régional"
        '
        'Labelhiérarchieparsecteur
        '
        Me.Labelhiérarchieparsecteur.AutoSize = True
        Me.Labelhiérarchieparsecteur.Location = New System.Drawing.Point(53, 59)
        Me.Labelhiérarchieparsecteur.Name = "Labelhiérarchieparsecteur"
        Me.Labelhiérarchieparsecteur.Size = New System.Drawing.Size(61, 13)
        Me.Labelhiérarchieparsecteur.TabIndex = 62
        Me.Labelhiérarchieparsecteur.Text = "Hiérarchie :"
        '
        'Labelnom
        '
        Me.Labelnom.AutoSize = True
        Me.Labelnom.Location = New System.Drawing.Point(54, 35)
        Me.Labelnom.Name = "Labelnom"
        Me.Labelnom.Size = New System.Drawing.Size(29, 13)
        Me.Labelnom.TabIndex = 60
        Me.Labelnom.Text = "Nom"
        '
        'Labelprenom
        '
        Me.Labelprenom.AutoSize = True
        Me.Labelprenom.Location = New System.Drawing.Point(54, 11)
        Me.Labelprenom.Name = "Labelprenom"
        Me.Labelprenom.Size = New System.Drawing.Size(43, 13)
        Me.Labelprenom.TabIndex = 59
        Me.Labelprenom.Text = "Prenom"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(10, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 52)
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'ComboBoxActiviteVisiteur
        '
        Me.ComboBoxActiviteVisiteur.FormattingEnabled = True
        Me.ComboBoxActiviteVisiteur.Location = New System.Drawing.Point(260, 157)
        Me.ComboBoxActiviteVisiteur.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxActiviteVisiteur.Name = "ComboBoxActiviteVisiteur"
        Me.ComboBoxActiviteVisiteur.Size = New System.Drawing.Size(164, 21)
        Me.ComboBoxActiviteVisiteur.TabIndex = 64
        '
        'LabelChoixVisiteur
        '
        Me.LabelChoixVisiteur.AutoSize = True
        Me.LabelChoixVisiteur.Location = New System.Drawing.Point(257, 120)
        Me.LabelChoixVisiteur.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelChoixVisiteur.Name = "LabelChoixVisiteur"
        Me.LabelChoixVisiteur.Size = New System.Drawing.Size(150, 13)
        Me.LabelChoixVisiteur.TabIndex = 66
        Me.LabelChoixVisiteur.Text = "Visionner l'activité d'un visiteur"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(257, 299)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 13)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Visionner l'activité de mon équipe "
        '
        'ButtonVisionnerActiviteVisiteur
        '
        Me.ButtonVisionnerActiviteVisiteur.Location = New System.Drawing.Point(260, 182)
        Me.ButtonVisionnerActiviteVisiteur.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonVisionnerActiviteVisiteur.Name = "ButtonVisionnerActiviteVisiteur"
        Me.ButtonVisionnerActiviteVisiteur.Size = New System.Drawing.Size(56, 19)
        Me.ButtonVisionnerActiviteVisiteur.TabIndex = 68
        Me.ButtonVisionnerActiviteVisiteur.Text = "Valider"
        Me.ButtonVisionnerActiviteVisiteur.UseVisualStyleBackColor = True
        '
        'ButtonVisionnerActiviteEquipe
        '
        Me.ButtonVisionnerActiviteEquipe.Location = New System.Drawing.Point(259, 337)
        Me.ButtonVisionnerActiviteEquipe.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonVisionnerActiviteEquipe.Name = "ButtonVisionnerActiviteEquipe"
        Me.ButtonVisionnerActiviteEquipe.Size = New System.Drawing.Size(56, 19)
        Me.ButtonVisionnerActiviteEquipe.TabIndex = 69
        Me.ButtonVisionnerActiviteEquipe.Text = "Valider"
        Me.ButtonVisionnerActiviteEquipe.UseVisualStyleBackColor = True
        '
        'SelectionActivite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 455)
        Me.Controls.Add(Me.ButtonVisionnerActiviteEquipe)
        Me.Controls.Add(Me.ButtonVisionnerActiviteVisiteur)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelChoixVisiteur)
        Me.Controls.Add(Me.ComboBoxActiviteVisiteur)
        Me.Controls.Add(Me.LabelHierarchie)
        Me.Controls.Add(Me.Labelhiérarchieparsecteur)
        Me.Controls.Add(Me.Labelnom)
        Me.Controls.Add(Me.Labelprenom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "SelectionActivite"
        Me.Text = "SelectionActivite"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelHierarchie As Label
    Friend WithEvents Labelhiérarchieparsecteur As Label
    Friend WithEvents Labelnom As Label
    Friend WithEvents Labelprenom As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBoxActiviteVisiteur As ComboBox
    Friend WithEvents LabelChoixVisiteur As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonVisionnerActiviteVisiteur As Button
    Friend WithEvents ButtonVisionnerActiviteEquipe As Button
End Class
