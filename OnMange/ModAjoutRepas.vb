' 624-2 Projet de Génie logiciel - OnMange!
'
' Module controlant l'ajout de repas
'
' Olivier Chevallier
Module ModAjoutRepas
    Public listeAlimentsRepas As New List(Of Aliment)
    Public strAlimentsRepas As String = ""
    Public nomPlatAjouter As String
    Public platAjouter As Plat

    Public Sub ConvertirAlimentsString()
        Dim i As Integer = 1
        If listeAlimentsRepas.Count > 0 Then
            strAlimentsRepas = listeAlimentsRepas(0).ToString
            While i < listeAlimentsRepas.Count()
                strAlimentsRepas += ", " + listeAlimentsRepas(i).ToString
                i = i + 1
            End While
        Else
            strAlimentsRepas = ""
        End If
    End Sub

    Public Sub enregistreRepas(paramNomPlat As String, paramOrigine As String, paramMoment As String)
        If IsNothing(platAjouter) Then
            enregistrerPlat(paramNomPlat, paramOrigine)
            enregistrerComposantsPlat(listeAlimentsRepas)
            enregistrerRepas(paramMoment, Date.Now)
        Else
            enregistrerRepas(paramMoment, Date.Now, platAjouter)
        End If
    End Sub
End Module
