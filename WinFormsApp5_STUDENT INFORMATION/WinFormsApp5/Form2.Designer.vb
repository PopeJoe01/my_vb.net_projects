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
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        ComboBox2 = New ComboBox()
        DataGridView1 = New DataGridView()
        Title = New DataGridViewTextBoxColumn()
        FirstName = New DataGridViewTextBoxColumn()
        Surname = New DataGridViewTextBoxColumn()
        Gender = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Edit = New DataGridViewButtonColumn()
        Update = New DataGridViewButtonColumn()
        Delete = New DataGridViewButtonColumn()
        Label4 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label5 = New Label()
        Label6 = New Label()
        TextBox2 = New TextBox()
        Label7 = New Label()
        PictureBox1 = New PictureBox()
        ComboBox3 = New ComboBox()
        TextBox3 = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        ComboBox4 = New ComboBox()
        ComboBox5 = New ComboBox()
        ComboBox6 = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(68, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 28)
        Label1.TabIndex = 0
        Label1.Text = "Title"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(154, 35)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(76, 33)
        ComboBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(36, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 28)
        Label2.TabIndex = 2
        Label2.Text = "FisrtName"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(154, 77)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(182, 31)
        TextBox1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(41, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 28)
        Label3.TabIndex = 4
        Label3.Text = "Gender"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"male", "female"})
        ComboBox2.Location = New Point(154, 151)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(76, 33)
        ComboBox2.TabIndex = 5
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Title, FirstName, Surname, Gender, Column1, Column2, Column3, Column4, Edit, Update, Delete})
        DataGridView1.Location = New Point(28, 339)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1071, 179)
        DataGridView1.TabIndex = 6
        ' 
        ' Title
        ' 
        Title.HeaderText = "Title"
        Title.MinimumWidth = 8
        Title.Name = "Title"
        Title.Width = 150
        ' 
        ' FirstName
        ' 
        FirstName.HeaderText = "Firstname"
        FirstName.MinimumWidth = 8
        FirstName.Name = "FirstName"
        FirstName.Width = 150
        ' 
        ' Surname
        ' 
        Surname.HeaderText = "surname"
        Surname.MinimumWidth = 8
        Surname.Name = "Surname"
        Surname.Width = 150
        ' 
        ' Gender
        ' 
        Gender.HeaderText = "Gender"
        Gender.MinimumWidth = 8
        Gender.Name = "Gender"
        Gender.Width = 150
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "DOB"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 150
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Age"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Occupation"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.Width = 150
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Telephone"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.Width = 150
        ' 
        ' Edit
        ' 
        Edit.HeaderText = "Edit"
        Edit.MinimumWidth = 8
        Edit.Name = "Edit"
        Edit.Text = "Edit"
        Edit.UseColumnTextForButtonValue = True
        Edit.Width = 50
        ' 
        ' Update
        ' 
        Update.HeaderText = "Update"
        Update.MinimumWidth = 8
        Update.Name = "Update"
        Update.Text = "Update"
        Update.UseColumnTextForButtonValue = True
        Update.Width = 75
        ' 
        ' Delete
        ' 
        Delete.HeaderText = "Delete"
        Delete.MinimumWidth = 8
        Delete.Name = "Delete"
        Delete.Text = "Delete"
        Delete.UseColumnTextForButtonValue = True
        Delete.Width = 60
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(51, 203)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 28)
        Label4.TabIndex = 7
        Label4.Text = "DOB"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(154, 205)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(280, 31)
        DateTimePicker1.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(51, 250)
        Label5.Name = "Label5"
        Label5.Size = New Size(47, 28)
        Label5.TabIndex = 9
        Label5.Text = "Age"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(28, 299)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 28)
        Label6.TabIndex = 10
        Label6.Text = "Occupation"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(154, 114)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(182, 31)
        TextBox2.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(36, 114)
        Label7.Name = "Label7"
        Label7.Size = New Size(89, 28)
        Label7.TabIndex = 12
        Label7.Text = "Surname"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.stud_login_image
        PictureBox1.Location = New Point(824, 35)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(150, 230)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(154, 294)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(182, 33)
        ComboBox3.TabIndex = 14
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(154, 250)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(182, 31)
        TextBox3.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(506, 199)
        Label8.Name = "Label8"
        Label8.Size = New Size(73, 28)
        Label8.TabIndex = 16
        Label8.Text = "Region"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(478, 35)
        Label9.Name = "Label9"
        Label9.Size = New Size(101, 28)
        Label9.TabIndex = 17
        Label9.Text = "Telephone"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(496, 151)
        Label10.Name = "Label10"
        Label10.Size = New Size(83, 28)
        Label10.TabIndex = 18
        Label10.Text = "Religion"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(456, 114)
        Label11.Name = "Label11"
        Label11.Size = New Size(132, 28)
        Label11.TabIndex = 19
        Label11.Text = "Marital Status"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(515, 77)
        Label12.Name = "Label12"
        Label12.Size = New Size(59, 28)
        Label12.TabIndex = 20
        Label12.Text = "Email"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(594, 37)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(182, 31)
        TextBox4.TabIndex = 21
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(594, 80)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(182, 31)
        TextBox5.TabIndex = 22
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(594, 117)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(182, 33)
        ComboBox4.TabIndex = 23
        ' 
        ' ComboBox5
        ' 
        ComboBox5.FormattingEnabled = True
        ComboBox5.Location = New Point(594, 156)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(182, 33)
        ComboBox5.TabIndex = 24
        ' 
        ' ComboBox6
        ' 
        ComboBox6.FormattingEnabled = True
        ComboBox6.Location = New Point(594, 203)
        ComboBox6.Name = "ComboBox6"
        ComboBox6.Size = New Size(182, 33)
        ComboBox6.TabIndex = 25
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Lime
        Button1.Location = New Point(396, 299)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 26
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.Location = New Point(532, 299)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 27
        Button2.Text = "Close"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(824, 262)
        Button3.Name = "Button3"
        Button3.Size = New Size(150, 34)
        Button3.TabIndex = 28
        Button3.Text = "Load photo"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        ClientSize = New Size(1141, 530)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ComboBox6)
        Controls.Add(ComboBox5)
        Controls.Add(ComboBox4)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(TextBox3)
        Controls.Add(ComboBox3)
        Controls.Add(PictureBox1)
        Controls.Add(Label7)
        Controls.Add(TextBox2)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label4)
        Controls.Add(DataGridView1)
        Controls.Add(ComboBox2)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "STUDENT INFORMATION"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Title As DataGridViewTextBoxColumn
    Friend WithEvents FirstName As DataGridViewTextBoxColumn
    Friend WithEvents Surname As DataGridViewTextBoxColumn
    Friend WithEvents Gender As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewButtonColumn
    Friend WithEvents Update As DataGridViewButtonColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
End Class
