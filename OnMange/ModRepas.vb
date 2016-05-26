Imports System.Data.OracleClient
Module ModRepas
    Public Function recupUnRepas(ByVal paramDateRepas As Date, ByVal paramMomentRepas As String) As Plat
        Dim strRequete As String
        Dim reader_Sql As OracleDataReader
        Dim repasCourant As Repas
        strRequete = "SELECT * FROM vw_repas WHERE Mange_le = to_date('" + paramDateRepas.Date + "', 'DD/MM/YYYY') AND UPPER(Moment) = UPPER('" + paramMomentRepas + "')"
        Try
            do_sql(strRequete, reader_Sql)
            While (reader_Sql.Read)
                repasCourant = New Repas(reader_Sql.Item(0), reader_Sql.Item(1), reader_Sql.Item(2), reader_Sql.Item(3), reader_Sql.Item(4))
            End While
        Catch e As Exception
            repasCourant = Nothing
        End Try
        Return repasCourant
    End Function

    Public Sub enregistrerRepas(ByVal paramRepas As Repas)
        Dim strRequete As String
        Dim i As Integer
        For i = 0 To listePlats.Count

        Next
    End Sub
End Module
