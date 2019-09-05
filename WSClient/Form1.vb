Public Class CRUD
    'Private Sub gvPersonas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvPersonas.CellContentClick, gvPersonas.CellClick

    'End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateGridView()
    End Sub

    Private Sub PopulateGridView()
        Using client As New WSPersonasServiceReference.WSPersonasClient()
            Dim dataSet As DataSet = client.GetDataSet()
            If dataSet.Tables.Count > 0 Then
                gvPersonas.DataSource = dataSet.Tables(0)
            End If
        End Using
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Using client As New WSPersonasServiceReference.WSPersonasClient()
            Dim message As String = client.Add(txtNombreCompleto.Text, txtFechaDeNacimiento.Text, txtEdad.Text, txtSexo.Text)
            PopulateGridView()
            CleanTextBoxes()
        End Using
    End Sub

    Private Sub gvPersonas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvPersonas.CellClick
        If e.RowIndex >= 0 Then
            If Not gvPersonas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Nothing Then
                gvPersonas.CurrentRow.Selected = True
                txtPersonaId.Text = gvPersonas.Rows(e.RowIndex).Cells("PersonaId").FormattedValue.ToString()
                txtNombreCompleto.Text = gvPersonas.Rows(e.RowIndex).Cells("NombreCompleto").FormattedValue.ToString()
                txtFechaDeNacimiento.Text = gvPersonas.Rows(e.RowIndex).Cells("FechaDeNacimiento").FormattedValue.ToString()
                txtEdad.Text = gvPersonas.Rows(e.RowIndex).Cells("Edad").FormattedValue.ToString()
                txtSexo.Text = gvPersonas.Rows(e.RowIndex).Cells("Sexo").FormattedValue.ToString()
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Using client As New WSPersonasServiceReference.WSPersonasClient()
            If Not String.IsNullOrEmpty(txtPersonaId.Text) Then
                Dim message As String = client.Update(txtPersonaId.Text, txtNombreCompleto.Text, txtFechaDeNacimiento.Text, txtEdad.Text, txtSexo.Text)
                PopulateGridView()
            Else
                txtNotificacion.Text = "Esta persona no existe. Si quieres crearla, hacé click en Agregar"
            End If
        End Using
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Using client As New WSPersonasServiceReference.WSPersonasClient()
            If Not String.IsNullOrEmpty(txtPersonaId.Text) Then
                Dim message As String = client.Delete(txtPersonaId.Text)
                PopulateGridView()
                CleanTextBoxes()
            Else
                txtNotificacion.Text = "No has seleccionado ninguna persona"
            End If
        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        CleanTextBoxes()
    End Sub

    Private Sub CleanTextBoxes()
        For Each txt In {txtPersonaId, txtNombreCompleto, txtFechaDeNacimiento, txtEdad, txtSexo}
            txt.Clear()
        Next
    End Sub
End Class
