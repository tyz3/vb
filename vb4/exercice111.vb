Module exercice111
    Sub fonction()
        Function PerimetreCercle(ByVal pRayon As Double) As Double
        Return 2 * Math.PI * pRayon
    End Function

    Function SurfaceCercle(ByVal pRayon As Double) As Double
        Return Math.PI * pRayon * pRayon
    End Function

    Function PerimetreRectangle(ByVal pLongueur As Double, ByVal pLargeur As Double) As Double
        Return 2 * (pLongueur + pLargeur)
    End Function

    Function SurfaceRectangle(ByVal pLongueur As Double, ByVal pLargeur As Double) As Double
        Return pLongueur * pLargeur
    End Function

    End Sub




    Sub Main()
        Dim n As Integer
        Do
            Console.WriteLine("1. Calcul du périmètre d'un cercle.")
            Console.WriteLine("2. Calcul de la surface d'un cercle.")
            Console.WriteLine("3. Calcul du périmètre d'un rectangle.")
            Console.WriteLine("4. Calcul de la surface d'un rectangle.")
            Console.WriteLine("5. Quitter.")
            Console.Write("Choix ? ")
            n = CInt(Console.ReadLine())

            Select Case n
                Case 1 'Périmètre Cercle
                    Dim rayon As Double = saisie("Rayon du cercle ?")
                    Console.WriteLine("Périmètre: & PerimètreCercle(Rayon)")
                Case 2 ' Surface d'un cercle
                    Dim rayon As Double = saisie("Rayon du cercle ? (Rayon > 0)")
                    Console.WriteLine("Surface: " & SurfaceCercle(rayon))
                Case 3 ' Périmètre d'un rectangle
                    Dim longueur As Double = LireSaisiePositive("Longueur du rectangle")
                    Dim largeur As Double = LireSaisiePositive("Largeur du rectangle")
                    Console.WriteLine("Périmètre: " & PerimetreRectangle(longueur, largeur))
                Case 4 ' Surface d'un rectangle
                    Dim longueur As Double = saisie("Longueur du rectangle")
                    Dim largeur As Double = saisie("Largeur du rectangle")
                    Console.WriteLine("Surface: " & SurfaceRectangle(longueur, largeur))
                Case 5 ' Quitter
                    Console.WriteLine("Au revoir.")
                Case Else
                    Console.WriteLine("Choix erroné.")
            End Select

        Function saisie(ByVal message As String) As Double
        Dim valeur As Double
        Do
            Console.Write(message & " ")
            valeur = CDbl(Console.ReadLine())
            If valeur <= 0 Then
                Console.WriteLine(message)
            End If
        Loop While valeur <= 0
        Return valeur

    End Function

    End Sub

End Module
