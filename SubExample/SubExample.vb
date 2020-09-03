Option Strict On
Option Explicit On


Module SubExample

    Sub Main()
        Dim x As Integer
        Dim y As Integer
        'this code runs at start up
        Console.WriteLine("In Sub Main")

        ''call the Example sub
        'AsubExample()

        'Console.WriteLine("Back In Sub Main")



        'SubWithArguments("secret code")
        'Console.ReadLine()
        x = 5I
        y = 3I
        Console.WriteLine(x)

        Console.ReadLine()
        VariableSope()
        Console.WriteLine("Back to sub main")
        Console.WriteLine(x)
        Console.ReadLine()
    End Sub


    Sub AsubExample()
        'this code only run when  its "called"
        Console.WriteLine("In Sub AsubExample")
        Console.ReadLine()
    End Sub

    Sub SubWithArguments(message As String)

        Console.WriteLine(message)

    End Sub

    Sub VariableSope()
        Dim x As Integer
        Console.WriteLine("In Sub VariableSope")

        x = 7I
        'y=3I
        Console.WriteLine(x)
        Console.ReadLine()
    End Sub
End Module
