Public Class FRM_POPUP_FECHAS
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
    Friend WithEvents DateTime2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTime1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_POPUP_FECHAS))
        Me.DateTime2 = New System.Windows.Forms.DateTimePicker
        Me.DateTime1 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'DateTime2
        '
        Me.DateTime2.CustomFormat = "yyyy-MMMM-dd"
        Me.DateTime2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTime2.Location = New System.Drawing.Point(328, 24)
        Me.DateTime2.Name = "DateTime2"
        Me.DateTime2.Size = New System.Drawing.Size(136, 20)
        Me.DateTime2.TabIndex = 3
        '
        'DateTime1
        '
        Me.DateTime1.CustomFormat = "yyyy-MMMM-dd"
        Me.DateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTime1.Location = New System.Drawing.Point(96, 24)
        Me.DateTime1.Name = "DateTime1"
        Me.DateTime1.Size = New System.Drawing.Size(136, 20)
        Me.DateTime1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Desde fecha..:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(248, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Hasta fecha..:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrar.Location = New System.Drawing.Point(384, 56)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(80, 72)
        Me.btnCerrar.TabIndex = 13
        Me.btnCerrar.TabStop = False
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(152, 56)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(80, 72)
        Me.btnNuevo.TabIndex = 12
        Me.btnNuevo.TabStop = False
        Me.btnNuevo.Text = "&Aceptar"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'FRM_POPUP_FECHAS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(474, 139)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTime2)
        Me.Controls.Add(Me.DateTime1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_POPUP_FECHAS"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rango de Fechas"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FRM_POPUP_FECHAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        DateTime1.Value = PrimerDiaDelMes(DateTime1.Value.Date)
        DateTime2.Value = UltimoDiaDelMes(DateTime2.Value.Date)
        'Me.BackColor = Color.FromArgb(colorr(0), colorr(1), colorr(2))
    End Sub

    Private Sub FRM_POPUP_FECHAS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        ElseIf e.KeyChar = Chr(13) Then
            SetDates()
        End If
    End Sub


    '/SUB PROGRAMAS
    Private Sub SetDates()
        If DateTime1.Value > DateTime2.Value Then
            Help.ShowPopup(DateTime1, "La primera fecha debe ser menor a la segunda", New Point(550, 375))
            Exit Sub
        End If
        fecha1 = formatDate(DateTime1.Value)
        fecha2 = formatDate(DateTime2.Value)
        fecha_rango = RANGO_FECHA_LETRA(DateTime1.Value, DateTime2.Value)
        Me.Text = "ACEPTAR"
        Me.Close()
    End Sub

    '/BOTONES
     
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        SetDates()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
