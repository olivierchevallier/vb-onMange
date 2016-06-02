' 624-2 Projet de Génie logiciel - OnMange!
'
' Classe modélisant un Repas
'
' Olivier Chevallier
Public Class Repas
    Inherits Plat

    Private moment As String

    Public Sub New(identifiant As Integer, nomPlat As String, origine As String, mangeLe As Date, moment As String, noteMoyenne As Double)
        MyBase.New(identifiant, nomPlat, origine, mangeLe, noteMoyenne)
        Me.moment = moment
    End Sub
End Class
