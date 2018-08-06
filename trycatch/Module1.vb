Module Module1

    Sub Main()
        Console.WriteLine("testando try")

        Try

            Console.WriteLine("passa aqui")
            Console.ReadLine()

            Dim a As Integer
            a = "RRRR"

            Console.WriteLine("passa aqui depois")
            Console.ReadLine()

        Catch ex As Exception
            Console.WriteLine(ex)


        Finally

            Console.WriteLine("chegou no finally")
            Console.ReadLine()



        End Try

        Console.ReadLine()
    End Sub

End Module
