Public Class Note
    Private boolLectureSeule As Boolean
    Private intNote As Integer
    Dim stars As Collection

    Private Sub Note_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialiserStars()
    End Sub

    Property LectureSeule() As Boolean
        Get
            Return boolLectureSeule
        End Get
        Set(ByVal Value As Boolean)
            boolLectureSeule = Value
        End Set
    End Property

    Property Note() As Integer
        Get
            Return intNote
        End Get
        Set(value As Integer)
            initialiserStars()
            intNote = value
            afficherNote(intNote, stars)
        End Set
    End Property

    Private Sub picEtoile1_MouseEnter(sender As Object, e As EventArgs) Handles picEtoile5.MouseEnter, picEtoile4.MouseEnter, picEtoile3.MouseEnter, picEtoile2.MouseEnter, picEtoile1.MouseEnter
        If boolLectureSeule = False And intNote = 0 Then
            afficheNoteSouris(sender, stars, False)
        End If
        Me.OnMouseEnter(e)
    End Sub

    Private Sub picEtoile1_MouseClick(sender As Object, e As MouseEventArgs) Handles picEtoile5.MouseClick, picEtoile4.MouseClick, picEtoile3.MouseClick, picEtoile2.MouseClick, picEtoile1.MouseClick
        If boolLectureSeule = False Then
            intNote = afficheNoteSouris(sender, stars, True)
        End If
        Me.OnMouseClick(e)
    End Sub

    Private Sub Note_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        If boolLectureSeule = False And intNote = 0 Then
            For i As Integer = 1 To stars.Count
                stars(i).image = My.Resources.dot
            Next
        End If
    End Sub

    Private Sub initialiserStars()
        stars = New Collection
        intNote = 0
        stars.Add(picEtoile1)
        stars.Add(picEtoile2)
        stars.Add(picEtoile3)
        stars.Add(picEtoile4)
        stars.Add(picEtoile5)
    End Sub
End Class
