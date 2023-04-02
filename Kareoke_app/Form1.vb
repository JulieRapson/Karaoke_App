'Author: Julie Rapson
'Date: 4/1/2023  (April fools day!)
'Program Description:  This application is a small program to show costs of different choices for Karaoke.  I spelled my project incorrect so 
'will try and get back to that.  You have 2 options, an hourly charge or a per song charge.  Each option has a different cost.  Once you select
'the option drop down, you can enter an amount and calculate the cost which will display.  There is error handling in this version.

'These two items are to be added to each project going forward
Option Strict On
Option Explicit On

Public Class Form1
    'Constant variables for the drop down menu cost settings.
    Private _decSong As Decimal = 2.99D
    Private _decHourly As Decimal = 8.99D

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This will set the splash screen to a three second timer.
        Threading.Thread.Sleep(3000)
    End Sub

    Private Function CalculateChoiceCost(ByVal intSongAmt As Integer) As Decimal
        'Fuctions have to have a return.  The song amount is passed here with a call to this function
        'then that number will multiply with the SONG option dollar amount of the dropdown.  Will return the cost.
        Dim decSongCost As Decimal
        decSongCost = intSongAmt * _decSong

        Return decSongCost
    End Function

    Private Function CalculateHourlyCost(ByVal intHours As Integer) As Decimal
        'The hour amount is passed here with a call to this function
        'then that number will multiply with the HOURLY option dollar amount of the dropdown.  Will return the cost.
        Dim decHourlyCost As Decimal
        decHourlyCost = intHours * _decHourly

        Return decHourlyCost
    End Function
    Private Sub cboChoices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboChoices.SelectedIndexChanged
        'Combo box selection triggers these actions. Zero based on the combo box so option 0 is the first selection.
        'Depending on which is selected, it's setting the text for the label that is displayed. Both options set multiple labels
        'to be visible.
        If cboChoices.SelectedIndex = 0 Then
            lblChoiceTitle.Text = "Number of Karaoke Songs"
            lblChoiceTitle.Visible = True
            txtNumOfSongs.Visible = True
            btnClear.Visible = True
            btnTotalCost.Visible = True
            txtNumOfSongs.Focus()
        End If
        If cboChoices.SelectedIndex = 1 Then
            lblChoiceTitle.Text = "Hourly Rental of Karaoke Room"
            lblChoiceTitle.Visible = True
            txtNumOfSongs.Visible = True
            btnClear.Visible = True
            btnTotalCost.Visible = True
            txtNumOfSongs.Focus()
        End If
    End Sub
    Private Sub ClearMe()
        'Sub's do NOT return values.
        'This will clear out all the labels, buttons, texts etc.  Returns no value.
        txtNumOfSongs.Text = ""
        lblChoiceTitle.Visible = False
        txtNumOfSongs.Visible = False
        btnClear.Visible = False
        btnTotalCost.Visible = False
        cboChoices.SelectedIndex = -1
        lblTotalCost.Text = ""
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Created the above ^^ procedure that does not return a value and calling it from here, the button click
        ClearMe()
    End Sub

    Private Sub btnTotalCost_Click(sender As Object, e As EventArgs) Handles btnTotalCost.Click
        'Variables declared here are a little different than previous.  Doing a boolean and setting it to false initially but
        'then calling the validate input function (BELOW) to see if this can be set to true and returned.
        'Otherwise standard variables being created for total cost and valid number. 
        Dim blnIsValid As Boolean = False
        Dim intValidNum As Integer
        Dim decTotalCost As Decimal
        'call to private function
        blnIsValid = ValidateInput()
        'If the private function returns true, then we go through the process of which function to call 
        'depending on which drop down selection was picked. 
        If blnIsValid = True Then
            intValidNum = Convert.ToInt32(txtNumOfSongs.Text)
            If cboChoices.SelectedIndex = 0 Then
                decTotalCost = CalculateChoiceCost(intValidNum)
            Else
                decTotalCost = CalculateHourlyCost(intValidNum)
            End If
            lblTotalCost.Visible = True
            lblTotalCost.Text = "Total Cost of Karaoke Night - " & decTotalCost.ToString("C")
        End If
    End Sub
    Private Function ValidateInput() As Boolean
        'This fuction makes it very easy to do a check on number validity. It's going through 
        'large number check, neg number check and letters.  It will display a message box depending on where
        'the try catch statement "catches" the issue.
        Dim intIsNum As Integer
        Dim blnIsValid As Boolean = False
        Try
            intIsNum = Convert.ToInt32(txtNumOfSongs.Text)
            If intIsNum > 0D Then
                blnIsValid = True
                Return blnIsValid
            Else
                MsgBox("Please enter a number greater than 0", , "Error")
            End If
        Catch Exception As FormatException
            MsgBox("Please enter a valid number", , "Error")
        Catch Exception As OverflowException
            MsgBox("Please enter a smaller number")
        Catch Exception As SystemException
            MsgBox("This is an invalid entry. Please enter a valid number.", , "Error")
        End Try
        txtNumOfSongs.Focus()
        txtNumOfSongs.Text = ""
        Return blnIsValid
    End Function
End Class
