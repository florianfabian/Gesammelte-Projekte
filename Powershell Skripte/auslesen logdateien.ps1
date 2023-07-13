# Der Pfad zur Log-Datei
$logFile = "Pfad-zur-Log-Datei"

# Laden Sie die Log-Datei
$logContent = Get-Content $logFile

# Zählen Sie die Anzahl der Log-Einträge
$numberOfLogEntries = ($logContent | Measure-Object -Line).Lines

# Geben Sie die Anzahl der Log-Einträge für PRTG aus
write-Host "$($numberOfLogEntries):Log Entries"
