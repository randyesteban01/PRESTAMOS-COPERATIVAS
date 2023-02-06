Imports  MySql.Data.MySqlClient
Public Class FRM_LIST_RECEP_SIN_ACT_AUX
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnAnular As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btn_Act_Aux As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_LIST_RECEP_SIN_ACT_AUX))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LV = New System.Windows.Forms.ListView
        Me.txtdescription = New System.Windows.Forms.TextBox
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.lblStatus = New System.Windows.Forms.Label
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnAnular = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btn_Act_Aux = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_Act_Aux)
        Me.GroupBox1.Controls.Add(Me.LV)
        Me.GroupBox1.Controls.Add(Me.txtdescription)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.btnCerrar)
        Me.GroupBox1.Controls.Add(Me.btnAnular)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(3, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(621, 320)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LV.Location = New System.Drawing.Point(7, 40)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(465, 272)
        Me.LV.TabIndex = 1
        '
        'txtdescription
        '
        Me.txtdescription.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtdescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescription.Location = New System.Drawing.Point(6, 16)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(466, 20)
        Me.txtdescription.TabIndex = 0
        Me.txtdescription.Text = ""
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Location = New System.Drawing.Point(16, 248)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 23)
        Me.btnNuevo.TabIndex = 6
        Me.btnNuevo.Text = "&NUEVO"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(176, 216)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(100, 16)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Text = "Label1"
        Me.lblStatus.Visible = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Location = New System.Drawing.Point(271, 248)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 23)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.Text = "&CERRAR"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnAnular
        '
        Me.btnAnular.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAnular.ForeColor = System.Drawing.Color.Black
        Me.btnAnular.Location = New System.Drawing.Point(186, 248)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(72, 23)
        Me.btnAnular.TabIndex = 3
        Me.btnAnular.Text = "&ANULAR"
        Me.btnAnular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Location = New System.Drawing.Point(101, 248)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(72, 23)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "&GUARDAR"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btn_Act_Aux
        '
        Me.btn_Act_Aux.Location = New System.Drawing.Point(480, 40)
        Me.btn_Act_Aux.Name = "btn_Act_Aux"
        Me.btn_Act_Aux.Size = New System.Drawing.Size(136, 23)
        Me.btn_Act_Aux.TabIndex = 7
        Me.btn_Act_Aux.Text = "Actuliazar Cta. Aux."
        '
        'FRM_LIST_RECEP_SIN_ACT_AUX
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(626, 330)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_LIST_RECEP_SIN_ACT_AUX"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Recepciones que no tienen la cuenta Aux. actulizada"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds As New DataSet
    Dim da As New MySqlDataAdapter
    Dim CurrentId As String

    Private Sub FRM_LIST_RECEP_SIN_ACT_AUX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillLV()
    End Sub

    Private Sub FRM_LIST_RECEP_SIN_ACT_AUX_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

#Region "ALL SUB"


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
        Dim fldToSearch As String = "fldCompany"



        Dim strTosearch As String = "'" & txtdescription.Text & "%'"
        Dim sqlSearch As String
        Dim accion As Short
        Trim(strTosearch)

       
        If strTosearch <> "" Then
            sqlSearch = "SELECT fldInvoiceID, fldCompany, fldCondicion, fldImporte FROM view_recepcion_mercancia WHERE " & fldToSearch & " LIKE " & strTosearch & " AND fldCondicion='CREDITO' AND fldActAux='NO'"

        Else
            sqlSearch = "SELECT fldInvoiceID, fldCompany, fldCondicion, fldImporte FROM view_recepcion_mercancia WHERE  fldCondicion='CREDITO' AND fldActAux='NO'"

        End If




        ds.Reset()
        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, "view_recepcion_mercancia")


        Dim columnText(4) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "CODIGO"
        columnText(1) = "PROVEEDOR"
        columnText(2) = "CONDICION"
        columnText(3) = "IMPORTE"

        Dim columnWidth(4) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 85
        columnWidth(1) = 175
        columnWidth(2) = 85
        columnWidth(3) = 85

        Dim columnAlign(4) As Int32 'PARA ALINEAR LOS DATOS
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 0 'IZQUIERDA
        columnAlign(3) = 1 'DERECHA


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
                    str(col) = Format(rr(col), "##,##0.00")
                End If
            Next

            Dim ii As New ListViewItem(str)
            LV.Items.Add(ii)
            'showing the number of records still added
        Next


    End Sub
    Private Sub LoadInvoice(ByVal Ids As String)
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_recepcion", conn)
        da.Fill(ds, "tbl_recepcion")

        With ds.Tables("tbl_recepcion")

            .PrimaryKey = New DataColumn() {.Columns("fldInvoiceID")}

        End With

        dr = ds.Tables("tbl_recepcion").Rows.Find(Ids)
        If Not (dr Is Nothing) Then

            create_row_estado_proveedor(CStr(dr("fldSupplier")), CDbl(dr("fldImporte")), "FACTURACREDITO", Ids, "RECEPCION DE MERCANCIA")
            update_recepcion(Ids)
            ds.Dispose()
            da.Dispose()
            Exit Sub
        End If


    End Sub
    Private Sub update_recepcion(ByVal ids As String)

        Dim cmd As New MySqlCommand
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "UPDATE tbl_recepcion SET fldActAux = 'SI' WHERE fldInvoiceID=" & ids & ""
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd.Dispose()
    End Sub


#End Region

    Private Sub txtdescription_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescription.KeyPress
        FillLV()
        If e.KeyChar = Chr(13) Then
            LV.Focus() 'LoadData(CurrentId)
        End If
    End Sub

    Private Sub LV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LV.KeyPress
        If e.KeyChar = Chr(13) Then
            Id = LV.FocusedItem.Text
            Me.Text = "ACEPTAR"
            Me.Close()
        End If
    End Sub

    Private Sub LV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LV.DoubleClick
        Id = LV.FocusedItem.Text
        Me.Text = "ACEPTAR"
        Me.Close()
    End Sub


    Private Sub btn_Act_Aux_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Act_Aux.Click
        If MsgBoxQuestion("SMC", "Favor verificar que los datos sean conrectos... ¿continuar?") = "YES" Then
            LoadInvoice(LV.FocusedItem.Text)
            MessageBox.Show("Cuenta Axu. actualizada con exito", "SMC", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FillLV()
        End If
    End Sub
End Class
