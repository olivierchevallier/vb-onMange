' 624-2 Projet de Génie logiciel - OnMange!
'
' Fenêtre permettant l'ajout d'aliments dans le cadre de l'ajout d'un repas
'
' Olivier Chevallier
Public Class FrmAjouterAliment
    Private Sub btnFermer_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
        Me.Close()
    End Sub

    Private Sub FrmAjouterAliment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RecupAliments()
        AfficherAliments()
        lstAliments.SelectedIndex() = 0
    End Sub

    'Effectue la recherche d'un aliment
    Private Sub txtRechercher_TextChanged(sender As Object, e As EventArgs) Handles txtRechercher.TextChanged
        RechercherAliments(Trim(txtRechercher.Text))
        AfficherAliments()
        NouvelAliment()
        If lstAliments.Items.Count > 0 Then lstAliments.SelectedIndex() = 0
    End Sub

    'Affiche les aliments de la liste
    Private Sub AfficherAliments()
        lstAliments.Items.Clear()
        For i = 0 To listeAliments.Count - 1
            lstAliments.Items.Add(listeAliments(i))
        Next
    End Sub

    'Gère le texte et l'activation du bouton
    Private Sub lstAliments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAliments.SelectedIndexChanged
        If lstAliments.SelectedIndices.Count > 0 And lstAliments.SelectedIndex >= listeAliments.Count Then
            btnAjouter.Text = "Ajouter"
            btnAjouter.Enabled = True
        ElseIf lstAliments.SelectedIndices.Count > 0 And Not listeAlimentsRepas.Contains(listeAliments(lstAliments.SelectedIndex)) Then
            btnAjouter.Text = "Ajouter"
            btnAjouter.Enabled = True
        ElseIf lstAliments.SelectedIndices.Count <= 0 Then
            btnAjouter.Text = "Ajouter"
            btnAjouter.Enabled = False
        Else
            btnAjouter.Text = "Supprimer"
            btnAjouter.Enabled = True
        End If
    End Sub

    'Demande la création d'un nouvel aliment 
    Private Sub NouvelAliment()
        Dim aliment As String
        aliment = StrConv(txtRechercher.Text, VbStrConv.ProperCase)
        If txtRechercher.Text <> "" And Not ExisteDansLaListe(aliment) Then
            lstAliments.Items.Add("Nouvel aliment : " + aliment)
        End If
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        GestionAliment()
    End Sub

    'Demande l'ajout de l'aliment au plat si celui-ci n'en fait pas encore parti ou le supprime du plat s'il en fait parti
    Private Sub GestionAliment()
        Dim aliment As String, index As Integer
        If listeAliments.Count < 1 Then
            aliment = StrConv(txtRechercher.Text, VbStrConv.ProperCase)
            ajouterAliment(aliment)
            RechercherAliments(Trim(txtRechercher.Text))
        End If
        index = If(lstAliments.SelectedIndex > 0, lstAliments.SelectedIndex, 0)
        If btnAjouter.Text = "Ajouter" Then
            listeAlimentsRepas.Add(listeAliments(index))
        Else
            listeAlimentsRepas.Remove(listeAliments(index))
        End If
        FrmPrincipale.afficherAlimentsAjouter()
        AfficherAliments()
        lstAliments.SelectedIndex() = index
    End Sub

    Private Sub lstAliments_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstAliments.MouseDoubleClick
        GestionAliment()
    End Sub
End Class