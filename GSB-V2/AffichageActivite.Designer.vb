<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AffichageActivite
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.LabelVisiteurMedical = New System.Windows.Forms.Label()
        Me.Labelhiérarchieparsecteur = New System.Windows.Forms.Label()
        Me.Labelnom = New System.Windows.Forms.Label()
        Me.Labelprenom = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelNomGraphique = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(634, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 26)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Retour arrière"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea1.Name = "Test"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Location = New System.Drawing.Point(164, 154)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "Test"
        Series1.LegendText = "TEST"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(513, 346)
        Me.Chart1.TabIndex = 2
        Me.Chart1.Text = "Delegue Regional"
        Title1.Alignment = System.Drawing.ContentAlignment.TopCenter
        Title1.Name = "Mois"
        Title1.Position.Auto = False
        Title1.Position.Width = 94.0!
        Title1.Position.X = 6.0!
        Title1.Position.Y = 95.0!
        Title1.Text = "Mois"
        Title2.Alignment = System.Drawing.ContentAlignment.TopLeft
        Title2.Name = "Title1"
        Title2.Position.Auto = False
        Title2.Position.Height = 27.88597!
        Title2.Position.Width = 94.0!
        Title2.Position.X = 3.0!
        Title2.Position.Y = 40.0!
        Title2.Text = "Nombre de visite"
        Title2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270
        Me.Chart1.Titles.Add(Title1)
        Me.Chart1.Titles.Add(Title2)
        '
        'LabelVisiteurMedical
        '
        Me.LabelVisiteurMedical.AutoSize = True
        Me.LabelVisiteurMedical.Location = New System.Drawing.Point(123, 85)
        Me.LabelVisiteurMedical.Name = "LabelVisiteurMedical"
        Me.LabelVisiteurMedical.Size = New System.Drawing.Size(87, 13)
        Me.LabelVisiteurMedical.TabIndex = 63
        Me.LabelVisiteurMedical.Text = "Délégué régional"
        '
        'Labelhiérarchieparsecteur
        '
        Me.Labelhiérarchieparsecteur.AutoSize = True
        Me.Labelhiérarchieparsecteur.Location = New System.Drawing.Point(56, 85)
        Me.Labelhiérarchieparsecteur.Name = "Labelhiérarchieparsecteur"
        Me.Labelhiérarchieparsecteur.Size = New System.Drawing.Size(61, 13)
        Me.Labelhiérarchieparsecteur.TabIndex = 62
        Me.Labelhiérarchieparsecteur.Text = "Hiérarchie :"
        '
        'Labelnom
        '
        Me.Labelnom.AutoSize = True
        Me.Labelnom.Location = New System.Drawing.Point(56, 54)
        Me.Labelnom.Name = "Labelnom"
        Me.Labelnom.Size = New System.Drawing.Size(29, 13)
        Me.Labelnom.TabIndex = 60
        Me.Labelnom.Text = "Nom"
        '
        'Labelprenom
        '
        Me.Labelprenom.AutoSize = True
        Me.Labelprenom.Location = New System.Drawing.Point(56, 22)
        Me.Labelprenom.Name = "Labelprenom"
        Me.Labelprenom.Size = New System.Drawing.Size(43, 13)
        Me.Labelprenom.TabIndex = 59
        Me.Labelprenom.Text = "Prenom"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 52)
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'LabelNomGraphique
        '
        Me.LabelNomGraphique.AutoSize = True
        Me.LabelNomGraphique.Location = New System.Drawing.Point(319, 85)
        Me.LabelNomGraphique.Name = "LabelNomGraphique"
        Me.LabelNomGraphique.Size = New System.Drawing.Size(62, 13)
        Me.LabelNomGraphique.TabIndex = 64
        Me.LabelNomGraphique.Text = "Graphique :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(418, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Label1"
        '
        'AffichageActivite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 527)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelNomGraphique)
        Me.Controls.Add(Me.LabelVisiteurMedical)
        Me.Controls.Add(Me.Labelhiérarchieparsecteur)
        Me.Controls.Add(Me.Labelnom)
        Me.Controls.Add(Me.Labelprenom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "AffichageActivite"
        Me.Text = "AfficheDelegueregional"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents LabelVisiteurMedical As Label
    Friend WithEvents Labelhiérarchieparsecteur As Label
    Friend WithEvents Labelnom As Label
    Friend WithEvents Labelprenom As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelNomGraphique As Label
    Friend WithEvents Label1 As Label
End Class
