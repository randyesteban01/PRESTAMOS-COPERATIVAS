Imports Microsoft.VisualBasic
Public Class FRM_ESTADO_FINANCIERO
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtSupermercado As System.Windows.Forms.TextBox
    Friend WithEvents txtAgua As System.Windows.Forms.TextBox
    Friend WithEvents txtLuz As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtTelecable As System.Windows.Forms.TextBox
    Friend WithEvents txtServiciosDomestico As System.Windows.Forms.TextBox
    Friend WithEvents txtOtrosEgresos As System.Windows.Forms.TextBox
    Friend WithEvents txtEfectivoBanco As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalIngresos As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalEgresos As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalGeneral As System.Windows.Forms.TextBox
    Friend WithEvents txtOtrosActivos As System.Windows.Forms.TextBox
    Friend WithEvents txtVehiculo As System.Windows.Forms.TextBox
    Friend WithEvents txtOtrosPasivos As System.Windows.Forms.TextBox
    Friend WithEvents txtDocumentoPorPagar As System.Windows.Forms.TextBox
    Friend WithEvents txtHipoteca As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalActivos As System.Windows.Forms.TextBox
    Friend WithEvents txtCapital As System.Windows.Forms.TextBox
    Friend WithEvents txtPasivoCapital As System.Windows.Forms.TextBox
    Friend WithEvents txtIDDoc As System.Windows.Forms.TextBox
    Friend WithEvents txtIDCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtSalario As System.Windows.Forms.TextBox
    Friend WithEvents txtOtrosIngresos As System.Windows.Forms.TextBox
    Friend WithEvents txtAlquiler As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaPorCobrar As System.Windows.Forms.TextBox
    Friend WithEvents txtBienesInmuebles As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_ESTADO_FINANCIERO))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSalario = New System.Windows.Forms.TextBox
        Me.txtOtrosIngresos = New System.Windows.Forms.TextBox
        Me.txtAlquiler = New System.Windows.Forms.TextBox
        Me.txtSupermercado = New System.Windows.Forms.TextBox
        Me.txtAgua = New System.Windows.Forms.TextBox
        Me.txtLuz = New System.Windows.Forms.TextBox
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.txtTelecable = New System.Windows.Forms.TextBox
        Me.txtServiciosDomestico = New System.Windows.Forms.TextBox
        Me.txtOtrosEgresos = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtOtrosActivos = New System.Windows.Forms.TextBox
        Me.txtBienesInmuebles = New System.Windows.Forms.TextBox
        Me.txtVehiculo = New System.Windows.Forms.TextBox
        Me.txtEfectivoBanco = New System.Windows.Forms.TextBox
        Me.txtCuentaPorCobrar = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtOtrosPasivos = New System.Windows.Forms.TextBox
        Me.txtDocumentoPorPagar = New System.Windows.Forms.TextBox
        Me.txtHipoteca = New System.Windows.Forms.TextBox
        Me.txtTotalIngresos = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtTotalEgresos = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtTotalGeneral = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtTotalActivos = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtCapital = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtPasivoCapital = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.txtIDDoc = New System.Windows.Forms.TextBox
        Me.txtIDCliente = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INGRESOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSalario
        '
        Me.txtSalario.Location = New System.Drawing.Point(113, 33)
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.TabIndex = 1
        Me.txtSalario.Text = "0.00"
        Me.txtSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOtrosIngresos
        '
        Me.txtOtrosIngresos.Location = New System.Drawing.Point(113, 57)
        Me.txtOtrosIngresos.Name = "txtOtrosIngresos"
        Me.txtOtrosIngresos.TabIndex = 2
        Me.txtOtrosIngresos.Text = "0.00"
        Me.txtOtrosIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAlquiler
        '
        Me.txtAlquiler.Location = New System.Drawing.Point(129, 225)
        Me.txtAlquiler.Name = "txtAlquiler"
        Me.txtAlquiler.TabIndex = 4
        Me.txtAlquiler.Text = "0.00"
        Me.txtAlquiler.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSupermercado
        '
        Me.txtSupermercado.Location = New System.Drawing.Point(129, 249)
        Me.txtSupermercado.Name = "txtSupermercado"
        Me.txtSupermercado.TabIndex = 3
        Me.txtSupermercado.Text = "0.00"
        Me.txtSupermercado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAgua
        '
        Me.txtAgua.Location = New System.Drawing.Point(129, 273)
        Me.txtAgua.Name = "txtAgua"
        Me.txtAgua.TabIndex = 6
        Me.txtAgua.Text = "0.00"
        Me.txtAgua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLuz
        '
        Me.txtLuz.Location = New System.Drawing.Point(129, 297)
        Me.txtLuz.Name = "txtLuz"
        Me.txtLuz.TabIndex = 5
        Me.txtLuz.Text = "0.00"
        Me.txtLuz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(129, 321)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.TabIndex = 8
        Me.txtTelefono.Text = "0.00"
        Me.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTelecable
        '
        Me.txtTelecable.Location = New System.Drawing.Point(129, 345)
        Me.txtTelecable.Name = "txtTelecable"
        Me.txtTelecable.TabIndex = 7
        Me.txtTelecable.Text = "0.00"
        Me.txtTelecable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtServiciosDomestico
        '
        Me.txtServiciosDomestico.Location = New System.Drawing.Point(129, 369)
        Me.txtServiciosDomestico.Name = "txtServiciosDomestico"
        Me.txtServiciosDomestico.TabIndex = 10
        Me.txtServiciosDomestico.Text = "0.00"
        Me.txtServiciosDomestico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOtrosEgresos
        '
        Me.txtOtrosEgresos.Location = New System.Drawing.Point(129, 393)
        Me.txtOtrosEgresos.Name = "txtOtrosEgresos"
        Me.txtOtrosEgresos.TabIndex = 9
        Me.txtOtrosEgresos.Text = "0.00"
        Me.txtOtrosEgresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "EGRESOS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(9, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Salario :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(9, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Otros Ingresos :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(25, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Alquiler :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(25, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Supermercado :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(25, 273)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Agua :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(25, 297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Luz :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(25, 321)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Teléfono :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(25, 345)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 16)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Telecable :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(9, 369)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 16)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Servicio doméstico :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(25, 393)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 16)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Otros Egresos :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(377, 129)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 16)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Otros activos :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(377, 105)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 16)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Vehículos :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(361, 81)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 16)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Bienes inmuebles :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(353, 57)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(120, 16)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Cuentas por cobrar :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(345, 33)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 16)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Efectivo en Banco :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(345, 1)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 16)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "ACTIVOS"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOtrosActivos
        '
        Me.txtOtrosActivos.Location = New System.Drawing.Point(481, 129)
        Me.txtOtrosActivos.Name = "txtOtrosActivos"
        Me.txtOtrosActivos.TabIndex = 26
        Me.txtOtrosActivos.Text = "0.00"
        Me.txtOtrosActivos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBienesInmuebles
        '
        Me.txtBienesInmuebles.Location = New System.Drawing.Point(481, 81)
        Me.txtBienesInmuebles.Name = "txtBienesInmuebles"
        Me.txtBienesInmuebles.TabIndex = 25
        Me.txtBienesInmuebles.Text = "0.00"
        Me.txtBienesInmuebles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVehiculo
        '
        Me.txtVehiculo.Location = New System.Drawing.Point(481, 105)
        Me.txtVehiculo.Name = "txtVehiculo"
        Me.txtVehiculo.TabIndex = 24
        Me.txtVehiculo.Text = "0.00"
        Me.txtVehiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEfectivoBanco
        '
        Me.txtEfectivoBanco.Location = New System.Drawing.Point(481, 33)
        Me.txtEfectivoBanco.Name = "txtEfectivoBanco"
        Me.txtEfectivoBanco.TabIndex = 23
        Me.txtEfectivoBanco.Text = "0.00"
        Me.txtEfectivoBanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCuentaPorCobrar
        '
        Me.txtCuentaPorCobrar.Location = New System.Drawing.Point(481, 57)
        Me.txtCuentaPorCobrar.Name = "txtCuentaPorCobrar"
        Me.txtCuentaPorCobrar.TabIndex = 22
        Me.txtCuentaPorCobrar.Text = "0.00"
        Me.txtCuentaPorCobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(377, 273)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(100, 16)
        Me.Label19.TabIndex = 39
        Me.Label19.Text = "Otros pasivos :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(377, 249)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 16)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "Hipotecas :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(345, 225)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(128, 16)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "Documentos por pagar :"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(345, 193)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(120, 16)
        Me.Label22.TabIndex = 36
        Me.Label22.Text = "PASIVO Y CAPITAL"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOtrosPasivos
        '
        Me.txtOtrosPasivos.Location = New System.Drawing.Point(481, 273)
        Me.txtOtrosPasivos.Name = "txtOtrosPasivos"
        Me.txtOtrosPasivos.TabIndex = 35
        Me.txtOtrosPasivos.Text = "0.00"
        Me.txtOtrosPasivos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDocumentoPorPagar
        '
        Me.txtDocumentoPorPagar.Location = New System.Drawing.Point(481, 225)
        Me.txtDocumentoPorPagar.Name = "txtDocumentoPorPagar"
        Me.txtDocumentoPorPagar.TabIndex = 34
        Me.txtDocumentoPorPagar.Text = "0.00"
        Me.txtDocumentoPorPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHipoteca
        '
        Me.txtHipoteca.Location = New System.Drawing.Point(481, 249)
        Me.txtHipoteca.Name = "txtHipoteca"
        Me.txtHipoteca.TabIndex = 33
        Me.txtHipoteca.Text = "0.00"
        Me.txtHipoteca.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalIngresos
        '
        Me.txtTotalIngresos.Enabled = False
        Me.txtTotalIngresos.Location = New System.Drawing.Point(217, 89)
        Me.txtTotalIngresos.Name = "txtTotalIngresos"
        Me.txtTotalIngresos.TabIndex = 40
        Me.txtTotalIngresos.Text = "0.00"
        Me.txtTotalIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(9, 89)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(152, 16)
        Me.Label24.TabIndex = 42
        Me.Label24.Text = "TOTAL INGRESOS"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(9, 417)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(152, 16)
        Me.Label23.TabIndex = 44
        Me.Label23.Text = "TOTAL EGRESOS"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalEgresos
        '
        Me.txtTotalEgresos.Enabled = False
        Me.txtTotalEgresos.Location = New System.Drawing.Point(217, 417)
        Me.txtTotalEgresos.Name = "txtTotalEgresos"
        Me.txtTotalEgresos.TabIndex = 43
        Me.txtTotalEgresos.Text = "0.00"
        Me.txtTotalEgresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(9, 449)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(152, 16)
        Me.Label25.TabIndex = 46
        Me.Label25.Text = "TOTAL GENERAL"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalGeneral
        '
        Me.txtTotalGeneral.Enabled = False
        Me.txtTotalGeneral.Location = New System.Drawing.Point(217, 449)
        Me.txtTotalGeneral.Name = "txtTotalGeneral"
        Me.txtTotalGeneral.TabIndex = 45
        Me.txtTotalGeneral.Text = "0.00"
        Me.txtTotalGeneral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(345, 161)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(152, 16)
        Me.Label26.TabIndex = 48
        Me.Label26.Text = "TOTAL ACTIVOS"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalActivos
        '
        Me.txtTotalActivos.Enabled = False
        Me.txtTotalActivos.Location = New System.Drawing.Point(585, 161)
        Me.txtTotalActivos.Name = "txtTotalActivos"
        Me.txtTotalActivos.TabIndex = 47
        Me.txtTotalActivos.Text = "0.00"
        Me.txtTotalActivos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(377, 313)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(100, 16)
        Me.Label27.TabIndex = 50
        Me.Label27.Text = "Capital :"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCapital
        '
        Me.txtCapital.Location = New System.Drawing.Point(481, 313)
        Me.txtCapital.Name = "txtCapital"
        Me.txtCapital.TabIndex = 49
        Me.txtCapital.Text = "0.00"
        Me.txtCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(345, 353)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(152, 16)
        Me.Label28.TabIndex = 52
        Me.Label28.Text = "TOTAL PASIVO Y CAPITAL"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPasivoCapital
        '
        Me.txtPasivoCapital.Enabled = False
        Me.txtPasivoCapital.Location = New System.Drawing.Point(585, 353)
        Me.txtPasivoCapital.Name = "txtPasivoCapital"
        Me.txtPasivoCapital.TabIndex = 51
        Me.txtPasivoCapital.Text = "0.00"
        Me.txtPasivoCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(1, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 184)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(1, 193)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(328, 288)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(337, 1)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(360, 184)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(337, 193)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(360, 192)
        Me.GroupBox4.TabIndex = 56
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrar.Location = New System.Drawing.Point(624, 393)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 56)
        Me.btnCerrar.TabIndex = 58
        Me.btnCerrar.TabStop = False
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(552, 393)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(72, 56)
        Me.btnGuardar.TabIndex = 57
        Me.btnGuardar.TabStop = False
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtIDDoc
        '
        Me.txtIDDoc.Location = New System.Drawing.Point(344, 408)
        Me.txtIDDoc.Name = "txtIDDoc"
        Me.txtIDDoc.Size = New System.Drawing.Size(40, 20)
        Me.txtIDDoc.TabIndex = 60
        Me.txtIDDoc.Text = "0"
        Me.txtIDDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtIDDoc.Visible = False
        '
        'txtIDCliente
        '
        Me.txtIDCliente.Location = New System.Drawing.Point(344, 384)
        Me.txtIDCliente.Name = "txtIDCliente"
        Me.txtIDCliente.Size = New System.Drawing.Size(40, 20)
        Me.txtIDCliente.TabIndex = 59
        Me.txtIDCliente.Text = "0"
        Me.txtIDCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtIDCliente.Visible = False
        '
        'FRM_ESTADO_FINANCIERO
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(698, 483)
        Me.Controls.Add(Me.txtIDDoc)
        Me.Controls.Add(Me.txtIDCliente)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtPasivoCapital)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txtCapital)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.txtTotalActivos)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtTotalGeneral)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtTotalEgresos)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtTotalIngresos)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtOtrosPasivos)
        Me.Controls.Add(Me.txtDocumentoPorPagar)
        Me.Controls.Add(Me.txtHipoteca)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtOtrosActivos)
        Me.Controls.Add(Me.txtBienesInmuebles)
        Me.Controls.Add(Me.txtVehiculo)
        Me.Controls.Add(Me.txtEfectivoBanco)
        Me.Controls.Add(Me.txtCuentaPorCobrar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtServiciosDomestico)
        Me.Controls.Add(Me.txtOtrosEgresos)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtTelecable)
        Me.Controls.Add(Me.txtAgua)
        Me.Controls.Add(Me.txtLuz)
        Me.Controls.Add(Me.txtAlquiler)
        Me.Controls.Add(Me.txtSupermercado)
        Me.Controls.Add(Me.txtOtrosIngresos)
        Me.Controls.Add(Me.txtSalario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_ESTADO_FINANCIERO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estado Financiero"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FRM_ESTADO_FINANCIERO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon


    End Sub

    Function ValidarDocumento() As Boolean

        If txtSalario.Text.Empty = True Then
            txtSalario.Text = "0.00"
        End If

        If txtOtrosIngresos.Text.Empty = True Then
            txtOtrosIngresos.Text = "0.00"
        End If


        If txtAlquiler.Text.Empty = True Then
            txtAlquiler.Text = "0.00"
        End If


        If txtSupermercado.Text.Empty = True Then
            txtSupermercado.Text = "0.00"
        End If

        If txtAgua.Text.Empty = True Then
            txtAgua.Text = "0.00"
        End If


        If txtLuz.Text.Empty = True Then
            txtLuz.Text = "0.00"
        End If


        If txtTelefono.Text.Empty = True Then
            txtTelefono.Text = "0.00"
        End If


        If txtServiciosDomestico.Text.Empty = True Then
            txtServiciosDomestico.Text = "0.00"
        End If


        If txtOtrosEgresos.Text.Empty = True Then
            txtOtrosEgresos.Text = "0.00"
        End If


        If txtEfectivoBanco.Text.Empty = True Then
            txtEfectivoBanco.Text = "0.00"
        End If


        If txtCuentaPorCobrar.Text.Empty = True Then
            txtCuentaPorCobrar.Text = "0.00"
        End If


        If txtBienesInmuebles.Text.Empty = True Then
            txtBienesInmuebles.Text = "0.00"
        End If


        If txtVehiculo.Text.Empty = True Then
            txtVehiculo.Text = "0.00"
        End If


        If txtOtrosActivos.Text.Empty = True Then
            txtOtrosActivos.Text = "0.00"
        End If


        If txtDocumentoPorPagar.Text.Empty = True Then
            txtDocumentoPorPagar.Text = "0.00"
        End If


        If txtHipoteca.Text.Empty = True Then
            txtHipoteca.Text = "0.00"
        End If


        If txtOtrosPasivos.Text.Empty = True Then
            txtOtrosPasivos.Text = "0.00"
        End If


        If txtCapital.Text.Empty = True Then
            txtCapital.Text = "0.00"
        End If


    End Function

    Private Sub NuevoDocumento()
        txtSalario.Text = "0.00"
        txtOtrosIngresos.Text = "0.00"
        txtAlquiler.Text = "0.00"
        txtSupermercado.Text = "0.00"
        txtAgua.Text = "0.00"
        txtLuz.Text = "0.00"
        txtTelefono.Text = "0.00"
        txtServiciosDomestico.Text = "0.00"
        txtOtrosEgresos.Text = "0.00"
        txtEfectivoBanco.Text = "0.00"
        txtCuentaPorCobrar.Text = "0.00"
        txtBienesInmuebles.Text = "0.00"
        txtVehiculo.Text = "0.00"
        txtOtrosActivos.Text = "0.00"
        txtDocumentoPorPagar.Text = "0.00"
        txtHipoteca.Text = "0.00"
        txtOtrosPasivos.Text = "0.00"
        txtCapital.Text = "0.00"
    End Sub

    Private Sub GuardarDocumento()
        NON_QUERY("INSERT INTO tbl_clientes_estados_finaciero (Fecha, ingSalario, ingOtros, egrAlquiles, egrSupermercado, egrAgua, egrLuz, egrTelefono, egrTelecable, egrServiciosDomesticos, egrOtros, actEfectivoBanco, actCuentaXCobrar, actBienesInmuebles, actVehiculo, actOtros, pasDocumentoXpagar, pasHipotecas, pasOtros, Capital, IDCliente) VALUES(Now()," & CDbl(txtSalario.Text) & "," & CDbl(txtOtrosIngresos.Text) & "," & CDbl(txtAlquiler.Text) & "," & CDbl(txtSupermercado.Text) & "," & CDbl(txtAgua.Text) & "," & CDbl(txtLuz.Text) & "," & CDbl(txtTelefono.Text) & "," & CDbl(txtTelecable.Text) & "," & CDbl(txtServiciosDomestico.Text) & "," & CDbl(txtOtrosEgresos.Text) & "," & CDbl(txtEfectivoBanco.Text) & "," & CDbl(txtCuentaPorCobrar.Text) & "," & CDbl(txtBienesInmuebles.Text) & "," & CDbl(txtVehiculo.Text) & "," & CDbl(txtOtrosActivos.Text) & "," & CDbl(txtDocumentoPorPagar.Text) & "," & CDbl(txtHipoteca.Text) & "," & CDbl(txtOtrosPasivos.Text) & "," & CDbl(txtCapital.Text) & "," & CInt(txtIDCliente.Text) & ")")
    End Sub

    Private Sub ModificarDocumento()
        NON_QUERY("UPDATE tbl_clientes_estados_finaciero SET ingSalario=" & CDbl(txtSalario.Text) & ", ingOtros=" & CDbl(txtOtrosIngresos.Text) & ", egrAlquiles=" & CDbl(txtAlquiler.Text) & ", egrSupermercado=" & CDbl(txtSupermercado.Text) & ", egrAgua=" & CDbl(txtAgua.Text) & ", egrLuz=" & CDbl(txtLuz.Text) & ", egrTelefono=" & CDbl(txtTelefono.Text) & ", egrTelecable=" & CDbl(txtTelecable.Text) & ", egrServiciosDomesticos=" & CDbl(txtServiciosDomestico.Text) & ", egrOtros=" & CDbl(txtOtrosEgresos.Text) & ", actEfectivoBanco=" & CDbl(txtEfectivoBanco.Text) & ", actCuentaXCobrar=" & CDbl(txtCuentaPorCobrar.Text) & ", actBienesInmuebles=" & CDbl(txtBienesInmuebles.Text) & ", actVehiculo=" & CDbl(txtVehiculo.Text) & ", actOtros=" & CDbl(txtOtrosActivos.Text) & ", pasDocumentoXpagar=" & CDbl(txtDocumentoPorPagar.Text) & ", pasHipotecas=" & CDbl(txtHipoteca.Text) & ", pasOtros=" & CDbl(txtOtrosPasivos.Text) & ", Capital=" & CDbl(txtCapital.Text) & " WHERE ID=" & CInt(txtIDDoc.Text) & "")
    End Sub

    Private Sub txtSalario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSalario.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtOtrosIngresos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOtrosIngresos.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAlquiler_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAlquiler.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSupermercado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSupermercado.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAgua_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAgua.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtLuz_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLuz.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelecable_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelecable.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtServiciosDomestico_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtServiciosDomestico.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtOtrosEgresos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOtrosEgresos.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEfectivoBanco_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEfectivoBanco.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCuentaPorCobrar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuentaPorCobrar.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtBienesInmuebles_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBienesInmuebles.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtVehiculo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVehiculo.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtOtrosActivos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOtrosActivos.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDocumentoPorPagar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDocumentoPorPagar.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtHipoteca_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHipoteca.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtOtrosPasivos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOtrosPasivos.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCapital_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCapital.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub


End Class
