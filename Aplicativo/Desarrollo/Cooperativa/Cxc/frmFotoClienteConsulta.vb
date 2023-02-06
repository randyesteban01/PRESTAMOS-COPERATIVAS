Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.IO
Public Class frmFotoClienteConsulta
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents buscarBtn As System.Windows.Forms.Button
    Friend WithEvents cerrarBtn As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFotoClienteConsulta))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.buscarBtn = New System.Windows.Forms.Button
        Me.cerrarBtn = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(29, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(328, 296)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'buscarBtn
        '
        Me.buscarBtn.BackColor = System.Drawing.SystemColors.Control
        Me.buscarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.buscarBtn.ForeColor = System.Drawing.Color.Black
        Me.buscarBtn.Image = CType(resources.GetObject("buscarBtn.Image"), System.Drawing.Image)
        Me.buscarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.buscarBtn.Location = New System.Drawing.Point(29, 323)
        Me.buscarBtn.Name = "buscarBtn"
        Me.buscarBtn.Size = New System.Drawing.Size(144, 56)
        Me.buscarBtn.TabIndex = 0
        Me.buscarBtn.Text = "&Buscar"
        Me.buscarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cerrarBtn
        '
        Me.cerrarBtn.BackColor = System.Drawing.SystemColors.Control
        Me.cerrarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cerrarBtn.ForeColor = System.Drawing.Color.Black
        Me.cerrarBtn.Image = CType(resources.GetObject("cerrarBtn.Image"), System.Drawing.Image)
        Me.cerrarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cerrarBtn.Location = New System.Drawing.Point(285, 323)
        Me.cerrarBtn.Name = "cerrarBtn"
        Me.cerrarBtn.Size = New System.Drawing.Size(72, 56)
        Me.cerrarBtn.TabIndex = 1
        Me.cerrarBtn.TabStop = False
        Me.cerrarBtn.Text = "&Cerrar"
        Me.cerrarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmFotoClienteConsulta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(386, 396)
        Me.Controls.Add(Me.buscarBtn)
        Me.Controls.Add(Me.cerrarBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFotoClienteConsulta"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Foto Socio"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Friend documento As String
    Private Sub frmFotoClienteConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
    End Sub

   
    'convertir binario a imágen
    Private Function Bytes_Imagen(ByVal Imagen As Byte()) As Image
        Try
            'si hay imagen
            If Not Imagen Is Nothing Then
                'caturar array con memorystream hacia Bin
                Dim Bin As New MemoryStream(Imagen)
                'con el método FroStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    'convertir imagen a binario
    Private Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        If Not Imagen Is Nothing Then
            'variable de datos binarios en stream(flujo)
            Dim Bin As New MemoryStream
            'convertir a bytes
            Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
            'retorna binario
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function

    Private Sub buscarFotoBD()
        Try
            Dim Sql As String = "select * from dbcoperativaimg.fotocliente where documento='" & documento & "'"
            Dim lector As MySqlDataReader

            conn.Open()
            If conn.State = ConnectionState.Open Then
                Dim Imag As Byte()
                Dim Comando As New MySqlCommand(Sql, conn)
                lector = Comando.ExecuteReader
                While lector.Read
                    Imag = lector("foto")
                    Me.PictureBox1.Image = Bytes_Imagen(Imag)

                End While
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub buscarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscarBtn.Click
        If FRMS_POPUP_CLIENTES("TODOS") = True Then
            Me.PictureBox1.Image = Nothing
            documento = SCALAR_STRING("SELECT fld_Identity FROM tbl_clientes WHERE fld_id=" & Id & "")
            buscarFotoBD()
        End If

    End Sub


    Private Sub cerrarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cerrarBtn.Click
        Me.Close()
    End Sub
End Class
