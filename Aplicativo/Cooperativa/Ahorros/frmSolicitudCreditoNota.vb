Imports MySql.Data.MySqlClient
Public Class frmSolicitudCreditoNota
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
    Friend WithEvents notaTxt As System.Windows.Forms.TextBox
    Friend WithEvents guardarBtn As System.Windows.Forms.Button
    Friend WithEvents cerrarBtn As System.Windows.Forms.Button
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSolicitudCreditoNota))
        Me.notaTxt = New System.Windows.Forms.TextBox
        Me.guardarBtn = New System.Windows.Forms.Button
        Me.cerrarBtn = New System.Windows.Forms.Button
        Me.LV = New System.Windows.Forms.ListView
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'notaTxt
        '
        Me.notaTxt.Location = New System.Drawing.Point(0, 8)
        Me.notaTxt.MaxLength = 2000
        Me.notaTxt.Multiline = True
        Me.notaTxt.Name = "notaTxt"
        Me.notaTxt.Size = New System.Drawing.Size(558, 56)
        Me.notaTxt.TabIndex = 0
        Me.notaTxt.Text = ""
        '
        'guardarBtn
        '
        Me.guardarBtn.BackColor = System.Drawing.SystemColors.Control
        Me.guardarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.guardarBtn.ForeColor = System.Drawing.Color.Black
        Me.guardarBtn.Image = CType(resources.GetObject("guardarBtn.Image"), System.Drawing.Image)
        Me.guardarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.guardarBtn.Location = New System.Drawing.Point(632, 8)
        Me.guardarBtn.Name = "guardarBtn"
        Me.guardarBtn.Size = New System.Drawing.Size(72, 56)
        Me.guardarBtn.TabIndex = 16
        Me.guardarBtn.Text = "&Guardar"
        Me.guardarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cerrarBtn
        '
        Me.cerrarBtn.BackColor = System.Drawing.SystemColors.Control
        Me.cerrarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cerrarBtn.ForeColor = System.Drawing.Color.Black
        Me.cerrarBtn.Image = CType(resources.GetObject("cerrarBtn.Image"), System.Drawing.Image)
        Me.cerrarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cerrarBtn.Location = New System.Drawing.Point(704, 8)
        Me.cerrarBtn.Name = "cerrarBtn"
        Me.cerrarBtn.Size = New System.Drawing.Size(72, 56)
        Me.cerrarBtn.TabIndex = 21
        Me.cerrarBtn.Text = "&Cerrar"
        Me.cerrarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'LV
        '
        Me.LV.Location = New System.Drawing.Point(0, 72)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(778, 256)
        Me.LV.TabIndex = 22
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(560, 8)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 56)
        Me.btnNuevo.TabIndex = 23
        Me.btnNuevo.Text = "&Nueva"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmSolicitudCreditoNota
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(783, 338)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.cerrarBtn)
        Me.Controls.Add(Me.guardarBtn)
        Me.Controls.Add(Me.notaTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSolicitudCreditoNota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitud Crédito Nota"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Friend IdSolicitud As Integer
    Private Sub frmSolicitudCreditoNota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        FillListView()
    End Sub
    Public Sub FillListView()

        lv.Clear()
        lv.View = View.Details
        lv.LabelEdit = False
        lv.FullRowSelect = True
        lv.GridLines = True
        lv.Sorting = SortOrder.None

        Dim fldToSearch As String
        Dim strTosearch As String
        Dim sqlSearch As String
        Dim accion As Short

        sqlSearch = "SELECT scn.Id, scn.Fecha, u.fld_UserID, scn.Nota FROM solicitudcreditonota AS scn INNER JOIN tbl_user AS u ON scn.IdUser = u.fld_id WHERE scn.IdSolicitud=" & IdSolicitud & "; "

        Dim ds As New DataSet
        Dim da As MySqlDataAdapter

        ds.Reset()
        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds)

        Dim columnText(17) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "ID"
        columnText(1) = "Fecha"
        columnText(2) = "Usuario"
        columnText(3) = "Nota"
        columnText(4) = "Monto"
        columnText(5) = "Estado"

        Dim columnWidth(17) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 0
        columnWidth(1) = 130
        columnWidth(2) = 125
        columnWidth(3) = 500
        columnWidth(4) = 100
        columnWidth(5) = 100

        Dim columnAlign(17) As Int32 'PARA ALINEAR LOS DATOS
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 0 'IZQUIERDA
        columnAlign(3) = 0 'DERECHA
        columnAlign(4) = 1 'IZQUIERDA
        columnAlign(5) = 0 'IZQUIERDA


        Dim count = 0
        Dim c As DataColumn
        For Each c In ds.Tables(0).Columns
            'adding names of columns as Listview columns				
            Dim h As New ColumnHeader
            h.Text = columnText(count) ' c.ColumnName
            h.TextAlign = columnAlign(count)
            h.Width = columnWidth(count)
            Me.lv.Columns.Add(h)
            count += 1
        Next

        Dim dt As DataTable = ds.Tables(0)
        Dim str(ds.Tables(0).Columns.Count) As String
        'adding Datarows as listview Grids
        Dim rr As DataRow

        For Each rr In dt.Rows

            For col As Integer = 0 To ds.Tables(0).Columns.Count - 1
                accion = 2 '/FORMATEAMO LOS DATOS DE ACUERDO A SU FORMATO, ESTO SE HACE POR CADA COLUMNA QUE EXISTA
                If rr(col).GetType().FullName.ToString = "System.Int32" Then
                    str(col) = Format(rr(col), "00000")
                ElseIf rr(col).GetType().FullName.ToString = "System.UInt32" Then
                    str(col) = Format(rr(col), "00000")
                ElseIf rr(col).GetType().FullName.ToString = "System.Int" Then
                    str(col) = Format(rr(col), "00000")
                ElseIf rr(col).GetType().FullName.ToString = "System.DateTime" Then
                    str(col) = Format(rr(col), "dd/MMM/yy hh:mm:ss tt")
                ElseIf rr(col).GetType().FullName.ToString = "System.String" Then
                    str(col) = rr(col).ToString()
                ElseIf rr(col).GetType().FullName.ToString = "System.Double" Then
                    str(col) = Format(rr(col), "C2")
                ElseIf rr(col).GetType().FullName.ToString = "System.Decimal" Then
                    str(col) = Format(rr(col), "C2")
                End If
            Next
            '

            Dim ii As New ListViewItem(str)
            lv.Items.Add(ii)

            'showing the number of records still added
        Next

    End Sub

    Private Sub guardarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardarBtn.Click

        If notaTxt.Text = String.Empty Then
            Alerta("Escriba un comentario por favor")
            Exit Sub
        End If

        NON_QUERY("INSERT INTO solicitudcreditonota(Fecha, IdSolicitud, IdUser, Nota) VALUES(Now()," & IdSolicitud & "," & User(5) & ",'" & notaTxt.Text & "') ")
        notaTxt.Text = String.Empty
        FillListView()

    End Sub

    Private Sub LV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LV.Click
        notaTxt.Text = SCALAR_STRING("SELECT Nota FROM solicitudcreditonota WHERE Id=" & CInt(LV.FocusedItem.Text) & "")
        guardarBtn.Enabled = False
    End Sub

    Private Sub cerrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cerrarBtn.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        guardarBtn.Enabled = True
        notaTxt.Text = ""
    End Sub
End Class
