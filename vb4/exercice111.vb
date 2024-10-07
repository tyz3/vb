Module exercice111
    Function PérimètreCercle(ByVal pRayon As Double) As Double
        PérimètreCercle = 2 * Math.PI * pRayon
    End Function

    Function SurfaceCercle(ByVal pRayon As Double) As Double
        SurfaceCercle = Math.PI * pRayon ** 2
    End Function

    Function PérimètreRectangle(ByVal pLongueur As Double, ByVal pLargeur As Double) As Double
        PérimètreRectangle = 2 * (pLongueur + pLargeur)
    End Function

    Function SurfaceRectangle(ByVal pLongueur As Double, ByVal pLargeur As Double) As Double
        SurfaceRectangle = (pLargeur + pLongueur)
    End Function

    Sub Main()
        Dim n As Double
        Console.WriteLine("1. Calcul du périmètre d un cercle".)
        Console.WriteLine("2. Calcul de la surface d un cercle.")
        Console.WriteLine("3. Calcul du périmètre d un rectangle")
        Console.WriteLine("4. Calcul de la surface d un rectangle".)
        Console.WriteLine("5. Quitter")

    End Sub

End Module
