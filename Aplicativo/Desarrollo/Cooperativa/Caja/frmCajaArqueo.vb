Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Public Class frmCajaArqueo
    Inherits System.Windows.Forms.Form
    ' 

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
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1_13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1_12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1_11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1_10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1_9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1_8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1_7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1_6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1_5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1_4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1_3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1_2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1_1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents fld_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents fld_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents fld_efectivo_inicio_caja As System.Windows.Forms.TextBox
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCajaArqueo))
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.TextBox13 = New System.Windows.Forms.TextBox
        Me.TextBox1_13 = New System.Windows.Forms.TextBox
        Me.TextBox1_12 = New System.Windows.Forms.TextBox
        Me.TextBox1_11 = New System.Windows.Forms.TextBox
        Me.TextBox1_10 = New System.Windows.Forms.TextBox
        Me.TextBox1_9 = New System.Windows.Forms.TextBox
        Me.TextBox1_8 = New System.Windows.Forms.TextBox
        Me.TextBox1_7 = New System.Windows.Forms.TextBox
        Me.TextBox1_6 = New System.Windows.Forms.TextBox
        Me.TextBox1_5 = New System.Windows.Forms.TextBox
        Me.TextBox1_4 = New System.Windows.Forms.TextBox
        Me.TextBox1_3 = New System.Windows.Forms.TextBox
        Me.TextBox1_2 = New System.Windows.Forms.TextBox
        Me.TextBox1_1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.TextBox14 = New System.Windows.Forms.TextBox
        Me.TextBox15 = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.TextBox16 = New System.Windows.Forms.TextBox
        Me.TextBox17 = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.TextBox18 = New System.Windows.Forms.TextBox
        Me.TextBox19 = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.TextBox20 = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.PrintDialog = New System.Windows.Forms.PrintDialog
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.fld_hasta = New System.Windows.Forms.DateTimePicker
        Me.fld_desde = New System.Windows.Forms.DateTimePicker
        Me.LV = New System.Windows.Forms.ListView
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label27 = New System.Windows.Forms.Label
        Me.fld_efectivo_inicio_caja = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "X 2,000.00"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(49, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "X 1,000.00"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(49, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 16)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "X 500.00"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(49, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 16)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "X 200.00"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(49, 205)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 16)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "X 100.00"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(49, 233)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 16)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "X 50.00"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(49, 261)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 16)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "X 25.00"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(49, 289)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 16)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "X 20.00"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(49, 317)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 16)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "X 10.00"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(49, 345)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 16)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "X 5.00"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(49, 373)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 16)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "X 1.00"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(49, 401)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 16)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "X US"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(49, 429)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 16)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "X €"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(1, 88)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(40, 26)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "0"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(1, 116)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(40, 26)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = "0"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(1, 144)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(40, 26)
        Me.TextBox3.TabIndex = 4
        Me.TextBox3.Text = "0"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(1, 172)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(40, 26)
        Me.TextBox4.TabIndex = 5
        Me.TextBox4.Text = "0"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(1, 200)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(40, 26)
        Me.TextBox5.TabIndex = 6
        Me.TextBox5.Text = "0"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(1, 228)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(40, 26)
        Me.TextBox6.TabIndex = 7
        Me.TextBox6.Text = "0"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(1, 256)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(40, 26)
        Me.TextBox7.TabIndex = 8
        Me.TextBox7.Text = "0"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(1, 284)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(40, 26)
        Me.TextBox8.TabIndex = 9
        Me.TextBox8.Text = "0"
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox9
        '
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(1, 312)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(40, 26)
        Me.TextBox9.TabIndex = 10
        Me.TextBox9.Text = "0"
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox10
        '
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(1, 340)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(40, 26)
        Me.TextBox10.TabIndex = 11
        Me.TextBox10.Text = "0"
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox11
        '
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(1, 368)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(40, 26)
        Me.TextBox11.TabIndex = 12
        Me.TextBox11.Text = "0"
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox12
        '
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(1, 396)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(40, 26)
        Me.TextBox12.TabIndex = 13
        Me.TextBox12.Text = "0"
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox13
        '
        Me.TextBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(1, 424)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(40, 26)
        Me.TextBox13.TabIndex = 14
        Me.TextBox13.Text = "0"
        Me.TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1_13
        '
        Me.TextBox1_13.BackColor = System.Drawing.Color.White
        Me.TextBox1_13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_13.Location = New System.Drawing.Point(137, 424)
        Me.TextBox1_13.Name = "TextBox1_13"
        Me.TextBox1_13.ReadOnly = True
        Me.TextBox1_13.Size = New System.Drawing.Size(120, 26)
        Me.TextBox1_13.TabIndex = 46
        Me.TextBox1_13.Text = "0.00"
        '
        'TextBox1_12
        '
        Me.TextBox1_12.BackColor = System.Drawing.Color.White
        Me.TextBox1_12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_12.Location = New System.Drawing.Point(137, 396)
        Me.TextBox1_12.Name = "TextBox1_12"
        Me.TextBox1_12.ReadOnly = True
        Me.TextBox1_12.Size = New System.Drawing.Size(120, 26)
        Me.TextBox1_12.TabIndex = 45
        Me.TextBox1_12.Text = "0.00"
        '
        'TextBox1_11
        '
        Me.TextBox1_11.BackColor = System.Drawing.Color.White
        Me.TextBox1_11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_11.Location = New System.Drawing.Point(137, 368)
        Me.TextBox1_11.Name = "TextBox1_11"
        Me.TextBox1_11.ReadOnly = True
        Me.TextBox1_11.Size = New System.Drawing.Size(120, 26)
        Me.TextBox1_11.TabIndex = 44
        Me.TextBox1_11.Text = "0.00"
        '
        'TextBox1_10
        '
        Me.TextBox1_10.BackColor = System.Drawing.Color.White
        Me.TextBox1_10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_10.Location = New System.Drawing.Point(137, 340)
        Me.TextBox1_10.Name = "TextBox1_10"
        Me.TextBox1_10.ReadOnly = True
        Me.TextBox1_10.Size = New System.Drawing.Size(120, 26)
        Me.TextBox1_10.TabIndex = 43
        Me.TextBox1_10.Text = "0.00"
        '
        'TextBox1_9
        '
        Me.TextBox1_9.BackColor = System.Drawing.Color.White
        Me.TextBox1_9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_9.Location = New System.Drawing.Point(137, 312)
        Me.TextBox1_9.Name = "TextBox1_9"
        Me.TextBox1_9.ReadOnly = True
        Me.TextBox1_9.Size = New System.Drawing.Size(120, 26)
        Me.TextBox1_9.TabIndex = 42
        Me.TextBox1_9.Text = "0.00"
        '
        'TextBox1_8
        '
        Me.TextBox1_8.BackColor = System.Drawing.Color.White
        Me.TextBox1_8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_8.Location = New System.Drawing.Point(137, 284)
        Me.TextBox1_8.Name = "TextBox1_8"
        Me.TextBox1_8.ReadOnly = True
        Me.TextBox1_8.Size = New System.Drawing.Size(120, 26)
        Me.TextBox1_8.TabIndex = 41
        Me.TextBox1_8.Text = "0.00"
        '
        'TextBox1_7
        '
        Me.TextBox1_7.BackColor = System.Drawing.Color.White
        Me.TextBox1_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_7.Location = New System.Drawing.Point(137, 256)
        Me.TextBox1_7.Name = "TextBox1_7"
        Me.TextBox1_7.ReadOnly = True
        Me.TextBox1_7.Size = New System.Drawing.Size(120, 26)
        Me.TextBox1_7.TabIndex = 40
        Me.TextBox1_7.Text = "0.00"
        '
        'TextBox1_6
        '
        Me.TextBox1_6.BackColor = System.Drawing.Color.White
        Me.TextBox1_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_6.Location = New System.Drawing.Point(137, 228)
        Me.TextBox1_6.Name = "TextBox1_6"
        Me.TextBox1_6.ReadOnly = True
        Me.TextBox1_6.Size = New System.Drawing.Size(120, 26)
        Me.TextBox1_6.TabIndex = 39
        Me.TextBox1_6.Text = "0.00"
        '
        'TextBox1_5
        '
        Me.TextBox1_5.BackColor = System.Drawing.Color.White
        Me.TextBox1_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_5.Location = New System.Drawing.Point(137, 200)
        Me.TextBox1_5.Name = "TextBox1_5"
        Me.TextBox1_5.ReadOnly = True
        Me.TextBox1_5.Size = New System.Drawing.Size(120, 26)
        Me.TextBox1_5.TabIndex = 38
        Me.TextBox1_5.Text = "0.00"
        '
        'TextBox1_4
        '
        Me.TextBox1_4.BackColor = System.Drawing.Color.White
        Me.TextBox1_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_4.Location = New System.Drawing.Point(137, 172)
        Me.TextBox1_4.Name = "TextBox1_4"
        Me.TextBox1_4.ReadOnly = True
        Me.TextBox1_4.Size = New System.Drawing.Size(120, 26)
        Me.TextBox1_4.TabIndex = 37
        Me.TextBox1_4.Text = "0.00"
        '
        'TextBox1_3
        '
        Me.TextBox1_3.BackColor = System.Drawing.Color.White
        Me.TextBox1_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_3.Location = New System.Drawing.Point(137, 144)
        Me.TextBox1_3.Name = "TextBox1_3"
        Me.TextBox1_3.ReadOnly = True
        Me.TextBox1_3.Size = New System.Drawing.Size(120, 26)
        Me.TextBox1_3.TabIndex = 36
        Me.TextBox1_3.Text = "0.00"
        '
        'TextBox1_2
        '
        Me.TextBox1_2.BackColor = System.Drawing.Color.White
        Me.TextBox1_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_2.Location = New System.Drawing.Point(137, 116)
        Me.TextBox1_2.Name = "TextBox1_2"
        Me.TextBox1_2.ReadOnly = True
        Me.TextBox1_2.Size = New System.Drawing.Size(120, 26)
        Me.TextBox1_2.TabIndex = 35
        Me.TextBox1_2.Text = "0.00"
        '
        'TextBox1_1
        '
        Me.TextBox1_1.BackColor = System.Drawing.Color.White
        Me.TextBox1_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1_1.Location = New System.Drawing.Point(137, 88)
        Me.TextBox1_1.Name = "TextBox1_1"
        Me.TextBox1_1.ReadOnly = True
        Me.TextBox1_1.Size = New System.Drawing.Size(120, 26)
        Me.TextBox1_1.TabIndex = 34
        Me.TextBox1_1.Text = "0.00"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(264, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 16)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Tarjetas Créditos"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(264, 149)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(168, 16)
        Me.Label18.TabIndex = 50
        Me.Label18.Text = "Tarjetas Débitos"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox14
        '
        Me.TextBox14.BackColor = System.Drawing.Color.White
        Me.TextBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(393, 116)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(120, 26)
        Me.TextBox14.TabIndex = 16
        Me.TextBox14.Text = "0.00"
        '
        'TextBox15
        '
        Me.TextBox15.BackColor = System.Drawing.Color.White
        Me.TextBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15.Location = New System.Drawing.Point(393, 144)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(120, 26)
        Me.TextBox15.TabIndex = 17
        Me.TextBox15.Text = "0.00"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(264, 177)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 16)
        Me.Label19.TabIndex = 51
        Me.Label19.Text = "Total Tarjetas"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox16
        '
        Me.TextBox16.BackColor = System.Drawing.Color.White
        Me.TextBox16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox16.Location = New System.Drawing.Point(393, 172)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.ReadOnly = True
        Me.TextBox16.Size = New System.Drawing.Size(120, 26)
        Me.TextBox16.TabIndex = 18
        Me.TextBox16.Text = "0.00"
        '
        'TextBox17
        '
        Me.TextBox17.BackColor = System.Drawing.Color.White
        Me.TextBox17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox17.Location = New System.Drawing.Point(393, 88)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.ReadOnly = True
        Me.TextBox17.Size = New System.Drawing.Size(120, 26)
        Me.TextBox17.TabIndex = 15
        Me.TextBox17.Text = "0.00"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(264, 93)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(128, 16)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "Total Efectivos"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox18
        '
        Me.TextBox18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox18.Location = New System.Drawing.Point(120, 16)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(80, 26)
        Me.TextBox18.TabIndex = 0
        Me.TextBox18.Text = "0"
        Me.TextBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox19
        '
        Me.TextBox19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox19.Location = New System.Drawing.Point(120, 48)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(80, 26)
        Me.TextBox19.TabIndex = 1
        Me.TextBox19.Text = "0"
        Me.TextBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(-16, 24)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(136, 16)
        Me.Label21.TabIndex = 54
        Me.Label21.Text = "Tasa de Dollar.....:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(-16, 48)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(136, 16)
        Me.Label22.TabIndex = 55
        Me.Label22.Text = "Tada de Euro.....:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button4.Location = New System.Drawing.Point(274, 370)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 80)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "&Calcular Efectivo"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TextBox20
        '
        Me.TextBox20.BackColor = System.Drawing.Color.White
        Me.TextBox20.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox20.Location = New System.Drawing.Point(272, 320)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(232, 32)
        Me.TextBox20.TabIndex = 53
        Me.TextBox20.Text = "0.00"
        Me.TextBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(264, 208)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(248, 152)
        Me.Label23.TabIndex = 52
        Me.Label23.Text = "TOTAL DE EFECTIVO EN LA CAJA"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(776, 370)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 80)
        Me.Button1.TabIndex = 78
        Me.Button1.Text = "&Cerrar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(386, 370)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 80)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "&Guardar e Imprimir"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(672, 64)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(80, 16)
        Me.Label25.TabIndex = 86
        Me.Label25.Text = "Hasta"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(552, 64)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(80, 16)
        Me.Label26.TabIndex = 85
        Me.Label26.Text = "Desde"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button5
        '
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(768, 8)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(56, 72)
        Me.Button5.TabIndex = 82
        Me.Button5.Text = "&Filtrar"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'fld_hasta
        '
        Me.fld_hasta.CustomFormat = "dd - MMM - yyyy"
        Me.fld_hasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fld_hasta.Location = New System.Drawing.Point(672, 80)
        Me.fld_hasta.Name = "fld_hasta"
        Me.fld_hasta.Size = New System.Drawing.Size(152, 23)
        Me.fld_hasta.TabIndex = 81
        '
        'fld_desde
        '
        Me.fld_desde.CustomFormat = "dd - MMM - yyyy"
        Me.fld_desde.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fld_desde.Location = New System.Drawing.Point(552, 80)
        Me.fld_desde.Name = "fld_desde"
        Me.fld_desde.Size = New System.Drawing.Size(152, 23)
        Me.fld_desde.TabIndex = 80
        '
        'LV
        '
        Me.LV.ContextMenu = Me.ContextMenu1
        Me.LV.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV.Location = New System.Drawing.Point(552, 112)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(328, 248)
        Me.LV.TabIndex = 79
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Imprimir Cuadre en TICKET"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "-"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Detalle de Venta"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "Detalle de Salida Caja"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        Me.MenuItem5.Text = "Detalle de Ingreso Caja"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 5
        Me.MenuItem6.Text = "Detalle de Recibo de Cobro"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(552, 370)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 80)
        Me.Button2.TabIndex = 93
        Me.Button2.Text = "Cerrar Turno"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.Visible = False
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.SteelBlue
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label27.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(0, 460)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(530, 32)
        Me.Label27.TabIndex = 47
        Me.Label27.Text = "Arqueo de Caja"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fld_efectivo_inicio_caja
        '
        Me.fld_efectivo_inicio_caja.BackColor = System.Drawing.Color.White
        Me.fld_efectivo_inicio_caja.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_efectivo_inicio_caja.Location = New System.Drawing.Point(672, 384)
        Me.fld_efectivo_inicio_caja.Name = "fld_efectivo_inicio_caja"
        Me.fld_efectivo_inicio_caja.ReadOnly = True
        Me.fld_efectivo_inicio_caja.Size = New System.Drawing.Size(104, 32)
        Me.fld_efectivo_inicio_caja.TabIndex = 96
        Me.fld_efectivo_inicio_caja.Text = "0.00"
        Me.fld_efectivo_inicio_caja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.fld_efectivo_inicio_caja.Visible = False
        '
        'frmCajaArqueo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(530, 492)
        Me.Controls.Add(Me.fld_efectivo_inicio_caja)
        Me.Controls.Add(Me.TextBox20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TextBox17)
        Me.Controls.Add(Me.TextBox16)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.fld_hasta)
        Me.Controls.Add(Me.fld_desde)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.TextBox19)
        Me.Controls.Add(Me.TextBox18)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1_13)
        Me.Controls.Add(Me.TextBox1_12)
        Me.Controls.Add(Me.TextBox1_11)
        Me.Controls.Add(Me.TextBox1_10)
        Me.Controls.Add(Me.TextBox1_9)
        Me.Controls.Add(Me.TextBox1_8)
        Me.Controls.Add(Me.TextBox1_7)
        Me.Controls.Add(Me.TextBox1_6)
        Me.Controls.Add(Me.TextBox1_5)
        Me.Controls.Add(Me.TextBox1_4)
        Me.Controls.Add(Me.TextBox1_3)
        Me.Controls.Add(Me.TextBox1_2)
        Me.Controls.Add(Me.TextBox1_1)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label23)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCajaArqueo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ARQUEO DE CAJA"
        Me.ResumeLayout(False)

    End Sub

