Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.Odbc

Public Class FRM_REPORTS
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
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
    Friend WithEvents CrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_REPORTS))
        Me.CrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer
        '
        Me.CrystalReportViewer.ActiveViewIndex = -1
        Me.CrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer.Name = "CrystalReportViewer"
        Me.CrystalReportViewer.ShowGroupTreeButton = False
        Me.CrystalReportViewer.Size = New System.Drawing.Size(777, 437)
        Me.CrystalReportViewer.TabIndex = 0
        Me.CrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(777, 437)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(777, 56)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Aplicación para demostración"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Visible = False
        '
        'FRM_REPORTS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(777, 437)
        Me.Controls.Add(Me.CrystalReportViewer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_REPORTS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_REPORTS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim crReportDocument As ReportDocument
    Dim crExportOptions As ExportOptions
    Dim crDiskFileDestinationOptions As DiskFileDestinationOptions
    Friend idSocio As Integer
    Friend idDoc As Integer

    Dim paramFields As New ParameterFields
    Dim paramField As New ParameterField
    Dim discreteVal As New ParameterDiscreteValue
    Dim objIniFile_cont As New IniFile(AppPath & "\Settings_Contabilidad.ini")
    Dim porciento As Double = 0 '/INI FILE

    Private Sub FRM_REPORTS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon

        Dim fechaServidor As Date = SCALAR_STRING("SELECT NOW()")
        Dim show As New FrmPopupMessage
        show.Show("Generando Reporte... Por favor espere")

        If ReportName = "SOLICITUD DE CREDITO" Then
            Dim ds1 As New DataSet

            Dim Report1 As New rptSolicitudCredito

            Dim daProf As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daProf.Fill(ds1, "tbl_profiledocument")
            Dim dr As DataRow



            Dim daSolicitud As New MySqlDataAdapter("SELECT * FROM solicitudcredito WHERE Id = " & idDoc & "", conn)
            daSolicitud.Fill(ds1, "solicitudcredito")

            Dim daSocio As New MySqlDataAdapter("SELECT * FROM solicitudcreditocliente WHERE fld_id = " & idSocio & "", conn)
            daSocio.Fill(ds1, "solicitudcreditocliente")


            'For Each dr In ds1.Tables(1).Rows
            '    Dim largo = Len(CStr(Format(CDbl(dr("Monto")), "##,###.00")))
            '    Dim decimales = Mid(CStr(Format(CDbl(dr("Monto")), "##,###.00")), largo - 2)
            '    dr("fld_nombre_banco2") = "SOLO " & Num2Text(dr("Monto") - decimales) & " CON " & Mid(decimales, Len(decimales) - 1).ToUpper & " / 100" & " "
            '    Exit For
            'Next


            Report1.Database.Tables(0).SetDataSource(ds1)
            Report1.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report1
            CrystalReportViewer.DisplayGroupTree = False
            CrystalReportViewer.ShowGroupTreeButton = False

            Me.Text = "CUENTA DE AHORROS"

        ElseIf ReportName = "CUENTA DE AHORRO" Then
            Dim ds1 As New DataSet

            Dim Report1 As New RPT_CUENTA_AHORRO

            Dim daProf As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daProf.Fill(ds1, "tbl_profiledocument")
            Dim dr As DataRow



            Dim daInv As New MySqlDataAdapter("SELECT * FROM view_ahorros WHERE ID = " & Id & "", conn)
            daInv.Fill(ds1, "view_ahorros")

            For Each dr In ds1.Tables(1).Rows
                Dim largo = Len(CStr(Format(CDbl(dr("Monto")), "##,###.00")))
                Dim decimales = Mid(CStr(Format(CDbl(dr("Monto")), "##,###.00")), largo - 2)
                dr("fld_nombre_banco2") = "SOLO " & Num2Text(dr("Monto") - decimales) & " CON " & Mid(decimales, Len(decimales) - 1).ToUpper & " / 100" & " "
                Exit For
            Next


            Report1.Database.Tables(0).SetDataSource(ds1)
            Report1.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report1
            CrystalReportViewer.DisplayGroupTree = False
            CrystalReportViewer.ShowGroupTreeButton = False

            Me.Text = "CUENTA DE AHORROS"
        ElseIf ReportName = "Recibo de Prestamos" Then
            Dim ds As New DataSet

            Dim Report1 As New RPT_RECIBO_PRESTAMO

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")

            Dim daP1 As New MySqlDataAdapter("SELECT * FROM view_clientes_con_prestamos WHERE fld_id_prestamos=" & Id & "", conn)
            daP1.Fill(ds, "view_clientes_con_prestamos")


            Report1.Database.Tables(0).SetDataSource(ds)
            Report1.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report1
            CrystalReportViewer.DisplayGroupTree = False
            CrystalReportViewer.ShowGroupTreeButton = False

            Me.Text = ReportName
        ElseIf ReportName = "Listado de Saldos" Then
            Dim ds As New DataSet

            Dim Report1 As New rptSaldos


            Dim daProf As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daProf.Fill(ds, "tbl_profiledocument")



            'Dim daInv As New MySqlDataAdapter("SELECT * FROM view_ahorros", conn)
            Dim daInv As New MySqlDataAdapter("SELECT * FROM view_ahorros WHERE estado='ACTIVA' ORDER BY fld_FullName ASC", conn)
            daInv.Fill(ds, "view_ahorros")

            Dim dr As DataRow
            Dim capitalAhorrado As Double, capitalRetirado As Double
            Dim dtpUltimoRetiro As Date, DiasAcumulados As Integer

            For Each dr In ds.Tables(1).Rows
                '   "Select IDCliente, Fecha, Id, Concepto, 0, monto, 0 FROM tbl_ahorros_retiros WHERE IDCliente=" & IDCliente & "" SELECT IDCliente,Fecha,ID,Notas,Monto,0,0 FROM tbl_ahorros_depositos WHERE IDCliente=
                dr("SaldoRetiros") = SCALAR_NUM("Select IFNULL(SUM(Monto),0) As monto FROM tbl_ahorros_retiros WHERE IDCliente=" & dr("IDCliente") & " and " & dr("IDAhorro") & "")
                dr("SaldoCapital") = SCALAR_NUM("Select IFNULL(SUM(Monto),0) As monto FROM tbl_ahorros_depositos WHERE IDCliente=" & dr("IDCliente") & " and " & dr("IDCuenta") & "")
            Next

            Report1.Database.Tables(0).SetDataSource(ds)
            Report1.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report1
            'CrystalReportViewer.DisplayGroupTree = True
            'CrystalReportViewer.ShowGroupTreeButton = True

            Me.Text = "Listado de Saldos"

            ' Listado Tipos de Ahorros
        ElseIf ReportName = "Listado por Tipo de Ahorros" Then
            Dim ds As New DataSet

            Dim Report1 As New rptSaldos
            Try

                Dim daProf As New MySqlDataAdapter("Select * FROM tbl_profiledocument", conn)
                daProf.Fill(ds, "tbl_profiledocument")



                Dim daInv As New MySqlDataAdapter("Select * FROM view_ahorros where descripcion='" & Filtro & "'", conn)
                daInv.Fill(ds, "view_ahorros")

                Dim dr As DataRow
                'Dim capitalAhorrado As Double, capitalRetirado As Double
                'Dim dtpUltimoRetiro As Date, DiasAcumulados As Integer

                For Each dr In ds.Tables(1).Rows
                    '   "SELECT IDCliente,Fecha, ID, Concepto, 0,Monto,0 FROM tbl_ahorros_retiros WHERE IDCliente=" & IDCliente & "" SELECT IDCliente,Fecha,ID,Notas,Monto,0,0 FROM tbl_ahorros_depositos WHERE IDCliente=
                    dr("SaldoRetiros") = SCALAR_NUM("SELECT IFNULL(SUM(Monto),0) AS monto FROM tbl_ahorros_retiros WHERE IDCliente=" & dr("IDCliente") & "")
                    dr("SaldoCapital") = SCALAR_NUM("SELECT IFNULL(SUM(Monto),0) AS monto FROM tbl_ahorros_depositos WHERE IDCliente=" & dr("IDCliente") & "")
                Next

                Report1.Database.Tables(0).SetDataSource(ds)
                Report1.PrintOptions.PaperSize = PaperSize.PaperLetter
                CrystalReportViewer.ReportSource = Report1
                CrystalReportViewer.DisplayGroupTree = True
                CrystalReportViewer.ShowGroupTreeButton = True
            Catch ex As Exception
            Finally
                CloseConn()
            End Try
            Me.Text = "Listado de  Tipos de Cuentas"
            '------------------------------------------------
            'Listado de Ahorro Por Socio
        ElseIf ReportName = "Listado de  Ahorros por socios" Then
            Dim ds As New DataSet

            Dim Report1 As New rptSaldos

            Try
                Dim daProf As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
                daProf.Fill(ds, "tbl_profiledocument")



                Dim daInv As New MySqlDataAdapter("SELECT * FROM view_ahorros where IDCLIENTE=" & Id & " ", conn)
                daInv.Fill(ds, "view_ahorros")

                Dim dr As DataRow
                'Dim capitalAhorrado As Double, capitalRetirado As Double
                'Dim dtpUltimoRetiro As Date, DiasAcumulados As Integer

                For Each dr In ds.Tables(1).Rows
                    '   "SELECT IDCliente,Fecha, ID, Concepto, 0,Monto,0 FROM tbl_ahorros_retiros WHERE IDCliente=" & IDCliente & "" SELECT IDCliente,Fecha,ID,Notas,Monto,0,0 FROM tbl_ahorros_depositos WHERE IDCliente=
                    dr("SaldoRetiros") = SCALAR_NUM("SELECT IFNULL(SUM(Monto),0) AS monto FROM tbl_ahorros_retiros WHERE IDCliente=" & dr("IDCliente") & "")
                    dr("SaldoCapital") = SCALAR_NUM("SELECT IFNULL(SUM(Monto),0) AS monto FROM tbl_ahorros_depositos WHERE IDCliente=" & dr("IDCliente") & "")
                Next

                Report1.Database.Tables(0).SetDataSource(ds)
                Report1.PrintOptions.PaperSize = PaperSize.PaperLetter
                CrystalReportViewer.ReportSource = Report1
                CrystalReportViewer.DisplayGroupTree = True
                CrystalReportViewer.ShowGroupTreeButton = True
            Catch ex As Exception
            Finally
                CloseConn()
            End Try


            Me.Text = "Listado de  Ahorros por socioListado de  Tipos de Cuentas"
            '------------------------------------------------

        ElseIf ReportName = "Listado de Retiros" Then
            Dim ds As New DataSet

            Dim Report1 As New rptRetiros


            Dim daProf As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daProf.Fill(ds, "tbl_profiledocument")
            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = "Desde " & fecha1 & " hasta " & fecha2
                Exit For
            Next
            Dim daInv As New MySqlDataAdapter("SELECT * FROM view_ahorros_retiros WHERE DATE(Fecha) >='" & fecha1 & "' AND DATE(Fecha) <='" & fecha2 & "' ", conn)
            daInv.Fill(ds, "view_ahorros_retiros")


            Report1.Database.Tables(0).SetDataSource(ds)
            Report1.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report1
            CrystalReportViewer.DisplayGroupTree = True
            CrystalReportViewer.ShowGroupTreeButton = True

            Me.Text = "Listado de Retiros"
        ElseIf ReportName = "Listado de Depósitos/Ahorros" Then
            Dim ds As New DataSet

            Dim Report1 As New rptDepositosListado


            Dim daProf As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daProf.Fill(ds, "tbl_profiledocument")
            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = "Desde " & fecha1 & " hasta " & fecha2
                Exit For
            Next
            Dim daInv As New MySqlDataAdapter("SELECT * FROM view_ahorros_depositos WHERE DATE(Fecha) >='" & fecha1 & "' AND DATE(Fecha) <='" & fecha2 & "' ", conn)
            daInv.Fill(ds, "view_ahorros_depositos")


            Report1.Database.Tables(0).SetDataSource(ds)
            Report1.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report1
            CrystalReportViewer.DisplayGroupTree = True
            CrystalReportViewer.ShowGroupTreeButton = True

            Me.Text = "Listado de Depósitos/Ahorros"


        ElseIf ReportName = "ESTADO_CUENTA_AHORROS" Then
            Dim Report As New rptEstadoCuenta

            Dim ds As New DataSet
            ds.Clear()

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")

            Dim dr As DataRow


            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = fecha_rango
                dr("fldNotaRecepcion") = ParametroReporte
            Next



            Dim daP1 As New MySqlDataAdapter("SELECT * FROM tbl_ahorros_estados WHERE IDCliente=" & CInt(Id) & " AND DATE(Fecha) >='" & fecha1 & "'  AND DATE(Fecha) <= '" & fecha2 & "' ORDER BY Fecha, ID DESC", conn)
            daP1.Fill(ds, "tbl_ahorros_estados")

            Dim daCliente As New MySqlDataAdapter("SELECT * FROM tbl_clientes WHERE fld_id=" & CInt(Id) & "", conn)
            daCliente.Fill(ds, "tbl_clientes")

            Dim BceAnt As Double = SCALAR_NUM("SELECT IFNULL(SUM(Ahorro)-SUM(Retiro),0) FROM tbl_ahorros_estados WHERE IDCliente=" & CInt(Id) & " AND DATE(Fecha) < '" & fecha1 & "' GROUP BY IDCliente")

            Dim Bce As Decimal = BceAnt

            For Each dr In ds.Tables(1).Rows
                Bce = Bce + dr("Ahorro") - dr("Retiro")
                dr("Saldo") = Bce
            Next

            For Each dr In ds.Tables(2).Rows
                dr("fld_bce") = BceAnt
                Exit For
            Next
            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = False
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = "ESTADO DE CUENTA AHORROS"
        ElseIf ReportName = "Listado de Aportes de Socios" Then
            Dim ds As New DataSet

            Dim Report1 As New rptAporteSocioListado


            Dim daProf As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daProf.Fill(ds, "tbl_profiledocument")

            Dim daInv As New MySqlDataAdapter("SELECT aa.ID AS ahoid, aa.Fecha AS ahofecha, cl.fld_Identity AS clicedula, cl.fld_FullName AS clinombre, SUM(aa.Monto) AS ahomonto, cl.fld_id AS clicod, cl.fld_apodo AS cliapodo, cl.fld_Address AS clidireccion, cl.fld_City AS cliciudad, aa.Concepto AS ahoconcepto, mc.CtaContable AS cajactacontable, mc.Descripcion AS cajanombre FROM tbl_clientes AS cl INNER JOIN tbl_ahorros_aportacion AS aa ON aa.IDSocio = cl.fld_id INNER JOIN cajamantenimiento AS mc ON aa.IDCaja = mc.ID GROUP BY cl.fld_id", conn)
            daInv.Fill(ds, "ahorroAportacion")


            Report1.Database.Tables(0).SetDataSource(ds)
            Report1.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report1
            CrystalReportViewer.DisplayGroupTree = True
            CrystalReportViewer.ShowGroupTreeButton = True

            Me.Text = ReportName
        ElseIf ReportName = "Listado de Aportes de un Socio" Then
            Dim ds As New DataSet

            Dim Report1 As New rptAporteUnSocioListado


            Dim daProf As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daProf.Fill(ds, "tbl_profiledocument")

            Dim daInv As New MySqlDataAdapter("SELECT aa.ID AS ahoid, aa.Fecha AS ahofecha, cl.fld_Identity AS clicedula, cl.fld_FullName AS clinombre, aa.Monto AS ahomonto, cl.fld_id AS clicod, cl.fld_apodo AS cliapodo, cl.fld_Address AS clidireccion, cl.fld_City AS cliciudad, aa.Concepto AS ahoconcepto, mc.CtaContable AS cajactacontable, mc.Descripcion AS cajanombre FROM tbl_clientes AS cl INNER JOIN tbl_ahorros_aportacion AS aa ON aa.IDSocio = cl.fld_id INNER JOIN cajamantenimiento AS mc ON aa.IDCaja = mc.ID WHERE cl.fld_id=" & Id & "", conn)
            daInv.Fill(ds, "ahorroAportacion")


            Report1.Database.Tables(0).SetDataSource(ds)
            Report1.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report1
            CrystalReportViewer.DisplayGroupTree = True
            CrystalReportViewer.ShowGroupTreeButton = True

            Me.Text = ReportName
        ElseIf ReportName = "Listado de Certificados de Socios" Then
            Dim ds As New DataSet

            Dim Report1 As New rptCertificadoListado


            Dim daProf As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daProf.Fill(ds, "tbl_profiledocument")

            Dim daInv As New MySqlDataAdapter("SELECT ac.ID AS certificadoID, cl.fld_id AS clienteID, cl.fld_Identity AS clienteCedula, cl.fld_FullName AS clienteNombre, ac.CuentaNo AS certificadoCuenta, ac.FechaApertura AS certificadoFechaApertura, ac.Tiempo AS certificadoTiempo, ac.SaldoCapital AS certificadoMonto, ac.TasaIteres AS certificadoInteres FROM tbl_ahorros_certificado AS ac INNER JOIN tbl_clientes AS cl ON ac.IDCliente=cl.fld_id WHERE ac.FechaApertura BETWEEN '" & fecha1 & "' AND '" & fecha2 & "'", conn)
            daInv.Fill(ds, "certificados")


            Report1.Database.Tables(0).SetDataSource(ds)
            Report1.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report1
            CrystalReportViewer.DisplayGroupTree = True
            CrystalReportViewer.ShowGroupTreeButton = True

            Me.Text = "Listado de Certificados de Socios"
        ElseIf ReportName = "CUADRE DE CAJA" Then
            Dim ds1 As New DataSet

            Dim Report1 As New RTP_CUADRE_CAJA

            Dim daProf As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daProf.Fill(ds1, "tbl_profiledocument")
            Dim dr As DataRow

            Dim daInv As New MySqlDataAdapter("SELECT * FROM tbl_cuadre", conn)
            daInv.Fill(ds1, "tbl_cuadre")

            Dim daInv1 As New MySqlDataAdapter("SELECT * FROM tbl_cuadre_detalle", conn)
            daInv1.Fill(ds1, "tbl_cuadre_detalle")



            Report1.Database.Tables(0).SetDataSource(ds1)
            Report1.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report1
            CrystalReportViewer.DisplayGroupTree = False
            CrystalReportViewer.ShowGroupTreeButton = False

            Me.Text = "CUADRE DE CAJA GENERAL"

        ElseIf ReportName = "ESTADO_CUENTA_CLIENTE" Then
            Dim Report As New RPT_ESTADO_CLIENTE
            Dim ds As New DataSet
            ds.Clear()

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")
            Dim dr As DataRow
            Dim capitalAhorrado As Double = 0
            Dim capitalRetirado As Double = 0
            capitalAhorrado = SCALAR_NUM("SELECT IFNULL(SUM(Monto),0) FROM tbl_ahorros_depositos WHERE IDCliente=" & CInt(Id) & "")
            capitalRetirado = SCALAR_NUM("SELECT IFNULL(SUM(Monto),0) FROM tbl_ahorros_retiros WHERE IDCliente=" & CInt(Id) & " AND Tipo <> 'Retiro de Interes'")

            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = fecha_rango
                dr("fldRnc") = Format(capitalAhorrado - capitalRetirado, "##,##0.00")
            Next

            Dim daP1 As New MySqlDataAdapter("SELECT * FROM view_estado_clientes WHERE fld_cliente_id=" & CInt(Id) & " AND DATE(fld_date) >='" & fecha1 & "'  AND DATE(fld_date) <= '" & fecha2 & "' ORDER BY fld_date", conn)
            daP1.Fill(ds, "view_estado_clientes")

            Dim BceAnt As Double = SCALAR_NUM("SELECT IFNULL(SUM(fld_dr)-SUM(fld_cr),0) FROM view_estado_clientes WHERE fld_cliente_id=" & CInt(Id) & " AND DATE(fld_date) < '" & fecha1 & "' GROUP BY fld_date")

            Dim Bce As Decimal = BceAnt

            For Each dr In ds.Tables(1).Rows
                dr("fld_bce") = BceAnt

                Bce = Bce + dr("fld_dr") - dr("fld_cr")
                dr("fld_bce_cliente") = Bce
            Next

            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = False
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = "ESTADO DE CUENTA CLIENTES"
        ElseIf ReportName = "LISTADO DE PROVEEDORES" Then
            Dim Report As New RPT_LISTADO_PROVEEDORES
            Dim ds As New DataSet
            ds.Clear()

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")

            Dim daP1 As New MySqlDataAdapter("SELECT * FROM tbl_supplier ORDER BY fldCompany", conn)
            daP1.Fill(ds, "tbl_supplier")


            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = True
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = "LISTADO DE PROVEEDORES"
        ElseIf ReportName = "CUENTAxPAGAR" Then
            Dim Report As New RPT_CUENTAxPAGAR
            Dim ds As New DataSet
            ds.Clear()

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")

            Dim daP1 As New MySqlDataAdapter("SELECT * FROM tbl_supplier  WHERE fldBalance " & Id, conn)
            daP1.Fill(ds, "tbl_supplier")
            Dim dr As DataRow


            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = True
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = "CUENTA POR PAGAR"
        ElseIf ReportName = "LISTA_ND_CXP" Then
            Dim Report As New RPT_LISTA_ND_CXP
            Dim ds As New DataSet
            ds.Clear()

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")

            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = fecha_rango
            Next

            Dim daP1 As New MySqlDataAdapter("SELECT * FROM view_nota_debito_cxp WHERE fld_fecha >= '" & fecha1 & "' AND fld_fecha <='" & fecha2 & "'", conn)
            daP1.Fill(ds, "view_nota_debito_cxp")

            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = True
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = "LISTADO DE NOTA DE DEBITO"
        ElseIf ReportName = "LISTA_NC_CXP" Then
            Dim Report As New RPT_LISTA_NC_CXP
            Dim ds As New DataSet
            ds.Clear()

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")

            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = fecha_rango
            Next

            Dim daP1 As New MySqlDataAdapter("SELECT * FROM view_nota_credito_cxp WHERE fld_fecha >= '" & fecha1 & "' AND fld_fecha <='" & fecha2 & "'", conn)
            daP1.Fill(ds, "view_nota_credito_cxp")

            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = True
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = "LISTADO DE NOTA DE CREDITO"
        ElseIf ReportName = "ESTADO_CUENTA_PROVEEDOR" Then
            Dim Report As New RPT_ESTADO_PROVEEDOR
            Dim ds As New DataSet
            ds.Clear()
            Dim dr As DataRow
            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")

            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = fecha_rango
            Next

            Dim daP1 As New MySqlDataAdapter("SELECT * FROM view_estado_proveedor WHERE fldSupplierID=" & Id & " AND DATE(fld_date) >='" & fecha1 & "'  AND DATE(fld_date) <= '" & fecha2 & "'  ORDER BY fld_id_ec_p", conn)
            daP1.Fill(ds, "view_estado_proveedor")


            Dim BceAnt As Double = SCALAR_NUM("SELECT IFNULL(SUM(fld_cr)-SUM(fld_dr),0) FROM view_estado_proveedor WHERE fldSupplierID=" & CInt(Id) & " AND DATE(fld_date) < '" & fecha1 & "' GROUP BY fldSupplierID")

            Dim Bce As Decimal = BceAnt


            For Each dr In ds.Tables(1).Rows
                dr("fldbalance") = BceAnt
                Bce = Bce + dr("fld_cr") - dr("fld_dr")
                dr("fld_bce_proveedor") = Bce

            Next


            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = False
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = "ESTADO DE CUENTA PROVEEDOR"
        ElseIf ReportName = "CUENTAxCOBRAR" Then
            Dim Report As New RPT_LISTADO_CLIENTES
            Dim ds As New DataSet
            ds.Clear()

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")

            Dim daP1 As New MySqlDataAdapter("SELECT * FROM tbl_clientes WHERE fld_bce > 0", conn)
            daP1.Fill(ds, "tbl_clientes")

            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = False
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = "CUENTA POR COBRAR"


        ElseIf ReportName = "CXC_TODOS" Then
            Try
                NON_QUERY("CALL bce_clientes();")
                Dim Report As New RPT_CXC_CLIENTES

                Dim ds As New DataSet
                ds.Clear()

                Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
                daP.Fill(ds, "tbl_profiledocument")
                Dim nr As DataRow
                For Each nr In ds.Tables(0).Rows
                    nr("fldColorForm") = "Hasta " & fecha2
                Next


                'Dim daP1 As New MySqlDataAdapter("SELECT * FROM tbl_clientes  WHERE fld_bce > 0 AND fld_cod_zona=" & Id & "", conn)
                Dim daP1 As New MySqlDataAdapter("SELECT * FROM tbl_clientes WHERE fld_bce > 0 AND fld_cod_zona=" & Id & " " & ParametroReporte, conn)

                daP1.Fill(ds, "tbl_clientes")


                Report.Database.Tables(0).SetDataSource(ds)

                Report.PrintOptions.PaperSize = PaperSize.PaperLetter
                CrystalReportViewer.ReportSource = Report
                CrystalReportViewer.DisplayGroupTree = True
                CrystalReportViewer.ShowGroupTreeButton = True
                CrystalReportViewer.RefreshReport()
                Me.Text = "Cuenta por Cobrar"
            Catch ex As Exception
                MsgBox(ex.Message)

            Finally

            End Try
        ElseIf ReportName = "INGRESOS DEVENGADOS" Then
            Dim Report As New RPT_INGRESOS_DEVENGADOS
            Dim ds As New DataSet
            ds.Clear()

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")
            Dim nr As DataRow

            For Each nr In ds.Tables(0).Rows
                nr("fldColorForm") = "Desde " & fecha1 & " Hasta " & fecha2
            Next

            Dim daP1 As New MySqlDataAdapter("SELECT * FROM view_cuotas_todas WHERE fld_fecha_termina_cuotas >='" & fecha1 & "' AND fld_fecha_termina_cuotas <='" & fecha2 & "' AND fld_tipo_cuotas <> 'ND' AND (fld_interes_cuota_balance > 0 OR fld_capital_cuota_balance > 0)", conn)
            daP1.Fill(ds, "view_cuotas_todas")

            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = True
            CrystalReportViewer.ShowGroupTreeButton = True
            Me.Text = "Cuenta por Cobrar de Capital e Interes"

        ElseIf ReportName = "CXC_TODOS_CUOTAS" Then

            Dim Report As New RPT_CUENTA_X_COBRAR
            Dim ds As New DataSet

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")

            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = "Hasta " & fecha2
                dr("fldDiasVenceFC") = ParametroReporte
            Next

            Dim daP1 As New MySqlDataAdapter("SELECT * FROM view_cuotas_todas WHERE fld_fecha_termina_cuotas <='" & fecha2 & "' AND fld_balance_cuotas > 0 AND fld_cod_zona=" & Id & " AND fld_tipo_cuotas <> 'ND' " & ParametroReporte, conn)
            daP1.Fill(ds, "view_cuotas_todas")

            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = True
            CrystalReportViewer.ShowGroupTreeButton = True
            Me.Text = "Cuenta por Cobrar de Capital e Interes"

        ElseIf ReportName = "CXC_CAPITAL" Then
            Dim Report As New RPT_CAPITAL_CXC
            Dim ds As New DataSet

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")

            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = "Hasta " & fecha2
                dr("fldDiasVenceFC") = ParametroReporte
            Next


            Dim daP1 As New MySqlDataAdapter("SELECT * FROM view_cuotas_todas WHERE fld_fecha_termina_cuotas <='" & fecha2 & "' AND fld_capital_cuota_balance > 0 AND fld_cod_zona=" & Id & " AND fld_tipo_cuotas <> 'ND' " & ParametroReporte, conn)
            daP1.Fill(ds, "view_cuotas_todas")

            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = True
            CrystalReportViewer.ShowGroupTreeButton = True
            Me.Text = "Cuenta por Cobrar de Capital"
        ElseIf ReportName = "CXC_INTERES" Then
            Dim Report As New RPT_INTERES_CXC
            Dim ds As New DataSet


            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")

            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = "Hasta " & fecha2
                dr("fldDiasVenceFC") = ParametroReporte
            Next
            Dim daP1 As New MySqlDataAdapter("SELECT * FROM view_cuotas_todas WHERE fld_fecha_termina_cuotas <='" & fecha2 & "' AND fld_interes_cuota_balance > 0  AND fld_cod_zona=" & Id & " AND fld_tipo_cuotas <> 'ND' " & ParametroReporte, conn)
            daP1.Fill(ds, "view_cuotas_todas")

            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = True
            CrystalReportViewer.ShowGroupTreeButton = True
            Me.Text = "Cuenta por Cobrar de Interes"

        ElseIf ReportName = "CLIENTES_SIN_PRESTAMOS" Then
            Dim Report As New RPT_LISTADO_CLIENTES
            Dim ds As New DataSet
            ds.Clear()

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")

            Dim daP1 As New MySqlDataAdapter("SELECT * FROM tbl_clientes WHERE fld_bce < 1", conn)
            daP1.Fill(ds, "tbl_clientes")

            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = False
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = "LISTADO DE CLIENTES SIN PRESTAMOS"
        ElseIf ReportName = "CLIENTES_TODOS" Then
            Dim Report As New RPT_LISTADO_CLIENTES
            Dim ds As New DataSet
            ds.Clear()

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")

            Dim daP1 As New MySqlDataAdapter("SELECT * FROM tbl_clientes", conn)
            daP1.Fill(ds, "tbl_clientes")

            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = False
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = "LISTADO DE TODOS LOS CLIENTES"


        ElseIf ReportName = "PRESTAMOS_PENDIENTES" Then
            Dim Report As New RPT_LISTADO_DE_PRESTAMOS
            Dim ds As New DataSet
            ds.Clear()

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")
            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = fecha_rango
            Next

            Dim daP1 As New MySqlDataAdapter("SELECT * FROM view_clientes_con_prestamos WHERE fld_Balance > 0 ", conn)
            daP1.Fill(ds, "view_clientes_con_prestamos")

            For Each dr In ds.Tables(1).Rows

                dr("fldPrecioMetro") = SCALAR_NUM("SELECT  SUM(fld_interes_cuota_balance) FROM tbl_cuotas WHERE fld_id_del_prestamo=" & DR("fld_id_prestamos") & "")
                dr("fldTazaMora") = SCALAR_NUM("SELECT SUM(fld_capital_cuota_balance) FROM tbl_cuotas WHERE fld_id_del_prestamo=" & DR("fld_id_prestamos") & "")
            Next

            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = False
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = "LISTADO DE PRESTAMOS PENDIENTES"


        ElseIf ReportName = "LISTA_ND_CXC" Then
            Dim Report As New RPT_ND_CXC_LISTA
            Dim ds As New DataSet
            ds.Clear()

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")

            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = fecha_rango
            Next

            Dim daP1 As New MySqlDataAdapter("SELECT * FROM view_cxc_nota_debito WHERE fld_fecha >= '" & fecha1 & "' AND fld_fecha <='" & fecha2 & "'", conn)
            daP1.Fill(ds, "view_cxc_nota_debito")

            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = False
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = "LISTADO DE NOTA DE DEBITO"
        ElseIf ReportName = "LISTA_NC_CXC" Then
            Dim Report As New RPT_NC_CXC_LISTA
            Dim ds As New DataSet
            ds.Clear()

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")

            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = fecha_rango
            Next

            Dim daP1 As New MySqlDataAdapter("SELECT * FROM view_cxc_nota_credito WHERE fld_fecha >= '" & fecha1 & "' AND fld_fecha <='" & fecha2 & "'", conn)
            daP1.Fill(ds, "view_cxc_nota_credito")

            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = False
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = "LISTADO DE NOTA DE CREDITO"
        ElseIf ReportName = "PRESTAMOS_SALDADOS" Then
            Dim Report As New RPT_LISTA_DE_PRESTAMOS_SALDOS
            Dim ds As New DataSet
            ds.Clear()

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")
            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = fecha_rango
            Next

            Dim daP1 As New MySqlDataAdapter("SELECT * FROM view_clientes_con_prestamos WHERE fld_fecha_ultimo_abono >= '" & fecha1 & "' AND fld_fecha_ultimo_abono <='" & fecha2 & "' and fld_Balance <= 0 ", conn)
            daP1.Fill(ds, "view_clientes_con_prestamos")

            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = False
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = "LISTADO DE PRESTAMOS SALDADOS"

        ElseIf ReportName = "PRESTAMOS_ENTREGADOS" Then
            Dim Report As New RPT_PRESTAMOS_ENTREGADOS
            Dim ds As New DataSet
            ds.Clear()

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")
            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = fecha_rango
            Next

            Dim daP1 As New MySqlDataAdapter("SELECT * FROM view_clientes_con_prestamos WHERE fld_fecha_entrega >= '" & fecha1 & "' AND fld_fecha_entrega <='" & fecha2 & "'", conn)
            daP1.Fill(ds, "view_clientes_con_prestamos")

            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = False
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = "LISTADO DE CLIENTES CON PRESTAMOS"
        ElseIf ReportName = "LIST_RECIBOS_EGRESOS" Then
            Dim Report As New RPT_LISTA_RECIBOS_EGRESOS
            Dim ds As New DataSet
            ds.Clear()

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")
            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = fecha_rango
            Next


            Dim sql As String = "SELECT re.fldIdDoc, re.fldFecha, re.fldEntregado, re.fldConcepto, re.fldMonto, mc.Descripcion FROM tbl_recibo_egresos AS re INNER JOIN cajamantenimiento AS mc ON re.IdCaja = mc.ID WHERE fldFecha >= '" & fecha1 & "' AND fldFecha <='" & fecha2 & "' AND mc.ID=" & Id & ""

            If Id = 0 Then 'todas las cajas
                sql = "SELECT re.fldIdDoc, re.fldFecha, re.fldEntregado, re.fldConcepto, re.fldMonto, mc.Descripcion FROM tbl_recibo_egresos AS re INNER JOIN cajamantenimiento AS mc ON re.IdCaja = mc.ID WHERE fldFecha >= '" & fecha1 & "' AND fldFecha <='" & fecha2 & "'"
            End If

            Dim daP1 As New MySqlDataAdapter(sql, conn)
            daP1.Fill(ds, "tbl_recibo_egresos")
            For Each dr In ds.Tables(1).Rows
                If Id = 0 Then
                    dr("Descripcion") = "TODAS"
                End If
            Next


            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = False
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = "LISTA DE RECIBOS EGRESOS DE CAJA"
        ElseIf ReportName = "LIST_RECIBOS_INGRESOS" Then
            Dim Report As New RPT_LISTA_RECIBOS_INGRESOS
            Dim ds As New DataSet
            ds.Clear()
            'LISTA_OTROS_INGRESOS_CAJA
            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")
            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = fecha_rango
            Next


            Dim sql As String = "SELECT ri.fld_Id_RI, ri.fld_id_cliente_ri, ri.fld_date, ri.fld_socio, ri.fld_concepto, ri.fld_monto, mc.Descripcion, ri.fld_interes_cobrado, ri.fld_capital_cobrado, ri.fld_mora_cobrada FROM tbl_recibo_ingresos_cxc AS ri INNER JOIN cajamantenimiento AS mc ON ri.IdCaja=mc.ID WHERE DATE(ri.fld_date) >= '" & fecha1 & "' AND DATE(ri.fld_date) <='" & fecha2 & "' AND mc.ID=" & Id & " AND fld_Estado <> 'NULO' AND ri.fld_id_cliente_ri > 0"

            If Id = 0 Then 'todas las cajas
                sql = "SELECT ri.fld_Id_RI, ri.fld_id_cliente_ri, ri.fld_date, ri.fld_socio, ri.fld_concepto, ri.fld_monto, mc.Descripcion, ri.fld_interes_cobrado, ri.fld_capital_cobrado, ri.fld_mora_cobrada FROM tbl_recibo_ingresos_cxc AS ri INNER JOIN cajamantenimiento AS mc ON ri.IdCaja=mc.ID WHERE DATE(ri.fld_date) >= '" & fecha1 & "' AND DATE(ri.fld_date) <='" & fecha2 & "' AND fld_Estado <> 'NULO' AND ri.fld_id_cliente_ri > 0"
            End If

            Dim daP1 As New MySqlDataAdapter(sql, conn)
            daP1.Fill(ds, "tbl_recibo_ingresos_cxc")
            For Each dr In ds.Tables(1).Rows
                If Id = 0 Then
                    dr("Descripcion") = "TODAS"
                End If
            Next


            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = False
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = "LISTA DE RECIBOS INGRESOS A CAJA"

        ElseIf ReportName = "LIST_RECIBOS_INGRESOS_NULO" Then
            Dim Report As New RPT_LISTA_RECIBOS_INGRESOS
            Dim ds As New DataSet
            ds.Clear()

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")
            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = fecha_rango
            Next
            Dim daP1 As New MySqlDataAdapter("SELECT * FROM view_ri_cxc WHERE DATE(fld_date) >= '" & fecha1 & "' AND DATE(fld_date) <='" & fecha2 & "' AND fld_Estado = 'NULO'", conn)
            daP1.Fill(ds, "view_ri_cxc")
            'Between '" & fecha1 & "' AND '" & fecha2 & "'
            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = False
            CrystalReportViewer.ShowGroupTreeButton = False

            Me.Text = "LISTA DE RECIBOS INGRESOS"
        ElseIf ReportName = "LISTADO DE OTROS INGRESOS" Then
            Dim Report As New rptOtrosIngresosLista
            Dim ds As New DataSet
            ds.Clear()

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")
            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = fecha_rango
            Next

            Dim sql As String = "SELECT ri.fld_Id_RI, ri.fld_date, ri.fld_socio, ri.fld_concepto, ri.fld_monto, mc.Descripcion FROM tbl_recibo_ingresos_cxc AS ri INNER JOIN cajamantenimiento AS mc ON ri.IdCaja=mc.ID WHERE DATE(ri.fld_date) >= '" & fecha1 & "' AND DATE(ri.fld_date) <='" & fecha2 & "' AND mc.ID=" & Id & ""

            If Id = 0 Then 'todas las cajas
                sql = "SELECT ri.fld_Id_RI, ri.fld_date, ri.fld_socio, ri.fld_concepto, ri.fld_monto, mc.Descripcion FROM tbl_recibo_ingresos_cxc AS ri INNER JOIN cajamantenimiento AS mc ON ri.IdCaja=mc.ID WHERE DATE(ri.fld_date) >= '" & fecha1 & "' AND DATE(ri.fld_date) <='" & fecha2 & "'"
            End If
            Dim daP1 As New MySqlDataAdapter(sql, conn)
            daP1.Fill(ds, "tbl_recibo_ingresos_cxc")
            For Each dr In ds.Tables(1).Rows
                If Id = 0 Then
                    dr("Descripcion") = "TODAS"
                End If
            Next


            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = False
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = ReportName
            'INICIO DE CONTABILIDAD
        ElseIf ReportName = "Catalogo de Cuentas Contable" Then
            Dim Report As New rptCatalogoCta
            Dim ds As New DataSet

            Dim dr As DataRow

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")

            Dim daP1 As New MySqlDataAdapter("SELECT * FROM view_cont_catalogo ORDER BY IDg, CuentaNo", conn)
            daP1.Fill(ds, "view_cont_catalogo")

            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = True
            CrystalReportViewer.ShowGroupTreeButton = True
            Me.Text = ReportName

        ElseIf ReportName = "ESTADO_CUENTA_BANCO" Then
            Dim Report As New RPT_ESTADO_BANCO
            Dim ds As New DataSet

            Dim dr As DataRow

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")

            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = fecha_rango
            Next

            Dim daP1 As New MySqlDataAdapter("SELECT * FROM view_estado_banco WHERE fld_banco_id='" & Id & "' AND DATE(fld_date) >= '" & fecha1 & "' AND DATE(fld_date) <= '" & fecha2 & "'", conn)
            daP1.Fill(ds, "view_estado_banco")

            Dim BceAnt As Double = SCALAR_NUM("SELECT IFNULL(SUM(fld_dr)-SUM(fld_cr),0) FROM tbl_estado_banco WHERE fld_banco_id='" & Id & "' AND DATE(fld_date) < '" & fecha1 & "' GROUP BY fld_banco_id")
            Dim Bce As Decimal = BceAnt

            For Each dr In ds.Tables(1).Rows
                dr("fld_balance") = BceAnt
                Bce = Bce + dr("fld_dr") - dr("fld_cr")
                dr("fld_bce_banco") = Bce
            Next

            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = False
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = "ESTADO DE CUENTA"
        ElseIf ReportName = "DEPOSITOS_TODOS" Then
            Dim Report As New RPT_DEPOSITOS
            Dim ds As New DataSet
            ds.Clear()

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")
            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = fecha_rango
            Next

            Dim SqlString As String
            If Estado = "TODOS" Then
                SqlString = "SELECT * FROM tbl_deposito WHERE fld_fecha Between '" & fecha1 & "' AND '" & fecha2 & "' AND fld_estado='N' "
            Else
                SqlString = "SELECT * FROM tbl_deposito WHERE fld_fecha Between '" & fecha1 & "' AND '" & fecha2 & "' AND fld_estado='N' AND fld_transito='" & Estado & "'"
            End If

            Dim daP1 As New MySqlDataAdapter(SqlString, conn)
            daP1.Fill(ds, "tbl_deposito")

            For Each dr In ds.Tables(1).Rows
                If Estado = "TODOS" Then
                    DR("fld_transito") = "TODOS"
                End If
            Next

            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = True
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = "DEPOSITOS" ' FRMS_REPORTES_NO_FECHA("ITEM_EXISTENCIA")

        ElseIf ReportName = "DEPOSITOS_UNO" Then
            Dim Report As New RPT_DEPOSITOS
            Dim ds As New DataSet
            ds.Clear()

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")
            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = fecha_rango
            Next
            Dim SqlString As String
            If Estado = "TODOS" Then
                SqlString = "SELECT * FROM tbl_deposito WHERE fld_fecha Between '" & fecha1 & "' AND '" & fecha2 & "' AND fld_estado='N' AND fld_id_banco='" & Id & "'"
            Else
                SqlString = "SELECT * FROM tbl_deposito WHERE fld_fecha Between '" & fecha1 & "' AND '" & fecha2 & "' AND fld_estado='N' AND fld_id_banco='" & Id & "' AND fld_transito='" & Estado & "'"
            End If

            Dim daP1 As New MySqlDataAdapter(SqlString, conn)
            daP1.Fill(ds, "tbl_deposito")
            For Each dr In ds.Tables(1).Rows
                If Estado = "TODOS" Then
                    DR("fld_transito") = "TODOS"
                End If
            Next

            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = True
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = "DEPOSITOS"

        ElseIf ReportName = "CK_TODOS" Then
            Dim Report As New RPT_CHEQUES
            Dim ds As New DataSet
            ds.Clear()

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")
            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = fecha_rango
            Next

            Dim SqlString As String
            If Estado = "TODOS" Then
                SqlString = "SELECT * FROM tbl_cheques WHERE fld_fecha Between '" & fecha1 & "' AND '" & fecha2 & "' AND fld_estado='" & Estado & "'"
            Else
                SqlString = "SELECT * FROM tbl_cheques WHERE fld_fecha Between '" & fecha1 & "' AND '" & fecha2 & "' AND fld_estado='" & Estado & "' AND fld_transito='" & Estado & "'"
            End If

            Dim daP1 As New MySqlDataAdapter(SqlString, conn)
            daP1.Fill(ds, "tbl_cheques")
            For Each dr In ds.Tables(1).Rows
                If Estado = "TODOS" Then
                    DR("fld_transito") = "TODOS"
                End If
            Next


            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = True
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = "CHEQUES"
        ElseIf ReportName = "CK_UNO_EMISION" Then
            Dim Report As New RPT_CHEQUES
            Dim ds As New DataSet
            ds.Clear()

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")
            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = fecha_rango
            Next 'AND fld_estado='" & Estado & "'

            Dim SqlString As String

            SqlString = "SELECT * FROM tbl_cheques WHERE fld_fecha Between '" & fecha1 & "' AND '" & fecha2 & "' AND fld_estado='EMISION' AND fld_id_banco='" & Id & "'"

            Dim daP1 As New MySqlDataAdapter(SqlString, conn)
            daP1.Fill(ds, "tbl_cheques")
            'For Each dr In ds.Tables(1).Rows
            '    If Estado = "TODOS" Then
            '        dr("fld_transito") = "TODOS"
            '    End If
            'Next

            ' Establecer el nombre del campo de parámetros; debe coincidir con un parámetro
            ' del informe
            paramField.ParameterFieldName = "banco"
            discreteVal.Value = SCALAR_STRING("SELECT fld_nombre FROM tbl_bancos WHERE fld_codigo='" & Id & "'")
            paramField.CurrentValues.Add(discreteVal)
            paramFields.Add(paramField)
            CrystalReportViewer.ParameterFieldInfo = paramFields

            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = True
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = "CHEQUES"
        ElseIf ReportName = "CK_UNO_NULOS" Then
            Dim Report As New RPT_CHEQUES
            Dim ds As New DataSet
            ds.Clear()

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")
            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = fecha_rango
            Next 'AND fld_estado='" & Estado & "'

            Dim SqlString As String

            SqlString = "SELECT * FROM tbl_cheques WHERE fld_fecha Between '" & fecha1 & "' AND '" & fecha2 & "' AND fld_estado <> 'EMISION' AND fld_id_banco='" & Id & "'"

            Dim daP1 As New MySqlDataAdapter(SqlString, conn)
            daP1.Fill(ds, "tbl_cheques")
            'For Each dr In ds.Tables(1).Rows
            '    If Estado = "TODOS" Then
            '        dr("fld_transito") = "TODOS"
            '    End If
            'Next

            ' Establecer el nombre del campo de parámetros; debe coincidir con un parámetro
            ' del informe
            paramField.ParameterFieldName = "banco"
            discreteVal.Value = SCALAR_STRING("SELECT fld_nombre FROM tbl_bancos WHERE fld_codigo='" & Id & "'")
            paramField.CurrentValues.Add(discreteVal)
            paramFields.Add(paramField)
            CrystalReportViewer.ParameterFieldInfo = paramFields

            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = True
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = "CHEQUES"
        ElseIf ReportName = "NC_BANCO_TODAS" Then
            Dim Report As New RPT_NC
            Dim ds As New DataSet
            ds.Clear()

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")
            Dim dr As DataRow

            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = fecha_rango
            Next

            Dim daP1 As New MySqlDataAdapter("SELECT * FROM tbl_nc_bancaria WHERE fld_fecha Between '" & fecha1 & "' AND '" & fecha2 & "' AND fld_estado='N' ", conn)
            daP1.Fill(ds, "tbl_nc_bancaria")

            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = True
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = "NOTAS DE CREDITOS"
        ElseIf ReportName = "NC_BANCO_UNO" Then
            Dim Report As New RPT_NC
            Dim ds As New DataSet
            ds.Clear()

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")
            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = fecha_rango
            Next
            Dim daP1 As New MySqlDataAdapter("SELECT * FROM tbl_nc_bancaria WHERE fld_fecha Between '" & fecha1 & "' AND '" & fecha2 & "' AND fld_estado='N' AND fld_id_banco='" & Id & "'", conn)
            daP1.Fill(ds, "tbl_nc_bancaria")
            paramField.ParameterFieldName = "banco"
            discreteVal.Value = SCALAR_STRING("SELECT fld_nombre FROM tbl_bancos WHERE fld_codigo='" & Id & "'")
            paramField.CurrentValues.Add(discreteVal)
            paramFields.Add(paramField)
            CrystalReportViewer.ParameterFieldInfo = paramFields

            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = True
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = "NOTAS DE CREDITOS"
        ElseIf ReportName = "ND_BANCO_TODAS" Then
            Dim Report As New RPT_ND
            Dim ds As New DataSet
            ds.Clear()

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")
            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = fecha_rango
            Next
            Dim daP1 As New MySqlDataAdapter("SELECT * FROM tbl_nd_bancaria WHERE fld_fecha Between '" & fecha1 & "' AND '" & fecha2 & "' AND fld_estado='N' ", conn)
            daP1.Fill(ds, "tbl_nd_bancaria")

            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = True
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = "NOTAS DE DEBITOS"
        ElseIf ReportName = "ND_BANCO_UNO" Then
            Dim Report As New RPT_ND
            Dim ds As New DataSet
            ds.Clear()

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")
            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = fecha_rango
            Next
            Dim daP1 As New MySqlDataAdapter("SELECT * FROM tbl_nd_bancaria WHERE fld_fecha Between '" & fecha1 & "' AND '" & fecha2 & "' AND fld_estado='N' AND fld_id_banco='" & Id & "'", conn)
            daP1.Fill(ds, "tbl_nd_bancaria")
            paramField.ParameterFieldName = "banco"
            discreteVal.Value = SCALAR_STRING("SELECT fld_nombre FROM tbl_bancos WHERE fld_codigo='" & Id & "'")
            paramField.CurrentValues.Add(discreteVal)
            paramFields.Add(paramField)
            CrystalReportViewer.ParameterFieldInfo = paramFields


            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = True
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = "NOTAS DE DEBITOS"
        ElseIf ReportName = "LIBRO_DIARIO_GENERAL" Then

            Dim Report As New rptLibroGeneral
            Dim ds As New DataSet
            ds.Clear()

            Dim dr As DataRow

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")

            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = fecha_rango
            Next

            Dim SQL = "SELECT * FROM view_cont_libro_general WHERE TransFechaMovimiento >= '" & fecha1 & "' AND TransFechaMovimiento <= '" & fecha2 & "' AND CuentaNo<>'" & ctaUtilidad & "'"

            Dim daP1 As New MySqlDataAdapter(SQL, conn)
            daP1.Fill(ds, "view_cont_libro_general")

            Report.Database.Tables(0).SetDataSource(ds)

            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = False
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = "LIBRO DIARIO GENERAL"

        ElseIf ReportName = "LIBRO_MAYOR_GENERAL" Then

            Dim Report As New rptLibroMayol
            Dim ds As New DataSet
            ds.Clear()


            Dim dr As DataRow

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")

            actualizarCuentas(fecha1, fecha2)
            Dim balance As Double = ReturnBceAnterior(cta_contable_selecionada, fecha1)
            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = fecha_rango
            Next

            Dim SQL = "SELECT * FROM view_cont_libro_general WHERE TransFechaMovimiento >= '" & fecha1 & "' AND TransFechaMovimiento <= '" & fecha2 & "' AND TransDCuentaNo = '" & cta_contable_selecionada & "'  ORDER BY TransFechaMovimiento ASC"

            Dim daP1 As New MySqlDataAdapter(SQL, conn)
            daP1.Fill(ds, "view_cont_libro_general")
            Dim Origen As Integer
            For Each dr In ds.Tables(1).Rows
                Origen = SCALAR_NUM("SELECT Origen FROM tbl_catalogo_grupo AS cg, tbl_catalogo AS c WHERE c.Grupo=cg.ID AND c.CuentaNo='" & dr("TransDCuentaNo") & "'")
                dr("Balance") = balance
                If Origen = 2 Then
                    If dr("TransDDebito") > 0 Then
                        balance = balance - dr("TransDDebito")
                        dr("TransDBalance") = balance
                    ElseIf dr("TransDCredito") > 0 Then
                        balance = balance + dr("TransDCredito")
                        dr("TransDBalance") = balance
                    End If
                ElseIf Origen = 1 Then
                    'ORDER BY fld_Date ASC
                    If dr("TransDDebito") > 0 Then
                        balance = balance + dr("TransDDebito")
                        dr("TransDBalance") = balance
                    ElseIf dr("TransDCredito") > 0 Then
                        balance = balance - dr("TransDCredito")
                        dr("TransDBalance") = balance
                    End If
                End If


            Next

            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = False
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = "LIBRO MAYOR GENERAL"

        ElseIf ReportName = "Balance de Resultado" Then

            Dim Report As New rptEstadoResultado
            Dim dr As DataRow, ds As New DataSet
            ds.Clear()

            actualizarCuentas(formatDate(PrimerDiaDelMes(CDate(fecha2))), formatDate(UltimoDiaDelMes(CDate(fecha2)))) 'Actualizar las cuentas del mes seleccionado
            actualizarCuentasBceAnterior(formatDate(fechaInicioPeriodo), formatDate(UltimoDiaDelMes(CDate(fecha2).AddMonths(-1))))

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")

            Dim daP1 As New MySqlDataAdapter("SELECT c.*, cg.Origen AS origen FROM tbl_catalogo AS c INNER JOIN tbl_catalogo_grupo AS cg ON c.Grupo=cg.ID  WHERE (Debito > 0 OR Credito > 0 OR Balance > 0 OR BalanceAnterior > 0) AND Grupo IN(4,5,6)", conn)
            '
            daP1.Fill(ds, "tbl_catalogo")

            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = "Al " & Format(UltimoDiaDelMes(CDate(fecha2)), "dd MMMM yyyy")  '
                Exit For
            Next


            Report.Database.Tables(0).SetDataSource(ds)

            '' eescobar
            Dim ingMesActual As Decimal = SCALAR_NUM("SELECT SUM(Balance) FROM tbl_catalogo WHERE Grupo =4 AND Tipo='Auxiliar'")
            Dim costogastosMesActual As Decimal = SCALAR_NUM("SELECT SUM(Balance) FROM tbl_catalogo WHERE Grupo IN (5,6) AND Tipo='Auxiliar'")

            Report.SetParameterValue("bceMesActual", ingMesActual - costogastosMesActual)


            Dim ingMesAnterior As Decimal = SCALAR_NUM("SELECT SUM(BalanceAnterior) FROM tbl_catalogo WHERE Grupo =4 AND Tipo='Auxiliar'")
            Dim costogastosMesAnterior As Decimal = SCALAR_NUM("SELECT SUM(BalanceAnterior) FROM tbl_catalogo WHERE Grupo IN (5,6) AND Tipo='Auxiliar'")

            Report.SetParameterValue("bceMesAnterior", ingMesAnterior - costogastosMesAnterior)

            Report.SetParameterValue("bceAct", (ingMesAnterior - costogastosMesAnterior) + (ingMesActual - costogastosMesActual))



            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = False
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = ReportName
        ElseIf ReportName = "Estado de Situación" Then

            Dim Report As New rptEstadoSituacion
            Dim dr As DataRow, ds As New DataSet
            ds.Clear()

            If crarEntradaUtilidad() = False Then
                Me.Close()
            End If

            actualizarCuentas(formatDate(fechaInicioPeriodo), formatDate(UltimoDiaDelMes(fecha2)))

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")

            ''Dim daP1 As New MySqlDataAdapter("SELECT c.*, cg.Origen AS origen FROM tbl_catalogo AS c INNER JOIN tbl_catalogo_grupo AS cg ON c.Grupo=cg.ID WHERE  Balance > 0  AND Grupo IN(1,2,3)", conn)
            Dim daP1 As New MySqlDataAdapter("SELECT c.*, cg.Origen AS origen FROM tbl_catalogo AS c INNER JOIN tbl_catalogo_grupo AS cg ON c.Grupo=cg.ID WHERE Balance <> 0 AND  Grupo IN(1,2,3)", conn)
            daP1.Fill(ds, "tbl_catalogo")

            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = "Al " & Format(UltimoDiaDelMes(CDate(fecha2)), "dd MMMM yyyy")
                Exit For
            Next

            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = False
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = ReportName

        ElseIf ReportName = "Resumen del Balance de Comprobación Mes" Then

            Dim Report As New rptBalanceComprobacion
            Dim ds As New DataSet
            ds.Clear()
            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")


            actualizarCuentas(formatDate(PrimerDiaDelMes(CDate(fecha2))), formatDate(UltimoDiaDelMes(CDate(fecha2)))) 'Actualizar las cuentas del mes seleccionado

            NON_QUERY("CALL cont_actualizar_cta_detallesBceAnt('" & formatDate(fechaInicioPeriodo) & "','" & formatDate(UltimoDiaDelMes(CDate(fecha2).AddMonths(-1))) & "')")


            Dim daP1 As New MySqlDataAdapter("SELECT c.*, cg.Origen AS origen FROM tbl_catalogo AS c INNER JOIN tbl_catalogo_grupo AS cg ON c.Grupo=cg.ID WHERE (Debito > 0 OR Credito > 0 or BalanceAnterior > 0) AND Tipo='Auxiliar' AND CuentaNo <> '" & ctaUtilidad & "'", conn)
            daP1.Fill(ds, "tbl_catalogo")

            Dim balance As Double = 0
            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = "Al " & Format(UltimoDiaDelMes(CDate(fecha2)), "dd MMMM yyyy")
                Exit For
            Next


            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PaperSize = PaperSize.PaperLetter
            CrystalReportViewer.ReportSource = Report
            CrystalReportViewer.DisplayGroupTree = False
            CrystalReportViewer.ShowGroupTreeButton = False
            Me.Text = ReportName

        ElseIf ReportName = "Recibo Ingreso" Then
            Dim ds As New DataSet

            Dim daProf As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daProf.Fill(ds, "tbl_profiledocument")

            If objIniFile.GetString("COMPANY", "Tipo Impresora RI", "Normal") = "Normal" Then
                Dim daInv As New MySqlDataAdapter("SELECT * FROM view_ri_cxc WHERE fld_id_ri=" & Id & "", conn)
                daInv.Fill(ds, "view_ri_cxc")
                Dim dr As DataRow

                For Each dr In ds.Tables(1).Rows
                    Dim largo = Len(CStr(Format(CDbl(dr("fld_monto")), "##,###.00")))
                    Dim decimales = Mid(CStr(Format(CDbl(dr("fld_monto")), "##,###.00")), largo - 2)
                    dr("fld_Description") = Num2Text(dr("fld_monto") - decimales) & " CON " & Mid(decimales, Len(decimales) - 1).ToUpper & " / 100" & " "
                    dr("fld_bce_anterior") = SCALAR_NUM("SELECT IFNULL(SUM(fld_interes_cuota_balance),0) FROM tbl_cuotas WHERE fld_id_del_cliente_cuotas = " & dr("fld_id_cliente_ri") & " AND fld_fecha_termina_cuotas < DATE(NOW()) AND fld_interes_cuota_balance > 0")
                Next

                Dim Report As New RPT_RECIBO_INGRESO
                Report.Database.Tables(0).SetDataSource(ds)
                Report.PrintOptions.PaperSize = PaperSize.PaperLetter
                CrystalReportViewer.ReportSource = Report
                CrystalReportViewer.DisplayGroupTree = False
                CrystalReportViewer.ShowGroupTreeButton = False
                Me.Text = ReportName
            Else

                Dim daInv As New MySqlDataAdapter("SELECT * FROM tbl_recibo_ingresos_imprimir WHERE ReciboNo=" & Id & "", conn)
                daInv.Fill(ds, "tbl_recibo_ingresos_imprimir")

                Dim Report As New RPT_RECIBO_INGRESO_SP
                Report.Database.Tables(0).SetDataSource(ds)
                Report.PrintOptions.PaperSize = PaperSize.PaperLetter
                CrystalReportViewer.ReportSource = Report
                CrystalReportViewer.DisplayGroupTree = False
                CrystalReportViewer.ShowGroupTreeButton = False
                Me.Text = ReportName
            End If
        ElseIf ReportName = "Recibo Otro Ingreso" Then
            Dim ds As New DataSet

            Dim daProf As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daProf.Fill(ds, "tbl_profiledocument")



            Dim daInv As New MySqlDataAdapter("SELECT * FROM tbl_recibo_ingresos_cxc WHERE fld_id_ri=" & Id & "", conn)
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
                Report.PrintOptions.PaperSize = PaperSize.PaperLetter
                CrystalReportViewer.ReportSource = Report
                CrystalReportViewer.DisplayGroupTree = False
                CrystalReportViewer.ShowGroupTreeButton = False
                Me.Text = ReportName
            Else
                Dim Report As New rptOtroIngresoSP
                Report.Database.Tables(0).SetDataSource(ds)
                Report.PrintOptions.PaperSize = PaperSize.PaperLetter
                CrystalReportViewer.ReportSource = Report
                CrystalReportViewer.DisplayGroupTree = False
                CrystalReportViewer.ShowGroupTreeButton = False
                Me.Text = ReportName
            End If
        ElseIf ReportName = "Recibo Egreso" Then
            Dim ds As New DataSet

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")

            Dim da As New MySqlDataAdapter("SELECT * FROM tbl_recibo_egresos WHERE fldIdDoc=" & Id & "  ", conn)
            da.Fill(ds, "tbl_recibo_egresos")

            Dim dr As DataRow

            For Each dr In ds.Tables(1).Rows
                Dim largo = Len(CStr(Format(CDbl(dr("fldMonto")), "##,###.00")))
                Dim decimales = Mid(CStr(Format(CDbl(dr("fldMonto")), "##,###.00")), largo - 2)

                dr("fldMontoLetra") = Num2Text(dr("fldMonto") - decimales) & " CON " & Mid(decimales, Len(decimales) - 1).ToUpper & " / 100" & " "
            Next
            If objIniFile.GetString("COMPANY", "Tipo Impresora RI", "Normal") = "Normal" Then
                Dim Report As New RPT_EGRESO_DE_CAJA
                Report.Database.Tables(0).SetDataSource(ds)
                Report.PrintOptions.PaperSize = PaperSize.PaperLetter
                CrystalReportViewer.ReportSource = Report
                CrystalReportViewer.DisplayGroupTree = False
                CrystalReportViewer.ShowGroupTreeButton = False
                Me.Text = ReportName
            Else
                Dim Report As New rptEgresoDeCajaSP
                Report.Database.Tables(0).SetDataSource(ds)
                Report.PrintOptions.PaperSize = PaperSize.PaperLetter
                CrystalReportViewer.ReportSource = Report
                CrystalReportViewer.DisplayGroupTree = False
                CrystalReportViewer.ShowGroupTreeButton = False
                Me.Text = ReportName
            End If
        ElseIf ReportName = "Recibo Deposito" Then

            Dim ds As New DataSet

            Dim daProf As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daProf.Fill(ds, "tbl_profiledocument")

            Dim daInv As New MySqlDataAdapter("SELECT dep.ID, fld_id, fld_FullName, fld_Identity, CuentaNo, Fecha, Monto, Notas, dep.Usuario, c.Descripcion AS Caja, Dosmil, Mil, Quiniento, DosCiento, Cien, Cincuenta, Veinticinco, Diez, Cinco, Cheque, Uno  FROM tbl_clientes AS cl, tbl_ahorros_depositos AS dep, tbl_ahorros_cuentas AS cta, cajamantenimiento AS c WHERE dep.ID = " & Id & " AND dep.IDCliente= cl.fld_id  AND dep.IDCuenta= cta.ID AND dep.IdCaja=c.ID", conn)
            daInv.Fill(ds, "tbl_ahorro")

            If objIniFile.GetString("COMPANY", "Tipo Impresora RI", "Normal") = "Normal" Then

                Dim Report As New rptAhorroDeposito
                Report.Database.Tables(0).SetDataSource(ds)
                Report.PrintOptions.PaperSize = PaperSize.PaperLetter
                CrystalReportViewer.ReportSource = Report
                CrystalReportViewer.DisplayGroupTree = False
                CrystalReportViewer.ShowGroupTreeButton = False
                Me.Text = ReportName

            Else

                Dim Report As New rptAhorroDepositoSP
                Report.Database.Tables(0).SetDataSource(ds)
                Report.PrintOptions.PaperSize = PaperSize.PaperLetter
                CrystalReportViewer.ReportSource = Report
                CrystalReportViewer.DisplayGroupTree = False
                CrystalReportViewer.ShowGroupTreeButton = False
                Me.Text = ReportName

            End If
        ElseIf ReportName = "Recibo Retiro" Then
            Dim ds As New DataSet

            Dim daProf As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daProf.Fill(ds, "tbl_profiledocument")

            Dim daInv As New MySqlDataAdapter("SELECT ret.ID, cl.fld_id, cl.fld_FullName, cl.fld_Identity, cta.CuentaNo, ret.Fecha, ret.Monto, ret.Concepto, ret.Usuario, mc.Descripcion, dosMil,Mil,Quiniento,Dosciento,Cien,Cincuenta,Veinticinco,Diez,Cinco,Cheque,Uno FROM tbl_clientes AS cl INNER JOIN tbl_ahorros_retiros AS ret ON ret.IDCliente=cl.fld_id INNER JOIN tbl_ahorros_cuentas AS cta ON ret.IDAhorro=cta.ID INNER JOIN cajamantenimiento AS mc ON ret.IdCaja=mc.ID WHERE ret.ID = " & Id & "", conn)
            daInv.Fill(ds, "tbl_ahorroretiro")

            If objIniFile.GetString("COMPANY", "Tipo Impresora RI", "Normal") = "Normal" Then
                Dim Report As New rptAhorroRetiro
                Report.Database.Tables(0).SetDataSource(ds)
                Report.PrintOptions.PaperSize = PaperSize.PaperLetter
                CrystalReportViewer.ReportSource = Report
                CrystalReportViewer.DisplayGroupTree = False
                CrystalReportViewer.ShowGroupTreeButton = False
                Me.Text = ReportName
            Else
                Dim Report As New rptAhorroRetiroSP
                Report.Database.Tables(0).SetDataSource(ds)
                Report.PrintOptions.PaperSize = PaperSize.PaperLetter
                CrystalReportViewer.ReportSource = Report
                CrystalReportViewer.DisplayGroupTree = False
                CrystalReportViewer.ShowGroupTreeButton = False
                Me.Text = ReportName
            End If

        ElseIf ReportName = "Recibo Aporte" Then
            Dim ds As New DataSet

            Dim daProf As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daProf.Fill(ds, "tbl_profiledocument")

            Dim daInv As New MySqlDataAdapter("SELECT aa.ID AS ahoid, aa.Fecha AS ahofecha, cl.fld_Identity AS clicedula, cl.fld_FullName AS clinombre, aa.Monto AS ahomonto, cl.fld_id AS clicod, cl.fld_apodo AS cliapodo, cl.fld_Address AS clidireccion, cl.fld_City AS cliciudad, aa.Concepto AS ahoconcepto, mc.CtaContable AS cajactacontable, mc.Descripcion AS cajanombre FROM tbl_clientes AS cl INNER JOIN tbl_ahorros_aportacion AS aa ON aa.IDSocio = cl.fld_id INNER JOIN cajamantenimiento AS mc ON aa.IDCaja = mc.ID WHERE aa.ID=" & Id & " ", conn)
            daInv.Fill(ds, "ahorroAportacion")


            If objIniFile.GetString("COMPANY", "Tipo Impresora RI", "Normal") = "Normal" Then
                Dim Report As New rptAporteSocioRecibo
                Report.Database.Tables(0).SetDataSource(ds)
                Report.PrintOptions.PaperSize = PaperSize.PaperLetter
                CrystalReportViewer.ReportSource = Report
                CrystalReportViewer.DisplayGroupTree = False
                CrystalReportViewer.ShowGroupTreeButton = False
                Me.Text = ReportName
            Else
                Dim Report As New rptAporteSocioReciboSP
                Report.Database.Tables(0).SetDataSource(ds)
                Report.PrintOptions.PaperSize = PaperSize.PaperLetter
                CrystalReportViewer.ReportSource = Report
                CrystalReportViewer.DisplayGroupTree = False
                CrystalReportViewer.ShowGroupTreeButton = False
                Me.Text = ReportName
            End If


        End If
VOLAR:
        Me.WindowState = FormWindowState.Maximized
        show.Close()

    End Sub

    Private Function RETURN_CONCEPTO(ByVal ids As String) As String
        Dim cmd As New MySqlCommand, dr As MySqlDataReader, result As String

        With cmd
            .Connection = conn
            .CommandText = "SELECT * FROM tbl_maestro_concepto WHERE fld_cod_MC='" & ids & "'"
            .Connection.Open()
            dr = .ExecuteReader
        End With
        If dr.Read Then
            result = dr("fld_concepto_MC")
        Else
            result = "n/a"
        End If
        dr.Close()
        dr = Nothing
        cmd.Connection.Close()
        cmd = Nothing

        RETURN_CONCEPTO = result
    End Function


End Class
