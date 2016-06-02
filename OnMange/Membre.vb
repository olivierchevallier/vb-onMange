' 624-2 Projet de Génie logiciel - OnMange!
'
' Classe modélisant un Membre
'
' Olivier Chevallier
Public Class Membre
    Dim identifiant As Integer
    Dim prenom As String
    Dim dateNaissance As Date
    Dim autorisation As String

    Public Sub New(prenom As String, dateNaissance As Date, autorisation As String, identifiant As Integer)
        Me.prenom = prenom
        Me.dateNaissance = dateNaissance
        Me.autorisation = autorisation
        Me.identifiant = identifiant
    End Sub

    Public Function getIdentifiant() As Integer
        Return identifiant
    End Function

    Public Sub setPrenom(prenom As String)
        Me.prenom = prenom
    End Sub

    Public Function getDateNaissance() As Date
        Return dateNaissance
    End Function

    Public Sub setDateNaissance(dateNaissance As Date)
        Me.dateNaissance = dateNaissance
    End Sub

    Public Function getAutorisation() As String
        Return autorisation
    End Function

    Public Sub setAutorisation(autorisation As String)
        Me.autorisation = autorisation
    End Sub

    Public Function isAdder() As Boolean
        Return autorisation = "A"
    End Function

    Public Overrides Function ToString() As String
        Return prenom
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return identifiant = obj.getIdentifiant()
    End Function
End Class
