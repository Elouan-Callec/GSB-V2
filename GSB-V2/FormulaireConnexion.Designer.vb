﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormulaireConnexion
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
        Me.TextBoxlogin = New System.Windows.Forms.TextBox()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.TextBoxmotdepasse = New System.Windows.Forms.TextBox()
        Me.Labelmotdepasse = New System.Windows.Forms.Label()
        Me.Labellogin = New System.Windows.Forms.Label()
        Me.Labelconnexion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxlogin
        '
        Me.TextBoxlogin.Location = New System.Drawing.Point(202, 162)
        Me.TextBoxlogin.Name = "TextBoxlogin"
        Me.TextBoxlogin.Size = New System.Drawing.Size(399, 20)
        Me.TextBoxlogin.TabIndex = 18
        Me.TextBoxlogin.Text = "Entrer le login"
        '
        'ButtonLogin
        '
        Me.ButtonLogin.Location = New System.Drawing.Point(202, 355)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(399, 40)
        Me.ButtonLogin.TabIndex = 17
        Me.ButtonLogin.Text = "LOGIN"
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'TextBoxmotdepasse
        '
        Me.TextBoxmotdepasse.AutoCompleteCustomSource.AddRange(New String() {"Entrer le mot de passe"})
        Me.TextBoxmotdepasse.Location = New System.Drawing.Point(202, 269)
        Me.TextBoxmotdepasse.Name = "TextBoxmotdepasse"
        Me.TextBoxmotdepasse.Size = New System.Drawing.Size(399, 20)
        Me.TextBoxmotdepasse.TabIndex = 16
        Me.TextBoxmotdepasse.Tag = ""
        Me.TextBoxmotdepasse.Text = "Entrer le mot de passe"
        '
        'Labelmotdepasse
        '
        Me.Labelmotdepasse.AutoSize = True
        Me.Labelmotdepasse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelmotdepasse.Location = New System.Drawing.Point(199, 235)
        Me.Labelmotdepasse.Name = "Labelmotdepasse"
        Me.Labelmotdepasse.Size = New System.Drawing.Size(93, 17)
        Me.Labelmotdepasse.TabIndex = 15
        Me.Labelmotdepasse.Text = "Mot de passe"
        '
        'Labellogin
        '
        Me.Labellogin.AutoSize = True
        Me.Labellogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labellogin.Location = New System.Drawing.Point(199, 122)
        Me.Labellogin.Name = "Labellogin"
        Me.Labellogin.Size = New System.Drawing.Size(43, 17)
        Me.Labellogin.TabIndex = 14
        Me.Labellogin.Text = "Login"
        '
        'Labelconnexion
        '
        Me.Labelconnexion.AutoSize = True
        Me.Labelconnexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelconnexion.Location = New System.Drawing.Point(300, 49)
        Me.Labelconnexion.Name = "Labelconnexion"
        Me.Labelconnexion.Size = New System.Drawing.Size(229, 51)
        Me.Labelconnexion.TabIndex = 13
        Me.Labelconnexion.Text = "Connexion"
        '
        'FormulaireConnexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBoxlogin)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.TextBoxmotdepasse)
        Me.Controls.Add(Me.Labelmotdepasse)
        Me.Controls.Add(Me.Labellogin)
        Me.Controls.Add(Me.Labelconnexion)
        Me.Name = "FormulaireConnexion"
        Me.Text = "FormulaireConnexion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxlogin As TextBox
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents TextBoxmotdepasse As TextBox
    Friend WithEvents Labelmotdepasse As Label
    Friend WithEvents Labellogin As Label
    Friend WithEvents Labelconnexion As Label
End Class
