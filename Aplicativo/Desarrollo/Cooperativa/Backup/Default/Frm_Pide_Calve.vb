Public Class Frm_Pide_Calve
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
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents fld_clave As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_Pide_Calve))
        Me.fld_clave = New System.Windows.Forms.TextBox
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'fld_clave
        '
        Me.fld_clave.BackColor = System.Drawing.Color.White
        Me.fld_clave.Location = New System.Drawing.Point(10, 24)
        Me.fld_clave.Name = "fld_clave"
        Me.fld_clave.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.fld_clave.Size = New System.Drawing.Size(272, 20)
        Me.fld_clave.TabIndex = 0
        Me.fld_clave.Text = ""
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_Aceptar.Image = CType(resources.GetObject("btn_Aceptar.Image"), System.Drawing.Image)
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Aceptar.Location = New System.Drawing.Point(10, 48)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(72, 56)
        Me.btn_Aceptar.TabIndex = 1
        Me.btn_Aceptar.Text = "&Aceptar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_Cancelar.Image = CType(resources.GetObject("btn_Cancelar.Image"), System.Drawing.Image)
        Me.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Cancelar.Location = New System.Drawing.Point(82, 48)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(72, 56)
        Me.btn_Cancelar.TabIndex = 2
        Me.btn_Cancelar.Text = "&Cerrar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Introduzca la clave de autorización"
        '
        'Frm_Pide_Calve
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(292, 107)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.fld_clave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Pide_Calve"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Permiso"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Frm_Pide_Calve_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
    End Sub

    Private Sub fld_clave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_clave.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.Text = "Borrar" Then
                If fld_clave.Text = borrar_clave Then
                    Me.Text = "ACEPTAR"
                    Me.Close()
                Else
                    Alerta("Clave incorrecta trate de nuevo")
                    'Me.Text = "CANCELAR"
                End If
            Else
                If fld_clave.Text = admin_clave Then
                    Me.Text = "ACEPTAR"
                    Me.Close()
                Else
                    Alerta("Clave incorrecta trate de nuevo")
                    'Me.Text = "CANCELAR"
                End If
            End If

        End If
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        If Me.Text = "Borrar" Then
            If fld_clave.Text = borrar_clave Then
                Me.Text = "ACEPTAR"
                Me.Close()
            Else
                Alerta("Clave incorrecta trate de nuevo")
                'Me.Text = "CANCELAR"
            End If
        Else
            If fld_clave.Text = admin_clave Then
                Me.Text = "ACEPTAR"
                Me.Close()
            Else
                Alerta("Clave incorrecta trate de nuevo")
                'Me.Text = "CANCELAR"
            End If
        End If

    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Me.Text = "CANCELAR"
        Me.Close()
    End Sub

    Private Sub Frm_Pide_Calve_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Text = "CANCELAR"
            Me.Close()
        End If
    End Sub
End Class
