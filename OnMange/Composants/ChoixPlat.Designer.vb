<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChoixPlat
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.plaPlat1 = New OnMange.PnlPlat()
        Me.plaPlat2 = New OnMange.PnlPlat()
        Me.plaPlat3 = New OnMange.PnlPlat()
        Me.plaPlat4 = New OnMange.PnlPlat()
        Me.SuspendLayout()
        '
        'plaPlat1
        '
        Me.plaPlat1.BackColor = System.Drawing.Color.White
        Me.plaPlat1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.plaPlat1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plaPlat1.Location = New System.Drawing.Point(4, 5)
        Me.plaPlat1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.plaPlat1.Name = "plaPlat1"
        Me.plaPlat1.Note = 0
        Me.plaPlat1.Origine = "Origine"
        Me.plaPlat1.Plat = ""
        Me.plaPlat1.Size = New System.Drawing.Size(279, 103)
        Me.plaPlat1.TabIndex = 0
        '
        'plaPlat2
        '
        Me.plaPlat2.BackColor = System.Drawing.Color.White
        Me.plaPlat2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.plaPlat2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plaPlat2.Location = New System.Drawing.Point(291, 5)
        Me.plaPlat2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.plaPlat2.Name = "plaPlat2"
        Me.plaPlat2.Note = 0
        Me.plaPlat2.Origine = "Origine"
        Me.plaPlat2.Plat = ""
        Me.plaPlat2.Size = New System.Drawing.Size(279, 103)
        Me.plaPlat2.TabIndex = 1
        '
        'plaPlat3
        '
        Me.plaPlat3.BackColor = System.Drawing.Color.White
        Me.plaPlat3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.plaPlat3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plaPlat3.Location = New System.Drawing.Point(4, 118)
        Me.plaPlat3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.plaPlat3.Name = "plaPlat3"
        Me.plaPlat3.Note = 0
        Me.plaPlat3.Origine = "Origine"
        Me.plaPlat3.Plat = ""
        Me.plaPlat3.Size = New System.Drawing.Size(279, 103)
        Me.plaPlat3.TabIndex = 2
        '
        'plaPlat4
        '
        Me.plaPlat4.BackColor = System.Drawing.Color.White
        Me.plaPlat4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.plaPlat4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plaPlat4.Location = New System.Drawing.Point(291, 118)
        Me.plaPlat4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.plaPlat4.Name = "plaPlat4"
        Me.plaPlat4.Note = 0
        Me.plaPlat4.Origine = "Origine"
        Me.plaPlat4.Plat = ""
        Me.plaPlat4.Size = New System.Drawing.Size(279, 103)
        Me.plaPlat4.TabIndex = 3
        '
        'ChoixPlat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.plaPlat4)
        Me.Controls.Add(Me.plaPlat3)
        Me.Controls.Add(Me.plaPlat2)
        Me.Controls.Add(Me.plaPlat1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Name = "ChoixPlat"
        Me.Size = New System.Drawing.Size(576, 228)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents plaPlat1 As PnlPlat
    Friend WithEvents plaPlat2 As PnlPlat
    Friend WithEvents plaPlat3 As PnlPlat
    Friend WithEvents plaPlat4 As PnlPlat
End Class