#End Region

    

    Private Sub frmCajaArqueo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        
    End Sub

  
    Private Function guardarDocumento() As Integer
        NON_QUERY("INSERT INTO cajaarqueo ( `fld_fecha`, `fld_estacion`, `fld_usuario`, `TextBox1`, `TextBox2`, `TextBox3`, `TextBox4`, `TextBox5`, `TextBox6`,  `TextBox7`, `TextBox8`, `TextBox9`, `TextBox10`, `TextBox11`, `TextBox12`, `TextBox13`, `TextBox1_1`, `TextBox1_2`,  `TextBox1_3`, `TextBox1_4`, `TextBox1_5`, `TextBox1_6`, `TextBox1_7`, `TextBox1_8`, `TextBox1_9`, `TextBox1_10`,  `TextBox1_11`, `TextBox1_12`, `TextBox1_13`, `TextBox14`, `TextBox15`, `TextBox16`, `TextBox17`) values( Now(), 'Caja', '" & User(0) & "', " & CDbl(TextBox1.Text) & ", " & CDbl(TextBox2.Text) & ", " & CDbl(TextBox3.Text) & ", " & CDbl(TextBox4.Text) & ", " & CDbl(TextBox5.Text) & ", " & CDbl(TextBox6.Text) & ", " & CDbl(TextBox7.Text) & ", " & CDbl(TextBox8.Text) & ", " & CDbl(TextBox9.Text) & ", " & CDbl(TextBox10.Text) & ", " & CDbl(TextBox11.Text) & ", " & CDbl(TextBox12.Text) & ", " & CDbl(TextBox13.Text) & ", " & CDbl(TextBox1_1.Text) & ", " & CDbl(TextBox1_2.Text) & ",  " & CDbl(TextBox1_3.Text) & ", " & CDbl(TextBox1_4.Text) & ", " & CDbl(TextBox1_5.Text) & ", " & CDbl(TextBox1_6.Text) & ", " & CDbl(TextBox1_7.Text) & ", " & CDbl(TextBox1_8.Text) & ", " & CDbl(TextBox1_9.Text) & ", " & CDbl(TextBox1_10.Text) & ",  " & CDbl(TextBox1_11.Text) & ", " & CDbl(TextBox1_12.Text) & ", " & CDbl(TextBox1_13.Text) & ", " & CDbl(TextBox14.Text) & ", " & CDbl(TextBox15.Text) & ", " & CDbl(TextBox16.Text) & ", " & CDbl(TextBox17.Text) & ")")
        guardarDocumento = SCALAR_NUM("SELECT MAX(fld_id) FROM cajaarqueo")
    End Function

    Private Sub Imprimir(ByVal IdDoc As Integer)

        PrintDialog.AllowSomePages = True
        PrintDialog.ShowHelp = True
        PrintDialog.Document = docToPrint
        Dim result As DialogResult = PrintDialog.ShowDialog()

        If (result = Windows.Forms.DialogResult.OK) Then

            Dim pd As New PrintDocument, strOldPrinter As String
            strOldPrinter = pd.PrinterSettings.PrinterName 'Get the Default Print


            Dim WshNetwork As Object
            WshNetwork = Microsoft.VisualBasic.CreateObject("WScript.Network")
            WshNetwork.SetDefaultPrinter(PrintDialog.PrinterSettings.PrinterName) 'Set the Default Print
            Dim ds As New DataSet

            Dim daProf As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daProf.Fill(ds, "tbl_profiledocument")

            Dim daClientes As New MySqlDataAdapter("SELECT * FROM cajaarqueo WHERE fld_id=" & IdDoc & "", conn)
            daClientes.Fill(ds, "cajaarqueo")

            Dim Report As New rptCajaArqueo
            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PrinterName = PrintDialog.PrinterSettings.PrinterName
            Report.PrintToPrinter(PrintDialog.PrinterSettings.Copies, True, PrintDialog.PrinterSettings.FromPage, PrintDialog.PrinterSettings.ToPage)

            WshNetwork.SetDefaultPrinter(strOldPrinter) 'Get the Default Print

        End If



    End Sub


    Private Sub LV_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.DoubleClick
        If CBool(IniFile_Ventas.GetString("CAJA", "VerCuadre", "False")) = True Then
            If User(1) <> "ADMINISTRADOR" Then
                Exit Sub
            End If
        End If
        Id = LV.FocusedItem.Text
        fld_efectivo_inicio_caja.Text = SCALAR_NUM("SELECT fld_monto_abrio_caja FROM rest_tbl_turno WHERE fld_id=" & Id & "")
        TextBox20.Text = SCALAR_NUM("SELECT fld_monto_cerro_caja FROM rest_tbl_turno WHERE fld_id=" & Id & "")
        Me.Text = "ACEPTAR"
        Me.Close()
    End Sub

    Private Sub LV_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LV.KeyDown
        If e.KeyCode = Keys.Enter Then
            If CBool(IniFile_Ventas.GetString("CAJA", "VerCuadre", "False")) = True Then
                If User(1) <> "ADMINISTRADOR" Then
                    Exit Sub
                End If
            End If
            Id = LV.FocusedItem.Text
            fld_efectivo_inicio_caja.Text = SCALAR_NUM("SELECT fld_monto_abrio_caja FROM rest_tbl_turno WHERE fld_id=" & Id & "")
            TextBox20.Text = SCALAR_NUM("SELECT fld_monto_cerro_caja FROM rest_tbl_turno WHERE fld_id=" & Id & "")
            Me.Text = "ACEPTAR"
            Me.Close()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If



    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox8.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox9.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox10.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox11_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox11.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox12_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox12.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox13_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox13.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox14_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox14.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox15_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox15.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox16_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox16.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox17_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox17.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1_1.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1_2.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1_3.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1_4.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1_5.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1_6.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1_7.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1_8.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1_9.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1_10.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_11_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1_11.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_12_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1_12.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_13_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1_13.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub




    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(TextBox1.Text) = "" Then
                TextBox1.Text = 0
            Else
                TextBox1_1.Text = Format(CDbl(TextBox1.Text) * 2000, "##,##0.00")
            End If
        End If
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(TextBox2.Text) = "" Then
                TextBox2.Text = 0
            Else
                TextBox1_2.Text = Format(CDbl(TextBox2.Text) * 1000, "##,##0.00")
            End If
        End If
    End Sub

    Private Sub TextBox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(TextBox3.Text) = "" Then
                TextBox3.Text = 0
            Else
                TextBox1_3.Text = Format(CDbl(TextBox3.Text) * 500, "##,##0.00")
            End If
        End If
    End Sub

    Private Sub TextBox4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(TextBox4.Text) = "" Then
                TextBox4.Text = 0
            Else
                TextBox1_4.Text = Format(CDbl(TextBox4.Text) * 200, "##,##0.00")
            End If
        End If
    End Sub

    Private Sub TextBox5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox5.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(TextBox5.Text) = "" Then
                TextBox5.Text = 0
            Else
                TextBox1_5.Text = Format(CDbl(TextBox5.Text) * 100, "##,##0.00")
            End If
        End If
    End Sub

    Private Sub TextBox6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox6.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(TextBox6.Text) = "" Then
                TextBox6.Text = 0
            Else
                TextBox1_6.Text = Format(CDbl(TextBox6.Text) * 50, "##,##0.00")
            End If
        End If
    End Sub

    Private Sub TextBox7_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox7.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(TextBox7.Text) = "" Then
                TextBox7.Text = 0
            Else
                TextBox1_7.Text = Format(CDbl(TextBox7.Text) * 25, "##,##0.00")
            End If
        End If
    End Sub

    Private Sub TextBox8_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox8.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(TextBox8.Text) = "" Then
                TextBox8.Text = 0
            Else
                TextBox1_8.Text = Format(CDbl(TextBox8.Text) * 20, "##,##0.00")
            End If
        End If
    End Sub

    Private Sub TextBox9_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox9.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(TextBox9.Text) = "" Then
                TextBox9.Text = 0
            Else
                TextBox1_9.Text = Format(CDbl(TextBox9.Text) * 10, "##,##0.00")
            End If
        End If
    End Sub

    Private Sub TextBox10_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox10.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(TextBox10.Text) = "" Then
                TextBox10.Text = 0
            Else
                TextBox1_10.Text = Format(CDbl(TextBox10.Text) * 5, "##,##0.00")
            End If
        End If
    End Sub

    Private Sub TextBox11_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox11.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(TextBox11.Text) = "" Then
                TextBox11.Text = 0
            Else
                TextBox1_11.Text = Format(CDbl(TextBox11.Text) * 1, "##,##0.00")
            End If
        End If
    End Sub

    Private Sub TextBox12_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox12.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(TextBox12.Text) = "" Then
                TextBox12.Text = 0
            Else
                If Trim(TextBox18.Text) = "" Then
                    TextBox18.Text = 0
                End If
                TextBox1_12.Text = Format(CDbl(TextBox12.Text) * CDbl(TextBox18.Text), "##,##0.00")
            End If
        End If
    End Sub

    Private Sub TextBox13_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox13.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(TextBox13.Text) = "" Then
                TextBox13.Text = 0
            Else
                If Trim(TextBox19.Text) = "" Then
                    TextBox19.Text = 0
                End If
                TextBox1_13.Text = Format(CDbl(TextBox13.Text) * CDbl(TextBox19.Text), "##,##0.00")
            End If
        End If
    End Sub


    Private Sub TextBox18_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox18.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox18_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox18.KeyDown

    End Sub

    Private Sub TextBox19_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox19.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox19_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox19.KeyDown

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox17.Text = Format(CDbl(TextBox1_1.Text) + CDbl(TextBox1_2.Text) + CDbl(TextBox1_3.Text) + CDbl(TextBox1_4.Text) + CDbl(TextBox1_5.Text) + CDbl(TextBox1_6.Text) + CDbl(TextBox1_7.Text) + CDbl(TextBox1_8.Text) + CDbl(TextBox1_9.Text) + CDbl(TextBox1_10.Text) + CDbl(TextBox1_11.Text) + CDbl(TextBox1_12.Text) + CDbl(TextBox1_13.Text), "##,##0.00")


        TextBox16.Text = Format(CDbl(TextBox14.Text) + CDbl(TextBox15.Text), "##,##0.00")

        TextBox20.Text = Format(CDbl(TextBox17.Text) + CDbl(TextBox16.Text), "##,##0.00")
    End Sub



    Private Sub TextBox14_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox14.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim amount As Decimal = CType(TextBox14.Text, Decimal)
            Me.TextBox14.Text = String.Format("{0:n2}", amount)

        End If
    End Sub

    Private Sub TextBox15_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox15.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim amount As Decimal = CType(TextBox15.Text, Decimal)
            Me.TextBox15.Text = String.Format("{0:n2}", amount)

        End If
    End Sub




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim IdDoc As Integer = guardarDocumento()

        Imprimir(IdDoc)


    End Sub

    Private Sub TextBox20_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox20.GotFocus
        TextBox20.SelectAll()
    End Sub


    Private Sub TextBox20_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox20.MouseDown
        TextBox20.SelectAll()
    End Sub

    Private Sub fld_user_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub



    Private Sub TextBox20_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox20.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub


    Private Sub frmCajaArqueo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class
