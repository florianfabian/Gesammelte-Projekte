# Pfad zum Dell Command Update-Programm
$dellCommandUpdatePath = "C:\Program Files\Dell\CommandUpdate\dcu-cli.exe"

# Überprüfen, ob das Dell Command Update-Programm existiert
if (Test-Path $dellCommandUpdatePath) {
    # Führe das Dell Command Update-Programm aus
    & $dellCommandUpdatePath /ApplyUpdates
    Write-Host "Dell Command Update wurde ausgeführt" -ForegroundColor Green
} else {
    Write-Host "Dell Command Update ist nicht unter dem Pfad installiert" -ForegroundColor Red
}
