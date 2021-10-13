Public Class CustomerForm

    'Form level member
    Private objCustomers As New ArrayList

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        'Get the new customer info
        Dim strFirstName = txtFirstName.Text
        Dim strLastName = txtLastName.Text
        Dim strEmail = txtEmail.Text

        'Create a new customer
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
        lstCustomers.Items.Add(objNewCustomer)
    End Sub

    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Pre-adds customers into list when form is opened
        CreateCustomer("Fred", "Garvin", "fgarvin@thiscompanysnl.com")
        CreateCustomer("Dr. Fran", "Pepper", "fpepper@notthesoftdrink.org")
        CreateCustomer("Will", "Robinson", "wrobinson@lostinspacetown.gov")
    End Sub

    Private Sub btnSelectCustomer_Click(sender As Object, e As EventArgs) Handles btnSelectCustomer.Click
        'If no customer is selected, then error and exit
        If lstCustomers.SelectedIndex = -1 Then
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

    Public ReadOnly Property SelectedCustomer() As Customer
        Get
            If lstCustomers.SelectedIndex <> -1 Then
                'Return this customer
                Return CType(objCustomers(lstCustomers.SelectedIndex), Customer)
            End If
        End Get
    End Property

End Class
