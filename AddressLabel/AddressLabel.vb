'Isabella Dougherty
'RCET0265
'Spring 2023
'Address Label Program
'https://github.com/IsabellaDougherty/AddressLable

Public Class AddressLabel
    Dim fullName As String
    Dim streetAddress As String
    Dim city As String
    Dim state As String
    Dim zip As String
    Private Sub AddressLabel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        fullName = FirstNameTextBox.Text + " " + LastNameTextBox.Text
        streetAddress = StreetAddressTextBox.Text
        city = CityTextBox.Text
        state = StateTextBox.Text
        zip = ZipTextBox.Text
        OutputLabel.Text = fullName + "
" + streetAddress + "
" + city + ", " + state + " " + zip
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        OutputLabel.Text = ""
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        End
    End Sub
End Class
