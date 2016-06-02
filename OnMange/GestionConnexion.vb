' 624-2 Projet de Génie logiciel - OnMange!
'
' Module controlant la connexion d'un membre
'
' Olivier Chevallier
Module GestionConnexion
    Public Function isConnected() As Boolean
        Return Not IsNothing(membreActif)
    End Function
End Module
