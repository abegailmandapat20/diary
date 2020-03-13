<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.createEntry = New System.Windows.Forms.Button()
        Me.viewEntries = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.sideBtnHome = New System.Windows.Forms.Button()
        Me.sideBtnProfile = New System.Windows.Forms.Button()
        Me.sideBtnEntries = New System.Windows.Forms.Button()
        Me.sideBtnSettings = New System.Windows.Forms.Button()
        Me.sideBtnLogout = New System.Windows.Forms.Button()
        Me.btnHamburger = New System.Windows.Forms.Button()
        Me.sideBtnClose = New System.Windows.Forms.Button()
        Me.sidebar = New System.Windows.Forms.PictureBox()
        CType(Me.sidebar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'createEntry
        '
        Me.createEntry.BackColor = System.Drawing.Color.Transparent
        Me.createEntry.BackgroundImage = Global.ProjectDiary.My.Resources.Resources.big_button
        Me.createEntry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.createEntry.FlatAppearance.BorderSize = 0
        Me.createEntry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.createEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.createEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.createEntry.Font = New System.Drawing.Font("KG HAPPY Solid", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createEntry.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.createEntry.Location = New System.Drawing.Point(256, 240)
        Me.createEntry.Name = "createEntry"
        Me.createEntry.Size = New System.Drawing.Size(120, 119)
        Me.createEntry.TabIndex = 0
        Me.createEntry.Text = "Create Entry"
        Me.createEntry.UseVisualStyleBackColor = False
        '
        'viewEntries
        '
        Me.viewEntries.BackColor = System.Drawing.Color.Transparent
        Me.viewEntries.BackgroundImage = Global.ProjectDiary.My.Resources.Resources.big_button
        Me.viewEntries.Cursor = System.Windows.Forms.Cursors.Hand
        Me.viewEntries.FlatAppearance.BorderSize = 0
        Me.viewEntries.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.viewEntries.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.viewEntries.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.viewEntries.Font = New System.Drawing.Font("KG HAPPY Solid", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewEntries.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.viewEntries.Location = New System.Drawing.Point(406, 240)
        Me.viewEntries.Name = "viewEntries"
        Me.viewEntries.Size = New System.Drawing.Size(120, 119)
        Me.viewEntries.TabIndex = 1
        Me.viewEntries.Text = "View Entries"
        Me.viewEntries.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("KG HAPPY Solid", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(2, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(795, 70)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "How have you been?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_time
        '
        Me.lbl_time.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_time.BackColor = System.Drawing.Color.Transparent
        Me.lbl_time.Font = New System.Drawing.Font("KG HAPPY Solid", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_time.Location = New System.Drawing.Point(3, 79)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(795, 44)
        Me.lbl_time.TabIndex = 3
        Me.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_date
        '
        Me.lbl_date.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_date.Font = New System.Drawing.Font("KG HAPPY Solid", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_date.Location = New System.Drawing.Point(3, 58)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(795, 31)
        Me.lbl_date.TabIndex = 4
        Me.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnClose.Location = New System.Drawing.Point(755, 25)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(20, 20)
        Me.btnClose.TabIndex = 6
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
        Me.btnMinimize.Location = New System.Drawing.Point(725, 25)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(20, 20)
        Me.btnMinimize.TabIndex = 7
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'sideBtnHome
        '
        Me.sideBtnHome.BackColor = System.Drawing.Color.White
        Me.sideBtnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sideBtnHome.FlatAppearance.BorderSize = 0
        Me.sideBtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sideBtnHome.Font = New System.Drawing.Font("KG HAPPY Solid", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.sideBtnHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.sideBtnHome.Image = Global.ProjectDiary.My.Resources.Resources.home_active
        Me.sideBtnHome.Location = New System.Drawing.Point(-1, 164)
        Me.sideBtnHome.Name = "sideBtnHome"
        Me.sideBtnHome.Size = New System.Drawing.Size(200, 35)
        Me.sideBtnHome.TabIndex = 0
        Me.sideBtnHome.Text = " Home"
        Me.sideBtnHome.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.sideBtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.sideBtnHome.UseVisualStyleBackColor = False
        '
        'sideBtnProfile
        '
        Me.sideBtnProfile.BackColor = System.Drawing.Color.White
        Me.sideBtnProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sideBtnProfile.FlatAppearance.BorderSize = 0
        Me.sideBtnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sideBtnProfile.Font = New System.Drawing.Font("KG HAPPY Solid", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.sideBtnProfile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.sideBtnProfile.Image = Global.ProjectDiary.My.Resources.Resources.profile_inactive
        Me.sideBtnProfile.Location = New System.Drawing.Point(-1, 214)
        Me.sideBtnProfile.Name = "sideBtnProfile"
        Me.sideBtnProfile.Size = New System.Drawing.Size(200, 35)
        Me.sideBtnProfile.TabIndex = 1
        Me.sideBtnProfile.Text = " Profile"
        Me.sideBtnProfile.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.sideBtnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.sideBtnProfile.UseVisualStyleBackColor = False
        '
        'sideBtnEntries
        '
        Me.sideBtnEntries.BackColor = System.Drawing.Color.White
        Me.sideBtnEntries.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sideBtnEntries.FlatAppearance.BorderSize = 0
        Me.sideBtnEntries.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sideBtnEntries.Font = New System.Drawing.Font("KG HAPPY Solid", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.sideBtnEntries.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.sideBtnEntries.Image = Global.ProjectDiary.My.Resources.Resources.entries_inactive
        Me.sideBtnEntries.Location = New System.Drawing.Point(-1, 264)
        Me.sideBtnEntries.Name = "sideBtnEntries"
        Me.sideBtnEntries.Size = New System.Drawing.Size(200, 35)
        Me.sideBtnEntries.TabIndex = 2
        Me.sideBtnEntries.Text = " Entries"
        Me.sideBtnEntries.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.sideBtnEntries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.sideBtnEntries.UseVisualStyleBackColor = False
        '
        'sideBtnSettings
        '
        Me.sideBtnSettings.BackColor = System.Drawing.Color.White
        Me.sideBtnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sideBtnSettings.FlatAppearance.BorderSize = 0
        Me.sideBtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sideBtnSettings.Font = New System.Drawing.Font("KG HAPPY Solid", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.sideBtnSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.sideBtnSettings.Image = Global.ProjectDiary.My.Resources.Resources.settings_inactive
        Me.sideBtnSettings.Location = New System.Drawing.Point(-1, 314)
        Me.sideBtnSettings.Name = "sideBtnSettings"
        Me.sideBtnSettings.Size = New System.Drawing.Size(200, 35)
        Me.sideBtnSettings.TabIndex = 3
        Me.sideBtnSettings.Text = " Settings"
        Me.sideBtnSettings.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.sideBtnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.sideBtnSettings.UseVisualStyleBackColor = False
        '
        'sideBtnLogout
        '
        Me.sideBtnLogout.BackColor = System.Drawing.Color.White
        Me.sideBtnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sideBtnLogout.FlatAppearance.BorderSize = 0
        Me.sideBtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sideBtnLogout.Font = New System.Drawing.Font("KG HAPPY Solid", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.sideBtnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.sideBtnLogout.Image = Global.ProjectDiary.My.Resources.Resources.logout_inactive
        Me.sideBtnLogout.Location = New System.Drawing.Point(-1, 364)
        Me.sideBtnLogout.Name = "sideBtnLogout"
        Me.sideBtnLogout.Size = New System.Drawing.Size(200, 35)
        Me.sideBtnLogout.TabIndex = 4
        Me.sideBtnLogout.Text = " Log out"
        Me.sideBtnLogout.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.sideBtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.sideBtnLogout.UseVisualStyleBackColor = False
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
        Me.btnHamburger.ForeColor = System.Drawing.Color.White
        Me.btnHamburger.Location = New System.Drawing.Point(25, 25)
        Me.btnHamburger.Name = "btnHamburger"
        Me.btnHamburger.Size = New System.Drawing.Size(27, 16)
        Me.btnHamburger.TabIndex = 5
        Me.btnHamburger.UseVisualStyleBackColor = False
        '
        'sideBtnClose
        '
        Me.sideBtnClose.BackColor = System.Drawing.Color.White
        Me.sideBtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sideBtnClose.FlatAppearance.BorderSize = 0
        Me.sideBtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sideBtnClose.Font = New System.Drawing.Font("KG HAPPY Solid", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sideBtnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.sideBtnClose.Location = New System.Drawing.Point(164, 20)
        Me.sideBtnClose.Name = "sideBtnClose"
        Me.sideBtnClose.Size = New System.Drawing.Size(25, 25)
        Me.sideBtnClose.TabIndex = 6
        Me.sideBtnClose.Text = "X"
        Me.sideBtnClose.UseVisualStyleBackColor = False
        '
        'sidebar
        '
        Me.sidebar.BackColor = System.Drawing.Color.White
        Me.sidebar.Location = New System.Drawing.Point(0, 0)
        Me.sidebar.Name = "sidebar"
        Me.sidebar.Size = New System.Drawing.Size(200, 450)
        Me.sidebar.TabIndex = 8
        Me.sidebar.TabStop = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjectDiary.My.Resources.Resources.projectDiaryBG
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.sideBtnClose)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.sideBtnLogout)
        Me.Controls.Add(Me.sideBtnSettings)
        Me.Controls.Add(Me.sideBtnEntries)
        Me.Controls.Add(Me.sideBtnProfile)
        Me.Controls.Add(Me.viewEntries)
        Me.Controls.Add(Me.sideBtnHome)
        Me.Controls.Add(Me.createEntry)
        Me.Controls.Add(Me.sidebar)
        Me.Controls.Add(Me.lbl_time)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnHamburger)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Day"
        CType(Me.sidebar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents createEntry As Button
    Friend WithEvents viewEntries As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_time As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents sideBtnHome As Button
    Friend WithEvents sideBtnProfile As Button
    Friend WithEvents sideBtnEntries As Button
    Friend WithEvents sideBtnSettings As Button
    Friend WithEvents sideBtnLogout As Button
    Friend WithEvents btnHamburger As Button
    Friend WithEvents sideBtnClose As Button
    Friend WithEvents sidebar As PictureBox
End Class
