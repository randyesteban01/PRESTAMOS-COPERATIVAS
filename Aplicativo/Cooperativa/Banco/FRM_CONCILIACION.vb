Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Public Class FRM_CONCILIACION
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btn_seleccionar_documento As System.Windows.Forms.Button
    Friend WithEvents fecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents fld_saldo_banco As System.Windows.Forms.TextBox
    Friend WithEvents fld_dep_transito As System.Windows.Forms.TextBox
    Friend WithEvents fld_ck_transito As System.Windows.Forms.TextBox
    Friend WithEvents fld_bce_conciliado_banco As System.Windows.Forms.TextBox
    Friend WithEvents fld_mas As System.Windows.Forms.TextBox
    Friend WithEvents fld_menos As System.Windows.Forms.TextBox
    Friend WithEvents fld_bce_segun_computador As System.Windows.Forms.TextBox
    Friend WithEvents btn_filtrar_doc As System.Windows.Forms.Button
    Friend WithEvents fld_id_banco As System.Windows.Forms.TextBox
    Friend WithEvents LV_NC As System.Windows.Forms.ListView
    Friend WithEvents btn_calcular As System.Windows.Forms.Button
    Friend WithEvents LV_ND As System.Windows.Forms.ListView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents fld_id_doc As System.Windows.Forms.TextBox
    Friend WithEvents btn_ver_dep_trans As System.Windows.Forms.Button
    Friend WithEvents btn_ver_ck_trans As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents btn_print_dep As System.Windows.Forms.Button
    Friend WithEvents btn_print_ck As System.Windows.Forms.Button
    Friend WithEvents btn_print_mas As System.Windows.Forms.Button
    Friend WithEvents btn_print_menos As System.Windows.Forms.Button
    Friend WithEvents fld_cta_bancaria_no As System.Windows.Forms.TextBox
    Friend WithEvents fld_bce_conciliadio_segun_pc As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents fld_depositos_registrados As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents fld_cheques_emitidos As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_CONCILIACION))
        Me.fecha1 = New System.Windows.Forms.DateTimePicker
        Me.fecha2 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.fld_saldo_banco = New System.Windows.Forms.TextBox
        Me.fld_dep_transito = New System.Windows.Forms.TextBox
        Me.fld_ck_transito = New System.Windows.Forms.TextBox
        Me.fld_bce_conciliado_banco = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.btn_seleccionar_documento = New System.Windows.Forms.Button
        Me.btn_filtrar_doc = New System.Windows.Forms.Button
        Me.fld_bce_segun_computador = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.LV_NC = New System.Windows.Forms.ListView
        Me.fld_mas = New System.Windows.Forms.TextBox
        Me.fld_menos = New System.Windows.Forms.TextBox
        Me.LV_ND = New System.Windows.Forms.ListView
        Me.fld_bce_conciliadio_segun_pc = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.fld_id_banco = New System.Windows.Forms.TextBox
        Me.btn_calcular = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_ver_dep_trans = New System.Windows.Forms.Button
        Me.btn_ver_ck_trans = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.fld_id_doc = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btn_print_ck = New System.Windows.Forms.Button
        Me.btn_print_dep = New System.Windows.Forms.Button
        Me.fld_cta_bancaria_no = New System.Windows.Forms.TextBox
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.btn_print_mas = New System.Windows.Forms.Button
        Me.btn_print_menos = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.fld_depositos_registrados = New System.Windows.Forms.TextBox
        Me.fld_cheques_emitidos = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'fecha1
        '
        Me.fecha1.CustomFormat = "dd / MMMM / yyyy"
        Me.fecha1.Enabled = False
        Me.fecha1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecha1.Location = New System.Drawing.Point(168, 6)
        Me.fecha1.Name = "fecha1"
        Me.fecha1.ShowUpDown = True
        Me.fecha1.Size = New System.Drawing.Size(144, 20)
        Me.fecha1.TabIndex = 0
        '
        'fecha2
        '
        Me.fecha2.CustomFormat = "dd / MMMM / yyyy"
        Me.fecha2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecha2.Location = New System.Drawing.Point(480, 8)
        Me.fecha2.Name = "fecha2"
        Me.fecha2.ShowUpDown = True
        Me.fecha2.Size = New System.Drawing.Size(144, 20)
        Me.fecha2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(24, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SALDO SEGÚN EL BANCO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(24, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "más:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(24, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Depositos en Transito"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(24, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cheques en Transito"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(24, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "menos:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fld_saldo_banco
        '
        Me.fld_saldo_banco.Location = New System.Drawing.Point(200, 61)
        Me.fld_saldo_banco.Name = "fld_saldo_banco"
        Me.fld_saldo_banco.Size = New System.Drawing.Size(112, 20)
        Me.fld_saldo_banco.TabIndex = 7
        Me.fld_saldo_banco.Text = "0.00"
        Me.fld_saldo_banco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fld_dep_transito
        '
        Me.fld_dep_transito.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.fld_dep_transito.Location = New System.Drawing.Point(200, 93)
        Me.fld_dep_transito.Name = "fld_dep_transito"
        Me.fld_dep_transito.ReadOnly = True
        Me.fld_dep_transito.Size = New System.Drawing.Size(112, 20)
        Me.fld_dep_transito.TabIndex = 8
        Me.fld_dep_transito.Text = "0.00"
        Me.fld_dep_transito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fld_ck_transito
        '
        Me.fld_ck_transito.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.fld_ck_transito.ForeColor = System.Drawing.SystemColors.WindowText
        Me.fld_ck_transito.Location = New System.Drawing.Point(200, 125)
        Me.fld_ck_transito.Name = "fld_ck_transito"
        Me.fld_ck_transito.ReadOnly = True
        Me.fld_ck_transito.Size = New System.Drawing.Size(112, 20)
        Me.fld_ck_transito.TabIndex = 9
        Me.fld_ck_transito.Text = "0.00"
        Me.fld_ck_transito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fld_bce_conciliado_banco
        '
        Me.fld_bce_conciliado_banco.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.fld_bce_conciliado_banco.Location = New System.Drawing.Point(512, 149)
        Me.fld_bce_conciliado_banco.Name = "fld_bce_conciliado_banco"
        Me.fld_bce_conciliado_banco.ReadOnly = True
        Me.fld_bce_conciliado_banco.Size = New System.Drawing.Size(112, 20)
        Me.fld_bce_conciliado_banco.TabIndex = 11
        Me.fld_bce_conciliado_banco.Text = "0.00"
        Me.fld_bce_conciliado_banco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(264, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(248, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "BALANCE CONCILIADO SEGUN BANCO"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_seleccionar_documento
        '
        Me.btn_seleccionar_documento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_seleccionar_documento.ForeColor = System.Drawing.Color.Black
        Me.btn_seleccionar_documento.Location = New System.Drawing.Point(24, 32)
        Me.btn_seleccionar_documento.Name = "btn_seleccionar_documento"
        Me.btn_seleccionar_documento.Size = New System.Drawing.Size(288, 23)
        Me.btn_seleccionar_documento.TabIndex = 12
        Me.btn_seleccionar_documento.Text = "&Seleccionar Documentos en Transitos"
        '
        'btn_filtrar_doc
        '
        Me.btn_filtrar_doc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_filtrar_doc.ForeColor = System.Drawing.Color.Black
        Me.btn_filtrar_doc.Location = New System.Drawing.Point(480, 32)
        Me.btn_filtrar_doc.Name = "btn_filtrar_doc"
        Me.btn_filtrar_doc.Size = New System.Drawing.Size(144, 23)
        Me.btn_filtrar_doc.TabIndex = 13
        Me.btn_filtrar_doc.Text = "&Filtrar Documentos"
        '
        'fld_bce_segun_computador
        '
        Me.fld_bce_segun_computador.BackColor = System.Drawing.Color.White
        Me.fld_bce_segun_computador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_bce_segun_computador.Location = New System.Drawing.Point(208, 184)
        Me.fld_bce_segun_computador.Name = "fld_bce_segun_computador"
        Me.fld_bce_segun_computador.Size = New System.Drawing.Size(112, 20)
        Me.fld_bce_segun_computador.TabIndex = 15
        Me.fld_bce_segun_computador.Text = "0.00"
        Me.fld_bce_segun_computador.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(176, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "SALDO SEGÚN C / ANTERIOR"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LV_NC
        '
        Me.LV_NC.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.LV_NC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV_NC.Location = New System.Drawing.Point(24, 224)
        Me.LV_NC.Name = "LV_NC"
        Me.LV_NC.Size = New System.Drawing.Size(472, 70)
        Me.LV_NC.TabIndex = 17
        '
        'fld_mas
        '
        Me.fld_mas.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.fld_mas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_mas.Location = New System.Drawing.Point(384, 298)
        Me.fld_mas.Name = "fld_mas"
        Me.fld_mas.ReadOnly = True
        Me.fld_mas.Size = New System.Drawing.Size(88, 20)
        Me.fld_mas.TabIndex = 18
        Me.fld_mas.Text = "0.00"
        Me.fld_mas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fld_menos
        '
        Me.fld_menos.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.fld_menos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_menos.Location = New System.Drawing.Point(384, 444)
        Me.fld_menos.Name = "fld_menos"
        Me.fld_menos.ReadOnly = True
        Me.fld_menos.Size = New System.Drawing.Size(88, 20)
        Me.fld_menos.TabIndex = 20
        Me.fld_menos.Text = "0.00"
        Me.fld_menos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LV_ND
        '
        Me.LV_ND.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.LV_ND.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV_ND.Location = New System.Drawing.Point(24, 344)
        Me.LV_ND.Name = "LV_ND"
        Me.LV_ND.Size = New System.Drawing.Size(472, 96)
        Me.LV_ND.TabIndex = 19
        '
        'fld_bce_conciliadio_segun_pc
        '
        Me.fld_bce_conciliadio_segun_pc.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.fld_bce_conciliadio_segun_pc.Location = New System.Drawing.Point(512, 469)
        Me.fld_bce_conciliadio_segun_pc.Name = "fld_bce_conciliadio_segun_pc"
        Me.fld_bce_conciliadio_segun_pc.ReadOnly = True
        Me.fld_bce_conciliadio_segun_pc.Size = New System.Drawing.Size(112, 20)
        Me.fld_bce_conciliadio_segun_pc.TabIndex = 23
        Me.fld_bce_conciliadio_segun_pc.Text = "0.00"
        Me.fld_bce_conciliadio_segun_pc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(248, 471)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(264, 16)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "BALANCE CONCILIADO SEGUN COMPUTADOR"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Button3.Location = New System.Drawing.Point(24, 201)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 23)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Más"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Red
        Me.Button4.Location = New System.Drawing.Point(24, 321)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 23)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "Menos"
        '
        'fld_id_banco
        '
        Me.fld_id_banco.Location = New System.Drawing.Point(512, 104)
        Me.fld_id_banco.Name = "fld_id_banco"
        Me.fld_id_banco.Size = New System.Drawing.Size(112, 20)
        Me.fld_id_banco.TabIndex = 31
        Me.fld_id_banco.Text = "0"
        Me.fld_id_banco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.fld_id_banco.Visible = False
        '
        'btn_calcular
        '
        Me.btn_calcular.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_calcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calcular.ForeColor = System.Drawing.Color.Black
        Me.btn_calcular.Location = New System.Drawing.Point(480, 184)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(144, 23)
        Me.btn_calcular.TabIndex = 32
        Me.btn_calcular.Text = "&Calcular"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(-2, 172)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(647, 4)
        Me.Panel1.TabIndex = 33
        '
        'btn_ver_dep_trans
        '
        Me.btn_ver_dep_trans.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_ver_dep_trans.ForeColor = System.Drawing.Color.Black
        Me.btn_ver_dep_trans.Location = New System.Drawing.Point(320, 92)
        Me.btn_ver_dep_trans.Name = "btn_ver_dep_trans"
        Me.btn_ver_dep_trans.Size = New System.Drawing.Size(40, 23)
        Me.btn_ver_dep_trans.TabIndex = 34
        Me.btn_ver_dep_trans.Text = "&Ver"
        '
        'btn_ver_ck_trans
        '
        Me.btn_ver_ck_trans.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_ver_ck_trans.ForeColor = System.Drawing.Color.Black
        Me.btn_ver_ck_trans.Location = New System.Drawing.Point(320, 124)
        Me.btn_ver_ck_trans.Name = "btn_ver_ck_trans"
        Me.btn_ver_ck_trans.Size = New System.Drawing.Size(40, 23)
        Me.btn_ver_ck_trans.TabIndex = 35
        Me.btn_ver_ck_trans.Text = "V&er"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(24, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(216, 16)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Fecha última Conciliación"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(384, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(216, 16)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Fecha Conciliación"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fld_id_doc
        '
        Me.fld_id_doc.Location = New System.Drawing.Point(448, 104)
        Me.fld_id_doc.Name = "fld_id_doc"
        Me.fld_id_doc.Size = New System.Drawing.Size(56, 20)
        Me.fld_id_doc.TabIndex = 38
        Me.fld_id_doc.Text = "0"
        Me.fld_id_doc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.fld_id_doc.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btn_print_ck)
        Me.Panel2.Controls.Add(Me.btn_print_dep)
        Me.Panel2.Controls.Add(Me.fld_cta_bancaria_no)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel2.Location = New System.Drawing.Point(-3, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(648, 176)
        Me.Panel2.TabIndex = 39
        '
        'btn_print_ck
        '
        Me.btn_print_ck.BackColor = System.Drawing.Color.Khaki
        Me.btn_print_ck.Image = CType(resources.GetObject("btn_print_ck.Image"), System.Drawing.Image)
        Me.btn_print_ck.Location = New System.Drawing.Point(168, 120)
        Me.btn_print_ck.Name = "btn_print_ck"
        Me.btn_print_ck.Size = New System.Drawing.Size(32, 24)
        Me.btn_print_ck.TabIndex = 41
        '
        'btn_print_dep
        '
        Me.btn_print_dep.BackColor = System.Drawing.Color.Khaki
        Me.btn_print_dep.Image = CType(resources.GetObject("btn_print_dep.Image"), System.Drawing.Image)
        Me.btn_print_dep.Location = New System.Drawing.Point(168, 88)
        Me.btn_print_dep.Name = "btn_print_dep"
        Me.btn_print_dep.Size = New System.Drawing.Size(32, 24)
        Me.btn_print_dep.TabIndex = 40
        '
        'fld_cta_bancaria_no
        '
        Me.fld_cta_bancaria_no.Location = New System.Drawing.Point(448, 72)
        Me.fld_cta_bancaria_no.Name = "fld_cta_bancaria_no"
        Me.fld_cta_bancaria_no.Size = New System.Drawing.Size(56, 20)
        Me.fld_cta_bancaria_no.TabIndex = 44
        Me.fld_cta_bancaria_no.Text = "0"
        Me.fld_cta_bancaria_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.fld_cta_bancaria_no.Visible = False
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6, Me.MenuItem7, Me.MenuItem8})
        Me.MenuItem1.Text = "&Archivo"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "&Nueva"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "&Guardar"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 3
        Me.MenuItem5.Text = "&Consultar"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 4
        Me.MenuItem6.Text = "&Imprimir"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 5
        Me.MenuItem7.Text = "-"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 6
        Me.MenuItem8.Text = "C&errar"
        '
        'btn_print_mas
        '
        Me.btn_print_mas.BackColor = System.Drawing.Color.Khaki
        Me.btn_print_mas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print_mas.Image = CType(resources.GetObject("btn_print_mas.Image"), System.Drawing.Image)
        Me.btn_print_mas.Location = New System.Drawing.Point(104, 200)
        Me.btn_print_mas.Name = "btn_print_mas"
        Me.btn_print_mas.Size = New System.Drawing.Size(32, 24)
        Me.btn_print_mas.TabIndex = 42
        '
        'btn_print_menos
        '
        Me.btn_print_menos.BackColor = System.Drawing.Color.Khaki
        Me.btn_print_menos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print_menos.Image = CType(resources.GetObject("btn_print_menos.Image"), System.Drawing.Image)
        Me.btn_print_menos.Location = New System.Drawing.Point(104, 320)
        Me.btn_print_menos.Name = "btn_print_menos"
        Me.btn_print_menos.Size = New System.Drawing.Size(32, 24)
        Me.btn_print_menos.TabIndex = 43
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 300)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(176, 16)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "DEPOSITOS REGISTRADOS"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fld_depositos_registrados
        '
        Me.fld_depositos_registrados.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.fld_depositos_registrados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_depositos_registrados.Location = New System.Drawing.Point(208, 298)
        Me.fld_depositos_registrados.Name = "fld_depositos_registrados"
        Me.fld_depositos_registrados.Size = New System.Drawing.Size(112, 20)
        Me.fld_depositos_registrados.TabIndex = 45
        Me.fld_depositos_registrados.Text = "0.00"
        Me.fld_depositos_registrados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fld_cheques_emitidos
        '
        Me.fld_cheques_emitidos.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.fld_cheques_emitidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_cheques_emitidos.Location = New System.Drawing.Point(208, 444)
        Me.fld_cheques_emitidos.Name = "fld_cheques_emitidos"
        Me.fld_cheques_emitidos.Size = New System.Drawing.Size(112, 20)
        Me.fld_cheques_emitidos.TabIndex = 47
        Me.fld_cheques_emitidos.Text = "0.00"
        Me.fld_cheques_emitidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(24, 446)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(176, 16)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "CHEQUES EMITIDOS"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Khaki
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(172, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 24)
        Me.Button1.TabIndex = 48
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Khaki
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(172, 442)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 24)
        Me.Button2.TabIndex = 49
        '
        'FRM_CONCILIACION
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(642, 493)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.fld_cheques_emitidos)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.fld_depositos_registrados)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btn_print_menos)
        Me.Controls.Add(Me.fld_id_doc)
        Me.Controls.Add(Me.btn_ver_ck_trans)
        Me.Controls.Add(Me.btn_ver_dep_trans)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.fld_id_banco)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.fld_bce_conciliadio_segun_pc)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.fld_menos)
        Me.Controls.Add(Me.LV_ND)
        Me.Controls.Add(Me.fld_mas)
        Me.Controls.Add(Me.LV_NC)
        Me.Controls.Add(Me.fld_bce_segun_computador)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_filtrar_doc)
        Me.Controls.Add(Me.btn_seleccionar_documento)
        Me.Controls.Add(Me.fld_bce_conciliado_banco)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.fld_ck_transito)
        Me.Controls.Add(Me.fld_dep_transito)
        Me.Controls.Add(Me.fld_saldo_banco)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fecha2)
        Me.Controls.Add(Me.fecha1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_print_mas)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "FRM_CONCILIACION"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conciliacion Bancaria"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub FRM_CONCILIACION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        LOAD_DATA_BANCO(fld_id_banco.Text)
        fecha1.Text = ult_fecha()
    End Sub

    Private Sub FRM_CONCILIACION_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

    End Sub

    Private Sub FRM_CONCILIACION_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress

    End Sub

    Private Sub btn_seleccionar_documento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_seleccionar_documento.Click
        FRMS_SELECCIONAR_DOC_TRANSITOS(fld_id_banco.Text)
    End Sub

    Private Sub CLEAR_DATA()
        fld_saldo_banco.Text = "0.00"
        fld_dep_transito.Text = "0.00"
        fld_ck_transito.Text = "0.00"
        fld_bce_conciliado_banco.Text = "0.00"
        fld_bce_segun_computador.Text = "0.00"
        fld_mas.Text = "0.00"
        fld_menos.Text = "0.00"
        fld_bce_conciliadio_segun_pc.Text = "0.00"
        LV_NC.Clear()
        LV_ND.Clear()
        fecha1.Text = ult_fecha()
        fecha2.Text = Now
        fld_cta_bancaria_no.Text = "0"
        fld_id_doc.Text = "0"
        fld_id_banco.Text = "0"
        MenuItem3.Enabled = True
        btn_filtrar_doc.Enabled = True
        btn_calcular.Enabled = True
        btn_seleccionar_documento.Enabled = True
    End Sub
    Private Function VALIDA_DATA() As Boolean

        If CDbl(fld_bce_conciliado_banco.Text) <> CDbl(fld_bce_conciliadio_segun_pc.Text) Then
            Alerta("La conciliación no está cuadrara")
            Return False
        ElseIf fecha1.Value.Date >= fecha2.Value.Date Then
            Alerta("La fecha de la conciliación es incorrecta")
            Return False
        End If
        Return True
    End Function
    Private Sub SAVE_DATA()
        If VALIDA_DATA() = False Then Exit Sub
        NON_QUERY("INSERT INTO tbl_conciliacion (fld_fecha_ultima_conciliacion, fld_al_fecha, fld_saldo_banco, fld_dep_transito, fld_ck_transito, fld_bce_conciliado_banco, fld_bce_segun_computador, fld_mas, fld_menos, fld_bce_conciliadio_segun_pc,fld_id_banco,fld_desp_banco,fld_cta_bancaria_no,fld_user_maked,fld_depositos_registrados,fld_cheques_emitidos)VALUES('" & formatDate(fecha1.Value.Date) & "','" & formatDate(fecha2.Value.Date) & "'," & CDbl(fld_saldo_banco.Text) & "," & CDbl(fld_dep_transito.Text) & "," & CDbl(fld_ck_transito.Text) & "," & CDbl(fld_bce_conciliado_banco.Text) & "," & CDbl(fld_bce_segun_computador.Text) & "," & CDbl(fld_mas.Text) & "," & CDbl(fld_menos.Text) & "," & CDbl(fld_bce_conciliadio_segun_pc.Text) & ",'" & fld_id_banco.Text & "','" & Me.Text & "','" & fld_cta_bancaria_no.Text & "','" & User(0) & "'," & CDbl(fld_depositos_registrados.Text) & "," & CDbl(fld_cheques_emitidos.Text) & ")")
        fld_id_doc.Text = UltimoID("tbl_conciliacion", "fld_id_con")
        READ_SAVE_CK()
        READ_SAVE_DEP()
    End Sub
    Private Sub LOAD_DATA(ByVal ID_DOC As String)
        Dim sqlString As String = "SELECT * FROM tbl_conciliacion WHERE fld_id_con=" & ID_DOC & ""
        Dim dr As DataRow, ds As New DataSet, da As New MySqlDataAdapter(sqlString, conn)
        da.Fill(ds, "tbl_conciliacion")

        For Each dr In ds.Tables(0).Rows
            fld_saldo_banco.Text = Format(dr("fld_saldo_banco"), "C2")
            fld_dep_transito.Text = Format(dr("fld_dep_transito"), "C2")
            fld_ck_transito.Text = Format(dr("fld_ck_transito"), "C2")
            fld_bce_conciliado_banco.Text = Format(dr("fld_bce_conciliado_banco"), "C2")
            fld_bce_segun_computador.Text = Format(dr("fld_bce_segun_computador"), "C2")
            fld_mas.Text = Format(dr("fld_mas"), "C2")
            fld_menos.Text = Format(dr("fld_menos"), "C2")
            fld_depositos_registrados.Text = Format(dr("fld_depositos_registrados"), "C2")
            fld_cheques_emitidos.Text = Format(dr("fld_cheques_emitidos"), "C2")
            fld_bce_conciliadio_segun_pc.Text = Format(dr("fld_bce_conciliadio_segun_pc"), "C2")
            fecha1.Text = dr("fld_fecha_ultima_conciliacion")
            fecha2.Text = dr("fld_al_fecha")
            fld_cta_bancaria_no.Text = dr("fld_cta_bancaria_no")
            fld_id_doc.Text = ID_DOC
            fld_id_banco.Text = dr("fld_id_banco")
            LOAD_DATA_BANCO(fld_id_banco.Text)
            FillLV_NC()
            FillLV_ND()
            MenuItem3.Enabled = False
        Next

    End Sub
    Private Function ult_fecha() As Date

        Dim cmd As New MySqlCommand, last_date As Date
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT MAX(fld_al_fecha) FROM tbl_conciliacion WHERE fld_cta_bancaria_no='" & fld_cta_bancaria_no.Text & "'"
            If .ExecuteScalar().GetType.ToString = "System.DBNull" Then
                last_date = Now.Date
                fecha1.Enabled = True
            Else
                last_date = .ExecuteScalar()
            End If

            .Connection.Close()
        End With
        cmd.Dispose()
        bce_mes(last_date)
        Return last_date
    End Function
    Private Sub bce_mes(ByVal fechas As Date)
        Dim cmd As New MySqlCommand, bce As Double = 0, dr As MySqlDataReader
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT * FROM tbl_conciliacion WHERE fld_cta_bancaria_no='" & fld_cta_bancaria_no.Text & "' AND fld_al_fecha='" & formatDate(fechas) & "'"
            dr = .ExecuteReader
        End With

        If dr.Read Then
            bce = dr("fld_bce_conciliadio_segun_pc")
        End If

        dr.Close()
        dr = Nothing
        cmd.Connection.Close()
        cmd.Dispose()

        fld_bce_segun_computador.Text = Format(bce, "##,#00.00")

    End Sub



    Private Sub SAVE_DATA_CK_TRANS(ByVal id_conciliacion As String, ByVal fld_no_ck As String, ByVal fld_fecha_ck As Date, ByVal fld_monto_ck As Double)
        NON_QUERY("INSERT INTO tbl_cheques_trans (fld_id_conciliacion_ck, fld_no_ck, fld_fecha_ck, fld_monto_ck)VALUES(" & id_conciliacion & ",'" & fld_no_ck & "','" & formatDate(fld_fecha_ck) & "'," & fld_monto_ck & ")")
    End Sub
    Private Sub READ_SAVE_CK()
        DEL_CK_TRANS()
        Dim sqlString As String = "SELECT * FROM tbl_cheques WHERE fld_ck_no > 0 AND fld_estado='EMISION' AND fld_id_banco='" & fld_id_banco.Text & "' AND fld_transito='SI' AND fld_fecha <= '" & formatDate(fecha2.Value.Date) & "'"
        Dim ds As New DataSet, dr As DataRow, da As New MySqlDataAdapter(sqlString, conn)
        da.Fill(ds, "tbl_cheques")
        For Each dr In ds.Tables(0).Rows
            SAVE_DATA_CK_TRANS(fld_id_doc.Text, dr("fld_ck_no"), dr("fld_fecha"), dr("fld_monto"))
        Next
        ds.Dispose()
        da.Dispose()
    End Sub
    Private Sub DEL_CK_TRANS()
       NON_QUERY("DELETE FROM tbl_cheques_trans WHERE fld_id_conciliacion_ck=" & fld_id_doc.Text & "")

    End Sub


    Private Sub SAVE_DATA_DEP_TRANS(ByVal id_conciliacion As String, ByVal fld_no_dep As String, ByVal fld_fecha_dep As Date, ByVal fld_monto_dep As Double)
      NON_QUERY("INSERT INTO tbl_deposito_trans (fld_id_conciliacion_dep, fld_no_dep, fld_fecha_dep, fld_monto_dep)VALUES(" & id_conciliacion & ",'" & fld_no_dep & "','" & formatDate(fld_fecha_dep) & "'," & fld_monto_dep & ")")
    End Sub
    Private Sub READ_SAVE_DEP()
        DEL_DEP_TRANS()
        Dim sqlString As String = "SELECT * FROM tbl_deposito WHERE  fld_id_banco='" & fld_id_banco.Text & "' AND fld_transito='SI' AND fld_fecha <= '" & formatDate(fecha2.Value.Date) & "'"
        Dim ds As New DataSet, dr As DataRow, da As New MySqlDataAdapter(sqlString, conn)
        da.Fill(ds, "tbl_deposito")
        For Each dr In ds.Tables(0).Rows
            SAVE_DATA_DEP_TRANS(fld_id_doc.Text, dr("fld_id_doc"), dr("fld_fecha"), dr("fld_monto"))
        Next
        ds.Dispose()
        da.Dispose()

    End Sub
    Private Sub DEL_DEP_TRANS()
        NON_QUERY("DELETE FROM tbl_deposito_trans WHERE fld_id_conciliacion_dep=" & fld_id_doc.Text & "")

    End Sub

    Private Sub LOAD_DATA_BANCO(ByVal Valor As String)
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM TBL_BANCOS WHERE FLD_CODIGO='" & Valor & "'", conn)
        da.Fill(ds, "TBL_BANCOS")
        For Each dr In ds.Tables(0).Rows

            Me.Text = "Conciliación Bancaria para " & dr("FLD_NOMBRE")
            'fld_bce_segun_computador.Text = Format(dr("fld_balance"), "C2")
            fld_cta_bancaria_no.Text = dr("fld_cuenta")
            GoTo exite
        Next
        Alerta("EL DOCUMENTO SOLICITADO NO EXISTE EN LA BASE DE DATOS")

        ds.Dispose()
        da.Dispose()
        Exit Sub
