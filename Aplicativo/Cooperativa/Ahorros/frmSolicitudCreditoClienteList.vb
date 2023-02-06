Imports  MySql.Data.MySqlClient
Public Class frmSolicitudCreditoClienteList
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
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents txtBuscarPor As System.Windows.Forms.ComboBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSolicitudCreditoClienteList))
        Me.LV = New System.Windows.Forms.ListView
        Me.txtBuscarPor = New System.Windows.Forms.ComboBox
        Me.lblId = New System.Windows.Forms.Label
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.White
        Me.LV.Location = New System.Drawing.Point(5, 32)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(672, 264)
        Me.LV.TabIndex = 1
        '
        'txtBuscarPor
        '
        Me.txtBuscarPor.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.txtBuscarPor.ForeColor = System.Drawing.Color.White
        Me.txtBuscarPor.Items.AddRange(New Object() {"NOMBRE", "CEDULA"})
        Me.txtBuscarPor.Location = New System.Drawing.Point(69, 8)
        Me.txtBuscarPor.Name = "txtBuscarPor"
        Me.txtBuscarPor.Size = New System.Drawing.Size(160, 21)
        Me.txtBuscarPor.TabIndex = 4
        Me.txtBuscarPor.Text = "NOMBRE"
        '
        'lblId
        '
        Me.lblId.Location = New System.Drawing.Point(5, 8)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(80, 16)
        Me.lblId.TabIndex = 3
        Me.lblId.Text = "Buscar por:"
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.White
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Location = New System.Drawing.Point(229, 8)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(448, 20)
        Me.txtBuscar.TabIndex = 0
        Me.txtBuscar.Text = ""
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCerrar.Location = New System.Drawing.Point(605, 304)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 56)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmSolicitudCreditoClienteList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(682, 363)
        Me.Controls.Add(Me.txtBuscarPor)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.txtBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSolicitudCreditoClienteList"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Socios"
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub frmSolicitudCreditoClienteList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        FILL_LIST_VIEW()
    End Sub
    Private Sub frmSolicitudCreditoClienteList_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub


    Private Sub FILL_LIST_VIEW()
        LV.Clear()
        LV.View = View.Details
        LV.LabelEdit = False
        LV.FullRowSelect = True
        LV.GridLines = True
        LV.Sorting = SortOrder.Ascending


        Dim fldToSearch As String
        Dim strTosearch As String = "'%" & txtBuscar.Text & "%'"
        Dim sqlSearch As String
        Dim accion As Short



        fldToSearch = "CONCAT(fld_FullName,' ',fld_Identity)"

        If strTosearch <> "" Then
            sqlSearch = "SELECT fld_id,  fld_FullName, fld_Identity FROM SolicitudCreditoCliente WHERE " & fldToSearch & " LIKE " & strTosearch & " AND fld_status='N'"
        Else
            sqlSearch = "SELECT fld_id,  fld_FullName, fld_Identity FROM SolicitudCreditoCliente WHERE fld_status='N'"
        End If





        Dim ds As New DataSet



        Dim da As New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, "SolicitudCreditoCliente")


        Dim columnText(5) As String
        columnText(0) = "CODIGO"
        columnText(1) = "NOMBRE"
        columnText(2) = "CEDULA"
        columnText(3) = "2do. APELLIDO"
        columnText(4) = "CEDULA"



        Dim columnWidth(5) As Int32
        columnWidth(0) = 0
        columnWidth(1) = 470
        columnWidth(2) = 100
        columnWidth(3) = 120
        columnWidth(4) = 100

        Dim columnAlign(5) As Int32
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 0 'IZQUIERDA
        columnAlign(3) = 0
        columnAlign(4) = 0


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
                    str(col) = Format(rr(col), "0000")
                ElseIf rr(col).GetType().FullName.ToString = "System.Int32" Then
                    str(col) = Format(rr(col), "0000")
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


    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = Chr(13) Then
            FILL_LIST_VIEW()
        End If
    End Sub


    Private Sub LV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LV.DoubleClick
        Id = LV.FocusedItem.Text
        Me.Text = "ACEPTAR"
        Me.Close()
    End Sub

    Private Sub LV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LV.KeyDown
        If e.KeyCode = Keys.Enter Then
            Id = LV.FocusedItem.Text
            Me.Text = "ACEPTAR"
            Me.Close()
        End If
    End Sub

    Private Sub txtBuscarPor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarPor.KeyPress
        e.Handled = True
    End Sub


    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmSolicitudCreditoClienteList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        End If
    End Sub
End Class

