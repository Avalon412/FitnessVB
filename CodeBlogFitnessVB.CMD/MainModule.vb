Imports CodeBlogFitnessVB.BL

Module MainModule

    Sub Main()
        Console.WriteLine("Greetings from CodeBlogFitnessVB")

        Console.WriteLine("Enter UserName")
        Dim name As String = Console.ReadLine()

        Console.WriteLine("Enter Gender")
        Dim gender As String = Console.ReadLine()

        Console.WriteLine("Enter BirthDate")
        Dim birthdate As DateTime = DateTime.Parse(Console.ReadLine())

        Console.WriteLine("Enter Weight")
        Dim weight As Double = Double.Parse(Console.ReadLine())

        Console.WriteLine("Enter Height")
        Dim height As Double = Double.Parse(Console.ReadLine())

        Dim userController = New UserController(name, gender, birthdate, weight, height)
        userController.Save()
    End Sub

End Module
