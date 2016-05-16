Public Class FrmAdmin
    Private Sub FrmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datAdminDateNaissance.MaxDate = Date.Now
        AfficherMembres()
    End Sub

    Private Sub lstUtilisateurs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUtilisateurs.SelectedIndexChanged
        If lstUtilisateurs.SelectedItems.Count <= 0 Then
            btnEditer.Text = "&Ajouter un nouveau membre"
            mnAdminStripSupprimer.Enabled = False
        Else
            afficherInfoMembre(listeMembres(lstUtilisateurs.SelectedIndices(0)))
            btnEditer.Text = "&Modifier ce membre"
            mnAdminStripSupprimer.Enabled = True
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
        'A terminer
        txtAdminPrenom.Text = membreAAfficher.ToString
    End Sub
End Class