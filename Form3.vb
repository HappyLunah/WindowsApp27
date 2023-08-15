Public Class Form3
    Public Property ID As Object

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        MessageBox.Show("Info saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblID.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblEmail.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblPhoneNo.Click

    End Sub

    Private Sub txtAddress_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged

    End Sub

    Private Sub btnCLEAR_Click(sender As Object, e As EventArgs) Handles btnCLEAR.Click
        txtID.Clear()
        txtFullNames.Clear()
        txtEmail.Clear()
        txtPhoneNumber.Clear()
        txtAddress.Clear()

        MessageBox.Show("Controls cleared.", "Clear", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub






End Class

