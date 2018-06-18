Public Class Form1
    Dim nrand, nrand1, nrand2, nrand4, nrand5, nrand6, nrand7 As Integer
    Dim RAN, RAN1, RAN2, RAN3, RAN4, RAN5, RAN6, RAN7, RAN8, RAN9, RAN10, RAN11, RAN12, RAN13, RAN14, RAN15, RAN16, RAN17, RAN18, RAN19, RAN20, RAN21, RAN22, RAN23, RAN24, RAN25, RAN26, RAN27, RAN28, RAN29, RAN30, RAN31, RAN32, RAN33, RAN34, RAN35, RAN36, RAN37, RAN38, RAN39, RAN40, RAN41, RAN42, RAN43, RAN44, RAN45, RAN46, RAN47, RAN48, RAN49, RAN50, RAN51, RAN52, RAN53, RAN54, RAN55, RAN56, RAN57, RAN58, RAN59, RAN60, RAN61, RAN62, RAN63, RAN64, RAN65, RAN66, RAN67, RAN68, RAN69, RAN70, RAN71, RAN72, RAN73, RAN74, RAN75, RAN76, RAN77, RAN78, RAN79 As Integer
    Dim globaltotal, total, total1, total2, comptotal, standtotal, standtotal1, standtotal2 As Integer
    Dim playerbalance, gamble, newgamblevalue As Integer
    Dim blackjack21 As Boolean = False
    Dim block As Boolean = False
    Dim counter As Integer = 0
    Dim counter1 As Integer = 0
    Dim counter2 As Integer = 0
    Dim counter3 As Integer = 0
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        playerbalance = 1000
        lblbalance1.Text = lblbalance1.Text & "$ " & playerbalance
    End Sub
    Private Sub btngamble_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngamble.Click
        gamble = InputBox("enter a value to gamble, range is between 100 to 500")
        If gamble >= 501 Then
            MsgBox("you entered a value that was too high, try again")
            gamble = InputBox("enter a value to gamble, range is between 100 to 500")
        ElseIf gamble <= 99 Then
            MsgBox("you entered a value that was too low, try again")
            gamble = InputBox("enter a value to gamble, range is between 100 to 500")
        End If
        playerbalance = playerbalance - gamble
        lblbalance1.Text = ""
        lblbalance1.Text = lblbalance1.Text & "$ " & playerbalance
        If playerbalance < 0 Then
            MsgBox("Unfortunately You Lack The Sufficient Funds, You are Broke")
            Application.Exit()
        End If
    End Sub
    Private Sub btndeal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeal.Click
        Dim img() As Image = {My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4, My.Resources._5, My.Resources._6, My.Resources._7, My.Resources._8, My.Resources._9, My.Resources._10, My.Resources._11, My.Resources._12, My.Resources._13, My.Resources._14, My.Resources._15, My.Resources._16, My.Resources._17, My.Resources._18, My.Resources._19, My.Resources._20, My.Resources._21, My.Resources._22, My.Resources._23, My.Resources._24, My.Resources._25, My.Resources._26, My.Resources._27, My.Resources._28, My.Resources._29, My.Resources._30, My.Resources._31, My.Resources._32, My.Resources._33, My.Resources._34, My.Resources._35, My.Resources._36, My.Resources._37, My.Resources._38, My.Resources._39, My.Resources._40, My.Resources._41, My.Resources._42, My.Resources._43, My.Resources._44, My.Resources._45, My.Resources._46, My.Resources._47, My.Resources._48, My.Resources._49, My.Resources._50, My.Resources._51, My.Resources._52}
        counter1 = counter1 + 1
        Randomize()
        nrand = Int(10 * Rnd() + 2)
        nrand1 = Int(10 * Rnd() + 2)
        nrand2 = Int(10 * Rnd() + 2)
        RAN = Int(3 * Rnd() + 1)
        RAN1 = Int(3 * Rnd() + 5)
        RAN2 = Int(2 * Rnd() + 9)
        RAN3 = Int(3 * Rnd() + 12)
        RAN4 = Int(3 * Rnd() + 16)
        RAN5 = Int(3 * Rnd() + 20)
        RAN6 = Int(3 * Rnd() + 24)
        RAN7 = Int(3 * Rnd() + 28)
        RAN8 = Int(3 * Rnd() + 32)
        RAN9 = Int(3 * Rnd() + 48)
        RAN10 = Int(3 * Rnd() + 1)
        RAN11 = Int(3 * Rnd() + 5)
        RAN12 = Int(2 * Rnd() + 9)
        RAN13 = Int(3 * Rnd() + 12)
        RAN14 = Int(3 * Rnd() + 16)
        RAN15 = Int(3 * Rnd() + 20)
        RAN16 = Int(3 * Rnd() + 24)
        RAN17 = Int(3 * Rnd() + 28)
        RAN18 = Int(3 * Rnd() + 32)
        RAN19 = Int(3 * Rnd() + 48)
        RAN20 = Int(3 * Rnd() + 1)
        RAN21 = Int(3 * Rnd() + 5)
        RAN22 = Int(2 * Rnd() + 9)
        RAN23 = Int(3 * Rnd() + 12)
        RAN24 = Int(3 * Rnd() + 16)
        RAN25 = Int(3 * Rnd() + 20)
        RAN26 = Int(3 * Rnd() + 24)
        RAN27 = Int(3 * Rnd() + 28)
        RAN28 = Int(3 * Rnd() + 32)
        RAN29 = Int(3 * Rnd() + 48)
        If nrand = 2 Then
            card1.Image = img(RAN)
        ElseIf nrand = 3 Then
            card1.Image = img(RAN1)
        ElseIf nrand = 4 Then
            card1.Image = img(RAN2)
        ElseIf nrand = 5 Then
            card1.Image = img(RAN3)
        ElseIf nrand = 6 Then
            card1.Image = img(RAN4)
        ElseIf nrand = 7 Then
            card1.Image = img(RAN5)
        ElseIf nrand = 8 Then
            card1.Image = img(RAN6)
        ElseIf nrand = 9 Then
            card1.Image = img(RAN7)
        ElseIf nrand = 10 Then
            card1.Image = img(RAN8)
        ElseIf nrand = 11 Then
            card1.Image = img(RAN9)
        End If
        If nrand1 = 2 Then
            card2.Image = img(RAN10)
        ElseIf nrand1 = 3 Then
            card2.Image = img(RAN11)
        ElseIf nrand1 = 4 Then
            card2.Image = img(RAN12)
        ElseIf nrand1 = 5 Then
            card2.Image = img(RAN13)
        ElseIf nrand1 = 6 Then
            card2.Image = img(RAN14)
        ElseIf nrand1 = 7 Then
            card2.Image = img(RAN15)
        ElseIf nrand1 = 8 Then
            card2.Image = img(RAN16)
        ElseIf nrand1 = 9 Then
            card2.Image = img(RAN17)
        ElseIf nrand1 = 10 Then
            card2.Image = img(RAN18)
        ElseIf nrand1 = 11 Then
            card2.Image = img(RAN19)
        End If
        If nrand2 = 2 Then
            card6.Image = img(RAN20)
        ElseIf nrand2 = 3 Then
            card6.Image = img(RAN21)
        ElseIf nrand2 = 4 Then
            card6.Image = img(RAN22)
        ElseIf nrand2 = 5 Then
            card6.Image = img(RAN23)
        ElseIf nrand2 = 6 Then
            card6.Image = img(RAN24)
        ElseIf nrand2 = 7 Then
            card6.Image = img(RAN25)
        ElseIf nrand2 = 8 Then
            card6.Image = img(RAN26)
        ElseIf nrand2 = 9 Then
            card6.Image = img(RAN27)
        ElseIf nrand2 = 10 Then
            card6.Image = img(RAN28)
        ElseIf nrand2 = 11 Then
            card6.Image = img(RAN29)
        End If
        standtotal1 = nrand2
        card7.Image = img(51)
        If nrand + nrand1 = 21 Then
            MsgBox("BlackJack, Congratulations you win")
            blackjack21 = True
            gamble = 2 * gamble
            newgamblevalue = gamble
            block = True
        End If
        If nrand = 11 And nrand + nrand1 >= 22 Then
            nrand = 1
        End If
        If nrand1 = 11 And nrand + nrand1 >= 22 Then
            nrand1 = 1
        End If
        lblbalance1.Text = Nothing
        lblbalance1.Text = lblbalance1.Text & "$ " & (playerbalance + newgamblevalue)
        If block = True And blackjack21 = True Then
            playerbalance = playerbalance + newgamblevalue
        End If
        If counter1 >= 1 Then
            block = False
            blackjack21 = False
        End If
    End Sub

    Private Sub btnstand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstand.Click
        Dim nrand40 As Integer
        Dim img() As Image = {My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4, My.Resources._5, My.Resources._6, My.Resources._7, My.Resources._8, My.Resources._9, My.Resources._10, My.Resources._11, My.Resources._12, My.Resources._13, My.Resources._14, My.Resources._15, My.Resources._16, My.Resources._17, My.Resources._18, My.Resources._19, My.Resources._20, My.Resources._21, My.Resources._22, My.Resources._23, My.Resources._24, My.Resources._25, My.Resources._26, My.Resources._27, My.Resources._28, My.Resources._29, My.Resources._30, My.Resources._31, My.Resources._32, My.Resources._33, My.Resources._34, My.Resources._35, My.Resources._36, My.Resources._37, My.Resources._38, My.Resources._39, My.Resources._40, My.Resources._41, My.Resources._42, My.Resources._43, My.Resources._44, My.Resources._45, My.Resources._46, My.Resources._47, My.Resources._48, My.Resources._49, My.Resources._50, My.Resources._51, My.Resources._52}
        counter2 = counter2 + 1
        Randomize()
        nrand40 = Int(10 * Rnd() + 2)
        'nrand40's value is always the same as nrand2's value for some reason. I have tried to figure out the issue but I cannot see why it doesn't work. The other randomize functions work perfectly fine
        RAN30 = Int(3 * Rnd() + 1)
        RAN31 = Int(3 * Rnd() + 5)
        RAN32 = Int(2 * Rnd() + 9)
        RAN33 = Int(3 * Rnd() + 12)
        RAN34 = Int(3 * Rnd() + 16)
        RAN35 = Int(3 * Rnd() + 20)
        RAN36 = Int(3 * Rnd() + 24)
        RAN37 = Int(3 * Rnd() + 28)
        RAN38 = Int(3 * Rnd() + 32)
        RAN39 = Int(3 * Rnd() + 48)
        RAN50 = Int(3 * Rnd() + 1)
        RAN51 = Int(3 * Rnd() + 5)
        RAN52 = Int(2 * Rnd() + 9)
        RAN53 = Int(3 * Rnd() + 12)
        RAN54 = Int(3 * Rnd() + 16)
        RAN55 = Int(3 * Rnd() + 20)
        RAN56 = Int(3 * Rnd() + 24)
        RAN57 = Int(3 * Rnd() + 28)
        RAN58 = Int(3 * Rnd() + 32)
        RAN59 = Int(3 * Rnd() + 48)
        If nrand40 = 2 Then
            card7.Image = img(RAN30)
        ElseIf nrand40 = 3 Then
            card7.Image = img(RAN31)
        ElseIf nrand40 = 4 Then
            card7.Image = img(RAN32)
        ElseIf nrand40 = 5 Then
            card7.Image = img(RAN33)
        ElseIf nrand40 = 6 Then
            card7.Image = img(RAN34)
        ElseIf nrand40 = 7 Then
            card7.Image = img(RAN35)
        ElseIf nrand40 = 8 Then
            card7.Image = img(RAN36)
        ElseIf nrand40 = 9 Then
            card7.Image = img(RAN37)
        ElseIf nrand40 = 10 Then
            card7.Image = img(RAN38)
        ElseIf nrand40 = 11 Then
            card7.Image = img(RAN39)
        End If
        If nrand2 = 11 And nrand2 + nrand40 > 21 Then
            nrand2 = 1
        End If
        If nrand40 = 11 And nrand40 + nrand2 > 21 Then
            nrand40 = 1
        End If
        standtotal1 = nrand40
        If nrand2 + nrand40 <= 17 Then
            Randomize()
            nrand5 = Int(10 * Rnd() + 2)
            If nrand5 = 2 Then
                card8.Image = img(RAN50)
            ElseIf nrand5 = 3 Then
                card8.Image = img(RAN51)
            ElseIf nrand5 = 4 Then
                card8.Image = img(RAN52)
            ElseIf nrand5 = 5 Then
                card8.Image = img(RAN53)
            ElseIf nrand5 = 6 Then
                card8.Image = img(RAN54)
            ElseIf nrand5 = 7 Then
                card8.Image = img(RAN55)
            ElseIf nrand5 = 8 Then
                card8.Image = img(RAN56)
            ElseIf nrand5 = 9 Then
                card8.Image = img(RAN57)
            ElseIf nrand5 = 10 Then
                card8.Image = img(RAN58)
            ElseIf nrand5 = 11 Then
                card8.Image = img(RAN59)
            End If
            If nrand2 + nrand40 + nrand5 > 21 And nrand5 = 11 Then
                nrand5 = 1
            ElseIf nrand2 + nrand40 + nrand5 > 21 And nrand40 = 11 Then
                nrand40 = 1
            ElseIf nrand2 + nrand40 + nrand5 > 21 And nrand2 = 11 Then
                nrand40 = 1
            End If
            If nrand2 + nrand40 + nrand5 = 21 Then
                MsgBox("BlackJack, The computer has won")
                gamble = 0
                newgamblevalue = gamble
                block = True
            End If
            If nrand2 + nrand40 + nrand5 > 21 Then
                MsgBox("BUST, computer got over 21 and so you have won")
                gamble = 2 * gamble
                newgamblevalue = gamble
                blackjack21 = True
            End If
            standtotal2 = nrand5
        End If
        If blackjack21 = False Then
            If globaltotal > comptotal Then
                MsgBox("you win, you got a higher number")
                gamble = 2 * gamble
                newgamblevalue = gamble
                block = True
                blackjack21 = True
            ElseIf comptotal > globaltotal Then
                MsgBox("you lost, computer got a higher number")
                gamble = 0
                newgamblevalue = gamble
            End If
        End If
        comptotal = standtotal + standtotal1 + standtotal2
        lblbalance1.Text = Nothing
        lblbalance1.Text = lblbalance1.Text & "$ " & (playerbalance + newgamblevalue)
        If block = True And blackjack21 = True Then
            playerbalance = playerbalance + newgamblevalue
        End If
        If counter2 >= 1 Then
            block = False
            blackjack21 = False
        End If
    End Sub

    Private Sub btnhit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhit.Click
        Dim img() As Image = {My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4, My.Resources._5, My.Resources._6, My.Resources._7, My.Resources._8, My.Resources._9, My.Resources._10, My.Resources._11, My.Resources._12, My.Resources._13, My.Resources._14, My.Resources._15, My.Resources._16, My.Resources._17, My.Resources._18, My.Resources._19, My.Resources._20, My.Resources._21, My.Resources._22, My.Resources._23, My.Resources._24, My.Resources._25, My.Resources._26, My.Resources._27, My.Resources._28, My.Resources._29, My.Resources._30, My.Resources._31, My.Resources._32, My.Resources._33, My.Resources._34, My.Resources._35, My.Resources._36, My.Resources._37, My.Resources._38, My.Resources._39, My.Resources._40, My.Resources._41, My.Resources._42, My.Resources._43, My.Resources._44, My.Resources._45, My.Resources._46, My.Resources._47, My.Resources._48, My.Resources._49, My.Resources._50, My.Resources._51, My.Resources._52}
        counter = counter + 1
        counter3 = counter3 + 1
        Randomize()
        RAN40 = Int(3 * Rnd() + 1)
        RAN41 = Int(3 * Rnd() + 5)
        RAN42 = Int(2 * Rnd() + 9)
        RAN43 = Int(3 * Rnd() + 12)
        RAN44 = Int(3 * Rnd() + 16)
        RAN45 = Int(3 * Rnd() + 20)
        RAN46 = Int(3 * Rnd() + 24)
        RAN47 = Int(3 * Rnd() + 28)
        RAN48 = Int(3 * Rnd() + 32)
        RAN49 = Int(3 * Rnd() + 48)
        RAN60 = Int(3 * Rnd() + 1)
        RAN61 = Int(3 * Rnd() + 5)
        RAN62 = Int(2 * Rnd() + 9)
        RAN63 = Int(3 * Rnd() + 12)
        RAN64 = Int(3 * Rnd() + 16)
        RAN65 = Int(3 * Rnd() + 20)
        RAN66 = Int(3 * Rnd() + 24)
        RAN67 = Int(3 * Rnd() + 28)
        RAN68 = Int(3 * Rnd() + 32)
        RAN69 = Int(3 * Rnd() + 48)
        RAN70 = Int(3 * Rnd() + 1)
        RAN71 = Int(3 * Rnd() + 5)
        RAN72 = Int(2 * Rnd() + 9)
        RAN73 = Int(3 * Rnd() + 12)
        RAN74 = Int(3 * Rnd() + 16)
        RAN75 = Int(3 * Rnd() + 20)
        RAN76 = Int(3 * Rnd() + 24)
        RAN77 = Int(3 * Rnd() + 28)
        RAN78 = Int(3 * Rnd() + 32)
        RAN79 = Int(3 * Rnd() + 48)
        If counter = 1 Then
            Randomize()
            nrand4 = Int(10 * Rnd() + 2)
            If nrand4 = 2 Then
                card3.Image = img(RAN40)
            ElseIf nrand4 = 3 Then
                card3.Image = img(RAN41)
            ElseIf nrand4 = 4 Then
                card3.Image = img(RAN42)
            ElseIf nrand4 = 5 Then
                card3.Image = img(RAN43)
            ElseIf nrand4 = 6 Then
                card3.Image = img(RAN44)
            ElseIf nrand4 = 7 Then
                card3.Image = img(RAN45)
            ElseIf nrand4 = 8 Then
                card3.Image = img(RAN46)
            ElseIf nrand4 = 9 Then
                card3.Image = img(RAN47)
            ElseIf nrand4 = 10 Then
                card3.Image = img(RAN48)
            ElseIf nrand4 = 11 Then
                card3.Image = img(RAN49)
            End If
            If nrand + nrand1 + nrand4 > 21 And nrand = 11 Then
                nrand = 1
            ElseIf nrand + nrand1 + nrand4 > 21 And nrand1 = 11 Then
                nrand1 = 1
            ElseIf nrand + nrand1 + nrand4 > 21 And nrand4 = 11 Then
                nrand4 = 1
            End If
            If nrand + nrand1 + nrand4 > 21 Then
                MsgBox("BUST, you got over 21 and have lost")
                gamble = 0
                newgamblevalue = gamble
            End If
            If nrand + nrand1 + nrand4 = 21 Then
                MsgBox("Blackjack, Congratulations you have won")
                gamble = 2 * gamble
                newgamblevalue = gamble
                blackjack21 = True
                block = True
            End If
            total = nrand + nrand1 + nrand4
        End If
        If counter = 2 Then
            Randomize()
            nrand6 = Int(10 * Rnd() + 2)
            If nrand6 = 2 Then
                card4.Image = img(RAN60)
            ElseIf nrand6 = 3 Then
                card4.Image = img(RAN61)
            ElseIf nrand6 = 4 Then
                card4.Image = img(RAN62)
            ElseIf nrand6 = 5 Then
                card4.Image = img(RAN63)
            ElseIf nrand6 = 6 Then
                card4.Image = img(RAN64)
            ElseIf nrand6 = 7 Then
                card4.Image = img(RAN65)
            ElseIf nrand6 = 8 Then
                card4.Image = img(RAN66)
            ElseIf nrand6 = 9 Then
                card4.Image = img(RAN67)
            ElseIf nrand6 = 10 Then
                card4.Image = img(RAN68)
            ElseIf nrand6 = 11 Then
                card4.Image = img(RAN69)
            End If
            If nrand + nrand1 + nrand4 + nrand6 > 21 And nrand6 = 11 Then
                nrand6 = 1
            End If
            If nrand + nrand1 + nrand4 + nrand6 > 21 Then
                MsgBox("BUST, you got over 21 and have lost")
                gamble = 0
                newgamblevalue = gamble
            ElseIf nrand + nrand1 + nrand4 + nrand6 = 21 Then
                MsgBox("Blackjack, Congratulations you have won")
                blackjack21 = True
                gamble = 2 * gamble
                newgamblevalue = gamble
                block = True
            End If
            total1 = nrand6
        End If
        If counter = 3 Then
            Randomize()
            nrand7 = Int(10 * Rnd() + 2)
            If nrand7 = 2 Then
                card5.Image = img(RAN70)
            ElseIf nrand7 = 3 Then
                card5.Image = img(RAN71)
            ElseIf nrand7 = 4 Then
                card5.Image = img(RAN72)
            ElseIf nrand7 = 5 Then
                card5.Image = img(RAN73)
            ElseIf nrand7 = 6 Then
                card5.Image = img(RAN74)
            ElseIf nrand7 = 7 Then
                card5.Image = img(RAN75)
            ElseIf nrand7 = 8 Then
                card5.Image = img(RAN76)
            ElseIf nrand7 = 9 Then
                card5.Image = img(RAN77)
            ElseIf nrand7 = 10 Then
                card5.Image = img(RAN78)
            ElseIf nrand7 = 11 Then
                card5.Image = img(RAN79)
            End If
            If nrand + nrand1 + nrand4 + nrand6 + nrand7 > 21 And nrand7 = 11 Then
                nrand7 = 1
            End If
            If nrand + nrand1 + nrand4 + nrand6 + nrand7 > 21 Then
                MsgBox("BUST, you got over 21 and have lost")
                gamble = 0
                newgamblevalue = gamble
            ElseIf nrand + nrand1 + nrand4 + nrand6 + nrand7 = 21 Then
                MsgBox("Blackjack, Congratulations you have won")
                blackjack21 = True
                gamble = 2 * gamble
                newgamblevalue = gamble
                block = True
            End If
            total2 = nrand7
        End If
        globaltotal = total + total1 + total2
        lblbalance1.Text = Nothing
        lblbalance1.Text = lblbalance1.Text & "$ " & (playerbalance + newgamblevalue)
        If block = True And blackjack21 = True Then
            playerbalance = playerbalance + newgamblevalue
        End If
        If counter3 >= 1 Then
            block = False
            blackjack21 = False
        End If
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        counter = 0
        nrand = 0
        nrand1 = 0
        nrand2 = 0
        nrand4 = 0
        nrand5 = 0
        nrand6 = 0
        nrand7 = 0
        RAN = 0
        RAN1 = 0
        RAN2 = 0
        RAN3 = 0
        RAN4 = 0
        RAN5 = 0
        RAN6 = 0
        RAN7 = 0
        RAN8 = 0
        RAN9 = 0
        RAN10 = 0
        RAN11 = 0
        RAN12 = 0
        RAN13 = 0
        RAN14 = 0
        RAN15 = 0
        RAN16 = 0
        RAN17 = 0
        RAN18 = 0
        RAN19 = 0
        RAN20 = 0
        RAN21 = 0
        RAN22 = 0
        RAN23 = 0
        RAN24 = 0
        RAN25 = 0
        RAN26 = 0
        RAN27 = 0
        RAN28 = 0
        RAN29 = 0
        RAN30 = 0
        RAN31 = 0
        RAN32 = 0
        RAN33 = 0
        RAN34 = 0
        RAN35 = 0
        RAN36 = 0
        RAN37 = 0
        RAN38 = 0
        RAN39 = 0
        RAN50 = 0
        RAN51 = 0
        RAN52 = 0
        RAN53 = 0
        RAN54 = 0
        RAN55 = 0
        RAN56 = 0
        RAN57 = 0
        RAN58 = 0
        RAN59 = 0
        RAN40 = 0
        RAN41 = 0
        RAN42 = 0
        RAN43 = 0
        RAN44 = 0
        RAN45 = 0
        RAN46 = 0
        RAN47 = 0
        RAN48 = 0
        RAN49 = 0
        RAN60 = 0
        RAN61 = 0
        RAN62 = 0
        RAN63 = 0
        RAN64 = 0
        RAN65 = 0
        RAN66 = 0
        RAN67 = 0
        RAN68 = 0
        RAN69 = 0
        RAN70 = 0
        RAN71 = 0
        RAN72 = 0
        RAN73 = 0
        RAN74 = 0
        RAN75 = 0
        RAN76 = 0
        RAN77 = 0
        RAN78 = 0
        RAN79 = 0
        card1.Image = Nothing
        card2.Image = Nothing
        card3.Image = Nothing
        card4.Image = Nothing
        card5.Image = Nothing
        card6.Image = Nothing
        card7.Image = Nothing
        card8.Image = Nothing
    End Sub
End Class
