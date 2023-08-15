<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblUnitType = New System.Windows.Forms.Label()
        Me.lblRoomType = New System.Windows.Forms.Label()
        Me.lblOccupancy = New System.Windows.Forms.Label()
        Me.cloLocation = New System.Windows.Forms.ComboBox()
        Me.cboUnitType = New System.Windows.Forms.ComboBox()
        Me.cboRoomType = New System.Windows.Forms.ComboBox()
        Me.txtOccupation = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSubmit.Location = New System.Drawing.Point(432, 380)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(110, 72)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Stencil", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(54, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(280, 38)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "LUNAH HOUSING"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PeachPuff
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(904, 574)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 102)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "NEXT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.PeachPuff
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(12, 574)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(182, 102)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "BACK"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(401, 50)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(70, 20)
        Me.lblLocation.TabIndex = 13
        Me.lblLocation.Text = "Location"
        '
        'lblUnitType
        '
        Me.lblUnitType.AutoSize = True
        Me.lblUnitType.Location = New System.Drawing.Point(401, 123)
        Me.lblUnitType.Name = "lblUnitType"
        Me.lblUnitType.Size = New System.Drawing.Size(76, 20)
        Me.lblUnitType.TabIndex = 14
        Me.lblUnitType.Text = "Unit Type"
        '
        'lblRoomType
        '
        Me.lblRoomType.AutoSize = True
        Me.lblRoomType.Location = New System.Drawing.Point(401, 200)
        Me.lblRoomType.Name = "lblRoomType"
        Me.lblRoomType.Size = New System.Drawing.Size(90, 20)
        Me.lblRoomType.TabIndex = 15
        Me.lblRoomType.Text = "Room Type"
        '
        'lblOccupancy
        '
        Me.lblOccupancy.AutoSize = True
        Me.lblOccupancy.Location = New System.Drawing.Point(401, 281)
        Me.lblOccupancy.Name = "lblOccupancy"
        Me.lblOccupancy.Size = New System.Drawing.Size(88, 20)
        Me.lblOccupancy.TabIndex = 16
        Me.lblOccupancy.Text = "Occupancy"
        '
        'cloLocation
        '
        Me.cloLocation.FormattingEnabled = True
        Me.cloLocation.Items.AddRange(New Object() {"Thika", " Kiambu", " Nyeri""", "Nairobi", " Mombasa"})
        Me.cloLocation.Location = New System.Drawing.Point(542, 47)
        Me.cloLocation.Name = "cloLocation"
        Me.cloLocation.Size = New System.Drawing.Size(121, 28)
        Me.cloLocation.TabIndex = 17
        '
        'cboUnitType
        '
        Me.cboUnitType.FormattingEnabled = True
        Me.cboUnitType.Items.AddRange(New Object() {"Condo", " Villa", " Studio", " Rentals"})
        Me.cboUnitType.Location = New System.Drawing.Point(542, 123)
        Me.cboUnitType.Name = "cboUnitType"
        Me.cboUnitType.Size = New System.Drawing.Size(121, 28)
        Me.cboUnitType.TabIndex = 18
        '
        'cboRoomType
        '
        Me.cboRoomType.FormattingEnabled = True
        Me.cboRoomType.Items.AddRange(New Object() {"Bedsitters", "1 Bedroom", "2 Bedroom"})
        Me.cboRoomType.Location = New System.Drawing.Point(542, 200)
        Me.cboRoomType.Name = "cboRoomType"
        Me.cboRoomType.Size = New System.Drawing.Size(121, 28)
        Me.cboRoomType.TabIndex = 19
        '
        'txtOccupation
        '
        Me.txtOccupation.Location = New System.Drawing.Point(542, 281)
        Me.txtOccupation.Multiline = True
        Me.txtOccupation.Name = "txtOccupation"
        Me.txtOccupation.Size = New System.Drawing.Size(135, 26)
        Me.txtOccupation.TabIndex = 20
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1145, 688)
        Me.Controls.Add(Me.txtOccupation)
        Me.Controls.Add(Me.cboRoomType)
        Me.Controls.Add(Me.cboUnitType)
        Me.Controls.Add(Me.cloLocation)
        Me.Controls.Add(Me.lblOccupancy)
        Me.Controls.Add(Me.lblRoomType)
        Me.Controls.Add(Me.lblUnitType)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSubmit)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form2"
        Me.Text = "PROPERTY"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblUnitType As Label
    Friend WithEvents lblRoomType As Label
    Friend WithEvents lblOccupancy As Label
    Friend WithEvents cloLocation As ComboBox
    Friend WithEvents cboUnitType As ComboBox
    Friend WithEvents cboRoomType As ComboBox
    Friend WithEvents txtOccupation As TextBox
    Private txtOccupancy As Object
    Private cboLocation As Object
    Private Sub UpdateOccupancy()
        Dim occupancy As Integer = (cloLocation.SelectedIndex + 1) * (cboUnitType.SelectedIndex + 1) * (cboRoomType.SelectedIndex + 1)
        If occupancy > 50 Then
            occupancy = 50
        End If
        txtOccupation.Text = occupancy.ToString()
    End Sub




    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblLocation_Click(sender As Object, e As EventArgs) Handles lblLocation.Click

    End Sub

    Private Sub cloLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cloLocation.SelectedIndexChanged
        UpdateOccupancy()

    End Sub

    Private Sub cboUnitType_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboUnitType.SelectedIndexChanged
        UpdateOccupancy()
    End Sub

    Private Sub cboRoomType_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboRoomType.SelectedIndexChanged
        UpdateOccupancy()
    End Sub

    Private Sub txtOccupation_TextChanged(sender As Object, e As EventArgs) Handles txtOccupation.TextChanged

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        MessageBox.Show("Info saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim Form5 As New Form5()
        Me.Hide()
        Form5.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Close()
    End Sub
End Class
