<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEmpleado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LNombreApellido = New System.Windows.Forms.Label()
        Me.LDocumento = New System.Windows.Forms.Label()
        Me.LFechaNacimiento = New System.Windows.Forms.Label()
        Me.LDireccion = New System.Windows.Forms.Label()
        Me.PBFoto = New System.Windows.Forms.PictureBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LNombreApellido
        '
        Me.LNombreApellido.AutoSize = True
        Me.LNombreApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombreApellido.ForeColor = System.Drawing.SystemColors.Control
        Me.LNombreApellido.Location = New System.Drawing.Point(466, 66)
        Me.LNombreApellido.Name = "LNombreApellido"
        Me.LNombreApellido.Size = New System.Drawing.Size(147, 18)
        Me.LNombreApellido.TabIndex = 0
        Me.LNombreApellido.Text = "Nombre + Apellido"
        '
        'LDocumento
        '
        Me.LDocumento.AutoSize = True
        Me.LDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDocumento.ForeColor = System.Drawing.SystemColors.Control
        Me.LDocumento.Location = New System.Drawing.Point(466, 105)
        Me.LDocumento.Name = "LDocumento"
        Me.LDocumento.Size = New System.Drawing.Size(86, 18)
        Me.LDocumento.TabIndex = 2
        Me.LDocumento.Text = "Documento"
        '
        'LFechaNacimiento
        '
        Me.LFechaNacimiento.AutoSize = True
        Me.LFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFechaNacimiento.ForeColor = System.Drawing.SystemColors.Control
        Me.LFechaNacimiento.Location = New System.Drawing.Point(466, 145)
        Me.LFechaNacimiento.Name = "LFechaNacimiento"
        Me.LFechaNacimiento.Size = New System.Drawing.Size(128, 18)
        Me.LFechaNacimiento.TabIndex = 3
        Me.LFechaNacimiento.Text = "Fecha Nacimiento"
        '
        'LDireccion
        '
        Me.LDireccion.AutoSize = True
        Me.LDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDireccion.ForeColor = System.Drawing.SystemColors.Control
        Me.LDireccion.Location = New System.Drawing.Point(466, 183)
        Me.LDireccion.Name = "LDireccion"
        Me.LDireccion.Size = New System.Drawing.Size(71, 18)
        Me.LDireccion.TabIndex = 4
        Me.LDireccion.Text = "Direccion"
        '
        'PBFoto
        '
        Me.PBFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBFoto.Location = New System.Drawing.Point(260, 50)
        Me.PBFoto.Name = "PBFoto"
        Me.PBFoto.Size = New System.Drawing.Size(174, 171)
        Me.PBFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBFoto.TabIndex = 5
        Me.PBFoto.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.AutoScroll = True
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 600)
        Me.PanelMenu.TabIndex = 6
        '
        'FormEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 559)
        Me.Controls.Add(Me.PBFoto)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.LDireccion)
        Me.Controls.Add(Me.LFechaNacimiento)
        Me.Controls.Add(Me.LDocumento)
        Me.Controls.Add(Me.LNombreApellido)
        Me.Name = "FormEmpleado"
        Me.Text = "FormEmpleado"
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LNombreApellido As Label
    Friend WithEvents LFechaNacimiento As Label
    Friend WithEvents LDireccion As Label
    Friend WithEvents PBFoto As PictureBox
    Friend WithEvents PanelMenu As Panel
    Public WithEvents LDocumento As Label
End Class
