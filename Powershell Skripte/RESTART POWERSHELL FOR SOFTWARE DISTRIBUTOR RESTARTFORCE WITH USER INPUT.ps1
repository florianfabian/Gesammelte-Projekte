# Letzten Startzeitpunkt des Systems holen
$os = Get-WmiObject -Class Win32_OperatingSystem
$lastBootTime = $os.ConvertToDateTime($os.LastBootUpTime)

# Betriebszeit berechnen
$uptime = New-TimeSpan -Start $lastBootTime -End (Get-Date)

# Nachricht erstellen
$message = @"
Es ist nun $($uptime.Days) Tage, $($uptime.Hours) Stunden und $($uptime.Minutes) Minuten her, seit Ihr Computer das letzte Mal neu gestartet wurde.

Regelmäßige Neustarts sind wichtig für die Sicherheit und Leistung Ihres Computers. Wenn Sie Fragen haben, wenden Sie sich bitte an die IT-Abteilung.

Möchten Sie jetzt neu starten?
"@

# Lade die benötigte .NET Assembly für MessageBox
Add-Type -AssemblyName System.Windows.Forms

# Nachricht in einer MessageBox anzeigen und Antwort speichern
$result = [System.Windows.Forms.MessageBox]::Show($message, "Neustart erforderlich", [System.Windows.Forms.MessageBoxButtons]::YesNo, [System.Windows.Forms.MessageBoxIcon]::Information, [System.Windows.Forms.MessageBoxDefaultButton]::Button1, [System.Windows.Forms.MessageBoxOptions]::DefaultDesktopOnly)

# Überprüfe das Ergebnis und starte neu, wenn 'Yes' ausgewählt wurde
if ($result -eq [System.Windows.Forms.DialogResult]::Yes) {
    Restart-Computer -Force
}
