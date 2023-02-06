Imports MySql.Data.MySqlClient
Public Class FRM_CONF_CHEQUERA
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents btnCierra As System.Windows.Forms.Button
    Friend WithEvents fld_y_fecha_top As System.Windows.Forms.TextBox
    Friend WithEvents fld_x_fecha_top As System.Windows.Forms.TextBox
    Friend WithEvents fld_y_concepto As System.Windows.Forms.TextBox
    Friend WithEvents fld_x_concepto As System.Windows.Forms.TextBox
    Friend WithEvents fld_y_valor_top As System.Windows.Forms.TextBox
    Friend WithEvents fld_x_valor_top As System.Windows.Forms.TextBox
    Friend WithEvents fld_y_beneficiario As System.Windows.Forms.TextBox
    Friend WithEvents fld_x_beneficiario As System.Windows.Forms.TextBox
    Friend WithEvents fld_y_valor As System.Windows.Forms.TextBox
    Friend WithEvents fld_x_valor As System.Windows.Forms.TextBox
    Friend WithEvents fld_y_letras As System.Windows.Forms.TextBox
    Friend WithEvents fld_x_letras As System.Windows.Forms.TextBox
    Friend WithEvents fld_y_pri_dig_dia As System.Windows.Forms.TextBox
    Friend WithEvents fld_x_pri_dig_dia As System.Windows.Forms.TextBox
    Friend WithEvents fld_x_seg_dig_dia As System.Windows.Forms.TextBox
    Friend WithEvents fld_y_seg_dig_dia As System.Windows.Forms.TextBox
    Friend WithEvents fld_x_seg_dig_mes As System.Windows.Forms.TextBox
    Friend WithEvents fld_y_seg_dig_mes As System.Windows.Forms.TextBox
    Friend WithEvents fld_x_pri_dig_mes As System.Windows.Forms.TextBox
    Friend WithEvents fld_y_pri_dig_mes As System.Windows.Forms.TextBox
    Friend WithEvents fld_x_seg_dig_ano As System.Windows.Forms.TextBox
    Friend WithEvents fld_y_seg_dig_ano As System.Windows.Forms.TextBox
    Friend WithEvents fld_x_pri_dig_ano As System.Windows.Forms.TextBox
    Friend WithEvents fld_y_pri_dig_ano As System.Windows.Forms.TextBox
    Friend WithEvents fld_x_cuar_dig_ano As System.Windows.Forms.TextBox
    Friend WithEvents fld_y_cuar_dig_ano As System.Windows.Forms.TextBox
    Friend WithEvents fld_x_ter_dig_ano As System.Windows.Forms.TextBox
    Friend WithEvents fld_y_ter_dig_ano As System.Windows.Forms.TextBox
    Friend WithEvents btnGuarda As System.Windows.Forms.Button
    Friend WithEvents fld_banco As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_CONF_CHEQUERA))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.fld_y_fecha_top = New System.Windows.Forms.TextBox
        Me.fld_x_fecha_top = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.fld_y_valor_top = New System.Windows.Forms.TextBox
        Me.fld_x_valor_top = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.Panel13 = New System.Windows.Forms.Panel
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.fld_y_concepto = New System.Windows.Forms.TextBox
        Me.fld_x_concepto = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.fld_y_beneficiario = New System.Windows.Forms.TextBox
        Me.fld_x_beneficiario = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.fld_y_valor = New System.Windows.Forms.TextBox
        Me.fld_x_valor = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.fld_y_letras = New System.Windows.Forms.TextBox
        Me.fld_x_letras = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.fld_x_cuar_dig_ano = New System.Windows.Forms.TextBox
        Me.fld_y_cuar_dig_ano = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.fld_x_ter_dig_ano = New System.Windows.Forms.TextBox
        Me.fld_y_ter_dig_ano = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.fld_x_seg_dig_ano = New System.Windows.Forms.TextBox
        Me.fld_y_seg_dig_ano = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.fld_x_pri_dig_ano = New System.Windows.Forms.TextBox
        Me.fld_y_pri_dig_ano = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.fld_x_seg_dig_dia = New System.Windows.Forms.TextBox
        Me.fld_y_seg_dig_dia = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.fld_x_pri_dig_dia = New System.Windows.Forms.TextBox
        Me.fld_y_pri_dig_dia = New System.Windows.Forms.TextBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.fld_x_seg_dig_mes = New System.Windows.Forms.TextBox
        Me.fld_y_seg_dig_mes = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.fld_x_pri_dig_mes = New System.Windows.Forms.TextBox
        Me.fld_y_pri_dig_mes = New System.Windows.Forms.TextBox
        Me.btnCierra = New System.Windows.Forms.Button
        Me.btnGuarda = New System.Windows.Forms.Button
        Me.fld_banco = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.fld_y_fecha_top)
        Me.GroupBox1.Controls.Add(Me.fld_x_fecha_top)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(84, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Y"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "X"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fld_y_fecha_top
        '
        Me.fld_y_fecha_top.Location = New System.Drawing.Point(80, 52)
        Me.fld_y_fecha_top.Name = "fld_y_fecha_top"
        Me.fld_y_fecha_top.Size = New System.Drawing.Size(40, 20)
        Me.fld_y_fecha_top.TabIndex = 5
        Me.fld_y_fecha_top.Text = "0"
        Me.fld_y_fecha_top.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fld_x_fecha_top
        '
        Me.fld_x_fecha_top.Location = New System.Drawing.Point(32, 52)
        Me.fld_x_fecha_top.Name = "fld_x_fecha_top"
        Me.fld_x_fecha_top.Size = New System.Drawing.Size(40, 20)
        Me.fld_x_fecha_top.TabIndex = 4
        Me.fld_x_fecha_top.Text = "0"
        Me.fld_x_fecha_top.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.fld_y_valor_top)
        Me.GroupBox3.Controls.Add(Me.fld_x_valor_top)
        Me.GroupBox3.Location = New System.Drawing.Point(542, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(152, 100)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Valor"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(84, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 23)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Y"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(36, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 23)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "X"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fld_y_valor_top
        '
        Me.fld_y_valor_top.Location = New System.Drawing.Point(80, 52)
        Me.fld_y_valor_top.Name = "fld_y_valor_top"
        Me.fld_y_valor_top.Size = New System.Drawing.Size(40, 20)
        Me.fld_y_valor_top.TabIndex = 5
        Me.fld_y_valor_top.Text = "0"
        Me.fld_y_valor_top.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fld_x_valor_top
        '
        Me.fld_x_valor_top.Location = New System.Drawing.Point(32, 52)
        Me.fld_x_valor_top.Name = "fld_x_valor_top"
        Me.fld_x_valor_top.Size = New System.Drawing.Size(40, 20)
        Me.fld_x_valor_top.TabIndex = 4
        Me.fld_x_valor_top.Text = "0"
        Me.fld_x_valor_top.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PAGUESE CONTRA ESTE CHEQUE A LA ORDEN DE:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(600, 229)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(99, 4)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Location = New System.Drawing.Point(-2, -2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(371, 4)
        Me.Panel2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(536, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "RD$"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(159, 229)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(377, 4)
        Me.Panel3.TabIndex = 5
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Controls.Add(Me.Panel10)
        Me.Panel7.Location = New System.Drawing.Point(-2, -2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(377, 4)
        Me.Panel7.TabIndex = 6
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Location = New System.Drawing.Point(1, -2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(371, 4)
        Me.Panel8.TabIndex = 5
        '
        'Panel9
        '
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel9.Location = New System.Drawing.Point(-2, -2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(371, 4)
        Me.Panel9.TabIndex = 4
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel10.Location = New System.Drawing.Point(-2, -2)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(371, 4)
        Me.Panel10.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Location = New System.Drawing.Point(1, -2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(371, 4)
        Me.Panel5.TabIndex = 5
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Location = New System.Drawing.Point(-2, -2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(371, 4)
        Me.Panel6.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Location = New System.Drawing.Point(-2, -2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(371, 4)
        Me.Panel4.TabIndex = 4
        '
        'Panel11
        '
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel11.Controls.Add(Me.Panel12)
        Me.Panel11.Controls.Add(Me.Panel14)
        Me.Panel11.Location = New System.Drawing.Point(16, 312)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(680, 4)
        Me.Panel11.TabIndex = 6
        '
        'Panel12
        '
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel12.Controls.Add(Me.Panel13)
        Me.Panel12.Location = New System.Drawing.Point(1, -2)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(371, 4)
        Me.Panel12.TabIndex = 5
        '
        'Panel13
        '
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel13.Location = New System.Drawing.Point(-2, -2)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(371, 4)
        Me.Panel13.TabIndex = 4
        '
        'Panel14
        '
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel14.Location = New System.Drawing.Point(-2, -2)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(371, 4)
        Me.Panel14.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.fld_y_concepto)
        Me.GroupBox2.Controls.Add(Me.fld_x_concepto)
        Me.GroupBox2.Location = New System.Drawing.Point(159, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(384, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Concepto"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(200, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Y"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(152, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 23)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "X"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fld_y_concepto
        '
        Me.fld_y_concepto.Location = New System.Drawing.Point(196, 52)
        Me.fld_y_concepto.Name = "fld_y_concepto"
        Me.fld_y_concepto.Size = New System.Drawing.Size(40, 20)
        Me.fld_y_concepto.TabIndex = 5
        Me.fld_y_concepto.Text = "0"
        Me.fld_y_concepto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fld_x_concepto
        '
        Me.fld_x_concepto.Location = New System.Drawing.Point(148, 52)
        Me.fld_x_concepto.Name = "fld_x_concepto"
        Me.fld_x_concepto.Size = New System.Drawing.Size(40, 20)
        Me.fld_x_concepto.TabIndex = 4
        Me.fld_x_concepto.Text = "0"
        Me.fld_x_concepto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(365, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 23)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Y"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(317, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 23)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "X"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fld_y_beneficiario
        '
        Me.fld_y_beneficiario.Location = New System.Drawing.Point(361, 200)
        Me.fld_y_beneficiario.Name = "fld_y_beneficiario"
        Me.fld_y_beneficiario.Size = New System.Drawing.Size(40, 20)
        Me.fld_y_beneficiario.TabIndex = 8
        Me.fld_y_beneficiario.Text = "0"
        Me.fld_y_beneficiario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fld_x_beneficiario
        '
        Me.fld_x_beneficiario.Location = New System.Drawing.Point(313, 200)
        Me.fld_x_beneficiario.Name = "fld_x_beneficiario"
        Me.fld_x_beneficiario.Size = New System.Drawing.Size(40, 20)
        Me.fld_x_beneficiario.TabIndex = 7
        Me.fld_x_beneficiario.Text = "0"
        Me.fld_x_beneficiario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(656, 176)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 23)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Y"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(608, 176)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 23)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "X"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fld_y_valor
        '
        Me.fld_y_valor.Location = New System.Drawing.Point(648, 200)
        Me.fld_y_valor.Name = "fld_y_valor"
        Me.fld_y_valor.Size = New System.Drawing.Size(40, 20)
        Me.fld_y_valor.TabIndex = 12
        Me.fld_y_valor.Text = "0"
        Me.fld_y_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fld_x_valor
        '
        Me.fld_x_valor.Location = New System.Drawing.Point(600, 200)
        Me.fld_x_valor.Name = "fld_x_valor"
        Me.fld_x_valor.Size = New System.Drawing.Size(40, 20)
        Me.fld_x_valor.TabIndex = 11
        Me.fld_x_valor.Text = "0"
        Me.fld_x_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(96, 264)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 23)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Y"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(48, 264)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 23)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "X"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fld_y_letras
        '
        Me.fld_y_letras.Location = New System.Drawing.Point(96, 288)
        Me.fld_y_letras.Name = "fld_y_letras"
        Me.fld_y_letras.Size = New System.Drawing.Size(40, 20)
        Me.fld_y_letras.TabIndex = 16
        Me.fld_y_letras.Text = "0"
        Me.fld_y_letras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fld_x_letras
        '
        Me.fld_x_letras.Location = New System.Drawing.Point(48, 288)
        Me.fld_x_letras.Name = "fld_x_letras"
        Me.fld_x_letras.Size = New System.Drawing.Size(40, 20)
        Me.fld_x_letras.TabIndex = 15
        Me.fld_x_letras.Text = "0"
        Me.fld_x_letras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox7)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 352)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(816, 136)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Valores para la fecha del cuerpo del cheque"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label33)
        Me.GroupBox7.Controls.Add(Me.Label34)
        Me.GroupBox7.Controls.Add(Me.Label35)
        Me.GroupBox7.Controls.Add(Me.Label36)
        Me.GroupBox7.Controls.Add(Me.fld_x_cuar_dig_ano)
        Me.GroupBox7.Controls.Add(Me.fld_y_cuar_dig_ano)
        Me.GroupBox7.Controls.Add(Me.Label37)
        Me.GroupBox7.Controls.Add(Me.Label38)
        Me.GroupBox7.Controls.Add(Me.fld_x_ter_dig_ano)
        Me.GroupBox7.Controls.Add(Me.fld_y_ter_dig_ano)
        Me.GroupBox7.Controls.Add(Me.Label27)
        Me.GroupBox7.Controls.Add(Me.Label28)
        Me.GroupBox7.Controls.Add(Me.Label29)
        Me.GroupBox7.Controls.Add(Me.Label30)
        Me.GroupBox7.Controls.Add(Me.fld_x_seg_dig_ano)
        Me.GroupBox7.Controls.Add(Me.fld_y_seg_dig_ano)
        Me.GroupBox7.Controls.Add(Me.Label31)
        Me.GroupBox7.Controls.Add(Me.Label32)
        Me.GroupBox7.Controls.Add(Me.fld_x_pri_dig_ano)
        Me.GroupBox7.Controls.Add(Me.fld_y_pri_dig_ano)
        Me.GroupBox7.Location = New System.Drawing.Point(411, 14)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(397, 100)
        Me.GroupBox7.TabIndex = 15
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Año"
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(304, 15)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(80, 16)
        Me.Label33.TabIndex = 23
        Me.Label33.Text = "Cuarto dígito"
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(208, 15)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(72, 16)
        Me.Label34.TabIndex = 22
        Me.Label34.Text = "Tercer dígito"
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(296, 31)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(32, 23)
        Me.Label35.TabIndex = 20
        Me.Label35.Text = "X"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(344, 31)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(32, 23)
        Me.Label36.TabIndex = 21
        Me.Label36.Text = "Y"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fld_x_cuar_dig_ano
        '
        Me.fld_x_cuar_dig_ano.Location = New System.Drawing.Point(296, 55)
        Me.fld_x_cuar_dig_ano.Name = "fld_x_cuar_dig_ano"
        Me.fld_x_cuar_dig_ano.Size = New System.Drawing.Size(40, 20)
        Me.fld_x_cuar_dig_ano.TabIndex = 18
        Me.fld_x_cuar_dig_ano.Text = "0"
        Me.fld_x_cuar_dig_ano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fld_y_cuar_dig_ano
        '
        Me.fld_y_cuar_dig_ano.Location = New System.Drawing.Point(344, 55)
        Me.fld_y_cuar_dig_ano.Name = "fld_y_cuar_dig_ano"
        Me.fld_y_cuar_dig_ano.Size = New System.Drawing.Size(40, 20)
        Me.fld_y_cuar_dig_ano.TabIndex = 19
        Me.fld_y_cuar_dig_ano.Text = "0"
        Me.fld_y_cuar_dig_ano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(200, 31)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(32, 23)
        Me.Label37.TabIndex = 16
        Me.Label37.Text = "X"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(248, 31)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(32, 23)
        Me.Label38.TabIndex = 17
        Me.Label38.Text = "Y"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fld_x_ter_dig_ano
        '
        Me.fld_x_ter_dig_ano.Location = New System.Drawing.Point(200, 55)
        Me.fld_x_ter_dig_ano.Name = "fld_x_ter_dig_ano"
        Me.fld_x_ter_dig_ano.Size = New System.Drawing.Size(40, 20)
        Me.fld_x_ter_dig_ano.TabIndex = 14
        Me.fld_x_ter_dig_ano.Text = "0"
        Me.fld_x_ter_dig_ano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fld_y_ter_dig_ano
        '
        Me.fld_y_ter_dig_ano.Location = New System.Drawing.Point(248, 55)
        Me.fld_y_ter_dig_ano.Name = "fld_y_ter_dig_ano"
        Me.fld_y_ter_dig_ano.Size = New System.Drawing.Size(40, 20)
        Me.fld_y_ter_dig_ano.TabIndex = 15
        Me.fld_y_ter_dig_ano.Text = "0"
        Me.fld_y_ter_dig_ano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(112, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(80, 16)
        Me.Label27.TabIndex = 13
        Me.Label27.Text = "Segundo dígito"
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(16, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(72, 16)
        Me.Label28.TabIndex = 12
        Me.Label28.Text = "Primer dígito"
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(104, 32)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(32, 23)
        Me.Label29.TabIndex = 10
        Me.Label29.Text = "X"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(152, 32)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(32, 23)
        Me.Label30.TabIndex = 11
        Me.Label30.Text = "Y"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fld_x_seg_dig_ano
        '
        Me.fld_x_seg_dig_ano.Location = New System.Drawing.Point(104, 56)
        Me.fld_x_seg_dig_ano.Name = "fld_x_seg_dig_ano"
        Me.fld_x_seg_dig_ano.Size = New System.Drawing.Size(40, 20)
        Me.fld_x_seg_dig_ano.TabIndex = 8
        Me.fld_x_seg_dig_ano.Text = "0"
        Me.fld_x_seg_dig_ano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fld_y_seg_dig_ano
        '
        Me.fld_y_seg_dig_ano.Location = New System.Drawing.Point(152, 56)
        Me.fld_y_seg_dig_ano.Name = "fld_y_seg_dig_ano"
        Me.fld_y_seg_dig_ano.Size = New System.Drawing.Size(40, 20)
        Me.fld_y_seg_dig_ano.TabIndex = 9
        Me.fld_y_seg_dig_ano.Text = "0"
        Me.fld_y_seg_dig_ano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(8, 32)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(32, 23)
        Me.Label31.TabIndex = 6
        Me.Label31.Text = "X"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(56, 32)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(32, 23)
        Me.Label32.TabIndex = 7
        Me.Label32.Text = "Y"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fld_x_pri_dig_ano
        '
        Me.fld_x_pri_dig_ano.Location = New System.Drawing.Point(8, 56)
        Me.fld_x_pri_dig_ano.Name = "fld_x_pri_dig_ano"
        Me.fld_x_pri_dig_ano.Size = New System.Drawing.Size(40, 20)
        Me.fld_x_pri_dig_ano.TabIndex = 4
        Me.fld_x_pri_dig_ano.Text = "0"
        Me.fld_x_pri_dig_ano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fld_y_pri_dig_ano
        '
        Me.fld_y_pri_dig_ano.Location = New System.Drawing.Point(56, 56)
        Me.fld_y_pri_dig_ano.Name = "fld_y_pri_dig_ano"
        Me.fld_y_pri_dig_ano.Size = New System.Drawing.Size(40, 20)
        Me.fld_y_pri_dig_ano.TabIndex = 5
        Me.fld_y_pri_dig_ano.Text = "0"
        Me.fld_y_pri_dig_ano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.fld_x_seg_dig_dia)
        Me.GroupBox5.Controls.Add(Me.fld_y_seg_dig_dia)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.fld_x_pri_dig_dia)
        Me.GroupBox5.Controls.Add(Me.fld_y_pri_dig_dia)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 13)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Día"
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(112, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(80, 16)
        Me.Label20.TabIndex = 13
        Me.Label20.Text = "Segundo dígito"
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(16, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 16)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Primer dígito"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(104, 32)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 23)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "X"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(152, 32)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(32, 23)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "Y"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fld_x_seg_dig_dia
        '
        Me.fld_x_seg_dig_dia.Location = New System.Drawing.Point(104, 56)
        Me.fld_x_seg_dig_dia.Name = "fld_x_seg_dig_dia"
        Me.fld_x_seg_dig_dia.Size = New System.Drawing.Size(40, 20)
        Me.fld_x_seg_dig_dia.TabIndex = 8
        Me.fld_x_seg_dig_dia.Text = "0"
        Me.fld_x_seg_dig_dia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fld_y_seg_dig_dia
        '
        Me.fld_y_seg_dig_dia.Location = New System.Drawing.Point(152, 56)
        Me.fld_y_seg_dig_dia.Name = "fld_y_seg_dig_dia"
        Me.fld_y_seg_dig_dia.Size = New System.Drawing.Size(40, 20)
        Me.fld_y_seg_dig_dia.TabIndex = 9
        Me.fld_y_seg_dig_dia.Text = "0"
        Me.fld_y_seg_dig_dia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 23)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "X"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(56, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 23)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Y"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fld_x_pri_dig_dia
        '
        Me.fld_x_pri_dig_dia.Location = New System.Drawing.Point(8, 56)
        Me.fld_x_pri_dig_dia.Name = "fld_x_pri_dig_dia"
        Me.fld_x_pri_dig_dia.Size = New System.Drawing.Size(40, 20)
        Me.fld_x_pri_dig_dia.TabIndex = 4
        Me.fld_x_pri_dig_dia.Text = "0"
        Me.fld_x_pri_dig_dia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fld_y_pri_dig_dia
        '
        Me.fld_y_pri_dig_dia.Location = New System.Drawing.Point(56, 56)
        Me.fld_y_pri_dig_dia.Name = "fld_y_pri_dig_dia"
        Me.fld_y_pri_dig_dia.Size = New System.Drawing.Size(40, 20)
        Me.fld_y_pri_dig_dia.TabIndex = 5
        Me.fld_y_pri_dig_dia.Text = "0"
        Me.fld_y_pri_dig_dia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.fld_x_seg_dig_mes)
        Me.GroupBox6.Controls.Add(Me.fld_y_seg_dig_mes)
        Me.GroupBox6.Controls.Add(Me.Label25)
        Me.GroupBox6.Controls.Add(Me.Label26)
        Me.GroupBox6.Controls.Add(Me.fld_x_pri_dig_mes)
        Me.GroupBox6.Controls.Add(Me.fld_y_pri_dig_mes)
        Me.GroupBox6.Location = New System.Drawing.Point(208, 14)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.TabIndex = 14
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Mes"
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(112, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 16)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "Segundo dígito"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(16, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 16)
        Me.Label22.TabIndex = 12
        Me.Label22.Text = "Primer dígito"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(104, 32)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(32, 23)
        Me.Label23.TabIndex = 10
        Me.Label23.Text = "X"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(152, 32)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(32, 23)
        Me.Label24.TabIndex = 11
        Me.Label24.Text = "Y"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fld_x_seg_dig_mes
        '
        Me.fld_x_seg_dig_mes.Location = New System.Drawing.Point(104, 56)
        Me.fld_x_seg_dig_mes.Name = "fld_x_seg_dig_mes"
        Me.fld_x_seg_dig_mes.Size = New System.Drawing.Size(40, 20)
        Me.fld_x_seg_dig_mes.TabIndex = 8
        Me.fld_x_seg_dig_mes.Text = "0"
        Me.fld_x_seg_dig_mes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fld_y_seg_dig_mes
        '
        Me.fld_y_seg_dig_mes.Location = New System.Drawing.Point(152, 56)
        Me.fld_y_seg_dig_mes.Name = "fld_y_seg_dig_mes"
        Me.fld_y_seg_dig_mes.Size = New System.Drawing.Size(40, 20)
        Me.fld_y_seg_dig_mes.TabIndex = 9
        Me.fld_y_seg_dig_mes.Text = "0"
        Me.fld_y_seg_dig_mes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(8, 32)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(32, 23)
        Me.Label25.TabIndex = 6
        Me.Label25.Text = "X"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(56, 32)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(32, 23)
        Me.Label26.TabIndex = 7
        Me.Label26.Text = "Y"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fld_x_pri_dig_mes
        '
        Me.fld_x_pri_dig_mes.Location = New System.Drawing.Point(8, 56)
        Me.fld_x_pri_dig_mes.Name = "fld_x_pri_dig_mes"
        Me.fld_x_pri_dig_mes.Size = New System.Drawing.Size(40, 20)
        Me.fld_x_pri_dig_mes.TabIndex = 4
        Me.fld_x_pri_dig_mes.Text = "0"
        Me.fld_x_pri_dig_mes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fld_y_pri_dig_mes
        '
        Me.fld_y_pri_dig_mes.Location = New System.Drawing.Point(56, 56)
        Me.fld_y_pri_dig_mes.Name = "fld_y_pri_dig_mes"
        Me.fld_y_pri_dig_mes.Size = New System.Drawing.Size(40, 20)
        Me.fld_y_pri_dig_mes.TabIndex = 5
        Me.fld_y_pri_dig_mes.Text = "0"
        Me.fld_y_pri_dig_mes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCierra
        '
        Me.btnCierra.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCierra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCierra.ForeColor = System.Drawing.Color.Black
        Me.btnCierra.Image = CType(resources.GetObject("btnCierra.Image"), System.Drawing.Image)
        Me.btnCierra.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCierra.Location = New System.Drawing.Point(760, 237)
        Me.btnCierra.Name = "btnCierra"
        Me.btnCierra.Size = New System.Drawing.Size(72, 56)
        Me.btnCierra.TabIndex = 30
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
        Me.btnGuarda.Location = New System.Drawing.Point(688, 237)
        Me.btnGuarda.Name = "btnGuarda"
        Me.btnGuarda.Size = New System.Drawing.Size(72, 56)
        Me.btnGuarda.TabIndex = 29
        Me.btnGuarda.Text = "&Guardar"
        Me.btnGuarda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'fld_banco
        '
        Me.fld_banco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.fld_banco.Location = New System.Drawing.Point(8, 144)
        Me.fld_banco.Name = "fld_banco"
        Me.fld_banco.Size = New System.Drawing.Size(536, 21)
        Me.fld_banco.TabIndex = 31
        '
        'FRM_CONF_CHEQUERA
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(842, 500)
        Me.Controls.Add(Me.fld_banco)
        Me.Controls.Add(Me.btnCierra)
        Me.Controls.Add(Me.btnGuarda)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.fld_y_letras)
        Me.Controls.Add(Me.fld_x_letras)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.fld_y_valor)
        Me.Controls.Add(Me.fld_x_valor)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.fld_y_beneficiario)
        Me.Controls.Add(Me.fld_x_beneficiario)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_CONF_CHEQUERA"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración Impresión de cheques"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Function CodigoBanco() As Integer
        Dim cod() As String
        cod = Split(fld_banco.Text, "-")
        Return CInt(Trim(cod(0)))
    End Function

    Private Sub CargaDatosBancos()
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT CONCAT(fld_id,'-Código.: ',fld_codigo,' Cuenta.: ', fld_cuenta, ' Banco.: ', fld_nombre) as Banco FROM tbl_bancos ORDER BY fld_id", conn)
        da.Fill(ds, "tbl_bancos")
        fld_banco.Items.Clear()
        Dim dr As DataRow
        For Each dr In ds.Tables(0).Rows
            fld_banco.Items.Add(dr("Banco"))
        Next
        ds.Dispose()
        da.Dispose()
        dr = Nothing
    End Sub

    Private Sub CargarDatos(ByVal idDocumento As Integer)
        btnGuarda.Text = "&Guardar"
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_confg_chequera WHERE fld_doc_chequera=" & idDocumento & "", conn)
        da.Fill(ds, "tbl_confg_chequera")
        For Each dr In ds.Tables(0).Rows
            fld_x_fecha_top.Text = dr("fld_x_fecha_top")
            fld_y_fecha_top.Text = dr("fld_y_fecha_top")
            fld_x_concepto.Text = dr("fld_x_concepto")
            fld_y_concepto.Text = dr("fld_y_concepto")
            fld_x_valor_top.Text = dr("fld_x_valor_top")
            fld_y_valor_top.Text = dr("fld_y_valor_top")
            fld_x_beneficiario.Text = dr("fld_x_beneficiario")
            fld_y_beneficiario.Text = dr("fld_y_beneficiario")
            fld_x_valor.Text = dr("fld_x_valor")
            fld_y_valor.Text = dr("fld_y_valor")
            fld_x_letras.Text = dr("fld_x_letras")
            fld_y_letras.Text = dr("fld_y_letras")
            fld_x_pri_dig_dia.Text = dr("fld_x_pri_dig_dia")
            fld_y_pri_dig_dia.Text = dr("fld_y_pri_dig_dia")
            fld_x_seg_dig_dia.Text = dr("fld_x_seg_dig_dia")
            fld_y_seg_dig_dia.Text = dr("fld_y_seg_dig_dia")
            fld_x_pri_dig_mes.Text = dr("fld_x_pri_dig_mes")
            fld_y_pri_dig_mes.Text = dr("fld_y_pri_dig_mes")
            fld_x_seg_dig_mes.Text = dr("fld_x_seg_dig_mes")
            fld_y_seg_dig_mes.Text = dr("fld_y_seg_dig_mes")
            fld_x_pri_dig_ano.Text = dr("fld_x_pri_dig_ano")
            fld_y_pri_dig_ano.Text = dr("fld_y_pri_dig_ano")
            fld_x_seg_dig_ano.Text = dr("fld_x_seg_dig_ano")
            fld_y_seg_dig_ano.Text = dr("fld_y_seg_dig_ano")
            fld_x_ter_dig_ano.Text = dr("fld_x_ter_dig_ano")
            fld_y_ter_dig_ano.Text = dr("fld_y_ter_dig_ano")
            fld_x_cuar_dig_ano.Text = dr("fld_x_cuar_dig_ano")
            fld_y_cuar_dig_ano.Text = dr("fld_y_cuar_dig_ano")
            btnGuarda.Text = "&Modificar"
        Next

        ds.Dispose()
        da.Dispose()
        dr = Nothing

    End Sub

    Private Sub GuardarDatos()

        NON_QUERY("INSERT INTO tbl_confg_chequera (fld_fecha, fld_x_fecha_top, fld_y_fecha_top, fld_x_concepto, fld_y_concepto, fld_x_valor_top, fld_y_valor_top, fld_x_beneficiario, fld_y_beneficiario, fld_x_valor, fld_y_valor, fld_x_letras, fld_y_letras, fld_x_pri_dig_dia, fld_y_pri_dig_dia, fld_x_seg_dig_dia, fld_y_seg_dig_dia, fld_x_pri_dig_mes, fld_y_pri_dig_mes, fld_x_seg_dig_mes, fld_y_seg_dig_mes, fld_x_pri_dig_ano, fld_y_pri_dig_ano, fld_x_seg_dig_ano, fld_y_seg_dig_ano, fld_x_ter_dig_ano, fld_y_ter_dig_ano, fld_x_cuar_dig_ano, fld_y_cuar_dig_ano,fld_doc_chequera) VALUES(Now()," & CInt(fld_x_fecha_top.Text) & " , " & CInt(fld_y_fecha_top.Text) & " , " & CInt(fld_x_concepto.Text) & " , " & CInt(fld_y_concepto.Text) & " , " & CInt(fld_x_valor_top.Text) & "," & CInt(fld_y_valor_top.Text) & " , " & CInt(fld_x_beneficiario.Text) & " , " & CInt(fld_y_beneficiario.Text) & " , " & CInt(fld_x_valor.Text) & " , " & CInt(fld_y_valor.Text) & " , " & CInt(fld_x_letras.Text) & "," & CInt(fld_y_letras.Text) & " , " & CInt(fld_x_pri_dig_dia.Text) & " , " & CInt(fld_y_pri_dig_dia.Text) & " , " & CInt(fld_x_seg_dig_dia.Text) & " , " & CInt(fld_y_seg_dig_dia.Text) & " , " & CInt(fld_x_pri_dig_mes.Text) & ", " & CInt(fld_y_pri_dig_mes.Text) & " , " & CInt(fld_x_seg_dig_mes.Text) & " , " & CInt(fld_y_seg_dig_mes.Text) & " , " & CInt(fld_x_pri_dig_ano.Text) & " , " & CInt(fld_y_pri_dig_ano.Text) & " , " & CInt(fld_x_seg_dig_ano.Text) & ", " & CInt(fld_y_seg_dig_ano.Text) & " , " & CInt(fld_x_ter_dig_ano.Text) & " , " & CInt(fld_y_ter_dig_ano.Text) & " , " & CInt(fld_x_cuar_dig_ano.Text) & " , " & CInt(fld_y_cuar_dig_ano.Text) & ", " & CodigoBanco() & ");")

    End Sub

    Private Sub ActualizaDatos(ByVal idDocumento As Integer)

        NON_QUERY("UPDATE tbl_confg_chequera SET fld_x_fecha_top = " & CInt(fld_x_fecha_top.Text) & " , fld_y_fecha_top = " & CInt(fld_y_fecha_top.Text) & " , fld_x_concepto = " & CInt(fld_x_concepto.Text) & " , fld_y_concepto = " & CInt(fld_y_concepto.Text) & " , fld_x_valor_top = " & CInt(fld_x_valor_top.Text) & " , fld_y_valor_top = " & CInt(fld_y_valor_top.Text) & " , fld_x_beneficiario = " & CInt(fld_x_beneficiario.Text) & " , fld_y_beneficiario = " & CInt(fld_y_beneficiario.Text) & " , fld_x_valor = " & CInt(fld_x_valor.Text) & " , fld_y_valor = " & CInt(fld_y_valor.Text) & " , fld_x_letras = " & CInt(fld_x_letras.Text) & " , fld_y_letras = " & CInt(fld_y_letras.Text) & " , fld_x_pri_dig_dia = " & CInt(fld_x_pri_dig_dia.Text) & " , fld_y_pri_dig_dia = " & CInt(fld_y_pri_dig_dia.Text) & " , fld_x_seg_dig_dia = " & CInt(fld_x_seg_dig_dia.Text) & " , fld_y_seg_dig_dia = " & CInt(fld_y_seg_dig_dia.Text) & " , fld_x_pri_dig_mes = " & CInt(fld_x_pri_dig_mes.Text) & " , fld_y_pri_dig_mes = " & CInt(fld_y_pri_dig_mes.Text) & " , fld_x_seg_dig_mes = " & CInt(fld_x_seg_dig_mes.Text) & " , fld_y_seg_dig_mes = " & CInt(fld_y_seg_dig_mes.Text) & " , fld_x_pri_dig_ano = " & CInt(fld_x_pri_dig_ano.Text) & " , fld_y_pri_dig_ano = " & CInt(fld_y_pri_dig_ano.Text) & " , fld_x_seg_dig_ano = " & CInt(fld_x_seg_dig_ano.Text) & " , fld_y_seg_dig_ano = " & CInt(fld_y_seg_dig_ano.Text) & " , fld_x_ter_dig_ano = " & CInt(fld_x_ter_dig_ano.Text) & " , fld_y_ter_dig_ano = " & CInt(fld_y_ter_dig_ano.Text) & " , fld_x_cuar_dig_ano = " & CInt(fld_x_cuar_dig_ano.Text) & " , fld_y_cuar_dig_ano = " & CInt(fld_y_cuar_dig_ano.Text) & " WHERE fld_doc_chequera = " & idDocumento & " ;")

    End Sub

    Private Sub btnCierra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCierra.Click
        Me.Close()
    End Sub

    Private Sub btnGuarda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuarda.Click
        If Trim(fld_banco.Text) = "" Then
            Alerta("Por favor seleccione una cuenta de Banco")
            Exit Sub
        End If
        If btnGuarda.Text = "&Modificar" Then
            ActualizaDatos(CodigoBanco)
            Alerta("Documento actualizado")
        Else
            GuardarDatos()
            btnGuarda.Text = "&Modificar"
            Alerta("Documento guardado")
        End If

    End Sub

    Private Sub FRM_CONF_CHEQUERA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        CargaDatosBancos()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btnGuarda.Text = "&Guardar"
    End Sub

    Private Sub fld_banco_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fld_banco.SelectedValueChanged
        CargarDatos(CodigoBanco)
    End Sub
End Class
