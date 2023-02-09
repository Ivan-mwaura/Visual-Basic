<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtrad = New System.Windows.Forms.TextBox()
        Me.btncompute = New System.Windows.Forms.Button()
        Me.lbloutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Radius"
        '
        'txtrad
        '
        Me.txtrad.Location = New System.Drawing.Point(132, 54)
        Me.txtrad.Name = "txtrad"
        Me.txtrad.Size = New System.Drawing.Size(100, 23)
        Me.txtrad.TabIndex = 1
        '
        'btncompute
        '
        Me.btncompute.Location = New System.Drawing.Point(101, 99)
        Me.btncompute.Name = "btncompute"
        Me.btncompute.Size = New System.Drawing.Size(75, 23)
        Me.btncompute.TabIndex = 2
        Me.btncompute.Text = "compute"
        Me.btncompute.UseVisualStyleBackColor = True
        '
        'lbloutput
        '
        Me.lbloutput.AutoSize = True
        Me.lbloutput.Location = New System.Drawing.Point(86, 151)
        Me.lbloutput.Name = "lbloutput"
        Me.lbloutput.Size = New System.Drawing.Size(41, 15)
        Me.lbloutput.TabIndex = 3
        Me.lbloutput.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbloutput)
        Me.Controls.Add(Me.btncompute)
        Me.Controls.Add(Me.txtrad)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtrad As TextBox
    Friend WithEvents btncompute As Button
    Friend WithEvents lbloutput As Label
End Class
