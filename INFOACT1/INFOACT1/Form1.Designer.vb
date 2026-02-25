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
        PictureBox1 = New PictureBox()
        loginBtn = New Button()
        pwbox = New TextBox()
        userbox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        showbtn = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.twice_modified
        PictureBox1.Location = New Point(473, 158)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(530, 319)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' loginBtn
        ' 
        loginBtn.Font = New Font("Times New Roman", 15F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        loginBtn.Location = New Point(769, 393)
        loginBtn.Name = "loginBtn"
        loginBtn.Size = New Size(109, 41)
        loginBtn.TabIndex = 1
        loginBtn.Text = "Login"
        loginBtn.UseVisualStyleBackColor = True
        ' 
        ' pwbox
        ' 
        pwbox.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pwbox.Location = New Point(610, 340)
        pwbox.Name = "pwbox"
        pwbox.Size = New Size(225, 34)
        pwbox.TabIndex = 2
        ' 
        ' userbox
        ' 
        userbox.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        userbox.Location = New Point(610, 272)
        userbox.Name = "userbox"
        userbox.Size = New Size(225, 34)
        userbox.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Gainsboro
        Label1.Font = New Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(610, 251)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 17)
        Label1.TabIndex = 4
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Gainsboro
        Label2.Font = New Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(610, 320)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 17)
        Label2.TabIndex = 5
        Label2.Text = "Password"
        ' 
        ' showbtn
        ' 
        showbtn.Location = New Point(841, 340)
        showbtn.Name = "showbtn"
        showbtn.Size = New Size(75, 34)
        showbtn.TabIndex = 6
        showbtn.Text = "Show"
        showbtn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.twice
        ClientSize = New Size(1492, 526)
        Controls.Add(Label1)
        Controls.Add(showbtn)
        Controls.Add(Label2)
        Controls.Add(userbox)
        Controls.Add(pwbox)
        Controls.Add(loginBtn)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents loginBtn As Button
    Friend WithEvents pwbox As TextBox
    Friend WithEvents userbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents showbtn As Button

End Class
