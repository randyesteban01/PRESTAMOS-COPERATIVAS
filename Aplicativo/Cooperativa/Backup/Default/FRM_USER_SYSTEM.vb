Imports  MySql.Data.MySqlClient
Public Class FRM_USER_SYSTEM
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
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents cbRol As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LV As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_USER_SYSTEM))
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCargo = New System.Windows.Forms.TextBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtPassword1 = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtUserID = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.cbRol = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.LV = New System.Windows.Forms.ListView
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(272, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Cargo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(272, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Apellidos"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(272, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Nombre"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Clave"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Usuario"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCargo
        '
        Me.txtCargo.BackColor = System.Drawing.Color.White
        Me.txtCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCargo.Location = New System.Drawing.Point(360, 72)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(216, 20)
        Me.txtCargo.TabIndex = 6
        Me.txtCargo.Text = ""
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.White
        Me.txtLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtLastName.Location = New System.Drawing.Point(360, 48)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(216, 20)
        Me.txtLastName.TabIndex = 5
        Me.txtLastName.Text = ""
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.White
        Me.txtFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtFirstName.Location = New System.Drawing.Point(360, 24)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(216, 20)
        Me.txtFirstName.TabIndex = 4
        Me.txtFirstName.Text = ""
        '
        'txtPassword1
        '
        Me.txtPassword1.BackColor = System.Drawing.Color.White
        Me.txtPassword1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtPassword1.Location = New System.Drawing.Point(104, 72)
        Me.txtPassword1.MaxLength = 15
        Me.txtPassword1.Name = "txtPassword1"
        Me.txtPassword1.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword1.Size = New System.Drawing.Size(176, 20)
        Me.txtPassword1.TabIndex = 2
        Me.txtPassword1.Text = ""
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtPassword.Location = New System.Drawing.Point(104, 48)
        Me.txtPassword.MaxLength = 15
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(176, 20)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.Text = ""
        '
        'txtUserID
        '
        Me.txtUserID.BackColor = System.Drawing.Color.White
        Me.txtUserID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtUserID.Location = New System.Drawing.Point(104, 24)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(176, 20)
        Me.txtUserID.TabIndex = 0
        Me.txtUserID.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(-24, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Confirmar clave"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrar.Location = New System.Drawing.Point(504, 104)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 56)
        Me.btnCerrar.TabIndex = 18
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(432, 104)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(72, 56)
        Me.btnGuardar.TabIndex = 15
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(360, 104)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 56)
        Me.btnNuevo.TabIndex = 14
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cbRol
        '
        Me.cbRol.Location = New System.Drawing.Point(104, 104)
        Me.cbRol.Name = "cbRol"
        Me.cbRol.Size = New System.Drawing.Size(121, 21)
        Me.cbRol.TabIndex = 19
        Me.cbRol.Text = "ComboBox1"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(16, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Rol"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LV
        '
        Me.LV.Location = New System.Drawing.Point(8, 176)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(568, 320)
        Me.LV.TabIndex = 21
        '
        'FRM_USER_SYSTEM
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(586, 508)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbRol)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPassword1)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCargo)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_USER_SYSTEM"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Usuarios"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim UserId As Integer
    'PROPETIE'S FORM
    
    Private Sub FRM_USER_SYSTEM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = vbCr Then 'BIGIN /DESABLED THE BEEP
            e.Handled = True
        End If 'END /DESABLED THE BEEP


        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub
   
    'SAVE, UPDATE, LOAD, VALIDATED AND NULL DATA
    Private Sub SaveData()
        NON_QUERY("INSERT INTO tbl_User (fld_UserID,fld_Password,fld_FirstName,fld_LastName,FLD_CARGO,fld_Created,fld_Status,IDRol) VALUES('" & txtUserID.Text & "','" & txtPassword.Text & "','" & txtFirstName.Text & "','" & txtLastName.Text & "','" & txtCargo.Text & "',NOW(),'N'," & cbRol.SelectedValue & ")")
       

    End Sub
    Private Sub UpDateData(ByVal IDUsuario As Integer)
        NON_QUERY("UPDATE tbl_User SET fld_FirstName='" & txtFirstName.Text & "', fld_LastName='" & txtLastName.Text & "', FLD_CARGO='" & txtCargo.Text & "', IdRol=" & cbRol.SelectedValue & " WHERE fld_id=" & IDUsuario & " ")

        
    End Sub
    Private Sub NullData(ByVal IDUsuario As Integer)
        NON_QUERY("UPDATE tbl_User SET fld_Status='B' WHERE fld_id=" & IDUsuario & "")
       
    End Sub
    Private Sub cargarDatos(ByVal id As Integer)
        Dim isdata As Boolean = False

        Dim nr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_User WHERE fld_id=" & id & "", conn)
        da.Fill(ds, "tbl_User")

        For Each nr In ds.Tables(0).Rows
            If nr("fld_Status") = "B" Then
                Alerta("Este usuario de está nulo")
                txtUserID.Text = ""
                GoTo SALTA
            End If
            UserId = nr("fld_Id")
            txtUserID.Text = nr("fld_UserID")
            txtPassword.Text = nr("fld_Password")
            txtPassword1.Text = nr("fld_Password")
            txtFirstName.Text = nr("fld_FirstName")
            txtLastName.Text = nr("fld_LastName")

            txtCargo.Text = nr("FLD_CARGO")
            cbRol.SelectedValue = nr("IdRol")

            btnGuardar.Text = "&Modificar"
            txtUserID.Enabled = False

        Next

