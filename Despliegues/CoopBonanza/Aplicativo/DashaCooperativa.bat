@ECHO OFF 
taskkill /IM "Dasha.exe" /F
del C:\Dasha\Dasha.exe
xcopy "\\servidor\Dash\DASHA.exe" "C:\Dasha" /Y
start C:\Dasha\Dasha.exe
exit