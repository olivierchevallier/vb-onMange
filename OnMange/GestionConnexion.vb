' 624-2 Projet de Génie logiciel - OnMange!
'
' Module controlant la connexion d'un membre
'
' Olivier Chevallier
Module GestionConnexion
    'Retourne vrai si un utilisateur connecté à l'application
    Public Function isConnected() As Boolean
        Return Not IsNothing(membreActif)
    End Function
End Module
