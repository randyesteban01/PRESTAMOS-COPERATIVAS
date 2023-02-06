Imports MySql.Data.MySqlClient
Public Class FRM_MANTENIMIENTO_CMB
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
    Friend WithEvents lblTeléfono As System.Windows.Forms.Label
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents fld_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents btnCierra As System.Windows.Forms.Button
    Friend WithEvents bntBorra As System.Windows.Forms.Button
    Friend WithEvents btnNueva As System.Windows.Forms.Button
    Friend WithEvents btnGuarda As System.Windows.Forms.Button
    Friend WithEvents fld_id_med As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_MANTENIMIENTO_CMB))
        Me.LV = New System.Windows.Forms.ListView
        Me.fld_descripcion = New System.Windows.Forms.TextBox
        Me.lblTeléfono = New System.Windows.Forms.Label
        Me.btnCierra = New System.Windows.Forms.Button
        Me.bntBorra = New System.Windows.Forms.Button
        Me.btnNueva = New System.Windows.Forms.Button
        Me.btnGuarda = New System.Windows.Forms.Button
        Me.fld_id_med = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.White
        Me.LV.Location = New System.Drawing.Point(8, 40)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(352, 216)
        Me.LV.TabIndex = 90
        '
        'fld_descripcion
        '
        Me.fld_descripcion.BackColor = System.Drawing.Color.White
        Me.fld_descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_descripcion.Location = New System.Drawing.Point(8, 16)
        Me.fld_descripcion.Name = "fld_descripcion"
        Me.fld_descripcion.Size = New System.Drawing.Size(352, 20)
        Me.fld_descripcion.TabIndex = 81
        Me.fld_descripcion.Text = ""
        '
        'lblTeléfono
        '
        Me.lblTeléfono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblTeléfono.Location = New System.Drawing.Point(8, 0)
        Me.lblTeléfono.Name = "lblTeléfono"
        Me.lblTeléfono.Size = New System.Drawing.Size(88, 16)
        Me.lblTeléfono.TabIndex = 89
        Me.lblTeléfono.Text = "Descripción"
        '
        'btnCierra
        '
        Me.btnCierra.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCierra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCierra.ForeColor = System.Drawing.Color.Black
        Me.btnCierra.Image = CType(resources.GetObject("btnCierra.Image"), System.Drawing.Image)
        Me.btnCierra.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCierra.Location = New System.Drawing.Point(224, 264)
        Me.btnCierra.Name = "btnCierra"
        Me.btnCierra.Size = New System.Drawing.Size(72, 56)
        Me.btnCierra.TabIndex = 11
        Me.btnCierra.Text = "&Cerrar"
        Me.btnCierra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bntBorra
        '
        Me.bntBorra.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bntBorra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntBorra.ForeColor = System.Drawing.Color.Black
        Me.bntBorra.Image = CType(resources.GetObject("bntBorra.Image"), System.Drawing.Image)
        Me.bntBorra.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bntBorra.Location = New System.Drawing.Point(152, 264)
        Me.bntBorra.Name = "bntBorra"
        Me.bntBorra.Size = New System.Drawing.Size(72, 56)
        Me.bntBorra.TabIndex = 10
        Me.bntBorra.Text = "&Borrar"
        Me.bntBorra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnNueva
        '
        Me.btnNueva.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNueva.ForeColor = System.Drawing.Color.Black
        Me.btnNueva.Image = CType(resources.GetObject("btnNueva.Image"), System.Drawing.Image)
        Me.btnNueva.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNueva.Location = New System.Drawing.Point(8, 264)
        Me.btnNueva.Name = "btnNueva"
        Me.btnNueva.Size = New System.Drawing.Size(72, 56)
        Me.btnNueva.TabIndex = 9
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
        Me.btnGuarda.Location = New System.Drawing.Point(80, 264)
        Me.btnGuarda.Name = "btnGuarda"
        Me.btnGuarda.Size = New System.Drawing.Size(72, 56)
        Me.btnGuarda.TabIndex = 8
        Me.btnGuarda.Text = "&Guardar"
        Me.btnGuarda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'fld_id_med
        '
        Me.fld_id_med.Location = New System.Drawing.Point(320, 288)
        Me.fld_id_med.Name = "fld_id_med"
        Me.fld_id_med.TabIndex = 91
        Me.fld_id_med.Text = "0"
        Me.fld_id_med.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FRM_MANTENIMIENTO_CMB
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(370, 323)
        Me.Controls.Add(Me.fld_id_med)
        Me.Controls.Add(Me.btnCierra)
        Me.Controls.Add(Me.bntBorra)
        Me.Controls.Add(Me.btnNueva)
        Me.Controls.Add(Me.btnGuarda)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.lblTeléfono)
        Me.Controls.Add(Me.fld_descripcion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_MANTENIMIENTO_CMB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Tabla As String

    '// PROPIEDADES DEL FORMULARIO
    Private Sub FRM_MANTENIMIENTO_CMB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        FILL_LIST_VIEW()
    End Sub

    Private Sub FRM_MANTENIMIENTO_CMB_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        

    End Sub

    Private Sub FILL_LIST_VIEW()

        LV.Clear()
        LV.View = View.Details
        LV.LabelEdit = False
        LV.FullRowSelect = True
        LV.GridLines = True
        LV.Sorting = SortOrder.None

        Dim fldToSearch As String = "Descripcion"
        Dim strTosearch As String = "'%" & fld_descripcion.Text & "%'"
        Dim sqlSearch As String
        Dim accion As Short


        If strTosearch <> "'%%'" Then
            sqlSearch = "SELECT ID, Descripcion FROM " & Tabla & " WHERE " & fldToSearch & " LIKE " & strTosearch & " ORDER BY Descripcion"
        Else
            sqlSearch = "SELECT ID, Descripcion FROM " & Tabla & " ORDER BY Descripcion"
        End If


        ' sqlSearch = "SELECT id_med, fld_descripcion FROM tbl_ciudad"




        Dim ds As New DataSet



        Dim da As New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, Tabla)


        Dim columnText(6) As String
        columnText(0) = "Código"
        columnText(1) = "_"



        Dim columnWidth(6) As Int32
        columnWidth(0) = 0
        columnWidth(1) = 289


        Dim columnAlign(6) As Int32
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA


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
        If Trim(fld_descripcion.Text) = "" Then
            fld_descripcion.Focus()
            Alerta("Escriba la descripción")
            Return False
        End If
        Return True
    End Function
    Private Sub NUEVO()
        fld_descripcion.Text = ""
        fld_id_med.Text = ""
        btnGuarda.Text = "&Guardar"


    End Sub
    Private Sub GUARDAR()
        NON_QUERY("INSERT INTO " & Tabla & " (Descripcion) VALUES('" & fld_descripcion.Text & " ')")
        FILL_LIST_VIEW()
        NUEVO()
    End Sub
    Private Sub MODIFICAR()
        NON_QUERY("UPDATE " & Tabla & "  SET Descripcion='" & fld_descripcion.Text & " 'WHERE ID=" & fld_id_med.Text & "")
        FILL_LIST_VIEW()
        NUEVO()
    End Sub
    Private Sub BORRAR(ByVal id_doc As String)
        If Alerta("Está a punto de borrar el documento sin posibilidad de recuperarlo" & Chr(13) & "¿Desea continuar?") = False Then Exit Sub

        NON_QUERY("DELETE FROM " & Tabla & "  WHERE ID=" & id_doc & "")
        FILL_LIST_VIEW()
    End Sub
    Private Sub BUSCAR(ByVal id_doc As String)
        Dim cmd As New MySqlCommand, dr As MySqlDataReader
        With cmd
            .Connection = conn
            .CommandText = "SELECT * FROM " & Tabla & "  WHERE ID=" & id_doc & ""
            .Connection.Open()
            dr = .ExecuteReader

        End With
        If dr.Read Then
            fld_id_med.Text = id_doc
            fld_descripcion.Text = dr("Descripcion")
            btnGuarda.Text = "&Modificar"
        End If
        dr.Close()
        cmd.Connection.Close()
        cmd.Dispose()

    End Sub

    '// BOTONES





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

    Private Sub bntBorra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntBorra.Click
        If btnGuarda.Text = "&Modificar" Then
            BORRAR(fld_id_med.Text)
        Else
            Alerta("Debe cargar el documento")
        End If
    End Sub

    Private Sub btnCierra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCierra.Click
        Me.Close()
    End Sub
    Private Sub fld_descripcion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fld_descripcion.KeyDown

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
