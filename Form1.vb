Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Public Function modExpo(b, q, c) As Long
        Dim x As Long = 1
        While (q <> 0)
            While (q Mod 2 = 0)
                q /= 2
                b = (b ^ 2) Mod c
            End While
            q -= 1
            x = (x * b) Mod c
        End While
        Return x
    End Function
    Private Sub calc_Click(sender As Object, e As EventArgs) Handles calc.Click
        Dim b, q, c As Long
        b = base.Text
        q = pow.Text
        c = modd.Text
        MsgBox(modExpo(b, q, c))
    End Sub
End Class
