<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.reg_btn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.diagnosis_btn = New System.Windows.Forms.Button()
        Me.email_btn = New System.Windows.Forms.Button()
        Me.weight_tb = New System.Windows.Forms.TextBox()
        Me.height_tb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(348, 235)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Login"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'reg_btn
        '
        Me.reg_btn.Location = New System.Drawing.Point(219, 235)
        Me.reg_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.reg_btn.Name = "reg_btn"
        Me.reg_btn.Size = New System.Drawing.Size(73, 34)
        Me.reg_btn.TabIndex = 18
        Me.reg_btn.Text = "Register staff"
        Me.reg_btn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(88, 235)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 34)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Register Patient"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'diagnosis_btn
        '
        Me.diagnosis_btn.Location = New System.Drawing.Point(355, 171)
        Me.diagnosis_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.diagnosis_btn.Name = "diagnosis_btn"
        Me.diagnosis_btn.Size = New System.Drawing.Size(53, 23)
        Me.diagnosis_btn.TabIndex = 16
        Me.diagnosis_btn.Text = "Diagnosis"
        Me.diagnosis_btn.UseVisualStyleBackColor = True
        '
        'email_btn
        '
        Me.email_btn.Location = New System.Drawing.Point(88, 171)
        Me.email_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.email_btn.Name = "email_btn"
        Me.email_btn.Size = New System.Drawing.Size(60, 23)
        Me.email_btn.TabIndex = 15
        Me.email_btn.Text = "Email"
        Me.email_btn.UseVisualStyleBackColor = True
        '
        'weight_tb
        '
        Me.weight_tb.Location = New System.Drawing.Point(210, 81)
        Me.weight_tb.Margin = New System.Windows.Forms.Padding(2)
        Me.weight_tb.Name = "weight_tb"
        Me.weight_tb.Size = New System.Drawing.Size(68, 20)
        Me.weight_tb.TabIndex = 14
        '
        'height_tb
        '
        Me.height_tb.Location = New System.Drawing.Point(210, 45)
        Me.height_tb.Margin = New System.Windows.Forms.Padding(2)
        Me.height_tb.Name = "height_tb"
        Me.height_tb.Size = New System.Drawing.Size(68, 20)
        Me.height_tb.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(128, 81)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "weight"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(126, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Height"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(219, 171)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "calculatebmi"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.reg_btn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.diagnosis_btn)
        Me.Controls.Add(Me.email_btn)
        Me.Controls.Add(Me.weight_tb)
        Me.Controls.Add(Me.height_tb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents reg_btn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents diagnosis_btn As Button
    Friend WithEvents email_btn As Button
    Friend WithEvents weight_tb As TextBox
    Friend WithEvents height_tb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
