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
        LoginBtn = New Button()
        userbox = New TextBox()
        UserText = New Label()
        PassText = New Label()
        Showbtn = New Button()
        pwbox = New TextBox()
        SuspendLayout()
        ' 
        ' LoginBtn
        ' 
        LoginBtn.BackColor = Color.Transparent
        LoginBtn.Font = New Font("Bernard MT Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LoginBtn.Location = New Point(789, 389)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(115, 44)
        LoginBtn.TabIndex = 0
        LoginBtn.Text = "Login"
        LoginBtn.UseVisualStyleBackColor = False
        ' 
        ' userbox
        ' 
        userbox.Location = New Point(652, 289)
        userbox.Name = "userbox"
        userbox.Size = New Size(230, 23)
        userbox.TabIndex = 2
        ' 
        ' UserText
        ' 
        UserText.AutoSize = True
        UserText.BackColor = Color.Gainsboro
        UserText.Location = New Point(652, 271)
        UserText.Name = "UserText"
        UserText.Size = New Size(60, 15)
        UserText.TabIndex = 3
        UserText.Text = "Username"
        ' 
        ' PassText
        ' 
        PassText.AutoSize = True
        PassText.BackColor = Color.Gainsboro
        PassText.Location = New Point(652, 329)
        PassText.Name = "PassText"
        PassText.Size = New Size(57, 15)
        PassText.TabIndex = 4
        PassText.Text = "Password"
        ' 
        ' Showbtn
        ' 
        Showbtn.Location = New Point(888, 347)
        Showbtn.Name = "Showbtn"
        Showbtn.Size = New Size(75, 23)
        Showbtn.TabIndex = 5
        Showbtn.Text = "SHOW"
        Showbtn.UseVisualStyleBackColor = True
        ' 
        ' pwbox
        ' 
        pwbox.Location = New Point(652, 347)
        pwbox.Name = "pwbox"
        pwbox.PasswordChar = "*"c
        pwbox.Size = New Size(230, 23)
        pwbox.TabIndex = 6
        ' 
        ' Form1
        ' 
        AcceptButton = LoginBtn
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.twice
        ClientSize = New Size(1479, 685)
        Controls.Add(pwbox)
        Controls.Add(Showbtn)
        Controls.Add(PassText)
        Controls.Add(UserText)
        Controls.Add(userbox)
        Controls.Add(LoginBtn)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LoginBtn As Button
    Friend WithEvents userbox As TextBox
    Friend WithEvents UserText As Label
    Friend WithEvents PassText As Label
    Friend WithEvents Showbtn As Button
    Friend WithEvents pwbox As TextBox

End Class
