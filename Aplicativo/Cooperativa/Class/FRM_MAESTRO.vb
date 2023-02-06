Module FRM_MAESTRO

#Region "ADMINISTRACION"


    Friend Function FRMS_POPUP_CLIENTES(ByVal tipo As String) As Boolean

        Try

            
            Dim F As New FRM_POPUP_CLIENTES
            If tipo = "TODOS" Then
                F.Text = "Listos General de  Socios"
            ElseIf tipo = "CLIENTES" Then
                F.Text = "Lista de Clientes"
            ElseIf tipo = "SEGUROS" Then
                F.Text = "Lista de Clientes Seguros"
            ElseIf tipo = "EMPLEADOS" Then
                F.Text = "Lista de Clientes Empleados"
            ElseIf tipo = "MEDICOS" Then
                F.Text = "Lista de Clientes Médicos"
            End If
            F.ShowDialog()
            If F.Text = "ACEPTAR" Then
                Return True
            Else
                Return False
            End If
            F.Dispose()


        Catch ex As Exception
            Alerta(ex.Message)
        End Try

    End Function
    Friend Sub FRMS_CLIENTES()
        Try

            
            Dim F As New FRM_CLIENTES
            F.MdiParent = FRM_DEFAULT.GlobalForm
            F.Show()




        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Sub
    
    Friend Function FRMS_CLAVE_MAESTRA(ByVal tipo As String) As Boolean

        Try

            
            Dim F As New Frm_Pide_Calve
            F.Text = tipo
            F.ShowDialog()
            If F.Text = "ACEPTAR" Then
                F.Dispose()
                Return True
            Else
                F.Dispose()
                Return False
            End If



        Catch ex As Exception
            Alerta(ex.Message)
        End Try

    End Function
    Friend Function FRMS_LOGIN() As Boolean

        Try

            
            Dim F As New FRM_LOGIN
            F.ShowDialog()
            If F.Text = "ACEPTAR" Then
                F.Dispose()
                Return True
            Else
                F.Dispose()
                Return False
            End If



        Catch ex As Exception
            Alerta(ex.Message)
        End Try

    End Function

    Friend Sub FRMS_MAESTRO_ZONAS()
        Try

            
            Dim F As New FRM_MAESTRO_ZONAS
            F.MdiParent = FRM_DEFAULT.GlobalForm
            F.Show()



        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Sub
    Friend Sub FRMS_MAESTRO_VENDEDORES()
        Try

            
            Dim F As New FRM_MAESTRO_VENDEDORES
            F.MdiParent = FRM_DEFAULT.GlobalForm
            F.Show()



        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Sub


#End Region

#Region "CONTABILIDAD"

    Friend Sub FrmsCatalagoCuentasContable()
        Try

            Dim F As New frmCrearCtaContable
            F.ShowDialog()
            F.Dispose()
        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Sub
    Friend Sub frmsTipoTransaccion()
        Try

            Dim F As New frmTipoTransaccion
            F.ShowDialog()
            F.Dispose()
        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Sub
    Friend Function FrmTrasacciones()
        Try


            Dim F As New frmTransacciones

            F.ShowDialog()

            F.Dispose()


        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Function

    Friend Function frmsConsultaTrasacciones() As Boolean

        Dim F As New frmConsultaTransacciones
        F.ShowDialog()
        If F.Text = "ACEPTAR" Then
            Return True
        Else
            Return False
        End If
        F.Dispose()

    End Function

    Friend Sub frmsConfiguracionBceGeneral()
        Try
 
            Dim F As New frmConfiguracionBceGeneral
            F.ShowDialog()
            F.Dispose()
 
        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Sub

    Friend Sub frmsConfiguracionEstadoResultado()
        Dim F As New frmConfiguracionEstadoResultado
        F.ShowDialog()
        F.Dispose()
    End Sub

    Friend Sub FRMS_PROFILE_CONTABILIDAD()
        Try


            Dim F As New FRM_PROFILE_CONTABILIDAD
            F.ShowDialog()
            F.Dispose()

        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Sub
    Friend Function frmsListaCatalogoCuentaContable() As Boolean
        Try


            Dim F As New frmListaCatalogoCuentaContable
            F.ShowDialog()
            If F.Text = "ACEPTAR" Then
                F.Dispose()
                Return True
            Else
                F.Dispose()
                Return False
            End If



        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Function
    Friend Function FRMS_LIST_ND_NC_CXC(ByVal Tipo As String) As Boolean

        Try


            Dim F As New FRM_LIST_ND_NC_CXC
            If Tipo = "NC" Then
                F.Text = "Lista de Nota de Crédito CXC"
            Else
                F.Text = "Lista de Nota de Débito CXC"
            End If
            F.ShowDialog()
            If F.Text = "ACEPTAR" Then
                Return True
            Else
                Return False
            End If
            F.Dispose()


        Catch ex As Exception
            Alerta(ex.Message)
        End Try

    End Function


