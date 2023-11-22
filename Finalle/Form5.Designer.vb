<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.login_btn = New System.Windows.Forms.Button()
        Me.password_tb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.username_tb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'login_btn
        '
        Me.login_btn.Location = New System.Drawing.Point(72, 179)
        Me.login_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(50, 21)
        Me.login_btn.TabIndex = 11
        Me.login_btn.Text = "Login"
        Me.login_btn.UseVisualStyleBackColor = True
        '
        'password_tb
        '
        Me.password_tb.Location = New System.Drawing.Point(22, 124)
        Me.password_tb.Margin = New System.Windows.Forms.Padding(2)
        Me.password_tb.Name = "password_tb"
        Me.password_tb.Size = New System.Drawing.Size(97, 20)
        Me.password_tb.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 109)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Password"
        '
        'username_tb
        '
        Me.username_tb.Location = New System.Drawing.Point(22, 73)
        Me.username_tb.Margin = New System.Windows.Forms.Padding(2)
        Me.username_tb.Name = "username_tb"
        Me.username_tb.Size = New System.Drawing.Size(97, 20)
        Me.username_tb.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "LOGIN"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.login_btn)
        Me.Controls.Add(Me.password_tb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.username_tb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents login_btn As Button
    Friend WithEvents password_tb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents username_tb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
