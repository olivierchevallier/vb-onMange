Imports System.Data.OracleClient

Module ModBDD

    'Public oradb As String = "Data Source=XE;User ID=onMange_user;Password=onMange_user;"
    Public oradb As String = "Data Source=HEGLOCAL;User ID=onMange_user;Password=onMange_user;"
    Public connexion As New OracleConnection(oradb)

    Public Sub connection()
        'Connexion à la base de données
        connexion.Open()
    End Sub

    Public Sub deconnection()
        'Deconnexion de la base de données
        connexion.Close()
    End Sub

    Public Sub do_sql(ByVal paramSql As String, ByRef paramOdr As OracleDataReader)
        Dim cmd As New OracleCommand(paramSql, connexion)
        cmd.CommandText = paramSql
        paramOdr = cmd.ExecuteReader()
    End Sub
End Module