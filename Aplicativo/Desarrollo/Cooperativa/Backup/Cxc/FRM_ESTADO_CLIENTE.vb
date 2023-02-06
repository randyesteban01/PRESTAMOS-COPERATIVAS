Imports MySql.Data.MySqlClient
Public Class FRM_ESTADO_CLIENTE
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
    Friend WithEvents fld_Codigo As System.Windows.Forms.TextBox
    Friend WithEvents fld_FullName As System.Windows.Forms.TextBox
    Friend WithEvents fld_Identity As System.Windows.Forms.TextBox
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents btnImprime As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDebito As System.Windows.Forms.TextBox
    Friend WithEvents txtCredito As System.Windows.Forms.TextBox
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtBceAnterior As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_ESTADO_CLIENTE))
        Me.fld_Codigo = New System.Windows.Forms.TextBox
        Me.fld_FullName = New System.Windows.Forms.TextBox
        Me.fld_Identity = New System.Windows.Forms.TextBox
        Me.lblId = New System.Windows.Forms.Label
        Me.lblCedula = New System.Windows.Forms.Label
        Me.lblNombre = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.LV = New System.Windows.Forms.ListView
        Me.txtConcepto = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnImprime = New System.Windows.Forms.Button
        Me.txtDebito = New System.Windows.Forms.TextBox
        Me.txtCredito = New System.Windows.Forms.TextBox
        Me.txtBalance = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtBceAnterior = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'fld_Codigo
        '
        Me.fld_Codigo.BackColor = System.Drawing.SystemColors.Control
        Me.fld_Codigo.Enabled = False
        Me.fld_Codigo.Location = New System.Drawing.Point(64, 16)
        Me.fld_Codigo.Name = "fld_Codigo"
        Me.fld_Codigo.ReadOnly = True
        Me.fld_Codigo.Size = New System.Drawing.Size(248, 20)
        Me.fld_Codigo.TabIndex = 6
        Me.fld_Codigo.Text = ""
        '
        'fld_FullName
        '
        Me.fld_FullName.BackColor = System.Drawing.SystemColors.Control
        Me.fld_FullName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_FullName.Enabled = False
        Me.fld_FullName.Location = New System.Drawing.Point(64, 40)
        Me.fld_FullName.Name = "fld_FullName"
        Me.fld_FullName.ReadOnly = True
        Me.fld_FullName.Size = New System.Drawing.Size(248, 20)
        Me.fld_FullName.TabIndex = 9
        Me.fld_FullName.Text = ""
        '
        'fld_Identity
        '
        Me.fld_Identity.BackColor = System.Drawing.SystemColors.Control
        Me.fld_Identity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_Identity.Enabled = False
        Me.fld_Identity.Location = New System.Drawing.Point(64, 64)
        Me.fld_Identity.MaxLength = 13
        Me.fld_Identity.Name = "fld_Identity"
        Me.fld_Identity.ReadOnly = True
        Me.fld_Identity.Size = New System.Drawing.Size(248, 20)
        Me.fld_Identity.TabIndex = 12
        Me.fld_Identity.Text = ""
        '
        'lblId
        '
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblId.Location = New System.Drawing.Point(0, 16)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(56, 16)
        Me.lblId.TabIndex = 5
        Me.lblId.Text = "Código"
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCedula
        '
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblCedula.Location = New System.Drawing.Point(0, 64)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(56, 16)
        Me.lblCedula.TabIndex = 11
        Me.lblCedula.Text = "Cédula"
        Me.lblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblNombre.Location = New System.Drawing.Point(0, 40)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(56, 16)
        Me.lblNombre.TabIndex = 8
        Me.lblNombre.Text = "Cliente"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(584, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 56)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "&Socios"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'LV
        '
        Me.LV.Location = New System.Drawing.Point(8, 168)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(792, 280)
        Me.LV.TabIndex = 18
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(64, 88)
        Me.txtConcepto.Multiline = True
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(736, 56)
        Me.txtConcepto.TabIndex = 14
        Me.txtConcepto.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(0, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Concepto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnImprime
        '
        Me.btnImprime.BackColor = System.Drawing.SystemColors.Control
        Me.btnImprime.ForeColor = System.Drawing.Color.Black
        Me.btnImprime.Image = CType(resources.GetObject("btnImprime.Image"), System.Drawing.Image)
        Me.btnImprime.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnImprime.Location = New System.Drawing.Point(656, 16)
        Me.btnImprime.Name = "btnImprime"
        Me.btnImprime.Size = New System.Drawing.Size(72, 56)
        Me.btnImprime.TabIndex = 3
        Me.btnImprime.Text = "&Imprimir"
        Me.btnImprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtDebito
        '
        Me.txtDebito.Location = New System.Drawing.Point(476, 472)
        Me.txtDebito.Name = "txtDebito"
        Me.txtDebito.ReadOnly = True
        Me.txtDebito.TabIndex = 22
        Me.txtDebito.Text = "0.00"
        Me.txtDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCredito
        '
        Me.txtCredito.Location = New System.Drawing.Point(574, 472)
        Me.txtCredito.Name = "txtCredito"
        Me.txtCredito.ReadOnly = True
        Me.txtCredito.TabIndex = 23
        Me.txtCredito.Text = "0.00"
        Me.txtCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(674, 472)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.TabIndex = 24
        Me.txtBalance.Text = "0.00"
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(488, 456)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Débito"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(584, 456)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Crédito"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(680, 456)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Balance"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrar.Location = New System.Drawing.Point(728, 16)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 56)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.TabStop = False
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(320, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Hasta"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(320, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Desde"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpHasta
        '
        Me.dtpHasta.CustomFormat = "dd-MMM-yyyy"
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHasta.Location = New System.Drawing.Point(376, 40)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(104, 20)
        Me.dtpHasta.TabIndex = 1
        '
        'dtpDesde
        '
        Me.dtpDesde.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDesde.Location = New System.Drawing.Point(376, 16)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(104, 20)
        Me.dtpDesde.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(440, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Balance Anterior RD$"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBceAnterior
        '
        Me.txtBceAnterior.BackColor = System.Drawing.Color.White
        Me.txtBceAnterior.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBceAnterior.Location = New System.Drawing.Point(616, 146)
        Me.txtBceAnterior.MaxLength = 13
        Me.txtBceAnterior.Name = "txtBceAnterior"
        Me.txtBceAnterior.ReadOnly = True
        Me.txtBceAnterior.Size = New System.Drawing.Size(168, 20)
        Me.txtBceAnterior.TabIndex = 17
        Me.txtBceAnterior.Text = "0.00"
        Me.txtBceAnterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(64, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(416, 23)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "crear un frm que se pueda ver e imprimir los movimientos por de cada préstamos"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Visible = False
        '
        'FRM_ESTADO_CLIENTE
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(810, 499)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtBceAnterior)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpHasta)
        Me.Controls.Add(Me.dtpDesde)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.txtCredito)
        Me.Controls.Add(Me.txtDebito)
        Me.Controls.Add(Me.btnImprime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.fld_Codigo)
        Me.Controls.Add(Me.fld_FullName)
        Me.Controls.Add(Me.fld_Identity)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_ESTADO_CLIENTE"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estado de Cuenta de Socio"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Function BceAnterior(ByVal IdCliente As String) As Double

        BceAnterior = SCALAR_NUM("SELECT IFNULL(SUM(fld_dr)-SUM(fld_cr),0) FROM tbl_estado_clientes WHERE fld_cliente_id='" & IdCliente & "' AND fld_date < '" & formatDate(dtpDesde.Value.Date) & "' GROUP BY fld_cliente_id")

    End Function

    Private Sub FRM_ESTADO_CLIENTE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        dtpDesde.Value = PrimerDiaDelMes(dtpDesde.Value.Date)
        dtpHasta.Value = UltimoDiaDelMes(dtpHasta.Value.Date)
    End Sub

    Private Sub BuscarCliente(ByVal id As Integer)


        Dim cmd As New MySqlCommand, dr As MySqlDataReader

        With cmd
            .CommandText = "SELECT * FROM tbl_clientes WHERE fld_id=" & id & ""
            .Connection = conn
            .Connection.Open()
            dr = .ExecuteReader
        End With

        If dr.Read Then
            fld_Codigo.Text = id
            fld_FullName.Text = dr("fld_FullName")
            fld_Identity.Text = dr("fld_Identity")
        End If

        dr.Close()
        dr = Nothing
        cmd.Connection.Close()
        cmd = Nothing

    End Sub

    Private Sub LlenarListView(ByVal IdCliente As String)
        LV.Clear()
        LV.View = View.Details
        LV.LabelEdit = False
        LV.FullRowSelect = True
        LV.GridLines = True
        LV.MultiSelect = False
        LV.Sorting = SortOrder.None

        Dim fldToSearch As String = "fld_description"



        Dim strTosearch As String = "'%" & Trim(txtConcepto.Text) & "%'"
        Dim sqlSearch As String
        Dim accion As Short
        Trim(strTosearch)
        Try


            sqlSearch = "SELECT fld_id_ec, fld_tipo_doc, fld_date, fld_description, fld_dr, fld_cr, fld_bce_cliente FROM tbl_estado_clientes WHERE fld_cliente_id='" & IdCliente & "' AND fld_date >='" & formatDate(dtpDesde.Value.Date) & "'  AND fld_date <= '" & formatDate(dtpHasta.Value.Date) & "' ORDER BY fld_date"

            Dim dr As DataRow




            Dim ds As New DataSet
            Dim da As New MySqlDataAdapter(sqlSearch, conn)
            da.Fill(ds, "tbl_estado_clientes")
            Dim debito As Double = 0, credito As Double = 0

            Dim Bce As Decimal = BceAnterior(IdCliente)
            txtBceAnterior.Text = Format(Bce, "C2")

            For Each dr In ds.Tables(0).Rows
                debito = debito + dr("fld_dr")
                credito = credito + dr("fld_cr")

                Bce = Bce + dr("fld_dr") - dr("fld_cr")
                dr("fld_bce_cliente") = Bce
            Next


            txtDebito.Text = Format(debito, "C2")
            txtCredito.Text = Format(credito, "C2")
            txtBalance.Text = Format(Bce, "C2")

            Dim columnText(7) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
            columnText(0) = "COD."
            columnText(1) = "TIPO DOC."
            columnText(2) = "FECHA"
            columnText(3) = "CONCEPTO"
            columnText(4) = "DEBITO"
            columnText(5) = "CREDITO"
            columnText(6) = "BALANCE"


            Dim columnWidth(7) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
            columnWidth(0) = 0
            columnWidth(1) = 100
            columnWidth(2) = 75
            columnWidth(3) = 290
            columnWidth(4) = 100
            columnWidth(5) = 100
            columnWidth(6) = 100


            Dim columnAlign(7) As Int32 'PARA ALINEAR LOS DATOS
            columnAlign(0) = 0 'IZQUIERDA
            columnAlign(1) = 0 'IZQUIERDA
            columnAlign(2) = 0 'IZQUIERDA
            columnAlign(3) = 0 'IZQUIERDA
            columnAlign(4) = 1 'IZQUIERDA
            columnAlign(5) = 1 'IZQUIERDA
            columnAlign(6) = 1 'IZQUIERDA

            Dim count = 0
            Dim c As DataColumn
            For Each c In ds.Tables(0).Columns
                'adding names of columns as Listview columns				
                Dim h As New ColumnHeader
                h.Text = columnText(count) ' c.ColumnName
                h.TextAlign = columnAlign(count)
                h.Width = columnWidth(count)
                Me.LV.Columns.Add(h)
                count += 1
            Next

            Dim dt As DataTable = ds.Tables(0)
            Dim str(ds.Tables(0).Columns.Count) As String
            'adding Datarows as listview Grids
            Dim rr As DataRow

            For Each rr In dt.Rows

                For col As Integer = 0 To ds.Tables(0).Columns.Count - 1
                    '/FORMATEAMO LOS DATOS DE ACUERDO A SU FORMATO, ESTO SE HACE POR CADA COLUMNA QUE EXISTA
                    If rr(col).GetType().FullName.ToString = "System.Int32" Then
                        str(col) = Format(rr(col), "00000")
                    ElseIf rr(col).GetType().FullName.ToString = "System.DateTime" Then
                        str(col) = Format(rr(col), "dd-MMM-yyyy")
                    ElseIf rr(col).GetType().FullName.ToString = "System.String" Then
                        str(col) = rr(col).ToString()
                    ElseIf rr(col).GetType().FullName.ToString = "System.Decimal" Then
                        str(col) = Format(rr(col), "C2")
                    ElseIf rr(col).GetType().FullName.ToString = "System.Double" Then
                        str(col) = Format(rr(col), "C2")
                    End If
                Next

                Dim ii As New ListViewItem(str)
                Me.LV.Items.Add(ii)
                'showing the number of records still added
            Next

        Catch ex As Exception
            Alerta(ex.Message)
        End Try



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If FRMS_POPUP_CLIENTES("TODOS") = True Then
            BuscarCliente(CInt(Id))
            LlenarListView(Id)
        End If

    End Sub

    Private Sub LV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged

    End Sub

    Private Sub LV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LV.Click
        txtConcepto.Text = SCALAR_STRING("SELECT fld_description FROM tbl_estado_clientes WHERE fld_id_ec=" & LV.FocusedItem.Text & "")
    End Sub

    Private Sub LV_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LV.KeyUp
        txtConcepto.Text = SCALAR_STRING("SELECT fld_description FROM tbl_estado_clientes WHERE fld_id_ec=" & LV.FocusedItem.Text & "")
    End Sub

    Private Sub btnImprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprime.Click
        Id = fld_Codigo.Text
        fecha1 = formatDate(dtpDesde.Value.Date)
        fecha2 = formatDate(dtpHasta.Value.Date)
        fecha_rango = "Desde " & Format(dtpDesde.Value.Date, "dd-MMM-yyy") & " Hasta " & Format(dtpHasta.Value.Date, "dd-MMM-yyy")
        AllReportSinFecha("ESTADO_CUENTA_CLIENTE")
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub FRM_ESTADO_CLIENTE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        End If
    End Sub
End Class
