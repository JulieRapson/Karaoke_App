'Author:
'Date:
'Program Description:
Option Strict On
Option Explicit On

Public Class Form1
    'Variables
    Private _decSong As Decimal = 2.99D
    Private _decHourly As Decimal = 8.99D

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(3000)
    End Sub

    Private Function CalculateChoiceCost(ByVal intSongAmt As Integer) As Decimal
        Dim decSongCost As Decimal
        decSongCost = intSongAmt * _decSong

        Return decSongCost
    End Function

    Private Function CalculateHourlyCost(ByVal intHours As Integer) As Decimal
        Dim decHourlyCost As Decimal
        decHourlyCost = intHours * _decHourly

        Return decHourlyCost
    End Function
    Private Sub cboChoices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboChoices.SelectedIndexChanged
        'Combo box selettion triggers these actions
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
        'Creating a procedure that does not return a value and calling it from here
        ClearMe()
    End Sub

    Private Sub btnTotalCost_Click(sender As Object, e As EventArgs) Handles btnTotalCost.Click
        Dim blnIsValid As Boolean = False
        Dim intValidNum As Integer
        Dim decTotalCost As Decimal
        blnIsValid = ValidateInput()
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
