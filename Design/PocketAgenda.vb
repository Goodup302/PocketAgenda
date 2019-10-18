Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Xml.Serialization
Imports System.IO

Public Class PocketAgenda
    Public Const Version As String = "1.3b"
    Public DataDirectory As String = Environment.GetEnvironmentVariable("systemdrive") & "\PocketAgenda\"
    Public DataFile As New List(Of Jour)
    '
    Public WeekArray(6) As Date
    '
    Public ButtonDay(6) As Object
    Public PictureButtonDay(6) As Object
    Public PictureNotification(6) As Object
    '
    Public Color_black As Color = Color.FromArgb(45, 47, 49)
    Public Color_blue As Color = Color.FromArgb(0, 128, 255)
    Public Color_Cyan As Color = Color.FromArgb(10, 154, 157)
    Public Color_Gray As Color = Color.FromArgb(63, 70, 73)
    Public Color_LimeGreen As Color = Color.FromArgb(35, 168, 109)
    Public Color_Orange As Color = Color.FromArgb(253, 181, 63)
    Public Color_Purple As Color = Color.FromArgb(155, 88, 181)
    Public Color_Red As Color = Color.FromArgb(220, 85, 96)
    Public Color_White As Color = Color.FromArgb(243, 243, 243)

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Program.IsStarted("PocketAgenda")
        Program.SetDirectory(DataDirectory)
        Program.CreateDirectory()
        Program.LoadConfig()
        Program.LanchToWindowsStart(Program.Config.EnableNotification)

        'Objet graphique dynamique
        ButtonDay(0) = ButtonDay1
        ButtonDay(1) = ButtonDay2
        ButtonDay(2) = ButtonDay3
        ButtonDay(3) = ButtonDay4
        ButtonDay(4) = ButtonDay5
        ButtonDay(5) = ButtonDay6
        ButtonDay(6) = ButtonDay7
        PictureButtonDay(0) = PictureBoxDay1
        PictureButtonDay(1) = PictureBoxDay2
        PictureButtonDay(2) = PictureBoxDay3
        PictureButtonDay(3) = PictureBoxDay4
        PictureButtonDay(4) = PictureBoxDay5
        PictureButtonDay(5) = PictureBoxDay6
        PictureButtonDay(6) = PictureBoxDay7
        PictureNotification(0) = PictureNotification1
        PictureNotification(1) = PictureNotification2
        PictureNotification(2) = PictureNotification3
        PictureNotification(3) = PictureNotification4
        PictureNotification(4) = PictureNotification5
        PictureNotification(5) = PictureNotification6
        PictureNotification(6) = PictureNotification7

        'Initialisation du Form
        With Me
            TimerNotification.Start()
            MonthCalendar_SetSelectionRange(MonthCalendar, Now)
            FlatLabel3.Text = MonthCalendar.SelectionRange.Start
            FlatStatusBar1.Text = "PocketAgenda v" & Version & " créer par GoodUp302"
            CalcFirstDay()
            RefrechButton()
            RefrechNotification()
            RefrechPictureBoxDay()
            RefrechTextbox()
        End With

    End Sub

