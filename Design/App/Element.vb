<Serializable()>
Public Class Element

    Protected _name As String
    Protected _leText As String
    Protected _laDate As DateTime
    Protected _type As Integer
    Protected _CreationDate As DateTime

    Sub New(ByVal nom As String, ByVal type As String, ByVal time As DateTime)
        _name = nom
        _type = type
        _laDate = time
        _CreationDate = Now
    End Sub

    Public Sub Modify(ByVal Element As Element, ByVal txt As String, ByVal time As DateTime)
        Me.text = txt
        Me.time = time
    End Sub

    Public Sub Delete(ByVal Element As Element)

    End Sub

#Region "Property"
    Public Property name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property
    Public Property text() As String
        Get
            Return _leText
        End Get
        Set(ByVal value As String)
            _leText = value
        End Set
    End Property
    Public Property time() As DateTime
        Get
            Return _laDate
        End Get
        Set(ByVal value As DateTime)
            _laDate = value
        End Set
    End Property
    Public Property type() As Integer
        Get
            Return _type
        End Get
        Set(ByVal value As Integer)
            _type = value
        End Set
    End Property
    Public Property CreationDate() As DateTime
        Get
            Return _CreationDate
        End Get
        Set(ByVal value As DateTime)
            _CreationDate = value
        End Set
    End Property
#End Region

End Class