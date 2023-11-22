<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btn_send = New System.Windows.Forms.Button()
        Me.body_tb = New System.Windows.Forms.TextBox()
        Me.subject_tb = New System.Windows.Forms.TextBox()
        Me.to_tb = New System.Windows.Forms.TextBox()
        Me.from_tb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_send
        '
        Me.btn_send.Location = New System.Drawing.Point(495, 272)
        Me.btn_send.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(50, 18)
        Me.btn_send.TabIndex = 17
        Me.btn_send.Text = "Send"
        Me.btn_send.UseVisualStyleBackColor = True
        Me.btn_send.UseWaitCursor = True
        '
        'body_tb
        '
        Me.body_tb.Location = New System.Drawing.Point(334, 223)
        Me.body_tb.Margin = New System.Windows.Forms.Padding(2)
        Me.body_tb.Multiline = True
        Me.body_tb.Name = "body_tb"
        Me.body_tb.Size = New System.Drawing.Size(146, 96)
        Me.body_tb.TabIndex = 16
        '
        'subject_tb
        '
        Me.subject_tb.Location = New System.Drawing.Point(334, 190)
        Me.subject_tb.Margin = New System.Windows.Forms.Padding(2)
        Me.subject_tb.Name = "subject_tb"
        Me.subject_tb.Size = New System.Drawing.Size(97, 20)
        Me.subject_tb.TabIndex = 15
        '
        'to_tb
        '
        Me.to_tb.Location = New System.Drawing.Point(334, 159)
        Me.to_tb.Margin = New System.Windows.Forms.Padding(2)
        Me.to_tb.Name = "to_tb"
        Me.to_tb.Size = New System.Drawing.Size(97, 20)
        Me.to_tb.TabIndex = 14
        '
        'from_tb
        '
        Me.from_tb.Location = New System.Drawing.Point(334, 131)
        Me.from_tb.Margin = New System.Windows.Forms.Padding(2)
        Me.from_tb.Name = "from_tb"
        Me.from_tb.Size = New System.Drawing.Size(97, 20)
        Me.from_tb.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(258, 223)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Body"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(256, 190)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Subject"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(256, 159)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(256, 131)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "From"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_send)
        Me.Controls.Add(Me.body_tb)
        Me.Controls.Add(Me.subject_tb)
        Me.Controls.Add(Me.to_tb)
        Me.Controls.Add(Me.from_tb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_send As Button
    Friend WithEvents body_tb As TextBox
    Friend WithEvents subject_tb As TextBox
    Friend WithEvents to_tb As TextBox
    Friend WithEvents from_tb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
