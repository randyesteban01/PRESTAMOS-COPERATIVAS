Imports MySql.Data.MySqlClient
Public Class FRM_CUENTAS_DE_BANCOS
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
    Friend WithEvents txtNumeroCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtBanco As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents txtIDCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtIDDoc As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipoCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_CUENTAS_DE_BANCOS))
        Me.cmbTipoCuenta = New System.Windows.Forms.ComboBox
        Me.txtNumeroCuenta = New System.Windows.Forms.TextBox
        Me.txtBanco = New System.Windows.Forms.TextBox
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lv = New System.Windows.Forms.ListView
        Me.txtIDCliente = New System.Windows.Forms.TextBox
        Me.txtIDDoc = New System.Windows.Forms.TextBox
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmbTipoCuenta
        '
        Me.cmbTipoCuenta.Items.AddRange(New Object() {"Corriente", "Ahorro", "Otros"})
        Me.cmbTipoCuenta.Location = New System.Drawing.Point(128, 14)
        Me.cmbTipoCuenta.Name = "cmbTipoCuenta"
        Me.cmbTipoCuenta.Size = New System.Drawing.Size(144, 21)
        Me.cmbTipoCuenta.TabIndex = 0
        Me.cmbTipoCuenta.Text = "Corriente"
        '
        'txtNumeroCuenta
        '
        Me.txtNumeroCuenta.Location = New System.Drawing.Point(128, 40)
        Me.txtNumeroCuenta.MaxLength = 30
        Me.txtNumeroCuenta.Name = "txtNumeroCuenta"
        Me.txtNumeroCuenta.Size = New System.Drawing.Size(144, 20)
        Me.txtNumeroCuenta.TabIndex = 1
        Me.txtNumeroCuenta.Text = ""
        '
        'txtBanco
        '
        Me.txtBanco.Location = New System.Drawing.Point(352, 14)
        Me.txtBanco.MaxLength = 30
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(240, 20)
        Me.txtBanco.TabIndex = 2
        Me.txtBanco.Text = ""
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(352, 40)
        Me.txtTelefono.MaxLength = 30
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(240, 20)
        Me.txtTelefono.TabIndex = 3
        Me.txtTelefono.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tipo de Cuenta :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Número de la Cuenta :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(288, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Banco :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(288, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Teléfono :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lv
        '
        Me.lv.Location = New System.Drawing.Point(128, 128)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(464, 144)
        Me.lv.TabIndex = 8
        '
        'txtIDCliente
        '
        Me.txtIDCliente.Location = New System.Drawing.Point(72, 104)
        Me.txtIDCliente.Name = "txtIDCliente"
        Me.txtIDCliente.Size = New System.Drawing.Size(40, 20)
        Me.txtIDCliente.TabIndex = 10
        Me.txtIDCliente.Text = "0"
        Me.txtIDCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtIDCliente.Visible = False
        '
        'txtIDDoc
        '
        Me.txtIDDoc.Location = New System.Drawing.Point(72, 128)
        Me.txtIDDoc.Name = "txtIDDoc"
        Me.txtIDDoc.Size = New System.Drawing.Size(40, 20)
        Me.txtIDDoc.TabIndex = 11
        Me.txtIDDoc.Text = "0"
        Me.txtIDDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtIDDoc.Visible = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrar.Location = New System.Drawing.Point(520, 64)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 56)
        Me.btnCerrar.TabIndex = 13
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
        Me.btnGuardar.Location = New System.Drawing.Point(448, 64)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(72, 56)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.TabStop = False
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'FRM_CUENTAS_DE_BANCOS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(594, 275)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtIDDoc)
        Me.Controls.Add(Me.txtIDCliente)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtBanco)
        Me.Controls.Add(Me.txtNumeroCuenta)
        Me.Controls.Add(Me.cmbTipoCuenta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_CUENTAS_DE_BANCOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuentas de Bancos"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FRM_CUENTAS_DE_BANCOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        NuevoDocumento()
    End Sub

    Function ValidarDocumento() As Boolean

        If cmbTipoCuenta.Text = "" Then
            cmbTipoCuenta.Focus()
            Alerta("Seleccione un TIPO DE CUENTA")
            Return False
        ElseIf txtNumeroCuenta.Text = String.Empty Then
            txtNumeroCuenta.Focus()
            Alerta("Escriba el NÚMERO DE LA CUENTA")
            Return False
        ElseIf txtBanco.Text = String.Empty Then
            txtBanco.Focus()
            Alerta("Escriba el NOMBRE DEL BANCO")
            Return False
        ElseIf txtTelefono.Text = String.Empty Then
            txtTelefono.Focus()
            Alerta("Escriba el NÚMERO DEL TELÉFONO")
            Return False
        End If
        Return True
    End Function

    Private Sub GuardarDocumento()
        NON_QUERY("INSERT INTO tbl_clientes_cuenta_banco (Fecha, TipoCuenta, NumeroCuenta, Banco, Telefono, IDCliente) VALUES(Now(),'" & cmbTipoCuenta.Text & "', '" & txtNumeroCuenta.Text & "','" & txtBanco.Text & "','" & txtTelefono.Text & "'," & CInt(txtIDCliente.Text) & ")")
    End Sub

    Private Sub NuevoDocumento()
        cmbTipoCuenta.Text = "Corriente"
        txtNumeroCuenta.Text = String.Empty
        txtBanco.Text = String.Empty
        txtTelefono.Text = String.Empty

        FillLV()
    End Sub

    Private Sub cmbTipoCuenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTipoCuenta.KeyPress
        e.Handled = True
    End Sub

    Private Sub FillLV()

        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        lv.Clear()
        lv.View = View.Details
        lv.LabelEdit = False
        lv.FullRowSelect = True
        lv.GridLines = True
        lv.MultiSelect = False


        Dim sqlSearch = "SELECT ID, TipoCuenta, NumeroCuenta, Banco, Telefono FROM tbl_clientes_cuenta_banco WHERE IDCliente=" & txtIDCliente.Text & ""

        ds.Reset()
        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, "tbl_clientes_cuenta_banco")


        Dim columnText(9) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "CODIGO"
        columnText(1) = "Tipo de Cuenta"
        columnText(2) = "Número de Cuenta"
        columnText(3) = "Banco"
        columnText(4) = "Teléfono"
        columnText(5) = "TIPO"
        columnText(6) = "GRUPO"
        columnText(7) = "ORIGEN"
        columnText(8) = "CTA. CONTROL"


        Dim columnWidth(9) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 0
        columnWidth(1) = 100
        columnWidth(2) = 100
        columnWidth(3) = 150
        columnWidth(4) = 100
        columnWidth(5) = 100
        columnWidth(6) = 85
        columnWidth(7) = 85
        columnWidth(8) = 85

        Dim columnAlign(9) As Int32 'PARA ALINEAR LOS DATOS
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 0 'IZQUIERDA
        columnAlign(3) = 0 'DERECHA
        columnAlign(4) = 0 'DERECHA
        columnAlign(5) = 0 'DERECHA
        columnAlign(6) = 1 'DERECHA
        columnAlign(7) = 1 'DERECHA
        columnAlign(8) = 1 'DERECHA

        Dim count = 0
        Dim c As DataColumn
        For Each c In ds.Tables(0).Columns
            'adding names of columns as Listview columns				
            Dim h As New ColumnHeader
            h.Text = columnText(count) ' c.ColumnName
            h.TextAlign = columnAlign(count)
            h.Width = columnWidth(count)
            Me.lv.Columns.Add(h)
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
                    str(col) = Format(rr(col), "d")
                ElseIf rr(col).GetType().FullName.ToString = "System.String" Then
                    str(col) = rr(col).ToString()
                ElseIf rr(col).GetType().FullName.ToString = "System.Double" Then
                    str(col) = Format(rr(col), "##,##0.00")
                End If
            Next

            Dim ii As New ListViewItem(str)
            lv.Items.Add(ii)
            'showing the number of records still added
        Next


    End Sub

    Private Sub lv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lv.KeyDown
        If e.KeyCode = Keys.Delete Then
            If Alerta("Seguro que desea borrar el documento seleccionado?") = True Then
                NON_QUERY("DELETE FROM tbl_clientes_cuenta_banco WHERE ID=" & lv.FocusedItem.Text & "")
                NuevoDocumento()
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If ValidarDocumento() = False Then Return
        GuardarDocumento()
        NuevoDocumento()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
