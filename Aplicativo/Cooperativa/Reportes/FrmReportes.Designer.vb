<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportes
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
        Me.Vsr_Imprime = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'Vsr_Imprime
        '
        Me.Vsr_Imprime.ActiveViewIndex = -1
        Me.Vsr_Imprime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Vsr_Imprime.Cursor = System.Windows.Forms.Cursors.Default
        Me.Vsr_Imprime.DisplayToolbar = False
        Me.Vsr_Imprime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Vsr_Imprime.Location = New System.Drawing.Point(0, 0)
        Me.Vsr_Imprime.Name = "Vsr_Imprime"
        Me.Vsr_Imprime.Size = New System.Drawing.Size(769, 381)
        Me.Vsr_Imprime.TabIndex = 0
        Me.Vsr_Imprime.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FrmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 381)
        Me.Controls.Add(Me.Vsr_Imprime)
        Me.Name = "FrmReportes"
        Me.Text = "Reportes"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Vsr_Imprime As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
