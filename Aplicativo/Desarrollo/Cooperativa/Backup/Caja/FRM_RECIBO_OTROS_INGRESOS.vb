Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Public Class FRM_RECIBO_OTROS_INGRESOS
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
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_procesar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEntregado As System.Windows.Forms.TextBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents fld_detalle_forma_pago As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFormaDePago As System.Windows.Forms.ComboBox
    Friend WithEvents fld_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtIdEntregado As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents btnImprime As System.Windows.Forms.Button
    Friend WithEvents cmbCajas As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents listaSociosBtn As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_RECIBO_OTROS_INGRESOS))
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.btn_cerrar = New System.Windows.Forms.Button
        Me.btn_procesar = New System.Windows.Forms.Button
        Me.txtEntregado = New System.Windows.Forms.TextBox
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.txtConcepto = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtId = New System.Windows.Forms.TextBox
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.Label13 = New System.Windows.Forms.Label
        Me.fld_detalle_forma_pago = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtFormaDePago = New System.Windows.Forms.ComboBox
        Me.fld_fecha = New System.Windows.Forms.DateTimePicker
        Me.txtIdEntregado = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbTipo = New System.Windows.Forms.ComboBox
        Me.btnImprime = New System.Windows.Forms.Button
        Me.cmbCajas = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.listaSociosBtn = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(96, 288)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 56)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar.ForeColor = System.Drawing.Color.Black
        Me.btn_cerrar.Image = CType(resources.GetObject("btn_cerrar.Image"), System.Drawing.Image)
        Me.btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cerrar.Location = New System.Drawing.Point(560, 288)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(72, 56)
        Me.btn_cerrar.TabIndex = 9
        Me.btn_cerrar.Text = "&Cerrar"
        Me.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btn_procesar
        '
        Me.btn_procesar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_procesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_procesar.ForeColor = System.Drawing.Color.Black
        Me.btn_procesar.Image = CType(resources.GetObject("btn_procesar.Image"), System.Drawing.Image)
        Me.btn_procesar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_procesar.Location = New System.Drawing.Point(168, 288)
        Me.btn_procesar.Name = "btn_procesar"
        Me.btn_procesar.Size = New System.Drawing.Size(72, 56)
        Me.btn_procesar.TabIndex = 6
        Me.btn_procesar.Text = "&Guardar"
        Me.btn_procesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtEntregado
        '
        Me.txtEntregado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEntregado.Location = New System.Drawing.Point(96, 88)
        Me.txtEntregado.MaxLength = 255
        Me.txtEntregado.Name = "txtEntregado"
        Me.txtEntregado.Size = New System.Drawing.Size(536, 20)
        Me.txtEntregado.TabIndex = 1
        Me.txtEntregado.Text = ""
        '
        'txtMonto
        '
        Me.txtMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Location = New System.Drawing.Point(96, 112)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(272, 29)
        Me.txtMonto.TabIndex = 2
        Me.txtMonto.Text = "0.00"
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtConcepto
        '
        Me.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConcepto.Location = New System.Drawing.Point(96, 216)
        Me.txtConcepto.MaxLength = 255
        Me.txtConcepto.Multiline = True
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(536, 56)
        Me.txtConcepto.TabIndex = 5
        Me.txtConcepto.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Recibimos de:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(0, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Monto RD$"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(0, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Por concepto de"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(640, 32)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "OTRO INGRESO A  CAJA"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(16, 280)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(64, 20)
        Me.txtId.TabIndex = 17
        Me.txtId.Text = "0"
        Me.txtId.Visible = False
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(8, 168)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 16)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Detalle"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_detalle_forma_pago
        '
        Me.fld_detalle_forma_pago.BackColor = System.Drawing.Color.White
        Me.fld_detalle_forma_pago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_detalle_forma_pago.Location = New System.Drawing.Point(96, 168)
        Me.fld_detalle_forma_pago.MaxLength = 100
        Me.fld_detalle_forma_pago.Multiline = True
        Me.fld_detalle_forma_pago.Name = "fld_detalle_forma_pago"
        Me.fld_detalle_forma_pago.Size = New System.Drawing.Size(272, 40)
        Me.fld_detalle_forma_pago.TabIndex = 4
        Me.fld_detalle_forma_pago.Text = "N/A"
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(0, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Forma de pago"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFormaDePago
        '
        Me.txtFormaDePago.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.txtFormaDePago.ForeColor = System.Drawing.Color.White
        Me.txtFormaDePago.ItemHeight = 13
        Me.txtFormaDePago.Items.AddRange(New Object() {"CHEQUE", "TARJETA", "EFECTIVO"})
        Me.txtFormaDePago.Location = New System.Drawing.Point(96, 144)
        Me.txtFormaDePago.Name = "txtFormaDePago"
        Me.txtFormaDePago.Size = New System.Drawing.Size(272, 21)
        Me.txtFormaDePago.TabIndex = 3
        Me.txtFormaDePago.Text = "EFECTIVO"
        '
        'fld_fecha
        '
        Me.fld_fecha.CustomFormat = "dd / MMM / yyyy"
        Me.fld_fecha.Enabled = False
        Me.fld_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fld_fecha.Location = New System.Drawing.Point(808, 56)
        Me.fld_fecha.Name = "fld_fecha"
        Me.fld_fecha.Size = New System.Drawing.Size(128, 20)
        Me.fld_fecha.TabIndex = 88
        Me.fld_fecha.Visible = False
        '
        'txtIdEntregado
        '
        Me.txtIdEntregado.Location = New System.Drawing.Point(736, 56)
        Me.txtIdEntregado.Name = "txtIdEntregado"
        Me.txtIdEntregado.Size = New System.Drawing.Size(40, 20)
        Me.txtIdEntregado.TabIndex = 87
        Me.txtIdEntregado.Text = "0"
        Me.txtIdEntregado.Visible = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(464, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Tipo Doc.:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Visible = False
        '
        'cmbTipo
        '
        Me.cmbTipo.Items.AddRange(New Object() {"NORMAL", "CLIENTES", "PROVEEDORES"})
        Me.cmbTipo.Location = New System.Drawing.Point(568, 56)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipo.TabIndex = 19
        Me.cmbTipo.Text = "NORMAL"
        Me.cmbTipo.Visible = False
        '
        'btnImprime
        '
        Me.btnImprime.BackColor = System.Drawing.SystemColors.Control
        Me.btnImprime.ForeColor = System.Drawing.Color.Black
        Me.btnImprime.Image = CType(resources.GetObject("btnImprime.Image"), System.Drawing.Image)
        Me.btnImprime.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnImprime.Location = New System.Drawing.Point(240, 288)
        Me.btnImprime.Name = "btnImprime"
        Me.btnImprime.Size = New System.Drawing.Size(72, 56)
        Me.btnImprime.TabIndex = 8
        Me.btnImprime.Text = "&Imprimir"
        Me.btnImprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmbCajas
        '
        Me.cmbCajas.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.cmbCajas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCajas.ForeColor = System.Drawing.Color.White
        Me.cmbCajas.Location = New System.Drawing.Point(96, 64)
        Me.cmbCajas.Name = "cmbCajas"
        Me.cmbCajas.Size = New System.Drawing.Size(288, 21)
        Me.cmbCajas.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(24, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Caja :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'listaSociosBtn
        '
        Me.listaSociosBtn.Image = CType(resources.GetObject("listaSociosBtn.Image"), System.Drawing.Image)
        Me.listaSociosBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.listaSociosBtn.Location = New System.Drawing.Point(384, 63)
        Me.listaSociosBtn.Name = "listaSociosBtn"
        Me.listaSociosBtn.Size = New System.Drawing.Size(99, 23)
        Me.listaSociosBtn.TabIndex = 89
        Me.listaSociosBtn.Text = "Lista de Socio"
        Me.listaSociosBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FRM_RECIBO_OTROS_INGRESOS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(642, 363)
        Me.Controls.Add(Me.listaSociosBtn)
        Me.Controls.Add(Me.cmbCajas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnImprime)
        Me.Controls.Add(Me.fld_fecha)
        Me.Controls.Add(Me.txtIdEntregado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.fld_detalle_forma_pago)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtFormaDePago)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.txtEntregado)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_procesar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_RECIBO_OTROS_INGRESOS"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Otro Ingreso a Caja"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Function validarDocumento() As Boolean

        If Trim(txtMonto.Text) = "" Then txtMonto.Text = 0

        If SCALAR_NUM("SELECT IFNULL(1,0) FROM  tbl_interfascontabletipotrans_conf WHERE Frm='" & Me.Text & "'") = 0 Then
            Alerta("El Interfas contable no está configurado, no se puede guardar el documento.")
            Return False
        End If

        If Trim(txtEntregado.Text) = String.Empty Then
            Alerta("Debe escribir de quién está recibiendo dinero")
            txtEntregado.Focus()
            Return False
        End If

        If CDbl(txtMonto.Text) <= 0 Then
            Alerta("Debe escribir el monto del Ingreso")
            txtMonto.Focus()
            Return False
        End If

        If Trim(txtConcepto.Text) = String.Empty Then
            Alerta("Debe escribir el concepto")
            txtConcepto.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub LlenarCajas()

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT Id, Descripcion FROM cajamantenimiento ORDER BY Orden, Descripcion", conn)
        da.Fill(dt)

        cmbCajas.DataSource = dt
        cmbCajas.DisplayMember = "Descripcion"
        cmbCajas.ValueMember = "Id"
        da.Dispose()



    End Sub

    Private Sub FRM_RECIBO_OTROS_INGRESOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        fld_fecha.Value = SCALAR_STRING("SELECT DATE(Now())")
        LlenarCajas()
    End Sub
    Private Sub BuscarCliente()
        If FRMS_POPUP_CLIENTES("TODOS") = True Then
            READER("SELECT fld_id, fld_FullName FROM tbl_clientes WHERE fld_id=" & Id & "")
            If reader_values.Length > 0 Then
                txtIdEntregado.Text = reader_values(0)
                txtEntregado.Text = reader_values(1)
                txtMonto.Focus()
            End If
        End If
    End Sub
    Private Sub BuscarProveedor()
        If FRMS_POPUP_PROVEEDORES() = True Then
            READER("SELECT fldSupplierID, fldCompany FROM tbl_supplier WHERE fldSupplierID=" & Id & "")
            If reader_values.Length > 0 Then
                txtIdEntregado.Text = reader_values(0)
                txtEntregado.Text = reader_values(1)
                txtMonto.Focus()
            End If
        End If
    End Sub
    Private Sub Nuevo()
        txtId.Text = "0"
        txtEntregado.Text = String.Empty
        txtMonto.Text = "0.00"
        txtConcepto.Text = String.Empty
        txtIdEntregado.Text = 0
        cmbCajas.SelectedValue = -1
    End Sub
    Private Function Guardar() As Integer

        NON_QUERY("INSERT INTO tbl_recibo_ingresos_cxc (fld_forma_pago,fld_detalle_forma_pago,fld_id_cliente_ri,fld_date,fld_Description,fld_monto,fld_fact_afectado,fdl_nd_afectado,fld_User,fld_Estado,fld_id_prestamo, fld_concepto, fld_interes_cobrado, fld_capital_cobrado, fld_mora_cobrada, fld_socio, idCaja) VALUES('" & txtFormaDePago.Text & "','" & fld_detalle_forma_pago.Text & "',0,Now(),'" & txtConcepto.Text & "'," & CDec(txtMonto.Text) & ",'0','0','" & User(0) & "','NEW',0,'" & txtConcepto.Text & "',0, 0," & CDec(txtMonto.Text) & ",'" & txtEntregado.Text & "'," & cmbCajas.SelectedValue & ")")

        Dim IdLastRI As Integer = SCALAR_NUM("SELECT MAX(fld_Id_RI) FROM tbl_recibo_ingresos_cxc")
        imprimirDocumento(IdLastRI)
        Return IdLastRI


    End Function

    Private Sub imprimirDocumento(ByVal idDoc As Integer)
        If CBool(SCALAR_NUM("SELECT VistaPreviaImpresion FROM parametrosgenerales WHERE ID=1")) = True Then
            Id = idDoc
            AllReportSinFecha("Recibo Otro Ingreso")
            Me.Close()
        Else
            PrintDialog1.AllowSomePages = True
            PrintDialog1.ShowHelp = True
            PrintDialog1.Document = docToPrint


            Dim pd As New PrintDocument, strOldPrinter As String
            strOldPrinter = pd.PrinterSettings.PrinterName 'Get the Default Print 


            Dim WshNetwork As Object
            WshNetwork = Microsoft.VisualBasic.CreateObject("WScript.Network")


            Dim result As DialogResult = PrintDialog1.ShowDialog()



            ' If the result is OK then print the document.
            If (result = Windows.Forms.DialogResult.OK) Then
                WshNetwork.SetDefaultPrinter(PrintDialog1.PrinterSettings.PrinterName) 'Set the Default Print 
                Dim ds As New DataSet

                Dim daProf As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
                daProf.Fill(ds, "tbl_profiledocument")

                Dim IdRi As Integer = UltimoID("tbl_recibo_ingresos_cxc", "fld_Id_RI")

                Dim daInv As New MySqlDataAdapter("SELECT * FROM tbl_recibo_ingresos_cxc WHERE fld_id_ri=" & idDoc & "", conn)
                daInv.Fill(ds, "tbl_recibo_ingresos_cxc")
                Dim dr As DataRow

                For Each dr In ds.Tables(1).Rows
                    Dim largo = Len(CStr(Format(CDbl(dr("fld_monto")), "##,###.00")))
                    Dim decimales = Mid(CStr(Format(CDbl(dr("fld_monto")), "##,###.00")), largo - 2)

                    dr("fld_Description") = Num2Text(dr("fld_monto") - decimales) & " CON " & Mid(decimales, Len(decimales) - 1).ToUpper & " / 100" & " "
                Next

                If objIniFile.GetString("COMPANY", "Tipo Impresora RI", "Normal") = "Normal" Then
                    Dim Report As New RPT_RECIBO_OTRO_INGRESO
                    Report.Database.Tables(0).SetDataSource(ds)
                    Report.PrintOptions.PrinterName = PrintDialog1.PrinterSettings.PrinterName
                    Report.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, True, 0, 0)
                Else
                    Dim Report As New rptOtroIngresoSP
                    Report.Database.Tables(0).SetDataSource(ds)
                    Report.PrintOptions.PrinterName = PrintDialog1.PrinterSettings.PrinterName
                    Report.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, True, 0, 0)
                End If


            End If


            WshNetwork.SetDefaultPrinter(strOldPrinter) 'Get the Default Print
        End If
        

    End Sub
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Nuevo()
    End Sub

    Private Sub btn_procesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_procesar.Click
        If validarDocumento() = False Then Return
        Dim ctaContableCaja = SCALAR_STRING("SELECT CtaContable  FROM cajamantenimiento WHERE ID=" & cmbCajas.SelectedValue & "")

        Dim idTipoTrans = SCALAR_NUM("SELECT IdTipo FROM  tbl_interfascontabletipotrans_conf WHERE Frm='" & Me.Text & "'")

        Dim nombreCta = ReturnDescripcion(ctaContableCaja)

        Dim idTran = CargarFrmInterfas(ctaContableCaja, nombreCta, txtMonto.Text, 0, 0, "Otro Ingreso de Caja", txtConcepto.Text, fld_fecha.Value.Date, idTipoTrans)

        If idTran > 0 Then
            Dim idDoc = Guardar()
            NON_QUERY("UPDATE tbl_interfascontabletransacciones SET TransIDDoc=" & idDoc & " WHERE TransID=" & idTran & "")
        Else
            Alerta("La operación ha sido cancelada")
            Return
        End If

        Nuevo()
    End Sub

    Private Sub btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub



    Private Sub txtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(13) Then
            Dim amount As Decimal = CType(txtMonto.Text, Decimal)
            Me.txtMonto.Text = String.Format("{0:n2}", amount)
            txtConcepto.Focus()
        End If

    End Sub

    Private Sub cmbTipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTipo.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipo.SelectedIndexChanged
        If cmbTipo.Text = "CLIENTES" Then
            BuscarCliente()
        ElseIf cmbTipo.Text = "PROVEEDORES" Then
            BuscarProveedor()
        Else
            txtIdEntregado.Text = 0
        End If
    End Sub

    Private Sub btnImprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprime.Click
        Dim f As New FRM_LIST_RECIBOS_OTROS_INGRESOS
        f.ShowDialog()
        f.Dispose()
        Me.Close()
    End Sub


    Private Sub FRM_RECIBO_OTROS_INGRESOS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub listaSociosBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listaSociosBtn.Click
        If FRMS_POPUP_CLIENTES("TODOS") = True Then
            READER("SELECT fld_id, fld_FullName FROM tbl_clientes WHERE fld_id=" & Id & "")
            If reader_values.Length > 0 Then

                txtEntregado.Text = reader_values(1)
            End If
            txtMonto.Focus()
        End If
    End Sub
End Class
