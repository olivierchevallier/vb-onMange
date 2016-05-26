<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Note
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Note))
        Me.picEtoile5 = New System.Windows.Forms.PictureBox()
        Me.picEtoile2 = New System.Windows.Forms.PictureBox()
        Me.picEtoile3 = New System.Windows.Forms.PictureBox()
        Me.picEtoile4 = New System.Windows.Forms.PictureBox()
        Me.picEtoile1 = New System.Windows.Forms.PictureBox()
        CType(Me.picEtoile5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEtoile2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEtoile3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEtoile4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEtoile1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picEtoile5
        '
        Me.picEtoile5.Image = CType(resources.GetObject("picEtoile5.Image"), System.Drawing.Image)
        Me.picEtoile5.Location = New System.Drawing.Point(144, 0)
        Me.picEtoile5.Name = "picEtoile5"
        Me.picEtoile5.Size = New System.Drawing.Size(30, 30)
        Me.picEtoile5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEtoile5.TabIndex = 20
        Me.picEtoile5.TabStop = False
        '
        'picEtoile2
        '
        Me.picEtoile2.Image = CType(resources.GetObject("picEtoile2.Image"), System.Drawing.Image)
        Me.picEtoile2.Location = New System.Drawing.Point(36, 0)
        Me.picEtoile2.Name = "picEtoile2"
        Me.picEtoile2.Size = New System.Drawing.Size(30, 30)
        Me.picEtoile2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEtoile2.TabIndex = 19
        Me.picEtoile2.TabStop = False
        '
        'picEtoile3
        '
        Me.picEtoile3.Image = CType(resources.GetObject("picEtoile3.Image"), System.Drawing.Image)
        Me.picEtoile3.Location = New System.Drawing.Point(72, 0)
        Me.picEtoile3.Name = "picEtoile3"
        Me.picEtoile3.Size = New System.Drawing.Size(30, 30)
        Me.picEtoile3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEtoile3.TabIndex = 18
        Me.picEtoile3.TabStop = False
        '
        'picEtoile4
        '
        Me.picEtoile4.Image = CType(resources.GetObject("picEtoile4.Image"), System.Drawing.Image)
        Me.picEtoile4.Location = New System.Drawing.Point(108, 0)
        Me.picEtoile4.Name = "picEtoile4"
        Me.picEtoile4.Size = New System.Drawing.Size(30, 30)
        Me.picEtoile4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEtoile4.TabIndex = 17
        Me.picEtoile4.TabStop = False
        '
        'picEtoile1
        '
        Me.picEtoile1.Image = CType(resources.GetObject("picEtoile1.Image"), System.Drawing.Image)
        Me.picEtoile1.Location = New System.Drawing.Point(0, 0)
        Me.picEtoile1.Name = "picEtoile1"
        Me.picEtoile1.Size = New System.Drawing.Size(30, 30)
        Me.picEtoile1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEtoile1.TabIndex = 16
        Me.picEtoile1.TabStop = False
        '
        'Note
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.picEtoile5)
        Me.Controls.Add(Me.picEtoile2)
        Me.Controls.Add(Me.picEtoile3)
        Me.Controls.Add(Me.picEtoile4)
        Me.Controls.Add(Me.picEtoile1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Note"
        Me.Size = New System.Drawing.Size(174, 30)
        CType(Me.picEtoile5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEtoile2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEtoile3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEtoile4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEtoile1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picEtoile5 As PictureBox
    Friend WithEvents picEtoile2 As PictureBox
    Friend WithEvents picEtoile3 As PictureBox
    Friend WithEvents picEtoile4 As PictureBox
    Friend WithEvents picEtoile1 As PictureBox
End Class
