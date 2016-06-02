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

    'Effectue toutes les opérations nécessaires au chargement de l'onglet ajouter
    Public Sub initTabAjouter(ByRef optSoir As RadioButton, ByRef optMidi As RadioButton)
        'S'il est passé 12h59 l'option soir est automatiquement cochée
        If Date.Now.Hour > 12 Then
            optSoir.Select()
        Else
            optMidi.Select()
        End If
    End Sub

    'Convertit la liste d'aliments en une chaine de caractères
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

    'Fait tout les nécessaire pour enregistrer un repas dans la base de données
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
