Public Class Membre
    Dim prenom As String
    Dim dateNaissance As Date
    Dim autorisation As String

    Public Sub New(ByVal prenom As String, ByVal dateNaissance As Date, ByVal autorisation As String)
        Me.prenom = prenom
        Me.dateNaissance = dateNaissance
        Me.autorisation = autorisation
    End Sub

    Public Overrides Function ToString() As String
        Return prenom
    End Function
End Class
