
'3.2. Crear una función que reciba una fecha y un entero que representa una cantidad de días a sumar
'a la fecha. Desde el módulo principal ingresar una fecha y la cantidad de días e invocar a esta
'función pasándole los parámetros: fecha actual y días, mostrar el valor obtenido

Module Ej03_02
    Sub main()
        Dim fecha As Date
        Dim dias As Integer
        Console.WriteLine("Ingrese una fecha: ")
        fecha = Console.ReadLine()
        Console.WriteLine("Ingrese los días a sumar: ")
        dias = Console.ReadLine()
        Console.WriteLine("La nueva fecha es: " & CalculoDias(fecha, dias))
        Console.ReadKey()
    End Sub

    Private Function CalculoDias(fec As Date, days As UShort) As Date
        Return fec.AddDays(days)
    End Function

End Module
