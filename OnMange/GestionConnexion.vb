Module GestionConnexion
    Public Function isConnected() As Boolean
        Return Not IsDBNull(membreActif)
    End Function
End Module
