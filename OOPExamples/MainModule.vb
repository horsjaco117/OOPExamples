Option Explicit On
Option Strict On

Module MainModule

    Sub Main()
        'DoSomethingInMainModule()
        'doSomethingInSecondModule()
        'MsgBox(ExampleClass.Sumof(4, 3))

        Dim jimmy As New Animal
        Dim bob As New Mammal
        Dim lucky As New Dog
        Dim pepe As New Dog
        Dim nemo As New Fish


        'jimmy.Move()
        'Console.WriteLine(jimmy.skinType)
        'bob.Move()
        'Console.WriteLine(bob.skinType)


        pepe.movement = "Shiver"
        pepe.skinType = "Hairless"
        pepe.vocalization = "yip yip yip"
        pepe.speak()
        pepe.Move()

        lucky.speak()
        lucky.Move()

        nemo.speak()

    End Sub

    ''' <summary>
    ''' Show a message box from within the main module
    ''' </summary>

    Sub DoSomethingInMainModule()
        MsgBox("Hello from the MainModule!")
    End Sub



End Module
