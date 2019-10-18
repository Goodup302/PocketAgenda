Public Class Settings

    Public TimerNotification As Integer
    Public EnableNotification As Boolean

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TrackBarNotification.Value = Program.Config.TimerNotification
        Me.ToggleNotification.Checked = Program.Config.EnableNotification
        Me.FlatLabel2.Text = "Vous serez prévenu de vos évènements " & Me.TimerNotification & " minute(s) avant."
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Program.LanchToWindowsStart(Me.ToggleNotification.Checked)
        Program.Config.TimerNotification = Me.TrackBarNotification.Value
        Program.Config.EnableNotification = Me.ToggleNotification.Checked
        Program.SaveConfig()
        Me.Close()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub FlatTrackBar1_Scroll(sender As Object) Handles TrackBarNotification.Scroll
        Me.TimerNotification = Me.TrackBarNotification.Value
        Me.FlatLabel2.Text = "Vous serez prévenu de vos évènements " & Me.TimerNotification & " minute(s) avant."
    End Sub
End Class