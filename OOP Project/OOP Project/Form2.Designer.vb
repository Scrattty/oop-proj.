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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Panel1 = New Panel()
        Panel2 = New Panel()
        btnSignupShow = New Button()
        Label7 = New Label()
        Label5 = New Label()
        btnLogin = New Button()
        Label3 = New Label()
        Label1 = New Label()
        txtPassword1 = New TextBox()
        txtEmailAddress1 = New TextBox()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.AppWorkspace
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(424, 537)
        Panel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnSignupShow)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(btnLogin)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(txtPassword1)
        Panel2.Controls.Add(txtEmailAddress1)
        Panel2.Location = New Point(423, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(633, 537)
        Panel2.TabIndex = 2
        ' 
        ' btnSignupShow
        ' 
        btnSignupShow.FlatAppearance.BorderSize = 0
        btnSignupShow.FlatStyle = FlatStyle.Flat
        btnSignupShow.ForeColor = Color.Blue
        btnSignupShow.Location = New Point(340, 309)
        btnSignupShow.Name = "btnSignupShow"
        btnSignupShow.Size = New Size(65, 29)
        btnSignupShow.TabIndex = 5
        btnSignupShow.Text = "Signup"
        btnSignupShow.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(195, 313)
        Label7.Name = "Label7"
        Label7.Size = New Size(143, 20)
        Label7.TabIndex = 4
        Label7.Text = "Don't have account?"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sans Serif Collection", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(195, 106)
        Label5.Name = "Label5"
        Label5.Size = New Size(123, 49)
        Label5.TabIndex = 3
        Label5.Text = "Sign in"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.ActiveCaptionText
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Sans Serif Collection", 4.79999971F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = SystemColors.ButtonHighlight
        btnLogin.Location = New Point(259, 357)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(146, 42)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sans Serif Collection", 4.79999971F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(195, 253)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 20)
        Label3.TabIndex = 1
        Label3.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sans Serif Collection", 4.79999971F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(195, 191)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 20)
        Label1.TabIndex = 1
        Label1.Text = "Email Address"
        ' 
        ' txtPassword1
        ' 
        txtPassword1.Location = New Point(195, 276)
        txtPassword1.Name = "txtPassword1"
        txtPassword1.PasswordChar = "*"c
        txtPassword1.Size = New Size(267, 27)
        txtPassword1.TabIndex = 0
        ' 
        ' txtEmailAddress1
        ' 
        txtEmailAddress1.Location = New Point(195, 214)
        txtEmailAddress1.Name = "txtEmailAddress1"
        txtEmailAddress1.Size = New Size(267, 27)
        txtEmailAddress1.TabIndex = 0
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1054, 537)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSignupShow As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword1 As TextBox
    Friend WithEvents txtEmailAddress1 As TextBox
End Class
