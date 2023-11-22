Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

'the following code takes patient data and saves it in a database called clinicDb in table patientregistration
Public Class Form3

    Dim genderselected As String
    Dim selectedCounty As String
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    'Radio button for male option
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            genderselected = "Male"
        Else
            genderselected = "" ' Reset gender selection
        End If
    End Sub

    'radio button for female option
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            genderselected = "Female"
        Else
            genderselected = "" ' Reset gender selection
        End If
    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        'initializing items
        Dim firstName As String = fname_tb.Text
        Dim lastName As String = lname_tb.Text
        Dim email As String = email_tb.Text
        Dim telephone As String

        'validating the first name
        If fname_tb.Text.Trim() = "" Then
            MessageBox.Show("Enter first name.")
            Return
        End If

        If Not IsLettersOnly(fname_tb.Text) Then
            MessageBox.Show("First name must contain only letters.")
            Return
        End If

        ' Validating the last name
        If lname_tb.Text.Trim() = "" Then
            MessageBox.Show("Enter last name.")
            Return
        End If

        If Not IsLettersOnly(lname_tb.Text) Then
            MessageBox.Show("Last name must contain only letters.")
            Return
        End If

        ' Validating the email address
        If Not IsValidEmailAddress(email_tb.Text) Then
            MessageBox.Show("Enter a valid email address.")
            Return

        End If

        ' Validating the telephone
        'makes sure the tel is in 07 formats and has 10 digits
        Try
            telephone = CInt(telephone_tb.Text)
            If Not IsValidPhoneNumber(telephone_tb.Text) Then
                MessageBox.Show("Please enter a valid phone number in the format 07********.")
                Return
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter a valid integer value for telephone.")
            Return
        End Try

        ' Validate gender selection
        If genderselected = "" Then
            MessageBox.Show("Please select a gender.")
            Return
        End If

        ' Validate county selection
        If combobox_tb.Text = "" Then
            MessageBox.Show("Please select a county.")
            Return
        End If

        Try
            ' Define the connection string 
            Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Joy Wanjiru M\source\repos\Finalle\Finalle\Database.mdf;"

            ' Create a SQL INSERT statement with parameters to prevent SQL injection
            Dim insertQuery As String = "INSERT INTO patientregistration (fname, lname, email, telephone, DOB, gender, county) VALUES (@firstName, @lastName, @eMail, @celPhone, @DoB, @Gender, @County)"

            ' 
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Create a command with the INSERT statement and connection
                Using cmd As New SqlCommand(insertQuery, connection)
                    ' Adding parameters to the command
                    cmd.Parameters.AddWithValue("@firstName", fname_tb.Text)
                    cmd.Parameters.AddWithValue("@lastname", lname_tb.Text)
                    cmd.Parameters.AddWithValue("@eMail", email_tb.Text)
                    cmd.Parameters.AddWithValue("@celphone", telephone_tb.Text)
                    cmd.Parameters.AddWithValue("@DoB", date_tb.Value)
                    cmd.Parameters.AddWithValue("@Gender", genderselected)
                    cmd.Parameters.AddWithValue("@County", combobox_tb.SelectedItem)

                    ' Execute the INSERT statement
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MsgBox("Data inserted successfully.", MsgBoxStyle.Information)

                        ' Clear the form for next capture of patient data
                        fname_tb.Clear()
                        lname_tb.Clear()
                        email_tb.Clear()
                        telephone_tb.Clear()
                        date_tb.Value = DateTime.Today
                        RadioButton1.Checked = False
                        RadioButton2.Checked = False
                        combobox_tb.SelectedIndex = -1

                        'after successfull registration exit the application
                        If MessageBox.Show("Do you want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            Application.Exit()
                        End If

                        'if registration fails a warning is displayed
                    Else
                        MsgBox("Data insertion failed.", MsgBoxStyle.Critical)
                    End If
                End Using
            End Using
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

    'function that checks if email is entered in the correct format
    Private Function IsValidEmailAddress(str As String) As Boolean
        Dim regex As New Regex("^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase)
        Return regex.IsMatch(str)
    End Function

    'function that checks if phone number is entered in the correct format
    Function IsValidPhoneNumber(phoneNumber As String) As Boolean
        ' Define the regular expression pattern for the phone number
        Dim pattern As String = "^07\d{8}$"

        ' Create a Regex object
        Dim regex As New Regex(pattern)

        ' Use the IsMatch method to check if the phone number matches the pattern
        Return regex.IsMatch(phoneNumber)
    End Function


End Class