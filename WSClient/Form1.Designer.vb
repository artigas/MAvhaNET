<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRUD
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gvPersonas = New System.Windows.Forms.DataGridView()
        Me.labelPersonaId = New System.Windows.Forms.Label()
        Me.txtPersonaId = New System.Windows.Forms.TextBox()
        Me.txtNombreCompleto = New System.Windows.Forms.TextBox()
        Me.labelNombreCompleto = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtFechaDeNacimiento = New System.Windows.Forms.TextBox()
        Me.labelFechaDeNacimiento = New System.Windows.Forms.Label()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.labelEdad = New System.Windows.Forms.Label()
        Me.txtSexo = New System.Windows.Forms.TextBox()
        Me.labelSexo = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtNotificacion = New System.Windows.Forms.RichTextBox()
        CType(Me.gvPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvPersonas
        '
        Me.gvPersonas.AllowUserToAddRows = False
        Me.gvPersonas.AllowUserToDeleteRows = False
        Me.gvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvPersonas.Location = New System.Drawing.Point(301, 12)
        Me.gvPersonas.Name = "gvPersonas"
        Me.gvPersonas.Size = New System.Drawing.Size(487, 410)
        Me.gvPersonas.TabIndex = 9
        '
        'labelPersonaId
        '
        Me.labelPersonaId.AutoSize = True
        Me.labelPersonaId.Location = New System.Drawing.Point(25, 17)
        Me.labelPersonaId.Name = "labelPersonaId"
        Me.labelPersonaId.Size = New System.Drawing.Size(61, 13)
        Me.labelPersonaId.TabIndex = 1
        Me.labelPersonaId.Text = "Persona Id:"
        '
        'txtPersonaId
        '
        Me.txtPersonaId.Location = New System.Drawing.Point(139, 14)
        Me.txtPersonaId.Name = "txtPersonaId"
        Me.txtPersonaId.ReadOnly = True
        Me.txtPersonaId.Size = New System.Drawing.Size(156, 20)
        Me.txtPersonaId.TabIndex = 0
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.Location = New System.Drawing.Point(139, 53)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.Size = New System.Drawing.Size(156, 20)
        Me.txtNombreCompleto.TabIndex = 1
        '
        'labelNombreCompleto
        '
        Me.labelNombreCompleto.AutoSize = True
        Me.labelNombreCompleto.Location = New System.Drawing.Point(25, 56)
        Me.labelNombreCompleto.Name = "labelNombreCompleto"
        Me.labelNombreCompleto.Size = New System.Drawing.Size(94, 13)
        Me.labelNombreCompleto.TabIndex = 3
        Me.labelNombreCompleto.Text = "Nombre Completo:"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Blue
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(28, 214)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(108, 29)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtFechaDeNacimiento
        '
        Me.txtFechaDeNacimiento.Location = New System.Drawing.Point(139, 91)
        Me.txtFechaDeNacimiento.Name = "txtFechaDeNacimiento"
        Me.txtFechaDeNacimiento.Size = New System.Drawing.Size(156, 20)
        Me.txtFechaDeNacimiento.TabIndex = 2
        '
        'labelFechaDeNacimiento
        '
        Me.labelFechaDeNacimiento.AutoSize = True
        Me.labelFechaDeNacimiento.Location = New System.Drawing.Point(25, 94)
        Me.labelFechaDeNacimiento.Name = "labelFechaDeNacimiento"
        Me.labelFechaDeNacimiento.Size = New System.Drawing.Size(111, 13)
        Me.labelFechaDeNacimiento.TabIndex = 6
        Me.labelFechaDeNacimiento.Text = "Fecha de Nacimiento:"
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(139, 129)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(156, 20)
        Me.txtEdad.TabIndex = 3
        '
        'labelEdad
        '
        Me.labelEdad.AutoSize = True
        Me.labelEdad.Location = New System.Drawing.Point(25, 132)
        Me.labelEdad.Name = "labelEdad"
        Me.labelEdad.Size = New System.Drawing.Size(35, 13)
        Me.labelEdad.TabIndex = 8
        Me.labelEdad.Text = "Edad:"
        '
        'txtSexo
        '
        Me.txtSexo.Location = New System.Drawing.Point(139, 168)
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New System.Drawing.Size(156, 20)
        Me.txtSexo.TabIndex = 4
        '
        'labelSexo
        '
        Me.labelSexo.AutoSize = True
        Me.labelSexo.Location = New System.Drawing.Point(25, 171)
        Me.labelSexo.Name = "labelSexo"
        Me.labelSexo.Size = New System.Drawing.Size(34, 13)
        Me.labelSexo.TabIndex = 10
        Me.labelSexo.Text = "Sexo:"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(175, 214)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(108, 29)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Eliminar"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Green
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(28, 260)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(108, 29)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Actualizar"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Location = New System.Drawing.Point(175, 260)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(108, 29)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Limpiar"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtNotificacion
        '
        Me.txtNotificacion.Location = New System.Drawing.Point(28, 324)
        Me.txtNotificacion.Name = "txtNotificacion"
        Me.txtNotificacion.ReadOnly = True
        Me.txtNotificacion.Size = New System.Drawing.Size(255, 50)
        Me.txtNotificacion.TabIndex = 11
        Me.txtNotificacion.Text = ""
        '
        'CRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtNotificacion)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtSexo)
        Me.Controls.Add(Me.labelSexo)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.labelEdad)
        Me.Controls.Add(Me.txtFechaDeNacimiento)
        Me.Controls.Add(Me.labelFechaDeNacimiento)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtNombreCompleto)
        Me.Controls.Add(Me.labelNombreCompleto)
        Me.Controls.Add(Me.txtPersonaId)
        Me.Controls.Add(Me.labelPersonaId)
        Me.Controls.Add(Me.gvPersonas)
        Me.Name = "CRUD"
        Me.Text = "CRUD con Web Service SOAP"
        CType(Me.gvPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gvPersonas As DataGridView
    Friend WithEvents labelPersonaId As Label
    Friend WithEvents txtPersonaId As TextBox
    Friend WithEvents txtNombreCompleto As TextBox
    Friend WithEvents labelNombreCompleto As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtFechaDeNacimiento As TextBox
    Friend WithEvents labelFechaDeNacimiento As Label
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents labelEdad As Label
    Friend WithEvents txtSexo As TextBox
    Friend WithEvents labelSexo As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtNotificacion As RichTextBox
End Class
