<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Panel2 = New Panel()
        btnLoginShow = New Button()
        Label6 = New Label()
        Label5 = New Label()
        btnCreateAccount = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        txtConfirmPassword = New TextBox()
        txtPassword = New TextBox()
        txtEmailAddress = New TextBox()
        txtName = New TextBox()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.AppWorkspace
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(648, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(424, 584)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnLoginShow)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(btnCreateAccount)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(txtConfirmPassword)
        Panel2.Controls.Add(txtPassword)
        Panel2.Controls.Add(txtEmailAddress)
        Panel2.Controls.Add(txtName)
        Panel2.Location = New Point(-2, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(653, 584)
        Panel2.TabIndex = 1
        ' 
        ' btnLoginShow
        ' 
        btnLoginShow.FlatAppearance.BorderSize = 0
        btnLoginShow.FlatStyle = FlatStyle.Flat
        btnLoginShow.ForeColor = Color.Blue
        btnLoginShow.Location = New Point(326, 412)
        btnLoginShow.Name = "btnLoginShow"
        btnLoginShow.Size = New Size(63, 29)
        btnLoginShow.TabIndex = 5
        btnLoginShow.Text = "Sign in"
        btnLoginShow.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(172, 416)
        Label6.Name = "Label6"
        Label6.Size = New Size(158, 20)
        Label6.TabIndex = 4
        Label6.Text = "Already have account?"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sans Serif Collection", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(172, 85)
        Label5.Name = "Label5"
        Label5.Size = New Size(134, 49)
        Label5.TabIndex = 3
        Label5.Text = "Sign up"
        ' 
        ' btnCreateAccount
        ' 
        btnCreateAccount.BackColor = SystemColors.ActiveCaptionText
        btnCreateAccount.FlatAppearance.BorderSize = 0
        btnCreateAccount.FlatStyle = FlatStyle.Flat
        btnCreateAccount.Font = New Font("Sans Serif Collection", 4.79999971F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCreateAccount.ForeColor = SystemColors.ButtonHighlight
        btnCreateAccount.Location = New Point(229, 466)
        btnCreateAccount.Name = "btnCreateAccount"
        btnCreateAccount.Size = New Size(146, 42)
        btnCreateAccount.TabIndex = 2
        btnCreateAccount.Text = "Create Account"
        btnCreateAccount.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sans Serif Collection", 4.79999971F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(172, 354)
        Label4.Name = "Label4"
        Label4.Size = New Size(135, 20)
        Label4.TabIndex = 1
        Label4.Text = "Confirm Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sans Serif Collection", 4.79999971F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(172, 292)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 20)
        Label3.TabIndex = 1
        Label3.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sans Serif Collection", 4.79999971F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(172, 230)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 20)
        Label1.TabIndex = 1
        Label1.Text = "Email Address"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sans Serif Collection", 4.79999971F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(172, 168)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 20)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(172, 377)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PasswordChar = "*"c
        txtConfirmPassword.Size = New Size(267, 27)
        txtConfirmPassword.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(172, 315)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(267, 27)
        txtPassword.TabIndex = 0
        ' 
        ' txtEmailAddress
        ' 
        txtEmailAddress.Location = New Point(172, 253)
        txtEmailAddress.Name = "txtEmailAddress"
        txtEmailAddress.Size = New Size(267, 27)
        txtEmailAddress.TabIndex = 0
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(172, 191)
        txtName.Name = "txtName"
        txtName.Size = New Size(267, 27)
        txtName.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1072, 584)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLoginShow As Button
    Friend WithEvents Label6 As Label

End Class
