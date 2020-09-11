'Doyle_Shaw
'RCET0265
'Fall_2020
'Fortune Cookie
'https://github.com/shawdoyl/Fortune-Cookie.git

Option Explicit On
Option Strict On
Option Compare Text

Module Module1

    Sub Main()
        Dim randomNumber As Integer
        Dim quitProgram As Boolean = False

        Do While quitProgram = False

            Console.Clear()
            Randomize()
            randomNumber = CInt((3 * Rnd()) + 1)
            Console.WriteLine("Your gift of wisdom is:")
            Console.WriteLine()
            If randomNumber = 1 Then
                Console.WriteLine("All boring normal people wear digital watches.")
            ElseIf randomNumber = 2 Then
                Console.WriteLine("Never leave home without a towel.")
            ElseIf randomNumber = 3 Then
                Console.WriteLine("You know it is extremely unlikely to be rescued when vented into space.")
            ElseIf randomNumber = 3 Then
                Console.WriteLine("Be glad. If the earth is destroyed then the worst poem in the universe is also destroyed along with it.")
            ElseIf randomNumber = 4 Then
                Console.WriteLine("The answer to life, meaning and the universe is 42.")
            Else
                Console.WriteLine("No fortune for you.")
            End If
            Console.WriteLine()
            Console.WriteLine("If more sage wisdom is desired, then press Enter, otherwise press q.")
            If Console.ReadLine() = "q" Then
                quitProgram = True
            Else
                quitProgram = False
            End If

        Loop

    End Sub

End Module
