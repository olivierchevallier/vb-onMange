Imports OnMange.ModBDD
Imports System.Data.OracleClient

Public Class FrmPrincipale
    Const FRM_HEIGHT = 600
    Const FRM_WIDTH = 560

    Dim noteAjouter As Integer = 0
    Dim noteNoter As Integer = 0

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbcTabController.SelectedIndexChanged
        If tbcTabController.SelectedTab.Name = "tabPlanifier" Then
            Me.Height += 150
            Me.Width += 100
        Else
            If tbcTabController.SelectedTab.Name = "tabNoter" Then
                AfficherANoter()
            ElseIf tbcTabController.SelectedTab.Name = "tabAjouter"
                initTabAjouter()
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
        mnuDeconnexion.Text += " (" + membreActif.ToString + ")"

        datNoterJour.MaxDate = Date.Now
        AfficherPropositionJour()
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
    End Sub

    'Affiche la proposition du jour
    Private Sub AfficherPropositionJour()
        plaPropositionJour.Plat = PropositionDuJour()
    End Sub

    'Affiche le plat à noter
    Private Sub AfficherANoter()
        Dim dateChoise As Date, moment As String, repasCourant As Repas
        moment = If(optMidi.Checked, "m", "s")
        dateChoise = datNoterJour.Value
        repasCourant = recupUnRepas(dateChoise, moment)
        If IsNothing(repasCourant) Then
            PlaNoter.NomPlat = "Date invalide"
            PlaNoter.Origine = "Pas de repas enregistré à ce moment"
            PlaNoter.Note = 0
        Else
            PlaNoter.Plat = repasCourant
        End If
        cmdEnregistrerNote.Enabled = Not IsNothing(repasCourant)
    End Sub

    Private Sub initTabAjouter()
        'S'il est passé 12h59 l'option soir est automatiquement cochée
        If Date.Now.Hour > 12 Then
            optAjouterSoir.Select()
        Else
            optAjouterMidi.Select()
        End If
    End Sub

    Private Sub datNoterJour_ValueChanged(sender As Object, e As EventArgs) Handles datNoterJour.ValueChanged
        AfficherANoter()
    End Sub

    Private Sub optSoir_CheckedChanged(sender As Object, e As EventArgs) Handles optSoir.CheckedChanged
        AfficherANoter()
    End Sub

    Private Sub cmdEnregistrerAjouter_Click(sender As Object, e As EventArgs) Handles cmdEnregistrerAjouter.Click

    End Sub
End Class