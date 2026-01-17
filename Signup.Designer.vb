<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signup
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Signup))
        logoStarbs = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        btnLogin = New LinkLabel()
        btnEnter = New Button()
        txtPass = New TextBox()
        txtUser = New TextBox()
        Label3 = New Label()
        CType(logoStarbs, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' logoStarbs
        ' 
        logoStarbs.BackColor = Color.Transparent
        logoStarbs.BackgroundImage = CType(resources.GetObject("logoStarbs.BackgroundImage"), Image)
        logoStarbs.BackgroundImageLayout = ImageLayout.Zoom
        logoStarbs.Location = New Point(243, 30)
        logoStarbs.Name = "logoStarbs"
        logoStarbs.Size = New Size(273, 128)
        logoStarbs.TabIndex = 9
        logoStarbs.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlLight
        Label2.Location = New Point(219, 175)
        Label2.Name = "Label2"
        Label2.Size = New Size(316, 17)
        Label2.TabIndex = 8
        Label2.Text = """Stressed, blessed, and coffee obsessed."""
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.LemonChiffon
        Label1.Location = New Point(260, 210)
        Label1.Name = "Label1"
        Label1.Size = New Size(235, 32)
        Label1.TabIndex = 7
        Label1.Text = "JOIN US TODAY!"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.FloralWhite
        Label4.Location = New Point(260, 411)
        Label4.Name = "Label4"
        Label4.Size = New Size(122, 14)
        Label4.TabIndex = 14
        Label4.Text = "Already a member?"
        ' 
        ' btnLogin
        ' 
        btnLogin.AutoSize = True
        btnLogin.BackColor = Color.Transparent
        btnLogin.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogin.LinkColor = Color.PaleGreen
        btnLogin.Location = New Point(384, 410)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(78, 15)
        btnLogin.TabIndex = 13
        btnLogin.TabStop = True
        btnLogin.Text = "Login Here"
        ' 
        ' btnEnter
        ' 
        btnEnter.BackColor = Color.FloralWhite
        btnEnter.FlatAppearance.BorderSize = 0
        btnEnter.FlatStyle = FlatStyle.Popup
        btnEnter.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnEnter.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        btnEnter.Location = New Point(291, 340)
        btnEnter.Name = "btnEnter"
        btnEnter.Size = New Size(172, 27)
        btnEnter.TabIndex = 12
        btnEnter.Text = "SIGN UP"
        btnEnter.UseVisualStyleBackColor = False
        ' 
        ' txtPass
        ' 
        txtPass.Font = New Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtPass.Location = New Point(291, 305)
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "•"c
        txtPass.PlaceholderText = "Password"
        txtPass.Size = New Size(172, 20)
        txtPass.TabIndex = 11
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(291, 266)
        txtUser.Name = "txtUser"
        txtUser.PlaceholderText = "Username"
        txtUser.Size = New Size(172, 23)
        txtUser.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial Rounded MT Bold", 8.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.Info
        Label3.Location = New Point(12, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 12)
        Label3.TabIndex = 15
        Label3.Text = "created by: Amihan"
        ' 
        ' Signup
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(586, 438)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(btnLogin)
        Controls.Add(btnEnter)
        Controls.Add(txtPass)
        Controls.Add(txtUser)
        Controls.Add(logoStarbs)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Signup"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Starbucks (Create Account)"
        CType(logoStarbs, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents logoStarbs As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLogin As LinkLabel
    Friend WithEvents btnEnter As Button
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label3 As Label
End Class
