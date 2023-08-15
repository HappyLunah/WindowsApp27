Imports System.Data.OleDb
Public Class Form4
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBACK.Click
        Form3.Show()
        Me.Hide()
    End Sub




    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLocation.SelectedIndexChanged
        ' cboLocation.Text = 
        ' Replace "YourConnectionString" with the actual connection string to your Access database.
        Dim connectionString As String = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HP\Downloads\RENTAL HOUSING SYSTEM.mdb"

        ' Replace "YourTableName" with the name of the table you want to populate the combo box from.
        Dim tableName As String = "BOOKING"

        ' Replace "YourColumnName" with the name of the column you want to display in the combo box.
        Dim displayColumnName As String = "Location"

        ' Assuming your combo box is named "comboBox1".


        ' Connect to the database and retrieve data.
        Using connection As New OleDbConnection(connectionString)
            Dim query As String = $"SELECT * FROM BOOKING"



            Try
                connection.Open()
                Using command As New OleDbCommand(query, connection)
                    Using reader As OleDbDataReader = command.ExecuteReader()
                        While reader.Read()
                            ' Add each item to the combo box.

                        End While
                    End Using
                End Using
            Catch ex As Exception
                ' Handle any potential exceptions here.
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

        ' Replace "YourConnectionString" with the actual connection string to your Access database.
        Dim connectionString As String = "Provider = Microsoft.JET.OLEDB.4.0;Data Source=C:\Users\HP\Downloads\RENTAL HOUSING SYSTEM.mdb"

        ' Replace "YourTableName" with the name of the table you want to populate the combo box from.
        Dim tableName As String = "BOOKING"

        ' Replace "YourColumnName" with the name of the column you want to display in the combo box.
        Dim displayColumnName As String = "Unit Type"

        ' Assuming your combo box is named "comboBox1".


        ' Connect to the database and retrieve data.
        Using connection As New OleDbConnection(connectionString)
            Dim query As String = $"SELECT {displayColumnName} FROM {tableName}"

            Try
                connection.Open()
                Using command As New OleDbCommand(query, connection)
                    Using reader As OleDbDataReader = command.ExecuteReader()
                        While reader.Read()
                            ' Add each item to the combo box.

                        End While
                    End Using
                End Using
            Catch ex As Exception
                ' Handle any potential exceptions here.
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRoomType.SelectedIndexChanged

        ' Replace "YourConnectionString" with the actual connection string to your Access database.
        Dim connectionString As String = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HP\Downloads\RENTAL HOUSING SYSTEM.mdb"

        ' Replace "YourTableName" with the name of the table you want to populate the combo box from.
        Dim tableName As String = "BOOKING"

        ' Replace "YourColumnName" with the name of the column you want to display in the combo box.
        Dim displayColumnName As String = "Room Type"

        ' Assuming your combo box is named "comboBox1".


        ' Connect to the database and retrieve data.
        Using connection As New OleDbConnection(connectionString)
            Dim query As String = $"SELECT {displayColumnName} FROM {tableName}"

            Try
                connection.Open()
                Using command As New OleDbCommand(query, connection)
                    Using reader As OleDbDataReader = command.ExecuteReader()
                        While reader.Read()
                            ' Add each item to the combo box.

                        End While
                    End Using
                End Using
            Catch ex As Exception
                ' Handle any potential exceptions here.
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnNEXT_Click(sender As Object, e As EventArgs) Handles btnNEXT.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click


        MsgBox("SUCCEFULLY SAVED:")
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub



    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub





    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub



    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub








End Class