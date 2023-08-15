<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.cmdProperty = New System.Windows.Forms.Button()
        Me.cmdCustomer = New System.Windows.Forms.Button()
        Me.cmdBooking = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdProperty
        '
        Me.cmdProperty.BackColor = System.Drawing.Color.PeachPuff
        Me.cmdProperty.Location = New System.Drawing.Point(403, 185)
        Me.cmdProperty.Name = "cmdProperty"
        Me.cmdProperty.Size = New System.Drawing.Size(144, 89)
        Me.cmdProperty.TabIndex = 0
        Me.cmdProperty.Text = "PROPERTY"
        Me.cmdProperty.UseVisualStyleBackColor = False
        '
        'cmdCustomer
        '
        Me.cmdCustomer.BackColor = System.Drawing.Color.PeachPuff
        Me.cmdCustomer.Location = New System.Drawing.Point(403, 346)
        Me.cmdCustomer.Name = "cmdCustomer"
        Me.cmdCustomer.Size = New System.Drawing.Size(144, 95)
        Me.cmdCustomer.TabIndex = 1
        Me.cmdCustomer.Text = "CUSTOMER"
        Me.cmdCustomer.UseVisualStyleBackColor = False
        '
        'cmdBooking
        '
        Me.cmdBooking.BackColor = System.Drawing.Color.PeachPuff
        Me.cmdBooking.Location = New System.Drawing.Point(403, 499)
        Me.cmdBooking.Name = "cmdBooking"
        Me.cmdBooking.Size = New System.Drawing.Size(144, 109)
        Me.cmdBooking.TabIndex = 2
        Me.cmdBooking.Text = "BOOKING"
        Me.cmdBooking.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PeachPuff
        Me.Button1.Location = New System.Drawing.Point(403, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 89)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "LOG IN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1058, 638)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdBooking)
        Me.Controls.Add(Me.cmdCustomer)
        Me.Controls.Add(Me.cmdProperty)
        Me.Name = "Form5"
        Me.Text = "DASHBOARD"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdProperty As Button
    Friend WithEvents cmdCustomer As Button
    Friend WithEvents cmdBooking As Button
    Friend WithEvents Button1 As Button
End Class
