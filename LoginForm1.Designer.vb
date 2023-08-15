<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LogInform1
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
    Friend WithEvents lblIDNO As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents TextBoxIDNO As System.Windows.Forms.TextBox
    Friend WithEvents btnLogIn As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogInform1))
        Me.lblIDNO = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.TextBoxIDNO = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label_Error_Mesg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblIDNO
        '
        Me.lblIDNO.Location = New System.Drawing.Point(430, 175)
        Me.lblIDNO.Name = "lblIDNO"
        Me.lblIDNO.Size = New System.Drawing.Size(220, 23)
        Me.lblIDNO.TabIndex = 0
        Me.lblIDNO.Text = "&Enter ID NO."
        Me.lblIDNO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(430, 294)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxIDNO
        '
        Me.TextBoxIDNO.Location = New System.Drawing.Point(516, 227)
        Me.TextBoxIDNO.Name = "TextBoxIDNO"
        Me.TextBoxIDNO.Size = New System.Drawing.Size(220, 26)
        Me.TextBoxIDNO.TabIndex = 1
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(516, 335)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(220, 26)
        Me.TextBoxPassword.TabIndex = 3
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.Color.PeachPuff
        Me.btnLogIn.Location = New System.Drawing.Point(516, 445)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(107, 40)
        Me.btnLogIn.TabIndex = 4
        Me.btnLogIn.Text = "LOGIN"
        Me.btnLogIn.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.PeachPuff
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(645, 445)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 40)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label_Error_Mesg
        '
        Me.Label_Error_Mesg.AutoSize = True
        Me.Label_Error_Mesg.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label_Error_Mesg.ForeColor = System.Drawing.Color.Maroon
        Me.Label_Error_Mesg.Location = New System.Drawing.Point(551, 388)
        Me.Label_Error_Mesg.Name = "Label_Error_Mesg"
        Me.Label_Error_Mesg.Size = New System.Drawing.Size(132, 20)
        Me.Label_Error_Mesg.TabIndex = 6
        Me.Label_Error_Mesg.Text = "forgot password?"
        '
        'LogInform1
        '
        Me.AcceptButton = Me.btnLogIn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1117, 709)
        Me.Controls.Add(Me.Label_Error_Mesg)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxIDNO)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.lblIDNO)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LogInform1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "LoginForm1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Error_Mesg As Label
    Friend WithEvents TextBoxPassword As TextBox
End Class
