Imports System.Data.OracleClient
Module ModRepas
    Public repasCourant As Repas

    Public Function recupUnRepas(ByVal dateRepas As Date, ByVal momentRepas As String) As Plat
        Dim strRequete As String
        Dim reader_Sql As OracleDataReader
        strRequete = "SELECT * FROM vw_repas WHERE Mange_le = to_date('" + dateRepas.Date + "', 'DD/MM/YYYY') AND UPPER(Moment) = UPPER('" + momentRepas + "')"
        do_sql(strRequete, reader_Sql)
        While (reader_Sql.Read)
            repasCourant = New Repas(reader_Sql.Item(0), reader_Sql.Item(1), reader_Sql.Item(2), reader_Sql.Item(3), reader_Sql.Item(4))
        End While
    End Function
End Module
