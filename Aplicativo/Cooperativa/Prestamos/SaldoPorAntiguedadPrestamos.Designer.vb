<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaldoPorAntiguedadPrestamos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SaldoPorAntiguedadPrestamos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.imprimirBtn = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DgvDatacredito = New System.Windows.Forms.DataGridView()
        Me.Tentidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RclientePre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ncompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CedVieja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CedNueva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NPasaporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rsocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Siglas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rnc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Residencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Celular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Oficina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Beeper = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Otro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Esquina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eresidencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Piso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Urba = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sector = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ciudad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pmunicipio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Esq1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nro1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eresi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Piso1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apto1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Urba1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sector1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ciudad1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nroprestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UdMoneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tprestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fpago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fapertura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fvencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mprestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mcuoata = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantCuota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FultcortePrestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fultpago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MultPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bce = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Matraso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantcuotaAtrasada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstatusCta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoCta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo60 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo90 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo120 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo150 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo180 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo181 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DgvDatacredito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DgvDatacredito)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(996, 526)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.imprimirBtn)
        Me.Panel3.Controls.Add(Me.btnCerrar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 463)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(996, 63)
        Me.Panel3.TabIndex = 1
        '
        'imprimirBtn
        '
        Me.imprimirBtn.BackColor = System.Drawing.SystemColors.Control
        Me.imprimirBtn.ForeColor = System.Drawing.Color.Black
        Me.imprimirBtn.Image = CType(resources.GetObject("imprimirBtn.Image"), System.Drawing.Image)
        Me.imprimirBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.imprimirBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.imprimirBtn.Location = New System.Drawing.Point(833, 4)
        Me.imprimirBtn.Name = "imprimirBtn"
        Me.imprimirBtn.Size = New System.Drawing.Size(72, 56)
        Me.imprimirBtn.TabIndex = 116
        Me.imprimirBtn.Text = "&Imprimir"
        Me.imprimirBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.imprimirBtn.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrar.Location = New System.Drawing.Point(911, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 56)
        Me.btnCerrar.TabIndex = 115
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(996, 61)
        Me.Panel2.TabIndex = 0
        '
        'DgvDatacredito
        '
        Me.DgvDatacredito.AllowUserToAddRows = False
        Me.DgvDatacredito.AllowUserToDeleteRows = False
        Me.DgvDatacredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDatacredito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tentidad, Me.Codigo, Me.RclientePre, Me.Ncompleto, Me.CedVieja, Me.CedNueva, Me.NPasaporte, Me.Rsocial, Me.Siglas, Me.Rnc, Me.Residencia, Me.Celular, Me.Oficina, Me.Beeper, Me.Fax, Me.Otro, Me.Calle, Me.Esquina, Me.Nro, Me.Eresidencia, Me.Piso, Me.Apto, Me.Urba, Me.Sector, Me.Ciudad, Me.Pmunicipio, Me.Cave, Me.Esq1, Me.Nro1, Me.Eresi, Me.Piso1, Me.Apto1, Me.Urba1, Me.Sector1, Me.Ciudad1, Me.Provincia, Me.Nroprestamo, Me.UdMoneda, Me.Tprestamo, Me.Fpago, Me.Fapertura, Me.Fvencimiento, Me.Mprestamo, Me.Mcuoata, Me.CantCuota, Me.FultcortePrestamo, Me.Fultpago, Me.MultPago, Me.Bce, Me.Matraso, Me.CantcuotaAtrasada, Me.EstatusCta, Me.EstadoCta, Me.Saldo30, Me.saldo60, Me.saldo90, Me.saldo120, Me.saldo150, Me.Saldo180, Me.Saldo181})
        Me.DgvDatacredito.Location = New System.Drawing.Point(3, 67)
        Me.DgvDatacredito.Name = "DgvDatacredito"
        Me.DgvDatacredito.ReadOnly = True
        Me.DgvDatacredito.Size = New System.Drawing.Size(980, 390)
        Me.DgvDatacredito.TabIndex = 25
        '
        'Tentidad
        '
        Me.Tentidad.DataPropertyName = "fld_entidad"
        Me.Tentidad.HeaderText = "Tipo de Entidad(Persona o Empresa)"
        Me.Tentidad.Name = "Tentidad"
        Me.Tentidad.ReadOnly = True
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "fld_cod_cliente"
        Me.Codigo.HeaderText = "Codigo de Cliente"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'RclientePre
        '
        Me.RclientePre.DataPropertyName = "fld_relacion_cliente"
        Me.RclientePre.HeaderText = "Relacion del Cliente con el Prestamo"
        Me.RclientePre.Name = "RclientePre"
        Me.RclientePre.ReadOnly = True
        '
        'Ncompleto
        '
        Me.Ncompleto.DataPropertyName = "fld_cliente"
        Me.Ncompleto.HeaderText = "Nombre Completo"
        Me.Ncompleto.Name = "Ncompleto"
        Me.Ncompleto.ReadOnly = True
        '
        'CedVieja
        '
        Me.CedVieja.HeaderText = "Cedula Vieja"
        Me.CedVieja.Name = "CedVieja"
        Me.CedVieja.ReadOnly = True
        '
        'CedNueva
        '
        Me.CedNueva.DataPropertyName = "fld_cedula"
        Me.CedNueva.HeaderText = "Cedula Nueva"
        Me.CedNueva.Name = "CedNueva"
        Me.CedNueva.ReadOnly = True
        '
        'NPasaporte
        '
        Me.NPasaporte.HeaderText = "Numero de Pasaporte"
        Me.NPasaporte.Name = "NPasaporte"
        Me.NPasaporte.ReadOnly = True
        '
        'Rsocial
        '
        Me.Rsocial.DataPropertyName = "fld_razon_social"
        Me.Rsocial.HeaderText = "Razon Social"
        Me.Rsocial.Name = "Rsocial"
        Me.Rsocial.ReadOnly = True
        '
        'Siglas
        '
        Me.Siglas.HeaderText = "Siglas"
        Me.Siglas.Name = "Siglas"
        Me.Siglas.ReadOnly = True
        '
        'Rnc
        '
        Me.Rnc.HeaderText = "RNC"
        Me.Rnc.Name = "Rnc"
        Me.Rnc.ReadOnly = True
        '
        'Residencia
        '
        Me.Residencia.DataPropertyName = "fld_direccion"
        Me.Residencia.HeaderText = "Residencia"
        Me.Residencia.Name = "Residencia"
        Me.Residencia.ReadOnly = True
        '
        'Celular
        '
        Me.Celular.DataPropertyName = "fld_celular"
        Me.Celular.HeaderText = "Celular"
        Me.Celular.Name = "Celular"
        Me.Celular.ReadOnly = True
        '
        'Oficina
        '
        Me.Oficina.HeaderText = "Oficina/Empresa"
        Me.Oficina.Name = "Oficina"
        Me.Oficina.ReadOnly = True
        '
        'Beeper
        '
        Me.Beeper.HeaderText = "Beeper"
        Me.Beeper.Name = "Beeper"
        Me.Beeper.ReadOnly = True
        '
        'Fax
        '
        Me.Fax.HeaderText = "Fax"
        Me.Fax.Name = "Fax"
        Me.Fax.ReadOnly = True
        '
        'Otro
        '
        Me.Otro.HeaderText = "Otro"
        Me.Otro.Name = "Otro"
        Me.Otro.ReadOnly = True
        '
        'Calle
        '
        Me.Calle.HeaderText = "Calle/Avenida"
        Me.Calle.Name = "Calle"
        Me.Calle.ReadOnly = True
        '
        'Esquina
        '
        Me.Esquina.HeaderText = "Esquina"
        Me.Esquina.Name = "Esquina"
        Me.Esquina.ReadOnly = True
        '
        'Nro
        '
        Me.Nro.HeaderText = "Numero"
        Me.Nro.Name = "Nro"
        Me.Nro.ReadOnly = True
        '
        'Eresidencia
        '
        Me.Eresidencia.HeaderText = "Edificio/Residencial"
        Me.Eresidencia.Name = "Eresidencia"
        Me.Eresidencia.ReadOnly = True
        '
        'Piso
        '
        Me.Piso.HeaderText = "Piso"
        Me.Piso.Name = "Piso"
        Me.Piso.ReadOnly = True
        '
        'Apto
        '
        Me.Apto.HeaderText = "Apartamento"
        Me.Apto.Name = "Apto"
        Me.Apto.ReadOnly = True
        '
        'Urba
        '
        Me.Urba.HeaderText = "Urbanizacion"
        Me.Urba.Name = "Urba"
        Me.Urba.ReadOnly = True
        '
        'Sector
        '
        Me.Sector.HeaderText = "Sector"
        Me.Sector.Name = "Sector"
        Me.Sector.ReadOnly = True
        '
        'Ciudad
        '
        Me.Ciudad.HeaderText = "Ciudad"
        Me.Ciudad.Name = "Ciudad"
        Me.Ciudad.ReadOnly = True
        '
        'Pmunicipio
        '
        Me.Pmunicipio.HeaderText = "Provincia/Municipio"
        Me.Pmunicipio.Name = "Pmunicipio"
        Me.Pmunicipio.ReadOnly = True
        '
        'Cave
        '
        Me.Cave.HeaderText = "Calle/Avenida"
        Me.Cave.Name = "Cave"
        Me.Cave.ReadOnly = True
        '
        'Esq1
        '
        Me.Esq1.HeaderText = "Esquina"
        Me.Esq1.Name = "Esq1"
        Me.Esq1.ReadOnly = True
        '
        'Nro1
        '
        Me.Nro1.HeaderText = "Numero"
        Me.Nro1.Name = "Nro1"
        Me.Nro1.ReadOnly = True
        '
        'Eresi
        '
        Me.Eresi.HeaderText = "Edificio/Residencial"
        Me.Eresi.Name = "Eresi"
        Me.Eresi.ReadOnly = True
        '
        'Piso1
        '
        Me.Piso1.HeaderText = "Piso"
        Me.Piso1.Name = "Piso1"
        Me.Piso1.ReadOnly = True
        '
        'Apto1
        '
        Me.Apto1.HeaderText = "Apartamento"
        Me.Apto1.Name = "Apto1"
        Me.Apto1.ReadOnly = True
        '
        'Urba1
        '
        Me.Urba1.HeaderText = "Urbanizacion"
        Me.Urba1.Name = "Urba1"
        Me.Urba1.ReadOnly = True
        '
        'Sector1
        '
        Me.Sector1.HeaderText = "Sector"
        Me.Sector1.Name = "Sector1"
        Me.Sector1.ReadOnly = True
        '
        'Ciudad1
        '
        Me.Ciudad1.HeaderText = "Ciudad"
        Me.Ciudad1.Name = "Ciudad1"
        Me.Ciudad1.ReadOnly = True
        '
        'Provincia
        '
        Me.Provincia.HeaderText = "Provincia/Municipio"
        Me.Provincia.Name = "Provincia"
        Me.Provincia.ReadOnly = True
        '
        'Nroprestamo
        '
        Me.Nroprestamo.DataPropertyName = "fld_cod_prestamo"
        Me.Nroprestamo.HeaderText = "Numero de Prestamo"
        Me.Nroprestamo.Name = "Nroprestamo"
        Me.Nroprestamo.ReadOnly = True
        '
        'UdMoneda
        '
        Me.UdMoneda.DataPropertyName = "fld_unidad_moneda"
        Me.UdMoneda.HeaderText = "Unidad Monetaria"
        Me.UdMoneda.Name = "UdMoneda"
        Me.UdMoneda.ReadOnly = True
        '
        'Tprestamo
        '
        Me.Tprestamo.DataPropertyName = "fld_clasificacion"
        Me.Tprestamo.HeaderText = "Tipo de Prestamo"
        Me.Tprestamo.Name = "Tprestamo"
        Me.Tprestamo.ReadOnly = True
        '
        'Fpago
        '
        Me.Fpago.DataPropertyName = "fld_forma_pago"
        Me.Fpago.HeaderText = "Forma de Pago"
        Me.Fpago.Name = "Fpago"
        Me.Fpago.ReadOnly = True
        '
        'Fapertura
        '
        Me.Fapertura.DataPropertyName = "fld_fecha"
        Me.Fapertura.HeaderText = "Fecha de Apertura"
        Me.Fapertura.Name = "Fapertura"
        Me.Fapertura.ReadOnly = True
        '
        'Fvencimiento
        '
        Me.Fvencimiento.DataPropertyName = "fld_fecha_vencimiento"
        Me.Fvencimiento.HeaderText = "Fecha de Vencimiento"
        Me.Fvencimiento.Name = "Fvencimiento"
        Me.Fvencimiento.ReadOnly = True
        '
        'Mprestamo
        '
        Me.Mprestamo.DataPropertyName = "fld_monto_prestamo"
        Me.Mprestamo.HeaderText = "Monto del Prestamo"
        Me.Mprestamo.Name = "Mprestamo"
        Me.Mprestamo.ReadOnly = True
        '
        'Mcuoata
        '
        Me.Mcuoata.DataPropertyName = "fld_monto_cuota"
        Me.Mcuoata.HeaderText = "Monto de la Cuota"
        Me.Mcuoata.Name = "Mcuoata"
        Me.Mcuoata.ReadOnly = True
        '
        'CantCuota
        '
        Me.CantCuota.DataPropertyName = "fld_cantidad_cuotas"
        Me.CantCuota.HeaderText = "Cantidad de Cuota"
        Me.CantCuota.Name = "CantCuota"
        Me.CantCuota.ReadOnly = True
        '
        'FultcortePrestamo
        '
        Me.FultcortePrestamo.DataPropertyName = "fld_fecha_ult_corte_prestamo"
        Me.FultcortePrestamo.HeaderText = "Fecha Ultimo Corte Prestamo"
        Me.FultcortePrestamo.Name = "FultcortePrestamo"
        Me.FultcortePrestamo.ReadOnly = True
        '
        'Fultpago
        '
        Me.Fultpago.DataPropertyName = "fld_fecha_ult_pago"
        Me.Fultpago.HeaderText = "Fecha Ultimo Pago/Actividad"
        Me.Fultpago.Name = "Fultpago"
        Me.Fultpago.ReadOnly = True
        '
        'MultPago
        '
        Me.MultPago.DataPropertyName = "fld_monto_ultimo_pago"
        Me.MultPago.HeaderText = "Monto Ultimo Pago"
        Me.MultPago.Name = "MultPago"
        Me.MultPago.ReadOnly = True
        '
        'Bce
        '
        Me.Bce.DataPropertyName = "fld_balance"
        Me.Bce.HeaderText = "Balance Actual"
        Me.Bce.Name = "Bce"
        Me.Bce.ReadOnly = True
        '
        'Matraso
        '
        Me.Matraso.DataPropertyName = "fld_atraso"
        Me.Matraso.HeaderText = "Monto en Atraso"
        Me.Matraso.Name = "Matraso"
        Me.Matraso.ReadOnly = True
        '
        'CantcuotaAtrasada
        '
        Me.CantcuotaAtrasada.DataPropertyName = "fld_cant_cuotas_atrasadas"
        Me.CantcuotaAtrasada.HeaderText = "Cantidad de Cuotas Atrasadas"
        Me.CantcuotaAtrasada.Name = "CantcuotaAtrasada"
        Me.CantcuotaAtrasada.ReadOnly = True
        '
        'EstatusCta
        '
        Me.EstatusCta.HeaderText = "Estatus de la Cuenta"
        Me.EstatusCta.Name = "EstatusCta"
        Me.EstatusCta.ReadOnly = True
        '
        'EstadoCta
        '
        Me.EstadoCta.HeaderText = "Estado de la Cuenta"
        Me.EstadoCta.Name = "EstadoCta"
        Me.EstadoCta.ReadOnly = True
        '
        'Saldo30
        '
        Me.Saldo30.DataPropertyName = "fld_saldo_vencido30"
        Me.Saldo30.HeaderText = "Saldo Vencido de 1-30 dias"
        Me.Saldo30.Name = "Saldo30"
        Me.Saldo30.ReadOnly = True
        '
        'saldo60
        '
        Me.saldo60.DataPropertyName = "fld_saldo_vencido60"
        Me.saldo60.HeaderText = "Column1Saldo Vencido de 31-60 dias"
        Me.saldo60.Name = "saldo60"
        Me.saldo60.ReadOnly = True
        '
        'saldo90
        '
        Me.saldo90.DataPropertyName = "fld_saldo_vencido60"
        Me.saldo90.HeaderText = "Saldo Vencido de 61-90 dias"
        Me.saldo90.Name = "saldo90"
        Me.saldo90.ReadOnly = True
        '
        'saldo120
        '
        Me.saldo120.DataPropertyName = "fld_saldo_vencido120"
        Me.saldo120.HeaderText = "Saldo Vencido de 91-120 dias"
        Me.saldo120.Name = "saldo120"
        Me.saldo120.ReadOnly = True
        '
        'saldo150
        '
        Me.saldo150.DataPropertyName = "fld_saldo_vencido150"
        Me.saldo150.HeaderText = "Saldo Vencido de 121-150 dias"
        Me.saldo150.Name = "saldo150"
        Me.saldo150.ReadOnly = True
        '
        'Saldo180
        '
        Me.Saldo180.DataPropertyName = "fld_saldo_vencido180"
        Me.Saldo180.HeaderText = "Saldo Vencido de 151-180 dias"
        Me.Saldo180.Name = "Saldo180"
        Me.Saldo180.ReadOnly = True
        '
        'Saldo181
        '
        Me.Saldo181.DataPropertyName = "fld_saldo_vencido181"
        Me.Saldo181.HeaderText = "Saldo Vencido 181 dias o mas"
        Me.Saldo181.Name = "Saldo181"
        Me.Saldo181.ReadOnly = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Location = New System.Drawing.Point(3, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(337, 41)
        Me.Panel4.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(96, 21)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(155, 13)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "PC: Prestamos Castigados"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(7, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(98, 13)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "CL: Cobro Legal"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(169, 5)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(164, 13)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "NA: Notificación de Aguacil"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(65, 5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(116, 13)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "CC: Carta de Cobro"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(5, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "N: Normal"
        '
        'SaldoPorAntiguedadPrestamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 526)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SaldoPorAntiguedadPrestamos"
        Me.Text = "Saldo Por Antiguedad Prestamos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DgvDatacredito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents imprimirBtn As Button
    Friend WithEvents DgvDatacredito As DataGridView
    Friend WithEvents Tentidad As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents RclientePre As DataGridViewTextBoxColumn
    Friend WithEvents Ncompleto As DataGridViewTextBoxColumn
    Friend WithEvents CedVieja As DataGridViewTextBoxColumn
    Friend WithEvents CedNueva As DataGridViewTextBoxColumn
    Friend WithEvents NPasaporte As DataGridViewTextBoxColumn
    Friend WithEvents Rsocial As DataGridViewTextBoxColumn
    Friend WithEvents Siglas As DataGridViewTextBoxColumn
    Friend WithEvents Rnc As DataGridViewTextBoxColumn
    Friend WithEvents Residencia As DataGridViewTextBoxColumn
    Friend WithEvents Celular As DataGridViewTextBoxColumn
    Friend WithEvents Oficina As DataGridViewTextBoxColumn
    Friend WithEvents Beeper As DataGridViewTextBoxColumn
    Friend WithEvents Fax As DataGridViewTextBoxColumn
    Friend WithEvents Otro As DataGridViewTextBoxColumn
    Friend WithEvents Calle As DataGridViewTextBoxColumn
    Friend WithEvents Esquina As DataGridViewTextBoxColumn
    Friend WithEvents Nro As DataGridViewTextBoxColumn
    Friend WithEvents Eresidencia As DataGridViewTextBoxColumn
    Friend WithEvents Piso As DataGridViewTextBoxColumn
    Friend WithEvents Apto As DataGridViewTextBoxColumn
    Friend WithEvents Urba As DataGridViewTextBoxColumn
    Friend WithEvents Sector As DataGridViewTextBoxColumn
    Friend WithEvents Ciudad As DataGridViewTextBoxColumn
    Friend WithEvents Pmunicipio As DataGridViewTextBoxColumn
    Friend WithEvents Cave As DataGridViewTextBoxColumn
    Friend WithEvents Esq1 As DataGridViewTextBoxColumn
    Friend WithEvents Nro1 As DataGridViewTextBoxColumn
    Friend WithEvents Eresi As DataGridViewTextBoxColumn
    Friend WithEvents Piso1 As DataGridViewTextBoxColumn
    Friend WithEvents Apto1 As DataGridViewTextBoxColumn
    Friend WithEvents Urba1 As DataGridViewTextBoxColumn
    Friend WithEvents Sector1 As DataGridViewTextBoxColumn
    Friend WithEvents Ciudad1 As DataGridViewTextBoxColumn
    Friend WithEvents Provincia As DataGridViewTextBoxColumn
    Friend WithEvents Nroprestamo As DataGridViewTextBoxColumn
    Friend WithEvents UdMoneda As DataGridViewTextBoxColumn
    Friend WithEvents Tprestamo As DataGridViewTextBoxColumn
    Friend WithEvents Fpago As DataGridViewTextBoxColumn
    Friend WithEvents Fapertura As DataGridViewTextBoxColumn
    Friend WithEvents Fvencimiento As DataGridViewTextBoxColumn
    Friend WithEvents Mprestamo As DataGridViewTextBoxColumn
    Friend WithEvents Mcuoata As DataGridViewTextBoxColumn
    Friend WithEvents CantCuota As DataGridViewTextBoxColumn
    Friend WithEvents FultcortePrestamo As DataGridViewTextBoxColumn
    Friend WithEvents Fultpago As DataGridViewTextBoxColumn
    Friend WithEvents MultPago As DataGridViewTextBoxColumn
    Friend WithEvents Bce As DataGridViewTextBoxColumn
    Friend WithEvents Matraso As DataGridViewTextBoxColumn
    Friend WithEvents CantcuotaAtrasada As DataGridViewTextBoxColumn
    Friend WithEvents EstatusCta As DataGridViewTextBoxColumn
    Friend WithEvents EstadoCta As DataGridViewTextBoxColumn
    Friend WithEvents Saldo30 As DataGridViewTextBoxColumn
    Friend WithEvents saldo60 As DataGridViewTextBoxColumn
    Friend WithEvents saldo90 As DataGridViewTextBoxColumn
    Friend WithEvents saldo120 As DataGridViewTextBoxColumn
    Friend WithEvents saldo150 As DataGridViewTextBoxColumn
    Friend WithEvents Saldo180 As DataGridViewTextBoxColumn
    Friend WithEvents Saldo181 As DataGridViewTextBoxColumn
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
End Class
