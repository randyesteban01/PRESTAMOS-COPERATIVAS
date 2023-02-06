Imports MySql.Data.MySqlClient
Public Class frmCrearCtaContable
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
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaNo As System.Windows.Forms.TextBox
    Friend WithEvents cmbGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Private WithEvents lvData As System.Windows.Forms.ListView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbControl As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNivel As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbFiltrar As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCrearCtaContable))
        Me.txtID = New System.Windows.Forms.TextBox
        Me.txtCuentaNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbGrupo = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbTipo = New System.Windows.Forms.ComboBox
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.lvData = New System.Windows.Forms.ListView
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbControl = New System.Windows.Forms.ComboBox
        Me.cmbNivel = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbFiltrar = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(120, 8)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(120, 20)
        Me.txtID.TabIndex = 12
        Me.txtID.Text = "0"
        '
        'txtCuentaNo
        '
        Me.txtCuentaNo.Location = New System.Drawing.Point(120, 80)
        Me.txtCuentaNo.Name = "txtCuentaNo"
        Me.txtCuentaNo.Size = New System.Drawing.Size(120, 20)
        Me.txtCuentaNo.TabIndex = 2
        Me.txtCuentaNo.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ID :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "No. de Cuenta :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbGrupo
        '
        Me.cmbGrupo.Location = New System.Drawing.Point(120, 32)
        Me.cmbGrupo.Name = "cmbGrupo"
        Me.cmbGrupo.Size = New System.Drawing.Size(121, 21)
        Me.cmbGrupo.TabIndex = 0
        Me.cmbGrupo.Text = "ComboBox1"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Grupo :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(64, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tipo :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbTipo
        '
        Me.cmbTipo.Items.AddRange(New Object() {"Cuenta", "Grupo", "Auxiliar"})
        Me.cmbTipo.Location = New System.Drawing.Point(120, 56)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipo.TabIndex = 1
        Me.cmbTipo.Text = "Cuenta"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(312, 80)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(336, 20)
        Me.txtDescripcion.TabIndex = 5
        Me.txtDescripcion.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(208, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Descripción :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lvData
        '
        Me.lvData.Location = New System.Drawing.Point(8, 112)
        Me.lvData.Name = "lvData"
        Me.lvData.Size = New System.Drawing.Size(888, 432)
        Me.lvData.TabIndex = 11
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGuardar.Location = New System.Drawing.Point(752, 40)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(72, 56)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCerrar.Location = New System.Drawing.Point(824, 40)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 56)
        Me.btnCerrar.TabIndex = 16
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(256, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Control :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbControl
        '
        Me.cmbControl.Location = New System.Drawing.Point(312, 32)
        Me.cmbControl.Name = "cmbControl"
        Me.cmbControl.Size = New System.Drawing.Size(121, 21)
        Me.cmbControl.TabIndex = 3
        '
        'cmbNivel
        '
        Me.cmbNivel.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbNivel.Location = New System.Drawing.Point(312, 56)
        Me.cmbNivel.Name = "cmbNivel"
        Me.cmbNivel.Size = New System.Drawing.Size(121, 21)
        Me.cmbNivel.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(256, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Nivel :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbFiltrar
        '
        Me.cmbFiltrar.Items.AddRange(New Object() {"Todas", "Cuenta", "Grupo", "Auxiliar", "Cuenta, Grupo"})
        Me.cmbFiltrar.Location = New System.Drawing.Point(312, 8)
        Me.cmbFiltrar.Name = "cmbFiltrar"
        Me.cmbFiltrar.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltrar.TabIndex = 17
        Me.cmbFiltrar.Text = "Todas"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(256, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Filtrar :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmCrearCtaContable
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(914, 555)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbFiltrar)
        Me.Controls.Add(Me.cmbNivel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbControl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.lvData)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbGrupo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCuentaNo)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCrearCtaContable"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Cuenta Contable"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmCrearCtaContable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        LlenarGrupo()
        LlenarData()
    End Sub

  
    Private Function ValidarDatos() As Boolean

        If txtCuentaNo.Text = String.Empty Then
            Alerta("Escriba el número de cuenta por favor")
            txtCuentaNo.Focus()
            Return False
        ElseIf txtDescripcion.Text = String.Empty Then
            Alerta("Escriba la descripción de la cuenta por favor")
            txtDescripcion.Focus()
            Return False
        ElseIf btnGuardar.Text = "&Guardar" Then
            If SCALAR_NUM("SELECT IFNULL(1,0) FROM tbl_catalogo WHERE CuentaNo='" & txtCuentaNo.Text & "'") > 0 Then
                Alerta("Ésta cuenta ya existe en la Base de Datos")
                txtCuentaNo.Focus()
                Return False
            End If
        End If

        Return True

    End Function
    Private Sub Limpiar()
        btnGuardar.Text = "&Guardar"
        txtCuentaNo.Text = String.Empty
        txtDescripcion.Text = String.Empty
        
        LlenarData()
        cmbGrupo.Focus()

    End Sub
  
    Private Sub Guardar()
        Dim control As String = cmbControl.Text
        NON_QUERY("INSERT INTO tbl_catalogo (CuentaNo, Descripcion, Grupo, Tipo, CtaControl,Fecha, Usuario) VALUES('" & txtCuentaNo.Text & "','" & txtDescripcion.Text & "'," & cmbGrupo.SelectedValue & ",'" & cmbTipo.Text & "','" & control & "',Now(),'" & User(0) & "')")
    End Sub
    Private Sub Buscar(ByVal ID As Integer)
        Dim ds As New DataSet
        Dim dr As DataRow
        Dim da As New MySqlDataAdapter("SELECT ID, CuentaNo, Descripcion, Grupo, Tipo, CtaControl, Nivel FROM tbl_catalogo WHERE ID=" & ID & "", conn)
        da.Fill(ds, "tbl_catalogo")
        For Each dr In ds.Tables(0).Rows
            txtID.Text = dr("ID")
            txtCuentaNo.Text = dr("CuentaNo")
            cmbGrupo.SelectedValue = dr("Grupo")
            cmbTipo.Text = dr("Tipo")
            cmbControl.Text = dr("CtaControl")
            cmbNivel.Text = dr("Nivel")
            txtDescripcion.Text = dr("Descripcion")
            btnGuardar.Text = "&Modificar"
        Next
        da.Dispose()
        ds.Dispose()

    End Sub
    Private Sub Modificar(ByVal ID As Integer)
        Dim control As String = cmbControl.Text
        NON_QUERY("UPDATE tbl_catalogo SET CuentaNo='" & txtCuentaNo.Text & "', Descripcion='" & txtDescripcion.Text & "', Grupo=" & cmbGrupo.SelectedValue & ", Tipo='" & cmbTipo.Text & "', CtaControl='" & control & "' WHERE ID=" & ID & "")
    End Sub
    Private Sub LlenarData()

        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        lvData.Clear()
        lvData.View = View.Details
        lvData.LabelEdit = False
        lvData.FullRowSelect = True
        lvData.GridLines = True
        lvData.MultiSelect = False
        lvData.Sorting = SortOrder.None



        Dim sqlSearch As String

        If cmbFiltrar.Text = "Todas" Then
            sqlSearch = "SELECT c.ID, CuentaNo, c.Descripcion, cg.Descripcion, Tipo, CtaControl FROM tbl_catalogo AS c, tbl_catalogo_grupo AS cg WHERE c.Grupo=cg.ID ORDER BY CuentaNo ASC"
      
        ElseIf cmbFiltrar.Text = "Cuenta, Grupo" Then
            sqlSearch = "SELECT c.ID, CuentaNo, c.Descripcion, cg.Descripcion, Tipo, CtaControl FROM tbl_catalogo AS c, tbl_catalogo_grupo AS cg WHERE c.Grupo=cg.ID AND (Tipo ='Grupo' or Tipo='Cuenta') ORDER BY CuentaNo ASC"

        Else
            sqlSearch = "SELECT c.ID, CuentaNo, c.Descripcion, cg.Descripcion, Tipo, CtaControl FROM tbl_catalogo AS c, tbl_catalogo_grupo AS cg WHERE c.Grupo=cg.ID AND Tipo ='" & cmbFiltrar.Text & "' ORDER BY CuentaNo ASC"
        End If



        ds.Reset()
        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, "tbl_catalogo")


        Dim columnText(9) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "ID"
        columnText(1) = "Cuenta"
        columnText(2) = "Descripción"
        columnText(3) = "Grupo"
        columnText(4) = "Tipo"
        columnText(5) = "Control"
        columnText(6) = "Nivel"
        columnText(7) = "ORIGEN"
        columnText(8) = "CTA. CONTROL"


        Dim columnWidth(9) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 0
        columnWidth(1) = 125
        columnWidth(2) = 250
        columnWidth(3) = 150
        columnWidth(4) = 85
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
        columnAlign(6) = 0 'DERECHA
        columnAlign(7) = 0 'DERECHA
        columnAlign(8) = 0 'DERECHA

        Dim count = 0
        Dim c As DataColumn
        For Each c In ds.Tables(0).Columns
            'adding names of columns as Listview columns				
            Dim h As New ColumnHeader
            h.Text = columnText(count) ' c.ColumnName
            h.TextAlign = columnAlign(count)
            h.Width = columnWidth(count)
            Me.lvData.Columns.Add(h)
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
                    str(col) = rr(col)
                ElseIf rr(col).GetType().FullName.ToString = "System.DateTime" Then
                    str(col) = Format(rr(col), "d")
                ElseIf rr(col).GetType().FullName.ToString = "System.String" Then
                    str(col) = rr(col).ToString()
                ElseIf rr(col).GetType().FullName.ToString = "System.Double" Then
                    str(col) = Format(rr(col), "##,##0.00")
                End If
            Next

            Dim ii As New ListViewItem(str)
            lvData.Items.Add(ii)
            'showing the number of records still added
        Next


    End Sub
    Private Sub LlenarGrupo()
        Dim da As New MySqlDataAdapter("SELECT ID, Descripcion FROM tbl_catalogo_grupo ORDER BY ID", conn)
        Dim dt As New DataTable
        da.Fill(dt)

        cmbGrupo.DataSource = dt
        cmbGrupo.DisplayMember = "Descripcion"
        cmbGrupo.ValueMember = "ID"
    End Sub

    Private Sub LlenarControl(ByVal grupoCta As Integer)
         

        Dim da As New MySqlDataAdapter("SELECT CuentaNo FROM tbl_catalogo WHERE GRUPO=" & grupoCta & " AND TIPO <> 'Auxiliar' ORDER BY CuentaNo", conn)
        Dim dt As New DataTable
        da.Fill(dt)

        cmbControl.DataSource = dt
        cmbControl.DisplayMember = "CuentaNo"
        cmbControl.ValueMember = "CuentaNo"
    End Sub

    Private Sub cmbGrupo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbGrupo.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbTipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTipo.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If ValidarDatos() = False Then Return
        If btnGuardar.Text = "&Guardar" Then
            Guardar()
        Else
            Modificar(CInt(txtID.Text))
        End If
        Limpiar()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub lvData_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvData.DoubleClick
        Buscar(lvData.FocusedItem.Text)
    End Sub

    Private Sub cmbControl_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbControl.KeyPress
        e.Handled = True
    End Sub



    Private Sub cmbTipo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTipo.LostFocus
        If cmbTipo.Text = "Cuenta" Then
            LlenarControl(-1)
            cmbControl.SelectedText = 0
        Else

            LlenarControl(cmbGrupo.SelectedValue)
        End If
    End Sub

    Private Sub cmbNivel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNivel.SelectedIndexChanged

    End Sub

    Private Sub cmbNivel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbNivel.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGrupo.SelectedIndexChanged

    End Sub

    Private Sub cmbGrupo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbGrupo.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbTipo.Focus()
        End If
    End Sub

    Private Sub cmbTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipo.SelectedIndexChanged

    End Sub

    Private Sub cmbTipo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbTipo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCuentaNo.Focus()
        End If
    End Sub

    Private Sub txtCuentaNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuentaNo.TextChanged

    End Sub

    Private Sub txtCuentaNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuentaNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbControl.Focus()
        End If
    End Sub

    Private Sub cmbControl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbControl.SelectedIndexChanged

    End Sub

    Private Sub cmbControl_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbControl.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbNivel.Focus()
        End If
    End Sub

    Private Sub cmbNivel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbNivel.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDescripcion.Focus()
        End If
    End Sub

    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged

    End Sub

    Private Sub txtDescripcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnGuardar_Click(sender, e)
        End If
    End Sub

    Private Sub cmbFiltrar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFiltrar.SelectedIndexChanged
        LlenarData()
    End Sub

    Private Sub cmbFiltrar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbFiltrar.KeyPress
        e.Handled = True
    End Sub
End Class
