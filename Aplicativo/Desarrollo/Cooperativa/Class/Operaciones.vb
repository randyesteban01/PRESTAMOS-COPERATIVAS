Module Operaciones
    Public Function Calculacuota(ByVal Monto As Double, ByVal TasaAnual As Double, ByVal Plazo As Integer)
        Dim CuotaPagar As Double = 0
        Dim Periodo As Double = 0
        Dim R As Double
        Dim Interes As Double = 0
        TasaAnual = TasaAnual / 100

        Periodo = 12
        Interes = CDbl(TasaAnual) / 100 / 12

        R = (1 + TasaAnual / Periodo)

        CuotaPagar = Monto * (R - 1) / (1 - R ^ (-Plazo))

        Return CuotaPagar
    End Function

End Module
