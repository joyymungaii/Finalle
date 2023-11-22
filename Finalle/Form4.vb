Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

'the following system is used to enter staff details using a simple form to a database
Public Class Form4


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Me.Close()
    End Sub

    'when check box is clicked the input of email is placed in the username part
    Private Sub use_email_btn_Click(sender As Object, e As EventArgs) Handles use_email_cb.Click
        username_tb.Text = email_tb.Text
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        password_tb.PasswordChar = "*"
    End Sub

    'Assigning of values
    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        Dim firstName As String = fname_tb.Text
        Dim lastName As String = lname_tb.Text
        Dim email As String = email_tb.Text
        Dim password As String = password_tb.Text
        Dim speciality As String = combobox_tb.SelectedIndex = -1

        'validating the first name
        If fname_tb.Text.Trim() = "" Then
            MessageBox.Show("First name cannot be empty.")
            Return
        End If

        If Not IsLettersOnly(fname_tb.Text) Then
            MessageBox.Show("First name must contain only letters.")
            Return
        End If

        ' Validating the last name
        If lname_tb.Text.Trim() = "" Then
            MessageBox.Show("Last name cannot be empty.")
            Return
        End If

        If Not IsLettersOnly(lname_tb.Text) Then
            MessageBox.Show("Last name must contain only letters.")
            Return
        End If

        ' Validating the email address
        If Not IsValidEmailAddress(email_tb.Text) Then
            MessageBox.Show("Invalid email address.")
            Return
        End If

        ' Validating the password complexity
        If Not IsPasswordStrong(password) Then
            MessageBox.Show("Password must be at least 10 characters long and contain uppercase and lowercase letters, numbers, and special characters.")
            Return
        End If
        'validating the speciality
        If combobox_tb.Text = "" Then
            MessageBox.Show("select a speciality")
            Return
        End If

        Try
            ' Define the connection string (update with your database information)
            Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Joy Wanjiru M\source\repos\Finalle\Finalle\Database.mdf"

            ' Create a SQL INSERT statement with parameters to prevent SQL injection
            Dim insertQuery As String = "INSERT INTO staffreg (fname, lname, email, username, password, speciality) VALUES (@firstName, @lastName, @eMail, @username, @password, @speciality)"

            ' Create a connection to the database
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Create a command with the INSERT statement and connection
                Using cmd As New SqlCommand(insertQuery, connection)
                    ' Add parameters to the command
                    cmd.Parameters.AddWithValue("@firstName", fname_tb.Text)
                    cmd.Parameters.AddWithValue("@lastname", lname_tb.Text)
                    cmd.Parameters.AddWithValue("@eMail", email_tb.Text)
                    cmd.Parameters.AddWithValue("@username", username_tb.Text)
                    cmd.Parameters.AddWithValue("@password", password_tb.Text)
                    cmd.Parameters.AddWithValue("@speciality", combobox_tb.SelectedItem)
                    ' Execute the INSERT statement
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MsgBox("Data inserted successfully.", MsgBoxStyle.Information)

                        ' Clear the form for next capture of staff data
                        fname_tb.Clear()
                        lname_tb.Clear()
                        email_tb.Clear()
                        username_tb.Clear()
                        password_tb.Clear()
                        combobox_tb.SelectedIndex = -1

                    Else
                        MsgBox("Data insertion failed.", MsgBoxStyle.Critical)
                    End If
                End Using
            End Using
            'after successfull entry it prompts you to exit
            If MessageBox.Show("Exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Application.Exit()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub


    'function that checks if first name and last name are letters only
    Private Function IsLettersOnly(str As String) As Boolean
        Dim i As Integer = 0
        While i < str.Length
            If Not Char.IsLetter(str(i)) Then
                Return False
            End If
            i += 1
        End While
        Return True
    End Function

    'function that validates the format of the email
    Private Function IsValidEmailAddress(str As String) As Boolean
        Dim regex As New Regex("^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase)
        Return regex.IsMatch(str)
    End Function

    Function IsValidPhoneNumber(phoneNumber As String) As Boolean
        ' Define the regular expression pattern for the phone number
        Dim pattern As String = "^07\d{8}$"

        ' Create a Regex object
        Dim regex As New Regex(pattern)

        ' Use the IsMatch method to check if the phone number matches the pattern
        Return regex.IsMatch(phoneNumber)
    End Function

    'function that checks if the password meets all the conditions
    Private Function IsPasswordStrong(password As String) As Boolean
        ' Check password length
        If password.Length < 10 Then
            Return False
        End If

        ' Check for uppercase letters
        Dim hasUppercase As Boolean = False
        For i As Integer = 0 To password.Length - 1
            If Char.IsUpper(password(i)) Then
                hasUppercase = True
                Exit For
            End If
        Next

        If Not hasUppercase Then
            Return False
        End If

        ' Check for lowercase letters
        Dim hasLowercase As Boolean = False
        For i As Integer = 0 To password.Length - 1
            If Char.IsLower(password(i)) Then
                hasLowercase = True
                Exit For
            End If
        Next

        If Not hasLowercase Then
            Return False
        End If

        ' Check for numbers
        Dim hasNumbers As Boolean = False
        For i As Integer = 0 To password.Length - 1
            If Char.IsDigit(password(i)) Then
                hasNumbers = True
                Exit For
            End If
        Next

        If Not hasNumbers Then
            Return False
        End If

        ' Check for special characters
        Dim hasSpecialCharacters As Boolean = False
        For i As Integer = 0 To password.Length - 1
            If Not Char.IsLetterOrDigit(password(i)) Then
                hasSpecialCharacters = True
                Exit For
            End If
        Next

        If Not hasSpecialCharacters Then
            Return False
        End If

        ' If all checks pass, password is strong
        Return True
    End Function


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles use_email_cb.CheckedChanged

    End Sub
End Class