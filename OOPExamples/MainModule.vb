Module MainModule

    Sub Main()
        'DoSomethingInMainModule()
        'doSomethingInSecondModule()
        'MsgBox(ExampleClass.Sumof(4, 3))

        Dim jimmy As New Animal
        Dim bob As New Animal

        jimmy.Move()
        bob.Move()




    End Sub

    ''' <summary>
    ''' Show a message box from within the main module
    ''' </summary>

    Sub DoSomethingInMainModule()
        MsgBox("Hello from the MainModule!")
    End Sub



End Module
