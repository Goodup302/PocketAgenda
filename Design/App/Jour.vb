Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

<Serializable()>
Public Class Jour

    Public laDate As Date
    Public Elements As New List(Of Element)

    Public Sub New(ByVal arg As Date)
        Me.laDate = arg
    End Sub

    Public Sub Save(ByVal dir As String)
        Dim Directory As String = dir & laDate.ToLongDateString & ".bin"
        File.Delete(Directory)
        '
        Dim FluxDeFichier As FileStream = File.Create(Directory)
        Dim Serialiseur As New BinaryFormatter
        Serialiseur.Serialize(FluxDeFichier, Me)
        FluxDeFichier.Close()
    End Sub

    Public Shared Function Import(ByVal dir As String) As Jour
        Dim Var As Jour
        If File.Exists(dir) Then
            Dim FluxDeFichier As Stream = File.OpenRead(dir)
            Dim Deserialiseur As New BinaryFormatter()
            Var = CType(Deserialiseur.Deserialize(FluxDeFichier), Jour)
            FluxDeFichier.Close()
        Else
            Var = New Jour(Gestion.laDate)
        End If
        Return Var
    End Function

    Public Sub Delete(ByVal dir As String)
        Dim Directory As String = dir & laDate.ToLongDateString & ".bin"
        File.Delete(Directory)
    End Sub

    Public Shared Function Text(ByVal dir As String, ByVal arg As Integer) As String
        Dim result As String = ""
        Dim var = New Jour(Now)

        If File.Exists(dir) Then
            Dim FluxDeFichier As Stream = File.OpenRead(dir)
            Dim Deserialiseur As New BinaryFormatter()
            var = CType(Deserialiseur.Deserialize(FluxDeFichier), Jour)
            FluxDeFichier.Close()
            If arg = 0 Then

                result += "Liste des Tache(s)" & Chr(13) & Chr(13)
                For Each Element In var.Elements
                    If Element.type = 0 Then
                        result += Element.name & " : " & Element.text & Chr(13)
                    End If
                Next

            ElseIf arg = 1 Then

                result += "Liste des Evénement(s)" & Chr(13) & Chr(13)
                For Each Element In var.Elements
                    If Element.type = 1 Then
                        result += Element.time.ToShortTimeString & " - " & Element.name & " : " & Element.text & Chr(13)
                    End If
                Next

            End If
        Else
            result = "Vide ..."
        End If

        Return result
    End Function

End Class
