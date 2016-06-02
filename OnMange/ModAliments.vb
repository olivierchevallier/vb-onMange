' 624-2 Projet de Génie logiciel - OnMange!
'
' Module gérant l'accès à la base de données pour les Aliments
'
' Olivier Chevallier
Imports System.Data.OracleClient
Module ModAliments
    Public listeAliments As New List(Of Aliment)

    'Récupère la liste de aliments dans la base de données
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

    'Recupère la liste des aliments correspondants au critère de recherche
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

    'Ajoute un aliment à la base de données
    Public Sub ajouterAliment(nomAliment As String)
        Dim strRequete As String
        Dim reader_Sql As OracleDataReader
        strRequete = "INSERT INTO vw_onm_aliment VALUES(NULL, '" + nomAliment.ToString() + "')"
        do_sql(strRequete, reader_Sql)
    End Sub

    'Retourne vrai si la liste de aliments contient l'aliment passé en paramètre
    Public Function ExisteDansLaListe(aliment As String) As Boolean
        For i = 0 To listeAliments.Count - 1
            If listeAliments(i).ToString = aliment Then
                Return True
            End If
        Next
        Return False
    End Function
End Module
