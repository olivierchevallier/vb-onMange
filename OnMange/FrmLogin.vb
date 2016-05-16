Imports OnMange.ModBDD
Imports System.Data.OracleClient
Public Class FrmLogin
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
End Class