#End Region

#Region "BANCO"

    Friend Sub FRMS_DIARIOBANCO(ByVal Type As String)
        Try


            Dim F As New FRM_DIARIO_BANCO

            F.Text = Type
            If Type = "Depósito Bancario" Then
                F.cbAfectaCaja.Visible = True
            End If
            F.MdiParent = FRM_DEFAULT.GlobalForm
            F.Show()

        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Sub
    Friend Function FRMS_DIARIO_BANCO_LIST(ByVal TIPO As String, ByVal id_banco As String, ByVal banco As String) As Boolean




        Dim F As New FRM_DIARIO_BANCO_LIST
        F.Text = TIPO
        F.fld_id_banco.Text = id_banco
        F.lbl_banco.Text = banco
        F.LBL_TITLE.Text = TIPO
        F.ShowDialog()

        If F.Text = "ACEPTAR" Then
            Return True
        Else
            Return False
        End If
        F.Dispose()




    End Function
    Friend Sub FRMS_MAESTRO_CK(ByVal Type As String)
        Try


            Dim F As New FRM_MAESTRO_CKS
            If Type = "S" Then
                F.Text = "Maestro de Cheques (SOLICITUD)"
            Else
                F.Text = "Maestro de Cheques (EMISION)"
            End If
            F.MdiParent = FRM_DEFAULT.GlobalForm
            F.Show()

        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Sub
    Friend Function FRMS_LIST_CK(ByVal Type As String) As Boolean




        Dim F As New FRM_LIST_CK
        If Type = "S" Then
            F.Text = "Solicitudes de cheques"
        Else
            F.Text = "Cheques emitidos"
        End If
        F.ShowDialog()

        If F.Text = "ACEPTAR" Then
            Return True
        Else
            Return False
        End If
        F.Dispose()




    End Function
    Friend Sub FRMS_BENEFICIARIOS()
        Try


            Dim F As New FRM_BENEFICIARIOS
            F.ShowDialog()
            F.Dispose()


        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Sub

    Friend Sub FRMS_MAESTRO_BANCOS()
        Try


            Dim F As New FRM_BANCO_MAESTRO

            F.ShowDialog()
            F.Dispose()

        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Sub
    Friend Function FRMS_LIST_BANCOS() As Boolean




        Dim F As New FRM_LIST_BANCO
        F.ShowDialog()

        If F.Text = "ACEPTAR" Then
            Return True
        Else
            Return False
        End If
        F.Dispose()




    End Function

    Friend Sub FRMS_CONCILIACION(ByVal banco_id As String)
        Try


            Dim F As New FRM_CONCILIACION
            F.fld_id_banco.Text = banco_id
            F.MdiParent = FRM_DEFAULT.GlobalForm
            F.Show()

        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Sub
    Friend Function FRMS_CONCILIACION_LISTA(ByVal ID_BANCO As String, ByVal title As String) As Boolean

        Try


            Dim F As New FRM_CONCILIACION_LISTA
            F.fld_id_banco.Text = ID_BANCO
            F.Text = title
            F.ShowDialog()
            If F.Text = "ACEPTAR" Then
                Return True
            Else
                Return False
            End If
            F.Dispose()


        Catch ex As Exception
            Alerta(ex.Message)
        End Try

    End Function

    Friend Sub FRMS_SELECCIONAR_DOC_TRANSITOS(ByVal banco_id As String)

        Try


            Dim F As New FRM_SELECCIONAR_DOC_TRANSITOS
            F.fld_id_banco.Text = banco_id
            F.ShowDialog()
            F.Dispose()


        Catch ex As Exception
            Alerta(ex.Message)
        End Try

    End Sub

    Friend Function FRMS_POPUP_STATUS() As String

        Try


            Dim F As New FRM_POPUP_STATUS, S As String
            F.ShowDialog()
            S = F.Text
            F.Dispose()

            Return S




        Catch ex As Exception
            Alerta(ex.Message)
        End Try

    End Function

