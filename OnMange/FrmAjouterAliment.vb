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
        If lstAliments.Items.Count > 0 Then lstAliments.SelectedIndex() = 0
    End Sub

    Private Sub AfficherAliments()
        lstAliments.Items.Clear()
        For i = 0 To listeAliments.Count - 1
            lstAliments.Items.Add(listeAliments(i))
        Next
    End Sub

    Private Sub lstAliments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAliments.SelectedIndexChanged
        If lstAliments.SelectedIndices.Count > 0 And lstAliments.SelectedIndex >= listeAliments.Count Then
            btnAjouter.Enabled = True
        ElseIf lstAliments.SelectedIndices.Count > 0 And Not listeAlimentsRepas.Contains(listeAliments(lstAliments.SelectedIndex)) Then
            btnAjouter.Enabled = True
        Else
            btnAjouter.Enabled = False
        End If
    End Sub

    Private Sub NouvelAliment()
        Dim aliment As String
        aliment = StrConv(txtRechercher.Text, VbStrConv.ProperCase)
        If txtRechercher.Text <> "" And Not ExisteDansLaListe(aliment) Then
            lstAliments.Items.Add("Nouvel aliment : " + aliment)
        End If
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Dim aliment As String, index As Integer
        If listeAliments.Count < 1 Then
            Aliment = StrConv(txtRechercher.Text, VbStrConv.ProperCase)
            ajouterAliment(aliment)
            RechercherAliments(Trim(txtRechercher.Text))
        End If
        index = If(lstAliments.SelectedIndex > 0, lstAliments.SelectedIndex, 0)
        listeAlimentsRepas.Add(listeAliments(index))
        ConvertirAlimentsString()
        FrmPrincipale.afficherAlimentsAjouter()
        AfficherAliments()
    End Sub
End Class