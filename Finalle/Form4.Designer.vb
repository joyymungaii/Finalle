<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.use_email_cb = New System.Windows.Forms.CheckBox()
        Me.password_tb = New System.Windows.Forms.TextBox()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.combobox_tb = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DOB = New System.Windows.Forms.Label()
        Me.username_tb = New System.Windows.Forms.TextBox()
        Me.Telephone = New System.Windows.Forms.Label()
        Me.email_tb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lname_tb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fname_tb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(211, 22)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 13)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "STAFF REGISTRATION"
        '
        'use_email_cb
        '
        Me.use_email_cb.AutoSize = True
        Me.use_email_cb.Location = New System.Drawing.Point(265, 154)
        Me.use_email_cb.Margin = New System.Windows.Forms.Padding(2)
        Me.use_email_cb.Name = "use_email_cb"
        Me.use_email_cb.Size = New System.Drawing.Size(70, 17)
        Me.use_email_cb.TabIndex = 54
        Me.use_email_cb.Text = "use email"
        Me.use_email_cb.UseVisualStyleBackColor = True
        '
        'password_tb
        '
        Me.password_tb.Location = New System.Drawing.Point(107, 184)
        Me.password_tb.Margin = New System.Windows.Forms.Padding(2)
        Me.password_tb.Name = "password_tb"
        Me.password_tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_tb.Size = New System.Drawing.Size(142, 20)
        Me.password_tb.TabIndex = 53
        '
        'exit_btn
        '
        Me.exit_btn.Location = New System.Drawing.Point(341, 311)
        Me.exit_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(50, 23)
        Me.exit_btn.TabIndex = 52
        Me.exit_btn.Text = "Exit"
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'save_btn
        '
        Me.save_btn.Location = New System.Drawing.Point(341, 255)
        Me.save_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(50, 21)
        Me.save_btn.TabIndex = 51
        Me.save_btn.Text = "Save"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'combobox_tb
        '
        Me.combobox_tb.FormattingEnabled = True
        Me.combobox_tb.Items.AddRange(New Object() {"Radiologist", "General physician", "Surgeon", "Urolologist", "Cardiologist", "Gynacologist", "Oncologist", "Triage Nurse", "Nurse", "ICT", "Pharmasist", "Accountant", "HR"})
        Me.combobox_tb.Location = New System.Drawing.Point(431, 43)
        Me.combobox_tb.Margin = New System.Windows.Forms.Padding(2)
        Me.combobox_tb.MaxDropDownItems = 15
        Me.combobox_tb.Name = "combobox_tb"
        Me.combobox_tb.Size = New System.Drawing.Size(129, 21)
        Me.combobox_tb.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(376, 45)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Speciality"
        '
        'DOB
        '
        Me.DOB.AutoSize = True
        Me.DOB.Location = New System.Drawing.Point(45, 188)
        Me.DOB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DOB.Name = "DOB"
        Me.DOB.Size = New System.Drawing.Size(53, 13)
        Me.DOB.TabIndex = 48
        Me.DOB.Text = "Password"
        '
        'username_tb
        '
        Me.username_tb.Location = New System.Drawing.Point(107, 154)
        Me.username_tb.Margin = New System.Windows.Forms.Padding(2)
        Me.username_tb.Name = "username_tb"
        Me.username_tb.Size = New System.Drawing.Size(142, 20)
        Me.username_tb.TabIndex = 47
        '
        'Telephone
        '
        Me.Telephone.AutoSize = True
        Me.Telephone.Location = New System.Drawing.Point(42, 159)
        Me.Telephone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Telephone.Name = "Telephone"
        Me.Telephone.Size = New System.Drawing.Size(55, 13)
        Me.Telephone.TabIndex = 46
        Me.Telephone.Text = "Username"
        '
        'email_tb
        '
        Me.email_tb.Location = New System.Drawing.Point(107, 120)
        Me.email_tb.Margin = New System.Windows.Forms.Padding(2)
        Me.email_tb.Name = "email_tb"
        Me.email_tb.Size = New System.Drawing.Size(142, 20)
        Me.email_tb.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 120)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "email"
        '
        'lname_tb
        '
        Me.lname_tb.Location = New System.Drawing.Point(107, 76)
        Me.lname_tb.Margin = New System.Windows.Forms.Padding(2)
        Me.lname_tb.Name = "lname_tb"
        Me.lname_tb.Size = New System.Drawing.Size(142, 20)
        Me.lname_tb.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Lastname"
        '
        'fname_tb
        '
        Me.fname_tb.Location = New System.Drawing.Point(107, 43)
        Me.fname_tb.Margin = New System.Windows.Forms.Padding(2)
        Me.fname_tb.Name = "fname_tb"
        Me.fname_tb.Size = New System.Drawing.Size(142, 20)
        Me.fname_tb.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Firstname"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.use_email_cb)
        Me.Controls.Add(Me.password_tb)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.combobox_tb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DOB)
        Me.Controls.Add(Me.username_tb)
        Me.Controls.Add(Me.Telephone)
        Me.Controls.Add(Me.email_tb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lname_tb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fname_tb)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents use_email_cb As CheckBox
    Friend WithEvents password_tb As TextBox
    Friend WithEvents exit_btn As Button
    Friend WithEvents save_btn As Button
    Friend WithEvents combobox_tb As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DOB As Label
    Friend WithEvents username_tb As TextBox
    Friend WithEvents Telephone As Label
    Friend WithEvents email_tb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lname_tb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents fname_tb As TextBox
    Friend WithEvents Label1 As Label
End Class
