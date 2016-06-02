' 624-2 Projet de Génie logiciel - OnMange!
'
' Classe modélisant un Repas
'
' Olivier Chevallier
Public Class Repas
    Inherits Plat

    Private moment As String

    Public Sub New(ByVal nomPlat As String, ByVal origine As String, ByVal mangeLe As Date, ByVal moment As String, ByVal noteMoyenne As Double)
        'identifiant bidon inséré (vérifier si ça ne pose pas de problème)
        MyBase.New(1, nomPlat, origine, mangeLe, noteMoyenne)
        Me.moment = moment
    End Sub
End Class
