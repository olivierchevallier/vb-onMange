Public Class FrmConsulter
    Private Sub btnChoisir_Click(sender As Object, e As EventArgs) Handles btnChoisir.Click
        Me.Close()
    End Sub

    Private Sub FrmConsulter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        afficherPlats()
    End Sub

    Private Sub afficherPlats()
        Dim uneLigne(5) As String
        dgvHistorique.Rows.Clear()
        For i = 0 To listePlats.Count - 1
            uneLigne(0) = listePlats(i).GetNomPlat
            uneLigne(1) = listePlats(i).GetAlimentsString
            uneLigne(2) = listePlats(i).GetOrigine
            uneLigne(3) = listePlats(i).GetMangeLe
            uneLigne(4) = listePlats(i).GetNoteMoyenne
            dgvHistorique.Rows.Add(uneLigne)
        Next
    End Sub
End Class