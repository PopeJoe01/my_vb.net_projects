Public Class Form1
    Private Sub txtuser_Click(sender As Object, e As EventArgs) Handles txtuser.Click
        Dim username As String
        Dim password As String

        username = txtuser.Text
        password = txtpass.text

        If (txtuser.Text = "amin" And txtpass.text = "admin") Then
            MessageBox.Show("login sucess", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("error", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
