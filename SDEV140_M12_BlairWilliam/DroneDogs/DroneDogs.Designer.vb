﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DroneDogsOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DroneDogsOrder))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblBeefDogs = New System.Windows.Forms.Label()
        Me.lblPorkDogs = New System.Windows.Forms.Label()
        Me.lblTurkeyDogs = New System.Windows.Forms.Label()
        Me.txtBeefDogs = New System.Windows.Forms.TextBox()
        Me.txtPorkDogs = New System.Windows.Forms.TextBox()
        Me.txtTurkeyDogs = New System.Windows.Forms.TextBox()
        Me.lblSalesTax = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtSalesTax = New System.Windows.Forms.TextBox()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSubmitOrder = New System.Windows.Forms.Button()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.btnGetCustomerInfo = New System.Windows.Forms.Button()
        Me.btnFormClear = New System.Windows.Forms.Button()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.chkConsent = New System.Windows.Forms.CheckBox()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Maroon
        Me.lblTitle.Location = New System.Drawing.Point(64, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(196, 20)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "DroneDogs Order Form"
        '
        'lblBeefDogs
        '
        Me.lblBeefDogs.AutoSize = True
        Me.lblBeefDogs.Location = New System.Drawing.Point(38, 60)
        Me.lblBeefDogs.Name = "lblBeefDogs"
        Me.lblBeefDogs.Size = New System.Drawing.Size(64, 13)
        Me.lblBeefDogs.TabIndex = 1
        Me.lblBeefDogs.Text = "# BeefDogs"
        '
        'lblPorkDogs
        '
        Me.lblPorkDogs.AutoSize = True
        Me.lblPorkDogs.Location = New System.Drawing.Point(38, 87)
        Me.lblPorkDogs.Name = "lblPorkDogs"
        Me.lblPorkDogs.Size = New System.Drawing.Size(67, 13)
        Me.lblPorkDogs.TabIndex = 2
        Me.lblPorkDogs.Text = "# PorkDogs:"
        '
        'lblTurkeyDogs
        '
        Me.lblTurkeyDogs.AutoSize = True
        Me.lblTurkeyDogs.Location = New System.Drawing.Point(38, 113)
        Me.lblTurkeyDogs.Name = "lblTurkeyDogs"
        Me.lblTurkeyDogs.Size = New System.Drawing.Size(78, 13)
        Me.lblTurkeyDogs.TabIndex = 3
        Me.lblTurkeyDogs.Text = "# TurkeyDogs:"
        '
        'txtBeefDogs
        '
        Me.txtBeefDogs.Location = New System.Drawing.Point(122, 60)
        Me.txtBeefDogs.Name = "txtBeefDogs"
        Me.txtBeefDogs.Size = New System.Drawing.Size(92, 20)
        Me.txtBeefDogs.TabIndex = 4
        '
        'txtPorkDogs
        '
        Me.txtPorkDogs.Location = New System.Drawing.Point(122, 87)
        Me.txtPorkDogs.Name = "txtPorkDogs"
        Me.txtPorkDogs.Size = New System.Drawing.Size(92, 20)
        Me.txtPorkDogs.TabIndex = 5
        '
        'txtTurkeyDogs
        '
        Me.txtTurkeyDogs.Location = New System.Drawing.Point(122, 113)
        Me.txtTurkeyDogs.Name = "txtTurkeyDogs"
        Me.txtTurkeyDogs.Size = New System.Drawing.Size(92, 20)
        Me.txtTurkeyDogs.TabIndex = 6
        '
        'lblSalesTax
        '
        Me.lblSalesTax.AutoSize = True
        Me.lblSalesTax.Location = New System.Drawing.Point(41, 231)
        Me.lblSalesTax.Name = "lblSalesTax"
        Me.lblSalesTax.Size = New System.Drawing.Size(67, 13)
        Me.lblSalesTax.TabIndex = 8
        Me.lblSalesTax.Text = "# Sales Tax:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(41, 258)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(68, 13)
        Me.lblTotalCost.TabIndex = 9
        Me.lblTotalCost.Text = "# Total Cost:"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(122, 205)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubtotal.TabIndex = 10
        '
        'txtSalesTax
        '
        Me.txtSalesTax.Location = New System.Drawing.Point(122, 231)
        Me.txtSalesTax.Name = "txtSalesTax"
        Me.txtSalesTax.ReadOnly = True
        Me.txtSalesTax.Size = New System.Drawing.Size(100, 20)
        Me.txtSalesTax.TabIndex = 11
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Location = New System.Drawing.Point(122, 258)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.ReadOnly = True
        Me.txtTotalCost.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalCost.TabIndex = 12
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(294, 9)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(88, 98)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 13
        Me.picLogo.TabStop = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(68, 155)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(146, 23)
        Me.btnCalculate.TabIndex = 14
        Me.btnCalculate.Text = "Calculate Order"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(201, 499)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(146, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSubmitOrder
        '
        Me.btnSubmitOrder.Location = New System.Drawing.Point(16, 499)
        Me.btnSubmitOrder.Name = "btnSubmitOrder"
        Me.btnSubmitOrder.Size = New System.Drawing.Size(146, 23)
        Me.btnSubmitOrder.TabIndex = 16
        Me.btnSubmitOrder.Text = "Submit Order"
        Me.btnSubmitOrder.UseVisualStyleBackColor = True
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(41, 208)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(56, 13)
        Me.lblSubtotal.TabIndex = 17
        Me.lblSubtotal.Text = "# Subtotal"
        '
        'btnGetCustomerInfo
        '
        Me.btnGetCustomerInfo.Location = New System.Drawing.Point(16, 296)
        Me.btnGetCustomerInfo.Name = "btnGetCustomerInfo"
        Me.btnGetCustomerInfo.Size = New System.Drawing.Size(146, 23)
        Me.btnGetCustomerInfo.TabIndex = 18
        Me.btnGetCustomerInfo.Text = "Get Customer Info"
        Me.btnGetCustomerInfo.UseVisualStyleBackColor = True
        '
        'btnFormClear
        '
        Me.btnFormClear.Location = New System.Drawing.Point(201, 296)
        Me.btnFormClear.Name = "btnFormClear"
        Me.btnFormClear.Size = New System.Drawing.Size(146, 23)
        Me.btnFormClear.TabIndex = 19
        Me.btnFormClear.Text = "Clear Form"
        Me.btnFormClear.UseVisualStyleBackColor = True
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(44, 359)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 20
        Me.lblFirstName.Text = "First Name:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(44, 384)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblLastName.TabIndex = 21
        Me.lblLastName.Text = "Last Name:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(44, 411)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(42, 13)
        Me.lblEmail.TabIndex = 22
        Me.lblEmail.Text = "# Email"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(122, 359)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(225, 20)
        Me.txtFirstName.TabIndex = 23
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(122, 386)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(225, 20)
        Me.txtLastName.TabIndex = 24
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(122, 413)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(225, 20)
        Me.txtEmail.TabIndex = 25
        '
        'chkConsent
        '
        Me.chkConsent.AutoSize = True
        Me.chkConsent.Location = New System.Drawing.Point(41, 459)
        Me.chkConsent.Name = "chkConsent"
        Me.chkConsent.Size = New System.Drawing.Size(303, 17)
        Me.chkConsent.TabIndex = 27
        Me.chkConsent.Text = "I give DroneDogs permission to use my location information"
        Me.chkConsent.UseVisualStyleBackColor = True
        '
        'DroneDogsOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 533)
        Me.Controls.Add(Me.chkConsent)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.btnFormClear)
        Me.Controls.Add(Me.btnGetCustomerInfo)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.btnSubmitOrder)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.txtSalesTax)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblSalesTax)
        Me.Controls.Add(Me.txtTurkeyDogs)
        Me.Controls.Add(Me.txtPorkDogs)
        Me.Controls.Add(Me.txtBeefDogs)
        Me.Controls.Add(Me.lblTurkeyDogs)
        Me.Controls.Add(Me.lblPorkDogs)
        Me.Controls.Add(Me.lblBeefDogs)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "DroneDogsOrder"
        Me.Text = "William Blair"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblBeefDogs As System.Windows.Forms.Label
    Friend WithEvents lblPorkDogs As System.Windows.Forms.Label
    Friend WithEvents lblTurkeyDogs As System.Windows.Forms.Label
    Friend WithEvents txtBeefDogs As System.Windows.Forms.TextBox
    Friend WithEvents txtPorkDogs As System.Windows.Forms.TextBox
    Friend WithEvents txtTurkeyDogs As System.Windows.Forms.TextBox
    Friend WithEvents lblSalesTax As System.Windows.Forms.Label
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents txtSalesTax As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCost As System.Windows.Forms.TextBox
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSubmitOrder As System.Windows.Forms.Button
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents btnGetCustomerInfo As Button
    Friend WithEvents btnFormClear As Button
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents chkConsent As CheckBox
End Class
