Public Class Form1
    Dim notes(12), random, correct As Integer
    Dim pstart As Boolean = True
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i = 0 To 12                     'establishes notes as positions through an array, C is note(0), C# is note(1), D is note(2) etc...
            notes(i) = i
        Next
        btnagain.Enabled = False            '"Listen Again" button off because there is nothing to listen to again
    End Sub
    Private Sub btnpractice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpractice.Click
        btnpractice.Enabled = False
        btnagain.Enabled = True
        Randomize()                         'randomizes the correct note that you should pick
        random = Int(Rnd() * 13)
        Select Case notes(random)           'plays the random note based on one of these case depending on the random number from 0 to 12
            Case 0
                My.Computer.Audio.Play(My.Resources.mid_c, AudioPlayMode.Background)
            Case 1
                My.Computer.Audio.Play(My.Resources.mid_c_sharp, AudioPlayMode.Background)
            Case 2
                My.Computer.Audio.Play(My.Resources.mid_d, AudioPlayMode.Background)
            Case 3
                My.Computer.Audio.Play(My.Resources.mid_d_sharp, AudioPlayMode.Background)
            Case 4
                My.Computer.Audio.Play(My.Resources.mid_e, AudioPlayMode.Background)
            Case 5
                My.Computer.Audio.Play(My.Resources.mid_f, AudioPlayMode.Background)
            Case 6
                My.Computer.Audio.Play(My.Resources.mid_f_sharp, AudioPlayMode.Background)
            Case 7
                My.Computer.Audio.Play(My.Resources.mid_g, AudioPlayMode.Background)
            Case 8
                My.Computer.Audio.Play(My.Resources.mid_g_sharp, AudioPlayMode.Background)
            Case 9
                My.Computer.Audio.Play(My.Resources.mid_a, AudioPlayMode.Background)
            Case 10
                My.Computer.Audio.Play(My.Resources.mid_a_sharp, AudioPlayMode.Background)
            Case 11
                My.Computer.Audio.Play(My.Resources.mid_b, AudioPlayMode.Background)
            Case 12
                My.Computer.Audio.Play(My.Resources.high_c, AudioPlayMode.Background)
        End Select
        pstart = False            'if pstart = false, then user can experiment with the piano before they click "Practice"
    End Sub
    Private Sub btnagain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagain.Click

        Select Case notes(random)                                             'plays the same note again when this button is pressed using the same note position as the random number
            Case 0
                My.Computer.Audio.Play(My.Resources.mid_c, AudioPlayMode.Background)
            Case 1
                My.Computer.Audio.Play(My.Resources.mid_c_sharp, AudioPlayMode.Background)
            Case 2
                My.Computer.Audio.Play(My.Resources.mid_d, AudioPlayMode.Background)
            Case 3
                My.Computer.Audio.Play(My.Resources.mid_d_sharp, AudioPlayMode.Background)
            Case 4
                My.Computer.Audio.Play(My.Resources.mid_e, AudioPlayMode.Background)
            Case 5
                My.Computer.Audio.Play(My.Resources.mid_f, AudioPlayMode.Background)
            Case 6
                My.Computer.Audio.Play(My.Resources.mid_f_sharp, AudioPlayMode.Background)
            Case 7
                My.Computer.Audio.Play(My.Resources.mid_g, AudioPlayMode.Background)
            Case 8
                My.Computer.Audio.Play(My.Resources.mid_g_sharp, AudioPlayMode.Background)
            Case 9
                My.Computer.Audio.Play(My.Resources.mid_a, AudioPlayMode.Background)
            Case 10
                My.Computer.Audio.Play(My.Resources.mid_a_sharp, AudioPlayMode.Background)
            Case 11
                My.Computer.Audio.Play(My.Resources.mid_b, AudioPlayMode.Background)
            Case 12
                My.Computer.Audio.Play(My.Resources.high_c, AudioPlayMode.Background)
        End Select
    End Sub
    Private Sub btnc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnc.Click
        My.Computer.Audio.Play(My.Resources.mid_c, AudioPlayMode.Background)
        If pstart = False Then
            If notes(0) = notes(random) Then     'checks if the user's note matches the program's note
                MsgBox("You are correct!")
                correct = correct + 1            'counter to display to user how many of their picks are correct
                lblcorrect.Text = correct & " correct."
            Else
                MsgBox("Sorry, incorrect.")
            End If
            btnpractice.Enabled = True           'turns on the practice button again for user to practice again
            btnagain.Enabled = False             'turns off listen again as they've already picked a note
        End If

    End Sub                                      'same process for buttons below
    Private Sub btncsharp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncsharp.Click
        My.Computer.Audio.Play(My.Resources.mid_c_sharp, AudioPlayMode.Background)
        If pstart = False Then
            If notes(1) = notes(random) Then
                MsgBox("You are correct!")
                correct = correct + 1
                lblcorrect.Text = correct & " correct."
            Else
                MsgBox("Sorry, incorrect.")
            End If
            btnpractice.Enabled = True
            btnagain.Enabled = False
        End If
    End Sub
    Private Sub btnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnd.Click
        My.Computer.Audio.Play(My.Resources.mid_d, AudioPlayMode.Background)
        If pstart = False Then
            If notes(2) = notes(random) Then
                MsgBox("You are correct!")
                correct = correct + 1
                lblcorrect.Text = correct & " correct."
            Else
                MsgBox("Sorry, incorrect.")
            End If
            btnpractice.Enabled = True
            btnagain.Enabled = False
        End If
    End Sub
    Private Sub btndsharp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndsharp.Click
        My.Computer.Audio.Play(My.Resources.mid_d_sharp, AudioPlayMode.Background)
        If pstart = False Then
            If notes(3) = notes(random) Then
                MsgBox("You are correct!")
                correct = correct + 1
                lblcorrect.Text = correct & " correct."
            Else
                MsgBox("Sorry, incorrect.")
            End If
            btnpractice.Enabled = True
            btnagain.Enabled = False
        End If
    End Sub
    Private Sub btne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btne.Click
        My.Computer.Audio.Play(My.Resources.mid_e, AudioPlayMode.Background)
        If pstart = False Then
            If notes(4) = notes(random) Then
                MsgBox("You are correct!")
                correct = correct + 1
                lblcorrect.Text = correct & " correct."
            Else
                MsgBox("Sorry, incorrect.")
            End If
            btnpractice.Enabled = True
            btnagain.Enabled = False
        End If
    End Sub
    Private Sub btnf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnf.Click
        My.Computer.Audio.Play(My.Resources.mid_f, AudioPlayMode.Background)
        If pstart = False Then
            If notes(5) = notes(random) Then
                MsgBox("You are correct!")
                correct = correct + 1
                lblcorrect.Text = correct & " correct."
            Else
                MsgBox("Sorry, incorrect.")
            End If
            btnpractice.Enabled = True
            btnagain.Enabled = False
        End If
    End Sub
    Private Sub btnfsharp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfsharp.Click
        My.Computer.Audio.Play(My.Resources.mid_f_sharp, AudioPlayMode.Background)
        If pstart = False Then
            If notes(6) = notes(random) Then
                MsgBox("You are correct!")
                correct = correct + 1
                lblcorrect.Text = correct & " correct."
            Else
                MsgBox("Sorry, incorrect.")
            End If
            btnpractice.Enabled = True
            btnagain.Enabled = False
        End If
    End Sub
    Private Sub btng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btng.Click
        My.Computer.Audio.Play(My.Resources.mid_g, AudioPlayMode.Background)
        If pstart = False Then
            If notes(7) = notes(random) Then
                MsgBox("You are correct!")
                correct = correct + 1
                lblcorrect.Text = correct & " correct."
            Else
                MsgBox("Sorry, incorrect.")
            End If
            btnpractice.Enabled = True
            btnagain.Enabled = False
        End If
    End Sub
    Private Sub btngsharp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngsharp.Click
        My.Computer.Audio.Play(My.Resources.mid_g_sharp, AudioPlayMode.Background)
        If pstart = False Then
            If notes(8) = notes(random) Then
                MsgBox("You are correct!")
                correct = correct + 1
                lblcorrect.Text = correct & " correct."
            Else
                MsgBox("Sorry, incorrect.")
            End If
            btnpractice.Enabled = True
            btnagain.Enabled = False
        End If
    End Sub
    Private Sub btna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btna.Click
        My.Computer.Audio.Play(My.Resources.mid_a, AudioPlayMode.Background)
        If pstart = False Then
            If notes(9) = notes(random) Then
                MsgBox("You are correct!")
                correct = correct + 1
                lblcorrect.Text = correct & " correct."
            Else
                MsgBox("Sorry, incorrect.")
            End If
            btnpractice.Enabled = True
            btnagain.Enabled = False
        End If
    End Sub
    Private Sub btnasharp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnasharp.Click
        My.Computer.Audio.Play(My.Resources.mid_a_sharp, AudioPlayMode.Background)
        If pstart = False Then
            If notes(10) = notes(random) Then
                MsgBox("You are correct!")
                correct = correct + 1
                lblcorrect.Text = correct & " correct."
            Else
                MsgBox("Sorry, incorrect.")
            End If
            btnpractice.Enabled = True
            btnagain.Enabled = False
        End If
    End Sub
    Private Sub btnb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb.Click
        My.Computer.Audio.Play(My.Resources.mid_b, AudioPlayMode.Background)
        If pstart = False Then
            If notes(11) = notes(random) Then
                MsgBox("You are correct!")
                correct = correct + 1
                lblcorrect.Text = correct & " correct."
            Else
                MsgBox("Sorry, incorrect.")
            End If
            btnpractice.Enabled = True
            btnagain.Enabled = False
        End If
    End Sub
    Private Sub btnc8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnc8.Click
        My.Computer.Audio.Play(My.Resources.high_c, AudioPlayMode.Background)
        If pstart = False Then
            If notes(12) = notes(random) Then
                MsgBox("You are correct!")
                correct = correct + 1
                lblcorrect.Text = correct & " correct."
            Else
                MsgBox("Sorry, incorrect.")
            End If
            btnpractice.Enabled = True
            btnagain.Enabled = False
        End If
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode                   'This makes the buttons on the piano usable with keyboard as well, instead of just clicking with the mouse
            Case Keys.A
                btnc.PerformClick()
            Case Keys.W
                btncsharp.PerformClick()
            Case Keys.S
                btnd.PerformClick()
            Case Keys.E
                btndsharp.PerformClick()
            Case Keys.D
                btne.PerformClick()
            Case Keys.F
                btnf.PerformClick()
            Case Keys.T
                btnfsharp.PerformClick()
            Case Keys.G
                btng.PerformClick()
            Case Keys.Y
                btngsharp.PerformClick()
            Case Keys.H
                btna.PerformClick()
            Case Keys.U
                btnasharp.PerformClick()
            Case Keys.J
                btnb.PerformClick()
            Case Keys.K
                btnc8.PerformClick()
        End Select
    End Sub
    Private Sub NoteNamesOnToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoteNamesOnToolStripMenuItem1.Click
        btnc.Text = "C"
        lblcsharp.Text = "C#"            'shows all note names
        btnd.Text = "D"
        lbldsharp.Text = "D#"
        btne.Text = "E"
        btnf.Text = "F"
        lblfsharp.Text = "F#"
        btng.Text = "G"
        lblgsharp.Text = "G#"
        btna.Text = "A"
        lblasharp.Text = "A#"
        btnb.Text = "B"
        btnc8.Text = "C"
    End Sub
    Private Sub NoteNamesOffToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoteNamesOffToolStripMenuItem1.Click
        btnc.Text = ""
        lblcsharp.Text = ""             'hides all note names
        btnd.Text = ""
        lbldsharp.Text = ""
        btne.Text = ""
        btnf.Text = ""
        lblfsharp.Text = ""
        btng.Text = ""
        lblgsharp.Text = ""
        btna.Text = ""
        lblasharp.Text = ""
        btnb.Text = ""
        btnc8.Text = ""
    End Sub
    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        MsgBox("To press a piano key, you can use the mouse to click the piano key. You may also use the keyboard in the order of the buttons of A,W,S,E,D,F,T,G,Y,H,U,J,K.")
    End Sub
    Private Sub RestartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartToolStripMenuItem.Click
        Application.Restart()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
