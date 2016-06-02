' 624-2 Projet de Génie logiciel - OnMange!
'
' Classe modélisant un Plat
'
' Olivier Chevallier
Imports System.Data.OracleClient
Public Class Plat
    Private identifiant As Integer
    Private nomPlat As String
    Private origine As String
    Private mangeLe As Date
    Private noteMoyenne As Double
    Private aliments As New List(Of Aliment)

    Public Sub New(identifiant As Integer, nomPlat As String, origine As String, mangeLe As Date, noteMoyenne As Double)
        Me.identifiant = identifiant
        Me.nomPlat = nomPlat
        Me.origine = origine
        Me.mangeLe = mangeLe
        Me.noteMoyenne = noteMoyenne
        aliments = RecupAlimentsPlat()
    End Sub

    Public Function getIdentifiant() As Integer
        Return identifiant
    End Function

    Public Function GetNomPlat() As String
        Return nomPlat
    End Function

    Public Function GetOrigine() As String
        Return origine
    End Function

    Public Function GetNoteMoyenne() As Double
        Return noteMoyenne
    End Function

    Public Function GetMangeLe() As Date
        Return mangeLe
    End Function

    Public Function getAliments() As List(Of Aliment)
        Return aliments
    End Function

    Public Function ToStringArray() As String()
        Dim platArray(5) As String
        platArray(0) = nomPlat
        platArray(1) = GetAlimentsString()
        platArray(2) = origine
        platArray(3) = mangeLe
        platArray(4) = noteMoyenne
        Return platArray
    End Function

    Public Function GetAlimentsString() As String
        Dim alimentsString As String = ""
        If aliments.Count > 0 Then
            alimentsString = aliments(0).ToString
            For i = 1 To aliments.Count - 1
                alimentsString += ", " + aliments(i).ToString
            Next
        End If
        Return alimentsString
    End Function

    Public Overrides Function Equals(ByVal paramPlat As Object) As Boolean
        Return Me.nomPlat.Equals(paramPlat.GetNomPlat)
    End Function

    'Récupère les aliment d'un plat
    Public Function RecupAlimentsPlat() As List(Of Aliment)
        Dim strRequete As String
        Dim reader_Sql As OracleDataReader
        Dim i = 0
        Dim listeAliments As New List(Of Aliment)
        strRequete = "SELECT identifiant, aliment FROM vw_composants WHERE plat = '" + nomPlat + "'"
        do_sql(strRequete, reader_Sql)
        While (reader_Sql.Read)
            If IsDBNull(reader_Sql.Item(0)) Then
                Dim aliment As New Aliment(0, "")
            Else
                Dim aliment As New Aliment(reader_Sql.Item(0), reader_Sql.Item(1))
                listeAliments.Add(aliment)
            End If
        End While
        Return listeAliments
    End Function
End Class
