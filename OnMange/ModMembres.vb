Imports System.Data.OracleClient
Module ModMembres
    Public membreActif As Membre
    Public listeMembres As New List(Of Membre)

    Public Sub RecupMemebres()
        Dim strRequete As String
        Dim reader_Sql As OracleDataReader
        Dim i = 0
        listeMembres = New List(Of Membre)
        strRequete = "SELECT * FROM vw_utilisateurs"
        do_sql(strRequete, reader_Sql)
        While (reader_Sql.Read)
            Dim membreAjouter As Membre = New Membre(reader_Sql.Item(0), reader_Sql.Item(1), reader_Sql.Item(2), reader_Sql.Item(3))
            listeMembres.Add(membreAjouter)
            i += 1
        End While
    End Sub

    Public Sub updateMembre(ByVal paramMembre As Membre)
        'Fonctionne, mais changer la classe personne pour intégrer l'id et faire la comparaison sur celui-ci plutot que sur le prénom
        Dim strRequete As String
        Dim reader_Sql As OracleDataReader
        strRequete = "UPDATE vw_onm_membre SET mem_prenom = '" + paramMembre.ToString() + "', mem_naissance = to_date('" + paramMembre.getDateNaissance() + "', 'DD/MM/YYYY'), mem_autorisation = '" + paramMembre.getAutorisation() + "' WHERE mem_no = " + CStr(paramMembre.getIdentifiant)
        do_sql(strRequete, reader_Sql)
    End Sub

    Public Sub AddMembre(ByVal paramMembre As Membre, ByVal paramNom As String)
        Dim strRequete As String
        Dim reader_Sql As OracleDataReader
        strRequete = "INSERT INTO vw_onm_membre VALUES(NULL, '" + paramMembre.ToString() + "', '" + paramNom + "','" + paramMembre.getDateNaissance().Date + "', '" + paramMembre.getAutorisation() + "')"
        do_sql(strRequete, reader_Sql)
    End Sub

    Public Sub DeleteMembre(ByVal paramMembre)
        Dim strRequete As String
        Dim reader_Sql As OracleDataReader
        strRequete = "DELETE FROM vw_onm_membre WHERE mem_no = " + CStr(paramMembre.getIdentifiant)
        do_sql(strRequete, reader_Sql)
    End Sub
End Module
