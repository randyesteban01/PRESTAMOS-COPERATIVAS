Imports MySql.Data.MySqlClient
Public Class FRM_CAMBIAR_CLAVE
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
    Friend WithEvents fld_clave_actual As System.Windows.Forms.TextBox
    Friend WithEvents fld_clave_nueva As System.Windows.Forms.TextBox
    Friend WithEvents fld_confirmar_clave As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_CAMBIAR_CLAVE))
        Me.fld_clave_actual = New System.Windows.Forms.TextBox
        Me.fld_clave_nueva = New System.Windows.Forms.TextBox
        Me.fld_confirmar_clave = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'fld_clave_actual
        '
        Me.fld_clave_actual.Location = New System.Drawing.Point(72, 16)
        Me.fld_clave_actual.MaxLength = 20
        Me.fld_clave_actual.Name = "fld_clave_actual"
        Me.fld_clave_actual.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.fld_clave_actual.Size = New System.Drawing.Size(144, 20)
        Me.fld_clave_actual.TabIndex = 0
        Me.fld_clave_actual.Text = ""
        '
        'fld_clave_nueva
        '
        Me.fld_clave_nueva.Location = New System.Drawing.Point(72, 56)
        Me.fld_clave_nueva.MaxLength = 20
        Me.fld_clave_nueva.Name = "fld_clave_nueva"
        Me.fld_clave_nueva.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.fld_clave_nueva.Size = New System.Drawing.Size(144, 20)
        Me.fld_clave_nueva.TabIndex = 1
        Me.fld_clave_nueva.Text = ""
        '
        'fld_confirmar_clave
        '
        Me.fld_confirmar_clave.Location = New System.Drawing.Point(72, 80)
        Me.fld_confirmar_clave.MaxLength = 20
        Me.fld_confirmar_clave.Name = "fld_confirmar_clave"
        Me.fld_confirmar_clave.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.fld_confirmar_clave.Size = New System.Drawing.Size(144, 20)
        Me.fld_confirmar_clave.TabIndex = 2
        Me.fld_confirmar_clave.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(-16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Clave Actual"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(-16, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nueva Clave"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(-16, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Confirmar"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(72, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 56)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "&Cambiar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(144, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 56)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "C&ancelar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'FRM_CAMBIAR_CLAVE
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(226, 179)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.fld_confirmar_clave)
        Me.Controls.Add(Me.fld_clave_nueva)
        Me.Controls.Add(Me.fld_clave_actual)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FRM_CAMBIAR_CLAVE"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambiar mi Clave"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FRM_CAMBIAR_CLAVE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
    End Sub
    Private Function ValidatedData() As Boolean
        If Trim(fld_clave_actual.Text) = "" Then
            fld_clave_actual.Focus()
            Alerta("FALTA LA CLAVE ACTUAL")
            Return False
            Exit Function
        ElseIf Trim(fld_clave_nueva.Text) = "" Then
            fld_confirmar_clave.Focus()
            Alerta("FALTA LA NEUVA CLAVE")
            Return False
            Exit Function
        ElseIf Trim(fld_confirmar_clave.Text) = "" Then
            fld_confirmar_clave.Focus()
            Alerta("FALTA CONFIRMAR LA CLAVE")
            Return False
            Exit Function
        ElseIf Trim(fld_clave_nueva.Text) <> Trim(fld_confirmar_clave.Text) Then
            fld_clave_nueva.Text = ""
            fld_confirmar_clave.Text = ""
            fld_clave_nueva.Focus()
            Alerta("LA NUEVA CLAVE NO ES LA MISMA QUE CONFIRMO")
            Return False
            Exit Function

        End If
        Return True
    End Function
    Private Sub set_pass()
        Dim cmd As New MySqlCommand
        With cmd
            .CommandText = "UPDATE tbl_user SET fld_Password='" & fld_clave_nueva.Text & "' WHERE fld_UserID='" & User(0) & "'"
            .Connection = conn
            .Connection.Open()
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd = Nothing
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If User(3) <> fld_clave_actual.Text Then
            Alerta("La Clave actual es erronea")
            Exit Sub
        End If
        If ValidatedData() = True Then
            set_pass()
            Alerta("La clave ha sido cambiada")
            User(3) = fld_clave_nueva.Text
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
