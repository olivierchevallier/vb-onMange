Module ModAjoutRepas
    Public listeAlimentsRepas As New List(Of Aliment)
    Public strAlimentsRepas As String = ""
    Public platAjouter As Plat

    Public Sub ConvertirAlimentsString()
        Dim i As Integer = 1
        strAlimentsRepas = listeAlimentsRepas(0).ToString
        While i < listeAlimentsRepas.Count()
            strAlimentsRepas += ", " + listeAlimentsRepas(i).ToString
            i = i + 1
        End While
    End Sub
End Module
