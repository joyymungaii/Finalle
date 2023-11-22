Public Class Form1
    Dim dbBMI As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dbheight As Double
        Dim dbweight As Double

        dbheight = height_tb.Text
        dbweight = weight_tb.Text

        dbBMI = dbweight / dbheight ^ 2

        MessageBox.Show(dbBMI)


    End Sub
    Private Sub email_btn_Click(sender As Object, e As EventArgs) Handles email_btn.Click
        Form2.Show()
    End Sub
    Function diagnosis(ByRef dblmi As Double) As String
        If dblmi < 18.5 Then
            Return "underweight"
        ElseIf dblmi > 25 Then
            Return "overweight"
        Else
            Return "referall"
        End If
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub diagnosis_btn_Click(sender As Object, e As EventArgs) Handles diagnosis_btn.Click
        Dim message As String
        message = diagnosis(dbBMI)
        MessageBox.Show(message)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form5.Show()
    End Sub

    Private Sub reg_btn_Click(sender As Object, e As EventArgs) Handles reg_btn.Click
        Form4.Show()
    End Sub
End Class
