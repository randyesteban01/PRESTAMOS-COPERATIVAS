Imports MySql.Data.MySqlClient
Public Class frmSolicitudCredito
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
    Friend WithEvents btn_nuevo_cliente As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblApellidos As System.Windows.Forms.Label
    Friend WithEvents btnListaPrestamos As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnImprime As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAccion As System.Windows.Forms.Button
    Friend WithEvents comentarioBtn As System.Windows.Forms.Button
    Friend WithEvents socioExistenteBtn As System.Windows.Forms.Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents RbCasa_Propia As RadioButton
    Friend WithEvents RbCasa_Alquilada As RadioButton
    Friend WithEvents TxtCedula As MaskedTextBox
    Friend WithEvents fld_phone As MaskedTextBox
    Friend WithEvents fld_phone2 As MaskedTextBox
    Friend WithEvents Fld_direccion As TextBox
    Friend WithEvents Fld_Provincia As TextBox
    Friend WithEvents Fld_Municipio As TextBox
    Friend WithEvents Fld_Barrio As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Fld_Emp_agno As TextBox
    Friend WithEvents Fld_emp_meses As TextBox
    Friend WithEvents Fld_email As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Fld_emppresa As TextBox
    Friend WithEvents Fld_tiempo_vivienda As TextBox
    Friend WithEvents fld_tiempo_alquiler As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Fld_phone3 As MaskedTextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label47 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents fld_tel_codeudor As MaskedTextBox
    Friend WithEvents fld_Codeudor As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents fld_tel_flia As MaskedTextBox
    Friend WithEvents fld_nomFlia As TextBox
    Friend WithEvents Fld_tel_conyugue As MaskedTextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents fld_nomConyugue As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents CobPrestamos As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GastoLegalTxt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents SeguroTxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents MontoSolicitadoTxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTasaIntere As Label
    Friend WithEvents fld_tipo_prestamo As ComboBox
    Friend WithEvents fld_porciento As TextBox
    Friend WithEvents fld_monto_prestamo As TextBox
    Friend WithEvents fld_clasificacion As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents fld_fecha_entrega As DateTimePicker
    Friend WithEvents fld_cod_prestamo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents fld_cantidad_cuotas As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMontoCuota As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents fldTazaMora As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtNotaGeneral As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label46 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label56 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents fld_total_gastos_fliares As TextBox
    Friend WithEvents fld_otros_fliares As TextBox
    Friend WithEvents Label78 As Label
    Friend WithEvents Label79 As Label
    Friend WithEvents Label80 As Label
    Friend WithEvents Label82 As Label
    Friend WithEvents Label83 As Label
    Friend WithEvents fld_Ingreso_conyugue As TextBox
    Friend WithEvents Label84 As Label
    Friend WithEvents fld_OtrosNegocios As TextBox
    Friend WithEvents Label85 As Label
    Friend WithEvents Label86 As Label
    Friend WithEvents Label87 As Label
    Friend WithEvents Label89 As Label
    Friend WithEvents Label95 As Label
    Friend WithEvents Label97 As Label
    Friend WithEvents fld_educacion As TextBox
    Friend WithEvents fld_transporte As TextBox
    Friend WithEvents fld_alimentacion As TextBox
    Friend WithEvents fld_remesas_fliares As TextBox
    Friend WithEvents fld_total_ingresos_fliares As TextBox
    Friend WithEvents fld_vivienda As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label90 As Label
    Friend WithEvents Label92 As Label
    Friend WithEvents Fld_Deudas_Bancarias As TextBox
    Friend WithEvents Label100 As Label
    Friend WithEvents Label101 As Label
    Friend WithEvents Fld_Total_Activo_4_9 As TextBox
    Friend WithEvents Fld_Total_Activo_Fijo As TextBox
    Friend WithEvents Label107 As Label
    Friend WithEvents Label108 As Label
    Friend WithEvents Fld_Servicios As TextBox
    Friend WithEvents Label109 As Label
    Friend WithEvents Fld_mant_reparacion As TextBox
    Friend WithEvents Label110 As Label
    Friend WithEvents fld_alquileres As TextBox
    Friend WithEvents Label112 As Label
    Friend WithEvents fld_Cuotas_Otros_Prestamos As TextBox
    Friend WithEvents Fld_Trans_Combustible As TextBox
    Friend WithEvents Label114 As Label
    Friend WithEvents Label115 As Label
    Friend WithEvents Fld_Capital_10_14 As TextBox
    Friend WithEvents Label116 As Label
    Friend WithEvents Label122 As Label
    Friend WithEvents Label123 As Label
    Friend WithEvents Label124 As Label
    Friend WithEvents Label127 As Label
    Friend WithEvents Fld_efectivo_Caja As TextBox
    Friend WithEvents Label128 As Label
    Friend WithEvents fld_Ventas_Ingresos As TextBox
    Friend WithEvents Label129 As Label
    Friend WithEvents Label130 As Label
    Friend WithEvents Label132 As Label
    Friend WithEvents Label134 As Label
    Friend WithEvents Label136 As Label
    Friend WithEvents Label137 As Label
    Friend WithEvents Label138 As Label
    Friend WithEvents Label139 As Label
    Friend WithEvents Label140 As Label
    Friend WithEvents Label142 As Label
    Friend WithEvents fld_salario As TextBox
    Friend WithEvents fld_margen_bruto As TextBox
    Friend WithEvents Fld_Otros_Activos As TextBox
    Friend WithEvents Fld_inventario As TextBox
    Friend WithEvents fld_compras_mes As TextBox
    Friend WithEvents Fld_Total_Activo As TextBox
    Friend WithEvents Fld_Mobiliario As TextBox
    Friend WithEvents Fld_Maquinaria_Equipos As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label164 As Label
    Friend WithEvents Label170 As Label
    Friend WithEvents Label172 As Label
    Friend WithEvents fld_Dispo_de_fondo As TextBox
    Friend WithEvents Label177 As Label
    Friend WithEvents Label179 As Label
    Friend WithEvents Label183 As Label
    Friend WithEvents Label186 As Label
    Friend WithEvents fld_monto_recomendado As TextBox
    Friend WithEvents fldComentario_Oficial As TextBox
    Friend WithEvents Fld_CxC As TextBox
    Friend WithEvents Fld_Inmueble_terreno As TextBox
    Friend WithEvents Label103 As Label
    Friend WithEvents Fld_CxP_Suplidores As TextBox
    Friend WithEvents Label102 As Label
    Friend WithEvents Fld_Total_Pasivo_10_14 As TextBox
    Friend WithEvents Fld_Otras_CxP As TextBox
    Friend WithEvents Fld_Total_Pasivo_Capital As TextBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label96 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents fld_Otros_Gastos As TextBox
    Friend WithEvents Label98 As Label
    Friend WithEvents fld_Total_de_Gastos As TextBox
    Friend WithEvents fld_Beneficio_neto As TextBox
    Friend WithEvents Label99 As Label
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Label93 As Label
    Friend WithEvents Label94 As Label
    Friend WithEvents Label104 As Label
    Friend WithEvents fld_Comentario_Analista As TextBox
    Friend WithEvents Fld_Comentario_Encargado As TextBox
    Friend WithEvents BtnVerSolicitud As Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSolicitudCredito))
        Me.btn_nuevo_cliente = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.btnListaPrestamos = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnImprime = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAccion = New System.Windows.Forms.Button()
        Me.comentarioBtn = New System.Windows.Forms.Button()
        Me.socioExistenteBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.RbCasa_Propia = New System.Windows.Forms.RadioButton()
        Me.RbCasa_Alquilada = New System.Windows.Forms.RadioButton()
        Me.TxtCedula = New System.Windows.Forms.MaskedTextBox()
        Me.fld_phone = New System.Windows.Forms.MaskedTextBox()
        Me.fld_phone2 = New System.Windows.Forms.MaskedTextBox()
        Me.Fld_direccion = New System.Windows.Forms.TextBox()
        Me.Fld_Provincia = New System.Windows.Forms.TextBox()
        Me.Fld_Municipio = New System.Windows.Forms.TextBox()
        Me.Fld_Barrio = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Fld_Emp_agno = New System.Windows.Forms.TextBox()
        Me.Fld_emp_meses = New System.Windows.Forms.TextBox()
        Me.Fld_email = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Fld_emppresa = New System.Windows.Forms.TextBox()
        Me.Fld_tiempo_vivienda = New System.Windows.Forms.TextBox()
        Me.fld_tiempo_alquiler = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Fld_phone3 = New System.Windows.Forms.MaskedTextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.fld_tel_codeudor = New System.Windows.Forms.MaskedTextBox()
        Me.fld_Codeudor = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.fld_tel_flia = New System.Windows.Forms.MaskedTextBox()
        Me.fld_nomFlia = New System.Windows.Forms.TextBox()
        Me.Fld_tel_conyugue = New System.Windows.Forms.MaskedTextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.fld_nomConyugue = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CobPrestamos = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GastoLegalTxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SeguroTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MontoSolicitadoTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTasaIntere = New System.Windows.Forms.Label()
        Me.fld_tipo_prestamo = New System.Windows.Forms.ComboBox()
        Me.fld_porciento = New System.Windows.Forms.TextBox()
        Me.fld_monto_prestamo = New System.Windows.Forms.TextBox()
        Me.fld_clasificacion = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.fld_fecha_entrega = New System.Windows.Forms.DateTimePicker()
        Me.fld_cod_prestamo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fld_cantidad_cuotas = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMontoCuota = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.fldTazaMora = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtNotaGeneral = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.fld_total_gastos_fliares = New System.Windows.Forms.TextBox()
        Me.fld_otros_fliares = New System.Windows.Forms.TextBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.fld_Ingreso_conyugue = New System.Windows.Forms.TextBox()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.fld_OtrosNegocios = New System.Windows.Forms.TextBox()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.fld_educacion = New System.Windows.Forms.TextBox()
        Me.fld_transporte = New System.Windows.Forms.TextBox()
        Me.fld_alimentacion = New System.Windows.Forms.TextBox()
        Me.fld_remesas_fliares = New System.Windows.Forms.TextBox()
        Me.fld_total_ingresos_fliares = New System.Windows.Forms.TextBox()
        Me.fld_vivienda = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.fld_Otros_Gastos = New System.Windows.Forms.TextBox()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.fld_Total_de_Gastos = New System.Windows.Forms.TextBox()
        Me.fld_Beneficio_neto = New System.Windows.Forms.TextBox()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.Fld_Total_Pasivo_10_14 = New System.Windows.Forms.TextBox()
        Me.Fld_Otras_CxP = New System.Windows.Forms.TextBox()
        Me.Fld_CxP_Suplidores = New System.Windows.Forms.TextBox()
        Me.Fld_Deudas_Bancarias = New System.Windows.Forms.TextBox()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.Fld_Total_Activo_4_9 = New System.Windows.Forms.TextBox()
        Me.Fld_Total_Activo_Fijo = New System.Windows.Forms.TextBox()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.Fld_Servicios = New System.Windows.Forms.TextBox()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.Fld_mant_reparacion = New System.Windows.Forms.TextBox()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.fld_alquileres = New System.Windows.Forms.TextBox()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.fld_Cuotas_Otros_Prestamos = New System.Windows.Forms.TextBox()
        Me.Fld_Trans_Combustible = New System.Windows.Forms.TextBox()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.Label115 = New System.Windows.Forms.Label()
        Me.Fld_Total_Pasivo_Capital = New System.Windows.Forms.TextBox()
        Me.Fld_Capital_10_14 = New System.Windows.Forms.TextBox()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.Label122 = New System.Windows.Forms.Label()
        Me.Label123 = New System.Windows.Forms.Label()
        Me.Label124 = New System.Windows.Forms.Label()
        Me.Label127 = New System.Windows.Forms.Label()
        Me.Fld_CxC = New System.Windows.Forms.TextBox()
        Me.Fld_efectivo_Caja = New System.Windows.Forms.TextBox()
        Me.Label128 = New System.Windows.Forms.Label()
        Me.fld_Ventas_Ingresos = New System.Windows.Forms.TextBox()
        Me.Label129 = New System.Windows.Forms.Label()
        Me.Label130 = New System.Windows.Forms.Label()
        Me.Label132 = New System.Windows.Forms.Label()
        Me.Label134 = New System.Windows.Forms.Label()
        Me.Label136 = New System.Windows.Forms.Label()
        Me.Label137 = New System.Windows.Forms.Label()
        Me.Label138 = New System.Windows.Forms.Label()
        Me.Label139 = New System.Windows.Forms.Label()
        Me.Label140 = New System.Windows.Forms.Label()
        Me.Label142 = New System.Windows.Forms.Label()
        Me.fld_salario = New System.Windows.Forms.TextBox()
        Me.fld_margen_bruto = New System.Windows.Forms.TextBox()
        Me.Fld_Otros_Activos = New System.Windows.Forms.TextBox()
        Me.Fld_inventario = New System.Windows.Forms.TextBox()
        Me.fld_compras_mes = New System.Windows.Forms.TextBox()
        Me.Fld_Total_Activo = New System.Windows.Forms.TextBox()
        Me.Fld_Inmueble_terreno = New System.Windows.Forms.TextBox()
        Me.Fld_Mobiliario = New System.Windows.Forms.TextBox()
        Me.Fld_Maquinaria_Equipos = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.fld_Comentario_Analista = New System.Windows.Forms.TextBox()
        Me.Fld_Comentario_Encargado = New System.Windows.Forms.TextBox()
        Me.Label164 = New System.Windows.Forms.Label()
        Me.Label170 = New System.Windows.Forms.Label()
        Me.Label172 = New System.Windows.Forms.Label()
        Me.fld_Dispo_de_fondo = New System.Windows.Forms.TextBox()
        Me.Label177 = New System.Windows.Forms.Label()
        Me.Label179 = New System.Windows.Forms.Label()
        Me.Label183 = New System.Windows.Forms.Label()
        Me.Label186 = New System.Windows.Forms.Label()
        Me.fld_monto_recomendado = New System.Windows.Forms.TextBox()
        Me.fldComentario_Oficial = New System.Windows.Forms.TextBox()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.BtnVerSolicitud = New System.Windows.Forms.Button()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_nuevo_cliente
        '
        Me.btn_nuevo_cliente.BackColor = System.Drawing.SystemColors.Control
        Me.btn_nuevo_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btn_nuevo_cliente.ForeColor = System.Drawing.Color.Black
        Me.btn_nuevo_cliente.Location = New System.Drawing.Point(1005, 24)
        Me.btn_nuevo_cliente.Name = "btn_nuevo_cliente"
        Me.btn_nuevo_cliente.Size = New System.Drawing.Size(96, 31)
        Me.btn_nuevo_cliente.TabIndex = 46
        Me.btn_nuevo_cliente.Text = "Nu&evo Socio"
        Me.btn_nuevo_cliente.UseVisualStyleBackColor = False
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(194, 8)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(240, 20)
        Me.txtNombre.TabIndex = 41
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnBuscar.ForeColor = System.Drawing.Color.Black
        Me.btnBuscar.Location = New System.Drawing.Point(1005, 49)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(96, 31)
        Me.btnBuscar.TabIndex = 45
        Me.btnBuscar.Text = "B&uscar Nuevo"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.Color.White
        Me.txtId.Location = New System.Drawing.Point(130, 8)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(56, 20)
        Me.txtId.TabIndex = 0
        Me.txtId.Text = "0"
        '
        'lblCedula
        '
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblCedula.Location = New System.Drawing.Point(7, 32)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(120, 16)
        Me.lblCedula.TabIndex = 23
        Me.lblCedula.Text = "Cédula"
        Me.lblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblNombre.Location = New System.Drawing.Point(7, 8)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(120, 16)
        Me.lblNombre.TabIndex = 22
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblApellidos
        '
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblApellidos.Location = New System.Drawing.Point(7, 147)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(120, 16)
        Me.lblApellidos.TabIndex = 24
        Me.lblApellidos.Text = "Telefonos"
        Me.lblApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnListaPrestamos
        '
        Me.btnListaPrestamos.BackColor = System.Drawing.SystemColors.Control
        Me.btnListaPrestamos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnListaPrestamos.ForeColor = System.Drawing.Color.Black
        Me.btnListaPrestamos.Image = CType(resources.GetObject("btnListaPrestamos.Image"), System.Drawing.Image)
        Me.btnListaPrestamos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnListaPrestamos.Location = New System.Drawing.Point(1201, 210)
        Me.btnListaPrestamos.Name = "btnListaPrestamos"
        Me.btnListaPrestamos.Size = New System.Drawing.Size(88, 56)
        Me.btnListaPrestamos.TabIndex = 16
        Me.btnListaPrestamos.Text = "&Consulta Nueva"
        Me.btnListaPrestamos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnListaPrestamos.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBorrar.Enabled = False
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnBorrar.ForeColor = System.Drawing.Color.Black
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrar.Location = New System.Drawing.Point(1201, 398)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(88, 56)
        Me.btnBorrar.TabIndex = 19
        Me.btnBorrar.Text = "&Rechazar"
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrar.Location = New System.Drawing.Point(1201, 526)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(88, 56)
        Me.btnCerrar.TabIndex = 20
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnProcesar
        '
        Me.btnProcesar.BackColor = System.Drawing.SystemColors.Control
        Me.btnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnProcesar.ForeColor = System.Drawing.Color.Black
        Me.btnProcesar.Image = CType(resources.GetObject("btnProcesar.Image"), System.Drawing.Image)
        Me.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProcesar.Location = New System.Drawing.Point(1201, 24)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(88, 56)
        Me.btnProcesar.TabIndex = 15
        Me.btnProcesar.Text = "&Guardar"
        Me.btnProcesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProcesar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(1107, 24)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(88, 56)
        Me.btnNuevo.TabIndex = 14
        Me.btnNuevo.Text = "&Nueva"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnImprime
        '
        Me.btnImprime.BackColor = System.Drawing.SystemColors.Control
        Me.btnImprime.Enabled = False
        Me.btnImprime.ForeColor = System.Drawing.Color.Black
        Me.btnImprime.Image = CType(resources.GetObject("btnImprime.Image"), System.Drawing.Image)
        Me.btnImprime.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnImprime.Location = New System.Drawing.Point(1201, 462)
        Me.btnImprime.Name = "btnImprime"
        Me.btnImprime.Size = New System.Drawing.Size(88, 56)
        Me.btnImprime.TabIndex = 17
        Me.btnImprime.Text = "&Imprimir"
        Me.btnImprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprime.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(8, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "DATOS DEL SOCIO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAccion
        '
        Me.btnAccion.BackColor = System.Drawing.SystemColors.Control
        Me.btnAccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnAccion.ForeColor = System.Drawing.Color.Black
        Me.btnAccion.Image = CType(resources.GetObject("btnAccion.Image"), System.Drawing.Image)
        Me.btnAccion.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAccion.Location = New System.Drawing.Point(1201, 333)
        Me.btnAccion.Name = "btnAccion"
        Me.btnAccion.Size = New System.Drawing.Size(88, 56)
        Me.btnAccion.TabIndex = 18
        Me.btnAccion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAccion.UseVisualStyleBackColor = False
        Me.btnAccion.Visible = False
        '
        'comentarioBtn
        '
        Me.comentarioBtn.BackColor = System.Drawing.SystemColors.Control
        Me.comentarioBtn.Enabled = False
        Me.comentarioBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.comentarioBtn.ForeColor = System.Drawing.Color.Black
        Me.comentarioBtn.Image = CType(resources.GetObject("comentarioBtn.Image"), System.Drawing.Image)
        Me.comentarioBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.comentarioBtn.Location = New System.Drawing.Point(1201, 272)
        Me.comentarioBtn.Name = "comentarioBtn"
        Me.comentarioBtn.Size = New System.Drawing.Size(88, 56)
        Me.comentarioBtn.TabIndex = 47
        Me.comentarioBtn.Text = "Comentarios"
        Me.comentarioBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.comentarioBtn.UseVisualStyleBackColor = False
        '
        'socioExistenteBtn
        '
        Me.socioExistenteBtn.BackColor = System.Drawing.SystemColors.Control
        Me.socioExistenteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.socioExistenteBtn.ForeColor = System.Drawing.Color.Black
        Me.socioExistenteBtn.Location = New System.Drawing.Point(1005, 75)
        Me.socioExistenteBtn.Name = "socioExistenteBtn"
        Me.socioExistenteBtn.Size = New System.Drawing.Size(96, 31)
        Me.socioExistenteBtn.TabIndex = 48
        Me.socioExistenteBtn.Text = "Buscar Existente"
        Me.socioExistenteBtn.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(1201, 148)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 56)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "&Consulta Aprobada"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Dirección"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 83)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 13)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "Provincia"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 105)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 13)
        Me.Label16.TabIndex = 53
        Me.Label16.Text = "Municipio"
        '
        'RbCasa_Propia
        '
        Me.RbCasa_Propia.AutoSize = True
        Me.RbCasa_Propia.Location = New System.Drawing.Point(130, 166)
        Me.RbCasa_Propia.Name = "RbCasa_Propia"
        Me.RbCasa_Propia.Size = New System.Drawing.Size(55, 17)
        Me.RbCasa_Propia.TabIndex = 57
        Me.RbCasa_Propia.TabStop = True
        Me.RbCasa_Propia.Text = "Propia"
        Me.RbCasa_Propia.UseVisualStyleBackColor = True
        '
        'RbCasa_Alquilada
        '
        Me.RbCasa_Alquilada.AutoSize = True
        Me.RbCasa_Alquilada.Location = New System.Drawing.Point(226, 167)
        Me.RbCasa_Alquilada.Name = "RbCasa_Alquilada"
        Me.RbCasa_Alquilada.Size = New System.Drawing.Size(68, 17)
        Me.RbCasa_Alquilada.TabIndex = 57
        Me.RbCasa_Alquilada.TabStop = True
        Me.RbCasa_Alquilada.Text = "Alquilada"
        Me.RbCasa_Alquilada.UseVisualStyleBackColor = True
        '
        'TxtCedula
        '
        Me.TxtCedula.Location = New System.Drawing.Point(130, 30)
        Me.TxtCedula.Mask = "000-000-0000-0"
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(100, 20)
        Me.TxtCedula.TabIndex = 58
        '
        'fld_phone
        '
        Me.fld_phone.Location = New System.Drawing.Point(130, 144)
        Me.fld_phone.Mask = "000-000-0000"
        Me.fld_phone.Name = "fld_phone"
        Me.fld_phone.Size = New System.Drawing.Size(100, 20)
        Me.fld_phone.TabIndex = 59
        '
        'fld_phone2
        '
        Me.fld_phone2.Location = New System.Drawing.Point(236, 144)
        Me.fld_phone2.Mask = "000-000-0000"
        Me.fld_phone2.Name = "fld_phone2"
        Me.fld_phone2.Size = New System.Drawing.Size(100, 20)
        Me.fld_phone2.TabIndex = 59
        '
        'Fld_direccion
        '
        Me.Fld_direccion.BackColor = System.Drawing.Color.White
        Me.Fld_direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fld_direccion.Location = New System.Drawing.Point(130, 53)
        Me.Fld_direccion.Name = "Fld_direccion"
        Me.Fld_direccion.Size = New System.Drawing.Size(336, 20)
        Me.Fld_direccion.TabIndex = 60
        '
        'Fld_Provincia
        '
        Me.Fld_Provincia.BackColor = System.Drawing.Color.White
        Me.Fld_Provincia.Location = New System.Drawing.Point(130, 76)
        Me.Fld_Provincia.Name = "Fld_Provincia"
        Me.Fld_Provincia.Size = New System.Drawing.Size(152, 20)
        Me.Fld_Provincia.TabIndex = 61
        '
        'Fld_Municipio
        '
        Me.Fld_Municipio.BackColor = System.Drawing.Color.White
        Me.Fld_Municipio.Location = New System.Drawing.Point(130, 98)
        Me.Fld_Municipio.Name = "Fld_Municipio"
        Me.Fld_Municipio.Size = New System.Drawing.Size(152, 20)
        Me.Fld_Municipio.TabIndex = 61
        '
        'Fld_Barrio
        '
        Me.Fld_Barrio.BackColor = System.Drawing.Color.White
        Me.Fld_Barrio.Location = New System.Drawing.Point(130, 121)
        Me.Fld_Barrio.Name = "Fld_Barrio"
        Me.Fld_Barrio.Size = New System.Drawing.Size(152, 20)
        Me.Fld_Barrio.TabIndex = 61
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(7, 124)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(34, 13)
        Me.Label20.TabIndex = 53
        Me.Label20.Text = "Barrio"
        '
        'Fld_Emp_agno
        '
        Me.Fld_Emp_agno.BackColor = System.Drawing.Color.White
        Me.Fld_Emp_agno.Location = New System.Drawing.Point(469, 135)
        Me.Fld_Emp_agno.Name = "Fld_Emp_agno"
        Me.Fld_Emp_agno.Size = New System.Drawing.Size(56, 20)
        Me.Fld_Emp_agno.TabIndex = 62
        Me.Fld_Emp_agno.Text = "0"
        Me.Fld_Emp_agno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Fld_emp_meses
        '
        Me.Fld_emp_meses.BackColor = System.Drawing.Color.White
        Me.Fld_emp_meses.Location = New System.Drawing.Point(547, 135)
        Me.Fld_emp_meses.Name = "Fld_emp_meses"
        Me.Fld_emp_meses.Size = New System.Drawing.Size(56, 20)
        Me.Fld_emp_meses.TabIndex = 63
        Me.Fld_emp_meses.Text = "0"
        Me.Fld_emp_meses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Fld_email
        '
        Me.Fld_email.BackColor = System.Drawing.Color.White
        Me.Fld_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fld_email.Location = New System.Drawing.Point(130, 208)
        Me.Fld_email.Name = "Fld_email"
        Me.Fld_email.Size = New System.Drawing.Size(336, 20)
        Me.Fld_email.TabIndex = 64
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(354, 138)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(112, 13)
        Me.Label21.TabIndex = 66
        Me.Label21.Text = "Tiempo en la Empresa"
        '
        'Fld_emppresa
        '
        Me.Fld_emppresa.BackColor = System.Drawing.Color.White
        Me.Fld_emppresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fld_emppresa.Location = New System.Drawing.Point(424, 85)
        Me.Fld_emppresa.Name = "Fld_emppresa"
        Me.Fld_emppresa.Size = New System.Drawing.Size(208, 20)
        Me.Fld_emppresa.TabIndex = 41
        '
        'Fld_tiempo_vivienda
        '
        Me.Fld_tiempo_vivienda.BackColor = System.Drawing.Color.White
        Me.Fld_tiempo_vivienda.Location = New System.Drawing.Point(129, 186)
        Me.Fld_tiempo_vivienda.Name = "Fld_tiempo_vivienda"
        Me.Fld_tiempo_vivienda.Size = New System.Drawing.Size(56, 20)
        Me.Fld_tiempo_vivienda.TabIndex = 62
        Me.Fld_tiempo_vivienda.Text = "0"
        Me.Fld_tiempo_vivienda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fld_tiempo_alquiler
        '
        Me.fld_tiempo_alquiler.BackColor = System.Drawing.Color.White
        Me.fld_tiempo_alquiler.Location = New System.Drawing.Point(226, 186)
        Me.fld_tiempo_alquiler.Name = "fld_tiempo_alquiler"
        Me.fld_tiempo_alquiler.Size = New System.Drawing.Size(56, 20)
        Me.fld_tiempo_alquiler.TabIndex = 63
        Me.fld_tiempo_alquiler.Text = "0"
        Me.fld_tiempo_alquiler.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(370, 88)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 13)
        Me.Label22.TabIndex = 53
        Me.Label22.Text = "Empresa"
        '
        'Fld_phone3
        '
        Me.Fld_phone3.Location = New System.Drawing.Point(424, 109)
        Me.Fld_phone3.Mask = "000-000-0000"
        Me.Fld_phone3.Name = "Fld_phone3"
        Me.Fld_phone3.Size = New System.Drawing.Size(100, 20)
        Me.Fld_phone3.TabIndex = 59
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(368, 116)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(49, 13)
        Me.Label23.TabIndex = 53
        Me.Label23.Text = "Telefono"
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label34.Location = New System.Drawing.Point(7, 147)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(120, 16)
        Me.Label34.TabIndex = 24
        Me.Label34.Text = "Telefonos"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label35.Location = New System.Drawing.Point(7, 8)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(120, 16)
        Me.Label35.TabIndex = 22
        Me.Label35.Text = "Nombre"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label36.Location = New System.Drawing.Point(7, 32)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(120, 16)
        Me.Label36.TabIndex = 23
        Me.Label36.Text = "Cédula"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(7, 62)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(52, 13)
        Me.Label37.TabIndex = 52
        Me.Label37.Text = "Dirección"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(7, 83)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(51, 13)
        Me.Label38.TabIndex = 52
        Me.Label38.Text = "Provincia"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(7, 105)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(52, 13)
        Me.Label39.TabIndex = 53
        Me.Label39.Text = "Municipio"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(7, 124)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(34, 13)
        Me.Label40.TabIndex = 53
        Me.Label40.Text = "Barrio"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(7, 170)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(85, 13)
        Me.Label41.TabIndex = 54
        Me.Label41.Text = "Tipo de Vivenda"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(7, 190)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(86, 13)
        Me.Label43.TabIndex = 56
        Me.Label43.Text = "Tiempo Vivienda"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 213)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(94, 13)
        Me.Label17.TabIndex = 79
        Me.Label17.Text = "Correo Electrónico"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(11, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(639, 1)
        Me.Panel1.TabIndex = 80
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Controls.Add(Me.Label47)
        Me.Panel4.Controls.Add(Me.Label32)
        Me.Panel4.Controls.Add(Me.fld_tel_codeudor)
        Me.Panel4.Controls.Add(Me.fld_Codeudor)
        Me.Panel4.Controls.Add(Me.Label33)
        Me.Panel4.Controls.Add(Me.Label30)
        Me.Panel4.Controls.Add(Me.Label29)
        Me.Panel4.Controls.Add(Me.Label31)
        Me.Panel4.Controls.Add(Me.Label45)
        Me.Panel4.Controls.Add(Me.Label28)
        Me.Panel4.Controls.Add(Me.fld_tel_flia)
        Me.Panel4.Controls.Add(Me.fld_nomFlia)
        Me.Panel4.Controls.Add(Me.Fld_tel_conyugue)
        Me.Panel4.Controls.Add(Me.Label44)
        Me.Panel4.Controls.Add(Me.Label25)
        Me.Panel4.Controls.Add(Me.fld_nomConyugue)
        Me.Panel4.Controls.Add(Me.Label42)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.CobPrestamos)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.GastoLegalTxt)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.SeguroTxt)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.MontoSolicitadoTxt)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.lblTasaIntere)
        Me.Panel4.Controls.Add(Me.fld_tipo_prestamo)
        Me.Panel4.Controls.Add(Me.fld_porciento)
        Me.Panel4.Controls.Add(Me.fld_monto_prestamo)
        Me.Panel4.Controls.Add(Me.fld_clasificacion)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.fld_fecha_entrega)
        Me.Panel4.Controls.Add(Me.fld_cod_prestamo)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.fld_cantidad_cuotas)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.txtMontoCuota)
        Me.Panel4.Controls.Add(Me.Label27)
        Me.Panel4.Controls.Add(Me.fldTazaMora)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.txtNotaGeneral)
        Me.Panel4.Controls.Add(Me.Label26)
        Me.Panel4.Controls.Add(Me.Label35)
        Me.Panel4.Controls.Add(Me.lblApellidos)
        Me.Panel4.Controls.Add(Me.lblNombre)
        Me.Panel4.Controls.Add(Me.Label34)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.lblCedula)
        Me.Panel4.Controls.Add(Me.txtId)
        Me.Panel4.Controls.Add(Me.Label36)
        Me.Panel4.Controls.Add(Me.txtNombre)
        Me.Panel4.Controls.Add(Me.Fld_emppresa)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label37)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.Label38)
        Me.Panel4.Controls.Add(Me.Label22)
        Me.Panel4.Controls.Add(Me.Label39)
        Me.Panel4.Controls.Add(Me.Label23)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.Label40)
        Me.Panel4.Controls.Add(Me.Label41)
        Me.Panel4.Controls.Add(Me.RbCasa_Propia)
        Me.Panel4.Controls.Add(Me.Label43)
        Me.Panel4.Controls.Add(Me.Label21)
        Me.Panel4.Controls.Add(Me.RbCasa_Alquilada)
        Me.Panel4.Controls.Add(Me.TxtCedula)
        Me.Panel4.Controls.Add(Me.Fld_email)
        Me.Panel4.Controls.Add(Me.fld_phone)
        Me.Panel4.Controls.Add(Me.fld_tiempo_alquiler)
        Me.Panel4.Controls.Add(Me.Fld_phone3)
        Me.Panel4.Controls.Add(Me.Fld_emp_meses)
        Me.Panel4.Controls.Add(Me.fld_phone2)
        Me.Panel4.Controls.Add(Me.Fld_tiempo_vivienda)
        Me.Panel4.Controls.Add(Me.Fld_direccion)
        Me.Panel4.Controls.Add(Me.Fld_Emp_agno)
        Me.Panel4.Controls.Add(Me.Fld_Provincia)
        Me.Panel4.Controls.Add(Me.Fld_Barrio)
        Me.Panel4.Controls.Add(Me.Fld_Municipio)
        Me.Panel4.Location = New System.Drawing.Point(11, 24)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(672, 298)
        Me.Panel4.TabIndex = 83
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(7, 247)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(639, 1)
        Me.Panel2.TabIndex = 130
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(4, 304)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(106, 13)
        Me.Label47.TabIndex = 129
        Me.Label47.Text = "CoDeudor (Opcional)"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(4, 304)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(106, 13)
        Me.Label32.TabIndex = 128
        Me.Label32.Text = "CoDeudor (Opcional)"
        '
        'fld_tel_codeudor
        '
        Me.fld_tel_codeudor.Location = New System.Drawing.Point(440, 299)
        Me.fld_tel_codeudor.Mask = "000-000-0000"
        Me.fld_tel_codeudor.Name = "fld_tel_codeudor"
        Me.fld_tel_codeudor.Size = New System.Drawing.Size(100, 20)
        Me.fld_tel_codeudor.TabIndex = 127
        '
        'fld_Codeudor
        '
        Me.fld_Codeudor.BackColor = System.Drawing.Color.White
        Me.fld_Codeudor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_Codeudor.Location = New System.Drawing.Point(128, 299)
        Me.fld_Codeudor.Name = "fld_Codeudor"
        Me.fld_Codeudor.Size = New System.Drawing.Size(240, 20)
        Me.fld_Codeudor.TabIndex = 126
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(385, 302)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(49, 13)
        Me.Label33.TabIndex = 124
        Me.Label33.Text = "Telefono"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(385, 278)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(49, 13)
        Me.Label30.TabIndex = 123
        Me.Label30.Text = "Telefono"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(385, 253)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(49, 13)
        Me.Label29.TabIndex = 125
        Me.Label29.Text = "Telefono"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(4, 278)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(112, 13)
        Me.Label31.TabIndex = 120
        Me.Label31.Text = "Nombre de un Familiar"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(4, 254)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(112, 13)
        Me.Label45.TabIndex = 121
        Me.Label45.Text = "Nombre del Cónyugue"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(4, 254)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(112, 13)
        Me.Label28.TabIndex = 122
        Me.Label28.Text = "Nombre del Cónyugue"
        '
        'fld_tel_flia
        '
        Me.fld_tel_flia.Location = New System.Drawing.Point(440, 273)
        Me.fld_tel_flia.Mask = "000-000-0000"
        Me.fld_tel_flia.Name = "fld_tel_flia"
        Me.fld_tel_flia.Size = New System.Drawing.Size(100, 20)
        Me.fld_tel_flia.TabIndex = 119
        '
        'fld_nomFlia
        '
        Me.fld_nomFlia.BackColor = System.Drawing.Color.White
        Me.fld_nomFlia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_nomFlia.Location = New System.Drawing.Point(128, 273)
        Me.fld_nomFlia.Name = "fld_nomFlia"
        Me.fld_nomFlia.Size = New System.Drawing.Size(240, 20)
        Me.fld_nomFlia.TabIndex = 118
        '
        'Fld_tel_conyugue
        '
        Me.Fld_tel_conyugue.Location = New System.Drawing.Point(440, 250)
        Me.Fld_tel_conyugue.Mask = "000-000-0000"
        Me.Fld_tel_conyugue.Name = "Fld_tel_conyugue"
        Me.Fld_tel_conyugue.Size = New System.Drawing.Size(100, 20)
        Me.Fld_tel_conyugue.TabIndex = 117
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label44.Location = New System.Drawing.Point(4, 232)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(112, 16)
        Me.Label44.TabIndex = 116
        Me.Label44.Text = "OTROS DATOS"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label25.Location = New System.Drawing.Point(4, 232)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(112, 16)
        Me.Label25.TabIndex = 115
        Me.Label25.Text = "OTROS DATOS"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fld_nomConyugue
        '
        Me.fld_nomConyugue.BackColor = System.Drawing.Color.White
        Me.fld_nomConyugue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_nomConyugue.Location = New System.Drawing.Point(128, 250)
        Me.fld_nomConyugue.Name = "fld_nomConyugue"
        Me.fld_nomConyugue.Size = New System.Drawing.Size(240, 20)
        Me.fld_nomConyugue.TabIndex = 114
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(5, 230)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(94, 13)
        Me.Label42.TabIndex = 113
        Me.Label42.Text = "Correo Electrónico"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(5, 230)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(94, 13)
        Me.Label18.TabIndex = 112
        Me.Label18.Text = "Correo Electrónico"
        '
        'CobPrestamos
        '
        Me.CobPrestamos.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.CobPrestamos.ForeColor = System.Drawing.Color.White
        Me.CobPrestamos.Items.AddRange(New Object() {"Personal", "De consumo", "Hipotecarios"})
        Me.CobPrestamos.Location = New System.Drawing.Point(128, 350)
        Me.CobPrestamos.Name = "CobPrestamos"
        Me.CobPrestamos.Size = New System.Drawing.Size(176, 21)
        Me.CobPrestamos.TabIndex = 110
        Me.CobPrestamos.Text = "Int. y Capital Fijos"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(0, 350)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 16)
        Me.Label11.TabIndex = 111
        Me.Label11.Text = "Tipo de Prestamos"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(312, 398)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 16)
        Me.Label10.TabIndex = 105
        Me.Label10.Text = "Gastos Legales"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GastoLegalTxt
        '
        Me.GastoLegalTxt.BackColor = System.Drawing.Color.White
        Me.GastoLegalTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GastoLegalTxt.Location = New System.Drawing.Point(440, 398)
        Me.GastoLegalTxt.Name = "GastoLegalTxt"
        Me.GastoLegalTxt.Size = New System.Drawing.Size(192, 20)
        Me.GastoLegalTxt.TabIndex = 91
        Me.GastoLegalTxt.Text = "0"
        Me.GastoLegalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(312, 374)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 16)
        Me.Label9.TabIndex = 104
        Me.Label9.Text = "Monto Seguro"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SeguroTxt
        '
        Me.SeguroTxt.BackColor = System.Drawing.Color.White
        Me.SeguroTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeguroTxt.Location = New System.Drawing.Point(440, 374)
        Me.SeguroTxt.Name = "SeguroTxt"
        Me.SeguroTxt.Size = New System.Drawing.Size(192, 20)
        Me.SeguroTxt.TabIndex = 90
        Me.SeguroTxt.Text = "0"
        Me.SeguroTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(312, 350)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 16)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Monto solicitado"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MontoSolicitadoTxt
        '
        Me.MontoSolicitadoTxt.BackColor = System.Drawing.Color.White
        Me.MontoSolicitadoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MontoSolicitadoTxt.Location = New System.Drawing.Point(440, 350)
        Me.MontoSolicitadoTxt.Name = "MontoSolicitadoTxt"
        Me.MontoSolicitadoTxt.Size = New System.Drawing.Size(192, 20)
        Me.MontoSolicitadoTxt.TabIndex = 89
        Me.MontoSolicitadoTxt.Text = "0"
        Me.MontoSolicitadoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(0, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 13)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "DATOS DE LA SOLICITUD"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTasaIntere
        '
        Me.lblTasaIntere.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTasaIntere.Location = New System.Drawing.Point(312, 470)
        Me.lblTasaIntere.Name = "lblTasaIntere"
        Me.lblTasaIntere.Size = New System.Drawing.Size(120, 16)
        Me.lblTasaIntere.TabIndex = 106
        Me.lblTasaIntere.Text = "Tasa de Interes"
        Me.lblTasaIntere.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_tipo_prestamo
        '
        Me.fld_tipo_prestamo.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.fld_tipo_prestamo.ForeColor = System.Drawing.Color.White
        Me.fld_tipo_prestamo.Items.AddRange(New Object() {"DIARIO", "SEMANAL", "QUINCENAL", "MENSUAL", "BIMESTRAL", "TRIMESTRAL", "SEMESTRAL", "ANUAL"})
        Me.fld_tipo_prestamo.Location = New System.Drawing.Point(128, 423)
        Me.fld_tipo_prestamo.Name = "fld_tipo_prestamo"
        Me.fld_tipo_prestamo.Size = New System.Drawing.Size(176, 21)
        Me.fld_tipo_prestamo.TabIndex = 85
        Me.fld_tipo_prestamo.Text = "MENSUAL"
        '
        'fld_porciento
        '
        Me.fld_porciento.BackColor = System.Drawing.Color.White
        Me.fld_porciento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_porciento.Location = New System.Drawing.Point(440, 470)
        Me.fld_porciento.Name = "fld_porciento"
        Me.fld_porciento.Size = New System.Drawing.Size(192, 20)
        Me.fld_porciento.TabIndex = 92
        Me.fld_porciento.Text = "0.00"
        Me.fld_porciento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fld_monto_prestamo
        '
        Me.fld_monto_prestamo.BackColor = System.Drawing.Color.White
        Me.fld_monto_prestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_monto_prestamo.Location = New System.Drawing.Point(440, 494)
        Me.fld_monto_prestamo.Name = "fld_monto_prestamo"
        Me.fld_monto_prestamo.Size = New System.Drawing.Size(192, 20)
        Me.fld_monto_prestamo.TabIndex = 93
        Me.fld_monto_prestamo.Text = "0.00"
        Me.fld_monto_prestamo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fld_clasificacion
        '
        Me.fld_clasificacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.fld_clasificacion.ForeColor = System.Drawing.Color.White
        Me.fld_clasificacion.Items.AddRange(New Object() {"Int. y Capital Amorizable", "Int. y Capital Fijos", "Int. Diario Sobre Saldo Insoluto", "Int. Diario Sobre Capital Inicial"})
        Me.fld_clasificacion.Location = New System.Drawing.Point(128, 399)
        Me.fld_clasificacion.Name = "fld_clasificacion"
        Me.fld_clasificacion.Size = New System.Drawing.Size(176, 21)
        Me.fld_clasificacion.TabIndex = 84
        Me.fld_clasificacion.Text = "Int. y Capital Fijos"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(4, 423)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Condición de pago"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(4, 399)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 16)
        Me.Label13.TabIndex = 98
        Me.Label13.Text = "Composición de Cuota"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(312, 494)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 16)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "Monto Préstamo RD$"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_fecha_entrega
        '
        Me.fld_fecha_entrega.CustomFormat = "dd / MMM /yyyy"
        Me.fld_fecha_entrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fld_fecha_entrega.Location = New System.Drawing.Point(128, 447)
        Me.fld_fecha_entrega.Name = "fld_fecha_entrega"
        Me.fld_fecha_entrega.Size = New System.Drawing.Size(176, 20)
        Me.fld_fecha_entrega.TabIndex = 86
        '
        'fld_cod_prestamo
        '
        Me.fld_cod_prestamo.BackColor = System.Drawing.Color.White
        Me.fld_cod_prestamo.Location = New System.Drawing.Point(128, 375)
        Me.fld_cod_prestamo.Name = "fld_cod_prestamo"
        Me.fld_cod_prestamo.Size = New System.Drawing.Size(176, 20)
        Me.fld_cod_prestamo.TabIndex = 83
        Me.fld_cod_prestamo.Text = "0"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(4, 375)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Código "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fld_cantidad_cuotas
        '
        Me.fld_cantidad_cuotas.BackColor = System.Drawing.Color.White
        Me.fld_cantidad_cuotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_cantidad_cuotas.Location = New System.Drawing.Point(440, 518)
        Me.fld_cantidad_cuotas.Name = "fld_cantidad_cuotas"
        Me.fld_cantidad_cuotas.Size = New System.Drawing.Size(192, 20)
        Me.fld_cantidad_cuotas.TabIndex = 94
        Me.fld_cantidad_cuotas.Text = "0.00"
        Me.fld_cantidad_cuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(4, 447)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 16)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "Fecha de Inicio"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(312, 518)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 16)
        Me.Label8.TabIndex = 108
        Me.Label8.Text = "Cantidad Cuotas"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMontoCuota
        '
        Me.txtMontoCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoCuota.Location = New System.Drawing.Point(440, 541)
        Me.txtMontoCuota.Name = "txtMontoCuota"
        Me.txtMontoCuota.Size = New System.Drawing.Size(192, 20)
        Me.txtMontoCuota.TabIndex = 95
        Me.txtMontoCuota.Text = "0.00"
        Me.txtMontoCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(312, 541)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(120, 16)
        Me.Label27.TabIndex = 109
        Me.Label27.Text = "Monto Cuota RD$"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fldTazaMora
        '
        Me.fldTazaMora.BackColor = System.Drawing.Color.White
        Me.fldTazaMora.Location = New System.Drawing.Point(128, 471)
        Me.fldTazaMora.Name = "fldTazaMora"
        Me.fldTazaMora.Size = New System.Drawing.Size(88, 20)
        Me.fldTazaMora.TabIndex = 87
        Me.fldTazaMora.Text = "0.00"
        Me.fldTazaMora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.fldTazaMora.Visible = False
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.Location = New System.Drawing.Point(4, 471)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(120, 16)
        Me.Label15.TabIndex = 101
        Me.Label15.Text = "% Mora Mensual"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label15.Visible = False
        '
        'txtNotaGeneral
        '
        Me.txtNotaGeneral.Location = New System.Drawing.Point(128, 495)
        Me.txtNotaGeneral.MaxLength = 1024
        Me.txtNotaGeneral.Multiline = True
        Me.txtNotaGeneral.Name = "txtNotaGeneral"
        Me.txtNotaGeneral.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtNotaGeneral.Size = New System.Drawing.Size(176, 63)
        Me.txtNotaGeneral.TabIndex = 88
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label26.Location = New System.Drawing.Point(6, 518)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(120, 16)
        Me.Label26.TabIndex = 102
        Me.Label26.Text = "Nota General"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(15, 340)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(639, 1)
        Me.Panel3.TabIndex = 131
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Location = New System.Drawing.Point(21, 340)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(639, 1)
        Me.Panel7.TabIndex = 135
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label46.Location = New System.Drawing.Point(11, 325)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(112, 16)
        Me.Label46.TabIndex = 133
        Me.Label46.Text = "PATRIMONIO"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(12, 323)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(94, 13)
        Me.Label48.TabIndex = 132
        Me.Label48.Text = "Correo Electrónico"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(12, 323)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(94, 13)
        Me.Label49.TabIndex = 131
        Me.Label49.Text = "Correo Electrónico"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.White
        Me.Panel9.Location = New System.Drawing.Point(689, 17)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(467, 1)
        Me.Panel9.TabIndex = 82
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(686, 2)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(148, 13)
        Me.Label19.TabIndex = 81
        Me.Label19.Text = "INGRESOS FAMILIARES"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.White
        Me.Panel10.Location = New System.Drawing.Point(692, 331)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(312, 1)
        Me.Panel10.TabIndex = 84
        '
        'Panel5
        '
        Me.Panel5.AutoScroll = True
        Me.Panel5.Controls.Add(Me.Panel17)
        Me.Panel5.Controls.Add(Me.Label93)
        Me.Panel5.Controls.Add(Me.Label94)
        Me.Panel5.Controls.Add(Me.Label104)
        Me.Panel5.Controls.Add(Me.Label56)
        Me.Panel5.Controls.Add(Me.Label57)
        Me.Panel5.Controls.Add(Me.fld_total_gastos_fliares)
        Me.Panel5.Controls.Add(Me.fld_otros_fliares)
        Me.Panel5.Controls.Add(Me.Label78)
        Me.Panel5.Controls.Add(Me.Label79)
        Me.Panel5.Controls.Add(Me.Label80)
        Me.Panel5.Controls.Add(Me.Label82)
        Me.Panel5.Controls.Add(Me.Label83)
        Me.Panel5.Controls.Add(Me.fld_Ingreso_conyugue)
        Me.Panel5.Controls.Add(Me.Label84)
        Me.Panel5.Controls.Add(Me.fld_OtrosNegocios)
        Me.Panel5.Controls.Add(Me.Label85)
        Me.Panel5.Controls.Add(Me.Label86)
        Me.Panel5.Controls.Add(Me.Label87)
        Me.Panel5.Controls.Add(Me.Label89)
        Me.Panel5.Controls.Add(Me.Label95)
        Me.Panel5.Controls.Add(Me.Label97)
        Me.Panel5.Controls.Add(Me.fld_educacion)
        Me.Panel5.Controls.Add(Me.fld_transporte)
        Me.Panel5.Controls.Add(Me.fld_alimentacion)
        Me.Panel5.Controls.Add(Me.fld_remesas_fliares)
        Me.Panel5.Controls.Add(Me.fld_total_ingresos_fliares)
        Me.Panel5.Controls.Add(Me.fld_vivienda)
        Me.Panel5.Location = New System.Drawing.Point(686, 24)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(313, 291)
        Me.Panel5.TabIndex = 132
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.White
        Me.Panel17.Location = New System.Drawing.Point(16, 121)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(297, 1)
        Me.Panel17.TabIndex = 140
        '
        'Label93
        '
        Me.Label93.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label93.Location = New System.Drawing.Point(2, 106)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(112, 16)
        Me.Label93.TabIndex = 139
        Me.Label93.Text = "Gastos Familiares"
        Me.Label93.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Location = New System.Drawing.Point(3, 104)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(94, 13)
        Me.Label94.TabIndex = 137
        Me.Label94.Text = "Correo Electrónico"
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.Location = New System.Drawing.Point(3, 104)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(94, 13)
        Me.Label104.TabIndex = 138
        Me.Label104.Text = "Correo Electrónico"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(4, 262)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(132, 13)
        Me.Label56.TabIndex = 120
        Me.Label56.Text = "Total de Gastos (c) (1 al 6)"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(4, 241)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(32, 13)
        Me.Label57.TabIndex = 121
        Me.Label57.Text = "Otros"
        '
        'fld_total_gastos_fliares
        '
        Me.fld_total_gastos_fliares.BackColor = System.Drawing.Color.White
        Me.fld_total_gastos_fliares.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_total_gastos_fliares.Location = New System.Drawing.Point(137, 259)
        Me.fld_total_gastos_fliares.Name = "fld_total_gastos_fliares"
        Me.fld_total_gastos_fliares.ReadOnly = True
        Me.fld_total_gastos_fliares.Size = New System.Drawing.Size(100, 20)
        Me.fld_total_gastos_fliares.TabIndex = 118
        Me.fld_total_gastos_fliares.Text = "0.00"
        Me.fld_total_gastos_fliares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fld_otros_fliares
        '
        Me.fld_otros_fliares.BackColor = System.Drawing.Color.White
        Me.fld_otros_fliares.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_otros_fliares.Location = New System.Drawing.Point(137, 233)
        Me.fld_otros_fliares.Name = "fld_otros_fliares"
        Me.fld_otros_fliares.ReadOnly = True
        Me.fld_otros_fliares.Size = New System.Drawing.Size(100, 20)
        Me.fld_otros_fliares.TabIndex = 114
        Me.fld_otros_fliares.Text = "0.00"
        Me.fld_otros_fliares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label78
        '
        Me.Label78.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label78.Location = New System.Drawing.Point(7, 8)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(120, 16)
        Me.Label78.TabIndex = 22
        Me.Label78.Text = "Ingreso del Conyugue"
        Me.Label78.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label79.Location = New System.Drawing.Point(11, 138)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(48, 13)
        Me.Label79.TabIndex = 24
        Me.Label79.Text = "Vivienda"
        Me.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label80
        '
        Me.Label80.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label80.Location = New System.Drawing.Point(7, 8)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(120, 16)
        Me.Label80.TabIndex = 22
        Me.Label80.Text = "Nombre"
        Me.Label80.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Location = New System.Drawing.Point(7, 213)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(58, 13)
        Me.Label82.TabIndex = 79
        Me.Label82.Text = "Educacion"
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label83.Location = New System.Drawing.Point(7, 32)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(80, 13)
        Me.Label83.TabIndex = 23
        Me.Label83.Text = "Otros Negocios"
        Me.Label83.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fld_Ingreso_conyugue
        '
        Me.fld_Ingreso_conyugue.BackColor = System.Drawing.Color.White
        Me.fld_Ingreso_conyugue.Location = New System.Drawing.Point(130, 8)
        Me.fld_Ingreso_conyugue.Name = "fld_Ingreso_conyugue"
        Me.fld_Ingreso_conyugue.Size = New System.Drawing.Size(100, 20)
        Me.fld_Ingreso_conyugue.TabIndex = 0
        Me.fld_Ingreso_conyugue.Text = "0.00"
        Me.fld_Ingreso_conyugue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label84
        '
        Me.Label84.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label84.Location = New System.Drawing.Point(7, 32)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(120, 16)
        Me.Label84.TabIndex = 23
        Me.Label84.Text = "Cédula"
        Me.Label84.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fld_OtrosNegocios
        '
        Me.fld_OtrosNegocios.BackColor = System.Drawing.Color.White
        Me.fld_OtrosNegocios.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_OtrosNegocios.Location = New System.Drawing.Point(130, 30)
        Me.fld_OtrosNegocios.Name = "fld_OtrosNegocios"
        Me.fld_OtrosNegocios.ReadOnly = True
        Me.fld_OtrosNegocios.Size = New System.Drawing.Size(100, 20)
        Me.fld_OtrosNegocios.TabIndex = 41
        Me.fld_OtrosNegocios.Text = "0.00"
        Me.fld_OtrosNegocios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Location = New System.Drawing.Point(7, 62)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(100, 13)
        Me.Label85.TabIndex = 52
        Me.Label85.Text = "Remesas Familiares"
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Location = New System.Drawing.Point(7, 83)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(123, 13)
        Me.Label86.TabIndex = 52
        Me.Label86.Text = "Total Ingresos Familiares"
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Location = New System.Drawing.Point(7, 62)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(52, 13)
        Me.Label87.TabIndex = 52
        Me.Label87.Text = "Dirección"
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Location = New System.Drawing.Point(7, 83)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(51, 13)
        Me.Label89.TabIndex = 52
        Me.Label89.Text = "Provincia"
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Location = New System.Drawing.Point(6, 165)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(67, 13)
        Me.Label95.TabIndex = 54
        Me.Label95.Text = "Alimentacion"
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Location = New System.Drawing.Point(7, 190)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(58, 13)
        Me.Label97.TabIndex = 56
        Me.Label97.Text = "Transporte"
        '
        'fld_educacion
        '
        Me.fld_educacion.BackColor = System.Drawing.Color.White
        Me.fld_educacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_educacion.Location = New System.Drawing.Point(137, 209)
        Me.fld_educacion.Name = "fld_educacion"
        Me.fld_educacion.ReadOnly = True
        Me.fld_educacion.Size = New System.Drawing.Size(100, 20)
        Me.fld_educacion.TabIndex = 64
        Me.fld_educacion.Text = "0.00"
        Me.fld_educacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fld_transporte
        '
        Me.fld_transporte.BackColor = System.Drawing.Color.White
        Me.fld_transporte.Location = New System.Drawing.Point(137, 186)
        Me.fld_transporte.Name = "fld_transporte"
        Me.fld_transporte.Size = New System.Drawing.Size(102, 20)
        Me.fld_transporte.TabIndex = 63
        Me.fld_transporte.Text = "0.00"
        Me.fld_transporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fld_alimentacion
        '
        Me.fld_alimentacion.BackColor = System.Drawing.Color.White
        Me.fld_alimentacion.Location = New System.Drawing.Point(137, 162)
        Me.fld_alimentacion.Name = "fld_alimentacion"
        Me.fld_alimentacion.Size = New System.Drawing.Size(102, 20)
        Me.fld_alimentacion.TabIndex = 62
        Me.fld_alimentacion.Text = "0.00"
        Me.fld_alimentacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fld_remesas_fliares
        '
        Me.fld_remesas_fliares.BackColor = System.Drawing.Color.White
        Me.fld_remesas_fliares.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_remesas_fliares.Location = New System.Drawing.Point(130, 53)
        Me.fld_remesas_fliares.Name = "fld_remesas_fliares"
        Me.fld_remesas_fliares.ReadOnly = True
        Me.fld_remesas_fliares.Size = New System.Drawing.Size(100, 20)
        Me.fld_remesas_fliares.TabIndex = 60
        Me.fld_remesas_fliares.Text = "0.00"
        Me.fld_remesas_fliares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fld_total_ingresos_fliares
        '
        Me.fld_total_ingresos_fliares.BackColor = System.Drawing.Color.White
        Me.fld_total_ingresos_fliares.Location = New System.Drawing.Point(130, 76)
        Me.fld_total_ingresos_fliares.Name = "fld_total_ingresos_fliares"
        Me.fld_total_ingresos_fliares.Size = New System.Drawing.Size(100, 20)
        Me.fld_total_ingresos_fliares.TabIndex = 61
        Me.fld_total_ingresos_fliares.Text = "0.00"
        Me.fld_total_ingresos_fliares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fld_vivienda
        '
        Me.fld_vivienda.BackColor = System.Drawing.Color.White
        Me.fld_vivienda.Location = New System.Drawing.Point(137, 137)
        Me.fld_vivienda.Name = "fld_vivienda"
        Me.fld_vivienda.Size = New System.Drawing.Size(100, 20)
        Me.fld_vivienda.TabIndex = 61
        Me.fld_vivienda.Text = "0.00"
        Me.fld_vivienda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel6
        '
        Me.Panel6.AutoScroll = True
        Me.Panel6.Controls.Add(Me.Label24)
        Me.Panel6.Controls.Add(Me.fld_Otros_Gastos)
        Me.Panel6.Controls.Add(Me.Label98)
        Me.Panel6.Controls.Add(Me.fld_Total_de_Gastos)
        Me.Panel6.Controls.Add(Me.fld_Beneficio_neto)
        Me.Panel6.Controls.Add(Me.Label99)
        Me.Panel6.Controls.Add(Me.Panel13)
        Me.Panel6.Controls.Add(Me.Label102)
        Me.Panel6.Controls.Add(Me.Label90)
        Me.Panel6.Controls.Add(Me.Label92)
        Me.Panel6.Controls.Add(Me.Fld_Total_Pasivo_10_14)
        Me.Panel6.Controls.Add(Me.Fld_Otras_CxP)
        Me.Panel6.Controls.Add(Me.Fld_CxP_Suplidores)
        Me.Panel6.Controls.Add(Me.Fld_Deudas_Bancarias)
        Me.Panel6.Controls.Add(Me.Label100)
        Me.Panel6.Controls.Add(Me.Label103)
        Me.Panel6.Controls.Add(Me.Label101)
        Me.Panel6.Controls.Add(Me.Fld_Total_Activo_4_9)
        Me.Panel6.Controls.Add(Me.Fld_Total_Activo_Fijo)
        Me.Panel6.Controls.Add(Me.Label107)
        Me.Panel6.Controls.Add(Me.Label108)
        Me.Panel6.Controls.Add(Me.Fld_Servicios)
        Me.Panel6.Controls.Add(Me.Label109)
        Me.Panel6.Controls.Add(Me.Fld_mant_reparacion)
        Me.Panel6.Controls.Add(Me.Label110)
        Me.Panel6.Controls.Add(Me.fld_alquileres)
        Me.Panel6.Controls.Add(Me.Label112)
        Me.Panel6.Controls.Add(Me.fld_Cuotas_Otros_Prestamos)
        Me.Panel6.Controls.Add(Me.Fld_Trans_Combustible)
        Me.Panel6.Controls.Add(Me.Label114)
        Me.Panel6.Controls.Add(Me.Label115)
        Me.Panel6.Controls.Add(Me.Fld_Total_Pasivo_Capital)
        Me.Panel6.Controls.Add(Me.Fld_Capital_10_14)
        Me.Panel6.Controls.Add(Me.Label116)
        Me.Panel6.Controls.Add(Me.Label122)
        Me.Panel6.Controls.Add(Me.Label123)
        Me.Panel6.Controls.Add(Me.Label124)
        Me.Panel6.Controls.Add(Me.Label127)
        Me.Panel6.Controls.Add(Me.Fld_CxC)
        Me.Panel6.Controls.Add(Me.Fld_efectivo_Caja)
        Me.Panel6.Controls.Add(Me.Label128)
        Me.Panel6.Controls.Add(Me.fld_Ventas_Ingresos)
        Me.Panel6.Controls.Add(Me.Label129)
        Me.Panel6.Controls.Add(Me.Label130)
        Me.Panel6.Controls.Add(Me.Label132)
        Me.Panel6.Controls.Add(Me.Label134)
        Me.Panel6.Controls.Add(Me.Label136)
        Me.Panel6.Controls.Add(Me.Label137)
        Me.Panel6.Controls.Add(Me.Label138)
        Me.Panel6.Controls.Add(Me.Label139)
        Me.Panel6.Controls.Add(Me.Label140)
        Me.Panel6.Controls.Add(Me.Label142)
        Me.Panel6.Controls.Add(Me.fld_salario)
        Me.Panel6.Controls.Add(Me.fld_margen_bruto)
        Me.Panel6.Controls.Add(Me.Fld_Otros_Activos)
        Me.Panel6.Controls.Add(Me.Fld_inventario)
        Me.Panel6.Controls.Add(Me.fld_compras_mes)
        Me.Panel6.Controls.Add(Me.Fld_Total_Activo)
        Me.Panel6.Controls.Add(Me.Fld_Inmueble_terreno)
        Me.Panel6.Controls.Add(Me.Fld_Mobiliario)
        Me.Panel6.Controls.Add(Me.Fld_Maquinaria_Equipos)
        Me.Panel6.Location = New System.Drawing.Point(11, 344)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(672, 257)
        Me.Panel6.TabIndex = 132
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(300, 214)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(68, 13)
        Me.Label24.TabIndex = 134
        Me.Label24.Text = "Otros Gastos"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_Otros_Gastos
        '
        Me.fld_Otros_Gastos.BackColor = System.Drawing.Color.White
        Me.fld_Otros_Gastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_Otros_Gastos.Location = New System.Drawing.Point(503, 214)
        Me.fld_Otros_Gastos.Name = "fld_Otros_Gastos"
        Me.fld_Otros_Gastos.Size = New System.Drawing.Size(100, 20)
        Me.fld_Otros_Gastos.TabIndex = 131
        Me.fld_Otros_Gastos.Text = "0.00"
        Me.fld_Otros_Gastos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.Location = New System.Drawing.Point(300, 244)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(123, 13)
        Me.Label98.TabIndex = 135
        Me.Label98.Text = "Total de Gastos (4 al 13)"
        Me.Label98.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_Total_de_Gastos
        '
        Me.fld_Total_de_Gastos.BackColor = System.Drawing.Color.White
        Me.fld_Total_de_Gastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_Total_de_Gastos.Location = New System.Drawing.Point(503, 237)
        Me.fld_Total_de_Gastos.Name = "fld_Total_de_Gastos"
        Me.fld_Total_de_Gastos.Size = New System.Drawing.Size(100, 20)
        Me.fld_Total_de_Gastos.TabIndex = 132
        Me.fld_Total_de_Gastos.Text = "0.00"
        Me.fld_Total_de_Gastos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fld_Beneficio_neto
        '
        Me.fld_Beneficio_neto.BackColor = System.Drawing.Color.White
        Me.fld_Beneficio_neto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_Beneficio_neto.Location = New System.Drawing.Point(503, 261)
        Me.fld_Beneficio_neto.Name = "fld_Beneficio_neto"
        Me.fld_Beneficio_neto.Size = New System.Drawing.Size(100, 20)
        Me.fld_Beneficio_neto.TabIndex = 133
        Me.fld_Beneficio_neto.Text = "0.00"
        Me.fld_Beneficio_neto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label99.Location = New System.Drawing.Point(300, 268)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(123, 13)
        Me.Label99.TabIndex = 136
        Me.Label99.Text = "Beneficio Neto (A) (3-14)"
        Me.Label99.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.White
        Me.Panel13.Location = New System.Drawing.Point(288, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(3, 421)
        Me.Panel13.TabIndex = 130
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Location = New System.Drawing.Point(6, 283)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(121, 13)
        Me.Label102.TabIndex = 129
        Me.Label102.Text = "Otras cuentas por pagar"
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Location = New System.Drawing.Point(4, 259)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(153, 13)
        Me.Label90.TabIndex = 129
        Me.Label90.Text = "Cuentas por pagar a suplidores"
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Location = New System.Drawing.Point(4, 259)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(106, 13)
        Me.Label92.TabIndex = 128
        Me.Label92.Text = "CoDeudor (Opcional)"
        '
        'Fld_Total_Pasivo_10_14
        '
        Me.Fld_Total_Pasivo_10_14.BackColor = System.Drawing.Color.White
        Me.Fld_Total_Pasivo_10_14.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fld_Total_Pasivo_10_14.Location = New System.Drawing.Point(182, 307)
        Me.Fld_Total_Pasivo_10_14.Name = "Fld_Total_Pasivo_10_14"
        Me.Fld_Total_Pasivo_10_14.Size = New System.Drawing.Size(100, 20)
        Me.Fld_Total_Pasivo_10_14.TabIndex = 126
        Me.Fld_Total_Pasivo_10_14.Text = "0.00"
        Me.Fld_Total_Pasivo_10_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Fld_Otras_CxP
        '
        Me.Fld_Otras_CxP.BackColor = System.Drawing.Color.White
        Me.Fld_Otras_CxP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fld_Otras_CxP.Location = New System.Drawing.Point(182, 283)
        Me.Fld_Otras_CxP.Name = "Fld_Otras_CxP"
        Me.Fld_Otras_CxP.Size = New System.Drawing.Size(100, 20)
        Me.Fld_Otras_CxP.TabIndex = 126
        Me.Fld_Otras_CxP.Text = "0.00"
        Me.Fld_Otras_CxP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Fld_CxP_Suplidores
        '
        Me.Fld_CxP_Suplidores.BackColor = System.Drawing.Color.White
        Me.Fld_CxP_Suplidores.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fld_CxP_Suplidores.Location = New System.Drawing.Point(182, 259)
        Me.Fld_CxP_Suplidores.Name = "Fld_CxP_Suplidores"
        Me.Fld_CxP_Suplidores.Size = New System.Drawing.Size(100, 20)
        Me.Fld_CxP_Suplidores.TabIndex = 126
        Me.Fld_CxP_Suplidores.Text = "0.00"
        Me.Fld_CxP_Suplidores.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Fld_Deudas_Bancarias
        '
        Me.Fld_Deudas_Bancarias.BackColor = System.Drawing.Color.White
        Me.Fld_Deudas_Bancarias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fld_Deudas_Bancarias.Location = New System.Drawing.Point(182, 236)
        Me.Fld_Deudas_Bancarias.Name = "Fld_Deudas_Bancarias"
        Me.Fld_Deudas_Bancarias.Size = New System.Drawing.Size(100, 20)
        Me.Fld_Deudas_Bancarias.TabIndex = 126
        Me.Fld_Deudas_Bancarias.Text = "0.00"
        Me.Fld_Deudas_Bancarias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Location = New System.Drawing.Point(7, 238)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(178, 13)
        Me.Label100.TabIndex = 120
        Me.Label100.Text = "Deudas bancarias ( prestamos y TC)"
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Location = New System.Drawing.Point(7, 192)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(122, 13)
        Me.Label103.TabIndex = 121
        Me.Label103.Text = "Total Activo Fijo (5+6+7)"
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Location = New System.Drawing.Point(7, 215)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(96, 13)
        Me.Label101.TabIndex = 121
        Me.Label101.Text = "Total Activos (4+9)"
        '
        'Fld_Total_Activo_4_9
        '
        Me.Fld_Total_Activo_4_9.BackColor = System.Drawing.Color.White
        Me.Fld_Total_Activo_4_9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fld_Total_Activo_4_9.Location = New System.Drawing.Point(182, 212)
        Me.Fld_Total_Activo_4_9.Name = "Fld_Total_Activo_4_9"
        Me.Fld_Total_Activo_4_9.Size = New System.Drawing.Size(100, 20)
        Me.Fld_Total_Activo_4_9.TabIndex = 118
        Me.Fld_Total_Activo_4_9.Text = "0.00"
        Me.Fld_Total_Activo_4_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Fld_Total_Activo_Fijo
        '
        Me.Fld_Total_Activo_Fijo.BackColor = System.Drawing.Color.White
        Me.Fld_Total_Activo_Fijo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fld_Total_Activo_Fijo.Location = New System.Drawing.Point(182, 189)
        Me.Fld_Total_Activo_Fijo.Name = "Fld_Total_Activo_Fijo"
        Me.Fld_Total_Activo_Fijo.Size = New System.Drawing.Size(100, 20)
        Me.Fld_Total_Activo_Fijo.TabIndex = 114
        Me.Fld_Total_Activo_Fijo.Text = "0.00"
        Me.Fld_Total_Activo_Fijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label107
        '
        Me.Label107.AutoSize = True
        Me.Label107.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label107.Location = New System.Drawing.Point(5, 309)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(123, 13)
        Me.Label107.TabIndex = 111
        Me.Label107.Text = "Total Pasivo (10+11+12)"
        Me.Label107.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label108
        '
        Me.Label108.AutoSize = True
        Me.Label108.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label108.Location = New System.Drawing.Point(300, 143)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(155, 13)
        Me.Label108.TabIndex = 105
        Me.Label108.Text = "Servicios (Telefono, Luz, Agua)"
        Me.Label108.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fld_Servicios
        '
        Me.Fld_Servicios.BackColor = System.Drawing.Color.White
        Me.Fld_Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fld_Servicios.Location = New System.Drawing.Point(503, 143)
        Me.Fld_Servicios.Name = "Fld_Servicios"
        Me.Fld_Servicios.Size = New System.Drawing.Size(100, 20)
        Me.Fld_Servicios.TabIndex = 91
        Me.Fld_Servicios.Text = "0.00"
        Me.Fld_Servicios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label109
        '
        Me.Label109.AutoSize = True
        Me.Label109.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label109.Location = New System.Drawing.Point(300, 119)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(198, 13)
        Me.Label109.TabIndex = 104
        Me.Label109.Text = "Mantenimiento y Reparacion de Equipos"
        Me.Label109.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fld_mant_reparacion
        '
        Me.Fld_mant_reparacion.BackColor = System.Drawing.Color.White
        Me.Fld_mant_reparacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fld_mant_reparacion.Location = New System.Drawing.Point(503, 119)
        Me.Fld_mant_reparacion.Name = "Fld_mant_reparacion"
        Me.Fld_mant_reparacion.Size = New System.Drawing.Size(100, 20)
        Me.Fld_mant_reparacion.TabIndex = 90
        Me.Fld_mant_reparacion.Text = "0.00"
        Me.Fld_mant_reparacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label110
        '
        Me.Label110.AutoSize = True
        Me.Label110.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label110.Location = New System.Drawing.Point(300, 95)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(52, 13)
        Me.Label110.TabIndex = 103
        Me.Label110.Text = "Alquileres"
        Me.Label110.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_alquileres
        '
        Me.fld_alquileres.BackColor = System.Drawing.Color.White
        Me.fld_alquileres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_alquileres.Location = New System.Drawing.Point(503, 95)
        Me.fld_alquileres.Name = "fld_alquileres"
        Me.fld_alquileres.Size = New System.Drawing.Size(100, 20)
        Me.fld_alquileres.TabIndex = 89
        Me.fld_alquileres.Text = "0.00"
        Me.fld_alquileres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label112
        '
        Me.Label112.AutoSize = True
        Me.Label112.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label112.Location = New System.Drawing.Point(300, 166)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(117, 13)
        Me.Label112.TabIndex = 106
        Me.Label112.Text = "Cuotas otros prestamos"
        Me.Label112.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_Cuotas_Otros_Prestamos
        '
        Me.fld_Cuotas_Otros_Prestamos.BackColor = System.Drawing.Color.White
        Me.fld_Cuotas_Otros_Prestamos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_Cuotas_Otros_Prestamos.Location = New System.Drawing.Point(503, 166)
        Me.fld_Cuotas_Otros_Prestamos.Name = "fld_Cuotas_Otros_Prestamos"
        Me.fld_Cuotas_Otros_Prestamos.Size = New System.Drawing.Size(100, 20)
        Me.fld_Cuotas_Otros_Prestamos.TabIndex = 92
        Me.fld_Cuotas_Otros_Prestamos.Text = "0.00"
        Me.fld_Cuotas_Otros_Prestamos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Fld_Trans_Combustible
        '
        Me.Fld_Trans_Combustible.BackColor = System.Drawing.Color.White
        Me.Fld_Trans_Combustible.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fld_Trans_Combustible.Location = New System.Drawing.Point(503, 190)
        Me.Fld_Trans_Combustible.Name = "Fld_Trans_Combustible"
        Me.Fld_Trans_Combustible.Size = New System.Drawing.Size(100, 20)
        Me.Fld_Trans_Combustible.TabIndex = 93
        Me.Fld_Trans_Combustible.Text = "0.00"
        Me.Fld_Trans_Combustible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label114
        '
        Me.Label114.AutoSize = True
        Me.Label114.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label114.Location = New System.Drawing.Point(4, 354)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(162, 13)
        Me.Label114.TabIndex = 98
        Me.Label114.Text = "Total Pasivo mas Capital (14+15)"
        Me.Label114.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label115
        '
        Me.Label115.AutoSize = True
        Me.Label115.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label115.Location = New System.Drawing.Point(300, 190)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(131, 13)
        Me.Label115.TabIndex = 107
        Me.Label115.Text = "Transporte y Combustibles"
        Me.Label115.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fld_Total_Pasivo_Capital
        '
        Me.Fld_Total_Pasivo_Capital.BackColor = System.Drawing.Color.White
        Me.Fld_Total_Pasivo_Capital.Location = New System.Drawing.Point(182, 353)
        Me.Fld_Total_Pasivo_Capital.Name = "Fld_Total_Pasivo_Capital"
        Me.Fld_Total_Pasivo_Capital.Size = New System.Drawing.Size(100, 20)
        Me.Fld_Total_Pasivo_Capital.TabIndex = 83
        Me.Fld_Total_Pasivo_Capital.Text = "0.00"
        Me.Fld_Total_Pasivo_Capital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Fld_Capital_10_14
        '
        Me.Fld_Capital_10_14.BackColor = System.Drawing.Color.White
        Me.Fld_Capital_10_14.Location = New System.Drawing.Point(182, 330)
        Me.Fld_Capital_10_14.Name = "Fld_Capital_10_14"
        Me.Fld_Capital_10_14.Size = New System.Drawing.Size(100, 20)
        Me.Fld_Capital_10_14.TabIndex = 83
        Me.Fld_Capital_10_14.Text = "0.00"
        Me.Fld_Capital_10_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label116
        '
        Me.Label116.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label116.Location = New System.Drawing.Point(4, 330)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(120, 16)
        Me.Label116.TabIndex = 97
        Me.Label116.Text = "Capital (10-14)"
        Me.Label116.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label122
        '
        Me.Label122.AutoSize = True
        Me.Label122.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label122.Location = New System.Drawing.Point(7, 11)
        Me.Label122.Name = "Label122"
        Me.Label122.Size = New System.Drawing.Size(127, 13)
        Me.Label122.TabIndex = 22
        Me.Label122.Text = "Efectivo en Caja y Banco"
        Me.Label122.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label123
        '
        Me.Label123.AutoSize = True
        Me.Label123.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label123.Location = New System.Drawing.Point(7, 147)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(141, 13)
        Me.Label123.TabIndex = 24
        Me.Label123.Text = "Inmuebles (Terrenos, Casas)"
        Me.Label123.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label124
        '
        Me.Label124.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label124.Location = New System.Drawing.Point(7, 8)
        Me.Label124.Name = "Label124"
        Me.Label124.Size = New System.Drawing.Size(120, 16)
        Me.Label124.TabIndex = 22
        Me.Label124.Text = "Nombre"
        Me.Label124.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label127
        '
        Me.Label127.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label127.Location = New System.Drawing.Point(7, 32)
        Me.Label127.Name = "Label127"
        Me.Label127.Size = New System.Drawing.Size(120, 16)
        Me.Label127.TabIndex = 23
        Me.Label127.Text = "Cuentas Por Cobrar"
        Me.Label127.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Fld_CxC
        '
        Me.Fld_CxC.BackColor = System.Drawing.Color.White
        Me.Fld_CxC.Location = New System.Drawing.Point(182, 27)
        Me.Fld_CxC.Name = "Fld_CxC"
        Me.Fld_CxC.Size = New System.Drawing.Size(100, 20)
        Me.Fld_CxC.TabIndex = 0
        Me.Fld_CxC.Text = "0.00"
        Me.Fld_CxC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Fld_efectivo_Caja
        '
        Me.Fld_efectivo_Caja.BackColor = System.Drawing.Color.White
        Me.Fld_efectivo_Caja.Location = New System.Drawing.Point(182, 5)
        Me.Fld_efectivo_Caja.Name = "Fld_efectivo_Caja"
        Me.Fld_efectivo_Caja.Size = New System.Drawing.Size(100, 20)
        Me.Fld_efectivo_Caja.TabIndex = 0
        Me.Fld_efectivo_Caja.Text = "0.00"
        Me.Fld_efectivo_Caja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label128
        '
        Me.Label128.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label128.Location = New System.Drawing.Point(7, 32)
        Me.Label128.Name = "Label128"
        Me.Label128.Size = New System.Drawing.Size(120, 16)
        Me.Label128.TabIndex = 23
        Me.Label128.Text = "Cédula"
        Me.Label128.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fld_Ventas_Ingresos
        '
        Me.fld_Ventas_Ingresos.BackColor = System.Drawing.Color.White
        Me.fld_Ventas_Ingresos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_Ventas_Ingresos.Location = New System.Drawing.Point(503, 3)
        Me.fld_Ventas_Ingresos.Name = "fld_Ventas_Ingresos"
        Me.fld_Ventas_Ingresos.Size = New System.Drawing.Size(100, 20)
        Me.fld_Ventas_Ingresos.TabIndex = 41
        Me.fld_Ventas_Ingresos.Text = "0.00"
        Me.fld_Ventas_Ingresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label129
        '
        Me.Label129.AutoSize = True
        Me.Label129.Location = New System.Drawing.Point(7, 53)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(54, 13)
        Me.Label129.TabIndex = 52
        Me.Label129.Text = "Inventario"
        '
        'Label130
        '
        Me.Label130.AutoSize = True
        Me.Label130.Location = New System.Drawing.Point(7, 74)
        Me.Label130.Name = "Label130"
        Me.Label130.Size = New System.Drawing.Size(145, 13)
        Me.Label130.TabIndex = 52
        Me.Label130.Text = "Total Activo Corriente(1+2+3)"
        '
        'Label132
        '
        Me.Label132.AutoSize = True
        Me.Label132.Location = New System.Drawing.Point(7, 95)
        Me.Label132.Name = "Label132"
        Me.Label132.Size = New System.Drawing.Size(155, 13)
        Me.Label132.TabIndex = 53
        Me.Label132.Text = "Maquinaria, Equipos Mobiliarios"
        '
        'Label134
        '
        Me.Label134.AutoSize = True
        Me.Label134.Location = New System.Drawing.Point(297, 5)
        Me.Label134.Name = "Label134"
        Me.Label134.Size = New System.Drawing.Size(134, 13)
        Me.Label134.TabIndex = 53
        Me.Label134.Text = "Ventas mes / Ingresos fijos"
        '
        'Label136
        '
        Me.Label136.AutoSize = True
        Me.Label136.Location = New System.Drawing.Point(297, 30)
        Me.Label136.Name = "Label136"
        Me.Label136.Size = New System.Drawing.Size(79, 13)
        Me.Label136.TabIndex = 53
        Me.Label136.Text = "Compras / Mes"
        '
        'Label137
        '
        Me.Label137.AutoSize = True
        Me.Label137.Location = New System.Drawing.Point(7, 124)
        Me.Label137.Name = "Label137"
        Me.Label137.Size = New System.Drawing.Size(51, 13)
        Me.Label137.TabIndex = 53
        Me.Label137.Text = "Mobiliario"
        '
        'Label138
        '
        Me.Label138.AutoSize = True
        Me.Label138.Location = New System.Drawing.Point(7, 124)
        Me.Label138.Name = "Label138"
        Me.Label138.Size = New System.Drawing.Size(34, 13)
        Me.Label138.TabIndex = 53
        Me.Label138.Text = "Barrio"
        '
        'Label139
        '
        Me.Label139.AutoSize = True
        Me.Label139.Location = New System.Drawing.Point(7, 167)
        Me.Label139.Name = "Label139"
        Me.Label139.Size = New System.Drawing.Size(125, 13)
        Me.Label139.TabIndex = 54
        Me.Label139.Text = "Otros Activos (Vehiculos)"
        '
        'Label140
        '
        Me.Label140.AutoSize = True
        Me.Label140.Location = New System.Drawing.Point(297, 74)
        Me.Label140.Name = "Label140"
        Me.Label140.Size = New System.Drawing.Size(39, 13)
        Me.Label140.TabIndex = 67
        Me.Label140.Text = "Salario"
        '
        'Label142
        '
        Me.Label142.AutoSize = True
        Me.Label142.Location = New System.Drawing.Point(297, 53)
        Me.Label142.Name = "Label142"
        Me.Label142.Size = New System.Drawing.Size(95, 13)
        Me.Label142.TabIndex = 66
        Me.Label142.Text = "Margen Bruto (1-2)"
        '
        'fld_salario
        '
        Me.fld_salario.BackColor = System.Drawing.Color.White
        Me.fld_salario.Location = New System.Drawing.Point(503, 71)
        Me.fld_salario.Name = "fld_salario"
        Me.fld_salario.Size = New System.Drawing.Size(100, 20)
        Me.fld_salario.TabIndex = 65
        Me.fld_salario.Text = "0.00"
        Me.fld_salario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fld_margen_bruto
        '
        Me.fld_margen_bruto.BackColor = System.Drawing.Color.White
        Me.fld_margen_bruto.Location = New System.Drawing.Point(503, 49)
        Me.fld_margen_bruto.Name = "fld_margen_bruto"
        Me.fld_margen_bruto.Size = New System.Drawing.Size(100, 20)
        Me.fld_margen_bruto.TabIndex = 63
        Me.fld_margen_bruto.Text = "0.00"
        Me.fld_margen_bruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Fld_Otros_Activos
        '
        Me.Fld_Otros_Activos.BackColor = System.Drawing.Color.White
        Me.Fld_Otros_Activos.Location = New System.Drawing.Point(182, 163)
        Me.Fld_Otros_Activos.Name = "Fld_Otros_Activos"
        Me.Fld_Otros_Activos.Size = New System.Drawing.Size(100, 20)
        Me.Fld_Otros_Activos.TabIndex = 62
        Me.Fld_Otros_Activos.Text = "0.00"
        Me.Fld_Otros_Activos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Fld_inventario
        '
        Me.Fld_inventario.BackColor = System.Drawing.Color.White
        Me.Fld_inventario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fld_inventario.Location = New System.Drawing.Point(182, 49)
        Me.Fld_inventario.Name = "Fld_inventario"
        Me.Fld_inventario.Size = New System.Drawing.Size(100, 20)
        Me.Fld_inventario.TabIndex = 60
        Me.Fld_inventario.Text = "0.00"
        Me.Fld_inventario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fld_compras_mes
        '
        Me.fld_compras_mes.BackColor = System.Drawing.Color.White
        Me.fld_compras_mes.Location = New System.Drawing.Point(503, 27)
        Me.fld_compras_mes.Name = "fld_compras_mes"
        Me.fld_compras_mes.Size = New System.Drawing.Size(100, 20)
        Me.fld_compras_mes.TabIndex = 62
        Me.fld_compras_mes.Text = "0.00"
        Me.fld_compras_mes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Fld_Total_Activo
        '
        Me.Fld_Total_Activo.BackColor = System.Drawing.Color.White
        Me.Fld_Total_Activo.Location = New System.Drawing.Point(182, 71)
        Me.Fld_Total_Activo.Name = "Fld_Total_Activo"
        Me.Fld_Total_Activo.Size = New System.Drawing.Size(100, 20)
        Me.Fld_Total_Activo.TabIndex = 61
        Me.Fld_Total_Activo.Text = "0.00"
        Me.Fld_Total_Activo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Fld_Inmueble_terreno
        '
        Me.Fld_Inmueble_terreno.BackColor = System.Drawing.Color.White
        Me.Fld_Inmueble_terreno.Location = New System.Drawing.Point(182, 140)
        Me.Fld_Inmueble_terreno.Name = "Fld_Inmueble_terreno"
        Me.Fld_Inmueble_terreno.Size = New System.Drawing.Size(100, 20)
        Me.Fld_Inmueble_terreno.TabIndex = 61
        Me.Fld_Inmueble_terreno.Text = "0.00"
        Me.Fld_Inmueble_terreno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Fld_Mobiliario
        '
        Me.Fld_Mobiliario.BackColor = System.Drawing.Color.White
        Me.Fld_Mobiliario.Location = New System.Drawing.Point(182, 118)
        Me.Fld_Mobiliario.Name = "Fld_Mobiliario"
        Me.Fld_Mobiliario.Size = New System.Drawing.Size(100, 20)
        Me.Fld_Mobiliario.TabIndex = 61
        Me.Fld_Mobiliario.Text = "0.00"
        Me.Fld_Mobiliario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Fld_Maquinaria_Equipos
        '
        Me.Fld_Maquinaria_Equipos.BackColor = System.Drawing.Color.White
        Me.Fld_Maquinaria_Equipos.Location = New System.Drawing.Point(182, 94)
        Me.Fld_Maquinaria_Equipos.Name = "Fld_Maquinaria_Equipos"
        Me.Fld_Maquinaria_Equipos.Size = New System.Drawing.Size(100, 20)
        Me.Fld_Maquinaria_Equipos.TabIndex = 61
        Me.Fld_Maquinaria_Equipos.Text = "0.00"
        Me.Fld_Maquinaria_Equipos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel8
        '
        Me.Panel8.AutoScroll = True
        Me.Panel8.Controls.Add(Me.fld_Comentario_Analista)
        Me.Panel8.Controls.Add(Me.Fld_Comentario_Encargado)
        Me.Panel8.Controls.Add(Me.Label164)
        Me.Panel8.Controls.Add(Me.Label170)
        Me.Panel8.Controls.Add(Me.Label172)
        Me.Panel8.Controls.Add(Me.fld_Dispo_de_fondo)
        Me.Panel8.Controls.Add(Me.Label177)
        Me.Panel8.Controls.Add(Me.Label179)
        Me.Panel8.Controls.Add(Me.Label183)
        Me.Panel8.Controls.Add(Me.Label186)
        Me.Panel8.Controls.Add(Me.fld_monto_recomendado)
        Me.Panel8.Controls.Add(Me.fldComentario_Oficial)
        Me.Panel8.Location = New System.Drawing.Point(692, 347)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(326, 254)
        Me.Panel8.TabIndex = 136
        '
        'fld_Comentario_Analista
        '
        Me.fld_Comentario_Analista.BackColor = System.Drawing.Color.White
        Me.fld_Comentario_Analista.Location = New System.Drawing.Point(6, 303)
        Me.fld_Comentario_Analista.Multiline = True
        Me.fld_Comentario_Analista.Name = "fld_Comentario_Analista"
        Me.fld_Comentario_Analista.Size = New System.Drawing.Size(290, 83)
        Me.fld_Comentario_Analista.TabIndex = 104
        '
        'Fld_Comentario_Encargado
        '
        Me.Fld_Comentario_Encargado.BackColor = System.Drawing.Color.White
        Me.Fld_Comentario_Encargado.Location = New System.Drawing.Point(4, 188)
        Me.Fld_Comentario_Encargado.Multiline = True
        Me.Fld_Comentario_Encargado.Name = "Fld_Comentario_Encargado"
        Me.Fld_Comentario_Encargado.Size = New System.Drawing.Size(290, 83)
        Me.Fld_Comentario_Encargado.TabIndex = 103
        '
        'Label164
        '
        Me.Label164.AutoSize = True
        Me.Label164.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label164.Location = New System.Drawing.Point(7, 281)
        Me.Label164.Name = "Label164"
        Me.Label164.Size = New System.Drawing.Size(261, 13)
        Me.Label164.TabIndex = 97
        Me.Label164.Text = "COMENTARIO DEL ANALISTA DE CREDITO"
        Me.Label164.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label170
        '
        Me.Label170.AutoSize = True
        Me.Label170.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label170.Location = New System.Drawing.Point(7, 8)
        Me.Label170.Name = "Label170"
        Me.Label170.Size = New System.Drawing.Size(134, 13)
        Me.Label170.TabIndex = 22
        Me.Label170.Text = "Disponibilidad de Fondos $"
        Me.Label170.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label172
        '
        Me.Label172.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label172.Location = New System.Drawing.Point(7, 8)
        Me.Label172.Name = "Label172"
        Me.Label172.Size = New System.Drawing.Size(120, 16)
        Me.Label172.TabIndex = 22
        Me.Label172.Text = "Nombre"
        Me.Label172.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fld_Dispo_de_fondo
        '
        Me.fld_Dispo_de_fondo.BackColor = System.Drawing.Color.White
        Me.fld_Dispo_de_fondo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_Dispo_de_fondo.Location = New System.Drawing.Point(147, 7)
        Me.fld_Dispo_de_fondo.Name = "fld_Dispo_de_fondo"
        Me.fld_Dispo_de_fondo.ReadOnly = True
        Me.fld_Dispo_de_fondo.Size = New System.Drawing.Size(100, 20)
        Me.fld_Dispo_de_fondo.TabIndex = 41
        Me.fld_Dispo_de_fondo.Text = "0.00"
        Me.fld_Dispo_de_fondo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label177
        '
        Me.Label177.AutoSize = True
        Me.Label177.Location = New System.Drawing.Point(7, 33)
        Me.Label177.Name = "Label177"
        Me.Label177.Size = New System.Drawing.Size(110, 13)
        Me.Label177.TabIndex = 52
        Me.Label177.Text = "Monto Recomendado"
        '
        'Label179
        '
        Me.Label179.AutoSize = True
        Me.Label179.Location = New System.Drawing.Point(7, 33)
        Me.Label179.Name = "Label179"
        Me.Label179.Size = New System.Drawing.Size(110, 13)
        Me.Label179.TabIndex = 52
        Me.Label179.Text = "Monto Recomendado"
        '
        'Label183
        '
        Me.Label183.AutoSize = True
        Me.Label183.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label183.Location = New System.Drawing.Point(11, 62)
        Me.Label183.Name = "Label183"
        Me.Label183.Size = New System.Drawing.Size(229, 13)
        Me.Label183.TabIndex = 53
        Me.Label183.Text = "COMENTARIO OFICIAL DE NEGOCIOS"
        '
        'Label186
        '
        Me.Label186.AutoSize = True
        Me.Label186.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label186.Location = New System.Drawing.Point(7, 172)
        Me.Label186.Name = "Label186"
        Me.Label186.Size = New System.Drawing.Size(287, 13)
        Me.Label186.TabIndex = 53
        Me.Label186.Text = "COMENTARIO DEL ENCARGADO DE NEGOCIOS"
        '
        'fld_monto_recomendado
        '
        Me.fld_monto_recomendado.BackColor = System.Drawing.Color.White
        Me.fld_monto_recomendado.Location = New System.Drawing.Point(147, 33)
        Me.fld_monto_recomendado.Name = "fld_monto_recomendado"
        Me.fld_monto_recomendado.Size = New System.Drawing.Size(100, 20)
        Me.fld_monto_recomendado.TabIndex = 61
        Me.fld_monto_recomendado.Text = "0.00"
        Me.fld_monto_recomendado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fldComentario_Oficial
        '
        Me.fldComentario_Oficial.BackColor = System.Drawing.Color.White
        Me.fldComentario_Oficial.Location = New System.Drawing.Point(10, 78)
        Me.fldComentario_Oficial.Multiline = True
        Me.fldComentario_Oficial.Name = "fldComentario_Oficial"
        Me.fldComentario_Oficial.Size = New System.Drawing.Size(288, 83)
        Me.fldComentario_Oficial.TabIndex = 61
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label96.Location = New System.Drawing.Point(381, 325)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(128, 13)
        Me.Label96.TabIndex = 137
        Me.Label96.Text = "IGRESOS Y GASTOS"
        Me.Label96.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnVerSolicitud
        '
        Me.BtnVerSolicitud.BackColor = System.Drawing.SystemColors.Control
        Me.BtnVerSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.BtnVerSolicitud.ForeColor = System.Drawing.Color.Black
        Me.BtnVerSolicitud.Image = CType(resources.GetObject("BtnVerSolicitud.Image"), System.Drawing.Image)
        Me.BtnVerSolicitud.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnVerSolicitud.Location = New System.Drawing.Point(1201, 86)
        Me.BtnVerSolicitud.Name = "BtnVerSolicitud"
        Me.BtnVerSolicitud.Size = New System.Drawing.Size(88, 56)
        Me.BtnVerSolicitud.TabIndex = 138
        Me.BtnVerSolicitud.Text = "&Ver Solicitud"
        Me.BtnVerSolicitud.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnVerSolicitud.UseVisualStyleBackColor = False
        '
        'frmSolicitudCredito
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1296, 630)
        Me.Controls.Add(Me.BtnVerSolicitud)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label96)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.comentarioBtn)
        Me.Controls.Add(Me.socioExistenteBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnListaPrestamos)
        Me.Controls.Add(Me.btnAccion)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btn_nuevo_cliente)
        Me.Controls.Add(Me.btnImprime)
        Me.Controls.Add(Me.btnBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSolicitudCredito"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitud de Crédito"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim SocioNuevo As Boolean = True

    Private Sub frmSolicitudCredito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        fld_porciento.Text = SCALAR_NUM("SELECT TasaInteres FROM parametrosgenerales WHERE ID=1")

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim F As New frmSolicitudCreditoClienteList
        F.Text = "Lista de Clientes Todos"
        F.ShowDialog()
        If F.Text = "ACEPTAR" Then

            buscarSocio(Id, True)
        End If
        F.Dispose()

    End Sub

    Private Function CrearSocio() As Integer


        NON_QUERY("INSERT INTO tbl_clientes ( TipoDocumento, fld_FullName, fld_apodo, fld_Identity, fld_Phone, fld_Phone2, fld_Address, fld_City_id, fld_City, fld_Status, fld_bce, fld_cod_zona, fld_zona,fld_nombre_con, fld_apodo_con, fld_cedula_con, fld_telefono_con, fld_celular_con, fld_ref_personales_cliente, fld_ref_comerciales_cliente, fld_nombre_gar, fld_apodo_gar, fld_cedula_gar, fld_telefono_gar, fld_celular_gar, fld_direccion_gar, fld_ciudad_gar, fld_ref_personales_gar, fld_ref_comerciales_gar, fld_ingresos_mesuales, fld_nombre_banco1, fld_cuenta_banco1, fld_nombre_banco2,fld_cuenta_banco2, fld_otra_informacion, fld_nombre_con_gar, fld_apodo_con_gar, fld_cedula_con_gar, fld_telefono_con_gar, fld_celular_con_gar, fld_edad, fld_estado_civil, fld_edad_gar, fld_estado_civil_gar, fld_ocupacion_cliente, fld_ocupacion_gar, fld_sector_id, fld_sector, fld_categoria, fld_limite, Puesto, TimpoTrabajo, ReferidoPor, Oriundo, DataCredito, ctaContable, email, fechaIngreso) (SELECT TipoDocumento, fld_FullName, fld_apodo, fld_Identity, fld_Phone, fld_Phone2, fld_Address, fld_City_id, fld_City, fld_Status, fld_bce, fld_cod_zona, fld_zona, fld_nombre_con, fld_apodo_con, fld_cedula_con, fld_telefono_con, fld_celular_con, fld_ref_personales_cliente, fld_ref_comerciales_cliente, fld_nombre_gar, fld_apodo_gar, fld_cedula_gar, fld_telefono_gar, fld_celular_gar, fld_direccion_gar, fld_ciudad_gar, fld_ref_personales_gar, fld_ref_comerciales_gar, fld_ingresos_mesuales, fld_nombre_banco1, fld_cuenta_banco1, fld_nombre_banco2, fld_cuenta_banco2, fld_otra_informacion, fld_nombre_con_gar,fld_apodo_con_gar, fld_cedula_con_gar, fld_telefono_con_gar, fld_celular_con_gar, fld_edad, fld_estado_civil, fld_edad_gar, fld_estado_civil_gar,fld_ocupacion_cliente, fld_ocupacion_gar, fld_sector_id, fld_sector, fld_categoria, fld_limite, Puesto, TimpoTrabajo, ReferidoPor, Oriundo, DataCredito, ctaContable, email, fechaIngreso FROM solicitudcreditocliente WHERE fld_id=" & CInt(txtId.Text) & ")")

        Return UltimoID("tbl_clientes", "fld_id")
    End Function

    Private Sub buscarSocio(ByVal idSocio As Integer, ByVal socioesNuevo As Boolean)
        Dim ds As New DataSet
        Dim Sql As String = "SELECT * FROM SolicitudCreditoCliente WHERE fld_id=" & idSocio & ""
        If socioesNuevo = False Then
            Sql = "SELECT * FROM tbl_clientes WHERE fld_id=" & idSocio & ""
        End If

        Dim da As New MySqlDataAdapter(Sql, conn)
        da.Fill(ds)

        Dim nr As DataRow

        For Each nr In ds.Tables(0).Rows

            txtId.Text = idSocio
            txtNombre.Text = nr("fld_FullName")
            fld_phone.Text = nr("fld_phone")
            fld_phone2.Text = nr("fld_phone2")
            TxtCedula.Text = nr("fld_Identity")
            SocioNuevo = socioesNuevo

            GoTo sigue
        Next
        Alerta("No se encontró el documento solicitado")
        txtId.Focus()
        da.Dispose()
        ds.Dispose()
        Exit Sub
sigue:
        fld_fecha_entrega.Focus()
        da.Dispose()
        ds.Dispose()
    End Sub

    Private Sub buscarSolicitud(ByVal IdDoc As Integer)
        Dim isdata As Boolean = False
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM solicitudcredito WHERE Id=" & IdDoc & "", conn)
        da.Fill(ds, "solicitudcredito")

        Dim nr As DataRow
        For Each nr In ds.Tables(0).Rows
            fld_cod_prestamo.Text = IdDoc
            fld_fecha_entrega.Value = nr("FechaInicio")
            fld_monto_prestamo.Text = Format(nr("Monto"), "N2")
            txtMontoCuota.Text = Format(nr("MontoCuotas"), "N2")
            fld_cantidad_cuotas.Text = nr("CantCuotas")
            fld_clasificacion.Text = nr("Clasificacion")
            fld_tipo_prestamo.Text = nr("Condicion")
            fld_porciento.Text = nr("Interes")
            'fldTazaMora.Text = nr("fldTazaMora")
            txtNotaGeneral.Text = nr("Notas")
            MontoSolicitadoTxt.Text = Format(nr("MontoSolicitado"), "N2")
            GastoLegalTxt.Text = Format(nr("MontoLegal"), "N2")
            SeguroTxt.Text = Format(nr("Seguro"), "N2")

            If nr("SocioNuevo") > 0 Then
                buscarSocio(nr("Socio"), True)
            Else
                buscarSocio(nr("Socio"), False)
            End If
            btnAccion.Visible = True

            btnImprime.Enabled = True
            btnProcesar.Enabled = False
            comentarioBtn.Enabled = True
            btnBorrar.Enabled = True
            comentarioBtn.Enabled = True

            If nr("Estado") = "Nueva" Then
                btnAccion.Text = "Aprobar"

            ElseIf nr("Estado") = "Aprobada" Then

                btnAccion.Text = "Procesar"
                btnBorrar.Enabled = False
                comentarioBtn.Enabled = False
                btnImprime.Enabled = False
            Else
                btnAccion.Visible = False
            End If





            GoTo sigue
        Next


        Alerta("No se encontró el documento solicitado")
        fld_cod_prestamo.Text = "0"
        fld_cod_prestamo.Focus()

sigue:

        da.Dispose()
        ds.Dispose()
    End Sub

    Private Sub calculoCuota()
        Dim interes_cuota As Double = Redondear((CDec(fld_monto_prestamo.Text) * CDec(fld_porciento.Text)) / 100, 2)
        Dim capital As Double = Redondear(CDec(fld_monto_prestamo.Text) / CDec(fld_cantidad_cuotas.Text), 2)


        If fld_clasificacion.Text = "Int. Adelantado" Then
            'txtMontoCuota.Text = Format(interes_cuota, "C2")
            txtMontoCuota.Text = interes_cuota
        ElseIf fld_clasificacion.Text = "Int. y Capital Amorizable" Then
            Dim Interes = CDec(fld_porciento.Text)
            Dim totalCuotas = CDec(fld_cantidad_cuotas.Text)
            Dim montoPrestamo = CDec(fld_monto_prestamo.Text)
            If Interes > 0 Then Interes = Interes / 100
            'txtMontoCuota.Text = Format(Pmt(Interes, totalCuotas, -montoPrestamo, 0, DueDate.EndOfPeriod), "C2")
            txtMontoCuota.Text = Pmt(Interes, totalCuotas, -montoPrestamo, 0, DueDate.EndOfPeriod)
        ElseIf fld_clasificacion.Text = "Int. y Capital Fijos" Then
            'txtMontoCuota.Text = Format(interes_cuota + capital, "C2")
            txtMontoCuota.Text = interes_cuota + capital
        Else
            'txtMontoCuota.Text = Format(capital, "C2")
            txtMontoCuota.Text = capital
        End If


    End Sub

    Private Function validarDatos() As Boolean

        If Trim(fld_porciento.Text) = "" Then fld_porciento.Text = "0.00"

        If fldTazaMora.Text = String.Empty Then fldTazaMora.Text = 0

        If MontoSolicitadoTxt.Text = String.Empty Then MontoSolicitadoTxt.Text = 0

        If SeguroTxt.Text = String.Empty Then SeguroTxt.Text = 0

        If GastoLegalTxt.Text = String.Empty Then GastoLegalTxt.Text = 0


        If txtNombre.Text = "" Then
            Alerta("Debe cargar los datos del cliente")
            Return False
        ElseIf CDec(Trim(fld_monto_prestamo.Text)) = 0 Then
            fld_monto_prestamo.Focus()
            Alerta("Introduzca el monto del préstamo")
            Return False
        ElseIf CDbl(Trim(fld_cantidad_cuotas.Text)) = 0 Then
            fld_cantidad_cuotas.Focus()
            Alerta("Introduzca la cantidad de cuotas")
            Return False
        ElseIf CDbl(Trim(MontoSolicitadoTxt.Text)) = 0 Then
            MontoSolicitadoTxt.Focus()
            Alerta("Introduzca el monto de la solicitud")
            Return False
        ElseIf CDbl(Trim(SeguroTxt.Text)) = 0 Then
            SeguroTxt.Focus()
            Alerta("Introduzca el monto del seguro")
            Return False
        ElseIf CDbl(Trim(GastoLegalTxt.Text)) = 0 Then
            GastoLegalTxt.Focus()
            Alerta("Introduzca el monto de gasto legal")
            Return False
        End If

        Return True

    End Function

    Private Sub guardarDoc()

        If validarDatos() = False Then Exit Sub
        calculoCuota()

        If CDec(Trim(fld_cantidad_cuotas.Text)) > 0 Then
            'HACER LOS CALCULOS Y GENERAL EL PRESTAMO SI EL USUARIO ACEPTA
            If Alerta("Verifique que los datos esten correcto..." & Chr(13) & "¿Desea continuar?") = True Then
                If SocioNuevo = True Then
                    'SolicitudCredito()
                    SolicitudCredito()
                    'NON_QUERY("INSERT INTO solicitudcredito (FechaCreada, FechaAprobacion, CreadoPor, AprobadoPOr,Condicion, Clasificacion, FechaInicio, Monto, Interes, CantCuotas, MontoCuotas, Notas, Socio, SocioNuevo, MontoSolicitado, Seguro, Montolegal) VALUES(Now(),Now()," & User(5) & ",0,'" & fld_tipo_prestamo.Text & "','" & fld_clasificacion.Text & "','" & formatDate(fld_fecha_entrega.Value.Date) & "'," & CDec(fld_monto_prestamo.Text) & "," & CDec(fld_porciento.Text) & "," & CInt(fld_cantidad_cuotas.Text) & "," & CDec(txtMontoCuota.Text) & ",'" & txtNotaGeneral.Text & "'," & CInt(txtId.Text) & ",1," & CDec(MontoSolicitadoTxt.Text) & ", " & CDec(SeguroTxt.Text) & ", " & CDec(GastoLegalTxt.Text) & ")")
                    'NON_QUERY("INSERT INTO solicitudcredito (FechaCreada, FechaAprobacion, CreadoPor, AprobadoPOr,Condicion, Clasificacion, FechaInicio, Monto, Interes, CantCuotas, MontoCuotas, Notas, Socio,MontoSolicitado, Seguro, Montolegal) VALUES(Now(),Now()," & User(5) & ",0,'" & fld_tipo_prestamo.Text & "','" & fld_clasificacion.Text & "','" & formatDate(fld_fecha_entrega.Value.Date) & "'," & CDec(fld_monto_prestamo.Text) & "," & CDec(fld_porciento.Text) & "," & CInt(fld_cantidad_cuotas.Text) & "," & CDec(txtMontoCuota.Text) & ",'" & txtNotaGeneral.Text & "'," & CInt(txtId.Text) & ",1," & CDec(MontoSolicitadoTxt.Text) & ", " & CDec(SeguroTxt.Text) & ", " & CDec(GastoLegalTxt.Text) & ")")

                Else

                    'NON_QUERY("INSERT INTO solicitudcredito (FechaCreada, FechaAprobacion, CreadoPor, AprobadoPOr,Condicion, Clasificacion, FechaInicio, Monto, Interes, CantCuotas, MontoCuotas, Notas, Socio, SocioNuevo, MontoSolicitado, Seguro, Montolegal) VALUES(Now(),Now()," & User(5) & ",0,'" & fld_tipo_prestamo.Text & "','" & fld_clasificacion.Text & "','" & formatDate(fld_fecha_entrega.Value.Date) & "'," & CDec(fld_monto_prestamo.Text) & "," & CDec(fld_porciento.Text) & "," & CInt(fld_cantidad_cuotas.Text) & "," & CDec(txtMontoCuota.Text) & ",'" & txtNotaGeneral.Text & "'," & CInt(txtId.Text) & ",0," & CDec(MontoSolicitadoTxt.Text) & ", " & CDec(SeguroTxt.Text) & ", " & CDec(GastoLegalTxt.Text) & ")")
                    'SolicitudCredito()
                    SolicitudCredito()
                    'NON_QUERY("INSERT INTO solicitudcredito (FechaCreada, FechaAprobacion, CreadoPor, AprobadoPOr,Condicion, Clasificacion, FechaInicio, Monto, Interes, CantCuotas, MontoCuotas, Notas, Socio,MontoSolicitado, Seguro, Montolegal) VALUES(Now(),Now()," & User(5) & ",0,'" & fld_tipo_prestamo.Text & "','" & fld_clasificacion.Text & "','" & formatDate(fld_fecha_entrega.Value.Date) & "'," & CDec(fld_monto_prestamo.Text) & "," & CDec(fld_porciento.Text) & "," & CInt(fld_cantidad_cuotas.Text) & "," & CDec(txtMontoCuota.Text) & ",'" & txtNotaGeneral.Text & "'," & CInt(txtId.Text) & ",0," & CDec(MontoSolicitadoTxt.Text) & ", " & CDec(SeguroTxt.Text) & ", " & CDec(GastoLegalTxt.Text) & ")")

                End If

            End If

            fld_cod_prestamo.Text = UltimoID("solicitudcredito", "Id")
            fld_cod_prestamo.Enabled = False
            txtId.Enabled = False
            btnImprime.Enabled = True
            'btnProcesar.Enabled = False
            btnBorrar.Enabled = True
            comentarioBtn.Enabled = True
            Alerta("Documento guardado")
        End If

    End Sub
    Private Function SolicitudCredito() As Boolean
        Dim cmd As New MySqlCommand
        Try
            conn.Open()
            cmd = New MySqlCommand("sp_insertar_solicitud_credito", conn)
            cmd.CommandType = 4
            cmd.Parameters.Add("_fechaCreada", Date.Now)
            cmd.Parameters.Add("_fechaAprobacion", Date.Now)
            cmd.Parameters.Add("_creadoPor", User(5))
            cmd.Parameters.Add("_AprobadoPor", 0)
            cmd.Parameters.Add("_condicion", fld_tipo_prestamo.Text)
            cmd.Parameters.Add("_clasificacion", fld_clasificacion.Text)
            cmd.Parameters.Add("_fechaInicio", formatDate(fld_fecha_entrega.Value.Date))
            cmd.Parameters.Add("_montoSolicitado", MontoSolicitadoTxt.Text)
            cmd.Parameters.Add("_monto", fld_monto_prestamo.Text)
            cmd.Parameters.Add("_seguro", SeguroTxt.Text)
            cmd.Parameters.Add("_montoLegal", GastoLegalTxt.Text)
            cmd.Parameters.Add("_interes", fld_porciento.Text)
            cmd.Parameters.Add("_cantCuotas", fld_cantidad_cuotas.Text)
            cmd.Parameters.Add("_montoCuotas", txtMontoCuota.Text)
            cmd.Parameters.Add("_socio", txtId.Text)
            cmd.Parameters.Add("s_ocioExistente", txtId.Text)
            cmd.Parameters.Add("_estado", "NUEVA")
            cmd.Parameters.Add("_cedula", TxtCedula.Text)
            cmd.Parameters.Add("_direccion", Fld_direccion.Text.Trim)
            cmd.Parameters.Add("_provincia", Fld_Provincia.Text.Trim)
            cmd.Parameters.Add("_municipio", Fld_Municipio.Text.Trim)
            cmd.Parameters.Add("_barrio", Fld_Barrio.Text.Trim)
            cmd.Parameters.Add("_phone", fld_phone.Text)
            cmd.Parameters.Add("_phone2", fld_phone2.Text)
            cmd.Parameters.Add("_casa_propia", "")
            cmd.Parameters.Add("_tiempo_vivienda", Fld_tiempo_vivienda.Text)
            cmd.Parameters.Add("_casa_alquilada", "-")
            cmd.Parameters.Add("_tiempo_alquiler", fld_tiempo_alquiler.Text)
            cmd.Parameters.Add("_correo", Fld_email.Text.Trim)
            cmd.Parameters.Add("_empresa", Fld_emppresa.Text.Trim)
            cmd.Parameters.Add("_phone3", Fld_phone3.Text)
            cmd.Parameters.Add("_empresa_agno", Fld_Emp_agno.Text)
            cmd.Parameters.Add("_empresa_meses", Fld_emp_meses.Text)
            cmd.Parameters.Add("_nomconyugue", fld_nomConyugue.Text.Trim)
            cmd.Parameters.Add("_tel_conyugue", Fld_tel_conyugue.Text)
            cmd.Parameters.Add("_nomflila", fld_nomFlia.Text.Trim)
            cmd.Parameters.Add("_tel_flia", fld_tel_flia.Text)
            cmd.Parameters.Add("_codeudor", fld_Codeudor.Text.Trim)
            cmd.Parameters.Add("_tel_codeudor", fld_tel_codeudor.Text)
            cmd.ExecuteNonQuery()

            Insertar_patrimonio_credito()
                Insertar_Gastos_ingresos()
                Insertar_ingresosFlias()
                Insertar_gastos_Flia()
                Insertar_nota_solicitud()
                SolicitudCredito()

        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message)
            Return False
        Finally
            conn.Close()
        End Try
    End Function
    Private Function Insertar_patrimonio_credito() As Boolean
        Dim cmd As New MySqlCommand
        Try

            cmd = New MySqlCommand("sp_solicitudcreditopatrimonio", conn)
            cmd.CommandType = 4
            cmd.Parameters.Add("_fld_id_sol", UltimoID("solicitudcredito", "Id"))
            cmd.Parameters.Add("_fldefectivo", Fld_efectivo_Caja.Text)
            cmd.Parameters.Add("_fldcxc", Fld_CxC.Text)
            cmd.Parameters.Add("_fldinventario", Fld_inventario.Text)
            cmd.Parameters.Add("_fldtotal_activo_corriente", Fld_Total_Activo.Text)
            cmd.Parameters.Add("_fldmaquina_equipos", Fld_Maquinaria_Equipos.Text)
            cmd.Parameters.Add("_fldmobiliario", Fld_Mobiliario.Text)
            cmd.Parameters.Add("_fldinmueble", Fld_Inmueble_terreno.Text)
            cmd.Parameters.Add("_Fld_Otros_Activos", Fld_Otros_Activos.Text)
            cmd.Parameters.Add("_fldtotal_activos_fijos", Fld_Total_Activo_Fijo.Text)
            cmd.Parameters.Add("_fldtotal_activos", Fld_Total_Activo_4_9.Text)
            cmd.Parameters.Add("_fld_deuda_bancarias", Fld_Deudas_Bancarias.Text)
            cmd.Parameters.Add("_fld_cxc_suplidores", Fld_CxP_Suplidores.Text)
            cmd.Parameters.Add("_fld_otras_cxc", Fld_Otras_CxP.Text)
            cmd.Parameters.Add("_fld_total_pasivo", Fld_Total_Pasivo_10_14.Text)
            cmd.Parameters.Add("_fld_capital", Fld_Capital_10_14.Text)
            cmd.Parameters.Add("_fld_pasivo_capital", Fld_Total_Pasivo_Capital.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
            conn.Close()
        Finally
            conn.Close()
        End Try

    End Function
    Private Function Insertar_Gastos_ingresos() As Boolean
        Dim cmd As New MySqlCommand
        Try
            cmd = New MySqlCommand("sp_solicitudcreditoingresos_gastos", conn)
            cmd.CommandType = 4
            cmd.Parameters.Add("_fld_id_sol", UltimoID("solicitudcredito", "Id"))
            cmd.Parameters.Add("_fld_ventas_ingresos_fijos", fld_Ventas_Ingresos.Text)
            cmd.Parameters.Add("_fld_compra_mes", fld_compras_mes.Text)
            cmd.Parameters.Add("_fld_margen_bruto", fld_margen_bruto.Text)
            cmd.Parameters.Add("_fld_salario", fld_salario.Text)
            cmd.Parameters.Add("_fld_alquileres", fld_alquileres.Text)
            cmd.Parameters.Add("_mant_repacion", Fld_mant_reparacion.Text)
            cmd.Parameters.Add("_Fld_Servicios", Fld_Servicios.Text)
            cmd.Parameters.Add("_fld_Cuotas_Otros_Prestamos", fld_Cuotas_Otros_Prestamos.Text)
            cmd.Parameters.Add("_Fld_Trans_Combustible", Fld_Trans_Combustible.Text)
            cmd.Parameters.Add("_fld_Otros_Gastos", fld_Otros_Gastos.Text)
            cmd.Parameters.Add("_fld_total_gastos", fld_Total_de_Gastos.Text) ',
            cmd.Parameters.Add("_fld_Beneficio_neto", fld_Beneficio_neto.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
            conn.Close()
        Finally
            conn.Close()
        End Try
    End Function
    Private Function Insertar_ingresosFlias() As Boolean
        Dim cmd As New MySqlCommand
        Try
            cmd = New MySqlCommand("sp_solicitudcreditoingresos_flia", conn)
            cmd.CommandType = 4
            cmd.Parameters.Add("_fld_id_sol", UltimoID("solicitudcredito", "Id"))
            cmd.Parameters.Add("_fld_Ingreso_conyugue", fld_Ingreso_conyugue.Text)
            cmd.Parameters.Add("_fld_otros_negocios", fld_OtrosNegocios.Text)
            cmd.Parameters.Add("_fld_remensa_fliares", fld_remesas_fliares.Text)
            cmd.Parameters.Add("_fld_ingresos_flia", fld_total_gastos_fliares.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
            conn.Close()
        Finally
            conn.Close()
        End Try

    End Function
    Public Function Insertar_gastos_Flia() As Boolean
        Dim cmd As New MySqlCommand
        Try
            cmd = New MySqlCommand("solicitudcreditogastos_flia", conn)
            cmd.CommandType = 4
            cmd.Parameters.Add("_fld_id_sol", UltimoID("solicitudcredito", "Id"))
            cmd.Parameters.Add("_fld_vivienda", fld_vivienda.Text)
            cmd.Parameters.Add("_fld_alimentacion", fld_alimentacion.Text)
            cmd.Parameters.Add("_fld_transporte", fld_transporte.Text)
            cmd.Parameters.Add("_fld_educacion", fld_educacion.Text)
            cmd.Parameters.Add("_fld_otros", fld_otros_fliares.Text)
            cmd.Parameters.Add("_fld_total_gastos", fld_total_gastos_fliares.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
            conn.Close()
        Finally
            conn.Close()
        End Try

    End Function
    Public Function Insertar_nota_solicitud() As Boolean
        Dim cmd As New MySqlCommand
        Try
            cmd = New MySqlCommand("sp_solicitudcreditonota", conn)
            cmd.CommandType = 4
            cmd.Parameters.Add("_Fecha", Date.Now)
            cmd.Parameters.Add("_IdSolicitud", UltimoID("solicitudcredito", "Id"))
            cmd.Parameters.Add("_IdUser", User(5))
            cmd.Parameters.Add("_Nota", txtNotaGeneral.Text)
            cmd.Parameters.Add("_comentario_Officer_negocio", fldComentario_Oficial.Text)
            cmd.Parameters.Add("_comentario_enc_negocio", Fld_Comentario_Encargado.Text)
            cmd.Parameters.Add("_comentario_analista_de_credito", fld_Comentario_Analista.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
            conn.Close()
        Finally
            conn.Close()
        End Try

    End Function
    Public Function Insertar_Score_cliente() As Boolean
        Dim cmd As New MySqlCommand
        Try
            conn.Open()
            cmd = New MySqlCommand("sp_score_Cliente", conn)
            cmd.CommandType = 4
            cmd.Parameters.Add("_fld_id_cliente", txtId.Text)
            cmd.Parameters.Add("_fld_id_prestamos", 0)
            cmd.Parameters.Add("_fld_monto_cuotas", txtMontoCuota.Text)
            cmd.Parameters.Add("_fld_disponibilidad", fld_Dispo_de_fondo.Text)
            cmd.Parameters.Add("_fld_puntuacion", 100)
            cmd.Parameters.Add("_fld_status", "Excelente")
            cmd.Parameters.Add("_fld_monto_recomendado", fld_monto_recomendado.Text)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
            conn.Close()
        Finally
            conn.Close()
        End Try

    End Function
    Private Sub modificarDoc(ByVal idDoc As Integer, ByVal User As String)

        If validarDatos() = False Then Exit Sub
        calculoCuota()

        If CDec(Trim(fld_cantidad_cuotas.Text)) > 0 Then
            'HACER LOS CALCULOS Y GENERAL EL PRESTAMO SI EL USUARIO ACEPTA
            If Alerta("Verifique que los datos esten correcto..." & Chr(13) & "¿Desea continuar?") = True Then
                Dim idUser = SCALAR_NUM("SELECT fld_id FROM tbl_user WHERE fld_UserID='" & User & "'")


                NON_QUERY("UPDATE solicitudcredito SET Condicion='" & fld_tipo_prestamo.Text & "', Clasificacion='" & fld_clasificacion.Text & "', FechaInicio='" & formatDate(fld_fecha_entrega.Value.Date) & "', Monto=" & CDec(fld_monto_prestamo.Text) & ", Interes=" & CDec(fld_porciento.Text) & ", CantCuotas=" & CInt(fld_cantidad_cuotas.Text) & ", MontoCuotas=" & CDec(txtMontoCuota.Text) & ", Notas='" & txtNotaGeneral.Text & "', MontoSolicitado=" & CDec(MontoSolicitadoTxt.Text) & ", Seguro=" & CDec(SeguroTxt.Text) & ", Montolegal=" & CDec(GastoLegalTxt.Text) & ", AprobadoPor=" & idUser & ", Estado='Aprobada', FechaAprobacion=Now() WHERE Id=" & idDoc & "")

                Alerta("Documento guardado y Aprobado")
            End If
        End If
    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        guardarDoc()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        CobPrestamos.Text = ""
        txtMontoCuota.Text = "0.00"
        txtId.Text = "0"
        txtNombre.Text = ""
        fld_phone.Text = ""
        fld_phone2.Text = ""
        TxtCedula.Text = ""
        txtNotaGeneral.Text = ""
        GastoLegalTxt.Text = "0.00"
        SeguroTxt.Text = "0.00"
        MontoSolicitadoTxt.Text = "0.00"
        fld_monto_prestamo.Text = "0.00"
        fld_cantidad_cuotas.Text = "0"
        fld_cod_prestamo.Enabled = True
        btnProcesar.Enabled = True
        btnBorrar.Enabled = False
        btnImprime.Enabled = False
        fld_cod_prestamo.Text = 0
        txtId.Focus()
        comentarioBtn.Enabled = False
        txtId.Enabled = True
        SocioNuevo = True
        fld_porciento.Text = SCALAR_NUM("SELECT TasaInteres FROM parametrosgenerales WHERE ID=1")

    End Sub

    Private Sub btn_nuevo_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo_cliente.Click
        Dim f As New frmSolicitudCreditoCliente
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub fld_porciento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fld_monto_prestamo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fld_cantidad_cuotas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMontoCuota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fldTazaMora_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fld_fecha_entrega_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ' If docientoTxt.Text = String.Empty Then docientoTxt.Text = "0.00"
            'resDocientoTxt.Text = Format(CInt(docientoTxt.Text) * 200, "N2")
            MontoSolicitadoTxt.Focus()

        End If
    End Sub

    Private Sub fldTazaMora_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ' If docientoTxt.Text = String.Empty Then docientoTxt.Text = "0.00"
            'resDocientoTxt.Text = Format(CInt(docientoTxt.Text) * 200, "N2")
            fld_porciento.Focus()

        End If
    End Sub

    Private Sub fld_porciento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ' If docientoTxt.Text = String.Empty Then docientoTxt.Text = "0.00"
            'resDocientoTxt.Text = Format(CInt(docientoTxt.Text) * 200, "N2")
            fld_monto_prestamo.Focus()

        End If
    End Sub

    Private Sub fld_monto_prestamo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If fld_monto_prestamo.Text = String.Empty Then fld_monto_prestamo.Text = "0.00"

            Dim amount As Decimal = CType(fld_monto_prestamo.Text, Decimal)
            Me.fld_monto_prestamo.Text = String.Format("{0:n2}", amount)

            fld_cantidad_cuotas.Focus()

        End If


    End Sub

    Private Sub fld_cantidad_cuotas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If validarDatos() = False Then Exit Sub
            calculoCuota()

            btnProcesar.Focus()
        End If
    End Sub

    Private Sub btnImprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprime.Click
        ReportName = "SOLICITUD DE CREDITO"
        Dim rep As New FRM_REPORTS
        rep.idDoc = CInt(fld_cod_prestamo.Text)
        rep.idSocio = CInt(txtId.Text)

        rep.Show()
    End Sub

    Private Sub btnListaPrestamos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListaPrestamos.Click
        Dim f As New frmSolicitudCreditoLista
        f.Text = "Solicitud nueva"
        If MessageBox.Show("El socio es nuevo?", "Socio", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then
            f.socioNuevo = False

        End If

        f.ShowDialog()
        If f.Text = "ACEPTAR" Then
            buscarSolicitud(Id)
        End If

        f.Dispose()
    End Sub
    Private Sub btnAccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccion.Click
        If btnAccion.Text = "Aprobar" Then
            Dim f As New frmAutorizacion
            f.ShowDialog()
            If f.Text = "ACEPTAR" Then
                If SocioNuevo = True Then  'Si el socio es nuevo, lo crea
                    NON_QUERY("UPDATE SolicitudCreditoCliente SET fld_status='P' WHERE fld_id=" & CInt(txtId.Text) & "")

                    Dim IdSocio = CrearSocio()

                    NON_QUERY("UPDATE solicitudcredito SET Socio=" & IdSocio & ", SocioNuevo=0 WHERE Id=" & CInt(fld_cod_prestamo.Text) & "")

                Else

                    NON_QUERY("UPDATE solicitudcredito SET Socio=" & CInt(txtId.Text) & " WHERE Id=" & CInt(fld_cod_prestamo.Text) & "")

                End If

                btnAccion.Text = "Procesar"
                modificarDoc(CInt(fld_cod_prestamo.Text), f.txtUserID.Text)
                btnNuevo_Click(sender, e)
            End If
        ElseIf btnAccion.Text = "Procesar" Then
            If Alerta("Seguro que desea procesar la solicitud?") = False Then Exit Sub
            Dim f As New FRM_PRESTAMO_MAESTRO
            f.IdSolicitudTxt.Text = fld_cod_prestamo.Text
            f.txtId.Text = txtId.Text
            f.ShowDialog()
            If f.Text = "ACEPTAR" Then
                NON_QUERY("UPDATE solicitudcredito SET Estado='Procesada' WHERE Id=" & CInt(fld_cod_prestamo.Text) & "")

                btnNuevo_Click(sender, e)
                Me.Close()
            End If
            f.Dispose()
        End If
    End Sub

    Private Sub MontoSolicitadoTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If MontoSolicitadoTxt.Text = String.Empty Then MontoSolicitadoTxt.Text = "0.00"

            Dim amount As Decimal = CType(MontoSolicitadoTxt.Text, Decimal)
            Me.MontoSolicitadoTxt.Text = String.Format("{0:n2}", amount)

            SeguroTxt.Focus()

        End If

    End Sub

    Private Sub SeguroTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If SeguroTxt.Text = String.Empty Then SeguroTxt.Text = "0.00"

            Dim amount As Decimal = CType(SeguroTxt.Text, Decimal)
            Me.SeguroTxt.Text = String.Format("{0:n2}", amount)

            GastoLegalTxt.Focus()

        End If

    End Sub

    Private Sub GastoLegalTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If GastoLegalTxt.Text = String.Empty Then GastoLegalTxt.Text = "0.00"

            Dim amount As Decimal = CType(GastoLegalTxt.Text, Decimal)
            Me.GastoLegalTxt.Text = String.Format("{0:n2}", amount)

            fld_porciento.Focus()
            fld_monto_prestamo.Text = String.Format("{0:n2}", CDec(MontoSolicitadoTxt.Text) + CDec(GastoLegalTxt.Text) + CDec(SeguroTxt.Text))

        End If

    End Sub

    Private Sub MontoSolicitadoTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If

    End Sub

    Private Sub SeguroTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If

    End Sub

    Private Sub GastoLegalTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub GastoLegalTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub comentarioBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comentarioBtn.Click
        Dim f As New frmSolicitudCreditoNota
        f.IdSolicitud = CInt(fld_cod_prestamo.Text)
        f.ShowDialog()
        f.Dispose()

    End Sub

    Private Sub socioExistenteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles socioExistenteBtn.Click
        If FRMS_POPUP_CLIENTES("TODOS") = True Then
            buscarSocio(Id, False)

        End If
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        If Alerta("Seguro que desea rechazar la solicituD?") = True Then
            Dim f As New frmAutorizacion
            f.ShowDialog()
            If f.Text = "ACEPTAR" Then
                NON_QUERY("UPDATE solicitudcredito SET Estado='Rechazada' WHERE Id=" & CInt(fld_cod_prestamo.Text) & "")
                btnNuevo_Click(sender, e)
            End If
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim f As New frmSolicitudCreditoLista
        f.Text = "Solicitud Aprobada"
        f.ShowDialog()

        If f.Text = "ACEPTAR" Then
            buscarSolicitud(Id)
        End If

        f.Dispose()
    End Sub

    Private Sub MontoSolicitadoTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MaskedTextBox3_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub Label129_Click(sender As Object, e As EventArgs) Handles Label129.Click

    End Sub

    Private Sub fld__TextChanged(sender As Object, e As EventArgs) Handles fld_margen_bruto.TextChanged

    End Sub

    Private Sub TextBox31_TextChanged(sender As Object, e As EventArgs) Handles fld_alquileres.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles fld_total_gastos_fliares.TextChanged

    End Sub
End Class
