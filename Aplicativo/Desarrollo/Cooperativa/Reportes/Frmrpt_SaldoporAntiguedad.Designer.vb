<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmrpt_SaldoporAntiguedad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmrpt_SaldoporAntiguedad))
        Me.CrVSaldoPorAntiguedad = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrVSaldoPorAntiguedad
        '
        Me.CrVSaldoPorAntiguedad.ActiveViewIndex = -1
        Me.CrVSaldoPorAntiguedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrVSaldoPorAntiguedad.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrVSaldoPorAntiguedad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrVSaldoPorAntiguedad.Location = New System.Drawing.Point(0, 0)
        Me.CrVSaldoPorAntiguedad.Name = "CrVSaldoPorAntiguedad"
        Me.CrVSaldoPorAntiguedad.ShowGroupTreeButton = False
        Me.CrVSaldoPorAntiguedad.Size = New System.Drawing.Size(614, 304)
        Me.CrVSaldoPorAntiguedad.TabIndex = 0
        '
        'Frmrpt_SaldoporAntiguedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 304)
        Me.Controls.Add(Me.CrVSaldoPorAntiguedad)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmrpt_SaldoporAntiguedad"
        Me.Text = "Saldo por Antiguedad"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrVSaldoPorAntiguedad As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
