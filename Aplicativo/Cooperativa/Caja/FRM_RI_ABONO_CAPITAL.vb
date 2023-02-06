Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Drawing.Printing
Imports System.IO
Public Class FRM_RI_ABONO_CAPITAL
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
    Friend WithEvents btnCierra As System.Windows.Forms.Button
    Friend WithEvents btnBusca As System.Windows.Forms.Button
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblCustomerID As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMontoCobrar As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFormaDePago As System.Windows.Forms.ComboBox
    Friend WithEvents fld_detalle_forma_pago As System.Windows.Forms.TextBox
    Friend WithEvents btn_cobrar As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents fld_id_prestamo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fld_concepto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents fld_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCapitalNuevo As System.Windows.Forms.TextBox
    Friend WithEvents txtCapitalActual As System.Windows.Forms.TextBox
    Friend WithEvents txtInteresActual As System.Windows.Forms.TextBox
    Friend WithEvents txtInteresNuevo As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_RI_ABONO_CAPITAL))
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCapitalNuevo = New System.Windows.Forms.TextBox
        Me.txtInteresNuevo = New System.Windows.Forms.TextBox
        Me.fld_fecha = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.fld_concepto = New System.Windows.Forms.TextBox
        Me.fld_id_prestamo = New System.Windows.Forms.TextBox
        Me.fld_detalle_forma_pago = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtFormaDePago = New System.Windows.Forms.ComboBox
        Me.txtMontoCobrar = New System.Windows.Forms.TextBox
        Me.btnBusca = New System.Windows.Forms.Button
        Me.lblFirstName = New System.Windows.Forms.Label
        Me.lblCustomerID = New System.Windows.Forms.Label
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtCustomerID = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_cobrar = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCierra = New System.Windows.Forms.Button
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtCapitalActual = New System.Windows.Forms.TextBox
        Me.txtInteresActual = New System.Windows.Forms.TextBox
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(176, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Nuevo Capital:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(176, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Nuevo Interes:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCapitalNuevo
        '
        Me.txtCapitalNuevo.Location = New System.Drawing.Point(280, 129)
        Me.txtCapitalNuevo.Name = "txtCapitalNuevo"
        Me.txtCapitalNuevo.ReadOnly = True
        Me.txtCapitalNuevo.Size = New System.Drawing.Size(88, 20)
        Me.txtCapitalNuevo.TabIndex = 82
        Me.txtCapitalNuevo.Text = "0.00"
        Me.txtCapitalNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtInteresNuevo
        '
        Me.txtInteresNuevo.Location = New System.Drawing.Point(280, 100)
        Me.txtInteresNuevo.Name = "txtInteresNuevo"
        Me.txtInteresNuevo.ReadOnly = True
        Me.txtInteresNuevo.Size = New System.Drawing.Size(88, 20)
        Me.txtInteresNuevo.TabIndex = 81
        Me.txtInteresNuevo.Text = "0.00"
        Me.txtInteresNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fld_fecha
        '
        Me.fld_fecha.CustomFormat = "dd / MMM / yyyy"
        Me.fld_fecha.Enabled = False
        Me.fld_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fld_fecha.Location = New System.Drawing.Point(648, 14)
        Me.fld_fecha.Name = "fld_fecha"
        Me.fld_fecha.Size = New System.Drawing.Size(128, 20)
        Me.fld_fecha.TabIndex = 5
        Me.fld_fecha.Visible = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(504, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 16)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Fecha de Servidor"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Visible = False
        '
        'fld_concepto
        '
        Me.fld_concepto.BackColor = System.Drawing.Color.White
        Me.fld_concepto.Location = New System.Drawing.Point(464, 44)
        Me.fld_concepto.MaxLength = 1000
        Me.fld_concepto.Multiline = True
        Me.fld_concepto.Name = "fld_concepto"
        Me.fld_concepto.Size = New System.Drawing.Size(312, 48)
        Me.fld_concepto.TabIndex = 6
        Me.fld_concepto.Text = "N/A"
        '
        'fld_id_prestamo
        '
        Me.fld_id_prestamo.BackColor = System.Drawing.Color.White
        Me.fld_id_prestamo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_id_prestamo.Location = New System.Drawing.Point(96, 72)
        Me.fld_id_prestamo.MaxLength = 8
        Me.fld_id_prestamo.Name = "fld_id_prestamo"
        Me.fld_id_prestamo.ReadOnly = True
        Me.fld_id_prestamo.Size = New System.Drawing.Size(272, 20)
        Me.fld_id_prestamo.TabIndex = 3
        Me.fld_id_prestamo.Text = ""
        '
        'fld_detalle_forma_pago
        '
        Me.fld_detalle_forma_pago.BackColor = System.Drawing.Color.White
        Me.fld_detalle_forma_pago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_detalle_forma_pago.Location = New System.Drawing.Point(464, 129)
        Me.fld_detalle_forma_pago.Multiline = True
        Me.fld_detalle_forma_pago.Name = "fld_detalle_forma_pago"
        Me.fld_detalle_forma_pago.ReadOnly = True
        Me.fld_detalle_forma_pago.Size = New System.Drawing.Size(312, 47)
        Me.fld_detalle_forma_pago.TabIndex = 5
        Me.fld_detalle_forma_pago.Text = "N/A"
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(368, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Forma de pago"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFormaDePago
        '
        Me.txtFormaDePago.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.txtFormaDePago.ForeColor = System.Drawing.Color.White
        Me.txtFormaDePago.ItemHeight = 13
        Me.txtFormaDePago.Items.AddRange(New Object() {"CHEQUE", "TARJETA", "EFECTIVO"})
        Me.txtFormaDePago.Location = New System.Drawing.Point(464, 100)
        Me.txtFormaDePago.Name = "txtFormaDePago"
        Me.txtFormaDePago.Size = New System.Drawing.Size(312, 21)
        Me.txtFormaDePago.TabIndex = 4
        Me.txtFormaDePago.Text = "EFECTIVO"
        '
        'txtMontoCobrar
        '
        Me.txtMontoCobrar.BackColor = System.Drawing.Color.White
        Me.txtMontoCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoCobrar.Location = New System.Drawing.Point(464, 208)
        Me.txtMontoCobrar.Name = "txtMontoCobrar"
        Me.txtMontoCobrar.Size = New System.Drawing.Size(312, 29)
        Me.txtMontoCobrar.TabIndex = 7
        Me.txtMontoCobrar.Text = "0.00"
        Me.txtMontoCobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnBusca
        '
        Me.btnBusca.BackColor = System.Drawing.SystemColors.Control
        Me.btnBusca.ForeColor = System.Drawing.Color.Black
        Me.btnBusca.Location = New System.Drawing.Point(192, 14)
        Me.btnBusca.Name = "btnBusca"
        Me.btnBusca.Size = New System.Drawing.Size(128, 20)
        Me.btnBusca.TabIndex = 0
        Me.btnBusca.Text = "&Lista de Clientes (F5)"
        '
        'lblFirstName
        '
        Me.lblFirstName.Location = New System.Drawing.Point(16, 46)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(72, 16)
        Me.lblFirstName.TabIndex = 36
        Me.lblFirstName.Text = "Socio"
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCustomerID
        '
        Me.lblCustomerID.Location = New System.Drawing.Point(16, 16)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(72, 16)
        Me.lblCustomerID.TabIndex = 35
        Me.lblCustomerID.Text = "Código"
        Me.lblCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.White
        Me.txtFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFirstName.Location = New System.Drawing.Point(96, 44)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(272, 20)
        Me.txtFirstName.TabIndex = 1
        Me.txtFirstName.Text = ""
        '
        'txtCustomerID
        '
        Me.txtCustomerID.BackColor = System.Drawing.Color.White
        Me.txtCustomerID.Location = New System.Drawing.Point(96, 14)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(88, 20)
        Me.txtCustomerID.TabIndex = 0
        Me.txtCustomerID.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(0, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Cod. Préstamo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(624, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 26)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Abono a Capital:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(384, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Concepto:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_cobrar
        '
        Me.btn_cobrar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cobrar.ForeColor = System.Drawing.Color.Black
        Me.btn_cobrar.Image = CType(resources.GetObject("btn_cobrar.Image"), System.Drawing.Image)
        Me.btn_cobrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cobrar.Location = New System.Drawing.Point(96, 165)
        Me.btn_cobrar.Name = "btn_cobrar"
        Me.btn_cobrar.Size = New System.Drawing.Size(72, 56)
        Me.btn_cobrar.TabIndex = 12
        Me.btn_cobrar.Text = "&Guardar"
        Me.btn_cobrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnCierra
        '
        Me.btnCierra.BackColor = System.Drawing.SystemColors.Control
        Me.btnCierra.ForeColor = System.Drawing.Color.Black
        Me.btnCierra.Image = CType(resources.GetObject("btnCierra.Image"), System.Drawing.Image)
        Me.btnCierra.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCierra.Location = New System.Drawing.Point(296, 165)
        Me.btnCierra.Name = "btnCierra"
        Me.btnCierra.Size = New System.Drawing.Size(72, 56)
        Me.btnCierra.TabIndex = 13
        Me.btnCierra.Text = "&Cerrar"
        Me.btnCierra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(-19, 248)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(832, 40)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "RECIBO INGRESO - ABONO A CAPITAL"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(-8, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Capital Actual:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(-8, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 16)
        Me.Label9.TabIndex = 87
        Me.Label9.Text = "Interes Actual:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCapitalActual
        '
        Me.txtCapitalActual.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtCapitalActual.Location = New System.Drawing.Point(96, 129)
        Me.txtCapitalActual.Name = "txtCapitalActual"
        Me.txtCapitalActual.ReadOnly = True
        Me.txtCapitalActual.Size = New System.Drawing.Size(88, 20)
        Me.txtCapitalActual.TabIndex = 86
        Me.txtCapitalActual.Text = "0.00"
        Me.txtCapitalActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtInteresActual
        '
        Me.txtInteresActual.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtInteresActual.Location = New System.Drawing.Point(96, 100)
        Me.txtInteresActual.Name = "txtInteresActual"
        Me.txtInteresActual.ReadOnly = True
        Me.txtInteresActual.Size = New System.Drawing.Size(88, 20)
        Me.txtInteresActual.TabIndex = 85
        Me.txtInteresActual.Text = "0.00"
        Me.txtInteresActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(168, 152)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.TabIndex = 89
        Me.dtpFecha.Visible = False
        '
        'FRM_RI_ABONO_CAPITAL
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(794, 299)
        Me.Controls.Add(Me.btnCierra)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btn_cobrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtCapitalNuevo)
        Me.Controls.Add(Me.txtInteresNuevo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.fld_concepto)
        Me.Controls.Add(Me.fld_id_prestamo)
        Me.Controls.Add(Me.fld_detalle_forma_pago)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtFormaDePago)
        Me.Controls.Add(Me.txtMontoCobrar)
        Me.Controls.Add(Me.btnBusca)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblCustomerID)
        Me.Controls.Add(Me.txtCapitalActual)
        Me.Controls.Add(Me.txtInteresActual)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.fld_fecha)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_RI_ABONO_CAPITAL"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recibo de Ingresos Abono a Capital"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private dsCustomer As New DataSet
    Private daCustomer As MySqlDataAdapter

    Dim isNewDoc As Boolean = True
    Dim isValidated As Boolean = True
    Dim CustBce As Double
    Dim CustAddress As String
    '
    Dim ds As DataSet
    Dim da As MySqlDataAdapter


    Dim cuotaMin As Integer
    Dim cuotaMax As Integer
    Dim BceAnterior As Double

    Dim monto As Double
    Dim capital_cobrado As Double, interes_cobrado As Double, monto_cta_cobrado As Double, mora_cobrada As Double, dias As Integer
    Dim tipoPrestamos As String
#Region "Limpia Prestamo"

    Private Sub clear_cuotas()

        Dim cmd As New MySqlCommand
        With cmd
            .CommandText = "UPDATE tbl_cuotas set fld_abono_cuotas=fld_monto_cuotas, fld_balance_cuotas=0, fld_capital_cuota_abono=fld_capital_cuota, fld_capital_cuota_balance=0, fld_interes_cuota_abono=fld_interes_cuota, fld_interes_cuota_balance=0 where fld_id_del_prestamo=" & fld_id_prestamo.Text & ""
            .Connection = conn
            .Connection.Open()
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd.Dispose()
    End Sub

    Private Sub clear_prestamo()

        Dim cmd As New MySqlCommand
        With cmd
            .CommandText = "UPDATE tbl_prestamos SET fld_abono=fld_monto, fld_balance=0 WHERE fld_id_prestamos=" & fld_id_prestamo.Text & ""
            .Connection = conn
            .Connection.Open()
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd.Dispose()
    End Sub

#End Region

    '/PROPIEDADES DEL FORMULARIO
    Private Sub FrmCustomer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub
    Private Sub FrmCustomer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
       
        fld_fecha.Value = SCALAR_STRING("SELECT DATE(Now())")
    End Sub

    '/SUB PROGRAMAS
   
    Private Function retunr_tipo_prestamo(ByVal id_pret As String) As String

        Dim data As String
        Dim ds1 As New DataSet
        Dim da1 As New MySqlDataAdapter("SELECT fld_tipo_prestamo FROM tbl_prestamos WHERE fld_id_prestamos=" & id_pret & "", conn)
        da1.Fill(ds1, "tbl_prestamos")

        Dim nr As DataRow
        For Each nr In ds1.Tables(0).Rows
            data = nr("fld_tipo_prestamo")
        Next

        ds1.Dispose()
        da1.Dispose()

        retunr_tipo_prestamo = data
    End Function
    Private Function retunr_interes_prestamo(ByVal id_pret As String) As Double

        Dim data As Double
        Dim ds1 As New DataSet
        Dim da1 As New MySqlDataAdapter("SELECT fld_interes_p FROM tbl_prestamos WHERE fld_id_prestamos=" & id_pret & "", conn)
        da1.Fill(ds1, "tbl_prestamos")

        Dim nr As DataRow
        For Each nr In ds1.Tables(0).Rows
            data = nr("fld_interes_p")
        Next

        ds1.Dispose()
        da1.Dispose()

        retunr_interes_prestamo = data
    End Function

    Private Sub SAVE_DETALLE_INGRESOS(ByVal id_doc As String, ByVal abono_interes As Double, ByVal abono_capital As Double, ByVal ri_no As Integer, ByVal tipo As String, ByVal abono_mora As Double)

        Dim cmd As New MySqlCommand
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "INSERT INTO tbl_recibo_ingresos_cxc_detalle (fld_cuota_id,fld_ult_abono_interes,fld_ult_abono_capital,fld_id_ri_padre, fld_tipo_doc_ri_d, fld_ultimo_abono_mora) VALUES(" & id_doc & ", " & abono_interes & ", " & abono_capital & ", " & ri_no & ", '" & tipo & "', " & abono_mora & ")"
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd = Nothing

    End Sub
 
     
    Private Sub CLEAR_FIELDS()

        fld_concepto.Text = ""
        txtCustomerID.Text = ""
        txtFirstName.Text = ""


        txtMontoCobrar.Text = "0.00"
        fld_id_prestamo.Text = ""

    End Sub
    Private Sub LOAD_CUSTOMER(ByVal id_CUST As String)
        Dim isdata As Boolean = False
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_clientes WHERE fld_id=" & id_CUST & "", conn)
        da.Fill(ds, "tbl_clientes")

        Dim nr As DataRow
        For Each nr In ds.Tables(0).Rows
            txtCustomerID.Text = id_CUST
            txtFirstName.Text = nr("fld_FullName")
        Next
        conn.Close()


    End Sub
    Dim porciento As Double = 0 '/INI FILE

    Private Sub ActualizarPrestamos(ByVal ID_P As Integer, ByVal Interes As Double, ByVal NuevoCapital As Double, ByVal NuevoMonto As Double)
        Dim CMD As New MySqlCommand
        With CMD
            .Connection = conn
            .Connection.Open()
            .CommandText = "UPDATE tbl_prestamos SET fld_monto_cuotas_a=" & Interes & ", fld_capital_prestamo=" & NuevoCapital & ", fld_monto=" & NuevoMonto & ", fld_abono=0, fld_balance=fld_monto, fld_fecha_ultimo_abono=Now() WHERE fld_id_prestamos=" & ID_P & ""
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        CMD.Dispose()
    End Sub

    Private Sub LOAD_CUOTAS(ByVal idPrestamo As Integer, ByVal idCuota As Integer)

        Dim SQLSTRING As String
        SQLSTRING = "SELECT * FROM tbl_cuotas WHERE fld_balance_cuotas > 0 AND fld_id_del_prestamo=" & idPrestamo & " AND fld_id_cuotas=" & idCuota & ""



        ds = New DataSet
        da = New MySqlDataAdapter(SQLSTRING, conn)
        da.Fill(ds, "tbl_cuotas")


        Dim DataTable As DataTable '/PARA QUE NO HAGA LA ULTIMA LINEA EN BLANCO
        DataTable = ds.Tables(0)
        DataTable.DefaultView.AllowNew = False



    End Sub

    Private Sub CREATE_INGRESOS()




        Dim fechas As String = formatDate(fld_fecha.Value.Date)
        Dim bceCapital As Double = SCALAR_NUM("SELECT SUM(fld_capital_cuota_balance) FROM tbl_cuotas WHERE fld_id_del_prestamo=" & fld_id_prestamo.Text & "")
        Try
            Dim cmd As New MySqlCommand
            With cmd
                .Connection = conn
                .Connection.Open()
                .CommandText = "INSERT INTO tbl_recibo_ingresos_cxc (fld_forma_pago,fld_detalle_forma_pago,fld_id_cliente_ri,fld_date,fld_Description,fld_monto,fld_fact_afectado,fdl_nd_afectado,fld_User,fld_Estado,fld_id_prestamo, fld_concepto, fld_interes_cobrado, fld_capital_cobrado, fld_mora_cobrada, fld_socio, fld_bce_actual, fld_monto_recibido) VALUES('" & txtFormaDePago.Text & "','" & fld_detalle_forma_pago.Text & "'," & txtCustomerID.Text & ",'" & fechas & "','" & fld_concepto.Text & "'," & CDbl(txtMontoCobrar.Text) & ",'','','" & User(0) & "','NEW'," & fld_id_prestamo.Text & ",'" & fld_concepto.Text & "',0, " & CDbl(txtMontoCobrar.Text) & ", 0,'" & txtFirstName.Text & "', " & bceCapital & "," & CDbl(txtMontoCobrar.Text) & ")"
                .ExecuteNonQuery()
                .Connection.Close()
            End With
            cmd.Dispose()

            Dim Atraso As Double = SCALAR_NUM("SELECT IFNULL(SUM(fld_capital_cuota_balance) + SUM(fld_interes_cuota_balance),0) FROM tbl_cuotas WHERE fld_id_del_prestamo=" & fld_id_prestamo.Text & " AND DATE(fld_fecha_termina_cuotas) < DATE(NOW())")

            Dim RI As Integer = UltimoID("tbl_recibo_ingresos_cxc", "fld_Id_RI")

            InterfarContableAutomatico("Caja", "Abono a Capital", fld_fecha.Value.Date, CDec(txtMontoCobrar.Text), RI, fld_concepto.Text)

            Dim FechaVencePrestamos As Date = SCALAR_STRING("SELECT fld_fecha_termina FROM tbl_prestamos WHERE fld_id_prestamos=" & fld_id_prestamo.Text & "")
            Dim MontoCuota As Double = SCALAR_NUM("SELECT fld_monto_cuotas_a FROM tbl_prestamos WHERE fld_id_prestamos=" & fld_id_prestamo.Text & "")
            Dim MontoPrestamos As Double = SCALAR_NUM("SELECT fld_capital_prestamo FROM tbl_prestamos WHERE fld_id_prestamos=" & fld_id_prestamo.Text & "")
            NON_QUERY("INSERT INTO tbl_recibo_ingresos_imprimir (ReciboNo, FechaRecibo, Cliente, PrestamoNo, MontoPrestamo, FechaVencePrestamo, MontoCuota, CapitalPagado, InterePagado, MoraPagada, OtroMontoPagado, MontoRecibido, CapitalAdeudado, Atraso, Concepto, Usuario) (SELECT fld_Id_RI, fld_date, fld_socio, fld_id_prestamo," & MontoPrestamos & ", '" & formatDate(FechaVencePrestamos) & "'," & MontoCuota & ", fld_capital_cobrado, fld_interes_cobrado, fld_mora_cobrada,0,fld_monto_recibido," & bceCapital & "," & Atraso & ",fld_Description, fld_User FROM tbl_recibo_ingresos_cxc WHERE fld_Id_RI=" & RI & ")")

        Catch ex As Exception

        End Try


    End Sub

    Private WithEvents docToPrint As New Printing.PrintDocument

    Private Sub GeneraCuotas(ByVal IdPrestamo As Integer, ByVal Interes As Double, ByVal Capital As Double)
        Dim i
        Dim fechaTermina As Date = dtpFecha.Value.Date
        Dim fechaEntrega As Date = CDate(SCALAR_STRING("SELECT fld_fecha_entrega FROM tbl_prestamos WHERE fld_id_prestamos=" & IdPrestamo & ""))
        Dim cuotaNo As Integer = cuotaMin

        Dim dia As Integer = 15
        If tipoPrestamos = "Int. Adelantado" Then
            For i = 1 To (cuotaMax - cuotaMin)
                CreaCuotas(formatDate(fechaEntrega), formatDate(fechaTermina), Format(cuotaNo, "000"), Interes, 0, Interes, 0, 0)
                cuotaNo = cuotaNo + 1
                fechaTermina = dtpFecha.Value.AddMonths(i)
            Next
        Else
            For i = 1 To (cuotaMax - cuotaMin)
                CreaCuotas(formatDate(fechaEntrega), formatDate(fechaTermina), Format(cuotaNo, "000"), Interes, 0, Interes, 0, 0)
                cuotaNo = cuotaNo + 1
                fechaTermina = dtpFecha.Value.AddDays(dia)
                dia = dia + 15
            Next
        End If



        CreaCuotas(formatDate(fechaEntrega), formatDate(fechaTermina), Format(cuotaNo, "000"), Capital + Interes, Capital, Interes, 0, 0)

        create_row_estado_cliente(txtCustomerID.Text, BceAnterior - CDbl(txtMontoCobrar.Text), "DEVOLUCION_PRESTAMOS", IdPrestamo, "AJUSTE ABONO A CAPITAL", formatDate(Now.Date))
        create_row_estado_cliente(txtCustomerID.Text, ((cuotaMax - cuotaMin) * Interes) + (Capital + Interes), "PRESTAMOS", IdPrestamo, "AJUSTE ABONO A CAPITAL", formatDate(Now.Date))

        ActualizarPrestamos(CInt(fld_id_prestamo.Text), Interes, Capital, ((cuotaMax - cuotaMin) * Interes) + (Capital + Interes))
    End Sub

    Private Sub CreaCuotas(ByVal fecha_entrega As String, ByVal fecha_termina As String, ByVal no_cuotas As String, ByVal monto_cuota As Double, ByVal capital_cuotas As Double, ByVal interes_cuota As Double, ByVal fld_pendiente_amortizar As Double, ByVal fld_total_amortizado As Double)

        Dim cmd As New MySqlCommand
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "INSERT INTO tbl_cuotas (fld_no_cuotas,fld_id_del_cliente_cuotas,fld_id_del_prestamo,fld_fecha_entrega_cuotas,fld_fecha_termina_cuotas,fld_capital_cuota,fld_interes_cuota,fld_monto_cuotas,fld_abono_cuotas,fld_balance_cuotas,fld_usuario_cuotas,fld_status_cuotas,fld_pendiente_amortizar,fld_total_amortizado, fld_capital_cuota_abono, fld_capital_cuota_balance,fld_interes_cuota_abono,fld_interes_cuota_balance,fld_fecha_ultimo_abono_cuotas,fld_monto_mora, fld_abono_mora, fld_balance_mora, fld_ultimo_abono_mora,fld_ultimo_abono_interes,fld_ultimo_abono_capital,fld_socio,fld_tipo_cuotas,fld_cant_cuotas) VALUES('" & no_cuotas & "'," & CInt(txtCustomerID.Text) & ", " & CInt(fld_id_prestamo.Text) & ", '" & fecha_entrega & "','" & fecha_termina & "'," & capital_cuotas & "," & interes_cuota & ", " & monto_cuota & ", 0, " & monto_cuota & ",'" & User(0) & "', 'Nueva', " & fld_pendiente_amortizar & "," & fld_total_amortizado & ",0," & capital_cuotas & ",0," & interes_cuota & ",'" & fecha_entrega & "',0,0,0,0,0,0,'','Int. Adelantado'," & (cuotaMax - cuotaMin) + 1 & ")"
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd.Dispose()

    End Sub

    Private Sub CrearHistorial(ByVal IDPrestamo As Integer, ByVal Monto As Decimal)

        NON_QUERY("INSERT INTO tbl_historia_abono_capital (IDPrestamos, Monto, Fecha, Usuario) VALUES(" & IDPrestamo & ", " & Monto & ", Now(), '" & User(0) & "')")

        NON_QUERY("INSERT INTO tbl_cuotas_abono_capital (fld_no_cuotas, fld_id_del_cliente_cuotas, fld_id_del_prestamo, fld_fecha_entrega_cuotas, fld_fecha_termina_cuotas, fld_fecha_ultimo_abono_cuotas, fld_capital_cuota, fld_interes_cuota, fld_monto_cuotas, fld_abono_cuotas, fld_balance_cuotas, fld_usuario_cuotas, fld_status_cuotas, fld_pendiente_amortizar, fld_total_amortizado, fld_capital_cuota_abono, fld_capital_cuota_balance, fld_interes_cuota_abono, fld_interes_cuota_balance, fld_ultimo_abono_interes, fld_ultimo_abono_capital, fld_monto_mora, fld_abono_mora, fld_balance_mora, fld_ultimo_abono_mora, fld_dias_vencimiento, fld_socio, fld_atraso_cuotas, fld_tipo_cuotas, fld_bce_prestamo, fld_cant_cuotas, fldchk, fld_termina_calculo_interes, fld_fecha_calculo_interes, FechaAbonoCapital) (SELECT fld_no_cuotas, fld_id_del_cliente_cuotas, fld_id_del_prestamo, fld_fecha_entrega_cuotas, fld_fecha_termina_cuotas, fld_fecha_ultimo_abono_cuotas, fld_capital_cuota, fld_interes_cuota, fld_monto_cuotas, fld_abono_cuotas, fld_balance_cuotas, fld_usuario_cuotas, fld_status_cuotas, fld_pendiente_amortizar, fld_total_amortizado, fld_capital_cuota_abono, fld_capital_cuota_balance, fld_interes_cuota_abono, fld_interes_cuota_balance, fld_ultimo_abono_interes, fld_ultimo_abono_capital, fld_monto_mora, fld_abono_mora, fld_balance_mora, fld_ultimo_abono_mora, fld_dias_vencimiento, fld_socio, fld_atraso_cuotas, fld_tipo_cuotas, fld_bce_prestamo, fld_cant_cuotas, fldchk, fld_termina_calculo_interes, fld_fecha_calculo_interes, Now() FROM tbl_cuotas WHERE fld_id_del_prestamo=" & IDPrestamo & ");DELETE FROM tbl_cuotas WHERE fld_id_del_prestamo=" & IDPrestamo & ";")
    End Sub

    Dim rows As DataRow

    Private Sub COBRANDO()

        If Alerta("Verifique que todo sea correcto" & Chr(13) & "¿Desea continuar?") = False Then
            Exit Sub
        End If

        Dim show As New FrmPopupMessage
        show.Show("Actualizando... Por favor espere")

        create_row_estado_cliente(txtCustomerID.Text, CDbl(txtMontoCobrar.Text), "RECIBOCOBROCXC", fld_id_prestamo.Text, fld_concepto.Text, formatDate(Now.Date))

        CrearHistorial(CInt(fld_id_prestamo.Text), CDbl(txtMontoCobrar.Text))

        GeneraCuotas(CInt(fld_id_prestamo.Text), CDbl(txtInteresNuevo.Text), CDbl(txtCapitalNuevo.Text))

        CREATE_INGRESOS()


        'UPDATE_PRESTAMOS(fld_id_prestamo.Text)


        LOAD_CUSTOMER(txtCustomerID.Text)

        txtMontoCobrar.Text = "0.00"
        fld_concepto.Text = ""

        show.Close()

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
            PRINT_DOCUMENTO_RI(UltimoID("tbl_recibo_ingresos_cxc", "fld_Id_RI"), PrintDialog1.PrinterSettings.PrinterName)
        End If


        WshNetwork.SetDefaultPrinter(strOldPrinter) 'Get the Default Print


        CustBce = Nothing
        CustAddress = Nothing

    End Sub

    Private Sub CargarVariable(ByVal IdPrestamo As Integer)

        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT fld_interes_p, fld_monto_cuotas_a, fld_capital_prestamo, fld_id_prestamos  FROM tbl_prestamos WHERE fld_id_prestamos=" & IdPrestamo & "", conn)
        da.Fill(ds, "tbl_prestamos")

        For Each dr In ds.Tables(0).Rows

            porciento = dr("fld_interes_p")

            txtInteresActual.Text = Format(dr("fld_monto_cuotas_a"), "C2")

            txtCapitalActual.Text = Format(dr("fld_capital_prestamo"), "C2")

            cuotaMin = CInt(SCALAR_STRING("SELECT MIN(fld_no_cuotas) FROM tbl_cuotas WHERE fld_id_del_prestamo = " & dr("fld_id_prestamos") & " AND fld_balance_cuotas > 0"))
            cuotaMax = CInt(SCALAR_STRING("SELECT MAX(fld_no_cuotas) FROM tbl_cuotas WHERE fld_id_del_prestamo = " & dr("fld_id_prestamos") & ""))

        Next

        dtpFecha.Value = CDate(SCALAR_STRING("SELECT MIN(fld_fecha_termina_cuotas) FROM tbl_cuotas WHERE fld_id_del_prestamo = " & CInt(fld_id_prestamo.Text) & " AND fld_balance_cuotas > 0"))

        BceAnterior = SCALAR_NUM(" SELECT SUM(fld_capital_cuota_balance+fld_interes_cuota_balance) FROM tbl_cuotas WHERE fld_id_del_prestamo=" & IdPrestamo & "")

        da.Dispose()
        ds.Dispose()
    End Sub

    Private Sub LISTA_CLIENTES()
        If FRMS_POPUP_CLIENTES("TODOS") = True Then
            LOAD_CUSTOMER(Id)

            If FRMS_LIST_PRESTAMOS_POR_CLIENTE(txtFirstName.Text, Id) = True Then
                tipoPrestamos = SCALAR_STRING("SELECT fld_clasificacion FROM tbl_prestamos WHERE fld_id_prestamos=" & Id & "")

                If Trim(tipoPrestamos) <> "Int. Adelantado" Then
                    
                    Alerta("El préstamo seleccionado no es de INTERES ADELANTADO")
                    CLEAR_FIELDS()
                    Return
                End If

                fld_id_prestamo.Text = Id
                CargarVariable(CInt(fld_id_prestamo.Text))
                txtFormaDePago.Focus()

            End If

            '
            'INT ADELANTADO QUINCENAL

        End If
    End Sub

    '/BOTONES
    Private Sub btnCierra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCierra.Click
        'id = Nothing
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        CLEAR_FIELDS()

        ds.Reset()

    End Sub

    '/FIELD PROPIEDADES
    Private Sub txtMontoCobrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMontoCobrar.Click
        txtMontoCobrar.SelectAll()
    End Sub
    Private Sub txtMontoCobrar_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMontoCobrar.Enter
        txtMontoCobrar.SelectAll()
    End Sub
    Private Sub txtMontoCobrar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontoCobrar.KeyPress

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(13) Then



            Dim amount As Double = CType(txtMontoCobrar.Text, Double)
            Me.txtMontoCobrar.Text = String.Format("{0:n2}", amount)
            If amount > CDbl(txtCapitalActual.Text) Then
                Alerta("El Abono a capital no debe ser mayor al capital actual")
                Return
            End If

            txtCapitalNuevo.Text = Format(CDbl(txtCapitalActual.Text) - amount, "C2")
            txtInteresNuevo.Text = Format((CDbl(txtCapitalNuevo.Text) * porciento) / 100, "C2")


        End If

    End Sub
    Private Sub txtCustomerID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCustomerID.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(13) Then
            If txtCustomerID.Text <> "" Then
                LOAD_CUSTOMER(txtCustomerID.Text)
                If FRMS_LIST_PRESTAMOS_POR_CLIENTE(txtFirstName.Text, txtCustomerID.Text) = True Then
                    fld_id_prestamo.Text = Id

                End If
                txtFormaDePago.Focus()
            End If
        End If
    End Sub

    Private Sub btnBusca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusca.Click
        LISTA_CLIENTES()
    End Sub

    Private Sub txtFormaDePago_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFormaDePago.SelectedValueChanged

        If txtFormaDePago.Text <> "EFECTIVO" Then
            fld_detalle_forma_pago.ReadOnly = False
        Else
            fld_detalle_forma_pago.ReadOnly = True
        End If

    End Sub

    Private Sub btn_cobrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cobrar.Click
        If Trim(txtMontoCobrar.Text) = "" Then txtMontoCobrar.Text = 0

        If fld_concepto.TextLength < 10 Then
            Alerta("Escriba un concepto válido por favor")
            fld_concepto.Focus()
            Return
        End If
        If txtFormaDePago.Text = "" Then
            Alerta("Por favor seleccione una forma de pago")
            txtFormaDePago.Focus()
            Return
        End If

        If CDbl(txtMontoCobrar.Text) <= 0 Then
            Alerta("Debe ingresar el monto que desea abonar a capital")
            txtMontoCobrar.Focus()
            Return
        End If
        If CDbl(txtCapitalNuevo.Text) = 0 Then
            Alerta("Despues de digitar el Abono a Capital, debe pulsar la tecla ENTER para carcular el nuevo inreres y capital")
            Return
        End If

        COBRANDO()
        Me.Close()
    End Sub

    Private Sub txtFormaDePago_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFormaDePago.KeyDown
        If e.KeyCode = Keys.Enter Then
            fld_detalle_forma_pago.Focus()
        End If
    End Sub

    Private Sub txtFormaDePago_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFormaDePago.KeyPress
        e.Handled = True
    End Sub

    Private Sub fld_detalle_forma_pago_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fld_detalle_forma_pago.KeyDown
        If e.KeyCode = Keys.Enter Then
            fld_concepto.Focus()
        End If
    End Sub

    Private Sub txtMontoCobrar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMontoCobrar.TextChanged

    End Sub

    Private Sub fld_monto_mora_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fld_id_cuotas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumerosSINPUNTO(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub FRM_RI_ABONO_CAPITAL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            LISTA_CLIENTES()
        End If
    End Sub






End Class
