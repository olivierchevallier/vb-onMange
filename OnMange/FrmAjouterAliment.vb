Public Class FrmAjouterAliment
    Private Sub btnFermer_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
        Me.Close()
    End Sub

    Private Sub FrmAjouterAliment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RecupAliments()
        AfficherAliments()
    End Sub

    Private Sub txtRechercher_TextChanged(sender As Object, e As EventArgs) Handles txtRechercher.TextChanged
        RechercherAliments(Trim(txtRechercher.Text))
        AfficherAliments()
    End Sub

    Private Sub AfficherAliments()
        lstAliments.Items.Clear()
        For i = 0 To listeAliments.Count - 1
            lstAliments.Items.Add(listeAliments(i))
        Next
    End Sub
End Class