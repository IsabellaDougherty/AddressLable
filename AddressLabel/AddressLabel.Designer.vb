<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddressLabel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.InputGroupBox = New System.Windows.Forms.GroupBox()
        Me.ZipLabel = New System.Windows.Forms.Label()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StreetAddressLabel = New System.Windows.Forms.Label()
        Me.StreetAddressTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.DisplayButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.OutputGroupBox = New System.Windows.Forms.GroupBox()
        Me.Toast = New System.Windows.Forms.PictureBox()
        Me.OutputLabel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.InputGroupBox.SuspendLayout()
        Me.OutputGroupBox.SuspendLayout()
        CType(Me.Toast, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InputGroupBox
        '
        Me.InputGroupBox.BackColor = System.Drawing.Color.Tan
        Me.InputGroupBox.Controls.Add(Me.ZipLabel)
        Me.InputGroupBox.Controls.Add(Me.ZipTextBox)
        Me.InputGroupBox.Controls.Add(Me.StateLabel)
        Me.InputGroupBox.Controls.Add(Me.StateTextBox)
        Me.InputGroupBox.Controls.Add(Me.CityLabel)
        Me.InputGroupBox.Controls.Add(Me.CityTextBox)
        Me.InputGroupBox.Controls.Add(Me.StreetAddressLabel)
        Me.InputGroupBox.Controls.Add(Me.StreetAddressTextBox)
        Me.InputGroupBox.Controls.Add(Me.LastNameLabel)
        Me.InputGroupBox.Controls.Add(Me.FirstNameLabel)
        Me.InputGroupBox.Controls.Add(Me.LastNameTextBox)
        Me.InputGroupBox.Controls.Add(Me.FirstNameTextBox)
        Me.InputGroupBox.Location = New System.Drawing.Point(29, 4)
        Me.InputGroupBox.Name = "InputGroupBox"
        Me.InputGroupBox.Size = New System.Drawing.Size(273, 304)
        Me.InputGroupBox.TabIndex = 0
        Me.InputGroupBox.TabStop = False
        Me.InputGroupBox.Text = "Mailing Address"
        '
        'ZipLabel
        '
        Me.ZipLabel.AutoSize = True
        Me.ZipLabel.Location = New System.Drawing.Point(196, 196)
        Me.ZipLabel.Name = "ZipLabel"
        Me.ZipLabel.Size = New System.Drawing.Size(55, 15)
        Me.ZipLabel.TabIndex = 11
        Me.ZipLabel.Text = "Zip Code"
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(196, 213)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(64, 23)
        Me.ZipTextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.ZipTextBox, "Enter your addresses zip code here")
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(136, 195)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(33, 15)
        Me.StateLabel.TabIndex = 9
        Me.StateLabel.Text = "State"
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(136, 213)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(50, 23)
        Me.StateTextBox.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.StateTextBox, "Enter the state of the address here")
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(9, 196)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(28, 15)
        Me.CityLabel.TabIndex = 7
        Me.CityLabel.Text = "City"
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(6, 213)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(124, 23)
        Me.CityTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.CityTextBox, "Enter the city of the address here")
        '
        'StreetAddressLabel
        '
        Me.StreetAddressLabel.AutoSize = True
        Me.StreetAddressLabel.Location = New System.Drawing.Point(9, 135)
        Me.StreetAddressLabel.Name = "StreetAddressLabel"
        Me.StreetAddressLabel.Size = New System.Drawing.Size(82, 15)
        Me.StreetAddressLabel.TabIndex = 5
        Me.StreetAddressLabel.Text = "Street Address"
        '
        'StreetAddressTextBox
        '
        Me.StreetAddressTextBox.Location = New System.Drawing.Point(6, 153)
        Me.StreetAddressTextBox.Name = "StreetAddressTextBox"
        Me.StreetAddressTextBox.Size = New System.Drawing.Size(254, 23)
        Me.StreetAddressTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.StreetAddressTextBox, "Enter the street address (numbers and name) here")
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(136, 77)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(63, 15)
        Me.LastNameLabel.TabIndex = 3
        Me.LastNameLabel.Text = "Last Name"
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(6, 77)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(64, 15)
        Me.FirstNameLabel.TabIndex = 2
        Me.FirstNameLabel.Text = "First Name"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(136, 95)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(124, 23)
        Me.LastNameTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.LastNameTextBox, "Enter your last name here")
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(6, 95)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(124, 23)
        Me.FirstNameTextBox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.FirstNameTextBox, "Enter your first name here")
        '
        'DisplayButton
        '
        Me.DisplayButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DisplayButton.Location = New System.Drawing.Point(6, 233)
        Me.DisplayButton.Name = "DisplayButton"
        Me.DisplayButton.Size = New System.Drawing.Size(160, 65)
        Me.DisplayButton.TabIndex = 6
        Me.DisplayButton.Text = "Display"
        Me.ToolTip1.SetToolTip(Me.DisplayButton, "Press this to display the address in a labled format")
        Me.DisplayButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClearButton.Location = New System.Drawing.Point(172, 233)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(139, 65)
        Me.ClearButton.TabIndex = 7
        Me.ClearButton.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Press this to clear the display")
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ExitButton.Location = New System.Drawing.Point(317, 233)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(138, 65)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Press this to exit the program")
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'OutputGroupBox
        '
        Me.OutputGroupBox.BackColor = System.Drawing.Color.Tan
        Me.OutputGroupBox.Controls.Add(Me.Toast)
        Me.OutputGroupBox.Controls.Add(Me.OutputLabel)
        Me.OutputGroupBox.Controls.Add(Me.ClearButton)
        Me.OutputGroupBox.Controls.Add(Me.ExitButton)
        Me.OutputGroupBox.Controls.Add(Me.DisplayButton)
        Me.OutputGroupBox.Location = New System.Drawing.Point(315, 4)
        Me.OutputGroupBox.Name = "OutputGroupBox"
        Me.OutputGroupBox.Size = New System.Drawing.Size(461, 304)
        Me.OutputGroupBox.TabIndex = 1
        Me.OutputGroupBox.TabStop = False
        Me.OutputGroupBox.Text = "Address Label"
        '
        'Toast
        '
        Me.Toast.Image = Global.AddressLabel.My.Resources.Resources.TOOOOOOOOOOOOOOOOOOOOOOAST
        Me.Toast.Location = New System.Drawing.Point(4, 14)
        Me.Toast.Name = "Toast"
        Me.Toast.Size = New System.Drawing.Size(451, 216)
        Me.Toast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Toast.TabIndex = 16
        Me.Toast.TabStop = False
        '
        'OutputLabel
        '
        Me.OutputLabel.Location = New System.Drawing.Point(6, 19)
        Me.OutputLabel.Name = "OutputLabel"
        Me.OutputLabel.Size = New System.Drawing.Size(449, 211)
        Me.OutputLabel.TabIndex = 15
        '
        'AddressLabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(790, 325)
        Me.Controls.Add(Me.OutputGroupBox)
        Me.Controls.Add(Me.InputGroupBox)
        Me.Name = "AddressLabel"
        Me.Text = "AddressLabel"
        Me.InputGroupBox.ResumeLayout(False)
        Me.InputGroupBox.PerformLayout()
        Me.OutputGroupBox.ResumeLayout(False)
        CType(Me.Toast, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InputGroupBox As GroupBox
    Friend WithEvents ZipLabel As Label
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents StateLabel As Label
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents CityLabel As Label
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StreetAddressLabel As Label
    Friend WithEvents StreetAddressTextBox As TextBox
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents DisplayButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents OutputGroupBox As GroupBox
    Friend WithEvents OutputLabel As Label
    Friend WithEvents Toast As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
