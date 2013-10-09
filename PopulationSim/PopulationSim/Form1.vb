Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click

        Dim year As Integer = 2012
        Dim population As Double = 7000000000
        Do While population > 6000000
            population = population / 2
            year = year - 50
        Loop
        MessageBox.Show("The population was less than 6 million in " & year)

    End Sub
End Class
