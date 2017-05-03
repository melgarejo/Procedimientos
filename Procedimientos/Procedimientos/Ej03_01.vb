
'3.1. Crear un módulo que imprima la fecha y hora actual con sus respectivas leyendas según las
'siguientes condiciones : 
' Utilizar una sub para imprimir la fecha actual.
' Utilizar una function para obtener la hora actual.
' Llamar a los métodos desde el método Main. 

Module Ej03_01
    Sub main()
        FechaActual()
        Console.WriteLine("Hora: " & HoraActual())
        Console.ReadKey()
    End Sub

    Private Sub FechaActual()
        Dim fecha As Date
        fecha = Today
        Console.WriteLine("Dia: " & fecha.Day & Chr(10) & "Mes: " & fecha.Month & Chr(10) & "Año: " & fecha.Year)
    End Sub

    'Ésta función es mas larga porque muestra las respectivas leyendas. y para que quede prolijo, hay que borrar
    '"Hora" de la linea 11 dentro del writeline

    'Private Function HoraActual() As String
    '    Dim horario As Date = Now
    '    Return "Hora: " & horario.Hour & Chr(10) & "Minuto: " & horario.Minute & Chr(10) & "Segundo " & horario.Second
    'End Function

    Private Function HoraActual() As Date
        Return TimeOfDay
    End Function
End Module
