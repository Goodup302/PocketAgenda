<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notification
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FormSkin1 = New Design.FormSkin()
        Me.ButtonOk = New Design.FlatButton()
        Me.FlatGroupBox = New Design.FlatGroupBox()
        Me.LabelText = New System.Windows.Forms.Label()
        Me.FlatColorPalette1 = New Design.FlatColorPalette()
        Me.FormSkin1.SuspendLayout()
        Me.FlatGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.ButtonOk)
        Me.FormSkin1.Controls.Add(Me.FlatGroupBox)
        Me.FormSkin1.Controls.Add(Me.FlatColorPalette1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(450, 300)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Notification"
        '
        'ButtonOk
        '
        Me.ButtonOk.BackColor = System.Drawing.Color.Transparent
        Me.ButtonOk.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonOk.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOk.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonOk.Location = New System.Drawing.Point(325, 10)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Rounded = False
        Me.ButtonOk.Size = New System.Drawing.Size(106, 32)
        Me.ButtonOk.TabIndex = 1
        Me.ButtonOk.Text = "Ok"
        Me.ButtonOk.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatGroupBox
        '
        Me.FlatGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox.BaseColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.FlatGroupBox.Controls.Add(Me.LabelText)
        Me.FlatGroupBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.FlatGroupBox.Location = New System.Drawing.Point(12, 67)
        Me.FlatGroupBox.Name = "FlatGroupBox"
        Me.FlatGroupBox.ShowText = True
        Me.FlatGroupBox.Size = New System.Drawing.Size(426, 221)
        Me.FlatGroupBox.TabIndex = 1
        '
        'LabelText
        '
        Me.LabelText.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.LabelText.Location = New System.Drawing.Point(3, 0)
        Me.LabelText.Name = "LabelText"
        Me.LabelText.Size = New System.Drawing.Size(420, 221)
        Me.LabelText.TabIndex = 0
        Me.LabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.FlatColorPalette1.Location = New System.Drawing.Point(128, -30)
        Me.FlatColorPalette1.Name = "FlatColorPalette1"
        Me.FlatColorPalette1.Orange = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.FlatColorPalette1.Purple = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.FlatColorPalette1.Red = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.FlatColorPalette1.Size = New System.Drawing.Size(180, 80)
        Me.FlatColorPalette1.TabIndex = 0
        Me.FlatColorPalette1.Text = "FlatColorPalette1"
        Me.FlatColorPalette1.Visible = False
        Me.FlatColorPalette1.White = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Notification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 300)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Notification"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notification"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FlatGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents FlatColorPalette1 As FlatColorPalette
    Friend WithEvents FlatGroupBox As FlatGroupBox
    Friend WithEvents LabelText As Label
    Friend WithEvents ButtonOk As FlatButton
End Class
