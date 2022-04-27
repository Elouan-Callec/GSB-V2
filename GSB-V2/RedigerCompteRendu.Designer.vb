<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RedigerCompteRendu
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelVisiteurMedical = New System.Windows.Forms.Label()
        Me.Labelhiérarchieparsecteur = New System.Windows.Forms.Label()
        Me.LinkLabelmodifiermoncompte = New System.Windows.Forms.LinkLabel()
        Me.Labelnom = New System.Windows.Forms.Label()
        Me.Labelprenom = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(776, 83)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 34)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Retour Arrière"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelVisiteurMedical
        '
        Me.LabelVisiteurMedical.AutoSize = True
        Me.LabelVisiteurMedical.Location = New System.Drawing.Point(184, 95)
        Me.LabelVisiteurMedical.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelVisiteurMedical.Name = "LabelVisiteurMedical"
        Me.LabelVisiteurMedical.Size = New System.Drawing.Size(129, 20)
        Me.LabelVisiteurMedical.TabIndex = 63
        Me.LabelVisiteurMedical.Text = "Délégué régional"
        '
        'Labelhiérarchieparsecteur
        '
        Me.Labelhiérarchieparsecteur.AutoSize = True
        Me.Labelhiérarchieparsecteur.Location = New System.Drawing.Point(84, 95)
        Me.Labelhiérarchieparsecteur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelhiérarchieparsecteur.Name = "Labelhiérarchieparsecteur"
        Me.Labelhiérarchieparsecteur.Size = New System.Drawing.Size(89, 20)
        Me.Labelhiérarchieparsecteur.TabIndex = 62
        Me.Labelhiérarchieparsecteur.Text = "Hiérarchie :"
        '
        'LinkLabelmodifiermoncompte
        '
        Me.LinkLabelmodifiermoncompte.AutoSize = True
        Me.LinkLabelmodifiermoncompte.Location = New System.Drawing.Point(84, 57)
        Me.LinkLabelmodifiermoncompte.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabelmodifiermoncompte.Name = "LinkLabelmodifiermoncompte"
        Me.LinkLabelmodifiermoncompte.Size = New System.Drawing.Size(157, 20)
        Me.LinkLabelmodifiermoncompte.TabIndex = 61
        Me.LinkLabelmodifiermoncompte.TabStop = True
        Me.LinkLabelmodifiermoncompte.Text = "Modifier mon compte"
        '
        'Labelnom
        '
        Me.Labelnom.AutoSize = True
        Me.Labelnom.Location = New System.Drawing.Point(153, 37)
        Me.Labelnom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelnom.Name = "Labelnom"
        Me.Labelnom.Size = New System.Drawing.Size(42, 20)
        Me.Labelnom.TabIndex = 60
        Me.Labelnom.Text = "Nom"
        '
        'Labelprenom
        '
        Me.Labelprenom.AutoSize = True
        Me.Labelprenom.Location = New System.Drawing.Point(84, 37)
        Me.Labelprenom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelprenom.Name = "Labelprenom"
        Me.Labelprenom.Size = New System.Drawing.Size(64, 20)
        Me.Labelprenom.TabIndex = 59
        Me.Labelprenom.Text = "Prenom"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(18, 37)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 80)
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 246)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 20)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Compte Rendu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 346)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(88, 388)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(298, 26)
        Me.DateTimePicker1.TabIndex = 66
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(634, 388)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(283, 26)
        Me.TextBox1.TabIndex = 67
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(630, 346)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 20)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Motif"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(634, 467)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 20)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Nombre Echantillons Offerts"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(92, 467)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 20)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Médicaments Présentés"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(88, 513)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(204, 27)
        Me.CheckedListBox1.TabIndex = 71
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.Location = New System.Drawing.Point(634, 513)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.Size = New System.Drawing.Size(214, 27)
        Me.CheckedListBox2.TabIndex = 72
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(96, 604)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 20)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Bilan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(630, 604)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 20)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Description des Produits"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(88, 653)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(283, 26)
        Me.TextBox2.TabIndex = 75
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(634, 653)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(283, 26)
        Me.TextBox3.TabIndex = 76
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(425, 764)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(170, 61)
        Me.Button2.TabIndex = 77
        Me.Button2.Text = "Valider Compte rendu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RedigerCompteRendu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 855)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CheckedListBox2)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelVisiteurMedical)
        Me.Controls.Add(Me.Labelhiérarchieparsecteur)
        Me.Controls.Add(Me.LinkLabelmodifiermoncompte)
        Me.Controls.Add(Me.Labelnom)
        Me.Controls.Add(Me.Labelprenom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "RedigerCompteRendu"
        Me.Text = "RedigerCompteRendu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents LabelVisiteurMedical As Label
    Friend WithEvents Labelhiérarchieparsecteur As Label
    Friend WithEvents LinkLabelmodifiermoncompte As LinkLabel
    Friend WithEvents Labelnom As Label
    Friend WithEvents Labelprenom As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents CheckedListBox2 As CheckedListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button2 As Button
End Class
