Imports System.Data.OracleClient
Module ModMembres
    Public membreActif As Membre
    Public listeMembres As New List(Of Membre)

    Public Sub RecupMemebres()
        Dim strRequete As String
        Dim reader_Sql As OracleDataReader
        Dim i = 0
        listeMembres = New List(Of Membre)
        strRequete = "SELECT * FROM vw_utilisateurs"
        do_sql(strRequete, reader_Sql)
        While (reader_Sql.Read)
            Dim membreAjouter As Membre = New Membre(reader_Sql.Item(0), reader_Sql.Item(1), reader_Sql.Item(2))
            listeMembres.Add(membreAjouter)
            i += 1
        End While
    End Sub

    Public Sub updateMembre(ByVal membreAModifier As Membre, ByVal membreModife As Membre)
        Dim strRequete As String
        Dim reader_Sql As OracleDataReader
        strRequete = "UPDATE vw_utilisateurs SET Date_Naissance = to_date('" + membreModife.getDateNaissance() + "', 'DD/MM/YYYY'), Autorisation = '" + membreModife.getAutorisation() + "' WHERE Prenom = '" + membreAModifier.ToString() + "'"
        do_sql(strRequete, reader_Sql)
    End Sub
End Module
