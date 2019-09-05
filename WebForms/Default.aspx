<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="WebForms._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvPersonas" runat="server" AutoGenerateColumns="false" ShowFooter="true" DataKeyNames="PersonaId" 
                OnRowCommand="gvPersonas_RowCommand" OnRowCancelingEdit="gvPersonas_RowCancelingEdit" OnRowDeleting="gvPersonas_RowDeleting" 
                OnRowEditing="gvPersonas_RowEditing" OnRowUpdating="gvPersonas_RowUpdating"
                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" EnableModelValidation="True">
                <%-- Propiedades del tema --%>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />

                <Columns>
                    <%-- Nombre Completo --%>
                    <asp:TemplateField HeaderText="Nombre Completo">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("NombreCompleto") %>' runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtNombreCompleto" Text='<%# Eval("NombreCompleto") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtNombreCompletoFooter" runat="server" />
                            <asp:RequiredFieldValidator ID="vgNombreCompleto" runat="server" ControlToValidate="txtNombreCompletoFooter" Text="!!"  ValidationGroup="vg"  />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <%-- Fecha De Nacimiento --%>
                    <asp:TemplateField HeaderText="Fecha de Nacimiento">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("FechaDeNacimiento", "{0:d}") %>' runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtFechaDeNacimiento" Text='<%# Eval("FechaDeNacimiento", "{0:d}") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtFechaDeNacimientoFooter" runat="server" />
                            <asp:RequiredFieldValidator ID="vgFechaDeNacimiento" runat="server" ControlToValidate="txtFechaDeNacimientoFooter" Text="!!"  ValidationGroup="vg"  />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <%-- Edad --%>
                    <asp:TemplateField HeaderText="Edad">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Edad") %>' runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtEdad" Text='<%# Eval("Edad") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtEdadFooter" runat="server" />
                            <asp:RequiredFieldValidator ID="vgEdad" runat="server" ControlToValidate="txtEdadFooter" Text="!!"  ValidationGroup="vg"  />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <%-- Sexo --%>
                    <asp:TemplateField HeaderText="Sexo">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Sexo") %>' runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtSexo" Text='<%# Eval("Sexo") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtSexoFooter" runat="server" />
                            <asp:RequiredFieldValidator ID="vgSexo" runat="server" ControlToValidate="txtSexoFooter" Text="!!"  ValidationGroup="vg"  />
                        </FooterTemplate>
                    </asp:TemplateField>


                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton runat="server" Text="Editar" ID="editButton" Font-Size="14px" CommandName="Edit" ToolTip="Edit" />
                            <asp:LinkButton runat="server" Text="Eliminar" ID="deleteButton" Font-Size="14px" CommandName="Delete" ToolTip="Delete" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:LinkButton runat="server" Text="Actualizar" ID="updateButton" Font-Size="14px" CommandName="Update" ToolTip="Update" />
                            <asp:LinkButton runat="server" Text="Cancelar" ID="cancelButton" Font-Size="14px" CommandName="Cancel" ToolTip="Cancel" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:LinkButton runat="server" Text="Agregar" ID="addNewButton" Font-Size="14px" CommandName="AddNew" ToolTip="Add" ValidationGroup="vg" />
                        </FooterTemplate>
                    </asp:TemplateField>
                </Columns>
                <EmptyDataTemplate>
                    No hay personas para mostrar.
                </EmptyDataTemplate>
            </asp:GridView>
            <br />
            <asp:Label runat="server" ID="labelSuccessMessage" Text="" ForeColor="Green" />
            <br />
            <asp:Label runat="server" Id="labelErrorMessage" Text="" ForeColor="Red" />

        </div>
    </form>
</body>
</html>
