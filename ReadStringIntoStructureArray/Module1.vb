Module Module1
    Structure Thing
        Dim ThingName As String
        Dim ThingAge As Integer
        Dim ThingRating As Integer
        Dim ThingScore As Double
        Sub New(tName, tAge, tRating, tScore)
            ThingName = tName
            ThingAge = tAge
            ThingRating = tRating
            ThingScore = tScore
        End Sub
    End Structure
    Sub Main()
        Dim Things(10) As Thing
        Dim demoThing As String = "Big thing,14,4,12.5"
        Dim demoSplit = demoThing.Split(",")
        Things(0) = New Thing(demoSplit(0), demoSplit(1), demoSplit(2), demoSplit(3))
        Console.WriteLine(Things(0).ThingName)
        Console.WriteLine(Things(0).ThingAge)
    End Sub

End Module
