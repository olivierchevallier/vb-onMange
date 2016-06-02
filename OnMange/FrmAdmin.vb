' 624-2 Projet de Génie logiciel - OnMange!
'
' Fenêtre d'administration de l'application
'
' Olivier Chevallier
Public Class FrmAdmin
    Dim modifier As Boolean
    Dim membreSelectionne As Membre

    Private Sub FrmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datAdminDateNaissance.MaxDate = Date.Now
        AfficherMembres()
        ActivationBouton()
    End Sub

    'Gère si un utilisateur est selectionné ou non
    Private Sub lstUtilisateurs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUtilisateurs.SelectedIndexChanged
        modifier = lstUtilisateurs.SelectedItems.Count > 0
        If modifier Then
            membreSelectionne = listeMembres(lstUtilisateurs.SelectedIndices(0))
            afficherInfoMembre(membreSelectionne)
            btnEditer.Text = "&Modifier ce membre"
            mnAdminStripSupprimer.Enabled = True
        Else
            btnEditer.Text = "&Ajouter un nouveau membre"
            mnAdminStripSupprimer.Enabled = False
            effacerChamps()
        End If
    End Sub

    Private Sub mnuAdministration_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mnuAdminContext.Opening
        If lstUtilisateurs.SelectedItems.Count <= 0 Then
            e.Cancel = True
        End If
    End Sub

    'Affiche la liste des membres
    Private Sub AfficherMembres()
        lstUtilisateurs.Items.Clear()
        RecupMemebres()
        For i = 0 To listeMembres.Count - 1
            lstUtilisateurs.Items.Add(listeMembres(i).ToString, 0)
        Next
    End Sub

    'Affiche les informations du membre selectionné
    Private Sub afficherInfoMembre(ByVal membreAAfficher As Membre)
        txtAdminPrenom.Text = membreAAfficher.ToString()
        datAdminDateNaissance.Value = membreAAfficher.getDateNaissance()
        If membreAAfficher.isAdder() Then
            cbxAdminAutorisations.SelectedIndex = 1
        Else
            cbxAdminAutorisations.SelectedIndex = 0
        End If
    End Sub

    'Efface le contenu des champs du formulaire
    Private Sub effacerChamps()
        txtAdminPrenom.Text = ""
        datAdminDateNaissance.Value = datAdminDateNaissance.MaxDate
        cbxAdminAutorisations.SelectedIndex = -1
    End Sub

    'Demande l'edition d'un membre
    Private Sub btnEditer_Click(sender As Object, e As EventArgs) Handles btnEditer.Click
        Dim membreEdite As Membre = New Membre(txtAdminPrenom.Text, datAdminDateNaissance.Value, If(cbxAdminAutorisations.SelectedIndex = 1, "A", "N"), 0)
        If modifier Then
            membreSelectionne.setPrenom(txtAdminPrenom.Text)
            membreSelectionne.setDateNaissance(datAdminDateNaissance.Value)
            membreSelectionne.setAutorisation(If(cbxAdminAutorisations.SelectedIndex = 1, "A", "N"))
            updateMembre(membreSelectionne)
        Else
            AddMembre(membreEdite, txtAdminNom.Text)
        End If
        AfficherMembres()
    End Sub

    'Active le bouton d'edition en fonction de plusieurs critères
    Private Sub ActivationBouton()
        btnEditer.Enabled = (txtAdminPrenom.Text.Length > 0 And cbxAdminAutorisations.SelectedIndex >= 0 And txtAdminNom.Text.Length > 0)
    End Sub

    Private Sub txtAdminPrenom_TextChanged(sender As Object, e As EventArgs) Handles txtAdminPrenom.TextChanged
        ActivationBouton()
    End Sub

    Private Sub cbxAdminAutorisations_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxAdminAutorisations.SelectedIndexChanged
        ActivationBouton()
    End Sub

    Private Sub mnAdminStripSupprimer_Click(sender As Object, e As EventArgs) Handles mnAdminStripSupprimer.Click
        deleteSelectedMembre()
    End Sub
    Private Sub mnuAminContextSupprimer_Click(sender As Object, e As EventArgs) Handles mnuAminContextSupprimer.Click
        deleteSelectedMembre()
    End Sub

    'Demande la supression d'un membre
    Private Sub deleteSelectedMembre()
        If membreActif.Equals(membreSelectionne) Then
            MsgBox("Connecter vous avec un autre utilisateur pour supprimer " + membreActif.ToString(), , "Vous ne pouvez pas vous suppimer vous même.")
        Else
            DeleteMembre(membreSelectionne)
            AfficherMembres()
        End If
    End Sub
End Class