Imports System.Data.SqlClient

Public Class DbContext
    Public Shared Function GetConnectionString() As String
        Return "Data Source=.\SQLEXPRESS;Integrated Security=true;Initial Catalog=MAvhaNET;"
    End Function

    Public Shared Function GetDataTable() As DataTable
        Dim dataTable As DataTable = New DataTable()
        Using sqlConnection As New SqlConnection(GetConnectionString())
            sqlConnection.Open()
            Dim sda As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM Personas", sqlConnection)
            sda.Fill(dataTable)
        End Using
        Return dataTable
    End Function

    Public Shared Function GetDataSet() As DataSet
        Dim dataSet As DataSet = New DataSet()
        Using sqlConnection As New SqlConnection(GetConnectionString())
            sqlConnection.Open()
            Dim sda As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM Personas", sqlConnection)
            sda.Fill(dataSet)
            sqlConnection.Close()
        End Using
        Return dataSet
    End Function

    Public Shared Sub Save(ByVal persona As Persona)
        Dim query As String = "INSERT INTO Personas (NombreCompleto, FechaDeNacimiento, Edad, Sexo) VALUES (@NombreCompleto, @FechaDeNacimiento, @Edad, @Sexo)"
        Using sqlConnection As New SqlConnection(GetConnectionString())
            sqlConnection.Open()
            Dim sqlCommand As SqlCommand = New SqlCommand(query, sqlConnection)
            sqlCommand.Parameters.AddWithValue("@NombreCompleto", persona.NombreCompleto)
            sqlCommand.Parameters.AddWithValue("@FechaDeNacimiento", persona.FechaDeNacimiento)
            sqlCommand.Parameters.AddWithValue("@Edad", persona.Edad)
            sqlCommand.Parameters.AddWithValue("@Sexo", persona.Sexo)
            sqlCommand.ExecuteNonQuery()
        End Using
    End Sub

    Public Shared Sub Update(ByVal persona As Persona)
        Dim query As String = "UPDATE Personas SET NombreCompleto=@NombreCompleto,FechaDeNacimiento=@FechaDeNacimiento,Edad=@Edad,Sexo=@Sexo WHERE PersonaId=@PersonaId"
        Using sqlConnection As New SqlConnection(GetConnectionString())
            sqlConnection.Open()
            Dim sqlCommand As SqlCommand = New SqlCommand(query, sqlConnection)
            sqlCommand.Parameters.AddWithValue("@NombreCompleto", persona.NombreCompleto)
            sqlCommand.Parameters.AddWithValue("@FechaDeNacimiento", persona.FechaDeNacimiento)
            sqlCommand.Parameters.AddWithValue("@Edad", persona.Edad)
            sqlCommand.Parameters.AddWithValue("@Sexo", persona.Sexo)
            sqlCommand.Parameters.AddWithValue("@PersonaId", persona.PersonaId)
            sqlCommand.ExecuteNonQuery()
        End Using
    End Sub

    Public Shared Sub Delete(ByVal personaId As Integer)
        Dim query As String = "DELETE FROM Personas WHERE PersonaId=@PersonaId"
        Using sqlConnection As New SqlConnection(GetConnectionString())
            sqlConnection.Open()
            Dim sqlCommand As SqlCommand = New SqlCommand(query, sqlConnection)
            sqlCommand.Parameters.AddWithValue("@PersonaId", personaId)
            sqlCommand.ExecuteNonQuery()
        End Using
    End Sub
End Class
