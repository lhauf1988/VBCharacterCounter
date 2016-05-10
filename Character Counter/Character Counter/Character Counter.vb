'Lucas Hauf 
'POS 408
'11/24/2015
'This is a program to count the diffrent characters entered by the user into the text field
Public Class frmCharacterCounter

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit() 'closes the application 
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtInput.Clear() 'Clears all data in the fields and puts focus back to the text field
        lblAmountLowerCase.Text = ""
        lblAmountNumbers.Text = ""
        lblAmountSpecialCharacters.Text = ""
        lblAmountUpper.Text = ""
        lblErrorMessage.Visible = False
        txtInput.Focus()
    End Sub

    Private Sub btnShowMe_Click(sender As Object, e As EventArgs) Handles btnShowMe.Click

        If LengthCheck() = True Then 'runs the check length function and if the text box is longer then 12 characters it runs the CounteCharacters subroutine
            Exit Sub
        Else
            Call CountCharacters()
        End If
    End Sub
    Private Function LengthCheck() As Boolean
        Dim strLength As String
        strLength = txtInput.Text
        If strLength.Count < 12 Then 'if the text box is less then 12 characters an error label is shown and the function is exited 
            lblErrorMessage.Text = "Please enter 12 or more Characters"
            lblErrorMessage.Visible = True

            txtInput.Focus()
            LengthCheck = True
            lblAmountLowerCase.Text = ""
            lblAmountNumbers.Text = ""
            lblAmountSpecialCharacters.Text = ""
            lblAmountUpper.Text = ""
            Exit Function
        Else
            LengthCheck = False 'if the text box has 12 or more the function ends and the error label stay invisible

        End If
    End Function

    Private Sub frmCharacterCounter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtInput.Focus() 'causes the courser to be on the text field
        tltpMessages.SetToolTip(Me.btnExit, "Exit Application") 'sets the tool tip text on each button 
        tltpMessages.SetToolTip(Me.btnReset, "Clears All Fields")
        tltpMessages.SetToolTip(Me.btnShowMe, "Count The Characters")


    End Sub
    Private Sub CountCharacters()
        Dim strInputField As String
        strInputField = txtInput.Text

        Dim strUpper = From Upper In strInputField Where Char.IsUpper(Upper)  'puts the uppercase letters into the variable 
        Dim strLower = From Lower In strInputField Where Char.IsLower(Lower)  ' puts the lowercase letter into the variable 
        Dim strNumbers = From Numbers In strInputField Where Char.IsNumber(Numbers)  'puts the numbers into the variable
        Dim strSpecial = From Special In strInputField Where Char.IsSymbol(Special)  ' puts the symbols into the variable

        lblAmountUpper.Text = strUpper.Count() 'this section counts the characters in each variable and displays the number of how many characters are in that variable
        lblAmountLowerCase.Text = strLower.Count()
        lblAmountNumbers.Text = strNumbers.Count()
        lblAmountSpecialCharacters.Text = strSpecial.Count()
        txtInput.Focus()
    End Sub


End Class
