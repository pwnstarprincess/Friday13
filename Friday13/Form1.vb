﻿'Jennifer Pezzulo
'Chapter 6.2 Question 36 Friday the 13th

Public Class Form1

    'Boolean function returns true if date is Friday
    Function IsFriday(myDate As Date) As Boolean
        'If Date converted to a [Day of Week, Month Day, Year] formatted String starts with Friday
        'Then return true because the supplied date is a Friday
        If myDate.ToString("D").StartsWith("Friday") Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'variable to increment the number of Fridays
        Dim fridays As Integer
        'Variable to hold the date
        Dim myDate As Date

        'For loop to loop through months
        For i As Integer = 1 To 12

            'convert to date [i/13/year from textbox] and assign to myDate
            myDate = CDate(i & "/" & "13/" & YearBox.Text)

            'If this date is a Friday then increment the friday counter
            If IsFriday(myDate) Then
                fridays += 1
            End If

        Next

        'Output total number of Fridays for the given year
        MonthsBox.Text = CStr(fridays)

    End Sub
End Class
