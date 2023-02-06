Imports MySql.Data.MySqlClient
Public Class FRM_NUMERACION_CTA
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
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents fld_id_med As System.Windows.Forms.TextBox
    Friend WithEvents btnCierra As System.Windows.Forms.Button
    Friend WithEvents btnNueva As System.Windows.Forms.Button
    Friend WithEvents btnGuarda As System.Windows.Forms.Button
    Friend WithEvents cmbCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtPrefijo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_NUMERACION_CTA))
        Me.LV = New System.Windows.Forms.ListView
        Me.fld_id_med = New System.Windows.Forms.TextBox
        Me.btnCierra = New System.Windows.Forms.Button
        Me.btnNueva = New System.Windows.Forms.Button
        Me.btnGuarda = New System.Windows.Forms.Button
        Me.cmbCategoria = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtPrefijo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.LV.Location = New System.Drawing.Point(72, 64)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(272, 96)
        Me.LV.TabIndex = 7
        '
        'fld_id_med
        '
        Me.fld_id_med.BackColor = System.Drawing.Color.White
        Me.fld_id_med.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fld_id_med.Location = New System.Drawing.Point(280, 24)
        Me.fld_id_med.Name = "fld_id_med"
        Me.fld_id_med.Size = New System.Drawing.Size(40, 20)
        Me.fld_id_med.TabIndex = 8
        Me.fld_id_med.Text = "0"
        '
        'btnCierra
        '
        Me.btnCierra.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCierra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCierra.ForeColor = System.Drawing.Color.Black
        Me.btnCierra.Image = CType(resources.GetObject("btnCierra.Image"), System.Drawing.Image)
        Me.btnCierra.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCierra.Location = New System.Drawing.Point(432, 72)
        Me.btnCierra.Name = "btnCierra"
        Me.btnCierra.Size = New System.Drawing.Size(72, 56)
        Me.btnCierra.TabIndex = 4
        Me.btnCierra.Text = "&Cerrar"
        Me.btnCierra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnNueva
        '
        Me.btnNueva.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNueva.ForeColor = System.Drawing.Color.Black
        Me.btnNueva.Image = CType(resources.GetObject("btnNueva.Image"), System.Drawing.Image)
        Me.btnNueva.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNueva.Location = New System.Drawing.Point(360, 16)
        Me.btnNueva.Name = "btnNueva"
        Me.btnNueva.Size = New System.Drawing.Size(72, 56)
        Me.btnNueva.TabIndex = 3
        Me.btnNueva.Text = "&Nuevo"
        Me.btnNueva.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnGuarda
        '
        Me.btnGuarda.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuarda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuarda.ForeColor = System.Drawing.Color.Black
        Me.btnGuarda.Image = CType(resources.GetObject("btnGuarda.Image"), System.Drawing.Image)
        Me.btnGuarda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuarda.Location = New System.Drawing.Point(432, 16)
        Me.btnGuarda.Name = "btnGuarda"
        Me.btnGuarda.Size = New System.Drawing.Size(72, 56)
        Me.btnGuarda.TabIndex = 2
        Me.btnGuarda.Text = "&Guardar"
        Me.btnGuarda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmbCategoria
        '
        Me.cmbCategoria.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategoria.ForeColor = System.Drawing.Color.White
        Me.cmbCategoria.Location = New System.Drawing.Point(72, 16)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(176, 21)
        Me.cmbCategoria.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(0, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 16)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Categoría"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrefijo
        '
        Me.txtPrefijo.Location = New System.Drawing.Point(72, 40)
        Me.txtPrefijo.MaxLength = 6
        Me.txtPrefijo.Name = "txtPrefijo"
        Me.txtPrefijo.Size = New System.Drawing.Size(72, 20)
        Me.txtPrefijo.TabIndex = 1
        Me.txtPrefijo.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(0, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Prefijo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FRM_NUMERACION_CTA
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(514, 171)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrefijo)
        Me.Controls.Add(Me.cmbCategoria)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnCierra)
        Me.Controls.Add(Me.btnNueva)
        Me.Controls.Add(Me.btnGuarda)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.fld_id_med)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_NUMERACION_CTA"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prefijos de Cuentas de Ahorros"
        Me.ResumeLayout(False)

    End Sub

