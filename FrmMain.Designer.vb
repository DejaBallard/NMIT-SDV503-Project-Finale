<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.lbl_PerSecond = New System.Windows.Forms.Label()
        Me.Pb_Resources = New System.Windows.Forms.PictureBox()
        Me.txt_Cheat = New System.Windows.Forms.TextBox()
        Me.lbl_Resources = New System.Windows.Forms.Label()
        Me.btn_Upgrades = New System.Windows.Forms.Button()
        Me.btn_Options = New System.Windows.Forms.Button()
        Me.btn_BuyHouse = New System.Windows.Forms.Button()
        Me.btn_BuyChurch = New System.Windows.Forms.Button()
        Me.btn_BuyFarm = New System.Windows.Forms.Button()
        Me.btn_BuyTavern = New System.Windows.Forms.Button()
        Me.btn_BuyWorker = New System.Windows.Forms.Button()
        Me.btn_BuyCastle = New System.Windows.Forms.Button()
        Me.Timer_UpdateInterface = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_TitlePage = New System.Windows.Forms.Label()
        Me.Timer_PerSecond = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_ItemsTitle = New System.Windows.Forms.Label()
        Me.btn_UpWorker = New System.Windows.Forms.Button()
        Me.btn_UpHouse = New System.Windows.Forms.Button()
        Me.btn_UpFarm = New System.Windows.Forms.Button()
        Me.btn_UpTavern = New System.Windows.Forms.Button()
        Me.btn_UpChurch = New System.Windows.Forms.Button()
        Me.btn_UpClick = New System.Windows.Forms.Button()
        Me.btn_Store = New System.Windows.Forms.Button()
        Me.lbl_ClickValue = New System.Windows.Forms.Label()
        Me.Timer_ClickValueLabel = New System.Windows.Forms.Timer(Me.components)
        Me.btn_Cheats = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_Load = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbl_CountDown = New System.Windows.Forms.Label()
        Me.Timer_CountDown = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_StopTimers = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_CheckIfTrue = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Pb_Resources, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_PerSecond
        '
        Me.lbl_PerSecond.AutoSize = True
        Me.lbl_PerSecond.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PerSecond.Location = New System.Drawing.Point(24, 349)
        Me.lbl_PerSecond.Name = "lbl_PerSecond"
        Me.lbl_PerSecond.Size = New System.Drawing.Size(124, 25)
        Me.lbl_PerSecond.TabIndex = 0
        Me.lbl_PerSecond.Text = "PerSecond:"
        '
        'Pb_Resources
        '
        Me.Pb_Resources.BackColor = System.Drawing.Color.Transparent
        Me.Pb_Resources.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pb_Resources.Image = Global.Clicker_Prototype_1.My.Resources.Resources.Resorces
        Me.Pb_Resources.Location = New System.Drawing.Point(24, 77)
        Me.Pb_Resources.Name = "Pb_Resources"
        Me.Pb_Resources.Size = New System.Drawing.Size(231, 226)
        Me.Pb_Resources.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pb_Resources.TabIndex = 1
        Me.Pb_Resources.TabStop = False
        '
        'txt_Cheat
        '
        Me.txt_Cheat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Cheat.Location = New System.Drawing.Point(24, 301)
        Me.txt_Cheat.Name = "txt_Cheat"
        Me.txt_Cheat.Size = New System.Drawing.Size(152, 20)
        Me.txt_Cheat.TabIndex = 2
        '
        'lbl_Resources
        '
        Me.lbl_Resources.AutoSize = True
        Me.lbl_Resources.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Resources.Location = New System.Drawing.Point(24, 322)
        Me.lbl_Resources.Name = "lbl_Resources"
        Me.lbl_Resources.Size = New System.Drawing.Size(121, 25)
        Me.lbl_Resources.TabIndex = 3
        Me.lbl_Resources.Text = "Resources:"
        '
        'btn_Upgrades
        '
        Me.btn_Upgrades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Upgrades.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Upgrades.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Upgrades.Location = New System.Drawing.Point(24, 423)
        Me.btn_Upgrades.Name = "btn_Upgrades"
        Me.btn_Upgrades.Size = New System.Drawing.Size(174, 78)
        Me.btn_Upgrades.TabIndex = 5
        Me.btn_Upgrades.Text = "Upgrades"
        Me.btn_Upgrades.UseVisualStyleBackColor = True
        '
        'btn_Options
        '
        Me.btn_Options.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Options.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Options.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Options.Image = CType(resources.GetObject("btn_Options.Image"), System.Drawing.Image)
        Me.btn_Options.Location = New System.Drawing.Point(24, 502)
        Me.btn_Options.Name = "btn_Options"
        Me.btn_Options.Size = New System.Drawing.Size(86, 85)
        Me.btn_Options.TabIndex = 6
        Me.btn_Options.UseVisualStyleBackColor = True
        '
        'btn_BuyHouse
        '
        Me.btn_BuyHouse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_BuyHouse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_BuyHouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_BuyHouse.Image = Global.Clicker_Prototype_1.My.Resources.Resources.final_House1
        Me.btn_BuyHouse.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_BuyHouse.Location = New System.Drawing.Point(295, 467)
        Me.btn_BuyHouse.Name = "btn_BuyHouse"
        Me.btn_BuyHouse.Size = New System.Drawing.Size(83, 120)
        Me.btn_BuyHouse.TabIndex = 7
        Me.btn_BuyHouse.Text = "House:"
        Me.btn_BuyHouse.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_BuyHouse.UseVisualStyleBackColor = True
        '
        'btn_BuyChurch
        '
        Me.btn_BuyChurch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_BuyChurch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_BuyChurch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_BuyChurch.Image = Global.Clicker_Prototype_1.My.Resources.Resources.Final_Church1
        Me.btn_BuyChurch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_BuyChurch.Location = New System.Drawing.Point(544, 467)
        Me.btn_BuyChurch.Name = "btn_BuyChurch"
        Me.btn_BuyChurch.Size = New System.Drawing.Size(83, 120)
        Me.btn_BuyChurch.TabIndex = 8
        Me.btn_BuyChurch.Text = "Church:"
        Me.btn_BuyChurch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_BuyChurch.UseVisualStyleBackColor = True
        '
        'btn_BuyFarm
        '
        Me.btn_BuyFarm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_BuyFarm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_BuyFarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_BuyFarm.Image = Global.Clicker_Prototype_1.My.Resources.Resources.Final_Farm1
        Me.btn_BuyFarm.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_BuyFarm.Location = New System.Drawing.Point(378, 467)
        Me.btn_BuyFarm.Name = "btn_BuyFarm"
        Me.btn_BuyFarm.Size = New System.Drawing.Size(83, 120)
        Me.btn_BuyFarm.TabIndex = 9
        Me.btn_BuyFarm.Text = "Farm:"
        Me.btn_BuyFarm.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_BuyFarm.UseVisualStyleBackColor = True
        '
        'btn_BuyTavern
        '
        Me.btn_BuyTavern.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_BuyTavern.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_BuyTavern.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_BuyTavern.Image = Global.Clicker_Prototype_1.My.Resources.Resources.final_tavern1
        Me.btn_BuyTavern.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_BuyTavern.Location = New System.Drawing.Point(461, 467)
        Me.btn_BuyTavern.Name = "btn_BuyTavern"
        Me.btn_BuyTavern.Size = New System.Drawing.Size(83, 120)
        Me.btn_BuyTavern.TabIndex = 10
        Me.btn_BuyTavern.Text = "Tavern:"
        Me.btn_BuyTavern.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_BuyTavern.UseVisualStyleBackColor = True
        '
        'btn_BuyWorker
        '
        Me.btn_BuyWorker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_BuyWorker.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_BuyWorker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_BuyWorker.Image = Global.Clicker_Prototype_1.My.Resources.Resources.final_worker
        Me.btn_BuyWorker.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_BuyWorker.Location = New System.Drawing.Point(212, 467)
        Me.btn_BuyWorker.Name = "btn_BuyWorker"
        Me.btn_BuyWorker.Size = New System.Drawing.Size(83, 120)
        Me.btn_BuyWorker.TabIndex = 11
        Me.btn_BuyWorker.Text = "Worker:"
        Me.btn_BuyWorker.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_BuyWorker.UseVisualStyleBackColor = True
        '
        'btn_BuyCastle
        '
        Me.btn_BuyCastle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_BuyCastle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_BuyCastle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_BuyCastle.Image = Global.Clicker_Prototype_1.My.Resources.Resources.final_Castle
        Me.btn_BuyCastle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_BuyCastle.Location = New System.Drawing.Point(627, 467)
        Me.btn_BuyCastle.Name = "btn_BuyCastle"
        Me.btn_BuyCastle.Size = New System.Drawing.Size(83, 120)
        Me.btn_BuyCastle.TabIndex = 12
        Me.btn_BuyCastle.Text = "Castle:"
        Me.btn_BuyCastle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_BuyCastle.UseVisualStyleBackColor = True
        '
        'Timer_UpdateInterface
        '
        Me.Timer_UpdateInterface.Enabled = True
        Me.Timer_UpdateInterface.Interval = 1
        '
        'lbl_TitlePage
        '
        Me.lbl_TitlePage.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TitlePage.Location = New System.Drawing.Point(15, 10)
        Me.lbl_TitlePage.Name = "lbl_TitlePage"
        Me.lbl_TitlePage.Size = New System.Drawing.Size(705, 31)
        Me.lbl_TitlePage.TabIndex = 13
        Me.lbl_TitlePage.Text = "The Kingdom"
        Me.lbl_TitlePage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer_PerSecond
        '
        Me.Timer_PerSecond.Enabled = True
        Me.Timer_PerSecond.Interval = 1000
        '
        'lbl_ItemsTitle
        '
        Me.lbl_ItemsTitle.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_ItemsTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ItemsTitle.Location = New System.Drawing.Point(212, 422)
        Me.lbl_ItemsTitle.Name = "lbl_ItemsTitle"
        Me.lbl_ItemsTitle.Size = New System.Drawing.Size(498, 42)
        Me.lbl_ItemsTitle.TabIndex = 14
        Me.lbl_ItemsTitle.Text = "Store"
        Me.lbl_ItemsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_UpWorker
        '
        Me.btn_UpWorker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_UpWorker.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_UpWorker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_UpWorker.Image = Global.Clicker_Prototype_1.My.Resources.Resources.final_worker
        Me.btn_UpWorker.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_UpWorker.Location = New System.Drawing.Point(295, 467)
        Me.btn_UpWorker.Name = "btn_UpWorker"
        Me.btn_UpWorker.Size = New System.Drawing.Size(83, 120)
        Me.btn_UpWorker.TabIndex = 15
        Me.btn_UpWorker.Text = "Worker:"
        Me.btn_UpWorker.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_UpWorker.UseVisualStyleBackColor = True
        Me.btn_UpWorker.Visible = False
        '
        'btn_UpHouse
        '
        Me.btn_UpHouse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_UpHouse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_UpHouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_UpHouse.Image = Global.Clicker_Prototype_1.My.Resources.Resources.final_House1
        Me.btn_UpHouse.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_UpHouse.Location = New System.Drawing.Point(378, 467)
        Me.btn_UpHouse.Name = "btn_UpHouse"
        Me.btn_UpHouse.Size = New System.Drawing.Size(83, 120)
        Me.btn_UpHouse.TabIndex = 16
        Me.btn_UpHouse.Text = "House:"
        Me.btn_UpHouse.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_UpHouse.UseVisualStyleBackColor = True
        Me.btn_UpHouse.Visible = False
        '
        'btn_UpFarm
        '
        Me.btn_UpFarm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_UpFarm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_UpFarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_UpFarm.Image = Global.Clicker_Prototype_1.My.Resources.Resources.Final_Farm1
        Me.btn_UpFarm.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_UpFarm.Location = New System.Drawing.Point(461, 467)
        Me.btn_UpFarm.Name = "btn_UpFarm"
        Me.btn_UpFarm.Size = New System.Drawing.Size(83, 120)
        Me.btn_UpFarm.TabIndex = 17
        Me.btn_UpFarm.Text = "Farm:"
        Me.btn_UpFarm.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_UpFarm.UseVisualStyleBackColor = True
        Me.btn_UpFarm.Visible = False
        '
        'btn_UpTavern
        '
        Me.btn_UpTavern.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_UpTavern.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_UpTavern.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_UpTavern.Image = Global.Clicker_Prototype_1.My.Resources.Resources.final_tavern1
        Me.btn_UpTavern.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_UpTavern.Location = New System.Drawing.Point(544, 467)
        Me.btn_UpTavern.Name = "btn_UpTavern"
        Me.btn_UpTavern.Size = New System.Drawing.Size(83, 120)
        Me.btn_UpTavern.TabIndex = 18
        Me.btn_UpTavern.Text = "Tavern:"
        Me.btn_UpTavern.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_UpTavern.UseVisualStyleBackColor = True
        Me.btn_UpTavern.Visible = False
        '
        'btn_UpChurch
        '
        Me.btn_UpChurch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_UpChurch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_UpChurch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_UpChurch.Image = Global.Clicker_Prototype_1.My.Resources.Resources.Final_Church1
        Me.btn_UpChurch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_UpChurch.Location = New System.Drawing.Point(627, 467)
        Me.btn_UpChurch.Name = "btn_UpChurch"
        Me.btn_UpChurch.Size = New System.Drawing.Size(83, 120)
        Me.btn_UpChurch.TabIndex = 19
        Me.btn_UpChurch.Text = "Church:"
        Me.btn_UpChurch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_UpChurch.UseVisualStyleBackColor = True
        Me.btn_UpChurch.Visible = False
        '
        'btn_UpClick
        '
        Me.btn_UpClick.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_UpClick.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_UpClick.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_UpClick.Image = Global.Clicker_Prototype_1.My.Resources.Resources.Final_clicker
        Me.btn_UpClick.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_UpClick.Location = New System.Drawing.Point(212, 467)
        Me.btn_UpClick.Name = "btn_UpClick"
        Me.btn_UpClick.Size = New System.Drawing.Size(83, 120)
        Me.btn_UpClick.TabIndex = 20
        Me.btn_UpClick.Text = "Clicker: "
        Me.btn_UpClick.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip.SetToolTip(Me.btn_UpClick, "Mouse Upgrade" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btn_UpClick.UseVisualStyleBackColor = True
        Me.btn_UpClick.Visible = False
        '
        'btn_Store
        '
        Me.btn_Store.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Store.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Store.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Store.Location = New System.Drawing.Point(24, 423)
        Me.btn_Store.Name = "btn_Store"
        Me.btn_Store.Size = New System.Drawing.Size(174, 78)
        Me.btn_Store.TabIndex = 21
        Me.btn_Store.Text = "Store"
        Me.btn_Store.UseVisualStyleBackColor = True
        Me.btn_Store.Visible = False
        '
        'lbl_ClickValue
        '
        Me.lbl_ClickValue.AutoSize = True
        Me.lbl_ClickValue.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ClickValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ClickValue.ForeColor = System.Drawing.Color.White
        Me.lbl_ClickValue.Location = New System.Drawing.Point(242, 331)
        Me.lbl_ClickValue.Name = "lbl_ClickValue"
        Me.lbl_ClickValue.Size = New System.Drawing.Size(0, 29)
        Me.lbl_ClickValue.TabIndex = 22
        '
        'Timer_ClickValueLabel
        '
        Me.Timer_ClickValueLabel.Interval = 10
        '
        'btn_Cheats
        '
        Me.btn_Cheats.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Cheats.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Cheats.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cheats.Location = New System.Drawing.Point(175, 301)
        Me.btn_Cheats.Name = "btn_Cheats"
        Me.btn_Cheats.Size = New System.Drawing.Size(80, 20)
        Me.btn_Cheats.TabIndex = 23
        Me.btn_Cheats.Text = "Enter"
        Me.btn_Cheats.UseVisualStyleBackColor = False
        '
        'btn_Save
        '
        Me.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.Location = New System.Drawing.Point(112, 502)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(86, 42)
        Me.btn_Save.TabIndex = 24
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_Load
        '
        Me.btn_Load.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Load.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Load.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Load.Location = New System.Drawing.Point(112, 545)
        Me.btn_Load.Name = "btn_Load"
        Me.btn_Load.Size = New System.Drawing.Size(86, 42)
        Me.btn_Load.TabIndex = 25
        Me.btn_Load.Text = "Load"
        Me.btn_Load.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(21, 303)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 16)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Label1"
        '
        'lbl_CountDown
        '
        Me.lbl_CountDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CountDown.Location = New System.Drawing.Point(304, 322)
        Me.lbl_CountDown.Name = "lbl_CountDown"
        Me.lbl_CountDown.Size = New System.Drawing.Size(406, 52)
        Me.lbl_CountDown.TabIndex = 27
        Me.lbl_CountDown.Text = "Time Till Arrival"
        Me.lbl_CountDown.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer_CountDown
        '
        '
        'Timer_StopTimers
        '
        '
        'Timer_CheckIfTrue
        '
        Me.Timer_CheckIfTrue.Enabled = True
        Me.Timer_CheckIfTrue.Interval = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(304, 77)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(406, 242)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BackgroundImage = Global.Clicker_Prototype_1.My.Resources.Resources.Background_Finished
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(734, 611)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_CountDown)
        Me.Controls.Add(Me.btn_Load)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.btn_Cheats)
        Me.Controls.Add(Me.lbl_ClickValue)
        Me.Controls.Add(Me.btn_Store)
        Me.Controls.Add(Me.btn_UpClick)
        Me.Controls.Add(Me.btn_UpChurch)
        Me.Controls.Add(Me.btn_UpTavern)
        Me.Controls.Add(Me.btn_UpFarm)
        Me.Controls.Add(Me.btn_UpHouse)
        Me.Controls.Add(Me.btn_UpWorker)
        Me.Controls.Add(Me.lbl_ItemsTitle)
        Me.Controls.Add(Me.lbl_TitlePage)
        Me.Controls.Add(Me.btn_BuyCastle)
        Me.Controls.Add(Me.btn_BuyWorker)
        Me.Controls.Add(Me.btn_BuyTavern)
        Me.Controls.Add(Me.btn_BuyFarm)
        Me.Controls.Add(Me.btn_BuyChurch)
        Me.Controls.Add(Me.btn_BuyHouse)
        Me.Controls.Add(Me.btn_Options)
        Me.Controls.Add(Me.btn_Upgrades)
        Me.Controls.Add(Me.txt_Cheat)
        Me.Controls.Add(Me.Pb_Resources)
        Me.Controls.Add(Me.lbl_Resources)
        Me.Controls.Add(Me.lbl_PerSecond)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMain"
        Me.Text = "FOR THE KING"
        CType(Me.Pb_Resources, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_PerSecond As Label
    Friend WithEvents Pb_Resources As PictureBox
    Friend WithEvents txt_Cheat As TextBox
    Friend WithEvents lbl_Resources As Label
    Friend WithEvents btn_Upgrades As Button
    Friend WithEvents btn_Options As Button
    Friend WithEvents btn_BuyHouse As Button
    Friend WithEvents btn_BuyChurch As Button
    Friend WithEvents btn_BuyFarm As Button
    Friend WithEvents btn_BuyTavern As Button
    Friend WithEvents btn_BuyWorker As Button
    Friend WithEvents btn_BuyCastle As Button
    Friend WithEvents Timer_UpdateInterface As Timer
    Friend WithEvents lbl_TitlePage As Label
    Friend WithEvents Timer_PerSecond As Timer
    Friend WithEvents lbl_ItemsTitle As Label
    Friend WithEvents btn_UpWorker As Button
    Friend WithEvents btn_UpHouse As Button
    Friend WithEvents btn_UpFarm As Button
    Friend WithEvents btn_UpTavern As Button
    Friend WithEvents btn_UpChurch As Button
    Friend WithEvents btn_UpClick As Button
    Friend WithEvents btn_Store As Button
    Friend WithEvents lbl_ClickValue As Label
    Friend WithEvents Timer_ClickValueLabel As Timer
    Friend WithEvents btn_Cheats As Button
    Friend WithEvents btn_Save As Button
    Friend WithEvents btn_Load As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents lbl_CountDown As Label
    Friend WithEvents Timer_CountDown As Timer
    Friend WithEvents Timer_StopTimers As Timer
    Friend WithEvents Timer_CheckIfTrue As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
