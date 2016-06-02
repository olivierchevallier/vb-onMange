Imports System.ComponentModel
Public Class PnlPlat
    Inherits System.Windows.Forms.UserControl

    Private intNote As Integer
    Private platPlat As Plat

    Property Plat() As Plat
        Get
            Return platPlat
        End Get
        Set(ByVal Value As Plat)
            platPlat = Value
            If Not IsNothing(platPlat) Then
                afficherPlat()
            End If
        End Set
    End Property

    Property NomPlat() As String
        Get
            Return lblPlat.Text
        End Get
        Set(value As String)
            lblPlat.Text = value
            Centrer(lblPlat)
        End Set
    End Property

    Property Origine() As String
        Get
            Return lblOrigine.Text
        End Get
        Set(ByVal Value As String)
            lblOrigine.Text = Value
            Centrer(lblOrigine)
        End Set
    End Property

    Property Note() As Integer
        Get
            Return notPlat.Note
        End Get
        Set(ByVal Value As Integer)
            notPlat.Note = Value
        End Set
    End Property

    Private Sub afficherPlat()
        lblOrigine.Text = platPlat.GetOrigine()
        lblPlat.Text = platPlat.GetNomPlat()
        notPlat.Note = platPlat.GetNoteMoyenne()
        Centrer(lblPlat)
        Centrer(lblOrigine)
    End Sub

    Private Sub Centrer(ByRef aCentrer As Control)
        aCentrer.Location = New Point(((Width - aCentrer.Width) / 2), aCentrer.Location.Y)
    End Sub

    Private Sub lblPlat_MouseEnter(sender As Object, e As EventArgs) Handles lblPlat.MouseEnter, lblOrigine.MouseEnter, notPlat.MouseEnter
        Me.OnMouseEnter(e)
    End Sub

    Private Sub lblPlat_MouseClick(sender As Object, e As MouseEventArgs) Handles notPlat.MouseClick, lblPlat.MouseClick, lblOrigine.MouseClick
        Me.OnMouseClick(e)
    End Sub
End Class
