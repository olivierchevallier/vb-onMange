<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipale))
        Me.tbcTabController = New System.Windows.Forms.TabControl()
        Me.tabManger = New System.Windows.Forms.TabPage()
        Me.plaPropositionJour = New OnMange.PnlPlat()
        Me.cmdRechercher = New System.Windows.Forms.Button()
        Me.picManger = New System.Windows.Forms.PictureBox()
        Me.lblPropositionJour = New System.Windows.Forms.Label()
        Me.lblMangerTitre = New System.Windows.Forms.Label()
        Me.tabAjouter = New System.Windows.Forms.TabPage()
        Me.cmdSupAliments = New System.Windows.Forms.Button()
        Me.lblOu = New System.Windows.Forms.Label()
        Me.btnPlatExistant = New System.Windows.Forms.Button()
        Me.cmdEnregistrerAjouter = New System.Windows.Forms.Button()
        Me.cmdAjouterAliment = New System.Windows.Forms.Button()
        Me.cboAjouterOrigine = New System.Windows.Forms.ComboBox()
        Me.txtAlimentsPrincipaux = New System.Windows.Forms.TextBox()
        Me.txtPlat = New System.Windows.Forms.TextBox()
        Me.lblAjouterOrigine = New System.Windows.Forms.Label()
        Me.lblAjouterAliments = New System.Windows.Forms.Label()
        Me.lblAjouterPlat = New System.Windows.Forms.Label()
        Me.optAjouterSoir = New System.Windows.Forms.RadioButton()
        Me.optAjouterMidi = New System.Windows.Forms.RadioButton()
        Me.lblAjouterTitre = New System.Windows.Forms.Label()
        Me.picAjouter = New System.Windows.Forms.PictureBox()
        Me.tabNoter = New System.Windows.Forms.TabPage()
        Me.notNotePerso = New OnMange.Note()
        Me.PlaNoter = New OnMange.PnlPlat()
        Me.optSoir = New System.Windows.Forms.RadioButton()
        Me.optMidi = New System.Windows.Forms.RadioButton()
        Me.datNoterJour = New System.Windows.Forms.DateTimePicker()
        Me.cmdEnregistrerNote = New System.Windows.Forms.Button()
        Me.lblNoterNotePerso = New System.Windows.Forms.Label()
        Me.lblNoterTitre = New System.Windows.Forms.Label()
        Me.picNoter = New System.Windows.Forms.PictureBox()
        Me.tabPlanifier = New System.Windows.Forms.TabPage()
        Me.cmdEnregistrerVote = New System.Windows.Forms.Button()
        Me.lblPlanifierPropositions = New System.Windows.Forms.Label()
        Me.calPlanifier = New System.Windows.Forms.MonthCalendar()
        Me.lblPlanifierTitre = New System.Windows.Forms.Label()
        Me.picPlanifier = New System.Windows.Forms.PictureBox()
        Me.chplaPlanifier = New OnMange.ChoixPlat()
        Me.mnuPrincipalStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuAdministration = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeconnexion = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbcTabController.SuspendLayout()
        Me.tabManger.SuspendLayout()
        CType(Me.picManger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAjouter.SuspendLayout()
        CType(Me.picAjouter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabNoter.SuspendLayout()
        CType(Me.picNoter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPlanifier.SuspendLayout()
        CType(Me.picPlanifier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuPrincipalStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcTabController
        '
        Me.tbcTabController.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbcTabController.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tbcTabController.Controls.Add(Me.tabManger)
        Me.tbcTabController.Controls.Add(Me.tabAjouter)
        Me.tbcTabController.Controls.Add(Me.tabNoter)
        Me.tbcTabController.Controls.Add(Me.tabPlanifier)
        Me.tbcTabController.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcTabController.Location = New System.Drawing.Point(12, 27)
        Me.tbcTabController.Multiline = True
        Me.tbcTabController.Name = "tbcTabController"
        Me.tbcTabController.Padding = New System.Drawing.Point(10, 10)
        Me.tbcTabController.SelectedIndex = 0
        Me.tbcTabController.Size = New System.Drawing.Size(520, 523)
        Me.tbcTabController.TabIndex = 0
        '
        'tabManger
        '
        Me.tabManger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tabManger.Controls.Add(Me.plaPropositionJour)
        Me.tabManger.Controls.Add(Me.cmdRechercher)
        Me.tabManger.Controls.Add(Me.picManger)
        Me.tabManger.Controls.Add(Me.lblPropositionJour)
        Me.tabManger.Controls.Add(Me.lblMangerTitre)
        Me.tabManger.Location = New System.Drawing.Point(4, 46)
        Me.tabManger.Name = "tabManger"
        Me.tabManger.Padding = New System.Windows.Forms.Padding(3)
        Me.tabManger.Size = New System.Drawing.Size(512, 473)
        Me.tabManger.TabIndex = 0
        Me.tabManger.Text = "Manger"
        Me.tabManger.UseVisualStyleBackColor = True
        '
        'plaPropositionJour
        '
        Me.plaPropositionJour.BackColor = System.Drawing.Color.White
        Me.plaPropositionJour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.plaPropositionJour.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plaPropositionJour.Location = New System.Drawing.Point(117, 185)
        Me.plaPropositionJour.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.plaPropositionJour.Name = "plaPropositionJour"
        Me.plaPropositionJour.NomPlat = "Plat"
        Me.plaPropositionJour.Note = 0
        Me.plaPropositionJour.Origine = "Origine"
        Me.plaPropositionJour.Plat = Nothing
        Me.plaPropositionJour.Size = New System.Drawing.Size(279, 103)
        Me.plaPropositionJour.TabIndex = 13
        '
        'cmdRechercher
        '
        Me.cmdRechercher.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdRechercher.Location = New System.Drawing.Point(184, 425)
        Me.cmdRechercher.Name = "cmdRechercher"
        Me.cmdRechercher.Size = New System.Drawing.Size(144, 35)
        Me.cmdRechercher.TabIndex = 11
        Me.cmdRechercher.Text = "&Trouver un plat"
        Me.cmdRechercher.UseVisualStyleBackColor = True
        '
        'picManger
        '
        Me.picManger.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picManger.Image = Global.OnMange.My.Resources.Resources.logo_long
        Me.picManger.Location = New System.Drawing.Point(145, 6)
        Me.picManger.Name = "picManger"
        Me.picManger.Size = New System.Drawing.Size(222, 95)
        Me.picManger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picManger.TabIndex = 12
        Me.picManger.TabStop = False
        '
        'lblPropositionJour
        '
        Me.lblPropositionJour.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPropositionJour.AutoSize = True
        Me.lblPropositionJour.Location = New System.Drawing.Point(186, 153)
        Me.lblPropositionJour.Name = "lblPropositionJour"
        Me.lblPropositionJour.Size = New System.Drawing.Size(140, 20)
        Me.lblPropositionJour.TabIndex = 1
        Me.lblPropositionJour.Text = "Proposition du jour"
        '
        'lblMangerTitre
        '
        Me.lblMangerTitre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMangerTitre.AutoSize = True
        Me.lblMangerTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblMangerTitre.Location = New System.Drawing.Point(84, 113)
        Me.lblMangerTitre.Name = "lblMangerTitre"
        Me.lblMangerTitre.Size = New System.Drawing.Size(344, 26)
        Me.lblMangerTitre.TabIndex = 0
        Me.lblMangerTitre.Text = "Que mangeons-nous aujourd'hui ?"
        '
        'tabAjouter
        '
        Me.tabAjouter.Controls.Add(Me.cmdSupAliments)
        Me.tabAjouter.Controls.Add(Me.lblOu)
        Me.tabAjouter.Controls.Add(Me.btnPlatExistant)
        Me.tabAjouter.Controls.Add(Me.cmdEnregistrerAjouter)
        Me.tabAjouter.Controls.Add(Me.cmdAjouterAliment)
        Me.tabAjouter.Controls.Add(Me.cboAjouterOrigine)
        Me.tabAjouter.Controls.Add(Me.txtAlimentsPrincipaux)
        Me.tabAjouter.Controls.Add(Me.txtPlat)
        Me.tabAjouter.Controls.Add(Me.lblAjouterOrigine)
        Me.tabAjouter.Controls.Add(Me.lblAjouterAliments)
        Me.tabAjouter.Controls.Add(Me.lblAjouterPlat)
        Me.tabAjouter.Controls.Add(Me.optAjouterSoir)
        Me.tabAjouter.Controls.Add(Me.optAjouterMidi)
        Me.tabAjouter.Controls.Add(Me.lblAjouterTitre)
        Me.tabAjouter.Controls.Add(Me.picAjouter)
        Me.tabAjouter.Location = New System.Drawing.Point(4, 46)
        Me.tabAjouter.Name = "tabAjouter"
        Me.tabAjouter.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAjouter.Size = New System.Drawing.Size(512, 473)
        Me.tabAjouter.TabIndex = 1
        Me.tabAjouter.Text = "Ajouter"
        Me.tabAjouter.UseVisualStyleBackColor = True
        '
        'cmdSupAliments
        '
        Me.cmdSupAliments.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdSupAliments.Location = New System.Drawing.Point(443, 305)
        Me.cmdSupAliments.Name = "cmdSupAliments"
        Me.cmdSupAliments.Size = New System.Drawing.Size(31, 27)
        Me.cmdSupAliments.TabIndex = 8
        Me.cmdSupAliments.Text = "&-"
        Me.cmdSupAliments.UseVisualStyleBackColor = True
        '
        'lblOu
        '
        Me.lblOu.AutoSize = True
        Me.lblOu.Location = New System.Drawing.Point(241, 227)
        Me.lblOu.Name = "lblOu"
        Me.lblOu.Size = New System.Drawing.Size(30, 20)
        Me.lblOu.TabIndex = 36
        Me.lblOu.Text = "Ou"
        '
        'btnPlatExistant
        '
        Me.btnPlatExistant.Location = New System.Drawing.Point(156, 176)
        Me.btnPlatExistant.Name = "btnPlatExistant"
        Me.btnPlatExistant.Size = New System.Drawing.Size(201, 35)
        Me.btnPlatExistant.TabIndex = 2
        Me.btnPlatExistant.Text = "&Choisir dans l'historique"
        Me.btnPlatExistant.UseVisualStyleBackColor = True
        '
        'cmdEnregistrerAjouter
        '
        Me.cmdEnregistrerAjouter.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdEnregistrerAjouter.Enabled = False
        Me.cmdEnregistrerAjouter.Location = New System.Drawing.Point(170, 425)
        Me.cmdEnregistrerAjouter.Name = "cmdEnregistrerAjouter"
        Me.cmdEnregistrerAjouter.Size = New System.Drawing.Size(172, 35)
        Me.cmdEnregistrerAjouter.TabIndex = 11
        Me.cmdEnregistrerAjouter.Text = "&Enregistrer ma saisie"
        Me.cmdEnregistrerAjouter.UseVisualStyleBackColor = True
        '
        'cmdAjouterAliment
        '
        Me.cmdAjouterAliment.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdAjouterAliment.Location = New System.Drawing.Point(406, 305)
        Me.cmdAjouterAliment.Name = "cmdAjouterAliment"
        Me.cmdAjouterAliment.Size = New System.Drawing.Size(31, 27)
        Me.cmdAjouterAliment.TabIndex = 7
        Me.cmdAjouterAliment.Text = "&+"
        Me.cmdAjouterAliment.UseVisualStyleBackColor = True
        '
        'cboAjouterOrigine
        '
        Me.cboAjouterOrigine.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboAjouterOrigine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAjouterOrigine.FormattingEnabled = True
        Me.cboAjouterOrigine.Items.AddRange(New Object() {"Europe", "Amérique du Nord", "Amérique du Sud", "Asie", "Afrique", "Océanie"})
        Me.cboAjouterOrigine.Location = New System.Drawing.Point(264, 348)
        Me.cboAjouterOrigine.Name = "cboAjouterOrigine"
        Me.cboAjouterOrigine.Size = New System.Drawing.Size(136, 28)
        Me.cboAjouterOrigine.TabIndex = 10
        '
        'txtAlimentsPrincipaux
        '
        Me.txtAlimentsPrincipaux.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtAlimentsPrincipaux.Location = New System.Drawing.Point(264, 305)
        Me.txtAlimentsPrincipaux.Name = "txtAlimentsPrincipaux"
        Me.txtAlimentsPrincipaux.Size = New System.Drawing.Size(136, 26)
        Me.txtAlimentsPrincipaux.TabIndex = 6
        '
        'txtPlat
        '
        Me.txtPlat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPlat.Location = New System.Drawing.Point(264, 264)
        Me.txtPlat.Name = "txtPlat"
        Me.txtPlat.Size = New System.Drawing.Size(136, 26)
        Me.txtPlat.TabIndex = 4
        '
        'lblAjouterOrigine
        '
        Me.lblAjouterOrigine.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAjouterOrigine.AutoSize = True
        Me.lblAjouterOrigine.Location = New System.Drawing.Point(113, 351)
        Me.lblAjouterOrigine.Name = "lblAjouterOrigine"
        Me.lblAjouterOrigine.Size = New System.Drawing.Size(59, 20)
        Me.lblAjouterOrigine.TabIndex = 9
        Me.lblAjouterOrigine.Text = "&Origine"
        '
        'lblAjouterAliments
        '
        Me.lblAjouterAliments.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAjouterAliments.AutoSize = True
        Me.lblAjouterAliments.Location = New System.Drawing.Point(113, 308)
        Me.lblAjouterAliments.Name = "lblAjouterAliments"
        Me.lblAjouterAliments.Size = New System.Drawing.Size(145, 20)
        Me.lblAjouterAliments.TabIndex = 5
        Me.lblAjouterAliments.Text = "&Aliments principaux"
        '
        'lblAjouterPlat
        '
        Me.lblAjouterPlat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAjouterPlat.AutoSize = True
        Me.lblAjouterPlat.Location = New System.Drawing.Point(113, 267)
        Me.lblAjouterPlat.Name = "lblAjouterPlat"
        Me.lblAjouterPlat.Size = New System.Drawing.Size(36, 20)
        Me.lblAjouterPlat.TabIndex = 3
        Me.lblAjouterPlat.Text = "&Plat"
        '
        'optAjouterSoir
        '
        Me.optAjouterSoir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.optAjouterSoir.AutoSize = True
        Me.optAjouterSoir.Location = New System.Drawing.Point(261, 146)
        Me.optAjouterSoir.Name = "optAjouterSoir"
        Me.optAjouterSoir.Size = New System.Drawing.Size(125, 24)
        Me.optAjouterSoir.TabIndex = 1
        Me.optAjouterSoir.Text = "&Repas du soir"
        Me.optAjouterSoir.UseVisualStyleBackColor = True
        '
        'optAjouterMidi
        '
        Me.optAjouterMidi.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.optAjouterMidi.AutoSize = True
        Me.optAjouterMidi.Checked = True
        Me.optAjouterMidi.Location = New System.Drawing.Point(127, 146)
        Me.optAjouterMidi.Name = "optAjouterMidi"
        Me.optAjouterMidi.Size = New System.Drawing.Size(128, 24)
        Me.optAjouterMidi.TabIndex = 0
        Me.optAjouterMidi.TabStop = True
        Me.optAjouterMidi.Text = "&Repas de midi"
        Me.optAjouterMidi.UseVisualStyleBackColor = True
        '
        'lblAjouterTitre
        '
        Me.lblAjouterTitre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAjouterTitre.AutoSize = True
        Me.lblAjouterTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblAjouterTitre.Location = New System.Drawing.Point(77, 113)
        Me.lblAjouterTitre.Name = "lblAjouterTitre"
        Me.lblAjouterTitre.Size = New System.Drawing.Size(358, 26)
        Me.lblAjouterTitre.TabIndex = 0
        Me.lblAjouterTitre.Text = "Qu'avons nous mangé aujourd'hui ?"
        '
        'picAjouter
        '
        Me.picAjouter.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picAjouter.Image = Global.OnMange.My.Resources.Resources.logo_long
        Me.picAjouter.Location = New System.Drawing.Point(145, 6)
        Me.picAjouter.Name = "picAjouter"
        Me.picAjouter.Size = New System.Drawing.Size(222, 95)
        Me.picAjouter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAjouter.TabIndex = 13
        Me.picAjouter.TabStop = False
        '
        'tabNoter
        '
        Me.tabNoter.Controls.Add(Me.notNotePerso)
        Me.tabNoter.Controls.Add(Me.PlaNoter)
        Me.tabNoter.Controls.Add(Me.optSoir)
        Me.tabNoter.Controls.Add(Me.optMidi)
        Me.tabNoter.Controls.Add(Me.datNoterJour)
        Me.tabNoter.Controls.Add(Me.cmdEnregistrerNote)
        Me.tabNoter.Controls.Add(Me.lblNoterNotePerso)
        Me.tabNoter.Controls.Add(Me.lblNoterTitre)
        Me.tabNoter.Controls.Add(Me.picNoter)
        Me.tabNoter.Location = New System.Drawing.Point(4, 46)
        Me.tabNoter.Name = "tabNoter"
        Me.tabNoter.Size = New System.Drawing.Size(512, 473)
        Me.tabNoter.TabIndex = 2
        Me.tabNoter.Text = "Noter"
        Me.tabNoter.UseVisualStyleBackColor = True
        '
        'notNotePerso
        '
        Me.notNotePerso.BackColor = System.Drawing.Color.Transparent
        Me.notNotePerso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notNotePerso.LectureSeule = False
        Me.notNotePerso.Location = New System.Drawing.Point(169, 347)
        Me.notNotePerso.Name = "notNotePerso"
        Me.notNotePerso.Note = 0
        Me.notNotePerso.Size = New System.Drawing.Size(174, 30)
        Me.notNotePerso.TabIndex = 39
        '
        'PlaNoter
        '
        Me.PlaNoter.BackColor = System.Drawing.Color.White
        Me.PlaNoter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PlaNoter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaNoter.Location = New System.Drawing.Point(117, 185)
        Me.PlaNoter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PlaNoter.Name = "PlaNoter"
        Me.PlaNoter.NomPlat = "Plat"
        Me.PlaNoter.Note = 0
        Me.PlaNoter.Origine = "Origine"
        Me.PlaNoter.Plat = Nothing
        Me.PlaNoter.Size = New System.Drawing.Size(279, 103)
        Me.PlaNoter.TabIndex = 38
        '
        'optSoir
        '
        Me.optSoir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.optSoir.AutoSize = True
        Me.optSoir.Location = New System.Drawing.Point(319, 150)
        Me.optSoir.Name = "optSoir"
        Me.optSoir.Size = New System.Drawing.Size(55, 24)
        Me.optSoir.TabIndex = 37
        Me.optSoir.Text = "Soir"
        Me.optSoir.UseVisualStyleBackColor = True
        '
        'optMidi
        '
        Me.optMidi.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.optMidi.AutoSize = True
        Me.optMidi.Checked = True
        Me.optMidi.Location = New System.Drawing.Point(258, 150)
        Me.optMidi.Name = "optMidi"
        Me.optMidi.Size = New System.Drawing.Size(55, 24)
        Me.optMidi.TabIndex = 36
        Me.optMidi.TabStop = True
        Me.optMidi.Text = "Midi"
        Me.optMidi.UseVisualStyleBackColor = True
        '
        'datNoterJour
        '
        Me.datNoterJour.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.datNoterJour.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datNoterJour.Location = New System.Drawing.Point(148, 147)
        Me.datNoterJour.Name = "datNoterJour"
        Me.datNoterJour.Size = New System.Drawing.Size(104, 26)
        Me.datNoterJour.TabIndex = 35
        '
        'cmdEnregistrerNote
        '
        Me.cmdEnregistrerNote.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdEnregistrerNote.Location = New System.Drawing.Point(170, 425)
        Me.cmdEnregistrerNote.Name = "cmdEnregistrerNote"
        Me.cmdEnregistrerNote.Size = New System.Drawing.Size(172, 35)
        Me.cmdEnregistrerNote.TabIndex = 3
        Me.cmdEnregistrerNote.Text = "&Enregistrer ma saisie"
        Me.cmdEnregistrerNote.UseVisualStyleBackColor = True
        '
        'lblNoterNotePerso
        '
        Me.lblNoterNotePerso.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNoterNotePerso.AutoSize = True
        Me.lblNoterNotePerso.Location = New System.Drawing.Point(190, 324)
        Me.lblNoterNotePerso.Name = "lblNoterNotePerso"
        Me.lblNoterNotePerso.Size = New System.Drawing.Size(133, 20)
        Me.lblNoterNotePerso.TabIndex = 2
        Me.lblNoterNotePerso.Text = "Note personnelle "
        '
        'lblNoterTitre
        '
        Me.lblNoterTitre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNoterTitre.AutoSize = True
        Me.lblNoterTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblNoterTitre.Location = New System.Drawing.Point(128, 113)
        Me.lblNoterTitre.Name = "lblNoterTitre"
        Me.lblNoterTitre.Size = New System.Drawing.Size(256, 26)
        Me.lblNoterTitre.TabIndex = 0
        Me.lblNoterTitre.Text = "Comment était le repas ?"
        '
        'picNoter
        '
        Me.picNoter.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picNoter.Image = Global.OnMange.My.Resources.Resources.logo_long
        Me.picNoter.Location = New System.Drawing.Point(145, 6)
        Me.picNoter.Name = "picNoter"
        Me.picNoter.Size = New System.Drawing.Size(222, 95)
        Me.picNoter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picNoter.TabIndex = 13
        Me.picNoter.TabStop = False
        '
        'tabPlanifier
        '
        Me.tabPlanifier.Controls.Add(Me.cmdEnregistrerVote)
        Me.tabPlanifier.Controls.Add(Me.lblPlanifierPropositions)
        Me.tabPlanifier.Controls.Add(Me.calPlanifier)
        Me.tabPlanifier.Controls.Add(Me.lblPlanifierTitre)
        Me.tabPlanifier.Controls.Add(Me.picPlanifier)
        Me.tabPlanifier.Controls.Add(Me.chplaPlanifier)
        Me.tabPlanifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPlanifier.Location = New System.Drawing.Point(4, 46)
        Me.tabPlanifier.Name = "tabPlanifier"
        Me.tabPlanifier.Size = New System.Drawing.Size(512, 473)
        Me.tabPlanifier.TabIndex = 3
        Me.tabPlanifier.Text = "Planifier"
        Me.tabPlanifier.UseVisualStyleBackColor = True
        '
        'cmdEnregistrerVote
        '
        Me.cmdEnregistrerVote.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdEnregistrerVote.Location = New System.Drawing.Point(170, 425)
        Me.cmdEnregistrerVote.Name = "cmdEnregistrerVote"
        Me.cmdEnregistrerVote.Size = New System.Drawing.Size(172, 35)
        Me.cmdEnregistrerVote.TabIndex = 35
        Me.cmdEnregistrerVote.Text = "&Enregistrer mon vote"
        Me.cmdEnregistrerVote.UseVisualStyleBackColor = True
        '
        'lblPlanifierPropositions
        '
        Me.lblPlanifierPropositions.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPlanifierPropositions.AutoSize = True
        Me.lblPlanifierPropositions.Location = New System.Drawing.Point(208, 312)
        Me.lblPlanifierPropositions.Name = "lblPlanifierPropositions"
        Me.lblPlanifierPropositions.Size = New System.Drawing.Size(96, 20)
        Me.lblPlanifierPropositions.TabIndex = 14
        Me.lblPlanifierPropositions.Text = "Propositions"
        '
        'calPlanifier
        '
        Me.calPlanifier.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.calPlanifier.Location = New System.Drawing.Point(143, 148)
        Me.calPlanifier.MinimumSize = New System.Drawing.Size(228, 162)
        Me.calPlanifier.Name = "calPlanifier"
        Me.calPlanifier.TabIndex = 0
        '
        'lblPlanifierTitre
        '
        Me.lblPlanifierTitre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPlanifierTitre.AutoSize = True
        Me.lblPlanifierTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblPlanifierTitre.Location = New System.Drawing.Point(30, 113)
        Me.lblPlanifierTitre.Name = "lblPlanifierTitre"
        Me.lblPlanifierTitre.Size = New System.Drawing.Size(447, 26)
        Me.lblPlanifierTitre.TabIndex = 2
        Me.lblPlanifierTitre.Text = "Qu'allons-nous manger ces prochains jours ?"
        '
        'picPlanifier
        '
        Me.picPlanifier.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picPlanifier.Image = Global.OnMange.My.Resources.Resources.logo_long
        Me.picPlanifier.Location = New System.Drawing.Point(145, 6)
        Me.picPlanifier.Name = "picPlanifier"
        Me.picPlanifier.Size = New System.Drawing.Size(222, 95)
        Me.picPlanifier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlanifier.TabIndex = 13
        Me.picPlanifier.TabStop = False
        '
        'chplaPlanifier
        '
        Me.chplaPlanifier.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chplaPlanifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.chplaPlanifier.Location = New System.Drawing.Point(-32, 261)
        Me.chplaPlanifier.Name = "chplaPlanifier"
        Me.chplaPlanifier.Size = New System.Drawing.Size(576, 228)
        Me.chplaPlanifier.TabIndex = 9
        '
        'mnuPrincipalStrip
        '
        Me.mnuPrincipalStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAdministration, Me.mnuDeconnexion})
        Me.mnuPrincipalStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuPrincipalStrip.Name = "mnuPrincipalStrip"
        Me.mnuPrincipalStrip.Size = New System.Drawing.Size(544, 24)
        Me.mnuPrincipalStrip.TabIndex = 1
        Me.mnuPrincipalStrip.Text = "MenuStrip1"
        '
        'mnuAdministration
        '
        Me.mnuAdministration.Name = "mnuAdministration"
        Me.mnuAdministration.Size = New System.Drawing.Size(98, 20)
        Me.mnuAdministration.Text = "&Administration"
        '
        'mnuDeconnexion
        '
        Me.mnuDeconnexion.Name = "mnuDeconnexion"
        Me.mnuDeconnexion.Size = New System.Drawing.Size(88, 20)
        Me.mnuDeconnexion.Text = "&Déconnexion"
        '
        'FrmPrincipale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 562)
        Me.Controls.Add(Me.tbcTabController)
        Me.Controls.Add(Me.mnuPrincipalStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuPrincipalStrip
        Me.Name = "FrmPrincipale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " On mange !"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.tbcTabController.ResumeLayout(False)
        Me.tabManger.ResumeLayout(False)
        Me.tabManger.PerformLayout()
        CType(Me.picManger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAjouter.ResumeLayout(False)
        Me.tabAjouter.PerformLayout()
        CType(Me.picAjouter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabNoter.ResumeLayout(False)
        Me.tabNoter.PerformLayout()
        CType(Me.picNoter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPlanifier.ResumeLayout(False)
        Me.tabPlanifier.PerformLayout()
        CType(Me.picPlanifier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuPrincipalStrip.ResumeLayout(False)
        Me.mnuPrincipalStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbcTabController As TabControl
    Friend WithEvents tabManger As TabPage
    Friend WithEvents tabAjouter As TabPage
    Friend WithEvents tabNoter As TabPage
    Friend WithEvents tabPlanifier As TabPage
    Friend WithEvents lblMangerTitre As Label
    Friend WithEvents lblAjouterTitre As Label
    Friend WithEvents lblNoterTitre As Label
    Friend WithEvents lblPlanifierTitre As Label
    Friend WithEvents lblPropositionJour As Label
    Friend WithEvents cmdRechercher As Button
    Friend WithEvents picManger As PictureBox
    Friend WithEvents picAjouter As PictureBox
    Friend WithEvents picNoter As PictureBox
    Friend WithEvents picPlanifier As PictureBox
    Friend WithEvents cmdEnregistrerAjouter As Button
    Friend WithEvents cmdAjouterAliment As Button
    Friend WithEvents cboAjouterOrigine As ComboBox
    Friend WithEvents txtAlimentsPrincipaux As TextBox
    Friend WithEvents txtPlat As TextBox
    Friend WithEvents lblAjouterOrigine As Label
    Friend WithEvents lblAjouterAliments As Label
    Friend WithEvents lblAjouterPlat As Label
    Friend WithEvents optAjouterSoir As RadioButton
    Friend WithEvents optAjouterMidi As RadioButton
    Friend WithEvents cmdEnregistrerNote As Button
    Friend WithEvents lblNoterNotePerso As Label
    Friend WithEvents lblPlanifierPropositions As Label
    Friend WithEvents calPlanifier As MonthCalendar
    Friend WithEvents cmdEnregistrerVote As Button
    Friend WithEvents mnuPrincipalStrip As MenuStrip
    Friend WithEvents mnuDeconnexion As ToolStripMenuItem
    Friend WithEvents mnuAdministration As ToolStripMenuItem
    Friend WithEvents optSoir As RadioButton
    Friend WithEvents optMidi As RadioButton
    Friend WithEvents datNoterJour As DateTimePicker
    Friend WithEvents lblOu As Label
    Friend WithEvents btnPlatExistant As Button
    Friend WithEvents plaPropositionJour As PnlPlat
    Friend WithEvents PlaNoter As PnlPlat
    Friend WithEvents notNotePerso As Note
    Friend WithEvents chplaPlanifier As ChoixPlat
    Friend WithEvents cmdSupAliments As Button
End Class
