Imports System.Text

Public Class Form1
    'Public Sub CheckAssociation()
    '    My.Computer.Registry.ClassesRoot.CreateSubKey(".sef").SetValue("", "Stats Editor File", Microsoft.Win32.RegistryValueKind.String)
    '    My.Computer.Registry.ClassesRoot.CreateSubKey("StatsEditorFile\shell\open\command").SetValue("", Application.ExecutablePath & " ""%1"" ", Microsoft.Win32.RegistryValueKind.String)
    '    My.Computer.Registry.ClassesRoot.CreateSubKey("StatsEditorFile\DefaultIcon").SetValue("", Application.StartupPath & "\index_Tl6_icon.ico")
    'End Sub

    ' Dim Area
    Dim life As Integer
    Dim moves As Integer
    Dim range As Integer
    Dim attack As Integer
    Dim Defense As Integer
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim FName As String
    Dim dfbg As String

    ' -----------

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CheckAssociation()

        'Dim file As String = Command$()
        'If Not file = "" Then
        '    file = Replace(file, Chr(34), "")
        '    'RichTextBox1.LoadFile(file)
        'End If



        'MessageBox.Show(file)


        life = 0
        moves = 0
        range = 0
        attack = 0
        Defense = 0
        dfbg = "blue"

    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown, fsi1.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove, fsi1.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp, fsi1.MouseUp
        drag = False
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New Form1
        f.Show()
    End Sub
    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.airborneelite_CustomImg_lightblue
        fsi1.Image = My.Resources.airborneelite_CustomImg_lightblue
        dfbg = "lblue"
    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.airborneelite_CustomImg_blue
        fsi1.Image = My.Resources.airborneelite_CustomImg_blue
        dfbg = "blue"
    End Sub

    Private Sub BrownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrownToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.airborneelite_CustomImg_brown
        fsi1.Image = My.Resources.airborneelite_CustomImg_brown
        dfbg = "brown"
    End Sub

    Private Sub GoldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoldToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.airborneelite_CustomImg_gold
        fsi1.Image = My.Resources.airborneelite_CustomImg_gold
        dfbg = "gold"
    End Sub

    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.airborneelite_CustomImg_green
        fsi1.Image = My.Resources.airborneelite_CustomImg_green
        dfbg = "green"
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.airborneelite_CustomImg_red
        fsi1.Image = My.Resources.airborneelite_CustomImg_red
        dfbg = "red"
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
                        "   Double click the ""#"" again to hide the ""+"" and ""-"" buttons." & vbNewLine &
                        "* Right click the background to change the colours." & vbNewLine &
                        "* Double click the ""Edit Me"" place holders to edit the area." & vbNewLine &
                        "   Double click the same text to hide the editor.",
                        "Help box")
    End Sub

    Private Sub topheadertxt_TextChanged(sender As Object, e As EventArgs) Handles topheadertxt.TextChanged
        NameStat.Text = topheadertxt.Text.ToString
        topheadertxt.Text = NameStat.Text.ToString
    End Sub

    Private Sub TopHeaderL_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NameStat.MouseDoubleClick
        If topheadertxt.Visible = 0 Then
            topheadertxt.Visible = 1
        Else
            topheadertxt.Visible = 0
        End If
    End Sub

    Private Sub bottomtopheaderL_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles bottomtopheaderL.MouseDoubleClick
        If bottomtopheadertxt.Visible = 0 Then
            bottomtopheadertxt.Visible = 1
        Else
            bottomtopheadertxt.Visible = 0
        End If
    End Sub

    Private Sub bottomtopheadertxt_TextChanged(sender As Object, e As EventArgs) Handles bottomtopheadertxt.TextChanged
        bottomtopheaderL.Text = bottomtopheadertxt.Text.ToString
        bottomtopheadertxt.Text = bottomtopheaderL.Text.ToString
    End Sub

    Private Sub lstxtL1_MouseDoubleClick(sender As Object, e As EventArgs) Handles lstxtL1.MouseDoubleClick
        If lstxt1.Visible = 0 Then
            lstxt1.Visible = 1
        Else
            lstxt1.Visible = 0
        End If
    End Sub

    Private Sub lstxtL2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstxtL2.MouseDoubleClick
        If lstxt2.Visible = 0 Then
            lstxt2.Visible = 1
        Else
            lstxt2.Visible = 0
        End If
    End Sub

    Private Sub lstxtL3_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstxtL3.MouseDoubleClick
        If lstxt3.Visible = 0 Then
            lstxt3.Visible = 1
        Else
            lstxt3.Visible = 0
        End If
    End Sub

    Private Sub lstxtL4_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstxtL4.MouseDoubleClick
        If lstxt4.Visible = 0 Then
            lstxt4.Visible = 1
        Else
            lstxt4.Visible = 0
        End If
    End Sub

    Private Sub lstxtL5_MouseDoubleClick(sender As Object, e As EventArgs) Handles lstxtL5.MouseDoubleClick
        If lstxt5.Visible = 0 Then
            lstxt5.Visible = 1
        Else
            lstxt5.Visible = 0
        End If
    End Sub

    Private Sub lstxt1_TextChanged(sender As Object, e As EventArgs) Handles lstxt1.TextChanged
        lstxtL1.Text = lstxt1.Text.ToString
        lstxt1.Text = lstxtL1.Text.ToString
    End Sub

    Private Sub lstxt2_TextChanged(sender As Object, e As EventArgs) Handles lstxt2.TextChanged
        lstxtL2.Text = lstxt2.Text.ToString
        lstxt2.Text = lstxtL2.Text.ToString
    End Sub

    Private Sub lstxt3_TextChanged(sender As Object, e As EventArgs) Handles lstxt3.TextChanged
        lstxtL3.Text = lstxt3.Text.ToString
        lstxt3.Text = lstxtL3.Text.ToString
    End Sub

    Private Sub lstxt4_TextChanged(sender As Object, e As EventArgs) Handles lstxt4.TextChanged
        lstxtL4.Text = lstxt4.Text.ToString
        lstxt4.Text = lstxtL4.Text.ToString
    End Sub

    Private Sub lstxt5_TextChanged(sender As Object, e As EventArgs) Handles lstxt5.TextChanged
        lstxtL5.Text = lstxt5.Text.ToString
        lstxt5.Text = lstxtL5.Text.ToString
    End Sub

    Private Sub lstxtL5_Click(sender As Object, e As EventArgs) Handles lstxtL5.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles SaveStat.Click


        Dim sb As StringBuilder = New StringBuilder()

        sb.Append(NameStat.Text & vbNewLine)
        sb.Append(LifeL.Text & vbNewLine)
        sb.Append(MoveL.Text & vbNewLine)
        sb.Append(RangeL.Text & vbNewLine)
        sb.Append(AttackL.Text & vbNewLine)
        sb.Append(DefenseL.Text & vbNewLine)
        sb.Append(bottomtopheaderL.Text & vbNewLine)
        sb.Append(lstxtL1.Text & vbNewLine)
        sb.Append(lstxtL2.Text & vbNewLine)
        sb.Append(lstxtL3.Text & vbNewLine)
        sb.Append(lstxtL4.Text & vbNewLine)
        sb.Append(lstxtL5.Text & vbNewLine)
        sb.Append(dfbg.ToString & vbNewLine)
        If (Not System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\StatEditor")) Then
            System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\StatEditor")
            System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\StatEditor\bio_files")
        End If
        If (Not System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\StatEditor\bio_files")) Then
            System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\StatEditor\bio_files")
        End If



        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\StatEditor\" & NameStat.Text & ".sef", sb.ToString())
        biotxt.SaveFile(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\StatEditor\bio_files\" & NameStat.Text & "_bio.sef")


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles OpenStat.Click
        Try
            Dim OpenF As New OpenFileDialog
            OpenF.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\StatEditor\"
            OpenF.Filter = "Stat Files (*.sef)|*.sef"
            OpenF.ShowDialog()
            OpenF.Title = "Open a Stat Card"
            OpenF.Multiselect = False
            FName = OpenF.FileName


            If FName = "" Then
                MessageBox.Show("Why did you even click open if" & vbNewLine &
                                "you were not going to even open a file.")
            Else
                Try
                    Dim reader As New System.IO.StreamReader(FName)
                    Dim NameCard, life1, move1, range1, attack1, defense1, lstxtL11, lstxtL22, lstxtL33, lstxtL44, lstxtL55, dfb As String

                    NameCard = reader.ReadLine()
                    life1 = reader.ReadLine()
                    move1 = reader.ReadLine()
                    range1 = reader.ReadLine()
                    attack1 = reader.ReadLine()
                    defense1 = reader.ReadLine()
                    bottomtopheaderL.Text = reader.ReadLine()
                    lstxtL11 = reader.ReadLine()
                    lstxtL22 = reader.ReadLine()
                    lstxtL33 = reader.ReadLine()
                    lstxtL44 = reader.ReadLine()
                    lstxtL55 = reader.ReadLine()
                    dfb = reader.ReadLine()
                    reader.Close()

                    NameStat.Text = NameCard
                    LifeL.Text = life1
                    MoveL.Text = move1
                    RangeL.Text = range1
                    AttackL.Text = attack1
                    DefenseL.Text = defense1
                    lstxtL1.Text = lstxtL11
                    lstxtL2.Text = lstxtL22
                    lstxtL3.Text = lstxtL33
                    lstxtL4.Text = lstxtL44
                    lstxtL5.Text = lstxtL55

                    'BG Loader -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

                    If dfb = "lblue" Then
                        Me.BackgroundImage = My.Resources.airborneelite_CustomImg_lightblue
                        fsi1.Image = My.Resources.airborneelite_CustomImg_lightblue
                    End If
                    If dfb = "blue" Then
                        Me.BackgroundImage = My.Resources.airborneelite_CustomImg_blue
                        fsi1.Image = My.Resources.airborneelite_CustomImg_blue
                    End If
                    If dfb = "brown" Then
                        Me.BackgroundImage = My.Resources.airborneelite_CustomImg_brown
                        fsi1.Image = My.Resources.airborneelite_CustomImg_brown
                    End If
                    If dfb = "gold" Then
                        Me.BackgroundImage = My.Resources.airborneelite_CustomImg_gold
                        fsi1.Image = My.Resources.airborneelite_CustomImg_gold
                    End If
                    If dfb = "green" Then
                        Me.BackgroundImage = My.Resources.airborneelite_CustomImg_green
                        fsi1.Image = My.Resources.airborneelite_CustomImg_green
                    End If
                    If dfb = "red" Then
                        Me.BackgroundImage = My.Resources.airborneelite_CustomImg_red
                        fsi1.Image = My.Resources.airborneelite_CustomImg_red
                    End If



                    ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

                    biotxt.LoadFile(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\StatEditor\bio_files\" & NameCard & "_bio.sef")


                    life = life1
                    moves = move1
                    range = range1
                    attack = attack1
                    Defense = defense1
                Catch ex As Exception
                    MessageBox.Show("Only you would figure out how to break the program. GG Mr.Eagle.", "GG", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
            End If
        Catch ex As Exception

            MessageBox.Show("Only you would figure out how to break the program. GG Mr.Eagle.", "GG", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try





    End Sub
End Class
