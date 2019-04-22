Module Module_Values

    'Money/Points/Total
    Public md_ResourceValue As Decimal = 0

    'Value that the items add onto
    Public md_PerSecond As Decimal = 0

    'Users Input
    Public md_ClickValue As Decimal = 1

    'Items Value
    Public md_Worker As Decimal = 0.5

    Public md_House As Decimal = 1

    Public md_Farm As Decimal = 10

    Public md_Tavern As Decimal = 50

    Public md_Church As Decimal = 300

    Public md_Castle As Decimal = 2000


    'When Upgrades purchased, multiply items by this
    Public md_ValueIncrease As Decimal = 1.2


    Public Sub ReUpdatePerSecond()
        Dim lc_Worker As Decimal
        Dim lc_House As Decimal
        Dim lc_Farm As Decimal
        Dim lc_Tavern As Decimal
        Dim lc_Church As Decimal
        Dim lc_Castle As Decimal

        lc_Worker = Module_Values.md_Worker * Module_Owned.md_Worker
        lc_House = Module_Values.md_House * Module_Owned.md_House
        lc_Farm = Module_Values.md_Farm * Module_Owned.md_Farm
        lc_Tavern = Module_Values.md_Tavern * Module_Owned.md_Tavern
        lc_Church = Module_Values.md_Church * Module_Owned.md_Church
        lc_Castle = Module_Values.md_Castle * Module_Owned.md_Castle

        Module_Values.md_PerSecond = lc_Worker + lc_House + lc_Farm + lc_Tavern + lc_Church + lc_Castle
    End Sub
End Module
