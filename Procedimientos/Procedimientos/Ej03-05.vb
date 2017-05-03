'3.5. El volumen de un cilindro se calcula multiplicando la constante Pi (π=3.14159265) por el
'cuadrado del radio de la base(r) por la altura(h) de lo que se da la siguiente fórmula: v = πr²h.
'Elaborar una función que lea el radio de la base y la altura de un cilindro, que calcule y
'devuelva el volumen. Ingresar los valores por teclado y mostrar el resultado en consola. Utilizar
'un procedimiento para validar los valores ingresados sean positivos, si no cumple esta condición
'pedir el reingreso del dato.
Module Ej03_05
    Sub main()
        Dim radio, alt As Single
        Do
            Console.WriteLine("Ingrese el radio de la base: ")
            radio = Console.ReadLine()
            Console.WriteLine("Ingrese la altura del cilindro: ")
            alt = Console.ReadLine()
        Loop Until validar(radio) And validar(alt)

        Console.WriteLine("El volumen es: " & calcular(radio, alt))

        Console.ReadKey()
    End Sub

    Private Function validar(valor As Single) As Boolean
        If valor > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function calcular(rad As Single, altura As Single) As Single
        Return 3.14159265 * rad * altura
    End Function

End Module
