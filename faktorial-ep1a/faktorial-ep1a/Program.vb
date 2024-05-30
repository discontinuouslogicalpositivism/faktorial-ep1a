Imports System

Module Program
    Sub Main(args As String())
        Dim cislo As Integer
        Dim soucet As Integer = 0
        Dim input As String
        Dim ano As Boolean = False

        While Not ano
            Console.Write("Zadej číslo (0 až 10): ")
            input = Console.ReadLine()

            If Integer.TryParse(input, cislo) Then
                If cislo >= 0 And cislo <= 10 Then
                    ano = True
                ElseIf cislo < 0 Then
                    Console.WriteLine("Záporné hodnoty NEJSOU povoleny!!!! Zadejte prosím číslo mezi 0 a 10.")
                Else
                    Console.WriteLine("Číslo je příliš vysoké. Zadejte prosím číslo mezi 0 a 10.")
                End If
            Else
                Console.WriteLine("Neplatný vstup. Zadejte prosím celé číslo.")
            End If
        End While

        For i As Integer = 1 To cislo
            soucet += i
        Next

        Console.WriteLine($" Součet od 1 do {cislo} je {soucet} ")

    End Sub
End Module
