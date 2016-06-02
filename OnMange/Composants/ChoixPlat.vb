Public Class ChoixPlat
    Dim plaPlats As Collection = New Collection

    Private Sub ChoixPlat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitialiserPlats()
    End Sub

    Private Sub ChoixPlat_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        InitialiserPlats()
    End Sub

    Private Sub InitialiserPlats()
        plaPlats = New Collection
        plaPlats.Add(plaPlat1)
        plaPlats.Add(plaPlat2)
        plaPlats.Add(plaPlat3)
        plaPlats.Add(plaPlat4)
    End Sub

    Private Sub plaPlat1_MouseEnter(sender As Object, e As EventArgs) Handles plaPlat4.MouseEnter, plaPlat3.MouseEnter, plaPlat2.MouseEnter, plaPlat1.MouseEnter
        If sender.BackColor <> Color.LightGreen Then
            sender.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub plaPlat1_MouseLeave(sender As Object, e As EventArgs) Handles plaPlat4.MouseLeave, plaPlat3.MouseLeave, plaPlat2.MouseLeave, plaPlat1.MouseLeave
        If sender.BackColor = Color.LightGray Then
            sender.BackColor = Color.White
        End If
    End Sub

    Private Sub plaPlat1_MouseClick(sender As Object, e As MouseEventArgs) Handles plaPlat4.MouseClick, plaPlat3.MouseClick, plaPlat2.MouseClick, plaPlat1.MouseClick
        For i As Integer = 1 To plaPlats.Count()
            plaPlats(i).BackColor = Color.White()
        Next
        sender.BackColor = Color.LightGreen
    End Sub
End Class
