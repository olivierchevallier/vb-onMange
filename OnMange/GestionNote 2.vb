' 624-2 Projet de Génie logiciel - OnMange!
'
' Module controlant le composant Note
' 
'
' Olivier Chevallier

Module GestionNote
    Public Function afficheNoteSouris(sender As Object, stars As Collection, click As Boolean) As Integer
        Dim image As Bitmap
        Dim note As Integer
        If click Then
            image = OnMange.My.Resources.star_yellow
        Else
            image = OnMange.My.Resources.star_grey
        End If
        note = trouverNote(sender, stars)
        afficherNote(note, stars, image)
        Return note
    End Function

    Public Function trouverNote(sender As Object, stars As Collection) As Integer
        Dim i As Integer = 1
        While sender.Name <> stars(i).Name
            i += 1
        End While
        Return i
    End Function

    Public Sub afficherNote(note As Integer, stars As Collection, image As Bitmap)
        Dim i As Integer = 1
        stars(i).image = image
        While i <= note
            stars(i).image = image
            i += 1
        End While
        i = stars.Count()
        While i > note
            stars(i).image = OnMange.My.Resources.dot
            i -= 1
        End While
    End Sub

    Public Sub afficherNote(note As Integer, stars As Collection)
        afficherNote(note, stars, OnMange.My.Resources.star_yellow)
    End Sub
End Module
