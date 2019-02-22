'Name: Alan Carruthers
'Date: 2/8/2019
'Description: This program will take 6 inputs as a course grade in different textboxes. It will then put the values into an array, sum
'them and then calculate the average. Finally it will display the average grade and also convert it to an equivalent letter grade.
Option Strict On
Public Class frmSemesterAverage
    Dim sum As Double 'Sum of all number grades
    Dim average As Double 'Average of number grades
    Dim gradesArray(5) As Double 'Array for all
    Dim convertedInput As Double 'String for user input
    Dim userInput As String 'User input
    Const gradeMax As Integer = 100 'Max grade allowed
    Const gradeMin As Integer = 0 'Minimum grade allowed
    Dim currentGrade As Integer = 0 'User's grade to be output
    Dim inputValidated As Boolean = False 'Boolean for input validation

    ''' <summary>
    ''' This function will check if a user's input if valid and return True or False
    ''' </summary>
    ''' <param name="input"></param>
    ''' <returns></returns>
    Public Function validation(input As String) As Boolean
        'Check if input can be parsed and is within range. Return result.
        If Double.TryParse(input, convertedInput) AndAlso (convertedInput <= gradeMax) AndAlso (convertedInput >= gradeMin) Then
            inputValidated = True
        Else
            inputValidated = False
        End If
        Return inputValidated
    End Function

    ''' <summary>
    ''' This function will convert the user's grade input to it's appropriate letter grade
    ''' </summary>
    ''' <param name="userInput"></param>
    ''' <returns></returns>
    Public Function letterConversion(userInput As Double) As String
        Dim letterGrade As String = ""
        'Switch statement to determine which letter grade should be assigned
        Select Case userInput
            Case 0 To 49
                letterGrade = "F"
            Case 50 To 52
                letterGrade = "D-"
            Case 53 To 56
                letterGrade = "D"
            Case 57 To 59
                letterGrade = "D+"
            Case 60 To 62
                letterGrade = "C-"
            Case 63 To 66
                letterGrade = "C"
            Case 67 To 69
                letterGrade = "C+"
            Case 70 To 72
                letterGrade = "B-"
            Case 73 To 76
                letterGrade = "B"
            Case 77 To 79
                letterGrade = "B+"
            Case 80 To 84
                letterGrade = "A-"
            Case 85 To 89
                letterGrade = "A"
            Case 90 To 100
                letterGrade = "A+"
        End Select
        Return letterGrade
    End Function


    ''' <summary>
    ''' Once the user tabs away from the textbox, run validation on the input and return focus to the textbox if validation fails.
    ''' If it succeeds then convert the number to a letter grade.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtGrade1_Leave(sender As Object, e As EventArgs) Handles txtGrade1.Leave
        userInput = txtGrade1.Text
        validation(userInput) 'Call validation function to validate user's input

        'If validation fails, create error message in output box, bring focus back to the textbox and reset them to empty strings.
        If (inputValidated = False) Then
            txtOutput.Text = "Grade must be a number between 0 and 100 inclusive. Please try again."
            txtGrade1.Text = ""
            lblLetter1.Text = ""
            txtGrade1.Focus()
            'If validation succeeds, run the letter conversion function and output it to its label. Also output the user's number grade to
            '   the output textbox
        ElseIf (inputValidated = True) Then
                lblLetter1.Text = letterConversion(convertedInput)
            txtOutput.Text = "" & txtGrade1.Text
        End If
    End Sub

    ''' <summary>
    ''' Once the user tabs away from the textbox, run validation on the input and return focus to the textbox if validation fails.
    ''' If it succeeds then convert the number to a letter grade.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtGrade2_Leave(sender As Object, e As EventArgs) Handles txtGrade2.Leave
        userInput = txtGrade2.Text
        validation(userInput)
        If (inputValidated = False) Then
            txtOutput.Text = "Grade must be a number between 0 and 100 inclusive. Please try again."
            txtGrade2.Text = ""
            lblLetter2.Text = ""
            txtGrade2.Focus()
            ElseIf (inputValidated = True) Then
                lblLetter2.Text = letterConversion(convertedInput)
            txtOutput.Text = txtGrade1.Text & vbCrLf & txtGrade2.Text
        End If
    End Sub

    ''' <summary>
    ''' Once the user tabs away from the textbox, run validation on the input and return focus to the textbox if validation fails.
    ''' If it succeeds then convert the number to a letter grade.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtGrade3_Leave(sender As Object, e As EventArgs) Handles txtGrade3.Leave
        userInput = txtGrade3.Text
        validation(userInput)
        If (inputValidated = False) Then
            txtOutput.Text = "Grade must be a number between 0 and 100 inclusive." & vbCrLf & "Please try again."
            txtGrade3.Text = ""
            lblLetter3.Text = ""
            txtGrade3.Focus()
        ElseIf (inputValidated = True) Then
            lblLetter3.Text = letterConversion(convertedInput)
            txtOutput.Text = txtGrade1.Text & vbCrLf & txtGrade2.Text & vbCrLf & txtGrade3.Text
        End If
    End Sub

    ''' <summary>
    ''' Once the user tabs away from the textbox, run validation on the input and return focus to the textbox if validation fails.
    ''' If it succeeds then convert the number to a letter grade.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtGrade4_Leave(sender As Object, e As EventArgs) Handles txtGrade4.Leave
        userInput = txtGrade4.Text
        validation(userInput)
        If (inputValidated = False) Then
            txtOutput.Text = "Grade must be a number between 0 and 100 inclusive." & vbCrLf & "Please try again."
            txtGrade4.Text = ""
            lblLetter4.Text = ""
            txtGrade4.Focus()
        ElseIf (inputValidated = True) Then
            lblLetter4.Text = letterConversion(convertedInput)
            txtOutput.Text = txtGrade1.Text & vbCrLf & txtGrade2.Text & vbCrLf & txtGrade3.Text & vbCrLf & txtGrade4.Text
        End If
    End Sub

    ''' <summary>
    ''' Once the user tabs away from the textbox, run validation on the input and return focus to the textbox if validation fails.
    ''' If it succeeds then convert the number to a letter grade.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtGrade5_Leave(sender As Object, e As EventArgs) Handles txtGrade5.Leave
        userInput = txtGrade5.Text
        validation(userInput)
        If (inputValidated = False) Then
            txtOutput.Text = "Grade must be a number between 0 and 100 inclusive. " & vbCrLf & "Please try again."
            txtGrade5.Text = ""
            lblLetter5.Text = ""
            txtGrade5.Focus()
        ElseIf (inputValidated = True) Then
            lblLetter5.Text = letterConversion(convertedInput)
            gradesArray(4) = convertedInput
            txtOutput.Text = txtGrade1.Text & vbCrLf & txtGrade2.Text & vbCrLf & txtGrade3.Text & vbCrLf & txtGrade4.Text _
                & vbCrLf & txtGrade5.Text
        End If
    End Sub

    ''' <summary>
    ''' Once the user tabs away from the textbox, run validation on the input and return focus to the textbox if validation fails.
    ''' If it succeeds then convert the number to a letter grade.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtGrade6_Leave(sender As Object, e As EventArgs) Handles txtGrade6.Leave
        userInput = txtGrade6.Text
        validation(userInput)
        If (inputValidated = False) Then
            txtOutput.Text = "Grade must be a number between 0 and 100 inclusive. " & vbCrLf & "Please try again."
            txtGrade6.Text = ""
            lblLetter6.Text = ""
            txtGrade6.Focus()
        ElseIf (inputValidated = True) Then
            lblLetter6.Text = letterConversion(convertedInput)
            gradesArray(5) = convertedInput
            txtOutput.Text = txtGrade1.Text & vbCrLf & txtGrade2.Text & vbCrLf & txtGrade3.Text & vbCrLf & txtGrade4.Text _
                & vbCrLf & txtGrade5.Text & vbCrLf & txtGrade6.Text
        End If
    End Sub

    ''' <summary>
    ''' Assign all textbox inputs to an array, sum the array with a loop and then calculate the average
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Check if any textboxes hvae been left blank
        If Not (String.IsNullOrWhiteSpace(txtGrade1.Text) Or Not String.IsNullOrWhiteSpace(txtGrade2.Text) Or Not _
            String.IsNullOrWhiteSpace(txtGrade3.Text) Or Not String.IsNullOrWhiteSpace(txtGrade4.Text) Or Not _
            String.IsNullOrWhiteSpace(txtGrade5.Text)) Or Not String.IsNullOrWhiteSpace(txtGrade6.Text) Then

            'Take textbox inputs and put them into the array
            gradesArray(0) = Convert.ToDouble(txtGrade1.Text)
            gradesArray(1) = Convert.ToDouble(txtGrade2.Text)
            gradesArray(2) = Convert.ToDouble(txtGrade3.Text)
            gradesArray(3) = Convert.ToDouble(txtGrade4.Text)
            gradesArray(4) = Convert.ToDouble(txtGrade5.Text)
            gradesArray(5) = Convert.ToDouble(txtGrade6.Text)

            'For loop to loop through the array and sum its elements
            For counter As Integer = 0 To 5
                sum += gradesArray(counter)
            Next counter

            'Calculate the average of the array and output it to the average textbox, then run the letter conversion function and assign 
            'the output to the letter label.
            average = Math.Round(sum / 6, 2)
            lblAverageNumber.Text = Convert.ToString(average)
            lblAverageLetter.Text = letterConversion(average)

            'Disable all textboxes and the calculate button until the application is reset
            txtGrade1.Enabled = False
            txtGrade2.Enabled = False
            txtGrade3.Enabled = False
            txtGrade4.Enabled = False
            txtGrade5.Enabled = False
            txtGrade6.Enabled = False
            btnCalculate.Enabled = False
        Else
            txtOutput.Text = "You cannot leave any textboxes blank. Please enter a value for each course."
        End If
    End Sub

    ''' <summary>
    ''' Reset all forms
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Briefly set inputs to valid entry
        txtGrade1.Text = "0"
        txtGrade2.Text = "0"
        txtGrade3.Text = "0"
        txtGrade4.Text = "0"
        txtGrade5.Text = "0"
        txtGrade6.Text = "0"
        'Set focus to first course
        txtGrade1.Focus()
        'Reset all text properties to blank
        txtGrade1.Text = ""
        txtGrade2.Text = ""
        txtGrade3.Text = ""
        txtGrade4.Text = ""
        txtGrade5.Text = ""
        txtGrade6.Text = ""
        txtOutput.Text = ""
        lblAverageNumber.Text = ""
        lblAverageLetter.Text = ""
        lblLetter1.Text = ""
        lblLetter2.Text = ""
        lblLetter3.Text = ""
        lblLetter4.Text = ""
        lblLetter5.Text = ""
        lblLetter6.Text = ""

        'Re-enable all buttons and textboxes
        txtGrade1.Enabled = True
        txtGrade2.Enabled = True
        txtGrade3.Enabled = True
        txtGrade4.Enabled = True
        txtGrade5.Enabled = True
        txtGrade6.Enabled = True
        btnCalculate.Enabled = True

        'Reset appropriate arrays and variables
        sum = 0
        average = 0
        Array.Clear(gradesArray, 0, 6)
    End Sub

    ''' <summary>
    ''' This will close the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub
End Class