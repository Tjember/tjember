Public Class DroneDogsOrder

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim numBeef, numPork, numTurkey, totDogs As Integer
        Dim subtotal, salesTaxAmt, totalCost As Double
        Const COST_PER_DOG As Double = 1.99
        Const SALES_TAX_RATE As Double = 0.06
        numBeef = Convert.ToInt32(txtBeefDogs.Text)
        numPork = Convert.ToInt32(txtPorkDogs.Text)
        numTurkey = Convert.ToInt32(txtTurkeyDogs.Text)
        totDogs = numBeef + numPork + numTurkey
        subtotal = totDogs * COST_PER_DOG
        salesTaxAmt = subtotal * SALES_TAX_RATE
        totalCost = subtotal - salesTaxAmt
        txtSubtotal.Text = subtotal.ToString("c2")
        txtSalesTax.Text = salesTaxAmt.ToString("c2")
        txtTotalCost.Text = totalCost.ToString("c2")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        MessageBox.Show("Thank you for ordering from the International House of Cards")
        Me.Close()
    End Sub


    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        'Make the customer form visible
        CustomerForm.Show()
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all text fields
        txtBeefDogs.Text = "Oink Oink"
        txtPorkDogs.Text = "Moo Moo"
        txtTurkeyDogs.Text = "Gobble Gobble"
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtEmail.Text = ""
        txtSubtotal.Text = ""
        txtSalesTax.Text = ""
        txtTotalCost.Text = ""
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Check the permission check box, the total cost text box and the email text box
        'Display an error message if any of them are empty
        'Otherwise, display a message box thanking them for ordering
        If chkPermission.Checked = False Then
            MessageBox.Show("ERROR...You must check the location permission check box.")
        ElseIf txtTotalCost.Text = "" Then
            MessageBox.Show("ERROR...You must order at least one item.")
        ElseIf txtEmail.Text = "" Then
            MessageBox.Show("ERROR...Please get customer information for this order.")
        Else
            MessageBox.Show("Thank you for ordering from DroneDogs!")
        End If
    End Sub

    Private Sub DroneDogsOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class