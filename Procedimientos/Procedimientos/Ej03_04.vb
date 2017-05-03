
'3.4. Dados los lados A y B de un triángulo rectángulo, según el teorema de Pitágoras, el cuadrado de
'la hipotenusa(C), es igual a la suma del cuadrado de los catetos (lados) de lo que se da la
'siguiente fórmula : c² = a² + b². Elaborar una función que reciba el tamaño de los lados A y B,
'calcule y devuelva C (hipotenusa). Ingresar los valores por teclado y mostrar el resultado en
'consola.Utilizar una función para validar los valores ingresados sean enteros positivos, si no
'cumple esta condición pedir el reingreso del dato.

Module Ej03_04
    Sub main()
        Dim ladoA As Integer
        Dim ladoB As Integer
        Do
            Console.WriteLine("Ingrese el lado A: ")
            ladoA = Console.ReadLine()
            Console.WriteLine("Ingrese el lado B: ")
            ladoB = Console.ReadLine()
        Loop Until validar(ladoA) And validar(ladoB)
        Console.WriteLine("La hipotenusa es: " & Hiponetusa(ladoA, ladoB))

        Console.ReadKey()
    End Sub

    Private Function validar(lado As Integer) As Boolean
        If lado > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function Hiponetusa(ladoN As Integer, ladoM As Integer) As Single
        Return Math.Sqrt(Math.Pow(ladoN, 2) + Math.Pow(ladoM, 2))
    End Function

End Module
