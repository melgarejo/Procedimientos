
'3.3. Mostrar las 5 primeras potencias de un valor numérico ingresado por teclado del mismo.
'Implementar una función que retornará una potencia cada vez que se invoque, la primera vez el
'exponente será 2, la segunda vez 3 y así sucesivamente.

Module Ej03_03
    Sub main()
        Dim numero As Integer
        Console.WriteLine("Ingrese un número")
        numero = Console.ReadLine()
        For x = 2 To 6 Step 1
            Console.WriteLine("La potencia de " & numero & " ^ " & x & " es " & potencia(numero, x))
        Next
        Console.ReadKey()
    End Sub

    Private Function potencia(num As Integer, exponente As Integer) As Single
        Return Math.Pow(num, exponente)
    End Function
End Module
