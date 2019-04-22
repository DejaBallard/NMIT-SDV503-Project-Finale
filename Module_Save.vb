Module Module_Save
    Dim md_Filename As String
    Dim md_Savefile As String

    'ADD ACHIVEMENTS!
    'ADD ALL OWNED
    'ADD CLICKS OWNED

    Public Sub SaveFileAs(ByVal pr01ValueResources, ByVal pr02ValuePerSecond, ByVal pr03ValueClick, ByVal pr04ValueWorker, ByVal pr05ValueHouse, ByVal pr06ValueFarm, ByVal pr07ValueTavern, ByVal pr08ValueChurch, ByVal pr09OwnedWorker, ByVal pr10OwnedHouse, ByVal pr11OwnedFarm, ByVal pr12OwnedTavern, ByVal pr13OwnedChurch, ByVal pr14OwnedCastle, ByVal pr15PriceBuyWorker, ByVal pr16PriceBuyHouse, ByVal pr17PriceBuyFarm, ByVal pr18PriceBuyTavern, ByVal pr19PriceBuyChurch, ByVal pr20PriceBuyCastle, ByVal pr21PriceUpClick, ByVal pr22PriceUpWorker, ByVal pr23PriceUpHouse, ByVal pr24PriceUpFarm, ByVal pr25PriceUpTavern, ByVal pr26PriceUpChurch, ByVal pr27UserDamage, ByVal pr28UserAttackCost, ByVal pr29EnemyDamage, ByVal pr30EnemyLevel, ByVal pr31EnemyHealth, ByVal pr32EnemyStartHealth, ByVal pr33UpWeaponPrice, ByVal pr34UpArmyPrice, ByVal pr35Achievement1, ByVal pr36)

        '26 Save items
        'They have been numbered to make sure all are used correctley
        'False = Delete and replace
        'True = Just add

        md_Filename = InputBox("Enter a file name to save as:", "Save Game")

        md_Filename = "\" & md_Filename & ".txt"

        If md_Filename = "\.txt" Then
            MessageBox.Show("Please enter a name to your save file.")

        Else md_Savefile = My.Computer.FileSystem.SpecialDirectories.MyDocuments & md_Filename

            'Saving Vaules
            My.Computer.FileSystem.WriteAllText(md_Savefile,
                                                pr01ValueResources & ",", False)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
                                    pr02ValuePerSecond & ",", True)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
                                    pr03ValueClick & ",", True)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
                                    pr04ValueWorker & ",", True)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
                                    pr05ValueHouse & ",", True)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
                                    pr06ValueFarm & ",", True)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
                                    pr07ValueTavern & ",", True)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
                                    pr08ValueChurch & ",", True)


            'Saving Owned
            My.Computer.FileSystem.WriteAllText(md_Savefile,
                                    pr09OwnedWorker & ",", True)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
                                    pr10OwnedHouse & ",", True)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
                                    pr11OwnedFarm & ",", True)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
                                    pr12OwnedTavern & ",", True)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
                                    pr13OwnedChurch & ",", True)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
                                    pr14OwnedCastle & ",", True)


            'Saving Buy Prices
            My.Computer.FileSystem.WriteAllText(md_Savefile,
                                    pr15PriceBuyWorker & ",", True)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
                                    pr16PriceBuyHouse & ",", True)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
                                    pr17PriceBuyFarm & ",", True)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
                                    pr18PriceBuyTavern & ",", True)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
                                    pr19PriceBuyChurch & ",", True)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
                                    pr20PriceBuyCastle & ",", True)



            'Saving Upgrade Prices

            My.Computer.FileSystem.WriteAllText(md_Savefile,
                                    pr21PriceUpClick & ",", True)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
                                    pr22PriceUpWorker & ",", True)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
                                    pr23PriceUpHouse & ",", True)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
                                    pr24PriceUpFarm & ",", True)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
                                    pr25PriceUpTavern & ",", True)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
            pr26PriceUpChurch & ",", True)

            'Enemy From

            My.Computer.FileSystem.WriteAllText(md_Savefile,
            pr27UserDamage & ",", True)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
            pr28UserAttackCost & ",", True)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
            pr29EnemyDamage & ",", True)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
            pr30EnemyLevel & ",", True)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
            pr31EnemyHealth & ",", True)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
            pr32EnemyStartHealth & ",", True)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
            pr33UpWeaponPrice & ",", True)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
