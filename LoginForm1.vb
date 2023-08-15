Public Class LogInform1
    Public Property PanelIDNO As Object
    Public Property PanelPasswword As Object

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.



    Private Sub Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        emptyfields()
        Form5.Show()

        Me.Hide()
    End Sub

    Private Sub cmdLogIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub IDNOTextBox_TextChanged(sender As Object, e As EventArgs) Handles TextBoxIDNO.TextChanged

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

    End Sub
    Public Function emptyfields() As Boolean
        Dim username As String = TextBoxIDNO.Text.Trim()
        Dim password As String = TextBoxPassword.Text.Trim()

        Dim value As Boolean = False
        If Not username.Equals("") And password.Equals("") Then
            PanelIDNO.BackColor = Color.Red
            PanelPasswword.Backcolor = Color.Red
            value = False

        ElseIf username.Equals("") Then

            PanelIDNO.BackColor = Color.Red

            value = False

        ElseIf password.Equals("") Then
            PanelPasswword.Backcolor = Color.Red

            value = False



        End If
        Return value 
    End Function
End Class
