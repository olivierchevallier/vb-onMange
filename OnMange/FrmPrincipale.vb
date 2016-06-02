' 624-2 Projet de Génie logiciel - OnMange!
'
' Fenêtre principale de l'application tout se passe ici.
' Plusieurs onglets sont disponibles, chacun est dédié à une fonctionnalité de l'application.
'
' Olivier Chevallier

Public Class FrmPrincipale
    'Constantes
    Const FRM_HEIGHT = 600
    Const FRM_WIDTH = 560

    'Variables globales
    Dim noteAjouter As Integer = 0
    Dim noteNoter As Integer = 0
    Dim repasCourant As Repas

    'Affiche le plat à noter
    Private Sub AfficherANoter()
        Dim dateChoise As Date, moment As String
        moment = If(optMidi.Checked, "m", "s")
        dateChoise = datNoterJour.Value
        repasCourant = recupUnRepas(dateChoise, moment)
        If IsNothing(repasCourant) Then
            PlaNoter.NomPlat = "Date invalide"
            PlaNoter.Origine = "Pas de repas enregistré à ce moment"
            PlaNoter.Note = 0
            cmdEnregistrerNote.Enabled = False
            notNotePerso.LectureSeule = True
        Else
            PlaNoter.Plat = repasCourant
            notNotePerso.Note = If(recupNote(repasCourant, membreActif) < 0, 0, recupNote(repasCourant, membreActif))
            notNotePerso.LectureSeule = recupNote(repasCourant, membreActif) >= 0
            cmdEnregistrerNote.Enabled = recupNote(repasCourant, membreActif) < 0 And notNotePerso.Note > 0
        End If
    End Sub

    'Effectue toutes les opérations nécessaires au chargement de l'onglet ajouter
    Private Sub initTabAjouter()
        'S'il est passé 12h59 l'option soir est automatiquement cochée
        If Date.Now.Hour > 12 Then
            optAjouterSoir.Select()
        Else
            optAjouterMidi.Select()
        End If
    End Sub

    'initialisations de l'interface en fonction du membre connecté
    Private Sub InitMembre()
        mnuDeconnexion.Text += " (" + membreActif.ToString + ")"
        tabAjouter.Enabled = membreActif.isAdder()
    End Sub

    'Affiche les aliments à ajouter dans champs prévu à cet effet
    Public Sub afficherAlimentsAjouter()
        ConvertirAlimentsString()
        txtAlimentsPrincipaux.Text = strAlimentsRepas
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbcTabController.SelectedIndexChanged
        If tbcTabController.SelectedTab.Name = "tabPlanifier" Then
            Me.Height += 150
            Me.Width += 100
            Me.AcceptButton = cmdEnregistrerVote
        Else
            If tbcTabController.SelectedTab.Name = "tabNoter" Then
                AfficherANoter()
                Me.AcceptButton = cmdEnregistrerNote
            ElseIf tbcTabController.SelectedTab.Name = "tabAjouter" Then
                initTabAjouter()
                Me.AcceptButton = cmdEnregistrerAjouter
            ElseIf tbcTabController.SelectedTab.Name = "tabManger" Then
                Me.AcceptButton = cmdRechercher
            End If
            Me.Height = FRM_HEIGHT
            Me.Width = FRM_WIDTH
        End If
    End Sub

    Private Sub mnuAdministration_Click(sender As Object, e As EventArgs) Handles mnuAdministration.Click
        FrmAdmin.Show()
    End Sub

    Private Sub FrmPrincipale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Gestion du login
        FrmLogin.ShowDialog(Me)
        If Not isConnected() Then
            Me.Close()
            Exit Sub
        End If
        InitMembre()

        datNoterJour.MaxDate = Date.Now
        calPlanifier.MinDate = Date.Now
        plaPropositionJour.Plat = PropositionDuJour()
    End Sub

    Private Sub mnuDeconnexion_Click(sender As Object, e As EventArgs) Handles mnuDeconnexion.Click
        System.Windows.Forms.Application.Restart()
    End Sub

    Private Sub cmdAjouterAliment_Click(sender As Object, e As EventArgs) Handles cmdAjouterAliment.Click
        FrmAjouterAliment.ShowDialog()
    End Sub

    Private Sub cmdRechercher_Click(sender As Object, e As EventArgs) Handles cmdRechercher.Click
        FrmConsulter.Show()
    End Sub

    Private Sub btnPlatExistant_Click(sender As Object, e As EventArgs) Handles btnPlatExistant.Click
        FrmConsulter.btnChoisir.Visible = True
        FrmConsulter.lblMangerTitre.Text = "Selectionner  dans  l'historique"
        FrmConsulter.Text = "On Mange ! - Selectionner  dans  l'historique"
        FrmConsulter.ShowDialog()
        FrmConsulter.btnChoisir.Visible = False
        FrmConsulter.lblMangerTitre.Text = "Consulter l'historique des repas"
        FrmConsulter.Text = "On Mange ! - Consulter l'historique"
        txtPlat.Text = nomPlatAjouter
    End Sub

    Private Sub datNoterJour_ValueChanged(sender As Object, e As EventArgs) Handles datNoterJour.ValueChanged
        AfficherANoter()
    End Sub

    Private Sub optSoir_CheckedChanged(sender As Object, e As EventArgs) Handles optSoir.CheckedChanged
        AfficherANoter()
    End Sub

    Private Sub txtPlat_TextChanged(sender As Object, e As EventArgs) Handles txtPlat.TextChanged
        platAjouter = RechercherUnPlat(txtPlat.Text)
        cmdAjouterAliment.Enabled = IsNothing(platAjouter)
        cmdSupAliments.Enabled = IsNothing(platAjouter)
        cboAjouterOrigine.Enabled = IsNothing(platAjouter)
        strAlimentsRepas = If(IsNothing(platAjouter), strAlimentsRepas, platAjouter.GetAlimentsString())
        txtAlimentsPrincipaux.Text = strAlimentsRepas
        cboAjouterOrigine.Text = If(IsNothing(platAjouter), cboAjouterOrigine.Text, platAjouter.GetOrigine())
        gestionBoutonEnregistrer()
        If IsNothing(platAjouter) Then afficherAlimentsAjouter()
    End Sub

    Private Sub txtAlimentsPrincipaux_TextChanged(sender As Object, e As EventArgs) Handles txtAlimentsPrincipaux.TextChanged
        txtAlimentsPrincipaux.Text = strAlimentsRepas
    End Sub

    Private Sub gestionBoutonEnregistrer()
        cmdEnregistrerAjouter.Enabled = txtPlat.Text <> "" And cboAjouterOrigine.Text <> "" And IsNothing(recupUnRepas(Date.Now, If(optAjouterMidi.Checked, "m", "s")))
    End Sub

    Private Sub cboAjouterOrigine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAjouterOrigine.SelectedIndexChanged
        gestionBoutonEnregistrer()
    End Sub

    Private Sub cboAjouterOrigine_TextChanged(sender As Object, e As EventArgs) Handles cboAjouterOrigine.TextChanged
        gestionBoutonEnregistrer()
    End Sub

    Private Sub cmdEnregistrerAjouter_Click(sender As Object, e As EventArgs) Handles cmdEnregistrerAjouter.Click
        enregistreRepas(txtPlat.Text, cboAjouterOrigine.Text, If(optAjouterMidi.Checked, "m", "s"))
        gestionBoutonEnregistrer()
    End Sub

    Private Sub optAjouterMidi_CheckedChanged(sender As Object, e As EventArgs) Handles optAjouterMidi.CheckedChanged
        gestionBoutonEnregistrer()
    End Sub

    Private Sub cmdSupAliments_Click(sender As Object, e As EventArgs) Handles cmdSupAliments.Click
        If listeAlimentsRepas.Count() > 0 Then
            listeAlimentsRepas.RemoveAt(listeAlimentsRepas.Count() - 1)
            afficherAlimentsAjouter()
        End If
    End Sub

    Private Sub cmdEnregistrerNote_Click(sender As Object, e As EventArgs) Handles cmdEnregistrerNote.Click
        enregistrerNote(repasCourant, membreActif, notNotePerso.Note)
        cmdEnregistrerNote.Enabled = False
        AfficherANoter()
    End Sub

    Private Sub notNotePerso_MouseClick(sender As Object, e As MouseEventArgs) Handles notNotePerso.MouseClick
        cmdEnregistrerNote.Enabled = Not notNotePerso.LectureSeule And notNotePerso.Note > 0
    End Sub
End Class