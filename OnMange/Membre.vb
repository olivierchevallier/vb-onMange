Public Class Membre
    Dim prenom As String
    Dim dateNaissance As Date
    Dim autorisation As String

    Public Sub New(ByVal prenom As String, ByVal dateNaissance As Date, ByVal autorisation As String)
        Me.prenom = prenom
        Me.dateNaissance = dateNaissance
        Me.autorisation = autorisation
    End Sub

    Public Function getDateNaissance() As Date
        Return dateNaissance
    End Function

    Public Function getAutorisation() As String
        Return autorisation
    End Function

    Public Function isAdder() As Boolean
        Return autorisation = "A"
    End Function

    Public Overrides Function ToString() As String
        Return prenom
    End Function
End Class
