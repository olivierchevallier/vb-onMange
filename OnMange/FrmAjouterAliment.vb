Public Class FrmAjouterAliment
    Private Sub btnFermer_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
        Me.Close()
    End Sub

    Private Sub FrmAjouterAliment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RecupAliments()
        AfficherAliments()
        lstAliments.SelectedIndex() = 0
    End Sub

    Private Sub txtRechercher_TextChanged(sender As Object, e As EventArgs) Handles txtRechercher.TextChanged
        RechercherAliments(Trim(txtRechercher.Text))
        AfficherAliments()
        NouvelAliment()
        lstAliments.SelectedIndex() = 0
    End Sub

    Private Sub AfficherAliments()
        lstAliments.Items.Clear()
        For i = 0 To listeAliments.Count - 1
            lstAliments.Items.Add(listeAliments(i))
        Next
    End Sub

    Private Sub lstAliments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAliments.SelectedIndexChanged
        btnAjouter.Enabled = lstAliments.SelectedIndices.Count > 0
    End Sub

    Private Sub NouvelAliment()
        Dim aliment As String
        aliment = StrConv(txtRechercher.Text, VbStrConv.ProperCase)
        If txtRechercher.Text <> "" And Not ExisteDansLaListe(aliment) Then
            lstAliments.Items.Add("Nouvel aliment : " + aliment)
        End If
    End Sub
End Class