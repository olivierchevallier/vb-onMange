Public Class Repas
    Inherits Plat

    Private moment As String

    Public Sub New(ByVal nomPlat As String, ByVal origine As String, ByVal mangeLe As Date, ByVal moment As String, ByVal noteMoyenne As Double)
        MyBase.New(nomPlat, origine, mangeLe, noteMoyenne)
        Me.moment = moment
    End Sub
End Class
