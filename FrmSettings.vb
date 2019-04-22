Public Class FrmSettings
    'ON LOAD
    Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideAll()


    End Sub
    'INSRUCTIONS
    Private Sub btn_Instructions_Click(sender As Object, e As EventArgs) Handles btn_Instructions.Click
        HideAll()

        lbl_Instructions.Show()
    End Sub

    'STATS
    Private Sub btn_Stats_Click(sender As Object, e As EventArgs) Handles btn_Stats.Click
        HideAll()
        lbl_Stats.Text = ("STATS:
Workers Owned: " & Module_Owned.md_Worker &
"
Workers Value: " & Module_Values.md_Worker &
"

Houses Owned: " & Module_Owned.md_House &
"
Houses Value: " & Module_Values.md_House &
"

Farms Owned: " & Module_Owned.md_Farm &
"
Farms Value: " & Module_Values.md_Farm &
"

Tavern Owned: " & Module_Owned.md_Tavern &
"
Tavern Value: " & Module_Values.md_Tavern &
"

Church Owned: " & Module_Owned.md_Church &
"
Church Value: " & Module_Values.md_Church &
"

Castles Owned: " & Module_Owned.md_Castle &
"
Castles Value: " & Module_Values.md_Castle &
"

Click Value: " & Module_Values.md_ClickValue)

        lbl_Stats.Show()

    End Sub


    'CHEATS
    Private Sub btn_Cheats_Click(sender As Object, e As EventArgs) Handles btn_Cheats.Click
        HideAll()

        lbl_Cheats.Show()
        btn_CWorker.Show()
        btn_CHouse.Show()
        btn_CFarm.Show()
        btn_CTavern.Show()
        btn_CChurch.Show()
        btn_CCastle.Show()
    End Sub
    Private Sub btn_CWorker_Click(sender As Object, e As EventArgs) Handles btn_CWorker.Click
        Module_Owned.md_Worker = Module_Owned.md_Worker + 1
        Module_Values.ReUpdatePerSecond()

    End Sub
    Private Sub btn_CHouse_Click(sender As Object, e As EventArgs) Handles btn_CHouse.Click
        Module_Owned.md_House = Module_Owned.md_House + 1
        Module_Values.ReUpdatePerSecond()
    End Sub
    Private Sub btn_CFarm_Click(sender As Object, e As EventArgs) Handles btn_CFarm.Click
        Module_Owned.md_Farm = Module_Owned.md_Farm + 1
        Module_Values.ReUpdatePerSecond()
    End Sub
    Private Sub btn_CTavern_Click(sender As Object, e As EventArgs) Handles btn_CTavern.Click
        Module_Owned.md_Tavern = Module_Owned.md_Tavern + 1
        Module_Values.ReUpdatePerSecond()
    End Sub
    Private Sub btn_CChurch_Click(sender As Object, e As EventArgs) Handles btn_CChurch.Click
        Module_Owned.md_Church = Module_Owned.md_Castle + 1
        Module_Values.ReUpdatePerSecond()
    End Sub
    Private Sub btn_CCastle_Click(sender As Object, e As EventArgs) Handles btn_CCastle.Click
        Module_Owned.md_Castle = Module_Owned.md_Castle + 1
        Module_Values.ReUpdatePerSecond()
    End Sub
    Private Sub btn_Return_Click(sender As Object, e As EventArgs) Handles btn_Return.Click
        Me.Close()

    End Sub

    'HIDEALL
    Private Sub HideAll()
        lbl_Stats.Hide()
        lbl_Cheats.Hide()
        lbl_Instructions.Hide()
        lbl_Achivements.Hide()

        btn_CWorker.Hide()
        btn_CHouse.Hide()
        btn_CFarm.Hide()
        btn_CTavern.Hide()
        btn_CChurch.Hide()
        btn_CCastle.Hide()
        lBox_Achivements.Hide()

    End Sub

    'ACHIEVEMENTS
    Private Sub btn_Achivements_Click(sender As Object, e As EventArgs) Handles btn_Achivements.Click
        HideAll()
        lbl_Achivements.Show()
        lBox_Achivements.Show()


        Dim lc_ItemList As New ArrayList
        Dim lc_UserProgress As New ArrayList
        Dim lc_TrueFalseList As New ArrayList

        'ACHIEVEMENT GOAL LIST
        lc_ItemList.Add(Module_Achivements.md_Achivement1)
        lc_ItemList.Add(Module_Achivements.md_Achivement2)
        lc_ItemList.Add(Module_Achivements.md_Achivement3)
        lc_ItemList.Add(Module_Achivements.md_Achivement4)
        lc_ItemList.Add(Module_Achivements.md_Achivement5)
        lc_ItemList.Add(Module_Achivements.md_Achivement6)
        lc_ItemList.Add(Module_Achivements.md_Achivement7)
        lc_ItemList.Add(Module_Achivements.md_Achivement8)
        lc_ItemList.Add(Module_Achivements.md_Achivement9)

        'USER PROGRESS LIST
        lc_UserProgress.Add(Module_Values.md_ResourceValue)
        lc_UserProgress.Add(Module_Values.md_ResourceValue)
        lc_UserProgress.Add(Module_Values.md_ResourceValue)
        lc_UserProgress.Add(Module_Owned.md_All)
        lc_UserProgress.Add(Module_Owned.md_All)
        lc_UserProgress.Add(Module_Owned.md_All)
        lc_UserProgress.Add(Module_Owned.md_Click)
        lc_UserProgress.Add(Module_Owned.md_Click)
        lc_UserProgress.Add(Module_Owned.md_Click)

        'TRUE OR FALSE LIST
        lc_TrueFalseList.Add(Module_Achivements.lc_AchievementTrue1)
        lc_TrueFalseList.Add(Module_Achivements.lc_AchievementTrue2)
        lc_TrueFalseList.Add(Module_Achivements.lc_AchievementTrue3)
        lc_TrueFalseList.Add(Module_Achivements.lc_AchievementTrue4)
        lc_TrueFalseList.Add(Module_Achivements.lc_AchievementTrue5)
        lc_TrueFalseList.Add(Module_Achivements.lc_AchievementTrue6)
        lc_TrueFalseList.Add(Module_Achivements.lc_AchievementTrue7)
        lc_TrueFalseList.Add(Module_Achivements.lc_AchievementTrue8)
        lc_TrueFalseList.Add(Module_Achivements.lc_AchievementTrue9)


        For lc_AchivementCounter As Integer = 0 To lc_ItemList.Count - 1

            Dim lc_TrueFalseCounter As Integer

            'IF TRUE
            If lc_TrueFalseList(lc_TrueFalseCounter) = True Then

                'IF First three lines
                If lc_AchivementCounter < 3 Then
                    lBox_Achivements.Items.Add("Collect " & lc_ItemList.Item(lc_AchivementCounter) & " Resources - Finished")

                    'If next three lines
                ElseIf lc_AchivementCounter >= 3 And lc_AchivementCounter < 6 Then
                    lBox_Achivements.Items.Add("Buy " & lc_ItemList.Item(lc_AchivementCounter) & " Items - Finished")

                    'If last three lines
                ElseIf lc_AchivementCounter >= 6 And lc_AchivementCounter < 10 Then
                    lBox_Achivements.Items.Add("Click " & lc_ItemList.Item(lc_AchivementCounter) & " Times - Finished")
                End If


                'IF FALSE
            ElseIf lc_TrueFalseList(lc_TrueFalseCounter) = False Then

                'IF first three lines
                If lc_AchivementCounter < 3 Then
                    lBox_Achivements.Items.Add("Collect " & lc_ItemList.Item(lc_AchivementCounter) & " Resources - Unfinished")

                    'IF next three lines
                ElseIf lc_AchivementCounter >= 3 And lc_AchivementCounter < 6 Then
                    lBox_Achivements.Items.Add("Buy " & lc_ItemList.Item(lc_AchivementCounter) & " Items - Unfinished")

                    'IF last three lines
                ElseIf lc_AchivementCounter >= 6 And lc_AchivementCounter < 10 Then
                    lBox_Achivements.Items.Add("Click " & lc_ItemList.Item(lc_AchivementCounter) & " Times - Unfinished")
                End If
            End If

            lc_TrueFalseCounter = lc_TrueFalseCounter + 1

            If lc_TrueFalseCounter > 9 Then
                lc_TrueFalseCounter = 0
            End If
        Next

    End Sub


End Class