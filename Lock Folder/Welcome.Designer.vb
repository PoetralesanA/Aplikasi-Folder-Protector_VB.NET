<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Welcome))
        Me.btN_SetPwd = New System.Windows.Forms.Button()
        Me.PwD = New System.Windows.Forms.TextBox()
        Me.ValPwd = New System.Windows.Forms.TextBox()
        Me.LcN = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btN_visiT = New System.Windows.Forms.Button()
        Me.Cbx = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btN_SetPwd
        '
        Me.btN_SetPwd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btN_SetPwd.Location = New System.Drawing.Point(18, 282)
        Me.btN_SetPwd.Name = "btN_SetPwd"
        Me.btN_SetPwd.Size = New System.Drawing.Size(334, 38)
        Me.btN_SetPwd.TabIndex = 2
        Me.btN_SetPwd.TabStop = False
        Me.btN_SetPwd.Text = "Set Password"
        Me.btN_SetPwd.UseVisualStyleBackColor = True
        '
        'PwD
        '
        Me.PwD.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PwD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PwD.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PwD.Location = New System.Drawing.Point(39, 209)
        Me.PwD.Name = "PwD"
        Me.PwD.Size = New System.Drawing.Size(293, 17)
        Me.PwD.TabIndex = 0
        Me.PwD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ValPwd
        '
        Me.ValPwd.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ValPwd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ValPwd.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValPwd.Location = New System.Drawing.Point(39, 252)
        Me.ValPwd.Name = "ValPwd"
        Me.ValPwd.Size = New System.Drawing.Size(293, 17)
        Me.ValPwd.TabIndex = 1
        Me.ValPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LcN
        '
        Me.LcN.BackColor = System.Drawing.Color.Gainsboro
        Me.LcN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LcN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.LcN.ForeColor = System.Drawing.Color.Black
        Me.LcN.Location = New System.Drawing.Point(12, 12)
        Me.LcN.Multiline = True
        Me.LcN.Name = "LcN"
        Me.LcN.ReadOnly = True
        Me.LcN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LcN.Size = New System.Drawing.Size(340, 169)
        Me.LcN.TabIndex = 3
        Me.LcN.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Location = New System.Drawing.Point(25, 239)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 1)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Typewriter", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 327)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "© PoetralesanA [ C.S.D Team ]"
        '
        'btN_visiT
        '
        Me.btN_visiT.BackgroundImage = CType(resources.GetObject("btN_visiT.BackgroundImage"), System.Drawing.Image)
        Me.btN_visiT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btN_visiT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btN_visiT.FlatAppearance.BorderSize = 0
        Me.btN_visiT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btN_visiT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btN_visiT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btN_visiT.Location = New System.Drawing.Point(69, 322)
        Me.btN_visiT.Name = "btN_visiT"
        Me.btN_visiT.Size = New System.Drawing.Size(19, 19)
        Me.btN_visiT.TabIndex = 6
        Me.btN_visiT.TabStop = False
        Me.btN_visiT.UseVisualStyleBackColor = True
        '
        'Cbx
        '
        Me.Cbx.AutoSize = True
        Me.Cbx.Location = New System.Drawing.Point(12, 187)
        Me.Cbx.Name = "Cbx"
        Me.Cbx.Size = New System.Drawing.Size(130, 17)
        Me.Cbx.TabIndex = 7
        Me.Cbx.Text = "Iya, Aku Mengerti beb"
        Me.Cbx.UseVisualStyleBackColor = True
        '
        'Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(370, 347)
        Me.Controls.Add(Me.Cbx)
        Me.Controls.Add(Me.btN_visiT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LcN)
        Me.Controls.Add(Me.ValPwd)
        Me.Controls.Add(Me.PwD)
        Me.Controls.Add(Me.btN_SetPwd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Welcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btN_SetPwd As System.Windows.Forms.Button
    Friend WithEvents PwD As System.Windows.Forms.TextBox
    Friend WithEvents ValPwd As System.Windows.Forms.TextBox
    Friend WithEvents LcN As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btN_visiT As System.Windows.Forms.Button
    Friend WithEvents Cbx As System.Windows.Forms.CheckBox
End Class
