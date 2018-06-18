Public Class form3
    ' Choosing random symbols for each square. 
    Private NewRandom As New Random

    ' Each of these letters is a symbol in the Webdings font and each letter must appear twice in this list
    Private symbol = New List(Of String) From {"q", "q", "w", "w", "e", "e", "r", "r", "t", "t", "y", "y", "u", "u", "i", "i", "o", "o", "p", "p",
                                               "a", "a", "s", "s", "d", "d", "f", "f", "g", "g", "h", "h", "j", "j", "k", "k", "l", "l",
                                               "z", "z", "x", "x", "c", "c", "v", "v", "b", "b", "n", "n", "m", "m", ",", ",", "!", "!"}

    ' firstClicked points to the first label control   
    ' that the player clicks, but it will be Nothing   
    ' if the player hasn't clicked a label yet. 
    Private firstClicked As Label = Nothing

    ' secondClicked points to the second label control   
    ' that the player clicks. 
    Private secondClicked As Label = Nothing

    Private Sub form3_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        AssignSymbolsToLabels() 'When the program starts, this statement runs Private Sub AssignsymbolsToLabels() which is defined below
    End Sub

    ''' Assign each symbol from the list of symbols to a random square. 
    Private Sub AssignSymbolsToLabels()

        For Each control In TLP.Controls 'TLP is the Table Layout Panel
            Dim symbolLabel = TryCast(control, Label) 'This line converts the control variable to a label named symbolLabel

            If symbolLabel IsNot Nothing Then ' This if statement checks if the conversion worked. If it does, the statements in the if statement run.
                Dim randomNumber = NewRandom.Next(symbol.Count)
                symbolLabel.Text = symbol(randomNumber) ' There are some random numbers created that correspond to one of the items in the symbols list
                symbolLabel.ForeColor = symbolLabel.BackColor ' This statement assigns one of the symbol list items to the Text property of the label.
                symbol.RemoveAt(randomNumber) ' This statement removes from the list the symbol that has been added to the form.

            End If
        Next
    End Sub


    Private Sub label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click,
       Label2.Click, Label3.Click, Label4.Click, Label5.Click, Label6.Click, Label7.Click, Label8.Click,
    Label9.Click, Label10.Click, Label11.Click, Label12.Click, Label13.Click, Label14.Click, Label15.Click, Label16.Click,
    Label17.Click, Label18.Click, Label19.Click, Label20.Click, Label21.Click, Label22.Click, Label23.Click, Label24.Click,
    Label25.Click, Label26.Click, Label27.Click, Label28.Click, Label29.Click, Label30.Click, Label31.Click, Label32.Click,
    Label33.Click, Label34.Click, Label35.Click, Label36.Click, Label37.Click, Label38.Click, Label39.Click, Label40.Click,
    Label41.Click, Label42.Click, Label43.Click, Label44.Click, Label45.Click, Label46.Click, Label47.Click, Label48.Click,
    Label49.Click, Label50.Click, Label51.Click, Label52.Click, Label53.Click, Label54.Click, Label55.Click, Label56.Click


        If Timer1.Enabled Then Exit Sub

        Dim clickedLabel = TryCast(sender, Label)

        If clickedLabel IsNot Nothing Then
            'If the player click to a revealed (black) label, this click is ignored.
            If clickedLabel.ForeColor = Color.Black Then Exit Sub

            'This statement changes the color of first clicked label to black
            If firstClicked Is Nothing Then
                firstClicked = clickedLabel
                firstClicked.ForeColor = Color.Black
                Exit Sub
            End If

            ' If the player gets this far, the timer isn't 
            ' running and firstClicked isn't Nothing, 
            ' so this must be the second symbol the player clicked
            ' Set its color to black
            secondClicked = clickedLabel
            secondClicked.ForeColor = Color.Black

            CheckForWinner()
            ' When the player matched two of the symbols, these statements keep them 
            ' black and reset firstClicked and secondClicked so the player can click another symbol

            If firstClicked.Text = secondClicked.Text Then
                firstClicked = Nothing
                secondClicked = Nothing
                Exit Sub
            End If

            ' If the player gets this far and clicked two different symbols,
            ' so start the timer.
            ' Timer's interval is 100 so it will wait 100 miliseconds, and then symbols will be hidden.

            Timer1.Start()

        End If
    End Sub


    'This timer is started when the player clicks two symbols that don't match.
    'so it counts 0.1 second  and then turns itself off and hides both symbols

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        ' Stop the timer
        Timer1.Stop()

        ' Hide both symbols
        firstClicked.ForeColor = firstClicked.BackColor
        secondClicked.ForeColor = secondClicked.BackColor

        ' Reset firstClicked and secondClicked 
        ' so the next time a label is
        ' clicked, the program knows it's the first click
        firstClicked = Nothing
        secondClicked = Nothing
    End Sub


    'Every symbol can be checked 
    ''' Check every symbol to see if it is matched, by   
    ''' comparing its foreground color to its background color.   
    ''' If all of the symbols are matched, the player wins. 

    Private Sub CheckForWinner()

        ' Go through all of the labels in the TableLayoutPanel, 
        ' checking each one to see if its symbol is matched
        For Each control In TLP.Controls
            Dim symbolLabel = TryCast(control, Label)
            If symbolLabel IsNot Nothing AndAlso
               symbolLabel.ForeColor = symbolLabel.BackColor Then Exit Sub
        Next

        ' If the loop didn't return, that means it didn't find any unmatched symbols and user won.
        MessageBox.Show("All the symbols are matched!", "Congratulations")
        Close()
    End Sub

    Private Sub Easy6x6ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Easy6x6ToolStripMenuItem.Click
        Me.Visible = False
        form2.Visible = True
    End Sub

    Private Sub Hard9x8ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hard9x8ToolStripMenuItem.Click
        Me.Visible = False
        Form1.Visible = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class


