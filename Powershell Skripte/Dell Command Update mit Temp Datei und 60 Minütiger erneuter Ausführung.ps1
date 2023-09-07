# Pfad zum Dell Command Update-Programm
$dellCommandUpdatePath = "C:\Program Files\Dell\CommandUpdate\dcu-cli.exe"
# Pfad zur Flag-Datei
$flagFilePath = "C:\temp\flagfile.txt"

# Lade die benötigte .NET Assembly für MessageBox
Add-Type -AssemblyName System.Windows.Forms

# Überprüfen, ob das Dell Command Update-Programm existiert
if (Test-Path $dellCommandUpdatePath) {
    # Führe das Dell Command Update-Programm nur aus, wenn die Flag-Datei nicht existiert
    if (!(Test-Path $flagFilePath)) {
        & $dellCommandUpdatePath /ApplyUpdates
        Write-Host "Dell Command Update wurde ausgeführt" -ForegroundColor Green
        # Erstelle die Flag-Datei
        New-Item -ItemType File -Path $flagFilePath -Force
    }
    
    # Warte 15 Minuten, um die Updates zu ziehen
    # Start-Sleep -Seconds 900

    # Nachricht für die MessageBox erstellen
    $message = @"
Updates wurden installiert, und ein Neustart ist zwingend erforderlich.
Möchten Sie jetzt neu starten? Wenn Sie auf 'Verschieben' klicken, wird die Meldung in 60 Minuten erneut angezeigt.
"@

    # Nachricht in einer MessageBox anzeigen und Antwort speichern
    $result = [System.Windows.Forms.MessageBox]::Show($message, "Neustart erforderlich", [System.Windows.Forms.MessageBoxButtons]::YesNo, [System.Windows.Forms.MessageBoxIcon]::Information, [System.Windows.Forms.MessageBoxDefaultButton]::Button1, [System.Windows.Forms.MessageBoxOptions]::DefaultDesktopOnly)

    # Überprüfe das Ergebnis
    if ($result -eq [System.Windows.Forms.DialogResult]::Yes) {
        # Neustart sofort
        Restart-Computer -Force
    } else {
        # Verschiebe den Neustart um 60 Minuten
        Start-Sleep -Seconds 3600
        # Neustart durchführen
        Restart-Computer -Force
    }
} else {
    Write-Host "Dell Command Update ist nicht unter dem Pfad installiert" -ForegroundColor Red
}
