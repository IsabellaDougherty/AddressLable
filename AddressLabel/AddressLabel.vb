'Isabella Dougherty
'RCET0265
'Spring 2023
'Address Label Program
'https://github.com/IsabellaDougherty/AddressLable

Public Class AddressLabel
    'Initializes variables to be used throughout code
    Dim fullName As String
    Dim streetAddress As String
    Dim city As String
    Dim state As String
    Dim zip As String
    Dim toasty As Integer = 0

    'Initializes form
    Private Sub AddressLabel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Toast.Visible = False
    End Sub

    'Sets the lable of the output display to the formatted version of the address label and clears the picture of toast or resets the clicks
    'for the picture of toast to appear
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        fullName = FirstNameTextBox.Text + " " + LastNameTextBox.Text
        streetAddress = StreetAddressTextBox.Text
        city = CityTextBox.Text
        state = StateTextBox.Text
        zip = ZipTextBox.Text
        OutputLabel.Text = fullName + "
" + streetAddress + "
" + city + ", " + state + " " + zip
        toasty = 0
        Toast.Visible = False
    End Sub

    'Clears the display box and displays a picture of toast if the clear button is clicked 10 times or more
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        OutputLabel.Text = ""
        toasty += 1
        If toasty >= 10 Then
            Toast.Visible = True
        Else
            Toast.Visible = False
        End If
    End Sub

    'Exits the code
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        End
    End Sub
End Class
