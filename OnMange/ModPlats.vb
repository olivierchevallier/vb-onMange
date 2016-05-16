Imports System.Data.OracleClient
Module ModPlats
    Public listePlats As New List(Of Plat)

    Public Sub RecupPlats()
        Dim strRequete As String
        Dim reader_Sql As OracleDataReader
        Dim i = 0
        listePlats = New List(Of Plat)
        strRequete = "SELECT * FROM vw_plats"
        do_sql(strRequete, reader_Sql)
        While (reader_Sql.Read)
            Dim platAjouter As Plat = New Plat(reader_Sql.Item(0), reader_Sql.Item(1), reader_Sql.Item(2), reader_Sql.Item(3))
            listePlats.Add(platAjouter)
            i += 1
        End While
    End Sub

    Public Function PropositionDuJour() As Plat
        RecupPlats()
        Randomize()
        Dim randomValue As Integer = CInt(Int(((listePlats.Count - 1) * Rnd()) + 1))
        Return listePlats(randomValue)
    End Function
End Module
