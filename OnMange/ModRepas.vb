' 624-2 Projet de Génie logiciel - OnMange!
'
' Module gérant l'accès à la base de données pour les Repas
'
' Olivier Chevallier
Imports System.Data.OracleClient
Module ModRepas
    'Récupère un repas en fonction de sa date et de son moment
    Public Function recupUnRepas(ByVal paramDateRepas As Date, ByVal paramMomentRepas As String) As Plat
        Dim strRequete As String
        Dim reader_Sql As OracleDataReader
        Dim repasCourant As Repas
        strRequete = "SELECT * FROM vw_repas WHERE Mange_le = to_date('" + paramDateRepas.Date + "', 'DD/MM/YYYY') AND UPPER(Moment) = UPPER('" + paramMomentRepas + "')"
        Try
            do_sql(strRequete, reader_Sql)
            While (reader_Sql.Read)
                repasCourant = New Repas(reader_Sql.Item(0), reader_Sql.Item(1), reader_Sql.Item(2), reader_Sql.Item(3), If(IsDBNull(reader_Sql.Item(4)), 0, reader_Sql.Item(4)))
            End While
        Catch e As Exception
            repasCourant = Nothing
        End Try
        Return repasCourant
    End Function

    'Insère un nouveau repas dans la base de données
    Public Sub enregistrerRepas(paramMoment As String, paramDate As Date, paramPlat As Plat)
        Dim strRequete As String
        Dim reader_Sql As OracleDataReader
        strRequete = "INSERT INTO vw_onm_repas VALUES(NULL, '" + paramMoment + "', to_date('" + paramDate.Date + "', 'DD/MM/YYYY'), " + CStr(paramPlat.getIdentifiant()) + ")"
        do_sql(strRequete, reader_Sql)
    End Sub

    'Insère un nouveau repas dans la base de données avec comme plat le dernier plat créé
    Public Sub enregistrerRepas(paramMoment As String, paramDate As Date)
        Dim strRequete As String
        Dim reader_Sql As OracleDataReader
        strRequete = "INSERT INTO vw_onm_repas VALUES(NULL, '" + paramMoment + "', to_date('" + paramDate.Date + "', 'DD/MM/YYYY'), " + CStr(getLastPlatId()) + ")"
        do_sql(strRequete, reader_Sql)
    End Sub
End Module
