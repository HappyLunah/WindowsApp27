<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblFullNames = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhoneNo = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtFullNames = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCLEAR = New System.Windows.Forms.Button()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(400, 37)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(26, 20)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID"
        '
        'lblFullNames
        '
        Me.lblFullNames.AutoSize = True
        Me.lblFullNames.Location = New System.Drawing.Point(400, 108)
        Me.lblFullNames.Name = "lblFullNames"
        Me.lblFullNames.Size = New System.Drawing.Size(110, 20)
        Me.lblFullNames.TabIndex = 1
        Me.lblFullNames.Text = "FULL NAMES"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(400, 196)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(58, 20)
        Me.lblEmail.TabIndex = 2
        Me.lblEmail.Text = "EMAIL"
        '
        'lblPhoneNo
        '
        Me.lblPhoneNo.AutoSize = True
        Me.lblPhoneNo.Location = New System.Drawing.Point(400, 292)
        Me.lblPhoneNo.Name = "lblPhoneNo"
        Me.lblPhoneNo.Size = New System.Drawing.Size(93, 20)
        Me.lblPhoneNo.TabIndex = 3
        Me.lblPhoneNo.Text = "PHONE No."
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(515, 31)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(155, 26)
        Me.txtID.TabIndex = 4
        '
        'txtFullNames
        '
        Me.txtFullNames.Location = New System.Drawing.Point(515, 108)
        Me.txtFullNames.Name = "txtFullNames"
        Me.txtFullNames.Size = New System.Drawing.Size(256, 26)
        Me.txtFullNames.TabIndex = 5
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(515, 196)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(256, 26)
        Me.txtEmail.TabIndex = 6
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(515, 289)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(256, 26)
        Me.txtPhoneNumber.TabIndex = 7
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnSave.Location = New System.Drawing.Point(515, 473)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(127, 103)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCLEAR
        '
        Me.btnCLEAR.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnCLEAR.Location = New System.Drawing.Point(644, 473)
        Me.btnCLEAR.Name = "btnCLEAR"
        Me.btnCLEAR.Size = New System.Drawing.Size(127, 103)
        Me.btnCLEAR.TabIndex = 9
        Me.btnCLEAR.Text = "CLEAR"
        Me.btnCLEAR.UseVisualStyleBackColor = False
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(400, 370)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(89, 20)
        Me.lblAddress.TabIndex = 10
        Me.lblAddress.Text = "ADDRESS"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(515, 350)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(256, 84)
        Me.txtAddress.TabIndex = 11
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.PeachPuff
        Me.btnBack.Location = New System.Drawing.Point(21, 557)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(127, 103)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.PeachPuff
        Me.btnNext.Location = New System.Drawing.Point(963, 557)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(127, 103)
        Me.btnNext.TabIndex = 13
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1115, 672)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.btnCLEAR)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtFullNames)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblPhoneNo)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblFullNames)
        Me.Controls.Add(Me.lblID)
        Me.Name = "Form3"
        Me.Text = "CUSTOMER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblID As Label
    Friend WithEvents lblFullNames As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhoneNo As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtFullNames As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCLEAR As Button
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnNext As Button
End Class
