Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Public Class FRM_RECIBO_EGRESO
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
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtIdEntregado As System.Windows.Forms.TextBox
    Friend WithEvents fld_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnImprime As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbCajas As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_RECIBO_EGRESO))
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
        Me.cmbTipo = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtIdEntregado = New System.Windows.Forms.TextBox
        Me.fld_fecha = New System.Windows.Forms.DateTimePicker
        Me.btnImprime = New System.Windows.Forms.Button
        Me.cmbCajas = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(96, 200)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 56)
        Me.btnNuevo.TabIndex = 5
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
        Me.btn_cerrar.Location = New System.Drawing.Point(560, 200)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(72, 56)
        Me.btn_cerrar.TabIndex = 7
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
        Me.btn_procesar.Location = New System.Drawing.Point(168, 200)
        Me.btn_procesar.Name = "btn_procesar"
        Me.btn_procesar.Size = New System.Drawing.Size(72, 56)
        Me.btn_procesar.TabIndex = 4
        Me.btn_procesar.Text = "&Guardar"
        Me.btn_procesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtEntregado
        '
        Me.txtEntregado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEntregado.Location = New System.Drawing.Point(96, 72)
        Me.txtEntregado.MaxLength = 255
        Me.txtEntregado.Name = "txtEntregado"
        Me.txtEntregado.Size = New System.Drawing.Size(536, 20)
        Me.txtEntregado.TabIndex = 1
        Me.txtEntregado.Text = ""
        '
        'txtMonto
        '
        Me.txtMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Location = New System.Drawing.Point(96, 96)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(136, 29)
        Me.txtMonto.TabIndex = 2
        Me.txtMonto.Text = "0.00"
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtConcepto
        '
        Me.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConcepto.Location = New System.Drawing.Point(96, 136)
        Me.txtConcepto.MaxLength = 255
        Me.txtConcepto.Multiline = True
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(536, 56)
        Me.txtConcepto.TabIndex = 3
        Me.txtConcepto.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(-8, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Entregamos a :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(-8, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Monto RD$ :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(-8, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Por concepto de :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(632, 32)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "EGRESO DE CAJA"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(8, 208)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(64, 20)
        Me.txtId.TabIndex = 8
        Me.txtId.Text = "0"
        Me.txtId.Visible = False
        '
        'cmbTipo
        '
        Me.cmbTipo.Items.AddRange(New Object() {"NORMAL", "CLIENTES", "PROVEEDORES"})
        Me.cmbTipo.Location = New System.Drawing.Point(400, 48)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipo.TabIndex = 15
        Me.cmbTipo.Text = "NORMAL"
        Me.cmbTipo.Visible = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(296, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Tipo Doc.:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Visible = False
        '
        'txtIdEntregado
        '
        Me.txtIdEntregado.Location = New System.Drawing.Point(568, 48)
        Me.txtIdEntregado.Name = "txtIdEntregado"
        Me.txtIdEntregado.Size = New System.Drawing.Size(40, 20)
        Me.txtIdEntregado.TabIndex = 16
        Me.txtIdEntregado.Text = "0"
        Me.txtIdEntregado.Visible = False
        '
        'fld_fecha
        '
        Me.fld_fecha.CustomFormat = "dd / MMM / yyyy"
        Me.fld_fecha.Enabled = False
        Me.fld_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fld_fecha.Location = New System.Drawing.Point(360, 96)
        Me.fld_fecha.Name = "fld_fecha"
        Me.fld_fecha.Size = New System.Drawing.Size(128, 20)
        Me.fld_fecha.TabIndex = 17
        Me.fld_fecha.Visible = False
        '
        'btnImprime
        '
        Me.btnImprime.BackColor = System.Drawing.SystemColors.Control
        Me.btnImprime.ForeColor = System.Drawing.Color.Black
        Me.btnImprime.Image = CType(resources.GetObject("btnImprime.Image"), System.Drawing.Image)
        Me.btnImprime.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnImprime.Location = New System.Drawing.Point(240, 200)
        Me.btnImprime.Name = "btnImprime"
        Me.btnImprime.Size = New System.Drawing.Size(72, 56)
        Me.btnImprime.TabIndex = 6
        Me.btnImprime.Text = "&Imprimir"
        Me.btnImprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmbCajas
        '
        Me.cmbCajas.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.cmbCajas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCajas.ForeColor = System.Drawing.Color.White
        Me.cmbCajas.Location = New System.Drawing.Point(96, 48)
        Me.cmbCajas.Name = "cmbCajas"
        Me.cmbCajas.Size = New System.Drawing.Size(288, 21)
        Me.cmbCajas.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(20, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Caja :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FRM_RECIBO_EGRESO
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(642, 275)
        Me.Controls.Add(Me.cmbCajas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnImprime)
        Me.Controls.Add(Me.fld_fecha)
        Me.Controls.Add(Me.txtIdEntregado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbTipo)
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
        Me.Name = "FRM_RECIBO_EGRESO"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Egreso de Caja"
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub LlenarCajas()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT Id, Descripcion FROM cajamantenimiento ORDER BY Orden, Descripcion", conn)
        da.Fill(dt)

        cmbCajas.DataSource = dt
        cmbCajas.DisplayMember = "Descripcion"
        cmbCajas.ValueMember = "Id"
        da.Dispose()

        cmbCajas.SelectedValue = -1

    End Sub

    Private Sub FRM_RECIBO_EGRESO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        txtEntregado.Text = ""
        txtMonto.Text = "0.00"
        txtIdEntregado.Text = 0
        txtConcepto.Text = ""
        cmbCajas.SelectedValue = -1
    End Sub
    Private Function ValidaCampo() As Boolean
        If Trim(txtMonto.Text) = "" Then txtMonto.Text = 0
        If SCALAR_NUM("SELECT IFNULL(1,0) FROM  tbl_interfascontabletipotrans_conf WHERE Frm='" & Me.Text & "'") = 0 Then
            Alerta("El Interfas contable no está configurado, no se puede guardar el documento.")
            Return False
        End If
        If cmbCajas.SelectedIndex.Equals(-1) Then
            Alerta("Debe seleccionar una caja")
            cmbCajas.Focus()
            Return False
        ElseIf Trim(txtEntregado.Text) = "" Then
            Alerta("Escriba a quien se le entregará el dinero")
            txtEntregado.Focus()
            Return False
        ElseIf CDbl(txtMonto.Text) < 0 Then
            Alerta("Debe ingresar un monto positivo")
            txtMonto.Text = ""
            txtMonto.Focus()
            Return False
        ElseIf CDbl(txtMonto.Text) = 0 Then
            Alerta("Debe ingresar un monto ")
            txtMonto.SelectAll()
            txtMonto.Focus()
            Return False
        ElseIf Trim(txtConcepto.Text) = "" Then
            Alerta("Escriba el concepto")
            txtConcepto.Focus()
            Return False
        End If
        Return True
    End Function
    Private Function Guardar() As Integer


        NON_QUERY("INSERT INTO tbl_recibo_egresos (fldFecha, fldTipo, fldIdTipo, fldEntregado, fldConcepto, fldMonto, fldMontoLetra, fldUsuario, idCaja) VALUES(Now(),'" & cmbTipo.Text & "'," & txtIdEntregado.Text & " ,'" & txtEntregado.Text & "','" & txtConcepto.Text & "'," & CDbl(txtMonto.Text) & ",'','" & User(0) & "'," & cmbCajas.SelectedValue & ")")
        Dim IdLastRE As Integer = SCALAR_NUM("SELECT MAX(fldIdDoc) FROM tbl_recibo_egresos")

        If CBool(SCALAR_NUM("SELECT VistaPreviaImpresion FROM parametrosgenerales WHERE ID=1")) = True Then
            Id = IdLastRE
            AllReportSinFecha("Recibo Egreso")
            Return IdLastRE
            Me.Close()
        Else
            ImprimirEgreso(IdLastRE)
            Return IdLastRE
        End If
        

    End Function


    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Nuevo()
    End Sub

    Private Sub btn_procesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_procesar.Click

        If Not ValidaCampo() Then Exit Sub

        Dim ctaContableCaja = SCALAR_STRING("SELECT CtaContable  FROM cajamantenimiento WHERE ID=" & cmbCajas.SelectedValue & "")
        Dim idTipoTrans = SCALAR_NUM("SELECT IdTipo FROM  tbl_interfascontabletipotrans_conf WHERE Frm='" & Me.Text & "'")
        Dim nombreCta = ReturnDescripcion(ctaContableCaja)
        Dim idTran = CargarFrmInterfas(ctaContableCaja, nombreCta, 0, txtMonto.Text, 0, "Egresos de Caja", txtConcepto.Text, fld_fecha.Value.Date, idTipoTrans)

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
        Dim f As New FRM_LISTA_EGRESOS
        f.ShowDialog()
        f.Dispose()
        Me.Close()
    End Sub
 
    Private Sub cmdCajas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbCajas.KeyPress
        e.Handled = True
    End Sub

    Private Sub FRM_RECIBO_EGRESO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class
