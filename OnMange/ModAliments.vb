Imports System.Data.OracleClient
Module ModAliments
    Public listeAliments As New List(Of String)

    Public Sub RecupAliments()
        Dim strRequete As String
        Dim reader_Sql As OracleDataReader
        listeAliments = New List(Of String)
        strRequete = "SELECT * FROM vw_aliments ORDER BY Aliment"
        do_sql(strRequete, reader_Sql)
        While (reader_Sql.Read)
            listeAliments.Add(reader_Sql.Item(0))
        End While
    End Sub

    Public Sub RechercherAliments(ByVal paramRecherche As String)
        Dim strRequete As String
        Dim reader_Sql As OracleDataReader
        listeAliments = New List(Of String)
        strRequete = "SELECT * FROM vw_aliments WHERE LOWER(Aliment) LIKE LOWER('" + paramRecherche + "%') ORDER BY Aliment"
        do_sql(strRequete, reader_Sql)
        While (reader_Sql.Read)
            listeAliments.Add(reader_Sql.Item(0))
        End While
    End Sub
End Module
