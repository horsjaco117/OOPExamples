Public Class ExampleClass

    ''' <summary>
    ''' takes two integer arguments and returns the sum 
    ''' </summary>
    ''' <param name="firstNumber"></param>
    ''' <param name="secondNumber"></param>
    ''' <returns>integer</returns>

    Public Shared Function Sumof(firstNumber As Integer, secondNumber As Integer) As Integer

        Return firstNumber + secondNumber
    End Function

    Public Sub DoSomething()
        MsgBox("Hello")
    End Sub
End Class
