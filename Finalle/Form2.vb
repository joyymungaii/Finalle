Imports System.Net.Mail

Public Class Form2
    Private Sub btn_Send_Click(sender As Object, e As EventArgs) Handles btn_send.Click
        Try
            Dim smtp As New SmtpClient("smtp.gmail.com")
            Dim email As New MailMessage()

            ' Set the SMTP client credentials
            smtp.UseDefaultCredentials = False
            smtp.Credentials = New Net.NetworkCredential("2204201@students.kcau.ac.ke", "41609331")
            smtp.Port = 587
            smtp.EnableSsl = True

            ' Set the sender's email address
            email.From = New MailAddress(from_tb.Text)

            ' Set the recipient's email address
            email.To.Add(to_tb.Text)

            ' Set email subject, body, and other properties
            email.Subject = subject_tb.Text
            email.IsBodyHtml = False
            email.Body = body_tb.Text

            ' Send the email
            smtp.Send(email)

            ' Display a success message
            MsgBox("Mail Sent", MsgBoxStyle.Information)

            ' Close the current form and show Form1
            Me.Close()
            Form1.Show()

        Catch ex As Exception
            ' Display an error message if something goes wrong
            MsgBox("There was a Problem: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
