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
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblSalesTax = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtSalesTax = New System.Windows.Forms.TextBox()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.chkPermission = New System.Windows.Forms.CheckBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Maroon
        Me.lblTitle.Location = New System.Drawing.Point(64, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(196, 20)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "DroneDogs Order Form"
        '
        'lblBeefDogs
        '
        Me.lblBeefDogs.AutoSize = True
        Me.lblBeefDogs.Location = New System.Drawing.Point(41, 42)
        Me.lblBeefDogs.Name = "lblBeefDogs"
        Me.lblBeefDogs.Size = New System.Drawing.Size(64, 13)
        Me.lblBeefDogs.TabIndex = 1
        Me.lblBeefDogs.Text = "# BeefDogs"
        '
        'lblPorkDogs
        '
        Me.lblPorkDogs.AutoSize = True
        Me.lblPorkDogs.Location = New System.Drawing.Point(41, 69)
        Me.lblPorkDogs.Name = "lblPorkDogs"
        Me.lblPorkDogs.Size = New System.Drawing.Size(67, 13)
        Me.lblPorkDogs.TabIndex = 2
        Me.lblPorkDogs.Text = "# PorkDogs:"
        '
        'lblTurkeyDogs
        '
        Me.lblTurkeyDogs.AutoSize = True
        Me.lblTurkeyDogs.Location = New System.Drawing.Point(41, 95)
        Me.lblTurkeyDogs.Name = "lblTurkeyDogs"
        Me.lblTurkeyDogs.Size = New System.Drawing.Size(78, 13)
        Me.lblTurkeyDogs.TabIndex = 3
        Me.lblTurkeyDogs.Text = "# TurkeyDogs:"
        '
        'txtBeefDogs
        '
        Me.txtBeefDogs.Location = New System.Drawing.Point(125, 42)
        Me.txtBeefDogs.Name = "txtBeefDogs"
        Me.txtBeefDogs.Size = New System.Drawing.Size(40, 20)
        Me.txtBeefDogs.TabIndex = 4
        '
        'txtPorkDogs
        '
        Me.txtPorkDogs.Location = New System.Drawing.Point(125, 69)
        Me.txtPorkDogs.Name = "txtPorkDogs"
        Me.txtPorkDogs.Size = New System.Drawing.Size(40, 20)
        Me.txtPorkDogs.TabIndex = 5
        '
        'txtTurkeyDogs
        '
        Me.txtTurkeyDogs.Location = New System.Drawing.Point(125, 95)
        Me.txtTurkeyDogs.Name = "txtTurkeyDogs"
        Me.txtTurkeyDogs.Size = New System.Drawing.Size(40, 20)
        Me.txtTurkeyDogs.TabIndex = 6
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(41, 151)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(49, 13)
        Me.lblSubtotal.TabIndex = 7
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'lblSalesTax
        '
        Me.lblSalesTax.AutoSize = True
        Me.lblSalesTax.Location = New System.Drawing.Point(41, 177)
        Me.lblSalesTax.Name = "lblSalesTax"
        Me.lblSalesTax.Size = New System.Drawing.Size(57, 13)
        Me.lblSalesTax.TabIndex = 8
        Me.lblSalesTax.Text = "Sales Tax:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(41, 204)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(58, 13)
        Me.lblTotalCost.TabIndex = 9
        Me.lblTotalCost.Text = "Total Cost:"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(122, 151)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubtotal.TabIndex = 10
        '
        'txtSalesTax
        '
        Me.txtSalesTax.Location = New System.Drawing.Point(122, 177)
        Me.txtSalesTax.Name = "txtSalesTax"
        Me.txtSalesTax.ReadOnly = True
        Me.txtSalesTax.Size = New System.Drawing.Size(100, 20)
        Me.txtSalesTax.TabIndex = 11
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Location = New System.Drawing.Point(122, 204)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.ReadOnly = True
        Me.txtTotalCost.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalCost.TabIndex = 12
        '
        'picLogo
        '
        Me.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(244, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(88, 98)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 13
        Me.picLogo.TabStop = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(96, 122)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(141, 23)
        Me.btnCalculate.TabIndex = 14
        Me.btnCalculate.Text = "Calculate Order"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(217, 389)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCustomer
        '
        Me.btnCustomer.Location = New System.Drawing.Point(42, 230)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(120, 23)
        Me.btnCustomer.TabIndex = 16
        Me.btnCustomer.Text = "Get Customer Info"
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(122, 338)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(212, 20)
        Me.txtEmail.TabIndex = 24
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(122, 304)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(212, 20)
        Me.txtLastName.TabIndex = 23
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(122, 270)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(212, 20)
        Me.txtFirstName.TabIndex = 22
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(25, 341)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 20
        Me.lblEmail.Text = "Email:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(25, 307)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblLastName.TabIndex = 19
        Me.lblLastName.Text = "Last Name:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(25, 273)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 18
        Me.lblFirstName.Text = "First Name:"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(217, 230)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 23)
        Me.btnClear.TabIndex = 25
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'chkPermission
        '
        Me.chkPermission.AutoSize = True
        Me.chkPermission.Location = New System.Drawing.Point(28, 366)
        Me.chkPermission.Name = "chkPermission"
        Me.chkPermission.Size = New System.Drawing.Size(306, 17)
        Me.chkPermission.TabIndex = 26
        Me.chkPermission.Text = "I give DroneDogs permission to use my location information."
        Me.chkPermission.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(42, 389)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(120, 23)
        Me.btnSubmit.TabIndex = 27
        Me.btnSubmit.Text = "Submit Order"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'DroneDogsOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 424)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.chkPermission)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.btnCustomer)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.txtSalesTax)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblSalesTax)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.txtTurkeyDogs)
        Me.Controls.Add(Me.txtPorkDogs)
        Me.Controls.Add(Me.txtBeefDogs)
        Me.Controls.Add(Me.lblTurkeyDogs)
        Me.Controls.Add(Me.lblPorkDogs)
        Me.Controls.Add(Me.lblBeefDogs)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "DroneDogsOrder"
        Me.Text = "Jane Doe"
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
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblSalesTax As System.Windows.Forms.Label
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents txtSalesTax As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCost As System.Windows.Forms.TextBox
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCustomer As System.Windows.Forms.Button
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents chkPermission As System.Windows.Forms.CheckBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button

End Class
