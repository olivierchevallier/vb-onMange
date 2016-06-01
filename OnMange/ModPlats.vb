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
            Dim platAjouter As Plat = New Plat(reader_Sql.Item(0), reader_Sql.Item(1), reader_Sql.Item(2), reader_Sql.Item(3), reader_Sql.Item(4))
            listePlats.Add(platAjouter)
        End While
    End Sub

    Public Function RechercherUnPlat(paramNomPlat As String) As Plat
        Dim strRequete As String, platsTrouves As List(Of Plat)
        Dim reader_Sql As OracleDataReader
        platsTrouves = New List(Of Plat)
        strRequete = "SELECT * FROM vw_plats WHERE UPPER(Plat) LIKE UPPER('" + paramNomPlat + "')"
        do_sql(strRequete, reader_Sql)
        While (reader_Sql.Read)
            Dim platAjouter As Plat = New Plat(reader_Sql.Item(0), reader_Sql.Item(1), reader_Sql.Item(2), reader_Sql.Item(3), reader_Sql.Item(4))
            platsTrouves.Add(platAjouter)
        End While
        Return If(platsTrouves.Count > 0, platsTrouves(0), Nothing)
    End Function

    Public Function RechercherPlats(ByVal paramOrigine As String, ByVal paramPasMange As Date) As List(Of Plat)
        Dim strRequete As String, platsTrouves As List(Of Plat)
        Dim reader_Sql As OracleDataReader
        platsTrouves = New List(Of Plat)
        strRequete = "SELECT * FROM vw_plats WHERE UPPER(Origine) LIKE UPPER('" + paramOrigine + "%') AND Mange_Le <= to_date('" + paramPasMange.Date + "','DD/MM/YYYY')"
        do_sql(strRequete, reader_Sql)
        While (reader_Sql.Read)
            Dim platAjouter As Plat = New Plat(reader_Sql.Item(0), reader_Sql.Item(1), reader_Sql.Item(2), reader_Sql.Item(3), reader_Sql.Item(4))
            platsTrouves.Add(platAjouter)
        End While
        Return platsTrouves
    End Function

    Public Sub EnregistrerPlat(ByVal paramPlat As Plat)

    End Sub

    Public Function PropositionDuJour() As Plat
        RecupPlats()
        Randomize()
        Dim randomValue As Integer = CInt(Int(((listePlats.Count - 1) * Rnd()) + 1))
        Return listePlats(randomValue)
    End Function
End Module