#Region "MainEvent"
    Private Sub Main_Closing(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim Cancel As Short = eventArgs.Cancel
        Cancel = True
        eventArgs.Cancel = Cancel
        Me.Visible = False
        Me.NotifyIcon.ShowBalloonTip(2000)
    End Sub
    Private Sub PictureClose_Click(sender As Object, e As EventArgs) Handles PictureClose.Click
        If Program.Config.EnableNotification Then
            Me.Visible = False
            Me.NotifyIcon.ShowBalloonTip(2000)
        Else
            Me.NotifyIcon.Visible = False
            End
        End If
    End Sub
    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin.DoubleClick
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
        Me.FlatMax1.Enabled = False : Me.FlatMax1.Enabled = True
    End Sub
    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Me.NotifyIcon.Visible = False
        End
    End Sub

    Private Sub OuvrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem.Click
        Me.Visible = True
    End Sub
#End Region

#Region "Refrech"
    Sub CalcFirstDay()
        Dim FirstDay As Date
        FirstDay = Me.MonthCalendar.SelectionRange.Start
        If Not Me.MonthCalendar.SelectionRange.Start.DayOfWeek = 0 Then
            Dim x As Integer = Me.MonthCalendar.SelectionRange.Start.DayOfWeek - 1
            FirstDay = FirstDay.AddDays(-x)
        Else
            FirstDay = FirstDay.AddDays(-6)
        End If
        Dim xday As Date = FirstDay.AddDays(-1)
        For x As Integer = 0 To 6
            xday = xday.AddDays(1)
            WeekArray(x) = xday
        Next
    End Sub

    Sub RefrechNotification()
        For x As Integer = 0 To 6
            PictureNotification(x).Visible = False
            If File.Exists(Program.DataDirectory & WeekArray(x).ToLongDateString & ".bin") Then
                PictureNotification(x).Visible = True
            End If
        Next
    End Sub

    Sub RefrechButton()
        With Me
            FlatLabel3.Text = "Du " & WeekArray(0).ToLongDateString & " au " & WeekArray(6).ToLongDateString
            LabelSelectDay.Text = MonthCalendar.SelectionRange.Start.ToLongDateString
            '
            For x As Integer = 0 To 6
                ButtonDay(x).Text = WeekArray(x).ToLongDateString
                ButtonDay(x).Enabled = False
            Next
            For x As Integer = 0 To 6
                ButtonDay(x).Enabled = True
            Next
            '
        End With
    End Sub

    Sub RefrechTextbox()
        Dim dir As String = Program.DataDirectory & Me.LabelSelectDay.Text & ".bin"
        Me.LabelTaches.Text = Jour.Text(dir, 0)
        Me.LabenEvenement.Text = Jour.Text(dir, 1)
    End Sub
#End Region

    Sub MonthCalendar_SetSelectionRange(ByVal _MonthCalendar As Object, ByVal _date As Date)
        _MonthCalendar.SelectionRange = New SelectionRange(DateTime.Parse(_date), DateTime.Parse(_date))
    End Sub

    Private Sub PictureBoxNext_Click(sender As Object, e As EventArgs) Handles PictureBoxNext.MouseDown
        MonthCalendar_SetSelectionRange(MonthCalendar, MonthCalendar.SelectionRange.Start.AddDays(7))
        CalcFirstDay()
        RefrechButton()
        RefrechNotification()
        RefrechTextbox()
    End Sub

    Private Sub PictureBoxPrevious_Click(sender As Object, e As EventArgs) Handles PictureBoxPrevious.MouseDown
        MonthCalendar_SetSelectionRange(MonthCalendar, MonthCalendar.SelectionRange.Start.AddDays(-7))
        CalcFirstDay()
        RefrechButton()
        RefrechNotification()
        RefrechTextbox()
    End Sub

#Region "ButtonDay"
    '
    Sub ShowProgram(ByVal nbr As Object)
        Gestion.laDate = WeekArray(nbr)
        Gestion.ShowDialog()
    End Sub

    Sub RefrechPictureBoxDay()
        Dim LocalDay As Date = Me.MonthCalendar.SelectionRange.Start.ToLongDateString
        Dim nbr As Integer
        For x = 0 To 6
            If ButtonDay(x).text = LocalDay Then
                nbr = x
                Exit For
            End If
        Next
        For x As Integer = 0 To 6
            PictureButtonDay(x).Visible = False
        Next
        PictureButtonDay(nbr).Visible = True
    End Sub

    Sub SelectButton(ByVal nbr As Integer)
        MonthCalendar_SetSelectionRange(MonthCalendar, WeekArray(nbr))
        Me.LabelSelectDay.Text = MonthCalendar.SelectionRange.Start.ToLongDateString
        RefrechPictureBoxDay()
        RefrechTextbox()
    End Sub

    'Clique simple
    Private Sub ButtonDay1_Click(sender As Object, e As EventArgs) Handles ButtonDay1.MouseDown
        SelectButton(0)
    End Sub
    Private Sub ButtonDay2_Click(sender As Object, e As EventArgs) Handles ButtonDay2.MouseDown
        SelectButton(1)
    End Sub
    Private Sub ButtonDay3_Click(sender As Object, e As EventArgs) Handles ButtonDay3.MouseDown
        SelectButton(2)
    End Sub
    Private Sub ButtonDay4_Click(sender As Object, e As EventArgs) Handles ButtonDay4.MouseDown
        SelectButton(3)
    End Sub
    Private Sub ButtonDay5_Click(sender As Object, e As EventArgs) Handles ButtonDay5.MouseDown
        SelectButton(4)
    End Sub
    Private Sub ButtonDay6_Click(sender As Object, e As EventArgs) Handles ButtonDay6.MouseDown
        SelectButton(5)
    End Sub
    Private Sub ButtonDay7_Click(sender As Object, e As EventArgs) Handles ButtonDay7.MouseDown
        SelectButton(6)
    End Sub
    'Double clique
    Private Sub ButtonDay1_DoubleClick(sender As Object, e As EventArgs) Handles ButtonDay1.DoubleClick
        ShowProgram(0)
    End Sub
    Private Sub ButtonDay2_DoubleClick(sender As Object, e As EventArgs) Handles ButtonDay2.DoubleClick
        ShowProgram(1)
    End Sub
    Private Sub ButtonDay3_DoubleClick(sender As Object, e As EventArgs) Handles ButtonDay3.DoubleClick
        ShowProgram(2)
    End Sub
    Private Sub ButtonDay4_DoubleClick(sender As Object, e As EventArgs) Handles ButtonDay4.DoubleClick
        ShowProgram(3)
    End Sub
    Private Sub ButtonDay5_DoubleClick(sender As Object, e As EventArgs) Handles ButtonDay5.DoubleClick
        ShowProgram(4)
    End Sub
    Private Sub ButtonDay6_DoubleClick(sender As Object, e As EventArgs) Handles ButtonDay6.DoubleClick
        ShowProgram(5)
    End Sub
    Private Sub ButtonDay7_DoubleClick(sender As Object, e As EventArgs) Handles ButtonDay7.DoubleClick
        ShowProgram(6)
    End Sub

#End Region

    Private Sub MonthCalendar_DateSelected(sender As Object, e As EventArgs) Handles MonthCalendar.DateSelected
        CalcFirstDay()
        RefrechButton()
        RefrechPictureBoxDay()
        RefrechNotification()
        RefrechTextbox()
    End Sub

    Private Sub PictureBoxSettings_Click(sender As Object, e As EventArgs) Handles PictureBoxSettings.Click
        Settings.ShowDialog()
    End Sub

#Region "Notification"
    Private Sub TimerNotification_Tick(sender As Object, e As EventArgs) Handles TimerNotification.Tick
        If Program.Config.EnableNotification Then
            'Définition des variables
            Dim dir1 As String = Program.DataDirectory & Now.ToLongDateString & ".bin"
            Dim dir2 As String = Program.DataDirectory & Now.AddDays(1).ToLongDateString & ".bin"
            Dim day1 As Jour = Jour.Import(dir1)
            Dim day2 As Jour = Jour.Import(dir2)
            Dim Timer As Integer = 0 : Timer -= Program.Config.TimerNotification

            'Ajout des elements du jour 2 dans le jour 1
            For Each Elements In day2.Elements
                day1.Elements.Add(Elements)
            Next

            'Détection des notification
            For Each Elements In day1.Elements
                If Elements.type = 1 And Now > Elements.time.AddMinutes(Timer) And Now < Elements.time.AddMinutes(Timer).AddSeconds(1) Then
                    ShowNotification(Elements)
                End If
            Next
        End If
    End Sub

    Sub ShowNotification(ByVal Element As Element)
        Notification.LabelText.Text = ""
        Notification.LabelText.Text += "L’évènement " & Element.name & " commence "
        If Program.Config.TimerNotification = 0 Then
            Notification.LabelText.Text += "maintenant."
        Else
            Notification.LabelText.Text += "dans " & Program.Config.TimerNotification & " minute(s)."
        End If
        Notification.LabelText.Text += Chr(13) & Chr(13) & Element.text
        Notification.Show()
        My.Computer.Audio.Play(My.Resources.notification, AudioPlayMode.Background)
    End Sub

    'Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    'Dim Test As New Element("Restorant", 1, Now)
    'Test.text = "Il faut venir bien habiller et  étre propre sur soi. njnjjnijnijnijnijnijnijnijninjinijnijniniqsdfghjklmlkjhgfdsqsdfghjklmqsdfghjklmqsdfghjklnpjnpijnpijnpijnpijnp"
    'ShowNotification(Test)
    'End Sub
#End Region
End Class