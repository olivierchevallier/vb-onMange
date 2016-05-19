Public Class FrmConsulter
    Private Sub btnChoisir_Click(sender As Object, e As EventArgs) Handles btnChoisir.Click
        Me.Close()
    End Sub

    Private Sub FrmConsulter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        afficherPlats()
    End Sub

    Private Sub afficherPlats()
        dgvHistorique.Rows.Clear()
        For i = 0 To listePlats.Count - 1
            dgvHistorique.Rows.Add(listePlats(i).ToStringArray())
        Next
    End Sub
End Class