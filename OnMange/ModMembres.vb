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
End Module