exite:
        ds.Dispose()
        da.Dispose()
    End Sub 'LOAD DATA FROM DATA BASE "TBL_BANCO"

    Private Sub CALCULO_BANCO()

        fld_bce_conciliado_banco.Text = Format(((CDbl(fld_saldo_banco.Text) + CDbl(fld_dep_transito.Text)) - CDbl(fld_ck_transito.Text)), "C2")


    End Sub
    Private Sub CALCULO_pc()
        fld_cheques_emitidos.Text = Format(RETURN_MONTO_CK_PC(), "C2")
        fld_depositos_registrados.Text = Format(RETURN_MONTO_DEP_PC(), "C2")
        fld_bce_conciliadio_segun_pc.Text = Format(((CDbl(fld_bce_segun_computador.Text) + CDbl(fld_mas.Text)) - CDbl(fld_menos.Text)), "C2")

        fld_bce_conciliadio_segun_pc.Text = Format((CDbl(fld_bce_conciliadio_segun_pc.Text) + CDbl(fld_depositos_registrados.Text)) - CDbl(fld_cheques_emitidos.Text), "C2")

    End Sub

 
    Private Function RETURN_MONTO_CK() As Double
        Dim cmd_registro As New MySqlCommand, hay As Double

        With cmd_registro
            .Connection = conn
            .Connection.Open()

            .CommandText = "SELECT COUNT(*) FROM tbl_cheques WHERE fld_ck_no > 0 AND fld_estado='EMISION' AND fld_id_banco='" & fld_id_banco.Text & "' AND fld_transito='SI' AND fld_fecha <= '" & formatDate(fecha2.Value.Date) & "'"
            hay = .ExecuteScalar
            .Connection.Close()
        End With

        cmd_registro.Dispose()
        If hay = 0 Then Exit Function

        Dim cmd As New MySqlCommand, MONTO As Double = 0
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT SUM(fld_monto) FROM tbl_cheques WHERE fld_ck_no > 0 AND fld_estado='EMISION' AND fld_id_banco='" & fld_id_banco.Text & "' AND fld_transito='SI' AND fld_fecha <= '" & formatDate(fecha2.Value.Date) & "'"
            MONTO = .ExecuteScalar

            .Connection.Close()
        End With
        cmd.Dispose()
        Return MONTO
    End Function
    Private Function RETURN_MONTO_DEP() As Double
        Dim cmd_registro As New MySqlCommand, hay As Double

        With cmd_registro
            .Connection = conn
            .Connection.Open()

            .CommandText = "SELECT COUNT(*) FROM tbl_deposito WHERE fld_id_banco='" & fld_id_banco.Text & "' AND fld_transito='SI' AND fld_fecha <= '" & formatDate(fecha2.Value.Date) & "'"
            hay = .ExecuteScalar
            .Connection.Close()
        End With

        cmd_registro.Dispose()

        If hay = 0 Then Exit Function

        Dim cmd As New MySqlCommand, MONTO As Double
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT SUM(fld_monto) FROM tbl_deposito WHERE  fld_id_banco='" & fld_id_banco.Text & "' AND fld_transito='SI' AND fld_fecha <= '" & formatDate(fecha2.Value.Date) & "'"
            MONTO = .ExecuteScalar
            .Connection.Close()
        End With
        cmd.Dispose()
        Return MONTO
    End Function

    Private Function RETURN_MONTO_CK_PC() As Double
        Dim cmd_registro As New MySqlCommand, hay As Double

        With cmd_registro
            .Connection = conn
            .Connection.Open()

            .CommandText = "SELECT COUNT(*) FROM tbl_cheques WHERE fld_ck_no > 0 AND fld_estado='EMISION' AND fld_id_banco='" & fld_id_banco.Text & "' AND fld_fecha > '" & formatDate(fecha1.Value.Date) & "' AND fld_fecha <= '" & formatDate(fecha2.Value.Date) & "'"
            hay = .ExecuteScalar
            .Connection.Close()
        End With

        cmd_registro.Dispose()
        If hay = 0 Then Exit Function

        Dim cmd As New MySqlCommand, MONTO As Double
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT SUM(fld_monto) FROM tbl_cheques WHERE fld_ck_no > 0 AND fld_estado='EMISION' AND fld_id_banco='" & fld_id_banco.Text & "'AND fld_fecha > '" & formatDate(fecha1.Value.Date) & "' AND fld_fecha <= '" & formatDate(fecha2.Value.Date) & "'"
            MONTO = .ExecuteScalar

            .Connection.Close()
        End With
        cmd.Dispose()
        Return MONTO
    End Function
    Private Function RETURN_MONTO_DEP_PC() As Double
        Dim cmd_registro As New MySqlCommand, hay As Double

        With cmd_registro
            .Connection = conn
            .Connection.Open()

            .CommandText = "SELECT COUNT(*) FROM tbl_deposito WHERE fld_id_banco='" & fld_id_banco.Text & "' AND fld_fecha > '" & formatDate(fecha1.Value.Date) & "' AND fld_fecha <= '" & formatDate(fecha2.Value.Date) & "'"
            hay = .ExecuteScalar
            .Connection.Close()
        End With

        cmd_registro.Dispose()

        If hay = 0 Then Exit Function

        Dim cmd As New MySqlCommand, MONTO As Double
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT SUM(fld_monto) FROM tbl_deposito WHERE  fld_id_banco='" & fld_id_banco.Text & "' AND fld_fecha > '" & formatDate(fecha1.Value.Date) & "' AND fld_fecha <= '" & formatDate(fecha2.Value.Date) & "'"
            MONTO = .ExecuteScalar
            .Connection.Close()
        End With
        cmd.Dispose()
        Return MONTO
    End Function


    Private Sub FillLV_NC()

        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        LV_NC.Clear()
        LV_NC.View = View.Details
        LV_NC.LabelEdit = False
        LV_NC.FullRowSelect = True
        LV_NC.GridLines = True
        LV_NC.MultiSelect = False
        LV_NC.Sorting = SortOrder.Ascending



        Dim sqlSearch As String
        Dim accion As Short, estado As String

        sqlSearch = "SELECT fld_id_doc, fld_fecha, fld_descripcion, fld_monto FROM tbl_nc_bancaria WHERE fld_id_banco='" & fld_id_banco.Text & "' AND fld_fecha > '" & formatDate(fecha1.Value.Date) & "' AND fld_fecha <='" & formatDate(fecha2.Value.Date) & "'"

        ds.Reset()
        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, "tbl_nc_bancaria")
        Dim dr As DataRow
        fld_mas.Text = "0"
        For Each dr In ds.Tables(0).Rows
            fld_mas.Text = Format(CDbl(fld_mas.Text) + dr("fld_monto"), "C2")
        Next


        Dim columnText(5) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "Doc. No."
        columnText(1) = "FECHA"
        columnText(2) = "CONCEPTO"
        columnText(3) = "MONTO"
        columnText(4) = "MONTO"

        Dim columnWidth(5) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 0
        columnWidth(1) = 85
        columnWidth(2) = 275
        columnWidth(3) = 85
        columnWidth(4) = 0

        Dim columnAlign(5) As Int32 'PARA ALINEAR LOS DATOS
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 0 'IZQUIERDA
        columnAlign(3) = 1 'DERECHA
        columnAlign(4) = 1 'DERECHA


        Dim count = 0
        Dim c As DataColumn
        For Each c In ds.Tables(0).Columns
            'adding names of columns as Listview columns				
            Dim h As New ColumnHeader
            h.Text = columnText(count) ' c.ColumnName
            h.TextAlign = columnAlign(count)
            h.Width = columnWidth(count)
            Me.LV_NC.Columns.Add(h)
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
                    str(col) = Format(rr(col), "C2")
                End If
            Next

            Dim ii As New ListViewItem(str)
            LV_NC.Items.Add(ii)
            'showing the number of records still added
        Next


    End Sub
    Private Sub FillLV_ND()

        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        LV_ND.Clear()
        LV_ND.View = View.Details
        LV_ND.LabelEdit = False
        LV_ND.FullRowSelect = True
        LV_ND.GridLines = True
        LV_ND.MultiSelect = False
        LV_ND.Sorting = SortOrder.Ascending



        Dim sqlSearch As String
        Dim accion As Short, estado As String

        sqlSearch = "SELECT fld_id_doc, fld_fecha, fld_descripcion, fld_monto FROM tbl_nd_bancaria WHERE fld_id_banco='" & fld_id_banco.Text & "' AND fld_fecha > '" & formatDate(fecha1.Value.Date) & "' AND fld_fecha <='" & formatDate(fecha2.Value.Date) & "'"

        ds.Reset()
        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, "tbl_nd_bancaria")

        Dim dr As DataRow
        fld_menos.Text = "0"
        For Each dr In ds.Tables(0).Rows
            fld_menos.Text = Format(CDbl(fld_menos.Text) + dr("fld_monto"), "C2")
        Next
        Dim columnText(5) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "Doc. No."
        columnText(1) = "FECHA"
        columnText(2) = "CONCEPTO"
        columnText(3) = "MONTO"
        columnText(4) = "MONTO"

        Dim columnWidth(5) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 0
        columnWidth(1) = 85
        columnWidth(2) = 275
        columnWidth(3) = 85
        columnWidth(4) = 0

        Dim columnAlign(5) As Int32 'PARA ALINEAR LOS DATOS
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 0 'IZQUIERDA
        columnAlign(3) = 1 'DERECHA
        columnAlign(4) = 1 'DERECHA


        Dim count = 0
        Dim c As DataColumn
        For Each c In ds.Tables(0).Columns
            'adding names of columns as Listview columns				
            Dim h As New ColumnHeader
            h.Text = columnText(count) ' c.ColumnName
            h.TextAlign = columnAlign(count)
            h.Width = columnWidth(count)
            Me.LV_ND.Columns.Add(h)
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
                    str(col) = Format(rr(col), "C2")
                End If
            Next

            Dim ii As New ListViewItem(str)
            LV_ND.Items.Add(ii)
            'showing the number of records still added
        Next


    End Sub

    Private Sub PRINT_CONCI()
        If fld_id_doc.Text = "0" Then
            Alerta("La Conciliación no ha sido guardada")
            Exit Sub
        End If
         '/INI FILE
        Dim PrintName As String = objIniFile.GetString("PRINTER", "Name", "(none)")

        Dim asking = Alerta("¿Desea imprimir la Conciliación?")
        

        If Asking = False Then
            Exit Sub
        End If

        Dim ds As New DataSet

        Dim daProf As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
        daProf.Fill(ds, "tbl_profiledocument")

        Dim daRecord As New MySqlDataAdapter("SELECT * FROM tbl_conciliacion WHERE fld_id_con=" & fld_id_doc.Text & "", conn)
        daRecord.Fill(ds, "tbl_conciliacion")

        Dim Report As New RPT_CONCILIACION
        Report.Database.Tables(0).SetDataSource(ds)
        Report.PrintOptions.PrinterDuplex = PrinterDuplex.Horizontal
        Report.PrintOptions.PrinterName = PrintName
        Report.PrintToPrinter(1, True, 0, 0)


    End Sub
    Private Sub PRINT_DEP()
        If fld_id_doc.Text = "0" Then
            Alerta("La Conciliación no ha sido guardada")
            Exit Sub
        End If
         '/INI FILE
        Dim PrintName As String = objIniFile.GetString("PRINTER", "Name", "(none)")

        Dim asking = Alerta("¿Desea imprimir los Depósitos en transito?")
        

        If Asking = False Then
            Exit Sub
        End If

        Dim ds As New DataSet



        Dim daRecord As New MySqlDataAdapter("SELECT * FROM tbl_deposito_trans WHERE fld_id_conciliacion_dep=" & fld_id_doc.Text & "", conn)
        daRecord.Fill(ds, "tbl_deposito_trans")

        Dim Report As New RPT_DEP_TRANSITO
        Report.Database.Tables(0).SetDataSource(ds)
        Report.PrintOptions.PrinterDuplex = PrinterDuplex.Horizontal
        Report.PrintOptions.PrinterName = PrintName
        Report.PrintToPrinter(1, True, 0, 0)
    End Sub
    Private Sub PRINT_CK()
        If fld_id_doc.Text = "0" Then
            Alerta("La Conciliación no ha sido guardada")
            Exit Sub
        End If
         '/INI FILE
        Dim PrintName As String = objIniFile.GetString("PRINTER", "Name", "(none)")

        Dim asking = Alerta("¿Desea imprimir los cheques en transito?")
        

        If Asking = False Then
            Exit Sub
        End If

        Dim ds As New DataSet


        Dim daRecord As New MySqlDataAdapter("SELECT * FROM tbl_cheques_trans WHERE fld_id_conciliacion_ck=" & fld_id_doc.Text & "", conn)
        daRecord.Fill(ds, "tbl_cheques_trans")

        Dim Report As New RPT_CK_TRANSITO
        Report.Database.Tables(0).SetDataSource(ds)
        Report.PrintOptions.PrinterDuplex = PrinterDuplex.Horizontal
        Report.PrintOptions.PrinterName = PrintName
        Report.PrintToPrinter(1, True, 0, 0)
    End Sub
    Private Sub PRINT_NC()
        If fld_id_doc.Text = "0" Then
            Alerta("La Conciliación no ha sido guardada")
            Exit Sub
        End If
         '/INI FILE
        Dim PrintName As String = objIniFile.GetString("PRINTER", "Name", "(none)")

        Dim asking = Alerta("¿Desea imprimir las Notas de Crédito?")
        

        If Asking = False Then
            Exit Sub
        End If

        Dim ds As New DataSet

        Dim daProf As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
        daProf.Fill(ds, "tbl_profiledocument")

        Dim dr As DataRow
        For Each dr In ds.Tables(0).Rows
            dr("fldColorForm") = fld_id_doc.Text
        Next

        Dim daRecord As New MySqlDataAdapter("SELECT * FROM tbl_nc_bancaria WHERE fld_id_banco='" & fld_id_banco.Text & "' AND fld_fecha > '" & formatDate(fecha1.Value.Date) & "' AND fld_fecha <='" & formatDate(fecha2.Value.Date) & "'", conn)
        daRecord.Fill(ds, "tbl_nc_bancaria")

        Dim Report As New RPT_NC_TRANSITO
        Report.Database.Tables(0).SetDataSource(ds)
        Report.PrintOptions.PrinterDuplex = PrinterDuplex.Horizontal
        Report.PrintOptions.PrinterName = PrintName
        Report.PrintToPrinter(1, True, 0, 0)
    End Sub
    Private Sub PRINT_ND()
        If fld_id_doc.Text = "0" Then
            Alerta("La Conciliación no ha sido guardada")
            Exit Sub
        End If
         '/INI FILE
        Dim PrintName As String = objIniFile.GetString("PRINTER", "Name", "(none)")

        Dim asking = Alerta("¿Desea imprimir las Notas de Débito?")
        

        If Asking = False Then
            Exit Sub
        End If

        Dim ds As New DataSet

        Dim daProf As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
        daProf.Fill(ds, "tbl_profiledocument")

        Dim dr As DataRow
        For Each dr In ds.Tables(0).Rows
            dr("fldColorForm") = fld_id_doc.Text
        Next

        Dim daRecord As New MySqlDataAdapter("SELECT * FROM tbl_nd_bancaria WHERE fld_id_banco='" & fld_id_banco.Text & "' AND fld_fecha > '" & formatDate(fecha1.Value.Date) & "' AND fld_fecha <='" & formatDate(fecha2.Value.Date) & "'", conn)
        daRecord.Fill(ds, "tbl_nd_bancaria")

        Dim Report As New RPT_ND_TRASITO
        Report.Database.Tables(0).SetDataSource(ds)
        Report.PrintOptions.PrinterDuplex = PrinterDuplex.Horizontal
        Report.PrintOptions.PrinterName = PrintName
        Report.PrintToPrinter(1, True, 0, 0)
    End Sub
    Private Sub PRINT_DEP_REG()
        If fld_id_doc.Text = "0" Then
            Alerta("La Conciliación no ha sido guardada")
            Exit Sub
        End If
         '/INI FILE
        Dim PrintName As String = objIniFile.GetString("PRINTER", "Name", "(none)")

        Dim asking = Alerta("¿Desea imprimir los Depósitos?")
        

        If Asking = False Then
            Exit Sub
        End If
        Dim Report As New RPT_DEPOSITOS
        Dim ds As New DataSet
        ds.Clear()

        Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
        daP.Fill(ds, "tbl_profiledocument")
        Dim dr As DataRow
        For Each dr In ds.Tables(0).Rows
            dr("fldColorForm") = "Desde " & fecha1.Value.Date.AddDays(1) & " Hasta " & fecha2.Value.Date
        Next

        Dim SqlString As String

        SqlString = "SELECT * FROM tbl_deposito WHERE  fld_fecha > '" & formatDate(fecha1.Value.Date) & "' AND fld_fecha <= '" & formatDate(fecha2.Value.Date) & "' AND fld_estado='N'  AND fld_id_banco='" & fld_id_banco.Text & "'"


        Dim daP1 As New MySqlDataAdapter(SqlString, conn)
        daP1.Fill(ds, "tbl_deposito")

        For Each dr In ds.Tables(1).Rows
            If Estado = "TODOS" Then
                dr("fld_transito") = "TODOS"
            End If
        Next

        Report.Database.Tables(0).SetDataSource(ds)
        Report.PrintOptions.PrinterDuplex = PrinterDuplex.Horizontal
        Report.PrintOptions.PrinterName = PrintName
        Report.PrintToPrinter(1, True, 0, 0)

    End Sub
    Private Sub PRINT_CK_EMITIDOS()
        If fld_id_doc.Text = "0" Then
            Alerta("La Conciliación no ha sido guardada")
            Exit Sub
        End If
         '/INI FILE
        Dim PrintName As String = objIniFile.GetString("PRINTER", "Name", "(none)")

        Dim asking = Alerta("¿Desea imprimir los Cheques?")
        

        If Asking = False Then
            Exit Sub
        End If
        Dim Report As New RPT_CHEQUES
        Dim ds As New DataSet
        ds.Clear()

        Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
        daP.Fill(ds, "tbl_profiledocument")
        Dim dr As DataRow
        For Each dr In ds.Tables(0).Rows
            dr("fldColorForm") = "Desde " & fecha1.Value.Date.AddDays(1) & " Hasta " & fecha2.Value.Date
        Next

        Dim SqlString As String


        SqlString = "SELECT * FROM tbl_cheques WHERE  fld_fecha > '" & formatDate(fecha1.Value.Date) & "' AND fld_fecha <= '" & formatDate(fecha2.Value.Date) & "' AND fld_estado='EMISION'  AND fld_id_banco='" & fld_id_banco.Text & "'"


        Dim daP1 As New MySqlDataAdapter(SqlString, conn)
        daP1.Fill(ds, "tbl_cheques")

        For Each dr In ds.Tables(1).Rows
            If Estado = "TODOS" Then
                dr("fld_transito") = "TODOS"
            End If
        Next

        Report.Database.Tables(0).SetDataSource(ds)
        Report.PrintOptions.PrinterDuplex = PrinterDuplex.Horizontal
        Report.PrintOptions.PrinterName = PrintName
        Report.PrintToPrinter(1, True, 0, 0)

    End Sub

    Private Sub btn_filtrar_doc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_filtrar_doc.Click
        fld_dep_transito.Text = Format(RETURN_MONTO_DEP(), "C2")
        fld_ck_transito.Text = Format(RETURN_MONTO_CK(), "C2")
        CALCULO_BANCO()
        'bce_mes()
    End Sub

    Private Sub btn_calcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular.Click
        FillLV_NC()
        FillLV_ND()
        CALCULO_pc()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'nota credito
        FRMS_DIARIOBANCO("NC Bancaria")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'nota debito
        FRMS_DIARIOBANCO("ND Bancaria")
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        'nueva
        If FRMS_LIST_BANCOS() = True Then
            CLEAR_DATA()
            fld_id_banco.Text = Id
            LOAD_DATA_BANCO(fld_id_banco.Text)
        End If
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        SAVE_DATA()
        PRINT_CONCI()
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        'consultar
        If FRMS_CONCILIACION_LISTA(fld_id_banco.Text, Me.Text) = True Then
            LOAD_DATA(Id)
            btn_filtrar_doc.Enabled = False
            btn_calcular.Enabled = False
            btn_seleccionar_documento.Enabled = False
        End If
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        'imprimir
        PRINT_CONCI()
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        'cerrar
        Me.Close()
    End Sub

    Private Sub btn_ver_ck_trans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ver_ck_trans.Click
        Id = fld_id_doc.Text
        READ_SAVE_CK()
        Dim F As New FRM_LIST_DOC_TRANSITO
        F.lbl_doc.Text = "Cheques en Transido"
        F.ShowDialog()
        F = Nothing
        Id = 0
    End Sub

    Private Sub btn_print_dep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print_dep.Click
        PRINT_DEP()
    End Sub

    Private Sub btn_print_ck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print_ck.Click
        PRINT_CK()
    End Sub

    Private Sub btn_print_mas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print_mas.Click
        PRINT_NC()
    End Sub

    Private Sub btn_print_menos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print_menos.Click
        PRINT_ND()
    End Sub


    Private Sub btn_ver_dep_trans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ver_dep_trans.Click
        Id = fld_id_doc.Text
        READ_SAVE_DEP()
        Dim F As New FRM_LIST_DOC_TRANSITO
        F.lbl_doc.Text = "Depósitos en Transido"
        F.ShowDialog()
        F = Nothing
        Id = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PRINT_DEP_REG()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PRINT_CK_EMITIDOS()
    End Sub
End Class
