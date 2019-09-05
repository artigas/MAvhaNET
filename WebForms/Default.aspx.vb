Imports System.Data.SqlClient
Imports BLL

Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            PopulateGridView()
        End If
    End Sub

    Sub PopulateGridView()
        Dim dataTable As DataTable = DbContext.GetDataTable()
        If dataTable.Rows.Count > 0 Then
            gvPersonas.DataSource = dataTable
            gvPersonas.DataBind()
        Else
            dataTable.Rows.Add(dataTable.NewRow())
            gvPersonas.DataSource = dataTable
            gvPersonas.DataBind()
            gvPersonas.Rows().Item(0).Cells.Clear()
            gvPersonas.Rows().Item(0).Cells.Add(New TableCell())
            gvPersonas.Rows().Item(0).Cells(0).ColumnSpan = dataTable.Columns.Count
            gvPersonas.Rows().Item(0).Cells(0).Text = "No hay personas para mostrar."
            gvPersonas.Rows().Item(0).Cells(0).HorizontalAlign = HorizontalAlign.Center
        End If
    End Sub

    Protected Sub gvPersonas_RowCommand(sender As Object, e As GridViewCommandEventArgs)
        If e.CommandName.Equals("AddNew") Then
            Try
                Dim persona As Persona = New Persona(
                                Nothing, 'PersonaId
                                TryCast(gvPersonas.FooterRow.FindControl("txtNombreCompletoFooter"), TextBox).Text.Trim(), 'NombreCompleto
                                TryCast(gvPersonas.FooterRow.FindControl("txtFechaDeNacimientoFooter"), TextBox).Text.Trim(), 'FechaDeNacimiento
                                TryCast(gvPersonas.FooterRow.FindControl("txtEdadFooter"), TextBox).Text.Trim(), 'Edad
                                TryCast(gvPersonas.FooterRow.FindControl("txtSexoFooter"), TextBox).Text.Trim()) 'Sexo

                DbContext.Save(persona)
                PopulateGridView()

                labelSuccessMessage.Text = "Persona creada exitosamente"
                labelErrorMessage.Text = ""
            Catch ex As Exception
                labelSuccessMessage.Text = ""
                labelErrorMessage.Text = "Error en el proceso: " + ex.Message
            End Try
        End If
    End Sub

    Protected Sub gvPersonas_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs)
        gvPersonas.EditIndex = -1
        PopulateGridView()
    End Sub

    Protected Sub gvPersonas_RowDeleting(sender As Object, e As GridViewDeleteEventArgs)
        Try
            Dim personaId As Integer = gvPersonas.DataKeys(e.RowIndex).Value 'PersonaId
            DbContext.Delete(personaId)
            PopulateGridView()

            labelSuccessMessage.Text = "Persona eliminada exitosamente"
            labelErrorMessage.Text = ""
        Catch ex As Exception
            labelSuccessMessage.Text = ""
            labelErrorMessage.Text = "Error en el proceso: " + ex.Message
        End Try

    End Sub

    Protected Sub gvPersonas_RowEditing(sender As Object, e As GridViewEditEventArgs)
        gvPersonas.EditIndex = e.NewEditIndex
        PopulateGridView()
    End Sub

    Protected Sub gvPersonas_RowUpdating(sender As Object, e As GridViewUpdateEventArgs)
        Try
            Dim personaId As Integer = gvPersonas.DataKeys(e.RowIndex).Value

            Dim persona As Persona = New Persona(
                gvPersonas.DataKeys(e.RowIndex).Value, 'PersonaId
                TryCast(gvPersonas.Rows(e.RowIndex).FindControl("txtNombreCompleto"), TextBox).Text.Trim(), 'NombreCompleto
                TryCast(gvPersonas.Rows(e.RowIndex).FindControl("txtFechaDeNacimiento"), TextBox).Text.Trim(), 'FechaDeNacimiento
                TryCast(gvPersonas.Rows(e.RowIndex).FindControl("txtEdad"), TextBox).Text.Trim(), 'Edad
                TryCast(gvPersonas.Rows(e.RowIndex).FindControl("txtSexo"), TextBox).Text.Trim()) 'Sexo

            DbContext.Update(persona)

            gvPersonas.EditIndex = -1
            PopulateGridView()

            labelSuccessMessage.Text = "Persona actualizada exitosamente"
            labelErrorMessage.Text = ""
        Catch ex As Exception
            labelSuccessMessage.Text = ""
            labelErrorMessage.Text = "Error en el proceso: " + ex.Message
        End Try

    End Sub
End Class