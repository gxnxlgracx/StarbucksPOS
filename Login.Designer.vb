<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Login))
        Label1 = New Label()
        txtUser = New TextBox()
        txtPass = New TextBox()
        btnEnter = New Button()
        Label2 = New Label()
        logoStarbs = New PictureBox()
        btnSign = New LinkLabel()
        Label3 = New Label()
        Label4 = New Label()
        CType(logoStarbs, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.LemonChiffon
        Label1.Location = New Point(166, 192)
        Label1.Name = "Label1"
        Label1.Size = New Size(270, 32)
        Label1.TabIndex = 0
        Label1.Text = "HELLO, WELCOME!"
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(213, 245)
        txtUser.Name = "txtUser"
        txtUser.PlaceholderText = "Username"
        txtUser.Size = New Size(172, 23)
        txtUser.TabIndex = 1
        ' 
        ' txtPass
        ' 
        txtPass.Font = New Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtPass.Location = New Point(213, 284)
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "•"c
        txtPass.PlaceholderText = "Password"
        txtPass.Size = New Size(172, 20)
        txtPass.TabIndex = 2
        ' 
        ' btnEnter
        ' 
        btnEnter.BackColor = Color.FloralWhite
        btnEnter.FlatAppearance.BorderSize = 0
        btnEnter.FlatStyle = FlatStyle.Popup
        btnEnter.Font = New Font("Arial Rounded MT Bold", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnEnter.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        btnEnter.Location = New Point(213, 319)
        btnEnter.Name = "btnEnter"
        btnEnter.Size = New Size(172, 27)
        btnEnter.TabIndex = 3
        btnEnter.Text = "LOGIN"
        btnEnter.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Italic, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlLight
        Label2.Location = New Point(139, 157)
        Label2.Name = "Label2"
        Label2.Size = New Size(316, 17)
        Label2.TabIndex = 4
        Label2.Text = """Stressed, blessed, and coffee obsessed."""
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' logoStarbs
        ' 
        logoStarbs.BackColor = Color.Transparent
        logoStarbs.BackgroundImage = CType(resources.GetObject("logoStarbs.BackgroundImage"), Image)
        logoStarbs.BackgroundImageLayout = ImageLayout.Zoom
        logoStarbs.Location = New Point(163, 12)
        logoStarbs.Name = "logoStarbs"
        logoStarbs.Size = New Size(273, 128)
        logoStarbs.TabIndex = 6
        logoStarbs.TabStop = False
        ' 
        ' btnSign
        ' 
        btnSign.AutoSize = True
        btnSign.BackColor = Color.Transparent
        btnSign.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnSign.LinkColor = Color.PaleGreen
        btnSign.Location = New Point(292, 395)
        btnSign.Name = "btnSign"
        btnSign.Size = New Size(109, 15)
        btnSign.TabIndex = 7
        btnSign.TabStop = True
        btnSign.Text = "Create Account"
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
        Label3.TabIndex = 8
        Label3.Text = "created by: Amihan"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial Rounded MT Bold", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.FloralWhite
        Label4.Location = New Point(197, 395)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 14)
        Label4.TabIndex = 9
        Label4.Text = "Not a member?"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(599, 419)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btnSign)
        Controls.Add(logoStarbs)
        Controls.Add(Label2)
        Controls.Add(btnEnter)
        Controls.Add(txtPass)
        Controls.Add(txtUser)
        Controls.Add(Label1)
        DoubleBuffered = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Starbucks"
        CType(logoStarbs, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents logoStarbs As PictureBox
    Friend WithEvents btnSign As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
