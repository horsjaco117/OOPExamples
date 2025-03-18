Public Class Dog
    Inherits Mammal

    Sub New()
        Me.movement = "Wag tail and pee on the floor"
        Me.skinType = "I have a shiny coat"
        Me.vocalization = "Woof woof"
    End Sub

    'Sub speak()
    '    Console.WriteLine("Woof woof")
    'End Sub (We can slap this in the sub new to define only in one place)

End Class
