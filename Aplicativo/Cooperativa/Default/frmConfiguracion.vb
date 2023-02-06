Public Class frmConfiguracion
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
    Friend WithEvents disponibilidadTxt As System.Windows.Forms.TextBox
    Friend WithEvents cbVistaPrevia As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoImpresoraRI As System.Windows.Forms.ComboBox
    Friend WithEvents txtDiasGracias As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tasaTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As Label
    Friend WithEvents fld_Pignorar As TextBox
    Friend WithEvents moraTxt As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfiguracion))
        Me.disponibilidadTxt = New System.Windows.Forms.TextBox()
        Me.cbVistaPrevia = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbTipoImpresoraRI = New System.Windows.Forms.ComboBox()
        Me.txtDiasGracias = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tasaTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.moraTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.fld_Pignorar = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'disponibilidadTxt
        '
        Me.disponibilidadTxt.Location = New System.Drawing.Point(16, 88)
        Me.disponibilidadTxt.MaxLength = 4
        Me.disponibilidadTxt.Name = "disponibilidadTxt"
        Me.disponibilidadTxt.Size = New System.Drawing.Size(40, 20)
        Me.disponibilidadTxt.TabIndex = 109
        Me.disponibilidadTxt.Text = "0.00"
        Me.disponibilidadTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbVistaPrevia
        '
        Me.cbVistaPrevia.Location = New System.Drawing.Point(12, 140)
        Me.cbVistaPrevia.Name = "cbVistaPrevia"
        Me.cbVistaPrevia.Size = New System.Drawing.Size(152, 24)
        Me.cbVistaPrevia.TabIndex = 108
        Me.cbVistaPrevia.Text = "Vista previa de impresión en caja"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(72, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 32)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "la suma de los ahorros más los aportes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(195, 13)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "Disponibilidad para préstamos (Pignorar)"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(216, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 16)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Formato para Impresora"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbTipoImpresoraRI
        '
        Me.cmbTipoImpresoraRI.Items.AddRange(New Object() {"Normal", "Ticket"})
        Me.cmbTipoImpresoraRI.Location = New System.Drawing.Point(216, 40)
        Me.cmbTipoImpresoraRI.Name = "cmbTipoImpresoraRI"
        Me.cmbTipoImpresoraRI.Size = New System.Drawing.Size(123, 21)
        Me.cmbTipoImpresoraRI.TabIndex = 104
        Me.cmbTipoImpresoraRI.Text = "Normal"
        '
        'txtDiasGracias
        '
        Me.txtDiasGracias.BackColor = System.Drawing.Color.White
        Me.txtDiasGracias.Location = New System.Drawing.Point(16, 40)
        Me.txtDiasGracias.Name = "txtDiasGracias"
        Me.txtDiasGracias.Size = New System.Drawing.Size(40, 20)
        Me.txtDiasGracias.TabIndex = 101
        Me.txtDiasGracias.Text = "0"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(56, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 16)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "días de vencida la cuota"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 16)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Empezar a cobrar la mora despues de:"
        '
        'tasaTxt
        '
        Me.tasaTxt.Location = New System.Drawing.Point(374, 88)
        Me.tasaTxt.Name = "tasaTxt"
        Me.tasaTxt.Size = New System.Drawing.Size(100, 20)
        Me.tasaTxt.TabIndex = 110
        Me.tasaTxt.Text = "0.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(357, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 13)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "% Pignorar Cta. Aportacion"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Visible = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrar.Location = New System.Drawing.Point(418, 128)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 56)
        Me.btnCerrar.TabIndex = 113
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(346, 128)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(72, 56)
        Me.btnGuardar.TabIndex = 112
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(216, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "Tasa de Mora sugerida"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'moraTxt
        '
        Me.moraTxt.Location = New System.Drawing.Point(216, 88)
        Me.moraTxt.Name = "moraTxt"
        Me.moraTxt.Size = New System.Drawing.Size(100, 20)
        Me.moraTxt.TabIndex = 114
        Me.moraTxt.Text = "0.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(371, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 13)
        Me.Label8.TabIndex = 117
        Me.Label8.Text = "Tasa de interes sugerida"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fld_Pignorar
        '
        Me.fld_Pignorar.Location = New System.Drawing.Point(374, 41)
        Me.fld_Pignorar.Name = "fld_Pignorar"
        Me.fld_Pignorar.Size = New System.Drawing.Size(100, 20)
        Me.fld_Pignorar.TabIndex = 116
        Me.fld_Pignorar.Text = "0.00"
        Me.fld_Pignorar.Visible = False
        '
        'frmConfiguracion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(495, 196)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.fld_Pignorar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.moraTxt)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tasaTxt)
        Me.Controls.Add(Me.disponibilidadTxt)
        Me.Controls.Add(Me.cbVistaPrevia)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbTipoImpresoraRI)
        Me.Controls.Add(Me.txtDiasGracias)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfiguracion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuraciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmConfiguracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        cargarDatos()
    End Sub

    Private Sub cargarDatos()

        cbVistaPrevia.Checked = CBool(SCALAR_NUM("SELECT VistaPreviaImpresion FROM parametrosgenerales WHERE ID=1"))

        disponibilidadTxt.Text = SCALAR_NUM("SELECT DispPignorada FROM parametrosgenerales WHERE ID=1")

        txtDiasGracias.Text = SCALAR_NUM("SELECT DiasGracias FROM parametrosgenerales WHERE ID=1")

        tasaTxt.Text = SCALAR_NUM("SELECT TasaInteres FROM parametrosgenerales WHERE ID=1")

        moraTxt.Text = SCALAR_NUM("SELECT Mora FROM parametrosgenerales WHERE ID=1")

        cmbTipoImpresoraRI.Text = SCALAR_STRING("SELECT TipoImpresoraRI FROM parametrosgenerales WHERE ID=1")

    End Sub

    Private Sub guardarDatos()

        If txtDiasGracias.Text = String.Empty Then
            txtDiasGracias.Text = 0
        End If

        If tasaTxt.Text = String.Empty Then
            tasaTxt.Text = 0
        End If

        NON_QUERY("UPDATE parametrosgenerales SET DispPignorada=" & CDec(disponibilidadTxt.Text) & ", VistaPreviaImpresion=" & CInt(cbVistaPrevia.Checked) * -1 & ", DiasGracias=" & txtDiasGracias.Text & ", TasaInteres=" & CDbl(tasaTxt.Text) & ", TipoImpresoraRI='" & cmbTipoImpresoraRI.Text & "', Mora=" & CDec(moraTxt.Text) & " WHERE ID=1")

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        guardarDatos()
        Alerta("Documento guardado")
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
