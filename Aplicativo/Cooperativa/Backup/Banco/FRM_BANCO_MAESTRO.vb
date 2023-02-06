Imports  MySql.Data.MySqlClient
Public Class FRM_BANCO_MAESTRO
    Inherits System.Windows.Forms.Form
    Dim ISNEWDOC As Boolean = True

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
    Friend WithEvents FLD_CODIGO As System.Windows.Forms.TextBox
    Friend WithEvents FLD_NOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents FLD_DIRECCION As System.Windows.Forms.TextBox
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnCierra As System.Windows.Forms.Button
    Friend WithEvents btnGuarda As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents fld_secuencia_ck As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblCuentaContable As System.Windows.Forms.Label
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaContable As System.Windows.Forms.TextBox
    Friend WithEvents ctaContableBtn As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_BANCO_MAESTRO))
        Me.LV = New System.Windows.Forms.ListView
        Me.FLD_DIRECCION = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCuentaContable = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.FLD_NOMBRE = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.FLD_CODIGO = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.fld_secuencia_ck = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.btnCierra = New System.Windows.Forms.Button
        Me.btnGuarda = New System.Windows.Forms.Button
        Me.lblCuentaContable = New System.Windows.Forms.Label
        Me.txtCuenta = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ctaContableBtn = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.White
        Me.LV.Location = New System.Drawing.Point(8, 104)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(488, 144)
        Me.LV.TabIndex = 13
        '
        'FLD_DIRECCION
        '
        Me.FLD_DIRECCION.BackColor = System.Drawing.Color.White
        Me.FLD_DIRECCION.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FLD_DIRECCION.Location = New System.Drawing.Point(72, 80)
        Me.FLD_DIRECCION.Name = "FLD_DIRECCION"
        Me.FLD_DIRECCION.Size = New System.Drawing.Size(424, 20)
        Me.FLD_DIRECCION.TabIndex = 4
        Me.FLD_DIRECCION.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Direccion"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCuentaContable
        '
        Me.txtCuentaContable.BackColor = System.Drawing.Color.White
        Me.txtCuentaContable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaContable.Location = New System.Drawing.Point(352, 32)
        Me.txtCuentaContable.Name = "txtCuentaContable"
        Me.txtCuentaContable.Size = New System.Drawing.Size(144, 20)
        Me.txtCuentaContable.TabIndex = 2
        Me.txtCuentaContable.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(208, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Cuenta Contable"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FLD_NOMBRE
        '
        Me.FLD_NOMBRE.BackColor = System.Drawing.Color.White
        Me.FLD_NOMBRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FLD_NOMBRE.Location = New System.Drawing.Point(72, 56)
        Me.FLD_NOMBRE.Name = "FLD_NOMBRE"
        Me.FLD_NOMBRE.Size = New System.Drawing.Size(424, 20)
        Me.FLD_NOMBRE.TabIndex = 3
        Me.FLD_NOMBRE.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nombre"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FLD_CODIGO
        '
        Me.FLD_CODIGO.BackColor = System.Drawing.Color.White
        Me.FLD_CODIGO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FLD_CODIGO.Location = New System.Drawing.Point(72, 8)
        Me.FLD_CODIGO.Name = "FLD_CODIGO"
        Me.FLD_CODIGO.Size = New System.Drawing.Size(136, 20)
        Me.FLD_CODIGO.TabIndex = 0
        Me.FLD_CODIGO.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Código"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'fld_secuencia_ck
        '
        Me.fld_secuencia_ck.BackColor = System.Drawing.Color.White
        Me.fld_secuencia_ck.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_secuencia_ck.Location = New System.Drawing.Point(232, 274)
        Me.fld_secuencia_ck.Name = "fld_secuencia_ck"
        Me.fld_secuencia_ck.Size = New System.Drawing.Size(56, 20)
        Me.fld_secuencia_ck.TabIndex = 7
        Me.fld_secuencia_ck.Text = "0000"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(160, 264)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 40)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Escriba la secuencia actual"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageIndex = 0
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(304, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 40)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "&Actualizar secuencia"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(8, 256)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 56)
        Me.btnNuevo.TabIndex = 6
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnCierra
        '
        Me.btnCierra.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCierra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCierra.ForeColor = System.Drawing.Color.Black
        Me.btnCierra.Image = CType(resources.GetObject("btnCierra.Image"), System.Drawing.Image)
        Me.btnCierra.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCierra.Location = New System.Drawing.Point(424, 256)
        Me.btnCierra.Name = "btnCierra"
        Me.btnCierra.Size = New System.Drawing.Size(72, 56)
        Me.btnCierra.TabIndex = 16
        Me.btnCierra.Text = "&Cerrar"
        Me.btnCierra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnGuarda
        '
        Me.btnGuarda.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuarda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuarda.ForeColor = System.Drawing.Color.Black
        Me.btnGuarda.Image = CType(resources.GetObject("btnGuarda.Image"), System.Drawing.Image)
        Me.btnGuarda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuarda.Location = New System.Drawing.Point(80, 256)
        Me.btnGuarda.Name = "btnGuarda"
        Me.btnGuarda.Size = New System.Drawing.Size(72, 56)
        Me.btnGuarda.TabIndex = 5
        Me.btnGuarda.Text = "&Guardar"
        Me.btnGuarda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblCuentaContable
        '
        Me.lblCuentaContable.Location = New System.Drawing.Point(224, 16)
        Me.lblCuentaContable.Name = "lblCuentaContable"
        Me.lblCuentaContable.Size = New System.Drawing.Size(272, 16)
        Me.lblCuentaContable.TabIndex = 14
        Me.lblCuentaContable.Text = "Código"
        Me.lblCuentaContable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCuenta
        '
        Me.txtCuenta.BackColor = System.Drawing.Color.White
        Me.txtCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuenta.Location = New System.Drawing.Point(72, 32)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(136, 20)
        Me.txtCuenta.TabIndex = 1
        Me.txtCuenta.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(-32, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Cuenta No."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ctaContableBtn
        '
        Me.ctaContableBtn.Image = CType(resources.GetObject("ctaContableBtn.Image"), System.Drawing.Image)
        Me.ctaContableBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ctaContableBtn.Location = New System.Drawing.Point(320, 31)
        Me.ctaContableBtn.Name = "ctaContableBtn"
        Me.ctaContableBtn.Size = New System.Drawing.Size(24, 23)
        Me.ctaContableBtn.TabIndex = 18
        Me.ctaContableBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FRM_BANCO_MAESTRO
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(506, 315)
        Me.Controls.Add(Me.ctaContableBtn)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblCuentaContable)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnCierra)
        Me.Controls.Add(Me.btnGuarda)
        Me.Controls.Add(Me.txtCuentaContable)
        Me.Controls.Add(Me.FLD_CODIGO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FLD_DIRECCION)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FLD_NOMBRE)
        Me.Controls.Add(Me.fld_secuencia_ck)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FRM_BANCO_MAESTRO"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maestro de Bancos"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FRM_BANCO_MAESTRO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        FILL_LV()

    End Sub
    Private Sub FRM_BANCO_MAESTRO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CLS_FIELD()

        fld_secuencia_ck.Text = "0000"
        ISNEWDOC = True
        FLD_CODIGO.Text = String.Empty
        FLD_NOMBRE.Text = String.Empty
        txtCuenta.Text = String.Empty
        FLD_DIRECCION.Text = String.Empty
        txtCuentaContable.Text = String.Empty

    End Sub 'CLEAR ALL FIELDS
    Private Sub SAVE()
        If VALIDA_DATOS() = True Then Exit Sub
        If VALIDA_DATA("TBL_BANCOS", "FLD_CUENTA", txtCuenta.Text) = True Then
            Alerta("Ya esta cuenta ha sido creada")
            If Alerta("¿Desea cargar los datos de la cuenta?") = True Then
                LOAD_DATA("FLD_CODIGO", FLD_CODIGO.Text)
            End If
            Exit Sub
        ElseIf VALIDA_DATA("TBL_BANCOS", "FLD_CODIGO", FLD_CODIGO.Text) = True Then
            Alerta("Este código ya está creado ")
            If Alerta("¿Desea cargar los datos de la cuenta?") = True Then
                LOAD_DATA("FLD_CUENTA", txtCuenta.Text)
            End If
            Exit Sub
        End If

        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM TBL_BANCOS", conn)
        da.Fill(ds, "TBL_BANCOS")

        dr = ds.Tables(0).NewRow

        dr("FLD_CODIGO") = FLD_CODIGO.Text
        dr("FLD_NOMBRE") = FLD_NOMBRE.Text
        dr("FLD_CUENTA") = txtCuenta.Text
        dr("FLD_CTA_CONTABLE") = txtCuentaContable.Text
        dr("FLD_DIRECCION") = FLD_DIRECCION.Text
        dr("FLD_SUCURSAL") = "N/A"
        dr("FLD_CONTACTO") = "N/A"
        dr("FLD_BALANCE") = 0
        dr("fld_tt_ck") = "N/A"
        dr("fld_tt_dep") = "N/A"
        dr("fld_tt_nc") = "N/A"
        dr("fld_tt_nd") = "N/A"
        dr("FLD_STATUS") = "N"

        ds.Tables(0).Rows.Add(dr)

        conn.Open()
        Dim cmd As New MySqlCommandBuilder(da)
        da.InsertCommand = cmd.GetInsertCommand
        da.Update(ds, "TBL_BANCOS")
        ds.AcceptChanges()
        conn.Close()

        ds.Dispose()
        da.Dispose()
        SAVE_SECUENCIA()
    End Sub 'SAVE DATA IN TO DATA BASE "TBL_BANCO"
    Private Sub SAVE_SECUENCIA()
        NON_QUERY("INSERT INTO tbl_cod_ck (fld_cuenta_no,fld_ck_no) VALUES('" & txtCuenta.Text & "'," & fld_secuencia_ck.Text & ")")

    End Sub 'SAVE DATA INTO "TBL_COD_CK"
    Private Sub MODIFY(ByVal Ids)
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM TBL_BANCOS WHERE FLD_CODIGO='" & Ids & "'", conn)
        da.Fill(ds, "TBL_BANCOS")
        For Each dr In ds.Tables(0).Rows
            dr("FLD_CODIGO") = FLD_CODIGO.Text
            dr("FLD_NOMBRE") = FLD_NOMBRE.Text
            dr("FLD_CUENTA") = txtCuenta.Text
            dr("fld_cta_contable") = txtCuentaContable.Text
            dr("FLD_DIRECCION") = FLD_DIRECCION.Text
            
            GoTo exite
        Next
        ds.Dispose()
        da.Dispose()
        Exit Sub
