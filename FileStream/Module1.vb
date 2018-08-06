Imports System.IO.FileStream

Module Module1

    Sub Main()

        Dim fs As IO.FileStream
        Dim sr As IO.StreamReader
        Dim sw As IO.StreamWriter
        Dim caminhoarquivo As String
        Dim tamanho As Integer
        Dim tipo As Type

        caminhoarquivo = "D:\teste.txt"
        fs = New IO.FileStream(caminhoarquivo, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Write)
        sr = New IO.StreamReader(fs, System.Text.Encoding.UTF8)
        sw = New IO.StreamWriter(caminhoarquivo)
        tipo = fs.GetType()


        Console.WriteLine(tipo)

        While sr.Peek() >= 0
            Console.Write(Convert.ToChar(sr.Read()))
        End While
        sr.Close()

        'Console.WriteLine(tamanho)
        Console.ReadLine()

    End Sub

End Module
