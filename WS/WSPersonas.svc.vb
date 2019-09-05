' NOTE: You can use the "Rename" command on the context menu to change the class name "Service1" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select WSPersonas.svc or WSPersonas.svc.vb at the Solution Explorer and start debugging.
Imports BLL
Imports WS

Public Class WSPersonas
    Implements IWSPersonas

    Public Function GetDataSet() As DataSet Implements IWSPersonas.GetDataSet
        Return DbContext.GetDataSet()
    End Function

    Public Function Add(nombreCompleto As String, fechaDeNacimiento As Date, edad As Byte, sexo As String) As String Implements IWSPersonas.Add
        Try
            DbContext.Save(New Persona(Nothing, nombreCompleto, fechaDeNacimiento, edad, sexo))
            Return "Persona creada exitosamente!"
        Catch ex As Exception
            Return "Error en el proceso: " + ex.Message
        End Try
    End Function

    Public Function Update(personaId As Integer, nombreCompleto As String, fechaDeNacimiento As Date, edad As Byte, sexo As String) As String Implements IWSPersonas.Update
        Try
            DbContext.Update(New Persona(personaId, nombreCompleto, fechaDeNacimiento, edad, sexo))
            Return "Persona actualizada exitosamente!"
        Catch ex As Exception
            Return "Error en el proceso: " + ex.Message
        End Try
    End Function

    Public Function Delete(personaId As Integer) As String Implements IWSPersonas.Delete
        Try
            DbContext.Delete(personaId)
            Return "Persona eliminada exitosamente!"
        Catch ex As Exception
            Return "Error en el proceso: " + ex.Message
        End Try
    End Function
End Class
