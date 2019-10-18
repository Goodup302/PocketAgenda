Imports System.Xml.Serialization
Imports System.IO

<Serializable()>
Public Class Config
    Public TimerNotification As Integer
    Public EnableNotification As Boolean
    Public Version As String
End Class

Module Program
    Public DataDirectory As String
    Public Config As New Config

    Public Sub IsStarted(ByVal name As String)
        Dim var As Integer = 0
        For Each p As Process In Process.GetProcesses
            If p.ProcessName = name Then
                var += 1
                If var = 2 Then
                    PocketAgenda.NotifyIcon.ShowBalloonTip(2000)
                    PocketAgenda.NotifyIcon.Visible = False
                    PocketAgenda.Close()
                    End
                End If
            End If
        Next
    End Sub

    Sub SetDirectory(ByVal dir As String)
        DataDirectory = dir
    End Sub

    Public Sub CreateDirectory()
        If Not Directory.Exists(DataDirectory) And Not IsNothing(DataDirectory) Then
            Directory.CreateDirectory(DataDirectory)
        End If
    End Sub

    Public Sub InitializeConfig()
        Config.TimerNotification = 30
        Config.EnableNotification = True
        Config.Version = PocketAgenda.Version
        SaveConfig()
    End Sub

    Public Sub LoadConfig()
        If File.Exists(DataDirectory & "config.xml") Then
            Dim FluxDeFichier As Stream = File.OpenRead(DataDirectory & "config.xml")
            Dim Deserialiseur As New XmlSerializer(GetType(Config))
            Config = CType(Deserialiseur.Deserialize(FluxDeFichier), Config)
            FluxDeFichier.Close()
            If Not Config.Version = PocketAgenda.Version Then
                MsgBox("Bienvenue sur la version " & PocketAgenda.Version & " de " & My.Forms.PocketAgenda.Name, 0, My.Forms.PocketAgenda.Name)
                Config.Version = PocketAgenda.Version
                SaveConfig()
            End If
        Else
            InitializeConfig()
        End If
    End Sub

    Public Sub SaveConfig()
        If Directory.Exists(DataDirectory) Then
            Dim FluxDeFichier As FileStream = File.Create(DataDirectory & "config.xml")
            Dim Serialiseur As New XmlSerializer(GetType(Config))
            Serialiseur.Serialize(FluxDeFichier, Config)
            FluxDeFichier.Close()
        End If
    End Sub

    Public Sub LanchToWindowsStart(ByVal var As Boolean)
        Try
            If var Then
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Run").SetValue("PocketAgenda", Application.ExecutablePath)
            Else
                My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue("PocketAgenda")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function Network() As Boolean
        If My.Computer.Network.IsAvailable Then
            Return True
        Else
            Return False
        End If
    End Function

End Module
