<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActualiarLibrera
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmActualiarLibrera))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DgvLibreta = New System.Windows.Forms.DataGridView()
        Me.TxtNroCuenta = New System.Windows.Forms.TextBox()
        Me.DtFecha = New System.Windows.Forms.DateTimePicker()
        Me.RbtRetiro = New System.Windows.Forms.RadioButton()
        Me.RbtDeposito = New System.Windows.Forms.RadioButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TxtCod_Impresion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtFecha_Impresion = New System.Windows.Forms.TextBox()
        Me.TxtHora_Impresion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCodSocio = New System.Windows.Forms.TextBox()
        Me.TxtNroLibreta = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnImprime = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.TxtSocio = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DgvLibreta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(755, 261)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TxtSocio)
        Me.Panel3.Controls.Add(Me.DateTimePicker1)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.ComboBox1)
        Me.Panel3.Controls.Add(Me.BtnBuscar)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.DgvLibreta)
        Me.Panel3.Controls.Add(Me.TxtNroCuenta)
        Me.Panel3.Controls.Add(Me.DtFecha)
        Me.Panel3.Controls.Add(Me.RbtRetiro)
        Me.Panel3.Controls.Add(Me.RbtDeposito)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.TxtCodSocio)
        Me.Panel3.Controls.Add(Me.TxtNroLibreta)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(755, 193)
        Me.Panel3.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(71, 94)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Hasta"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(59, 143)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 13
        Me.ComboBox1.Visible = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.BtnBuscar.ForeColor = System.Drawing.Color.Black
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBuscar.Location = New System.Drawing.Point(126, 34)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(45, 31)
        Me.BtnBuscar.TabIndex = 12
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(-7, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Nro. Cuenta"
        Me.Label7.Visible = False
        '
        'DgvLibreta
        '
        Me.DgvLibreta.AllowUserToAddRows = False
        Me.DgvLibreta.AllowUserToDeleteRows = False
        Me.DgvLibreta.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DgvLibreta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvLibreta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DgvLibreta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvLibreta.ColumnHeadersVisible = False
        Me.DgvLibreta.Location = New System.Drawing.Point(181, 10)
        Me.DgvLibreta.Name = "DgvLibreta"
        Me.DgvLibreta.ReadOnly = True
        Me.DgvLibreta.Size = New System.Drawing.Size(571, 150)
        Me.DgvLibreta.TabIndex = 8
        '
        'TxtNroCuenta
        '
        Me.TxtNroCuenta.Location = New System.Drawing.Point(59, 123)
        Me.TxtNroCuenta.Name = "TxtNroCuenta"
        Me.TxtNroCuenta.Size = New System.Drawing.Size(100, 20)
        Me.TxtNroCuenta.TabIndex = 10
        Me.TxtNroCuenta.Text = "0"
        Me.TxtNroCuenta.Visible = False
        '
        'DtFecha
        '
        Me.DtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFecha.Location = New System.Drawing.Point(71, 68)
        Me.DtFecha.Name = "DtFecha"
        Me.DtFecha.Size = New System.Drawing.Size(100, 20)
        Me.DtFecha.TabIndex = 9
        '
        'RbtRetiro
        '
        Me.RbtRetiro.AutoSize = True
        Me.RbtRetiro.Location = New System.Drawing.Point(86, 166)
        Me.RbtRetiro.Name = "RbtRetiro"
        Me.RbtRetiro.Size = New System.Drawing.Size(53, 17)
        Me.RbtRetiro.TabIndex = 7
        Me.RbtRetiro.Text = "Retiro"
        Me.RbtRetiro.UseVisualStyleBackColor = True
        '
        'RbtDeposito
        '
        Me.RbtDeposito.AutoSize = True
        Me.RbtDeposito.Checked = True
        Me.RbtDeposito.Location = New System.Drawing.Point(13, 165)
        Me.RbtDeposito.Name = "RbtDeposito"
        Me.RbtDeposito.Size = New System.Drawing.Size(67, 17)
        Me.RbtDeposito.TabIndex = 7
        Me.RbtDeposito.TabStop = True
        Me.RbtDeposito.Text = "Deposito"
        Me.RbtDeposito.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.TxtCod_Impresion)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.TxtFecha_Impresion)
        Me.Panel4.Controls.Add(Me.TxtHora_Impresion)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(723, 64)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(259, 100)
        Me.Panel4.TabIndex = 6
        Me.Panel4.Visible = False
        '
        'TxtCod_Impresion
        '
        Me.TxtCod_Impresion.Location = New System.Drawing.Point(124, 15)
        Me.TxtCod_Impresion.Name = "TxtCod_Impresion"
        Me.TxtCod_Impresion.Size = New System.Drawing.Size(44, 20)
        Me.TxtCod_Impresion.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Fecha Impresion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cod. Impresion"
        '
        'TxtFecha_Impresion
        '
        Me.TxtFecha_Impresion.Location = New System.Drawing.Point(106, 41)
        Me.TxtFecha_Impresion.Name = "TxtFecha_Impresion"
        Me.TxtFecha_Impresion.Size = New System.Drawing.Size(77, 20)
        Me.TxtFecha_Impresion.TabIndex = 4
        '
        'TxtHora_Impresion
        '
        Me.TxtHora_Impresion.Location = New System.Drawing.Point(124, 75)
        Me.TxtHora_Impresion.Name = "TxtHora_Impresion"
        Me.TxtHora_Impresion.Size = New System.Drawing.Size(44, 20)
        Me.TxtHora_Impresion.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Hora Impresion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cod. Socio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nro. Libreta"
        '
        'TxtCodSocio
        '
        Me.TxtCodSocio.Location = New System.Drawing.Point(71, 38)
        Me.TxtCodSocio.Name = "TxtCodSocio"
        Me.TxtCodSocio.Size = New System.Drawing.Size(49, 20)
        Me.TxtCodSocio.TabIndex = 0
        '
        'TxtNroLibreta
        '
        Me.TxtNroLibreta.Location = New System.Drawing.Point(71, 12)
        Me.TxtNroLibreta.Name = "TxtNroLibreta"
        Me.TxtNroLibreta.Size = New System.Drawing.Size(100, 20)
        Me.TxtNroLibreta.TabIndex = 0
        Me.TxtNroLibreta.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnImprime)
        Me.Panel2.Controls.Add(Me.btnGuardar)
        Me.Panel2.Controls.Add(Me.btnCerrar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 199)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(755, 62)
        Me.Panel2.TabIndex = 0
        '
        'btnImprime
        '
        Me.btnImprime.BackColor = System.Drawing.SystemColors.Control
        Me.btnImprime.ForeColor = System.Drawing.Color.Black
        Me.btnImprime.Image = CType(resources.GetObject("btnImprime.Image"), System.Drawing.Image)
        Me.btnImprime.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnImprime.Location = New System.Drawing.Point(8, 3)
        Me.btnImprime.Name = "btnImprime"
        Me.btnImprime.Size = New System.Drawing.Size(72, 56)
        Me.btnImprime.TabIndex = 19
        Me.btnImprime.Text = "&Imprimir"
        Me.btnImprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprime.UseVisualStyleBackColor = False
        Me.btnImprime.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGuardar.Location = New System.Drawing.Point(181, 3)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(72, 56)
        Me.btnGuardar.TabIndex = 17
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = False
        Me.btnGuardar.Visible = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCerrar.Location = New System.Drawing.Point(671, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 56)
        Me.btnCerrar.TabIndex = 18
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'TxtSocio
        '
        Me.TxtSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSocio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtSocio.Location = New System.Drawing.Point(181, 167)
        Me.TxtSocio.Name = "TxtSocio"
        Me.TxtSocio.Size = New System.Drawing.Size(571, 22)
        Me.TxtSocio.TabIndex = 16
        '
        'FrmActualiarLibrera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 261)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmActualiarLibrera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresion de Libreta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DgvLibreta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnImprime As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TxtCod_Impresion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtFecha_Impresion As TextBox
    Friend WithEvents TxtHora_Impresion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCodSocio As TextBox
    Friend WithEvents TxtNroLibreta As TextBox
    Friend WithEvents RbtRetiro As RadioButton
    Friend WithEvents RbtDeposito As RadioButton
    Friend WithEvents DgvLibreta As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtNroCuenta As TextBox
    Friend WithEvents DtFecha As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtSocio As TextBox
End Class
