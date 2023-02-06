Public Class FRM_CUADRE
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
    Friend WithEvents txtNota As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBceAnterior As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ArqueoCajaBtn As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_CUADRE))
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNota = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtBceAnterior = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.ArqueoCajaBtn = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "dd - MM - yyyy"
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(112, 16)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(136, 20)
        Me.dtpFecha.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fecha...: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNota
        '
        Me.txtNota.Location = New System.Drawing.Point(112, 64)
        Me.txtNota.MaxLength = 500
        Me.txtNota.Multiline = True
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(504, 56)
        Me.txtNota.TabIndex = 2
        Me.txtNota.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nota...: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Balance Anterior...: "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBceAnterior
        '
        Me.txtBceAnterior.Location = New System.Drawing.Point(112, 40)
        Me.txtBceAnterior.Name = "txtBceAnterior"
        Me.txtBceAnterior.Size = New System.Drawing.Size(136, 20)
        Me.txtBceAnterior.TabIndex = 1
        Me.txtBceAnterior.Text = "0.00"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(184, 128)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 56)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "&Cerrar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(112, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 56)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&Aceptar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ArqueoCajaBtn
        '
        Me.ArqueoCajaBtn.Location = New System.Drawing.Point(264, 16)
        Me.ArqueoCajaBtn.Name = "ArqueoCajaBtn"
        Me.ArqueoCajaBtn.Size = New System.Drawing.Size(120, 23)
        Me.ArqueoCajaBtn.TabIndex = 5
        Me.ArqueoCajaBtn.Text = "Arqueo de Caja"
        '
        'FRM_CUADRE
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(626, 211)
        Me.Controls.Add(Me.ArqueoCajaBtn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtBceAnterior)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNota)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpFecha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_CUADRE"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuadre de Caja"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub GeneraCuadre()


        '/// REGISTRO DE INGRESOS CXC
        NON_QUERY("TRUNCATE TABLE tbl_cuadre_detalle;")
        Dim Ingresos As Double = SCALAR_NUM("SELECT IFNULL(SUM(fld_monto),0) FROM tbl_recibo_ingresos_cxc WHERE DATE(fld_date)='" & Format(dtpFecha.Value, "yyyy-MM-dd") & "' AND fld_id_cliente_ri > 0")

        NON_QUERY("INSERT INTO tbl_cuadre_detalle (fldTipoDocumento, fldIdDocumento, fldDetalleDocumento,fldFechaDocumento, fldMontoDocumento, fldCliente) (SELECT 'INGRESOS CXC', fld_Id_RI, fld_concepto, fld_date, fld_monto, fld_socio FROM tbl_recibo_ingresos_cxc WHERE DATE(fld_date)='" & Format(dtpFecha.Value, "yyyy-MM-dd") & "' AND fld_id_cliente_ri > 0)")


        '/// REGISTRO DE DEPOSITO BANCARIO
        Dim Depositos As Double = SCALAR_NUM("SELECT IFNULL(SUM(fld_monto),0) FROM tbl_deposito WHERE fld_fecha='" & Format(dtpFecha.Value, "yyyy-MM-dd") & "' AND afectacaja=1")

        If Depositos = 0 Then

            NON_QUERY("INSERT INTO tbl_cuadre_detalle (fldTipoDocumento, fldIdDocumento, fldDetalleDocumento,fldFechaDocumento, fldMontoDocumento,fldCliente ) VALUES('DEPOSITOS',  0, 'NO EXISTEN MOVIMIENTOS', Now(), 0, '-')")

        Else
            NON_QUERY("INSERT INTO tbl_cuadre_detalle (fldTipoDocumento, fldIdDocumento, fldDetalleDocumento,fldFechaDocumento, fldMontoDocumento,fldCliente ) (SELECT 'DEPOSITOS', fld_id_doc, fld_descripcion, fld_fecha, fld_monto,fld_nombre FROM view_depositos WHERE fld_fecha='" & Format(dtpFecha.Value, "yyyy-MM-dd") & "' AND afectacaja=1)")

        End If

        '/// REGISTRO DE OTROS INGRESOS

        Dim OtrosIngresos As Double = SCALAR_NUM("SELECT IFNULL(SUM(fld_monto),0) FROM tbl_recibo_ingresos_cxc WHERE DATE(fld_date)='" & Format(dtpFecha.Value, "yyyy-MM-dd") & "' AND fld_id_cliente_ri = 0")


        If OtrosIngresos = 0 And Ingresos = 0 Then
            NON_QUERY("INSERT INTO tbl_cuadre_detalle (fldTipoDocumento, fldIdDocumento, fldDetalleDocumento,fldFechaDocumento, fldMontoDocumento,fldCliente) VALUES('OTROS INGRESOS', 0, 'NO EXISTEN MOVIMIENTOS', Now(), 0, '-')")

        Else
            NON_QUERY("INSERT INTO tbl_cuadre_detalle (fldTipoDocumento, fldIdDocumento, fldDetalleDocumento,fldFechaDocumento, fldMontoDocumento,fldCliente) (SELECT 'OTROS INGRESOS', fld_Id_RI, fld_concepto, fld_date, fld_monto,fld_socio FROM tbl_recibo_ingresos_cxc WHERE DATE(fld_date)='" & Format(dtpFecha.Value, "yyyy-MM-dd") & "' AND fld_id_cliente_ri = 0)")

        End If


        '/// REGISTRO DE CHEQUES BANCARIOS
        'Dim Cheques As Double = SCALAR_NUM("SELECT IFNULL(SUM(fld_monto),0) FROM tbl_cheques WHERE fld_fecha='" & Format(dtpFecha.Value, "yyyy-MM-dd") & "' AND fld_estado='EMISION'")


        'If Cheques = 0 Then

        '    NON_QUERY("INSERT INTO tbl_cuadre_detalle (fldTipoDocumento, fldIdDocumento, fldDetalleDocumento,fldFechaDocumento, fldMontoDocumento, fldCliente) VALUES('CHEQUES', 0, 'NO EXISTEN MOVIMIENTOS', Now(), 0, '-')")
        'Else
        '    NON_QUERY("INSERT INTO tbl_cuadre_detalle (fldTipoDocumento, fldIdDocumento, fldDetalleDocumento,fldFechaDocumento, fldMontoDocumento, fldCliente) (SELECT 'CHEQUES', fld_ck_no, fld_concepto, fld_fecha, fld_monto,fld_beneficiario FROM tbl_cheques WHERE fld_fecha='" & Format(dtpFecha.Value, "yyyy-MM-dd") & "' AND fld_estado='EMISION')")

        'End If


        '/// REGISTRO DE EGRESOS DE CAJA
        Dim Egresos As Double = SCALAR_NUM("SELECT IFNULL(SUM(fldMonto),0) FROM tbl_recibo_egresos WHERE DATE(fldFecha)='" & Format(dtpFecha.Value, "yyyy-MM-dd") & "'")

        If Egresos = 0 Then
            NON_QUERY("INSERT INTO tbl_cuadre_detalle (fldTipoDocumento, fldIdDocumento, fldDetalleDocumento,fldFechaDocumento, fldMontoDocumento, fldCliente) VALUES('EGRESOS', 0, 'NO EXISTEN MOVIMIENTOS', Now(), 0, '-')")

        Else

            NON_QUERY("INSERT INTO tbl_cuadre_detalle (fldTipoDocumento, fldIdDocumento, fldDetalleDocumento,fldFechaDocumento, fldMontoDocumento, fldCliente) (SELECT 'EGRESOS', fldIdDoc, fldConcepto, fldFecha, fldMonto, fldEntregado FROM tbl_recibo_egresos WHERE DATE(fldFecha)='" & Format(dtpFecha.Value, "yyyy-MM-dd") & "') ")
        End If


        '/// REGISTRO DE DEPOSITO DE AHORROS
        Dim ahorros As Double = SCALAR_NUM("SELECT IFNULL(SUM(Monto),0) FROM tbl_ahorros_depositos WHERE DATE(Fecha)='" & Format(dtpFecha.Value, "yyyy-MM-dd") & "'")

        If ahorros = 0 Then
            NON_QUERY("INSERT INTO tbl_cuadre_detalle (fldTipoDocumento, fldIdDocumento, fldDetalleDocumento,fldFechaDocumento, fldMontoDocumento, fldCliente) VALUES('AHORROS', 0, 'NO EXISTEN MOVIMIENTOS', Now(), 0, '-')")

        Else

            NON_QUERY("INSERT INTO tbl_cuadre_detalle (fldTipoDocumento, fldIdDocumento, fldDetalleDocumento,fldFechaDocumento, fldMontoDocumento, fldCliente) (SELECT 'AHORROS', IDCuenta, CONCAT('AHORROS ',Notas), Fecha, Monto, cl.fld_FullName FROM tbl_ahorros_depositos AS ad INNER JOIN tbl_clientes AS cl ON ad.IDCliente=cl.fld_id WHERE DATE(Fecha)='" & Format(dtpFecha.Value, "yyyy-MM-dd") & "') ")
        End If

        '/// REGISTRO DE RETIROS DE AHORROS
        Dim retiros As Double = SCALAR_NUM("SELECT IFNULL(SUM(Monto),0) FROM tbl_ahorros_retiros WHERE DATE(Fecha)='" & Format(dtpFecha.Value, "yyyy-MM-dd") & "'")

        If retiros = 0 Then
            NON_QUERY("INSERT INTO tbl_cuadre_detalle (fldTipoDocumento, fldIdDocumento, fldDetalleDocumento,fldFechaDocumento, fldMontoDocumento, fldCliente) VALUES('RETIROS', 0, 'NO EXISTEN MOVIMIENTOS', Now(), 0, '-')")

        Else

            NON_QUERY("INSERT INTO tbl_cuadre_detalle (fldTipoDocumento, fldIdDocumento, fldDetalleDocumento,fldFechaDocumento, fldMontoDocumento, fldCliente) (SELECT 'RETIROS', IDAhorro, CONCAT('RETIROS ',Concepto), Fecha, Monto, cl.fld_FullName FROM tbl_ahorros_retiros AS ar INNER JOIN tbl_clientes AS cl ON ar.IDCliente=cl.fld_id WHERE DATE(Fecha)='" & Format(dtpFecha.Value, "yyyy-MM-dd") & "') ")
        End If

        '/// REGISTRO DE APORTES DE SOCIOS
        Dim aportes As Double = SCALAR_NUM("SELECT IFNULL(SUM(Monto),0) FROM tbl_ahorros_aportacion WHERE DATE(Fecha)='" & Format(dtpFecha.Value, "yyyy-MM-dd") & "'")

        If aportes = 0 Then
            NON_QUERY("INSERT INTO tbl_cuadre_detalle (fldTipoDocumento, fldIdDocumento, fldDetalleDocumento,fldFechaDocumento, fldMontoDocumento, fldCliente) VALUES('APORTES', 0, 'NO EXISTEN MOVIMIENTOS', Now(), 0, '-')")

        Else

            NON_QUERY("INSERT INTO tbl_cuadre_detalle (fldTipoDocumento, fldIdDocumento, fldDetalleDocumento,fldFechaDocumento, fldMontoDocumento, fldCliente) (SELECT 'APORTES', ID, CONCAT('APORTE ',Concepto), Fecha, Monto, cl.fld_FullName FROM tbl_ahorros_aportacion AS aa INNER JOIN tbl_clientes AS cl ON aa.IDSocio=cl.fld_id WHERE DATE(Fecha)='" & Format(dtpFecha.Value, "yyyy-MM-dd") & "') ")
        End If

        '/// REGISTRO DE CERTIFICADOS DE SOCIOS
        Dim certificados As Double = SCALAR_NUM("SELECT IFNULL(SUM(SaldoCapital),0) FROM tbl_ahorros_certificado WHERE DATE(FechaApertura)='" & Format(dtpFecha.Value, "yyyy-MM-dd") & "'")

        If certificados = 0 Then
            NON_QUERY("INSERT INTO tbl_cuadre_detalle (fldTipoDocumento, fldIdDocumento, fldDetalleDocumento,fldFechaDocumento, fldMontoDocumento, fldCliente) VALUES('CERTIFICADOS', 0, 'NO EXISTEN MOVIMIENTOS', Now(), 0, '-')")

        Else

            NON_QUERY("INSERT INTO tbl_cuadre_detalle (fldTipoDocumento, fldIdDocumento, fldDetalleDocumento,fldFechaDocumento, fldMontoDocumento, fldCliente) (SELECT 'CERTIFICADOS', CuentaNo, CONCAT('CERTIFICADOS ',Nota), FechaApertura, SaldoCapital, cl.fld_FullName FROM tbl_ahorros_certificado AS ac INNER JOIN tbl_clientes AS cl ON ac.IDCliente=cl.fld_id WHERE DATE(FechaApertura)='" & Format(dtpFecha.Value, "yyyy-MM-dd") & "') ")
        End If

        If Trim(txtBceAnterior.Text) = "" Then txtBceAnterior.Text = 0

        Dim BceAnterior As Double = CDbl(txtBceAnterior.Text)

        Dim BceDisponible As Double = (Ingresos + OtrosIngresos + BceAnterior + ahorros + aportes + certificados) - (Depositos + Egresos + retiros)

        NON_QUERY("TRUNCATE TABLE tbl_cuadre; INSERT INTO tbl_cuadre (fldFecha, fldNota, fldUsuario, fldIngresos, fldDepositos, fldOtroIngresos, fldCheques, fldEgresos, fldBceAnterior, fldBceDisponible) VALUES('" & Format(dtpFecha.Value, "yyyy-MM-dd") & "','" & txtNota.Text & "','" & User(0) & "'," & Ingresos & "," & Depositos & "," & OtrosIngresos & ",0," & Egresos & "," & BceAnterior & "," & BceDisponible & ");")


        fecha2 = formatDate(dtpFecha.Value)
        AllReportSinFecha("CUADRE DE CAJA")

    End Sub

    Private Sub txtBceAnterior_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBceAnterior.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GeneraCuadre()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    
    Private Sub FRM_CUADRE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
    End Sub

    Private Sub ArqueoCajaBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArqueoCajaBtn.Click
        Dim f As New frmCajaArqueo
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub dtpFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged

    End Sub

    Private Sub dtpFecha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub FRM_CUADRE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class
