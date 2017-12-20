Public Class Form1
    ' Dim Area
    Dim life As Integer
    Dim moves As Integer
    Dim range As Integer
    Dim attack As Integer
    Dim Defense As Integer
    ' -----------
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New Form1
        f.Show()
    End Sub
    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.airborneelite_CustomImg_lightblue
    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.airborneelite_CustomImg_blue
    End Sub

    Private Sub BrownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrownToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.airborneelite_CustomImg_brown
    End Sub

    Private Sub GoldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoldToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.airborneelite_CustomImg_gold
    End Sub

    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.airborneelite_CustomImg_green
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.airborneelite_CustomImg_red
    End Sub

    Private Sub Label12_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles LifeL.MouseDoubleClick
        If LifePlus.Visible = 0 And LifeMinus.Visible = 0 Then
            LifePlus.Visible = 1
            LifeMinus.Visible = 1
        Else
            LifePlus.Visible = 0
            LifeMinus.Visible = 0
        End If
    End Sub

    Private Sub Label1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles MoveL.MouseDoubleClick
        If MovePlus.Visible = 0 And MoveMinus.Visible = 0 Then
            MovePlus.Visible = 1
            MoveMinus.Visible = 1
        Else
            MovePlus.Visible = 0
            MoveMinus.Visible = 0
        End If
    End Sub

    Private Sub Label2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles RangeL.MouseDoubleClick
        If RangePlus.Visible = 0 And RangeMinus.Visible = 0 Then
            RangePlus.Visible = 1
            RangeMinus.Visible = 1
        Else
            RangePlus.Visible = 0
            RangeMinus.Visible = 0
        End If
    End Sub

    Private Sub Label3_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles AttackL.MouseDoubleClick
        If AttackPlus.Visible = 0 And AttackMinus.Visible = 0 Then
            AttackPlus.Visible = 1
            AttackMinus.Visible = 1
        Else
            AttackPlus.Visible = 0
            AttackMinus.Visible = 0
        End If
    End Sub

    Private Sub Label4_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DefenseL.MouseDoubleClick
        If DefensePlus.Visible = 0 And DefenseMinus.Visible = 0 Then
            DefensePlus.Visible = 1
            DefenseMinus.Visible = 1
        Else
            DefensePlus.Visible = 0
            DefenseMinus.Visible = 0
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        life = 0
        moves = 0
        range = 0
        attack = 0
        Defense = 0
    End Sub

    Private Sub LifePlus_Click(sender As Object, e As EventArgs) Handles LifePlus.Click
        life = life + 1
        LifeL.Text = life
    End Sub

    Private Sub LifeMinus_Click(sender As Object, e As EventArgs) Handles LifeMinus.Click
        life = life - 1
        LifeL.Text = life
    End Sub

    Private Sub MovePlus_Click(sender As Object, e As EventArgs) Handles MovePlus.Click
        moves = moves + 1
        MoveL.Text = moves
    End Sub

    Private Sub MoveMinus_Click(sender As Object, e As EventArgs) Handles MoveMinus.Click
        moves = moves - 1
        MoveL.Text = moves
    End Sub

    Private Sub RangePlus_Click(sender As Object, e As EventArgs) Handles RangePlus.Click
        range = range + 1
        RangeL.Text = range
    End Sub

    Private Sub RangeMinus_Click(sender As Object, e As EventArgs) Handles RangeMinus.Click
        range = range - 1
        RangeL.Text = range
    End Sub

    Private Sub AttackPlus_Click(sender As Object, e As EventArgs) Handles AttackPlus.Click
        attack = attack + 1
        AttackL.Text = attack
    End Sub

    Private Sub AttackMinus_Click(sender As Object, e As EventArgs) Handles AttackMinus.Click
        attack = attack - 1
        AttackL.Text = attack
    End Sub

    Private Sub DefensePlus_Click(sender As Object, e As EventArgs) Handles DefensePlus.Click
        Defense = Defense + 1
        DefenseL.Text = Defense
    End Sub

    Private Sub DefenseMinus_Click(sender As Object, e As EventArgs) Handles DefenseMinus.Click
        Defense = Defense - 1
        DefenseL.Text = Defense
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("How to use the features so far." & vbNewLine &
                        "* Double click the ""#"" for the ""+"" or ""-"" buttons and edit the numbers." & vbNewLine &
                        "* Double click the ""#"" again to hide the ""+"" and ""-"" buttons." & vbNewLine &
                        "* Right click the background to change the colours.",
                        "Help box")
    End Sub
End Class