#End Region



    '// PROPIEDADES DEL FORMULARIO
    Private Sub FRM_NUMERACION_CTA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        LlenarCategoria()
        FILL_LIST_VIEW()
    End Sub

    Private Sub FRM_NUMERACION_CTA_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub LlenarCategoria()

        Dim da As New MySqlDataAdapter("SELECT ID, Descripcion FROM tbl_ahorros_categorias ORDER BY Descripcion", conn)
        Dim dt As New DataTable
        da.Fill(dt)

        cmbCategoria.DataSource = dt
        cmbCategoria.DisplayMember = "Descripcion"
        cmbCategoria.ValueMember = "ID"

    End Sub
    Private Sub FILL_LIST_VIEW()

        LV.Clear()
        LV.View = View.Details
        LV.LabelEdit = False
        LV.FullRowSelect = True
        LV.GridLines = True
        LV.Sorting = SortOrder.None


        Dim sqlSearch As String
        Dim accion As Short


        sqlSearch = "SELECT p.ID, c.Descripcion, p.PreFijo FROM tbl_ahorros_categorias AS c INNER JOIN tbl_ahorros_prefijos_cta AS p ON c.ID=p.Categoria ORDER BY  c.Descripcion"


        Dim ds As New DataSet

        Dim da As New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds)


        Dim columnText(6) As String
        columnText(0) = "Código"
        columnText(1) = "Categoría"
        columnText(2) = "Prefijo"



        Dim columnWidth(6) As Int32
        columnWidth(0) = 0
        columnWidth(1) = 175
        columnWidth(2) = 75

        Dim columnAlign(6) As Int32
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 0 'IZQUIERDA


        Dim count = 0
        Dim c As DataColumn
        For Each c In ds.Tables(0).Columns

            Dim h As New ColumnHeader
            h.Text = columnText(count)
            h.TextAlign = columnAlign(count)
            h.Width = columnWidth(count)
            Me.LV.Columns.Add(h)
            count += 1
        Next



        Dim dt As DataTable = ds.Tables(0)
        Dim str(ds.Tables(0).Columns.Count) As String

        Dim rr As DataRow



        For Each rr In dt.Rows

            For col As Integer = 0 To ds.Tables(0).Columns.Count - 1
                If rr(col).GetType().FullName.ToString = "System.UInt32" Then
                    str(col) = Format(rr(col), "000000")
                ElseIf rr(col).GetType().FullName.ToString = "System.Int32" Then
                    str(col) = Format(rr(col), "000000")
                ElseIf rr(col).GetType().FullName.ToString = "System.DateTime" Then
                    str(col) = Format(rr(col), "d")
                ElseIf rr(col).GetType().FullName.ToString = "System.String" Then
                    str(col) = rr(col).ToString()
                ElseIf rr(col).GetType().FullName.ToString = "System.Decimal" Then
                    str(col) = Format(rr(col), "C2")
                End If
            Next

            Dim ii As New ListViewItem(str)
            Me.LV.Items.Add(ii)

        Next
    End Sub

    '//SUB RUTINAS
    Private Function VALIDAR() As Boolean
        If Trim(txtPrefijo.Text) = "" Then
            txtPrefijo.Focus()
            Alerta("Escriba el prefijo")
            Return False
        End If
        Return True
    End Function
    Private Sub NUEVO()
        txtPrefijo.Text = ""
        fld_id_med.Text = "0"
        btnGuarda.Text = "&Guardar"
    End Sub
    Private Sub GUARDAR()
        If SCALAR_NUM("SELECT IFNULL(1,0) FROM tbl_ahorros_prefijos_cta WHERE Categoria=" & cmbCategoria.SelectedValue & "") = 1 Then
            Alerta("Esta categoría ya tiene Prefijo")
            Return
        End If
        NON_QUERY("INSERT INTO tbl_ahorros_prefijos_cta (Categoria, PreFijo) VALUES(" & cmbCategoria.SelectedValue & ",'" & txtPrefijo.Text & "')")
        FILL_LIST_VIEW()
        NUEVO()
    End Sub
    Private Sub MODIFICAR()
        NON_QUERY("UPDATE tbl_ahorros_prefijos_cta  SET Categoria=" & cmbCategoria.SelectedValue & ", PreFijo='" & txtPrefijo.Text & "' WHERE ID=" & fld_id_med.Text & "")
        FILL_LIST_VIEW()
        NUEVO()
    End Sub
    Private Sub BORRAR(ByVal id_doc As String)
        If Alerta("Está a punto de borrar el documento sin posibilidad de recuperarlo" & Chr(13) & "¿Desea continuar?") = False Then Exit Sub

        NON_QUERY("DELETE FROM tbl_ahorros_prefijos_cta  WHERE ID=" & id_doc & "")
        FILL_LIST_VIEW()
    End Sub
    Private Sub BUSCAR(ByVal id_doc As String)
        Dim cmd As New MySqlCommand, dr As MySqlDataReader
        With cmd
            .Connection = conn
            .CommandText = "SELECT * FROM tbl_ahorros_prefijos_cta  WHERE ID=" & id_doc & ""
            .Connection.Open()
            dr = .ExecuteReader

        End With
        If dr.Read Then
            fld_id_med.Text = id_doc
            cmbCategoria.SelectedValue = dr("Categoria")
            txtPrefijo.Text = dr("Prefijo")
            btnGuarda.Text = "&Modificar"
        End If
        dr.Close()
        cmd.Connection.Close()
        cmd.Dispose()

    End Sub

    '// EVENTOS DE LOS CAMPOS
    Private Sub btnNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNueva.Click
        NUEVO()
    End Sub

    Private Sub btnGuarda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuarda.Click
        If VALIDAR() = False Then Exit Sub
        If btnGuarda.Text = "&Modificar" Then
            MODIFICAR()
        Else
            GUARDAR()
        End If
        FILL_LIST_VIEW()
    End Sub

    Private Sub btnCierra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCierra.Click
        Me.Close()
    End Sub

    Private Sub LV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LV.KeyDown
        If e.KeyCode = Keys.Delete Then
            BORRAR(LV.FocusedItem.Text)
        ElseIf e.KeyCode = Keys.Enter Then
            BUSCAR(LV.FocusedItem.Text)
        End If
    End Sub

    Private Sub LV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LV.DoubleClick
        BUSCAR(LV.FocusedItem.Text)
    End Sub


End Class
