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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.YearBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MonthsBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(119, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "4 Digit Year:"
        '
        'YearBox
        '
        Me.YearBox.Location = New System.Drawing.Point(234, 20)
        Me.YearBox.Mask = "0000"
        Me.YearBox.Name = "YearBox"
        Me.YearBox.Size = New System.Drawing.Size(100, 26)
        Me.YearBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Number of Months:"
        '
        'MonthsBox
        '
        Me.MonthsBox.Location = New System.Drawing.Point(234, 143)
        Me.MonthsBox.Name = "MonthsBox"
        Me.MonthsBox.ReadOnly = True
        Me.MonthsBox.Size = New System.Drawing.Size(100, 26)
        Me.MonthsBox.TabIndex = 0
        Me.MonthsBox.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(74, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(303, 64)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Determine the Number of Months on Which the 13th Falls on a Friday"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 201)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MonthsBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.YearBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Friday the 13th"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents YearBox As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MonthsBox As TextBox
    Friend WithEvents Button1 As Button
End Class
