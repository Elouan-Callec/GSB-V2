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
        Me.LabelHierarchie = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Labelnom = New System.Windows.Forms.Label()
        Me.Labelprenom = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelTypeActivité = New System.Windows.Forms.Label()
        Me.LabelSelection = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(951, 72)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Retour arrière"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea1.Name = "Test"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Location = New System.Drawing.Point(240, 142)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "Test"
        Series1.LegendText = "TEST"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(770, 532)
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
        'LabelHierarchie
        '
        Me.LabelHierarchie.AutoSize = True
        Me.LabelHierarchie.Location = New System.Drawing.Point(184, 92)
        Me.LabelHierarchie.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelHierarchie.Name = "LabelHierarchie"
        Me.LabelHierarchie.Size = New System.Drawing.Size(129, 20)
        Me.LabelHierarchie.TabIndex = 63
        Me.LabelHierarchie.Text = "Délégué régional"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(84, 92)
        Me.Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(89, 20)
        Me.Label.TabIndex = 62
        Me.Label.Text = "Hiérarchie :"
        '
        'Labelnom
        '
        Me.Labelnom.AutoSize = True
        Me.Labelnom.Location = New System.Drawing.Point(84, 34)
        Me.Labelnom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelnom.Name = "Labelnom"
        Me.Labelnom.Size = New System.Drawing.Size(42, 20)
        Me.Labelnom.TabIndex = 60
        Me.Labelnom.Text = "Nom"
        '
        'Labelprenom
        '
        Me.Labelprenom.AutoSize = True
        Me.Labelprenom.Location = New System.Drawing.Point(84, 61)
        Me.Labelprenom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelprenom.Name = "Labelprenom"
        Me.Labelprenom.Size = New System.Drawing.Size(64, 20)
        Me.Labelprenom.TabIndex = 59
        Me.Labelprenom.Text = "Prenom"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(18, 34)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 80)
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'LabelTypeActivité
        '
        Me.LabelTypeActivité.AutoSize = True
        Me.LabelTypeActivité.Location = New System.Drawing.Point(604, 34)
        Me.LabelTypeActivité.Name = "LabelTypeActivité"
        Me.LabelTypeActivité.Size = New System.Drawing.Size(57, 20)
        Me.LabelTypeActivité.TabIndex = 64
        Me.LabelTypeActivité.Text = "Label2"
        '
        'LabelSelection
        '
        Me.LabelSelection.AutoSize = True
        Me.LabelSelection.Location = New System.Drawing.Point(604, 72)
        Me.LabelSelection.Name = "LabelSelection"
        Me.LabelSelection.Size = New System.Drawing.Size(57, 20)
        Me.LabelSelection.TabIndex = 65
        Me.LabelSelection.Text = "Label1"
        '
        'AffichageActivite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.LabelSelection)
        Me.Controls.Add(Me.LabelTypeActivité)
        Me.Controls.Add(Me.LabelHierarchie)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Labelnom)
        Me.Controls.Add(Me.Labelprenom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AffichageActivite"
        Me.Text = "AfficheDelegueregional"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents LabelHierarchie As Label
    Friend WithEvents Label As Label
    Friend WithEvents Labelnom As Label
    Friend WithEvents Labelprenom As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelTypeActivité As Label
    Friend WithEvents LabelSelection As Label
End Class
