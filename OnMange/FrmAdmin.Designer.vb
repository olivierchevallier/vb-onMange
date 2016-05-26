<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdmin
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
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Romain", 0)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Ophélie", "people.png")
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Olivier", 0)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Clothilde", 0)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Benoît", 0)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdmin))
        Me.lblAdminTitre = New System.Windows.Forms.Label()
        Me.lblAdminNom = New System.Windows.Forms.Label()
        Me.txtAdminNom = New System.Windows.Forms.TextBox()
        Me.lstUtilisateurs = New System.Windows.Forms.ListView()
        Me.mnuAdminContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuAminContextSupprimer = New System.Windows.Forms.ToolStripMenuItem()
        Me.imgLstUtilisateurs = New System.Windows.Forms.ImageList(Me.components)
        Me.lblAdminMembres = New System.Windows.Forms.Label()
        Me.lblAdminPrenom = New System.Windows.Forms.Label()
        Me.txtAdminPrenom = New System.Windows.Forms.TextBox()
        Me.lblAdminDateNaissance = New System.Windows.Forms.Label()
        Me.datAdminDateNaissance = New System.Windows.Forms.DateTimePicker()
        Me.lblAdminAutorisations = New System.Windows.Forms.Label()
        Me.cbxAdminAutorisations = New System.Windows.Forms.ComboBox()
        Me.btnEditer = New System.Windows.Forms.Button()
        Me.mnuAdminStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuAdminStripEdition = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnAdminStripSupprimer = New System.Windows.Forms.ToolStripMenuItem()
        Me.picManger = New System.Windows.Forms.PictureBox()
        Me.mnuAdminContext.SuspendLayout()
        Me.mnuAdminStrip.SuspendLayout()
        CType(Me.picManger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAdminTitre
        '
        Me.lblAdminTitre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAdminTitre.AutoSize = True
        Me.lblAdminTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblAdminTitre.Location = New System.Drawing.Point(201, 134)
        Me.lblAdminTitre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdminTitre.Name = "lblAdminTitre"
        Me.lblAdminTitre.Size = New System.Drawing.Size(151, 26)
        Me.lblAdminTitre.TabIndex = 0
        Me.lblAdminTitre.Text = "Administration"
        '
        'lblAdminNom
        '
        Me.lblAdminNom.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAdminNom.AutoSize = True
        Me.lblAdminNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblAdminNom.Location = New System.Drawing.Point(118, 169)
        Me.lblAdminNom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdminNom.Name = "lblAdminNom"
        Me.lblAdminNom.Size = New System.Drawing.Size(121, 20)
        Me.lblAdminNom.TabIndex = 1
        Me.lblAdminNom.Text = "&Nom de famille :"
        '
        'txtAdminNom
        '
        Me.txtAdminNom.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtAdminNom.Enabled = False
        Me.txtAdminNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtAdminNom.Location = New System.Drawing.Point(247, 166)
        Me.txtAdminNom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAdminNom.Name = "txtAdminNom"
        Me.txtAdminNom.Size = New System.Drawing.Size(187, 26)
        Me.txtAdminNom.TabIndex = 2
        Me.txtAdminNom.Text = "Chevallier"
        '
        'lstUtilisateurs
        '
        Me.lstUtilisateurs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstUtilisateurs.BackColor = System.Drawing.Color.White
        Me.lstUtilisateurs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstUtilisateurs.ContextMenuStrip = Me.mnuAdminContext
        Me.lstUtilisateurs.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10})
        Me.lstUtilisateurs.LargeImageList = Me.imgLstUtilisateurs
        Me.lstUtilisateurs.Location = New System.Drawing.Point(12, 230)
        Me.lstUtilisateurs.MultiSelect = False
        Me.lstUtilisateurs.Name = "lstUtilisateurs"
        Me.lstUtilisateurs.Size = New System.Drawing.Size(531, 218)
        Me.lstUtilisateurs.TabIndex = 4
        Me.lstUtilisateurs.UseCompatibleStateImageBehavior = False
        '
        'mnuAdminContext
        '
        Me.mnuAdminContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAminContextSupprimer})
        Me.mnuAdminContext.Name = "mnuAdminContext"
        Me.mnuAdminContext.Size = New System.Drawing.Size(130, 26)
        '
        'mnuAminContextSupprimer
        '
        Me.mnuAminContextSupprimer.Name = "mnuAminContextSupprimer"
        Me.mnuAminContextSupprimer.Size = New System.Drawing.Size(152, 22)
        Me.mnuAminContextSupprimer.Text = "Supprimer"
        '
        'imgLstUtilisateurs
        '
        Me.imgLstUtilisateurs.ImageStream = CType(resources.GetObject("imgLstUtilisateurs.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgLstUtilisateurs.TransparentColor = System.Drawing.Color.Transparent
        Me.imgLstUtilisateurs.Images.SetKeyName(0, "people.png")
        '
        'lblAdminMembres
        '
        Me.lblAdminMembres.AutoSize = True
        Me.lblAdminMembres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblAdminMembres.Location = New System.Drawing.Point(12, 207)
        Me.lblAdminMembres.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdminMembres.Name = "lblAdminMembres"
        Me.lblAdminMembres.Size = New System.Drawing.Size(162, 20)
        Me.lblAdminMembres.TabIndex = 3
        Me.lblAdminMembres.Text = "Membres de la famille"
        '
        'lblAdminPrenom
        '
        Me.lblAdminPrenom.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblAdminPrenom.AutoSize = True
        Me.lblAdminPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblAdminPrenom.Location = New System.Drawing.Point(13, 463)
        Me.lblAdminPrenom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdminPrenom.Name = "lblAdminPrenom"
        Me.lblAdminPrenom.Size = New System.Drawing.Size(72, 20)
        Me.lblAdminPrenom.TabIndex = 5
        Me.lblAdminPrenom.Text = "&Prénom :"
        '
        'txtAdminPrenom
        '
        Me.txtAdminPrenom.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtAdminPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtAdminPrenom.Location = New System.Drawing.Point(139, 460)
        Me.txtAdminPrenom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAdminPrenom.Name = "txtAdminPrenom"
        Me.txtAdminPrenom.Size = New System.Drawing.Size(120, 26)
        Me.txtAdminPrenom.TabIndex = 6
        '
        'lblAdminDateNaissance
        '
        Me.lblAdminDateNaissance.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblAdminDateNaissance.AutoSize = True
        Me.lblAdminDateNaissance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblAdminDateNaissance.Location = New System.Drawing.Point(276, 463)
        Me.lblAdminDateNaissance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdminDateNaissance.Name = "lblAdminDateNaissance"
        Me.lblAdminDateNaissance.Size = New System.Drawing.Size(142, 20)
        Me.lblAdminDateNaissance.TabIndex = 7
        Me.lblAdminDateNaissance.Text = "&Date de naissance"
        '
        'datAdminDateNaissance
        '
        Me.datAdminDateNaissance.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.datAdminDateNaissance.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datAdminDateNaissance.Location = New System.Drawing.Point(425, 458)
        Me.datAdminDateNaissance.Name = "datAdminDateNaissance"
        Me.datAdminDateNaissance.Size = New System.Drawing.Size(118, 26)
        Me.datAdminDateNaissance.TabIndex = 8
        '
        'lblAdminAutorisations
        '
        Me.lblAdminAutorisations.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblAdminAutorisations.AutoSize = True
        Me.lblAdminAutorisations.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblAdminAutorisations.Location = New System.Drawing.Point(13, 507)
        Me.lblAdminAutorisations.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdminAutorisations.Name = "lblAdminAutorisations"
        Me.lblAdminAutorisations.Size = New System.Drawing.Size(110, 20)
        Me.lblAdminAutorisations.TabIndex = 9
        Me.lblAdminAutorisations.Text = "&Autorisations :"
        '
        'cbxAdminAutorisations
        '
        Me.cbxAdminAutorisations.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cbxAdminAutorisations.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxAdminAutorisations.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxAdminAutorisations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAdminAutorisations.FormattingEnabled = True
        Me.cbxAdminAutorisations.Items.AddRange(New Object() {"Noter", "Noter + Ajouter"})
        Me.cbxAdminAutorisations.Location = New System.Drawing.Point(139, 504)
        Me.cbxAdminAutorisations.Name = "cbxAdminAutorisations"
        Me.cbxAdminAutorisations.Size = New System.Drawing.Size(120, 28)
        Me.cbxAdminAutorisations.TabIndex = 10
        '
        'btnEditer
        '
        Me.btnEditer.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEditer.Location = New System.Drawing.Point(280, 504)
        Me.btnEditer.Name = "btnEditer"
        Me.btnEditer.Size = New System.Drawing.Size(263, 31)
        Me.btnEditer.TabIndex = 11
        Me.btnEditer.Text = "&Ajouter un nouveau membre"
        Me.btnEditer.UseVisualStyleBackColor = True
        '
        'mnuAdminStrip
        '
        Me.mnuAdminStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAdminStripEdition})
        Me.mnuAdminStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuAdminStrip.Name = "mnuAdminStrip"
        Me.mnuAdminStrip.Size = New System.Drawing.Size(555, 24)
        Me.mnuAdminStrip.TabIndex = 28
        Me.mnuAdminStrip.Text = "MenuStrip1"
        '
        'mnuAdminStripEdition
        '
        Me.mnuAdminStripEdition.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnAdminStripSupprimer})
        Me.mnuAdminStripEdition.Name = "mnuAdminStripEdition"
        Me.mnuAdminStripEdition.Size = New System.Drawing.Size(56, 20)
        Me.mnuAdminStripEdition.Text = "&Edition"
        '
        'mnAdminStripSupprimer
        '
        Me.mnAdminStripSupprimer.Enabled = False
        Me.mnAdminStripSupprimer.Name = "mnAdminStripSupprimer"
        Me.mnAdminStripSupprimer.Size = New System.Drawing.Size(129, 22)
        Me.mnAdminStripSupprimer.Text = "&Supprimer"
        '
        'picManger
        '
        Me.picManger.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picManger.Image = Global.OnMange.My.Resources.Resources.logo_long
        Me.picManger.Location = New System.Drawing.Point(165, 27)
        Me.picManger.Name = "picManger"
        Me.picManger.Size = New System.Drawing.Size(222, 95)
        Me.picManger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picManger.TabIndex = 17
        Me.picManger.TabStop = False
        '
        'FrmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 547)
        Me.Controls.Add(Me.mnuAdminStrip)
        Me.Controls.Add(Me.btnEditer)
        Me.Controls.Add(Me.cbxAdminAutorisations)
        Me.Controls.Add(Me.lblAdminAutorisations)
        Me.Controls.Add(Me.datAdminDateNaissance)
        Me.Controls.Add(Me.lblAdminDateNaissance)
        Me.Controls.Add(Me.txtAdminPrenom)
        Me.Controls.Add(Me.lblAdminPrenom)
        Me.Controls.Add(Me.lblAdminMembres)
        Me.Controls.Add(Me.lstUtilisateurs)
        Me.Controls.Add(Me.picManger)
        Me.Controls.Add(Me.txtAdminNom)
        Me.Controls.Add(Me.lblAdminNom)
        Me.Controls.Add(Me.lblAdminTitre)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuAdminStrip
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(571, 585)
        Me.Name = "FrmAdmin"
        Me.Text = "On mange ! - Administration"
        Me.mnuAdminContext.ResumeLayout(False)
        Me.mnuAdminStrip.ResumeLayout(False)
        Me.mnuAdminStrip.PerformLayout()
        CType(Me.picManger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAdminTitre As Label
    Friend WithEvents lblAdminNom As Label
    Friend WithEvents txtAdminNom As TextBox
    Friend WithEvents picManger As PictureBox
    Friend WithEvents lstUtilisateurs As ListView
    Friend WithEvents imgLstUtilisateurs As ImageList
    Friend WithEvents lblAdminMembres As Label
    Friend WithEvents lblAdminPrenom As Label
    Friend WithEvents txtAdminPrenom As TextBox
    Friend WithEvents lblAdminDateNaissance As Label
    Friend WithEvents datAdminDateNaissance As DateTimePicker
    Friend WithEvents lblAdminAutorisations As Label
    Friend WithEvents cbxAdminAutorisations As ComboBox
    Friend WithEvents btnEditer As Button
    Friend WithEvents mnuAdminContext As ContextMenuStrip
    Friend WithEvents mnuAminContextSupprimer As ToolStripMenuItem
    Friend WithEvents mnuAdminStrip As MenuStrip
    Friend WithEvents mnuAdminStripEdition As ToolStripMenuItem
    Friend WithEvents mnAdminStripSupprimer As ToolStripMenuItem
End Class
