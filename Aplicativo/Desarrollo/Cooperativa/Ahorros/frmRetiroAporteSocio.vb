Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Web
Imports System.Web.Mail
Public Class frmRetiroAporteSocio
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
    Friend WithEvents cmbCajas As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents listaSociosBtn As System.Windows.Forms.Button
    Friend WithEvents imprimirBtn As System.Windows.Forms.Button
    Friend WithEvents idDocTxt As System.Windows.Forms.TextBox
    Friend WithEvents conceptoTxt As System.Windows.Forms.TextBox
    Friend WithEvents montoTxt As System.Windows.Forms.TextBox
    Friend WithEvents socioTxt As System.Windows.Forms.TextBox
    Friend WithEvents nuevoBtn As System.Windows.Forms.Button
    Friend WithEvents cerrarBtn As System.Windows.Forms.Button
    Friend WithEvents guardarBtn As System.Windows.Forms.Button
    Friend WithEvents IdSocioTxt As System.Windows.Forms.TextBox
    Friend WithEvents lbMontoAporteDisponible As Label
    Friend WithEvents txtTotalAporteDisponible As TextBox
    Friend WithEvents dtpFechaRetiro As DateTimePicker
    Friend WithEvents lblFechaRecibo As Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRetiroAporteSocio))
        Me.cmbCajas = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.imprimirBtn = New System.Windows.Forms.Button()
        Me.idDocTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.conceptoTxt = New System.Windows.Forms.TextBox()
        Me.montoTxt = New System.Windows.Forms.TextBox()
        Me.socioTxt = New System.Windows.Forms.TextBox()
        Me.nuevoBtn = New System.Windows.Forms.Button()
        Me.cerrarBtn = New System.Windows.Forms.Button()
        Me.guardarBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.listaSociosBtn = New System.Windows.Forms.Button()
        Me.IdSocioTxt = New System.Windows.Forms.TextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.lbMontoAporteDisponible = New System.Windows.Forms.Label()
        Me.txtTotalAporteDisponible = New System.Windows.Forms.TextBox()
        Me.dtpFechaRetiro = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaRecibo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbCajas
        '
        Me.cmbCajas.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.cmbCajas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCajas.ForeColor = System.Drawing.Color.White
        Me.cmbCajas.Location = New System.Drawing.Point(101, 64)
        Me.cmbCajas.Name = "cmbCajas"
        Me.cmbCajas.Size = New System.Drawing.Size(288, 21)
        Me.cmbCajas.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(29, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Caja :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'imprimirBtn
        '
        Me.imprimirBtn.BackColor = System.Drawing.SystemColors.Control
        Me.imprimirBtn.FlatAppearance.BorderSize = 0
        Me.imprimirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.imprimirBtn.ForeColor = System.Drawing.Color.Black
        Me.imprimirBtn.Image = CType(resources.GetObject("imprimirBtn.Image"), System.Drawing.Image)
        Me.imprimirBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.imprimirBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.imprimirBtn.Location = New System.Drawing.Point(266, 216)
        Me.imprimirBtn.Name = "imprimirBtn"
        Me.imprimirBtn.Size = New System.Drawing.Size(72, 56)
        Me.imprimirBtn.TabIndex = 6
        Me.imprimirBtn.Text = "&Imprimir"
        Me.imprimirBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.imprimirBtn.UseVisualStyleBackColor = False
        '
        'idDocTxt
        '
        Me.idDocTxt.Location = New System.Drawing.Point(21, 208)
        Me.idDocTxt.Name = "idDocTxt"
        Me.idDocTxt.Size = New System.Drawing.Size(64, 20)
        Me.idDocTxt.TabIndex = 14
        Me.idDocTxt.Text = "0"
        Me.idDocTxt.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(640, 32)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "RETIRO APORTE DE SOCIOS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'conceptoTxt
        '
        Me.conceptoTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.conceptoTxt.Location = New System.Drawing.Point(101, 144)
        Me.conceptoTxt.MaxLength = 255
        Me.conceptoTxt.Multiline = True
        Me.conceptoTxt.Name = "conceptoTxt"
        Me.conceptoTxt.Size = New System.Drawing.Size(536, 56)
        Me.conceptoTxt.TabIndex = 3
        '
        'montoTxt
        '
        Me.montoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.montoTxt.Location = New System.Drawing.Point(101, 112)
        Me.montoTxt.Name = "montoTxt"
        Me.montoTxt.Size = New System.Drawing.Size(272, 29)
        Me.montoTxt.TabIndex = 2
        Me.montoTxt.Text = "0.00"
        Me.montoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'socioTxt
        '
        Me.socioTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.socioTxt.Location = New System.Drawing.Point(101, 88)
        Me.socioTxt.MaxLength = 255
        Me.socioTxt.Name = "socioTxt"
        Me.socioTxt.Size = New System.Drawing.Size(536, 20)
        Me.socioTxt.TabIndex = 15
        '
        'nuevoBtn
        '
        Me.nuevoBtn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.nuevoBtn.FlatAppearance.BorderSize = 0
        Me.nuevoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nuevoBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuevoBtn.ForeColor = System.Drawing.Color.Black
        Me.nuevoBtn.Image = CType(resources.GetObject("nuevoBtn.Image"), System.Drawing.Image)
        Me.nuevoBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nuevoBtn.Location = New System.Drawing.Point(101, 216)
        Me.nuevoBtn.Name = "nuevoBtn"
        Me.nuevoBtn.Size = New System.Drawing.Size(72, 56)
        Me.nuevoBtn.TabIndex = 5
        Me.nuevoBtn.Text = "&Nuevo"
        Me.nuevoBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.nuevoBtn.UseVisualStyleBackColor = False
        '
        'cerrarBtn
        '
        Me.cerrarBtn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cerrarBtn.FlatAppearance.BorderSize = 0
        Me.cerrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cerrarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cerrarBtn.ForeColor = System.Drawing.Color.Black
        Me.cerrarBtn.Image = CType(resources.GetObject("cerrarBtn.Image"), System.Drawing.Image)
        Me.cerrarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cerrarBtn.Location = New System.Drawing.Point(565, 216)
        Me.cerrarBtn.Name = "cerrarBtn"
        Me.cerrarBtn.Size = New System.Drawing.Size(72, 56)
        Me.cerrarBtn.TabIndex = 7
        Me.cerrarBtn.Text = "&Cerrar"
        Me.cerrarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cerrarBtn.UseVisualStyleBackColor = False
        '
        'guardarBtn
        '
        Me.guardarBtn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.guardarBtn.FlatAppearance.BorderSize = 0
        Me.guardarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.guardarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guardarBtn.ForeColor = System.Drawing.Color.Black
        Me.guardarBtn.Image = CType(resources.GetObject("guardarBtn.Image"), System.Drawing.Image)
        Me.guardarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.guardarBtn.Location = New System.Drawing.Point(188, 216)
        Me.guardarBtn.Name = "guardarBtn"
        Me.guardarBtn.Size = New System.Drawing.Size(72, 56)
        Me.guardarBtn.TabIndex = 4
        Me.guardarBtn.Text = "&Guardar"
        Me.guardarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.guardarBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Monto RD$"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Socio:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(5, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Por concepto de"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'listaSociosBtn
        '
        Me.listaSociosBtn.FlatAppearance.BorderSize = 0
        Me.listaSociosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.listaSociosBtn.Image = CType(resources.GetObject("listaSociosBtn.Image"), System.Drawing.Image)
        Me.listaSociosBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.listaSociosBtn.Location = New System.Drawing.Point(394, 62)
        Me.listaSociosBtn.Name = "listaSociosBtn"
        Me.listaSociosBtn.Size = New System.Drawing.Size(99, 23)
        Me.listaSociosBtn.TabIndex = 1
        Me.listaSociosBtn.Text = "Lista de Socio"
        Me.listaSociosBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IdSocioTxt
        '
        Me.IdSocioTxt.Location = New System.Drawing.Point(16, 88)
        Me.IdSocioTxt.Name = "IdSocioTxt"
        Me.IdSocioTxt.Size = New System.Drawing.Size(32, 20)
        Me.IdSocioTxt.TabIndex = 11
        Me.IdSocioTxt.Text = "0"
        Me.IdSocioTxt.Visible = False
        '
        'lbMontoAporteDisponible
        '
        Me.lbMontoAporteDisponible.Location = New System.Drawing.Point(391, 112)
        Me.lbMontoAporteDisponible.Name = "lbMontoAporteDisponible"
        Me.lbMontoAporteDisponible.Size = New System.Drawing.Size(120, 23)
        Me.lbMontoAporteDisponible.TabIndex = 16
        Me.lbMontoAporteDisponible.Text = "Total Aporte Disponible:"
        Me.lbMontoAporteDisponible.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalAporteDisponible
        '
        Me.txtTotalAporteDisponible.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalAporteDisponible.Enabled = False
        Me.txtTotalAporteDisponible.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAporteDisponible.Location = New System.Drawing.Point(517, 112)
        Me.txtTotalAporteDisponible.Name = "txtTotalAporteDisponible"
        Me.txtTotalAporteDisponible.Size = New System.Drawing.Size(120, 29)
        Me.txtTotalAporteDisponible.TabIndex = 17
        Me.txtTotalAporteDisponible.Text = "0.00"
        Me.txtTotalAporteDisponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpFechaRetiro
        '
        Me.dtpFechaRetiro.CustomFormat = "dd / MMM /yyyy"
        Me.dtpFechaRetiro.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaRetiro.Location = New System.Drawing.Point(101, 39)
        Me.dtpFechaRetiro.Name = "dtpFechaRetiro"
        Me.dtpFechaRetiro.Size = New System.Drawing.Size(120, 20)
        Me.dtpFechaRetiro.TabIndex = 77
        '
        'lblFechaRecibo
        '
        Me.lblFechaRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblFechaRecibo.Location = New System.Drawing.Point(2, 40)
        Me.lblFechaRecibo.Name = "lblFechaRecibo"
        Me.lblFechaRecibo.Size = New System.Drawing.Size(98, 16)
        Me.lblFechaRecibo.TabIndex = 78
        Me.lblFechaRecibo.Text = "Fecha Retiro:"
        Me.lblFechaRecibo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmRetiroAporteSocio
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(650, 284)
        Me.Controls.Add(Me.dtpFechaRetiro)
        Me.Controls.Add(Me.lblFechaRecibo)
        Me.Controls.Add(Me.txtTotalAporteDisponible)
        Me.Controls.Add(Me.lbMontoAporteDisponible)
        Me.Controls.Add(Me.IdSocioTxt)
        Me.Controls.Add(Me.listaSociosBtn)
        Me.Controls.Add(Me.cmbCajas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.imprimirBtn)
        Me.Controls.Add(Me.idDocTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.conceptoTxt)
        Me.Controls.Add(Me.montoTxt)
        Me.Controls.Add(Me.socioTxt)
        Me.Controls.Add(Me.nuevoBtn)
        Me.Controls.Add(Me.cerrarBtn)
        Me.Controls.Add(Me.guardarBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRetiroAporteSocio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retiro Aporte de Socio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region



    Private Sub frmRetiroAporteSocio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon

        '' Verificar permiso de usuario
        If SCALAR_STRING("SELECT CambiarFechaRetiroAporte FROM tbl_userahorros WHERE IDUsuario=" & CInt(User(5)) & "") <> "" Then
            Dim CambiarFechaDeposito As Boolean = SCALAR_STRING("SELECT CambiarFechaRetiroAporte FROM tbl_userahorros WHERE IDUsuario=" & CInt(User(5)) & "")
            dtpFechaRetiro.Enabled = CambiarFechaDeposito
        Else
            dtpFechaRetiro.Enabled = False
        End If


        LlenarCajas()

    End Sub


    Private Sub CargarMontoAporteDisp(ByVal idCliente As Integer)
        Dim aportacion As Decimal = SCALAR_NUM("SELECT IFNULL(SUM(Monto),0) AS monto FROM tbl_ahorros_aportacion WHERE IDSocio=" & idCliente & ";")
        Dim retiroaportacion As Decimal = SCALAR_NUM("SELECT IFNULL(SUM(Monto),0) AS monto FROM tbl_retiro_ahorros_aportacion WHERE IDSocio=" & idCliente & ";")
        txtTotalAporteDisponible.Text = Format(aportacion - retiroaportacion, "N2")

    End Sub


    Private Sub LlenarCajas()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT Id, Descripcion FROM cajamantenimiento ORDER BY Orden, Descripcion", conn)
        da.Fill(dt)

        cmbCajas.DataSource = dt
        cmbCajas.DisplayMember = "Descripcion"
        cmbCajas.ValueMember = "Id"
        da.Dispose()



    End Sub
    Private Function validarDatos() As Boolean
        If SCALAR_NUM("SELECT IFNULL(1,0) FROM  tbl_interfascontabletipotrans_conf WHERE Frm='" & Me.Text & "'") = 0 Then
            Alerta("El Interfas contable no está configurado, no se puede guardar el documento.")
            Return False
        End If
        If cmbCajas.SelectedIndex.Equals(-1) Then
            Alerta("Debe seleccionar una caja")
            cmbCajas.Focus()
            Return False
        ElseIf IdSocioTxt.Text = String.Empty Or socioTxt.Text = String.Empty Then
            Alerta("Debe buscar los datos del socio")
            socioTxt.Focus()
            Return False
        ElseIf CDbl(montoTxt.Text) <= 0 Then
            Alerta("Escriba el monto del aporte por favor")
            montoTxt.Focus()
            Return False
        ElseIf conceptoTxt.Text = String.Empty Then
            Alerta("Escriba el concepto por favor")
            conceptoTxt.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub listaSociosBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listaSociosBtn.Click
        If FRMS_POPUP_CLIENTES("TODOS") = True Then
            READER("SELECT fld_id, fld_FullName FROM tbl_clientes WHERE fld_id=" & Id & "")
            If reader_values.Length > 0 Then
                IdSocioTxt.Text = reader_values(0)
                socioTxt.Text = reader_values(1)
            End If
            montoTxt.Focus()
            CargarMontoAporteDisp(IdSocioTxt.Text)
        End If
    End Sub

    Private Sub nuevoBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevoBtn.Click
        cmbCajas.SelectedValue = -1
        IdSocioTxt.Text = String.Empty
        socioTxt.Text = String.Empty
        montoTxt.Text = "0.00"
        txtTotalAporteDisponible.Text = "0.00"
        conceptoTxt.Text = String.Empty
    End Sub
    Private Function guardarDatos() As Integer
        NON_QUERY("INSERT INTO tbl_retiro_ahorros_aportacion (IDSocio, Fecha, Monto, Concepto, IdCaja) VALUES	(" & CInt(IdSocioTxt.Text) & ", '" & Format(dtpFechaRetiro.Value, "yyyy-MM-dd") & "', " & CDbl(montoTxt.Text) & ", '" & conceptoTxt.Text & "'," & cmbCajas.SelectedValue & ");")

        Return SCALAR_NUM("SELECT MAX(ID) FROM tbl_retiro_ahorros_aportacion")
    End Function
    Private Sub guardarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardarBtn.Click
        If validarDatos() = False Then Exit Sub

        Dim ctaContableCaja = SCALAR_STRING("SELECT CtaContable  FROM cajamantenimiento WHERE ID=" & cmbCajas.SelectedValue & "")
        Dim idTipoTrans = SCALAR_NUM("SELECT IdTipo FROM  tbl_interfascontabletipotrans_conf WHERE Frm='" & Me.Text & "'")
        Dim nombreCta = ReturnDescripcion(ctaContableCaja)
        Dim fecha As Date = Format(dtpFechaRetiro.Value, "yyyy-MM-dd") ''CDate(SCALAR_STRING("SELECT Now()"))
        Dim idTran = CargarFrmInterfas(ctaContableCaja, nombreCta, 0, montoTxt.Text, 0, "Retiro Aportacion de Socio", conceptoTxt.Text, fecha.Date, idTipoTrans)

        If idTran > 0 Then
            Dim idDoc = guardarDatos()
            NON_QUERY("UPDATE tbl_interfascontabletransacciones SET TransIDDoc=" & idDoc & " WHERE TransID=" & idTran & "")
            If CBool(SCALAR_NUM("SELECT VistaPreviaImpresion FROM parametrosgenerales WHERE ID=1")) = True Then
                'Id = Id
                Id = idDoc
                AllReportSinFecha("Retiro Recibo Aporte")
                'Me.Close()
            Else
                imprimirDocumento(idDoc)
            End If

        Else
            Alerta("La operación ha sido cancelada")
            Return
        End If

        nuevoBtn_Click(sender, e)
    End Sub
    Private Sub imprimirDocumento(ByVal idDoc As Integer)
        PrintDialog1.AllowSomePages = True
        PrintDialog1.ShowHelp = True
        PrintDialog1.Document = docToPrint


        Dim pd As New PrintDocument, strOldPrinter As String
        strOldPrinter = pd.PrinterSettings.PrinterName 'Get the Default Print 


        Dim WshNetwork As Object
        WshNetwork = Microsoft.VisualBasic.CreateObject("WScript.Network")

        'Dim TamañoPersonal = New Printing.PaperSize(PrintDialog1.PrinterSettings.PrinterName, 8.5, 5.5)
        'PrintDialog1.PrinterSettings.DefaultPageSettings.PaperSize = TamañoPersonal
        Dim result As DialogResult = PrintDialog1.ShowDialog()

        ' If the result is OK then print the document.
        If (result = Windows.Forms.DialogResult.OK) Then
            WshNetwork.SetDefaultPrinter(PrintDialog1.PrinterSettings.PrinterName) 'Set the Default Print 
            Dim ds As New DataSet

            Dim daProf As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daProf.Fill(ds, "tbl_profiledocument")

            Dim daInv As New MySqlDataAdapter("SELECT aa.ID AS ahoid, aa.Fecha AS ahofecha, cl.fld_Identity AS clicedula, cl.fld_FullName AS clinombre, aa.Monto AS ahomonto, cl.fld_id AS clicod, cl.fld_apodo AS cliapodo, cl.fld_Address AS clidireccion, cl.fld_City AS cliciudad, aa.Concepto AS ahoconcepto, mc.CtaContable AS cajactacontable, mc.Descripcion AS cajanombre FROM tbl_clientes AS cl INNER JOIN tbl_retiro_ahorros_aportacion AS aa ON aa.IDSocio = cl.fld_id INNER JOIN cajamantenimiento AS mc ON aa.IDCaja = mc.ID WHERE aa.ID=" & idDoc & " ", conn)
            daInv.Fill(ds, "ahorroAportacion")


            Dim Report As New rptAporteSocioRecibo
            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PrinterName = PrintDialog1.PrinterSettings.PrinterName
            Report.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, True, 0, 0)


        End If
        WshNetwork.SetDefaultPrinter(strOldPrinter) 'Get the Default Print
    End Sub
    Private Sub imprimirBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imprimirBtn.Click
        Dim f As New frmRetiroAporteSocioLista
        f.ShowDialog()
        If f.Text = "ACEPTAR" Then
            If CBool(SCALAR_NUM("SELECT VistaPreviaImpresion FROM parametrosgenerales WHERE ID=1")) = True Then
                Id = Id
                AllReportSinFecha("Retiro Recibo Aporte")
                Me.Close()
            Else
                imprimirDocumento(Id)

            End If

        End If
        f.Dispose()
    End Sub

    Private Sub cerrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cerrarBtn.Click
        Me.Close()
    End Sub

    Private Sub montoTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles montoTxt.TextChanged

    End Sub

    Private Sub montoTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles montoTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(13) Then
            Dim amount As Decimal = CType(montoTxt.Text, Decimal)
            Me.montoTxt.Text = String.Format("{0:n2}", amount)
            conceptoTxt.Focus()
        End If
    End Sub

    Private Sub frmRetiroAporteSocio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub


End Class
