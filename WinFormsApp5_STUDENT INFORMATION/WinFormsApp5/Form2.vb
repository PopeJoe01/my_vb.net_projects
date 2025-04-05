Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Mr")
        ComboBox1.Items.Add("Mrs")
        ComboBox1.Items.Add("Miss")

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        Dim currentyear, DOBYear As Integer
        currentyear = Date.Today.Year
        DOBYear = DateTimePicker1.Value.Year
        TextBox3.Text = currentyear - DOBYear
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        DataGridView1.Rows.Add(ComboBox1.Text, TextBox1.Text, TextBox2.Text, ComboBox2.Text)


        ComboBox1.Text = " "
        TextBox1.Text = " "
        TextBox2.Text = " "
        ComboBox2.Text = " "


        ComboBox1.Focus()


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If DataGridView1.Columns(e.ColumnIndex).Name = "Edit" Then

            ComboBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
            TextBox1.Text = DataGridView1.CurrentRow.Cells(1).Value
            TextBox2.Text = DataGridView1.CurrentRow.Cells(2).Value
            ComboBox2.Text = DataGridView1.CurrentRow.Cells(3).Value
            DateTimePicker1.Text = DataGridView1.CurrentRow.Cells(4).Value
            TextBox3.Text = DataGridView1.CurrentRow.Cells(5).Value
            TextBox4.Text = DataGridView1.CurrentRow.Cells(6).Value
            TextBox5.Text = DataGridView1.CurrentRow.Cells(7).Value
            ComboBox3.Text = DataGridView1.CurrentRow.Cells(8).Value
            ComboBox4.Text = DataGridView1.CurrentRow.Cells(9).Value
            ComboBox5.Text = DataGridView1.CurrentRow.Cells(10).Value
            ComboBox6.Text = DataGridView1.CurrentRow.Cells(11).Value

            Button1.Enabled = False

        ElseIf DataGridView1.Columns(e.ColumnIndex).Name = "Update" Then

            DataGridView1.CurrentRow.Cells(0).Value = ComboBox1
            DataGridView1.CurrentRow.Cells(1).Value = TextBox1
            DataGridView1.CurrentRow.Cells(2).Value = TextBox2
            DataGridView1.CurrentRow.Cells(11).Value = ComboBox2
            DataGridView1.CurrentRow.Cells(3).Value = DateTimePicker1
            DataGridView1.CurrentRow.Cells(4).Value = TextBox3
            DataGridView1.CurrentRow.Cells(5).Value = TextBox4
            DataGridView1.CurrentRow.Cells(6).Value = TextBox5
            DataGridView1.CurrentRow.Cells(7).Value = ComboBox3
            DataGridView1.CurrentRow.Cells(8).Value = ComboBox4
            DataGridView1.CurrentRow.Cells(9).Value = ComboBox5
            DataGridView1.CurrentRow.Cells(10).Value = ComboBox6

        ElseIf DataGridView1.Columns(e.ColumnIndex).Name = "Delete" Then
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)

            MessageBox.Show("information", "record deleted successfully", MessageBoxButtons.YesNo, MessageBoxIcon.Information)



        End If

    End Sub
End Class
