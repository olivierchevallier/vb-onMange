Public Class FrmConsulter
    Private Sub btnChoisir_Click(sender As Object, e As EventArgs) Handles btnChoisir.Click
        nomPlatAjouter = dgvHistorique.SelectedCells(0).Value
        Me.Close()
    End Sub

    Private Sub FrmConsulter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        afficherPlats(listePlats)
    End Sub

    Private Sub afficherPlats(ByVal platsAAfficher As List(Of Plat))
        dgvHistorique.Rows.Clear()
        For i = 0 To platsAAfficher.Count - 1
            dgvHistorique.Rows.Add(platsAAfficher(i).ToStringArray())
        Next
    End Sub

    Private Sub cboMangerOrigine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMangerOrigine.SelectedIndexChanged
        Rechercher()
    End Sub

    Private Sub cboPasMange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPasMange.SelectedIndexChanged
        Rechercher()
    End Sub

    Private Sub Rechercher()
        Dim origine As String, pasMange As Date
        origine = If(IsNothing(cboMangerOrigine.SelectedItem), "", cboMangerOrigine.SelectedItem)
        pasMange = Date.Now
        Select Case cboPasMange.SelectedItem
            Case "Un jour"
                pasMange = pasMange.AddDays(-1)
            Case "Cinq jours"
                pasMange = pasMange.AddDays(-5)
            Case "Une semaine"
                pasMange = pasMange.AddDays(-7)
            Case "Deux semaines"
                pasMange = pasMange.AddDays(-14)
            Case "Un mois"
                pasMange = pasMange.AddMonths(-1)
        End Select
        afficherPlats(RechercherPlats(origine, pasMange))
    End Sub
End Class