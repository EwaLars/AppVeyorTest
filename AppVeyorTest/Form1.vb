Imports Xunit

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(TeileDurch(17, 3))
    End Sub

    Public Shared Function TeileDurch(Dividend As Decimal, Divisor As Decimal) As Decimal
        Dim result As Decimal
        result = Dividend / Divisor
        Return result
    End Function
End Class

Public Class Form1_Test

    <Theory>
    <InlineData(15, 3, 5)>
    <InlineData(20, 4, 5)>
    <InlineData(9, 3, 3)>
    <InlineData(100, 10, 10)>
    Public Sub TeileDurch_working(Dividend As Decimal, Divisor As Decimal, Expected As Decimal)
        Dim result = Form1.TeileDurch(Dividend, Divisor)
        Assert.Equal(Expected, result)
    End Sub

    <Fact>
    Public Sub TeileDurch_devidedByZero()
        Assert.Throws(Of DivideByZeroException)(Function() Form1.TeileDurch(15, 0))
    End Sub

End Class