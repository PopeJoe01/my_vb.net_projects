Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    'Dim username As String
    'Dim password As String
    'username = Txtuser.Text
    'password = Txtpass.Text

    If (Txtuser.Text.Equals("admin") And Txtpass.Text.Equals("admin")) Then
        MessageBox.Show("login sucess", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)


    Else
        MessageBox.Show("error", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
    'End If
End Sub
End Class
