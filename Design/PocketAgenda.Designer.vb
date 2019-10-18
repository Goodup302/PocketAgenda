<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PocketAgenda
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PocketAgenda))
        Me.TimerNotification = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin = New Design.FormSkin()
        Me.FlatLabel6 = New Design.FlatLabel()
        Me.PictureBoxSettings = New System.Windows.Forms.PictureBox()
        Me.PictureClose = New System.Windows.Forms.PictureBox()
        Me.GroupBox = New Design.FlatGroupBox()
        Me.PictureNotification7 = New System.Windows.Forms.PictureBox()
        Me.PictureNotification6 = New System.Windows.Forms.PictureBox()
        Me.PictureNotification5 = New System.Windows.Forms.PictureBox()
        Me.LabelSelectDay = New Design.FlatLabel()
        Me.PictureNotification4 = New System.Windows.Forms.PictureBox()
        Me.PictureNotification3 = New System.Windows.Forms.PictureBox()
        Me.PictureNotification2 = New System.Windows.Forms.PictureBox()
        Me.PictureNotification1 = New System.Windows.Forms.PictureBox()
        Me.FlatLabel3 = New Design.FlatLabel()
        Me.ButtonDay7 = New Design.FlatStickyButton()
        Me.MonthCalendar = New System.Windows.Forms.MonthCalendar()
        Me.ButtonDay6 = New Design.FlatStickyButton()
        Me.ButtonDay5 = New Design.FlatStickyButton()
        Me.ButtonDay4 = New Design.FlatStickyButton()
        Me.ButtonDay3 = New Design.FlatStickyButton()
        Me.ButtonDay2 = New Design.FlatStickyButton()
        Me.ButtonDay1 = New Design.FlatStickyButton()
        Me.PictureBoxDay1 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxDay3 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxDay4 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxDay5 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxDay2 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxDay6 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxDay7 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxPrevious = New System.Windows.Forms.PictureBox()
        Me.PictureBoxNext = New System.Windows.Forms.PictureBox()
        Me.FlatLabel1 = New Design.FlatLabel()
        Me.FlatLabel2 = New Design.FlatLabel()
        Me.FlatGroupBox1 = New Design.FlatGroupBox()
        Me.LabenEvenement = New Design.FlatLabel()
        Me.LabelTaches = New Design.FlatLabel()
        Me.Title = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FlatStatusBar1 = New Design.FlatStatusBar()
        Me.FlatColorPalette1 = New Design.FlatColorPalette()
        Me.FlatMax1 = New Design.FlatMax()
        Me.FlatMini1 = New Design.FlatMini()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStripIcon = New Design.FlatContextMenuStrip()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormSkin.SuspendLayout()
        CType(Me.PictureBoxSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox.SuspendLayout()
        CType(Me.PictureNotification7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureNotification6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureNotification5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureNotification4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureNotification3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureNotification2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureNotification1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxDay1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxDay3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxDay4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxDay5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxDay2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxDay6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxDay7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPrevious, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxNext, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlatGroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripIcon.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimerNotification
        '
        Me.TimerNotification.Interval = 1000
        '
        'FormSkin
        '
        Me.FormSkin.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.FormSkin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.FormSkin.BorderColor = System.Drawing.Color.Teal
        Me.FormSkin.Controls.Add(Me.FlatLabel6)
        Me.FormSkin.Controls.Add(Me.PictureBoxSettings)
        Me.FormSkin.Controls.Add(Me.PictureClose)
        Me.FormSkin.Controls.Add(Me.GroupBox)
        Me.FormSkin.Controls.Add(Me.Title)
        Me.FormSkin.Controls.Add(Me.PictureBox1)
        Me.FormSkin.Controls.Add(Me.FlatStatusBar1)
        Me.FormSkin.Controls.Add(Me.FlatColorPalette1)
        Me.FormSkin.Controls.Add(Me.FlatMax1)
        Me.FormSkin.Controls.Add(Me.FlatMini1)
        Me.FormSkin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin.FlatColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.FormSkin.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.FormSkin.HeaderMaximize = False
        Me.FormSkin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.FormSkin.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin.Name = "FormSkin"
        Me.FormSkin.Size = New System.Drawing.Size(1280, 720)
        Me.FormSkin.TabIndex = 0
        Me.FormSkin.Text = "PocketAgenda"
        '
        'FlatLabel6
        '
        Me.FlatLabel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlatLabel6.AutoSize = True
        Me.FlatLabel6.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel6.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.FlatLabel6.Location = New System.Drawing.Point(1084, 103)
        Me.FlatLabel6.Name = "FlatLabel6"
        Me.FlatLabel6.Size = New System.Drawing.Size(86, 20)
        Me.FlatLabel6.TabIndex = 53
        Me.FlatLabel6.Text = "Paramètres"
        '
        'PictureBoxSettings
        '
        Me.PictureBoxSettings.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBoxSettings.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxSettings.Image = Global.Design.My.Resources.Resources.settings
        Me.PictureBoxSettings.Location = New System.Drawing.Point(1176, 80)
        Me.PictureBoxSettings.Name = "PictureBoxSettings"
        Me.PictureBoxSettings.Size = New System.Drawing.Size(64, 64)
        Me.PictureBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxSettings.TabIndex = 52
        Me.PictureBoxSettings.TabStop = False
        '
        'PictureClose
        '
        Me.PictureClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureClose.Image = Global.Design.My.Resources.Resources.close
        Me.PictureClose.Location = New System.Drawing.Point(1246, 16)
        Me.PictureClose.Name = "PictureClose"
        Me.PictureClose.Size = New System.Drawing.Size(18, 18)
        Me.PictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureClose.TabIndex = 48
        Me.PictureClose.TabStop = False
        '
        'GroupBox
        '
        Me.GroupBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox.BaseColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.GroupBox.Controls.Add(Me.PictureNotification7)
        Me.GroupBox.Controls.Add(Me.PictureNotification6)
        Me.GroupBox.Controls.Add(Me.PictureNotification5)
        Me.GroupBox.Controls.Add(Me.LabelSelectDay)
        Me.GroupBox.Controls.Add(Me.PictureNotification4)
        Me.GroupBox.Controls.Add(Me.PictureNotification3)
        Me.GroupBox.Controls.Add(Me.PictureNotification2)
        Me.GroupBox.Controls.Add(Me.PictureNotification1)
        Me.GroupBox.Controls.Add(Me.FlatLabel3)
        Me.GroupBox.Controls.Add(Me.ButtonDay7)
        Me.GroupBox.Controls.Add(Me.MonthCalendar)
        Me.GroupBox.Controls.Add(Me.ButtonDay6)
        Me.GroupBox.Controls.Add(Me.ButtonDay5)
        Me.GroupBox.Controls.Add(Me.ButtonDay4)
        Me.GroupBox.Controls.Add(Me.ButtonDay3)
        Me.GroupBox.Controls.Add(Me.ButtonDay2)
        Me.GroupBox.Controls.Add(Me.ButtonDay1)
        Me.GroupBox.Controls.Add(Me.PictureBoxDay1)
        Me.GroupBox.Controls.Add(Me.PictureBoxDay3)
        Me.GroupBox.Controls.Add(Me.PictureBoxDay4)
        Me.GroupBox.Controls.Add(Me.PictureBoxDay5)
        Me.GroupBox.Controls.Add(Me.PictureBoxDay2)
        Me.GroupBox.Controls.Add(Me.PictureBoxDay6)
        Me.GroupBox.Controls.Add(Me.PictureBoxDay7)
        Me.GroupBox.Controls.Add(Me.PictureBoxPrevious)
        Me.GroupBox.Controls.Add(Me.PictureBoxNext)
        Me.GroupBox.Controls.Add(Me.FlatLabel1)
        Me.GroupBox.Controls.Add(Me.FlatLabel2)
        Me.GroupBox.Controls.Add(Me.FlatGroupBox1)
        Me.GroupBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GroupBox.Location = New System.Drawing.Point(12, 160)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.ShowText = True
        Me.GroupBox.Size = New System.Drawing.Size(1256, 531)
        Me.GroupBox.TabIndex = 45
        '
        'PictureNotification7
        '
        Me.PictureNotification7.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PictureNotification7.Image = CType(resources.GetObject("PictureNotification7.Image"), System.Drawing.Image)
        Me.PictureNotification7.Location = New System.Drawing.Point(906, 56)
        Me.PictureNotification7.Name = "PictureNotification7"
        Me.PictureNotification7.Size = New System.Drawing.Size(32, 32)
        Me.PictureNotification7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureNotification7.TabIndex = 122
        Me.PictureNotification7.TabStop = False
        Me.PictureNotification7.Tag = "5"
        Me.PictureNotification7.Visible = False
        '
        'PictureNotification6
        '
        Me.PictureNotification6.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PictureNotification6.Image = CType(resources.GetObject("PictureNotification6.Image"), System.Drawing.Image)
        Me.PictureNotification6.Location = New System.Drawing.Point(783, 56)
        Me.PictureNotification6.Name = "PictureNotification6"
        Me.PictureNotification6.Size = New System.Drawing.Size(32, 32)
        Me.PictureNotification6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureNotification6.TabIndex = 121
        Me.PictureNotification6.TabStop = False
        Me.PictureNotification6.Tag = "5"
        Me.PictureNotification6.Visible = False
        '
        'PictureNotification5
        '
        Me.PictureNotification5.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PictureNotification5.Image = CType(resources.GetObject("PictureNotification5.Image"), System.Drawing.Image)
        Me.PictureNotification5.Location = New System.Drawing.Point(660, 56)
        Me.PictureNotification5.Name = "PictureNotification5"
        Me.PictureNotification5.Size = New System.Drawing.Size(32, 32)
        Me.PictureNotification5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureNotification5.TabIndex = 57
        Me.PictureNotification5.TabStop = False
        Me.PictureNotification5.Tag = "5"
        Me.PictureNotification5.Visible = False
        '
        'LabelSelectDay
        '
        Me.LabelSelectDay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelSelectDay.BackColor = System.Drawing.Color.Transparent
        Me.LabelSelectDay.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSelectDay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.LabelSelectDay.Location = New System.Drawing.Point(1007, 24)
        Me.LabelSelectDay.Name = "LabelSelectDay"
        Me.LabelSelectDay.Size = New System.Drawing.Size(227, 21)
        Me.LabelSelectDay.TabIndex = 64
        Me.LabelSelectDay.Text = "LabelSelectDay"
        Me.LabelSelectDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureNotification4
        '
        Me.PictureNotification4.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PictureNotification4.Image = CType(resources.GetObject("PictureNotification4.Image"), System.Drawing.Image)
        Me.PictureNotification4.Location = New System.Drawing.Point(537, 56)
        Me.PictureNotification4.Name = "PictureNotification4"
        Me.PictureNotification4.Size = New System.Drawing.Size(32, 32)
        Me.PictureNotification4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureNotification4.TabIndex = 56
        Me.PictureNotification4.TabStop = False
        Me.PictureNotification4.Tag = "4"
        Me.PictureNotification4.Visible = False
        '
        'PictureNotification3
        '
        Me.PictureNotification3.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PictureNotification3.Image = CType(resources.GetObject("PictureNotification3.Image"), System.Drawing.Image)
        Me.PictureNotification3.Location = New System.Drawing.Point(414, 56)
        Me.PictureNotification3.Name = "PictureNotification3"
        Me.PictureNotification3.Size = New System.Drawing.Size(32, 32)
        Me.PictureNotification3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureNotification3.TabIndex = 55
        Me.PictureNotification3.TabStop = False
        Me.PictureNotification3.Tag = "3"
        Me.PictureNotification3.Visible = False
        '
        'PictureNotification2
        '
        Me.PictureNotification2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PictureNotification2.Image = CType(resources.GetObject("PictureNotification2.Image"), System.Drawing.Image)
        Me.PictureNotification2.Location = New System.Drawing.Point(291, 56)
        Me.PictureNotification2.Name = "PictureNotification2"
        Me.PictureNotification2.Size = New System.Drawing.Size(32, 32)
        Me.PictureNotification2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureNotification2.TabIndex = 54
        Me.PictureNotification2.TabStop = False
        Me.PictureNotification2.Tag = "2"
        Me.PictureNotification2.Visible = False
        '
        'PictureNotification1
        '
        Me.PictureNotification1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PictureNotification1.Image = CType(resources.GetObject("PictureNotification1.Image"), System.Drawing.Image)
        Me.PictureNotification1.Location = New System.Drawing.Point(168, 56)
        Me.PictureNotification1.Name = "PictureNotification1"
        Me.PictureNotification1.Size = New System.Drawing.Size(32, 32)
        Me.PictureNotification1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureNotification1.TabIndex = 53
        Me.PictureNotification1.TabStop = False
        Me.PictureNotification1.Tag = "1"
        Me.PictureNotification1.Visible = False
        '
        'FlatLabel3
        '
        Me.FlatLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.FlatLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatLabel3.Location = New System.Drawing.Point(82, 15)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(856, 32)
        Me.FlatLabel3.TabIndex = 45
        Me.FlatLabel3.Text = "Date"
        Me.FlatLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonDay7
        '
        Me.ButtonDay7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonDay7.BackColor = System.Drawing.Color.Transparent
        Me.ButtonDay7.BaseColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ButtonDay7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDay7.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.ButtonDay7.Location = New System.Drawing.Point(820, 56)
        Me.ButtonDay7.Name = "ButtonDay7"
        Me.ButtonDay7.Rounded = False
        Me.ButtonDay7.Size = New System.Drawing.Size(118, 162)
        Me.ButtonDay7.TabIndex = 111
        Me.ButtonDay7.Text = "Dimanche"
        Me.ButtonDay7.TextColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        '
        'MonthCalendar
        '
        Me.MonthCalendar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MonthCalendar.Location = New System.Drawing.Point(1007, 56)
        Me.MonthCalendar.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.MonthCalendar.MaxSelectionCount = 1
        Me.MonthCalendar.MinDate = New Date(2016, 1, 1, 0, 0, 0, 0)
        Me.MonthCalendar.Name = "MonthCalendar"
        Me.MonthCalendar.ShowTodayCircle = False
        Me.MonthCalendar.TabIndex = 44
        '
        'ButtonDay6
        '
        Me.ButtonDay6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonDay6.BackColor = System.Drawing.Color.Transparent
        Me.ButtonDay6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ButtonDay6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDay6.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.ButtonDay6.Location = New System.Drawing.Point(697, 56)
        Me.ButtonDay6.Name = "ButtonDay6"
        Me.ButtonDay6.Rounded = False
        Me.ButtonDay6.Size = New System.Drawing.Size(118, 162)
        Me.ButtonDay6.TabIndex = 110
        Me.ButtonDay6.Text = "Samedi"
        Me.ButtonDay6.TextColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        '
        'ButtonDay5
        '
        Me.ButtonDay5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonDay5.BackColor = System.Drawing.Color.Transparent
        Me.ButtonDay5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ButtonDay5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDay5.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.ButtonDay5.Location = New System.Drawing.Point(574, 56)
        Me.ButtonDay5.Name = "ButtonDay5"
        Me.ButtonDay5.Rounded = False
        Me.ButtonDay5.Size = New System.Drawing.Size(118, 162)
        Me.ButtonDay5.TabIndex = 109
        Me.ButtonDay5.Text = "Vendredi"
        Me.ButtonDay5.TextColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        '
        'ButtonDay4
        '
        Me.ButtonDay4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonDay4.BackColor = System.Drawing.Color.Transparent
        Me.ButtonDay4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ButtonDay4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDay4.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.ButtonDay4.Location = New System.Drawing.Point(451, 56)
        Me.ButtonDay4.Name = "ButtonDay4"
        Me.ButtonDay4.Rounded = False
        Me.ButtonDay4.Size = New System.Drawing.Size(118, 162)
        Me.ButtonDay4.TabIndex = 108
        Me.ButtonDay4.Text = "Jeudi"
        Me.ButtonDay4.TextColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        '
        'ButtonDay3
        '
        Me.ButtonDay3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonDay3.BackColor = System.Drawing.Color.Transparent
        Me.ButtonDay3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ButtonDay3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDay3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.ButtonDay3.Location = New System.Drawing.Point(328, 56)
        Me.ButtonDay3.Name = "ButtonDay3"
        Me.ButtonDay3.Rounded = False
        Me.ButtonDay3.Size = New System.Drawing.Size(118, 162)
        Me.ButtonDay3.TabIndex = 107
        Me.ButtonDay3.Text = "Mercredi"
        Me.ButtonDay3.TextColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        '
        'ButtonDay2
        '
        Me.ButtonDay2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonDay2.BackColor = System.Drawing.Color.Transparent
        Me.ButtonDay2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ButtonDay2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDay2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.ButtonDay2.Location = New System.Drawing.Point(205, 56)
        Me.ButtonDay2.Name = "ButtonDay2"
        Me.ButtonDay2.Rounded = False
        Me.ButtonDay2.Size = New System.Drawing.Size(118, 162)
        Me.ButtonDay2.TabIndex = 106
        Me.ButtonDay2.Text = "Mardi"
        Me.ButtonDay2.TextColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        '
        'ButtonDay1
        '
        Me.ButtonDay1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonDay1.BackColor = System.Drawing.Color.Transparent
        Me.ButtonDay1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ButtonDay1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDay1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.ButtonDay1.Location = New System.Drawing.Point(82, 56)
        Me.ButtonDay1.Name = "ButtonDay1"
        Me.ButtonDay1.Rounded = False
        Me.ButtonDay1.Size = New System.Drawing.Size(118, 162)
        Me.ButtonDay1.TabIndex = 52
        Me.ButtonDay1.Text = "Lundi"
        Me.ButtonDay1.TextColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        '
        'PictureBoxDay1
        '
        Me.PictureBoxDay1.BackColor = System.Drawing.Color.DarkCyan
        Me.PictureBoxDay1.Location = New System.Drawing.Point(79, 53)
        Me.PictureBoxDay1.Name = "PictureBoxDay1"
        Me.PictureBoxDay1.Size = New System.Drawing.Size(124, 168)
        Me.PictureBoxDay1.TabIndex = 51
        Me.PictureBoxDay1.TabStop = False
        Me.PictureBoxDay1.Tag = "1"
        Me.PictureBoxDay1.Visible = False
        '
        'PictureBoxDay3
        '
        Me.PictureBoxDay3.BackColor = System.Drawing.Color.DarkCyan
        Me.PictureBoxDay3.Location = New System.Drawing.Point(325, 53)
        Me.PictureBoxDay3.Name = "PictureBoxDay3"
        Me.PictureBoxDay3.Size = New System.Drawing.Size(124, 168)
        Me.PictureBoxDay3.TabIndex = 115
        Me.PictureBoxDay3.TabStop = False
        Me.PictureBoxDay3.Tag = "1"
        Me.PictureBoxDay3.Visible = False
        '
        'PictureBoxDay4
        '
        Me.PictureBoxDay4.BackColor = System.Drawing.Color.DarkCyan
        Me.PictureBoxDay4.Location = New System.Drawing.Point(448, 53)
        Me.PictureBoxDay4.Name = "PictureBoxDay4"
        Me.PictureBoxDay4.Size = New System.Drawing.Size(124, 168)
        Me.PictureBoxDay4.TabIndex = 114
        Me.PictureBoxDay4.TabStop = False
        Me.PictureBoxDay4.Tag = "1"
        Me.PictureBoxDay4.Visible = False
        '
        'PictureBoxDay5
        '
        Me.PictureBoxDay5.BackColor = System.Drawing.Color.DarkCyan
        Me.PictureBoxDay5.Location = New System.Drawing.Point(571, 53)
        Me.PictureBoxDay5.Name = "PictureBoxDay5"
        Me.PictureBoxDay5.Size = New System.Drawing.Size(124, 168)
        Me.PictureBoxDay5.TabIndex = 113
        Me.PictureBoxDay5.TabStop = False
        Me.PictureBoxDay5.Tag = "1"
        Me.PictureBoxDay5.Visible = False
        '
        'PictureBoxDay2
        '
        Me.PictureBoxDay2.BackColor = System.Drawing.Color.DarkCyan
        Me.PictureBoxDay2.Location = New System.Drawing.Point(202, 53)
        Me.PictureBoxDay2.Name = "PictureBoxDay2"
        Me.PictureBoxDay2.Size = New System.Drawing.Size(124, 168)
        Me.PictureBoxDay2.TabIndex = 112
        Me.PictureBoxDay2.TabStop = False
        Me.PictureBoxDay2.Tag = "1"
        Me.PictureBoxDay2.Visible = False
        '
        'PictureBoxDay6
        '
        Me.PictureBoxDay6.BackColor = System.Drawing.Color.DarkCyan
        Me.PictureBoxDay6.Location = New System.Drawing.Point(694, 53)
        Me.PictureBoxDay6.Name = "PictureBoxDay6"
        Me.PictureBoxDay6.Size = New System.Drawing.Size(124, 168)
        Me.PictureBoxDay6.TabIndex = 116
        Me.PictureBoxDay6.TabStop = False
        Me.PictureBoxDay6.Tag = "1"
        Me.PictureBoxDay6.Visible = False
        '
        'PictureBoxDay7
        '
        Me.PictureBoxDay7.BackColor = System.Drawing.Color.DarkCyan
        Me.PictureBoxDay7.Location = New System.Drawing.Point(817, 53)
        Me.PictureBoxDay7.Name = "PictureBoxDay7"
        Me.PictureBoxDay7.Size = New System.Drawing.Size(124, 168)
        Me.PictureBoxDay7.TabIndex = 117
        Me.PictureBoxDay7.TabStop = False
        Me.PictureBoxDay7.Tag = "1"
        Me.PictureBoxDay7.Visible = False
        '
        'PictureBoxPrevious
        '
        Me.PictureBoxPrevious.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBoxPrevious.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxPrevious.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxPrevious.Image = Global.Design.My.Resources.Resources.arrow_left
        Me.PictureBoxPrevious.Location = New System.Drawing.Point(12, 97)
        Me.PictureBoxPrevious.Name = "PictureBoxPrevious"
        Me.PictureBoxPrevious.Size = New System.Drawing.Size(75, 78)
        Me.PictureBoxPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxPrevious.TabIndex = 22
        Me.PictureBoxPrevious.TabStop = False
        '
        'PictureBoxNext
        '
        Me.PictureBoxNext.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBoxNext.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxNext.Image = Global.Design.My.Resources.Resources.arrow_right
        Me.PictureBoxNext.Location = New System.Drawing.Point(932, 97)
        Me.PictureBoxNext.Name = "PictureBoxNext"
        Me.PictureBoxNext.Size = New System.Drawing.Size(75, 78)
        Me.PictureBoxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxNext.TabIndex = 23
        Me.PictureBoxNext.TabStop = False
        '
        'FlatLabel1
        '
        Me.FlatLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FlatLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatLabel1.Location = New System.Drawing.Point(16, 79)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(60, 15)
        Me.FlatLabel1.TabIndex = 24
        Me.FlatLabel1.Text = "Précédent"
        '
        'FlatLabel2
        '
        Me.FlatLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FlatLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatLabel2.Location = New System.Drawing.Point(950, 79)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(47, 15)
        Me.FlatLabel2.TabIndex = 25
        Me.FlatLabel2.Text = "Suivant"
        '
        'FlatGroupBox1
        '
        Me.FlatGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox1.BaseColor = System.Drawing.Color.Silver
        Me.FlatGroupBox1.Controls.Add(Me.LabenEvenement)
        Me.FlatGroupBox1.Controls.Add(Me.LabelTaches)
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox1.Location = New System.Drawing.Point(19, 230)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = True
        Me.FlatGroupBox1.Size = New System.Drawing.Size(1215, 282)
        Me.FlatGroupBox1.TabIndex = 126
        '
        'LabenEvenement
        '
        Me.LabenEvenement.BackColor = System.Drawing.Color.Transparent
        Me.LabenEvenement.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.LabenEvenement.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.LabenEvenement.Location = New System.Drawing.Point(618, 10)
        Me.LabenEvenement.Name = "LabenEvenement"
        Me.LabenEvenement.Size = New System.Drawing.Size(578, 244)
        Me.LabenEvenement.TabIndex = 125
        Me.LabenEvenement.Text = "......"
        Me.LabenEvenement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelTaches
        '
        Me.LabelTaches.BackColor = System.Drawing.Color.Transparent
        Me.LabelTaches.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTaches.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.LabelTaches.Location = New System.Drawing.Point(23, 10)
        Me.LabelTaches.Name = "LabelTaches"
        Me.LabelTaches.Size = New System.Drawing.Size(578, 244)
        Me.LabelTaches.TabIndex = 124
        Me.LabelTaches.Text = "......"
        Me.LabelTaches.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Title
        '
        Me.Title.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Title.Location = New System.Drawing.Point(117, 80)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(244, 47)
        Me.Title.TabIndex = 37
        Me.Title.Text = "PocketAgenda"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Design.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'FlatStatusBar1
        '
        Me.FlatStatusBar1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.FlatStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlatStatusBar1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatStatusBar1.ForeColor = System.Drawing.Color.White
        Me.FlatStatusBar1.Location = New System.Drawing.Point(0, 697)
        Me.FlatStatusBar1.Name = "FlatStatusBar1"
        Me.FlatStatusBar1.RectColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.FlatStatusBar1.ShowTimeDate = False
        Me.FlatStatusBar1.Size = New System.Drawing.Size(1280, 23)
        Me.FlatStatusBar1.TabIndex = 11
        Me.FlatStatusBar1.TextColor = System.Drawing.Color.White
        '
        'FlatColorPalette1
        '
        Me.FlatColorPalette1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatColorPalette1.Black = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatColorPalette1.Blue = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FlatColorPalette1.Cyan = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.FlatColorPalette1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatColorPalette1.Gray = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatColorPalette1.LimeGreen = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatColorPalette1.Location = New System.Drawing.Point(778, 10)
        Me.FlatColorPalette1.Name = "FlatColorPalette1"
        Me.FlatColorPalette1.Orange = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.FlatColorPalette1.Purple = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.FlatColorPalette1.Red = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.FlatColorPalette1.Size = New System.Drawing.Size(180, 80)
        Me.FlatColorPalette1.TabIndex = 10
        Me.FlatColorPalette1.Text = "FlatColorPalette1"
        Me.FlatColorPalette1.Visible = False
        Me.FlatColorPalette1.White = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatMax1
        '
        Me.FlatMax1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMax1.BackColor = System.Drawing.Color.White
        Me.FlatMax1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.FlatMax1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMax1.Location = New System.Drawing.Point(1222, 16)
        Me.FlatMax1.Name = "FlatMax1"
        Me.FlatMax1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMax1.TabIndex = 8
        Me.FlatMax1.Text = "FlatMax1"
        Me.FlatMax1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(1197, 16)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 7
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'NotifyIcon
        '
        Me.NotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon.BalloonTipText = "Pour ouvrir PocketAgenda cliquez sur l'icon ci dessous"
        Me.NotifyIcon.BalloonTipTitle = "PocketAgenda"
        Me.NotifyIcon.ContextMenuStrip = Me.ContextMenuStripIcon
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "PocketAgenda"
        Me.NotifyIcon.Visible = True
        '
        'ContextMenuStripIcon
        '
        Me.ContextMenuStripIcon.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ContextMenuStripIcon.ForeColor = System.Drawing.Color.White
        Me.ContextMenuStripIcon.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.ContextMenuStripIcon.Name = "FlatContextMenuStrip1"
        Me.ContextMenuStripIcon.ShowImageMargin = False
        Me.ContextMenuStripIcon.Size = New System.Drawing.Size(128, 70)
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        Me.OuvrirToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.OuvrirToolStripMenuItem.Text = "Ouvrir"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'PocketAgenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.FormSkin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PocketAgenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PocketAgenda"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin.ResumeLayout(False)
        Me.FormSkin.PerformLayout()
        CType(Me.PictureBoxSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        CType(Me.PictureNotification7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureNotification6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureNotification5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureNotification4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureNotification3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureNotification2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureNotification1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxDay1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxDay3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxDay4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxDay5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxDay2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxDay6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxDay7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPrevious, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxNext, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlatGroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripIcon.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin As FormSkin
    Friend WithEvents FlatMax1 As FlatMax
    Friend WithEvents FlatMini1 As FlatMini
    Friend WithEvents FlatStatusBar1 As FlatStatusBar
    Friend WithEvents FlatColorPalette1 As FlatColorPalette
    Friend WithEvents PictureBoxNext As PictureBox
    Friend WithEvents PictureBoxPrevious As PictureBox
    Friend WithEvents FlatLabel2 As FlatLabel
    Friend WithEvents FlatLabel1 As FlatLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents MonthCalendar As MonthCalendar
    Friend WithEvents GroupBox As FlatGroupBox
    Friend WithEvents FlatLabel3 As FlatLabel
    Friend WithEvents PictureBoxDay1 As PictureBox
    Friend WithEvents PictureNotification1 As PictureBox
    Friend WithEvents PictureNotification5 As PictureBox
    Friend WithEvents PictureNotification4 As PictureBox
    Friend WithEvents PictureNotification3 As PictureBox
    Friend WithEvents PictureNotification2 As PictureBox
    Friend WithEvents LabelSelectDay As FlatLabel
    Friend WithEvents PictureClose As PictureBox
    Friend WithEvents ButtonDay7 As FlatStickyButton
    Friend WithEvents ButtonDay6 As FlatStickyButton
    Friend WithEvents ButtonDay5 As FlatStickyButton
    Friend WithEvents ButtonDay4 As FlatStickyButton
    Friend WithEvents ButtonDay3 As FlatStickyButton
    Friend WithEvents ButtonDay2 As FlatStickyButton
    Friend WithEvents ButtonDay1 As FlatStickyButton
    Friend WithEvents PictureBoxDay3 As PictureBox
    Friend WithEvents PictureBoxDay4 As PictureBox
    Friend WithEvents PictureBoxDay5 As PictureBox
    Friend WithEvents PictureBoxDay2 As PictureBox
    Friend WithEvents PictureBoxDay6 As PictureBox
    Friend WithEvents PictureBoxDay7 As PictureBox
    Friend WithEvents PictureNotification7 As PictureBox
    Friend WithEvents PictureNotification6 As PictureBox
    Friend WithEvents LabelTaches As FlatLabel
    Friend WithEvents LabenEvenement As FlatLabel
    Friend WithEvents FlatGroupBox1 As FlatGroupBox
    Public WithEvents TimerNotification As Timer
    Friend WithEvents FlatLabel6 As FlatLabel
    Friend WithEvents PictureBoxSettings As PictureBox
    Friend WithEvents NotifyIcon As NotifyIcon
    Friend WithEvents ContextMenuStripIcon As FlatContextMenuStrip
    Friend WithEvents OuvrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
End Class
