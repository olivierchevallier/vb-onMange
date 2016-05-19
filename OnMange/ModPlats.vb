Imports System.Data.OracleClient
Module ModPlats
    Public listePlats As New List(Of Plat)

    Public Sub RecupPlats()
        Dim strRequete As String
        Dim reader_Sql As OracleDataReader
        listePlats = New List(Of Plat)
        strRequete = "SELECT * FROM vw_plats"
        do_sql(strRequete, reader_Sql)
        While (reader_Sql.Read)
            Dim platAjouter As Plat = New Plat(reader_Sql.Item(0), reader_Sql.Item(1), reader_Sql.Item(2), reader_Sql.Item(3))
            listePlats.Add(platAjouter)
        End While
    End Sub

    Public Function RechercherPlats(ByVal origine As String, ByVal pasMange As Date) As List(Of Plat)
        Dim strRequete As String, platsTrouves As List(Of Plat)
        Dim reader_Sql As OracleDataReader
        platsTrouves = New List(Of Plat)
        strRequete = "SELECT * FROM vw_plats WHERE UPPER(Origine) LIKE UPPER('" + origine + "%') AND Mange_Le <= to_date('" + pasMange.Date + "','DD/MM/YYYY')"
        do_sql(strRequete, reader_Sql)
        While (reader_Sql.Read)
            Dim platAjouter As Plat = New Plat(reader_Sql.Item(0), reader_Sql.Item(1), reader_Sql.Item(2), reader_Sql.Item(3))
            platsTrouves.Add(platAjouter)
        End While
        Return platsTrouves
    End Function

    Public Function PropositionDuJour() As Plat
        RecupPlats()
        Randomize()
        Dim randomValue As Integer = CInt(Int(((listePlats.Count - 1) * Rnd()) + 1))
        Return listePlats(randomValue)
    End Function
End Module
