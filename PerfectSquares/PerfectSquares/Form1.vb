Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click

        lstResult.Items.Clear()

        Dim num As Integer = 1
        Dim numSq As Integer
        Do While num <= 10
            numSq = num ^ 2
            lstResult.Items.Add(numSq)
            num = num + 1
        Loop


    End Sub
End Class
