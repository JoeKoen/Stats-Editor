<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MoveL = New System.Windows.Forms.Label()
        Me.RangeL = New System.Windows.Forms.Label()
        Me.AttackL = New System.Windows.Forms.Label()
        Me.DefenseL = New System.Windows.Forms.Label()
        Me.biotxt = New System.Windows.Forms.RichTextBox()
        Me.lstxtL1 = New System.Windows.Forms.Label()
        Me.lstxtL2 = New System.Windows.Forms.Label()
        Me.lstxtL3 = New System.Windows.Forms.Label()
        Me.lstxtL4 = New System.Windows.Forms.Label()
        Me.lstxtL5 = New System.Windows.Forms.Label()
        Me.TopHeaderL = New System.Windows.Forms.Label()
        Me.bottomtopheaderL = New System.Windows.Forms.Label()
        Me.LifeL = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BackGroundChanger = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LightBlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoldToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LifePlus = New System.Windows.Forms.Button()
        Me.LifeMinus = New System.Windows.Forms.Button()
        Me.MovePlus = New System.Windows.Forms.Button()
        Me.MoveMinus = New System.Windows.Forms.Button()
        Me.RangePlus = New System.Windows.Forms.Button()
        Me.RangeMinus = New System.Windows.Forms.Button()
        Me.AttackPlus = New System.Windows.Forms.Button()
        Me.AttackMinus = New System.Windows.Forms.Button()
        Me.DefensePlus = New System.Windows.Forms.Button()
        Me.DefenseMinus = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.topheadertxt = New System.Windows.Forms.TextBox()
        Me.bottomtopheadertxt = New System.Windows.Forms.TextBox()
        Me.lstxt1 = New System.Windows.Forms.TextBox()
        Me.lstxt2 = New System.Windows.Forms.TextBox()
        Me.lstxt3 = New System.Windows.Forms.TextBox()
        Me.lstxt4 = New System.Windows.Forms.TextBox()
        Me.lstxt5 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BackGroundChanger.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(226, 597)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "New Window"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MoveL
        '
        Me.MoveL.BackColor = System.Drawing.Color.Transparent
        Me.MoveL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoveL.ForeColor = System.Drawing.Color.White
        Me.MoveL.Location = New System.Drawing.Point(548, 411)
        Me.MoveL.Name = "MoveL"
        Me.MoveL.Size = New System.Drawing.Size(30, 20)
        Me.MoveL.TabIndex = 2
        Me.MoveL.Text = "0"
        Me.MoveL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RangeL
        '
        Me.RangeL.BackColor = System.Drawing.Color.Transparent
        Me.RangeL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RangeL.ForeColor = System.Drawing.Color.White
        Me.RangeL.Location = New System.Drawing.Point(548, 460)
        Me.RangeL.Name = "RangeL"
        Me.RangeL.Size = New System.Drawing.Size(30, 20)
        Me.RangeL.TabIndex = 2
        Me.RangeL.Text = "0"
        Me.RangeL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AttackL
        '
        Me.AttackL.BackColor = System.Drawing.Color.Transparent
        Me.AttackL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttackL.ForeColor = System.Drawing.Color.White
        Me.AttackL.Location = New System.Drawing.Point(547, 506)
        Me.AttackL.Name = "AttackL"
        Me.AttackL.Size = New System.Drawing.Size(30, 20)
        Me.AttackL.TabIndex = 2
        Me.AttackL.Text = "0"
        Me.AttackL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DefenseL
        '
        Me.DefenseL.BackColor = System.Drawing.Color.Transparent
        Me.DefenseL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefenseL.ForeColor = System.Drawing.Color.White
        Me.DefenseL.Location = New System.Drawing.Point(547, 555)
        Me.DefenseL.Name = "DefenseL"
        Me.DefenseL.Size = New System.Drawing.Size(30, 20)
        Me.DefenseL.TabIndex = 2
        Me.DefenseL.Text = "0"
        Me.DefenseL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'biotxt
        '
        Me.biotxt.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.biotxt.Location = New System.Drawing.Point(185, 187)
        Me.biotxt.Name = "biotxt"
        Me.biotxt.ReadOnly = True
        Me.biotxt.Size = New System.Drawing.Size(176, 404)
        Me.biotxt.TabIndex = 3
        Me.biotxt.Text = "You will be able to write your own text here!"
        '
        'lstxtL1
        '
        Me.lstxtL1.BackColor = System.Drawing.Color.Transparent
        Me.lstxtL1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lstxtL1.ForeColor = System.Drawing.Color.White
        Me.lstxtL1.Location = New System.Drawing.Point(93, 299)
        Me.lstxtL1.Name = "lstxtL1"
        Me.lstxtL1.Size = New System.Drawing.Size(77, 13)
        Me.lstxtL1.TabIndex = 4
        Me.lstxtL1.Text = "Edit Me"
        Me.lstxtL1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lstxtL2
        '
        Me.lstxtL2.BackColor = System.Drawing.Color.Transparent
        Me.lstxtL2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lstxtL2.ForeColor = System.Drawing.Color.White
        Me.lstxtL2.Location = New System.Drawing.Point(65, 325)
        Me.lstxtL2.Name = "lstxtL2"
        Me.lstxtL2.Size = New System.Drawing.Size(105, 13)
        Me.lstxtL2.TabIndex = 4
        Me.lstxtL2.Text = "Edit Me"
        Me.lstxtL2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lstxtL3
        '
        Me.lstxtL3.BackColor = System.Drawing.Color.Transparent
        Me.lstxtL3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lstxtL3.ForeColor = System.Drawing.Color.White
        Me.lstxtL3.Location = New System.Drawing.Point(54, 349)
        Me.lstxtL3.Name = "lstxtL3"
        Me.lstxtL3.Size = New System.Drawing.Size(116, 13)
        Me.lstxtL3.TabIndex = 4
        Me.lstxtL3.Text = "Edit Me"
        Me.lstxtL3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lstxtL4
        '
        Me.lstxtL4.BackColor = System.Drawing.Color.Transparent
        Me.lstxtL4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lstxtL4.ForeColor = System.Drawing.Color.White
        Me.lstxtL4.Location = New System.Drawing.Point(55, 375)
        Me.lstxtL4.Name = "lstxtL4"
        Me.lstxtL4.Size = New System.Drawing.Size(115, 13)
        Me.lstxtL4.TabIndex = 4
        Me.lstxtL4.Text = "Edit Me"
        Me.lstxtL4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lstxtL5
        '
        Me.lstxtL5.BackColor = System.Drawing.Color.Transparent
        Me.lstxtL5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lstxtL5.ForeColor = System.Drawing.Color.White
        Me.lstxtL5.Location = New System.Drawing.Point(54, 399)
        Me.lstxtL5.Name = "lstxtL5"
        Me.lstxtL5.Size = New System.Drawing.Size(116, 32)
        Me.lstxtL5.TabIndex = 4
        Me.lstxtL5.Text = "Edit Me"
        Me.lstxtL5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TopHeaderL
        '
        Me.TopHeaderL.BackColor = System.Drawing.Color.Transparent
        Me.TopHeaderL.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.TopHeaderL.ForeColor = System.Drawing.Color.White
        Me.TopHeaderL.Location = New System.Drawing.Point(184, 112)
        Me.TopHeaderL.Name = "TopHeaderL"
        Me.TopHeaderL.Size = New System.Drawing.Size(171, 52)
        Me.TopHeaderL.TabIndex = 4
        Me.TopHeaderL.Text = "Edit Me"
        Me.TopHeaderL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bottomtopheaderL
        '
        Me.bottomtopheaderL.BackColor = System.Drawing.Color.Transparent
        Me.bottomtopheaderL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.bottomtopheaderL.ForeColor = System.Drawing.Color.White
        Me.bottomtopheaderL.Location = New System.Drawing.Point(182, 161)
        Me.bottomtopheaderL.Name = "bottomtopheaderL"
        Me.bottomtopheaderL.Size = New System.Drawing.Size(173, 20)
        Me.bottomtopheaderL.TabIndex = 4
        Me.bottomtopheaderL.Text = "Edit Me"
        Me.bottomtopheaderL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LifeL
        '
        Me.LifeL.BackColor = System.Drawing.Color.Transparent
        Me.LifeL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LifeL.ForeColor = System.Drawing.Color.White
        Me.LifeL.Location = New System.Drawing.Point(492, 359)
        Me.LifeL.Name = "LifeL"
        Me.LifeL.Size = New System.Drawing.Size(30, 20)
        Me.LifeL.TabIndex = 2
        Me.LifeL.Text = "0"
        Me.LifeL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(483, 379)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 20)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "LIFE"
        '
        'BackGroundChanger
        '
        Me.BackGroundChanger.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LightBlueToolStripMenuItem, Me.BlueToolStripMenuItem, Me.BrownToolStripMenuItem, Me.GoldToolStripMenuItem, Me.GreenToolStripMenuItem, Me.RedToolStripMenuItem})
        Me.BackGroundChanger.Name = "BackGroundChanger"
        Me.BackGroundChanger.Size = New System.Drawing.Size(128, 136)
        '
        'LightBlueToolStripMenuItem
        '
        Me.LightBlueToolStripMenuItem.Name = "LightBlueToolStripMenuItem"
        Me.LightBlueToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.LightBlueToolStripMenuItem.Text = "Light Blue"
        '
        'BlueToolStripMenuItem
        '
        Me.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        Me.BlueToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.BlueToolStripMenuItem.Text = "Blue"
        '
        'BrownToolStripMenuItem
        '
        Me.BrownToolStripMenuItem.Name = "BrownToolStripMenuItem"
        Me.BrownToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.BrownToolStripMenuItem.Text = "Brown"
        '
        'GoldToolStripMenuItem
        '
        Me.GoldToolStripMenuItem.Name = "GoldToolStripMenuItem"
        Me.GoldToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.GoldToolStripMenuItem.Text = "Gold"
        '
        'GreenToolStripMenuItem
        '
        Me.GreenToolStripMenuItem.Name = "GreenToolStripMenuItem"
        Me.GreenToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.GreenToolStripMenuItem.Text = "Green"
        '
        'RedToolStripMenuItem
        '
        Me.RedToolStripMenuItem.Name = "RedToolStripMenuItem"
        Me.RedToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.RedToolStripMenuItem.Text = "Red"
        '
        'LifePlus
        '
        Me.LifePlus.Location = New System.Drawing.Point(472, 356)
        Me.LifePlus.Name = "LifePlus"
        Me.LifePlus.Size = New System.Drawing.Size(18, 23)
        Me.LifePlus.TabIndex = 5
        Me.LifePlus.Text = "+"
        Me.LifePlus.UseVisualStyleBackColor = True
        Me.LifePlus.Visible = False
        '
        'LifeMinus
        '
        Me.LifeMinus.Location = New System.Drawing.Point(521, 356)
        Me.LifeMinus.Name = "LifeMinus"
        Me.LifeMinus.Size = New System.Drawing.Size(18, 23)
        Me.LifeMinus.TabIndex = 6
        Me.LifeMinus.Text = "-"
        Me.LifeMinus.UseVisualStyleBackColor = True
        Me.LifeMinus.Visible = False
        '
        'MovePlus
        '
        Me.MovePlus.Location = New System.Drawing.Point(529, 408)
        Me.MovePlus.Name = "MovePlus"
        Me.MovePlus.Size = New System.Drawing.Size(18, 23)
        Me.MovePlus.TabIndex = 5
        Me.MovePlus.Text = "+"
        Me.MovePlus.UseVisualStyleBackColor = True
        Me.MovePlus.Visible = False
        '
        'MoveMinus
        '
        Me.MoveMinus.Location = New System.Drawing.Point(578, 408)
        Me.MoveMinus.Name = "MoveMinus"
        Me.MoveMinus.Size = New System.Drawing.Size(18, 23)
        Me.MoveMinus.TabIndex = 6
        Me.MoveMinus.Text = "-"
        Me.MoveMinus.UseVisualStyleBackColor = True
        Me.MoveMinus.Visible = False
        '
        'RangePlus
        '
        Me.RangePlus.Location = New System.Drawing.Point(529, 457)
        Me.RangePlus.Name = "RangePlus"
        Me.RangePlus.Size = New System.Drawing.Size(18, 23)
        Me.RangePlus.TabIndex = 5
        Me.RangePlus.Text = "+"
        Me.RangePlus.UseVisualStyleBackColor = True
        Me.RangePlus.Visible = False
        '
        'RangeMinus
        '
        Me.RangeMinus.Location = New System.Drawing.Point(578, 457)
        Me.RangeMinus.Name = "RangeMinus"
        Me.RangeMinus.Size = New System.Drawing.Size(18, 23)
        Me.RangeMinus.TabIndex = 6
        Me.RangeMinus.Text = "-"
        Me.RangeMinus.UseVisualStyleBackColor = True
        Me.RangeMinus.Visible = False
        '
        'AttackPlus
        '
        Me.AttackPlus.Location = New System.Drawing.Point(529, 506)
        Me.AttackPlus.Name = "AttackPlus"
        Me.AttackPlus.Size = New System.Drawing.Size(18, 23)
        Me.AttackPlus.TabIndex = 5
        Me.AttackPlus.Text = "+"
        Me.AttackPlus.UseVisualStyleBackColor = True
        Me.AttackPlus.Visible = False
        '
        'AttackMinus
        '
        Me.AttackMinus.Location = New System.Drawing.Point(578, 506)
        Me.AttackMinus.Name = "AttackMinus"
        Me.AttackMinus.Size = New System.Drawing.Size(18, 23)
        Me.AttackMinus.TabIndex = 6
        Me.AttackMinus.Text = "-"
        Me.AttackMinus.UseVisualStyleBackColor = True
        Me.AttackMinus.Visible = False
        '
        'DefensePlus
        '
        Me.DefensePlus.Location = New System.Drawing.Point(529, 555)
        Me.DefensePlus.Name = "DefensePlus"
        Me.DefensePlus.Size = New System.Drawing.Size(18, 23)
        Me.DefensePlus.TabIndex = 5
        Me.DefensePlus.Text = "+"
        Me.DefensePlus.UseVisualStyleBackColor = True
        Me.DefensePlus.Visible = False
        '
        'DefenseMinus
        '
        Me.DefenseMinus.Location = New System.Drawing.Point(578, 555)
        Me.DefenseMinus.Name = "DefenseMinus"
        Me.DefenseMinus.Size = New System.Drawing.Size(18, 23)
        Me.DefenseMinus.TabIndex = 6
        Me.DefenseMinus.Text = "-"
        Me.DefenseMinus.UseVisualStyleBackColor = True
        Me.DefenseMinus.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(219, 626)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Help"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'topheadertxt
        '
        Me.topheadertxt.Location = New System.Drawing.Point(185, 90)
        Me.topheadertxt.Name = "topheadertxt"
        Me.topheadertxt.Size = New System.Drawing.Size(170, 20)
        Me.topheadertxt.TabIndex = 8
        Me.topheadertxt.Visible = False
        '
        'bottomtopheadertxt
        '
        Me.bottomtopheadertxt.Location = New System.Drawing.Point(185, 132)
        Me.bottomtopheadertxt.Name = "bottomtopheadertxt"
        Me.bottomtopheadertxt.Size = New System.Drawing.Size(170, 20)
        Me.bottomtopheadertxt.TabIndex = 9
        Me.bottomtopheadertxt.Visible = False
        '
        'lstxt1
        '
        Me.lstxt1.Location = New System.Drawing.Point(70, 270)
        Me.lstxt1.Name = "lstxt1"
        Me.lstxt1.Size = New System.Drawing.Size(100, 20)
        Me.lstxt1.TabIndex = 10
        Me.lstxt1.Visible = False
        '
        'lstxt2
        '
        Me.lstxt2.Location = New System.Drawing.Point(70, 296)
        Me.lstxt2.Name = "lstxt2"
        Me.lstxt2.Size = New System.Drawing.Size(100, 20)
        Me.lstxt2.TabIndex = 10
        Me.lstxt2.Visible = False
        '
        'lstxt3
        '
        Me.lstxt3.Location = New System.Drawing.Point(70, 320)
        Me.lstxt3.Name = "lstxt3"
        Me.lstxt3.Size = New System.Drawing.Size(100, 20)
        Me.lstxt3.TabIndex = 10
        Me.lstxt3.Visible = False
        '
        'lstxt4
        '
        Me.lstxt4.Location = New System.Drawing.Point(70, 346)
        Me.lstxt4.Name = "lstxt4"
        Me.lstxt4.Size = New System.Drawing.Size(100, 20)
        Me.lstxt4.TabIndex = 10
        Me.lstxt4.Visible = False
        '
        'lstxt5
        '
        Me.lstxt5.Location = New System.Drawing.Point(70, 370)
        Me.lstxt5.Name = "lstxt5"
        Me.lstxt5.Size = New System.Drawing.Size(100, 20)
        Me.lstxt5.TabIndex = 10
        Me.lstxt5.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(189, 597)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(31, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "[X]"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.BackgroundImage = Global.Stats_Editor.My.Resources.Resources.airborneelite_CustomImg_blue
        Me.ClientSize = New System.Drawing.Size(780, 727)
        Me.ContextMenuStrip = Me.BackGroundChanger
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lstxt5)
        Me.Controls.Add(Me.lstxt4)
        Me.Controls.Add(Me.lstxt3)
        Me.Controls.Add(Me.lstxt2)
        Me.Controls.Add(Me.lstxt1)
        Me.Controls.Add(Me.bottomtopheadertxt)
        Me.Controls.Add(Me.topheadertxt)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DefenseMinus)
        Me.Controls.Add(Me.AttackMinus)
        Me.Controls.Add(Me.RangeMinus)
        Me.Controls.Add(Me.MoveMinus)
        Me.Controls.Add(Me.DefensePlus)
        Me.Controls.Add(Me.AttackPlus)
        Me.Controls.Add(Me.RangePlus)
        Me.Controls.Add(Me.MovePlus)
        Me.Controls.Add(Me.LifeMinus)
        Me.Controls.Add(Me.LifePlus)
        Me.Controls.Add(Me.bottomtopheaderL)
        Me.Controls.Add(Me.TopHeaderL)
        Me.Controls.Add(Me.lstxtL5)
        Me.Controls.Add(Me.lstxtL4)
        Me.Controls.Add(Me.lstxtL3)
        Me.Controls.Add(Me.lstxtL2)
        Me.Controls.Add(Me.lstxtL1)
        Me.Controls.Add(Me.biotxt)
        Me.Controls.Add(Me.DefenseL)
        Me.Controls.Add(Me.AttackL)
        Me.Controls.Add(Me.RangeL)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LifeL)
        Me.Controls.Add(Me.MoveL)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stats Editor"
        Me.TransparencyKey = System.Drawing.Color.Lime
        Me.BackGroundChanger.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MoveL As System.Windows.Forms.Label
    Friend WithEvents RangeL As System.Windows.Forms.Label
    Friend WithEvents AttackL As System.Windows.Forms.Label
    Friend WithEvents DefenseL As System.Windows.Forms.Label
    Friend WithEvents biotxt As System.Windows.Forms.RichTextBox
    Friend WithEvents lstxtL1 As System.Windows.Forms.Label
    Friend WithEvents lstxtL2 As System.Windows.Forms.Label
    Friend WithEvents lstxtL3 As System.Windows.Forms.Label
    Friend WithEvents lstxtL4 As System.Windows.Forms.Label
    Friend WithEvents lstxtL5 As System.Windows.Forms.Label
    Friend WithEvents TopHeaderL As System.Windows.Forms.Label
    Friend WithEvents bottomtopheaderL As System.Windows.Forms.Label
    Friend WithEvents LifeL As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BackGroundChanger As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LightBlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoldToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LifePlus As System.Windows.Forms.Button
    Friend WithEvents LifeMinus As System.Windows.Forms.Button
    Friend WithEvents MovePlus As System.Windows.Forms.Button
    Friend WithEvents MoveMinus As System.Windows.Forms.Button
    Friend WithEvents RangePlus As System.Windows.Forms.Button
    Friend WithEvents RangeMinus As System.Windows.Forms.Button
    Friend WithEvents AttackPlus As System.Windows.Forms.Button
    Friend WithEvents AttackMinus As System.Windows.Forms.Button
    Friend WithEvents DefensePlus As System.Windows.Forms.Button
    Friend WithEvents DefenseMinus As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents topheadertxt As System.Windows.Forms.TextBox
    Friend WithEvents bottomtopheadertxt As System.Windows.Forms.TextBox
    Friend WithEvents lstxt1 As System.Windows.Forms.TextBox
    Friend WithEvents lstxt2 As System.Windows.Forms.TextBox
    Friend WithEvents lstxt3 As System.Windows.Forms.TextBox
    Friend WithEvents lstxt4 As System.Windows.Forms.TextBox
    Friend WithEvents lstxt5 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
