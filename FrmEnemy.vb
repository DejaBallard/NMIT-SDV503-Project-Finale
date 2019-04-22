Public Class FrmEnemy

    Dim md_UsableEnemyHealth As Decimal = Module_EnemyFrm.md_EnemyHealth
    Dim md_UsableEnemyDamage As Decimal = Module_EnemyFrm.md_EnemyDamage

    Dim md_UsableUserHealth As Decimal = Module_Values.md_ResourceValue

    'ON LOAD
    Private Sub FrmEnemy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_ClickValue.Hide()

        ProB_Enemy.ForeColor = Color.Maroon
        ProB_Resources.ForeColor = Color.Green
        pb_Enemy.Image = My.Resources.Finished_Enemy_100


        MessageBox.Show("You are being attacked!

Click on the enemy to kill him

Each time you click, it will cost you Resources

Enemy's Level:                           " & Module_EnemyFrm.md_EnemyLevel &
"
Enemy's Health:                        " & Module_EnemyFrm.md_EnemyStartHealth &
"
Enemy's Damage PerSecond: " & Module_EnemyFrm.md_EnemyDamage &
"

Good luck", "You are being attacked!")

        Timer_EnemyAttack.Start()
        Timer_UpdateInterface.Start()
    End Sub

    'USER CLICK
    Private Sub pb_Enemy_MouseDown(sender As Object, e As MouseEventArgs) Handles pb_Enemy.MouseDown

        md_UsableEnemyHealth = md_UsableEnemyHealth - Module_EnemyFrm.md_UserDamage
        md_UsableUserHealth = md_UsableUserHealth - Module_EnemyFrm.md_UserAttackCost

        'Resize the image
        pb_Enemy.Height = pb_Enemy.Height - 8
        pb_Enemy.Width = pb_Enemy.Width - 8
        pb_Enemy.Location = New Point(pb_Enemy.Location.X + 4, pb_Enemy.Location.Y + 4)
    End Sub
    Private Sub pb_Enemy_MouseUp(sender As Object, e As MouseEventArgs) Handles pb_Enemy.MouseUp

        'Resizing the image
        pb_Enemy.Height = pb_Enemy.Height + 8
        pb_Enemy.Width = pb_Enemy.Width + 8
        pb_Enemy.Location = New Point(pb_Enemy.Location.X - 4, pb_Enemy.Location.Y - 4)

        '+1 label
        lbl_ClickValue.Location = New System.Drawing.Point(pb_Enemy.Location.X + 330, pb_Enemy.Location.Y + 20)
        lbl_ClickValue.Text = ("Damage: -" & Module_EnemyFrm.md_UserDamage.ToString("n1") & "
Cost: -" & Module_EnemyFrm.md_UserAttackCost.ToString("n1"))
        lbl_ClickValue.BringToFront()

        lbl_ClickValue.Show()

        Timer_ClickValueLabel.Start()

    End Sub
    Private Sub Timer_ClickValueLabel_Tick(sender As Object, e As EventArgs) Handles Timer_ClickValueLabel.Tick

        'Moving +1 label
        lbl_ClickValue.Top -= 1
        If lbl_ClickValue.Location.Y < 110 Then
            lbl_ClickValue.Hide()

            Timer_ClickValueLabel.Stop()

        End If
    End Sub

    'ENEMY DAMAGE
    Private Sub Timer_EnemyAttack_Tick(sender As Object, e As EventArgs) Handles Timer_EnemyAttack.Tick
        Timer_EnemyAttack.Interval = 1000
        md_UsableUserHealth = md_UsableUserHealth - md_UsableEnemyDamage


        ProB_Resources.Location = New Point(ProB_Resources.Location.X, ProB_Resources.Location.Y + 1)
        System.Threading.Thread.Sleep(100)
        ProB_Resources.Location = New Point(ProB_Resources.Location.X, ProB_Resources.Location.Y - 1)


    End Sub

    'UPDATE UINTERFACE
    Private Sub Timer_UpdateInterface_Tick(sender As Object, e As EventArgs) Handles Timer_UpdateInterface.Tick
        'UPDATE lABELS
        UpdatingLabels()

        'UPDATING BUTTONS
        CheckingButtonsPrice(md_UsableUserHealth, Module_EnemyFrm.md_UpDamagePrice, btn_UpWeapon)
        CheckingButtonsPrice(md_UsableUserHealth, Module_EnemyFrm.md_DownCostPrice, btn_UpArmy)

        'CHECK IF ENEMY DIED
        If md_UsableEnemyHealth <= 0 Then
            ProB_Enemy.Value = 0
            Module_EnemyFrm.md_EnemyDamage = Module_EnemyFrm.md_EnemyDamage * 1.2
            Module_EnemyFrm.md_EnemyHealth = Module_EnemyFrm.md_EnemyHealth * 1.2
            Module_EnemyFrm.md_EnemyStartHealth = Module_EnemyFrm.md_EnemyStartHealth * 1.2
            Module_EnemyFrm.md_EnemyLevel = Module_EnemyFrm.md_EnemyLevel + 1

            md_UsableUserHealth = md_UsableUserHealth + 10000

            Module_Values.md_ResourceValue = md_UsableUserHealth
            Timer_UpdateInterface.Stop()
            Timer_EnemyAttack.Stop()
            Module_StopWatch.Md_Stopwatch.Reset()
            MessageBox.Show("YOU WIN

You were able to beat the attacking enemy

You found 10000 Resources on the battlefield

Current Resources: " & Module_Values.md_ResourceValue, "You Win")
            Module_StopWatch.Md_Stopwatch.Start()
            Me.Close()
            FrmMain.Show()
            'CHECK IF USER DIED
        ElseIf md_UsableUserHealth <= 0 Then
            Module_Values.md_ResourceValue = md_UsableUserHealth
            Timer_UpdateInterface.Stop()
            Timer_EnemyAttack.Stop()
            Module_StopWatch.Md_Stopwatch.Reset()
            MessageBox.Show("GAME OVER

You have lost everything", "You Lost")
            Module_StopWatch.Md_Stopwatch.Start()
            Me.Close()
            FrmMain.Show()
            'UPDATE PROGRESSBARS
        Else
            ProB_Enemy.Value = md_UsableEnemyHealth / Module_EnemyFrm.md_EnemyStartHealth * 100
            ProB_Resources.Value = md_UsableUserHealth / Module_Values.md_ResourceValue * 100
        End If


    End Sub
    Private Sub UpdatingLabels()
        lbl_EnemyHealth.Text = ("Enemy's Health: " & md_UsableEnemyHealth.ToString("n3") & " / " & Module_EnemyFrm.md_EnemyStartHealth.ToString("n3"))
        lbl_Resources.Text = ("Your Resources: " & md_UsableUserHealth.ToString("n3") & " / " & Module_Values.md_ResourceValue.ToString("n3"))
        btn_UpArmy.Text = ("Increase Your Attack Damage by 1.2

Price: " & Module_EnemyFrm.md_DownCostPrice.ToString("n1"))
        btn_UpWeapon.Text = ("Decrease Your Attack Cost by 0.1

Price: " & Module_EnemyFrm.md_UpDamagePrice.ToString("n1"))

        lbl_EnemyStats.Text = "Enemy Stats

Level: 
" & Module_EnemyFrm.md_EnemyLevel &
"
Damage:
" & Module_EnemyFrm.md_EnemyDamage.ToString("n1")

        lbl_YourStats.Text = ("Your Stats

Attack Damage:
" & Module_EnemyFrm.md_UserDamage.ToString("n1") &
"
Attack Cost:
" & Module_EnemyFrm.md_UserAttackCost.ToString("n1"))
    End Sub
    Private Sub CheckingButtonsPrice(ByVal prResources, ByVal prItem, ByVal prButton)

        If prResources >= prItem Then
            prButton.Enabled = True
        Else
            prButton.Enabled = False
        End If

    End Sub

    'UPGRADE BUTTONS
    Private Sub btn_UpWeapon_Click(sender As Object, e As EventArgs) Handles btn_UpWeapon.Click
        md_UsableUserHealth = md_UsableUserHealth - Module_EnemyFrm.md_UpDamagePrice
        Module_EnemyFrm.md_UserDamage = Module_EnemyFrm.md_UserDamage * 1.2
        Module_EnemyFrm.md_UpDamagePrice = Module_EnemyFrm.md_UpDamagePrice * 1.2
    End Sub
    Private Sub btn_UpArmy_Click(sender As Object, e As EventArgs) Handles btn_UpArmy.Click
        md_UsableUserHealth = md_UsableUserHealth - Module_EnemyFrm.md_DownCostPrice
        Module_EnemyFrm.md_UserAttackCost = Module_EnemyFrm.md_UserAttackCost - 0.1
        Module_EnemyFrm.md_DownCostPrice = Module_EnemyFrm.md_DownCostPrice * 2
    End Sub

    'SAVE/LOAD
    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Module_Values.md_ResourceValue = md_UsableUserHealth
        Module_Save.SaveFileAs(Module_Values.md_ResourceValue, Module_Values.md_PerSecond, Module_Values.md_ClickValue, Module_Values.md_Worker, Module_Values.md_House, Module_Values.md_Farm, Module_Values.md_Tavern, Module_Values.md_Church, Module_Owned.md_Worker, Module_Owned.md_House, Module_Owned.md_Farm, Module_Owned.md_Tavern, Module_Owned.md_Church, Module_Owned.md_Castle, Module_Prices.md_BuyWorker, Module_Prices.md_BuyHouse, Module_Prices.md_BuyFarm, Module_Prices.md_BuyTavern, Module_Prices.md_BuyChurch, Module_Prices.md_BuyCastle, Module_Prices.md_UpClick, Module_Prices.md_UpWorker, Module_Prices.md_UpHouse, Module_Prices.md_UpFarm, Module_Prices.md_UpTavern, Module_Prices.md_UpChurch, Module_EnemyFrm.md_UserDamage, Module_EnemyFrm.md_UserAttackCost, Module_EnemyFrm.md_EnemyDamage, Module_EnemyFrm.md_EnemyLevel, Module_EnemyFrm.md_EnemyHealth, Module_EnemyFrm.md_EnemyStartHealth, Module_EnemyFrm.md_UpDamagePrice, Module_EnemyFrm.md_DownCostPrice, Module_Achivements.lc_AchievementTrue1, Module_Achivements.lc_AchievementTrue7)
    End Sub
    Private Sub btn_Load_Click(sender As Object, e As EventArgs) Handles btn_Load.Click
        Module_Save.LoadFile(Module_Values.md_ResourceValue, Module_Values.md_PerSecond, Module_Values.md_ClickValue, Module_Values.md_Worker, Module_Values.md_House, Module_Values.md_Farm, Module_Values.md_Tavern, Module_Values.md_Church, Module_Owned.md_Worker, Module_Owned.md_House, Module_Owned.md_Farm, Module_Owned.md_Tavern, Module_Owned.md_Church, Module_Owned.md_Castle, Module_Prices.md_BuyWorker, Module_Prices.md_BuyHouse, Module_Prices.md_BuyFarm, Module_Prices.md_BuyTavern, Module_Prices.md_BuyChurch, Module_Prices.md_BuyCastle, Module_Prices.md_UpClick, Module_Prices.md_UpWorker, Module_Prices.md_UpHouse, Module_Prices.md_UpFarm, Module_Prices.md_UpTavern, Module_Prices.md_UpChurch, Module_EnemyFrm.md_UserDamage, Module_EnemyFrm.md_UserAttackCost, Module_EnemyFrm.md_EnemyDamage, Module_EnemyFrm.md_EnemyLevel, Module_EnemyFrm.md_EnemyHealth, Module_EnemyFrm.md_EnemyStartHealth, Module_EnemyFrm.md_UpDamagePrice, Module_EnemyFrm.md_DownCostPrice, Module_Achivements.lc_AchievementTrue1, Module_Achivements.lc_AchievementTrue7)
        FrmMain.Show()
        Me.Close()


    End Sub

    'IMAGE DISPLAY
    Private Sub Timer_EnemyPicture_Tick(sender As Object, e As EventArgs) Handles Timer_EnemyPicture.Tick

        If md_UsableEnemyHealth <= Module_EnemyFrm.md_EnemyHealth / 2 Then
            pb_Enemy.Image = My.Resources.Finished_Enemy_50
        End If
        If md_UsableEnemyHealth <= 0 Then
            pb_Enemy.Image = My.Resources.Finished_Enemy_10
        End If

    End Sub
End Class