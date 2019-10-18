Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Xml.Serialization
Imports System.IO

Public Class Gestion

    Private _theDate As Date
    Private leJour As Jour

    Public Property laDate() As Date
        Get
            Return _theDate
        End Get
        Set(ByVal value As Date)
            _theDate = value
        End Set
    End Property

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Inisialization de L'obect Principal
        Dim dir As String = Program.DataDirectory & _theDate.ToLongDateString & ".bin"
        leJour = Nothing
        leJour = Jour.Import(dir)


        'Inisialization des DateTimePicker 
        Me.DateTimePicker.Value = Me.laDate
        'Me.DateTimePicker.Value.Second
        Me.DateTimePicker.Format = DateTimePickerFormat.Custom
        Me.DateTimePicker.CustomFormat = "HH:mm"
        Me.DateTimePickerEdit.Format = DateTimePickerFormat.Custom
        Me.DateTimePickerEdit.CustomFormat = "HH:mm"

        'Inisialization Du Form
        Me.FormSkin1.Text = Me.laDate.ToLongDateString
        Me.FlatComboBox1.SelectedIndex = 0
        Me.FlatTextBox1.Text = ""
        RefrechComboBox()
        EditZone(False)
    End Sub

    Sub ClearVar()
        _theDate = Nothing
        leJour = Nothing
    End Sub

    Sub EditZone(ByVal arg As Boolean)
        If arg Then
            Me.RichTextBox1.Enabled = True
            Me.TextBox1.Enabled = True
            Me.DateTimePickerEdit.Enabled = True
        Else
            Me.RichTextBox1.Text = "" : Me.RichTextBox1.Enabled = False
            Me.TextBox1.Text = "" : Me.TextBox1.Enabled = False
            Me.DateTimePickerEdit.Enabled = False
            Me.FlatLabel4.Text = "Pour ..."
        End If
    End Sub

    Private Sub DateTimePicker_MouseDoubleClick(sender As Object, e As EventArgs) Handles DateTimePicker.MouseDoubleClick
        If Me.DateTimePicker.Enabled = True Then
            Me.DateTimePicker.Enabled = False
        Else
            Me.DateTimePicker.Enabled = True
        End If
    End Sub

    Sub RefrechComboBox()
        Me.ListBox1.Items.Clear()
        'For Each Elements In leJour.Elements
        'If Elements.type = 0 Then
        'Me.ListBox1.Items.Add(Elements.name)
        'ElseIf Elements.type = 1 Then
        'Me.ListBox1.Items.Add(Elements.name & " - " & Elements.time.ToShortTimeString)
        'End If
        'Next

        Dim x As Integer = 0
        For Each Elements In leJour.Elements
            If Elements.type = 0 Then
                ListBox1.Items.Insert(x, Elements.name)
            ElseIf Elements.type = 1 Then
                ListBox1.Items.Insert(x, Elements.time.ToShortTimeString & " - " & Elements.name)
            End If
            x += 1
        Next
    End Sub

    Private Sub FlatStickyButton2_Click(sender As Object, e As EventArgs) Handles FlatStickyButton2.Click
        If Not Me.FlatTextBox1.Text = "" And Not ListBox1.Items.Contains(Me.FlatTextBox1.Text) Then
            leJour.Elements.Add(New Element(FlatTextBox1.Text, Me.FlatComboBox1.SelectedIndex, Me.DateTimePicker.Value))
            RefrechComboBox()
            Me.FlatTextBox1.Text = ""
            EditZone(False)
        End If
    End Sub

    Private Sub FlatStickyButton3_Click(sender As Object, e As EventArgs) Handles FlatStickyButton3.Click
        If leJour.Elements.Count > 0 Then
            leJour.Save(Program.DataDirectory)
        End If
        ClearVar()
        Me.Close()
        PocketAgenda.RefrechNotification()
        PocketAgenda.RefrechTextbox()
    End Sub

    Private Sub FlatStickyButton6_Click(sender As Object, e As EventArgs) Handles FlatStickyButton6.Click
        ClearVar()
        Me.Close()
    End Sub

    Private Sub FlatStickyButton1_Click_1(sender As Object, e As EventArgs) Handles FlatStickyButton1.Click
        leJour.Delete(Program.DataDirectory)
        ClearVar()
        Me.Close()
        PocketAgenda.RefrechNotification()
        PocketAgenda.RefrechTextbox()
    End Sub

    Private Sub FlatStickyButton7_Click(sender As Object, e As EventArgs) Handles FlatStickyButton7.Click
        If ListBox1.SelectedIndex < leJour.Elements.Count And ListBox1.SelectedIndex >= 0 Then
            leJour.Elements.RemoveAt(ListBox1.SelectedIndex)
            Me.ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            Me.ListBox1.SelectedIndex = -1
            EditZone(False)
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedValueChanged
        If ListBox1.SelectedIndex < leJour.Elements.Count And ListBox1.SelectedIndex >= 0 Then

            Dim nbr As Integer = ListBox1.SelectedIndex

            EditZone(True)
            Me.RichTextBox1.Text = leJour.Elements(ListBox1.SelectedIndex).text
            Me.TextBox1.Text = leJour.Elements(ListBox1.SelectedIndex).name
            If leJour.Elements(ListBox1.SelectedIndex).type = 1 Then
                Me.DateTimePickerEdit.Value = leJour.Elements(ListBox1.SelectedIndex).time
            Else
                Me.DateTimePickerEdit.Enabled = False
            End If

            Me.FlatLabel4.Text = "Pour le " & leJour.laDate.ToLongDateString
            If leJour.Elements(nbr).type = 1 Then
                Me.FlatLabel4.Text += " à " & leJour.Elements(ListBox1.SelectedIndex).time.ToShortTimeString
            End If
        Else
                Me.FlatLabel4.Text = "Pour ..."
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If ListBox1.SelectedIndex < leJour.Elements.Count And ListBox1.SelectedIndex >= 0 Then
            If Not Me.TextBox1.Text = "" Then
                leJour.Elements(ListBox1.SelectedIndex).name = Me.TextBox1.Text
            End If
        Else
            EditZone(False)
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        If ListBox1.SelectedIndex < leJour.Elements.Count And ListBox1.SelectedIndex >= 0 Then
            leJour.Elements(ListBox1.SelectedIndex).text = Me.RichTextBox1.Text
        Else
            EditZone(False)
        End If
    End Sub

    Private Sub FlatComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FlatComboBox1.SelectedIndexChanged
        If FlatComboBox1.SelectedIndex = 0 Then
            Me.DateTimePicker.Enabled = False
        Else
            Me.DateTimePicker.Enabled = True
            Me.DateTimePicker.Value = Now
        End If
    End Sub

    Private Sub DateTimePickerEdit_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerEdit.ValueChanged
        If ListBox1.SelectedIndex < leJour.Elements.Count And ListBox1.SelectedIndex >= 0 Then
            leJour.Elements(ListBox1.SelectedIndex).time = Me.DateTimePickerEdit.Value
        Else
            EditZone(False)
        End If
    End Sub
End Class