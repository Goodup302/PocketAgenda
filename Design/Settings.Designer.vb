<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Me.FormSkin1 = New Design.FormSkin()
        Me.FlatGroupBox1 = New Design.FlatGroupBox()
        Me.ButtonSave = New Design.FlatStickyButton()
        Me.ButtonCancel = New Design.FlatStickyButton()
        Me.FlatLabel2 = New Design.FlatLabel()
        Me.TrackBarNotification = New Design.FlatTrackBar()
        Me.FlatLabel1 = New Design.FlatLabel()
        Me.ToggleNotification = New Design.FlatToggle()
        Me.FlatColorPalette1 = New Design.FlatColorPalette()
        Me.FormSkin1.SuspendLayout()
        Me.FlatGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.Teal
        Me.FormSkin1.Controls.Add(Me.FlatGroupBox1)
        Me.FormSkin1.Controls.Add(Me.FlatColorPalette1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(521, 326)
        Me.FormSkin1.TabIndex = 1
        Me.FormSkin1.Text = "Paramètres"
        '
        'FlatGroupBox1
        '
        Me.FlatGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.FlatGroupBox1.Controls.Add(Me.ButtonSave)
        Me.FlatGroupBox1.Controls.Add(Me.ButtonCancel)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel2)
        Me.FlatGroupBox1.Controls.Add(Me.TrackBarNotification)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel1)
        Me.FlatGroupBox1.Controls.Add(Me.ToggleNotification)
        Me.FlatGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox1.Location = New System.Drawing.Point(0, 56)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = True
        Me.FlatGroupBox1.Size = New System.Drawing.Size(521, 270)
        Me.FlatGroupBox1.TabIndex = 10
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSave.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSave.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonSave.Location = New System.Drawing.Point(263, 203)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Rounded = False
        Me.ButtonSave.Size = New System.Drawing.Size(155, 39)
        Me.ButtonSave.TabIndex = 12
        Me.ButtonSave.Text = "Sauvegarder"
        Me.ButtonSave.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.Transparent
        Me.ButtonCancel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonCancel.Location = New System.Drawing.Point(102, 203)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Rounded = False
        Me.ButtonCancel.Size = New System.Drawing.Size(155, 39)
        Me.ButtonCancel.TabIndex = 2
        Me.ButtonCancel.Text = "Annuler"
        Me.ButtonCancel.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel2
        '
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(12, 100)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(497, 25)
        Me.FlatLabel2.TabIndex = 11
        Me.FlatLabel2.Text = "Notifications"
        Me.FlatLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TrackBarNotification
        '
        Me.TrackBarNotification.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TrackBarNotification.HatchColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TrackBarNotification.Location = New System.Drawing.Point(33, 141)
        Me.TrackBarNotification.Maximum = 60
        Me.TrackBarNotification.Minimum = 0
        Me.TrackBarNotification.Name = "TrackBarNotification"
        Me.TrackBarNotification.ShowValue = False
        Me.TrackBarNotification.Size = New System.Drawing.Size(455, 23)
        Me.TrackBarNotification.Style = Design.FlatTrackBar._Style.Slider
        Me.TrackBarNotification.TabIndex = 10
        Me.TrackBarNotification.TrackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TrackBarNotification.Value = 0
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(163, 36)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(112, 25)
        Me.FlatLabel1.TabIndex = 9
        Me.FlatLabel1.Text = "Notifications"
        '
        'ToggleNotification
        '
        Me.ToggleNotification.BackColor = System.Drawing.Color.Transparent
        Me.ToggleNotification.Checked = False
        Me.ToggleNotification.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ToggleNotification.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ToggleNotification.Location = New System.Drawing.Point(281, 34)
        Me.ToggleNotification.Name = "ToggleNotification"
        Me.ToggleNotification.Options = Design.FlatToggle._Options.Style2
        Me.ToggleNotification.Size = New System.Drawing.Size(76, 33)
        Me.ToggleNotification.TabIndex = 7
        Me.ToggleNotification.Text = "FlatToggle1"
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
        Me.FlatColorPalette1.Location = New System.Drawing.Point(191, -41)
        Me.FlatColorPalette1.Name = "FlatColorPalette1"
        Me.FlatColorPalette1.Orange = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.FlatColorPalette1.Purple = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.FlatColorPalette1.Red = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.FlatColorPalette1.Size = New System.Drawing.Size(180, 80)
        Me.FlatColorPalette1.TabIndex = 6
        Me.FlatColorPalette1.Text = "FlatColorPalette1"
        Me.FlatColorPalette1.Visible = False
        Me.FlatColorPalette1.White = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 326)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FlatGroupBox1.ResumeLayout(False)
        Me.FlatGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents FlatColorPalette1 As FlatColorPalette
    Friend WithEvents ToggleNotification As FlatToggle
    Friend WithEvents FlatGroupBox1 As FlatGroupBox
    Friend WithEvents FlatLabel1 As FlatLabel
    Friend WithEvents TrackBarNotification As FlatTrackBar
    Friend WithEvents FlatLabel2 As FlatLabel
    Friend WithEvents ButtonSave As FlatStickyButton
    Friend WithEvents ButtonCancel As FlatStickyButton
End Class
