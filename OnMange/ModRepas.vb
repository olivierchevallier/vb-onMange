' 624-2 Projet de Génie logiciel - OnMange!
'
' Module gérant l'accès à la base de données pour les Repas
'
' Olivier Chevallier
Imports System.Data.OracleClient
Module ModRepas
    'Récupère un repas en fonction de sa date et de son moment
    Public Function recupUnRepas(paramDateRepas As Date, paramMomentRepas As String) As Plat
        Dim strRequete As String
        Dim reader_Sql As OracleDataReader
        Dim repasCourant As Repas
        strRequete = "SELECT * FROM vw_repas WHERE Mange_le = to_date('" + paramDateRepas.Date + "', 'DD/MM/YYYY') AND UPPER(Moment) = UPPER('" + paramMomentRepas + "')"
        Try
            do_sql(strRequete, reader_Sql)
            While (reader_Sql.Read)
                repasCourant = New Repas(reader_Sql.Item(0), reader_Sql.Item(1), reader_Sql.Item(2), reader_Sql.Item(3), reader_Sql.Item(3), If(IsDBNull(reader_Sql.Item(5)), 0, reader_Sql.Item(5)))
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

    Public Sub enregistrerNote(paramRepas As Repas, paramMembre As Membre, paramNote As Integer)
        Dim strRequete As String
        Dim reader_Sql As OracleDataReader
        strRequete = "INSERT INTO vw_onm_note VALUES(" + CStr(paramRepas.getIdentifiant()) + ", " + CStr(paramMembre.getIdentifiant()) + ", " + CStr(paramNote) + ")"
        do_sql(strRequete, reader_Sql)
    End Sub

    Public Function recupNote(paramRepas As Repas, paramMembre As Membre)
        Dim strRequete As String
        Dim reader_Sql As OracleDataReader
        strRequete = "SELECT not_note FROM vw_onm_note WHERE not_rep_no = " + CStr(paramRepas.getIdentifiant()) + " AND not_mem_no = " + CStr(paramMembre.getIdentifiant())
        do_sql(strRequete, reader_Sql)
        If (reader_Sql.Read()) Then Return reader_Sql.Item(0) Else Return -1
    End Function
End Module
