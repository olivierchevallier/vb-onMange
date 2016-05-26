Imports OnMange.ModBDD
Imports System.Data.OracleClient

Public Class FrmPrincipale
    Const FRM_HEIGHT = 600
    Const FRM_WIDTH = 560

    Dim propositions As Collection = New Collection
    Dim noteAjouter As Integer = 0
    Dim noteNoter As Integer = 0

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbcTabController.SelectedIndexChanged
        If (tbcTabController.SelectedTab.Name = "tabPlanifier") Then
            Me.Height += 150
            Me.Width += 100
        Else
            If (tbcTabController.SelectedTab.Name = "tabNoter") Then
                AfficherANoter()
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
        If isConnected() Then
            mnuDeconnexion.Text += " (" + membreActif.ToString + ")"
        Else
            Me.Close()
        End If

        datNoterJour.MaxDate = Date.Now

        'Ajout du panel à la collection
        propositions.Add(pnlProposition1)
        propositions.Add(pnlProposition2)
        propositions.Add(pnlProposition3)
        propositions.Add(pnlProposition4)

        AfficherPropositionJour()
    End Sub


    Private Sub pnlProposition1_MouseEnter(sender As Object, e As EventArgs) Handles pnlProposition4.MouseEnter, pnlProposition3.MouseEnter, pnlProposition2.MouseEnter, pnlProposition1.MouseEnter
        If sender.BackColor <> Color.LightGreen Then
            sender.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub pnlProposition1_MouseLeave(sender As Object, e As EventArgs) Handles pnlProposition4.MouseLeave, pnlProposition3.MouseLeave, pnlProposition2.MouseLeave, pnlProposition1.MouseLeave
        If sender.BackColor = Color.LightGray Then
            sender.BackColor = Color.White
        End If
    End Sub

    Private Sub pnlProposition1_MouseClick(sender As Object, e As MouseEventArgs) Handles pnlProposition4.MouseClick, pnlProposition3.MouseClick, pnlProposition2.MouseClick, pnlProposition1.MouseClick
        For i As Integer = 1 To propositions.Count()
            propositions(i).BackColor = Color.White()
        Next
        sender.BackColor = Color.LightGreen
    End Sub

    Private Sub lblProposition4Aliments_MouseEnter(sender As Object, e As EventArgs) Handles picProposition4Etoile5.MouseEnter, picProposition4Etoile4.MouseEnter, picProposition4Etoile3.MouseEnter, picProposition4Etoile2.MouseEnter, picProposition4Etoile1.MouseEnter, picProposition3Etoile5.MouseEnter, picProposition3Etoile4.MouseEnter, picProposition3Etoile3.MouseEnter, picProposition3Etoile2.MouseEnter, picProposition3Etoile1.MouseEnter, picProposition2Etoile5.MouseEnter, picProposition2Etoile4.MouseEnter, picProposition2Etoile3.MouseEnter, picProposition2Etoile2.MouseEnter, picProposition2Etoile1.MouseEnter, picProposition1Etoile5.MouseEnter, picProposition1Etoile4.MouseEnter, picProposition1Etoile3.MouseEnter, picProposition1Etoile2.MouseEnter, picProposition1Etoile1.MouseEnter, lblProposition4Plat.MouseEnter, lblProposition4Origine.MouseEnter, lblProposition4Note.MouseEnter, lblProposition4Aliments.MouseEnter, lblProposition3Plat.MouseEnter, lblProposition3Origine.MouseEnter, lblProposition3Note.MouseEnter, lblProposition3Aliments.MouseEnter, lblProposition2Plat.MouseEnter, lblProposition2Origine.MouseEnter, lblProposition2Note.MouseEnter, lblProposition2Aliments.MouseEnter, lblProposition1Plat.MouseEnter, lblProposition1Origine.MouseEnter, lblProposition1Note.MouseEnter, lblProposition1Aliments.MouseEnter
        If sender.Parent.BackColor <> Color.LightGreen Then
            sender.Parent.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub lblProposition4Aliments_MouseLeave(sender As Object, e As EventArgs) Handles picProposition4Etoile5.MouseLeave, picProposition4Etoile4.MouseLeave, picProposition4Etoile3.MouseLeave, picProposition4Etoile2.MouseLeave, picProposition4Etoile1.MouseLeave, picProposition3Etoile5.MouseLeave, picProposition3Etoile4.MouseLeave, picProposition3Etoile3.MouseLeave, picProposition3Etoile2.MouseLeave, picProposition3Etoile1.MouseLeave, picProposition2Etoile5.MouseLeave, picProposition2Etoile4.MouseLeave, picProposition2Etoile3.MouseLeave, picProposition2Etoile2.MouseLeave, picProposition2Etoile1.MouseLeave, picProposition1Etoile5.MouseLeave, picProposition1Etoile4.MouseLeave, picProposition1Etoile3.MouseLeave, picProposition1Etoile2.MouseLeave, picProposition1Etoile1.MouseLeave, lblProposition4Plat.MouseLeave, lblProposition4Origine.MouseLeave, lblProposition4Note.MouseLeave, lblProposition4Aliments.MouseLeave, lblProposition3Plat.MouseLeave, lblProposition3Origine.MouseLeave, lblProposition3Note.MouseLeave, lblProposition3Aliments.MouseLeave, lblProposition2Plat.MouseLeave, lblProposition2Origine.MouseLeave, lblProposition2Note.MouseLeave, lblProposition2Aliments.MouseLeave, lblProposition1Plat.MouseLeave, lblProposition1Origine.MouseLeave, lblProposition1Note.MouseLeave, lblProposition1Aliments.MouseLeave
        If sender.Parent.BackColor = Color.LightGray Then
            sender.Parent.BackColor = Color.White
        End If
    End Sub

    Private Sub lblProposition4Aliments_MouseClick(sender As Object, e As MouseEventArgs) Handles picProposition4Etoile5.MouseClick, picProposition4Etoile4.MouseClick, picProposition4Etoile3.MouseClick, picProposition4Etoile2.MouseClick, picProposition4Etoile1.MouseClick, picProposition3Etoile5.MouseClick, picProposition3Etoile4.MouseClick, picProposition3Etoile3.MouseClick, picProposition3Etoile2.MouseClick, picProposition3Etoile1.MouseClick, picProposition2Etoile5.MouseClick, picProposition2Etoile4.MouseClick, picProposition2Etoile3.MouseClick, picProposition2Etoile2.MouseClick, picProposition2Etoile1.MouseClick, picProposition1Etoile5.MouseClick, picProposition1Etoile4.MouseClick, picProposition1Etoile3.MouseClick, picProposition1Etoile2.MouseClick, picProposition1Etoile1.MouseClick, lblProposition4Plat.MouseClick, lblProposition4Origine.MouseClick, lblProposition4Note.MouseClick, lblProposition4Aliments.MouseClick, lblProposition3Plat.MouseClick, lblProposition3Origine.MouseClick, lblProposition3Note.MouseClick, lblProposition3Aliments.MouseClick, lblProposition2Plat.MouseClick, lblProposition2Origine.MouseClick, lblProposition2Note.MouseClick, lblProposition2Aliments.MouseClick, lblProposition1Plat.MouseClick, lblProposition1Origine.MouseClick, lblProposition1Note.MouseClick, lblProposition1Aliments.MouseClick
        For i As Integer = 1 To propositions.Count()
            propositions(i).BackColor = Color.White()
        Next
        sender.Parent.BackColor = Color.LightGreen
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
        Dim platPropose As Plat = PropositionDuJour()
        plaPropositionJour.Plat = platPropose.GetNomPlat()
        plaPropositionJour.Origine = platPropose.GetOrigine()
        plaPropositionJour.Note = platPropose.GetNoteMoyenne()
    End Sub

    'Affiche le plat à noter
    Private Sub AfficherANoter()
        Dim dateChoise As Date, moment As String, repasCourant As Repas
        moment = If(optMidi.Checked, "m", "s")
        dateChoise = datNoterJour.Value
        repasCourant = recupUnRepas(dateChoise, moment)
        PlaNoter.Plat = If(IsNothing(repasCourant), "Date invalide", repasCourant.GetNomPlat)
        PlaNoter.Origine = If(IsNothing(repasCourant), "Pas de repas enregistré à ce moment", repasCourant.GetOrigine)
        PlaNoter.Note = If(IsNothing(repasCourant), 0, repasCourant.GetNoteMoyenne())
        cmdEnregistrerNote.Enabled = Not IsNothing(repasCourant)
    End Sub

    Private Sub datNoterJour_ValueChanged(sender As Object, e As EventArgs) Handles datNoterJour.ValueChanged
        AfficherANoter()
    End Sub

    Private Sub optSoir_CheckedChanged(sender As Object, e As EventArgs) Handles optSoir.CheckedChanged
        AfficherANoter()
    End Sub
End Class