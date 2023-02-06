Imports MySql.Data.MySqlClient
Public Class frmInterfasRecibosIngresos
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
    Friend WithEvents lblDebitoIngreso As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_cta_db_ingresos As System.Windows.Forms.TextBox
    Friend WithEvents lblOtros As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_cta_ing_otros As System.Windows.Forms.TextBox
    Friend WithEvents lblMora As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_cta_ing_mora As System.Windows.Forms.TextBox
    Friend WithEvents lblInteres As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_cta_ing_interes As System.Windows.Forms.TextBox
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btn_procesar As System.Windows.Forms.Button
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents lblCierre As System.Windows.Forms.Label
    Friend WithEvents lblUtilidades As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents txt_cta_utilidad As System.Windows.Forms.TextBox
    Friend WithEvents txt_cta_cierre As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents ctaCertificadosLbl As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ctaCertificadosTxt As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmInterfasRecibosIngresos))
        Me.lblDebitoIngreso = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txt_cta_db_ingresos = New System.Windows.Forms.TextBox
        Me.lblOtros = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_cta_ing_otros = New System.Windows.Forms.TextBox
        Me.lblMora = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_cta_ing_mora = New System.Windows.Forms.TextBox
        Me.lblInteres = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_cta_ing_interes = New System.Windows.Forms.TextBox
        Me.txtConcepto = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btn_procesar = New System.Windows.Forms.Button
        Me.Label46 = New System.Windows.Forms.Label
        Me.lblCierre = New System.Windows.Forms.Label
        Me.lblUtilidades = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.txt_cta_utilidad = New System.Windows.Forms.TextBox
        Me.txt_cta_cierre = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbTipo = New System.Windows.Forms.ComboBox
        Me.ctaCertificadosLbl = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ctaCertificadosTxt = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'lblDebitoIngreso
        '
        Me.lblDebitoIngreso.Font = New System.Drawing.Font("Arial", 6.5!)
        Me.lblDebitoIngreso.ForeColor = System.Drawing.Color.Red
        Me.lblDebitoIngreso.Location = New System.Drawing.Point(320, 296)
        Me.lblDebitoIngreso.Name = "lblDebitoIngreso"
        Me.lblDebitoIngreso.Size = New System.Drawing.Size(248, 20)
        Me.lblDebitoIngreso.TabIndex = 14
        Me.lblDebitoIngreso.Text = "Label21"
        Me.lblDebitoIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDebitoIngreso.Visible = False
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(216, 280)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(216, 16)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "Cta. Débito de Recibos de Ingresos"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label17.Visible = False
        '
        'txt_cta_db_ingresos
        '
        Me.txt_cta_db_ingresos.Location = New System.Drawing.Point(216, 296)
        Me.txt_cta_db_ingresos.Name = "txt_cta_db_ingresos"
        Me.txt_cta_db_ingresos.TabIndex = 13
        Me.txt_cta_db_ingresos.Text = "0"
        Me.txt_cta_db_ingresos.Visible = False
        '
        'lblOtros
        '
        Me.lblOtros.Font = New System.Drawing.Font("Arial", 6.5!)
        Me.lblOtros.ForeColor = System.Drawing.Color.Red
        Me.lblOtros.Location = New System.Drawing.Point(112, 120)
        Me.lblOtros.Name = "lblOtros"
        Me.lblOtros.Size = New System.Drawing.Size(248, 20)
        Me.lblOtros.TabIndex = 11
        Me.lblOtros.Text = "Label21"
        Me.lblOtros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(176, 16)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Cta. para Otros Ingresos RI"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_cta_ing_otros
        '
        Me.txt_cta_ing_otros.Location = New System.Drawing.Point(8, 120)
        Me.txt_cta_ing_otros.Name = "txt_cta_ing_otros"
        Me.txt_cta_ing_otros.TabIndex = 10
        Me.txt_cta_ing_otros.Text = ""
        '
        'lblMora
        '
        Me.lblMora.Font = New System.Drawing.Font("Arial", 6.5!)
        Me.lblMora.ForeColor = System.Drawing.Color.Red
        Me.lblMora.Location = New System.Drawing.Point(112, 80)
        Me.lblMora.Name = "lblMora"
        Me.lblMora.Size = New System.Drawing.Size(248, 20)
        Me.lblMora.TabIndex = 8
        Me.lblMora.Text = "Label21"
        Me.lblMora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Cta. para Mora RI"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_cta_ing_mora
        '
        Me.txt_cta_ing_mora.Location = New System.Drawing.Point(8, 80)
        Me.txt_cta_ing_mora.Name = "txt_cta_ing_mora"
        Me.txt_cta_ing_mora.TabIndex = 7
        Me.txt_cta_ing_mora.Text = ""
        '
        'lblInteres
        '
        Me.lblInteres.Font = New System.Drawing.Font("Arial", 6.5!)
        Me.lblInteres.ForeColor = System.Drawing.Color.Red
        Me.lblInteres.Location = New System.Drawing.Point(112, 40)
        Me.lblInteres.Name = "lblInteres"
        Me.lblInteres.Size = New System.Drawing.Size(248, 20)
        Me.lblInteres.TabIndex = 5
        Me.lblInteres.Text = "Label21"
        Me.lblInteres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Cta. para Interes RI"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_cta_ing_interes
        '
        Me.txt_cta_ing_interes.Location = New System.Drawing.Point(8, 40)
        Me.txt_cta_ing_interes.Name = "txt_cta_ing_interes"
        Me.txt_cta_ing_interes.TabIndex = 4
        Me.txt_cta_ing_interes.Text = ""
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(216, 336)
        Me.txtConcepto.MaxLength = 145
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(312, 20)
        Me.txtConcepto.TabIndex = 16
        Me.txtConcepto.Text = "0"
        Me.txtConcepto.Visible = False
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(216, 320)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Concepto :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Visible = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrar.Location = New System.Drawing.Point(656, 152)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 56)
        Me.btnCerrar.TabIndex = 26
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btn_procesar
        '
        Me.btn_procesar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_procesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_procesar.Image = CType(resources.GetObject("btn_procesar.Image"), System.Drawing.Image)
        Me.btn_procesar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_procesar.Location = New System.Drawing.Point(576, 152)
        Me.btn_procesar.Name = "btn_procesar"
        Me.btn_procesar.Size = New System.Drawing.Size(72, 56)
        Me.btn_procesar.TabIndex = 25
        Me.btn_procesar.Text = "&Guardar"
        Me.btn_procesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label46
        '
        Me.Label46.Location = New System.Drawing.Point(360, 24)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(100, 16)
        Me.Label46.TabIndex = 19
        Me.Label46.Text = "Cta. Utilidades"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCierre
        '
        Me.lblCierre.Font = New System.Drawing.Font("Arial", 6.5!)
        Me.lblCierre.ForeColor = System.Drawing.Color.Red
        Me.lblCierre.Location = New System.Drawing.Point(464, 80)
        Me.lblCierre.Name = "lblCierre"
        Me.lblCierre.Size = New System.Drawing.Size(272, 20)
        Me.lblCierre.TabIndex = 24
        Me.lblCierre.Text = "Label21"
        Me.lblCierre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUtilidades
        '
        Me.lblUtilidades.Font = New System.Drawing.Font("Arial", 6.5!)
        Me.lblUtilidades.ForeColor = System.Drawing.Color.Red
        Me.lblUtilidades.Location = New System.Drawing.Point(464, 40)
        Me.lblUtilidades.Name = "lblUtilidades"
        Me.lblUtilidades.Size = New System.Drawing.Size(272, 20)
        Me.lblUtilidades.TabIndex = 21
        Me.lblUtilidades.Text = "Label21"
        Me.lblUtilidades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label51
        '
        Me.Label51.Location = New System.Drawing.Point(360, 64)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(256, 16)
        Me.Label51.TabIndex = 22
        Me.Label51.Text = "Cta. del Grupo Capital para el cierre del período"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_cta_utilidad
        '
        Me.txt_cta_utilidad.Location = New System.Drawing.Point(360, 40)
        Me.txt_cta_utilidad.Name = "txt_cta_utilidad"
        Me.txt_cta_utilidad.TabIndex = 20
        Me.txt_cta_utilidad.Text = ""
        '
        'txt_cta_cierre
        '
        Me.txt_cta_cierre.Location = New System.Drawing.Point(360, 80)
        Me.txt_cta_cierre.Name = "txt_cta_cierre"
        Me.txt_cta_cierre.TabIndex = 23
        Me.txt_cta_cierre.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Tipo :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbTipo
        '
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.Location = New System.Drawing.Point(8, 160)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(168, 21)
        Me.cmbTipo.TabIndex = 18
        '
        'ctaCertificadosLbl
        '
        Me.ctaCertificadosLbl.Font = New System.Drawing.Font("Arial", 6.5!)
        Me.ctaCertificadosLbl.ForeColor = System.Drawing.Color.Red
        Me.ctaCertificadosLbl.Location = New System.Drawing.Point(464, 120)
        Me.ctaCertificadosLbl.Name = "ctaCertificadosLbl"
        Me.ctaCertificadosLbl.Size = New System.Drawing.Size(272, 20)
        Me.ctaCertificadosLbl.TabIndex = 29
        Me.ctaCertificadosLbl.Text = "Label21"
        Me.ctaCertificadosLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(360, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Cta. para Certificados"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ctaCertificadosTxt
        '
        Me.ctaCertificadosTxt.Location = New System.Drawing.Point(360, 120)
        Me.ctaCertificadosTxt.Name = "ctaCertificadosTxt"
        Me.ctaCertificadosTxt.TabIndex = 28
        Me.ctaCertificadosTxt.Text = ""
        '
        'frmInterfasRecibosIngresos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(746, 220)
        Me.Controls.Add(Me.ctaCertificadosLbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ctaCertificadosTxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.lblCierre)
        Me.Controls.Add(Me.lblUtilidades)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.txt_cta_utilidad)
        Me.Controls.Add(Me.txt_cta_cierre)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.txt_cta_db_ingresos)
        Me.Controls.Add(Me.txt_cta_ing_otros)
        Me.Controls.Add(Me.txt_cta_ing_mora)
        Me.Controls.Add(Me.txt_cta_ing_interes)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btn_procesar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblDebitoIngreso)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lblOtros)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblMora)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblInteres)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInterfasRecibosIngresos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Interfas Contable"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmInterfasRecibosIngresos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        If SCALAR_NUM("SELECT IFNULL(1,0) FROM tbl_interfascontableingresos") = 1 Then btn_procesar.Text = "&Modificar"
        LlenarTipo()
        Buscar()
    End Sub

    Private Sub LlenarTipo()
        Dim da As New MySqlDataAdapter("SELECT fld_id, fld_descripcion FROM tbl_interfascontableotrastipo ORDER BY fld_descripcion", conn)
        Dim dt As New DataTable
        da.Fill(dt)

        cmbTipo.DataSource = dt
        cmbTipo.DisplayMember = "fld_descripcion"
        cmbTipo.ValueMember = "fld_id"
    End Sub

    Private Sub Guardar()
        NON_QUERY("INSERT INTO tbl_interfascontableingresos (Debito, Capital, Interes, Mora, Otros, Cliente, Proveedor, IdTipo, DescripcionTipo) VALUES('" & txt_cta_db_ingresos.Text & "','', '" & txt_cta_ing_interes.Text & "','" & txt_cta_ing_mora.Text & "','" & txt_cta_ing_otros.Text & "','',''," & cmbTipo.SelectedValue & ",'" & txtConcepto.Text & "'); INSERT INTO tbl_interfascontableotras(Utilidad,Cierre,Certificados) VALUES('" & txt_cta_utilidad.Text & "','" & txt_cta_cierre.Text & "','" & ctaCertificadosTxt.Text & "')")
    End Sub

    Private Sub Modificar()
        NON_QUERY("UPDATE tbl_interfascontableingresos SET Debito='" & txt_cta_db_ingresos.Text & "', Capital='', Interes='" & txt_cta_ing_interes.Text & "', Mora='" & txt_cta_ing_mora.Text & "', Otros='" & txt_cta_ing_otros.Text & "', IdTipo=" & cmbTipo.SelectedValue & ", DescripcionTipo='" & txtConcepto.Text & "' WHERE ID=1; UPDATE tbl_interfascontableotras SET Utilidad='" & txt_cta_utilidad.Text & "',Cierre='" & txt_cta_cierre.Text & "',Certificados='" & ctaCertificadosTxt.Text & "' WHERE ID=1")
    End Sub

    Private Sub Buscar()

        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT Debito, Interes, Mora, Otros, Cliente, Proveedor,  IdTIpo, DescripcionTipo FROM tbl_interfascontableingresos WHERE ID=1", conn)
        da.Fill(ds, "tbl_interfascontableingresos")
        Dim dr As DataRow
        For Each dr In ds.Tables(0).Rows
            txt_cta_db_ingresos.Text = dr("Debito")

            txt_cta_ing_interes.Text = dr("Interes")
            txt_cta_ing_mora.Text = dr("Mora")
            txt_cta_ing_otros.Text = dr("Otros")

            cmbTipo.SelectedValue = dr("IdTIpo")
            txtConcepto.Text = dr("DescripcionTipo")
        Next
        da.Dispose()
        ds.Dispose()
        lblDebitoIngreso.Text = ReturnDescripcion(txt_cta_db_ingresos.Text)

        lblInteres.Text = ReturnDescripcion(txt_cta_ing_interes.Text)
        lblMora.Text = ReturnDescripcion(txt_cta_ing_mora.Text)
        lblOtros.Text = ReturnDescripcion(txt_cta_ing_otros.Text)


        Dim ds1 As New DataSet
        Dim da1 As New MySqlDataAdapter("SELECT Utilidad, Cierre, Certificados FROM tbl_interfascontableotras WHERE ID=1", conn)
        da1.Fill(ds1, "tbl_interfascontableotras")

        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            txt_cta_utilidad.Text = dr1("Utilidad")
            txt_cta_cierre.Text = dr1("Cierre")
            ctaCertificadosTxt.Text = dr1("Certificados")

        Next
        da1.Dispose()
        ds1.Dispose()
        lblUtilidades.Text = ReturnDescripcion(txt_cta_utilidad.Text)
        lblCierre.Text = ReturnDescripcion(txt_cta_cierre.Text)
        ctaCertificadosLbl.Text = ReturnDescripcion(ctaCertificadosTxt.Text)

    End Sub

    Private Sub txt_cta_ing_interes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cta_ing_interes.KeyDown
        If e.KeyCode = Keys.F5 Then
            If frmsListaCatalogoCuentaContable() = True Then
                txt_cta_ing_interes.Text = Id
                lblInteres.Text = ReturnDescripcion(Id)
            End If
        End If
    End Sub

    Private Sub txt_cta_ing_mora_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cta_ing_mora.KeyDown
        If e.KeyCode = Keys.F5 Then
            If frmsListaCatalogoCuentaContable() = True Then
                txt_cta_ing_mora.Text = Id
                lblMora.Text = ReturnDescripcion(Id)
            End If
        End If
    End Sub

    Private Sub txt_cta_ing_otros_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cta_ing_otros.KeyDown
        If e.KeyCode = Keys.F5 Then
            If frmsListaCatalogoCuentaContable() = True Then
                txt_cta_ing_otros.Text = Id
                lblOtros.Text = ReturnDescripcion(Id)
            End If
        End If
    End Sub

    Private Sub txt_cta_db_ingresos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cta_db_ingresos.KeyDown
        If e.KeyCode = Keys.F5 Then
            If frmsListaCatalogoCuentaContable() = True Then
                txt_cta_db_ingresos.Text = Id
                lblDebitoIngreso.Text = ReturnDescripcion(Id)
            End If
        End If
    End Sub

    Private Sub btn_procesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_procesar.Click
        If btn_procesar.Text = "&Modificar" Then
            Modificar()
        Else
            Guardar()
        End If
        Alerta("Documento guardado")
        Me.Close()
    End Sub

    Private Sub fld_cta_utilidad_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cta_utilidad.KeyDown
        If e.KeyCode = Keys.F5 Then
            If frmsListaCatalogoCuentaContable() = True Then
                txt_cta_utilidad.Text = Id
                lblUtilidades.Text = ReturnDescripcion(Id)
            End If
        End If
    End Sub

    Private Sub fld_cta_cierre_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cta_cierre.KeyDown
        If e.KeyCode = Keys.F5 Then
            If frmsListaCatalogoCuentaContable() = True Then
                txt_cta_cierre.Text = Id
                lblCierre.Text = ReturnDescripcion(Id)
            End If
        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub



    Private Sub ctaCertificadosTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ctaCertificadosTxt.KeyDown
        If e.KeyCode = Keys.F5 Then
            If frmsListaCatalogoCuentaContable() = True Then
                ctaCertificadosTxt.Text = Id
                ctaCertificadosLbl.Text = ReturnDescripcion(Id)
            End If
        End If
    End Sub
End Class
