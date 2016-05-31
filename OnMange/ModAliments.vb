Imports System.Data.OracleClient
Module ModAliments
    Public listeAliments As New List(Of Aliment)

    Public Sub RecupAliments()
        Dim strRequete As String
        Dim reader_Sql As OracleDataReader
        listeAliments = New List(Of Aliment)
        strRequete = "SELECT * FROM vw_aliments ORDER BY Aliment"
        do_sql(strRequete, reader_Sql)
        While (reader_Sql.Read)
            Dim aliment As New Aliment(reader_Sql.Item(0), reader_Sql.Item(1))
            listeAliments.Add(aliment)
        End While
    End Sub

    Public Sub RechercherAliments(paramRecherche As String)
        Dim strRequete As String
        Dim reader_Sql As OracleDataReader
        listeAliments = New List(Of Aliment)
        strRequete = "SELECT * FROM vw_aliments WHERE LOWER(Aliment) LIKE LOWER('" + paramRecherche + "%') ORDER BY Aliment"
        do_sql(strRequete, reader_Sql)
        While (reader_Sql.Read)
            Dim aliment As New Aliment(reader_Sql.Item(0), reader_Sql.Item(1))
            listeAliments.Add(aliment)
        End While
    End Sub

    Public Sub ajouterAliment(nomAliment As String)
        Dim strRequete As String
        Dim reader_Sql As OracleDataReader
        strRequete = "INSERT INTO vw_onm_aliment VALUES(NULL, '" + nomAliment.ToString() + "')"
        do_sql(strRequete, reader_Sql)
    End Sub

    Public Function ExisteDansLaListe(aliment As String) As Boolean
        For i = 0 To listeAliments.Count - 1
            If listeAliments(i).ToString = aliment Then
                Return True
            End If
        Next
        Return False
    End Function
End Module
