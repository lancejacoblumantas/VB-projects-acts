Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles pwbox.TextChanged
        pwbox.PasswordChar = "*"
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles userbox.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub showbtn_Click(sender As Object, e As EventArgs) Handles showbtn.Click
        If showbtn.Text = "Show" Then
            showbtn.Text = "Hide"
            pwbox.PasswordChar = Chr(0)
        ElseIf showbtn.Text = "Hide" Then
            showbtn.Text = "Show"
            pwbox.PasswordChar = "*"c
        End If
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim username As String = userbox.Text.Trim()
        Dim password As String = pwbox.Text.Trim()

        If pwbox.Text = "admin123" And userbox.Text = "admin" Then
            ' Me.Close()
            Me.Hide()
            Form2.Show()

        End If
    End Sub
End Class
