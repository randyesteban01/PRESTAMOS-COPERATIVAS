Imports MySql.Data.MySqlClient
Public Class FRM_BENEFICIARIOS
    Inherits System.Windows.Forms.Form
    Dim isNewData As Boolean = True
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
    Friend WithEvents fld_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents fld_id As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_BENEFICIARIOS))
        Me.fld_descripcion = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.LV = New System.Windows.Forms.ListView
        Me.fld_id = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'fld_descripcion
        '
        Me.fld_descripcion.BackColor = System.Drawing.Color.White
        Me.fld_descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_descripcion.Location = New System.Drawing.Point(104, 16)
        Me.fld_descripcion.MaxLength = 100
        Me.fld_descripcion.Name = "fld_descripcion"
        Me.fld_descripcion.Size = New System.Drawing.Size(336, 20)
        Me.fld_descripcion.TabIndex = 0
        Me.fld_descripcion.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Beneficiario"
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.LV.Location = New System.Drawing.Point(8, 40)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(432, 192)
        Me.LV.TabIndex = 1
        '
        'fld_id
        '
        Me.fld_id.Location = New System.Drawing.Point(416, 8)
        Me.fld_id.Name = "fld_id"
        Me.fld_id.Size = New System.Drawing.Size(24, 20)
        Me.fld_id.TabIndex = 3
        Me.fld_id.Text = ""
        Me.fld_id.Visible = False
        '
        'FRM_BENEFICIARIOS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(450, 242)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fld_descripcion)
        Me.Controls.Add(Me.fld_id)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_BENEFICIARIOS"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maestro de Beneficiarios"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FRM_BENEFICIARIOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        FillLV()
    End Sub

    Private Sub FRM_BENEFICIARIOS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub SAVE_DATA()
        NON_QUERY("INSERT INTO tbl_beneficiarios (fld_beneficiario) VALUES('" & fld_descripcion.Text & "')")
            
    End Sub
    Private Sub UPDATE_DATA(ByVal ID_DATA As String)
        NON_QUERY("UPDATE tbl_beneficiarios SET fld_beneficiario = '" & fld_descripcion.Text & "' WHERE fld_id=" & CInt(fld_id.Text) & "")

    End Sub
    Private Sub LOAD_DATA(ByVal ID_DATA As String)
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT * FROM tbl_beneficiarios WHERE fld_id=" & ID_DATA & ""
            dr = .ExecuteReader()

        End With
        If dr.Read() Then
            fld_id.Text = ID_DATA

            fld_descripcion.Text = dr("fld_beneficiario")

            isNewData = False
        End If
        cmd.Connection.Close()
        cmd.Dispose()
    End Sub
    Private Sub DELETE_DATA(ByVal ID_DATA As String)
        NON_QUERY("DELETE FROM tbl_beneficiarios WHERE fld_id=" & ID_DATA & "")
    End Sub
    Private Sub CLEAR_FIELDS()
        fld_id.Text = ""
        fld_descripcion.Text = ""
        isNewData = True
    End Sub
    Private Function VALIDA_DATA() As Boolean
        If Trim(fld_descripcion.Text) = "" Then
            Alerta("Debe escribir la descripción del documento")
            fld_descripcion.Focus()
            Return False
        End If
        Return True
    End Function
   Private Sub FillLV()

        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        LV.Clear()
        LV.View = View.Details
        LV.LabelEdit = False
        LV.FullRowSelect = True
        LV.GridLines = True
        LV.MultiSelect = False
        LV.Sorting = SortOrder.Ascending


        Dim fldToSearch As String = "fld_beneficiario" ' = cboSearch.Text
        Dim strTosearch As String = "'" & fld_descripcion.Text & "%'"
        Dim sqlSearch As String
        Dim accion As Short


        If strTosearch <> "" Then
            sqlSearch = "SELECT fld_id, fld_beneficiario FROM tbl_beneficiarios WHERE " & fldToSearch & " LIKE " & strTosearch & " "
        Else
            sqlSearch = "SELECT fld_id, fld_beneficiario FROM tbl_beneficiarios"
        End If

        ds.Reset()
        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, "tbl_beneficiarios")


        Dim columnText(2) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "CODIGO"
        columnText(1) = "Beneficiarios"
       

        Dim columnWidth(2) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 0
        columnWidth(1) = 408
       


        Dim columnAlign(2) As Int32 'PARA ALINEAR LOS DATOS
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
       

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
            LV.Items.Add(ii)
            'showing the number of records still added
        Next


    End Sub

    Private Sub fld_descripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_descripcion.KeyPress
        FillLV()

        If e.KeyChar = Chr(13) Then
            If VALIDA_DATA() = False Then Exit Sub
            If isNewData = True Then
                SAVE_DATA()
                Alerta("Documento guardado")
            Else
                UPDATE_DATA(fld_id.Text)
                Alerta("Documento modificado")
            End If
            FillLV()
            CLEAR_FIELDS()
        End If

    End Sub

    Private Sub LV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LV.KeyDown
        If e.KeyCode = Keys.Enter Then
            LOAD_DATA(LV.FocusedItem.Text)
        End If
    End Sub

    Private Sub LV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LV.DoubleClick
        LOAD_DATA(LV.FocusedItem.Text)
    End Sub

    

End Class