pr34UpArmyPrice & ",", True)

            My.Computer.FileSystem.WriteAllText(md_Savefile,
pr35Achievement1 & ",", True)
            My.Computer.FileSystem.WriteAllText(md_Savefile,
pr36, True)

        End If
    End Sub

    Public Sub LoadFile(ByRef pr01ValueResources, ByRef pr02ValuePerSecond, ByRef pr03ValueClick, ByRef pr04ValueWorker, ByRef pr05ValueHouse, ByRef pr06ValueFarm, ByRef pr07ValueTavern, ByRef pr08ValueChurch, ByRef pr09OwnedWorker, ByRef pr10OwnedHouse, ByRef pr11OwnedFarm, ByRef pr12OwnedTavern, ByRef pr13OwnedChurch, ByRef pr14OwnedCastle, ByRef pr15PriceBuyWorker, ByRef pr16PriceBuyHouse, ByRef pr17PriceBuyFarm, ByRef pr18PriceBuyTavern, ByRef pr19PriceBuyChurch, ByRef pr20PriceBuyCastle, ByRef pr21PriceUpClick, ByRef pr22PriceUpWorker, ByRef pr23PriceUpHouse, ByRef pr24PriceUpFarm, ByRef pr25PriceUpTavern, ByRef pr26PriceUpChurch, ByRef pr27UserDamage, ByRef pr28UserAttackCost, ByRef pr29EnemyDamage, ByRef pr30EnemyLevel, ByRef pr31EnemyHealth, ByRef pr32EnemyStartHealth, ByRef pr33UpWeaponPrice, ByRef pr34UpArmyPrice, ByRef pr35Achievement1, ByRef pr36)
        md_Filename = InputBox("Enter your saved file name: ", "Load Game", "Type name here.")

        md_Filename = "\" & md_Filename & ".txt"

        md_Savefile = My.Computer.FileSystem.SpecialDirectories.MyDocuments & md_Filename

        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(md_Savefile)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")

            Dim CurrentRow As String()

            While Not MyReader.EndOfData
                Try

                    CurrentRow = MyReader.ReadFields()

                    Dim CurrentField As String

                    Dim VairablesInSaveFileCounter As Integer = 0

                    For Each CurrentField In CurrentRow
                        Select Case VairablesInSaveFileCounter
                            Case 0
                                pr01ValueResources = CurrentField
                            Case 1
                                pr02ValuePerSecond = CurrentField
                            Case 2
                                pr03ValueClick = CurrentField

                            Case 3
                                pr04ValueWorker = CurrentField
                            Case 4
                                pr05ValueHouse = CurrentField
                            Case 5
                                pr06ValueFarm = CurrentField
                            Case 6
                                pr07ValueTavern = CurrentField
                            Case 7
                                pr08ValueChurch = CurrentField
                            Case 8
                                pr09OwnedWorker = CurrentField
                            Case 9
                                pr10OwnedHouse = CurrentField
                            Case 10
                                pr11OwnedFarm = CurrentField
                            Case 11
                                pr12OwnedTavern = CurrentField
                            Case 12
                                pr13OwnedChurch = CurrentField
                            Case 13
                                pr14OwnedCastle = CurrentField
                            Case 14
                                pr15PriceBuyWorker = CurrentField
                            Case 15
                                pr16PriceBuyHouse = CurrentField
                            Case 16
                                pr17PriceBuyFarm = CurrentField
                            Case 17
                                pr18PriceBuyTavern = CurrentField
                            Case 18
                                pr19PriceBuyChurch = CurrentField
                            Case 19
                                pr20PriceBuyCastle = CurrentField
                            Case 20
                                pr21PriceUpClick = CurrentField
                            Case 21
                                pr22PriceUpWorker = CurrentField
                            Case 22
                                pr23PriceUpHouse = CurrentField
                            Case 23
                                pr24PriceUpFarm = CurrentField
                            Case 24
                                pr25PriceUpTavern = CurrentField
                            Case 25
                                pr26PriceUpChurch = CurrentField
                            Case 26
                                pr27UserDamage = CurrentField
                            Case 27
                                pr28UserAttackCost = CurrentField
                            Case 28
                                pr29EnemyDamage = CurrentField
                            Case 29
                                pr30EnemyLevel = CurrentField
                            Case 30
                                pr31EnemyHealth = CurrentField
                            Case 31
                                pr32EnemyStartHealth = CurrentField
                            Case 32
                                pr33UpWeaponPrice = CurrentField
                            Case 33
                                pr34UpArmyPrice = CurrentField
                            Case 34
                                pr35Achievement1 = CurrentField
                            Case 34
                                pr36 = CurrentField
                        End Select

                        VairablesInSaveFileCounter = VairablesInSaveFileCounter + 1

                    Next


                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException


                End Try
            End While
        End Using
    End Sub
End Module
