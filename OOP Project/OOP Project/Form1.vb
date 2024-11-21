Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As New MySqlConnection("host=127.0.0.1; database=users.db; user=root; password=")

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        ' Get user input
        Dim name As String = txtName.Text
        Dim email As String = txtEmailAddress.Text
        Dim password As String = txtPassword.Text
        Dim confirmPassword As String = txtConfirmPassword.Text

        'verify pass
        If password <> confirmPassword Then
            MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        'Insert data in table
        Try
            conn.Open()
            Dim query As String = "INSERT INTO users (Name, Email, Password) VALUES (@Name, @Email, @Password)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Name", name)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@Password", password)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


                txtName.Clear()
                txtEmailAddress.Clear()
                txtPassword.Clear()
                txtConfirmPassword.Clear()
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("This email is already registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnLoginShow_Click(sender As Object, e As EventArgs) Handles btnLoginShow.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
