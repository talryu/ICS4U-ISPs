<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Parentform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Parentform))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.scorelabel = New System.Windows.Forms.Label()
        Me.levelshow = New System.Windows.Forms.Label()
        Me.dead = New System.Windows.Forms.Label()
        Me.shot5 = New System.Windows.Forms.Label()
        Me.shot4 = New System.Windows.Forms.Label()
        Me.shot3 = New System.Windows.Forms.Label()
        Me.shot2 = New System.Windows.Forms.Label()
        Me.shot1 = New System.Windows.Forms.Label()
        Me.Restartshot = New System.Windows.Forms.Label()
        Me.Alien9 = New System.Windows.Forms.PictureBox()
        Me.Alien10 = New System.Windows.Forms.PictureBox()
        Me.Alien11 = New System.Windows.Forms.PictureBox()
        Me.Alien12 = New System.Windows.Forms.PictureBox()
        Me.Alien2 = New System.Windows.Forms.PictureBox()
        Me.Alien3 = New System.Windows.Forms.PictureBox()
        Me.Alien4 = New System.Windows.Forms.PictureBox()
        Me.Alien5 = New System.Windows.Forms.PictureBox()
        Me.Alien6 = New System.Windows.Forms.PictureBox()
        Me.Alien7 = New System.Windows.Forms.PictureBox()
        Me.Alien8 = New System.Windows.Forms.PictureBox()
        Me.Alien1 = New System.Windows.Forms.PictureBox()
        Me.Spaceship = New System.Windows.Forms.PictureBox()
        Me.Move = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Alien9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Spaceship, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(267, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(588, 66)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Space Invaders"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("OCR A Extended", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(515, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 56)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Start Game"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(515, 265)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 56)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Quit Game"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(503, 365)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(689, 243)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(116, 88)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(833, 139)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(116, 88)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(253, 306)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(116, 88)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(105, 151)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(116, 88)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 8
        Me.PictureBox5.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.scorelabel)
        Me.Panel1.Controls.Add(Me.levelshow)
        Me.Panel1.Controls.Add(Me.dead)
        Me.Panel1.Controls.Add(Me.shot5)
        Me.Panel1.Controls.Add(Me.shot4)
        Me.Panel1.Controls.Add(Me.shot3)
        Me.Panel1.Controls.Add(Me.shot2)
        Me.Panel1.Controls.Add(Me.shot1)
        Me.Panel1.Controls.Add(Me.Restartshot)
        Me.Panel1.Controls.Add(Me.Alien9)
        Me.Panel1.Controls.Add(Me.Alien10)
        Me.Panel1.Controls.Add(Me.Alien11)
        Me.Panel1.Controls.Add(Me.Alien12)
        Me.Panel1.Controls.Add(Me.Alien2)
        Me.Panel1.Controls.Add(Me.Alien3)
        Me.Panel1.Controls.Add(Me.Alien4)
        Me.Panel1.Controls.Add(Me.Alien5)
        Me.Panel1.Controls.Add(Me.Alien6)
        Me.Panel1.Controls.Add(Me.Alien7)
        Me.Panel1.Controls.Add(Me.Alien8)
        Me.Panel1.Controls.Add(Me.Alien1)
        Me.Panel1.Controls.Add(Me.Spaceship)
        Me.Panel1.Location = New System.Drawing.Point(6, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1057, 645)
        Me.Panel1.TabIndex = 9
        Me.Panel1.Visible = False
        '
        'scorelabel
        '
        Me.scorelabel.AutoSize = True
        Me.scorelabel.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scorelabel.ForeColor = System.Drawing.Color.White
        Me.scorelabel.Location = New System.Drawing.Point(967, 18)
        Me.scorelabel.Name = "scorelabel"
        Me.scorelabel.Size = New System.Drawing.Size(81, 18)
        Me.scorelabel.TabIndex = 23
        Me.scorelabel.Text = "SCORE: 0"
        '
        'levelshow
        '
        Me.levelshow.AutoSize = True
        Me.levelshow.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.levelshow.ForeColor = System.Drawing.Color.White
        Me.levelshow.Location = New System.Drawing.Point(961, 0)
        Me.levelshow.Name = "levelshow"
        Me.levelshow.Size = New System.Drawing.Size(87, 18)
        Me.levelshow.TabIndex = 22
        Me.levelshow.Text = "LEVEL: 1"
        '
        'dead
        '
        Me.dead.AutoSize = True
        Me.dead.Font = New System.Drawing.Font("Modern No. 20", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dead.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dead.Location = New System.Drawing.Point(407, 154)
        Me.dead.Name = "dead"
        Me.dead.Size = New System.Drawing.Size(300, 65)
        Me.dead.TabIndex = 21
        Me.dead.Text = "You Died!"
        Me.dead.Visible = False
        '
        'shot5
        '
        Me.shot5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.shot5.Location = New System.Drawing.Point(546, 527)
        Me.shot5.Name = "shot5"
        Me.shot5.Size = New System.Drawing.Size(5, 20)
        Me.shot5.TabIndex = 20
        Me.shot5.Visible = False
        '
        'shot4
        '
        Me.shot4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.shot4.Location = New System.Drawing.Point(546, 527)
        Me.shot4.Name = "shot4"
        Me.shot4.Size = New System.Drawing.Size(5, 20)
        Me.shot4.TabIndex = 19
        Me.shot4.Visible = False
        '
        'shot3
        '
        Me.shot3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.shot3.Location = New System.Drawing.Point(546, 527)
        Me.shot3.Name = "shot3"
        Me.shot3.Size = New System.Drawing.Size(5, 20)
        Me.shot3.TabIndex = 18
        Me.shot3.Visible = False
        '
        'shot2
        '
        Me.shot2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.shot2.Location = New System.Drawing.Point(546, 527)
        Me.shot2.Name = "shot2"
        Me.shot2.Size = New System.Drawing.Size(5, 20)
        Me.shot2.TabIndex = 17
        Me.shot2.Visible = False
        '
        'shot1
        '
        Me.shot1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.shot1.Location = New System.Drawing.Point(546, 527)
        Me.shot1.Name = "shot1"
        Me.shot1.Size = New System.Drawing.Size(5, 20)
        Me.shot1.TabIndex = 16
        Me.shot1.Visible = False
        '
        'Restartshot
        '
        Me.Restartshot.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Restartshot.Location = New System.Drawing.Point(546, 527)
        Me.Restartshot.Name = "Restartshot"
        Me.Restartshot.Size = New System.Drawing.Size(5, 20)
        Me.Restartshot.TabIndex = 15
        Me.Restartshot.Visible = False
        '
        'Alien9
        '
        Me.Alien9.Image = CType(resources.GetObject("Alien9.Image"), System.Drawing.Image)
        Me.Alien9.Location = New System.Drawing.Point(295, 96)
        Me.Alien9.Name = "Alien9"
        Me.Alien9.Size = New System.Drawing.Size(106, 85)
        Me.Alien9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien9.TabIndex = 14
        Me.Alien9.TabStop = False
        '
        'Alien10
        '
        Me.Alien10.Image = CType(resources.GetObject("Alien10.Image"), System.Drawing.Image)
        Me.Alien10.Location = New System.Drawing.Point(440, 96)
        Me.Alien10.Name = "Alien10"
        Me.Alien10.Size = New System.Drawing.Size(106, 85)
        Me.Alien10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien10.TabIndex = 13
        Me.Alien10.TabStop = False
        '
        'Alien11
        '
        Me.Alien11.Image = CType(resources.GetObject("Alien11.Image"), System.Drawing.Image)
        Me.Alien11.Location = New System.Drawing.Point(585, 96)
        Me.Alien11.Name = "Alien11"
        Me.Alien11.Size = New System.Drawing.Size(106, 85)
        Me.Alien11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien11.TabIndex = 12
        Me.Alien11.TabStop = False
        '
        'Alien12
        '
        Me.Alien12.Image = CType(resources.GetObject("Alien12.Image"), System.Drawing.Image)
        Me.Alien12.Location = New System.Drawing.Point(730, 96)
        Me.Alien12.Name = "Alien12"
        Me.Alien12.Size = New System.Drawing.Size(106, 85)
        Me.Alien12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien12.TabIndex = 11
        Me.Alien12.TabStop = False
        '
        'Alien2
        '
        Me.Alien2.Image = CType(resources.GetObject("Alien2.Image"), System.Drawing.Image)
        Me.Alien2.Location = New System.Drawing.Point(150, 5)
        Me.Alien2.Name = "Alien2"
        Me.Alien2.Size = New System.Drawing.Size(106, 85)
        Me.Alien2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien2.TabIndex = 8
        Me.Alien2.TabStop = False
        '
        'Alien3
        '
        Me.Alien3.Image = CType(resources.GetObject("Alien3.Image"), System.Drawing.Image)
        Me.Alien3.Location = New System.Drawing.Point(295, 5)
        Me.Alien3.Name = "Alien3"
        Me.Alien3.Size = New System.Drawing.Size(106, 85)
        Me.Alien3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien3.TabIndex = 7
        Me.Alien3.TabStop = False
        '
        'Alien4
        '
        Me.Alien4.Image = CType(resources.GetObject("Alien4.Image"), System.Drawing.Image)
        Me.Alien4.Location = New System.Drawing.Point(440, 5)
        Me.Alien4.Name = "Alien4"
        Me.Alien4.Size = New System.Drawing.Size(106, 85)
        Me.Alien4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien4.TabIndex = 6
        Me.Alien4.TabStop = False
        '
        'Alien5
        '
        Me.Alien5.Image = CType(resources.GetObject("Alien5.Image"), System.Drawing.Image)
        Me.Alien5.Location = New System.Drawing.Point(585, 5)
        Me.Alien5.Name = "Alien5"
        Me.Alien5.Size = New System.Drawing.Size(106, 85)
        Me.Alien5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien5.TabIndex = 5
        Me.Alien5.TabStop = False
        '
        'Alien6
        '
        Me.Alien6.Image = CType(resources.GetObject("Alien6.Image"), System.Drawing.Image)
        Me.Alien6.Location = New System.Drawing.Point(730, 5)
        Me.Alien6.Name = "Alien6"
        Me.Alien6.Size = New System.Drawing.Size(106, 85)
        Me.Alien6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien6.TabIndex = 4
        Me.Alien6.TabStop = False
        '
        'Alien7
        '
        Me.Alien7.Image = CType(resources.GetObject("Alien7.Image"), System.Drawing.Image)
        Me.Alien7.Location = New System.Drawing.Point(10, 96)
        Me.Alien7.Name = "Alien7"
        Me.Alien7.Size = New System.Drawing.Size(106, 85)
        Me.Alien7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien7.TabIndex = 3
        Me.Alien7.TabStop = False
        '
        'Alien8
        '
        Me.Alien8.Image = CType(resources.GetObject("Alien8.Image"), System.Drawing.Image)
        Me.Alien8.Location = New System.Drawing.Point(150, 96)
        Me.Alien8.Name = "Alien8"
        Me.Alien8.Size = New System.Drawing.Size(106, 85)
        Me.Alien8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien8.TabIndex = 2
        Me.Alien8.TabStop = False
        '
        'Alien1
        '
        Me.Alien1.Image = CType(resources.GetObject("Alien1.Image"), System.Drawing.Image)
        Me.Alien1.Location = New System.Drawing.Point(10, 5)
        Me.Alien1.Name = "Alien1"
        Me.Alien1.Size = New System.Drawing.Size(106, 85)
        Me.Alien1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien1.TabIndex = 1
        Me.Alien1.TabStop = False
        '
        'Spaceship
        '
        Me.Spaceship.Image = CType(resources.GetObject("Spaceship.Image"), System.Drawing.Image)
        Me.Spaceship.Location = New System.Drawing.Point(478, 495)
        Me.Spaceship.Name = "Spaceship"
        Me.Spaceship.Size = New System.Drawing.Size(139, 139)
        Me.Spaceship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Spaceship.TabIndex = 0
        Me.Spaceship.TabStop = False
        '
        'Move
        '
        Me.Move.Interval = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("OCR A Extended", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(372, 522)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(370, 87)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Press ""A"" to go left " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press ""D"" to go right" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press ""L"" to shoot"
        '
        'Parentform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1069, 667)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.KeyPreview = True
        Me.Name = "Parentform"
        Me.Text = "Space Invaders"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Alien9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Spaceship, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Spaceship As System.Windows.Forms.PictureBox
    Friend WithEvents Move As System.Windows.Forms.Timer
    Friend WithEvents Alien9 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien10 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien11 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien12 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien2 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien3 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien4 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien5 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien6 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien7 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien8 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien1 As System.Windows.Forms.PictureBox
    Friend WithEvents shot5 As System.Windows.Forms.Label
    Friend WithEvents shot4 As System.Windows.Forms.Label
    Friend WithEvents shot3 As System.Windows.Forms.Label
    Friend WithEvents shot2 As System.Windows.Forms.Label
    Friend WithEvents shot1 As System.Windows.Forms.Label
    Friend WithEvents Restartshot As System.Windows.Forms.Label
    Friend WithEvents dead As System.Windows.Forms.Label
    Friend WithEvents levelshow As System.Windows.Forms.Label
    Friend WithEvents scorelabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
