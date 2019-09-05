<Serializable>
Public Class Persona
    Private _PersonaId As Integer?
    Private _NombreCompleto As String
    Private _FechaDeNacimiento As Date
    Private _Edad As Byte
    Private _Sexo As String

    Public Property PersonaId As Integer?
        Get
            Return _PersonaId
        End Get
        Set(value As Integer?)
            _PersonaId = value
        End Set
    End Property
    Public Property NombreCompleto As String
        Get
            Return _NombreCompleto
        End Get
        Set(value As String)
            _NombreCompleto = value
        End Set
    End Property
    Public Property FechaDeNacimiento As Date
        Get
            Return _FechaDeNacimiento
        End Get
        Set(value As Date)
            _FechaDeNacimiento = value
        End Set
    End Property
    Public Property Edad As Byte
        Get
            Return _Edad
        End Get
        Set(value As Byte)
            _Edad = value
        End Set
    End Property
    Public Property Sexo As String
        Get
            Return _Sexo
        End Get
        Set(value As String)
            _Sexo = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal PersonaId As Integer?, ByVal NombreCompleto As String, ByVal FechaDeNacimiento As Date, ByVal Edad As Byte, ByVal Sexo As String)
        _PersonaId = PersonaId
        _NombreCompleto = NombreCompleto
        _FechaDeNacimiento = FechaDeNacimiento
        _Edad = Edad
        _Sexo = Sexo
    End Sub
End Class
