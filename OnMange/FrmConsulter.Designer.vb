<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConsulter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsulter))
        Me.picTitre = New System.Windows.Forms.PictureBox()
        Me.lblMangerTitre = New System.Windows.Forms.Label()
        Me.lblCritere = New System.Windows.Forms.Label()
        Me.dgvHistorique = New System.Windows.Forms.DataGridView()
        Me.colPlat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAlimentsPrincipaux = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOrigine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMangeLe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblOuPlus = New System.Windows.Forms.Label()
        Me.cmdRechercher = New System.Windows.Forms.Button()
        Me.cboPasMange = New System.Windows.Forms.ComboBox()
        Me.lblPasMange = New System.Windows.Forms.Label()
        Me.cboMangerOrigine = New System.Windows.Forms.ComboBox()
        Me.lblOrigine = New System.Windows.Forms.Label()
        Me.txtAlimentPrincipal = New System.Windows.Forms.TextBox()
        Me.lblAliment = New System.Windows.Forms.Label()
        Me.btnChoisir = New System.Windows.Forms.Button()
        CType(Me.picTitre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHistorique, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picTitre
        '
        Me.picTitre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picTitre.Image = Global.OnMange.My.Resources.Resources.logo_long
        Me.picTitre.Location = New System.Drawing.Point(256, 6)
        Me.picTitre.Name = "picTitre"
        Me.picTitre.Size = New System.Drawing.Size(222, 95)
        Me.picTitre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTitre.TabIndex = 13
        Me.picTitre.TabStop = False
        '
        'lblMangerTitre
        '
        Me.lblMangerTitre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMangerTitre.AutoSize = True
        Me.lblMangerTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblMangerTitre.Location = New System.Drawing.Point(210, 113)
        Me.lblMangerTitre.Name = "lblMangerTitre"
        Me.lblMangerTitre.Size = New System.Drawing.Size(315, 26)
        Me.lblMangerTitre.TabIndex = 0
        Me.lblMangerTitre.Text = "Consulter l'historique des repas"
        '
        'lblCritere
        '
        Me.lblCritere.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCritere.AutoSize = True
        Me.lblCritere.Location = New System.Drawing.Point(267, 148)
        Me.lblCritere.Name = "lblCritere"
        Me.lblCritere.Size = New System.Drawing.Size(200, 20)
        Me.lblCritere.TabIndex = 1
        Me.lblCritere.Text = "Aucun critère de recherche"
        '
        'dgvHistorique
        '
        Me.dgvHistorique.AllowUserToAddRows = False
        Me.dgvHistorique.AllowUserToDeleteRows = False
        Me.dgvHistorique.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvHistorique.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHistorique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistorique.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPlat, Me.colAlimentsPrincipaux, Me.colOrigine, Me.colMangeLe, Me.colNote})
        Me.dgvHistorique.Location = New System.Drawing.Point(12, 171)
        Me.dgvHistorique.Name = "dgvHistorique"
        Me.dgvHistorique.ReadOnly = True
        Me.dgvHistorique.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHistorique.Size = New System.Drawing.Size(710, 263)
        Me.dgvHistorique.TabIndex = 2
        '
        'colPlat
        '
        Me.colPlat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPlat.HeaderText = "Plat"
        Me.colPlat.Name = "colPlat"
        Me.colPlat.ReadOnly = True
        Me.colPlat.ToolTipText = "Intitulé du plat"
        '
        'colAlimentsPrincipaux
        '
        Me.colAlimentsPrincipaux.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colAlimentsPrincipaux.HeaderText = "Aliments principaux"
        Me.colAlimentsPrincipaux.Name = "colAlimentsPrincipaux"
        Me.colAlimentsPrincipaux.ReadOnly = True
        Me.colAlimentsPrincipaux.ToolTipText = "Aliments principaux composant le plat"
        '
        'colOrigine
        '
        Me.colOrigine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colOrigine.HeaderText = "Origine"
        Me.colOrigine.Name = "colOrigine"
        Me.colOrigine.ReadOnly = True
        Me.colOrigine.ToolTipText = "Origine du plat"
        '
        'colMangeLe
        '
        Me.colMangeLe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colMangeLe.HeaderText = "Mangé le"
        Me.colMangeLe.Name = "colMangeLe"
        Me.colMangeLe.ReadOnly = True
        Me.colMangeLe.ToolTipText = "Dernière date à laquelle ce plat a été mangé"
        '
        'colNote
        '
        Me.colNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNote.HeaderText = "Note moyenne"
        Me.colNote.Name = "colNote"
        Me.colNote.ReadOnly = True
        Me.colNote.ToolTipText = "Note moyenne attribuée par les membre de la famille"
        '
        'lblOuPlus
        '
        Me.lblOuPlus.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblOuPlus.AutoSize = True
        Me.lblOuPlus.Location = New System.Drawing.Point(472, 481)
        Me.lblOuPlus.Name = "lblOuPlus"
        Me.lblOuPlus.Size = New System.Drawing.Size(60, 20)
        Me.lblOuPlus.TabIndex = 9
        Me.lblOuPlus.Text = "ou plus"
        '
        'cmdRechercher
        '
        Me.cmdRechercher.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdRechercher.Location = New System.Drawing.Point(295, 520)
        Me.cmdRechercher.Name = "cmdRechercher"
        Me.cmdRechercher.Size = New System.Drawing.Size(144, 35)
        Me.cmdRechercher.TabIndex = 10
        Me.cmdRechercher.Text = "&Rechercher"
        Me.cmdRechercher.UseVisualStyleBackColor = True
        '
        'cboPasMange
        '
        Me.cboPasMange.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cboPasMange.FormattingEnabled = True
        Me.cboPasMange.Items.AddRange(New Object() {"Cinq jours", "Deux semaines", "Un jour", "Un mois", "Une semaine"})
        Me.cboPasMange.Location = New System.Drawing.Point(345, 478)
        Me.cboPasMange.Name = "cboPasMange"
        Me.cboPasMange.Size = New System.Drawing.Size(121, 28)
        Me.cboPasMange.TabIndex = 8
        '
        'lblPasMange
        '
        Me.lblPasMange.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblPasMange.AutoSize = True
        Me.lblPasMange.Location = New System.Drawing.Point(202, 481)
        Me.lblPasMange.Name = "lblPasMange"
        Me.lblPasMange.Size = New System.Drawing.Size(140, 20)
        Me.lblPasMange.TabIndex = 7
        Me.lblPasMange.Text = "&Pas mangé depuis"
        '
        'cboMangerOrigine
        '
        Me.cboMangerOrigine.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cboMangerOrigine.FormattingEnabled = True
        Me.cboMangerOrigine.Items.AddRange(New Object() {"Europe", "Amérique du Nord", "Amérique du Sud", "Asie", "Afrique", "Océanie"})
        Me.cboMangerOrigine.Location = New System.Drawing.Point(439, 440)
        Me.cboMangerOrigine.Name = "cboMangerOrigine"
        Me.cboMangerOrigine.Size = New System.Drawing.Size(158, 28)
        Me.cboMangerOrigine.TabIndex = 6
        '
        'lblOrigine
        '
        Me.lblOrigine.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblOrigine.AutoSize = True
        Me.lblOrigine.Location = New System.Drawing.Point(374, 443)
        Me.lblOrigine.Name = "lblOrigine"
        Me.lblOrigine.Size = New System.Drawing.Size(59, 20)
        Me.lblOrigine.TabIndex = 5
        Me.lblOrigine.Text = "&Origine"
        '
        'txtAlimentPrincipal
        '
        Me.txtAlimentPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtAlimentPrincipal.Location = New System.Drawing.Point(268, 440)
        Me.txtAlimentPrincipal.Name = "txtAlimentPrincipal"
        Me.txtAlimentPrincipal.Size = New System.Drawing.Size(100, 26)
        Me.txtAlimentPrincipal.TabIndex = 4
        '
        'lblAliment
        '
        Me.lblAliment.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblAliment.AutoSize = True
        Me.lblAliment.Location = New System.Drawing.Point(138, 443)
        Me.lblAliment.Name = "lblAliment"
        Me.lblAliment.Size = New System.Drawing.Size(124, 20)
        Me.lblAliment.TabIndex = 3
        Me.lblAliment.Text = "&Aliment principal"
        '
        'btnChoisir
        '
        Me.btnChoisir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChoisir.Location = New System.Drawing.Point(633, 520)
        Me.btnChoisir.Name = "btnChoisir"
        Me.btnChoisir.Size = New System.Drawing.Size(89, 35)
        Me.btnChoisir.TabIndex = 11
        Me.btnChoisir.Text = "&Choisir"
        Me.btnChoisir.UseVisualStyleBackColor = True
        Me.btnChoisir.Visible = False
        '
        'FrmConsulter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 567)
        Me.Controls.Add(Me.btnChoisir)
        Me.Controls.Add(Me.lblOuPlus)
        Me.Controls.Add(Me.cmdRechercher)
        Me.Controls.Add(Me.cboPasMange)
        Me.Controls.Add(Me.lblPasMange)
        Me.Controls.Add(Me.cboMangerOrigine)
        Me.Controls.Add(Me.lblOrigine)
        Me.Controls.Add(Me.txtAlimentPrincipal)
        Me.Controls.Add(Me.lblAliment)
        Me.Controls.Add(Me.dgvHistorique)
        Me.Controls.Add(Me.lblCritere)
        Me.Controls.Add(Me.lblMangerTitre)
        Me.Controls.Add(Me.picTitre)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(750, 500)
        Me.Name = "FrmConsulter"
        Me.Text = "On Mange ! - Consulter l'historique"
        CType(Me.picTitre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHistorique, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picTitre As PictureBox
    Friend WithEvents lblMangerTitre As Label
    Friend WithEvents lblCritere As Label
    Friend WithEvents dgvHistorique As DataGridView
    Friend WithEvents lblOuPlus As Label
    Friend WithEvents cmdRechercher As Button
    Friend WithEvents cboPasMange As ComboBox
    Friend WithEvents lblPasMange As Label
    Friend WithEvents cboMangerOrigine As ComboBox
    Friend WithEvents lblOrigine As Label
    Friend WithEvents txtAlimentPrincipal As TextBox
    Friend WithEvents lblAliment As Label
    Friend WithEvents btnChoisir As Button
    Friend WithEvents colPlat As DataGridViewTextBoxColumn
    Friend WithEvents colAlimentsPrincipaux As DataGridViewTextBoxColumn
    Friend WithEvents colOrigine As DataGridViewTextBoxColumn
    Friend WithEvents colMangeLe As DataGridViewTextBoxColumn
    Friend WithEvents colNote As DataGridViewTextBoxColumn
End Class
