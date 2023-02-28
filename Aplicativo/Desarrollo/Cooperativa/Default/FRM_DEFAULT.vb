Imports System.Management
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Public Class FRM_DEFAULT
    Inherits System.Windows.Forms.Form
    Dim PathBackup As String, id_doc_nulo As String, monto_doc_nulo As Double
    Friend WithEvents MnTipoDeCuentaSaldos As MenuItem
    Friend WithEvents MenuItem22 As MenuItem
    Friend WithEvents MnTodosLosSaldos As MenuItem
    Friend WithEvents MenuItem20 As MenuItem
    Friend WithEvents MenuItem21 As MenuItem
    Friend WithEvents MenuItem23 As MenuItem
    Friend WithEvents MenuItem24 As MenuItem
    Friend WithEvents MenuItem25 As MenuItem
    Friend WithEvents MenuItem26 As MenuItem
    Friend WithEvents MenuItem28 As MenuItem
    Friend WithEvents MenuItem29 As MenuItem
    Friend WithEvents MenuItem30 As MenuItem
    Friend WithEvents MenuItem31 As MenuItem
    Friend WithEvents MenuItem40 As MenuItem
    Friend WithEvents MenuItem39 As MenuItem
    Friend WithEvents MenuItem41 As MenuItem
    Friend WithEvents MenuItem45 As MenuItem
    Friend WithEvents MenuItem43 As MenuItem
    Friend WithEvents MenuItem46 As MenuItem
    Friend WithEvents MenuItem47 As MenuItem
    Friend WithEvents MenuItem48 As MenuItem
    Friend WithEvents MenuItem49 As MenuItem
    Friend WithEvents MenuItem50 As MenuItem
    Friend WithEvents MenuItem51 As MenuItem
    Friend WithEvents MnuPar_Saldo_Por_Antiguedad As MenuItem
    Friend WithEvents MenuItem53 As MenuItem
    Friend WithEvents MenuItem54 As MenuItem
    Friend WithEvents MnuActualiarLibretas As MenuItem
    Friend WithEvents MenuItem11 As MenuItem
    '/INI FILE

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        Me.GlobalForm = Me
        DataBaseName = objIniFile.GetString("COMPANY", "DataBase", "(none)")
        ServerName = objIniFile.GetString("COMPANY", "ServerName", "(none)")
        ServerPort = objIniFile.GetString("COMPANY", "ServerPort", "(none)")
        conn = MySQLConn(ServerName, DataBaseName, ServerPort, "randy", "dayelcris")
        If FRMS_LOGIN() = False Then
            End
        End If

        LeerPermisos()

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
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents StatusBar As System.Windows.Forms.StatusBar
    Friend WithEvents Puesto As System.Windows.Forms.StatusBarPanel
    Friend WithEvents fecha As System.Windows.Forms.StatusBarPanel
    Friend WithEvents User1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Archivo_Salir As System.Windows.Forms.MenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuItem108 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem109 As System.Windows.Forms.MenuItem
    Friend WithEvents b_clientes As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents b_prestasmos As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents b_nd_cxc As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton6 As System.Windows.Forms.ToolBarButton
    Friend WithEvents b_nc_cxc As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents b_ri As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents b_salir As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton7 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem88 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem99 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem100 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem101 As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMantenimiento As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCliente As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInmuebles As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCobradores As System.Windows.Forms.MenuItem
    Friend WithEvents mnuZonas As System.Windows.Forms.MenuItem
    Friend WithEvents mnuUrbanizaciones As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCiudad As System.Windows.Forms.MenuItem
    Friend WithEvents mnuProvincias As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBanco As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMaestroBanco As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDiarioBanco As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDiarioBancoSolicitud As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDiarioBancoCheque As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDiarioBancoDeposito As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDiarioBancoND As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDiarioBancoNC As System.Windows.Forms.MenuItem
    Friend WithEvents mnuConciliacion As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCaja As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRecibosIngresos As System.Windows.Forms.MenuItem
    Friend WithEvents mnuOtrosIngresos As System.Windows.Forms.MenuItem
    Friend WithEvents mnuConsultaIngresos As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEgresos As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCuadreCaja As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPrestamosNuevo As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCuentaPorCobrar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuGeneraRecibos As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCxCND As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCxCNC As System.Windows.Forms.MenuItem
    Friend WithEvents mnuConsultaCxCNC As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCuentaPorPagar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuProveedores As System.Windows.Forms.MenuItem
    Friend WithEvents mnuIngresosCajaCxP As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCxPND As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCxPNC As System.Windows.Forms.MenuItem
    Friend WithEvents repEstadoBanco As System.Windows.Forms.MenuItem
    Friend WithEvents repDepositos As System.Windows.Forms.MenuItem
    Friend WithEvents repCheques As System.Windows.Forms.MenuItem
    Friend WithEvents repNCBanco As System.Windows.Forms.MenuItem
    Friend WithEvents repNDBanco As System.Windows.Forms.MenuItem
    Friend WithEvents repRecibosIngresos As System.Windows.Forms.MenuItem
    Friend WithEvents repRecibosIngresosNulos As System.Windows.Forms.MenuItem
    Friend WithEvents repEgresosCaja As System.Windows.Forms.MenuItem
    Friend WithEvents repPrestamosEntregados As System.Windows.Forms.MenuItem
    Friend WithEvents repPrestamosPendientes As System.Windows.Forms.MenuItem
    Friend WithEvents repPrestamosSaldados As System.Windows.Forms.MenuItem
    Friend WithEvents repEstadoCliente As System.Windows.Forms.MenuItem
    Friend WithEvents repNDCxC As System.Windows.Forms.MenuItem
    Friend WithEvents repNCCxC As System.Windows.Forms.MenuItem
    Friend WithEvents repCuentaPorCobrar As System.Windows.Forms.MenuItem
    Friend WithEvents repCuentaPorCobrarCuotasFechas As System.Windows.Forms.MenuItem
    Friend WithEvents repCuentaPorCobrarCapital As System.Windows.Forms.MenuItem
    Friend WithEvents repCuentaPorCobrarIntes As System.Windows.Forms.MenuItem
    Friend WithEvents repTodosClientes As System.Windows.Forms.MenuItem
    Friend WithEvents repEstadoProveedor As System.Windows.Forms.MenuItem
    Friend WithEvents repCuentaPorPagar As System.Windows.Forms.MenuItem
    Friend WithEvents repNDCuentaPorPagar As System.Windows.Forms.MenuItem
    Friend WithEvents repNCCuentaPorPagar As System.Windows.Forms.MenuItem
    Friend WithEvents repTodoProveedores As System.Windows.Forms.MenuItem
    Friend WithEvents mnuUsuarioNuevo As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCambiarMiClave As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCambiarUsuario As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFormatoCheque As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTimbrado As System.Windows.Forms.MenuItem
    Friend WithEvents mnuArchivo As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBar As System.Windows.Forms.ToolBar
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPermisosUsuarios As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDiarioBancoCargosComisiones As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCategoriaAhorro As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAhorros As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents menuTipoDocCliente As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuIngresosDevengados As System.Windows.Forms.MenuItem
    Friend WithEvents mnuActualizarInteres As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuContabilidad As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCatalogoCuenta As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMaestroDeTransacciones As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEntradaDeDiario As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEntradaDeDiarioNueva As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEntradaDeDiarioConsultar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBalanceComprobacionResumido As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBalanceComprobacionDetallado As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBalanceGeneral As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEstadoDeResultado As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLibroMayorGeneral As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLibroDiarioGeneral As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLitadoCatalogoDeCuenta As System.Windows.Forms.MenuItem
    Friend WithEvents mnuConfiguracionContabilidad As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAhorrosNuevo As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAhorrosRealizarRetiros As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAhorrosEstadoCuenta As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAhorrosRetiros As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAhorrosSaldos As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents b_foto_cliente As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuAhorrosCertificados As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAhorrosCertificadosApertura As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAhorrosCertificadosCancelacion As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCajaMentenimiento As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAhorroAporteSocio As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAhorrosListadoAportes As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAhorrosCertificadosListado As System.Windows.Forms.MenuItem
    Friend WithEvents repOtrosIngresos As System.Windows.Forms.MenuItem
    Friend WithEvents mnuConfiguracionGeneral As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPrestamosTabla As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSolicitudCredito As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAhorrosListadoAportesUnSocio As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAhorrosListadoAportesTodosLosSocios As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_DEFAULT))
        Me.MainMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuArchivo = New System.Windows.Forms.MenuItem()
        Me.mnuActualizarInteres = New System.Windows.Forms.MenuItem()
        Me.MenuItem46 = New System.Windows.Forms.MenuItem()
        Me.mnuPermisosUsuarios = New System.Windows.Forms.MenuItem()
        Me.MenuItem47 = New System.Windows.Forms.MenuItem()
        Me.mnuCambiarMiClave = New System.Windows.Forms.MenuItem()
        Me.MenuItem48 = New System.Windows.Forms.MenuItem()
        Me.mnuCambiarUsuario = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.mnuFormatoCheque = New System.Windows.Forms.MenuItem()
        Me.MenuItem49 = New System.Windows.Forms.MenuItem()
        Me.mnuTimbrado = New System.Windows.Forms.MenuItem()
        Me.MenuItem50 = New System.Windows.Forms.MenuItem()
        Me.mnuConfiguracionContabilidad = New System.Windows.Forms.MenuItem()
        Me.MenuItem51 = New System.Windows.Forms.MenuItem()
        Me.mnuConfiguracionGeneral = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MnuPar_Saldo_Por_Antiguedad = New System.Windows.Forms.MenuItem()
        Me.MenuItem53 = New System.Windows.Forms.MenuItem()
        Me.Archivo_Salir = New System.Windows.Forms.MenuItem()
        Me.mnuMantenimiento = New System.Windows.Forms.MenuItem()
        Me.mnuUsuarioNuevo = New System.Windows.Forms.MenuItem()
        Me.MenuItem88 = New System.Windows.Forms.MenuItem()
        Me.mnuCajaMentenimiento = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.menuTipoDocCliente = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.mnuCliente = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.mnuProveedores = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.mnuInmuebles = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.mnuCobradores = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.mnuZonas = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.mnuProvincias = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.mnuCiudad = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.mnuUrbanizaciones = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.mnuCategoriaAhorro = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem40 = New System.Windows.Forms.MenuItem()
        Me.MenuItem39 = New System.Windows.Forms.MenuItem()
        Me.MenuItem45 = New System.Windows.Forms.MenuItem()
        Me.MenuItem43 = New System.Windows.Forms.MenuItem()
        Me.MenuItem54 = New System.Windows.Forms.MenuItem()
        Me.MnuActualiarLibretas = New System.Windows.Forms.MenuItem()
        Me.mnuContabilidad = New System.Windows.Forms.MenuItem()
        Me.mnuCatalogoCuenta = New System.Windows.Forms.MenuItem()
        Me.mnuMaestroDeTransacciones = New System.Windows.Forms.MenuItem()
        Me.mnuEntradaDeDiario = New System.Windows.Forms.MenuItem()
        Me.mnuEntradaDeDiarioNueva = New System.Windows.Forms.MenuItem()
        Me.mnuEntradaDeDiarioConsultar = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.MenuItem36 = New System.Windows.Forms.MenuItem()
        Me.MenuItem37 = New System.Windows.Forms.MenuItem()
        Me.mnuBalanceComprobacionResumido = New System.Windows.Forms.MenuItem()
        Me.mnuBalanceComprobacionDetallado = New System.Windows.Forms.MenuItem()
        Me.mnuBalanceGeneral = New System.Windows.Forms.MenuItem()
        Me.mnuEstadoDeResultado = New System.Windows.Forms.MenuItem()
        Me.MenuItem44 = New System.Windows.Forms.MenuItem()
        Me.mnuLibroMayorGeneral = New System.Windows.Forms.MenuItem()
        Me.mnuLibroDiarioGeneral = New System.Windows.Forms.MenuItem()
        Me.mnuLitadoCatalogoDeCuenta = New System.Windows.Forms.MenuItem()
        Me.mnuBanco = New System.Windows.Forms.MenuItem()
        Me.mnuMaestroBanco = New System.Windows.Forms.MenuItem()
        Me.mnuDiarioBanco = New System.Windows.Forms.MenuItem()
        Me.mnuDiarioBancoSolicitud = New System.Windows.Forms.MenuItem()
        Me.mnuDiarioBancoCheque = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.mnuDiarioBancoDeposito = New System.Windows.Forms.MenuItem()
        Me.mnuDiarioBancoND = New System.Windows.Forms.MenuItem()
        Me.mnuDiarioBancoNC = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.mnuDiarioBancoCargosComisiones = New System.Windows.Forms.MenuItem()
        Me.mnuConciliacion = New System.Windows.Forms.MenuItem()
        Me.MenuItem33 = New System.Windows.Forms.MenuItem()
        Me.MenuItem34 = New System.Windows.Forms.MenuItem()
        Me.MenuItem35 = New System.Windows.Forms.MenuItem()
        Me.repEstadoBanco = New System.Windows.Forms.MenuItem()
        Me.repDepositos = New System.Windows.Forms.MenuItem()
        Me.repCheques = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.repNCBanco = New System.Windows.Forms.MenuItem()
        Me.repNDBanco = New System.Windows.Forms.MenuItem()
        Me.mnuCaja = New System.Windows.Forms.MenuItem()
        Me.mnuRecibosIngresos = New System.Windows.Forms.MenuItem()
        Me.mnuOtrosIngresos = New System.Windows.Forms.MenuItem()
        Me.mnuConsultaIngresos = New System.Windows.Forms.MenuItem()
        Me.mnuEgresos = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.mnuCuadreCaja = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.repRecibosIngresos = New System.Windows.Forms.MenuItem()
        Me.mnuIngresosDevengados = New System.Windows.Forms.MenuItem()
        Me.repRecibosIngresosNulos = New System.Windows.Forms.MenuItem()
        Me.repEgresosCaja = New System.Windows.Forms.MenuItem()
        Me.repOtrosIngresos = New System.Windows.Forms.MenuItem()
        Me.mnuAhorros = New System.Windows.Forms.MenuItem()
        Me.mnuAhorrosNuevo = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.mnuAhorrosRealizarRetiros = New System.Windows.Forms.MenuItem()
        Me.mnuAhorroAporteSocio = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.mnuAhorrosCertificados = New System.Windows.Forms.MenuItem()
        Me.mnuAhorrosCertificadosApertura = New System.Windows.Forms.MenuItem()
        Me.mnuAhorrosCertificadosCancelacion = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.mnuAhorrosCertificadosListado = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.mnuAhorrosEstadoCuenta = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.mnuAhorrosRetiros = New System.Windows.Forms.MenuItem()
        Me.mnuAhorrosSaldos = New System.Windows.Forms.MenuItem()
        Me.MnTipoDeCuentaSaldos = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MnTodosLosSaldos = New System.Windows.Forms.MenuItem()
        Me.mnuAhorrosListadoAportes = New System.Windows.Forms.MenuItem()
        Me.mnuAhorrosListadoAportesUnSocio = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.mnuAhorrosListadoAportesTodosLosSocios = New System.Windows.Forms.MenuItem()
        Me.mnuCuentaPorCobrar = New System.Windows.Forms.MenuItem()
        Me.mnuPrestamosNuevo = New System.Windows.Forms.MenuItem()
        Me.mnuGeneraRecibos = New System.Windows.Forms.MenuItem()
        Me.mnuPrestamosTabla = New System.Windows.Forms.MenuItem()
        Me.mnuSolicitudCredito = New System.Windows.Forms.MenuItem()
        Me.MenuItem42 = New System.Windows.Forms.MenuItem()
        Me.mnuCxCND = New System.Windows.Forms.MenuItem()
        Me.mnuCxCNC = New System.Windows.Forms.MenuItem()
        Me.mnuConsultaCxCNC = New System.Windows.Forms.MenuItem()
        Me.MenuItem38 = New System.Windows.Forms.MenuItem()
        Me.MenuItem108 = New System.Windows.Forms.MenuItem()
        Me.MenuItem109 = New System.Windows.Forms.MenuItem()
        Me.repEstadoCliente = New System.Windows.Forms.MenuItem()
        Me.repNDCxC = New System.Windows.Forms.MenuItem()
        Me.repNCCxC = New System.Windows.Forms.MenuItem()
        Me.repCuentaPorCobrar = New System.Windows.Forms.MenuItem()
        Me.repCuentaPorCobrarCuotasFechas = New System.Windows.Forms.MenuItem()
        Me.repCuentaPorCobrarCapital = New System.Windows.Forms.MenuItem()
        Me.repCuentaPorCobrarIntes = New System.Windows.Forms.MenuItem()
        Me.MenuItem41 = New System.Windows.Forms.MenuItem()
        Me.repTodosClientes = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.repPrestamosEntregados = New System.Windows.Forms.MenuItem()
        Me.repPrestamosPendientes = New System.Windows.Forms.MenuItem()
        Me.repPrestamosSaldados = New System.Windows.Forms.MenuItem()
        Me.mnuCuentaPorPagar = New System.Windows.Forms.MenuItem()
        Me.mnuIngresosCajaCxP = New System.Windows.Forms.MenuItem()
        Me.mnuCxPND = New System.Windows.Forms.MenuItem()
        Me.mnuCxPNC = New System.Windows.Forms.MenuItem()
        Me.MenuItem99 = New System.Windows.Forms.MenuItem()
        Me.MenuItem100 = New System.Windows.Forms.MenuItem()
        Me.MenuItem101 = New System.Windows.Forms.MenuItem()
        Me.repEstadoProveedor = New System.Windows.Forms.MenuItem()
        Me.repCuentaPorPagar = New System.Windows.Forms.MenuItem()
        Me.repNDCuentaPorPagar = New System.Windows.Forms.MenuItem()
        Me.repNCCuentaPorPagar = New System.Windows.Forms.MenuItem()
        Me.repTodoProveedores = New System.Windows.Forms.MenuItem()
        Me.StatusBar = New System.Windows.Forms.StatusBar()
        Me.User1 = New System.Windows.Forms.StatusBarPanel()
        Me.Puesto = New System.Windows.Forms.StatusBarPanel()
        Me.fecha = New System.Windows.Forms.StatusBarPanel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolBar = New System.Windows.Forms.ToolBar()
        Me.b_clientes = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton()
        Me.b_prestasmos = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton()
        Me.b_nd_cxc = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton6 = New System.Windows.Forms.ToolBarButton()
        Me.b_ri = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton()
        Me.b_nc_cxc = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton()
        Me.b_foto_cliente = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton5 = New System.Windows.Forms.ToolBarButton()
        Me.b_salir = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton7 = New System.Windows.Forms.ToolBarButton()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.User1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Puesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuArchivo, Me.mnuMantenimiento, Me.mnuContabilidad, Me.mnuBanco, Me.mnuCaja, Me.mnuAhorros, Me.mnuCuentaPorCobrar, Me.mnuCuentaPorPagar})
        '
        'mnuArchivo
        '
        Me.mnuArchivo.Index = 0
        Me.mnuArchivo.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuActualizarInteres, Me.MenuItem46, Me.mnuPermisosUsuarios, Me.MenuItem47, Me.mnuCambiarMiClave, Me.MenuItem48, Me.mnuCambiarUsuario, Me.MenuItem3, Me.mnuFormatoCheque, Me.MenuItem49, Me.mnuTimbrado, Me.MenuItem50, Me.mnuConfiguracionContabilidad, Me.MenuItem51, Me.mnuConfiguracionGeneral, Me.MenuItem2, Me.MnuPar_Saldo_Por_Antiguedad, Me.MenuItem53, Me.Archivo_Salir})
        Me.mnuArchivo.Text = "&Archivo"
        '
        'mnuActualizarInteres
        '
        Me.mnuActualizarInteres.Index = 0
        Me.mnuActualizarInteres.Text = "Actualizar Intereses "
        '
        'MenuItem46
        '
        Me.MenuItem46.Index = 1
        Me.MenuItem46.Text = "-"
        '
        'mnuPermisosUsuarios
        '
        Me.mnuPermisosUsuarios.Index = 2
        Me.mnuPermisosUsuarios.Text = "&Permisos de Usuarios"
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = 3
        Me.MenuItem47.Text = "-"
        '
        'mnuCambiarMiClave
        '
        Me.mnuCambiarMiClave.Index = 4
        Me.mnuCambiarMiClave.Text = "Cambiar mi &Clave"
        '
        'MenuItem48
        '
        Me.MenuItem48.Index = 5
        Me.MenuItem48.Text = "-"
        '
        'mnuCambiarUsuario
        '
        Me.mnuCambiarUsuario.Index = 6
        Me.mnuCambiarUsuario.Text = "Cambiar &Usuario"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 7
        Me.MenuItem3.Text = "-"
        '
        'mnuFormatoCheque
        '
        Me.mnuFormatoCheque.Index = 8
        Me.mnuFormatoCheque.Text = "&Formato de Cheques"
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = 9
        Me.MenuItem49.Text = "-"
        '
        'mnuTimbrado
        '
        Me.mnuTimbrado.Index = 10
        Me.mnuTimbrado.Text = "&Timbrado"
        '
        'MenuItem50
        '
        Me.MenuItem50.Index = 11
        Me.MenuItem50.Text = "-"
        '
        'mnuConfiguracionContabilidad
        '
        Me.mnuConfiguracionContabilidad.Index = 12
        Me.mnuConfiguracionContabilidad.Text = "&Configuración de Contabilidad"
        '
        'MenuItem51
        '
        Me.MenuItem51.Index = 13
        Me.MenuItem51.Text = "-"
        '
        'mnuConfiguracionGeneral
        '
        Me.mnuConfiguracionGeneral.Index = 14
        Me.mnuConfiguracionGeneral.Text = "Configuración General"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 15
        Me.MenuItem2.Text = "-"
        '
        'MnuPar_Saldo_Por_Antiguedad
        '
        Me.MnuPar_Saldo_Por_Antiguedad.Index = 16
        Me.MnuPar_Saldo_Por_Antiguedad.Text = "Configuración Saldo Por Antiguedad"
        '
        'MenuItem53
        '
        Me.MenuItem53.Index = 17
        Me.MenuItem53.Text = "-"
        '
        'Archivo_Salir
        '
        Me.Archivo_Salir.Index = 18
        Me.Archivo_Salir.Shortcut = System.Windows.Forms.Shortcut.AltF4
        Me.Archivo_Salir.Text = "S&alir"
        '
        'mnuMantenimiento
        '
        Me.mnuMantenimiento.Index = 1
        Me.mnuMantenimiento.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuUsuarioNuevo, Me.MenuItem88, Me.mnuCajaMentenimiento, Me.MenuItem20, Me.menuTipoDocCliente, Me.MenuItem21, Me.mnuCliente, Me.MenuItem23, Me.mnuProveedores, Me.MenuItem24, Me.mnuInmuebles, Me.MenuItem25, Me.mnuCobradores, Me.MenuItem26, Me.mnuZonas, Me.MenuItem28, Me.mnuProvincias, Me.MenuItem29, Me.mnuCiudad, Me.MenuItem30, Me.mnuUrbanizaciones, Me.MenuItem4, Me.mnuCategoriaAhorro, Me.MenuItem31, Me.MenuItem6, Me.MenuItem40, Me.MenuItem39, Me.MenuItem45, Me.MenuItem43, Me.MenuItem54, Me.MnuActualiarLibretas})
        Me.mnuMantenimiento.Text = "&Mantenimiento"
        '
        'mnuUsuarioNuevo
        '
        Me.mnuUsuarioNuevo.Index = 0
        Me.mnuUsuarioNuevo.Text = "&Usuarios"
        '
        'MenuItem88
        '
        Me.MenuItem88.Index = 1
        Me.MenuItem88.Text = "-"
        '
        'mnuCajaMentenimiento
        '
        Me.mnuCajaMentenimiento.Index = 2
        Me.mnuCajaMentenimiento.Text = "Caja"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 3
        Me.MenuItem20.Text = "-"
        '
        'menuTipoDocCliente
        '
        Me.menuTipoDocCliente.Index = 4
        Me.menuTipoDocCliente.Text = "Tipos de Doc. de Identidad"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 5
        Me.MenuItem21.Text = "-"
        '
        'mnuCliente
        '
        Me.mnuCliente.Index = 6
        Me.mnuCliente.Text = "Socios"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 7
        Me.MenuItem23.Text = "-"
        '
        'mnuProveedores
        '
        Me.mnuProveedores.Index = 8
        Me.mnuProveedores.Text = "Proveedor"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 9
        Me.MenuItem24.Text = "-"
        '
        'mnuInmuebles
        '
        Me.mnuInmuebles.Index = 10
        Me.mnuInmuebles.Text = "&Inmuebles"
        Me.mnuInmuebles.Visible = False
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 11
        Me.MenuItem25.Text = "-"
        '
        'mnuCobradores
        '
        Me.mnuCobradores.Index = 12
        Me.mnuCobradores.Text = "C&obradores"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 13
        Me.MenuItem26.Text = "-"
        '
        'mnuZonas
        '
        Me.mnuZonas.Index = 14
        Me.mnuZonas.Text = "Car&tera"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 15
        Me.MenuItem28.Text = "-"
        '
        'mnuProvincias
        '
        Me.mnuProvincias.Index = 16
        Me.mnuProvincias.Text = "&Provincias"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 17
        Me.MenuItem29.Text = "-"
        '
        'mnuCiudad
        '
        Me.mnuCiudad.Index = 18
        Me.mnuCiudad.Text = "&Ciudades"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 19
        Me.MenuItem30.Text = "-"
        '
        'mnuUrbanizaciones
        '
        Me.mnuUrbanizaciones.Index = 20
        Me.mnuUrbanizaciones.Text = "&Sector"
        '
        'MenuItem4
        '
        Me.MenuItem4.Enabled = False
        Me.MenuItem4.Index = 21
        Me.MenuItem4.Text = "-"
        '
        'mnuCategoriaAhorro
        '
        Me.mnuCategoriaAhorro.Index = 22
        Me.mnuCategoriaAhorro.Text = "C&ategorías de Certificados"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 23
        Me.MenuItem31.Text = "-"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 24
        Me.MenuItem6.Text = "&Prefijos de Certificados"
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = 25
        Me.MenuItem40.Text = "-"
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 26
        Me.MenuItem39.Text = "Crear Anulaciones"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 27
        Me.MenuItem45.Text = "-"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 28
        Me.MenuItem43.Text = "Parametros Saldos X Antiguedad"
        '
        'MenuItem54
        '
        Me.MenuItem54.Index = 29
        Me.MenuItem54.Text = "-"
        '
        'MnuActualiarLibretas
        '
        Me.MnuActualiarLibretas.Index = 30
        Me.MnuActualiarLibretas.Text = "Impresion de Libretas"
        '
        'mnuContabilidad
        '
        Me.mnuContabilidad.Index = 2
        Me.mnuContabilidad.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuCatalogoCuenta, Me.mnuMaestroDeTransacciones, Me.mnuEntradaDeDiario, Me.MenuItem32, Me.MenuItem36, Me.MenuItem37, Me.mnuBalanceComprobacionResumido, Me.mnuBalanceComprobacionDetallado, Me.mnuBalanceGeneral, Me.mnuEstadoDeResultado, Me.MenuItem44, Me.mnuLibroMayorGeneral, Me.mnuLibroDiarioGeneral, Me.mnuLitadoCatalogoDeCuenta})
        Me.mnuContabilidad.Text = "C&ontabilidad"
        '
        'mnuCatalogoCuenta
        '
        Me.mnuCatalogoCuenta.Index = 0
        Me.mnuCatalogoCuenta.Text = "Catalogo de cuentas"
        '
        'mnuMaestroDeTransacciones
        '
        Me.mnuMaestroDeTransacciones.Index = 1
        Me.mnuMaestroDeTransacciones.Text = "Maestro de transacciones"
        '
        'mnuEntradaDeDiario
        '
        Me.mnuEntradaDeDiario.Index = 2
        Me.mnuEntradaDeDiario.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuEntradaDeDiarioNueva, Me.mnuEntradaDeDiarioConsultar})
        Me.mnuEntradaDeDiario.Text = "Entrada de diario"
        '
        'mnuEntradaDeDiarioNueva
        '
        Me.mnuEntradaDeDiarioNueva.Index = 0
        Me.mnuEntradaDeDiarioNueva.Text = "Nueva Transacción"
        '
        'mnuEntradaDeDiarioConsultar
        '
        Me.mnuEntradaDeDiarioConsultar.Index = 1
        Me.mnuEntradaDeDiarioConsultar.Text = "Consulta, Reimprime"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 3
        Me.MenuItem32.Text = "-"
        '
        'MenuItem36
        '
        Me.MenuItem36.Checked = True
        Me.MenuItem36.Index = 4
        Me.MenuItem36.Text = "<< Reportes Generales >>"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 5
        Me.MenuItem37.Text = "-"
        '
        'mnuBalanceComprobacionResumido
        '
        Me.mnuBalanceComprobacionResumido.Index = 6
        Me.mnuBalanceComprobacionResumido.Text = "Balance Comprobación"
        '
        'mnuBalanceComprobacionDetallado
        '
        Me.mnuBalanceComprobacionDetallado.Index = 7
        Me.mnuBalanceComprobacionDetallado.Text = "Balance Comprobación Detallado"
        Me.mnuBalanceComprobacionDetallado.Visible = False
        '
        'mnuBalanceGeneral
        '
        Me.mnuBalanceGeneral.Index = 8
        Me.mnuBalanceGeneral.Text = "Estado de Situación"
        '
        'mnuEstadoDeResultado
        '
        Me.mnuEstadoDeResultado.Index = 9
        Me.mnuEstadoDeResultado.Text = "Estado de Resultado"
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 10
        Me.MenuItem44.Text = "-"
        '
        'mnuLibroMayorGeneral
        '
        Me.mnuLibroMayorGeneral.Index = 11
        Me.mnuLibroMayorGeneral.Text = "Libro mayor general"
        '
        'mnuLibroDiarioGeneral
        '
        Me.mnuLibroDiarioGeneral.Index = 12
        Me.mnuLibroDiarioGeneral.Text = "Libro diario general"
        '
        'mnuLitadoCatalogoDeCuenta
        '
        Me.mnuLitadoCatalogoDeCuenta.Index = 13
        Me.mnuLitadoCatalogoDeCuenta.Text = "Listado Catalogo de cuenta"
        '
        'mnuBanco
        '
        Me.mnuBanco.Index = 3
        Me.mnuBanco.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMaestroBanco, Me.mnuDiarioBanco, Me.mnuConciliacion, Me.MenuItem33, Me.MenuItem34, Me.MenuItem35, Me.repEstadoBanco, Me.repDepositos, Me.repCheques, Me.MenuItem17, Me.repNCBanco, Me.repNDBanco})
        Me.mnuBanco.Text = "&Banco"
        '
        'mnuMaestroBanco
        '
        Me.mnuMaestroBanco.Index = 0
        Me.mnuMaestroBanco.Text = "Maestro de banco"
        '
        'mnuDiarioBanco
        '
        Me.mnuDiarioBanco.Index = 1
        Me.mnuDiarioBanco.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuDiarioBancoSolicitud, Me.mnuDiarioBancoCheque, Me.MenuItem27, Me.mnuDiarioBancoDeposito, Me.mnuDiarioBancoND, Me.mnuDiarioBancoNC, Me.MenuItem1, Me.mnuDiarioBancoCargosComisiones})
        Me.mnuDiarioBanco.Text = "Diario de banco"
        '
        'mnuDiarioBancoSolicitud
        '
        Me.mnuDiarioBancoSolicitud.Index = 0
        Me.mnuDiarioBancoSolicitud.Text = "Solicitud de Ck"
        '
        'mnuDiarioBancoCheque
        '
        Me.mnuDiarioBancoCheque.Index = 1
        Me.mnuDiarioBancoCheque.Text = "Emisión de Ck"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 2
        Me.MenuItem27.Text = "-"
        '
        'mnuDiarioBancoDeposito
        '
        Me.mnuDiarioBancoDeposito.Index = 3
        Me.mnuDiarioBancoDeposito.Text = "Depósitos"
        '
        'mnuDiarioBancoND
        '
        Me.mnuDiarioBancoND.Index = 4
        Me.mnuDiarioBancoND.Text = "Nota de débito"
        '
        'mnuDiarioBancoNC
        '
        Me.mnuDiarioBancoNC.Index = 5
        Me.mnuDiarioBancoNC.Text = "Nota de crédito"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 6
        Me.MenuItem1.Text = "-"
        '
        'mnuDiarioBancoCargosComisiones
        '
        Me.mnuDiarioBancoCargosComisiones.Index = 7
        Me.mnuDiarioBancoCargosComisiones.Text = "Cargos / Comisiones"
        '
        'mnuConciliacion
        '
        Me.mnuConciliacion.Index = 2
        Me.mnuConciliacion.Text = "Conciliación"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 3
        Me.MenuItem33.Text = "-"
        '
        'MenuItem34
        '
        Me.MenuItem34.Checked = True
        Me.MenuItem34.Index = 4
        Me.MenuItem34.Text = "<< Reportes Generales >>"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 5
        Me.MenuItem35.Text = "-"
        '
        'repEstadoBanco
        '
        Me.repEstadoBanco.Index = 6
        Me.repEstadoBanco.Text = "Estado de cuenta"
        '
        'repDepositos
        '
        Me.repDepositos.Index = 7
        Me.repDepositos.Text = "Depósitos"
        '
        'repCheques
        '
        Me.repCheques.Index = 8
        Me.repCheques.Text = "Cheques emitidos"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 9
        Me.MenuItem17.Text = "Cheques nulos"
        '
        'repNCBanco
        '
        Me.repNCBanco.Index = 10
        Me.repNCBanco.Text = "Notas de créditos"
        '
        'repNDBanco
        '
        Me.repNDBanco.Index = 11
        Me.repNDBanco.Text = "Notas de débitos"
        '
        'mnuCaja
        '
        Me.mnuCaja.Index = 4
        Me.mnuCaja.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRecibosIngresos, Me.mnuOtrosIngresos, Me.mnuConsultaIngresos, Me.mnuEgresos, Me.MenuItem7, Me.mnuCuadreCaja, Me.MenuItem5, Me.MenuItem8, Me.MenuItem12, Me.repRecibosIngresos, Me.mnuIngresosDevengados, Me.repRecibosIngresosNulos, Me.repEgresosCaja, Me.repOtrosIngresos})
        Me.mnuCaja.Text = "&Caja"
        '
        'mnuRecibosIngresos
        '
        Me.mnuRecibosIngresos.Index = 0
        Me.mnuRecibosIngresos.Text = "Recibo de Ingreso"
        '
        'mnuOtrosIngresos
        '
        Me.mnuOtrosIngresos.Index = 1
        Me.mnuOtrosIngresos.Text = "Otro Ingreso"
        '
        'mnuConsultaIngresos
        '
        Me.mnuConsultaIngresos.Index = 2
        Me.mnuConsultaIngresos.Text = "Consulta de Ingresos"
        '
        'mnuEgresos
        '
        Me.mnuEgresos.Index = 3
        Me.mnuEgresos.Text = "Egresos "
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 4
        Me.MenuItem7.Text = "-"
        '
        'mnuCuadreCaja
        '
        Me.mnuCuadreCaja.Index = 5
        Me.mnuCuadreCaja.Text = "Cuadre General"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 6
        Me.MenuItem5.Text = "-"
        '
        'MenuItem8
        '
        Me.MenuItem8.Checked = True
        Me.MenuItem8.Index = 7
        Me.MenuItem8.Text = "<< Reportes Generales >>"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 8
        Me.MenuItem12.Text = "-"
        '
        'repRecibosIngresos
        '
        Me.repRecibosIngresos.Index = 9
        Me.repRecibosIngresos.Text = "Ingresos Percibidos"
        '
        'mnuIngresosDevengados
        '
        Me.mnuIngresosDevengados.Index = 10
        Me.mnuIngresosDevengados.Text = "Ingresos Devengados"
        '
        'repRecibosIngresosNulos
        '
        Me.repRecibosIngresosNulos.Index = 11
        Me.repRecibosIngresosNulos.Text = "Ingresos Nulos"
        '
        'repEgresosCaja
        '
        Me.repEgresosCaja.Index = 12
        Me.repEgresosCaja.Text = "Egresos de Caja"
        '
        'repOtrosIngresos
        '
        Me.repOtrosIngresos.Index = 13
        Me.repOtrosIngresos.Text = "Otros Ingresos"
        '
        'mnuAhorros
        '
        Me.mnuAhorros.Index = 5
        Me.mnuAhorros.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAhorrosNuevo, Me.MenuItem13, Me.mnuAhorrosRealizarRetiros, Me.mnuAhorroAporteSocio, Me.MenuItem19, Me.mnuAhorrosCertificados, Me.MenuItem14, Me.MenuItem15, Me.MenuItem10, Me.mnuAhorrosEstadoCuenta, Me.MenuItem16, Me.mnuAhorrosRetiros, Me.mnuAhorrosSaldos, Me.mnuAhorrosListadoAportes})
        Me.mnuAhorros.Text = "A&horro"
        '
        'mnuAhorrosNuevo
        '
        Me.mnuAhorrosNuevo.Index = 0
        Me.mnuAhorrosNuevo.Text = "&Aperturar Cuenta"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 1
        Me.MenuItem13.Text = "Nuevo &Depósito"
        '
        'mnuAhorrosRealizarRetiros
        '
        Me.mnuAhorrosRealizarRetiros.Index = 2
        Me.mnuAhorrosRealizarRetiros.Text = "Nuevo &Retiro"
        '
        'mnuAhorroAporteSocio
        '
        Me.mnuAhorroAporteSocio.Index = 3
        Me.mnuAhorroAporteSocio.Text = "Aporte de Socio"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 4
        Me.MenuItem19.Text = "-"
        '
        'mnuAhorrosCertificados
        '
        Me.mnuAhorrosCertificados.Index = 5
        Me.mnuAhorrosCertificados.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAhorrosCertificadosApertura, Me.mnuAhorrosCertificadosCancelacion, Me.MenuItem18, Me.mnuAhorrosCertificadosListado})
        Me.mnuAhorrosCertificados.Text = "Certificados"
        '
        'mnuAhorrosCertificadosApertura
        '
        Me.mnuAhorrosCertificadosApertura.Index = 0
        Me.mnuAhorrosCertificadosApertura.Text = "Apertura"
        '
        'mnuAhorrosCertificadosCancelacion
        '
        Me.mnuAhorrosCertificadosCancelacion.Index = 1
        Me.mnuAhorrosCertificadosCancelacion.Text = "Cancelación"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 2
        Me.MenuItem18.Text = "-"
        '
        'mnuAhorrosCertificadosListado
        '
        Me.mnuAhorrosCertificadosListado.Index = 3
        Me.mnuAhorrosCertificadosListado.Text = "Listado"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 6
        Me.MenuItem14.Text = "-"
        '
        'MenuItem15
        '
        Me.MenuItem15.Checked = True
        Me.MenuItem15.Index = 7
        Me.MenuItem15.Text = "<< Reportes Generales >>"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 8
        Me.MenuItem10.Text = "-"
        '
        'mnuAhorrosEstadoCuenta
        '
        Me.mnuAhorrosEstadoCuenta.Index = 9
        Me.mnuAhorrosEstadoCuenta.Text = "Estado de Cuenta"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 10
        Me.MenuItem16.Text = "Listado de Depósitos"
        '
        'mnuAhorrosRetiros
        '
        Me.mnuAhorrosRetiros.Index = 11
        Me.mnuAhorrosRetiros.Text = "Listado de Retiros"
        '
        'mnuAhorrosSaldos
        '
        Me.mnuAhorrosSaldos.Index = 12
        Me.mnuAhorrosSaldos.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnTipoDeCuentaSaldos, Me.MenuItem22, Me.MnTodosLosSaldos})
        Me.mnuAhorrosSaldos.Text = "Listado de Saldos"
        '
        'MnTipoDeCuentaSaldos
        '
        Me.MnTipoDeCuentaSaldos.Index = 0
        Me.MnTipoDeCuentaSaldos.Text = "Por Tipo de Cuenta"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 1
        Me.MenuItem22.Text = "-"
        '
        'MnTodosLosSaldos
        '
        Me.MnTodosLosSaldos.Index = 2
        Me.MnTodosLosSaldos.Text = "Todos"
        '
        'mnuAhorrosListadoAportes
        '
        Me.mnuAhorrosListadoAportes.Index = 13
        Me.mnuAhorrosListadoAportes.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAhorrosListadoAportesUnSocio, Me.MenuItem11, Me.mnuAhorrosListadoAportesTodosLosSocios})
        Me.mnuAhorrosListadoAportes.Text = "Listado de Aportes"
        '
        'mnuAhorrosListadoAportesUnSocio
        '
        Me.mnuAhorrosListadoAportesUnSocio.Index = 0
        Me.mnuAhorrosListadoAportesUnSocio.Text = "Un socio"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 1
        Me.MenuItem11.Text = "-"
        '
        'mnuAhorrosListadoAportesTodosLosSocios
        '
        Me.mnuAhorrosListadoAportesTodosLosSocios.Index = 2
        Me.mnuAhorrosListadoAportesTodosLosSocios.Text = "Todos"
        '
        'mnuCuentaPorCobrar
        '
        Me.mnuCuentaPorCobrar.Index = 6
        Me.mnuCuentaPorCobrar.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuPrestamosNuevo, Me.mnuGeneraRecibos, Me.mnuPrestamosTabla, Me.mnuSolicitudCredito, Me.MenuItem42, Me.mnuCxCND, Me.mnuCxCNC, Me.mnuConsultaCxCNC, Me.MenuItem38, Me.MenuItem108, Me.MenuItem109, Me.repEstadoCliente, Me.repNDCxC, Me.repNCCxC, Me.repCuentaPorCobrar, Me.repCuentaPorCobrarCuotasFechas, Me.repCuentaPorCobrarCapital, Me.repCuentaPorCobrarIntes, Me.MenuItem41, Me.repTodosClientes, Me.MenuItem9, Me.repPrestamosEntregados, Me.repPrestamosPendientes, Me.repPrestamosSaldados})
        Me.mnuCuentaPorCobrar.Text = "C&uenta x Cobrar"
        '
        'mnuPrestamosNuevo
        '
        Me.mnuPrestamosNuevo.Index = 0
        Me.mnuPrestamosNuevo.Text = "Crear Préstamo"
        '
        'mnuGeneraRecibos
        '
        Me.mnuGeneraRecibos.Index = 1
        Me.mnuGeneraRecibos.Text = "Genera Recibo de Cobro ( Semanal/Diario )"
        Me.mnuGeneraRecibos.Visible = False
        '
        'mnuPrestamosTabla
        '
        Me.mnuPrestamosTabla.Index = 2
        Me.mnuPrestamosTabla.Text = "Tabla de Préstamos"
        '
        'mnuSolicitudCredito
        '
        Me.mnuSolicitudCredito.Index = 3
        Me.mnuSolicitudCredito.Text = "Solicitud de Crédito"
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = 4
        Me.MenuItem42.Text = "-"
        '
        'mnuCxCND
        '
        Me.mnuCxCND.Index = 5
        Me.mnuCxCND.Text = "Nota de Débito"
        '
        'mnuCxCNC
        '
        Me.mnuCxCNC.Index = 6
        Me.mnuCxCNC.Text = "Nota de Crédito"
        '
        'mnuConsultaCxCNC
        '
        Me.mnuConsultaCxCNC.Index = 7
        Me.mnuConsultaCxCNC.Text = "Consulta Nota de Crédito ( Todas )"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 8
        Me.MenuItem38.Text = "-"
        '
        'MenuItem108
        '
        Me.MenuItem108.Checked = True
        Me.MenuItem108.Index = 9
        Me.MenuItem108.Text = "<< Reportes Generales >>"
        '
        'MenuItem109
        '
        Me.MenuItem109.Index = 10
        Me.MenuItem109.Text = "-"
        '
        'repEstadoCliente
        '
        Me.repEstadoCliente.Index = 11
        Me.repEstadoCliente.Text = "Estado de Cuenta Socio"
        '
        'repNDCxC
        '
        Me.repNDCxC.Index = 12
        Me.repNDCxC.Text = "Nota de Débito"
        '
        'repNCCxC
        '
        Me.repNCCxC.Index = 13
        Me.repNCCxC.Text = "Nota de Crédito "
        '
        'repCuentaPorCobrar
        '
        Me.repCuentaPorCobrar.Index = 14
        Me.repCuentaPorCobrar.Text = "Cuentas por Cobrar "
        '
        'repCuentaPorCobrarCuotasFechas
        '
        Me.repCuentaPorCobrarCuotasFechas.Index = 15
        Me.repCuentaPorCobrarCuotasFechas.Text = "Cuentas por Cobrar Cuotas Capital e Interes"
        '
        'repCuentaPorCobrarCapital
        '
        Me.repCuentaPorCobrarCapital.Index = 16
        Me.repCuentaPorCobrarCapital.Text = "Cuentas por Cobrar Cuotas Capital"
        '
        'repCuentaPorCobrarIntes
        '
        Me.repCuentaPorCobrarIntes.Index = 17
        Me.repCuentaPorCobrarIntes.Text = "Cuentas por Cobrar Interes"
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 18
        Me.MenuItem41.Text = " Saldo por Antiguedad"
        '
        'repTodosClientes
        '
        Me.repTodosClientes.Index = 19
        Me.repTodosClientes.Text = "Todos los Clientes"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 20
        Me.MenuItem9.Text = "-"
        '
        'repPrestamosEntregados
        '
        Me.repPrestamosEntregados.Index = 21
        Me.repPrestamosEntregados.Text = "Préstamos Entregados"
        '
        'repPrestamosPendientes
        '
        Me.repPrestamosPendientes.Index = 22
        Me.repPrestamosPendientes.Text = "Préstamos Pendientes"
        '
        'repPrestamosSaldados
        '
        Me.repPrestamosSaldados.Index = 23
        Me.repPrestamosSaldados.Text = "Préstamos Saldados"
        '
        'mnuCuentaPorPagar
        '
        Me.mnuCuentaPorPagar.Index = 7
        Me.mnuCuentaPorPagar.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuIngresosCajaCxP, Me.mnuCxPND, Me.mnuCxPNC, Me.MenuItem99, Me.MenuItem100, Me.MenuItem101, Me.repEstadoProveedor, Me.repCuentaPorPagar, Me.repNDCuentaPorPagar, Me.repNCCuentaPorPagar, Me.repTodoProveedores})
        Me.mnuCuentaPorPagar.Text = " Cuenta x &Pagar "
        '
        'mnuIngresosCajaCxP
        '
        Me.mnuIngresosCajaCxP.Index = 0
        Me.mnuIngresosCajaCxP.Text = "Ingreso a Caja CxP"
        Me.mnuIngresosCajaCxP.Visible = False
        '
        'mnuCxPND
        '
        Me.mnuCxPND.Index = 1
        Me.mnuCxPND.Text = "Nota de Débito(Pagos)"
        '
        'mnuCxPNC
        '
        Me.mnuCxPNC.Index = 2
        Me.mnuCxPNC.Text = "Nota de Crédito (Factura)"
        '
        'MenuItem99
        '
        Me.MenuItem99.Index = 3
        Me.MenuItem99.Text = "-"
        '
        'MenuItem100
        '
        Me.MenuItem100.Checked = True
        Me.MenuItem100.Index = 4
        Me.MenuItem100.Text = "<< Reportes Generales >>"
        '
        'MenuItem101
        '
        Me.MenuItem101.Index = 5
        Me.MenuItem101.Text = "-"
        '
        'repEstadoProveedor
        '
        Me.repEstadoProveedor.Index = 6
        Me.repEstadoProveedor.Text = "Estado de Cuenta Proveedor"
        '
        'repCuentaPorPagar
        '
        Me.repCuentaPorPagar.Index = 7
        Me.repCuentaPorPagar.Text = "Cuentas por Pagar"
        '
        'repNDCuentaPorPagar
        '
        Me.repNDCuentaPorPagar.Index = 8
        Me.repNDCuentaPorPagar.Text = "Nota de Débito"
        '
        'repNCCuentaPorPagar
        '
        Me.repNCCuentaPorPagar.Index = 9
        Me.repNCCuentaPorPagar.Text = "Listado Nota de Crédito (Factura)"
        '
        'repTodoProveedores
        '
        Me.repTodoProveedores.Index = 10
        Me.repTodoProveedores.Text = "Todos los Proveedores"
        '
        'StatusBar
        '
        Me.StatusBar.Location = New System.Drawing.Point(0, 365)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.User1, Me.Puesto, Me.fecha})
        Me.StatusBar.ShowPanels = True
        Me.StatusBar.Size = New System.Drawing.Size(914, 21)
        Me.StatusBar.SizingGrip = False
        Me.StatusBar.TabIndex = 2
        Me.StatusBar.Text = "SMC-Administrativo"
        '
        'User1
        '
        Me.User1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.User1.Name = "User1"
        Me.User1.Text = "User1"
        Me.User1.ToolTipText = "USUARIO ACTUAL"
        Me.User1.Width = 823
        '
        'Puesto
        '
        Me.Puesto.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.Puesto.Name = "Puesto"
        Me.Puesto.Text = "Puesto"
        Me.Puesto.ToolTipText = "PUESTO"
        Me.Puesto.Width = 49
        '
        'fecha
        '
        Me.fecha.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.fecha.Name = "fecha"
        Me.fecha.Text = "fecha"
        Me.fecha.Width = 42
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'ToolBar
        '
        Me.ToolBar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.b_clientes, Me.ToolBarButton2, Me.b_prestasmos, Me.ToolBarButton3, Me.b_nd_cxc, Me.ToolBarButton6, Me.b_ri, Me.ToolBarButton4, Me.b_nc_cxc, Me.ToolBarButton1, Me.b_foto_cliente, Me.ToolBarButton5, Me.b_salir, Me.ToolBarButton7})
        Me.ToolBar.ButtonSize = New System.Drawing.Size(180, 70)
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.ImageList = Me.ImageList1
        Me.ToolBar.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(914, 59)
        Me.ToolBar.TabIndex = 17
        '
        'b_clientes
        '
        Me.b_clientes.ImageIndex = 0
        Me.b_clientes.Name = "b_clientes"
        Me.b_clientes.Text = "Socios (F2)"
        Me.b_clientes.ToolTipText = "Maestro de Socios, permite crear, modifica y borrar las fichas de los clientes"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.Name = "ToolBarButton2"
        Me.ToolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'b_prestasmos
        '
        Me.b_prestasmos.ImageIndex = 1
        Me.b_prestasmos.Name = "b_prestasmos"
        Me.b_prestasmos.Text = "Préstamos (F3)"
        Me.b_prestasmos.ToolTipText = "Permite realizar préstamos a los clientes"
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.Name = "ToolBarButton3"
        Me.ToolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'b_nd_cxc
        '
        Me.b_nd_cxc.ImageIndex = 2
        Me.b_nd_cxc.Name = "b_nd_cxc"
        Me.b_nd_cxc.Text = "Nota de Débito CxC (F4)"
        Me.b_nd_cxc.ToolTipText = "Su función es hacer CARGOS a las cuentas por cobrar de los clientes"
        '
        'ToolBarButton6
        '
        Me.ToolBarButton6.Name = "ToolBarButton6"
        Me.ToolBarButton6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'b_ri
        '
        Me.b_ri.ImageIndex = 4
        Me.b_ri.Name = "b_ri"
        Me.b_ri.Text = "Recibos Ingresos (F6)"
        Me.b_ri.ToolTipText = "Crear Recibo de Ingresos CxC"
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.Name = "ToolBarButton4"
        Me.ToolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'b_nc_cxc
        '
        Me.b_nc_cxc.ImageIndex = 3
        Me.b_nc_cxc.Name = "b_nc_cxc"
        Me.b_nc_cxc.Text = "Nota de Crédito (F5)"
        Me.b_nc_cxc.ToolTipText = "Su función es hacer DESCUENTOS a las cuentas por cobrar de los clientes"
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.Name = "ToolBarButton1"
        Me.ToolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'b_foto_cliente
        '
        Me.b_foto_cliente.ImageIndex = 6
        Me.b_foto_cliente.Name = "b_foto_cliente"
        Me.b_foto_cliente.Text = "Foto Socio"
        Me.b_foto_cliente.ToolTipText = "Buscar foto de socio"
        '
        'ToolBarButton5
        '
        Me.ToolBarButton5.Name = "ToolBarButton5"
        Me.ToolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'b_salir
        '
        Me.b_salir.ImageIndex = 5
        Me.b_salir.Name = "b_salir"
        Me.b_salir.Text = "Salir del Sistema"
        Me.b_salir.ToolTipText = "Sale del Sistema por completo"
        '
        'ToolBarButton7
        '
        Me.ToolBarButton7.Name = "ToolBarButton7"
        Me.ToolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(2, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(909, 32)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "COMPAÑIA"
        '
        'FRM_DEFAULT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(914, 386)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolBar)
        Me.Controls.Add(Me.StatusBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Menu = Me.MainMenu
        Me.Name = "FRM_DEFAULT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataPréstamos versión 1.1"
        CType(Me.User1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Puesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


#Region " Global Form "

    Private Shared m_GlobalForm As FRM_DEFAULT

    Public Shared Property GlobalForm() As FRM_DEFAULT

        Get
            If m_GlobalForm Is Nothing OrElse m_GlobalForm.IsDisposed Then
                m_GlobalForm = New FRM_DEFAULT
            End If
            Return m_GlobalForm
        End Get

        Set(ByVal Value As FRM_DEFAULT)
            m_GlobalForm = Value
        End Set

    End Property

#End Region

    Private Sub LeerPermisos()
        LeerPermisoArchivo()
        LeerPermisoMatenimiento()
        LeerPermisoBanco()
        LeerPermisoCaja()
        LeerPermisoPrestamos()
        LeerPermisoCxC()
        LeerPermisoCxP()
        LeerPermisoBarra()
        LeerPermisoAhorros()
    End Sub
    Private Sub LeerPermisoArchivo()
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT mnuArchivo, mnuPermisosUsuarios, mnuCambiarMiClave, mnuCambiarUsuario, mnuFormatoCheque, mnuTimbrado FROM tbl_userarchivo  WHERE IDUsuario=" & CInt(User(5)) & "", conn)
        da.Fill(ds, "tbl_userarchivo")

        For Each dr In ds.Tables(0).Rows
            mnuArchivo.Visible = CBool(dr("mnuArchivo"))
            mnuPermisosUsuarios.Enabled = CBool(dr("mnuPermisosUsuarios"))
            mnuCambiarMiClave.Enabled = CBool(dr("mnuCambiarMiClave"))
            mnuCambiarUsuario.Enabled = CBool(dr("mnuCambiarUsuario"))
            mnuFormatoCheque.Enabled = CBool(dr("mnuFormatoCheque"))
            mnuTimbrado.Enabled = CBool(dr("mnuTimbrado"))
        Next
        ds.Dispose()
        da.Dispose()

    End Sub
    Private Sub LeerPermisoMatenimiento()
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT 	mnuMantenimiento, mnuCliente, mnuInmuebles, mnuUsuarioNuevo, mnuCobradores, mnuZonas, mnuUrbanizaciones, mnuCiudad, mnuProvincias FROM tbl_usermantenimiento WHERE IDUsuario=" & CInt(User(5)) & "", conn)
        da.Fill(ds, "tbl_usermantenimiento")

        For Each dr In ds.Tables(0).Rows
            mnuMantenimiento.Visible = CBool(dr("mnuMantenimiento"))
            mnuCliente.Enabled = CBool(dr("mnuCliente"))
            mnuInmuebles.Enabled = CBool(dr("mnuInmuebles"))
            mnuUsuarioNuevo.Enabled = CBool(dr("mnuUsuarioNuevo"))
            mnuCobradores.Enabled = CBool(dr("mnuCobradores"))
            mnuZonas.Enabled = CBool(dr("mnuZonas"))
            mnuUrbanizaciones.Enabled = CBool(dr("mnuUrbanizaciones"))
            mnuCiudad.Enabled = CBool(dr("mnuCiudad"))
            mnuProvincias.Enabled = CBool(dr("mnuProvincias"))
        Next
        ds.Dispose()
        da.Dispose()

    End Sub
    Private Sub LeerPermisoBanco()
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT 	mnuBanco, mnuMaestroBanco, mnuDiarioBanco, mnuDiarioBancoSolicitud, mnuDiarioBancoCheque, mnuDiarioBancoDeposito, mnuDiarioBancoND, mnuDiarioBancoNC, mnuConciliacion, repEstadoBanco, repDepositos, repCheques, repNCBanco, repNDBanco FROM tbl_userbanco WHERE IDUsuario=" & CInt(User(5)) & "", conn)
        da.Fill(ds, "tbl_userbanco")

        For Each dr In ds.Tables(0).Rows
            mnuBanco.Visible = CBool(dr("mnuBanco"))
            mnuMaestroBanco.Enabled = CBool(dr("mnuMaestroBanco"))
            mnuDiarioBanco.Enabled = CBool(dr("mnuDiarioBanco"))
            mnuDiarioBancoSolicitud.Enabled = CBool(dr("mnuDiarioBancoSolicitud"))
            mnuDiarioBancoCheque.Enabled = CBool(dr("mnuDiarioBancoCheque"))
            mnuDiarioBancoDeposito.Enabled = CBool(dr("mnuDiarioBancoDeposito"))
            mnuDiarioBancoND.Enabled = CBool(dr("mnuDiarioBancoND"))
            mnuDiarioBancoNC.Enabled = CBool(dr("mnuDiarioBancoNC"))
            mnuConciliacion.Enabled = CBool(dr("mnuConciliacion"))
            repEstadoBanco.Enabled = CBool(dr("repEstadoBanco"))
            repDepositos.Enabled = CBool(dr("repDepositos"))
            repCheques.Enabled = CBool(dr("repCheques"))
            repNCBanco.Enabled = CBool(dr("repNCBanco"))
            repNDBanco.Enabled = CBool(dr("repNDBanco"))
        Next
        ds.Dispose()
        da.Dispose()

    End Sub
    Private Sub LeerPermisoCaja()
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT mnuCaja, mnuRecibosIngresos, mnuOtrosIngresos, mnuConsultaIngresos, mnuEgresos, mnuCuadreCaja, repRecibosIngresos, repRecibosIngresosNulos, repEgresosCaja FROM tbl_usercaja WHERE IDUsuario=" & CInt(User(5)) & "", conn)
        da.Fill(ds, "tbl_userbanco")

        For Each dr In ds.Tables(0).Rows
            mnuCaja.Visible = CBool(dr("mnuCaja"))
            mnuRecibosIngresos.Enabled = CBool(dr("mnuRecibosIngresos"))
            mnuOtrosIngresos.Enabled = CBool(dr("mnuOtrosIngresos"))
            mnuConsultaIngresos.Enabled = CBool(dr("mnuConsultaIngresos"))
            mnuEgresos.Enabled = CBool(dr("mnuEgresos"))
            mnuCuadreCaja.Enabled = CBool(dr("mnuCuadreCaja"))
            repRecibosIngresos.Enabled = CBool(dr("repRecibosIngresos"))
            repRecibosIngresosNulos.Enabled = CBool(dr("repRecibosIngresosNulos"))
            repEgresosCaja.Enabled = CBool(dr("repEgresosCaja"))
        Next
        ds.Dispose()
        da.Dispose()

    End Sub
    Private Sub LeerPermisoPrestamos()
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT mnuPrestamosNuevo, repPrestamosEntregados, repPrestamosPendientes, repPrestamosSaldados FROM tbl_userprestamos WHERE IDUsuario=" & CInt(User(5)) & "", conn)
        da.Fill(ds, "tbl_userprestamos")

        For Each dr In ds.Tables(0).Rows

            mnuPrestamosNuevo.Enabled = CBool(dr("mnuPrestamosNuevo"))
            repPrestamosEntregados.Enabled = CBool(dr("repPrestamosEntregados"))
            repPrestamosPendientes.Enabled = CBool(dr("repPrestamosPendientes"))
            repPrestamosSaldados.Enabled = CBool(dr("repPrestamosSaldados"))
        Next
        ds.Dispose()
        da.Dispose()

    End Sub
    Private Sub LeerPermisoCxC()
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT mnuCuentaPorCobrar, mnuGeneraRecibos, mnuCxCND, mnuCxCNC, mnuConsultaCxCNC, repEstadoCliente, repNDCxC, repNCCxC, repCuentaPorCobrar, repCuentaPorCobrarCuotasFechas, repCuentaPorCobrarCapital, repCuentaPorCobrarIntes, repTodosClientes FROM tbl_usercuentaporcobrar WHERE IDUsuario=" & CInt(User(5)) & "", conn)
        da.Fill(ds, "tbl_usercuentaporcobrar")

        For Each dr In ds.Tables(0).Rows
            mnuCuentaPorCobrar.Visible = CBool(dr("mnuCuentaPorCobrar"))
            mnuGeneraRecibos.Enabled = CBool(dr("mnuGeneraRecibos"))
            mnuCxCND.Enabled = CBool(dr("mnuCxCND"))
            mnuCxCNC.Enabled = CBool(dr("mnuCxCNC"))
            mnuConsultaCxCNC.Enabled = CBool(dr("mnuConsultaCxCNC"))
            repEstadoCliente.Enabled = CBool(dr("repEstadoCliente"))
            repNDCxC.Enabled = CBool(dr("repNDCxC"))
            repNCCxC.Enabled = CBool(dr("repNCCxC"))
            repCuentaPorCobrar.Enabled = CBool(dr("repCuentaPorCobrar"))
            repCuentaPorCobrarCuotasFechas.Enabled = CBool(dr("repCuentaPorCobrarCuotasFechas"))
            repCuentaPorCobrarCapital.Enabled = CBool(dr("repCuentaPorCobrarCapital"))
            repCuentaPorCobrarIntes.Enabled = CBool(dr("repCuentaPorCobrarIntes"))
            repTodosClientes.Enabled = CBool(dr("repTodosClientes"))
        Next
        ds.Dispose()
        da.Dispose()

    End Sub
    Private Sub LeerPermisoCxP()
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT mnuCuentaPorPagar, mnuProveedores, mnuIngresosCajaCxP, mnuCxPND, mnuCxPNC, repEstadoProveedor, repCuentaPorPagar, repNDCuentaPorPagar, repNCCuentaPorPagar, repTodoProveedores FROM tbl_usercuentaporpagar WHERE IDUsuario=" & CInt(User(5)) & "", conn)
        da.Fill(ds, "tbl_usercuentaporpagar")

        For Each dr In ds.Tables(0).Rows
            mnuCuentaPorPagar.Visible = CBool(dr("mnuCuentaPorPagar"))
            mnuProveedores.Enabled = CBool(dr("mnuProveedores"))
            mnuIngresosCajaCxP.Enabled = CBool(dr("mnuIngresosCajaCxP"))
            mnuCxPND.Enabled = CBool(dr("mnuCxPND"))
            mnuCxPNC.Enabled = CBool(dr("mnuCxPNC"))
            repEstadoProveedor.Enabled = CBool(dr("repEstadoProveedor"))
            repCuentaPorPagar.Enabled = CBool(dr("repCuentaPorPagar"))
            repNDCuentaPorPagar.Enabled = CBool(dr("repNDCuentaPorPagar"))
            repNCCuentaPorPagar.Enabled = CBool(dr("repNCCuentaPorPagar"))
            repTodoProveedores.Enabled = CBool(dr("repTodoProveedores"))

        Next
        ds.Dispose()
        da.Dispose()

    End Sub
    Private Sub LeerPermisoBarra()
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT ToolBar, b_clientes, b_prestasmos, b_nd_cxc, b_ri, b_nc_cxc FROM tbl_userbarraherramienta WHERE IDUsuario=" & CInt(User(5)) & "", conn)
        da.Fill(ds, "tbl_userbarraherramienta")

        For Each dr In ds.Tables(0).Rows
            ToolBar.Visible = CBool(dr("ToolBar"))
            b_clientes.Visible = CBool(dr("b_clientes"))
            b_prestasmos.Visible = CBool(dr("b_prestasmos"))
            b_nd_cxc.Visible = CBool(dr("b_nd_cxc"))
            b_ri.Visible = CBool(dr("b_ri"))
            b_nc_cxc.Visible = CBool(dr("b_nc_cxc"))
        Next
        ds.Dispose()
        da.Dispose()

    End Sub
    Private Sub LeerPermisoAhorros()
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT mnuAhorros, mnuAhorrosNuevo, mnuAhorrosRealizarRetiros, mnuAhorrosEstadoCuenta, mnuAhorrosRetiros, mnuAhorrosSaldos FROM tbl_userahorros WHERE IDUsuario=" & CInt(User(5)) & "", conn)
        da.Fill(ds, "tbl_userahorros")

        For Each dr In ds.Tables(0).Rows
            mnuAhorros.Enabled = CBool(dr("mnuAhorros"))
            mnuAhorrosNuevo.Enabled = CBool(dr("mnuAhorrosNuevo"))
            mnuAhorrosRealizarRetiros.Enabled = CBool(dr("mnuAhorrosRealizarRetiros"))
            mnuAhorrosEstadoCuenta.Enabled = CBool(dr("mnuAhorrosEstadoCuenta"))
            mnuAhorrosRetiros.Enabled = CBool(dr("mnuAhorrosRetiros"))
            mnuAhorrosSaldos.Enabled = CBool(dr("mnuAhorrosSaldos"))


        Next
        ds.Dispose()
        da.Dispose()

    End Sub



    Private Sub RI()
        Dim f As New FRM_POPUP_RI
        f.ShowDialog()
        Dim result = f.Text
        Dim nc = f.cmbTipo.Text
        f.Dispose()
        If result = "ACEPTAR" Then
            If nc = "ABONO A CAPITAL" Then
                Dim f1 As New FRM_RECIBO_INGRESO_CAPITAL
                f1.MdiParent = FRM_DEFAULT.GlobalForm
                f1.Show()
            Else
                FRMS_RECIBO_INGRESO("0")
            End If
        End If
    End Sub

    Private Sub NC()
        FRMS_NC_CXC()
        Exit Sub
        Dim f As New FRM_POPUP_NC
        f.ShowDialog()
        Dim result = f.Text
        Dim nc = f.cmbTipo.Text
        f.Dispose()
        If result = "ACEPTAR" Then
            If nc = "CAPITAL E INTERES" Then
                Dim nc1 As New FRM_NC_CXC_COMP
                nc1.MdiParent = FRM_DEFAULT.GlobalForm
                nc1.Show()
            ElseIf nc = "INTERES" Then
                Dim nc1 As New FRM_NC_CXC
                nc1.MdiParent = FRM_DEFAULT.GlobalForm
                nc1.Show()
            ElseIf nc = "CAPITAL" Then
                Dim f1 As New FRM_NC_ABONOCAPITAL
                f1.MdiParent = FRM_DEFAULT.GlobalForm
                f1.Show()
            End If
        End If
    End Sub
    'Private Sub NCa()
    '    Dim nc1 As New FRM_NC_CXC
    '    nc1.MdiParent = FRM_DEFAULT.GlobalForm
    '    nc1.Show()
    'End Sub

    Private Sub load_clave_admin()
        Dim cmd As New MySqlCommand
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT fldPassAdmin FROM tbl_profiledocument"
            admin_clave = .ExecuteScalar()
            .Connection.Close()
        End With
        cmd.Dispose()
    End Sub

    Private Sub load_clave_borrar()
        Dim cmd As New MySqlCommand
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT fldPassConfig FROM tbl_profiledocument"
            borrar_clave = .ExecuteScalar()
            .Connection.Close()
        End With
        cmd.Dispose()
    End Sub

    Private Sub DiaGracia()

        Dim cmd As New MySqlCommand
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT DiasGracias FROM parametrosgenerales WHERE ID=1"
            DiasGracias = .ExecuteScalar()
            .Connection.Close()
        End With
        cmd.Dispose()
    End Sub

    Private Function CANT_CUOTAS(ByVal ID_PREST) As Integer
        Dim CMD As New MySqlCommand, VALUES As Integer
        With CMD
            .CommandText = "SELECT COUNT(*) FROM tbl_cuotas WHERE fld_id_del_prestamo=" & ID_PREST & ""
            .Connection = conn
            .Connection.Open()
            VALUES = .ExecuteScalar
            .Connection.Close()
        End With
        CMD.Dispose()
        CANT_CUOTAS = VALUES
    End Function

    Private Function BCE_CUOTAS(ByVal ID_PREST) As Double
        Dim CMD As New MySqlCommand, VALUES As Double
        With CMD
            .CommandText = "SELECT SUM(fld_balance_cuotas) FROM tbl_cuotas WHERE fld_id_del_prestamo=" & ID_PREST & " AND fld_fecha_termina_cuotas<'" & formatDate(Now.Date) & "'"
            .Connection = conn
            .Connection.Open()
            If .ExecuteScalar().GetType.ToString = "System.DBNull" Then
                VALUES = 0
            Else
                VALUES = .ExecuteScalar
            End If

            .Connection.Close()
        End With
        CMD.Dispose()
        BCE_CUOTAS = VALUES
    End Function

    Private Function ID_CLIENTE_FACTURA(ByVal TABLA As String, ByVal field_id As String, ByVal Id_doc As String) As Integer
        Dim cmd1 As New MySqlCommand, importe As Integer
        With cmd1
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT fldCliente from " & TABLA & " WHERE " & field_id & "=" & Id_doc & ""
            importe = .ExecuteScalar()
            .Connection.Close()
        End With
        cmd1.Dispose()
        Return importe
    End Function


    Private Sub FRM_DEFAULT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        User1.Text = "USUARIO..: " & User(2)
        Puesto.Text = "CARGO..: " & User(1)
        Me.WindowState = FormWindowState.Maximized

        load_clave_admin()

        load_clave_borrar()

        DiaGracia()

        Me.Label1.Text = objIniFile.GetString("COMPANY", "Name", "(none)")
        aplicaInteres()
    End Sub

    Private Sub FRM_DEFAULT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            FRMS_CLIENTES()
        ElseIf e.KeyCode = Keys.F3 Then
            FRMS_MAESTRO_PRESTAMOS()
        ElseIf e.KeyCode = Keys.F4 Then
            FRMS_ND_NC_CXC("ND")
        ElseIf e.KeyCode = Keys.F5 Then
            FRMS_NC_CXC()
        ElseIf e.KeyCode = Keys.F6 Then
            FRMS_RECIBO_INGRESO("0")
        End If

    End Sub

    Private Sub Archivo_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Archivo_Salir.Click
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        fecha.Text = Now
        fecha.ToolTipText = Now
    End Sub

    Private Sub cMnu_CXC_Archivo_Paciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCliente.Click
        FRMS_CLIENTES()
    End Sub

    Private Sub cMnu_CXC_ND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCxCND.Click

        FRMS_ND_NC_CXC("ND")
    End Sub

    Private Sub Mnu_Archivo_zonas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuZonas.Click
        FRMS_MAESTRO_ZONAS()
    End Sub

    Private Sub Mnu_Archivo_vendedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCobradores.Click
        FRMS_MAESTRO_VENDEDORES()
    End Sub

    Private Sub mNu_prestamos_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrestamosNuevo.Click
        FRMS_MAESTRO_PRESTAMOS()
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repTodosClientes.Click
        AllReportSinFecha("CLIENTES_TODOS")
    End Sub

    Private Sub MenuItem78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repPrestamosEntregados.Click
        AllReport("PRESTAMOS_ENTREGADOS")
    End Sub

    Private Sub MenuItem79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repPrestamosPendientes.Click
        Dim show As New FrmPopupMessage
        show.Show("Actualizando préstamos... Por favor espere")
        NON_QUERY("CALL bce_prestamos()")
        show.Close()
        AllReportSinFecha("PRESTAMOS_PENDIENTES")
    End Sub

    Private Sub MenuItem80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repPrestamosSaldados.Click
        Dim show As New FrmPopupMessage
        show.Show("Actualizando préstamos... Por favor espere")
        NON_QUERY("CALL bce_prestamos()")
        show.Close()
        AllReport("PRESTAMOS_SALDADOS")
    End Sub

    Private Sub cMnu_CXC_ND_Rep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repNDCxC.Click
        AllReport("LISTA_ND_CXC")
    End Sub

    Private Sub cMnu_CXC_NC_Rep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repNCCxC.Click
        AllReport("LISTA_NC_CXC")
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar.ButtonClick
        If e.Button Is Me.b_clientes Then
            FRMS_CLIENTES()
        ElseIf e.Button Is Me.b_prestasmos Then
            FRMS_MAESTRO_PRESTAMOS()
        ElseIf e.Button Is Me.b_ri Then
            FRMS_RECIBO_INGRESO("0")
        ElseIf e.Button Is Me.b_nc_cxc Then
            NC()
        ElseIf e.Button Is Me.b_nd_cxc Then
            FRMS_ND_NC_CXC("ND")
        ElseIf e.Button Is Me.b_salir Then
            Me.Close()
        ElseIf e.Button Is Me.b_foto_cliente Then
            Dim f As New frmFotoClienteConsulta
            f.ShowDialog()
            f.Dispose()
        End If

    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repEgresosCaja.Click
        AllReportCaja("LIST_RECIBOS_EGRESOS")
    End Sub

    Private Sub MenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConsultaIngresos.Click
        FRMS_LISTA_RECIBOS_INGRESOS()
    End Sub

    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repRecibosIngresos.Click
        AllReportCaja("LIST_RECIBOS_INGRESOS")
    End Sub

    Private Sub MenuItem52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repCuentaPorCobrarCuotasFechas.Click
        Dim f As New FRM_PARAMETROS_REPORTES_CXC
        f.ShowDialog()
        If f.Text <> "Parámetros de Reportes" Then
            Id = f.Text
            AllReportSinFecha("CXC_TODOS_CUOTAS")
        End If
        f.Dispose()
    End Sub

    Private Sub MenuItem54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repCuentaPorCobrarCapital.Click
        Dim f As New FRM_PARAMETROS_REPORTES_CXC
        f.ShowDialog()
        If f.Text <> "Parámetros de Reportes" Then
            Id = f.Text
            AllReportSinFecha("CXC_CAPITAL")
        End If
        f.Dispose()

    End Sub

    Private Sub MenuItem55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repCuentaPorCobrarIntes.Click
        Dim f As New FRM_PARAMETROS_REPORTES_CXC
        f.ShowDialog()
        If f.Text <> "Parámetros de Reportes" Then
            Id = f.Text
            AllReportSinFecha("CXC_INTERES")
        End If
        f.Dispose()
    End Sub

    Private Sub MenuItem58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConsultaCxCNC.Click
        Dim f As New FRM_LIST_NOTA_CREDITO
        f.MdiParent = FRM_DEFAULT.GlobalForm
        f.Show()
    End Sub

    Private Sub MenuItem67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repRecibosIngresosNulos.Click
        AllReport("LIST_RECIBOS_INGRESOS_NULO")
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repEstadoCliente.Click
        Dim f As New FRM_ESTADO_CLIENTE
        f.MdiParent = FRM_DEFAULT.GlobalForm
        f.Show()


    End Sub

    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMaestroBanco.Click
        FRMS_MAESTRO_BANCOS()
    End Sub

    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDiarioBancoSolicitud.Click
        Dim f As New FRM_SOLICITUD_CKS
        f.MdiParent = FRM_DEFAULT.GlobalForm
        f.Show()
    End Sub

    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDiarioBancoCheque.Click
        FRMS_MAESTRO_CK("")
    End Sub

    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDiarioBancoDeposito.Click
        FRMS_DIARIOBANCO("Depósito Bancario")
    End Sub

    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDiarioBancoND.Click
        FRMS_DIARIOBANCO("ND Bancaria")
    End Sub

    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDiarioBancoNC.Click
        FRMS_DIARIOBANCO("NC Bancaria")
    End Sub

    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConciliacion.Click
        If FRMS_LIST_BANCOS() = True Then
            FRMS_CONCILIACION(Id)
        End If
    End Sub

    Private Sub MenuItem84_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUrbanizaciones.Click
        Dim f As New FRM_URBANIZACIONES
        f.MdiParent = FRM_DEFAULT.GlobalForm
        f.Show()
    End Sub

    Private Sub MenuItem86_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCiudad.Click
        Dim f As New FRM_CIUDADES
        f.MdiParent = FRM_DEFAULT.GlobalForm
        f.Show()
    End Sub

    Private Sub MenuItem87_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProvincias.Click
        Dim f As New FRM_PROVINCIAS
        f.MdiParent = FRM_DEFAULT.GlobalForm
        f.Show()
    End Sub



    Private Sub Mnu_Ventas_compras_salida_caja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEgresos.Click
        Dim f As New FRM_RECIBO_EGRESO
        f.MdiParent = FRM_DEFAULT.GlobalForm
        f.Show()
    End Sub

    Private Sub MenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repDepositos.Click
        If FRMS_POPUP_STATUS() = "Estatus" Then Exit Sub
        If FRMS_LIST_BANCOS() = False Then Exit Sub
        AllReport("DEPOSITOS_UNO")
    End Sub

    Private Sub MenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repCheques.Click
        'If FRMS_POPUP_STATUS() = "Estatus" Then Exit Sub
        If FRMS_LIST_BANCOS() = False Then Exit Sub
        'Estado = "EMISION"
        AllReport("CK_UNO_EMISION")
    End Sub

    Private Sub MenuItem65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repNCBanco.Click
        If FRMS_LIST_BANCOS() = False Then Exit Sub
        AllReport("NC_BANCO_UNO")
    End Sub

    Private Sub MenuItem72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repNDBanco.Click
        If FRMS_LIST_BANCOS() = False Then Exit Sub
        AllReport("ND_BANCO_UNO")
    End Sub

    Private Sub MenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGeneraRecibos.Click
        Dim f As New FRM_GENERANDO_CUOTAS
        f.MdiParent = FRM_DEFAULT.GlobalForm
        f.Show()
    End Sub

    Private Sub MenuItem93_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProveedores.Click
        Dim f As New FRM_PROVEEDORES
        f.MdiParent = FRM_DEFAULT.GlobalForm
        f.Show()
    End Sub

    Private Sub MenuItem94_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCxPND.Click
        Dim f As New FRM_ND_CXP
        f.MdiParent = FRM_DEFAULT.GlobalForm
        f.Show()
    End Sub

    Private Sub MenuItem95_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCxPNC.Click
        Dim f As New FRM_NC_CXP
        f.Label8.Visible = False
        f.Label13.Visible = False
        f.txtFormaDePago.Visible = False
        f.fld_detalle_forma_pago.Visible = False
        f.MdiParent = FRM_DEFAULT.GlobalForm
        f.Show()
    End Sub

    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOtrosIngresos.Click
        Dim f As New FRM_RECIBO_OTROS_INGRESOS
        f.MdiParent = FRM_DEFAULT.GlobalForm
        f.Show()
    End Sub

    Private Sub MenuItem61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCuadreCaja.Click
        Dim f As New FRM_CUADRE
        f.MdiParent = FRM_DEFAULT.GlobalForm
        f.Show()

    End Sub

    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repEstadoBanco.Click

        Dim f As New FRM_ESTADO_BANCO
        f.MdiParent = FRM_DEFAULT.GlobalForm
        f.Show()

    End Sub

    Private Sub MenuItem118_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repEstadoProveedor.Click
        Dim f As New FRM_ESTADO_PROVEEDOR
        f.MdiParent = FRM_DEFAULT.GlobalForm
        f.Show()
    End Sub

    Private Sub MenuItem119_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repCuentaPorPagar.Click
        Dim f As New FRM_POPUP_BCE
        f.ShowDialog()
        If f.Text = "ACEPTAR" Then
            AllReportSinFecha("CUENTAxPAGAR")
        End If
    End Sub

    Private Sub MenuItem120_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repNDCuentaPorPagar.Click
        AllReport("LISTA_ND_CXP")
    End Sub

    Private Sub MenuItem121_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repNCCuentaPorPagar.Click
        AllReport("LISTA_NC_CXP")
    End Sub

    Private Sub MenuItem62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repTodoProveedores.Click
        AllReportSinFecha("LISTADO DE PROVEEDORES")
    End Sub

    Private Sub MenuItem68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuIngresosCajaCxP.Click
        Dim f As New FRM_NC_CXP
        f.lblTipo.Text = "INGRESO A CAJA DE CUENTA POR PAGAR"
        f.MdiParent = FRM_DEFAULT.GlobalForm
        f.Show()
    End Sub

    Private Sub MenuItem70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCxCNC.Click
        NC()
    End Sub

    Private Sub MenuItem39_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRecibosIngresos.Click
        FRMS_RECIBO_INGRESO("0")
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repCuentaPorCobrar.Click
        'Dim f As New FRM_PARAMETROS_REPORTES_CXC
        Dim f As New FrmReporte_CXC
        f.ShowDialog()
        'If f.Text <> "Parámetros de Reportes" Then
        '    'Id = f.Text
        '    'AllReportSinFecha("CXC_TODOS")
        'End If
        f.Dispose()
    End Sub

    Private Sub mnuUsuarioNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUsuarioNuevo.Click
        Dim f As New FRM_USER_SYSTEM
        f.MdiParent = FRM_DEFAULT.GlobalForm
        f.Show()
    End Sub

    Private Sub mnuCambiarMiClave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCambiarMiClave.Click
        Dim f As New FRM_CAMBIAR_CLAVE

        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub mnuFormatoCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFormatoCheque.Click
        Dim f As New FRM_CONF_CHEQUERA
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub mnuTimbrado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTimbrado.Click
        If FRMS_CLAVE_MAESTRA("Acceso") = True Then
            Dim F As New FRM_PROFILE_DOC
            F.ShowDialog()
            F.Dispose()
        End If
    End Sub

    Private Sub mnuPermisosUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPermisosUsuarios.Click
        Dim f As New FRM_PERMISO_ROLES
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub mnuDiarioBancoCargosComisiones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDiarioBancoCargosComisiones.Click
        Dim f As New FRM_POPUP_CARGOS_COMISIONES
        f.ShowDialog()
        If f.Text = "ACEPTAR" Then
            If f.cmbTipo.Text = "REGISTRAR CARGOS BANCARIOS" Then
                FRMS_DIARIOBANCO("NC Bancaria")
            Else
                FRMS_DIARIOBANCO("ND Bancaria")
            End If
        End If

    End Sub

    Private Sub mnuCambiarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCambiarUsuario.Click
        If FRMS_LOGIN() = True Then
            LeerPermisos()
            User1.Text = "USUARIO..: " & User(2)
            Puesto.Text = "CARGO..: " & User(1)
        End If

    End Sub

    Private Sub MenuItem6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAhorrosNuevo.Click
        Dim f As New frmCuentaAhorros
        f.MdiParent = FRM_DEFAULT.GlobalForm
        f.Show()
    End Sub

    Private Sub mnuCategoriaAhorro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCategoriaAhorro.Click
        Dim f As New FRM_MANTENIMIENTO_CMB
        f.Tabla = "tbl_ahorros_categorias"
        f.Text = "Categorías de Ahorros"
        f.ShowDialog()
    End Sub

    Private Sub MenuItem6_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        Dim f As New FRM_NUMERACION_CTA
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub menuTipoDocCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuTipoDocCliente.Click
        Dim f As New FRM_MANTENIMIENTO_CMB
        f.Tabla = "tbl_tipos_documentos"
        f.Text = "Tipo de Indentidad para Clientes"
        f.ShowDialog()
    End Sub

    Private Sub mnuIngresosDevengados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuIngresosDevengados.Click
        AllReport("INGRESOS DEVENGADOS")
    End Sub

    Private Sub mnuRealizarRetiros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAhorrosRealizarRetiros.Click
        Dim f As New FRM_RETIROS
        f.ShowDialog()
        f.Dispose()
    End Sub


    Private Sub mnuActualizarInteres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuActualizarInteres.Click

        Dim f As New FRM_POPUP_UNA_FECHA
        f.ShowDialog()
        If f.Text = "ACEPTAR" Then
            aplicaInteres(f.DateTime2.Value)
        End If
        f.Dispose()

    End Sub
    Private Sub aplicaInteres(ByVal fecha As DateTime)
        Dim doc_date As Date, sys_date As Date

        sys_date = CDate(SCALAR_STRING("SELECT DATE(Now())"))


        If fecha = sys_date Then Exit Sub


        Dim show As New FrmPopupMessage
        show.Show("Generando interes diarios... Por favor espere")

        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT c.fld_id_cuotas, c.fld_fecha_entrega_cuotas, c.fld_fecha_termina_cuotas, p.fld_fecha_calcula_interes, p.fld_clasificacion, p.fld_interes_p, p.fld_id_prestamos, p.fld_capital_prestamo, p.fld_tipo_prestamo FROM tbl_cuotas AS c INNER JOIN tbl_prestamos AS p ON c.fld_id_del_prestamo=p.fld_id_prestamos WHERE MONTH(fld_fecha_termina_cuotas)= " & fecha.Month & " AND YEAR(fld_fecha_termina_cuotas)= " & fecha.Year & " AND c.fld_balance_cuotas > 0 ", conn)
        da.Fill(ds)

        Dim nr As DataRow


        Dim bceCapital As Double

        Dim dias As Integer = 0


        For Each nr In ds.Tables(0).Rows
            '
            '
            'Solo válidamos los préstamos que son con intereses diarios
            If nr("fld_clasificacion") = "Int. Diario Sobre Saldo Insoluto" Or nr("fld_clasificacion") = "Int. Diario Sobre Capital Inicial" Then
                'Validamos solo las que vence en el mes actual, esto es para controlar que no me le siga calculando a las cuotas que ya han sido calculada 
                'en su totalidad "Meses anteriores"
                bceCapital = SCALAR_NUM("SELECT SUM(fld_capital_cuota_balance) FROM tbl_cuotas WHERE fld_id_del_prestamo=" & nr("fld_id_prestamos") & "")


                dias = 30 'DateDiff(DateInterval.Day, nr("fld_fecha_calcula_interes"), sys_date) 'Devuelve los días desde el útimo
                'día que se calculo el interes

                Dim Interes As Double = 0

                If nr("fld_tipo_prestamo") = "DIARIO" Then
                    Interes = nr("fld_interes_p")
                ElseIf nr("fld_tipo_prestamo") = "SEMANAL" Then
                    Interes = nr("fld_interes_p") / 7
                ElseIf nr("fld_tipo_prestamo") = "QUINCENAL" Then
                    Interes = nr("fld_interes_p") / 15
                ElseIf nr("fld_tipo_prestamo") = "MENSUAL" Then
                    Interes = nr("fld_interes_p") / 30
                ElseIf nr("fld_tipo_prestamo") = "BIMESTRAL" Then
                    Interes = nr("fld_interes_p") / (30 * 2)
                ElseIf nr("fld_tipo_prestamo") = "TRIMESTRAL" Then
                    Interes = nr("fld_interes_p") / (30 * 3)
                ElseIf nr("fld_tipo_prestamo") = "SEMESTRAL" Then
                    Interes = nr("fld_interes_p") / (30 * 6)
                ElseIf nr("fld_tipo_prestamo") = "ANUAL" Then
                    Interes = nr("fld_interes_p") / (30 * 12)
                End If

                If nr("fld_clasificacion") = "Int. Diario Sobre Saldo Insoluto" Then
                    Interes = (bceCapital * Interes / 100) * dias
                ElseIf nr("fld_clasificacion") = "Int. Diario Sobre Capital Inicial" Then
                    Interes = CDbl((nr("fld_capital_prestamo") * Interes) / 100) * dias
                End If

                If dias > 0 Then
                    NON_QUERY("UPDATE tbl_cuotas SET fld_interes_cuota=fld_interes_cuota + " & Interes & ", fld_interes_cuota_balance=fld_interes_cuota-fld_interes_cuota_abono, fld_balance_cuotas=fld_interes_cuota_balance+fld_capital_cuota_balance, fld_monto_cuotas=fld_interes_cuota_balance+fld_capital_cuota_balance WHERE fld_id_cuotas=" & nr("fld_id_cuotas") & "; UPDATE tbl_prestamos SET fld_fecha_calcula_interes='" & formatDate(fecha) & "' WHERE fld_id_prestamos=" & nr("fld_id_prestamos") & "")
                End If

            End If
        Next
        show.Close()

    End Sub

    Private Sub aplicaInteres()

        Dim doc_date As Date, sys_date As Date

        sys_date = CDate(SCALAR_STRING("SELECT DATE(Now())"))
        Dim fechaCalculaIntere As Date = CDate(SCALAR_STRING("SELECT Fecha FROM tbl_calculainteres"))

        If DateDiff(DateInterval.Day, fechaCalculaIntere, sys_date) = 0 Then
            Exit Sub
        End If

        Dim show As New FrmPopupMessage
        show.Show("Generando interes diarios... Por favor espere")

        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT c.fld_no_cuotas, c.fld_id_cuotas, c.fld_fecha_entrega_cuotas, c.fld_fecha_termina_cuotas, c.fld_fecha_calculo_interes, p.fld_clasificacion, p.fld_interes_p, p.fld_id_prestamos, p.fld_capital_prestamo, p.fld_tipo_prestamo, p.fld_fecha_calcula_interes FROM tbl_cuotas AS c INNER JOIN tbl_prestamos AS p ON c.fld_id_del_prestamo=p.fld_id_prestamos WHERE c.fld_balance_cuotas > 0 AND fld_termina_calculo_interes<>'True' ORDER BY c.fld_id_cuotas", conn)
        da.Fill(ds)
        'MONTH(fld_fecha_termina_cuotas)= MONTH(Now()) AND YEAR(fld_fecha_termina_cuotas)= YEAR(Now()) AND
        Dim nr As DataRow

        Dim bceCapital As Double

        Dim dias As Integer = 0

        Dim fechaCalculoInteres As Date

        For Each nr In ds.Tables(0).Rows

            'Solo válidamos los préstamos que son con intereses diarios
            If nr("fld_clasificacion") = "Int. Diario Sobre Saldo Insoluto" Or nr("fld_clasificacion") = "Int. Diario Sobre Capital Inicial" Then
                'Válidamos solo las que vence en el mes actual, esto es para controlar que no me le siga calculando a las cuotas que ya han sido calculada 
                'en su totalidad "Meses anteriores"
                bceCapital = SCALAR_NUM("SELECT SUM(fld_capital_cuota_balance) FROM tbl_cuotas WHERE fld_id_del_prestamo=" & nr("fld_id_prestamos") & "")

                If nr("fld_fecha_calculo_interes") = nr("fld_fecha_entrega_cuotas") Then 'Nunca se ha cálculado el interes
                    dias = DateDiff(DateInterval.Day, CDate(nr("fld_fecha_termina_cuotas")).AddMonths(-1), sys_date)
                Else
                    dias = DateDiff(DateInterval.Day, CDate(nr("fld_fecha_calculo_interes")), sys_date)
                End If

                If dias < 1 Then 'Si el cálculo de los día arroja cero o menos entonces salta al siguiente registro
                    GoTo siguiente
                End If

                If dias >= 30 Then
                    NON_QUERY("UPDATE tbl_cuotas SET fld_termina_calculo_interes='True' WHERE fld_id_cuotas=" & nr("fld_id_cuotas") & "")
                    dias = 30
                End If

                Dim Interes As Double = 0

                If nr("fld_tipo_prestamo") = "DIARIO" Then
                    Interes = nr("fld_interes_p")
                ElseIf nr("fld_tipo_prestamo") = "SEMANAL" Then
                    Interes = nr("fld_interes_p") / 7
                ElseIf nr("fld_tipo_prestamo") = "QUINCENAL" Then
                    Interes = nr("fld_interes_p") / 15
                ElseIf nr("fld_tipo_prestamo") = "MENSUAL" Then
                    Interes = nr("fld_interes_p") / 30
                ElseIf nr("fld_tipo_prestamo") = "BIMESTRAL" Then
                    Interes = nr("fld_interes_p") / (30 * 2)
                ElseIf nr("fld_tipo_prestamo") = "TRIMESTRAL" Then
                    Interes = nr("fld_interes_p") / (30 * 3)
                ElseIf nr("fld_tipo_prestamo") = "SEMESTRAL" Then
                    Interes = nr("fld_interes_p") / (30 * 6)
                ElseIf nr("fld_tipo_prestamo") = "ANUAL" Then
                    Interes = nr("fld_interes_p") / (30 * 12)
                End If

                If nr("fld_clasificacion") = "Int. Diario Sobre Saldo Insoluto" Then
                    Interes = (bceCapital * Interes / 100) * dias
                ElseIf nr("fld_clasificacion") = "Int. Diario Sobre Capital Inicial" Then
                    Interes = CDbl((nr("fld_capital_prestamo") * Interes) / 100) * dias
                End If

                If dias > 0 Then

                    NON_QUERY("UPDATE tbl_cuotas SET fld_interes_cuota=fld_interes_cuota + " & Interes & ", fld_interes_cuota_balance=fld_interes_cuota-fld_interes_cuota_abono, fld_balance_cuotas=fld_interes_cuota_balance+fld_capital_cuota_balance, fld_monto_cuotas=fld_interes_cuota_balance+fld_capital_cuota_balance, fld_abono_cuotas=(fld_monto_cuotas-fld_balance_cuotas) WHERE fld_id_cuotas=" & nr("fld_id_cuotas") & "; UPDATE tbl_prestamos SET fld_fecha_calcula_interes=Now() WHERE fld_id_prestamos=" & nr("fld_id_prestamos") & "")
                End If
            End If
siguiente:
        Next
        NON_QUERY("UPDATE tbl_calculainteres SET Fecha=Now()")
        show.Close()

    End Sub


    Private Sub mnuCatalogoCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCatalogoCuenta.Click
        FrmsCatalagoCuentasContable()
    End Sub

    Private Sub mnuMaestroDeTransacciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMaestroDeTransacciones.Click
        frmsTipoTransaccion()
    End Sub

    Private Sub mnuEntradaDeDiarioNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEntradaDeDiarioNueva.Click
        FrmTrasacciones()
    End Sub

    Private Sub mnuEntradaDeDiarioConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEntradaDeDiarioConsultar.Click
        frmsConsultaTrasacciones()
    End Sub

    Private Sub mnuBalanceComprobacionResumido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBalanceComprobacionResumido.Click
        AllReport_una_fechaMes("Resumen del Balance de Comprobación Mes")
    End Sub

    Private Sub mnuBalanceComprobacionDetallado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBalanceComprobacionDetallado.Click
        AllReport("Balance de Comprobación Detalle")
    End Sub

    Private Sub mnuBalanceGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBalanceGeneral.Click
        AllReport_una_fechaMes("Estado de Situación")
    End Sub

    Private Sub mnuEstadoDeResultado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEstadoDeResultado.Click
        AllReport_una_fechaMes("Balance de Resultado")
    End Sub

    Private Sub mnuLibroMayorGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLibroMayorGeneral.Click
        Dim f As New frmSeleccionarCtaUnaContable
        f.ShowDialog()
        If f.Text = "ACEPTAR" Then
            AllReport("LIBRO_MAYOR_GENERAL")
        End If
        f.Dispose()
    End Sub

    Private Sub mnuLibroDiarioGeneralRangoDeCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmSeleccionarCtaDosContable
        f.ShowDialog()
        If f.Text = "ACEPTAR" Then
            AllReport("LIBRO_DIARIO_GENERAL_POR_CUENTA")
        End If
        f.Dispose()
    End Sub

    Private Sub mnuLitadoCatalogoDeCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLitadoCatalogoDeCuenta.Click
        AllReportSinFecha("Catalogo de Cuentas Contable")
    End Sub

    Private Sub mnuConfiguracionContabilidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConfiguracionContabilidad.Click
        FRMS_PROFILE_CONTABILIDAD()
    End Sub


    Private Sub mnuAhorrosSaldos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAhorrosSaldos.Click

        'AllReportSinFecha("Listado de Saldos")

    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrestamosTabla.Click
        Dim f As New FRM_TABLA_PRESTAMOS
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub mnuAhorrosRetiros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAhorrosRetiros.Click
        AllReport("Listado de Retiros")
    End Sub

    Private Sub mnuAhorrosEstadoCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAhorrosEstadoCuenta.Click
        Dim f As New frmEstadoCuentaAhorro
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub mnuLibroDiarioGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLibroDiarioGeneral.Click
        AllReport("LIBRO_DIARIO_GENERAL")
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        Dim f As New frmDepositos
        f.MdiParent = FRM_DEFAULT.GlobalForm
        f.Show()
    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        AllReport("Listado de Depósitos/Ahorros")
    End Sub

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        If FRMS_LIST_BANCOS() = False Then Exit Sub
        'Estado = "EMISION"
        AllReport("CK_UNO_NULOS")

    End Sub

    Private Sub mnuArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuArchivo.Click

    End Sub

    Private Sub mnuAhorrosCertificadosApertura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAhorrosCertificadosApertura.Click
        Dim f As New frmCertificadoApertura
        f.MdiParent = FRM_DEFAULT.GlobalForm
        f.Show()
    End Sub

    Private Sub mnuAhorrosCertificadosCancelacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAhorrosCertificadosCancelacion.Click
        Dim f As New frmCertificadoRetiro
        f.MdiParent = FRM_DEFAULT.GlobalForm
        f.Show()
    End Sub

    Private Sub mnuCajaMentenimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCajaMentenimiento.Click
        Dim f As New frmCajaMantenimiento
        f.MdiParent = FRM_DEFAULT.GlobalForm
        f.Show()
    End Sub

    Private Sub mnuAhorroAporteSocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAhorroAporteSocio.Click
        Dim f As New frmAporteSocio
        f.MdiParent = FRM_DEFAULT.GlobalForm
        f.Show()
    End Sub

    Private Sub mnuAhorrosCertificadosListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAhorrosCertificadosListado.Click
        AllReport("Listado de Certificados de Socios")
    End Sub

    Private Sub repOtrosIngresos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repOtrosIngresos.Click
        AllReportCaja("LISTADO DE OTROS INGRESOS")
    End Sub

    Private Sub mnuConfiguracionGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConfiguracionGeneral.Click
        Dim f As New frmConfiguracion
        f.ShowDialog()
        f.Dispose()
    End Sub



    Private Sub mnuSolicitudCredito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSolicitudCredito.Click
        Dim f As New frmSolicitudCredito
        f.ShowDialog()
        f.Dispose()
        'DashboarSolicitudPrestamos.ShowDialog()

    End Sub

    Private Sub MnTipoDeCuentaSaldos_Click(sender As Object, e As EventArgs) Handles MnTipoDeCuentaSaldos.Click
        Tipo_Cuenta.ShowDialog()
    End Sub

    Private Sub MnTodosLosSaldos_Click(sender As Object, e As EventArgs) Handles MnTodosLosSaldos.Click
        AllReportSinFecha("Listado de Saldos")
    End Sub

    Private Sub MenuItem39_Click(sender As Object, e As EventArgs) Handles MenuItem39.Click
        Crear_Anulaciones.ShowDialog()
    End Sub

    Private Sub MenuItem41_Click(sender As Object, e As EventArgs) Handles MenuItem41.Click
        SaldoPorAntiguedadPrestamos.ShowDialog()

    End Sub

    Private Sub MenuItem43_Click(sender As Object, e As EventArgs) Handles MenuItem43.Click
        FrmParametros_SaldosXAntiguedad.ShowDialog()
    End Sub

    Private Sub MnuPar_Saldo_Por_Antiguedad_Click(sender As Object, e As EventArgs) Handles MnuPar_Saldo_Por_Antiguedad.Click
        FrmParametros_SaldosXAntiguedad.ShowDialog()
    End Sub

    Private Sub MnuActualiarLibretas_Click(sender As Object, e As EventArgs) Handles MnuActualiarLibretas.Click
        FrmActualiarLibrera.ShowDialog()
    End Sub

    Private Sub mnuAhorrosListadoAportesUnSocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAhorrosListadoAportesUnSocio.Click
        If FRMS_POPUP_CLIENTES("TODOS") = True Then
            AllReportSinFecha("Listado de Aportes de un Socio")
        End If

    End Sub

    Private Sub mnuAhorrosListadoAportesTodosLosSocios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAhorrosListadoAportesTodosLosSocios.Click
        AllReportSinFecha("Listado de Aportes de Socios")
    End Sub
End Class
