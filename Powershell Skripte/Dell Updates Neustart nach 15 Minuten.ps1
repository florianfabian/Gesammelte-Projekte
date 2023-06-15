# Lade die benötigte .NET Assembly für MessageBox
Add-Type -AssemblyName System.Windows.Forms

# Warte 15 Minuten, um die Updates zu ziehen
Start-Sleep -Seconds 900

# Nachricht für die MessageBox erstellen
$message = @"
Updates wurden installiert, und ein Neustart ist zwingend erforderlich.
Bitte speichern Sie alle offenen Arbeiten.
Möchten Sie jetzt neu starten? Wenn Sie auf 'Verschieben' klicken, wird der PC in 15 Minuten automatisch neu gestartet.
"@

# Nachricht in einer MessageBox anzeigen und Antwort speichern
$result = [System.Windows.Forms.MessageBox]::Show($message, "Neustart erforderlich", [System.Windows.Forms.MessageBoxButtons]::YesNo, [System.Windows.Forms.MessageBoxIcon]::Information, [System.Windows.Forms.MessageBoxDefaultButton]::Button1, [System.Windows.Forms.MessageBoxOptions]::DefaultDesktopOnly)

# Überprüfe das Ergebnis
if ($result -eq [System.Windows.Forms.DialogResult]::Yes) {
    # Neustart sofort
    Restart-Computer -Force
} else {
    # Verschiebe den Neustart um 15 Minuten
    Start-Sleep -Seconds 900
    # Neustart durchführen
    Restart-Computer -Force
}
