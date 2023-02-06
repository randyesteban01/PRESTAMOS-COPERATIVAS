Module INI_VARIABLES

    Friend IniFile_Principal As New IniFile(AppPath & "\Settings.ini") '/INI FILE
    Friend IniFile_Ventas As New IniFile(AppPath & "\Settings_Ventas.ini")  '/INI FILE
    Friend IniFile_Contabilidad As New IniFile(AppPath & "\Settings_Contabilidad.ini")  '/INI FILE
    Friend cta_contable_selecionada As String, cta_contable_selecionada1 As String

End Module
