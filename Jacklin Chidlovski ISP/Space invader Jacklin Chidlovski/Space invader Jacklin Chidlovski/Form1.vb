Public Class Parentform

#Region "variables"

    Dim aliens(11) As PictureBox
    Dim locations(11) As System.Drawing.Point

    Dim lef As Boolean
    Dim rig As Boolean

    Dim fire As Boolean
    Dim fire1 As Boolean
    Dim fire2 As Boolean
    Dim fire3 As Boolean
    Dim fire4 As Boolean
    Dim fire5 As Boolean

    Dim movealien As Integer = 3
    Dim whichalien As Integer
    Dim complete As Integer
    Dim level As Integer = 1
    Dim score As Integer

#End Region

#Region "Buttons"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label1.Hide()
        Button1.Hide()
        Button2.Hide()
        PictureBox1.Hide()
        PictureBox2.Hide()
        Panel1.Show()
        Move.Enabled = True
        Move.Start()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
#End Region

#Region "timers"

    Private Sub Move_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Move.Tick
        If lef = True Then
            Spaceship.Left = Spaceship.Left - 7
            Restartshot.Left = Restartshot.Left - 7
            If fire1 = False Then
                shot1.Left = shot1.Left - 7
            End If
            If fire2 = False Then
                shot2.Left = shot2.Left - 7
            End If
            If fire3 = False Then
                shot3.Left = shot3.Left - 7
            End If
            If fire4 = False Then
                shot4.Left = shot4.Left - 7
            End If
            If fire5 = False Then
                shot5.Left = shot5.Left - 7
            End If
        End If
        If rig = True Then
            Spaceship.Left = Spaceship.Left + 7
            Restartshot.Left = Restartshot.Left + 7
            If fire1 = False Then
                shot1.Left = shot1.Left + 7
            End If
            If fire2 = False Then
                shot2.Left = shot2.Left + 7
            End If
            If fire3 = False Then
                shot3.Left = shot3.Left + 7
            End If
            If fire4 = False Then
                shot4.Left = shot4.Left + 7
            End If
            If fire5 = False Then
                shot5.Left = shot5.Left + 7
            End If
        End If
        movealiens()
        If fire = True Then
            checkshot()
        End If
        moveshot()

    End Sub

#End Region

