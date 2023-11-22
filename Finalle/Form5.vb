Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form5

    Dim username As String = " "
    Dim password As String = " "
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Joy Wanjiru M\source\repos\Finalle\Finalle\Database.mdf;"
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        username = username_tb.Text
        password = password_tb.Text


        If AuthenticateUser(username, password) Then
            MsgBox("Login successful!!", MsgBoxStyle.Information)

        Else
            MsgBox("Incorrect username or password. Please try again.", MsgBoxStyle.Critical)
        End If

        'after successfull registration exit the application
        If MessageBox.Show("Exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub
    Private Function AuthenticateUser(username As String, password As String) As Boolean
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM staffreg WHERE username = @username AND password = @password"


            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)
                Dim count As Integer = CInt(command.ExecuteScalar())

                Return count > 0
            End Using
        End Using
    End Function

End Class