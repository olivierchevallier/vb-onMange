<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PnlPlat
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblOrigine = New System.Windows.Forms.Label()
        Me.lblPlat = New System.Windows.Forms.Label()
        Me.notPlat = New OnMange.Note()
        Me.SuspendLayout()
        '
        'lblOrigine
        '
        Me.lblOrigine.AutoSize = True
        Me.lblOrigine.Location = New System.Drawing.Point(110, 40)
        Me.lblOrigine.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOrigine.Name = "lblOrigine"
        Me.lblOrigine.Size = New System.Drawing.Size(59, 20)
        Me.lblOrigine.TabIndex = 16
        Me.lblOrigine.Text = "Origine"
        '
        'lblPlat
        '
        Me.lblPlat.AutoSize = True
        Me.lblPlat.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlat.Location = New System.Drawing.Point(109, 11)
        Me.lblPlat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlat.Name = "lblPlat"
        Me.lblPlat.Size = New System.Drawing.Size(58, 29)
        Me.lblPlat.TabIndex = 10
        Me.lblPlat.Text = "Plat"
        '
        'notPlat
        '
        Me.notPlat.BackColor = System.Drawing.Color.Transparent
        Me.notPlat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notPlat.LectureSeule = True
        Me.notPlat.Location = New System.Drawing.Point(52, 63)
        Me.notPlat.Name = "notPlat"
        Me.notPlat.Note = 0
        Me.notPlat.Size = New System.Drawing.Size(174, 30)
        Me.notPlat.TabIndex = 17
        '
        'PnlPlat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.notPlat)
        Me.Controls.Add(Me.lblOrigine)
        Me.Controls.Add(Me.lblPlat)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "PnlPlat"
        Me.Size = New System.Drawing.Size(279, 103)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOrigine As Label
    Friend WithEvents lblPlat As Label
    Friend WithEvents notPlat As Note
End Class