#End Region

#Region "CXC"

    Friend Sub FRMS_RECIBO_INGRESO(ByVal id_cliente As String)
        Try


            Dim F As New FRM_RECIBO_INGRESO
            F.txtCustomerID.Text = id_cliente
            F.MdiParent = FRM_DEFAULT.GlobalForm
            F.Show()



        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Sub

    Friend Function FRMS_LISTA_RECIBOS_INGRESOS()

        Try

            Dim F As New FRM_LIST_RECIBOS_INGRESOS
            F.ShowDialog()
            F.Dispose()


        Catch ex As Exception
            Alerta(ex.Message)
        End Try


    End Function

    Friend Sub FRMS_ND_NC_CXC(ByVal Tipo As String)
        Try


            Dim F As New FRM_ND_CXC
            If Tipo = "NC" Then
                F.Text = "Nota de Crédito CXC"
            Else
                F.Text = "Nota de Débito CXC"
            End If
            F.MdiParent = FRM_DEFAULT.GlobalForm
            F.Show()



        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Sub
    Friend Sub FRMS_NC_CXC()
        Try


            Dim F As New FRM_NC_CXC
            F.MdiParent = FRM_DEFAULT.GlobalForm
            F.Show()



        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Sub
    Friend Function FRMS_LIST_ND_NC_CXC(ByVal Tipo As String, ByVal doc_tipe As String) As Boolean

        Try


            Dim F As New FRM_LIST_ND_NC_CXC
            F.fld_tipo_doc.Text = doc_tipe
            If Tipo = "NC" Then
                F.Text = "Lista de Nota de Crédito CXC"
            Else
                F.Text = "Lista de Nota de Débito CXC"
            End If
            F.ShowDialog()
            If F.Text = "ACEPTAR" Then
                Return True
            Else
                Return False
            End If
            F.Dispose()


        Catch ex As Exception
            Alerta(ex.Message)
        End Try

    End Function

    Friend Sub FRMS_POPUP_FECHA_VENCIMIENTO()
        Try


            Dim F As New FRM_POPUP_FECHA1
            F.ShowDialog()
            F.Dispose()


        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Sub

#End Region

#Region "CXP"

    Friend Function FRMS_LIST_ND_NC_CXP(ByVal Tipo As String) As Boolean

        Try


            Dim F As New FRM_LIST_ND_NC_CXP
            If Tipo = "NC" Then
                F.Text = "Lista de Nota de Crédito CXP"
            Else
                F.Text = "Lista de Nota de Débito CXP"
            End If
            F.ShowDialog()
            If F.Text = "ACEPTAR" Then
                Return True
            Else
                Return False
            End If
            F.Dispose()


        Catch ex As Exception
            Alerta(ex.Message)
        End Try

    End Function

    Friend Function FRMS_POPUP_PROVEEDORES() As Boolean

        'Try


        Dim F As New FRM_POPUP_PROVEEDORES
        F.ShowDialog()
        If F.Text = "ACEPTAR" Then
            Return True
        Else
            Return False
        End If
        F.Dispose()


        'Catch ex As Exception
        '    Alerta(ex.Message)
        'End Try

    End Function

#End Region

