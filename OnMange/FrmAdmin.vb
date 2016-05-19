Public Class FrmAdmin
    Dim modifier As Boolean
    Dim membreSelectionne As Membre

    Private Sub FrmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datAdminDateNaissance.MaxDate = Date.Now
        AfficherMembres()
    End Sub

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

    Private Sub AfficherMembres()
        lstUtilisateurs.Items.Clear()
        RecupMemebres()
        For i = 0 To listeMembres.Count - 1
            lstUtilisateurs.Items.Add(listeMembres(i).ToString, 0)
        Next
    End Sub

    Private Sub afficherInfoMembre(ByVal membreAAfficher As Membre)
        txtAdminPrenom.Text = membreAAfficher.ToString()
        datAdminDateNaissance.Value = membreAAfficher.getDateNaissance()
        If membreAAfficher.isAdder() Then
            cbxAdminAutorisations.SelectedIndex = 1
        Else
            cbxAdminAutorisations.SelectedIndex = 0
        End If
    End Sub

    Private Sub effacerChamps()
        txtAdminPrenom.Text = ""
        datAdminDateNaissance.Value = datAdminDateNaissance.MaxDate
        cbxAdminAutorisations.SelectedIndex = -1
    End Sub

    Private Sub btnEditer_Click(sender As Object, e As EventArgs) Handles btnEditer.Click
        If modifier Then
            Dim membreModifie As Membre = New Membre(txtAdminPrenom.Text, datAdminDateNaissance.Value, cbxAdminAutorisations.SelectedValue)
            'updateMembre(membreSelectionne, membreModifie)
        End If
    End Sub
End Class