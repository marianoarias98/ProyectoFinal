<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.LIdCliente = New System.Windows.Forms.Label()
        Me.BVerSolicitudes = New System.Windows.Forms.Button()
        Me.BVerCatalogo = New System.Windows.Forms.Button()
        Me.GBVerSolicitudes = New System.Windows.Forms.GroupBox()
        Me.LNumeroSolicitudes = New System.Windows.Forms.Label()
        Me.DGVVerSolicitudes = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelMenu.SuspendLayout()
        Me.GBVerSolicitudes.SuspendLayout()
        CType(Me.DGVVerSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.Label1)
        Me.PanelMenu.Controls.Add(Me.LIdCliente)
        Me.PanelMenu.Controls.Add(Me.BVerSolicitudes)
        Me.PanelMenu.Controls.Add(Me.BVerCatalogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(200, 559)
        Me.PanelMenu.TabIndex = 0
        '
        'LIdCliente
        '
        Me.LIdCliente.AutoSize = True
        Me.LIdCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LIdCliente.ForeColor = System.Drawing.SystemColors.Control
        Me.LIdCliente.Location = New System.Drawing.Point(158, 508)
        Me.LIdCliente.Name = "LIdCliente"
        Me.LIdCliente.Size = New System.Drawing.Size(22, 18)
        Me.LIdCliente.TabIndex = 4
        Me.LIdCliente.Text = "ID"
        '
        'BVerSolicitudes
        '
        Me.BVerSolicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVerSolicitudes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVerSolicitudes.ForeColor = System.Drawing.Color.Snow
        Me.BVerSolicitudes.Location = New System.Drawing.Point(24, 213)
        Me.BVerSolicitudes.Name = "BVerSolicitudes"
        Me.BVerSolicitudes.Size = New System.Drawing.Size(157, 35)
        Me.BVerSolicitudes.TabIndex = 3
        Me.BVerSolicitudes.Text = "Estado Solicitudes"
        Me.BVerSolicitudes.UseVisualStyleBackColor = True
        '
        'BVerCatalogo
        '
        Me.BVerCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVerCatalogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVerCatalogo.ForeColor = System.Drawing.Color.Snow
        Me.BVerCatalogo.Location = New System.Drawing.Point(24, 139)
        Me.BVerCatalogo.Name = "BVerCatalogo"
        Me.BVerCatalogo.Size = New System.Drawing.Size(157, 35)
        Me.BVerCatalogo.TabIndex = 2
        Me.BVerCatalogo.Text = "Ver Catologo"
        Me.BVerCatalogo.UseVisualStyleBackColor = True
        '
        'GBVerSolicitudes
        '
        Me.GBVerSolicitudes.Controls.Add(Me.LNumeroSolicitudes)
        Me.GBVerSolicitudes.Controls.Add(Me.DGVVerSolicitudes)
        Me.GBVerSolicitudes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBVerSolicitudes.ForeColor = System.Drawing.SystemColors.Control
        Me.GBVerSolicitudes.Location = New System.Drawing.Point(217, 12)
        Me.GBVerSolicitudes.Name = "GBVerSolicitudes"
        Me.GBVerSolicitudes.Size = New System.Drawing.Size(955, 535)
        Me.GBVerSolicitudes.TabIndex = 1
        Me.GBVerSolicitudes.TabStop = False
        Me.GBVerSolicitudes.Text = "Ver Solicitudes"
        '
        'LNumeroSolicitudes
        '
        Me.LNumeroSolicitudes.AutoSize = True
        Me.LNumeroSolicitudes.Location = New System.Drawing.Point(38, 52)
        Me.LNumeroSolicitudes.Name = "LNumeroSolicitudes"
        Me.LNumeroSolicitudes.Size = New System.Drawing.Size(166, 18)
        Me.LNumeroSolicitudes.TabIndex = 1
        Me.LNumeroSolicitudes.Text = "Cantidad de Solicitudes:"
        '
        'DGVVerSolicitudes
        '
        Me.DGVVerSolicitudes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.DGVVerSolicitudes.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVVerSolicitudes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVVerSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVerSolicitudes.EnableHeadersVisualStyles = False
        Me.DGVVerSolicitudes.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.DGVVerSolicitudes.Location = New System.Drawing.Point(41, 105)
        Me.DGVVerSolicitudes.Name = "DGVVerSolicitudes"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVVerSolicitudes.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVVerSolicitudes.RowHeadersWidth = 45
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control
        Me.DGVVerSolicitudes.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVVerSolicitudes.Size = New System.Drawing.Size(883, 150)
        Me.DGVVerSolicitudes.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(30, 508)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tu ID de cliente:"
        '
        'FormCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1184, 559)
        Me.Controls.Add(Me.GBVerSolicitudes)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "FormCliente"
        Me.Text = "FormCliente"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        Me.GBVerSolicitudes.ResumeLayout(False)
        Me.GBVerSolicitudes.PerformLayout()
        CType(Me.DGVVerSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents BVerCatalogo As Button
    Friend WithEvents BVerSolicitudes As Button
    Friend WithEvents GBVerSolicitudes As GroupBox
    Friend WithEvents LNumeroSolicitudes As Label
    Friend WithEvents DGVVerSolicitudes As DataGridView
    Friend WithEvents LIdCliente As Label
    Friend WithEvents Label1 As Label
End Class
