﻿' 624-2 Projet de Génie logiciel - OnMange!
'
' Module gérant l'accès à la base de données pour les Membres
'
' Olivier Chevallier
Imports System.Data.OracleClient
Module ModMembres
    Public membreActif As Membre = Nothing
    Public listeMembres As New List(Of Membre)

    'Récupère la liste des membres dans la base de données
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

    'Modifie le membre passé en paramètre dans la base de données
    Public Sub updateMembre(paramMembre As Membre)
        Dim strRequete As String
        Dim reader_Sql As OracleDataReader
        strRequete = "UPDATE vw_onm_membre SET mem_prenom = '" + paramMembre.ToString() + "', mem_naissance = to_date('" + paramMembre.getDateNaissance() + "', 'DD/MM/YYYY'), mem_autorisation = '" + paramMembre.getAutorisation() + "' WHERE mem_no = " + CStr(paramMembre.getIdentifiant)
        do_sql(strRequete, reader_Sql)
    End Sub

    'Ajoute un memebre à la base de données
    Public Sub AddMembre(paramMembre As Membre, paramNom As String)
        Dim strRequete As String
        Dim reader_Sql As OracleDataReader
        strRequete = "INSERT INTO vw_onm_membre VALUES(NULL, '" + paramMembre.ToString() + "', '" + paramNom + "','" + paramMembre.getDateNaissance().Date + "', '" + paramMembre.getAutorisation() + "')"
        do_sql(strRequete, reader_Sql)
    End Sub

    'Supprime le membre passé en paramètre de la base de données
    Public Sub DeleteMembre(paramMembre)
        Dim strRequete As String
        Dim reader_Sql As OracleDataReader
        strRequete = "DELETE FROM vw_onm_membre WHERE mem_no = " + CStr(paramMembre.getIdentifiant)
        do_sql(strRequete, reader_Sql)
    End Sub
End Module