SALTA:

        da.Dispose()
        ds.Dispose()
    End Sub
    Private Function ValidatedData() As Boolean
        If Trim(txtUserID.Text) = "" Then
            txtUserID.Focus()
            Alerta("FALTA EL ID DEL USUARIO")
            Return False
            Exit Function
        ElseIf Trim(txtPassword.Text) = "" Then
            txtPassword.Focus()
            Alerta("FALTA LA CLAVE DE ACCESOS")
            Return False
            Exit Function
        ElseIf Trim(txtPassword1.Text) = "" Then
            txtPassword1.Focus()
            Alerta("FALTA CONFIRMAR LA CLAVE DE ACCESOS")
            Return False
            Exit Function
        ElseIf Trim(txtPassword.Text) <> Trim(txtPassword1.Text) Then
            txtPassword.Text = ""
            txtPassword1.Text = ""
            txtPassword.Focus()
            Alerta("LA CLAVE DE ACCESOS NO ES LA MISMA QUE CONFIRMO")
            Return False
            Exit Function
        ElseIf Trim(txtFirstName.Text) = "" Then
            txtFirstName.Focus()
            Alerta("FALTA EL NOMBRE")
            Return False
            Exit Function
        ElseIf Trim(txtLastName.Text) = "" Then
            txtLastName.Focus()
            Alerta("FALTA EL APELLIDO")
            Return False
            Exit Function

        End If
        Return True
    End Function
    Private Function ValidatedUser() As Boolean
        Dim nr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_User", conn)
        da.Fill(ds, "tbl_User")

        For Each nr In ds.Tables(0).Rows
            If nr("fld_UserId") = txtUserID.Text Then
                Return True

            End If
        Next
        Return False
    End Function

    Private Sub FillListView()
        LV.Clear()
        LV.View = View.Details
        LV.LabelEdit = False
        LV.FullRowSelect = True
        LV.GridLines = True
        LV.MultiSelect = False
        LV.Sorting = SortOrder.Ascending

        Dim fldToSearch As String = "u.fld_FirstName"



        Dim strTosearch As String = "'%" & txtFirstName.Text & "%'"
        Dim sqlSearch As String
        Dim accion As Short
        Trim(strTosearch)
        Try


            If strTosearch <> "'%%'" Then
                sqlSearch = "SELECT u.fld_id, u.fld_UserID, CONCAT(u.fld_FirstName,' ',u.fld_LastName), ur.Rol FROM tbl_user AS u INNER JOIN tbl_user_rol AS ur ON u.IDRol=ur.ID WHERE " & fldToSearch & " LIKE " & strTosearch & " "
            Else
                sqlSearch = "SELECT u.fld_id, u.fld_UserID, CONCAT(u.fld_FirstName,' ',u.fld_LastName), ur.Rol FROM tbl_user AS u INNER JOIN tbl_user_rol AS ur ON u.IDRol=ur.ID"
            End If




            Dim ds As New DataSet
            Dim da As New MySqlDataAdapter(sqlSearch, conn)
            da.Fill(ds, "tbl_user")

            Dim columnText(7) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
            columnText(0) = "ID"
            columnText(1) = "Usuario"
            columnText(2) = "Nombre"
            columnText(3) = "Rol"
            columnText(4) = "ABONO"
            columnText(5) = "BALANCE"


            Dim columnWidth(7) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
            columnWidth(0) = 0
            columnWidth(1) = 125
            columnWidth(2) = 230
            columnWidth(3) = 85
            columnWidth(4) = 85
            columnWidth(5) = 85


            Dim columnAlign(7) As Int32 'PARA ALINEAR LOS DATOS
            columnAlign(0) = 0 'IZQUIERDA
            columnAlign(1) = 0 'IZQUIERDA
            columnAlign(2) = 0 'IZQUIERDA
            columnAlign(3) = 0 'IZQUIERDA
            columnAlign(4) = 1 'IZQUIERDA
            columnAlign(5) = 1 'IZQUIERDA

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
                    ElseIf rr(col).GetType().FullName.ToString = "System.Decimal" Then
                        str(col) = Format(rr(col), "C2")
                    ElseIf rr(col).GetType().FullName.ToString = "System.Double" Then
                        str(col) = Format(rr(col), "C2")
                    End If
                Next

                Dim ii As New ListViewItem(str)
                Me.LV.Items.Add(ii)
                'showing the number of records still added
            Next






        Catch ex As Exception
            Alerta(ex.Message)
        End Try








    End Sub


    Private Sub ClearFields()
        txtUserID.Enabled = True
        txtUserID.Text = ""
        txtPassword.Text = ""
        txtPassword1.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtCargo.Text = ""
        btnGuardar.Text = "&Guardar"
        FillListView()
    End Sub

    Private Sub llenarRoles()

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT ID, Rol FROM tbl_user_rol ORDER BY ID", conn)
        da.Fill(dt)

        cbRol.DataSource = dt
        cbRol.DisplayMember = "Rol"
        cbRol.ValueMember = "ID"
        da.Dispose()


    End Sub



    'BUTTOM'S PROPETIES
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If ValidatedData() = False Then Exit Sub

        If btnGuardar.Text = "&Guardar" Then
            If ValidatedUser() = True Then
                Alerta("Este usuario ya exixte en la base de datos")
                Exit Sub
            End If
            If Alerta("¿Seguro que desea guardar?") = True Then
                SaveData()
                ClearFields()
            End If
            Exit Sub
        Else
            If Alerta("¿Seguro que desea actualizar los cambios?") = True Then
                UpDateData(UserId)
                ClearFields()

            End If
        End If
        FillListView()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        ClearFields()
    End Sub

     
    Private Sub FLD_DEPARTAMENTO_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub


    Private Sub FRM_USER_SYSTEM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        llenarRoles()
        FillListView()
    End Sub


    Private Sub cbRol_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbRol.KeyPress
        e.Handled = True
    End Sub


    Private Sub LV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LV.DoubleClick
        cargarDatos(LV.FocusedItem.Text)
    End Sub

    Private Sub txtUserID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserID.TextChanged

    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged

    End Sub
End Class
