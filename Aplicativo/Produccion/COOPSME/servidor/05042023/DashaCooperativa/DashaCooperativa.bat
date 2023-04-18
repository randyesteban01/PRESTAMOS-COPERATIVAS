@ECHO OFF 
taskkill /IM "Cooperativa.exe" /F
del C:\DashaCooperativa\Cooperativa.exe
xcopy "\\DESKTOP-JKEHT3L\dash\Cooperativa.exe" "C:\DashaCooperativa" /Y
start C:\DashaCooperativa\Cooperativa.exe
exit