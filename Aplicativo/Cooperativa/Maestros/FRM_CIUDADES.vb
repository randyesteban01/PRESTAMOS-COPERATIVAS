Imports MySql.Data.MySqlClient
Public Class FRM_CIUDADES
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnProcesar As System.Windows.Forms.Button
    Friend WithEvents fldDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents fldCodigo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_CIUDADES))
        Me.Label2 = New System.Windows.Forms.Label
        Me.fldDescripcion = New System.Windows.Forms.TextBox
        Me.LV = New System.Windows.Forms.ListView
        Me.fldCodigo = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.BtnProcesar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Descripción"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fldDescripcion
        '
        Me.fldDescripcion.BackColor = System.Drawing.Color.White
        Me.fldDescripcion.Location = New System.Drawing.Point(8, 24)
        Me.fldDescripcion.Name = "fldDescripcion"
        Me.fldDescripcion.Size = New System.Drawing.Size(280, 20)
        Me.fldDescripcion.TabIndex = 0
        Me.fldDescripcion.Text = ""
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.LV.Location = New System.Drawing.Point(8, 48)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(304, 304)
        Me.LV.TabIndex = 4
        '
        'fldCodigo
        '
        Me.fldCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fldCodigo.Location = New System.Drawing.Point(160, 392)
        Me.fldCodigo.Name = "fldCodigo"
        Me.fldCodigo.Size = New System.Drawing.Size(48, 20)
        Me.fldCodigo.TabIndex = 6
        Me.fldCodigo.Text = "0"
        Me.fldCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.fldCodigo.Visible = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(8, 360)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 56)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "&Nueva"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnCancelar.ForeColor = System.Drawing.Color.Black
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnCancelar.Location = New System.Drawing.Point(240, 360)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(72, 56)
        Me.BtnCancelar.TabIndex = 3
        Me.BtnCancelar.Text = "&Cerrar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'BtnProcesar
        '
        Me.BtnProcesar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnProcesar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnProcesar.ForeColor = System.Drawing.Color.Black
        Me.BtnProcesar.Image = CType(resources.GetObject("BtnProcesar.Image"), System.Drawing.Image)
        Me.BtnProcesar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnProcesar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnProcesar.Location = New System.Drawing.Point(80, 360)
        Me.BtnProcesar.Name = "BtnProcesar"
        Me.BtnProcesar.Size = New System.Drawing.Size(72, 56)
        Me.BtnProcesar.TabIndex = 1
        Me.BtnProcesar.Text = "&Guardar"
        Me.BtnProcesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'FRM_CIUDADES
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(322, 419)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnProcesar)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fldDescripcion)
        Me.Controls.Add(Me.fldCodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_CIUDADES"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ciudades"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FRM_CIUDADES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        FILL_LIST_VIEW()
    End Sub

    Private Sub CLEAR_DATA()
        fldDescripcion.Text = ""
        fldCodigo.Text = "0"
        BtnProcesar.Text = "&Guardar"
        FILL_LIST_VIEW()
    End Sub

    Private Sub SAVE_DATA()



        NON_QUERY("INSERT INTO tbl_ciudad (fldDescripcion) VALUES('" & fldDescripcion.Text & "')")


        CLEAR_DATA()
        FILL_LIST_VIEW()

    End Sub

    Private Sub UPDATE_DATA()


        NON_QUERY("UPDATE tbl_ciudad SET fldDescripcion='" & fldDescripcion.Text & "' WHERE fldCodigo = " & fldCodigo.Text & "")
        CLEAR_DATA()


    End Sub

    Private Sub LOAD_DATA(ByVal id_doc As Integer)





        Dim cmd As New MySqlCommand, dr As MySqlDataReader
        With cmd
            .CommandText = "SELECT * FROM tbl_ciudad WHERE fldCodigo =" & id_doc & ""
            .Connection = conn
            .Connection.Open()
            dr = .ExecuteReader

        End With

        If dr.Read Then
            fldCodigo.Text = id_doc
            fldDescripcion.Text = dr("fldDescripcion")

            BtnProcesar.Text = "&Modificar"
        End If
        dr.Close()
        dr = Nothing
        cmd.Connection.Close()
        cmd = Nothing
    End Sub



    Private Sub DELETE_DATA(ByVal id_doc As String)

        If Alerta("¿Seguro que desea continuar?") = False Then
            Exit Sub
        End If

        NON_QUERY("DELETE FROM tbl_ciudad WHERE fldCodigo=" & id_doc & "")
        FILL_LIST_VIEW()
    End Sub

    Private Sub FILL_LIST_VIEW()
        LV.Clear()
        LV.View = View.Details
        LV.LabelEdit = False
        LV.FullRowSelect = True
        LV.GridLines = True
        LV.Sorting = SortOrder.None

        Dim fldToSearch As String = "fldDescripcion"
        Dim strTosearch As String = "'" & fldDescripcion.Text & "%'"
        Dim sqlSearch As String
        Dim accion As Short
        Dim columnText(6) As String


        Dim ds As New DataSet

        If strTosearch <> "" Then
            sqlSearch = "SELECT fldCodigo, fldDescripcion FROM tbl_ciudad WHERE " & fldToSearch & " LIKE " & strTosearch & " ORDER BY fldDescripcion ASC LIMIT 150"
        Else
            sqlSearch = "SELECT fldCodigo, fldDescripcion FROM tbl_ciudad ORDER BY fldDescripcion ASC LIMIT 150"
        End If

        Dim da As New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, "tbl_ciudad")

        columnText(0) = "Código"
        columnText(1) = "Descripción"
        columnText(2) = "CELULAR"
        columnText(3) = "TRABAJO"
        columnText(4) = "CASA"
        columnText(5) = "BALANCE"


        Dim columnWidth(6) As Int32
        columnWidth(0) = 0
        columnWidth(1) = 280
        columnWidth(2) = 96
        columnWidth(3) = 96
        columnWidth(4) = 96
        columnWidth(5) = 100

        Dim columnAlign(6) As Int32
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 1 'IZQUIERDA
        columnAlign(3) = 1
        columnAlign(4) = 1
        columnAlign(5) = 1

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
                    str(col) = Format(rr(col), "000")
                ElseIf rr(col).GetType().FullName.ToString = "System.Int32" Then
                    str(col) = Format(rr(col), "000")
                ElseIf rr(col).GetType().FullName.ToString = "System.DateTime" Then
                    str(col) = Format(rr(col), "dd/MMM/yyyy")
                ElseIf rr(col).GetType().FullName.ToString = "System.String" Then
                    str(col) = rr(col).ToString()
                ElseIf rr(col).GetType().FullName.ToString = "System.Decimal" Then
                    str(col) = Format(rr(col), "C2")
                ElseIf rr(col).GetType().FullName.ToString = "System.Double" Then
                    str(col) = Format(rr(col), "C2")
                End If
            Next

            Dim ii As New ListViewItem(str)
            Me.LV.Items.Add(ii)

        Next
    End Sub


    Private Sub LV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LV.KeyDown
        If e.KeyCode = Keys.Delete Then
            DELETE_DATA(LV.FocusedItem.Text)
        ElseIf e.KeyCode = Keys.Enter Then
            LOAD_DATA(LV.FocusedItem.Text)
        End If
    End Sub

    Private Sub LV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LV.DoubleClick
        LOAD_DATA(LV.FocusedItem.Text)
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CLEAR_DATA()
    End Sub

    Private Sub BtnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProcesar.Click
        If BtnProcesar.Text = "&Guardar" Then
            SAVE_DATA()
        Else
            UPDATE_DATA()
        End If
    End Sub

    Private Sub btnImprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FRMS_REPORTES_NO_FECHA("AGENDA")
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub


    Private Sub fldDescripcion_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fldDescripcion.KeyUp
        FILL_LIST_VIEW()
    End Sub

    Private Sub LV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged

    End Sub

    Private Sub FRM_CIUDADES_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class
