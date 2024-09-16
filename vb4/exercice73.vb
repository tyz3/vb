Module Exercice7_2
    Sub Main()
        Dim nb_j, dis, j_total_diesel, dis_total_diesel, j_total_essence, dis_total_essence, total_d, total_e As Double ' Saisie des nombres

        Console.WriteLine("Nombre de jours de location")
        nb_j = Console.ReadLine()
        Console.WriteLine("Nombre de km à parcourir")
        dis = Console.ReadLine()
        j_total_essence = 30 * nb_j
        dis_total_essence = 0.85 * dis
        j_total_diesel = 35 * nb_j
        dis_total_diesel = 0.65 * dis
        Console.WriteLine("le montant du au km (essence) est  : " + dis_total_essence.ToString())
        Console.WriteLine("le motant de la location (essence) est : " + j_total_essence.ToString())
        Console.WriteLine("le montant du au km (diesel) est  : " + dis_total_diesel.ToString())
        Console.WriteLine("le motant de la location (diesel) est : " + j_total_diesel.ToString())
        total_d = j_total_diesel + dis_total_diesel
        total_e = j_total_essence + j_total_essence

        If total_d < total_e Then
            Console.WriteLine("Meilleur choix : Dielsel")

        Else
            Console.WriteLine("Meilleur choix : Essence")
        End If
        Console.ReadLine()
    End Sub
End Module
