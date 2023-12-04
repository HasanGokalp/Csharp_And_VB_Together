Module Program
    Sub Main(args As String())
        Dim araba As New Entity.araba With {
         .Id = 1
        }
        Console.WriteLine(araba.Id.ToString())
    End Sub
End Module
