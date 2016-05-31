Module GestionConnexion
    Public Function isConnected() As Boolean
        Return Not IsNothing(membreActif)
    End Function
End Module
