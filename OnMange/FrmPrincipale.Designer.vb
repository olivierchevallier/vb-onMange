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
        Me.Note1 = New OnMange.Note()
        Me.lblOu = New System.Windows.Forms.Label()
        Me.btnPlatExistant = New System.Windows.Forms.Button()
        Me.lblAjouterNoteP = New System.Windows.Forms.Label()
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
        Me.pnlProposition3 = New System.Windows.Forms.Panel()
        Me.picProposition3Etoile5 = New System.Windows.Forms.PictureBox()
        Me.picProposition3Etoile2 = New System.Windows.Forms.PictureBox()
        Me.picProposition3Etoile3 = New System.Windows.Forms.PictureBox()
        Me.picProposition3Etoile4 = New System.Windows.Forms.PictureBox()
        Me.picProposition3Etoile1 = New System.Windows.Forms.PictureBox()
        Me.lblProposition3Note = New System.Windows.Forms.Label()
        Me.lblProposition3Origine = New System.Windows.Forms.Label()
        Me.lblProposition3Aliments = New System.Windows.Forms.Label()
        Me.lblProposition3Plat = New System.Windows.Forms.Label()
        Me.pnlProposition1 = New System.Windows.Forms.Panel()
        Me.picProposition1Etoile5 = New System.Windows.Forms.PictureBox()
        Me.picProposition1Etoile2 = New System.Windows.Forms.PictureBox()
        Me.picProposition1Etoile3 = New System.Windows.Forms.PictureBox()
        Me.picProposition1Etoile4 = New System.Windows.Forms.PictureBox()
        Me.picProposition1Etoile1 = New System.Windows.Forms.PictureBox()
        Me.lblProposition1Note = New System.Windows.Forms.Label()
        Me.lblProposition1Origine = New System.Windows.Forms.Label()
        Me.lblProposition1Aliments = New System.Windows.Forms.Label()
        Me.lblProposition1Plat = New System.Windows.Forms.Label()
        Me.pnlProposition4 = New System.Windows.Forms.Panel()
        Me.picProposition4Etoile5 = New System.Windows.Forms.PictureBox()
        Me.picProposition4Etoile2 = New System.Windows.Forms.PictureBox()
        Me.picProposition4Etoile3 = New System.Windows.Forms.PictureBox()
        Me.picProposition4Etoile4 = New System.Windows.Forms.PictureBox()
        Me.picProposition4Etoile1 = New System.Windows.Forms.PictureBox()
        Me.lblProposition4Note = New System.Windows.Forms.Label()
        Me.lblProposition4Origine = New System.Windows.Forms.Label()
        Me.lblProposition4Aliments = New System.Windows.Forms.Label()
        Me.lblProposition4Plat = New System.Windows.Forms.Label()
        Me.pnlProposition2 = New System.Windows.Forms.Panel()
        Me.picProposition2Etoile5 = New System.Windows.Forms.PictureBox()
        Me.picProposition2Etoile2 = New System.Windows.Forms.PictureBox()
        Me.picProposition2Etoile3 = New System.Windows.Forms.PictureBox()
        Me.picProposition2Etoile4 = New System.Windows.Forms.PictureBox()
        Me.picProposition2Etoile1 = New System.Windows.Forms.PictureBox()
        Me.lblProposition2Note = New System.Windows.Forms.Label()
        Me.lblProposition2Origine = New System.Windows.Forms.Label()
        Me.lblProposition2Aliments = New System.Windows.Forms.Label()
        Me.lblProposition2Plat = New System.Windows.Forms.Label()
        Me.lblPlanifierPropositions = New System.Windows.Forms.Label()
        Me.calPlanifier = New System.Windows.Forms.MonthCalendar()
        Me.lblPlanifierTitre = New System.Windows.Forms.Label()
        Me.picPlanifier = New System.Windows.Forms.PictureBox()
        Me.mnuPrincipalStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuAdministration = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeconnexion = New System.Windows.Forms.ToolStripMenuItem()
        Me.VW_UTILISATEURSTableAdapter1 = New OnMange.DataSet1TableAdapters.VW_UTILISATEURSTableAdapter()
        Me.ChoixPlat1 = New OnMange.ChoixPlat()
        Me.tbcTabController.SuspendLayout()
        Me.tabManger.SuspendLayout()
        CType(Me.picManger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAjouter.SuspendLayout()
        CType(Me.picAjouter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabNoter.SuspendLayout()
        CType(Me.picNoter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPlanifier.SuspendLayout()
        Me.pnlProposition3.SuspendLayout()
        CType(Me.picProposition3Etoile5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProposition3Etoile2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProposition3Etoile3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProposition3Etoile4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProposition3Etoile1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProposition1.SuspendLayout()
        CType(Me.picProposition1Etoile5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProposition1Etoile2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProposition1Etoile3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProposition1Etoile4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProposition1Etoile1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProposition4.SuspendLayout()
        CType(Me.picProposition4Etoile5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProposition4Etoile2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProposition4Etoile3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProposition4Etoile4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProposition4Etoile1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProposition2.SuspendLayout()
        CType(Me.picProposition2Etoile5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProposition2Etoile2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProposition2Etoile3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProposition2Etoile4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProposition2Etoile1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabManger.Controls.Add(Me.ChoixPlat1)
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
        Me.plaPropositionJour.Note = 0
        Me.plaPropositionJour.Origine = "Origine"
        Me.plaPropositionJour.Plat = ""
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
        Me.tabAjouter.Controls.Add(Me.Note1)
        Me.tabAjouter.Controls.Add(Me.lblOu)
        Me.tabAjouter.Controls.Add(Me.btnPlatExistant)
        Me.tabAjouter.Controls.Add(Me.lblAjouterNoteP)
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
        'Note1
        '
        Me.Note1.BackColor = System.Drawing.Color.Transparent
        Me.Note1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Note1.LectureSeule = False
        Me.Note1.Location = New System.Drawing.Point(264, 374)
        Me.Note1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Note1.Name = "Note1"
        Me.Note1.Note = 0
        Me.Note1.Size = New System.Drawing.Size(136, 22)
        Me.Note1.TabIndex = 37
        '
        'lblOu
        '
        Me.lblOu.AutoSize = True
        Me.lblOu.Location = New System.Drawing.Point(241, 219)
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
        Me.btnPlatExistant.TabIndex = 35
        Me.btnPlatExistant.Text = "&Choisir dans l'historique"
        Me.btnPlatExistant.UseVisualStyleBackColor = True
        '
        'lblAjouterNoteP
        '
        Me.lblAjouterNoteP.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAjouterNoteP.AutoSize = True
        Me.lblAjouterNoteP.Location = New System.Drawing.Point(113, 374)
        Me.lblAjouterNoteP.Name = "lblAjouterNoteP"
        Me.lblAjouterNoteP.Size = New System.Drawing.Size(43, 20)
        Me.lblAjouterNoteP.TabIndex = 28
        Me.lblAjouterNoteP.Text = "&Note"
        '
        'cmdEnregistrerAjouter
        '
        Me.cmdEnregistrerAjouter.Anchor = System.Windows.Forms.AnchorStyles.Bottom
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
        Me.cmdAjouterAliment.Location = New System.Drawing.Point(406, 289)
        Me.cmdAjouterAliment.Name = "cmdAjouterAliment"
        Me.cmdAjouterAliment.Size = New System.Drawing.Size(31, 27)
        Me.cmdAjouterAliment.TabIndex = 7
        Me.cmdAjouterAliment.Text = "&+"
        Me.cmdAjouterAliment.UseVisualStyleBackColor = True
        '
        'cboAjouterOrigine
        '
        Me.cboAjouterOrigine.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboAjouterOrigine.FormattingEnabled = True
        Me.cboAjouterOrigine.Location = New System.Drawing.Point(264, 332)
        Me.cboAjouterOrigine.Name = "cboAjouterOrigine"
        Me.cboAjouterOrigine.Size = New System.Drawing.Size(136, 28)
        Me.cboAjouterOrigine.TabIndex = 9
        '
        'txtAlimentsPrincipaux
        '
        Me.txtAlimentsPrincipaux.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtAlimentsPrincipaux.Location = New System.Drawing.Point(264, 289)
        Me.txtAlimentsPrincipaux.Name = "txtAlimentsPrincipaux"
        Me.txtAlimentsPrincipaux.Size = New System.Drawing.Size(136, 26)
        Me.txtAlimentsPrincipaux.TabIndex = 6
        '
        'txtPlat
        '
        Me.txtPlat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPlat.Location = New System.Drawing.Point(264, 248)
        Me.txtPlat.Name = "txtPlat"
        Me.txtPlat.Size = New System.Drawing.Size(136, 26)
        Me.txtPlat.TabIndex = 4
        '
        'lblAjouterOrigine
        '
        Me.lblAjouterOrigine.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAjouterOrigine.AutoSize = True
        Me.lblAjouterOrigine.Location = New System.Drawing.Point(113, 335)
        Me.lblAjouterOrigine.Name = "lblAjouterOrigine"
        Me.lblAjouterOrigine.Size = New System.Drawing.Size(59, 20)
        Me.lblAjouterOrigine.TabIndex = 8
        Me.lblAjouterOrigine.Text = "&Origine"
        '
        'lblAjouterAliments
        '
        Me.lblAjouterAliments.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAjouterAliments.AutoSize = True
        Me.lblAjouterAliments.Location = New System.Drawing.Point(113, 292)
        Me.lblAjouterAliments.Name = "lblAjouterAliments"
        Me.lblAjouterAliments.Size = New System.Drawing.Size(145, 20)
        Me.lblAjouterAliments.TabIndex = 5
        Me.lblAjouterAliments.Text = "&Aliments principaux"
        '
        'lblAjouterPlat
        '
        Me.lblAjouterPlat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAjouterPlat.AutoSize = True
        Me.lblAjouterPlat.Location = New System.Drawing.Point(113, 251)
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
        Me.optAjouterSoir.TabIndex = 2
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
        Me.optAjouterMidi.TabIndex = 1
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
        Me.PlaNoter.Note = 0
        Me.PlaNoter.Origine = "Origine"
        Me.PlaNoter.Plat = ""
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
        Me.tabPlanifier.Controls.Add(Me.pnlProposition3)
        Me.tabPlanifier.Controls.Add(Me.pnlProposition1)
        Me.tabPlanifier.Controls.Add(Me.pnlProposition4)
        Me.tabPlanifier.Controls.Add(Me.pnlProposition2)
        Me.tabPlanifier.Controls.Add(Me.lblPlanifierPropositions)
        Me.tabPlanifier.Controls.Add(Me.calPlanifier)
        Me.tabPlanifier.Controls.Add(Me.lblPlanifierTitre)
        Me.tabPlanifier.Controls.Add(Me.picPlanifier)
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
        'pnlProposition3
        '
        Me.pnlProposition3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlProposition3.BackColor = System.Drawing.Color.White
        Me.pnlProposition3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlProposition3.Controls.Add(Me.picProposition3Etoile5)
        Me.pnlProposition3.Controls.Add(Me.picProposition3Etoile2)
        Me.pnlProposition3.Controls.Add(Me.picProposition3Etoile3)
        Me.pnlProposition3.Controls.Add(Me.picProposition3Etoile4)
        Me.pnlProposition3.Controls.Add(Me.picProposition3Etoile1)
        Me.pnlProposition3.Controls.Add(Me.lblProposition3Note)
        Me.pnlProposition3.Controls.Add(Me.lblProposition3Origine)
        Me.pnlProposition3.Controls.Add(Me.lblProposition3Aliments)
        Me.pnlProposition3.Controls.Add(Me.lblProposition3Plat)
        Me.pnlProposition3.Location = New System.Drawing.Point(-27, 444)
        Me.pnlProposition3.Name = "pnlProposition3"
        Me.pnlProposition3.Size = New System.Drawing.Size(279, 103)
        Me.pnlProposition3.TabIndex = 0
        '
        'picProposition3Etoile5
        '
        Me.picProposition3Etoile5.Image = CType(resources.GetObject("picProposition3Etoile5.Image"), System.Drawing.Image)
        Me.picProposition3Etoile5.Location = New System.Drawing.Point(240, 73)
        Me.picProposition3Etoile5.Name = "picProposition3Etoile5"
        Me.picProposition3Etoile5.Size = New System.Drawing.Size(20, 20)
        Me.picProposition3Etoile5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProposition3Etoile5.TabIndex = 8
        Me.picProposition3Etoile5.TabStop = False
        '
        'picProposition3Etoile2
        '
        Me.picProposition3Etoile2.Image = CType(resources.GetObject("picProposition3Etoile2.Image"), System.Drawing.Image)
        Me.picProposition3Etoile2.Location = New System.Drawing.Point(162, 73)
        Me.picProposition3Etoile2.Name = "picProposition3Etoile2"
        Me.picProposition3Etoile2.Size = New System.Drawing.Size(20, 20)
        Me.picProposition3Etoile2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProposition3Etoile2.TabIndex = 7
        Me.picProposition3Etoile2.TabStop = False
        '
        'picProposition3Etoile3
        '
        Me.picProposition3Etoile3.Image = CType(resources.GetObject("picProposition3Etoile3.Image"), System.Drawing.Image)
        Me.picProposition3Etoile3.Location = New System.Drawing.Point(188, 73)
        Me.picProposition3Etoile3.Name = "picProposition3Etoile3"
        Me.picProposition3Etoile3.Size = New System.Drawing.Size(20, 20)
        Me.picProposition3Etoile3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProposition3Etoile3.TabIndex = 6
        Me.picProposition3Etoile3.TabStop = False
        '
        'picProposition3Etoile4
        '
        Me.picProposition3Etoile4.Image = CType(resources.GetObject("picProposition3Etoile4.Image"), System.Drawing.Image)
        Me.picProposition3Etoile4.Location = New System.Drawing.Point(214, 73)
        Me.picProposition3Etoile4.Name = "picProposition3Etoile4"
        Me.picProposition3Etoile4.Size = New System.Drawing.Size(20, 20)
        Me.picProposition3Etoile4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProposition3Etoile4.TabIndex = 5
        Me.picProposition3Etoile4.TabStop = False
        '
        'picProposition3Etoile1
        '
        Me.picProposition3Etoile1.Image = CType(resources.GetObject("picProposition3Etoile1.Image"), System.Drawing.Image)
        Me.picProposition3Etoile1.Location = New System.Drawing.Point(136, 73)
        Me.picProposition3Etoile1.Name = "picProposition3Etoile1"
        Me.picProposition3Etoile1.Size = New System.Drawing.Size(20, 20)
        Me.picProposition3Etoile1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProposition3Etoile1.TabIndex = 4
        Me.picProposition3Etoile1.TabStop = False
        '
        'lblProposition3Note
        '
        Me.lblProposition3Note.AutoSize = True
        Me.lblProposition3Note.Location = New System.Drawing.Point(10, 70)
        Me.lblProposition3Note.Name = "lblProposition3Note"
        Me.lblProposition3Note.Size = New System.Drawing.Size(120, 20)
        Me.lblProposition3Note.TabIndex = 3
        Me.lblProposition3Note.Text = "Note moyenne :"
        '
        'lblProposition3Origine
        '
        Me.lblProposition3Origine.AutoSize = True
        Me.lblProposition3Origine.Location = New System.Drawing.Point(10, 50)
        Me.lblProposition3Origine.Name = "lblProposition3Origine"
        Me.lblProposition3Origine.Size = New System.Drawing.Size(123, 20)
        Me.lblProposition3Origine.TabIndex = 2
        Me.lblProposition3Origine.Text = "Origine : Europe"
        '
        'lblProposition3Aliments
        '
        Me.lblProposition3Aliments.AutoSize = True
        Me.lblProposition3Aliments.Location = New System.Drawing.Point(10, 30)
        Me.lblProposition3Aliments.Name = "lblProposition3Aliments"
        Me.lblProposition3Aliments.Size = New System.Drawing.Size(259, 20)
        Me.lblProposition3Aliments.TabIndex = 1
        Me.lblProposition3Aliments.Text = "Aliments principaux : Fromage, pain"
        '
        'lblProposition3Plat
        '
        Me.lblProposition3Plat.AutoSize = True
        Me.lblProposition3Plat.Location = New System.Drawing.Point(10, 10)
        Me.lblProposition3Plat.Name = "lblProposition3Plat"
        Me.lblProposition3Plat.Size = New System.Drawing.Size(103, 20)
        Me.lblProposition3Plat.TabIndex = 0
        Me.lblProposition3Plat.Text = "Plat : Fondue"
        '
        'pnlProposition1
        '
        Me.pnlProposition1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlProposition1.BackColor = System.Drawing.Color.White
        Me.pnlProposition1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlProposition1.Controls.Add(Me.picProposition1Etoile5)
        Me.pnlProposition1.Controls.Add(Me.picProposition1Etoile2)
        Me.pnlProposition1.Controls.Add(Me.picProposition1Etoile3)
        Me.pnlProposition1.Controls.Add(Me.picProposition1Etoile4)
        Me.pnlProposition1.Controls.Add(Me.picProposition1Etoile1)
        Me.pnlProposition1.Controls.Add(Me.lblProposition1Note)
        Me.pnlProposition1.Controls.Add(Me.lblProposition1Origine)
        Me.pnlProposition1.Controls.Add(Me.lblProposition1Aliments)
        Me.pnlProposition1.Controls.Add(Me.lblProposition1Plat)
        Me.pnlProposition1.Location = New System.Drawing.Point(-27, 335)
        Me.pnlProposition1.Name = "pnlProposition1"
        Me.pnlProposition1.Size = New System.Drawing.Size(279, 103)
        Me.pnlProposition1.TabIndex = 0
        '
        'picProposition1Etoile5
        '
        Me.picProposition1Etoile5.Image = CType(resources.GetObject("picProposition1Etoile5.Image"), System.Drawing.Image)
        Me.picProposition1Etoile5.Location = New System.Drawing.Point(240, 73)
        Me.picProposition1Etoile5.Name = "picProposition1Etoile5"
        Me.picProposition1Etoile5.Size = New System.Drawing.Size(20, 20)
        Me.picProposition1Etoile5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProposition1Etoile5.TabIndex = 8
        Me.picProposition1Etoile5.TabStop = False
        '
        'picProposition1Etoile2
        '
        Me.picProposition1Etoile2.Image = CType(resources.GetObject("picProposition1Etoile2.Image"), System.Drawing.Image)
        Me.picProposition1Etoile2.Location = New System.Drawing.Point(162, 73)
        Me.picProposition1Etoile2.Name = "picProposition1Etoile2"
        Me.picProposition1Etoile2.Size = New System.Drawing.Size(20, 20)
        Me.picProposition1Etoile2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProposition1Etoile2.TabIndex = 7
        Me.picProposition1Etoile2.TabStop = False
        '
        'picProposition1Etoile3
        '
        Me.picProposition1Etoile3.Image = CType(resources.GetObject("picProposition1Etoile3.Image"), System.Drawing.Image)
        Me.picProposition1Etoile3.Location = New System.Drawing.Point(188, 73)
        Me.picProposition1Etoile3.Name = "picProposition1Etoile3"
        Me.picProposition1Etoile3.Size = New System.Drawing.Size(20, 20)
        Me.picProposition1Etoile3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProposition1Etoile3.TabIndex = 6
        Me.picProposition1Etoile3.TabStop = False
        '
        'picProposition1Etoile4
        '
        Me.picProposition1Etoile4.Image = CType(resources.GetObject("picProposition1Etoile4.Image"), System.Drawing.Image)
        Me.picProposition1Etoile4.Location = New System.Drawing.Point(214, 73)
        Me.picProposition1Etoile4.Name = "picProposition1Etoile4"
        Me.picProposition1Etoile4.Size = New System.Drawing.Size(20, 20)
        Me.picProposition1Etoile4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProposition1Etoile4.TabIndex = 5
        Me.picProposition1Etoile4.TabStop = False
        '
        'picProposition1Etoile1
        '
        Me.picProposition1Etoile1.Image = CType(resources.GetObject("picProposition1Etoile1.Image"), System.Drawing.Image)
        Me.picProposition1Etoile1.Location = New System.Drawing.Point(136, 73)
        Me.picProposition1Etoile1.Name = "picProposition1Etoile1"
        Me.picProposition1Etoile1.Size = New System.Drawing.Size(20, 20)
        Me.picProposition1Etoile1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProposition1Etoile1.TabIndex = 4
        Me.picProposition1Etoile1.TabStop = False
        '
        'lblProposition1Note
        '
        Me.lblProposition1Note.AutoSize = True
        Me.lblProposition1Note.Location = New System.Drawing.Point(10, 70)
        Me.lblProposition1Note.Name = "lblProposition1Note"
        Me.lblProposition1Note.Size = New System.Drawing.Size(120, 20)
        Me.lblProposition1Note.TabIndex = 3
        Me.lblProposition1Note.Text = "Note moyenne :"
        '
        'lblProposition1Origine
        '
        Me.lblProposition1Origine.AutoSize = True
        Me.lblProposition1Origine.Location = New System.Drawing.Point(10, 50)
        Me.lblProposition1Origine.Name = "lblProposition1Origine"
        Me.lblProposition1Origine.Size = New System.Drawing.Size(123, 20)
        Me.lblProposition1Origine.TabIndex = 2
        Me.lblProposition1Origine.Text = "Origine : Europe"
        '
        'lblProposition1Aliments
        '
        Me.lblProposition1Aliments.AutoSize = True
        Me.lblProposition1Aliments.Location = New System.Drawing.Point(10, 30)
        Me.lblProposition1Aliments.Name = "lblProposition1Aliments"
        Me.lblProposition1Aliments.Size = New System.Drawing.Size(259, 20)
        Me.lblProposition1Aliments.TabIndex = 1
        Me.lblProposition1Aliments.Text = "Aliments principaux : Fromage, pain"
        '
        'lblProposition1Plat
        '
        Me.lblProposition1Plat.AutoSize = True
        Me.lblProposition1Plat.Location = New System.Drawing.Point(10, 10)
        Me.lblProposition1Plat.Name = "lblProposition1Plat"
        Me.lblProposition1Plat.Size = New System.Drawing.Size(103, 20)
        Me.lblProposition1Plat.TabIndex = 0
        Me.lblProposition1Plat.Text = "Plat : Fondue"
        '
        'pnlProposition4
        '
        Me.pnlProposition4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlProposition4.BackColor = System.Drawing.Color.White
        Me.pnlProposition4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlProposition4.Controls.Add(Me.picProposition4Etoile5)
        Me.pnlProposition4.Controls.Add(Me.picProposition4Etoile2)
        Me.pnlProposition4.Controls.Add(Me.picProposition4Etoile3)
        Me.pnlProposition4.Controls.Add(Me.picProposition4Etoile4)
        Me.pnlProposition4.Controls.Add(Me.picProposition4Etoile1)
        Me.pnlProposition4.Controls.Add(Me.lblProposition4Note)
        Me.pnlProposition4.Controls.Add(Me.lblProposition4Origine)
        Me.pnlProposition4.Controls.Add(Me.lblProposition4Aliments)
        Me.pnlProposition4.Controls.Add(Me.lblProposition4Plat)
        Me.pnlProposition4.Location = New System.Drawing.Point(259, 444)
        Me.pnlProposition4.Name = "pnlProposition4"
        Me.pnlProposition4.Size = New System.Drawing.Size(279, 103)
        Me.pnlProposition4.TabIndex = 2
        '
        'picProposition4Etoile5
        '
        Me.picProposition4Etoile5.Image = CType(resources.GetObject("picProposition4Etoile5.Image"), System.Drawing.Image)
        Me.picProposition4Etoile5.Location = New System.Drawing.Point(240, 73)
        Me.picProposition4Etoile5.Name = "picProposition4Etoile5"
        Me.picProposition4Etoile5.Size = New System.Drawing.Size(20, 20)
        Me.picProposition4Etoile5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProposition4Etoile5.TabIndex = 8
        Me.picProposition4Etoile5.TabStop = False
        '
        'picProposition4Etoile2
        '
        Me.picProposition4Etoile2.Image = CType(resources.GetObject("picProposition4Etoile2.Image"), System.Drawing.Image)
        Me.picProposition4Etoile2.Location = New System.Drawing.Point(162, 73)
        Me.picProposition4Etoile2.Name = "picProposition4Etoile2"
        Me.picProposition4Etoile2.Size = New System.Drawing.Size(20, 20)
        Me.picProposition4Etoile2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProposition4Etoile2.TabIndex = 7
        Me.picProposition4Etoile2.TabStop = False
        '
        'picProposition4Etoile3
        '
        Me.picProposition4Etoile3.Image = CType(resources.GetObject("picProposition4Etoile3.Image"), System.Drawing.Image)
        Me.picProposition4Etoile3.Location = New System.Drawing.Point(188, 73)
        Me.picProposition4Etoile3.Name = "picProposition4Etoile3"
        Me.picProposition4Etoile3.Size = New System.Drawing.Size(20, 20)
        Me.picProposition4Etoile3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProposition4Etoile3.TabIndex = 6
        Me.picProposition4Etoile3.TabStop = False
        '
        'picProposition4Etoile4
        '
        Me.picProposition4Etoile4.Image = CType(resources.GetObject("picProposition4Etoile4.Image"), System.Drawing.Image)
        Me.picProposition4Etoile4.Location = New System.Drawing.Point(214, 73)
        Me.picProposition4Etoile4.Name = "picProposition4Etoile4"
        Me.picProposition4Etoile4.Size = New System.Drawing.Size(20, 20)
        Me.picProposition4Etoile4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProposition4Etoile4.TabIndex = 5
        Me.picProposition4Etoile4.TabStop = False
        '
        'picProposition4Etoile1
        '
        Me.picProposition4Etoile1.Image = CType(resources.GetObject("picProposition4Etoile1.Image"), System.Drawing.Image)
        Me.picProposition4Etoile1.Location = New System.Drawing.Point(136, 73)
        Me.picProposition4Etoile1.Name = "picProposition4Etoile1"
        Me.picProposition4Etoile1.Size = New System.Drawing.Size(20, 20)
        Me.picProposition4Etoile1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProposition4Etoile1.TabIndex = 4
        Me.picProposition4Etoile1.TabStop = False
        '
        'lblProposition4Note
        '
        Me.lblProposition4Note.AutoSize = True
        Me.lblProposition4Note.Location = New System.Drawing.Point(10, 70)
        Me.lblProposition4Note.Name = "lblProposition4Note"
        Me.lblProposition4Note.Size = New System.Drawing.Size(120, 20)
        Me.lblProposition4Note.TabIndex = 3
        Me.lblProposition4Note.Text = "Note moyenne :"
        '
        'lblProposition4Origine
        '
        Me.lblProposition4Origine.AutoSize = True
        Me.lblProposition4Origine.Location = New System.Drawing.Point(10, 50)
        Me.lblProposition4Origine.Name = "lblProposition4Origine"
        Me.lblProposition4Origine.Size = New System.Drawing.Size(123, 20)
        Me.lblProposition4Origine.TabIndex = 2
        Me.lblProposition4Origine.Text = "Origine : Europe"
        '
        'lblProposition4Aliments
        '
        Me.lblProposition4Aliments.AutoSize = True
        Me.lblProposition4Aliments.Location = New System.Drawing.Point(10, 30)
        Me.lblProposition4Aliments.Name = "lblProposition4Aliments"
        Me.lblProposition4Aliments.Size = New System.Drawing.Size(259, 20)
        Me.lblProposition4Aliments.TabIndex = 1
        Me.lblProposition4Aliments.Text = "Aliments principaux : Fromage, pain"
        '
        'lblProposition4Plat
        '
        Me.lblProposition4Plat.AutoSize = True
        Me.lblProposition4Plat.Location = New System.Drawing.Point(10, 10)
        Me.lblProposition4Plat.Name = "lblProposition4Plat"
        Me.lblProposition4Plat.Size = New System.Drawing.Size(103, 20)
        Me.lblProposition4Plat.TabIndex = 0
        Me.lblProposition4Plat.Text = "Plat : Fondue"
        '
        'pnlProposition2
        '
        Me.pnlProposition2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlProposition2.BackColor = System.Drawing.Color.White
        Me.pnlProposition2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlProposition2.Controls.Add(Me.picProposition2Etoile5)
        Me.pnlProposition2.Controls.Add(Me.picProposition2Etoile2)
        Me.pnlProposition2.Controls.Add(Me.picProposition2Etoile3)
        Me.pnlProposition2.Controls.Add(Me.picProposition2Etoile4)
        Me.pnlProposition2.Controls.Add(Me.picProposition2Etoile1)
        Me.pnlProposition2.Controls.Add(Me.lblProposition2Note)
        Me.pnlProposition2.Controls.Add(Me.lblProposition2Origine)
        Me.pnlProposition2.Controls.Add(Me.lblProposition2Aliments)
        Me.pnlProposition2.Controls.Add(Me.lblProposition2Plat)
        Me.pnlProposition2.Location = New System.Drawing.Point(259, 335)
        Me.pnlProposition2.Name = "pnlProposition2"
        Me.pnlProposition2.Size = New System.Drawing.Size(279, 103)
        Me.pnlProposition2.TabIndex = 1
        '
        'picProposition2Etoile5
        '
        Me.picProposition2Etoile5.Image = CType(resources.GetObject("picProposition2Etoile5.Image"), System.Drawing.Image)
        Me.picProposition2Etoile5.Location = New System.Drawing.Point(240, 73)
        Me.picProposition2Etoile5.Name = "picProposition2Etoile5"
        Me.picProposition2Etoile5.Size = New System.Drawing.Size(20, 20)
        Me.picProposition2Etoile5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProposition2Etoile5.TabIndex = 8
        Me.picProposition2Etoile5.TabStop = False
        '
        'picProposition2Etoile2
        '
        Me.picProposition2Etoile2.Image = CType(resources.GetObject("picProposition2Etoile2.Image"), System.Drawing.Image)
        Me.picProposition2Etoile2.Location = New System.Drawing.Point(162, 73)
        Me.picProposition2Etoile2.Name = "picProposition2Etoile2"
        Me.picProposition2Etoile2.Size = New System.Drawing.Size(20, 20)
        Me.picProposition2Etoile2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProposition2Etoile2.TabIndex = 7
        Me.picProposition2Etoile2.TabStop = False
        '
        'picProposition2Etoile3
        '
        Me.picProposition2Etoile3.Image = CType(resources.GetObject("picProposition2Etoile3.Image"), System.Drawing.Image)
        Me.picProposition2Etoile3.Location = New System.Drawing.Point(188, 73)
        Me.picProposition2Etoile3.Name = "picProposition2Etoile3"
        Me.picProposition2Etoile3.Size = New System.Drawing.Size(20, 20)
        Me.picProposition2Etoile3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProposition2Etoile3.TabIndex = 6
        Me.picProposition2Etoile3.TabStop = False
        '
        'picProposition2Etoile4
        '
        Me.picProposition2Etoile4.Image = CType(resources.GetObject("picProposition2Etoile4.Image"), System.Drawing.Image)
        Me.picProposition2Etoile4.Location = New System.Drawing.Point(214, 73)
        Me.picProposition2Etoile4.Name = "picProposition2Etoile4"
        Me.picProposition2Etoile4.Size = New System.Drawing.Size(20, 20)
        Me.picProposition2Etoile4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProposition2Etoile4.TabIndex = 5
        Me.picProposition2Etoile4.TabStop = False
        '
        'picProposition2Etoile1
        '
        Me.picProposition2Etoile1.Image = CType(resources.GetObject("picProposition2Etoile1.Image"), System.Drawing.Image)
        Me.picProposition2Etoile1.Location = New System.Drawing.Point(136, 73)
        Me.picProposition2Etoile1.Name = "picProposition2Etoile1"
        Me.picProposition2Etoile1.Size = New System.Drawing.Size(20, 20)
        Me.picProposition2Etoile1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProposition2Etoile1.TabIndex = 4
        Me.picProposition2Etoile1.TabStop = False
        '
        'lblProposition2Note
        '
        Me.lblProposition2Note.AutoSize = True
        Me.lblProposition2Note.Location = New System.Drawing.Point(10, 70)
        Me.lblProposition2Note.Name = "lblProposition2Note"
        Me.lblProposition2Note.Size = New System.Drawing.Size(120, 20)
        Me.lblProposition2Note.TabIndex = 3
        Me.lblProposition2Note.Text = "Note moyenne :"
        '
        'lblProposition2Origine
        '
        Me.lblProposition2Origine.AutoSize = True
        Me.lblProposition2Origine.Location = New System.Drawing.Point(10, 50)
        Me.lblProposition2Origine.Name = "lblProposition2Origine"
        Me.lblProposition2Origine.Size = New System.Drawing.Size(123, 20)
        Me.lblProposition2Origine.TabIndex = 2
        Me.lblProposition2Origine.Text = "Origine : Europe"
        '
        'lblProposition2Aliments
        '
        Me.lblProposition2Aliments.AutoSize = True
        Me.lblProposition2Aliments.Location = New System.Drawing.Point(10, 30)
        Me.lblProposition2Aliments.Name = "lblProposition2Aliments"
        Me.lblProposition2Aliments.Size = New System.Drawing.Size(259, 20)
        Me.lblProposition2Aliments.TabIndex = 1
        Me.lblProposition2Aliments.Text = "Aliments principaux : Fromage, pain"
        '
        'lblProposition2Plat
        '
        Me.lblProposition2Plat.AutoSize = True
        Me.lblProposition2Plat.Location = New System.Drawing.Point(10, 10)
        Me.lblProposition2Plat.Name = "lblProposition2Plat"
        Me.lblProposition2Plat.Size = New System.Drawing.Size(103, 20)
        Me.lblProposition2Plat.TabIndex = 0
        Me.lblProposition2Plat.Text = "Plat : Fondue"
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
        'VW_UTILISATEURSTableAdapter1
        '
        Me.VW_UTILISATEURSTableAdapter1.ClearBeforeFill = True
        '
        'ChoixPlat1
        '
        Me.ChoixPlat1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ChoixPlat1.Location = New System.Drawing.Point(-60, 210)
        Me.ChoixPlat1.Name = "ChoixPlat1"
        Me.ChoixPlat1.Size = New System.Drawing.Size(576, 228)
        Me.ChoixPlat1.TabIndex = 14
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
        Me.pnlProposition3.ResumeLayout(False)
        Me.pnlProposition3.PerformLayout()
        CType(Me.picProposition3Etoile5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProposition3Etoile2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProposition3Etoile3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProposition3Etoile4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProposition3Etoile1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProposition1.ResumeLayout(False)
        Me.pnlProposition1.PerformLayout()
        CType(Me.picProposition1Etoile5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProposition1Etoile2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProposition1Etoile3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProposition1Etoile4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProposition1Etoile1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProposition4.ResumeLayout(False)
        Me.pnlProposition4.PerformLayout()
        CType(Me.picProposition4Etoile5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProposition4Etoile2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProposition4Etoile3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProposition4Etoile4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProposition4Etoile1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProposition2.ResumeLayout(False)
        Me.pnlProposition2.PerformLayout()
        CType(Me.picProposition2Etoile5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProposition2Etoile2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProposition2Etoile3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProposition2Etoile4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProposition2Etoile1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents pnlProposition4 As Panel
    Friend WithEvents picProposition4Etoile5 As PictureBox
    Friend WithEvents picProposition4Etoile2 As PictureBox
    Friend WithEvents picProposition4Etoile3 As PictureBox
    Friend WithEvents picProposition4Etoile4 As PictureBox
    Friend WithEvents picProposition4Etoile1 As PictureBox
    Friend WithEvents lblProposition4Note As Label
    Friend WithEvents lblProposition4Origine As Label
    Friend WithEvents lblProposition4Aliments As Label
    Friend WithEvents lblProposition4Plat As Label
    Friend WithEvents pnlProposition2 As Panel
    Friend WithEvents picProposition2Etoile5 As PictureBox
    Friend WithEvents picProposition2Etoile2 As PictureBox
    Friend WithEvents picProposition2Etoile3 As PictureBox
    Friend WithEvents picProposition2Etoile4 As PictureBox
    Friend WithEvents picProposition2Etoile1 As PictureBox
    Friend WithEvents lblProposition2Note As Label
    Friend WithEvents lblProposition2Origine As Label
    Friend WithEvents lblProposition2Aliments As Label
    Friend WithEvents lblProposition2Plat As Label
    Friend WithEvents cmdEnregistrerVote As Button
    Friend WithEvents mnuPrincipalStrip As MenuStrip
    Friend WithEvents mnuDeconnexion As ToolStripMenuItem
    Friend WithEvents mnuAdministration As ToolStripMenuItem
    Friend WithEvents lblAjouterNoteP As Label
    Friend WithEvents pnlProposition3 As Panel
    Friend WithEvents picProposition3Etoile5 As PictureBox
    Friend WithEvents picProposition3Etoile2 As PictureBox
    Friend WithEvents picProposition3Etoile3 As PictureBox
    Friend WithEvents picProposition3Etoile4 As PictureBox
    Friend WithEvents picProposition3Etoile1 As PictureBox
    Friend WithEvents lblProposition3Note As Label
    Friend WithEvents lblProposition3Origine As Label
    Friend WithEvents lblProposition3Aliments As Label
    Friend WithEvents lblProposition3Plat As Label
    Friend WithEvents pnlProposition1 As Panel
    Friend WithEvents picProposition1Etoile5 As PictureBox
    Friend WithEvents picProposition1Etoile2 As PictureBox
    Friend WithEvents picProposition1Etoile3 As PictureBox
    Friend WithEvents picProposition1Etoile4 As PictureBox
    Friend WithEvents picProposition1Etoile1 As PictureBox
    Friend WithEvents lblProposition1Note As Label
    Friend WithEvents lblProposition1Origine As Label
    Friend WithEvents lblProposition1Aliments As Label
    Friend WithEvents lblProposition1Plat As Label
    Friend WithEvents optSoir As RadioButton
    Friend WithEvents optMidi As RadioButton
    Friend WithEvents datNoterJour As DateTimePicker
    Friend WithEvents lblOu As Label
    Friend WithEvents btnPlatExistant As Button
    Friend WithEvents VW_UTILISATEURSTableAdapter1 As DataSet1TableAdapters.VW_UTILISATEURSTableAdapter
    Friend WithEvents plaPropositionJour As PnlPlat
    Friend WithEvents PlaNoter As PnlPlat
    Friend WithEvents notNotePerso As Note
    Friend WithEvents Note1 As Note
    Friend WithEvents ChoixPlat1 As ChoixPlat
End Class
