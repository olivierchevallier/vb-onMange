Public Class Aliment
    Dim identifiant As Integer
    Dim nomAliment As String

    Public Sub New(identifiant As Integer, nomAliment As String)
        Me.identifiant = identifiant
        Me.nomAliment = nomAliment
    End Sub

    Public Function getIdentifiant() As Integer
        Return identifiant
    End Function

    Public Overrides Function ToString() As String
        Return nomAliment
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return obj.ToString().Equals(Me.ToString())
    End Function
End Class
