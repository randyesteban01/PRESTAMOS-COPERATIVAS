Imports MySql.Data.MySqlClient
Public Class FRM_PERMISO_ROLES
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents tpArchivo As System.Windows.Forms.TabPage
    Friend WithEvents tpMantenimiento As System.Windows.Forms.TabPage
    Friend WithEvents tpBanco As System.Windows.Forms.TabPage
    Friend WithEvents tpCaja As System.Windows.Forms.TabPage
    Friend WithEvents tpCxC As System.Windows.Forms.TabPage
    Friend WithEvents tpCxP As System.Windows.Forms.TabPage
    Friend WithEvents cmbUsuarios As System.Windows.Forms.ComboBox
    Friend WithEvents mnuArchivo As System.Windows.Forms.CheckBox
    Friend WithEvents mnuCambiarMiClave As System.Windows.Forms.CheckBox
    Friend WithEvents mnuCambiarUsuario As System.Windows.Forms.CheckBox
    Friend WithEvents mnuFormatoCheque As System.Windows.Forms.CheckBox
    Friend WithEvents mnuTimbrado As System.Windows.Forms.CheckBox
    Friend WithEvents mnuPermisosUsuarios As System.Windows.Forms.CheckBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnVerPermisos As System.Windows.Forms.Button
    Friend WithEvents mnuMantenimiento As System.Windows.Forms.CheckBox
    Friend WithEvents mnuCliente As System.Windows.Forms.CheckBox
    Friend WithEvents mnuInmuebles As System.Windows.Forms.CheckBox
    Friend WithEvents mnuUsuarioNuevo As System.Windows.Forms.CheckBox
    Friend WithEvents mnuCobradores As System.Windows.Forms.CheckBox
    Friend WithEvents mnuZonas As System.Windows.Forms.CheckBox
    Friend WithEvents mnuUrbanizaciones As System.Windows.Forms.CheckBox
    Friend WithEvents mnuCiudad As System.Windows.Forms.CheckBox
    Friend WithEvents mnuProvincias As System.Windows.Forms.CheckBox
    Friend WithEvents mnuBanco As System.Windows.Forms.CheckBox
    Friend WithEvents mnuMaestroBanco As System.Windows.Forms.CheckBox
    Friend WithEvents mnuDiarioBanco As System.Windows.Forms.CheckBox
    Friend WithEvents mnuDiarioBancoSolicitud As System.Windows.Forms.CheckBox
    Friend WithEvents mnuDiarioBancoCheque As System.Windows.Forms.CheckBox
    Friend WithEvents mnuDiarioBancoDeposito As System.Windows.Forms.CheckBox
    Friend WithEvents mnuDiarioBancoND As System.Windows.Forms.CheckBox
    Friend WithEvents mnuDiarioBancoNC As System.Windows.Forms.CheckBox
    Friend WithEvents mnuConciliacion As System.Windows.Forms.CheckBox
    Friend WithEvents repEstadoBanco As System.Windows.Forms.CheckBox
    Friend WithEvents repDepositos As System.Windows.Forms.CheckBox
    Friend WithEvents repCheques As System.Windows.Forms.CheckBox
    Friend WithEvents repNCBanco As System.Windows.Forms.CheckBox
    Friend WithEvents repNDBanco As System.Windows.Forms.CheckBox
    Friend WithEvents mnuDiarioBancoCargosComisiones As System.Windows.Forms.CheckBox
    Friend WithEvents mnuCaja As System.Windows.Forms.CheckBox
    Friend WithEvents mnuRecibosIngresos As System.Windows.Forms.CheckBox
    Friend WithEvents mnuOtrosIngresos As System.Windows.Forms.CheckBox
    Friend WithEvents mnuConsultaIngresos As System.Windows.Forms.CheckBox
    Friend WithEvents mnuEgresos As System.Windows.Forms.CheckBox
    Friend WithEvents mnuCuadreCaja As System.Windows.Forms.CheckBox
    Friend WithEvents repRecibosIngresos As System.Windows.Forms.CheckBox
    Friend WithEvents repRecibosIngresosNulos As System.Windows.Forms.CheckBox
    Friend WithEvents repEgresosCaja As System.Windows.Forms.CheckBox
    Friend WithEvents repPrestamosSaldados As System.Windows.Forms.CheckBox
    Friend WithEvents repPrestamosPendientes As System.Windows.Forms.CheckBox
    Friend WithEvents repPrestamosEntregados As System.Windows.Forms.CheckBox
    Friend WithEvents mnuPrestamosNuevo As System.Windows.Forms.CheckBox
    Friend WithEvents repCuentaPorCobrar As System.Windows.Forms.CheckBox
    Friend WithEvents repTodosClientes As System.Windows.Forms.CheckBox
    Friend WithEvents repCuentaPorCobrarIntes As System.Windows.Forms.CheckBox
    Friend WithEvents repCuentaPorCobrarCapital As System.Windows.Forms.CheckBox
    Friend WithEvents repCuentaPorCobrarCuotasFechas As System.Windows.Forms.CheckBox
    Friend WithEvents repNCCxC As System.Windows.Forms.CheckBox
    Friend WithEvents repNDCxC As System.Windows.Forms.CheckBox
    Friend WithEvents repEstadoCliente As System.Windows.Forms.CheckBox
    Friend WithEvents mnuConsultaCxCNC As System.Windows.Forms.CheckBox
    Friend WithEvents mnuCxCNC As System.Windows.Forms.CheckBox
    Friend WithEvents mnuCxCND As System.Windows.Forms.CheckBox
    Friend WithEvents mnuGeneraRecibos As System.Windows.Forms.CheckBox
    Friend WithEvents mnuCuentaPorCobrar As System.Windows.Forms.CheckBox
    Friend WithEvents repNCCuentaPorPagar As System.Windows.Forms.CheckBox
    Friend WithEvents repTodoProveedores As System.Windows.Forms.CheckBox
    Friend WithEvents repNDCuentaPorPagar As System.Windows.Forms.CheckBox
    Friend WithEvents repCuentaPorPagar As System.Windows.Forms.CheckBox
    Friend WithEvents repEstadoProveedor As System.Windows.Forms.CheckBox
    Friend WithEvents mnuCxPNC As System.Windows.Forms.CheckBox
    Friend WithEvents mnuCxPND As System.Windows.Forms.CheckBox
    Friend WithEvents mnuIngresosCajaCxP As System.Windows.Forms.CheckBox
    Friend WithEvents mnuProveedores As System.Windows.Forms.CheckBox
    Friend WithEvents mnuCuentaPorPagar As System.Windows.Forms.CheckBox
    Friend WithEvents tpBarra As System.Windows.Forms.TabPage
    Friend WithEvents b_nc_cxc As System.Windows.Forms.CheckBox
    Friend WithEvents b_ri As System.Windows.Forms.CheckBox
    Friend WithEvents b_nd_cxc As System.Windows.Forms.CheckBox
    Friend WithEvents b_prestasmos As System.Windows.Forms.CheckBox
    Friend WithEvents b_clientes As System.Windows.Forms.CheckBox
    Friend WithEvents ToolBar As System.Windows.Forms.CheckBox
    Friend WithEvents mnuCategoriaAhorro As System.Windows.Forms.CheckBox
    Friend WithEvents mnuIngresosDevengados As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents mnuActualizarInteres As System.Windows.Forms.CheckBox
    Friend WithEvents mnuConfiguracionContabilidad As System.Windows.Forms.CheckBox
    Friend WithEvents tpAhorro As System.Windows.Forms.TabPage
    Friend WithEvents mnuAhorrosNuevo As System.Windows.Forms.CheckBox
    Friend WithEvents mnuAhorros As System.Windows.Forms.CheckBox
    Friend WithEvents mnuAhorrosRealizarRetiros As System.Windows.Forms.CheckBox
    Friend WithEvents mnuAhorrosEstadoCuenta As System.Windows.Forms.CheckBox
    Friend WithEvents mnuAhorrosRetiros As System.Windows.Forms.CheckBox
    Friend WithEvents mnuAhorrosSaldos As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_PERMISO_ROLES))
        Me.TabControl = New System.Windows.Forms.TabControl
        Me.tpArchivo = New System.Windows.Forms.TabPage
        Me.mnuConfiguracionContabilidad = New System.Windows.Forms.CheckBox
        Me.mnuActualizarInteres = New System.Windows.Forms.CheckBox
        Me.mnuPermisosUsuarios = New System.Windows.Forms.CheckBox
        Me.mnuTimbrado = New System.Windows.Forms.CheckBox
        Me.mnuFormatoCheque = New System.Windows.Forms.CheckBox
        Me.mnuCambiarUsuario = New System.Windows.Forms.CheckBox
        Me.mnuCambiarMiClave = New System.Windows.Forms.CheckBox
        Me.mnuArchivo = New System.Windows.Forms.CheckBox
        Me.tpMantenimiento = New System.Windows.Forms.TabPage
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.mnuCategoriaAhorro = New System.Windows.Forms.CheckBox
        Me.mnuProvincias = New System.Windows.Forms.CheckBox
        Me.mnuCiudad = New System.Windows.Forms.CheckBox
        Me.mnuUrbanizaciones = New System.Windows.Forms.CheckBox
        Me.mnuZonas = New System.Windows.Forms.CheckBox
        Me.mnuCobradores = New System.Windows.Forms.CheckBox
        Me.mnuUsuarioNuevo = New System.Windows.Forms.CheckBox
        Me.mnuInmuebles = New System.Windows.Forms.CheckBox
        Me.mnuCliente = New System.Windows.Forms.CheckBox
        Me.mnuMantenimiento = New System.Windows.Forms.CheckBox
        Me.tpBanco = New System.Windows.Forms.TabPage
        Me.mnuDiarioBancoCargosComisiones = New System.Windows.Forms.CheckBox
        Me.repNDBanco = New System.Windows.Forms.CheckBox
        Me.repNCBanco = New System.Windows.Forms.CheckBox
        Me.repCheques = New System.Windows.Forms.CheckBox
        Me.repDepositos = New System.Windows.Forms.CheckBox
        Me.repEstadoBanco = New System.Windows.Forms.CheckBox
        Me.mnuConciliacion = New System.Windows.Forms.CheckBox
        Me.mnuDiarioBancoNC = New System.Windows.Forms.CheckBox
        Me.mnuDiarioBancoND = New System.Windows.Forms.CheckBox
        Me.mnuDiarioBancoDeposito = New System.Windows.Forms.CheckBox
        Me.mnuDiarioBancoCheque = New System.Windows.Forms.CheckBox
        Me.mnuDiarioBancoSolicitud = New System.Windows.Forms.CheckBox
        Me.mnuDiarioBanco = New System.Windows.Forms.CheckBox
        Me.mnuMaestroBanco = New System.Windows.Forms.CheckBox
        Me.mnuBanco = New System.Windows.Forms.CheckBox
        Me.tpCaja = New System.Windows.Forms.TabPage
        Me.mnuIngresosDevengados = New System.Windows.Forms.CheckBox
        Me.repEgresosCaja = New System.Windows.Forms.CheckBox
        Me.repRecibosIngresosNulos = New System.Windows.Forms.CheckBox
        Me.repRecibosIngresos = New System.Windows.Forms.CheckBox
        Me.mnuCuadreCaja = New System.Windows.Forms.CheckBox
        Me.mnuEgresos = New System.Windows.Forms.CheckBox
        Me.mnuConsultaIngresos = New System.Windows.Forms.CheckBox
        Me.mnuOtrosIngresos = New System.Windows.Forms.CheckBox
        Me.mnuRecibosIngresos = New System.Windows.Forms.CheckBox
        Me.mnuCaja = New System.Windows.Forms.CheckBox
        Me.tpAhorro = New System.Windows.Forms.TabPage
        Me.mnuAhorrosSaldos = New System.Windows.Forms.CheckBox
        Me.mnuAhorrosRetiros = New System.Windows.Forms.CheckBox
        Me.mnuAhorrosEstadoCuenta = New System.Windows.Forms.CheckBox
        Me.mnuAhorrosRealizarRetiros = New System.Windows.Forms.CheckBox
        Me.mnuAhorrosNuevo = New System.Windows.Forms.CheckBox
        Me.mnuAhorros = New System.Windows.Forms.CheckBox
        Me.tpCxC = New System.Windows.Forms.TabPage
        Me.repCuentaPorCobrar = New System.Windows.Forms.CheckBox
        Me.repTodosClientes = New System.Windows.Forms.CheckBox
        Me.repCuentaPorCobrarIntes = New System.Windows.Forms.CheckBox
        Me.repCuentaPorCobrarCapital = New System.Windows.Forms.CheckBox
        Me.repCuentaPorCobrarCuotasFechas = New System.Windows.Forms.CheckBox
        Me.repNCCxC = New System.Windows.Forms.CheckBox
        Me.repNDCxC = New System.Windows.Forms.CheckBox
        Me.repEstadoCliente = New System.Windows.Forms.CheckBox
        Me.mnuConsultaCxCNC = New System.Windows.Forms.CheckBox
        Me.mnuCxCNC = New System.Windows.Forms.CheckBox
        Me.mnuCxCND = New System.Windows.Forms.CheckBox
        Me.mnuGeneraRecibos = New System.Windows.Forms.CheckBox
        Me.mnuCuentaPorCobrar = New System.Windows.Forms.CheckBox
        Me.repPrestamosSaldados = New System.Windows.Forms.CheckBox
        Me.repPrestamosPendientes = New System.Windows.Forms.CheckBox
        Me.repPrestamosEntregados = New System.Windows.Forms.CheckBox
        Me.mnuPrestamosNuevo = New System.Windows.Forms.CheckBox
        Me.tpCxP = New System.Windows.Forms.TabPage
        Me.repNCCuentaPorPagar = New System.Windows.Forms.CheckBox
        Me.repTodoProveedores = New System.Windows.Forms.CheckBox
        Me.repNDCuentaPorPagar = New System.Windows.Forms.CheckBox
        Me.repCuentaPorPagar = New System.Windows.Forms.CheckBox
        Me.repEstadoProveedor = New System.Windows.Forms.CheckBox
        Me.mnuCxPNC = New System.Windows.Forms.CheckBox
        Me.mnuCxPND = New System.Windows.Forms.CheckBox
        Me.mnuIngresosCajaCxP = New System.Windows.Forms.CheckBox
        Me.mnuProveedores = New System.Windows.Forms.CheckBox
        Me.mnuCuentaPorPagar = New System.Windows.Forms.CheckBox
        Me.tpBarra = New System.Windows.Forms.TabPage
        Me.b_nc_cxc = New System.Windows.Forms.CheckBox
        Me.b_ri = New System.Windows.Forms.CheckBox
        Me.b_nd_cxc = New System.Windows.Forms.CheckBox
        Me.b_prestasmos = New System.Windows.Forms.CheckBox
        Me.b_clientes = New System.Windows.Forms.CheckBox
        Me.ToolBar = New System.Windows.Forms.CheckBox
        Me.cmbUsuarios = New System.Windows.Forms.ComboBox
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnVerPermisos = New System.Windows.Forms.Button
        Me.TabControl.SuspendLayout()
        Me.tpArchivo.SuspendLayout()
        Me.tpMantenimiento.SuspendLayout()
        Me.tpBanco.SuspendLayout()
        Me.tpCaja.SuspendLayout()
        Me.tpAhorro.SuspendLayout()
        Me.tpCxC.SuspendLayout()
        Me.tpCxP.SuspendLayout()
        Me.tpBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.tpArchivo)
        Me.TabControl.Controls.Add(Me.tpMantenimiento)
        Me.TabControl.Controls.Add(Me.tpBanco)
        Me.TabControl.Controls.Add(Me.tpAhorro)
        Me.TabControl.Controls.Add(Me.tpCxC)
        Me.TabControl.Controls.Add(Me.tpCxP)
        Me.TabControl.Controls.Add(Me.tpCaja)
        Me.TabControl.Controls.Add(Me.tpBarra)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl.Location = New System.Drawing.Point(0, 67)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(738, 424)
        Me.TabControl.TabIndex = 0
        '
        'tpArchivo
        '
        Me.tpArchivo.Controls.Add(Me.mnuConfiguracionContabilidad)
        Me.tpArchivo.Controls.Add(Me.mnuActualizarInteres)
        Me.tpArchivo.Controls.Add(Me.mnuPermisosUsuarios)
        Me.tpArchivo.Controls.Add(Me.mnuTimbrado)
        Me.tpArchivo.Controls.Add(Me.mnuFormatoCheque)
        Me.tpArchivo.Controls.Add(Me.mnuCambiarUsuario)
        Me.tpArchivo.Controls.Add(Me.mnuCambiarMiClave)
        Me.tpArchivo.Controls.Add(Me.mnuArchivo)
        Me.tpArchivo.Location = New System.Drawing.Point(4, 22)
        Me.tpArchivo.Name = "tpArchivo"
        Me.tpArchivo.Size = New System.Drawing.Size(730, 398)
        Me.tpArchivo.TabIndex = 0
        Me.tpArchivo.Text = "Archivo"
        '
        'mnuConfiguracionContabilidad
        '
        Me.mnuConfiguracionContabilidad.Location = New System.Drawing.Point(32, 166)
        Me.mnuConfiguracionContabilidad.Name = "mnuConfiguracionContabilidad"
        Me.mnuConfiguracionContabilidad.Size = New System.Drawing.Size(200, 16)
        Me.mnuConfiguracionContabilidad.TabIndex = 7
        Me.mnuConfiguracionContabilidad.Text = "Configuración de Contabilidad"
        '
        'mnuActualizarInteres
        '
        Me.mnuActualizarInteres.Location = New System.Drawing.Point(32, 40)
        Me.mnuActualizarInteres.Name = "mnuActualizarInteres"
        Me.mnuActualizarInteres.Size = New System.Drawing.Size(200, 16)
        Me.mnuActualizarInteres.TabIndex = 6
        Me.mnuActualizarInteres.Text = "Actualizar Interes"
        '
        'mnuPermisosUsuarios
        '
        Me.mnuPermisosUsuarios.Location = New System.Drawing.Point(32, 61)
        Me.mnuPermisosUsuarios.Name = "mnuPermisosUsuarios"
        Me.mnuPermisosUsuarios.Size = New System.Drawing.Size(200, 16)
        Me.mnuPermisosUsuarios.TabIndex = 5
        Me.mnuPermisosUsuarios.Text = "Permiso de Usuario"
        '
        'mnuTimbrado
        '
        Me.mnuTimbrado.Location = New System.Drawing.Point(32, 145)
        Me.mnuTimbrado.Name = "mnuTimbrado"
        Me.mnuTimbrado.Size = New System.Drawing.Size(200, 16)
        Me.mnuTimbrado.TabIndex = 4
        Me.mnuTimbrado.Text = "Timbrado"
        '
        'mnuFormatoCheque
        '
        Me.mnuFormatoCheque.Location = New System.Drawing.Point(32, 124)
        Me.mnuFormatoCheque.Name = "mnuFormatoCheque"
        Me.mnuFormatoCheque.Size = New System.Drawing.Size(200, 16)
        Me.mnuFormatoCheque.TabIndex = 3
        Me.mnuFormatoCheque.Text = "Formato de Cheque"
        '
        'mnuCambiarUsuario
        '
        Me.mnuCambiarUsuario.Location = New System.Drawing.Point(32, 103)
        Me.mnuCambiarUsuario.Name = "mnuCambiarUsuario"
        Me.mnuCambiarUsuario.Size = New System.Drawing.Size(200, 16)
        Me.mnuCambiarUsuario.TabIndex = 2
        Me.mnuCambiarUsuario.Text = "Cambiar Usuario"
        '
        'mnuCambiarMiClave
        '
        Me.mnuCambiarMiClave.Location = New System.Drawing.Point(32, 82)
        Me.mnuCambiarMiClave.Name = "mnuCambiarMiClave"
        Me.mnuCambiarMiClave.Size = New System.Drawing.Size(200, 16)
        Me.mnuCambiarMiClave.TabIndex = 1
        Me.mnuCambiarMiClave.Text = "Cambiar Mi Clave"
        '
        'mnuArchivo
        '
        Me.mnuArchivo.Location = New System.Drawing.Point(16, 16)
        Me.mnuArchivo.Name = "mnuArchivo"
        Me.mnuArchivo.Size = New System.Drawing.Size(200, 16)
        Me.mnuArchivo.TabIndex = 0
        Me.mnuArchivo.Text = "Archivo"
        '
        'tpMantenimiento
        '
        Me.tpMantenimiento.Controls.Add(Me.CheckBox2)
        Me.tpMantenimiento.Controls.Add(Me.CheckBox1)
        Me.tpMantenimiento.Controls.Add(Me.mnuCategoriaAhorro)
        Me.tpMantenimiento.Controls.Add(Me.mnuProvincias)
        Me.tpMantenimiento.Controls.Add(Me.mnuCiudad)
        Me.tpMantenimiento.Controls.Add(Me.mnuUrbanizaciones)
        Me.tpMantenimiento.Controls.Add(Me.mnuZonas)
        Me.tpMantenimiento.Controls.Add(Me.mnuCobradores)
        Me.tpMantenimiento.Controls.Add(Me.mnuUsuarioNuevo)
        Me.tpMantenimiento.Controls.Add(Me.mnuInmuebles)
        Me.tpMantenimiento.Controls.Add(Me.mnuCliente)
        Me.tpMantenimiento.Controls.Add(Me.mnuMantenimiento)
        Me.tpMantenimiento.Controls.Add(Me.mnuProveedores)
        Me.tpMantenimiento.Location = New System.Drawing.Point(4, 22)
        Me.tpMantenimiento.Name = "tpMantenimiento"
        Me.tpMantenimiento.Size = New System.Drawing.Size(730, 398)
        Me.tpMantenimiento.TabIndex = 1
        Me.tpMantenimiento.Text = "Mantenimiento"
        '
        'CheckBox2
        '
        Me.CheckBox2.Location = New System.Drawing.Point(384, 248)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(200, 16)
        Me.CheckBox2.TabIndex = 12
        Me.CheckBox2.Text = "Prefijos de Cuentas de Ahorros"
        Me.CheckBox2.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(360, 88)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(200, 16)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "Tipos de Doc. de Identidad"
        Me.CheckBox1.Visible = False
        '
        'mnuCategoriaAhorro
        '
        Me.mnuCategoriaAhorro.Location = New System.Drawing.Point(296, 272)
        Me.mnuCategoriaAhorro.Name = "mnuCategoriaAhorro"
        Me.mnuCategoriaAhorro.Size = New System.Drawing.Size(200, 16)
        Me.mnuCategoriaAhorro.TabIndex = 10
        Me.mnuCategoriaAhorro.Text = "Categoría ahorros"
        Me.mnuCategoriaAhorro.Visible = False
        '
        'mnuProvincias
        '
        Me.mnuProvincias.Location = New System.Drawing.Point(32, 232)
        Me.mnuProvincias.Name = "mnuProvincias"
        Me.mnuProvincias.Size = New System.Drawing.Size(200, 16)
        Me.mnuProvincias.TabIndex = 9
        Me.mnuProvincias.Text = "Provincias"
        '
        'mnuCiudad
        '
        Me.mnuCiudad.Location = New System.Drawing.Point(32, 208)
        Me.mnuCiudad.Name = "mnuCiudad"
        Me.mnuCiudad.Size = New System.Drawing.Size(200, 16)
        Me.mnuCiudad.TabIndex = 8
        Me.mnuCiudad.Text = "Ciudad"
        '
        'mnuUrbanizaciones
        '
        Me.mnuUrbanizaciones.Location = New System.Drawing.Point(32, 184)
        Me.mnuUrbanizaciones.Name = "mnuUrbanizaciones"
        Me.mnuUrbanizaciones.Size = New System.Drawing.Size(200, 16)
        Me.mnuUrbanizaciones.TabIndex = 7
        Me.mnuUrbanizaciones.Text = "Urbanizaciones"
        '
        'mnuZonas
        '
        Me.mnuZonas.Location = New System.Drawing.Point(32, 160)
        Me.mnuZonas.Name = "mnuZonas"
        Me.mnuZonas.Size = New System.Drawing.Size(200, 16)
        Me.mnuZonas.TabIndex = 6
        Me.mnuZonas.Text = "Zonas"
        '
        'mnuCobradores
        '
        Me.mnuCobradores.Location = New System.Drawing.Point(32, 136)
        Me.mnuCobradores.Name = "mnuCobradores"
        Me.mnuCobradores.Size = New System.Drawing.Size(200, 16)
        Me.mnuCobradores.TabIndex = 5
        Me.mnuCobradores.Text = "Cobradores"
        '
        'mnuUsuarioNuevo
        '
        Me.mnuUsuarioNuevo.Location = New System.Drawing.Point(32, 112)
        Me.mnuUsuarioNuevo.Name = "mnuUsuarioNuevo"
        Me.mnuUsuarioNuevo.Size = New System.Drawing.Size(200, 16)
        Me.mnuUsuarioNuevo.TabIndex = 4
        Me.mnuUsuarioNuevo.Text = "Usuarios"
        '
        'mnuInmuebles
        '
        Me.mnuInmuebles.Location = New System.Drawing.Point(32, 88)
        Me.mnuInmuebles.Name = "mnuInmuebles"
        Me.mnuInmuebles.Size = New System.Drawing.Size(200, 16)
        Me.mnuInmuebles.TabIndex = 3
        Me.mnuInmuebles.Text = "Inmuebles"
        '
        'mnuCliente
        '
        Me.mnuCliente.Location = New System.Drawing.Point(32, 40)
        Me.mnuCliente.Name = "mnuCliente"
        Me.mnuCliente.Size = New System.Drawing.Size(200, 16)
        Me.mnuCliente.TabIndex = 2
        Me.mnuCliente.Text = "Clientes"
        '
        'mnuMantenimiento
        '
        Me.mnuMantenimiento.Location = New System.Drawing.Point(16, 16)
        Me.mnuMantenimiento.Name = "mnuMantenimiento"
        Me.mnuMantenimiento.Size = New System.Drawing.Size(200, 16)
        Me.mnuMantenimiento.TabIndex = 1
        Me.mnuMantenimiento.Text = "Mantenimiento"
        '
        'tpBanco
        '
        Me.tpBanco.Controls.Add(Me.mnuDiarioBancoCargosComisiones)
        Me.tpBanco.Controls.Add(Me.repNDBanco)
        Me.tpBanco.Controls.Add(Me.repNCBanco)
        Me.tpBanco.Controls.Add(Me.repCheques)
        Me.tpBanco.Controls.Add(Me.repDepositos)
        Me.tpBanco.Controls.Add(Me.repEstadoBanco)
        Me.tpBanco.Controls.Add(Me.mnuConciliacion)
        Me.tpBanco.Controls.Add(Me.mnuDiarioBancoNC)
        Me.tpBanco.Controls.Add(Me.mnuDiarioBancoND)
        Me.tpBanco.Controls.Add(Me.mnuDiarioBancoDeposito)
        Me.tpBanco.Controls.Add(Me.mnuDiarioBancoCheque)
        Me.tpBanco.Controls.Add(Me.mnuDiarioBancoSolicitud)
        Me.tpBanco.Controls.Add(Me.mnuDiarioBanco)
        Me.tpBanco.Controls.Add(Me.mnuMaestroBanco)
        Me.tpBanco.Controls.Add(Me.mnuBanco)
        Me.tpBanco.Location = New System.Drawing.Point(4, 22)
        Me.tpBanco.Name = "tpBanco"
        Me.tpBanco.Size = New System.Drawing.Size(730, 398)
        Me.tpBanco.TabIndex = 2
        Me.tpBanco.Text = "Banco"
        '
        'mnuDiarioBancoCargosComisiones
        '
        Me.mnuDiarioBancoCargosComisiones.Location = New System.Drawing.Point(48, 208)
        Me.mnuDiarioBancoCargosComisiones.Name = "mnuDiarioBancoCargosComisiones"
        Me.mnuDiarioBancoCargosComisiones.Size = New System.Drawing.Size(200, 16)
        Me.mnuDiarioBancoCargosComisiones.TabIndex = 8
        Me.mnuDiarioBancoCargosComisiones.Text = "Cargos / Comisiones"
        Me.mnuDiarioBancoCargosComisiones.Visible = False
        '
        'repNDBanco
        '
        Me.repNDBanco.Location = New System.Drawing.Point(32, 352)
        Me.repNDBanco.Name = "repNDBanco"
        Me.repNDBanco.Size = New System.Drawing.Size(200, 16)
        Me.repNDBanco.TabIndex = 14
        Me.repNDBanco.Text = "Notas de débitos"
        '
        'repNCBanco
        '
        Me.repNCBanco.Location = New System.Drawing.Point(32, 328)
        Me.repNCBanco.Name = "repNCBanco"
        Me.repNCBanco.Size = New System.Drawing.Size(200, 16)
        Me.repNCBanco.TabIndex = 13
        Me.repNCBanco.Text = "Notas de créditos"
        '
        'repCheques
        '
        Me.repCheques.Location = New System.Drawing.Point(32, 304)
        Me.repCheques.Name = "repCheques"
        Me.repCheques.Size = New System.Drawing.Size(200, 16)
        Me.repCheques.TabIndex = 12
        Me.repCheques.Text = "Cheques emitidos"
        '
        'repDepositos
        '
        Me.repDepositos.Location = New System.Drawing.Point(32, 280)
        Me.repDepositos.Name = "repDepositos"
        Me.repDepositos.Size = New System.Drawing.Size(200, 16)
        Me.repDepositos.TabIndex = 11
        Me.repDepositos.Text = "Depósitos"
        '
        'repEstadoBanco
        '
        Me.repEstadoBanco.Location = New System.Drawing.Point(32, 256)
        Me.repEstadoBanco.Name = "repEstadoBanco"
        Me.repEstadoBanco.Size = New System.Drawing.Size(200, 16)
        Me.repEstadoBanco.TabIndex = 10
        Me.repEstadoBanco.Text = "Estado de cuenta"
        '
        'mnuConciliacion
        '
        Me.mnuConciliacion.Location = New System.Drawing.Point(32, 232)
        Me.mnuConciliacion.Name = "mnuConciliacion"
        Me.mnuConciliacion.Size = New System.Drawing.Size(200, 16)
        Me.mnuConciliacion.TabIndex = 9
        Me.mnuConciliacion.Text = "Conciliación"
        '
        'mnuDiarioBancoNC
        '
        Me.mnuDiarioBancoNC.Location = New System.Drawing.Point(48, 184)
        Me.mnuDiarioBancoNC.Name = "mnuDiarioBancoNC"
        Me.mnuDiarioBancoNC.Size = New System.Drawing.Size(200, 16)
        Me.mnuDiarioBancoNC.TabIndex = 7
        Me.mnuDiarioBancoNC.Text = "Nota de crédito"
        '
        'mnuDiarioBancoND
        '
        Me.mnuDiarioBancoND.Location = New System.Drawing.Point(48, 160)
        Me.mnuDiarioBancoND.Name = "mnuDiarioBancoND"
        Me.mnuDiarioBancoND.Size = New System.Drawing.Size(200, 16)
        Me.mnuDiarioBancoND.TabIndex = 6
        Me.mnuDiarioBancoND.Text = "Nota de débito"
        '
        'mnuDiarioBancoDeposito
        '
        Me.mnuDiarioBancoDeposito.Location = New System.Drawing.Point(48, 136)
        Me.mnuDiarioBancoDeposito.Name = "mnuDiarioBancoDeposito"
        Me.mnuDiarioBancoDeposito.Size = New System.Drawing.Size(200, 16)
        Me.mnuDiarioBancoDeposito.TabIndex = 5
        Me.mnuDiarioBancoDeposito.Text = "Dépositos"
        '
        'mnuDiarioBancoCheque
        '
        Me.mnuDiarioBancoCheque.Location = New System.Drawing.Point(48, 112)
        Me.mnuDiarioBancoCheque.Name = "mnuDiarioBancoCheque"
        Me.mnuDiarioBancoCheque.Size = New System.Drawing.Size(200, 16)
        Me.mnuDiarioBancoCheque.TabIndex = 4
        Me.mnuDiarioBancoCheque.Text = "Emisión de Ck"
        '
        'mnuDiarioBancoSolicitud
        '
        Me.mnuDiarioBancoSolicitud.Location = New System.Drawing.Point(48, 88)
        Me.mnuDiarioBancoSolicitud.Name = "mnuDiarioBancoSolicitud"
        Me.mnuDiarioBancoSolicitud.Size = New System.Drawing.Size(200, 16)
        Me.mnuDiarioBancoSolicitud.TabIndex = 3
        Me.mnuDiarioBancoSolicitud.Text = "Solicitud de Ck"
        '
        'mnuDiarioBanco
        '
        Me.mnuDiarioBanco.Location = New System.Drawing.Point(32, 64)
        Me.mnuDiarioBanco.Name = "mnuDiarioBanco"
        Me.mnuDiarioBanco.Size = New System.Drawing.Size(200, 16)
        Me.mnuDiarioBanco.TabIndex = 2
        Me.mnuDiarioBanco.Text = "Diario de banco"
        '
        'mnuMaestroBanco
        '
        Me.mnuMaestroBanco.Location = New System.Drawing.Point(32, 40)
        Me.mnuMaestroBanco.Name = "mnuMaestroBanco"
        Me.mnuMaestroBanco.Size = New System.Drawing.Size(200, 16)
        Me.mnuMaestroBanco.TabIndex = 1
        Me.mnuMaestroBanco.Text = "Maestro de banco"
        '
        'mnuBanco
        '
        Me.mnuBanco.Location = New System.Drawing.Point(16, 16)
        Me.mnuBanco.Name = "mnuBanco"
        Me.mnuBanco.Size = New System.Drawing.Size(200, 16)
        Me.mnuBanco.TabIndex = 0
        Me.mnuBanco.Text = "Banco"
        '
        'tpCaja
        '
        Me.tpCaja.Controls.Add(Me.mnuIngresosDevengados)
        Me.tpCaja.Controls.Add(Me.repEgresosCaja)
        Me.tpCaja.Controls.Add(Me.repRecibosIngresosNulos)
        Me.tpCaja.Controls.Add(Me.repRecibosIngresos)
        Me.tpCaja.Controls.Add(Me.mnuCuadreCaja)
        Me.tpCaja.Controls.Add(Me.mnuEgresos)
        Me.tpCaja.Controls.Add(Me.mnuConsultaIngresos)
        Me.tpCaja.Controls.Add(Me.mnuOtrosIngresos)
        Me.tpCaja.Controls.Add(Me.mnuRecibosIngresos)
        Me.tpCaja.Controls.Add(Me.mnuCaja)
        Me.tpCaja.Location = New System.Drawing.Point(4, 22)
        Me.tpCaja.Name = "tpCaja"
        Me.tpCaja.Size = New System.Drawing.Size(730, 398)
        Me.tpCaja.TabIndex = 3
        Me.tpCaja.Text = "Caja"
        '
        'mnuIngresosDevengados
        '
        Me.mnuIngresosDevengados.Location = New System.Drawing.Point(32, 170)
        Me.mnuIngresosDevengados.Name = "mnuIngresosDevengados"
        Me.mnuIngresosDevengados.Size = New System.Drawing.Size(200, 16)
        Me.mnuIngresosDevengados.TabIndex = 7
        Me.mnuIngresosDevengados.Text = "Ingresos Devengados"
        '
        'repEgresosCaja
        '
        Me.repEgresosCaja.Location = New System.Drawing.Point(32, 214)
        Me.repEgresosCaja.Name = "repEgresosCaja"
        Me.repEgresosCaja.Size = New System.Drawing.Size(200, 16)
        Me.repEgresosCaja.TabIndex = 9
        Me.repEgresosCaja.Text = "Egresos de Caja"
        '
        'repRecibosIngresosNulos
        '
        Me.repRecibosIngresosNulos.Location = New System.Drawing.Point(32, 192)
        Me.repRecibosIngresosNulos.Name = "repRecibosIngresosNulos"
        Me.repRecibosIngresosNulos.Size = New System.Drawing.Size(200, 16)
        Me.repRecibosIngresosNulos.TabIndex = 8
        Me.repRecibosIngresosNulos.Text = "Ingresos Nulos"
        '
        'repRecibosIngresos
        '
        Me.repRecibosIngresos.Location = New System.Drawing.Point(32, 148)
        Me.repRecibosIngresos.Name = "repRecibosIngresos"
        Me.repRecibosIngresos.Size = New System.Drawing.Size(200, 16)
        Me.repRecibosIngresos.TabIndex = 6
        Me.repRecibosIngresos.Text = "Ingresos Percibidos"
        '
        'mnuCuadreCaja
        '
        Me.mnuCuadreCaja.Location = New System.Drawing.Point(32, 126)
        Me.mnuCuadreCaja.Name = "mnuCuadreCaja"
        Me.mnuCuadreCaja.Size = New System.Drawing.Size(200, 16)
        Me.mnuCuadreCaja.TabIndex = 5
        Me.mnuCuadreCaja.Text = "Cuadre General"
        '
        'mnuEgresos
        '
        Me.mnuEgresos.Location = New System.Drawing.Point(32, 104)
        Me.mnuEgresos.Name = "mnuEgresos"
        Me.mnuEgresos.Size = New System.Drawing.Size(200, 16)
        Me.mnuEgresos.TabIndex = 4
        Me.mnuEgresos.Text = "Egresos"
        '
        'mnuConsultaIngresos
        '
        Me.mnuConsultaIngresos.Location = New System.Drawing.Point(32, 82)
        Me.mnuConsultaIngresos.Name = "mnuConsultaIngresos"
        Me.mnuConsultaIngresos.Size = New System.Drawing.Size(200, 16)
        Me.mnuConsultaIngresos.TabIndex = 3
        Me.mnuConsultaIngresos.Text = "Consultal Ingresos"
        '
        'mnuOtrosIngresos
        '
        Me.mnuOtrosIngresos.Location = New System.Drawing.Point(32, 60)
        Me.mnuOtrosIngresos.Name = "mnuOtrosIngresos"
        Me.mnuOtrosIngresos.Size = New System.Drawing.Size(200, 16)
        Me.mnuOtrosIngresos.TabIndex = 2
        Me.mnuOtrosIngresos.Text = "Otro Ingreso"
        '
        'mnuRecibosIngresos
        '
        Me.mnuRecibosIngresos.Location = New System.Drawing.Point(32, 38)
        Me.mnuRecibosIngresos.Name = "mnuRecibosIngresos"
        Me.mnuRecibosIngresos.Size = New System.Drawing.Size(200, 16)
        Me.mnuRecibosIngresos.TabIndex = 1
        Me.mnuRecibosIngresos.Text = "Recibos de Ingresos"
        '
        'mnuCaja
        '
        Me.mnuCaja.Location = New System.Drawing.Point(16, 16)
        Me.mnuCaja.Name = "mnuCaja"
        Me.mnuCaja.Size = New System.Drawing.Size(200, 16)
        Me.mnuCaja.TabIndex = 0
        Me.mnuCaja.Text = "Caja"
        '
        'tpAhorro
        '
        Me.tpAhorro.Controls.Add(Me.mnuAhorrosSaldos)
        Me.tpAhorro.Controls.Add(Me.mnuAhorrosRetiros)
        Me.tpAhorro.Controls.Add(Me.mnuAhorrosEstadoCuenta)
        Me.tpAhorro.Controls.Add(Me.mnuAhorrosRealizarRetiros)
        Me.tpAhorro.Controls.Add(Me.mnuAhorrosNuevo)
        Me.tpAhorro.Controls.Add(Me.mnuAhorros)
        Me.tpAhorro.Location = New System.Drawing.Point(4, 22)
        Me.tpAhorro.Name = "tpAhorro"
        Me.tpAhorro.Size = New System.Drawing.Size(730, 398)
        Me.tpAhorro.TabIndex = 8
        Me.tpAhorro.Text = "Ahorro"
        '
        'mnuAhorrosSaldos
        '
        Me.mnuAhorrosSaldos.Location = New System.Drawing.Point(40, 144)
        Me.mnuAhorrosSaldos.Name = "mnuAhorrosSaldos"
        Me.mnuAhorrosSaldos.Size = New System.Drawing.Size(296, 16)
        Me.mnuAhorrosSaldos.TabIndex = 5
        Me.mnuAhorrosSaldos.Text = "Listado de Saldos"
        '
        'mnuAhorrosRetiros
        '
        Me.mnuAhorrosRetiros.Location = New System.Drawing.Point(40, 120)
        Me.mnuAhorrosRetiros.Name = "mnuAhorrosRetiros"
        Me.mnuAhorrosRetiros.Size = New System.Drawing.Size(296, 16)
        Me.mnuAhorrosRetiros.TabIndex = 4
        Me.mnuAhorrosRetiros.Text = "Listado de Retiros"
        '
        'mnuAhorrosEstadoCuenta
        '
        Me.mnuAhorrosEstadoCuenta.Location = New System.Drawing.Point(40, 96)
        Me.mnuAhorrosEstadoCuenta.Name = "mnuAhorrosEstadoCuenta"
        Me.mnuAhorrosEstadoCuenta.Size = New System.Drawing.Size(296, 16)
        Me.mnuAhorrosEstadoCuenta.TabIndex = 3
        Me.mnuAhorrosEstadoCuenta.Text = "Estado de Cuenta"
        '
        'mnuAhorrosRealizarRetiros
        '
        Me.mnuAhorrosRealizarRetiros.Location = New System.Drawing.Point(40, 72)
        Me.mnuAhorrosRealizarRetiros.Name = "mnuAhorrosRealizarRetiros"
        Me.mnuAhorrosRealizarRetiros.Size = New System.Drawing.Size(296, 16)
        Me.mnuAhorrosRealizarRetiros.TabIndex = 2
        Me.mnuAhorrosRealizarRetiros.Text = "Realizar Retiro"
        '
        'mnuAhorrosNuevo
        '
        Me.mnuAhorrosNuevo.Location = New System.Drawing.Point(40, 48)
        Me.mnuAhorrosNuevo.Name = "mnuAhorrosNuevo"
        Me.mnuAhorrosNuevo.Size = New System.Drawing.Size(296, 16)
        Me.mnuAhorrosNuevo.TabIndex = 1
        Me.mnuAhorrosNuevo.Text = "Nuevo Ahorro"
        '
        'mnuAhorros
        '
        Me.mnuAhorros.Location = New System.Drawing.Point(24, 24)
        Me.mnuAhorros.Name = "mnuAhorros"
        Me.mnuAhorros.Size = New System.Drawing.Size(296, 16)
        Me.mnuAhorros.TabIndex = 0
        Me.mnuAhorros.Text = "Ahorros"
        '
        'tpCxC
        '
        Me.tpCxC.Controls.Add(Me.repCuentaPorCobrar)
        Me.tpCxC.Controls.Add(Me.repTodosClientes)
        Me.tpCxC.Controls.Add(Me.repCuentaPorCobrarIntes)
        Me.tpCxC.Controls.Add(Me.repCuentaPorCobrarCapital)
        Me.tpCxC.Controls.Add(Me.repCuentaPorCobrarCuotasFechas)
        Me.tpCxC.Controls.Add(Me.repNCCxC)
        Me.tpCxC.Controls.Add(Me.repNDCxC)
        Me.tpCxC.Controls.Add(Me.repEstadoCliente)
        Me.tpCxC.Controls.Add(Me.mnuConsultaCxCNC)
        Me.tpCxC.Controls.Add(Me.mnuCxCNC)
        Me.tpCxC.Controls.Add(Me.mnuCxCND)
        Me.tpCxC.Controls.Add(Me.mnuGeneraRecibos)
        Me.tpCxC.Controls.Add(Me.mnuCuentaPorCobrar)
        Me.tpCxC.Controls.Add(Me.repPrestamosSaldados)
        Me.tpCxC.Controls.Add(Me.repPrestamosPendientes)
        Me.tpCxC.Controls.Add(Me.repPrestamosEntregados)
        Me.tpCxC.Controls.Add(Me.mnuPrestamosNuevo)
        Me.tpCxC.Location = New System.Drawing.Point(4, 22)
        Me.tpCxC.Name = "tpCxC"
        Me.tpCxC.Size = New System.Drawing.Size(730, 398)
        Me.tpCxC.TabIndex = 5
        Me.tpCxC.Text = "Cuenta por Cobrar"
        '
        'repCuentaPorCobrar
        '
        Me.repCuentaPorCobrar.Location = New System.Drawing.Point(32, 192)
        Me.repCuentaPorCobrar.Name = "repCuentaPorCobrar"
        Me.repCuentaPorCobrar.Size = New System.Drawing.Size(288, 16)
        Me.repCuentaPorCobrar.TabIndex = 22
        Me.repCuentaPorCobrar.Text = "Cuentas por Cobrar "
        '
        'repTodosClientes
        '
        Me.repTodosClientes.Location = New System.Drawing.Point(32, 288)
        Me.repTodosClientes.Name = "repTodosClientes"
        Me.repTodosClientes.Size = New System.Drawing.Size(288, 16)
        Me.repTodosClientes.TabIndex = 26
        Me.repTodosClientes.Text = "Todos los Clientes"
        '
        'repCuentaPorCobrarIntes
        '
        Me.repCuentaPorCobrarIntes.Location = New System.Drawing.Point(32, 264)
        Me.repCuentaPorCobrarIntes.Name = "repCuentaPorCobrarIntes"
        Me.repCuentaPorCobrarIntes.Size = New System.Drawing.Size(288, 16)
        Me.repCuentaPorCobrarIntes.TabIndex = 25
        Me.repCuentaPorCobrarIntes.Text = "Cuentas por Cobrar Interes"
        '
        'repCuentaPorCobrarCapital
        '
        Me.repCuentaPorCobrarCapital.Location = New System.Drawing.Point(32, 240)
        Me.repCuentaPorCobrarCapital.Name = "repCuentaPorCobrarCapital"
        Me.repCuentaPorCobrarCapital.Size = New System.Drawing.Size(288, 16)
        Me.repCuentaPorCobrarCapital.TabIndex = 24
        Me.repCuentaPorCobrarCapital.Text = "Cuentas por Cobrar Cuotas Capital"
        '
        'repCuentaPorCobrarCuotasFechas
        '
        Me.repCuentaPorCobrarCuotasFechas.Location = New System.Drawing.Point(32, 216)
        Me.repCuentaPorCobrarCuotasFechas.Name = "repCuentaPorCobrarCuotasFechas"
        Me.repCuentaPorCobrarCuotasFechas.Size = New System.Drawing.Size(288, 16)
        Me.repCuentaPorCobrarCuotasFechas.TabIndex = 23
        Me.repCuentaPorCobrarCuotasFechas.Text = "Cuentas por Cobrar Cuotas Capital e Interes"
        '
        'repNCCxC
        '
        Me.repNCCxC.Location = New System.Drawing.Point(32, 168)
        Me.repNCCxC.Name = "repNCCxC"
        Me.repNCCxC.Size = New System.Drawing.Size(288, 16)
        Me.repNCCxC.TabIndex = 21
        Me.repNCCxC.Text = "Nota de crédito"
        '
        'repNDCxC
        '
        Me.repNDCxC.Location = New System.Drawing.Point(32, 144)
        Me.repNDCxC.Name = "repNDCxC"
        Me.repNDCxC.Size = New System.Drawing.Size(288, 16)
        Me.repNDCxC.TabIndex = 20
        Me.repNDCxC.Text = "Nota de débito"
        '
        'repEstadoCliente
        '
        Me.repEstadoCliente.Location = New System.Drawing.Point(32, 120)
        Me.repEstadoCliente.Name = "repEstadoCliente"
        Me.repEstadoCliente.Size = New System.Drawing.Size(288, 16)
        Me.repEstadoCliente.TabIndex = 19
        Me.repEstadoCliente.Text = "Estado de Cuenta Cliente"
        '
        'mnuConsultaCxCNC
        '
        Me.mnuConsultaCxCNC.Location = New System.Drawing.Point(32, 96)
        Me.mnuConsultaCxCNC.Name = "mnuConsultaCxCNC"
        Me.mnuConsultaCxCNC.Size = New System.Drawing.Size(288, 16)
        Me.mnuConsultaCxCNC.TabIndex = 18
        Me.mnuConsultaCxCNC.Text = "Consulta Nota de Crédito ( Todas )"
        '
        'mnuCxCNC
        '
        Me.mnuCxCNC.Location = New System.Drawing.Point(32, 72)
        Me.mnuCxCNC.Name = "mnuCxCNC"
        Me.mnuCxCNC.Size = New System.Drawing.Size(288, 16)
        Me.mnuCxCNC.TabIndex = 17
        Me.mnuCxCNC.Text = "Nota deCredito"
        '
        'mnuCxCND
        '
        Me.mnuCxCND.Location = New System.Drawing.Point(32, 48)
        Me.mnuCxCND.Name = "mnuCxCND"
        Me.mnuCxCND.Size = New System.Drawing.Size(288, 16)
        Me.mnuCxCND.TabIndex = 16
        Me.mnuCxCND.Text = "Nota de Debito"
        '
        'mnuGeneraRecibos
        '
        Me.mnuGeneraRecibos.Location = New System.Drawing.Point(400, 104)
        Me.mnuGeneraRecibos.Name = "mnuGeneraRecibos"
        Me.mnuGeneraRecibos.Size = New System.Drawing.Size(288, 16)
        Me.mnuGeneraRecibos.TabIndex = 15
        Me.mnuGeneraRecibos.Text = "Genera Recibo de Cobro (Semanal/Diario)"
        Me.mnuGeneraRecibos.Visible = False
        '
        'mnuCuentaPorCobrar
        '
        Me.mnuCuentaPorCobrar.Location = New System.Drawing.Point(16, 16)
        Me.mnuCuentaPorCobrar.Name = "mnuCuentaPorCobrar"
        Me.mnuCuentaPorCobrar.Size = New System.Drawing.Size(200, 16)
        Me.mnuCuentaPorCobrar.TabIndex = 14
        Me.mnuCuentaPorCobrar.Text = "Cuenta por Cobrar"
        '
        'repPrestamosSaldados
        '
        Me.repPrestamosSaldados.Location = New System.Drawing.Point(32, 352)
        Me.repPrestamosSaldados.Name = "repPrestamosSaldados"
        Me.repPrestamosSaldados.Size = New System.Drawing.Size(200, 16)
        Me.repPrestamosSaldados.TabIndex = 10
        Me.repPrestamosSaldados.Text = "Préstamos Saldados"
        '
        'repPrestamosPendientes
        '
        Me.repPrestamosPendientes.Location = New System.Drawing.Point(32, 336)
        Me.repPrestamosPendientes.Name = "repPrestamosPendientes"
        Me.repPrestamosPendientes.Size = New System.Drawing.Size(200, 16)
        Me.repPrestamosPendientes.TabIndex = 9
        Me.repPrestamosPendientes.Text = "Préstamos Pendientes"
        '
        'repPrestamosEntregados
        '
        Me.repPrestamosEntregados.Location = New System.Drawing.Point(32, 312)
        Me.repPrestamosEntregados.Name = "repPrestamosEntregados"
        Me.repPrestamosEntregados.Size = New System.Drawing.Size(200, 16)
        Me.repPrestamosEntregados.TabIndex = 8
        Me.repPrestamosEntregados.Text = "Préstamos entregados"
        '
        'mnuPrestamosNuevo
        '
        Me.mnuPrestamosNuevo.Location = New System.Drawing.Point(32, 32)
        Me.mnuPrestamosNuevo.Name = "mnuPrestamosNuevo"
        Me.mnuPrestamosNuevo.Size = New System.Drawing.Size(200, 16)
        Me.mnuPrestamosNuevo.TabIndex = 7
        Me.mnuPrestamosNuevo.Text = "Crear Préstamo"
        '
        'tpCxP
        '
        Me.tpCxP.Controls.Add(Me.repNCCuentaPorPagar)
        Me.tpCxP.Controls.Add(Me.repTodoProveedores)
        Me.tpCxP.Controls.Add(Me.repNDCuentaPorPagar)
        Me.tpCxP.Controls.Add(Me.repCuentaPorPagar)
        Me.tpCxP.Controls.Add(Me.repEstadoProveedor)
        Me.tpCxP.Controls.Add(Me.mnuCxPNC)
        Me.tpCxP.Controls.Add(Me.mnuCxPND)
        Me.tpCxP.Controls.Add(Me.mnuIngresosCajaCxP)
        Me.tpCxP.Controls.Add(Me.mnuCuentaPorPagar)
        Me.tpCxP.Location = New System.Drawing.Point(4, 22)
        Me.tpCxP.Name = "tpCxP"
        Me.tpCxP.Size = New System.Drawing.Size(730, 398)
        Me.tpCxP.TabIndex = 6
        Me.tpCxP.Text = "Cuenta por Pagar"
        '
        'repNCCuentaPorPagar
        '
        Me.repNCCuentaPorPagar.Location = New System.Drawing.Point(32, 176)
        Me.repNCCuentaPorPagar.Name = "repNCCuentaPorPagar"
        Me.repNCCuentaPorPagar.Size = New System.Drawing.Size(288, 16)
        Me.repNCCuentaPorPagar.TabIndex = 35
        Me.repNCCuentaPorPagar.Text = "Listado Nota de Crédito (Factura)"
        '
        'repTodoProveedores
        '
        Me.repTodoProveedores.Location = New System.Drawing.Point(32, 200)
        Me.repTodoProveedores.Name = "repTodoProveedores"
        Me.repTodoProveedores.Size = New System.Drawing.Size(288, 16)
        Me.repTodoProveedores.TabIndex = 36
        Me.repTodoProveedores.Text = "Todos los Proveedores"
        '
        'repNDCuentaPorPagar
        '
        Me.repNDCuentaPorPagar.Location = New System.Drawing.Point(32, 152)
        Me.repNDCuentaPorPagar.Name = "repNDCuentaPorPagar"
        Me.repNDCuentaPorPagar.Size = New System.Drawing.Size(288, 16)
        Me.repNDCuentaPorPagar.TabIndex = 34
        Me.repNDCuentaPorPagar.Text = "Nota de Débito"
        '
        'repCuentaPorPagar
        '
        Me.repCuentaPorPagar.Location = New System.Drawing.Point(32, 128)
        Me.repCuentaPorPagar.Name = "repCuentaPorPagar"
        Me.repCuentaPorPagar.Size = New System.Drawing.Size(288, 16)
        Me.repCuentaPorPagar.TabIndex = 33
        Me.repCuentaPorPagar.Text = "Cuentas por Pagar"
        '
        'repEstadoProveedor
        '
        Me.repEstadoProveedor.Location = New System.Drawing.Point(32, 104)
        Me.repEstadoProveedor.Name = "repEstadoProveedor"
        Me.repEstadoProveedor.Size = New System.Drawing.Size(288, 16)
        Me.repEstadoProveedor.TabIndex = 32
        Me.repEstadoProveedor.Text = "Estado de Cuenta Proveedor"
        '
        'mnuCxPNC
        '
        Me.mnuCxPNC.Location = New System.Drawing.Point(32, 80)
        Me.mnuCxPNC.Name = "mnuCxPNC"
        Me.mnuCxPNC.Size = New System.Drawing.Size(288, 16)
        Me.mnuCxPNC.TabIndex = 31
        Me.mnuCxPNC.Text = "Nota de Crédito (Factura)"
        '
        'mnuCxPND
        '
        Me.mnuCxPND.Location = New System.Drawing.Point(32, 56)
        Me.mnuCxPND.Name = "mnuCxPND"
        Me.mnuCxPND.Size = New System.Drawing.Size(288, 16)
        Me.mnuCxPND.TabIndex = 30
        Me.mnuCxPND.Text = "Nota de Débito (Pagos)"
        '
        'mnuIngresosCajaCxP
        '
        Me.mnuIngresosCajaCxP.Location = New System.Drawing.Point(408, 240)
        Me.mnuIngresosCajaCxP.Name = "mnuIngresosCajaCxP"
        Me.mnuIngresosCajaCxP.Size = New System.Drawing.Size(120, 16)
        Me.mnuIngresosCajaCxP.TabIndex = 29
        Me.mnuIngresosCajaCxP.Text = "Ingreso a Caja CxP"
        Me.mnuIngresosCajaCxP.Visible = False
        '
        'mnuProveedores
        '
        Me.mnuProveedores.Location = New System.Drawing.Point(32, 64)
        Me.mnuProveedores.Name = "mnuProveedores"
        Me.mnuProveedores.Size = New System.Drawing.Size(200, 16)
        Me.mnuProveedores.TabIndex = 28
        Me.mnuProveedores.Text = "Proveedores"
        '
        'mnuCuentaPorPagar
        '
        Me.mnuCuentaPorPagar.Location = New System.Drawing.Point(16, 16)
        Me.mnuCuentaPorPagar.Name = "mnuCuentaPorPagar"
        Me.mnuCuentaPorPagar.Size = New System.Drawing.Size(200, 16)
        Me.mnuCuentaPorPagar.TabIndex = 27
        Me.mnuCuentaPorPagar.Text = "Cuenta por Pagar"
        '
        'tpBarra
        '
        Me.tpBarra.Controls.Add(Me.b_nc_cxc)
        Me.tpBarra.Controls.Add(Me.b_ri)
        Me.tpBarra.Controls.Add(Me.b_nd_cxc)
        Me.tpBarra.Controls.Add(Me.b_prestasmos)
        Me.tpBarra.Controls.Add(Me.b_clientes)
        Me.tpBarra.Controls.Add(Me.ToolBar)
        Me.tpBarra.Location = New System.Drawing.Point(4, 22)
        Me.tpBarra.Name = "tpBarra"
        Me.tpBarra.Size = New System.Drawing.Size(730, 398)
        Me.tpBarra.TabIndex = 7
        Me.tpBarra.Text = "Barra de Herramienta"
        '
        'b_nc_cxc
        '
        Me.b_nc_cxc.Location = New System.Drawing.Point(32, 136)
        Me.b_nc_cxc.Name = "b_nc_cxc"
        Me.b_nc_cxc.Size = New System.Drawing.Size(288, 16)
        Me.b_nc_cxc.TabIndex = 38
        Me.b_nc_cxc.Text = "Nota de Crédito"
        '
        'b_ri
        '
        Me.b_ri.Location = New System.Drawing.Point(32, 112)
        Me.b_ri.Name = "b_ri"
        Me.b_ri.Size = New System.Drawing.Size(288, 16)
        Me.b_ri.TabIndex = 37
        Me.b_ri.Text = "Recibos Ingresos"
        '
        'b_nd_cxc
        '
        Me.b_nd_cxc.Location = New System.Drawing.Point(32, 88)
        Me.b_nd_cxc.Name = "b_nd_cxc"
        Me.b_nd_cxc.Size = New System.Drawing.Size(288, 16)
        Me.b_nd_cxc.TabIndex = 36
        Me.b_nd_cxc.Text = "Nota de Débito"
        '
        'b_prestasmos
        '
        Me.b_prestasmos.Location = New System.Drawing.Point(32, 64)
        Me.b_prestasmos.Name = "b_prestasmos"
        Me.b_prestasmos.Size = New System.Drawing.Size(288, 16)
        Me.b_prestasmos.TabIndex = 35
        Me.b_prestasmos.Text = "Préstamos"
        '
        'b_clientes
        '
        Me.b_clientes.Location = New System.Drawing.Point(32, 40)
        Me.b_clientes.Name = "b_clientes"
        Me.b_clientes.Size = New System.Drawing.Size(288, 16)
        Me.b_clientes.TabIndex = 34
        Me.b_clientes.Text = "Clientes"
        '
        'ToolBar
        '
        Me.ToolBar.Location = New System.Drawing.Point(16, 16)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.Size = New System.Drawing.Size(200, 16)
        Me.ToolBar.TabIndex = 33
        Me.ToolBar.Text = "Barra de Herramienta"
        '
        'cmbUsuarios
        '
        Me.cmbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUsuarios.Location = New System.Drawing.Point(8, 16)
        Me.cmbUsuarios.Name = "cmbUsuarios"
        Me.cmbUsuarios.Size = New System.Drawing.Size(344, 21)
        Me.cmbUsuarios.TabIndex = 1
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(656, 8)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(72, 56)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnVerPermisos
        '
        Me.btnVerPermisos.Image = CType(resources.GetObject("btnVerPermisos.Image"), System.Drawing.Image)
        Me.btnVerPermisos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnVerPermisos.Location = New System.Drawing.Point(560, 8)
        Me.btnVerPermisos.Name = "btnVerPermisos"
        Me.btnVerPermisos.Size = New System.Drawing.Size(96, 56)
        Me.btnVerPermisos.TabIndex = 3
        Me.btnVerPermisos.Text = "&Ver permisos"
        Me.btnVerPermisos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'FRM_PERMISO_ROLES
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(738, 491)
        Me.Controls.Add(Me.btnVerPermisos)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.cmbUsuarios)
        Me.Controls.Add(Me.TabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_PERMISO_ROLES"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Permisos de Usuarios"
        Me.TabControl.ResumeLayout(False)
        Me.tpArchivo.ResumeLayout(False)
        Me.tpMantenimiento.ResumeLayout(False)
        Me.tpBanco.ResumeLayout(False)
        Me.tpCaja.ResumeLayout(False)
        Me.tpAhorro.ResumeLayout(False)
        Me.tpCxC.ResumeLayout(False)
        Me.tpCxP.ResumeLayout(False)
        Me.tpBarra.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ActualizarPermisos()
        ActualizaPermisoArchivo()
        ActualizaPermisoMantenimiento()
        ActualizaPermisoBanco()
        ActualizaPermisoCaja()
        ActualizaPermisoPrestamos()
        ActualizaPermisoCxC()
        ActualizaPermisoCxP()
        ActualizaPermisoBarra()
        ActualizaPermisoAhorros()
    End Sub
    Private Sub BuscarPermisos()
        BuscarPermisoArchivo()
        BuscarPermisoMantenimiento()
        BuscarPermisoBanco()
        BuscarPermisoCaja()
        BuscarPermisoPrestamos()
        BuscarPermisoCxC()
        BuscarPermisoCxP()
        BuscarPermisoBarra()
        BuscarPermisoAhorros()
    End Sub
    Private Sub LlenarCmbUsuarios()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT fld_id AS ID, CONCAT(fld_FirstName,' ',fld_LastName) AS USUARIO FROM tbl_user  ORDER BY 2", conn)
        da.Fill(dt) 'UNION SELECT -1,'[SELECCIONE UN USUARIO]'

        cmbUsuarios.DataSource = dt
        cmbUsuarios.DisplayMember = "USUARIO"
        cmbUsuarios.ValueMember = "ID"

        da.Dispose()
        '
    End Sub


    '//---------------------------------------------------------------------------//
    Private Sub ActualizaPermisoArchivo()
        NON_QUERY("UPDATE tbl_userarchivo SET mnuPermisosUsuarios='" & mnuPermisosUsuarios.Checked & "', mnuArchivo = '" & mnuArchivo.Checked & "'  , mnuCambiarMiClave = '" & mnuCambiarMiClave.Checked & "'  , mnuCambiarUsuario = '" & mnuCambiarUsuario.Checked & "'  , mnuFormatoCheque = '" & mnuFormatoCheque.Checked & "' , mnuTimbrado = '" & mnuTimbrado.Checked & "' WHERE IDUsuario=" & cmbUsuarios.SelectedValue & "")
    End Sub
    Private Sub BuscarPermisoArchivo()
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT mnuPermisosUsuarios, mnuArchivo, mnuCambiarMiClave, mnuCambiarUsuario, mnuFormatoCheque, mnuTimbrado FROM tbl_userarchivo  WHERE IDUsuario=" & cmbUsuarios.SelectedValue & "", conn)
        da.Fill(ds, "tbl_userarchivo")

        For Each dr In ds.Tables(0).Rows
            mnuPermisosUsuarios.Checked = CBool(dr("mnuPermisosUsuarios"))
            mnuArchivo.Checked = CBool(dr("mnuArchivo"))
            mnuCambiarMiClave.Checked = CBool(dr("mnuCambiarMiClave"))
            mnuCambiarUsuario.Checked = CBool(dr("mnuCambiarUsuario"))
            mnuFormatoCheque.Checked = CBool(dr("mnuFormatoCheque"))
            mnuTimbrado.Checked = CBool(dr("mnuTimbrado"))
        Next
        ds.Dispose()
        da.Dispose()

    End Sub

    Private Sub ActualizaPermisoMantenimiento()
        NON_QUERY("UPDATE tbl_usermantenimiento SET mnuMantenimiento = '" & mnuMantenimiento.Checked & "', mnuCliente = '" & mnuCliente.Checked & "', mnuInmuebles = '" & mnuInmuebles.Checked & "', mnuUsuarioNuevo = '" & mnuUsuarioNuevo.Checked & "', mnuCobradores = '" & mnuCobradores.Checked & "', mnuZonas = '" & mnuZonas.Checked & "', mnuUrbanizaciones = '" & mnuUrbanizaciones.Checked & "', mnuCiudad = '" & mnuCiudad.Checked & "', mnuProvincias = '" & mnuProvincias.Checked & "' WHERE IDUsuario=" & cmbUsuarios.SelectedValue & "")
    End Sub
    Private Sub BuscarPermisoMantenimiento()
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT 	mnuMantenimiento, mnuCliente, mnuInmuebles, mnuUsuarioNuevo, mnuCobradores, mnuZonas, mnuUrbanizaciones, mnuCiudad, mnuProvincias FROM tbl_usermantenimiento WHERE IDUsuario=" & cmbUsuarios.SelectedValue & "", conn)
        da.Fill(ds, "tbl_userarchivo")

        For Each dr In ds.Tables(0).Rows
            mnuMantenimiento.Checked = CBool(dr("mnuMantenimiento"))
            mnuCliente.Checked = CBool(dr("mnuCliente"))
            mnuInmuebles.Checked = CBool(dr("mnuInmuebles"))
            mnuUsuarioNuevo.Checked = CBool(dr("mnuUsuarioNuevo"))
            mnuCobradores.Checked = CBool(dr("mnuCobradores"))
            mnuZonas.Checked = CBool(dr("mnuZonas"))
            mnuUrbanizaciones.Checked = CBool(dr("mnuUrbanizaciones"))
            mnuCiudad.Checked = CBool(dr("mnuCiudad"))
            mnuProvincias.Checked = CBool(dr("mnuProvincias"))
        Next
        ds.Dispose()
        da.Dispose()

    End Sub

    Private Sub ActualizaPermisoBanco()
        NON_QUERY("UPDATE tbl_userbanco SET mnuBanco = '" & mnuBanco.Checked & "', mnuMaestroBanco = '" & mnuMaestroBanco.Checked & "', mnuDiarioBanco = '" & mnuDiarioBanco.Checked & "', mnuDiarioBancoSolicitud = '" & mnuDiarioBancoSolicitud.Checked & "', mnuDiarioBancoCheque = '" & mnuDiarioBancoCheque.Checked & "', mnuDiarioBancoDeposito = '" & mnuDiarioBancoDeposito.Checked & "', mnuDiarioBancoND = '" & mnuDiarioBancoND.Checked & "', mnuDiarioBancoNC = '" & mnuDiarioBancoNC.Checked & "', mnuDiarioBancoCargosComisiones='" & mnuDiarioBancoCargosComisiones.Checked & "', mnuConciliacion = '" & mnuConciliacion.Checked & "', repEstadoBanco = '" & repEstadoBanco.Checked & "', repDepositos = '" & repDepositos.Checked & "', repCheques = '" & repCheques.Checked & "', repNCBanco = '" & repNCBanco.Checked & "', repNDBanco = '" & repNDBanco.Checked & "'  WHERE IDUsuario=" & cmbUsuarios.SelectedValue & "")
    End Sub
    Private Sub BuscarPermisoBanco()
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT 	mnuBanco, mnuMaestroBanco, mnuDiarioBanco, mnuDiarioBancoSolicitud, mnuDiarioBancoCheque, mnuDiarioBancoDeposito, mnuDiarioBancoND, mnuDiarioBancoNC, mnuDiarioBancoCargosComisiones, mnuConciliacion, repEstadoBanco, repDepositos, repCheques, repNCBanco, repNDBanco FROM tbl_userbanco WHERE IDUsuario=" & cmbUsuarios.SelectedValue & "", conn)
        da.Fill(ds, "tbl_userbanco")

        For Each dr In ds.Tables(0).Rows
            mnuBanco.Checked = CBool(dr("mnuBanco"))
            mnuMaestroBanco.Checked = CBool(dr("mnuMaestroBanco"))
            mnuDiarioBanco.Checked = CBool(dr("mnuDiarioBanco"))
            mnuDiarioBancoSolicitud.Checked = CBool(dr("mnuDiarioBancoSolicitud"))
            mnuDiarioBancoCheque.Checked = CBool(dr("mnuDiarioBancoCheque"))
            mnuDiarioBancoDeposito.Checked = CBool(dr("mnuDiarioBancoDeposito"))
            mnuDiarioBancoND.Checked = CBool(dr("mnuDiarioBancoND"))
            mnuDiarioBancoNC.Checked = CBool(dr("mnuDiarioBancoNC"))
            mnuDiarioBancoCargosComisiones.Checked = CBool(dr("mnuDiarioBancoCargosComisiones"))
            mnuConciliacion.Checked = CBool(dr("mnuConciliacion"))
            repEstadoBanco.Checked = CBool(dr("repEstadoBanco"))
            repDepositos.Checked = CBool(dr("repDepositos"))
            repCheques.Checked = CBool(dr("repCheques"))
            repNCBanco.Checked = CBool(dr("repNCBanco"))
            repNDBanco.Checked = CBool(dr("repNDBanco"))
        Next
        ds.Dispose()
        da.Dispose()

    End Sub

    Private Sub ActualizaPermisoCaja()
        NON_QUERY("UPDATE tbl_usercaja SET mnuCaja = '" & mnuCaja.Checked & "', mnuRecibosIngresos = '" & mnuRecibosIngresos.Checked & "', mnuOtrosIngresos = '" & mnuOtrosIngresos.Checked & "', mnuConsultaIngresos = '" & mnuConsultaIngresos.Checked & "', mnuEgresos = '" & mnuEgresos.Checked & "', mnuCuadreCaja = '" & mnuCuadreCaja.Checked & "', repRecibosIngresos = '" & repRecibosIngresos.Checked & "', repRecibosIngresosNulos = '" & repRecibosIngresosNulos.Checked & "', repEgresosCaja='" & repEgresosCaja.Checked & "' WHERE IDUsuario=" & cmbUsuarios.SelectedValue & "")
    End Sub
    Private Sub BuscarPermisoCaja()
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT mnuCaja, mnuRecibosIngresos, mnuOtrosIngresos, mnuConsultaIngresos, mnuEgresos, mnuCuadreCaja, repRecibosIngresos, repRecibosIngresosNulos, repEgresosCaja FROM tbl_usercaja WHERE IDUsuario=" & cmbUsuarios.SelectedValue & "", conn)
        da.Fill(ds, "tbl_userbanco")

        For Each dr In ds.Tables(0).Rows
            mnuCaja.Checked = CBool(dr("mnuCaja"))
            mnuRecibosIngresos.Checked = CBool(dr("mnuRecibosIngresos"))
            mnuOtrosIngresos.Checked = CBool(dr("mnuOtrosIngresos"))
            mnuConsultaIngresos.Checked = CBool(dr("mnuConsultaIngresos"))
            mnuEgresos.Checked = CBool(dr("mnuEgresos"))
            mnuCuadreCaja.Checked = CBool(dr("mnuCuadreCaja"))
            repRecibosIngresos.Checked = CBool(dr("repRecibosIngresos"))
            repRecibosIngresosNulos.Checked = CBool(dr("repRecibosIngresosNulos"))
            repEgresosCaja.Checked = CBool(dr("repEgresosCaja"))
        Next
        ds.Dispose()
        da.Dispose()

    End Sub

    Private Sub ActualizaPermisoPrestamos()
        NON_QUERY("UPDATE tbl_userprestamos SET mnuPrestamosNuevo = '" & mnuPrestamosNuevo.Checked & "', repPrestamosEntregados = '" & repPrestamosEntregados.Checked & "', repPrestamosPendientes = '" & repPrestamosPendientes.Checked & "', repPrestamosSaldados = '" & repPrestamosSaldados.Checked & "' WHERE IDUsuario=" & cmbUsuarios.SelectedValue & "")
    End Sub
    Private Sub BuscarPermisoPrestamos()
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT mnuPrestamos, mnuPrestamosNuevo, repPrestamosEntregados, repPrestamosPendientes, repPrestamosSaldados FROM tbl_userprestamos WHERE IDUsuario=" & cmbUsuarios.SelectedValue & "", conn)
        da.Fill(ds, "tbl_userprestamos")

        For Each dr In ds.Tables(0).Rows

            mnuPrestamosNuevo.Checked = CBool(dr("mnuPrestamosNuevo"))
            repPrestamosEntregados.Checked = CBool(dr("repPrestamosEntregados"))
            repPrestamosPendientes.Checked = CBool(dr("repPrestamosPendientes"))
            repPrestamosSaldados.Checked = CBool(dr("repPrestamosSaldados"))
        Next
        ds.Dispose()
        da.Dispose()

    End Sub

    Private Sub ActualizaPermisoCxC()
        NON_QUERY("UPDATE tbl_usercuentaporcobrar SET mnuCuentaPorCobrar = '" & mnuCuentaPorCobrar.Checked & "', mnuGeneraRecibos = '" & mnuGeneraRecibos.Checked & "', mnuCxCND = '" & mnuCxCND.Checked & "', mnuCxCNC = '" & mnuCxCNC.Checked & "', mnuConsultaCxCNC = '" & mnuConsultaCxCNC.Checked & "', repEstadoCliente = '" & repEstadoCliente.Checked & "', repNDCxC = '" & repNDCxC.Checked & "', repNCCxC = '" & repNCCxC.Checked & "', repCuentaPorCobrar='" & repCuentaPorCobrar.Checked & "', repCuentaPorCobrarCuotasFechas = '" & repCuentaPorCobrarCuotasFechas.Checked & "', repCuentaPorCobrarCapital = '" & repCuentaPorCobrarCapital.Checked & "', repCuentaPorCobrarIntes = '" & repCuentaPorCobrarIntes.Checked & "', repTodosClientes = '" & repTodosClientes.Checked & "' WHERE IDUsuario=" & cmbUsuarios.SelectedValue & "")
    End Sub
    Private Sub BuscarPermisoCxC()
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT mnuCuentaPorCobrar, mnuGeneraRecibos, mnuCxCND, mnuCxCNC, mnuConsultaCxCNC, repEstadoCliente, repNDCxC, repNCCxC, repCuentaPorCobrar, repCuentaPorCobrarCuotasFechas, repCuentaPorCobrarCapital, repCuentaPorCobrarIntes, repTodosClientes FROM tbl_usercuentaporcobrar WHERE IDUsuario=" & cmbUsuarios.SelectedValue & "", conn)
        da.Fill(ds, "tbl_usercuentaporcobrar")

        For Each dr In ds.Tables(0).Rows
            mnuCuentaPorCobrar.Checked = CBool(dr("mnuCuentaPorCobrar"))
            mnuGeneraRecibos.Checked = CBool(dr("mnuGeneraRecibos"))
            mnuCxCND.Checked = CBool(dr("mnuCxCND"))
            mnuCxCNC.Checked = CBool(dr("mnuCxCNC"))
            mnuConsultaCxCNC.Checked = CBool(dr("mnuConsultaCxCNC"))
            repEstadoCliente.Checked = CBool(dr("repEstadoCliente"))
            repNDCxC.Checked = CBool(dr("repNDCxC"))
            repNCCxC.Checked = CBool(dr("repNCCxC"))
            repCuentaPorCobrar.Checked = CBool(dr("repCuentaPorCobrar"))
            repCuentaPorCobrarCuotasFechas.Checked = CBool(dr("repCuentaPorCobrarCuotasFechas"))
            repCuentaPorCobrarCapital.Checked = CBool(dr("repCuentaPorCobrarCapital"))
            repCuentaPorCobrarIntes.Checked = CBool(dr("repCuentaPorCobrarIntes"))
            repTodosClientes.Checked = CBool(dr("repTodosClientes"))
        Next
        ds.Dispose()
        da.Dispose()

    End Sub

    Private Sub ActualizaPermisoCxP()
        NON_QUERY("UPDATE tbl_usercuentaporpagar SET mnuCuentaPorPagar = '" & mnuCuentaPorPagar.Checked & "', mnuProveedores = '" & mnuProveedores.Checked & "', mnuIngresosCajaCxP = '" & mnuIngresosCajaCxP.Checked & "', mnuCxPND = '" & mnuCxPND.Checked & "', mnuCxPNC = '" & mnuCxPNC.Checked & "', repEstadoProveedor = '" & repEstadoProveedor.Checked & "', repCuentaPorPagar = '" & repCuentaPorPagar.Checked & "', repNDCuentaPorPagar = '" & repNDCuentaPorPagar.Checked & "', repNCCuentaPorPagar='" & repNCCuentaPorPagar.Checked & "', repTodoProveedores = '" & repTodoProveedores.Checked & "' WHERE IDUsuario=" & cmbUsuarios.SelectedValue & "")
    End Sub
    Private Sub BuscarPermisoCxP()
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT mnuCuentaPorPagar, mnuProveedores, mnuIngresosCajaCxP, mnuCxPND, mnuCxPNC, repEstadoProveedor, repCuentaPorPagar, repNDCuentaPorPagar, repNCCuentaPorPagar, repTodoProveedores FROM tbl_usercuentaporpagar WHERE IDUsuario=" & cmbUsuarios.SelectedValue & "", conn)
        da.Fill(ds, "tbl_usercuentaporpagar")

        For Each dr In ds.Tables(0).Rows
            mnuCuentaPorPagar.Checked = CBool(dr("mnuCuentaPorPagar"))
            mnuProveedores.Checked = CBool(dr("mnuProveedores"))
            mnuIngresosCajaCxP.Checked = CBool(dr("mnuIngresosCajaCxP"))
            mnuCxPND.Checked = CBool(dr("mnuCxPND"))
            mnuCxPNC.Checked = CBool(dr("mnuCxPNC"))
            repEstadoProveedor.Checked = CBool(dr("repEstadoProveedor"))
            repCuentaPorPagar.Checked = CBool(dr("repCuentaPorPagar"))
            repNDCuentaPorPagar.Checked = CBool(dr("repNDCuentaPorPagar"))
            repNCCuentaPorPagar.Checked = CBool(dr("repNCCuentaPorPagar"))
            repTodoProveedores.Checked = CBool(dr("repTodoProveedores"))
           
        Next
        ds.Dispose()
        da.Dispose()

    End Sub

    Private Sub ActualizaPermisoBarra()
        NON_QUERY("UPDATE tbl_userbarraherramienta SET ToolBar = '" & ToolBar.Checked & "', b_clientes = '" & b_clientes.Checked & "', b_prestasmos = '" & b_prestasmos.Checked & "', b_nd_cxc = '" & b_nd_cxc.Checked & "', b_ri = '" & b_ri.Checked & "', b_nc_cxc = '" & b_nc_cxc.Checked & "' WHERE IDUsuario=" & cmbUsuarios.SelectedValue & "")
    End Sub
    Private Sub BuscarPermisoBarra()
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT ToolBar, b_clientes, b_prestasmos, b_nd_cxc, b_ri, b_nc_cxc FROM tbl_userbarraherramienta WHERE IDUsuario=" & cmbUsuarios.SelectedValue & "", conn)
        da.Fill(ds, "tbl_userbarraherramienta")

        For Each dr In ds.Tables(0).Rows
            ToolBar.Checked = CBool(dr("ToolBar"))
            b_clientes.Checked = CBool(dr("b_clientes"))
            b_prestasmos.Checked = CBool(dr("b_prestasmos"))
            b_nd_cxc.Checked = CBool(dr("b_nd_cxc"))
            b_ri.Checked = CBool(dr("b_ri"))
            b_nc_cxc.Checked = CBool(dr("b_nc_cxc"))
            

        Next
        ds.Dispose()
        da.Dispose()

    End Sub

    Private Sub ActualizaPermisoAhorros()
        NON_QUERY("UPDATE tbl_userahorros SET mnuAhorros = '" & mnuAhorros.Checked & "', mnuAhorrosNuevo = '" & mnuAhorrosNuevo.Checked & "', mnuAhorrosRealizarRetiros = '" & mnuAhorrosRealizarRetiros.Checked & "', mnuAhorrosEstadoCuenta = '" & mnuAhorrosEstadoCuenta.Checked & "', mnuAhorrosRetiros = '" & mnuAhorrosRetiros.Checked & "', mnuAhorrosSaldos = '" & mnuAhorrosSaldos.Checked & "' WHERE IDUsuario=" & cmbUsuarios.SelectedValue & "")
    End Sub
    Private Sub BuscarPermisoAhorros()
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT mnuAhorros, mnuAhorrosNuevo, mnuAhorrosRealizarRetiros, mnuAhorrosEstadoCuenta, mnuAhorrosRetiros, mnuAhorrosSaldos FROM tbl_userahorros WHERE IDUsuario=" & cmbUsuarios.SelectedValue & "", conn)
        da.Fill(ds, "tbl_userahorros")

        For Each dr In ds.Tables(0).Rows
            mnuAhorros.Checked = CBool(dr("mnuAhorros"))
            mnuAhorrosNuevo.Checked = CBool(dr("mnuAhorrosNuevo"))
            mnuAhorrosRealizarRetiros.Checked = CBool(dr("mnuAhorrosRealizarRetiros"))
            mnuAhorrosEstadoCuenta.Checked = CBool(dr("mnuAhorrosEstadoCuenta"))
            mnuAhorrosRetiros.Checked = CBool(dr("mnuAhorrosRetiros"))
            mnuAhorrosSaldos.Checked = CBool(dr("mnuAhorrosSaldos"))


        Next
        ds.Dispose()
        da.Dispose()

    End Sub



    Private Sub FRM_PERMISO_ROLES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        LlenarCmbUsuarios()
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        ActualizarPermisos()
        Me.Close()
    End Sub
    Private Sub btnVerPermisos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerPermisos.Click
        BuscarPermisos()
    End Sub

End Class