#Region "REPORTES"

    Friend Function FRMS_POPUP_FECHAS() As Boolean
        Try


            Dim F As New FRM_POPUP_FECHAS
            F.ShowDialog()
            If F.Text = "ACEPTAR" Then
                Return True
            End If
            F.Dispose()


        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Function

    Friend Sub FRMS_REPORTES_NO_FECHA(ByVal REPNAME As String)
        Try
            ReportName = REPNAME

            Dim F As New FRM_REPORTS
            F.ShowDialog()
            F.Dispose()


        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Sub

    Friend Sub FRMS_REPORTES_CON_FECHA(ByVal REPNAME As String)

        If FRMS_POPUP_FECHAS() = True Then
            ReportName = REPNAME

            Dim rep As New FRM_REPORTS
            rep.Show()
        End If

    End Sub

#End Region

#Region "PRESTAMO"


    Friend Sub FRMS_MAESTRO_PRESTAMOS()
        Try


            Dim F As New FRM_PRESTAMO_MAESTRO
            F.MdiParent = FRM_DEFAULT.GlobalForm
            F.Show()



        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Sub
    Friend Function FRMS_LIST_PRESTAMOS() As Boolean
        Try


            Dim F As New FRM_LIST_PRESTAMOS
            F.ShowDialog()
            If F.Text = "ACEPTAR" Then
                Return True
            Else
                Return False
            End If
            F.Dispose()


        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Function
    Friend Function FRMS_LIST_PRESTAMOS_CUOTAS(ByVal id_prestamos As String) As Boolean
        Try


            Dim F As New FRM_LIST_PRESTAMOS_CUOTAS
            F.ID_DEL_PRESTAMOS = id_prestamos
            F.ShowDialog()
            If F.Text = "ACEPTAR" Then
                Return True
            Else
                Return False
            End If
            F.Dispose()


        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Function
    Friend Function FRMS_LIST_PRESTAMOS_POR_CLIENTE(ByVal nombre As String, ByVal id_cliente As String) As Boolean
        Try


            Dim F As New FRM_LIST_PRESTAMOS_POR_CLIENTE
            F.Text = nombre
            F.fld_id.Text = id_cliente
            F.ShowDialog()
            If F.Text = "ACEPTAR" Then
                Return True
            Else
                Return False
            End If
            F.Dispose()


        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Function


#End Region

#Region "CERTIFICADOS"
    Friend Function FRMS_LIST_CERTIFICADO() As Boolean
        Try


            Dim F As New frmListaCertificado
            F.ShowDialog()
            If F.Text = "ACEPTAR" Then
                Return True
            Else
                Return False
            End If
            F.Dispose()


        Catch ex As Exception
            Alerta(ex.Message)
        End Try

    End Function

#End Region

#Region "AHORROS"

    Friend Function frmsListaCuentaAhorro() As Boolean
        Try


            Dim F As New frmListaCuentaAhorro
            F.ShowDialog()
            If F.Text = "ACEPTAR" Then
                Return True
            Else
                Return False
            End If
            F.Dispose()


        Catch ex As Exception
            Alerta(ex.Message)
        End Try

    End Function

    Friend Function frmDepositosLista() As Boolean
        Try


            Dim F As New frmDespositosLista
            F.ShowDialog()
            If F.Text = "ACEPTAR" Then
                Return True
            Else
                Return False
            End If
            F.Dispose()


        Catch ex As Exception
            Alerta(ex.Message)
        End Try

    End Function

#End Region

    Friend Function Alerta(ByVal textto As String) As Boolean
        Dim Valor As Boolean = False
        Dim f As New FRM_ALERTA
        f.Label1.Text = textto
        f.ShowDialog()
        If f.Text = "ACEPTAR" Then
            f.Dispose()
            Valor = True
        End If
        Return Valor
    End Function

    Friend Sub FRMS_PROFILE_DOC()
        Try


            Dim F As New FRM_PROFILE_DOC
            F.ShowDialog()
            F.Dispose()


        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Sub

    Friend Sub FRMS_USER_SYSTEM()
        ' Try


        Dim F As New FRM_USER_SYSTEM
        F.MdiParent = FRM_DEFAULT.GlobalForm
        F.Show()



        ' Catch ex As Exception
        '    Alerta(ex.Message)
        'End Try
    End Sub




End Module
