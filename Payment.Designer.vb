<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Payment))
        PictureBox2 = New PictureBox()
        DataGridView2 = New DataGridView()
        receipt = New RichTextBox()
        btnBack = New Button()
        lblTotal = New Label()
        lblTender = New Label()
        lblChange = New Label()
        txtTender = New TextBox()
        txtTotal = New TextBox()
        txtChange = New TextBox()
        btnPay = New Button()
        btnPrint = New Button()
        btnLogOut = New Button()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Dock = DockStyle.Top
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(806, 50)
        PictureBox2.TabIndex = 20
        PictureBox2.TabStop = False
        ' 
        ' DataGridView2
        ' 
        DataGridView2.BackgroundColor = SystemColors.ActiveCaptionText
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(12, 66)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowTemplate.Height = 25
        DataGridView2.Size = New Size(476, 227)
        DataGridView2.TabIndex = 21
        ' 
        ' receipt
        ' 
        receipt.BackColor = SystemColors.ButtonFace
        receipt.Location = New Point(511, 66)
        receipt.Name = "receipt"
        receipt.Size = New Size(283, 424)
        receipt.TabIndex = 22
        receipt.Text = ""
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(12, 467)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 23)
        btnBack.TabIndex = 42
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTotal.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        lblTotal.Location = New Point(40, 319)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(121, 15)
        lblTotal.TabIndex = 43
        lblTotal.Text = "Transaction Total"
        ' 
        ' lblTender
        ' 
        lblTender.AutoSize = True
        lblTender.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTender.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        lblTender.Location = New Point(40, 353)
        lblTender.Name = "lblTender"
        lblTender.Size = New Size(120, 15)
        lblTender.TabIndex = 44
        lblTender.Text = "Customer Tender"
        ' 
        ' lblChange
        ' 
        lblChange.AutoSize = True
        lblChange.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblChange.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        lblChange.Location = New Point(40, 387)
        lblChange.Name = "lblChange"
        lblChange.Size = New Size(57, 15)
        lblChange.TabIndex = 45
        lblChange.Text = "Change"
        ' 
        ' txtTender
        ' 
        txtTender.Location = New Point(166, 350)
        txtTender.Name = "txtTender"
        txtTender.Size = New Size(100, 23)
        txtTender.TabIndex = 46
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(166, 316)
        txtTotal.Name = "txtTotal"
        txtTotal.ReadOnly = True
        txtTotal.Size = New Size(100, 23)
        txtTotal.TabIndex = 47
        ' 
        ' txtChange
        ' 
        txtChange.Location = New Point(166, 384)
        txtChange.Name = "txtChange"
        txtChange.ReadOnly = True
        txtChange.Size = New Size(100, 23)
        txtChange.TabIndex = 48
        ' 
        ' btnPay
        ' 
        btnPay.BackColor = Color.OliveDrab
        btnPay.FlatAppearance.BorderSize = 0
        btnPay.FlatStyle = FlatStyle.Popup
        btnPay.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnPay.ForeColor = Color.White
        btnPay.Location = New Point(290, 319)
        btnPay.Name = "btnPay"
        btnPay.Size = New Size(96, 91)
        btnPay.TabIndex = 49
        btnPay.Text = "PAY"
        btnPay.UseVisualStyleBackColor = False
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.Navy
        btnPrint.FlatAppearance.BorderSize = 0
        btnPrint.FlatStyle = FlatStyle.Popup
        btnPrint.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnPrint.ForeColor = Color.White
        btnPrint.Location = New Point(392, 319)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(96, 91)
        btnPrint.TabIndex = 50
        btnPrint.Text = "PRINT"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Location = New Point(719, 12)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(75, 23)
        btnLogOut.TabIndex = 51
        btnLogOut.Text = "LOGOUT"
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' Payment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FloralWhite
        ClientSize = New Size(806, 502)
        Controls.Add(btnLogOut)
        Controls.Add(btnPrint)
        Controls.Add(btnPay)
        Controls.Add(txtChange)
        Controls.Add(txtTotal)
        Controls.Add(txtTender)
        Controls.Add(lblChange)
        Controls.Add(lblTender)
        Controls.Add(lblTotal)
        Controls.Add(btnBack)
        Controls.Add(receipt)
        Controls.Add(DataGridView2)
        Controls.Add(PictureBox2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Payment"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Payment"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents receipt As RichTextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTender As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents txtTender As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtChange As TextBox
    Friend WithEvents btnPay As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnLogOut As Button
End Class
