Imports MySql.Data.MySqlClient
Public Class frmSeleccionarCtaDosContable
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
    Friend WithEvents lblDR As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnProcesar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtCtaContableDesde As System.Windows.Forms.TextBox
    Friend WithEvents txtCtaContableHasta As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSeleccionarCtaDosContable))
        Me.txtCtaContableDesde = New System.Windows.Forms.TextBox
        Me.lblDR = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCtaContableHasta = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnProcesar = New System.Windows.Forms.Button
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtCtaContableDesde
        '
        Me.txtCtaContableDesde.Location = New System.Drawing.Point(56, 16)
        Me.txtCtaContableDesde.MaxLength = 11
        Me.txtCtaContableDesde.Name = "txtCtaContableDesde"
        Me.txtCtaContableDesde.Size = New System.Drawing.Size(144, 20)
        Me.txtCtaContableDesde.TabIndex = 0
        Me.txtCtaContableDesde.Text = ""
        '
        'lblDR
        '
        Me.lblDR.BackColor = System.Drawing.SystemColors.Control
        Me.lblDR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDR.ForeColor = System.Drawing.Color.Black
        Me.lblDR.Location = New System.Drawing.Point(200, 18)
        Me.lblDR.Name = "lblDR"
        Me.lblDR.Size = New System.Drawing.Size(264, 16)
        Me.lblDR.TabIndex = 4
        Me.lblDR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(200, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCtaContableHasta
        '
        Me.txtCtaContableHasta.Location = New System.Drawing.Point(56, 40)
        Me.txtCtaContableHasta.MaxLength = 11
        Me.txtCtaContableHasta.Name = "txtCtaContableHasta"
        Me.txtCtaContableHasta.Size = New System.Drawing.Size(144, 20)
        Me.txtCtaContableHasta.TabIndex = 1
        Me.txtCtaContableHasta.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Desde :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Hasta :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnProcesar
        '
        Me.BtnProcesar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnProcesar.ForeColor = System.Drawing.Color.Black
        Me.BtnProcesar.Image = CType(resources.GetObject("BtnProcesar.Image"), System.Drawing.Image)
        Me.BtnProcesar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnProcesar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnProcesar.Location = New System.Drawing.Point(56, 72)
        Me.BtnProcesar.Name = "BtnProcesar"
        Me.BtnProcesar.Size = New System.Drawing.Size(72, 56)
        Me.BtnProcesar.TabIndex = 2
        Me.BtnProcesar.Text = "&Aceptar"
        Me.BtnProcesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnCancelar.ForeColor = System.Drawing.Color.Black
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnCancelar.Location = New System.Drawing.Point(128, 72)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(72, 56)
        Me.BtnCancelar.TabIndex = 3
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmSeleccionarCtaDosContable
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(474, 139)
        Me.Controls.Add(Me.BtnProcesar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCtaContableHasta)
        Me.Controls.Add(Me.lblDR)
        Me.Controls.Add(Me.txtCtaContableDesde)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSeleccionarCtaDosContable"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rango de cuentas contables"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmSeleccionarCtaDosContable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
    End Sub
    Private Sub ListaCuentasContables(ByVal cual As Integer)
        If frmsListaCatalogoCuentaContable() = True Then
            If cual = 1 Then
                txtCtaContableDesde.Text = Id
                lblDR.Text = SCALAR_STRING("SELECT Descripcion FROM tbl_catalogo WHERE CuentaNo='" & Id & "'")
            Else
                txtCtaContableHasta.Text = Id
                Label1.Text = SCALAR_STRING("SELECT Descripcion FROM tbl_catalogo WHERE CuentaNo='" & Id & "'")
            End If



        End If
    End Sub



    Private Sub BtnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProcesar.Click

        If lblDR.Text = String.Empty Then
            Alerta("Por favor seleccione la primera cuenta contable, pulse la tecla F5 para buscar la cuenta")
            Return
        End If
        If Label1.Text = String.Empty Then
            Alerta("Por favor seleccione la segunda cuenta contable, pulse la tecla F5 para buscar la cuenta")
            Return
        End If
        cta_contable_selecionada = txtCtaContableDesde.Text
        cta_contable_selecionada1 = txtCtaContableHasta.Text
        Me.Text = "ACEPTAR"
        Me.Close()
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub


    Private Sub txtCtaContableDesde_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCtaContableDesde.KeyDown
        If e.KeyCode = Keys.F5 Then
            ListaCuentasContables(1)
        End If
    End Sub


    Private Sub txtCtaContableHasta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCtaContableHasta.KeyDown
        If e.KeyCode = Keys.F5 Then
            ListaCuentasContables(2)
        End If
    End Sub

    Private Sub frmSeleccionarCtaDosContable_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class
