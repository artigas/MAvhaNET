' NOTE: You can use the "Rename" command on the context menu to change the interface name "IService1" in both code and config file together.
<ServiceContract()>
Public Interface IWSPersonas

    <OperationContract()>
    Function Add(ByVal nombreCompleto As String, ByVal fechaDeNacimiento As Date, ByVal edad As Byte, ByVal sexo As String) As String

    <OperationContract()>
    Function Update(ByVal personaId As Integer, ByVal nombreCompleto As String, ByVal fechaDeNacimiento As Date, ByVal edad As Byte, ByVal sexo As String) As String

    <OperationContract()>
    Function Delete(ByVal personaId As Integer) As String

    <OperationContract()>
    Function GetDataSet() As DataSet

    '<OperationContract()>
    'Function GetData(ByVal value As Integer) As String

    '<OperationContract()>
    'Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType

    ' TODO: Add your service operations here

End Interface

' Use a data contract as illustrated in the sample below to add composite types to service operations.
<DataContract()>
Public Class PersonaType
    Inherits BaseResponse
    Private _PersonaId As Integer?
    Private _NombreCompleto As String
    Private _FechaDeNacimiento As Date
    Private _Edad As Byte
    Private _Sexo As String

    <DataMember()>
    Public Property PersonaId As Integer?
        Get
            Return _PersonaId
        End Get
        Set(value As Integer?)
            _PersonaId = value
        End Set
    End Property
    <DataMember()>
    Public Property NombreCompleto As String
        Get
            Return _NombreCompleto
        End Get
        Set(value As String)
            _NombreCompleto = value
        End Set
    End Property
    <DataMember()>
    Public Property FechaDeNacimiento As Date
        Get
            Return _FechaDeNacimiento
        End Get
        Set(value As Date)
            _FechaDeNacimiento = value
        End Set
    End Property
    <DataMember()>
    Public Property Edad As Byte
        Get
            Return _Edad
        End Get
        Set(value As Byte)
            _Edad = value
        End Set
    End Property
    <DataMember()>
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

<DataContract()>
Public Class BaseResponse
    Private _ResponseMessage As String
    Private _ErrorMessage As String

    <DataMember()>
    Public Property ResponseMessage() As String
        Get
            Return _ResponseMessage
        End Get
        Set(ByVal value As String)
            _ResponseMessage = value
        End Set
    End Property

    <DataMember()>
    Public Property ErrorMessage() As String
        Get
            Return _ErrorMessage
        End Get
        Set(ByVal value As String)
            _ErrorMessage = value
        End Set
    End Property
End Class

<DataContract()> _
Public Class CompositeType

    Private boolValueField As Boolean
    Private stringValueField As String

    <DataMember()> _
    Public Property BoolValue() As Boolean
        Get
            Return boolValueField
        End Get
        Set(ByVal value As Boolean)
            boolValueField = value
        End Set
    End Property

    <DataMember()> _
    Public Property StringValue() As String
        Get
            Return stringValueField
        End Get
        Set(ByVal value As String)
            stringValueField = value
        End Set
    End Property

End Class
