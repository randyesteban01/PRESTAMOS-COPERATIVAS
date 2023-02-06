Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Drawing.Printing
Imports System.IO
Public Class FRM_GENERANDO_CUOTAS
    Inherits System.Windows.Forms.Form
    Dim ds_print As DataSet
    Dim ds1 As DataSet, ds2 As DataSet

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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents cboSearch As System.Windows.Forms.ComboBox
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fld_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents btn_imprime_lista As System.Windows.Forms.Button
    Friend WithEvents btn_seleccionar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents fld_semana_no As System.Windows.Forms.ComboBox
    Friend WithEvents fld_total As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents fld_atraso As System.Windows.Forms.TextBox
    Friend WithEvents fld_abono As System.Windows.Forms.TextBox
    Friend WithEvents fld_monto As System.Windows.Forms.TextBox
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnCierra As System.Windows.Forms.Button
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents fld_tipo_prestamo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtZona As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_GENERANDO_CUOTAS))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label2 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.fld_fecha = New System.Windows.Forms.DateTimePicker
        Me.fld_tipo_prestamo = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.fld_monto = New System.Windows.Forms.TextBox
        Me.fld_abono = New System.Windows.Forms.TextBox
        Me.fld_atraso = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.fld_total = New System.Windows.Forms.TextBox
        Me.fld_semana_no = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.cboSearch = New System.Windows.Forms.ComboBox
        Me.LV = New System.Windows.Forms.ListView
        Me.txtZona = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btn_imprimir = New System.Windows.Forms.Button
        Me.btn_imprime_lista = New System.Windows.Forms.Button
        Me.btn_seleccionar = New System.Windows.Forms.Button
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.PrintDialog = New System.Windows.Forms.PrintDialog
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnCierra = New System.Windows.Forms.Button
        Me.btnProcesar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(714, 480)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.DateTimePicker1)
        Me.TabPage1.Controls.Add(Me.fld_fecha)
        Me.TabPage1.Controls.Add(Me.fld_tipo_prestamo)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.fld_monto)
        Me.TabPage1.Controls.Add(Me.fld_abono)
        Me.TabPage1.Controls.Add(Me.fld_atraso)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.fld_total)
        Me.TabPage1.Controls.Add(Me.fld_semana_no)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtBuscar)
        Me.TabPage1.Controls.Add(Me.cboSearch)
        Me.TabPage1.Controls.Add(Me.LV)
        Me.TabPage1.Controls.Add(Me.txtZona)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(706, 451)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Generales"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(688, 30)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Genera recibo temporal de Cobro para préstamos Semanales"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd / MMM / yy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(528, 50)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(160, 29)
        Me.DateTimePicker1.TabIndex = 108
        Me.DateTimePicker1.Visible = False
        '
        'fld_fecha
        '
        Me.fld_fecha.CustomFormat = "dd / MMM / yy"
        Me.fld_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fld_fecha.Location = New System.Drawing.Point(360, 50)
        Me.fld_fecha.Name = "fld_fecha"
        Me.fld_fecha.Size = New System.Drawing.Size(160, 29)
        Me.fld_fecha.TabIndex = 1
        '
        'fld_tipo_prestamo
        '
        Me.fld_tipo_prestamo.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.fld_tipo_prestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_tipo_prestamo.ForeColor = System.Drawing.Color.White
        Me.fld_tipo_prestamo.Items.AddRange(New Object() {"SEMANAL"})
        Me.fld_tipo_prestamo.Location = New System.Drawing.Point(72, 48)
        Me.fld_tipo_prestamo.Name = "fld_tipo_prestamo"
        Me.fld_tipo_prestamo.Size = New System.Drawing.Size(176, 32)
        Me.fld_tipo_prestamo.TabIndex = 106
        Me.fld_tipo_prestamo.Text = "SEMANAL"
        Me.fld_tipo_prestamo.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 30)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Tipo"
        Me.Label3.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(8, 416)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 24)
        Me.Button1.TabIndex = 96
        Me.Button1.Text = "&Listado Cuenta x Cobrar"
        Me.Button1.Visible = False
        '
        'fld_monto
        '
        Me.fld_monto.BackColor = System.Drawing.Color.White
        Me.fld_monto.Location = New System.Drawing.Point(333, 424)
        Me.fld_monto.Name = "fld_monto"
        Me.fld_monto.ReadOnly = True
        Me.fld_monto.Size = New System.Drawing.Size(85, 20)
        Me.fld_monto.TabIndex = 95
        Me.fld_monto.Text = "0.00"
        Me.fld_monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fld_abono
        '
        Me.fld_abono.BackColor = System.Drawing.Color.White
        Me.fld_abono.Location = New System.Drawing.Point(417, 424)
        Me.fld_abono.Name = "fld_abono"
        Me.fld_abono.ReadOnly = True
        Me.fld_abono.Size = New System.Drawing.Size(85, 20)
        Me.fld_abono.TabIndex = 94
        Me.fld_abono.Text = "0.00"
        Me.fld_abono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fld_atraso
        '
        Me.fld_atraso.BackColor = System.Drawing.Color.White
        Me.fld_atraso.Location = New System.Drawing.Point(501, 424)
        Me.fld_atraso.Name = "fld_atraso"
        Me.fld_atraso.ReadOnly = True
        Me.fld_atraso.Size = New System.Drawing.Size(85, 20)
        Me.fld_atraso.TabIndex = 93
        Me.fld_atraso.Text = "0.00"
        Me.fld_atraso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(256, 424)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Totales"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_total
        '
        Me.fld_total.BackColor = System.Drawing.Color.White
        Me.fld_total.Location = New System.Drawing.Point(587, 424)
        Me.fld_total.Name = "fld_total"
        Me.fld_total.ReadOnly = True
        Me.fld_total.Size = New System.Drawing.Size(85, 20)
        Me.fld_total.TabIndex = 91
        Me.fld_total.Text = "0.00"
        Me.fld_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fld_semana_no
        '
        Me.fld_semana_no.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.fld_semana_no.ForeColor = System.Drawing.Color.White
        Me.fld_semana_no.Items.AddRange(New Object() {"Todas", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15"})
        Me.fld_semana_no.Location = New System.Drawing.Point(632, 456)
        Me.fld_semana_no.Name = "fld_semana_no"
        Me.fld_semana_no.Size = New System.Drawing.Size(56, 21)
        Me.fld_semana_no.TabIndex = 90
        Me.fld_semana_no.Text = "Todas"
        Me.fld_semana_no.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Fecha"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.White
        Me.txtBuscar.Location = New System.Drawing.Point(704, 32)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(120, 20)
        Me.txtBuscar.TabIndex = 11
        Me.txtBuscar.Text = ""
        Me.txtBuscar.Visible = False
        '
        'cboSearch
        '
        Me.cboSearch.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.cboSearch.ForeColor = System.Drawing.Color.White
        Me.cboSearch.Items.AddRange(New Object() {"Nombre", "Primer Apellido"})
        Me.cboSearch.Location = New System.Drawing.Point(704, 8)
        Me.cboSearch.Name = "cboSearch"
        Me.cboSearch.Size = New System.Drawing.Size(120, 21)
        Me.cboSearch.TabIndex = 10
        Me.cboSearch.Text = "Nombre"
        Me.cboSearch.Visible = False
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.White
        Me.LV.CheckBoxes = True
        Me.LV.Location = New System.Drawing.Point(8, 112)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(688, 304)
        Me.LV.TabIndex = 0
        '
        'txtZona
        '
        Me.txtZona.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.txtZona.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZona.ForeColor = System.Drawing.Color.White
        Me.txtZona.Location = New System.Drawing.Point(72, 80)
        Me.txtZona.Name = "txtZona"
        Me.txtZona.Size = New System.Drawing.Size(616, 32)
        Me.txtZona.TabIndex = 86
        Me.txtZona.Text = "TODAS"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 24)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Zona"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_imprimir
        '
        Me.btn_imprimir.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_imprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imprimir.ForeColor = System.Drawing.Color.Black
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_imprimir.Location = New System.Drawing.Point(168, 480)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(72, 56)
        Me.btn_imprimir.TabIndex = 3
        Me.btn_imprimir.Text = "&Imprimir"
        Me.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btn_imprime_lista
        '
        Me.btn_imprime_lista.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_imprime_lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imprime_lista.ForeColor = System.Drawing.Color.Black
        Me.btn_imprime_lista.Image = CType(resources.GetObject("btn_imprime_lista.Image"), System.Drawing.Image)
        Me.btn_imprime_lista.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_imprime_lista.Location = New System.Drawing.Point(248, 480)
        Me.btn_imprime_lista.Name = "btn_imprime_lista"
        Me.btn_imprime_lista.Size = New System.Drawing.Size(72, 56)
        Me.btn_imprime_lista.TabIndex = 4
        Me.btn_imprime_lista.Text = "I&mp. Lista"
        Me.btn_imprime_lista.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btn_seleccionar
        '
        Me.btn_seleccionar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_seleccionar.ForeColor = System.Drawing.Color.Black
        Me.btn_seleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_seleccionar.ImageIndex = 1
        Me.btn_seleccionar.ImageList = Me.ImageList2
        Me.btn_seleccionar.Location = New System.Drawing.Point(40, 16)
        Me.btn_seleccionar.Name = "btn_seleccionar"
        Me.btn_seleccionar.Size = New System.Drawing.Size(88, 24)
        Me.btn_seleccionar.TabIndex = 5
        Me.btn_seleccionar.Text = "&Si"
        '
        'ImageList2
        '
        Me.ImageList2.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.Black
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(88, 480)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(72, 56)
        Me.btnModificar.TabIndex = 185
        Me.btnModificar.Text = "&Consultar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnCierra
        '
        Me.btnCierra.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCierra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCierra.ForeColor = System.Drawing.Color.Black
        Me.btnCierra.Image = CType(resources.GetObject("btnCierra.Image"), System.Drawing.Image)
        Me.btnCierra.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCierra.Location = New System.Drawing.Point(328, 480)
        Me.btnCierra.Name = "btnCierra"
        Me.btnCierra.Size = New System.Drawing.Size(72, 56)
        Me.btnCierra.TabIndex = 187
        Me.btnCierra.Text = "&Cerrar"
        Me.btnCierra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnProcesar
        '
        Me.btnProcesar.BackColor = System.Drawing.Color.FromArgb(CType(242, Byte), CType(231, Byte), CType(61, Byte))
        Me.btnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcesar.ForeColor = System.Drawing.Color.Black
        Me.btnProcesar.Image = CType(resources.GetObject("btnProcesar.Image"), System.Drawing.Image)
        Me.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProcesar.Location = New System.Drawing.Point(8, 480)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(72, 56)
        Me.btnProcesar.TabIndex = 184
        Me.btnProcesar.Text = "&Generar"
        Me.btnProcesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_seleccionar)
        Me.GroupBox2.Location = New System.Drawing.Point(544, 488)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(160, 48)
        Me.GroupBox2.TabIndex = 188
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selecionar todos los Docs."
        '
        'FRM_GENERANDO_CUOTAS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(714, 547)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCierra)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.btn_imprime_lista)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_GENERANDO_CUOTAS"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recibos de Cobro Semanal/Diario"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FRM_GENERANDO_CUOTAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        LlenarZona()
    End Sub

    Private Sub Generar()
        CUOTAS_GENERAR()
        LV_GENERAR() 
    End Sub

    Private Sub LV_GENERAR()


        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        LV.Clear()
        LV.View = View.Details
        LV.LabelEdit = False
        LV.FullRowSelect = True
        LV.GridLines = True
        LV.MultiSelect = False
        LV.Sorting = SortOrder.None


        Dim fldToSearch As String = "fld_FullName" ' = cboSearch.Text
        Dim strTosearch As String = "'%" & txtBuscar.Text & "%'"
        Dim sqlSearch As String
        Dim accion As Short
        Dim dr As DataRow


        sqlSearch = "SELECT fld_id_cuotas, fld_id_del_prestamo, fld_no_cuotas, fld_FullName, fld_monto_cuotas, fld_abono_cuotas, fld_atraso_cuotas, fld_balance_cuotas, fld_sector FROM view_generar_cuotas WHERE fld_fecha_termina_cuotas='" & formatDate(fld_fecha.Value.Date) & "' AND fld_tipo_cuotas='" & fld_tipo_prestamo.Text & "' AND fld_cod_zona=" & txtZona.SelectedValue & " ORDER BY fld_no_cuotas ASC"
         

        ds.Reset()

        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, "view_generar_cuotas")
        fld_total.Text = 0
        fld_monto.Text = 0
        fld_abono.Text = 0
        fld_atraso.Text = 0

        For Each dr In ds.Tables(0).Rows
            dr("fld_balance_cuotas") = dr("fld_balance_cuotas") + dr("fld_atraso_cuotas")
            fld_total.Text = Format(CDbl(fld_total.Text) + dr("fld_balance_cuotas"), "C2")
            fld_monto.Text = Format(CDbl(fld_monto.Text) + dr("fld_monto_cuotas"), "C2")
            fld_abono.Text = Format(CDbl(fld_abono.Text) + dr("fld_abono_cuotas"), "C2")
            fld_atraso.Text = Format(CDbl(fld_atraso.Text) + dr("fld_atraso_cuotas"), "C2")
        Next


        Dim columnText(10) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = ""
        columnText(1) = "P.No."
        columnText(2) = "S."
        columnText(3) = "CLIENTE"
        columnText(4) = "MONTO"
        columnText(5) = "ABONO"
        columnText(6) = "ATRASO"
        columnText(7) = "BALANCE"

        Dim columnWidth(10) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 20
        columnWidth(1) = 70
        columnWidth(2) = 30
        columnWidth(3) = 200
        columnWidth(4) = 85
        columnWidth(5) = 85
        columnWidth(6) = 85
        columnWidth(7) = 85

        Dim columnAlign(10) As Int32 'PARA ALINEAR LOS DATOS
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 0 'IZQUIERDA
        columnAlign(3) = 0 'DERECHA
        columnAlign(4) = 1 'IZQUIERDA
        columnAlign(5) = 1 'IZQUIERDA
        columnAlign(6) = 1 'IZQUIERDA
        columnAlign(7) = 1 'DERECHA


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
                    str(col) = Format(rr(col), "0000")
                ElseIf rr(col).GetType().FullName.ToString = "System.DateTime" Then
                    str(col) = Format(rr(col), "d")
                ElseIf rr(col).GetType().FullName.ToString = "System.String" Then
                    str(col) = rr(col).ToString()
                ElseIf rr(col).GetType().FullName.ToString = "System.Double" Then
                    str(col) = Format(rr(col), "C2")
                End If
            Next

            Dim ii As New ListViewItem(str)
            LV.Items.Add(ii)
            'showing the number of records still added
        Next


    End Sub
    Private Sub CUOTAS_GENERAR()
        Dim ds As New DataSet

        Dim dr As DataRow
        Dim sqlSearch As String = "SELECT * FROM view_generar_cuotas WHERE fld_fecha_termina_cuotas='" & formatDate(fld_fecha.Value.Date) & "' AND fld_tipo_cuotas='" & fld_tipo_prestamo.Text & "' AND fld_cod_zona=" & txtZona.SelectedValue & ""
         

        Dim da As New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, "view_generar_cuotas")

        For Each dr In ds.Tables(0).Rows
            update_atraso(dr("fld_id_cuotas"), calcula_atraso(dr("fld_id_del_prestamo")))
            SetBcePretCuotas(dr("fld_id_cuotas"), dr("fld_id_del_prestamo"))
        Next

    End Sub

    Private Function calcula_atraso(ByVal id_prestamo As Integer) As Double

        Dim cmd As New MySqlCommand, monto As Double
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT SUM(fld_balance_cuotas) FROM tbl_cuotas WHERE fld_id_del_prestamo=" & id_prestamo & " AND fld_fecha_termina_cuotas < '" & formatDate(fld_fecha.Value.Date) & "' AND fld_balance_cuotas >0"
            If .ExecuteScalar.GetType.ToString = "System.DBNull" Then
                monto = 0
            Else
                monto = .ExecuteScalar
            End If

            .Connection.Close()
        End With
        cmd.Dispose()
        Return monto

    End Function

    Private Sub update_atraso(ByVal id_cuota As Integer, ByVal atraso As Double)
        Dim cmd As New MySqlCommand
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "UPDATE tbl_cuotas SET fld_atraso_cuotas=" & atraso & " WHERE fld_id_cuotas=" & id_cuota & ""
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd.Dispose()

    End Sub

    Private Sub SetBcePretCuotas(ByVal IdCuota As Integer, ByVal IdPrestamo As Integer)
        'ACTUALIZA EL BCE. DEL PRESTAMOS PARA MOSTRARLO EN LA CUOTA A IMPRIMIR
        Dim sqlString = "SELECT SUM(fld_balance_cuotas) FROM tbl_cuotas WHERE  fld_id_del_prestamo=" & IdPrestamo & ""

        Dim cmd As New MySqlCommand, bce As Double


        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = sqlString
            If .ExecuteScalar.GetType.ToString = "System.DBNull" Then
                bce = 0
            Else
                bce = .ExecuteScalar
            End If

            .Connection.Close()
        End With
        cmd.Dispose()

        Dim cmd1 As New MySqlCommand
        With cmd1
            .Connection = conn
            .Connection.Open()
            .CommandText = "UPDATE tbl_cuotas SET fld_bce_prestamo=" & bce & " where fld_id_cuotas=" & IdCuota & ""

            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd1 = Nothing

    End Sub

    Private Sub agrega_al_ds1_print(ByVal id_cuota As String)


        Dim da As New MySqlDataAdapter("SELECT * FROM view_generar_cuotas WHERE fld_id_cuotas=" & id_cuota & "  ", conn)
        da.Fill(ds1, "view_generar_cuotas")


        'ds1.Dispose()
        'da.Dispose()
    End Sub
    Private Sub ready_to_print()
        ds1 = New DataSet
        For Each lvitem As ListViewItem In Me.LV.Items

            If lvitem.Checked = True Then
                agrega_al_ds1_print(lvitem.Text)
            End If

        Next
        ds_print = New DataSet
        ds_print = ds1.Clone
        Dim dr As DataRow
        For Each dr In ds1.Tables(0).Rows
            ds_print.Tables(0).ImportRow(dr)
        Next

    End Sub
    Private Sub printing_document()
        Try
            Dim printd As New PrintDialog
            printd.AllowSomePages = True
            printd.ShowHelp = True
            printd.Document = docToPrint
            Dim result As DialogResult = printd.ShowDialog()
            If (result = Windows.Forms.DialogResult.OK) Then


                Dim daProf As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
                daProf.Fill(ds_print, "tbl_profiledocument")

                Dim pd As New PrintDocument, strOldPrinter As String
                strOldPrinter = pd.PrinterSettings.PrinterName 'Get the Default Print


                Dim WshNetwork As Object
                WshNetwork = Microsoft.VisualBasic.CreateObject("WScript.Network")
                WshNetwork.SetDefaultPrinter(printd.PrinterSettings.PrinterName)  'Set the Default Print


                Dim Report As New RPT_CUOTAS
                Report.Database.Tables(0).SetDataSource(ds_print)
                Report.PrintOptions.PrinterDuplex = PrinterDuplex.Horizontal
                Report.PrintOptions.PrinterName = printd.PrinterSettings.PrinterName
                Report.PrintToPrinter(printd.PrinterSettings.Copies, True, 0, 0)


                WshNetwork.SetDefaultPrinter(strOldPrinter) 'Get the Default Print


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub agrega_al_ds2_print_list(ByVal id_cuota As String)

        Dim da As New MySqlDataAdapter("SELECT * FROM view_generar_cuotas WHERE fld_id_cuotas=" & id_cuota & "  ", conn)
        da.Fill(ds2, "view_generar_cuotas")


        'ds1.Dispose()
        'da.Dispose()
    End Sub
    Private Sub ready_to_print_list()
        ds2 = New DataSet
        For Each lvitem As ListViewItem In Me.LV.Items

            If lvitem.Checked = True Then
                agrega_al_ds2_print_list(lvitem.Text)
            End If

        Next
        ds_print_list = New DataSet
        ds_print_list = ds2.Clone
        Dim dr As DataRow
        For Each dr In ds2.Tables(0).Rows
            ds_print_list.Tables(0).ImportRow(dr)
        Next

    End Sub
    Private Sub printing_document_lista()
        Dim Print_Name As String

        PrintDialog.AllowSomePages = True


        PrintDialog.ShowHelp = True


        PrintDialog.Document = docToPrint

        Dim result As DialogResult = PrintDialog.ShowDialog()

        ' If the result is OK then print the document.
        If (result = Windows.Forms.DialogResult.OK) Then
            Print_Name = PrintDialog.PrinterSettings.PrinterName
        Else
            Exit Sub
        End If



        Dim pd As New PrintDocument, strOldPrinter As String
        strOldPrinter = pd.PrinterSettings.PrinterName 'Get the Default Print


        Dim WshNetwork As Object
        WshNetwork = Microsoft.VisualBasic.CreateObject("WScript.Network")
        WshNetwork.SetDefaultPrinter(Print_Name) 'Set the Default Print

        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
        da.Fill(ds_print_list, "tbl_profiledocument")


        Dim Report As New RPT_LISTADO_COBROS
        Report.Database.Tables(0).SetDataSource(ds_print_list)
        Report.PrintOptions.PrinterName = Print_Name
        Report.PrintToPrinter(1, True, 0, 0)

        WshNetwork.SetDefaultPrinter(strOldPrinter) 'Get the Default Print


    End Sub

    Private Sub print_cobros()
        ready_to_print()
        printing_document()
    End Sub

    Private Sub print_lista()
        ready_to_print_list()
        printing_document_lista()
    End Sub

    Private Sub LlenarZona()

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT fldId, fldDescripcion FROM tbl_maestro_zonas ORDER BY fldDescripcion", conn)
        da.Fill(dt)

        txtZona.DataSource = dt
        txtZona.DisplayMember = "fldDescripcion"
        txtZona.ValueMember = "fldId"

        da.Dispose()

    End Sub

    Private Sub btn_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir.Click
        print_cobros()
    End Sub

    Private Sub btn_imprime_lista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprime_lista.Click
        ready_to_print_list()
        ' printing_document_lista()
        AllReportSinFecha("LISTADO DE COBRO")
    End Sub

    Private Sub btn_seleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_seleccionar.Click
        If btn_seleccionar.Text = "&Si" Then
            For Each lvitem As ListViewItem In Me.LV.Items
                lvitem.Checked = True
            Next
            btn_seleccionar.ImageIndex = 0
            btn_seleccionar.Text = "&No"
        Else
            For Each lvitem As ListViewItem In Me.LV.Items
                lvitem.Checked = False
            Next
            btn_seleccionar.ImageIndex = 1
            btn_seleccionar.Text = "&Si"
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        fecha1 = formatDate(fld_fecha.Value.Date)
        AllReportSinFecha("LISTADO DE CXC")
    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click

        Generar()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        LV_GENERAR()
    End Sub

    Private Sub btnCierra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCierra.Click
        Me.Close()
    End Sub

    Private Sub fld_cobrador_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

End Class
