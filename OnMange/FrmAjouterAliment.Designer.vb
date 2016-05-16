<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAjouterAliment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAjouterAliment))
        Me.lblRechercher = New System.Windows.Forms.Label()
        Me.txtRechercher = New System.Windows.Forms.TextBox()
        Me.lstAliments = New System.Windows.Forms.ListBox()
        Me.lblAliments = New System.Windows.Forms.Label()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRechercher
        '
        Me.lblRechercher.AutoSize = True
        Me.lblRechercher.Location = New System.Drawing.Point(13, 13)
        Me.lblRechercher.Name = "lblRechercher"
        Me.lblRechercher.Size = New System.Drawing.Size(63, 13)
        Me.lblRechercher.TabIndex = 0
        Me.lblRechercher.Text = "&Rechercher"
        '
        'txtRechercher
        '
        Me.txtRechercher.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRechercher.Location = New System.Drawing.Point(82, 10)
        Me.txtRechercher.Name = "txtRechercher"
        Me.txtRechercher.Size = New System.Drawing.Size(225, 20)
        Me.txtRechercher.TabIndex = 1
        '
        'lstAliments
        '
        Me.lstAliments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstAliments.FormattingEnabled = True
        Me.lstAliments.Items.AddRange(New Object() {"Boeuf", "Fromage", "Poulet", "Veau"})
        Me.lstAliments.Location = New System.Drawing.Point(82, 36)
        Me.lstAliments.Name = "lstAliments"
        Me.lstAliments.Size = New System.Drawing.Size(225, 186)
        Me.lstAliments.TabIndex = 3
        '
        'lblAliments
        '
        Me.lblAliments.AutoSize = True
        Me.lblAliments.Location = New System.Drawing.Point(13, 36)
        Me.lblAliments.Name = "lblAliments"
        Me.lblAliments.Size = New System.Drawing.Size(46, 13)
        Me.lblAliments.TabIndex = 2
        Me.lblAliments.Text = "&Aliments"
        '
        'btnAjouter
        '
        Me.btnAjouter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAjouter.Location = New System.Drawing.Point(151, 227)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(75, 23)
        Me.btnAjouter.TabIndex = 4
        Me.btnAjouter.Text = "&Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = True
        '
        'btnFermer
        '
        Me.btnFermer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFermer.Location = New System.Drawing.Point(232, 227)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(75, 23)
        Me.btnFermer.TabIndex = 5
        Me.btnFermer.Text = "&Fermer"
        Me.btnFermer.UseVisualStyleBackColor = True
        '
        'FrmAjouterAliment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 262)
        Me.Controls.Add(Me.btnFermer)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.lblAliments)
        Me.Controls.Add(Me.lstAliments)
        Me.Controls.Add(Me.txtRechercher)
        Me.Controls.Add(Me.lblRechercher)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(335, 300)
        Me.Name = "FrmAjouterAliment"
        Me.Text = "On mange ! - Ajouter des aliments"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRechercher As Label
    Friend WithEvents txtRechercher As TextBox
    Friend WithEvents lstAliments As ListBox
    Friend WithEvents lblAliments As Label
    Friend WithEvents btnAjouter As Button
    Friend WithEvents btnFermer As Button
End Class
