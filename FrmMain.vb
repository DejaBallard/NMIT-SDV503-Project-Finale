Public Class FrmMain

    'TO DO LIST:
    'Timer per second interval = Number! so random event power up can change it COMPLETED
    'Add a owned module COMPLETED
    'Fix error with upgrading auto clickers COMPLETED
    'Start interface on Options
    'When Resources label becomes a certain number change it. Example: change 1000000 to 1 Mil. Change 1500000 to 1.5 Mil
    'When +1 label becomes to big change it. Stop it at 5 numbers
    'Create visuals for right box
    'random events?
    'Subtask the buying/upgrade buttons code
    'Tool Tips


    'Prototype1

    'ON LOAD
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Displaying start up information
        Dim lc_InputResult = InputBox("
You have been banished for your homeland.
Left to roam the earth, you decided to build your own village and become the new king of the land.
However, your old home has found out and will be sending an army to stop you.

HOW TO PLAY:
Collect Resources from the Crystals
Buy buildings and workers to help your village
Every five minutes an army will attack! 
Enter your name below

", "FOR THE KING")

        'Personalising the title page
        If lc_InputResult = ("") Then
            lbl_TitlePage.Text = "The Kingdom"
        Else
            lbl_TitlePage.Text = lc_InputResult & "'s" & " Kingdom"
        End If

        'Start count down for enemy to arrive
        Timer_CountDown.Start()
        md_Countdown = TimeSpan.FromMinutes(1)
        Md_Stopwatch.Start()



    End Sub

    'Timer Countdown for enemy
    Private Sub Timer_CountDown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_CountDown.Tick
        Dim ts As TimeSpan = md_Countdown - Md_Stopwatch.Elapsed
        lbl_CountDown.Text = String.Format("Time Till Arrival: {0:0}:{1:00}", ts.Minutes, ts.Seconds)

        If lbl_CountDown.Text = ("Time Till Arrival: 0:00") Then
            FrmEnemy.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub lbl_CountDown_Click(sender As Object, e As EventArgs) Handles lbl_CountDown.Click
        FrmEnemy.Show()
        Me.Hide()
    End Sub
    'Stoping timers when enemy open
    Private Sub Timer_StopTimers_Tick(sender As Object, e As EventArgs) Handles Timer_StopTimers.Tick
        If Me.Visible = False Then
            Timer_CountDown.Stop()
            Md_Stopwatch.Stop()
            Timer_PerSecond.Stop()
            Timer_UpdateInterface.Stop()
            Timer_CheckIfTrue.Stop()

        Else
            Timer_CountDown.Start()
            Md_Stopwatch.Start()
            Timer_PerSecond.Start()
            Timer_UpdateInterface.Start()
            Timer_CheckIfTrue.Start()

        End If
    End Sub


    'CHEAT
    Private Sub btn_Cheats_Click(sender As Object, e As EventArgs) Handles btn_Cheats.Click
        Try
            Module_Values.md_ResourceValue = txt_Cheat.Text
            lbl_Resources.Text = Module_Values.md_ResourceValue

        Catch Null As Exception
            txt_Cheat.Text = ""
        End Try
    End Sub

    'USER CLICK
    Private Sub Pb_Resources_MouseDown(sender As Object, e As MouseEventArgs) Handles Pb_Resources.MouseDown

        Module_Values.md_ResourceValue = Module_Values.md_ResourceValue + Module_Values.md_ClickValue

        Module_Owned.md_Click = Module_Owned.md_Click + 1

        'Resize the image
        Pb_Resources.Height = Pb_Resources.Height - 8
        Pb_Resources.Width = Pb_Resources.Width - 8
        Pb_Resources.Location = New Point(Pb_Resources.Location.X + 4, Pb_Resources.Location.Y + 4)

    End Sub
    Private Sub Pb_Resources_MouseUp(sender As Object, e As MouseEventArgs) Handles Pb_Resources.MouseUp

        'Resizing the image
        Pb_Resources.Height = Pb_Resources.Height + 8
        Pb_Resources.Width = Pb_Resources.Width + 8
        Pb_Resources.Location = New Point(Pb_Resources.Location.X - 4, Pb_Resources.Location.Y - 4)

        '+1 label
        lbl_ClickValue.Location = New System.Drawing.Point(Pb_Resources.Location.X + 125, Pb_Resources.Location.Y + 50)
        lbl_ClickValue.Text = "+" & Module_Values.md_ClickValue
        lbl_ClickValue.Show()

        Timer_ClickValueLabel.Start()

    End Sub
    Private Sub Timer_ClickValueLabel_Tick(sender As Object, e As EventArgs) Handles Timer_ClickValueLabel.Tick

        'Moving +1 label
        lbl_ClickValue.Top -= 1
        If lbl_ClickValue.Location.Y < 80 Then
            lbl_ClickValue.Hide()

            Timer_ClickValueLabel.Stop()

        End If
    End Sub

    'USER CLICK UPGRADES SHOW
    Private Sub btn_Upgrades_Click(sender As Object, e As EventArgs) Handles btn_Upgrades.Click

        btn_Upgrades.Hide()
        btn_BuyWorker.Hide()
        btn_BuyHouse.Hide()
        btn_BuyFarm.Hide()
        btn_BuyTavern.Hide()
        btn_BuyChurch.Hide()
        btn_BuyCastle.Hide()
        btn_UpWorker.Show()
        btn_UpHouse.Show()
        btn_UpFarm.Show()
        btn_UpTavern.Show()
        btn_UpChurch.Show()
        btn_UpClick.Show()
        btn_Store.Show()
        lbl_ItemsTitle.Text = "Upgrades"

    End Sub

    'USER CLICK STORE SHOW`
    Private Sub btn_Store_Click(sender As Object, e As EventArgs) Handles btn_Store.Click

        btn_Store.Hide()
        btn_UpWorker.Hide()
        btn_UpHouse.Hide()
        btn_UpFarm.Hide()
        btn_UpTavern.Hide()
        btn_UpChurch.Hide()
        btn_UpClick.Hide()
        btn_BuyWorker.Show()
        btn_BuyHouse.Show()
        btn_BuyFarm.Show()
        btn_BuyTavern.Show()
        btn_BuyChurch.Show()
        btn_BuyCastle.Show()
        btn_Upgrades.Show()
        lbl_ItemsTitle.Text = "Store"

    End Sub

    'UPDATE INTERFACE TIMER
    Private Sub Timer_UpdateInterface_Tick(sender As Object, e As EventArgs) Handles Timer_UpdateInterface.Tick

        Timer_UpdateInterface.Interval = 10

        UpdatingUserLabels()

        UpdatingButtonLabel()

        'DISABLE/ENABLE ITEM BUTTONS
        'Worker
        CheckingButtonsPrice(Module_Values.md_ResourceValue, Module_Prices.md_BuyWorker, btn_BuyWorker)
        'House
        CheckingButtonsPrice(Module_Values.md_ResourceValue, Module_Prices.md_BuyHouse, btn_BuyHouse)
        'Farm
        CheckingButtonsPrice(Module_Values.md_ResourceValue, Module_Prices.md_BuyFarm, btn_BuyFarm)
        'Tavern
        CheckingButtonsPrice(Module_Values.md_ResourceValue, Module_Prices.md_BuyTavern, btn_BuyTavern)
        'Church
        CheckingButtonsPrice(Module_Values.md_ResourceValue, Module_Prices.md_BuyChurch, btn_BuyChurch)
        'Castle
        CheckingButtonsPrice(Module_Values.md_ResourceValue, Module_Prices.md_BuyCastle, btn_BuyCastle)

        'DISABLE/ENABLE UPGRADE BUTTONS
        'USER CLICK
        CheckingButtonsPrice(Module_Values.md_ResourceValue, Module_Prices.md_UpClick, btn_UpClick)
        'WORKER
        CheckingButtonsPriceAndOwned(Module_Owned.md_Worker, Module_Values.md_ResourceValue, Module_Prices.md_UpWorker, btn_UpWorker)
        'HOUSE
        CheckingButtonsPriceAndOwned(Module_Owned.md_House, Module_Values.md_ResourceValue, Module_Prices.md_UpHouse, btn_UpHouse)
        'FARM
        CheckingButtonsPriceAndOwned(Module_Owned.md_Farm, Module_Values.md_ResourceValue, Module_Prices.md_UpFarm, btn_UpFarm)
        'TAVERN
        CheckingButtonsPriceAndOwned(Module_Owned.md_Tavern, Module_Values.md_ResourceValue, Module_Prices.md_UpTavern, btn_UpTavern)
        'CHURCH
        CheckingButtonsPriceAndOwned(Module_Owned.md_Church, Module_Values.md_ResourceValue, Module_Prices.md_UpChurch, btn_UpChurch)

    End Sub
    Private Sub UpdatingUserLabels()
        ' If Module_Values.md_ResourceValue > 999999 Then
        ' lbl_Resources.Text = (Module_Values.md_ResourceValue.ToString , "000")
        'Else
        lbl_Resources.Text = ("Resources: " & Module_Values.md_ResourceValue.ToString("n2"))
        ' End If

        lbl_PerSecond.Text = ("PerSecond: " & Module_Values.md_PerSecond.ToString("n1"))
    End Sub
    Private Sub CheckingButtonsPrice(ByVal prResources, ByVal prItem, ByVal prButton)

        If prResources >= prItem Then
            prButton.Enabled = True
        Else
            prButton.Enabled = False
        End If

    End Sub
    Private Sub CheckingButtonsPriceAndOwned(ByVal prItemsOwned, ByVal prResources, ByVal prItem, ByVal prButton)
        If prItemsOwned > 0 And prResources >= prItem Then
            prButton.Enabled = True
        Else
            prButton.Enabled = False
        End If
    End Sub
    Private Sub UpdatingButtonLabel()


        btn_BuyWorker.Text = "Worker: " & Module_Prices.md_BuyWorker
        btn_BuyHouse.Text = "House: " & Module_Prices.md_BuyHouse
        btn_BuyFarm.Text = "Farm:  " & Module_Prices.md_BuyFarm
        btn_BuyTavern.Text = "Tavern: " & Module_Prices.md_BuyTavern
        btn_BuyChurch.Text = "Church: " & Module_Prices.md_BuyChurch
        btn_BuyCastle.Text = "Castle: " & Module_Prices.md_BuyCastle

        'Updating Upgrade buttons
        btn_UpWorker.Text = "Worker: " & Module_Prices.md_UpWorker
        btn_UpHouse.Text = "House: " & Module_Prices.md_UpHouse
        btn_UpFarm.Text = "Farm: " & Module_Prices.md_UpFarm
        btn_UpTavern.Text = "Tavern: " & Module_Prices.md_UpTavern
        btn_UpChurch.Text = "Church: " & Module_Prices.md_UpChurch
        btn_UpClick.Text = "Clicker: " & Module_Prices.md_UpClick

    End Sub


    'Prototype 2

    'PER SECOND TIMER
    Private Sub Timer_PerSecond_Tick(sender As Object, e As EventArgs) Handles Timer_PerSecond.Tick

        Timer_PerSecond.Interval = 1000

        Module_Values.md_ResourceValue = Module_Values.md_ResourceValue + Module_Values.md_PerSecond
    End Sub

    'BUYING ITEMS
    Private Sub btn_BuyWorker_Click(sender As Object, e As EventArgs) Handles btn_BuyWorker.Click

        Module_Values.md_ResourceValue = Module_Values.md_ResourceValue - Module_Prices.md_BuyWorker

        Module_Values.md_PerSecond = Module_Values.md_PerSecond + Module_Values.md_Worker

        Module_Owned.md_Worker = Module_Owned.md_Worker + 1

        Module_Owned.md_All = Module_Owned.md_All + 1

        Module_Prices.md_BuyWorker = Module_Prices.md_BuyWorker * Module_Prices.md_PriceIncrease
    End Sub
    Private Sub btn_BuyHouse_Click(sender As Object, e As EventArgs) Handles btn_BuyHouse.Click
        Module_Values.md_ResourceValue = Module_Values.md_ResourceValue - Module_Prices.md_BuyHouse

        Module_Values.md_PerSecond = Module_Values.md_PerSecond + Module_Values.md_House

        Module_Owned.md_House = Module_Owned.md_House + 1

        Module_Owned.md_All = Module_Owned.md_All + 1

        Module_Prices.md_BuyHouse = Module_Prices.md_BuyHouse * Module_Prices.md_PriceIncrease
    End Sub
    Private Sub btn_BuyFarm_Click(sender As Object, e As EventArgs) Handles btn_BuyFarm.Click
        Module_Values.md_ResourceValue = Module_Values.md_ResourceValue - Module_Prices.md_BuyFarm

        Module_Values.md_PerSecond = Module_Values.md_PerSecond + Module_Values.md_Farm

        Module_Owned.md_Farm = Module_Owned.md_Farm + 1

        Module_Owned.md_All = Module_Owned.md_All + 1

        Module_Prices.md_BuyFarm = Module_Prices.md_BuyFarm * Module_Prices.md_PriceIncrease
    End Sub
    Private Sub btn_BuyTavern_Click(sender As Object, e As EventArgs) Handles btn_BuyTavern.Click
        Module_Values.md_ResourceValue = Module_Values.md_ResourceValue - Module_Prices.md_BuyTavern

        Module_Values.md_PerSecond = Module_Values.md_PerSecond + Module_Values.md_Tavern

        Module_Owned.md_Tavern = Module_Owned.md_Farm + 1

        Module_Owned.md_All = Module_Owned.md_All + 1

        Module_Prices.md_BuyFarm = Module_Prices.md_BuyTavern * Module_Prices.md_PriceIncrease
    End Sub
    Private Sub btn_BuyChurch_Click(sender As Object, e As EventArgs) Handles btn_BuyChurch.Click
        Module_Values.md_ResourceValue = Module_Values.md_ResourceValue - Module_Prices.md_BuyChurch

        Module_Values.md_PerSecond = Module_Values.md_PerSecond + Module_Values.md_Church

        Module_Owned.md_Church = Module_Owned.md_Church + 1

        Module_Owned.md_All = Module_Owned.md_All + 1

        Module_Prices.md_BuyChurch = Module_Prices.md_BuyChurch * Module_Prices.md_PriceIncrease
    End Sub
    Private Sub btn_BuyCastle_Click(sender As Object, e As EventArgs) Handles btn_BuyCastle.Click
        Module_Values.md_ResourceValue = Module_Values.md_ResourceValue - Module_Prices.md_BuyCastle

        Module_Values.md_PerSecond = Module_Values.md_PerSecond + Module_Values.md_Castle

        Module_Owned.md_Castle = Module_Owned.md_Castle + 1

        Module_Owned.md_All = Module_Owned.md_All + 1

        Module_Prices.md_BuyCastle = Module_Prices.md_BuyCastle * Module_Prices.md_PriceIncrease
    End Sub

    'UPGRADING ITEMS
    Private Sub btn_UpClick_Click(sender As Object, e As EventArgs) Handles btn_UpClick.Click

        Module_Values.md_ResourceValue = Module_Values.md_ResourceValue - Module_Prices.md_UpClick

        Module_Values.md_ClickValue = Module_Values.md_ClickValue * Module_Values.md_ValueIncrease

        Module_Prices.md_UpClick = Module_Prices.md_UpClick * Module_Prices.md_PriceIncrease

        Module_Owned.md_All = Module_Owned.md_All + 1

    End Sub
    Private Sub btn_UpWorker_Click(sender As Object, e As EventArgs) Handles btn_UpWorker.Click

        Module_Values.md_ResourceValue = Module_Values.md_ResourceValue - Module_Prices.md_UpWorker

        Module_Values.md_Worker = Module_Values.md_Worker * Module_Values.md_ValueIncrease

        Module_Prices.md_UpWorker = Module_Prices.md_UpWorker * Module_Prices.md_PriceIncrease

        Module_Owned.md_All = Module_Owned.md_All + 1

        Module_Values.ReUpdatePerSecond()

    End Sub
    Private Sub btn_UpHouse_Click(sender As Object, e As EventArgs) Handles btn_UpHouse.Click
        Module_Values.md_ResourceValue = Module_Values.md_ResourceValue - Module_Prices.md_UpHouse

        Module_Values.md_House = Module_Values.md_House * Module_Values.md_ValueIncrease

        Module_Prices.md_UpHouse = Module_Prices.md_UpHouse * Module_Prices.md_PriceIncrease

        Module_Owned.md_All = Module_Owned.md_All + 1

        Module_Values.ReUpdatePerSecond()
    End Sub
    Private Sub btn_UpFarm_Click(sender As Object, e As EventArgs) Handles btn_UpFarm.Click
        Module_Values.md_ResourceValue = Module_Values.md_ResourceValue - Module_Prices.md_UpFarm

        Module_Values.md_Farm = Module_Values.md_Farm * Module_Values.md_ValueIncrease

        Module_Prices.md_UpFarm = Module_Prices.md_UpFarm * Module_Prices.md_PriceIncrease

        Module_Owned.md_All = Module_Owned.md_All + 1

        Module_Values.ReUpdatePerSecond()
    End Sub
    Private Sub btn_UpTavern_Click(sender As Object, e As EventArgs) Handles btn_UpTavern.Click
        Module_Values.md_ResourceValue = Module_Values.md_ResourceValue - Module_Prices.md_UpTavern

        Module_Values.md_Tavern = Module_Values.md_Tavern * Module_Values.md_ValueIncrease

        Module_Prices.md_UpTavern = Module_Prices.md_UpTavern * Module_Prices.md_PriceIncrease

        Module_Owned.md_All = Module_Owned.md_All + 1

        Module_Values.ReUpdatePerSecond()
    End Sub
    Private Sub btn_UpChurch_Click(sender As Object, e As EventArgs) Handles btn_UpChurch.Click
        Module_Values.md_ResourceValue = Module_Values.md_ResourceValue - Module_Prices.md_UpChurch

        Module_Values.md_Church = Module_Values.md_Church * Module_Values.md_ValueIncrease

        Module_Prices.md_UpChurch = Module_Prices.md_UpChurch * Module_Prices.md_PriceIncrease

        Module_Owned.md_All = Module_Owned.md_All + 1

        Module_Values.ReUpdatePerSecond()
    End Sub




    'Prototype 3

    'SAVE/LOAD
    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Module_Save.SaveFileAs(Module_Values.md_ResourceValue, Module_Values.md_PerSecond, Module_Values.md_ClickValue, Module_Values.md_Worker, Module_Values.md_House, Module_Values.md_Farm, Module_Values.md_Tavern, Module_Values.md_Church, Module_Owned.md_Worker, Module_Owned.md_House, Module_Owned.md_Farm, Module_Owned.md_Tavern, Module_Owned.md_Church, Module_Owned.md_Castle, Module_Prices.md_BuyWorker, Module_Prices.md_BuyHouse, Module_Prices.md_BuyFarm, Module_Prices.md_BuyTavern, Module_Prices.md_BuyChurch, Module_Prices.md_BuyCastle, Module_Prices.md_UpClick, Module_Prices.md_UpWorker, Module_Prices.md_UpHouse, Module_Prices.md_UpFarm, Module_Prices.md_UpTavern, Module_Prices.md_UpChurch, Module_EnemyFrm.md_UserDamage, Module_EnemyFrm.md_UserAttackCost, Module_EnemyFrm.md_EnemyDamage, Module_EnemyFrm.md_EnemyLevel, Module_EnemyFrm.md_EnemyHealth, Module_EnemyFrm.md_EnemyStartHealth, Module_EnemyFrm.md_UpDamagePrice, Module_EnemyFrm.md_DownCostPrice, Module_Achivements.lc_AchievementTrue1, Module_Achivements.lc_AchievementTrue7)
    End Sub
    Private Sub btn_Load_Click(sender As Object, e As EventArgs) Handles btn_Load.Click
        Module_Save.LoadFile(Module_Values.md_ResourceValue, Module_Values.md_PerSecond, Module_Values.md_ClickValue, Module_Values.md_Worker, Module_Values.md_House, Module_Values.md_Farm, Module_Values.md_Tavern, Module_Values.md_Church, Module_Owned.md_Worker, Module_Owned.md_House, Module_Owned.md_Farm, Module_Owned.md_Tavern, Module_Owned.md_Church, Module_Owned.md_Castle, Module_Prices.md_BuyWorker, Module_Prices.md_BuyHouse, Module_Prices.md_BuyFarm, Module_Prices.md_BuyTavern, Module_Prices.md_BuyChurch, Module_Prices.md_BuyCastle, Module_Prices.md_UpClick, Module_Prices.md_UpWorker, Module_Prices.md_UpHouse, Module_Prices.md_UpFarm, Module_Prices.md_UpTavern, Module_Prices.md_UpChurch, Module_EnemyFrm.md_UserDamage, Module_EnemyFrm.md_UserAttackCost, Module_EnemyFrm.md_EnemyDamage, Module_EnemyFrm.md_EnemyLevel, Module_EnemyFrm.md_EnemyHealth, Module_EnemyFrm.md_EnemyStartHealth, Module_EnemyFrm.md_UpDamagePrice, Module_EnemyFrm.md_DownCostPrice, Module_Achivements.lc_AchievementTrue1, Module_Achivements.lc_AchievementTrue7)

    End Sub

    'SETTINGS
    Private Sub btn_Options_Click(sender As Object, e As EventArgs) Handles btn_Options.Click
        FrmSettings.Show()
    End Sub

    'TOOL TIPS
    'UPGRADE BUTTONS
    Private Sub btn_UpClick_MouseHover(sender As Object, e As EventArgs) Handles btn_UpClick.MouseHover
        DoToolTip(btn_UpClick, "Mouse", Module_Values.md_ClickValue)
    End Sub
    Private Sub btn_UpWorker_MouseHover(sender As Object, e As EventArgs) Handles btn_UpWorker.MouseHover
        DoToolTip(btn_UpWorker, "Worker", Module_Values.md_Worker)

    End Sub
    Private Sub btn_UpHouse_MouseHover(sender As Object, e As EventArgs) Handles btn_UpHouse.MouseHover
        DoToolTip(btn_UpHouse, "House", Module_Values.md_House)
    End Sub
    Private Sub btn_UpFarm_MouseHover(sender As Object, e As EventArgs) Handles btn_UpFarm.MouseHover
        DoToolTip(btn_UpFarm, "House", Module_Values.md_Farm)
    End Sub
    Private Sub btn_UpTavern_MouseHover(sender As Object, e As EventArgs) Handles btn_UpTavern.MouseHover
        DoToolTip(btn_UpTavern, "Tavern", Module_Values.md_Tavern)
    End Sub
    Private Sub btn_UpChurch_MouseHover(sender As Object, e As EventArgs) Handles btn_UpChurch.MouseHover
        DoToolTip(btn_UpChurch, "Church", Module_Values.md_Church)
    End Sub
    Private Sub DoToolTip(prButton, prName, prValue)
        ToolTip.SetToolTip(prButton, prName & " Upgrade

Collection per second: " & prValue &
"

This increases how much the " & prName & " will by " & Module_Values.md_ValueIncrease)
    End Sub
    'BUY ITEMS
    Private Sub btn_BuyWorker_MouseHover(sender As Object, e As EventArgs) Handles btn_BuyWorker.MouseHover
        ToolTip.SetToolTip(btn_BuyWorker, "Buy a Worker

Collection per second: " & Module_Values.md_Worker &
"

This will help you collect resources")
    End Sub
    Private Sub btn_BuyHouse_MouseHover(sender As Object, e As EventArgs) Handles btn_BuyHouse.MouseHover
        ToolTip.SetToolTip(btn_BuyHouse, "Buy a House

Collection per second: " & Module_Values.md_House &
"

This will help you collect resources")
    End Sub
    Private Sub btn_BuyFarm_MouseHover(sender As Object, e As EventArgs) Handles btn_BuyFarm.MouseHover
        ToolTip.SetToolTip(btn_BuyFarm, "Buy a Farm

Collection per second: " & Module_Values.md_Church &
"

This will help you collect resources")
    End Sub
    Private Sub btn_BuyTavern_MouseHover(sender As Object, e As EventArgs) Handles btn_BuyTavern.MouseHover
        ToolTip.SetToolTip(btn_BuyTavern, "Buy a Tavern

Collection per second: " & Module_Values.md_Tavern &
"

This will help you collect resources")
    End Sub
    Private Sub btn_BuyChurch_MouseHover(sender As Object, e As EventArgs) Handles btn_BuyChurch.MouseHover
        ToolTip.SetToolTip(btn_BuyChurch, "Buy a Church

Collection per second: " & Module_Values.md_Church &
"

This will help you collect resources")
    End Sub
    Private Sub btn_BuyCastle_MouseHover(sender As Object, e As EventArgs) Handles btn_BuyCastle.MouseHover
        ToolTip.SetToolTip(btn_BuyCastle, "Buy a Castle

Collection per second: " & Module_Values.md_Castle &
"

This will help you collect resources")
    End Sub



    'Check If Achievement has been meet
    Private Sub Timer_CheckIfTrue_Tick(sender As Object, e As EventArgs) Handles Timer_CheckIfTrue.Tick

        If Module_Values.md_ResourceValue >= Module_Achivements.md_Achivement1 And Module_Achivements.lc_AchievementTrue1 = False Then
            Module_Achivements.lc_AchievementTrue1 = True
            MessageBox.Show("Achievement complete: Collect " & Module_Achivements.md_Achivement1 & " Resources", "Achievement Complete")
        End If
        If Module_Values.md_ResourceValue >= Module_Achivements.md_Achivement2 And Module_Achivements.lc_AchievementTrue2 = False Then
            Module_Achivements.lc_AchievementTrue2 = True
            MessageBox.Show("Achievement complete: Collect " & Module_Achivements.md_Achivement2 & " Resources")
        End If
        If Module_Values.md_ResourceValue >= Module_Achivements.md_Achivement3 And Module_Achivements.lc_AchievementTrue3 = False Then
            Module_Achivements.lc_AchievementTrue3 = True
            MessageBox.Show("Achievement complete: Collect " & Module_Achivements.md_Achivement3 & " Resources", "Achievement Complete")
        End If


        If Module_Owned.md_All >= Module_Achivements.md_Achivement4 And Module_Achivements.lc_AchievementTrue4 = False Then
            Module_Achivements.lc_AchievementTrue4 = True
            MessageBox.Show("Achievement complete: Buy " & Module_Achivements.md_Achivement4 & " Items", "Achievement Complete")
        End If
        If Module_Owned.md_All >= Module_Achivements.md_Achivement5 And Module_Achivements.lc_AchievementTrue5 = False Then
            Module_Achivements.lc_AchievementTrue5 = True
            MessageBox.Show("Achievement complete: Buy " & Module_Achivements.md_Achivement5 & " Items", "Achievement Complete")
        End If
        If Module_Owned.md_All >= Module_Achivements.md_Achivement6 And Module_Achivements.lc_AchievementTrue6 = False Then
            Module_Achivements.lc_AchievementTrue6 = True
            MessageBox.Show("Achievement complete: Buy " & Module_Achivements.md_Achivement6 & " Items", "Achievement Complete")
        End If


        If Module_Owned.md_Click >= Module_Achivements.md_Achivement7 And Module_Achivements.lc_AchievementTrue7 = False Then
            Module_Achivements.lc_AchievementTrue7 = True
            MessageBox.Show("Achievement complete: Click " & Module_Achivements.md_Achivement7 & " Times", "Achievement Complete")
        End If
        If Module_Owned.md_Click >= Module_Achivements.md_Achivement8 And Module_Achivements.lc_AchievementTrue8 = False Then
            Module_Achivements.lc_AchievementTrue8 = True
            MessageBox.Show("Achievement complete: Click " & Module_Achivements.md_Achivement8 & " Times", "Achievement Complete")
        End If
        If Module_Owned.md_Click >= Module_Achivements.md_Achivement9 And Module_Achivements.lc_AchievementTrue9 = False Then
            Module_Achivements.lc_AchievementTrue9 = True
            MessageBox.Show("Achievement complete: Click " & Module_Achivements.md_Achivement9 & " Times", "Achievement Complete")
        End If

    End Sub


    'STOP TIMERS

End Class
