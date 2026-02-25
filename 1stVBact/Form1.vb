Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Showbtn_Click(sender As Object, e As EventArgs) Handles Showbtn.Click
        If Showbtn.Text = "SHOW" Then
            Showbtn.Text = "HIDE"
            pwbox.PasswordChar = Chr(0)
        ElseIf Showbtn.Text = "HIDE" Then
            Showbtn.Text = "SHOW"
            pwbox.PasswordChar = "*"c
        End If
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim username As String = userbox.Text.Trim()
        Dim password As String = pwbox.Text.Trim()

        If username = "admin" Or password = "password123" Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub pwbox_TextChanged(sender As Object, e As EventArgs) Handles pwbox.TextChanged

    End Sub

    Private Sub userbox_TextChanged(sender As Object, e As EventArgs) Handles userbox.TextChanged

    End Sub

    Private Sub PassText_Click(sender As Object, e As EventArgs) Handles PassText.Click

    End Sub
End Class
