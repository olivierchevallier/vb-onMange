Imports OnMange.ModBDD
Imports System.Data.OracleClient
Public Class FrmLogin
    Dim secondes As Integer

    Private Sub lstUtilisateurs_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstUtilisateurs.MouseDoubleClick
        If lstUtilisateurs.SelectedItems.Count > 0 Then
            membreActif = listeMembres(lstUtilisateurs.SelectedIndices(0))
            Me.Close()
        End If
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
        AfficherMembres()
    End Sub

    Private Sub AfficherMembres()
        lstUtilisateurs.Items.Clear()
        RecupMemebres()
        For i = 0 To listeMembres.Count - 1
            lstUtilisateurs.Items.Add(listeMembres(i).ToString, 0)
        Next
    End Sub

    Private Sub lstUtilisateurs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUtilisateurs.SelectedIndexChanged
        timTip.Start()
        secondes = 0
    End Sub

    Private Sub timTip_Tick(sender As Object, e As EventArgs) Handles timTip.Tick
        secondes += 1
        If (secondes > 2) Then
            lblTip.Text = "Astuce : Double-cliquez pour vous identifier"
            lblTip.Location = New Point(((Me.Width - lblTip.Width) / 2), lblTip.Location.Y)
        End If
    End Sub
End Class