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
        Me.btngo = New System.Windows.Forms.Button()
        Me.btnstop = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblscore = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GameOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X8ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btngo2 = New System.Windows.Forms.Button()
        Me.lbltime2 = New System.Windows.Forms.Label()
        Me.btnstop2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblscore2 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btngo3 = New System.Windows.Forms.Button()
        Me.lbltime3 = New System.Windows.Forms.Label()
        Me.btnstop3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblscore3 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.lbltag = New System.Windows.Forms.Label()
        Me.lbltag2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btngo
        '
        Me.btngo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btngo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngo.Location = New System.Drawing.Point(3, 3)
        Me.btngo.Name = "btngo"
        Me.btngo.Size = New System.Drawing.Size(75, 23)
        Me.btngo.TabIndex = 0
        Me.btngo.Text = "Resume"
        Me.btngo.UseVisualStyleBackColor = True
        '
        'btnstop
        '
        Me.btnstop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnstop.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstop.Location = New System.Drawing.Point(3, 32)
        Me.btnstop.Name = "btnstop"
        Me.btnstop.Size = New System.Drawing.Size(75, 23)
        Me.btnstop.TabIndex = 1
        Me.btnstop.Text = "Pause"
        Me.btnstop.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Score:"
        '
        'lblscore
        '
        Me.lblscore.AutoSize = True
        Me.lblscore.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscore.Location = New System.Drawing.Point(50, 58)
        Me.lblscore.Name = "lblscore"
        Me.lblscore.Size = New System.Drawing.Size(13, 13)
        Me.lblscore.TabIndex = 3
        Me.lblscore.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Timer:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(190, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameOptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 405)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(487, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GameOptionsToolStripMenuItem
        '
        Me.GameOptionsToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.GameOptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitGameToolStripMenuItem, Me.GridOptionsToolStripMenuItem})
        Me.GameOptionsToolStripMenuItem.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameOptionsToolStripMenuItem.Name = "GameOptionsToolStripMenuItem"
        Me.GameOptionsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.GameOptionsToolStripMenuItem.Text = "Menu"
        '
        'QuitGameToolStripMenuItem
        '
        Me.QuitGameToolStripMenuItem.Name = "QuitGameToolStripMenuItem"
        Me.QuitGameToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.QuitGameToolStripMenuItem.Text = "Quit Game"
        '
        'GridOptionsToolStripMenuItem
        '
        Me.GridOptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.X4ToolStripMenuItem, Me.X6ToolStripMenuItem, Me.X8ToolStripMenuItem})
        Me.GridOptionsToolStripMenuItem.Name = "GridOptionsToolStripMenuItem"
        Me.GridOptionsToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.GridOptionsToolStripMenuItem.Text = "Select Grid"
        '
        'X4ToolStripMenuItem
        '
        Me.X4ToolStripMenuItem.Name = "X4ToolStripMenuItem"
        Me.X4ToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.X4ToolStripMenuItem.Text = "4 x 4"
        '
        'X6ToolStripMenuItem
        '
        Me.X6ToolStripMenuItem.Name = "X6ToolStripMenuItem"
        Me.X6ToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.X6ToolStripMenuItem.Text = "6 x 6 "
        '
        'X8ToolStripMenuItem
        '
        Me.X8ToolStripMenuItem.Name = "X8ToolStripMenuItem"
        Me.X8ToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.X8ToolStripMenuItem.Text = "8 x 8 "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lbltime)
        Me.Panel1.Controls.Add(Me.btngo)
        Me.Panel1.Controls.Add(Me.btnstop)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblscore)
        Me.Panel1.Location = New System.Drawing.Point(198, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(82, 97)
        Me.Panel1.TabIndex = 7
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.Location = New System.Drawing.Point(45, 75)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(19, 13)
        Me.lbltime.TabIndex = 6
        Me.lbltime.Text = "60"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btngo2)
        Me.Panel2.Controls.Add(Me.lbltime2)
        Me.Panel2.Controls.Add(Me.btnstop2)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.lblscore2)
        Me.Panel2.Location = New System.Drawing.Point(298, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(82, 97)
        Me.Panel2.TabIndex = 10
        '
        'btngo2
        '
        Me.btngo2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btngo2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngo2.Location = New System.Drawing.Point(3, 3)
        Me.btngo2.Name = "btngo2"
        Me.btngo2.Size = New System.Drawing.Size(75, 23)
        Me.btngo2.TabIndex = 0
        Me.btngo2.Text = "Resume"
        Me.btngo2.UseVisualStyleBackColor = True
        '
        'lbltime2
        '
        Me.lbltime2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime2.Location = New System.Drawing.Point(45, 75)
        Me.lbltime2.Name = "lbltime2"
        Me.lbltime2.Size = New System.Drawing.Size(33, 13)
        Me.lbltime2.TabIndex = 5
        Me.lbltime2.Text = "120"
        '
        'btnstop2
        '
        Me.btnstop2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnstop2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstop2.Location = New System.Drawing.Point(3, 32)
        Me.btnstop2.Name = "btnstop2"
        Me.btnstop2.Size = New System.Drawing.Size(75, 23)
        Me.btnstop2.TabIndex = 1
        Me.btnstop2.Text = "Pause"
        Me.btnstop2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Score:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Timer:"
        '
        'lblscore2
        '
        Me.lblscore2.AutoSize = True
        Me.lblscore2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscore2.Location = New System.Drawing.Point(45, 58)
        Me.lblscore2.Name = "lblscore2"
        Me.lblscore2.Size = New System.Drawing.Size(13, 13)
        Me.lblscore2.TabIndex = 3
        Me.lblscore2.Text = "0"
        '
        'Timer2
        '
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.btngo3)
        Me.Panel3.Controls.Add(Me.lbltime3)
        Me.Panel3.Controls.Add(Me.btnstop3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.lblscore3)
        Me.Panel3.Location = New System.Drawing.Point(397, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(82, 97)
        Me.Panel3.TabIndex = 11
        '
        'btngo3
        '
        Me.btngo3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btngo3.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngo3.Location = New System.Drawing.Point(3, 3)
        Me.btngo3.Name = "btngo3"
        Me.btngo3.Size = New System.Drawing.Size(75, 23)
        Me.btngo3.TabIndex = 0
        Me.btngo3.Text = "Resume"
        Me.btngo3.UseVisualStyleBackColor = True
        '
        'lbltime3
        '
        Me.lbltime3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime3.Location = New System.Drawing.Point(45, 75)
        Me.lbltime3.Name = "lbltime3"
        Me.lbltime3.Size = New System.Drawing.Size(33, 13)
        Me.lbltime3.TabIndex = 5
        Me.lbltime3.Text = "240"
        '
        'btnstop3
        '
        Me.btnstop3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnstop3.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstop3.Location = New System.Drawing.Point(3, 32)
        Me.btnstop3.Name = "btnstop3"
        Me.btnstop3.Size = New System.Drawing.Size(75, 23)
        Me.btnstop3.TabIndex = 1
        Me.btnstop3.Text = "Pause"
        Me.btnstop3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Score:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Timer:"
        '
        'lblscore3
        '
        Me.lblscore3.AutoSize = True
        Me.lblscore3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscore3.Location = New System.Drawing.Point(45, 58)
        Me.lblscore3.Name = "lblscore3"
        Me.lblscore3.Size = New System.Drawing.Size(13, 13)
        Me.lblscore3.TabIndex = 3
        Me.lblscore3.Text = "0"
        '
        'Timer3
        '
        '
        'lbltag
        '
        Me.lbltag.AutoSize = True
        Me.lbltag.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltag.Location = New System.Drawing.Point(164, 187)
        Me.lbltag.Name = "lbltag"
        Me.lbltag.Size = New System.Drawing.Size(152, 18)
        Me.lbltag.TabIndex = 12
        Me.lbltag.Text = "Tile Matching Game"
        '
        'lbltag2
        '
        Me.lbltag2.AutoSize = True
        Me.lbltag2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltag2.Location = New System.Drawing.Point(6, 387)
        Me.lbltag2.Name = "lbltag2"
        Me.lbltag2.Size = New System.Drawing.Size(56, 14)
        Me.lbltag2.TabIndex = 13
        Me.lbltag2.Text = "Play ↓ "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(487, 429)
        Me.Controls.Add(Me.lbltag2)
        Me.Controls.Add(Me.lbltag)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Tile Matching Game"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btngo As System.Windows.Forms.Button
    Friend WithEvents btnstop As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblscore As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GameOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents X4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents X6ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents X8ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btngo2 As System.Windows.Forms.Button
    Friend WithEvents lbltime2 As System.Windows.Forms.Label
    Friend WithEvents btnstop2 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblscore2 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btngo3 As System.Windows.Forms.Button
    Friend WithEvents lbltime3 As System.Windows.Forms.Label
    Friend WithEvents btnstop3 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblscore3 As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents lbltag As System.Windows.Forms.Label
    Friend WithEvents lbltag2 As System.Windows.Forms.Label

End Class
