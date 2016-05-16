Imports System.Data.OracleClient

Module ModBDD

    Public oradb As String = "Data Source=heglocal;User ID=onMange_user;Password=onMange_user;"
    Public connexion As New OracleConnection(oradb)

    Public Sub connection()
        'Connexion à la base de données
        connexion.Open()
    End Sub

    Public Sub deconnection()
        'Deconnexion de la base de données
        connexion.Close()
    End Sub

    Public Sub do_sql(ByVal sql As String, ByRef odr As OracleDataReader)
        Dim cmd As New OracleCommand(sql, connexion)
        cmd.CommandText = sql
        odr = cmd.ExecuteReader()
    End Sub
End Module
