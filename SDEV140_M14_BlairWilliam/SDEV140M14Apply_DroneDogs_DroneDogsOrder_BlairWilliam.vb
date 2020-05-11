Public Class DroneDogsOrder

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim numBeef, numPork, numTurkey, totDogs As Integer
        Dim subtotal, salesTaxAmt, totalCost As Double
        Const COST_PER_DOG As Double = 1.99
        Const SALES_TAX_RATE As Double = 0.06

        'We must do error handling to ensure that the user only users 0 or non-negative numbers
        'While inputting quantities.
        'The default values are set to 0.

        Try
            numBeef = Convert.ToInt32(txtBeefDogs.Text)

        Catch ex As System.FormatException
            ' Show the exception's message.
            'MessageBox.Show(ex.Message)
            MessageBox.Show("BeefDog quantity encountered an error. Please start over and ensure " _
                            & "only 0 or non-negative numbers are in the quantity box.")
            btnClear_Click(sender, e)
            Exit Sub
            ' Show the stack trace, which is a list of methods
            ' that are currently executing.
            'MessageBox.Show("Stack Trace: " & vbCrLf & ex.StackTrace)

        Finally
            ' This line executes whether or not the exception occurs.
            'MessageBox.Show("in Finally block")

        End Try

        Try
            numPork = Convert.ToInt32(txtPorkDogs.Text)

        Catch ex As System.FormatException
            ' Show the exception's message.
            'MessageBox.Show(ex.Message)
            MessageBox.Show("BeefDog quantity encountered an error. Please start over and ensure " _
                            & "only 0 or non-negative numbers are in the quantity box.")
            btnClear_Click(sender, e)
            Exit Sub
            ' Show the stack trace, which is a list of methods
            ' that are currently executing.
            'MessageBox.Show("Stack Trace: " & vbCrLf & ex.StackTrace)

        Finally
            ' This line executes whether or not the exception occurs.
            'MessageBox.Show("in Finally block")
        End Try

        Try
            numTurkey = Convert.ToInt32(txtTurkeyDogs.Text)

        Catch ex As System.FormatException
            ' Show the exception's message.
            'MessageBox.Show(ex.Message)
            MessageBox.Show("BeefDog quantity encountered an error. Please start over and ensure " _
                            & "only 0 or non-negative numbers are in the quantity box.")
            btnClear_Click(sender, e)

            Exit Sub
            ' Show the stack trace, which is a list of methods
            ' that are currently executing.
            'MessageBox.Show("Stack Trace: " & vbCrLf & ex.StackTrace)

        Finally
            ' This line executes whether or not the exception occurs.
            'MessageBox.Show("in Finally block")

        End Try

        'Some error handling to ensure that negative values are not entered into the order.
        If (numBeef < 0) Or (numPork < 0) Or (numTurkey < 0) Then
            MessageBox.Show("ERROR...Quantities cannot be a negative amount.")
            btnClear_Click(sender, e)
            Exit Sub
        End If

        totDogs = numBeef + numPork + numTurkey
        subtotal = totDogs * COST_PER_DOG

        'Throw an error message and reset if the subttotal is <= 0.
        If (subtotal <= 0) Then
            MessageBox.Show("ERROR...Subtotal cannot be 0 or a negative amount.")
            btnClear_Click(sender, e)
            Exit Sub

        End If

        salesTaxAmt = subtotal * SALES_TAX_RATE
        totalCost = subtotal - salesTaxAmt
        txtSubtotal.Text = subtotal.ToString("c2")
        txtSalesTax.Text = salesTaxAmt.ToString("c2")
        txtTotalCost.Text = totalCost.ToString("c2")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        'Enter a closing message, if you desire
        'MessageBox.Show("Thank you for choosing DroneDogs")
        Me.Close()
    End Sub


    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        'Make the customer form visible
        CustomerForm.Show()
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all text fields
        txtBeefDogs.Text = "0"
        txtPorkDogs.Text = "0"
        txtTurkeyDogs.Text = "0"
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

    Private Sub lblBeefDogs_Click(sender As Object, e As EventArgs) Handles lblBeefDogs.Click

    End Sub

    Private Sub DroneDogsOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set these to a default so the user doesn't have to enter 0 if they want nothing.  If nothing is entered, the program will crash.
        txtBeefDogs.Text = "0"
        txtPorkDogs.Text = "0"
        txtTurkeyDogs.Text = "0"
    End Sub

    Private Sub txtBeefDogs_TextChanged(sender As Object, e As EventArgs) Handles txtBeefDogs.TextChanged

    End Sub
End Class