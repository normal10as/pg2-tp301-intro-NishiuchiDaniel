Imports Entidades


Module LoroTest

    Sub Main()

        Dim pajaro As New Loro
        pajaro.FechaNacimiento = #1989-10-10#

        pajaro.Escuchar("papita ")
        pajaro.Escuchar("pa el loro ")
        pajaro.Escuchar("Juan ")


        Console.WriteLine(pajaro.Hablar())
        Console.WriteLine(pajaro.Hablar())
        Console.WriteLine(pajaro.Hablar())
        Console.WriteLine(pajaro.Hablar())


        Console.WriteLine(pajaro.Edad)

    End Sub

End Module
