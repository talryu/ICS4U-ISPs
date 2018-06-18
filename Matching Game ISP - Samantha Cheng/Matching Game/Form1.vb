Public Class Form1
    Dim num As Integer
    Private img(4) As Image

    Private RandNum As Random
    Private RandIndex As Integer

    Dim PBTemp() As PictureBox 'dynamic picturebox
    Private score As Integer

    Private FoundPairs As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Visible = False
        btngo.Visible = False
        btnstop.Visible = False
        lblscore.Visible = False
        lbltime.Visible = False

        Panel2.Visible = False
        btngo2.Visible = False
        btnstop2.Visible = False
        lblscore2.Visible = False
        lbltime2.Visible = False

        Panel3.Visible = False
        btngo3.Visible = False
        btnstop3.Visible = False
        lblscore3.Visible = False
        lbltime3.Visible = False

        Timer1.Enabled = False
        Timer1.Interval = 900
        Timer2.Enabled = False
        Timer2.Interval = 900
        Timer3.Enabled = False
        Timer3.Interval = 900
    End Sub

    Public Sub DrawPBGrid()
        Dim NewLoc As New Point 'location of each new block
        img(0) = My.Resources.image_1
        img(1) = My.Resources.image_2
        img(2) = My.Resources.image_3
        img(3) = My.Resources.image_4
        img(4) = My.Resources.image_5
        RandNum = New Random(Now.Millisecond)

        For row As Integer = 0 To 3 'rows
            For column As Integer = 0 To 3 'columns

                NewLoc.X = 2 + row * 50 'height of block
                NewLoc.Y = 2 + column * 50 'width of block

                Dim PB As New PictureBox 'new picturebox
                ReDim Preserve PBTemp(column)

                With PB 'block properties
                    .Name = row.ToString() & "_" & column.ToString 'Name Ex: 1_2 ( Row 1 _ Col 2 )
                    .BorderStyle = BorderStyle.FixedSingle 'block effect
                    .Location = NewLoc 'set position
                    .Width = 30 'width
                    .Height = 30 'height
                    .BackColor = System.Drawing.Color.White
                    RandIndex = RandNum.Next(0, 5)
                    .Image = img(RandIndex)

                    AddHandler PB.MouseClick, AddressOf PB_MouseClick 'Event Handler Click

                End With
                PBTemp(column) = New PictureBox
                PBTemp(column).Image = PB.Image
                Me.Controls.Add(PB)
            Next column
        Next row
    End Sub

    Public Sub DrawPBGrid2()
        Dim NewLoc As New Point
        img(0) = My.Resources.image_1
        img(1) = My.Resources.image_2
        img(2) = My.Resources.image_3
        img(3) = My.Resources.image_4
        img(4) = My.Resources.image_5
        RandNum = New Random(Now.Millisecond)

        For row As Integer = 0 To 5
            For column As Integer = 0 To 5

                NewLoc.X = 2 + row * 50
                NewLoc.Y = 2 + column * 50

                Dim PB As New PictureBox
                ReDim Preserve PBTemp(column)

                With PB
                    .Name = row.ToString() & "_" & column.ToString
                    .BorderStyle = BorderStyle.FixedSingle
                    .Location = NewLoc
                    .Width = 30
                    .Height = 30
                    .BackColor = System.Drawing.Color.White
                    RandIndex = RandNum.Next(0, 5)
                    .Image = img(RandIndex)

                    AddHandler PB.MouseClick, AddressOf PB_MouseClick

                End With
                PBTemp(column) = New PictureBox
                PBTemp(column).Image = PB.Image
                Me.Controls.Add(PB)
            Next column
        Next row
    End Sub

    Public Sub DrawPBGrid3()
        Dim NewLoc As New Point
        img(0) = My.Resources.image_1
        img(1) = My.Resources.image_2
        img(2) = My.Resources.image_3
        img(3) = My.Resources.image_4
        img(4) = My.Resources.image_5
        RandNum = New Random(Now.Millisecond)

        For row As Integer = 0 To 7
            For column As Integer = 0 To 7

                NewLoc.X = 2 + row * 50
                NewLoc.Y = 2 + column * 50

                Dim PB As New PictureBox
                ReDim Preserve PBTemp(column)

                With PB
                    .Name = row.ToString() & "_" & column.ToString
                    .BorderStyle = BorderStyle.FixedSingle
                    .Location = NewLoc
                    .Width = 30
                    .Height = 30
                    .BackColor = System.Drawing.Color.White
                    RandIndex = RandNum.Next(0, 5)
                    .Image = img(RandIndex)

                    AddHandler PB.MouseClick, AddressOf PB_MouseClick

                End With
                PBTemp(column) = New PictureBox
                PBTemp(column).Image = PB.Image
                Me.Controls.Add(PB)
            Next column
        Next row
    End Sub

    Private Sub PB_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
        Static counted As Integer
        Static pb() As PictureBox
        Static colname() As String
        Static rowname() As String
        ReDim Preserve pb(counted)
        ReDim Preserve colname(counted)
        ReDim Preserve rowname(counted)


        pb(counted) = New PictureBox
        pb(counted) = DirectCast(sender, PictureBox)

        colname(counted) = pb(counted).Name.ToString.Substring(0, pb(counted).Name.ToString.LastIndexOf("_"))
        rowname(counted) = pb(counted).Name.ToString.Substring(pb(counted).Name.ToString.LastIndexOf("_") + 1)

        If counted >= 1 Then
            If pb(counted - 1).Image Is pb(counted).Image Then
                If colname(counted - 1) = colname(counted) OrElse rowname(counted - 1) = rowname(counted) Then

                    pb(counted - 1).BackColor = Color.Black
                    pb(counted).BackColor = Color.Black

                    pb(counted - 1).Image = Nothing
                    pb(counted).Image = Nothing

                    score += 5
                    lblscore.Text = score
                    lblscore2.Text = score
                    lblscore3.Text = score
                    FoundPairs += 1

                    Shuffle()
                End If
            End If
        End If

        counted += 1
    End Sub

    Private Sub Shuffle()
        Dim RandGen As New Random(Now.Millisecond)

        For Each P As PictureBox In Me.Controls.OfType(Of PictureBox)()
            Dim RandIndex As Integer = RandGen.Next(0, 5)

            If P.BackColor <> Color.Black Then
                P.Image = img(RandIndex)
            Else
                P.Image = Nothing
            End If
        Next

    End Sub

    Private Sub btnstop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstop.Click
        Timer1.Enabled = False
    End Sub

    Private Sub btnstop2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstop2.Click
        Timer2.Enabled = False
    End Sub

    Private Sub btnstop3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstop3.Click
        Timer3.Enabled = False
    End Sub

    Private Sub btngo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngo.Click
        Timer1.Enabled = True
    End Sub

    Private Sub btngo2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngo2.Click
        Timer2.Enabled = True
    End Sub

    Private Sub btngo3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngo3.Click
        Timer3.Enabled = True
    End Sub

    Private Sub QuitGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitGameToolStripMenuItem.Click
        Dim result As Integer = MessageBox.Show("Are you sure?", "Quit Game", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub X4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles X4ToolStripMenuItem.Click
        DrawPBGrid()
        lbltag.Visible = False
        lbltag2.Visible = False
        Panel1.Visible = True
        btngo.Visible = True
        btnstop.Visible = True
        lblscore.Visible = True
        lbltime.Visible = True
        Timer1.Enabled = True

    End Sub

    Private Sub X6ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles X6ToolStripMenuItem.Click
        DrawPBGrid2()
        lbltag.Visible = False
        lbltag2.Visible = False
        Panel1.Visible = False
        btngo.Visible = False
        btnstop.Visible = False
        lblscore.Visible = False
        lbltime.Visible = False
        Timer1.Enabled = False

        Panel2.Visible = True
        btngo2.Visible = True
        btnstop2.Visible = True
        lblscore2.Visible = True
        lbltime2.Visible = True
        Timer2.Enabled = True
    End Sub

    Private Sub X8ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles X8ToolStripMenuItem.Click
        DrawPBGrid3()
        lbltag.Visible = False
        lbltag2.Visible = False
        Panel1.Visible = False
        btngo.Visible = False
        btnstop.Visible = False
        lblscore.Visible = False
        lbltime.Visible = False
        Timer1.Enabled = False

        Panel2.Visible = False
        btngo2.Visible = False
        btnstop2.Visible = False
        lblscore2.Visible = False
        lbltime2.Visible = False
        Timer2.Enabled = False

        Panel3.Visible = True
        btngo3.Visible = True
        btnstop3.Visible = True
        lblscore3.Visible = True
        lbltime3.Visible = True
        Timer3.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim current As Integer
        current = lbltime.Text
        num = 1

        current = current - num
        lbltime.Text = current

        If lbltime.Text = 0 Then
            Timer1.Enabled = False
            MsgBox("Times up!", vbInformation, "Message")
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim current2 As Integer
        current2 = lbltime2.Text
        num = 1

        current2 = current2 - num
        lbltime2.Text = current2

        If lbltime2.Text = 0 Then
            Timer2.Enabled = False
            MsgBox("Times up!", vbInformation, "Message")
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Dim current3 As Integer
        current3 = lbltime3.Text
        num = 1

        current3 = current3 - num
        lbltime3.Text = current3

        If lbltime3.Text = 0 Then
            Timer3.Enabled = False
            MsgBox("Times up!", vbInformation, "Message")
        End If
    End Sub

End Class