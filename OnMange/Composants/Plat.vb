﻿Imports System.ComponentModel
Public Class PnlPlat
    Inherits System.Windows.Forms.UserControl

    Private intNote As Integer

    Property Plat() As String
        Get
            Return lblPlat.Text
        End Get
        Set(ByVal Value As String)
            lblPlat.Text = Value
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

    Private Sub Centrer(ByRef aCentrer As Control)
        aCentrer.Location = New Point(((Width - aCentrer.Width) / 2), aCentrer.Location.Y)
    End Sub

    Private Sub lblPlat_MouseEnter(sender As Object, e As EventArgs) Handles lblPlat.MouseEnter
        PnlPlat_MouseEnter(Me, e)
    End Sub

    Private Sub lblOrigine_MouseEnter(sender As Object, e As EventArgs) Handles lblOrigine.MouseEnter
        PnlPlat_MouseEnter(Me, e)
    End Sub

    Private Sub notPlat_MouseEnter(sender As Object, e As EventArgs) Handles notPlat.MouseEnter
        PnlPlat_MouseEnter(Me, e)
    End Sub

    Private Sub PnlPlat_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter

    End Sub
End Class
