<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEnemy
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
        Me.components = New System.ComponentModel.Container()
        Me.ProB_Enemy = New System.Windows.Forms.ProgressBar()
        Me.ProB_Resources = New System.Windows.Forms.ProgressBar()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_UpWeapon = New System.Windows.Forms.Button()
        Me.btn_UpArmy = New System.Windows.Forms.Button()
        Me.btn_Load = New System.Windows.Forms.Button()
        Me.pb_Enemy = New System.Windows.Forms.PictureBox()
        Me.Timer_EnemyAttack = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_UpdateInterface = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_ = New System.Windows.Forms.Label()
        Me.lbl_Resources = New System.Windows.Forms.Label()
        Me.lbl_EnemyHealth = New System.Windows.Forms.Label()
        Me.lbl_EnemyStats = New System.Windows.Forms.Label()
        Me.Timer_EnemyPicture = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_ClickValueLabel = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_ClickValue = New System.Windows.Forms.Label()
        Me.lbl_YourStats = New System.Windows.Forms.Label()
        CType(Me.pb_Enemy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProB_Enemy
        '
        Me.ProB_Enemy.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ProB_Enemy.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ProB_Enemy.Location = New System.Drawing.Point(29, 27)
        Me.ProB_Enemy.Name = "ProB_Enemy"
        Me.ProB_Enemy.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProB_Enemy.Size = New System.Drawing.Size(628, 29)
        Me.ProB_Enemy.Step = 1
        Me.ProB_Enemy.TabIndex = 0
        '
        'ProB_Resources
        '
        Me.ProB_Resources.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ProB_Resources.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ProB_Resources.Location = New System.Drawing.Point(28, 382)
        Me.ProB_Resources.Name = "ProB_Resources"
        Me.ProB_Resources.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProB_Resources.Size = New System.Drawing.Size(628, 30)
        Me.ProB_Resources.Step = 1
        Me.ProB_Resources.TabIndex = 1
        '
        'btn_Save
        '
        Me.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.Location = New System.Drawing.Point(28, 461)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(225, 60)
        Me.btn_Save.TabIndex = 2
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_UpWeapon
        '
        Me.btn_UpWeapon.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_UpWeapon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_UpWeapon.Location = New System.Drawing.Point(259, 461)
        Me.btn_UpWeapon.Name = "btn_UpWeapon"
        Me.btn_UpWeapon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_UpWeapon.Size = New System.Drawing.Size(200, 122)
        Me.btn_UpWeapon.TabIndex = 3
        Me.btn_UpWeapon.Text = "Increase your Attack Damage by 1.2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Price: 100" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_UpWeapon.UseVisualStyleBackColor = True
        '
        'btn_UpArmy
        '
        Me.btn_UpArmy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_UpArmy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_UpArmy.Location = New System.Drawing.Point(456, 461)
        Me.btn_UpArmy.Name = "btn_UpArmy"
        Me.btn_UpArmy.Size = New System.Drawing.Size(200, 122)
        Me.btn_UpArmy.TabIndex = 4
        Me.btn_UpArmy.Text = "Decrease your Attack Cost by 0.1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Price: 200"
        Me.btn_UpArmy.UseVisualStyleBackColor = True
        '
        'btn_Load
        '
        Me.btn_Load.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Load.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Load.Location = New System.Drawing.Point(28, 523)
        Me.btn_Load.Name = "btn_Load"
        Me.btn_Load.Size = New System.Drawing.Size(225, 60)
        Me.btn_Load.TabIndex = 5
        Me.btn_Load.Text = "Load"
        Me.btn_Load.UseVisualStyleBackColor = True
        '
        'pb_Enemy
        '
        Me.pb_Enemy.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pb_Enemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_Enemy.Location = New System.Drawing.Point(29, 104)
        Me.pb_Enemy.Name = "pb_Enemy"
        Me.pb_Enemy.Size = New System.Drawing.Size(496, 225)
        Me.pb_Enemy.TabIndex = 6
        Me.pb_Enemy.TabStop = False
        '
        'Timer_EnemyAttack
        '
        '
        'Timer_UpdateInterface
        '
        Me.Timer_UpdateInterface.Interval = 10
        '
        'lbl_
        '
        Me.lbl_.AutoSize = True
        Me.lbl_.Location = New System.Drawing.Point(24, 326)
        Me.lbl_.Name = "lbl_"
        Me.lbl_.Size = New System.Drawing.Size(0, 13)
        Me.lbl_.TabIndex = 8
        '
        'lbl_Resources
        '
        Me.lbl_Resources.AutoSize = True
        Me.lbl_Resources.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbl_Resources.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Resources.Location = New System.Drawing.Point(28, 387)
        Me.lbl_Resources.Name = "lbl_Resources"
        Me.lbl_Resources.Size = New System.Drawing.Size(63, 20)
        Me.lbl_Resources.TabIndex = 9
        Me.lbl_Resources.Text = "Label1"
        '
        'lbl_EnemyHealth
        '
        Me.lbl_EnemyHealth.AutoSize = True
        Me.lbl_EnemyHealth.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbl_EnemyHealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EnemyHealth.Location = New System.Drawing.Point(29, 31)
        Me.lbl_EnemyHealth.Name = "lbl_EnemyHealth"
        Me.lbl_EnemyHealth.Size = New System.Drawing.Size(63, 20)
        Me.lbl_EnemyHealth.TabIndex = 10
        Me.lbl_EnemyHealth.Text = "Label1"
        '
        'lbl_EnemyStats
        '
        Me.lbl_EnemyStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EnemyStats.Location = New System.Drawing.Point(30, 104)
        Me.lbl_EnemyStats.Name = "lbl_EnemyStats"
        Me.lbl_EnemyStats.Size = New System.Drawing.Size(165, 225)
        Me.lbl_EnemyStats.TabIndex = 11
        Me.lbl_EnemyStats.Text = "Enemy Stats" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Level:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Damage:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Timer_EnemyPicture
        '
        Me.Timer_EnemyPicture.Enabled = True
        '
        'Timer_ClickValueLabel
        '
        '
        'lbl_ClickValue
        '
        Me.lbl_ClickValue.AutoSize = True
        Me.lbl_ClickValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ClickValue.ForeColor = System.Drawing.Color.White
        Me.lbl_ClickValue.Location = New System.Drawing.Point(428, 115)
        Me.lbl_ClickValue.Name = "lbl_ClickValue"
        Me.lbl_ClickValue.Size = New System.Drawing.Size(72, 24)
        Me.lbl_ClickValue.TabIndex = 12
        Me.lbl_ClickValue.Text = "Label1"
        '
        'lbl_YourStats
        '
        Me.lbl_YourStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_YourStats.Location = New System.Drawing.Point(491, 104)
        Me.lbl_YourStats.Name = "lbl_YourStats"
        Me.lbl_YourStats.Size = New System.Drawing.Size(165, 225)
        Me.lbl_YourStats.TabIndex = 13
        Me.lbl_YourStats.Text = "Your Stats" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Damage:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Attack Cost:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'FrmEnemy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BackgroundImage = Global.Clicker_Prototype_1.My.Resources.Resources.Enemy_background_Finished
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(684, 611)
        Me.Controls.Add(Me.lbl_YourStats)
        Me.Controls.Add(Me.lbl_ClickValue)
        Me.Controls.Add(Me.lbl_EnemyStats)
        Me.Controls.Add(Me.lbl_EnemyHealth)
        Me.Controls.Add(Me.lbl_Resources)
        Me.Controls.Add(Me.lbl_)
        Me.Controls.Add(Me.pb_Enemy)
        Me.Controls.Add(Me.btn_Load)
        Me.Controls.Add(Me.btn_UpArmy)
        Me.Controls.Add(Me.btn_UpWeapon)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.ProB_Resources)
        Me.Controls.Add(Me.ProB_Enemy)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmEnemy"
        Me.Text = "Enemy"
        CType(Me.pb_Enemy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProB_Enemy As ProgressBar
    Friend WithEvents ProB_Resources As ProgressBar
    Friend WithEvents btn_Save As Button
    Friend WithEvents btn_UpWeapon As Button
    Friend WithEvents btn_UpArmy As Button
    Friend WithEvents btn_Load As Button
    Friend WithEvents pb_Enemy As PictureBox
    Friend WithEvents Timer_EnemyAttack As Timer
    Friend WithEvents Timer_UpdateInterface As Timer
    Friend WithEvents lbl_ As Label
    Friend WithEvents lbl_Resources As Label
    Friend WithEvents lbl_EnemyHealth As Label
    Friend WithEvents lbl_EnemyStats As Label
    Friend WithEvents Timer_EnemyPicture As Timer
    Friend WithEvents Timer_ClickValueLabel As Timer
    Friend WithEvents lbl_ClickValue As Label
    Friend WithEvents lbl_YourStats As Label
End Class
