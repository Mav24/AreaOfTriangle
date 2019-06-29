Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Display numbers from 20 - 50 increments of 0.5 in base and height listboxes
        For index = 20 To 50 Step 0.5
            lstBase.Items.Add(index)
            lstHeight.Items.Add(index)
        Next
        ' Display numbers 1 - 6 in increments of 0.5 in price listbox
        For priceListBox = 1 To 6 Step 0.5
            lstPrice.Items.Add(priceListBox)
        Next
        lstBase.SelectedIndex = 0
        lstHeight.SelectedIndex = 0
        lstPrice.SelectedIndex = 0

    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Declar variable for Triangle class
        Dim playGround As Triangle
        ' Declar need variables
        Dim base As Double
        Dim height As Double
        Dim price As Double

        ' Assign variables
        price = lstPrice.SelectedItem
        base = lstBase.SelectedItem
        height = lstHeight.SelectedItem

        ' Instantiate and initialize a Triangle object
        playGround = New Triangle(base, height, price)

        ' Display calculate values
        lblArea.Text = playGround.GetArea().ToString() + " Sqf"
        lblCost.Text = playGround.GetPrice().ToString("C")
    End Sub
End Class
