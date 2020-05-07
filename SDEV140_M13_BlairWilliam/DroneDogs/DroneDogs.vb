Public Class DroneDogsOrder
    'Declare constants
    Const DBL_COST_HOTDOG As Double = 1.99
    Const DBL_COST_SALESTAX As Double = 0.07

    'Declare variables
    Dim intNumBeefDogs As Integer = 0
    Dim intNumPorkDogs As Integer = 0
    Dim intNumTurkeyDogs As Integer = 0

    'Calculate total number of hot dogs ordered
    Dim intNumHotDogs As Integer = 0

    'Calculate subtotal, sales tax, and total amounts
    Dim dblAmountSubTotal As Double = 0
    Dim dblAmountSalesTax As Double = 0
    Dim dblAmountGrandTotal As Double = 0

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Extract user typed quantities from text boxes and convert to integers
        intNumBeefDogs = Convert.ToInt32(txtBeefDogs.Text)
        intNumPorkDogs = Convert.ToInt32(txtPorkDogs.Text)
        intNumTurkeyDogs = Convert.ToInt32(txtTurkeyDogs.Text)

        'Calculate total number of hot dogs ordered
        'intNumHotDogs = Val(txtBeefDogs.Text) + Val(txtPorkDogs.Text) + Val(txtTurkeyDogs.Text)
        intNumHotDogs = intNumBeefDogs + intNumPorkDogs + intNumTurkeyDogs

        'Calculate subtotal, sales tax, and total amounts
        dblAmountSubTotal = (intNumHotDogs * DBL_COST_HOTDOG)
        dblAmountSalesTax = (dblAmountSubTotal * DBL_COST_SALESTAX)
        dblAmountGrandTotal = (dblAmountSubTotal + dblAmountSalesTax)

        'Convert numbers back to text and display in text boxes
        txtSubtotal.Text = dblAmountSubTotal.ToString("c2")
        txtSalesTax.Text = dblAmountSalesTax.ToString("c2")
        txtTotalCost.Text = dblAmountGrandTotal.ToString("c2")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        'Close form

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmitOrder.Click
        MsgBox("Thank you for ordering your meal from DroneDogs!")

        'Display message box thanking the user

    End Sub

    Private Sub txtBeefDogs_TextChanged(sender As Object, e As EventArgs) Handles txtBeefDogs.TextChanged

    End Sub

    Private Sub txtSalesTax_TextChanged(sender As Object, e As EventArgs) Handles txtSalesTax.TextChanged

    End Sub

    Private Sub lblBeefDogs_Click(sender As Object, e As EventArgs) Handles lblBeefDogs.Click

    End Sub

    Private Sub txtPorkDogs_TextChanged(sender As Object, e As EventArgs) Handles txtPorkDogs.TextChanged

    End Sub

    Private Sub txtTurkeyDogs_TextChanged(sender As Object, e As EventArgs) Handles txtTurkeyDogs.TextChanged

    End Sub

    Private Sub txtSubtotal_TextChanged(sender As Object, e As EventArgs) Handles txtSubtotal.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblSubtotal.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGetCustomerInfo.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblFirstName.Click

    End Sub

    Private Sub picLogo_Click(sender As Object, e As EventArgs) Handles picLogo.Click

    End Sub
End Class
