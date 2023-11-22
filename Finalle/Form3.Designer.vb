<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.date_tb = New System.Windows.Forms.DateTimePicker()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.combobox_tb = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DOB = New System.Windows.Forms.Label()
        Me.telephone_tb = New System.Windows.Forms.TextBox()
        Me.Telephone = New System.Windows.Forms.Label()
        Me.email_tb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lname_tb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fname_tb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'date_tb
        '
        Me.date_tb.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_tb.Location = New System.Drawing.Point(86, 179)
        Me.date_tb.Margin = New System.Windows.Forms.Padding(2)
        Me.date_tb.Name = "date_tb"
        Me.date_tb.Size = New System.Drawing.Size(91, 20)
        Me.date_tb.TabIndex = 37
        '
        'exit_btn
        '
        Me.exit_btn.Location = New System.Drawing.Point(287, 355)
        Me.exit_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(50, 23)
        Me.exit_btn.TabIndex = 36
        Me.exit_btn.Text = "Exit"
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(144, 224)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton2.TabIndex = 35
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Female"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(86, 224)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton1.TabIndex = 34
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Male"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'save_btn
        '
        Me.save_btn.Location = New System.Drawing.Point(287, 301)
        Me.save_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(50, 21)
        Me.save_btn.TabIndex = 33
        Me.save_btn.Text = "Save"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'combobox_tb
        '
        Me.combobox_tb.FormattingEnabled = True
        Me.combobox_tb.Items.AddRange(New Object() {"Nairobi", "Kiambu", "Samburu", "Narok", "Meru"})
        Me.combobox_tb.Location = New System.Drawing.Point(367, 24)
        Me.combobox_tb.Margin = New System.Windows.Forms.Padding(2)
        Me.combobox_tb.Name = "combobox_tb"
        Me.combobox_tb.Size = New System.Drawing.Size(107, 21)
        Me.combobox_tb.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(284, 27)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "County"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 224)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Gender"
        '
        'DOB
        '
        Me.DOB.AutoSize = True
        Me.DOB.Location = New System.Drawing.Point(11, 186)
        Me.DOB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DOB.Name = "DOB"
        Me.DOB.Size = New System.Drawing.Size(30, 13)
        Me.DOB.TabIndex = 29
        Me.DOB.Text = "DOB"
        '
        'telephone_tb
        '
        Me.telephone_tb.Location = New System.Drawing.Point(86, 142)
        Me.telephone_tb.Margin = New System.Windows.Forms.Padding(2)
        Me.telephone_tb.Name = "telephone_tb"
        Me.telephone_tb.Size = New System.Drawing.Size(91, 20)
        Me.telephone_tb.TabIndex = 28
        '
        'Telephone
        '
        Me.Telephone.AutoSize = True
        Me.Telephone.Location = New System.Drawing.Point(1, 145)
        Me.Telephone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Telephone.Name = "Telephone"
        Me.Telephone.Size = New System.Drawing.Size(58, 13)
        Me.Telephone.TabIndex = 27
        Me.Telephone.Text = "Telephone"
        '
        'email_tb
        '
        Me.email_tb.Location = New System.Drawing.Point(86, 102)
        Me.email_tb.Margin = New System.Windows.Forms.Padding(2)
        Me.email_tb.Name = "email_tb"
        Me.email_tb.Size = New System.Drawing.Size(91, 20)
        Me.email_tb.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 105)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "email"
        '
        'lname_tb
        '
        Me.lname_tb.Location = New System.Drawing.Point(86, 62)
        Me.lname_tb.Margin = New System.Windows.Forms.Padding(2)
        Me.lname_tb.Name = "lname_tb"
        Me.lname_tb.Size = New System.Drawing.Size(91, 20)
        Me.lname_tb.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Lastname"
        '
        'fname_tb
        '
        Me.fname_tb.Location = New System.Drawing.Point(86, 25)
        Me.fname_tb.Margin = New System.Windows.Forms.Padding(2)
        Me.fname_tb.Name = "fname_tb"
        Me.fname_tb.Size = New System.Drawing.Size(91, 20)
        Me.fname_tb.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Firstname"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.date_tb)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.combobox_tb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DOB)
        Me.Controls.Add(Me.telephone_tb)
        Me.Controls.Add(Me.Telephone)
        Me.Controls.Add(Me.email_tb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lname_tb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fname_tb)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents date_tb As DateTimePicker
    Friend WithEvents exit_btn As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents save_btn As Button
    Friend WithEvents combobox_tb As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DOB As Label
    Friend WithEvents telephone_tb As TextBox
    Friend WithEvents Telephone As Label
    Friend WithEvents email_tb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lname_tb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents fname_tb As TextBox
    Friend WithEvents Label1 As Label
End Class
