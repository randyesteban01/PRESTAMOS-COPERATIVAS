Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class FRM_LOGIN
    Inherits System.Windows.Forms.Form
    Dim daUsers As MySqlDataAdapter
    Dim dsUsers As New DataSet
     '/INI FILE
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
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents fld_departamento As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_LOGIN))
        Me.txtUserID = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.fld_departamento = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'txtUserID
        '
        Me.txtUserID.BackColor = System.Drawing.Color.White
        Me.txtUserID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserID.Location = New System.Drawing.Point(272, 40)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(192, 20)
        Me.txtUserID.TabIndex = 1
        Me.txtUserID.Text = ""
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.Location = New System.Drawing.Point(272, 64)
        Me.txtPassword.MaxLength = 15
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(192, 20)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Text = ""
        '
        'fld_departamento
        '
        Me.fld_departamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.fld_departamento.Location = New System.Drawing.Point(296, 344)
        Me.fld_departamento.Name = "fld_departamento"
        Me.fld_departamento.Size = New System.Drawing.Size(72, 32)
        Me.fld_departamento.TabIndex = 0
        Me.fld_departamento.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(216, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Usuario:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(216, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Clave:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(256, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 58)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "&Entrar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(384, 144)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 58)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "&Cerrar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(456, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 180)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'FRM_LOGIN
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(480, 216)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fld_departamento)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_LOGIN"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim count = 0


    '' prueba de lectura y escritura de archivo .ini
    Public Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

    Public Function saveINIkey(file As String, section As String, key As String, value As String) As Boolean

        Dim lret As Long, ret As String = ""

        lret = WritePrivateProfileString(section.Trim, key.Trim, value.Trim, file.Trim)
        ret = lret.ToString().Trim().ToLower

        If ret = "0" Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub EjecutarBat(ByVal pathArchivoBat As String)
        Dim proceso As Process = New Process()
        proceso.StartInfo.FileName = pathArchivoBat
        proceso.Start()
        proceso.WaitForExit()
    End Sub

    Private Sub VerificarVersionSistema()
        Try

            Dim strVersionServidor As String = String.Empty
            Dim strVersionLocal As String = String.Empty
            Dim strUrlSistemaServidorCentral As String = String.Empty

            strVersionServidor = SCALAR_STRING("SELECT VersionPublicacionSistema FROM parametrosgenerales WHERE ID=1")
            strVersionLocal = objIniFile.GetString("VERSION", "Publicacion", "(none)")

            If strVersionLocal <> strVersionServidor Then

                MsgBox("Se ha detectado una nueva versión de software en el servidor central, se procederá con la actualización", MsgBoxStyle.Information)

                If saveINIkey(AppPath & "\Settings.ini", "VERSION", "Publicacion", strVersionServidor) = True Then
                    MsgBox("Versión Actualizada.", MsgBoxStyle.Information)
                Else
                    MsgBox("Error en Actualización.", MsgBoxStyle.Critical)
                End If

                EjecutarBat(AppPath & "\DashaCooperativa.bat")

            End If

        Catch ex As Exception
            MsgBox("Error en Actualización, Se podrá trabajar con la versión actual del sistema", MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub FRM_LOGIN_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        VerificarVersionSistema()

        Me.Label3.Text = objIniFile.GetString("COMPANY", "Name", "(none)")
        System.Windows.Forms.Application.EnableVisualStyles()
        Me.Icon = appIcon
    End Sub

    Private Sub FRM_LOGIN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            End
        End If
    End Sub
    

    Private Sub ValidatedUser()

        If txtUserID.Text = "" Then

            txtUserID.Focus()
            Alerta("Aun no ha escrito el nombre de Usuario")
            Exit Sub

        ElseIf txtPassword.Text = "" Then

            txtPassword.Focus()
            Alerta("Aun no ha escrito la clave")
            Exit Sub

        End If

        daUsers = New MySqlDataAdapter("SELECT * FROM tbl_User", conn)
        daUsers.Fill(dsUsers, "tbl_User")
        Dim dr As DataRow

        With dsUsers.Tables("tbl_User")

            .PrimaryKey = New DataColumn() {.Columns("fld_UserID")}

        End With

        dr = dsUsers.Tables("tbl_User").Rows.Find(txtUserID.Text)

        If Not (dr Is Nothing) Then

            If dr("fld_Status".ToString) <> "N" Then
                txtPassword.Text = ""
                txtUserID.Text = ""
                txtUserID.Focus()
                Alerta("Este usuario no está activo en el sistema")
                Exit Sub
            End If

            If txtPassword.Text = dr("fld_Password".ToString) Then
                User(0) = dr("fld_UserID")
                User(1) = dr("fld_cargo")
                User(2) = dr("fld_FirstName") & " " & dr("fld_LastName")
                User(3) = txtPassword.Text
                User(4) = dr("fld_tipo")
                User(5) = dr("fld_id")

                count = 0
                daUsers.Dispose()
                dsUsers.Dispose()
                dr = Nothing
                Me.Text = "ACEPTAR"
                Me.Close()
            Else
                txtPassword.Text = ""
                txtUserID.Focus()
                txtUserID.Text = ""
                Alerta("El usuario o la clave es incorrecta, trate de nuevo")
            End If
        Else
            txtPassword.Text = ""
            txtUserID.Focus()
            txtUserID.Text = ""
            Alerta("El usuario o la clave es incorrecta, trate de nuevo")
        End If
        If count = 3 Then
            Alerta("Ha realizado varios intentos, por favor trate luego.")
            End
        End If
        count = count + 1


    End Sub

    Private Sub txtUserID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserID.KeyPress
        If e.KeyChar = Chr(13) Then
            If Trim(txtUserID.Text) <> "" Then
                txtPassword.Focus()
            End If
        End If
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            If Trim(txtPassword.Text) <> "" Then
                ValidatedUser()
            End If
        End If
    End Sub

    Private Sub fld_departamento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_departamento.KeyPress
        If e.KeyChar = Chr(13) Then
            txtUserID.Focus()
        End If
    End Sub

    Private Sub fld_departamento_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fld_departamento.TextChanged
        Dim boxIndex As Integer, lExst As Boolean
        Dim box As ComboBox = sender
        Dim txt As String = box.Text
        Dim posCursor As Integer = box.SelectionStart

        ' If Cursor does not stay on the beginning of text box.
        If posCursor <> 0 Then
            lExst = False
            ' Go in cycle through the combo box list to find the appropriate entry in the list
            For boxIndex = 0 To box.Items.Count - 1
                If UCase(Mid(box.Items(boxIndex), 1, posCursor)) = _
                   UCase(Mid(txt, 1, posCursor)) Then
                    box.Text = box.Items(boxIndex)
                    box.SelectionStart = posCursor
                    lExst = True
                    Exit For
                End If
            Next
            ' We didn't find appropriate entry and return previous value to text box
            If Not lExst Then
                'box.Text = Mid(txt, 1, posCursor - 1) + Mid(txt, posCursor + 1)
                'box.SelectionStart = posCursor - 1
            End If
        End If

    End Sub

    

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

   
  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ValidatedUser()
    End Sub

    Private Sub FRM_LOGIN_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed

    End Sub
End Class
