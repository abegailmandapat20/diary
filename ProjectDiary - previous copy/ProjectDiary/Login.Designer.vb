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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.btnHamburger = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tboxUsername = New System.Windows.Forms.TextBox()
        Me.tboxPassword = New System.Windows.Forms.TextBox()
        Me.registerLink = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHamburger
        '
        Me.btnHamburger.BackColor = System.Drawing.Color.Transparent
        Me.btnHamburger.BackgroundImage = CType(resources.GetObject("btnHamburger.BackgroundImage"), System.Drawing.Image)
        Me.btnHamburger.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHamburger.FlatAppearance.BorderSize = 0
        Me.btnHamburger.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHamburger.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnHamburger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHamburger.Location = New System.Drawing.Point(33, 31)
        Me.btnHamburger.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHamburger.Name = "btnHamburger"
        Me.btnHamburger.Size = New System.Drawing.Size(36, 20)
        Me.btnHamburger.TabIndex = 6
        Me.btnHamburger.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = Global.ProjectDiary.My.Resources.Resources.Close
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(1007, 31)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(27, 25)
        Me.btnClose.TabIndex = 7
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.BackgroundImage = Global.ProjectDiary.My.Resources.Resources.Minimize
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Location = New System.Drawing.Point(967, 31)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(27, 25)
        Me.btnMinimize.TabIndex = 8
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(3, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1060, 86)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "My Day"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.ProjectDiary.My.Resources.Resources.Rectangle_3
        Me.PictureBox1.InitialImage = Global.ProjectDiary.My.Resources.Resources.Rectangle_3
        Me.PictureBox1.Location = New System.Drawing.Point(343, 148)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(381, 336)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(343, 171)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(381, 55)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Login"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tboxUsername
        '
        Me.tboxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tboxUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tboxUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.tboxUsername.Location = New System.Drawing.Point(409, 240)
        Me.tboxUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.tboxUsername.Name = "tboxUsername"
        Me.tboxUsername.Size = New System.Drawing.Size(248, 23)
        Me.tboxUsername.TabIndex = 12
        Me.tboxUsername.Text = "Username"
        '
        'tboxPassword
        '
        Me.tboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tboxPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tboxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.tboxPassword.Location = New System.Drawing.Point(409, 295)
        Me.tboxPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.tboxPassword.Name = "tboxPassword"
        Me.tboxPassword.Size = New System.Drawing.Size(248, 23)
        Me.tboxPassword.TabIndex = 13
        Me.tboxPassword.Text = "Password"
        '
        'registerLink
        '
        Me.registerLink.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.registerLink.AutoSize = True
        Me.registerLink.BackColor = System.Drawing.Color.White
        Me.registerLink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.registerLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registerLink.LinkColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.registerLink.Location = New System.Drawing.Point(476, 367)
        Me.registerLink.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.registerLink.Name = "registerLink"
        Me.registerLink.Size = New System.Drawing.Size(114, 18)
        Me.registerLink.TabIndex = 14
        Me.registerLink.TabStop = True
        Me.registerLink.Text = "Register Now!"
        Me.registerLink.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(217, Byte), Integer))
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(437, 347)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Don't have an account yet?"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.White
        Me.btnLogin.BackgroundImage = Global.ProjectDiary.My.Resources.Resources.long_button
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(409, 405)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(248, 33)
        Me.btnLogin.TabIndex = 18
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BackgroundImage = Global.ProjectDiary.My.Resources.Resources.Line
        Me.PictureBox2.InitialImage = Global.ProjectDiary.My.Resources.Resources.Line
        Me.PictureBox2.Location = New System.Drawing.Point(409, 271)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(248, 5)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.BackgroundImage = Global.ProjectDiary.My.Resources.Resources.Line
        Me.PictureBox3.InitialImage = Global.ProjectDiary.My.Resources.Resources.Line
        Me.PictureBox3.Location = New System.Drawing.Point(409, 326)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(248, 5)
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjectDiary.My.Resources.Resources.projectDiaryBG
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.registerLink)
        Me.Controls.Add(Me.tboxPassword)
        Me.Controls.Add(Me.tboxUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnHamburger)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHamburger As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tboxUsername As TextBox
    Friend WithEvents tboxPassword As TextBox
    Friend WithEvents registerLink As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
