Public Class CustomerForm

    'Form level member
    Private objCustomers As New ArrayList


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub btnSubmitOrder_Click(sender As Object, e As EventArgs) Handles btnAddNewCustomer.Click
        'Getting new customer information from DroneDogs.vb txtFirstName, txtLastName, and txtEmail
        Dim strFirstName = txtFirstName.Text
        Dim strLastName = txtLastName.Text
        Dim strEmail = txtEmail.Text

        'Create a procedure to send customer information string variables as arguments
        CreateCustomer(strFirstName, strLastName, strEmail)

    End Sub

    Public Sub CreateCustomer(firstName As String, lastName As String, email As String)
        'Declare a customer object
        Dim objNewCustomer As Customer

        'Create the new customer
        objNewCustomer.FirstName = firstName
        objNewCustomer.LastName = lastName
        objNewCustomer.Email = email

        'Add the new customer to the list
        objCustomers.Add(objNewCustomer)

        'Add the new customer to the ListBox control
        lsbCustomer.Items.Add(objNewCustomer)
    End Sub

    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateCustomer("Fred", "Garvin", "fgarvin@thiscompanysnl.com")
        CreateCustomer("Fran", "Pepper", "fpepper@notthesoftdrink.org")
        CreateCustomer("Will", "Robinson", "wrobinson@lostinspacetown.gov")

    End Sub

    Public ReadOnly Property SelectedCustomer() As Customer
        Get
            If lsbCustomer.SelectedIndex <> -1 Then
                'Return this customer
                Return CType(objCustomers(lsbCustomer.SelectedIndex), Customer)
            End If
        End Get
    End Property

    Private Sub btnSelectHighlightedCustomer_Click(sender As Object, e As EventArgs) Handles btnSelectHighlightedCustomer.Click
        'If no customer is selected, then error and exit
        If lsbCustomer.SelectedIndex = -1 Then
            'Display error message and exit
            MessageBox.Show("ERROR...no customer selected.")
            Exit Sub
        End If

        'Get customer info and display it in the order form
        Dim objCustomerSelected As Customer = SelectedCustomer
        DroneDogsOrder.txtFirstName.Text = objCustomerSelected.FirstName
        DroneDogsOrder.txtLastName.Text = objCustomerSelected.LastName
        DroneDogsOrder.txtEmail.Text = objCustomerSelected.Email


    End Sub
End Class