# Letzten Startzeitpunkt des Systems holen
$os = Get-WmiObject -Class Win32_OperatingSystem
$lastBootTime = $os.ConvertToDateTime($os.LastBootUpTime)

# Betriebszeit berechnen
$uptime = New-TimeSpan -Start $lastBootTime -End (Get-Date)

# Nachricht erstellen
$message = @"
Es ist nun $($uptime.Days) Tage, $($uptime.Hours) Stunden und $($uptime.Minutes) Minuten her, seit Ihr Computer das letzte Mal neu gestartet wurde.

Regelmäßige Neustarts sind wichtig für die Sicherheit und Leistung Ihres Computers. Wenn Sie Fragen haben, wenden Sie sich bitte an die IT-Abteilung.

Möchten Sie jetzt neu starten? (j/n)
"@

# Nachricht anzeigen und Benutzereingabe abfragen
$restart = Read-Host -Prompt $message

# Wenn die Benutzereingabe 'j' ist, Computer neu starten
if ($restart -eq 'j') {
    Restart-Computer -Confirm
}