exite:

        conn.Open()
        Dim cmd As New MySqlCommandBuilder(da)

        da.UpdateCommand = cmd.GetUpdateCommand
        da.Update(ds, "TBL_BANCOS")
        ds.AcceptChanges()
        conn.Close()

        ds.Dispose()
        da.Dispose()
    End Sub ' MODIFY DATA IN TO DATA BASE "TBL_BANCO"
    
    Private Sub LOAD_DATA(ByVal Campo As String, ByVal Valor As String)
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM TBL_BANCOS WHERE " & Campo & "='" & Valor & "'", conn)
        da.Fill(ds, "TBL_BANCOS")
        For Each dr In ds.Tables(0).Rows
            FLD_CODIGO.Text = dr("FLD_CODIGO")
            FLD_NOMBRE.Text = dr("FLD_NOMBRE")
            txtCuenta.Text = dr("FLD_CUENTA")
            txtCuentaContable.Text = dr("fld_cta_contable")
            FLD_DIRECCION.Text = dr("FLD_DIRECCION")
            

             

            ISNEWDOC = False
            GoTo exite
        Next
        Alerta("El documento no existe")

        ds.Dispose()
        da.Dispose()
        Exit Sub
exite:
        lblCuentaContable.Text = ReturnDescripcion(txtCuentaContable.Text)
        LOAD_SECUENCIA(txtCuenta.Text)
        ds.Dispose()
        da.Dispose()
    End Sub ' LOAD DATA FROM DATA BASE "TBL_BANCO"
    Private Sub LOAD_SECUENCIA(ByVal valor As String)

        Dim cmd As New MySqlCommand
        With cmd
            .CommandText = "SELECT IFNULL(fld_ck_no,0) FROM tbl_cod_ck WHERE fld_cuenta_no='" & valor & "'"
            .Connection = conn
            .Connection.Open()
            fld_secuencia_ck.Text = .ExecuteScalar
            .Connection.Close()
        End With
        cmd.Dispose()

    End Sub ' LOAD DATA FROM DATA BASE "TBL_COD_CK"
    Private Sub FILL_LV()
        LV.Clear()
        LV.View = View.Details
        LV.LabelEdit = False
        LV.FullRowSelect = True
        LV.GridLines = True
        LV.Sorting = SortOrder.Ascending

        'Dim fldToSearch As String = "fld_Description" ' = cboSearch.Text
        'Dim strTosearch As String = "'" & txtdescription.Text & "%'"
        Dim sqlSearch As String
        Dim accion As Short

        'Select Case cboSearch.Text
        'Case "Nombre"
        'fldToSearch = "fld_Company"
        'Case "Direccion"
        'fldToSearch = "fld_Address"
        'End Select


        sqlSearch = "SELECT FLD_CODIGO, FLD_NOMBRE, FLD_CUENTA, FLD_BALANCE FROM TBL_BANCOS WHERE FLD_STATUS='N'"

        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        ds.Reset()
        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, "TBL_BANCOS")


        Dim columnText(4) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "CODIGO"
        columnText(1) = "NOMBRE"
        columnText(2) = "CTA. NO"
        columnText(3) = "BALANCE"


        Dim columnWidth(4) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 50
        columnWidth(1) = 250
        columnWidth(2) = 105
        columnWidth(3) = 80


        Dim columnAlign(4) As Int32 'PARA ALINEAR LOS DATOS
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 0
        columnAlign(3) = 1

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
                If rr(col).GetType().FullName.ToString = "System.UInt32" Then
                    str(col) = Format(rr(col), "000")
                ElseIf rr(col).GetType().FullName.ToString = "System.Int32" Then
                    str(col) = Format(rr(col), "000")
                ElseIf rr(col).GetType().FullName.ToString = "System.DateTime" Then
                    str(col) = Format(rr(col), "d")
                ElseIf rr(col).GetType().FullName.ToString = "System.String" Then
                    str(col) = rr(col).ToString()
                ElseIf rr(col).GetType().FullName.ToString = "System.Double" Then
                    str(col) = Format(rr(col), "C2")
                End If
            Next

            Dim ii As New ListViewItem(str)
            Me.LV.Items.Add(ii)
            'showing the number of records still added
        Next


    End Sub 'FILL LV WHIT DATA FROM DATA BASE "TBL_BANCO"
    Private Function VALIDA_DATOS() As Boolean
        If Trim(FLD_CODIGO.Text) = "" Then
            Alerta("Escriba un código para la cuenta")
            FLD_CODIGO.Focus()
            Return True
        ElseIf Trim(FLD_NOMBRE.Text) = "" Then
            Alerta("Escriba un nombre de la cuenta")
            FLD_NOMBRE.Focus()
            Return True
        ElseIf Trim(txtCuenta.Text) = "" Then
            Alerta("Seleccione una cuenta contable")
            txtCuenta.Focus()
            Return True
        ElseIf Trim(FLD_DIRECCION.Text) = "" Then
            Alerta("Escriba una dirección")
            FLD_DIRECCION.Focus()
            Return True

        End If
        Return False
    End Function
  
   
  
    Private Sub LV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LV.DoubleClick
        LOAD_DATA("FLD_CODIGO", LV.FocusedItem.Text)
    End Sub

    Private Sub LV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LV.KeyDown
        If e.KeyCode = Keys.Enter Then
            LOAD_DATA("FLD_CODIGO", LV.FocusedItem.Text)
        End If
    End Sub

   

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        CLS_FIELD()
    End Sub

    Private Sub btnGuarda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuarda.Click
        If ISNEWDOC = False Then
            If FRMS_CLAVE_MAESTRA("Acceso") = False Then Exit Sub
            MODIFY(FLD_CODIGO.Text) 'DEBE PEDIR CLAVE
        Else
            SAVE()
        End If

        FILL_LV()
        CLS_FIELD()
    End Sub

    Private Sub btnCierra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCierra.Click
        Me.Close()
    End Sub


    Private Sub fld_secuencia_ck_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_secuencia_ck.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If SCALAR_NUM("SELECT IFNULL(COUNT(*),0) FROM tbl_cod_ck WHERE fld_cuenta_no='" & txtCuenta.Text & "'") > 0 Then
            'TIENE UNA SECUENCIA, ACTULIZAR ENTONCES
            NON_QUERY("UPDATE tbl_cod_ck SET  fld_ck_no =" & fld_secuencia_ck.Text & " WHERE fld_cuenta_no='" & txtCuenta.Text & "'")
        Else
            NON_QUERY("INSERT INTO tbl_cod_ck SET  fld_ck_no =" & fld_secuencia_ck.Text & ", fld_cuenta_no='" & txtCuenta.Text & "'")
        End If

    End Sub


    
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtCuentaContable_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuentaContable.TextChanged

    End Sub

    Private Sub txtCuentaContable_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuentaContable.KeyDown
        If e.KeyCode = Keys.F5 Then
            If frmsListaCatalogoCuentaContable() = True Then
                txtCuentaContable.Text = Id
                lblCuentaContable.Text = ReturnDescripcion(Id)
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctaContableBtn.Click
        If frmsListaCatalogoCuentaContable() = True Then
            txtCuentaContable.Text = Id
            lblCuentaContable.Text = ReturnDescripcion(Id)
        End If
    End Sub
End Class
