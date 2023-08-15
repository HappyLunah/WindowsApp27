Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdProperty.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdCustomer.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmdBooking.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        LogInform1.Show()
        Me.Hide()
    End Sub
End Class