<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerForm))
        Me.lsbCustomer = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.btnAddNewCustomer = New System.Windows.Forms.Button()
        Me.btnSelectHighlightedCustomer = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lsbCustomer
        '
        Me.lsbCustomer.FormattingEnabled = True
        Me.lsbCustomer.Location = New System.Drawing.Point(12, 39)
        Me.lsbCustomer.Name = "lsbCustomer"
        Me.lsbCustomer.Size = New System.Drawing.Size(277, 95)
        Me.lsbCustomer.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(306, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(76, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Maroon
        Me.lblTitle.Location = New System.Drawing.Point(93, 17)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(161, 13)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Drone Dogs Customer Form"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(134, 203)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(137, 20)
        Me.txtEmail.TabIndex = 33
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(134, 176)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(137, 20)
        Me.txtLastName.TabIndex = 32
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(134, 149)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(137, 20)
        Me.txtFirstName.TabIndex = 31
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(56, 201)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 30
        Me.lblEmail.Text = "Email"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(56, 174)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblLastName.TabIndex = 29
        Me.lblLastName.Text = "Last Name:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(56, 149)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 28
        Me.lblFirstName.Text = "First Name:"
        '
        'btnAddNewCustomer
        '
        Me.btnAddNewCustomer.Location = New System.Drawing.Point(12, 289)
        Me.btnAddNewCustomer.Name = "btnAddNewCustomer"
        Me.btnAddNewCustomer.Size = New System.Drawing.Size(163, 23)
        Me.btnAddNewCustomer.TabIndex = 27
        Me.btnAddNewCustomer.Text = "Add New Customer"
        Me.btnAddNewCustomer.UseVisualStyleBackColor = True
        '
        'btnSelectHighlightedCustomer
        '
        Me.btnSelectHighlightedCustomer.Location = New System.Drawing.Point(219, 289)
        Me.btnSelectHighlightedCustomer.Name = "btnSelectHighlightedCustomer"
        Me.btnSelectHighlightedCustomer.Size = New System.Drawing.Size(163, 23)
        Me.btnSelectHighlightedCustomer.TabIndex = 26
        Me.btnSelectHighlightedCustomer.Text = "Select Highlighted Customer"
        Me.btnSelectHighlightedCustomer.UseVisualStyleBackColor = True
        '
        'CustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 331)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.btnAddNewCustomer)
        Me.Controls.Add(Me.btnSelectHighlightedCustomer)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lsbCustomer)
        Me.Name = "CustomerForm"
        Me.Text = "William Blair"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lsbCustomer As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents btnAddNewCustomer As Button
    Friend WithEvents btnSelectHighlightedCustomer As Button
End Class
