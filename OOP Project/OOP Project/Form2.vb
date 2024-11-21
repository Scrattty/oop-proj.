Imports MySql.Data.MySqlClient

Public Class Form2

    Dim conn As New MySqlConnection("host=127.0.0.1; database=users.db; user=root; password=")

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim email As String = txtEmailAddress1.Text
        Dim password As String = txtPassword1.Text

        Try
            conn.Open()

            Dim query As String = "SELECT COUNT(1) FROM users WHERE Email = @Email AND Password = @Password"
            Using cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@Password", password)

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    Form3.Show()
                    Me.Hide()

                Else
                    MessageBox.Show("Invalid email or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSignupShow.Click
        Me.Close()
        Form1.Show()
    End Sub

End Class
