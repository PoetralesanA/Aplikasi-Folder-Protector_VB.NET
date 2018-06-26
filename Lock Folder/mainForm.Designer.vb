<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cRt_Folder = New System.Windows.Forms.Button()
        Me.findFile = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.RichTextBox()
        Me.status = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SecurityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoftwareVersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KelEnder = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LoadingProgress = New System.Windows.Forms.Timer(Me.components)
        Me.BrowseFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(8, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 61)
        Me.Button1.TabIndex = 0
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Location = New System.Drawing.Point(9, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 61)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = " "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(129, 23)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(236, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "C:\Locker Folder"
        '
        'cRt_Folder
        '
        Me.cRt_Folder.Location = New System.Drawing.Point(11, 15)
        Me.cRt_Folder.Name = "cRt_Folder"
        Me.cRt_Folder.Size = New System.Drawing.Size(103, 37)
        Me.cRt_Folder.TabIndex = 4
        Me.cRt_Folder.Text = "Created Folder"
        Me.cRt_Folder.UseVisualStyleBackColor = True
        '
        'findFile
        '
        Me.findFile.Location = New System.Drawing.Point(11, 15)
        Me.findFile.Name = "findFile"
        Me.findFile.Size = New System.Drawing.Size(103, 37)
        Me.findFile.TabIndex = 5
        Me.findFile.Text = "Browse File"
        Me.findFile.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.cRt_Folder)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 67)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Protect Folder ( Default )"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(129, 44)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(80, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Set Menual"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.status)
        Me.GroupBox2.Controls.Add(Me.findFile)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(377, 67)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Browse Folder To Protect / Unprotect"
        '
        'TextBox2
        '
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(129, 23)
        Me.TextBox2.MaxLength = 0
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(236, 21)
        Me.TextBox2.TabIndex = 16
        Me.TextBox2.Text = ""
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.Location = New System.Drawing.Point(168, 54)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(70, 13)
        Me.status.TabIndex = 15
        Me.status.Text = "Status Pesan"
        Me.status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListBox1
        '
        Me.ListBox1.ForeColor = System.Drawing.Color.ForestGreen
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.Location = New System.Drawing.Point(10, 19)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBox1.Size = New System.Drawing.Size(181, 95)
        Me.ListBox1.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 174)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 127)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Log"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(215, 279)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(170, 21)
        Me.ProgressBar1.TabIndex = 10
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SecurityToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(396, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SecurityToolStripMenuItem
        '
        Me.SecurityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem, Me.ClearLogToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.SecurityToolStripMenuItem.Name = "SecurityToolStripMenuItem"
        Me.SecurityToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SecurityToolStripMenuItem.Text = "Security"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Image = CType(resources.GetObject("ChangePasswordToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'ClearLogToolStripMenuItem
        '
        Me.ClearLogToolStripMenuItem.Image = CType(resources.GetObject("ClearLogToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClearLogToolStripMenuItem.Name = "ClearLogToolStripMenuItem"
        Me.ClearLogToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ClearLogToolStripMenuItem.Text = "Clear Log"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CoderToolStripMenuItem, Me.SoftwareVersionToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'CoderToolStripMenuItem
        '
        Me.CoderToolStripMenuItem.Image = CType(resources.GetObject("CoderToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CoderToolStripMenuItem.Name = "CoderToolStripMenuItem"
        Me.CoderToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.CoderToolStripMenuItem.Text = "Coder"
        '
        'SoftwareVersionToolStripMenuItem
        '
        Me.SoftwareVersionToolStripMenuItem.Image = CType(resources.GetObject("SoftwareVersionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SoftwareVersionToolStripMenuItem.Name = "SoftwareVersionToolStripMenuItem"
        Me.SoftwareVersionToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SoftwareVersionToolStripMenuItem.Text = "Software Version"
        '
        'KelEnder
        '
        Me.KelEnder.Enabled = False
        Me.KelEnder.Location = New System.Drawing.Point(179, -1)
        Me.KelEnder.Name = "KelEnder"
        Me.KelEnder.Size = New System.Drawing.Size(217, 20)
        Me.KelEnder.TabIndex = 12
        Me.KelEnder.Value = New Date(2018, 6, 14, 5, 40, 0, 0)
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Location = New System.Drawing.Point(215, 185)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(79, 88)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Lock Folder"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Location = New System.Drawing.Point(297, 185)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(88, 88)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Unlock Folder"
        '
        'LoadingProgress
        '
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 305)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.KelEnder)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "mainForm"
        Me.Opacity = 0.97R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Folder Protector"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cRt_Folder As System.Windows.Forms.Button
    Friend WithEvents findFile As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SecurityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SoftwareVersionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CoderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KelEnder As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents LoadingProgress As System.Windows.Forms.Timer
    Friend WithEvents BrowseFolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents status As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ClearLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
