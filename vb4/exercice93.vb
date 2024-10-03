Module exercice93
    Sub Main()
        Dim n As Integer

        Console.WriteLine("Veuillez entrer un nombre entier positif (n) :")
        n = CInt(Console.ReadLine())

        While n <= 0
            Console.WriteLine("Le nombre doit être supérieur à 0. Veuillez réessayer :")
        End While

        Console.WriteLine("Les " & n & " premiers nombres pairs supérieurs à 0 sont :")

        For i As Integer = 1 To n
            Console.WriteLine(i * 2)
        Next

        Console.WriteLine("Appuyez sur une touche pour quitter.")
        Console.ReadLine()
    End Sub
End Module
