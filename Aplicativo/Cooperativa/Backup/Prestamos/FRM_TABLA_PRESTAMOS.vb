Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.IO
Public Class FRM_TABLA_PRESTAMOS
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents fld_cantidad_cuotas As System.Windows.Forms.TextBox
    Friend WithEvents fld_monto_prestamo As System.Windows.Forms.TextBox
    Friend WithEvents fld_fecha_entrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents fld_cod_prestamo As System.Windows.Forms.TextBox
    Friend WithEvents fld_porciento As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents fld_tipo_prestamo As System.Windows.Forms.ComboBox
    Friend WithEvents fld_clasificacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnImprime As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents fldTazaMora As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtMontoCuota As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents DG As System.Windows.Forms.DataGrid
    Friend WithEvents txtBalancePrestamo As System.Windows.Forms.TextBox
    Friend WithEvents btnCambiar As System.Windows.Forms.Button
    Friend WithEvents lblTasaInteres As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SocioRncTxt As System.Windows.Forms.TextBox
    Friend WithEvents SocioTxt As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_TABLA_PRESTAMOS))
        Me.fldTazaMora = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.SocioRncTxt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SocioTxt = New System.Windows.Forms.TextBox
        Me.DG = New System.Windows.Forms.DataGrid
        Me.lblTasaInteres = New System.Windows.Forms.Label
        Me.fld_tipo_prestamo = New System.Windows.Forms.ComboBox
        Me.fld_porciento = New System.Windows.Forms.TextBox
        Me.fld_monto_prestamo = New System.Windows.Forms.TextBox
        Me.fld_clasificacion = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.fld_fecha_entrega = New System.Windows.Forms.DateTimePicker
        Me.fld_cod_prestamo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.fld_cantidad_cuotas = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtMontoCuota = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnProcesar = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.btnImprime = New System.Windows.Forms.Button
        Me.txtBalancePrestamo = New System.Windows.Forms.TextBox
        Me.btnCambiar = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.GroupBox3.SuspendLayout()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fldTazaMora
        '
        Me.fldTazaMora.BackColor = System.Drawing.Color.White
        Me.fldTazaMora.Location = New System.Drawing.Point(136, 120)
        Me.fldTazaMora.Name = "fldTazaMora"
        Me.fldTazaMora.Size = New System.Drawing.Size(88, 20)
        Me.fldTazaMora.TabIndex = 9
        Me.fldTazaMora.Text = "0"
        Me.fldTazaMora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.Location = New System.Drawing.Point(24, 122)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 16)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "% Mora Mensual"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.SocioRncTxt)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.SocioTxt)
        Me.GroupBox3.Controls.Add(Me.DG)
        Me.GroupBox3.Controls.Add(Me.lblTasaInteres)
        Me.GroupBox3.Controls.Add(Me.fld_tipo_prestamo)
        Me.GroupBox3.Controls.Add(Me.fld_porciento)
        Me.GroupBox3.Controls.Add(Me.fld_monto_prestamo)
        Me.GroupBox3.Controls.Add(Me.fld_clasificacion)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.fld_fecha_entrega)
        Me.GroupBox3.Controls.Add(Me.fld_cod_prestamo)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.fld_cantidad_cuotas)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtMontoCuota)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.btnCerrar)
        Me.GroupBox3.Controls.Add(Me.btnProcesar)
        Me.GroupBox3.Controls.Add(Me.btnNuevo)
        Me.GroupBox3.Controls.Add(Me.btnImprime)
        Me.GroupBox3.Controls.Add(Me.txtBalancePrestamo)
        Me.GroupBox3.Controls.Add(Me.btnCambiar)
        Me.GroupBox3.Controls.Add(Me.fldTazaMora)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(837, 456)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Finaciamiento y/o Préstamo"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(24, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "RNC"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SocioRncTxt
        '
        Me.SocioRncTxt.Location = New System.Drawing.Point(136, 168)
        Me.SocioRncTxt.Name = "SocioRncTxt"
        Me.SocioRncTxt.Size = New System.Drawing.Size(176, 20)
        Me.SocioRncTxt.TabIndex = 14
        Me.SocioRncTxt.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(24, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Cliente"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SocioTxt
        '
        Me.SocioTxt.Location = New System.Drawing.Point(136, 144)
        Me.SocioTxt.Name = "SocioTxt"
        Me.SocioTxt.Size = New System.Drawing.Size(312, 20)
        Me.SocioTxt.TabIndex = 12
        Me.SocioTxt.Text = ""
        '
        'DG
        '
        Me.DG.BackgroundColor = System.Drawing.Color.White
        Me.DG.CaptionVisible = False
        Me.DG.DataMember = ""
        Me.DG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DG.Location = New System.Drawing.Point(8, 200)
        Me.DG.Name = "DG"
        Me.DG.Size = New System.Drawing.Size(680, 248)
        Me.DG.TabIndex = 28
        '
        'lblTasaInteres
        '
        Me.lblTasaInteres.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTasaInteres.Location = New System.Drawing.Point(368, 19)
        Me.lblTasaInteres.Name = "lblTasaInteres"
        Me.lblTasaInteres.Size = New System.Drawing.Size(312, 24)
        Me.lblTasaInteres.TabIndex = 15
        Me.lblTasaInteres.Text = "Tasa de Interes"
        Me.lblTasaInteres.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_tipo_prestamo
        '
        Me.fld_tipo_prestamo.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.fld_tipo_prestamo.ForeColor = System.Drawing.Color.White
        Me.fld_tipo_prestamo.Items.AddRange(New Object() {"DIARIO", "SEMANAL", "QUINCENAL", "MENSUAL", "BIMESTRAL", "TRIMESTRAL", "SEMESTRAL", "ANUAL"})
        Me.fld_tipo_prestamo.Location = New System.Drawing.Point(136, 72)
        Me.fld_tipo_prestamo.Name = "fld_tipo_prestamo"
        Me.fld_tipo_prestamo.Size = New System.Drawing.Size(176, 21)
        Me.fld_tipo_prestamo.TabIndex = 5
        Me.fld_tipo_prestamo.Text = "MENSUAL"
        '
        'fld_porciento
        '
        Me.fld_porciento.BackColor = System.Drawing.Color.White
        Me.fld_porciento.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_porciento.Location = New System.Drawing.Point(688, 16)
        Me.fld_porciento.Name = "fld_porciento"
        Me.fld_porciento.Size = New System.Drawing.Size(144, 30)
        Me.fld_porciento.TabIndex = 16
        Me.fld_porciento.Text = "5"
        Me.fld_porciento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fld_monto_prestamo
        '
        Me.fld_monto_prestamo.BackColor = System.Drawing.Color.White
        Me.fld_monto_prestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_monto_prestamo.Location = New System.Drawing.Point(688, 48)
        Me.fld_monto_prestamo.Name = "fld_monto_prestamo"
        Me.fld_monto_prestamo.Size = New System.Drawing.Size(144, 30)
        Me.fld_monto_prestamo.TabIndex = 18
        Me.fld_monto_prestamo.Text = "0.00"
        Me.fld_monto_prestamo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fld_clasificacion
        '
        Me.fld_clasificacion.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.fld_clasificacion.ForeColor = System.Drawing.Color.White
        Me.fld_clasificacion.Items.AddRange(New Object() {"Int. y Capital Amorizable", "Int. y Capital Fijos", "Int. Adelantado", "Int. Diario Sobre Saldo Insoluto", "Int. Diario Sobre Capital Inicial"})
        Me.fld_clasificacion.Location = New System.Drawing.Point(136, 48)
        Me.fld_clasificacion.Name = "fld_clasificacion"
        Me.fld_clasificacion.Size = New System.Drawing.Size(176, 21)
        Me.fld_clasificacion.TabIndex = 3
        Me.fld_clasificacion.Text = "Int. y Capital Amorizable"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(8, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Condición de pago"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(8, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 16)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Composición de Cuota"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(368, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(312, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Monto Préstamo RD$"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_fecha_entrega
        '
        Me.fld_fecha_entrega.CustomFormat = "dd / MMM /yyyy"
        Me.fld_fecha_entrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fld_fecha_entrega.Location = New System.Drawing.Point(136, 96)
        Me.fld_fecha_entrega.Name = "fld_fecha_entrega"
        Me.fld_fecha_entrega.Size = New System.Drawing.Size(176, 20)
        Me.fld_fecha_entrega.TabIndex = 7
        '
        'fld_cod_prestamo
        '
        Me.fld_cod_prestamo.BackColor = System.Drawing.Color.White
        Me.fld_cod_prestamo.Location = New System.Drawing.Point(136, 24)
        Me.fld_cod_prestamo.Name = "fld_cod_prestamo"
        Me.fld_cod_prestamo.Size = New System.Drawing.Size(96, 20)
        Me.fld_cod_prestamo.TabIndex = 1
        Me.fld_cod_prestamo.Text = "0"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(48, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_cantidad_cuotas
        '
        Me.fld_cantidad_cuotas.BackColor = System.Drawing.Color.White
        Me.fld_cantidad_cuotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_cantidad_cuotas.Location = New System.Drawing.Point(688, 80)
        Me.fld_cantidad_cuotas.Name = "fld_cantidad_cuotas"
        Me.fld_cantidad_cuotas.Size = New System.Drawing.Size(144, 30)
        Me.fld_cantidad_cuotas.TabIndex = 20
        Me.fld_cantidad_cuotas.Text = "0"
        Me.fld_cantidad_cuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(16, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Fecha de Inicio"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(368, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(312, 24)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Cantidad Cuotas"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMontoCuota
        '
        Me.txtMontoCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoCuota.Location = New System.Drawing.Point(688, 112)
        Me.txtMontoCuota.Name = "txtMontoCuota"
        Me.txtMontoCuota.ReadOnly = True
        Me.txtMontoCuota.Size = New System.Drawing.Size(144, 30)
        Me.txtMontoCuota.TabIndex = 22
        Me.txtMontoCuota.Text = "0.00"
        Me.txtMontoCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(496, 115)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(184, 24)
        Me.Label27.TabIndex = 21
        Me.Label27.Text = "Monto Cuota RD$"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrar.Location = New System.Drawing.Point(688, 312)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(144, 56)
        Me.btnCerrar.TabIndex = 25
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnProcesar
        '
        Me.btnProcesar.BackColor = System.Drawing.SystemColors.Control
        Me.btnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnProcesar.ForeColor = System.Drawing.Color.Black
        Me.btnProcesar.Image = CType(resources.GetObject("btnProcesar.Image"), System.Drawing.Image)
        Me.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProcesar.Location = New System.Drawing.Point(688, 200)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(144, 56)
        Me.btnProcesar.TabIndex = 23
        Me.btnProcesar.Text = "&Guardar"
        Me.btnProcesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(688, 144)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(144, 56)
        Me.btnNuevo.TabIndex = 26
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnImprime
        '
        Me.btnImprime.BackColor = System.Drawing.SystemColors.Control
        Me.btnImprime.Enabled = False
        Me.btnImprime.ForeColor = System.Drawing.Color.Black
        Me.btnImprime.Image = CType(resources.GetObject("btnImprime.Image"), System.Drawing.Image)
        Me.btnImprime.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnImprime.Location = New System.Drawing.Point(688, 256)
        Me.btnImprime.Name = "btnImprime"
        Me.btnImprime.Size = New System.Drawing.Size(144, 56)
        Me.btnImprime.TabIndex = 24
        Me.btnImprime.Text = "&Imprimir"
        Me.btnImprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtBalancePrestamo
        '
        Me.txtBalancePrestamo.Location = New System.Drawing.Point(472, 128)
        Me.txtBalancePrestamo.Name = "txtBalancePrestamo"
        Me.txtBalancePrestamo.Size = New System.Drawing.Size(40, 20)
        Me.txtBalancePrestamo.TabIndex = 27
        Me.txtBalancePrestamo.Text = "0.00"
        Me.txtBalancePrestamo.Visible = False
        '
        'btnCambiar
        '
        Me.btnCambiar.Enabled = False
        Me.btnCambiar.Location = New System.Drawing.Point(232, 119)
        Me.btnCambiar.Name = "btnCambiar"
        Me.btnCambiar.TabIndex = 10
        Me.btnCambiar.Text = "&Modificar"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'FRM_TABLA_PRESTAMOS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(842, 467)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_TABLA_PRESTAMOS"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de préstamos"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Tipos de Cuotas"

    'Int. y Capital Amorizable
    'Int. y Capital Fijos
    'Int. Adelantado
    'Int. Diario Sobre Saldo Insoluto
    'Int. Diario Sobre Capital Inicial

    Sub InteresCapitalAmortizables()

        Dim montoPrestamo, Interes As Double, numerosPagos As Double, pagoMensual As Double, CuotaNo, P As Double, I As Double

        Dim tipoPago As DueDate

        montoPrestamo = CDbl(fld_monto_prestamo.Text)

        Interes = CDbl(fld_porciento.Text)
        If Interes > 0 Then Interes = Interes / 100

        If fld_tipo_prestamo.Text = "DIARIO" Then
            Interes = (Interes / 12) / 30
        ElseIf fld_tipo_prestamo.Text = "SEMANAL" Then
            Interes = (Interes / 12) / 7
        ElseIf fld_tipo_prestamo.Text = "QUINCENAL" Then
            Interes = (Interes / 12) / 15
        ElseIf fld_tipo_prestamo.Text = "MENSUAL AMORTIZABLE" Then
            Interes = (Interes / 12)
        ElseIf fld_tipo_prestamo.Text = "BIMESTRAL" Then
            Interes = (Interes / 12) * 2
        ElseIf fld_tipo_prestamo.Text = "TRIMESTRAL" Then
            Interes = (Interes / 12) * 3
        ElseIf fld_tipo_prestamo.Text = "SEMESTRAL" Then
            Interes = (Interes / 12) * 6
        ElseIf fld_tipo_prestamo.Text = "ANUAL" Then
            Interes = Interes
        End If

        numerosPagos = CDbl(fld_cantidad_cuotas.Text)

        tipoPago = DueDate.EndOfPeriod

        pagoMensual = Math.Abs(-Pmt(Interes, numerosPagos, montoPrestamo, 0, tipoPago))

        Dim fechas As Date

        For CuotaNo = 1 To numerosPagos

            P = PPmt(Interes / 12, CuotaNo, numerosPagos, -montoPrestamo, 0, tipoPago)
            ' Round principal.
            P = (Int((P + 0.005) * 100) / 100)
            I = pagoMensual - P
            ' Round interest.
            I = (Int((I + 0.005) * 100) / 100)

            If fld_tipo_prestamo.Text = "DIARIO" Then
                fechas = fld_fecha_entrega.Value.AddDays(CuotaNo)
            ElseIf fld_tipo_prestamo.Text = "SEMANAL" Then
                fechas = fld_fecha_entrega.Value.AddDays(CuotaNo * 7)
            ElseIf fld_tipo_prestamo.Text = "QUINCENAL" Then
                fechas = fld_fecha_entrega.Value.AddDays(CuotaNo * 15)
            ElseIf fld_tipo_prestamo.Text = "MENSUAL" Then
                fechas = fld_fecha_entrega.Value.AddMonths(CuotaNo)
            ElseIf fld_tipo_prestamo.Text = "BIMESTRAL" Then
                fechas = fld_fecha_entrega.Value.AddMonths(CuotaNo * 2)
            ElseIf fld_tipo_prestamo.Text = "TRIMESTRAL" Then
                fechas = fld_fecha_entrega.Value.AddMonths(CuotaNo * 3)
            ElseIf fld_tipo_prestamo.Text = "SEMESTRAL" Then
                fechas = fld_fecha_entrega.Value.AddMonths(CuotaNo * 6)
            ElseIf fld_tipo_prestamo.Text = "ANUAL" Then
                fechas = fld_fecha_entrega.Value.AddYears(CuotaNo)
            End If

            CREA_CUOTAS(formatDate(fechas), Format(CuotaNo, "000"), P, I, 0, 0)

        Next CuotaNo

    End Sub

    Sub InteresCapitalFijosInteresAplicDiario(ByVal interes As Double, ByVal capital As Double)

        Dim cuotaNo, numerosPagos, bce_capital As Double
        Dim fechas As Date

        numerosPagos = CDbl(fld_cantidad_cuotas.Text)
        bce_capital = CDbl(fld_monto_prestamo.Text)

        If fld_clasificacion.Text = "Int. Adelantado" Then
            numerosPagos = numerosPagos - 1
        End If

        For cuotaNo = 1 To numerosPagos


            If fld_tipo_prestamo.Text = "DIARIO" Then
                fechas = fld_fecha_entrega.Value.AddDays(cuotaNo)
            ElseIf fld_tipo_prestamo.Text = "SEMANAL" Then
                fechas = fld_fecha_entrega.Value.AddDays(cuotaNo * 7)
            ElseIf fld_tipo_prestamo.Text = "QUINCENAL" Then
                fechas = fld_fecha_entrega.Value.AddDays(cuotaNo * 15)
            ElseIf fld_tipo_prestamo.Text = "MENSUAL" Then
                fechas = fld_fecha_entrega.Value.AddMonths(cuotaNo)
            ElseIf fld_tipo_prestamo.Text = "BIMESTRAL" Then
                fechas = fld_fecha_entrega.Value.AddMonths(cuotaNo * 2)
            ElseIf fld_tipo_prestamo.Text = "TRIMESTRAL" Then
                fechas = fld_fecha_entrega.Value.AddMonths(cuotaNo * 3)
            ElseIf fld_tipo_prestamo.Text = "SEMESTRAL" Then
                fechas = fld_fecha_entrega.Value.AddMonths(cuotaNo * 6)
            ElseIf fld_tipo_prestamo.Text = "ANUAL" Then
                fechas = fld_fecha_entrega.Value.AddYears(cuotaNo)
            End If

            If fld_clasificacion.Text = "Int. y Capital Fijos" Then
                CREA_CUOTAS(formatDate(fechas), Format(cuotaNo, "000"), capital, interes, 0, 0)
            Else
                CREA_CUOTAS(formatDate(fechas), Format(cuotaNo, "000"), capital, 0, 0, 0)
            End If

        Next cuotaNo



    End Sub

    Sub InteresAdelantado(ByVal interes As Double)

        Dim cuotaNo, numerosPagos, capital As Double
        Dim fechas As Date

        numerosPagos = CDbl(fld_cantidad_cuotas.Text)
        capital = CDbl(fld_monto_prestamo.Text)



        For cuotaNo = 1 To numerosPagos - 1


            If fld_tipo_prestamo.Text = "DIARIO" Then
                fechas = fld_fecha_entrega.Value.AddDays(cuotaNo)
            ElseIf fld_tipo_prestamo.Text = "SEMANAL" Then
                fechas = fld_fecha_entrega.Value.AddDays(cuotaNo * 7)
            ElseIf fld_tipo_prestamo.Text = "QUINCENAL" Then
                fechas = fld_fecha_entrega.Value.AddDays(cuotaNo * 15)
            ElseIf fld_tipo_prestamo.Text = "MENSUAL" Then
                fechas = fld_fecha_entrega.Value.AddMonths(cuotaNo)
            ElseIf fld_tipo_prestamo.Text = "BIMESTRAL" Then
                fechas = fld_fecha_entrega.Value.AddMonths(cuotaNo * 2)
            ElseIf fld_tipo_prestamo.Text = "TRIMESTRAL" Then
                fechas = fld_fecha_entrega.Value.AddMonths(cuotaNo * 3)
            ElseIf fld_tipo_prestamo.Text = "SEMESTRAL" Then
                fechas = fld_fecha_entrega.Value.AddMonths(cuotaNo * 6)
            ElseIf fld_tipo_prestamo.Text = "ANUAL" Then
                fechas = fld_fecha_entrega.Value.AddYears(cuotaNo)
            End If

            CREA_CUOTAS(formatDate(fechas), Format(cuotaNo, "000"), 0, interes, 0, 0)
        Next cuotaNo


        If fld_tipo_prestamo.Text = "DIARIO" Then
            fechas = fld_fecha_entrega.Value.AddDays(cuotaNo + 1)
        ElseIf fld_tipo_prestamo.Text = "SEMANAL" Then
            fechas = fld_fecha_entrega.Value.AddDays(cuotaNo + 7)
        ElseIf fld_tipo_prestamo.Text = "QUINCENAL" Then
            fechas = fld_fecha_entrega.Value.AddDays(cuotaNo + 15)
        ElseIf fld_tipo_prestamo.Text = "MENSUAL" Then
            fechas = fld_fecha_entrega.Value.AddMonths(cuotaNo)
        ElseIf fld_tipo_prestamo.Text = "BIMESTRAL" Then
            fechas = fld_fecha_entrega.Value.AddMonths(cuotaNo + 2)
        ElseIf fld_tipo_prestamo.Text = "TRIMESTRAL" Then
            fechas = fld_fecha_entrega.Value.AddMonths(cuotaNo + 3)
        ElseIf fld_tipo_prestamo.Text = "SEMESTRAL" Then
            fechas = fld_fecha_entrega.Value.AddMonths(cuotaNo + 6)
        ElseIf fld_tipo_prestamo.Text = "ANUAL" Then
            fechas = fld_fecha_entrega.Value.AddYears(cuotaNo + 1)
        End If

        CREA_CUOTAS(formatDate(fechas), Format(cuotaNo, "000"), capital, interes, 0, 0)


    End Sub


    Sub TestRate()
        Dim PVal, Payment, TotPmts, APR As Double
        Dim PayType As DueDate

        ' Define percentage format. 
        Dim Fmt As String = "##0.00"
        Dim Response As MsgBoxResult
        ' Usually 0 for a loan. 
        Dim FVal As Double = 0
        ' Guess of 10 percent. 
        Dim Guess As Double = 0.1
        PVal = CDbl(InputBox("Cantidad a préstar"))
        Payment = CDbl(InputBox("What's your monthly payment?"))
        TotPmts = CDbl(InputBox("How many monthly payments do you have to make?"))
        Response = MsgBox("Do you make payments at the end of the month?", MsgBoxStyle.YesNo)
        If Response = MsgBoxResult.No Then
            PayType = DueDate.BegOfPeriod
        Else
            PayType = DueDate.EndOfPeriod
        End If
        APR = (Rate(TotPmts, -Payment, PVal, FVal, PayType, Guess) * 12) * 100

        MsgBox("Your interest rate is " & Format(CInt(APR), Fmt) & " percent.")
    End Sub
    Sub TestIPMT()
        Dim APR, PVal, Period, IntPmt, TotInt, TotPmts As Double
        Dim PayType As DueDate
        Dim Response As MsgBoxResult

        ' Usually 0 for a loan. 
        Dim Fval As Double = 0
        ' Define money format. 
        Dim Fmt As String = "###,###,##0.00"
        PVal = CDbl(InputBox("Cantidad a préstar?"))
        APR = CDbl(InputBox("Cuál es el interes anual?"))
        If APR > 1 Then APR = APR / 100 ' Ensure proper form.
        TotPmts = CInt(InputBox("Cuánto pagos mensuales?"))
        Response = MsgBox("Los pagos se harán al final de cada mes?", MsgBoxStyle.YesNo)
        If Response = MsgBoxResult.No Then
            PayType = DueDate.BegOfPeriod
        Else
            PayType = DueDate.EndOfPeriod
        End If
        For Period = 1 To TotPmts   ' Total all interest.
            IntPmt = IPmt(APR / 12, Period, TotPmts, -PVal, Fval, PayType)
            TotInt = TotInt + IntPmt
        Next Period

        ' Display results.
        MsgBox("You will pay a total of " & Format(TotInt, Fmt) & " in interest for this loan.")
    End Sub
    Sub TestPMT()
        Dim PVal, APR, Payment, TotPmts As Double
        Dim PayType As DueDate
        Dim Response As MsgBoxResult

        ' Define money format. 
        Dim Fmt As String = "###,###,##0.00"
        ' Usually 0 for a loan. 
        Dim FVal As Double = 0
        PVal = CDbl(InputBox("How much do you want to borrow?"))
        APR = CDbl(InputBox("What is the annual percentage rate of your loan?"))
        If APR > 1 Then APR = APR / 100 ' Ensure proper form.
        TotPmts = CDbl(InputBox("How many monthly payments will you make?"))
        Response = MsgBox("Do you make payments at the end of month?", MsgBoxStyle.YesNo)
        If Response = MsgBoxResult.No Then
            PayType = DueDate.BegOfPeriod
        Else
            PayType = DueDate.EndOfPeriod
        End If
        Payment = Pmt(APR / 12, TotPmts, -PVal, FVal, PayType)

        MsgBox("Your payment will be " & Format(Payment, Fmt) & " per month.")
    End Sub


#End Region



#Region "Cuotas"

    Dim dsCuotas As DataSet

    Private Sub CargarCuotas(ByVal IdPrest As Integer)

        StyleFact()
        dsCuotas = New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_tabla_cuotas WHERE fld_id_del_prestamo=" & IdPrest & " ORDER BY fld_no_cuotas", conn)
        da.Fill(dsCuotas, "tbl_tabla_cuotas")


        DG.DataSource = dsCuotas.Tables(0)
        Dim dr As DataRow
        For Each dr In dsCuotas.Tables(0).Rows
            txtBalancePrestamo.Text = CDbl(txtBalancePrestamo.Text) + (dr("fld_capital_cuota_balance") + dr("fld_interes_cuota_balance"))
        Next
        Dim DataTable As DataTable '/PARA QUE NO HAGA LA ULTIMA LINEA EN BLANCO
        DataTable = dsCuotas.Tables(0)
        DataTable.DefaultView.AllowNew = False

    End Sub

    Private Sub StyleFact()
        DG.TableStyles.Clear()

        ' Create a new DataGridTableStyle and set 
        ' its MappingName to the TableName of a DataTable. 

        Dim ts1 As New DataGridTableStyle
        ts1.GridLineColor = Color.Peru
        ts1.MappingName = "tbl_tabla_cuotas"




        Dim TextCol0 As New DataGridTextBoxColumn
        TextCol0.MappingName = "fld_no_cuotas"
        TextCol0.HeaderText = "DOC.NO."
        TextCol0.Width = 80
        TextCol0.ReadOnly = True
        TextCol0.NullText = ""
        ts1.GridColumnStyles.Add(TextCol0)


        ' Add a second column style. 
        Dim TextCol1 As New DataGridTextBoxColumn
        TextCol1.MappingName = "fld_fecha_termina_cuotas"
        TextCol1.HeaderText = "VENCE"
        TextCol1.Width = 125
        TextCol1.ReadOnly = True
        TextCol1.NullText = ""
        TextCol1.Format = "dd-MMM-yyyy"
        ts1.GridColumnStyles.Add(TextCol1)


        ' Add a second column style. 
        Dim TextCol4 As New DataGridTextBoxColumn
        TextCol4.MappingName = "fld_interes_cuota_balance"
        TextCol4.HeaderText = "B. INTERES"
        TextCol4.Width = 125
        TextCol4.Format = "C2"
        TextCol4.Alignment = HorizontalAlignment.Right
        TextCol4.ReadOnly = True
        TextCol4.NullText = ""
        ts1.GridColumnStyles.Add(TextCol4)

        'Add a second column style. 
        Dim TextCol7 As New DataGridTextBoxColumn
        TextCol7.MappingName = "fld_capital_cuota_balance"
        TextCol7.HeaderText = "B. CAPITAL"
        TextCol7.Width = 125
        TextCol7.Format = "C2"
        TextCol7.Alignment = HorizontalAlignment.Right
        TextCol7.ReadOnly = True
        TextCol7.NullText = ""
        ts1.GridColumnStyles.Add(TextCol7)

        'Add a second column style. 
        Dim TextCol8 As New DataGridTextBoxColumn
        TextCol8.MappingName = "fld_balance_cuotas"
        TextCol8.HeaderText = "B. CUOTA"
        TextCol8.Width = 125
        TextCol8.Format = "C2"
        TextCol8.Alignment = HorizontalAlignment.Right
        TextCol8.ReadOnly = True
        TextCol8.NullText = ""
        ts1.GridColumnStyles.Add(TextCol8)

        'Dim checkbox = New DataGridBoolColumn
        'checkbox.MappingName = "fld_chk"
        'checkbox.HeaderText = "S"
        'checkbox.Width = 20
        'checkbox.FalseValue = ""
        'checkbox.TrueValue = True
        'checkbox.AllowNull = False
        'checkbox.NullValue = ""
        'AddHandler checkbox.Boolean.KeyPress, New KeyPressEventHandler(AddressOf DateKeyPress)
        'ts1.GridColumnStyles.Add(checkbox)

        ts1.RowHeadersVisible = False

        ' Add the DataGridTableStyle objects to the collection. 
        DG.GridLineColor.GetHashCode()
        DG.TableStyles.Add(ts1)



    End Sub

    Private Sub GuardarCambioCuotas(ByVal id_doc As String, ByVal abono_interes As Double, ByVal abono_capital As Double, ByVal abono_cuota As Double)

        NON_QUERY("UPDATE tbl_tabla_cuotas SET fld_interes_cuota_abono=fld_interes_cuota_abono + " & abono_interes & ",  fld_interes_cuota_balance=fld_interes_cuota-fld_interes_cuota_abono,  fld_capital_cuota_abono=fld_capital_cuota_abono+" & abono_capital & ",fld_capital_cuota_balance=fld_capital_cuota-fld_capital_cuota_abono, fld_abono_cuotas=fld_abono_cuotas + " & abono_capital + abono_interes & ", fld_balance_cuotas=fld_monto_cuotas-fld_abono_cuotas WHERE  fld_id_cuotas=" & id_doc & "")

    End Sub

#End Region

    Private Sub CREAR()
        If fldTazaMora.Text = String.Empty Then fldTazaMora.Text = 0

        If CDbl(fldTazaMora.Text) <= 0 Then
            Alerta("La taza de mora mensual es igual a CERO")
        End If

        CALCULO_CUOTA_INICIAL()
        GENERANDO_PRESTAMO()
    End Sub

    Private Sub FRM_TABLA_PRESTAMOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        fld_porciento.Text = SCALAR_NUM("SELECT TasaInteres FROM parametrosgenerales WHERE ID=1")

    End Sub


    Private Sub CLEAR_ALL_DATA()

        txtMontoCuota.Text = "0.00"

        fld_monto_prestamo.Text = "0.00"
        fld_cantidad_cuotas.Text = "0"
        txtBalancePrestamo.Text = "0.00"
        dsCuotas.Clear()
        fld_cod_prestamo.Enabled = True
        btnProcesar.Enabled = True

        btnImprime.Enabled = False
        fld_cod_prestamo.Text = 0
        fld_cod_prestamo.Focus()
        SocioTxt.Text = ""
        SocioRncTxt.Text = ""

    End Sub

    Private Sub LOAD_DATA_PRESTAMO(ByVal id_PRESTAMO As Integer)

        Dim isdata As Boolean = False
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_tabla_prestamos WHERE fld_id_prestamos=" & id_PRESTAMO & "", conn)
        da.Fill(ds, "tbl_tabla_prestamos")

        Dim nr As DataRow
        For Each nr In ds.Tables(0).Rows
            fld_cod_prestamo.Text = Format(id_PRESTAMO, "00000")


            fld_fecha_entrega.Value = nr("fld_fecha_entrega")

            fld_monto_prestamo.Text = Format(nr("fld_capital_prestamo"), "C2")
            txtMontoCuota.Text = Format(nr("fld_monto_cuotas_a"), "C2")
            fld_cantidad_cuotas.Text = nr("fld_cantidad_cuotas")
            fld_clasificacion.Text = nr("fld_clasificacion")
            fld_tipo_prestamo.Text = nr("fld_tipo_prestamo")
            'txtBalancePrestamo.Text = nr("fld_monto")
            fld_porciento.Text = nr("fld_interes_p")
            fldTazaMora.Text = nr("fldTazaMora")



            CargarCuotas(id_PRESTAMO)
            fld_cod_prestamo.Enabled = False
            btnProcesar.Enabled = False
            btnImprime.Enabled = True

            GoTo sigue
        Next


        Alerta("No se encontró el documento solicitado")
        fld_cod_prestamo.Text = "0"
        fld_cod_prestamo.Focus()

sigue:

        da.Dispose()
        ds.Dispose()
    End Sub



    Private Sub CALCULO_CUOTA_INICIAL()
        Dim interes_cuota As Double = (CDbl(fld_monto_prestamo.Text) * CDbl(fld_porciento.Text)) / 100
        Dim capital As Double = CDbl(fld_monto_prestamo.Text) / CDbl(fld_cantidad_cuotas.Text)

        If fld_clasificacion.Text = "Int. Adelantado" Then
            txtMontoCuota.Text = Format(interes_cuota, "C2")
        ElseIf fld_clasificacion.Text = "Int. y Capital Amorizable" Then
            Dim Interes = CDbl(fld_porciento.Text)
            Dim totalCuotas = CDbl(fld_cantidad_cuotas.Text)
            Dim montoPrestamo = CDbl(fld_monto_prestamo.Text)
            If Interes > 0 Then Interes = Interes / 100
            txtMontoCuota.Text = Format(Pmt(Interes, totalCuotas, -montoPrestamo, 0, DueDate.EndOfPeriod), "C2")
        ElseIf fld_clasificacion.Text = "Int. y Capital Fijos" Then
            txtMontoCuota.Text = Format(interes_cuota + capital, "C2")
        Else
            txtMontoCuota.Text = Format(capital, "C2")
        End If


    End Sub

    Private Function VALIDA_DATOS() As Boolean

        If Trim(fldTazaMora.Text) = "" Then fldTazaMora.Text = "0"
        If Trim(fld_porciento.Text) = "" Then fld_porciento.Text = "0.00"

        If CDbl(Trim(fld_monto_prestamo.Text)) = 0 Then
            fld_monto_prestamo.Focus()
            Alerta("Introduzca el monto del préstamo")
            Return False
        ElseIf CDbl(Trim(fld_cantidad_cuotas.Text)) = 0 Then
            fld_cantidad_cuotas.Focus()
            Alerta("Introduzca la cantidad de cuotas")
            Return False
        End If

        Return True
    End Function

    Private Sub CREA_PRESTAMO()

        Dim cmd As New MySqlCommand
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "INSERT INTO tbl_tabla_prestamos (fld_id_del_cliente,fld_fecha_entrega,fld_cantidad_cuotas,fld_monto_cuotas_a,fld_capital_prestamo,fld_monto,fld_abono,fld_balance,fld_usuario,fld_status_prestamos, fld_anos, fld_interes_p,fld_tipo_prestamo,fld_tipo_garantia, fld_garantia, fld_clasificacion,fld_ck_no, fldFinanciamiento, fldMontoFinan, fldMontoInicial, fldCodInm, fldDescInm, fldMetros, fldPrecioMetro, fldTazaMora,fldNota,fld_socio,fld_socio_rnc) VALUES(0,'" & formatDate(fld_fecha_entrega.Value.Date) & "'," & fld_cantidad_cuotas.Text & "," & CDbl(txtMontoCuota.Text) & "," & CDbl(fld_monto_prestamo.Text) & ",0,0,0,'" & User(0) & "','Nuevo', 0, " & CDbl(fld_porciento.Text) & ",'" & fld_tipo_prestamo.Text & "','N/A', 'N/A','" & fld_clasificacion.Text & "','','NO',0,0,0,'N/A',0,0," & CDbl(fldTazaMora.Text) & ",'TablaPréstamos','" & SocioTxt.Text & "','" & SocioRncTxt.Text & "')"
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd.Dispose()
        fld_cod_prestamo.Enabled = False
        btnProcesar.Enabled = False
    End Sub

    Private Sub CREA_CUOTAS(ByVal fecha_termina As String, ByVal no_cuotas As String, ByVal capital_cuotas As Double, ByVal interes_cuota As Double, ByVal fld_pendiente_amortizar As Double, ByVal fld_total_amortizado As Double)

        Dim cmd As New MySqlCommand
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "INSERT INTO tbl_tabla_cuotas (fld_no_cuotas,fld_id_del_cliente_cuotas,fld_id_del_prestamo,fld_fecha_entrega_cuotas,fld_fecha_termina_cuotas,fld_capital_cuota,fld_interes_cuota,fld_monto_cuotas,fld_abono_cuotas,fld_balance_cuotas,fld_usuario_cuotas,fld_status_cuotas,fld_pendiente_amortizar,fld_total_amortizado, fld_capital_cuota_abono, fld_capital_cuota_balance,fld_interes_cuota_abono,fld_interes_cuota_balance,fld_fecha_ultimo_abono_cuotas,fld_monto_mora, fld_abono_mora, fld_balance_mora, fld_ultimo_abono_mora,fld_ultimo_abono_interes,fld_ultimo_abono_capital,fld_tipo_cuotas,fld_cant_cuotas, fld_fecha_calculo_interes) VALUES('" & no_cuotas & "',0, " & CInt(fld_cod_prestamo.Text) & ", '" & formatDate(fld_fecha_entrega.Value.Date) & "','" & fecha_termina & "'," & capital_cuotas & "," & interes_cuota & ", " & capital_cuotas + interes_cuota & ", 0, " & capital_cuotas + interes_cuota & ",'" & User(0) & "', 'Nueva', " & fld_pendiente_amortizar & "," & fld_total_amortizado & ",0," & capital_cuotas & ",0," & interes_cuota & ",'" & formatDate(fld_fecha_entrega.Value.Date) & "',0,0,0,0,0,0,'" & fld_tipo_prestamo.Text & "'," & fld_cantidad_cuotas.Text & ", '" & formatDate(fld_fecha_entrega.Value.Date) & "')"
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd.Dispose()

    End Sub

    Private Function UPDATE_CUOTA_PAGADAS(ByVal ID_CUOTA As String) As Double
        Dim CMD As New MySqlCommand
        With CMD
            .Connection = conn
            .Connection.Open()
            .CommandText = "UPDATE tbl_tabla_cuotas SET fld_abono_cuotas=fld_monto_cuotas, fld_balance_cuotas=0, fld_capital_cuota_abono=fld_capital_cuota, fld_capital_cuota_balance=0, fld_interes_cuota_abono=fld_interes_cuota, fld_interes_cuota_balance=0, fld_fecha_ultimo_abono_cuotas=fld_fecha_termina_cuotas WHERE fld_no_cuotas=" & ID_CUOTA & " AND fld_id_del_prestamo=" & CInt(fld_cod_prestamo.Text) & ""
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        CMD.Dispose()

    End Function

    Private Sub GENERANDO_PRESTAMO()

        If VALIDA_DATOS() = False Then Exit Sub


        If btnProcesar.Enabled = False Then Exit Sub

        If CDbl(Trim(fld_cantidad_cuotas.Text)) > 0 Then
            'HACER LOS CALCULOS Y GENERAL EL PRESTAMO SI EL USUARIO ACEPTA
            If Alerta("Verifique que los datos esten correcto..." & Chr(13) & "¿Desea continuar?") = True Then
                CREA_PRESTAMO() 'Crea el préstamos
                fld_cod_prestamo.Text = UltimoID("tbl_tabla_prestamos", "fld_id_prestamos")
                GENERANDO_CUOTAS() 'Genera y crea las cuotas
                CargarCuotas(CInt(fld_cod_prestamo.Text))
                Dim fechaTermina As Date = CDate(SCALAR_STRING("SELECT MAX(fld_fecha_termina_cuotas) FROM tbl_tabla_cuotas WHERE fld_id_del_prestamo=" & fld_cod_prestamo.Text & ""))
                NON_QUERY("UPDATE tbl_tabla_prestamos SET fld_monto=" & CDbl(txtBalancePrestamo.Text) & ",  fld_balance=fld_monto, fld_fecha_termina='" & formatDate(fechaTermina) & "' WHERE fld_id_prestamos=" & fld_cod_prestamo.Text & "")

                btnImprime.Enabled = True
            End If
        End If
    End Sub

    Private Sub GENERANDO_CUOTAS()


        Dim porciento_prestamo As Double = CDbl(fld_porciento.Text)

        Dim interes_cuota As Double = 0, cap_cuota As Double = 0

        'Int. y Capital Amorizable OK
        'Int. y Capital Fijos
        'Int. Adelantado
        'Int. Diario Sobre Saldo Insoluto
        'Int. Diario Sobre Capital Inicial

        cap_cuota = CDbl(fld_monto_prestamo.Text) / CDbl(fld_cantidad_cuotas.Text)
        interes_cuota = ((CDbl(fld_monto_prestamo.Text) * CDbl(porciento_prestamo)) / 100)

        If fld_clasificacion.Text = "Int. y Capital Amorizable" Then
            InteresCapitalAmortizables()
        ElseIf fld_clasificacion.Text = "Int. Adelantado" Then
            InteresAdelantado(interes_cuota)
        Else
            InteresCapitalFijosInteresAplicDiario(interes_cuota, cap_cuota)
        End If

        'If fld_tipo_prestamo.Text = "INT. ADELANTADO MENSUAL" Then
        '    Dim interes As Double = Format(((CDbl(fld_monto_prestamo.Text) * CDbl(porciento_prestamo)) / 100), "C2")
        '    Dim interes_capital As Double = Format((CDbl(fld_monto_prestamo.Text) + ((CDbl(fld_monto_prestamo.Text) * CDbl(porciento_prestamo)) / 100)), "C2")

        '    For i = 1 To CInt(fld_cantidad_cuotas.Text) - 1
        '        fechas = fld_fecha_entrega.Value.AddMonths(i)
        '        CREA_CUOTAS(formatDate(fechas), Format(cuota_no, "000"), 0, interes, 0, 0)
        '        cuota_no = cuota_no + 1
        '    Next

        '    fechas = fechas.Date.AddMonths(1)
        '    CREA_CUOTAS(formatDate(fechas), Format(cuota_no, "000"), CDbl(fld_monto_prestamo.Text), interes, 0, 0)
        '    Exit Sub
        'ElseIf fld_tipo_prestamo.Text = "INT. ADELANTADO QUINCENAL" Then
        '    Dim interes As Double = Format(((CDbl(fld_monto_prestamo.Text) * CDbl(porciento_prestamo)) / 100), "C2")
        '    Dim dia As Integer = 15
        '    fechas = fld_fecha_entrega.Value.AddDays(dia)

        '    For i = 1 To CInt(fld_cantidad_cuotas.Text) - 1
        '        fechas = fld_fecha_entrega.Value.AddDays(dia)
        '        CREA_CUOTAS(formatDate(fechas), Format(cuota_no, "000"), 0, interes, 0, 0)
        '        cuota_no = cuota_no + 1
        '        dia = dia + 15
        '    Next

        '    fechas = fechas.Date.AddDays(15)
        '    CREA_CUOTAS(formatDate(fechas), Format(cuota_no, "000"), CDbl(fld_monto_prestamo.Text), interes, 0, 0)
        '    Exit Sub
        'End If



        'Dim bce_capital As Double = CDbl(fld_monto_prestamo.Text)

        'Dim dias As Integer = 7
        'If fld_tipo_prestamo.Text = "QUINCENAL" Then
        '    dias = 15
        'End If

        'For i = 1 To CDbl(fld_cantidad_cuotas.Text)

        '    If fld_tipo_prestamo.Text = "QUINCENAL" Then
        '        fechas = fld_fecha_entrega.Value.AddDays(dias)
        '        dias = dias + 15
        '    ElseIf fld_tipo_prestamo.Text = "SEMANAL" Then
        '        fechas = fld_fecha_entrega.Value.AddDays(dias)
        '        dias = dias + 7
        '    Else
        '        fechas = fld_fecha_entrega.Value.AddMonths(i)
        '    End If

        '    If fld_clasificacion.Text = "No Amortizales" Then
        '        CREA_CUOTAS(formatDate(fechas), Format(cuota_no, "000"), cap_cuota, interes_cuota, 0, 0)
        '    ElseIf fld_clasificacion.Text = "Amortizables" Then
        '        CREA_CUOTAS(formatDate(fechas), Format(cuota_no, "000"), cap_cuota, interes_cuota, 0, 0)
        '        interes_cuota = (((bce_capital - cap_cuota) * CDbl(porciento_prestamo)) / 100)
        '        bce_capital = bce_capital - cap_cuota
        '    Else
        '        CREA_CUOTAS(formatDate(fechas), Format(cuota_no, "000"), cap_cuota, 0, 0, 0)
        '    End If

        '    cuota_no = cuota_no + 1
        'Next

        'count = 0
        'cuota_no = 1


    End Sub

    Private Sub BORRAR_PRESTAMO()
        Dim cmd As New MySqlCommand
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "DELETE FROM tbl_tabla_prestamos WHERE fld_id_prestamos=" & fld_cod_prestamo.Text & ""
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd.Dispose()
    End Sub

    Private Sub BORRAR_CUOTAS()
        Dim cmd As New MySqlCommand
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "DELETE FROM tbl_tabla_cuotas WHERE fld_id_del_prestamo=" & fld_cod_prestamo.Text & ""
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd.Dispose()
    End Sub

    Private Function UPDATE_CUOTA(ByVal ID_CUOTA As String, ByVal monto As Double) As Double
        Dim CMD As New MySqlCommand
        With CMD
            .Connection = conn
            .Connection.Open()
            .CommandText = "UPDATE tbl_tabla_cuotas SET fld_abono_cuotas=fld_abono_cuotas+" & monto & ", fld_balance_cuotas=fld_balance_cuotas-" & monto & ", fld_fecha_ultimo_abono_cuotas='" & formatDate(Now.Date) & "' WHERE fld_id_cuotas=" & ID_CUOTA & ""
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        CMD.Dispose()
        '
        Dim CMD1 As New MySqlCommand, CAPITAL As Double
        With CMD1
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT fld_capital_cuota FROM tbl_tabla_cuotas  WHERE fld_id_cuotas=" & ID_CUOTA & ""
            CAPITAL = .ExecuteScalar
            .Connection.Close()
        End With
        CMD1.Dispose()
        Return CAPITAL
    End Function

    Private Function BCE_CUOTA(ByVal ID_CUOTA As String) As Double

        Dim CMD1 As New MySqlCommand, CAPITAL As Double
        With CMD1
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT fld_balance_cuotas FROM tbl_tabla_cuotas  WHERE fld_id_cuotas=" & ID_CUOTA & ""
            CAPITAL = .ExecuteScalar
            .Connection.Close()
        End With
        CMD1.Dispose()
        BCE_CUOTA = CAPITAL
    End Function

    Private Function RETURN_NO_CUOTA(ByVal ID_CUOTA As String) As String

        Dim CMD1 As New MySqlCommand, CAPITAL As String
        With CMD1
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT fld_no_cuotas FROM tbl_tabla_cuotas  WHERE fld_id_cuotas=" & ID_CUOTA & ""
            CAPITAL = .ExecuteScalar
            .Connection.Close()
        End With
        CMD1.Dispose()
        Return CAPITAL
    End Function

    Private Sub txtId_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fld_fecha_entrega_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fld_fecha_entrega.KeyDown
        If e.KeyCode = Keys.Enter Then
            fld_porciento.Focus()
        End If
    End Sub

    Private Sub fld_monto_prestamo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fld_monto_prestamo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If CDbl(Trim(fld_monto_prestamo.Text)) > 0 Then
                Dim amount As Decimal = CType(fld_monto_prestamo.Text, Decimal)
                Me.fld_monto_prestamo.Text = String.Format("{0:n2}", amount)
                fld_cantidad_cuotas.Focus()
            End If
        End If
    End Sub

    Private Sub fld_monto_prestamo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_monto_prestamo.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fld_cantidad_cuotas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fld_cantidad_cuotas.KeyDown
        If e.KeyCode = Keys.Enter Then
            CREAR()
        End If
    End Sub

    Private Sub fld_cantidad_cuotas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_cantidad_cuotas.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        CLEAR_ALL_DATA()

    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        CREAR()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click

        Me.Close()
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If btnProcesar.Enabled = True Then
            Alerta("Debe buscar el documento que desea borrar")
            Exit Sub
        End If

        If SCALAR_NUM("SELECT SUM(fld_abono_cuotas) FROM tbl_tabla_cuotas WHERE fld_id_del_prestamo=" & fld_cod_prestamo.Text & "") > 0 Then
            Alerta("El documento ya tiene abono realizado, por tanto no puede ser anulado")
            Exit Sub
        End If



    End Sub

    Private Sub fld_cod_prestamo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fld_cod_prestamo.KeyDown

        If e.KeyCode = Keys.Enter Then
            If Trim(fld_cod_prestamo.Text) <> "" Then
                LOAD_DATA_PRESTAMO(fld_cod_prestamo.Text)
            End If
        End If

    End Sub

    Private Sub fld_cod_prestamo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_cod_prestamo.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fld_cod_zona_prestamos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub fld_tipo_prestamo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub fld_interes_adelantado_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub fld_porciento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_porciento.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fld_anos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fld_porciento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fld_porciento.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(fld_porciento.Text) <> "" Then
                If CDbl(fld_porciento.Text) > 0 Then
                    fld_monto_prestamo.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub fld_tipo_prestamo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fld_tipo_prestamo.SelectedValueChanged
        If fld_tipo_prestamo.Text = "INT. DIAS" Then
            fld_cantidad_cuotas.Text = 1
            fld_cantidad_cuotas.ReadOnly = True
        Else
            fld_cantidad_cuotas.ReadOnly = False
        End If
    End Sub

    Private Sub fld_tipo_prestamo_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_tipo_prestamo.KeyPress
        e.Handled = True
    End Sub

    Private Sub fld_tipo_garantia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private WithEvents docToPrint As New Printing.PrintDocument

    Private Sub btnImprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprime.Click



        PrintDialog1.AllowSomePages = True
        PrintDialog1.ShowHelp = True
        PrintDialog1.Document = docToPrint

        Dim result As DialogResult = PrintDialog1.ShowDialog()



        ' If the result is OK then print the document.
        If (result = Windows.Forms.DialogResult.OK) Then

            Dim pd As New PrintDocument, strOldPrinter As String
            strOldPrinter = pd.PrinterSettings.PrinterName 'Get the Default Print 


            Dim WshNetwork As Object
            WshNetwork = Microsoft.VisualBasic.CreateObject("WScript.Network")
            WshNetwork.SetDefaultPrinter(PrintDialog1.PrinterSettings.PrinterName) 'Set the Default Print 


            Dim ds As New DataSet



            Dim daP1 As New MySqlDataAdapter("SELECT * FROM view_tabla_prestamos WHERE fld_id_prestamos=" & fld_cod_prestamo.Text & "", conn)
            daP1.Fill(ds, "view_tabla_prestamos")


            Dim Report As New RPT_TABLA_PRESTAMOS
            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PrinterName = PrintDialog1.PrinterSettings.PrinterName
            Report.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, True, 0, 0)


            WshNetwork.SetDefaultPrinter(strOldPrinter) 'Get the Default Print
        End If

    End Sub

    Private Sub fldMontoInicial_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fldMontoAdicional_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fldCodInm_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fldCantMetros_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fldPrecioMetro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fldFinanciamiento_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub fldTazaMora_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fldTazaMora.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fld_tipo_prestamo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fld_tipo_prestamo.SelectedIndexChanged
        lblTasaInteres.Text = "Tasa de Interes " & fld_tipo_prestamo.Text
    End Sub

    Private Sub fld_clasificacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_clasificacion.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnListaPrestamos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If FRMS_LIST_PRESTAMOS() = True Then
            LOAD_DATA_PRESTAMO(Id)
        End If
    End Sub

    Private Sub fld_cantidad_cuotas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fld_cantidad_cuotas.TextChanged

    End Sub

    Private Sub fld_clasificacion_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fld_clasificacion.SelectedValueChanged
        lblTasaInteres.Text = "Tasa de Interes " & fld_tipo_prestamo.Text
    End Sub

    Private Sub btnCambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiar.Click
        If btnProcesar.Enabled = True Then
            Alerta("Debe buscar el préstamo al cual desea modificar la Mora")
            Exit Sub
        End If

        If Alerta("¿Seguro que desea modificar el porciento de mora?") = True Then
            NON_QUERY("UPDATE tbl_tabla_prestamos set fldTazaMora=" & fldTazaMora.Text & " WHERE fld_id_prestamos=" & CInt(fld_cod_prestamo.Text) & "")
            Alerta("Mora modificada")
        End If
    End Sub




End Class
