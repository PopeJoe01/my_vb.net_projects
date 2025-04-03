<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtuser = New Label()
        txtpass = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' txtuser
        ' 
        txtuser.AutoSize = True
        txtuser.Font = New Font("Segoe UI", 20F)
        txtuser.Location = New Point(188, 100)
        txtuser.Name = "txtuser"
        txtuser.Size = New Size(200, 54)
        txtuser.TabIndex = 0
        txtuser.Text = "Username"
        ' 
        ' txtpass
        ' 
        txtpass.AutoSize = True
        txtpass.Font = New Font("Segoe UI", 20F)
        txtpass.Location = New Point(188, 160)
        txtpass.Name = "txtpass"
        txtpass.Size = New Size(188, 54)
        txtpass.TabIndex = 1
        txtpass.Text = "Password"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(450, 120)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(232, 31)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(450, 183)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(232, 31)
        TextBox2.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 15F)
        Button1.Location = New Point(485, 275)
        Button1.Name = "Button1"
        Button1.Size = New Size(140, 51)
        Button1.TabIndex = 4
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1088, 540)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(txtpass)
        Controls.Add(txtuser)
        Name = "Form1"
        Text = "Lgin Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtuser As Label
    Friend WithEvents txtpass As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button

End Class
