Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Drawing.Printing
Imports System.IO
Public Class frmConfiguracionBceGeneral
    Inherits System.Windows.Forms.Form
    Dim ds As DataSet
    Dim da As MySqlDataAdapter
    Dim Dv As DataView

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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DG As System.Windows.Forms.DataGrid
    Friend WithEvents BtnProcesar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbGrupo As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmConfiguracionBceGeneral))
        Me.Label1 = New System.Windows.Forms.Label
        Me.DG = New System.Windows.Forms.DataGrid
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbGrupo = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.BtnProcesar = New System.Windows.Forms.Button
        Me.BtnCancelar = New System.Windows.Forms.Button
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(392, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 23)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "BALANCE GENERAL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DG
        '
        Me.DG.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.DG.BackColor = System.Drawing.Color.White
        Me.DG.BackgroundColor = System.Drawing.Color.White
        Me.DG.CaptionBackColor = System.Drawing.Color.White
        Me.DG.CaptionFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.DG.CaptionForeColor = System.Drawing.Color.Navy
        Me.DG.CaptionVisible = False
        Me.DG.DataMember = ""
        Me.DG.ForeColor = System.Drawing.Color.Black
        Me.DG.GridLineColor = System.Drawing.Color.Black
        Me.DG.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DG.HeaderBackColor = System.Drawing.Color.Silver
        Me.DG.HeaderForeColor = System.Drawing.Color.Black
        Me.DG.LinkColor = System.Drawing.Color.Navy
        Me.DG.Location = New System.Drawing.Point(8, 56)
        Me.DG.Name = "DG"
        Me.DG.ParentRowsBackColor = System.Drawing.Color.White
        Me.DG.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DG.SelectionBackColor = System.Drawing.Color.Navy
        Me.DG.SelectionForeColor = System.Drawing.Color.White
        Me.DG.Size = New System.Drawing.Size(648, 256)
        Me.DG.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Grupo :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbGrupo
        '
        Me.cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGrupo.Items.AddRange(New Object() {"ACTIVOS", "PASIVOS", "CAPITAL"})
        Me.cmbGrupo.Location = New System.Drawing.Point(80, 8)
        Me.cmbGrupo.Name = "cmbGrupo"
        Me.cmbGrupo.Size = New System.Drawing.Size(200, 21)
        Me.cmbGrupo.TabIndex = 25
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(288, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 40)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "&Consultar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnProcesar
        '
        Me.BtnProcesar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnProcesar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnProcesar.ForeColor = System.Drawing.Color.Black
        Me.BtnProcesar.Image = CType(resources.GetObject("BtnProcesar.Image"), System.Drawing.Image)
        Me.BtnProcesar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnProcesar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnProcesar.Location = New System.Drawing.Point(512, 320)
        Me.BtnProcesar.Name = "BtnProcesar"
        Me.BtnProcesar.Size = New System.Drawing.Size(72, 56)
        Me.BtnProcesar.TabIndex = 40
        Me.BtnProcesar.Text = "&Guardar"
        Me.BtnProcesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnCancelar.ForeColor = System.Drawing.Color.Black
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnCancelar.Location = New System.Drawing.Point(584, 320)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(72, 56)
        Me.BtnCancelar.TabIndex = 39
        Me.BtnCancelar.Text = "&Cerrar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmConfiguracionBceGeneral
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(666, 379)
        Me.Controls.Add(Me.BtnProcesar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.DG)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbGrupo)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfiguracionBceGeneral"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance General"
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LlenarGrupo()
        Dim da As New MySqlDataAdapter("SELECT ID, Descripcion FROM tbl_catalogo_grupo WHERE ID IN(1,2,3) ORDER BY Descripcion", conn)
        Dim dt As New DataTable
        da.Fill(dt)

        cmbGrupo.DataSource = dt
        cmbGrupo.DisplayMember = "Descripcion"
        cmbGrupo.ValueMember = "ID"
    End Sub
    Private Sub Fill_DG()

        Dim sqlSearch = "SELECT ID, CuentaNo , Descripcion , Tipo , BalanceGeneral  FROM tbl_catalogo WHERE Grupo=" & cmbGrupo.SelectedValue & ""


        ds = New DataSet


        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, "tbl_catalogo")

        DG.DataSource = ds
        DG.DataMember = ds.Tables(0).TableName
        AddCustomDataTableStyle()
        'Instanciamos y creamos nuestro manejador
        Dim cm As CurrencyManager
        cm = CType(BindingContext(ds, ds.Tables(0).TableName), CurrencyManager)
        'Instanciamos y creamos un DataView asosiado a nuestro manejador CurrencyManager
        Dv = CType(cm.List, DataView)
        'Asignamos el valor que deseamos para evitar o permitir nuevos registros
        Dv.AllowNew = False

    End Sub
    Private Sub AddCustomDataTableStyle()
        ' Create a new DataGridTableStyle and set 
        ' its MappingName to the TableName of a DataTable. 
        DG.TableStyles.Clear()
        Dim ts1 As New DataGridTableStyle
        ts1.GridLineColor = Color.Tan

        ts1.MappingName = "tbl_catalogo"

        Dim TextCol As New DataGridTextBoxColumn
        TextCol.MappingName = "ID"
        TextCol.HeaderText = "ID"
        TextCol.Width = 25
        TextCol.ReadOnly = True
        TextCol.NullText = ""
        ts1.GridColumnStyles.Add(TextCol)

        Dim TextCol0 As New DataGridTextBoxColumn
        TextCol0.MappingName = "CuentaNo"
        TextCol0.HeaderText = "Cuenta No."
        TextCol0.Width = 85
        TextCol0.ReadOnly = True
        TextCol0.NullText = ""
        ts1.GridColumnStyles.Add(TextCol0)

        Dim TextCol1 As New DataGridTextBoxColumn
        TextCol1.MappingName = "Descripcion"
        TextCol1.HeaderText = "Descripción"
        TextCol1.Width = 400
        TextCol1.ReadOnly = True
        TextCol1.NullText = ""
        ts1.GridColumnStyles.Add(TextCol1)


        ' Add a second column style. 
        Dim TextCol2 As New DataGridTextBoxColumn
        TextCol2.MappingName = "Tipo"
        TextCol2.HeaderText = "Tipo"
        TextCol2.Width = 80
        TextCol2.ReadOnly = True
        TextCol2.NullText = ""
        ts1.GridColumnStyles.Add(TextCol2)

        ' Add a second column style. 
        Dim TextCol3 As New DataGridTextBoxColumn
        TextCol3.MappingName = "BalanceGeneral"
        TextCol3.HeaderText = "BG"
        TextCol3.Width = 33
        TextCol3.ReadOnly = False
        TextCol3.NullText = ""
        TextCol3.Alignment = HorizontalAlignment.Center
        ts1.GridColumnStyles.Add(TextCol3)

        ts1.RowHeadersVisible = False

        ' Add the DataGridTableStyle objects to the collection. 
        DG.GridLineColor.GetHashCode()
        DG.TableStyles.Add(ts1)

    End Sub
    Private Sub UPDATE_DATA()
        conn.Open()
        Dim cmd As New MySqlCommandBuilder(da)
        da.UpdateCommand = cmd.GetUpdateCommand
        da.Update(ds, "tbl_catalogo")
        ds.AcceptChanges()
        conn.Close()
        Alerta("Documento actualizado exitosamente")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Fill_DG()
    End Sub


    Private Sub BtnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProcesar.Click
        Try

            UPDATE_DATA()

        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Sub

    Private Sub BtnCancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub


    Private Sub frmConfiguracionBceGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        LlenarGrupo()
    End Sub
End Class
