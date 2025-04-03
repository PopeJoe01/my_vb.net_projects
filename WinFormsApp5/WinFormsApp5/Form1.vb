Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = "Pope"
        Dim password As String = "8282"

        Try
            If TextBox1.Text = username And TextBox2.Text = password Then
                Form2.Show()
                Me.Hide()


            Else
                MessageBox.Show("wrong username and password")

            End If

        Catch ex As Exception

        End Try



    End Sub
End Class