' 624-2 Projet de Génie logiciel - OnMange!
'
' Module gérant l'accès à la base de données pour les Plats
'
' Olivier Chevallier
Imports System.Data.OracleClient
Module ModPlats
    Public listePlats As New List(Of Plat)

    'Récupère la liste des plats dans la base de données
    Public Sub RecupPlats()
        Dim strRequete As String
        Dim reader_Sql As OracleDataReader
        listePlats = New List(Of Plat)
        strRequete = "SELECT * FROM vw_plats"
        do_sql(strRequete, reader_Sql)
        While (reader_Sql.Read)
            Dim platAjouter As Plat = New Plat(reader_Sql.Item(0), reader_Sql.Item(1), reader_Sql.Item(2), reader_Sql.Item(3), If(IsDBNull(reader_Sql.Item(4)), 0, reader_Sql.Item(4)))
            listePlats.Add(platAjouter)
        End While
    End Sub

    'Récupère la liste des plats correspondant au critère passé en paramètre dans la base de données
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

    'Récupère la liste des plats correspondant aux critères passés en paramètre dans la base de données
    Public Function RechercherPlats(paramOrigine As String, paramPasMange As Date) As List(Of Plat)
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

    'Enregistre un nouveau plat dans la base de données
    Public Sub enregistrerPlat(paramNom As String, paramOrigine As String)
        Dim strRequete As String, strSsRequete As String
        Dim reader_Sql As OracleDataReader
        strSsRequete = "SELECT ori_no FROM vw_onm_origine WHERE UPPER(ori_continent) LIKE UPPER('" + paramOrigine + "')"
        strRequete = "INSERT INTO vw_onm_plat VALUES(NULL, '" + paramNom + "', (" + strSsRequete + "))"
        do_sql(strRequete, reader_Sql)
    End Sub

    'Enregistre les composants du dernier plat ajouté à la base de données 
    Public Sub enregistrerComposantsPlat(paramAliments As List(Of Aliment))
        Dim i As Integer, strRequete As String
        Dim reader_Sql As OracleDataReader
        For i = 0 To paramAliments.Count - 1
            strRequete = "INSERT INTO vw_onm_compose VALUES(" + CStr(getLastPlatId()) + ", " + CStr(paramAliments(i).getIdentifiant()) + ")"
            do_sql(strRequete, reader_Sql)
        Next
    End Sub

    'Récupère l'identifiant du dernier plat ajouté à la base de données
    Public Function getLastPlatId() As Integer
        Dim strRequete As String, id As Integer
        Dim reader_Sql As OracleDataReader
        strRequete = "SELECT MAX(pla_no) FROM vw_onm_plat"
        do_sql(strRequete, reader_Sql)
        reader_Sql.Read()
        Return reader_Sql.Item(0)
    End Function

    'Récupère un plat au hasard dans la base de données 
    Public Function getPlatAleatoire() As Plat
        RecupPlats()
        Randomize()
        Dim randomValue As Integer = CInt(Int(((listePlats.Count - 1) * Rnd()) + 1))
        Return listePlats(randomValue)
    End Function
End Module
