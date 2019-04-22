<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSettings))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_Instructions = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btn_Stats = New System.Windows.Forms.Button()
        Me.btn_Return = New System.Windows.Forms.Button()
        Me.btn_Achivements = New System.Windows.Forms.Button()
        Me.btn_Cheats = New System.Windows.Forms.Button()
        Me.lbl_Instructions = New System.Windows.Forms.Label()
        Me.lbl_Stats = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btn_CWorker = New System.Windows.Forms.Button()
        Me.btn_CHouse = New System.Windows.Forms.Button()
        Me.btn_CFarm = New System.Windows.Forms.Button()
        Me.btn_CTavern = New System.Windows.Forms.Button()
        Me.btn_CChurch = New System.Windows.Forms.Button()
        Me.btn_CCastle = New System.Windows.Forms.Button()
        Me.lbl_Cheats = New System.Windows.Forms.Label()
        Me.lbl_Achivements = New System.Windows.Forms.Label()
        Me.lBox_Achivements = New System.Windows.Forms.ListBox()
        Me.Timer_CheckIfTrue = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(23, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(0, 0)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_Instructions
        '
        Me.btn_Instructions.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Instructions.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Instructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Instructions.ForeColor = System.Drawing.Color.Black
        Me.btn_Instructions.Location = New System.Drawing.Point(23, 22)
        Me.btn_Instructions.Name = "btn_Instructions"
        Me.btn_Instructions.Size = New System.Drawing.Size(156, 82)
        Me.btn_Instructions.TabIndex = 1
        Me.btn_Instructions.Text = "Instructions"
        Me.btn_Instructions.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(23, 234)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(0, 0)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(23, 340)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(0, 0)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btn_Stats
        '
        Me.btn_Stats.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Stats.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Stats.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Stats.Location = New System.Drawing.Point(23, 104)
        Me.btn_Stats.Name = "btn_Stats"
        Me.btn_Stats.Size = New System.Drawing.Size(156, 82)
        Me.btn_Stats.TabIndex = 4
        Me.btn_Stats.Text = "Stats"
        Me.btn_Stats.UseVisualStyleBackColor = False
        '
        'btn_Return
        '
        Me.btn_Return.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Return.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Return.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Return.Location = New System.Drawing.Point(23, 350)
        Me.btn_Return.Name = "btn_Return"
        Me.btn_Return.Size = New System.Drawing.Size(156, 88)
        Me.btn_Return.TabIndex = 7
        Me.btn_Return.Text = "Return"
        Me.btn_Return.UseVisualStyleBackColor = False
        '
        'btn_Achivements
        '
        Me.btn_Achivements.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Achivements.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Achivements.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Achivements.Location = New System.Drawing.Point(23, 186)
        Me.btn_Achivements.Name = "btn_Achivements"
        Me.btn_Achivements.Size = New System.Drawing.Size(156, 82)
        Me.btn_Achivements.TabIndex = 8
        Me.btn_Achivements.Text = "Achievements"
        Me.btn_Achivements.UseVisualStyleBackColor = False
        '
        'btn_Cheats
        '
        Me.btn_Cheats.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Cheats.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Cheats.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cheats.Location = New System.Drawing.Point(23, 268)
        Me.btn_Cheats.Name = "btn_Cheats"
        Me.btn_Cheats.Size = New System.Drawing.Size(156, 82)
        Me.btn_Cheats.TabIndex = 9
        Me.btn_Cheats.Text = "Cheats"
        Me.btn_Cheats.UseVisualStyleBackColor = False
        '
        'lbl_Instructions
        '
        Me.lbl_Instructions.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_Instructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Instructions.Location = New System.Drawing.Point(229, 22)
        Me.lbl_Instructions.Name = "lbl_Instructions"
        Me.lbl_Instructions.Size = New System.Drawing.Size(231, 416)
        Me.lbl_Instructions.TabIndex = 10
        Me.lbl_Instructions.Text = resources.GetString("lbl_Instructions.Text")
        '
        'lbl_Stats
        '
        Me.lbl_Stats.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_Stats.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Stats.Location = New System.Drawing.Point(229, 22)
        Me.lbl_Stats.Name = "lbl_Stats"
        Me.lbl_Stats.Size = New System.Drawing.Size(231, 416)
        Me.lbl_Stats.TabIndex = 11
        Me.lbl_Stats.Text = resources.GetString("lbl_Stats.Text")
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(127, 189)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(0, 0)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Stats"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'btn_CWorker
        '
        Me.btn_CWorker.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_CWorker.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_CWorker.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CWorker.Location = New System.Drawing.Point(228, 49)
        Me.btn_CWorker.Name = "btn_CWorker"
        Me.btn_CWorker.Size = New System.Drawing.Size(233, 60)
        Me.btn_CWorker.TabIndex = 15
        Me.btn_CWorker.Text = "1+ Worker"
        Me.btn_CWorker.UseVisualStyleBackColor = False
        '
        'btn_CHouse
        '
        Me.btn_CHouse.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_CHouse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_CHouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CHouse.Location = New System.Drawing.Point(228, 115)
        Me.btn_CHouse.Name = "btn_CHouse"
        Me.btn_CHouse.Size = New System.Drawing.Size(233, 60)
        Me.btn_CHouse.TabIndex = 16
        Me.btn_CHouse.Text = "1+ House"
        Me.btn_CHouse.UseVisualStyleBackColor = False
        '
        'btn_CFarm
        '
        Me.btn_CFarm.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_CFarm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_CFarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CFarm.Location = New System.Drawing.Point(228, 180)
        Me.btn_CFarm.Name = "btn_CFarm"
        Me.btn_CFarm.Size = New System.Drawing.Size(233, 60)
        Me.btn_CFarm.TabIndex = 17
        Me.btn_CFarm.Text = "1+ Farm"
        Me.btn_CFarm.UseVisualStyleBackColor = False
        '
        'btn_CTavern
        '
        Me.btn_CTavern.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_CTavern.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_CTavern.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CTavern.Location = New System.Drawing.Point(228, 246)
        Me.btn_CTavern.Name = "btn_CTavern"
        Me.btn_CTavern.Size = New System.Drawing.Size(233, 60)
        Me.btn_CTavern.TabIndex = 18
        Me.btn_CTavern.Text = "1+ Tavern"
        Me.btn_CTavern.UseVisualStyleBackColor = False
        '
        'btn_CChurch
        '
        Me.btn_CChurch.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_CChurch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_CChurch.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CChurch.Location = New System.Drawing.Point(228, 312)
        Me.btn_CChurch.Name = "btn_CChurch"
        Me.btn_CChurch.Size = New System.Drawing.Size(233, 60)
        Me.btn_CChurch.TabIndex = 19
        Me.btn_CChurch.Text = "1+ Church"
        Me.btn_CChurch.UseVisualStyleBackColor = False
        '
        'btn_CCastle
        '
        Me.btn_CCastle.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_CCastle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_CCastle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CCastle.Location = New System.Drawing.Point(228, 378)
        Me.btn_CCastle.Name = "btn_CCastle"
        Me.btn_CCastle.Size = New System.Drawing.Size(233, 60)
        Me.btn_CCastle.TabIndex = 20
        Me.btn_CCastle.Text = "1+ Castle"
        Me.btn_CCastle.UseVisualStyleBackColor = False
        '
        'lbl_Cheats
        '
        Me.lbl_Cheats.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_Cheats.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cheats.Location = New System.Drawing.Point(229, 22)
        Me.lbl_Cheats.Name = "lbl_Cheats"
        Me.lbl_Cheats.Size = New System.Drawing.Size(232, 24)
        Me.lbl_Cheats.TabIndex = 21
        Me.lbl_Cheats.Text = "CHEATS:"
        '
        'lbl_Achivements
        '
        Me.lbl_Achivements.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_Achivements.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Achivements.Location = New System.Drawing.Point(229, 22)
        Me.lbl_Achivements.Name = "lbl_Achivements"
        Me.lbl_Achivements.Size = New System.Drawing.Size(232, 24)
        Me.lbl_Achivements.TabIndex = 22
        Me.lbl_Achivements.Text = "ACHIVEMENTS:"
        '
        'lBox_Achivements
        '
        Me.lBox_Achivements.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lBox_Achivements.FormattingEnabled = True
        Me.lBox_Achivements.ItemHeight = 16
        Me.lBox_Achivements.Location = New System.Drawing.Point(228, 57)
        Me.lBox_Achivements.Name = "lBox_Achivements"
        Me.lBox_Achivements.Size = New System.Drawing.Size(232, 372)
        Me.lBox_Achivements.TabIndex = 23
        '
        'Timer_CheckIfTrue
        '
        Me.Timer_CheckIfTrue.Enabled = True
        '
        'FrmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = Global.Clicker_Prototype_1.My.Resources.Resources.final_settings2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.lBox_Achivements)
        Me.Controls.Add(Me.lbl_Achivements)
        Me.Controls.Add(Me.lbl_Cheats)
        Me.Controls.Add(Me.btn_CCastle)
        Me.Controls.Add(Me.btn_CChurch)
        Me.Controls.Add(Me.btn_CTavern)
        Me.Controls.Add(Me.btn_CFarm)
        Me.Controls.Add(Me.btn_CHouse)
        Me.Controls.Add(Me.btn_CWorker)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.lbl_Stats)
        Me.Controls.Add(Me.lbl_Instructions)
        Me.Controls.Add(Me.btn_Cheats)
        Me.Controls.Add(Me.btn_Achivements)
        Me.Controls.Add(Me.btn_Return)
        Me.Controls.Add(Me.btn_Stats)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_Instructions)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.Name = "FrmSettings"
        Me.Text = "FrmSettings"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btn_Instructions As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btn_Stats As Button
    Friend WithEvents btn_Return As Button
    Friend WithEvents btn_Achivements As Button
    Friend WithEvents btn_Cheats As Button
    Friend WithEvents lbl_Instructions As Label
    Friend WithEvents lbl_Stats As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents btn_CWorker As Button
    Friend WithEvents btn_CHouse As Button
    Friend WithEvents btn_CFarm As Button
    Friend WithEvents btn_CTavern As Button
    Friend WithEvents btn_CChurch As Button
    Friend WithEvents btn_CCastle As Button
    Friend WithEvents lbl_Cheats As Label
    Friend WithEvents lbl_Achivements As Label
    Friend WithEvents lBox_Achivements As ListBox
    Friend WithEvents Timer_CheckIfTrue As Timer
End Class