#Region "keypresses"
    Private Sub movecompleft(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.A Then
            lef = True
        End If
        If e.KeyValue = Keys.D Then
            rig = True
        End If
        If e.KeyValue = Keys.L Then
            fire = True
        End If
    End Sub

    Private Sub movecompstop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = Keys.A Then
            lef = False
        End If
        If e.KeyValue = Keys.D Then
            rig = False
        End If
        If e.KeyCode = Keys.L Then
            fire = False
        End If
    End Sub
#End Region

#Region "My Subs"

    Public Sub New()

        InitializeComponent()
        createarray()
    End Sub

    Private Sub createarray()
        aliens(0) = Alien1
        aliens(1) = Alien2
        aliens(2) = Alien3
        aliens(3) = Alien4
        aliens(4) = Alien5
        aliens(5) = Alien6
        aliens(6) = Alien7
        aliens(7) = Alien8
        aliens(8) = Alien9
        aliens(9) = Alien10
        aliens(10) = Alien11
        aliens(11) = Alien12
        For i = 0 To 11
            locations(i) = aliens(i).Location
        Next
    End Sub

    Private Sub movealiens()
        For i = 0 To 11
            aliens(i).Left = aliens(i).Left + movealien
            If aliens(i).Bounds.IntersectsWith(Spaceship.Bounds) Then
                playerdead()
            End If
        Next
        If Alien6.Left > Me.Width - Alien6.Width Then
            movealien = movealien * -1
            For i = 0 To 11
                aliens(i).Top = aliens(i).Top + 25
            Next
        End If
        If Alien1.Left < 0 Then
            movealien = movealien * -1
            For i = 0 To 11
                aliens(i).Top = aliens(i).Top + 25
            Next
        End If
    End Sub

    Private Sub checkshot()
        fire = False
        If fire1 = False Then
            fire1 = True
            shot1.Show()
            Exit Sub
        End If
        If fire2 = False Then
            fire2 = True
            shot2.Show()
            Exit Sub
        End If
        If fire3 = False Then
            fire3 = True
            shot3.Show()
            Exit Sub
        End If
        If fire4 = False Then
            fire4 = True
            shot4.Show()
            Exit Sub
        End If
        If fire5 = False Then
            fire5 = True
            shot5.Show()
            Exit Sub
        End If
    End Sub

    Private Sub moveshot()
        If fire1 = True Then
            shot1.Top = shot1.Top - 3
            For i = 0 To 11
                If shot1.Bounds.IntersectsWith(aliens(i).Bounds) Then
                    whichalien = i
                    shot1hit()
                End If
            Next
            If shot1.Top < 0 Then
                shot1.Hide()
                fire1 = False
                shot1.Location = Restartshot.Location
            End If
        End If
        If fire2 = True Then
            shot2.Top = shot2.Top - 3
            For i = 0 To 11
                If shot2.Bounds.IntersectsWith(aliens(i).Bounds) Then
                    whichalien = i
                    shot2hit()
                End If
            Next
            If shot2.Top < 0 Then
                shot2.Hide()
                fire2 = False
                shot2.Location = Restartshot.Location
            End If
        End If
        If fire3 = True Then
            shot3.Top = shot3.Top - 3
            For i = 0 To 11
                If shot3.Bounds.IntersectsWith(aliens(i).Bounds) Then
                    whichalien = i
                    shot3hit()
                End If
            Next
            If shot3.Top < 0 Then
                shot3.Hide()
                fire3 = False
                shot3.Location = Restartshot.Location
            End If
        End If
        If fire4 = True Then
            shot4.Top = shot4.Top - 3
            For i = 0 To 11
                If shot4.Bounds.IntersectsWith(aliens(i).Bounds) Then
                    whichalien = i
                    shot4hit()
                End If
            Next
            If shot4.Top < 0 Then
                shot4.Hide()
                fire4 = False
                shot4.Location = Restartshot.Location
            End If
        End If
        If fire5 = True Then
            shot5.Top = shot5.Top - 3
            For i = 0 To 11
                If shot5.Bounds.IntersectsWith(aliens(i).Bounds) Then
                    whichalien = i
                    shot5hit()
                End If
            Next
            If shot5.Top < 0 Then
                shot5.Hide()
                fire5 = False
                shot5.Location = Restartshot.Location
            End If
        End If
    End Sub

    Private Sub shot1hit()
        fire1 = False
        shot1.Hide()
        shot1.Location = Restartshot.Location
        aliens(whichalien).Top = aliens(whichalien).Top + 10000
        complete = complete + 1
        If complete = 12 Then
            levelcomplete()
        End If
        score = score + 1
        scorelabel.Text = "SCORE:" & score
    End Sub

    Private Sub shot2hit()
        fire2 = False
        shot2.Hide()
        shot2.Location = Restartshot.Location
        aliens(whichalien).Top = aliens(whichalien).Top + 10000
        complete = complete + 1
        If complete = 12 Then
            levelcomplete()
        End If
        score = score + 1
        scorelabel.Text = "SCORE:" & score
    End Sub

    Private Sub shot3hit()
        fire3 = False
        shot3.Hide()
        shot3.Location = Restartshot.Location
        aliens(whichalien).Top = aliens(whichalien).Top + 10000
        complete = complete + 1
        If complete = 12 Then
            levelcomplete()
        End If
        score = score + 1
        scorelabel.Text = "SCORE:" & score
    End Sub

    Private Sub shot4hit()
        fire4 = False
        shot4.Hide()
        shot4.Location = Restartshot.Location
        aliens(whichalien).Top = aliens(whichalien).Top + 10000
        complete = complete + 1
        If complete = 12 Then
            levelcomplete()
        End If
        score = score + 1
        scorelabel.Text = "SCORE:" & score
    End Sub

    Private Sub shot5hit()
        fire5 = False
        shot5.Hide()
        shot5.Location = Restartshot.Location
        aliens(whichalien).Top = aliens(whichalien).Top + 10000
        complete = complete + 1
        If complete = 12 Then
            levelcomplete()
        End If
        score = score + 1
        scorelabel.Text = "SCORE:" & score
    End Sub

    Private Sub playerdead()
        Move.Stop()
        Spaceship.Image = My.Resources.explosion_153710_960_720
        dead.Show()

    End Sub

    Private Sub levelcomplete()
        complete = 0
        level = level + 1
        levelshow.Text = "LEVEL:" & level
        For i = 0 To 11
            aliens(i).Location = locations(i)
        Next
    End Sub
#End Region

End Class
