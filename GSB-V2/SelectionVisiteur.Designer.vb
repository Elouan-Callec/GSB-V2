<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectionVisiteur
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
        Me.Labelnom = New System.Windows.Forms.Label()
        Me.Labelprenom = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelChoixVisiteur = New System.Windows.Forms.Label()
        Me.ComboBoxChoixVisiteur = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelVisiteurMedical
        '
        Me.LabelVisiteurMedical.AutoSize = True
        Me.LabelVisiteurMedical.Location = New System.Drawing.Point(123, 50)
        Me.LabelVisiteurMedical.Name = "LabelVisiteurMedical"
        Me.LabelVisiteurMedical.Size = New System.Drawing.Size(87, 13)
        Me.LabelVisiteurMedical.TabIndex = 63
        Me.LabelVisiteurMedical.Text = "Délégué régional"
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
        'Labelnom
        '
        Me.Labelnom.AutoSize = True
        Me.Labelnom.Location = New System.Drawing.Point(102, 12)
        Me.Labelnom.Name = "Labelnom"
        Me.Labelnom.Size = New System.Drawing.Size(29, 13)
        Me.Labelnom.TabIndex = 60
        Me.Labelnom.Text = "Nom"
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
        'LabelChoixVisiteur
        '
        Me.LabelChoixVisiteur.AutoSize = True
        Me.LabelChoixVisiteur.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelChoixVisiteur.Location = New System.Drawing.Point(273, 165)
        Me.LabelChoixVisiteur.Name = "LabelChoixVisiteur"
        Me.LabelChoixVisiteur.Size = New System.Drawing.Size(145, 20)
        Me.LabelChoixVisiteur.TabIndex = 64
        Me.LabelChoixVisiteur.Text = "Choisir le visiteur"
        '
        'ComboBoxChoixVisiteur
        '
        Me.ComboBoxChoixVisiteur.FormattingEnabled = True
        Me.ComboBoxChoixVisiteur.Items.AddRange(New Object() {"Visiteur numéro 1", "Visiteur numéro 2"})
        Me.ComboBoxChoixVisiteur.Location = New System.Drawing.Point(277, 206)
        Me.ComboBoxChoixVisiteur.Name = "ComboBoxChoixVisiteur"
        Me.ComboBoxChoixVisiteur.Size = New System.Drawing.Size(201, 21)
        Me.ComboBoxChoixVisiteur.TabIndex = 65
        '
        'SelectionVisiteur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 386)
        Me.Controls.Add(Me.ComboBoxChoixVisiteur)
        Me.Controls.Add(Me.LabelChoixVisiteur)
        Me.Controls.Add(Me.LabelVisiteurMedical)
        Me.Controls.Add(Me.Labelhiérarchieparsecteur)
        Me.Controls.Add(Me.LinkLabelmodifiermoncompte)
        Me.Controls.Add(Me.Labelnom)
        Me.Controls.Add(Me.Labelprenom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "SelectionVisiteur"
        Me.Text = "VisionnageActiviteVisiteur"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelVisiteurMedical As Label
    Friend WithEvents Labelhiérarchieparsecteur As Label
    Friend WithEvents LinkLabelmodifiermoncompte As LinkLabel
    Friend WithEvents Labelnom As Label
    Friend WithEvents Labelprenom As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelChoixVisiteur As Label
    Friend WithEvents ComboBoxChoixVisiteur As ComboBox
End Class
