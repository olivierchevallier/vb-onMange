' 624-2 Projet de Génie logiciel - OnMange!
'
' Module controlant la planification du calendrier de repas (CLASSE INCOMPLÈTE)
'
' Olivier Chevallier
Module ModPlanifier
    'Affiche les plats dans le composant de vote
    Public Sub initTabPlanifier(ByRef chPlat As ChoixPlat)
        chPlat.plaPlat1.Plat = getPlatAleatoire()
        chPlat.plaPlat2.Plat = getPlatAleatoire()
        chPlat.plaPlat3.Plat = getPlatAleatoire()
        chPlat.plaPlat4.Plat = getPlatAleatoire()
    End Sub
End Module
