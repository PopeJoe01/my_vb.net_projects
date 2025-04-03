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
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Txtuser = New TextBox()
        Txtpass = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.Location = New Point(91, 146)
        Label1.Name = "Label1"
        Label1.Size = New Size(200, 54)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20F)
        Label2.Location = New Point(91, 216)
        Label2.Name = "Label2"
        Label2.Size = New Size(188, 54)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 15F)
        Button1.Location = New Point(484, 290)
        Button1.Name = "Button1"
        Button1.Size = New Size(180, 52)
        Button1.TabIndex = 2
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Txtuser
        ' 
        Txtuser.Location = New Point(425, 166)
        Txtuser.Name = "Txtuser"
        Txtuser.Size = New Size(286, 31)
        Txtuser.TabIndex = 3
        ' 
        ' Txtpass
        ' 
        Txtpass.Location = New Point(425, 216)
        Txtpass.Name = "Txtpass"
        Txtpass.Size = New Size(286, 31)
        Txtpass.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1095, 553)
        Controls.Add(Txtpass)
        Controls.Add(Txtuser)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Login Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Txtuser As TextBox
    Friend WithEvents Txtpass As TextBox

End Class
