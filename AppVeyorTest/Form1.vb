Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MsgBox(TeileDurch(17, 3))

    End Sub


    Public Shared Function TeileDurch(Dividend As Decimal, Divisor As Decimal) As Decimal
        Return Dividend / Divisor
    End Function



End Class
