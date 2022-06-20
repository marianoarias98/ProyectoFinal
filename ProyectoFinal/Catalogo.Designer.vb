<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Catalogo
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
        Me.CBFiltroNarca = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVVehiculos = New System.Windows.Forms.DataGridView()
        Me.BTVerMas = New System.Windows.Forms.Button()
        Me.GBCatalogo = New System.Windows.Forms.GroupBox()
        Me.LStock = New System.Windows.Forms.Label()
        Me.LPeso = New System.Windows.Forms.Label()
        Me.LVelocidad = New System.Windows.Forms.Label()
        Me.LAsientos = New System.Windows.Forms.Label()
        Me.LPrecio = New System.Windows.Forms.Label()
        Me.LMotor = New System.Windows.Forms.Label()
        Me.LAño = New System.Windows.Forms.Label()
        Me.LMarcaModelo = New System.Windows.Forms.Label()
        Me.PbFotoVehiculo = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBPrecio = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBBusqueda = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BMasVendido = New System.Windows.Forms.Button()
        Me.BCerrarSesion = New System.Windows.Forms.Button()
        Me.BVerTodos = New System.Windows.Forms.Button()
        Me.GBVerTodos = New System.Windows.Forms.GroupBox()
        Me.GBMasVenidos = New System.Windows.Forms.GroupBox()
        Me.PBMasVendido4 = New System.Windows.Forms.PictureBox()
        Me.PBMasVendido3 = New System.Windows.Forms.PictureBox()
        Me.PBMasVendido2 = New System.Windows.Forms.PictureBox()
        Me.PBMasVendido1 = New System.Windows.Forms.PictureBox()
        Me.BSolicitarCompra = New System.Windows.Forms.Button()
        CType(Me.DGVVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBCatalogo.SuspendLayout()
        CType(Me.PbFotoVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GBVerTodos.SuspendLayout()
        Me.GBMasVenidos.SuspendLayout()
        CType(Me.PBMasVendido4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBMasVendido3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBMasVendido2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBMasVendido1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CBFiltroNarca
        '
        Me.CBFiltroNarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBFiltroNarca.FormattingEnabled = True
        Me.CBFiltroNarca.Items.AddRange(New Object() {"Chevrolet", "Citroen", "Fiat", "Ford", "Peugeot", "Renault", "Toyota", "Volkwagen"})
        Me.CBFiltroNarca.Location = New System.Drawing.Point(143, 19)
        Me.CBFiltroNarca.Name = "CBFiltroNarca"
        Me.CBFiltroNarca.Size = New System.Drawing.Size(152, 26)
        Me.CBFiltroNarca.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(20, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Filtrar por Marca"
        '
        'DGVVehiculos
        '
        Me.DGVVehiculos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.DGVVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVVehiculos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVVehiculos.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVVehiculos.EnableHeadersVisualStyles = False
        Me.DGVVehiculos.GridColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DGVVehiculos.Location = New System.Drawing.Point(23, 62)
        Me.DGVVehiculos.Name = "DGVVehiculos"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVVehiculos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVVehiculos.RowHeadersWidth = 45
        Me.DGVVehiculos.Size = New System.Drawing.Size(866, 150)
        Me.DGVVehiculos.TabIndex = 3
        '
        'BTVerMas
        '
        Me.BTVerMas.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BTVerMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTVerMas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTVerMas.ForeColor = System.Drawing.SystemColors.Control
        Me.BTVerMas.Location = New System.Drawing.Point(728, 230)
        Me.BTVerMas.Name = "BTVerMas"
        Me.BTVerMas.Size = New System.Drawing.Size(159, 33)
        Me.BTVerMas.TabIndex = 5
        Me.BTVerMas.Text = "Ver Mas"
        Me.BTVerMas.UseVisualStyleBackColor = False
        '
        'GBCatalogo
        '
        Me.GBCatalogo.Controls.Add(Me.LStock)
        Me.GBCatalogo.Controls.Add(Me.LPeso)
        Me.GBCatalogo.Controls.Add(Me.LVelocidad)
        Me.GBCatalogo.Controls.Add(Me.LAsientos)
        Me.GBCatalogo.Controls.Add(Me.LPrecio)
        Me.GBCatalogo.Controls.Add(Me.LMotor)
        Me.GBCatalogo.Controls.Add(Me.LAño)
        Me.GBCatalogo.Controls.Add(Me.LMarcaModelo)
        Me.GBCatalogo.Controls.Add(Me.PbFotoVehiculo)
        Me.GBCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GBCatalogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBCatalogo.ForeColor = System.Drawing.SystemColors.Control
        Me.GBCatalogo.Location = New System.Drawing.Point(21, 269)
        Me.GBCatalogo.Name = "GBCatalogo"
        Me.GBCatalogo.Size = New System.Drawing.Size(866, 234)
        Me.GBCatalogo.TabIndex = 6
        Me.GBCatalogo.TabStop = False
        Me.GBCatalogo.Text = "Catalogo"
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LStock.ForeColor = System.Drawing.SystemColors.Control
        Me.LStock.Location = New System.Drawing.Point(573, 176)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(55, 18)
        Me.LStock.TabIndex = 8
        Me.LStock.Text = "Stock?"
        '
        'LPeso
        '
        Me.LPeso.AutoSize = True
        Me.LPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPeso.ForeColor = System.Drawing.SystemColors.Control
        Me.LPeso.Location = New System.Drawing.Point(573, 128)
        Me.LPeso.Name = "LPeso"
        Me.LPeso.Size = New System.Drawing.Size(43, 18)
        Me.LPeso.TabIndex = 7
        Me.LPeso.Text = "Peso"
        '
        'LVelocidad
        '
        Me.LVelocidad.AutoSize = True
        Me.LVelocidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVelocidad.ForeColor = System.Drawing.SystemColors.Control
        Me.LVelocidad.Location = New System.Drawing.Point(573, 81)
        Me.LVelocidad.Name = "LVelocidad"
        Me.LVelocidad.Size = New System.Drawing.Size(88, 18)
        Me.LVelocidad.TabIndex = 6
        Me.LVelocidad.Text = "Velocidades"
        '
        'LAsientos
        '
        Me.LAsientos.AutoSize = True
        Me.LAsientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAsientos.ForeColor = System.Drawing.SystemColors.Control
        Me.LAsientos.Location = New System.Drawing.Point(573, 35)
        Me.LAsientos.Name = "LAsientos"
        Me.LAsientos.Size = New System.Drawing.Size(65, 18)
        Me.LAsientos.TabIndex = 5
        Me.LAsientos.Text = "Asientos"
        '
        'LPrecio
        '
        Me.LPrecio.AutoSize = True
        Me.LPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPrecio.ForeColor = System.Drawing.SystemColors.Control
        Me.LPrecio.Location = New System.Drawing.Point(353, 176)
        Me.LPrecio.Name = "LPrecio"
        Me.LPrecio.Size = New System.Drawing.Size(51, 18)
        Me.LPrecio.TabIndex = 4
        Me.LPrecio.Text = "Precio"
        '
        'LMotor
        '
        Me.LMotor.AutoSize = True
        Me.LMotor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMotor.ForeColor = System.Drawing.SystemColors.Control
        Me.LMotor.Location = New System.Drawing.Point(353, 128)
        Me.LMotor.Name = "LMotor"
        Me.LMotor.Size = New System.Drawing.Size(48, 18)
        Me.LMotor.TabIndex = 3
        Me.LMotor.Text = "Motor"
        '
        'LAño
        '
        Me.LAño.AutoSize = True
        Me.LAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAño.ForeColor = System.Drawing.SystemColors.Control
        Me.LAño.Location = New System.Drawing.Point(353, 81)
        Me.LAño.Name = "LAño"
        Me.LAño.Size = New System.Drawing.Size(34, 18)
        Me.LAño.TabIndex = 2
        Me.LAño.Text = "Año"
        '
        'LMarcaModelo
        '
        Me.LMarcaModelo.AutoSize = True
        Me.LMarcaModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMarcaModelo.ForeColor = System.Drawing.SystemColors.Control
        Me.LMarcaModelo.Location = New System.Drawing.Point(353, 35)
        Me.LMarcaModelo.Name = "LMarcaModelo"
        Me.LMarcaModelo.Size = New System.Drawing.Size(129, 18)
        Me.LMarcaModelo.TabIndex = 1
        Me.LMarcaModelo.Text = "Marca y Modelo"
        '
        'PbFotoVehiculo
        '
        Me.PbFotoVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PbFotoVehiculo.Location = New System.Drawing.Point(23, 35)
        Me.PbFotoVehiculo.Name = "PbFotoVehiculo"
        Me.PbFotoVehiculo.Size = New System.Drawing.Size(297, 171)
        Me.PbFotoVehiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbFotoVehiculo.TabIndex = 0
        Me.PbFotoVehiculo.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(307, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Filtrar por Precio"
        '
        'CBPrecio
        '
        Me.CBPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBPrecio.FormattingEnabled = True
        Me.CBPrecio.Items.AddRange(New Object() {"Menos de 2 Millones", "Menos de 3 Millones", "Menos de 4 millones", "4 Millones o mas"})
        Me.CBPrecio.Location = New System.Drawing.Point(431, 20)
        Me.CBPrecio.Name = "CBPrecio"
        Me.CBPrecio.Size = New System.Drawing.Size(152, 26)
        Me.CBPrecio.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(594, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Buscar Modelo"
        '
        'TBBusqueda
        '
        Me.TBBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBBusqueda.Location = New System.Drawing.Point(717, 21)
        Me.TBBusqueda.Name = "TBBusqueda"
        Me.TBBusqueda.Size = New System.Drawing.Size(172, 24)
        Me.TBBusqueda.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BMasVendido)
        Me.Panel1.Controls.Add(Me.BCerrarSesion)
        Me.Panel1.Controls.Add(Me.BVerTodos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 611)
        Me.Panel1.TabIndex = 12
        '
        'BMasVendido
        '
        Me.BMasVendido.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BMasVendido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BMasVendido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BMasVendido.ForeColor = System.Drawing.SystemColors.Control
        Me.BMasVendido.Location = New System.Drawing.Point(23, 225)
        Me.BMasVendido.Name = "BMasVendido"
        Me.BMasVendido.Size = New System.Drawing.Size(159, 33)
        Me.BMasVendido.TabIndex = 15
        Me.BMasVendido.Text = "Mas Vendidos"
        Me.BMasVendido.UseVisualStyleBackColor = False
        '
        'BCerrarSesion
        '
        Me.BCerrarSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCerrarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCerrarSesion.ForeColor = System.Drawing.SystemColors.Control
        Me.BCerrarSesion.Location = New System.Drawing.Point(23, 450)
        Me.BCerrarSesion.Name = "BCerrarSesion"
        Me.BCerrarSesion.Size = New System.Drawing.Size(159, 33)
        Me.BCerrarSesion.TabIndex = 14
        Me.BCerrarSesion.Text = "Volver"
        Me.BCerrarSesion.UseVisualStyleBackColor = False
        '
        'BVerTodos
        '
        Me.BVerTodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BVerTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVerTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVerTodos.ForeColor = System.Drawing.SystemColors.Control
        Me.BVerTodos.Location = New System.Drawing.Point(23, 150)
        Me.BVerTodos.Name = "BVerTodos"
        Me.BVerTodos.Size = New System.Drawing.Size(159, 33)
        Me.BVerTodos.TabIndex = 13
        Me.BVerTodos.Text = "Ver Todos"
        Me.BVerTodos.UseVisualStyleBackColor = False
        '
        'GBVerTodos
        '
        Me.GBVerTodos.Controls.Add(Me.TBBusqueda)
        Me.GBVerTodos.Controls.Add(Me.GBCatalogo)
        Me.GBVerTodos.Controls.Add(Me.Label2)
        Me.GBVerTodos.Controls.Add(Me.CBFiltroNarca)
        Me.GBVerTodos.Controls.Add(Me.Label3)
        Me.GBVerTodos.Controls.Add(Me.BTVerMas)
        Me.GBVerTodos.Controls.Add(Me.Label1)
        Me.GBVerTodos.Controls.Add(Me.DGVVehiculos)
        Me.GBVerTodos.Controls.Add(Me.CBPrecio)
        Me.GBVerTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GBVerTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBVerTodos.ForeColor = System.Drawing.SystemColors.Control
        Me.GBVerTodos.Location = New System.Drawing.Point(233, 12)
        Me.GBVerTodos.Name = "GBVerTodos"
        Me.GBVerTodos.Size = New System.Drawing.Size(920, 520)
        Me.GBVerTodos.TabIndex = 13
        Me.GBVerTodos.TabStop = False
        Me.GBVerTodos.Text = "Ver Todos"
        '
        'GBMasVenidos
        '
        Me.GBMasVenidos.Controls.Add(Me.PBMasVendido4)
        Me.GBMasVenidos.Controls.Add(Me.PBMasVendido3)
        Me.GBMasVenidos.Controls.Add(Me.PBMasVendido2)
        Me.GBMasVenidos.Controls.Add(Me.PBMasVendido1)
        Me.GBMasVenidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBMasVenidos.ForeColor = System.Drawing.SystemColors.Control
        Me.GBMasVenidos.Location = New System.Drawing.Point(233, 12)
        Me.GBMasVenidos.Name = "GBMasVenidos"
        Me.GBMasVenidos.Size = New System.Drawing.Size(920, 514)
        Me.GBMasVenidos.TabIndex = 14
        Me.GBMasVenidos.TabStop = False
        Me.GBMasVenidos.Text = "Mas Vendidos"
        '
        'PBMasVendido4
        '
        Me.PBMasVendido4.Location = New System.Drawing.Point(687, 62)
        Me.PBMasVendido4.Name = "PBMasVendido4"
        Me.PBMasVendido4.Size = New System.Drawing.Size(156, 137)
        Me.PBMasVendido4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBMasVendido4.TabIndex = 3
        Me.PBMasVendido4.TabStop = False
        '
        'PBMasVendido3
        '
        Me.PBMasVendido3.Location = New System.Drawing.Point(485, 62)
        Me.PBMasVendido3.Name = "PBMasVendido3"
        Me.PBMasVendido3.Size = New System.Drawing.Size(156, 137)
        Me.PBMasVendido3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBMasVendido3.TabIndex = 2
        Me.PBMasVendido3.TabStop = False
        '
        'PBMasVendido2
        '
        Me.PBMasVendido2.Location = New System.Drawing.Point(281, 62)
        Me.PBMasVendido2.Name = "PBMasVendido2"
        Me.PBMasVendido2.Size = New System.Drawing.Size(156, 137)
        Me.PBMasVendido2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBMasVendido2.TabIndex = 1
        Me.PBMasVendido2.TabStop = False
        '
        'PBMasVendido1
        '
        Me.PBMasVendido1.Location = New System.Drawing.Point(67, 62)
        Me.PBMasVendido1.Name = "PBMasVendido1"
        Me.PBMasVendido1.Size = New System.Drawing.Size(156, 137)
        Me.PBMasVendido1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBMasVendido1.TabIndex = 0
        Me.PBMasVendido1.TabStop = False
        '
        'BSolicitarCompra
        '
        Me.BSolicitarCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BSolicitarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BSolicitarCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSolicitarCompra.ForeColor = System.Drawing.SystemColors.Control
        Me.BSolicitarCompra.Location = New System.Drawing.Point(961, 554)
        Me.BSolicitarCompra.Name = "BSolicitarCompra"
        Me.BSolicitarCompra.Size = New System.Drawing.Size(159, 33)
        Me.BSolicitarCompra.TabIndex = 12
        Me.BSolicitarCompra.Text = "Solicitar Compra"
        Me.BSolicitarCompra.UseVisualStyleBackColor = False
        '
        'Catalogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1184, 611)
        Me.Controls.Add(Me.BSolicitarCompra)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GBVerTodos)
        Me.Controls.Add(Me.GBMasVenidos)
        Me.Name = "Catalogo"
        Me.Text = "Catalogo"
        CType(Me.DGVVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBCatalogo.ResumeLayout(False)
        Me.GBCatalogo.PerformLayout()
        CType(Me.PbFotoVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GBVerTodos.ResumeLayout(False)
        Me.GBVerTodos.PerformLayout()
        Me.GBMasVenidos.ResumeLayout(False)
        CType(Me.PBMasVendido4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBMasVendido3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBMasVendido2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBMasVendido1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CBFiltroNarca As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DGVVehiculos As DataGridView
    Friend WithEvents BTVerMas As Button
    Friend WithEvents GBCatalogo As GroupBox
    Friend WithEvents PbFotoVehiculo As PictureBox
    Friend WithEvents LMarcaModelo As Label
    Friend WithEvents LStock As Label
    Friend WithEvents LPeso As Label
    Friend WithEvents LVelocidad As Label
    Friend WithEvents LAsientos As Label
    Friend WithEvents LPrecio As Label
    Friend WithEvents LMotor As Label
    Friend WithEvents LAño As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CBPrecio As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBBusqueda As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BCerrarSesion As Button
    Friend WithEvents BVerTodos As Button
    Friend WithEvents GBVerTodos As GroupBox
    Friend WithEvents GBMasVenidos As GroupBox
    Friend WithEvents BMasVendido As Button
    Friend WithEvents PBMasVendido4 As PictureBox
    Friend WithEvents PBMasVendido3 As PictureBox
    Friend WithEvents PBMasVendido2 As PictureBox
    Friend WithEvents PBMasVendido1 As PictureBox
    Friend WithEvents BSolicitarCompra As Button
End Class
