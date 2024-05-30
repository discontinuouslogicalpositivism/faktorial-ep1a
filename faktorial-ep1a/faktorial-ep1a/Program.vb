Imports System

Module Program
    Sub Main(args As String())
        Dim cislo As Integer
        Dim soucet As Integer = 0
        Dim input As String
        Dim ano As Boolean = False

        While Not ano
            Console.Write(" Zadej číslo: ")
            input = Console.ReadLine()

            If Integer.TryParse(input, cislo) Then
                ano = True
            Else
                Console.WriteLine(" Neplatnej vstup. Zadejte prosím celé číslo. ")
            End If
        End While

        For i As Integer = 1 To cislo
            soucet += i
        Next

        Console.WriteLine($" Součet od 1 do {cislo} je {soucet} ")

    End Sub
End Module
